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
        let v17 : string = v13 + v9 
        let v20 : int32 = v5 + 1
        let v21 : string = "\n"
        v3.l0 <- v20
        v3.l1 <- v17
        v3.l2 <- v21
        ()
    let struct (v22 : string, v23 : string) = v3.l1, v3.l2
    v22
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
    let v90 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v91 : string = "String::from($0)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr v77 v91 
    let _run_target_args'_v90 = v92 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v93 : string = "String::from($0)"
    let v94 : std_string_String = Fable.Core.RustInterop.emitRustExpr v77 v93 
    let _run_target_args'_v90 = v94 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v95 : string = "String::from($0)"
    let v96 : std_string_String = Fable.Core.RustInterop.emitRustExpr v77 v95 
    let _run_target_args'_v90 = v96 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v98 : std_string_String = v77 |> unbox<std_string_String>
    let _run_target_args'_v90 = v98 
    #endif
#if FABLE_COMPILER_PYTHON
    let v102 : std_string_String = v77 |> unbox<std_string_String>
    let _run_target_args'_v90 = v102 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v106 : std_string_String = v77 |> unbox<std_string_String>
    let _run_target_args'_v90 = v106 
    #endif
#else
    let v110 : std_string_String = v77 |> unbox<std_string_String>
    let _run_target_args'_v90 = v110 
    #endif
    let v113 : std_string_String = _run_target_args'_v90 
    let v122 : string = "std::ffi::CString::new($0).unwrap()"
    let v123 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v113 v122 
    let v124 : string = ""
    (* run_target_args'
    let v129 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v130 : string = "&*$0"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v124 v130 
    let _run_target_args'_v129 = v131 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v132 : string = "&*$0"
    let v133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v124 v132 
    let _run_target_args'_v129 = v133 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v134 : string = "&*$0"
    let v135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v124 v134 
    let _run_target_args'_v129 = v135 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v137 : Ref<Str> = v124 |> unbox<Ref<Str>>
    let _run_target_args'_v129 = v137 
    #endif
#if FABLE_COMPILER_PYTHON
    let v141 : Ref<Str> = v124 |> unbox<Ref<Str>>
    let _run_target_args'_v129 = v141 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v145 : Ref<Str> = v124 |> unbox<Ref<Str>>
    let _run_target_args'_v129 = v145 
    #endif
#else
    let v149 : Ref<Str> = v124 |> unbox<Ref<Str>>
    let _run_target_args'_v129 = v149 
    #endif
    let v152 : Ref<Str> = _run_target_args'_v129 
    (* run_target_args'
    let v165 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v166 : string = "String::from($0)"
    let v167 : std_string_String = Fable.Core.RustInterop.emitRustExpr v152 v166 
    let _run_target_args'_v165 = v167 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v168 : string = "String::from($0)"
    let v169 : std_string_String = Fable.Core.RustInterop.emitRustExpr v152 v168 
    let _run_target_args'_v165 = v169 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v170 : string = "String::from($0)"
    let v171 : std_string_String = Fable.Core.RustInterop.emitRustExpr v152 v170 
    let _run_target_args'_v165 = v171 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v173 : std_string_String = v152 |> unbox<std_string_String>
    let _run_target_args'_v165 = v173 
    #endif
#if FABLE_COMPILER_PYTHON
    let v177 : std_string_String = v152 |> unbox<std_string_String>
    let _run_target_args'_v165 = v177 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v181 : std_string_String = v152 |> unbox<std_string_String>
    let _run_target_args'_v165 = v181 
    #endif
#else
    let v185 : std_string_String = v152 |> unbox<std_string_String>
    let _run_target_args'_v165 = v185 
    #endif
    let v188 : std_string_String = _run_target_args'_v165 
    let v197 : string = "std::ffi::CString::new($0).unwrap()"
    let v198 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v188 v197 
    let v199 : string = "pyo3::types::PyModule::from_code(v49, &$0, &v198, &v198)"
    let v200 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v123 v199 
    let v201 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v202 : bool = Fable.Core.RustInterop.emitRustExpr v200 v201 
    let v203 : string = "x"
    let v204 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v203 
    (* run_target_args'
    let v209 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v210 : string = "format!(\"{}\", $0)"
    let v211 : std_string_String = Fable.Core.RustInterop.emitRustExpr v204 v210 
    let _run_target_args'_v209 = v211 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v212 : string = "format!(\"{}\", $0)"
    let v213 : std_string_String = Fable.Core.RustInterop.emitRustExpr v204 v212 
    let _run_target_args'_v209 = v213 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v214 : string = "format!(\"{}\", $0)"
    let v215 : std_string_String = Fable.Core.RustInterop.emitRustExpr v204 v214 
    let _run_target_args'_v209 = v215 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v217 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v209 = v217 
    #endif
#if FABLE_COMPILER_PYTHON
    let v221 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v209 = v221 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v225 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v209 = v225 
    #endif
#else
    let v229 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v209 = v229 
    #endif
    let v232 : std_string_String = _run_target_args'_v209 
    let v241 : string = "true; $0 })"
    let v242 : bool = Fable.Core.RustInterop.emitRustExpr v232 v241 
    let v243 : string = "_result_map_error__"
    let v244 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v243 
    (* run_target_args'
    let v246 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v247 : string = "$0.unwrap()"
    let v248 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v244 v247 
    let _run_target_args'_v246 = v248 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v249 : string = "$0.unwrap()"
    let v250 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v244 v249 
    let _run_target_args'_v246 = v250 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v251 : string = "$0.unwrap()"
    let v252 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v244 v251 
    let _run_target_args'_v246 = v252 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v253 : pyo3_Bound<pyo3_types_PyModule> = match v244 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v246 = v253 
    #endif
#if FABLE_COMPILER_PYTHON
    let v254 : pyo3_Bound<pyo3_types_PyModule> = match v244 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v246 = v254 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v255 : pyo3_Bound<pyo3_types_PyModule> = match v244 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v246 = v255 
    #endif
#else
    let v256 : pyo3_Bound<pyo3_types_PyModule> = match v244 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v246 = v256 
    #endif
    let v257 : pyo3_Bound<pyo3_types_PyModule> = _run_target_args'_v246 
    let v260 : string = method8()
    (* run_target_args'
    let v265 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v266 : string = "&*$0"
    let v267 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v260 v266 
    let _run_target_args'_v265 = v267 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v268 : string = "&*$0"
    let v269 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v260 v268 
    let _run_target_args'_v265 = v269 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v270 : string = "&*$0"
    let v271 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v260 v270 
    let _run_target_args'_v265 = v271 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v273 : Ref<Str> = v260 |> unbox<Ref<Str>>
    let _run_target_args'_v265 = v273 
    #endif
#if FABLE_COMPILER_PYTHON
    let v277 : Ref<Str> = v260 |> unbox<Ref<Str>>
    let _run_target_args'_v265 = v277 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v281 : Ref<Str> = v260 |> unbox<Ref<Str>>
    let _run_target_args'_v265 = v281 
    #endif
#else
    let v285 : Ref<Str> = v260 |> unbox<Ref<Str>>
    let _run_target_args'_v265 = v285 
    #endif
    let v288 : Ref<Str> = _run_target_args'_v265 
    let v297 : pyo3_Bound<pyo3_types_PyModule> = method9(v257)
    let v298 : string = "v297.getattr($0)"
    let v299 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v288 v298 
    let v300 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v301 : bool = Fable.Core.RustInterop.emitRustExpr v299 v300 
    let v302 : string = "x"
    let v303 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v302 
    (* run_target_args'
    let v308 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v309 : string = "format!(\"{}\", $0)"
    let v310 : std_string_String = Fable.Core.RustInterop.emitRustExpr v303 v309 
    let _run_target_args'_v308 = v310 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v311 : string = "format!(\"{}\", $0)"
    let v312 : std_string_String = Fable.Core.RustInterop.emitRustExpr v303 v311 
    let _run_target_args'_v308 = v312 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v313 : string = "format!(\"{}\", $0)"
    let v314 : std_string_String = Fable.Core.RustInterop.emitRustExpr v303 v313 
    let _run_target_args'_v308 = v314 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v316 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v308 = v316 
    #endif
#if FABLE_COMPILER_PYTHON
    let v320 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v308 = v320 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v324 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v308 = v324 
    #endif
#else
    let v328 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v308 = v328 
    #endif
    let v331 : std_string_String = _run_target_args'_v308 
    let v340 : string = "true; $0 })"
    let v341 : bool = Fable.Core.RustInterop.emitRustExpr v331 v340 
    let v342 : string = "_result_map_error__"
    let v343 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v342 
    (* run_target_args'
    let v345 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v346 : string = "$0.unwrap()"
    let v347 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v343 v346 
    let _run_target_args'_v345 = v347 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v348 : string = "$0.unwrap()"
    let v349 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v343 v348 
    let _run_target_args'_v345 = v349 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v350 : string = "$0.unwrap()"
    let v351 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v343 v350 
    let _run_target_args'_v345 = v351 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v352 : pyo3_Bound<pyo3_PyAny> = match v343 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v345 = v352 
    #endif
#if FABLE_COMPILER_PYTHON
    let v353 : pyo3_Bound<pyo3_PyAny> = match v343 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v345 = v353 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v354 : pyo3_Bound<pyo3_PyAny> = match v343 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v345 = v354 
    #endif
#else
    let v355 : pyo3_Bound<pyo3_PyAny> = match v343 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v345 = v355 
    #endif
    let v356 : pyo3_Bound<pyo3_PyAny> = _run_target_args'_v345 
    let v359 : (bool * (float * float)) = method10(v46)
    let v360 : pyo3_Bound<pyo3_PyAny> = method11(v356)
    let v361 : string = "pyo3::prelude::PyAnyMethods::call(&v360, ((*v359).0, *(*v359).1), None)"
    let v362 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v361 
    let v363 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v364 : bool = Fable.Core.RustInterop.emitRustExpr v362 v363 
    let v365 : string = "x"
    let v366 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v365 
    (* run_target_args'
    let v371 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v372 : string = "format!(\"{}\", $0)"
    let v373 : std_string_String = Fable.Core.RustInterop.emitRustExpr v366 v372 
    let _run_target_args'_v371 = v373 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v374 : string = "format!(\"{}\", $0)"
    let v375 : std_string_String = Fable.Core.RustInterop.emitRustExpr v366 v374 
    let _run_target_args'_v371 = v375 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v376 : string = "format!(\"{}\", $0)"
    let v377 : std_string_String = Fable.Core.RustInterop.emitRustExpr v366 v376 
    let _run_target_args'_v371 = v377 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v379 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v371 = v379 
    #endif
#if FABLE_COMPILER_PYTHON
    let v383 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v371 = v383 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v387 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v371 = v387 
    #endif
#else
    let v391 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v371 = v391 
    #endif
    let v394 : std_string_String = _run_target_args'_v371 
    let v403 : string = "true; $0 })"
    let v404 : bool = Fable.Core.RustInterop.emitRustExpr v394 v403 
    let v405 : string = "_result_map_error__"
    let v406 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v405 
    let v407 : string = "$0?"
    let v408 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v406 v407 
    let v409 : pyo3_Bound<pyo3_PyAny> = method12(v408)
    let v410 : string = "v409.extract()"
    let v411 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v410 
    let v412 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v413 : bool = Fable.Core.RustInterop.emitRustExpr v411 v412 
    let v414 : string = "x"
    let v415 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v414 
    (* run_target_args'
    let v420 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v421 : string = "format!(\"{}\", $0)"
    let v422 : std_string_String = Fable.Core.RustInterop.emitRustExpr v415 v421 
    let _run_target_args'_v420 = v422 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v423 : string = "format!(\"{}\", $0)"
    let v424 : std_string_String = Fable.Core.RustInterop.emitRustExpr v415 v423 
    let _run_target_args'_v420 = v424 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v425 : string = "format!(\"{}\", $0)"
    let v426 : std_string_String = Fable.Core.RustInterop.emitRustExpr v415 v425 
    let _run_target_args'_v420 = v426 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v428 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v420 = v428 
    #endif
#if FABLE_COMPILER_PYTHON
    let v432 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v420 = v432 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v436 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v420 = v436 
    #endif
#else
    let v440 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v420 = v440 
    #endif
    let v443 : std_string_String = _run_target_args'_v420 
    let v452 : string = "true; $0 })"
    let v453 : bool = Fable.Core.RustInterop.emitRustExpr v443 v452 
    let v454 : string = "_result_map_error__"
    let v455 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v454 
    let v456 : string = "$0?"
    let struct (v457 : float, v458 : float) = Fable.Core.RustInterop.emitRustExpr v455 v456 
    let v459 : string = "num_complex::Complex::new($0, $1)"
    let v460 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v457, v458) v459 
    let v462 : Result<num_complex_Complex<float>, std_string_String> = Ok v460 
    v462
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
    let v90 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v91 : string = "String::from($0)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr v77 v91 
    let _run_target_args'_v90 = v92 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v93 : string = "String::from($0)"
    let v94 : std_string_String = Fable.Core.RustInterop.emitRustExpr v77 v93 
    let _run_target_args'_v90 = v94 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v95 : string = "String::from($0)"
    let v96 : std_string_String = Fable.Core.RustInterop.emitRustExpr v77 v95 
    let _run_target_args'_v90 = v96 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v98 : std_string_String = v77 |> unbox<std_string_String>
    let _run_target_args'_v90 = v98 
    #endif
#if FABLE_COMPILER_PYTHON
    let v102 : std_string_String = v77 |> unbox<std_string_String>
    let _run_target_args'_v90 = v102 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v106 : std_string_String = v77 |> unbox<std_string_String>
    let _run_target_args'_v90 = v106 
    #endif
#else
    let v110 : std_string_String = v77 |> unbox<std_string_String>
    let _run_target_args'_v90 = v110 
    #endif
    let v113 : std_string_String = _run_target_args'_v90 
    let v122 : string = "std::ffi::CString::new($0).unwrap()"
    let v123 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v113 v122 
    let v124 : string = ""
    (* run_target_args'
    let v129 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v130 : string = "&*$0"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v124 v130 
    let _run_target_args'_v129 = v131 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v132 : string = "&*$0"
    let v133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v124 v132 
    let _run_target_args'_v129 = v133 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v134 : string = "&*$0"
    let v135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v124 v134 
    let _run_target_args'_v129 = v135 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v137 : Ref<Str> = v124 |> unbox<Ref<Str>>
    let _run_target_args'_v129 = v137 
    #endif
#if FABLE_COMPILER_PYTHON
    let v141 : Ref<Str> = v124 |> unbox<Ref<Str>>
    let _run_target_args'_v129 = v141 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v145 : Ref<Str> = v124 |> unbox<Ref<Str>>
    let _run_target_args'_v129 = v145 
    #endif
#else
    let v149 : Ref<Str> = v124 |> unbox<Ref<Str>>
    let _run_target_args'_v129 = v149 
    #endif
    let v152 : Ref<Str> = _run_target_args'_v129 
    (* run_target_args'
    let v165 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v166 : string = "String::from($0)"
    let v167 : std_string_String = Fable.Core.RustInterop.emitRustExpr v152 v166 
    let _run_target_args'_v165 = v167 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v168 : string = "String::from($0)"
    let v169 : std_string_String = Fable.Core.RustInterop.emitRustExpr v152 v168 
    let _run_target_args'_v165 = v169 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v170 : string = "String::from($0)"
    let v171 : std_string_String = Fable.Core.RustInterop.emitRustExpr v152 v170 
    let _run_target_args'_v165 = v171 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v173 : std_string_String = v152 |> unbox<std_string_String>
    let _run_target_args'_v165 = v173 
    #endif
#if FABLE_COMPILER_PYTHON
    let v177 : std_string_String = v152 |> unbox<std_string_String>
    let _run_target_args'_v165 = v177 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v181 : std_string_String = v152 |> unbox<std_string_String>
    let _run_target_args'_v165 = v181 
    #endif
#else
    let v185 : std_string_String = v152 |> unbox<std_string_String>
    let _run_target_args'_v165 = v185 
    #endif
    let v188 : std_string_String = _run_target_args'_v165 
    let v197 : string = "std::ffi::CString::new($0).unwrap()"
    let v198 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v188 v197 
    let v199 : string = "pyo3::types::PyModule::from_code(v49, &$0, &v198, &v198)"
    let v200 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v123 v199 
    let v201 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v202 : bool = Fable.Core.RustInterop.emitRustExpr v200 v201 
    let v203 : string = "x"
    let v204 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v203 
    (* run_target_args'
    let v209 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v210 : string = "format!(\"{}\", $0)"
    let v211 : std_string_String = Fable.Core.RustInterop.emitRustExpr v204 v210 
    let _run_target_args'_v209 = v211 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v212 : string = "format!(\"{}\", $0)"
    let v213 : std_string_String = Fable.Core.RustInterop.emitRustExpr v204 v212 
    let _run_target_args'_v209 = v213 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v214 : string = "format!(\"{}\", $0)"
    let v215 : std_string_String = Fable.Core.RustInterop.emitRustExpr v204 v214 
    let _run_target_args'_v209 = v215 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v217 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v209 = v217 
    #endif
#if FABLE_COMPILER_PYTHON
    let v221 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v209 = v221 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v225 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v209 = v225 
    #endif
#else
    let v229 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v209 = v229 
    #endif
    let v232 : std_string_String = _run_target_args'_v209 
    let v241 : string = "true; $0 })"
    let v242 : bool = Fable.Core.RustInterop.emitRustExpr v232 v241 
    let v243 : string = "_result_map_error__"
    let v244 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v243 
    (* run_target_args'
    let v246 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v247 : string = "$0.unwrap()"
    let v248 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v244 v247 
    let _run_target_args'_v246 = v248 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v249 : string = "$0.unwrap()"
    let v250 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v244 v249 
    let _run_target_args'_v246 = v250 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v251 : string = "$0.unwrap()"
    let v252 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v244 v251 
    let _run_target_args'_v246 = v252 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v253 : pyo3_Bound<pyo3_types_PyModule> = match v244 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v246 = v253 
    #endif
#if FABLE_COMPILER_PYTHON
    let v254 : pyo3_Bound<pyo3_types_PyModule> = match v244 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v246 = v254 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v255 : pyo3_Bound<pyo3_types_PyModule> = match v244 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v246 = v255 
    #endif
#else
    let v256 : pyo3_Bound<pyo3_types_PyModule> = match v244 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v246 = v256 
    #endif
    let v257 : pyo3_Bound<pyo3_types_PyModule> = _run_target_args'_v246 
    let v260 : string = method8()
    (* run_target_args'
    let v265 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v266 : string = "&*$0"
    let v267 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v260 v266 
    let _run_target_args'_v265 = v267 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v268 : string = "&*$0"
    let v269 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v260 v268 
    let _run_target_args'_v265 = v269 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v270 : string = "&*$0"
    let v271 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v260 v270 
    let _run_target_args'_v265 = v271 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v273 : Ref<Str> = v260 |> unbox<Ref<Str>>
    let _run_target_args'_v265 = v273 
    #endif
#if FABLE_COMPILER_PYTHON
    let v277 : Ref<Str> = v260 |> unbox<Ref<Str>>
    let _run_target_args'_v265 = v277 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v281 : Ref<Str> = v260 |> unbox<Ref<Str>>
    let _run_target_args'_v265 = v281 
    #endif
#else
    let v285 : Ref<Str> = v260 |> unbox<Ref<Str>>
    let _run_target_args'_v265 = v285 
    #endif
    let v288 : Ref<Str> = _run_target_args'_v265 
    let v297 : pyo3_Bound<pyo3_types_PyModule> = method9(v257)
    let v298 : string = "v297.getattr($0)"
    let v299 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v288 v298 
    let v300 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v301 : bool = Fable.Core.RustInterop.emitRustExpr v299 v300 
    let v302 : string = "x"
    let v303 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v302 
    (* run_target_args'
    let v308 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v309 : string = "format!(\"{}\", $0)"
    let v310 : std_string_String = Fable.Core.RustInterop.emitRustExpr v303 v309 
    let _run_target_args'_v308 = v310 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v311 : string = "format!(\"{}\", $0)"
    let v312 : std_string_String = Fable.Core.RustInterop.emitRustExpr v303 v311 
    let _run_target_args'_v308 = v312 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v313 : string = "format!(\"{}\", $0)"
    let v314 : std_string_String = Fable.Core.RustInterop.emitRustExpr v303 v313 
    let _run_target_args'_v308 = v314 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v316 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v308 = v316 
    #endif
#if FABLE_COMPILER_PYTHON
    let v320 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v308 = v320 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v324 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v308 = v324 
    #endif
#else
    let v328 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v308 = v328 
    #endif
    let v331 : std_string_String = _run_target_args'_v308 
    let v340 : string = "true; $0 })"
    let v341 : bool = Fable.Core.RustInterop.emitRustExpr v331 v340 
    let v342 : string = "_result_map_error__"
    let v343 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v342 
    (* run_target_args'
    let v345 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v346 : string = "$0.unwrap()"
    let v347 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v343 v346 
    let _run_target_args'_v345 = v347 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v348 : string = "$0.unwrap()"
    let v349 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v343 v348 
    let _run_target_args'_v345 = v349 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v350 : string = "$0.unwrap()"
    let v351 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v343 v350 
    let _run_target_args'_v345 = v351 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v352 : pyo3_Bound<pyo3_PyAny> = match v343 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v345 = v352 
    #endif
#if FABLE_COMPILER_PYTHON
    let v353 : pyo3_Bound<pyo3_PyAny> = match v343 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v345 = v353 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v354 : pyo3_Bound<pyo3_PyAny> = match v343 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v345 = v354 
    #endif
#else
    let v355 : pyo3_Bound<pyo3_PyAny> = match v343 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v345 = v355 
    #endif
    let v356 : pyo3_Bound<pyo3_PyAny> = _run_target_args'_v345 
    let v359 : (bool * (float * float)) = method10(v46)
    let v360 : pyo3_Bound<pyo3_PyAny> = method11(v356)
    let v361 : string = "pyo3::prelude::PyAnyMethods::call(&v360, ((*v359).0, *(*v359).1), None)"
    let v362 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v361 
    let v363 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v364 : bool = Fable.Core.RustInterop.emitRustExpr v362 v363 
    let v365 : string = "x"
    let v366 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v365 
    (* run_target_args'
    let v371 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v372 : string = "format!(\"{}\", $0)"
    let v373 : std_string_String = Fable.Core.RustInterop.emitRustExpr v366 v372 
    let _run_target_args'_v371 = v373 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v374 : string = "format!(\"{}\", $0)"
    let v375 : std_string_String = Fable.Core.RustInterop.emitRustExpr v366 v374 
    let _run_target_args'_v371 = v375 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v376 : string = "format!(\"{}\", $0)"
    let v377 : std_string_String = Fable.Core.RustInterop.emitRustExpr v366 v376 
    let _run_target_args'_v371 = v377 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v379 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v371 = v379 
    #endif
#if FABLE_COMPILER_PYTHON
    let v383 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v371 = v383 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v387 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v371 = v387 
    #endif
#else
    let v391 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v371 = v391 
    #endif
    let v394 : std_string_String = _run_target_args'_v371 
    let v403 : string = "true; $0 })"
    let v404 : bool = Fable.Core.RustInterop.emitRustExpr v394 v403 
    let v405 : string = "_result_map_error__"
    let v406 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v405 
    let v407 : string = "$0?"
    let v408 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v406 v407 
    let v409 : pyo3_Bound<pyo3_PyAny> = method12(v408)
    let v410 : string = "v409.extract()"
    let v411 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v410 
    let v412 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v413 : bool = Fable.Core.RustInterop.emitRustExpr v411 v412 
    let v414 : string = "x"
    let v415 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v414 
    (* run_target_args'
    let v420 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v421 : string = "format!(\"{}\", $0)"
    let v422 : std_string_String = Fable.Core.RustInterop.emitRustExpr v415 v421 
    let _run_target_args'_v420 = v422 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v423 : string = "format!(\"{}\", $0)"
    let v424 : std_string_String = Fable.Core.RustInterop.emitRustExpr v415 v423 
    let _run_target_args'_v420 = v424 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v425 : string = "format!(\"{}\", $0)"
    let v426 : std_string_String = Fable.Core.RustInterop.emitRustExpr v415 v425 
    let _run_target_args'_v420 = v426 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v428 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v420 = v428 
    #endif
#if FABLE_COMPILER_PYTHON
    let v432 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v420 = v432 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v436 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v420 = v436 
    #endif
#else
    let v440 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v420 = v440 
    #endif
    let v443 : std_string_String = _run_target_args'_v420 
    let v452 : string = "true; $0 })"
    let v453 : bool = Fable.Core.RustInterop.emitRustExpr v443 v452 
    let v454 : string = "_result_map_error__"
    let v455 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v454 
    let v456 : string = "$0?"
    let struct (v457 : float, v458 : float) = Fable.Core.RustInterop.emitRustExpr v455 v456 
    let v459 : string = "num_complex::Complex::new($0, $1)"
    let v460 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v457, v458) v459 
    let v462 : Result<num_complex_Complex<float>, std_string_String> = Ok v460 
    v462
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
        let v81 : US0 = US0_1
        let v82 : US0 = v61 |> Option.defaultValue v81 
        let v86 : string = "f64::NAN"
        let v87 : float = Fable.Core.RustInterop.emitRustExpr () v86 
        let v88 : string = "f64::NAN"
        let v89 : float = Fable.Core.RustInterop.emitRustExpr () v88 
        let v90 : string = "num_complex::Complex::new($0, $1)"
        let v91 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v87, v89) v90 
        let v94 : num_complex_Complex<float> =
            match v82 with
            | US0_1 -> (* None *)
                v91
            | US0_0(v92) -> (* Some *)
                v92
        let v95 : string = "num_complex::Complex::new($0, $1)"
        let v96 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v95 
        let v97 : string = "$0 * $1"
        let v98 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v96, v1) v97 
        let v99 : string = "num_complex::Complex::new($0, $1)"
        let v100 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v99 
        let v101 : string = "$0 / $1"
        let v102 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v98, v100) v101 
        let v103 : string = "$0.sin()"
        let v104 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v102 v103 
        let v105 : string = "$0.re"
        let v106 : float = Fable.Core.RustInterop.emitRustExpr v1 v105 
        let v107 : float = 1.0 - v106
        let v108 : string = "$0.im"
        let v109 : float = Fable.Core.RustInterop.emitRustExpr v1 v108 
        let v110 : float =  -v109
        let v111 : string = "num_complex::Complex::new($0, $1)"
        let v112 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v107, v110) v111 
        let v113 : string = "$0.re"
        let v114 : float = Fable.Core.RustInterop.emitRustExpr v112 v113 
        let v115 : bool = v114 <= 1.0
        let v646 : num_complex_Complex<float> =
            if v115 then
                let v116 : string = "num_complex::Complex::new($0, $1)"
                let v117 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v116 
                v117
            else
                let v118 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                Fable.Core.RustInterop.emitRustExpr struct (1, v112) v118 
                let v119 : string = "$0.re"
                let v120 : float = Fable.Core.RustInterop.emitRustExpr v112 v119 
                let v121 : bool = v120 > 1.0
                if v121 then
                    let v122 : string = "num_complex::Complex::new($0, $1)"
                    let v123 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v122 
                    let v124 : (int32 []) = Array.zeroCreate<int32> (10000)
                    let v125 : Mut0 = {l0 = 0} : Mut0
                    while method14(v125) do
                        let v127 : int32 = v125.l0
                        v124.[int v127] <- v127
                        let v128 : int32 = v127 + 1
                        v125.l0 <- v128
                        ()
                    let v129 : int32 = v124.Length
                    let v130 : Mut2 = {l0 = 0; l1 = v123} : Mut2
                    while method15(v129, v130) do
                        let v132 : int32 = v130.l0
                        let v133 : num_complex_Complex<float> = v130.l1
                        let v134 : int32 = v124.[int v132]
                        let v135 : string = "num_complex::Complex::new($0, $1)"
                        let v136 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v135 
                        let v138 : (int32 -> float) = float
                        let v139 : float = v138 v134
                        let v142 : string = "num_complex::Complex::new($0, $1)"
                        let v143 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v139, 0.0) v142 
                        let v144 : string = "num_complex::Complex::powc($0, $1)"
                        let v145 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v143, v112) v144 
                        let v146 : string = "$0 / $1"
                        let v147 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v136, v145) v146 
                        let v148 : string = "$0 + $1"
                        let v149 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v133, v147) v148 
                        let v150 : int32 = v132 + 1
                        v130.l0 <- v150
                        v130.l1 <- v149
                        ()
                    let v151 : num_complex_Complex<float> = v130.l1
                    v151
                else
                    let v152 : string = "num_complex::Complex::new($0, $1)"
                    let v153 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v152 
                    let v154 : string = "$0 - $1"
                    let v155 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v153, v112) v154 
                    let v156 : string = $"        s = mpmath.gamma(s)"
                    let v157 : num_complex_Complex<float> = method3(v155)
                    let v158 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v156, v157)
                    (* run_target_args'
                    let v160 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v161 : string = "$0.ok()"
                    let v162 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v158 v161 
                    let _run_target_args'_v160 = v162 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v163 : string = "$0.ok()"
                    let v164 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v158 v163 
                    let _run_target_args'_v160 = v164 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v165 : string = "$0.ok()"
                    let v166 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v158 v165 
                    let _run_target_args'_v160 = v166 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v167 : num_complex_Complex<float> option = match v158 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v160 = v167 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v168 : num_complex_Complex<float> option = match v158 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v160 = v168 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v169 : num_complex_Complex<float> option = match v158 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v160 = v169 
                    #endif
#else
                    let v170 : num_complex_Complex<float> option = match v158 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v160 = v170 
                    #endif
                    let v171 : num_complex_Complex<float> option = _run_target_args'_v160 
                    let v176 : (num_complex_Complex<float> -> US0) = method17()
                    let v177 : US0 option = v171 |> Option.map v176 
                    let v197 : US0 = US0_1
                    let v198 : US0 = v177 |> Option.defaultValue v197 
                    let v202 : string = "f64::NAN"
                    let v203 : float = Fable.Core.RustInterop.emitRustExpr () v202 
                    let v204 : string = "f64::NAN"
                    let v205 : float = Fable.Core.RustInterop.emitRustExpr () v204 
                    let v206 : string = "num_complex::Complex::new($0, $1)"
                    let v207 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v203, v205) v206 
                    let v210 : num_complex_Complex<float> =
                        match v198 with
                        | US0_1 -> (* None *)
                            v207
                        | US0_0(v208) -> (* Some *)
                            v208
                    let v211 : string = "num_complex::Complex::new($0, $1)"
                    let v212 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v211 
                    let v213 : string = "$0 * $1"
                    let v214 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v212, v112) v213 
                    let v215 : string = "num_complex::Complex::new($0, $1)"
                    let v216 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v215 
                    let v217 : string = "$0 / $1"
                    let v218 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v214, v216) v217 
                    let v219 : string = "$0.sin()"
                    let v220 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v218 v219 
                    let v221 : string = "$0.re"
                    let v222 : float = Fable.Core.RustInterop.emitRustExpr v112 v221 
                    let v223 : float = 1.0 - v222
                    let v224 : string = "$0.im"
                    let v225 : float = Fable.Core.RustInterop.emitRustExpr v112 v224 
                    let v226 : float =  -v225
                    let v227 : string = "num_complex::Complex::new($0, $1)"
                    let v228 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v223, v226) v227 
                    let v229 : string = "$0.re"
                    let v230 : float = Fable.Core.RustInterop.emitRustExpr v228 v229 
                    let v231 : bool = v230 <= 1.0
                    let v630 : num_complex_Complex<float> =
                        if v231 then
                            let v232 : string = "num_complex::Complex::new($0, $1)"
                            let v233 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v232 
                            v233
                        else
                            let v234 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                            Fable.Core.RustInterop.emitRustExpr struct (2, v228) v234 
                            let v235 : string = "$0.re"
                            let v236 : float = Fable.Core.RustInterop.emitRustExpr v228 v235 
                            let v237 : bool = v236 > 1.0
                            if v237 then
                                let v238 : string = "num_complex::Complex::new($0, $1)"
                                let v239 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v238 
                                let v240 : (int32 []) = Array.zeroCreate<int32> (10000)
                                let v241 : Mut0 = {l0 = 0} : Mut0
                                while method14(v241) do
                                    let v243 : int32 = v241.l0
                                    v240.[int v243] <- v243
                                    let v244 : int32 = v243 + 1
                                    v241.l0 <- v244
                                    ()
                                let v245 : int32 = v240.Length
                                let v246 : Mut2 = {l0 = 0; l1 = v239} : Mut2
                                while method15(v245, v246) do
                                    let v248 : int32 = v246.l0
                                    let v249 : num_complex_Complex<float> = v246.l1
                                    let v250 : int32 = v240.[int v248]
                                    let v251 : string = "num_complex::Complex::new($0, $1)"
                                    let v252 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v251 
                                    let v254 : (int32 -> float) = float
                                    let v255 : float = v254 v250
                                    let v258 : string = "num_complex::Complex::new($0, $1)"
                                    let v259 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v255, 0.0) v258 
                                    let v260 : string = "num_complex::Complex::powc($0, $1)"
                                    let v261 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v259, v228) v260 
                                    let v262 : string = "$0 / $1"
                                    let v263 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v252, v261) v262 
                                    let v264 : string = "$0 + $1"
                                    let v265 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v249, v263) v264 
                                    let v266 : int32 = v248 + 1
                                    v246.l0 <- v266
                                    v246.l1 <- v265
                                    ()
                                let v267 : num_complex_Complex<float> = v246.l1
                                v267
                            else
                                let v268 : string = "num_complex::Complex::new($0, $1)"
                                let v269 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v268 
                                let v270 : string = "$0 - $1"
                                let v271 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v269, v228) v270 
                                let v272 : string = $"        s = mpmath.gamma(s)"
                                let v273 : num_complex_Complex<float> = method3(v271)
                                let v274 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v272, v273)
                                (* run_target_args'
                                let v276 : unit = ()
                                run_target_args' *)
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v277 : string = "$0.ok()"
                                let v278 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v274 v277 
                                let _run_target_args'_v276 = v278 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v279 : string = "$0.ok()"
                                let v280 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v274 v279 
                                let _run_target_args'_v276 = v280 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v281 : string = "$0.ok()"
                                let v282 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v274 v281 
                                let _run_target_args'_v276 = v282 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v283 : num_complex_Complex<float> option = match v274 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v276 = v283 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v284 : num_complex_Complex<float> option = match v274 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v276 = v284 
                                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                                let v285 : num_complex_Complex<float> option = match v274 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v276 = v285 
                                #endif
#else
                                let v286 : num_complex_Complex<float> option = match v274 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v276 = v286 
                                #endif
                                let v287 : num_complex_Complex<float> option = _run_target_args'_v276 
                                let v292 : (num_complex_Complex<float> -> US0) = method17()
                                let v293 : US0 option = v287 |> Option.map v292 
                                let v313 : US0 = US0_1
                                let v314 : US0 = v293 |> Option.defaultValue v313 
                                let v318 : string = "f64::NAN"
                                let v319 : float = Fable.Core.RustInterop.emitRustExpr () v318 
                                let v320 : string = "f64::NAN"
                                let v321 : float = Fable.Core.RustInterop.emitRustExpr () v320 
                                let v322 : string = "num_complex::Complex::new($0, $1)"
                                let v323 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v319, v321) v322 
                                let v326 : num_complex_Complex<float> =
                                    match v314 with
                                    | US0_1 -> (* None *)
                                        v323
                                    | US0_0(v324) -> (* Some *)
                                        v324
                                let v327 : string = "num_complex::Complex::new($0, $1)"
                                let v328 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v327 
                                let v329 : string = "$0 * $1"
                                let v330 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v328, v228) v329 
                                let v331 : string = "num_complex::Complex::new($0, $1)"
                                let v332 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v331 
                                let v333 : string = "$0 / $1"
                                let v334 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v330, v332) v333 
                                let v335 : string = "$0.sin()"
                                let v336 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v334 v335 
                                let v337 : string = "$0.re"
                                let v338 : float = Fable.Core.RustInterop.emitRustExpr v228 v337 
                                let v339 : float = 1.0 - v338
                                let v340 : string = "$0.im"
                                let v341 : float = Fable.Core.RustInterop.emitRustExpr v228 v340 
                                let v342 : float =  -v341
                                let v343 : string = "num_complex::Complex::new($0, $1)"
                                let v344 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v339, v342) v343 
                                let v345 : string = "$0.re"
                                let v346 : float = Fable.Core.RustInterop.emitRustExpr v344 v345 
                                let v347 : bool = v346 <= 1.0
                                let v614 : num_complex_Complex<float> =
                                    if v347 then
                                        let v348 : string = "num_complex::Complex::new($0, $1)"
                                        let v349 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v348 
                                        v349
                                    else
                                        let v350 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                        Fable.Core.RustInterop.emitRustExpr struct (3, v344) v350 
                                        let v351 : string = "$0.re"
                                        let v352 : float = Fable.Core.RustInterop.emitRustExpr v344 v351 
                                        let v353 : bool = v352 > 1.0
                                        if v353 then
                                            let v354 : string = "num_complex::Complex::new($0, $1)"
                                            let v355 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v354 
                                            let v356 : (int32 []) = Array.zeroCreate<int32> (10000)
                                            let v357 : Mut0 = {l0 = 0} : Mut0
                                            while method14(v357) do
                                                let v359 : int32 = v357.l0
                                                v356.[int v359] <- v359
                                                let v360 : int32 = v359 + 1
                                                v357.l0 <- v360
                                                ()
                                            let v361 : int32 = v356.Length
                                            let v362 : Mut2 = {l0 = 0; l1 = v355} : Mut2
                                            while method15(v361, v362) do
                                                let v364 : int32 = v362.l0
                                                let v365 : num_complex_Complex<float> = v362.l1
                                                let v366 : int32 = v356.[int v364]
                                                let v367 : string = "num_complex::Complex::new($0, $1)"
                                                let v368 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v367 
                                                let v370 : (int32 -> float) = float
                                                let v371 : float = v370 v366
                                                let v374 : string = "num_complex::Complex::new($0, $1)"
                                                let v375 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v371, 0.0) v374 
                                                let v376 : string = "num_complex::Complex::powc($0, $1)"
                                                let v377 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v375, v344) v376 
                                                let v378 : string = "$0 / $1"
                                                let v379 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v368, v377) v378 
                                                let v380 : string = "$0 + $1"
                                                let v381 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v365, v379) v380 
                                                let v382 : int32 = v364 + 1
                                                v362.l0 <- v382
                                                v362.l1 <- v381
                                                ()
                                            let v383 : num_complex_Complex<float> = v362.l1
                                            v383
                                        else
                                            let v384 : string = "num_complex::Complex::new($0, $1)"
                                            let v385 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v384 
                                            let v386 : string = "$0 - $1"
                                            let v387 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v385, v344) v386 
                                            let v388 : string = $"        s = mpmath.gamma(s)"
                                            let v389 : num_complex_Complex<float> = method3(v387)
                                            let v390 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v388, v389)
                                            (* run_target_args'
                                            let v392 : unit = ()
                                            run_target_args' *)
                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                            let v393 : string = "$0.ok()"
                                            let v394 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v390 v393 
                                            let _run_target_args'_v392 = v394 
                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                            let v395 : string = "$0.ok()"
                                            let v396 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v390 v395 
                                            let _run_target_args'_v392 = v396 
                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                            let v397 : string = "$0.ok()"
                                            let v398 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v390 v397 
                                            let _run_target_args'_v392 = v398 
                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                            let v399 : num_complex_Complex<float> option = match v390 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v392 = v399 
                                            #endif
#if FABLE_COMPILER_PYTHON
                                            let v400 : num_complex_Complex<float> option = match v390 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v392 = v400 
                                            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                                            let v401 : num_complex_Complex<float> option = match v390 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v392 = v401 
                                            #endif
#else
                                            let v402 : num_complex_Complex<float> option = match v390 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v392 = v402 
                                            #endif
                                            let v403 : num_complex_Complex<float> option = _run_target_args'_v392 
                                            let v408 : (num_complex_Complex<float> -> US0) = method17()
                                            let v409 : US0 option = v403 |> Option.map v408 
                                            let v429 : US0 = US0_1
                                            let v430 : US0 = v409 |> Option.defaultValue v429 
                                            let v434 : string = "f64::NAN"
                                            let v435 : float = Fable.Core.RustInterop.emitRustExpr () v434 
                                            let v436 : string = "f64::NAN"
                                            let v437 : float = Fable.Core.RustInterop.emitRustExpr () v436 
                                            let v438 : string = "num_complex::Complex::new($0, $1)"
                                            let v439 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v435, v437) v438 
                                            let v442 : num_complex_Complex<float> =
                                                match v430 with
                                                | US0_1 -> (* None *)
                                                    v439
                                                | US0_0(v440) -> (* Some *)
                                                    v440
                                            let v443 : string = "num_complex::Complex::new($0, $1)"
                                            let v444 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v443 
                                            let v445 : string = "$0 * $1"
                                            let v446 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v444, v344) v445 
                                            let v447 : string = "num_complex::Complex::new($0, $1)"
                                            let v448 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v447 
                                            let v449 : string = "$0 / $1"
                                            let v450 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v446, v448) v449 
                                            let v451 : string = "$0.sin()"
                                            let v452 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v450 v451 
                                            let v453 : string = "$0.re"
                                            let v454 : float = Fable.Core.RustInterop.emitRustExpr v344 v453 
                                            let v455 : float = 1.0 - v454
                                            let v456 : string = "$0.im"
                                            let v457 : float = Fable.Core.RustInterop.emitRustExpr v344 v456 
                                            let v458 : float =  -v457
                                            let v459 : string = "num_complex::Complex::new($0, $1)"
                                            let v460 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v455, v458) v459 
                                            let v461 : string = "$0.re"
                                            let v462 : float = Fable.Core.RustInterop.emitRustExpr v460 v461 
                                            let v463 : bool = v462 <= 1.0
                                            let v598 : num_complex_Complex<float> =
                                                if v463 then
                                                    let v464 : string = "num_complex::Complex::new($0, $1)"
                                                    let v465 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v464 
                                                    v465
                                                else
                                                    let v466 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                                    Fable.Core.RustInterop.emitRustExpr struct (4, v460) v466 
                                                    let v467 : string = "$0.re"
                                                    let v468 : float = Fable.Core.RustInterop.emitRustExpr v460 v467 
                                                    let v469 : bool = v468 > 1.0
                                                    if v469 then
                                                        let v470 : string = "num_complex::Complex::new($0, $1)"
                                                        let v471 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v470 
                                                        let v472 : (int32 []) = Array.zeroCreate<int32> (10000)
                                                        let v473 : Mut0 = {l0 = 0} : Mut0
                                                        while method14(v473) do
                                                            let v475 : int32 = v473.l0
                                                            v472.[int v475] <- v475
                                                            let v476 : int32 = v475 + 1
                                                            v473.l0 <- v476
                                                            ()
                                                        let v477 : int32 = v472.Length
                                                        let v478 : Mut2 = {l0 = 0; l1 = v471} : Mut2
                                                        while method15(v477, v478) do
                                                            let v480 : int32 = v478.l0
                                                            let v481 : num_complex_Complex<float> = v478.l1
                                                            let v482 : int32 = v472.[int v480]
                                                            let v483 : string = "num_complex::Complex::new($0, $1)"
                                                            let v484 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v483 
                                                            let v486 : (int32 -> float) = float
                                                            let v487 : float = v486 v482
                                                            let v490 : string = "num_complex::Complex::new($0, $1)"
                                                            let v491 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v487, 0.0) v490 
                                                            let v492 : string = "num_complex::Complex::powc($0, $1)"
                                                            let v493 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v491, v460) v492 
                                                            let v494 : string = "$0 / $1"
                                                            let v495 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v484, v493) v494 
                                                            let v496 : string = "$0 + $1"
                                                            let v497 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v481, v495) v496 
                                                            let v498 : int32 = v480 + 1
                                                            v478.l0 <- v498
                                                            v478.l1 <- v497
                                                            ()
                                                        let v499 : num_complex_Complex<float> = v478.l1
                                                        v499
                                                    else
                                                        let v500 : string = "num_complex::Complex::new($0, $1)"
                                                        let v501 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v500 
                                                        let v502 : string = "$0 - $1"
                                                        let v503 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v501, v460) v502 
                                                        let v504 : string = $"        s = mpmath.gamma(s)"
                                                        let v505 : num_complex_Complex<float> = method3(v503)
                                                        let v506 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v504, v505)
                                                        (* run_target_args'
                                                        let v508 : unit = ()
                                                        run_target_args' *)
                                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                        let v509 : string = "$0.ok()"
                                                        let v510 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v506 v509 
                                                        let _run_target_args'_v508 = v510 
                                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                                        let v511 : string = "$0.ok()"
                                                        let v512 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v506 v511 
                                                        let _run_target_args'_v508 = v512 
                                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                        let v513 : string = "$0.ok()"
                                                        let v514 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v506 v513 
                                                        let _run_target_args'_v508 = v514 
                                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                        let v515 : num_complex_Complex<float> option = match v506 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v508 = v515 
                                                        #endif
#if FABLE_COMPILER_PYTHON
                                                        let v516 : num_complex_Complex<float> option = match v506 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v508 = v516 
                                                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                                                        let v517 : num_complex_Complex<float> option = match v506 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v508 = v517 
                                                        #endif
#else
                                                        let v518 : num_complex_Complex<float> option = match v506 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v508 = v518 
                                                        #endif
                                                        let v519 : num_complex_Complex<float> option = _run_target_args'_v508 
                                                        let v524 : (num_complex_Complex<float> -> US0) = method17()
                                                        let v525 : US0 option = v519 |> Option.map v524 
                                                        let v545 : US0 = US0_1
                                                        let v546 : US0 = v525 |> Option.defaultValue v545 
                                                        let v550 : string = "f64::NAN"
                                                        let v551 : float = Fable.Core.RustInterop.emitRustExpr () v550 
                                                        let v552 : string = "f64::NAN"
                                                        let v553 : float = Fable.Core.RustInterop.emitRustExpr () v552 
                                                        let v554 : string = "num_complex::Complex::new($0, $1)"
                                                        let v555 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v551, v553) v554 
                                                        let v558 : num_complex_Complex<float> =
                                                            match v546 with
                                                            | US0_1 -> (* None *)
                                                                v555
                                                            | US0_0(v556) -> (* Some *)
                                                                v556
                                                        let v559 : string = "num_complex::Complex::new($0, $1)"
                                                        let v560 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v559 
                                                        let v561 : string = "$0 * $1"
                                                        let v562 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v560, v460) v561 
                                                        let v563 : string = "num_complex::Complex::new($0, $1)"
                                                        let v564 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v563 
                                                        let v565 : string = "$0 / $1"
                                                        let v566 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v562, v564) v565 
                                                        let v567 : string = "$0.sin()"
                                                        let v568 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v566 v567 
                                                        let v569 : string = "$0.re"
                                                        let v570 : float = Fable.Core.RustInterop.emitRustExpr v460 v569 
                                                        let v571 : float = 1.0 - v570
                                                        let v572 : string = "$0.im"
                                                        let v573 : float = Fable.Core.RustInterop.emitRustExpr v460 v572 
                                                        let v574 : float =  -v573
                                                        let v575 : string = "num_complex::Complex::new($0, $1)"
                                                        let v576 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v571, v574) v575 
                                                        let v577 : string = "$0.re"
                                                        let v578 : float = Fable.Core.RustInterop.emitRustExpr v576 v577 
                                                        let v579 : bool = v578 <= 1.0
                                                        let v582 : num_complex_Complex<float> =
                                                            if v579 then
                                                                let v580 : string = "num_complex::Complex::new($0, $1)"
                                                                let v581 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v580 
                                                                v581
                                                            else
                                                                v576
                                                        let v583 : string = "num_complex::Complex::new($0, $1)"
                                                        let v584 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v583 
                                                        let v585 : string = "num_complex::Complex::new($0, $1)"
                                                        let v586 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v585 
                                                        let v587 : string = "num_complex::Complex::powc($0, $1)"
                                                        let v588 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v586, v460) v587 
                                                        let v589 : string = "$0 * $1"
                                                        let v590 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v584, v588) v589 
                                                        let v591 : string = "$0 * $1"
                                                        let v592 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v590, v568) v591 
                                                        let v593 : string = "$0 * $1"
                                                        let v594 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v592, v558) v593 
                                                        let v595 : string = "$0 * $1"
                                                        let v596 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v594, v582) v595 
                                                        v596
                                            let v599 : string = "num_complex::Complex::new($0, $1)"
                                            let v600 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v599 
                                            let v601 : string = "num_complex::Complex::new($0, $1)"
                                            let v602 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v601 
                                            let v603 : string = "num_complex::Complex::powc($0, $1)"
                                            let v604 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v602, v344) v603 
                                            let v605 : string = "$0 * $1"
                                            let v606 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v600, v604) v605 
                                            let v607 : string = "$0 * $1"
                                            let v608 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v606, v452) v607 
                                            let v609 : string = "$0 * $1"
                                            let v610 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v608, v442) v609 
                                            let v611 : string = "$0 * $1"
                                            let v612 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v610, v598) v611 
                                            v612
                                let v615 : string = "num_complex::Complex::new($0, $1)"
                                let v616 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v615 
                                let v617 : string = "num_complex::Complex::new($0, $1)"
                                let v618 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v617 
                                let v619 : string = "num_complex::Complex::powc($0, $1)"
                                let v620 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v618, v228) v619 
                                let v621 : string = "$0 * $1"
                                let v622 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v616, v620) v621 
                                let v623 : string = "$0 * $1"
                                let v624 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v622, v336) v623 
                                let v625 : string = "$0 * $1"
                                let v626 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v624, v326) v625 
                                let v627 : string = "$0 * $1"
                                let v628 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v626, v614) v627 
                                v628
                    let v631 : string = "num_complex::Complex::new($0, $1)"
                    let v632 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v631 
                    let v633 : string = "num_complex::Complex::new($0, $1)"
                    let v634 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v633 
                    let v635 : string = "num_complex::Complex::powc($0, $1)"
                    let v636 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v634, v112) v635 
                    let v637 : string = "$0 * $1"
                    let v638 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v632, v636) v637 
                    let v639 : string = "$0 * $1"
                    let v640 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v638, v220) v639 
                    let v641 : string = "$0 * $1"
                    let v642 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v640, v210) v641 
                    let v643 : string = "$0 * $1"
                    let v644 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v642, v630) v643 
                    v644
        let v647 : string = "num_complex::Complex::new($0, $1)"
        let v648 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v647 
        let v649 : string = "num_complex::Complex::new($0, $1)"
        let v650 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v649 
        let v651 : string = "num_complex::Complex::powc($0, $1)"
        let v652 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v650, v1) v651 
        let v653 : string = "$0 * $1"
        let v654 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v648, v652) v653 
        let v655 : string = "$0 * $1"
        let v656 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v654, v104) v655 
        let v657 : string = "$0 * $1"
        let v658 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v656, v94) v657 
        let v659 : string = "$0 * $1"
        let v660 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v658, v646) v659 
        v660
and method18 (v0 : bool) : bool =
    v0
and method19 () : string =
    let v0 : string = ""
    v0
and closure2 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v4 : string = v2 + v1 
    v0.l0 <- v4
    ()
and closure3 (v0 : string) () : unit =
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
        let v54 : US0 = US0_1
        let v55 : US0 = v34 |> Option.defaultValue v54 
        let v59 : string = "f64::NAN"
        let v60 : float = Fable.Core.RustInterop.emitRustExpr () v59 
        let v61 : string = "f64::NAN"
        let v62 : float = Fable.Core.RustInterop.emitRustExpr () v61 
        let v63 : string = "num_complex::Complex::new($0, $1)"
        let v64 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v60, v62) v63 
        let v67 : num_complex_Complex<float> =
            match v55 with
            | US0_1 -> (* None *)
                v64
            | US0_0(v65) -> (* Some *)
                v65
        let v68 : string = "$0.im"
        let v69 : float = Fable.Core.RustInterop.emitRustExpr v67 v68 
        let v70 : bool = v69 = 0.0
        let v72 : bool =
            if v70 then
                true
            else
                method18(v70)
        let v73 : string = method19()
        let v74 : Mut3 = {l0 = v73} : Mut3
        let v77 : string = "{ "
        let v78 : string = $"{v77}"
        let v86 : unit = ()
        let v87 : (unit -> unit) = closure2(v74, v78)
        let v88 : unit = (fun () -> v87 (); v86) ()
        let v96 : string = "name"
        let v97 : string = $"{v96}"
        let v105 : unit = ()
        let v106 : (unit -> unit) = closure2(v74, v97)
        let v107 : unit = (fun () -> v106 (); v105) ()
        let v115 : string = " = "
        let v116 : string = $"{v115}"
        let v124 : unit = ()
        let v125 : (unit -> unit) = closure2(v74, v116)
        let v126 : unit = (fun () -> v125 (); v124) ()
        let v134 : string = "__assert_eq"
        let v135 : string = $"{v134}"
        let v143 : unit = ()
        let v144 : (unit -> unit) = closure2(v74, v135)
        let v145 : unit = (fun () -> v144 (); v143) ()
        let v153 : string = "; "
        let v154 : string = $"{v153}"
        let v162 : unit = ()
        let v163 : (unit -> unit) = closure2(v74, v154)
        let v164 : unit = (fun () -> v163 (); v162) ()
        let v172 : string = "actual"
        let v173 : string = $"{v172}"
        let v181 : unit = ()
        let v182 : (unit -> unit) = closure2(v74, v173)
        let v183 : unit = (fun () -> v182 (); v181) ()
        let v190 : string = $"{v115}"
        let v198 : unit = ()
        let v199 : (unit -> unit) = closure2(v74, v190)
        let v200 : unit = (fun () -> v199 (); v198) ()
        let v210 : string = $"%+.6f{v69}"
        let v218 : unit = ()
        let v219 : (unit -> unit) = closure2(v74, v210)
        let v220 : unit = (fun () -> v219 (); v218) ()
        let v227 : string = $"{v153}"
        let v235 : unit = ()
        let v236 : (unit -> unit) = closure2(v74, v227)
        let v237 : unit = (fun () -> v236 (); v235) ()
        let v245 : string = "expected"
        let v246 : string = $"{v245}"
        let v254 : unit = ()
        let v255 : (unit -> unit) = closure2(v74, v246)
        let v256 : unit = (fun () -> v255 (); v254) ()
        let v263 : string = $"{v115}"
        let v271 : unit = ()
        let v272 : (unit -> unit) = closure2(v74, v263)
        let v273 : unit = (fun () -> v272 (); v271) ()
        let v283 : string = $"%+.6f{0.0}"
        let v291 : unit = ()
        let v292 : (unit -> unit) = closure2(v74, v283)
        let v293 : unit = (fun () -> v292 (); v291) ()
        let v301 : string = " }"
        let v302 : string = $"{v301}"
        let v310 : unit = ()
        let v311 : (unit -> unit) = closure2(v74, v302)
        let v312 : unit = (fun () -> v311 (); v310) ()
        let v318 : string = v74.l0
        let v320 : unit = ()
        let v321 : (unit -> unit) = closure3(v318)
        let v322 : unit = (fun () -> v321 (); v320) ()
        let v324 : bool = v72 = false
        if v324 then
            failwith<unit> v318
        let v325 : string = "$0.re"
        let v326 : float = Fable.Core.RustInterop.emitRustExpr v67 v325 
        let v327 : float = v326 - v11
        let v328 : float =  -v327
        let v329 : bool = v327 >= v328
        let v330 : float =
            if v329 then
                v327
            else
                v328
        let v331 : bool = v330 < 0.0001
        let v333 : bool =
            if v331 then
                true
            else
                method18(v331)
        let v334 : string = method19()
        let v335 : Mut3 = {l0 = v334} : Mut3
        let v337 : string = $"{v77}"
        let v345 : unit = ()
        let v346 : (unit -> unit) = closure2(v335, v337)
        let v347 : unit = (fun () -> v346 (); v345) ()
        let v354 : string = $"{v96}"
        let v362 : unit = ()
        let v363 : (unit -> unit) = closure2(v335, v354)
        let v364 : unit = (fun () -> v363 (); v362) ()
        let v371 : string = $"{v115}"
        let v379 : unit = ()
        let v380 : (unit -> unit) = closure2(v335, v371)
        let v381 : unit = (fun () -> v380 (); v379) ()
        let v389 : string = "__assert_lt"
        let v390 : string = $"{v389}"
        let v398 : unit = ()
        let v399 : (unit -> unit) = closure2(v335, v390)
        let v400 : unit = (fun () -> v399 (); v398) ()
        let v407 : string = $"{v153}"
        let v415 : unit = ()
        let v416 : (unit -> unit) = closure2(v335, v407)
        let v417 : unit = (fun () -> v416 (); v415) ()
        let v424 : string = $"{v172}"
        let v432 : unit = ()
        let v433 : (unit -> unit) = closure2(v335, v424)
        let v434 : unit = (fun () -> v433 (); v432) ()
        let v441 : string = $"{v115}"
        let v449 : unit = ()
        let v450 : (unit -> unit) = closure2(v335, v441)
        let v451 : unit = (fun () -> v450 (); v449) ()
        let v461 : string = $"%+.6f{v330}"
        let v469 : unit = ()
        let v470 : (unit -> unit) = closure2(v335, v461)
        let v471 : unit = (fun () -> v470 (); v469) ()
        let v478 : string = $"{v153}"
        let v486 : unit = ()
        let v487 : (unit -> unit) = closure2(v335, v478)
        let v488 : unit = (fun () -> v487 (); v486) ()
        let v495 : string = $"{v245}"
        let v503 : unit = ()
        let v504 : (unit -> unit) = closure2(v335, v495)
        let v505 : unit = (fun () -> v504 (); v503) ()
        let v512 : string = $"{v115}"
        let v520 : unit = ()
        let v521 : (unit -> unit) = closure2(v335, v512)
        let v522 : unit = (fun () -> v521 (); v520) ()
        let v532 : string = $"%+.6f{0.0001}"
        let v540 : unit = ()
        let v541 : (unit -> unit) = closure2(v335, v532)
        let v542 : unit = (fun () -> v541 (); v540) ()
        let v549 : string = $"{v301}"
        let v557 : unit = ()
        let v558 : (unit -> unit) = closure2(v335, v549)
        let v559 : unit = (fun () -> v558 (); v557) ()
        let v565 : string = v335.l0
        let v567 : unit = ()
        let v568 : (unit -> unit) = closure3(v565)
        let v569 : unit = (fun () -> v568 (); v567) ()
        let v571 : bool = v333 = false
        if v571 then
            failwith<unit> v565
        let v572 : int32 = v9 + 1
        v7.l0 <- v572
        ()
    ()
and method20 (v0 : Result<unit, pyo3_PyErr>) : Result<unit, pyo3_PyErr> =
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
    let v8 : Result<unit, pyo3_PyErr> = method20(v5)
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
    let v25 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr () v25 
    let v27 : string = "__run_test"
    let v28 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v27 
    (* run_target_args'
    let v29 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v30 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method22 (v0 : pyo3_Python) : unit =
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
    let v45 : US0 = US0_1
    let v46 : US0 = v25 |> Option.defaultValue v45 
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
    let v61 : float = v60 - 0.8673
    let v62 : float =  -v61
    let v63 : bool = v61 >= v62
    let v64 : float =
        if v63 then
            v61
        else
            v62
    let v65 : bool = v64 < 0.001
    let v67 : bool =
        if v65 then
            true
        else
            method18(v65)
    let v68 : string = method19()
    let v69 : Mut3 = {l0 = v68} : Mut3
    let v72 : string = "{ "
    let v73 : string = $"{v72}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure2(v69, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "name"
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure2(v69, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = " = "
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure2(v69, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v129 : string = "__assert_lt"
    let v130 : string = $"{v129}"
    let v138 : unit = ()
    let v139 : (unit -> unit) = closure2(v69, v130)
    let v140 : unit = (fun () -> v139 (); v138) ()
    let v148 : string = "; "
    let v149 : string = $"{v148}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure2(v69, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v167 : string = "actual"
    let v168 : string = $"{v167}"
    let v176 : unit = ()
    let v177 : (unit -> unit) = closure2(v69, v168)
    let v178 : unit = (fun () -> v177 (); v176) ()
    let v185 : string = $"{v110}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure2(v69, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v205 : string = $"%+.6f{v64}"
    let v213 : unit = ()
    let v214 : (unit -> unit) = closure2(v69, v205)
    let v215 : unit = (fun () -> v214 (); v213) ()
    let v222 : string = $"{v148}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure2(v69, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v240 : string = "expected"
    let v241 : string = $"{v240}"
    let v249 : unit = ()
    let v250 : (unit -> unit) = closure2(v69, v241)
    let v251 : unit = (fun () -> v250 (); v249) ()
    let v258 : string = $"{v110}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure2(v69, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v278 : string = $"%+.6f{0.001}"
    let v286 : unit = ()
    let v287 : (unit -> unit) = closure2(v69, v278)
    let v288 : unit = (fun () -> v287 (); v286) ()
    let v296 : string = " }"
    let v297 : string = $"{v296}"
    let v305 : unit = ()
    let v306 : (unit -> unit) = closure2(v69, v297)
    let v307 : unit = (fun () -> v306 (); v305) ()
    let v313 : string = v69.l0
    let v315 : unit = ()
    let v316 : (unit -> unit) = closure3(v313)
    let v317 : unit = (fun () -> v316 (); v315) ()
    let v319 : bool = v67 = false
    if v319 then
        failwith<unit> v313
    let v320 : string = "$0.im"
    let v321 : float = Fable.Core.RustInterop.emitRustExpr v58 v320 
    let v322 : float = v321 - 0.275
    let v323 : float =  -v322
    let v324 : bool = v322 >= v323
    let v325 : float =
        if v324 then
            v322
        else
            v323
    let v326 : bool = v325 < 0.001
    let v328 : bool =
        if v326 then
            true
        else
            method18(v326)
    let v329 : string = method19()
    let v330 : Mut3 = {l0 = v329} : Mut3
    let v332 : string = $"{v72}"
    let v340 : unit = ()
    let v341 : (unit -> unit) = closure2(v330, v332)
    let v342 : unit = (fun () -> v341 (); v340) ()
    let v349 : string = $"{v91}"
    let v357 : unit = ()
    let v358 : (unit -> unit) = closure2(v330, v349)
    let v359 : unit = (fun () -> v358 (); v357) ()
    let v366 : string = $"{v110}"
    let v374 : unit = ()
    let v375 : (unit -> unit) = closure2(v330, v366)
    let v376 : unit = (fun () -> v375 (); v374) ()
    let v383 : string = $"{v129}"
    let v391 : unit = ()
    let v392 : (unit -> unit) = closure2(v330, v383)
    let v393 : unit = (fun () -> v392 (); v391) ()
    let v400 : string = $"{v148}"
    let v408 : unit = ()
    let v409 : (unit -> unit) = closure2(v330, v400)
    let v410 : unit = (fun () -> v409 (); v408) ()
    let v417 : string = $"{v167}"
    let v425 : unit = ()
    let v426 : (unit -> unit) = closure2(v330, v417)
    let v427 : unit = (fun () -> v426 (); v425) ()
    let v434 : string = $"{v110}"
    let v442 : unit = ()
    let v443 : (unit -> unit) = closure2(v330, v434)
    let v444 : unit = (fun () -> v443 (); v442) ()
    let v454 : string = $"%+.6f{v325}"
    let v462 : unit = ()
    let v463 : (unit -> unit) = closure2(v330, v454)
    let v464 : unit = (fun () -> v463 (); v462) ()
    let v471 : string = $"{v148}"
    let v479 : unit = ()
    let v480 : (unit -> unit) = closure2(v330, v471)
    let v481 : unit = (fun () -> v480 (); v479) ()
    let v488 : string = $"{v240}"
    let v496 : unit = ()
    let v497 : (unit -> unit) = closure2(v330, v488)
    let v498 : unit = (fun () -> v497 (); v496) ()
    let v505 : string = $"{v110}"
    let v513 : unit = ()
    let v514 : (unit -> unit) = closure2(v330, v505)
    let v515 : unit = (fun () -> v514 (); v513) ()
    let v525 : string = $"%+.6f{0.001}"
    let v533 : unit = ()
    let v534 : (unit -> unit) = closure2(v330, v525)
    let v535 : unit = (fun () -> v534 (); v533) ()
    let v542 : string = $"{v296}"
    let v550 : unit = ()
    let v551 : (unit -> unit) = closure2(v330, v542)
    let v552 : unit = (fun () -> v551 (); v550) ()
    let v558 : string = v330.l0
    let v560 : unit = ()
    let v561 : (unit -> unit) = closure3(v558)
    let v562 : unit = (fun () -> v561 (); v560) ()
    let v564 : bool = v328 = false
    if v564 then
        failwith<unit> v558
and method21 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method22(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method20(v5)
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
    let v25 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr () v25 
    let v27 : string = "__run_test"
    let v28 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v27 
    (* run_target_args'
    let v29 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v30 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method25 () : UH0 =
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
and method26 (v0 : pyo3_Python, v1 : UH0) : unit =
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
        let v48 : US0 = US0_1
        let v49 : US0 = v28 |> Option.defaultValue v48 
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
        let v62 : string = "$0.re"
        let v63 : float = Fable.Core.RustInterop.emitRustExpr v61 v62 
        let v64 : bool = v63 = 0.0
        let v66 : bool =
            if v64 then
                true
            else
                method18(v64)
        let v67 : string = method19()
        let v68 : Mut3 = {l0 = v67} : Mut3
        let v71 : string = "{ "
        let v72 : string = $"{v71}"
        let v80 : unit = ()
        let v81 : (unit -> unit) = closure2(v68, v72)
        let v82 : unit = (fun () -> v81 (); v80) ()
        let v90 : string = "name"
        let v91 : string = $"{v90}"
        let v99 : unit = ()
        let v100 : (unit -> unit) = closure2(v68, v91)
        let v101 : unit = (fun () -> v100 (); v99) ()
        let v109 : string = " = "
        let v110 : string = $"{v109}"
        let v118 : unit = ()
        let v119 : (unit -> unit) = closure2(v68, v110)
        let v120 : unit = (fun () -> v119 (); v118) ()
        let v128 : string = "__assert_eq"
        let v129 : string = $"{v128}"
        let v137 : unit = ()
        let v138 : (unit -> unit) = closure2(v68, v129)
        let v139 : unit = (fun () -> v138 (); v137) ()
        let v147 : string = "; "
        let v148 : string = $"{v147}"
        let v156 : unit = ()
        let v157 : (unit -> unit) = closure2(v68, v148)
        let v158 : unit = (fun () -> v157 (); v156) ()
        let v166 : string = "actual"
        let v167 : string = $"{v166}"
        let v175 : unit = ()
        let v176 : (unit -> unit) = closure2(v68, v167)
        let v177 : unit = (fun () -> v176 (); v175) ()
        let v184 : string = $"{v109}"
        let v192 : unit = ()
        let v193 : (unit -> unit) = closure2(v68, v184)
        let v194 : unit = (fun () -> v193 (); v192) ()
        let v204 : string = $"%+.6f{v63}"
        let v212 : unit = ()
        let v213 : (unit -> unit) = closure2(v68, v204)
        let v214 : unit = (fun () -> v213 (); v212) ()
        let v221 : string = $"{v147}"
        let v229 : unit = ()
        let v230 : (unit -> unit) = closure2(v68, v221)
        let v231 : unit = (fun () -> v230 (); v229) ()
        let v239 : string = "expected"
        let v240 : string = $"{v239}"
        let v248 : unit = ()
        let v249 : (unit -> unit) = closure2(v68, v240)
        let v250 : unit = (fun () -> v249 (); v248) ()
        let v257 : string = $"{v109}"
        let v265 : unit = ()
        let v266 : (unit -> unit) = closure2(v68, v257)
        let v267 : unit = (fun () -> v266 (); v265) ()
        let v277 : string = $"%+.6f{0.0}"
        let v285 : unit = ()
        let v286 : (unit -> unit) = closure2(v68, v277)
        let v287 : unit = (fun () -> v286 (); v285) ()
        let v295 : string = " }"
        let v296 : string = $"{v295}"
        let v304 : unit = ()
        let v305 : (unit -> unit) = closure2(v68, v296)
        let v306 : unit = (fun () -> v305 (); v304) ()
        let v312 : string = v68.l0
        let v314 : unit = ()
        let v315 : (unit -> unit) = closure3(v312)
        let v316 : unit = (fun () -> v315 (); v314) ()
        let v318 : bool = v66 = false
        if v318 then
            failwith<unit> v312
        let v319 : string = "$0.im"
        let v320 : float = Fable.Core.RustInterop.emitRustExpr v61 v319 
        let v321 : bool = v320 = 0.0
        let v323 : bool =
            if v321 then
                true
            else
                method18(v321)
        let v324 : string = method19()
        let v325 : Mut3 = {l0 = v324} : Mut3
        let v327 : string = $"{v71}"
        let v335 : unit = ()
        let v336 : (unit -> unit) = closure2(v325, v327)
        let v337 : unit = (fun () -> v336 (); v335) ()
        let v344 : string = $"{v90}"
        let v352 : unit = ()
        let v353 : (unit -> unit) = closure2(v325, v344)
        let v354 : unit = (fun () -> v353 (); v352) ()
        let v361 : string = $"{v109}"
        let v369 : unit = ()
        let v370 : (unit -> unit) = closure2(v325, v361)
        let v371 : unit = (fun () -> v370 (); v369) ()
        let v378 : string = $"{v128}"
        let v386 : unit = ()
        let v387 : (unit -> unit) = closure2(v325, v378)
        let v388 : unit = (fun () -> v387 (); v386) ()
        let v395 : string = $"{v147}"
        let v403 : unit = ()
        let v404 : (unit -> unit) = closure2(v325, v395)
        let v405 : unit = (fun () -> v404 (); v403) ()
        let v412 : string = $"{v166}"
        let v420 : unit = ()
        let v421 : (unit -> unit) = closure2(v325, v412)
        let v422 : unit = (fun () -> v421 (); v420) ()
        let v429 : string = $"{v109}"
        let v437 : unit = ()
        let v438 : (unit -> unit) = closure2(v325, v429)
        let v439 : unit = (fun () -> v438 (); v437) ()
        let v449 : string = $"%+.6f{v320}"
        let v457 : unit = ()
        let v458 : (unit -> unit) = closure2(v325, v449)
        let v459 : unit = (fun () -> v458 (); v457) ()
        let v466 : string = $"{v147}"
        let v474 : unit = ()
        let v475 : (unit -> unit) = closure2(v325, v466)
        let v476 : unit = (fun () -> v475 (); v474) ()
        let v483 : string = $"{v239}"
        let v491 : unit = ()
        let v492 : (unit -> unit) = closure2(v325, v483)
        let v493 : unit = (fun () -> v492 (); v491) ()
        let v500 : string = $"{v109}"
        let v508 : unit = ()
        let v509 : (unit -> unit) = closure2(v325, v500)
        let v510 : unit = (fun () -> v509 (); v508) ()
        let v520 : string = $"%+.6f{0.0}"
        let v528 : unit = ()
        let v529 : (unit -> unit) = closure2(v325, v520)
        let v530 : unit = (fun () -> v529 (); v528) ()
        let v537 : string = $"{v295}"
        let v545 : unit = ()
        let v546 : (unit -> unit) = closure2(v325, v537)
        let v547 : unit = (fun () -> v546 (); v545) ()
        let v553 : string = v325.l0
        let v555 : unit = ()
        let v556 : (unit -> unit) = closure3(v553)
        let v557 : unit = (fun () -> v556 (); v555) ()
        let v559 : bool = v323 = false
        if v559 then
            failwith<unit> v553
        method26(v0, v3)
    | UH0_0 -> (* Nil *)
        ()
and method24 (v0 : pyo3_Python) : unit =
    let v1 : UH0 = method25()
    method26(v0, v1)
and method23 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method24(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method20(v5)
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
    let v25 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr () v25 
    let v27 : string = "__run_test"
    let v28 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v27 
    (* run_target_args'
    let v29 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v30 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method28 (v0 : pyo3_Python) : unit =
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
        let v61 : US0 = US0_1
        let v62 : US0 = v41 |> Option.defaultValue v61 
        let v66 : string = "f64::NAN"
        let v67 : float = Fable.Core.RustInterop.emitRustExpr () v66 
        let v68 : string = "f64::NAN"
        let v69 : float = Fable.Core.RustInterop.emitRustExpr () v68 
        let v70 : string = "num_complex::Complex::new($0, $1)"
        let v71 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v67, v69) v70 
        let v74 : num_complex_Complex<float> =
            match v62 with
            | US0_1 -> (* None *)
                v71
            | US0_0(v72) -> (* Some *)
                v72
        let v75 : string = "$0.re"
        let v76 : float = Fable.Core.RustInterop.emitRustExpr v74 v75 
        let v77 : float =  -v76
        let v78 : bool = v76 >= v77
        let v79 : float =
            if v78 then
                v76
            else
                v77
        let v80 : bool = v79 < 0.0001
        let v82 : bool =
            if v80 then
                true
            else
                method18(v80)
        let v83 : string = method19()
        let v84 : Mut3 = {l0 = v83} : Mut3
        let v87 : string = "{ "
        let v88 : string = $"{v87}"
        let v96 : unit = ()
        let v97 : (unit -> unit) = closure2(v84, v88)
        let v98 : unit = (fun () -> v97 (); v96) ()
        let v106 : string = "name"
        let v107 : string = $"{v106}"
        let v115 : unit = ()
        let v116 : (unit -> unit) = closure2(v84, v107)
        let v117 : unit = (fun () -> v116 (); v115) ()
        let v125 : string = " = "
        let v126 : string = $"{v125}"
        let v134 : unit = ()
        let v135 : (unit -> unit) = closure2(v84, v126)
        let v136 : unit = (fun () -> v135 (); v134) ()
        let v144 : string = "__assert_lt"
        let v145 : string = $"{v144}"
        let v153 : unit = ()
        let v154 : (unit -> unit) = closure2(v84, v145)
        let v155 : unit = (fun () -> v154 (); v153) ()
        let v163 : string = "; "
        let v164 : string = $"{v163}"
        let v172 : unit = ()
        let v173 : (unit -> unit) = closure2(v84, v164)
        let v174 : unit = (fun () -> v173 (); v172) ()
        let v182 : string = "actual"
        let v183 : string = $"{v182}"
        let v191 : unit = ()
        let v192 : (unit -> unit) = closure2(v84, v183)
        let v193 : unit = (fun () -> v192 (); v191) ()
        let v200 : string = $"{v125}"
        let v208 : unit = ()
        let v209 : (unit -> unit) = closure2(v84, v200)
        let v210 : unit = (fun () -> v209 (); v208) ()
        let v220 : string = $"%+.6f{v79}"
        let v228 : unit = ()
        let v229 : (unit -> unit) = closure2(v84, v220)
        let v230 : unit = (fun () -> v229 (); v228) ()
        let v237 : string = $"{v163}"
        let v245 : unit = ()
        let v246 : (unit -> unit) = closure2(v84, v237)
        let v247 : unit = (fun () -> v246 (); v245) ()
        let v255 : string = "expected"
        let v256 : string = $"{v255}"
        let v264 : unit = ()
        let v265 : (unit -> unit) = closure2(v84, v256)
        let v266 : unit = (fun () -> v265 (); v264) ()
        let v273 : string = $"{v125}"
        let v281 : unit = ()
        let v282 : (unit -> unit) = closure2(v84, v273)
        let v283 : unit = (fun () -> v282 (); v281) ()
        let v293 : string = $"%+.6f{0.0001}"
        let v301 : unit = ()
        let v302 : (unit -> unit) = closure2(v84, v293)
        let v303 : unit = (fun () -> v302 (); v301) ()
        let v311 : string = " }"
        let v312 : string = $"{v311}"
        let v320 : unit = ()
        let v321 : (unit -> unit) = closure2(v84, v312)
        let v322 : unit = (fun () -> v321 (); v320) ()
        let v328 : string = v84.l0
        let v330 : unit = ()
        let v331 : (unit -> unit) = closure3(v328)
        let v332 : unit = (fun () -> v331 (); v330) ()
        let v334 : bool = v82 = false
        if v334 then
            failwith<unit> v328
        let v335 : string = "$0.im"
        let v336 : float = Fable.Core.RustInterop.emitRustExpr v74 v335 
        let v337 : float =  -v336
        let v338 : bool = v336 >= v337
        let v339 : float =
            if v338 then
                v336
            else
                v337
        let v340 : bool = v339 < 0.0001
        let v342 : bool =
            if v340 then
                true
            else
                method18(v340)
        let v343 : string = method19()
        let v344 : Mut3 = {l0 = v343} : Mut3
        let v346 : string = $"{v87}"
        let v354 : unit = ()
        let v355 : (unit -> unit) = closure2(v344, v346)
        let v356 : unit = (fun () -> v355 (); v354) ()
        let v363 : string = $"{v106}"
        let v371 : unit = ()
        let v372 : (unit -> unit) = closure2(v344, v363)
        let v373 : unit = (fun () -> v372 (); v371) ()
        let v380 : string = $"{v125}"
        let v388 : unit = ()
        let v389 : (unit -> unit) = closure2(v344, v380)
        let v390 : unit = (fun () -> v389 (); v388) ()
        let v397 : string = $"{v144}"
        let v405 : unit = ()
        let v406 : (unit -> unit) = closure2(v344, v397)
        let v407 : unit = (fun () -> v406 (); v405) ()
        let v414 : string = $"{v163}"
        let v422 : unit = ()
        let v423 : (unit -> unit) = closure2(v344, v414)
        let v424 : unit = (fun () -> v423 (); v422) ()
        let v431 : string = $"{v182}"
        let v439 : unit = ()
        let v440 : (unit -> unit) = closure2(v344, v431)
        let v441 : unit = (fun () -> v440 (); v439) ()
        let v448 : string = $"{v125}"
        let v456 : unit = ()
        let v457 : (unit -> unit) = closure2(v344, v448)
        let v458 : unit = (fun () -> v457 (); v456) ()
        let v468 : string = $"%+.6f{v339}"
        let v476 : unit = ()
        let v477 : (unit -> unit) = closure2(v344, v468)
        let v478 : unit = (fun () -> v477 (); v476) ()
        let v485 : string = $"{v163}"
        let v493 : unit = ()
        let v494 : (unit -> unit) = closure2(v344, v485)
        let v495 : unit = (fun () -> v494 (); v493) ()
        let v502 : string = $"{v255}"
        let v510 : unit = ()
        let v511 : (unit -> unit) = closure2(v344, v502)
        let v512 : unit = (fun () -> v511 (); v510) ()
        let v519 : string = $"{v125}"
        let v527 : unit = ()
        let v528 : (unit -> unit) = closure2(v344, v519)
        let v529 : unit = (fun () -> v528 (); v527) ()
        let v539 : string = $"%+.6f{0.0001}"
        let v547 : unit = ()
        let v548 : (unit -> unit) = closure2(v344, v539)
        let v549 : unit = (fun () -> v548 (); v547) ()
        let v556 : string = $"{v311}"
        let v564 : unit = ()
        let v565 : (unit -> unit) = closure2(v344, v556)
        let v566 : unit = (fun () -> v565 (); v564) ()
        let v572 : string = v344.l0
        let v574 : unit = ()
        let v575 : (unit -> unit) = closure3(v572)
        let v576 : unit = (fun () -> v575 (); v574) ()
        let v578 : bool = v342 = false
        if v578 then
            failwith<unit> v572
        let v579 : int32 = v17 + 1
        v15.l0 <- v579
        ()
    ()
and method27 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method28(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method20(v5)
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
    let v25 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr () v25 
    let v27 : string = "__run_test"
    let v28 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v27 
    (* run_target_args'
    let v29 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v30 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method30 (v0 : pyo3_Python) : unit =
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
        let v51 : US0 = US0_1
        let v52 : US0 = v31 |> Option.defaultValue v51 
        let v56 : string = "f64::NAN"
        let v57 : float = Fable.Core.RustInterop.emitRustExpr () v56 
        let v58 : string = "f64::NAN"
        let v59 : float = Fable.Core.RustInterop.emitRustExpr () v58 
        let v60 : string = "num_complex::Complex::new($0, $1)"
        let v61 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v57, v59) v60 
        let v64 : num_complex_Complex<float> =
            match v52 with
            | US0_1 -> (* None *)
                v61
            | US0_0(v62) -> (* Some *)
                v62
        let v65 : string = "$0.re"
        let v66 : float = Fable.Core.RustInterop.emitRustExpr v64 v65 
        let v67 : bool = v66 > 0.0
        let v69 : bool =
            if v67 then
                true
            else
                method18(v67)
        let v70 : string = method19()
        let v71 : Mut3 = {l0 = v70} : Mut3
        let v74 : string = "{ "
        let v75 : string = $"{v74}"
        let v83 : unit = ()
        let v84 : (unit -> unit) = closure2(v71, v75)
        let v85 : unit = (fun () -> v84 (); v83) ()
        let v93 : string = "name"
        let v94 : string = $"{v93}"
        let v102 : unit = ()
        let v103 : (unit -> unit) = closure2(v71, v94)
        let v104 : unit = (fun () -> v103 (); v102) ()
        let v112 : string = " = "
        let v113 : string = $"{v112}"
        let v121 : unit = ()
        let v122 : (unit -> unit) = closure2(v71, v113)
        let v123 : unit = (fun () -> v122 (); v121) ()
        let v131 : string = "__assert_gt"
        let v132 : string = $"{v131}"
        let v140 : unit = ()
        let v141 : (unit -> unit) = closure2(v71, v132)
        let v142 : unit = (fun () -> v141 (); v140) ()
        let v150 : string = "; "
        let v151 : string = $"{v150}"
        let v159 : unit = ()
        let v160 : (unit -> unit) = closure2(v71, v151)
        let v161 : unit = (fun () -> v160 (); v159) ()
        let v169 : string = "actual"
        let v170 : string = $"{v169}"
        let v178 : unit = ()
        let v179 : (unit -> unit) = closure2(v71, v170)
        let v180 : unit = (fun () -> v179 (); v178) ()
        let v187 : string = $"{v112}"
        let v195 : unit = ()
        let v196 : (unit -> unit) = closure2(v71, v187)
        let v197 : unit = (fun () -> v196 (); v195) ()
        let v207 : string = $"%+.6f{v66}"
        let v215 : unit = ()
        let v216 : (unit -> unit) = closure2(v71, v207)
        let v217 : unit = (fun () -> v216 (); v215) ()
        let v224 : string = $"{v150}"
        let v232 : unit = ()
        let v233 : (unit -> unit) = closure2(v71, v224)
        let v234 : unit = (fun () -> v233 (); v232) ()
        let v242 : string = "expected"
        let v243 : string = $"{v242}"
        let v251 : unit = ()
        let v252 : (unit -> unit) = closure2(v71, v243)
        let v253 : unit = (fun () -> v252 (); v251) ()
        let v260 : string = $"{v112}"
        let v268 : unit = ()
        let v269 : (unit -> unit) = closure2(v71, v260)
        let v270 : unit = (fun () -> v269 (); v268) ()
        let v280 : string = $"%+.6f{0.0}"
        let v288 : unit = ()
        let v289 : (unit -> unit) = closure2(v71, v280)
        let v290 : unit = (fun () -> v289 (); v288) ()
        let v298 : string = " }"
        let v299 : string = $"{v298}"
        let v307 : unit = ()
        let v308 : (unit -> unit) = closure2(v71, v299)
        let v309 : unit = (fun () -> v308 (); v307) ()
        let v315 : string = v71.l0
        let v317 : unit = ()
        let v318 : (unit -> unit) = closure3(v315)
        let v319 : unit = (fun () -> v318 (); v317) ()
        let v321 : bool = v69 = false
        if v321 then
            failwith<unit> v315
        let v322 : string = "$0.im"
        let v323 : float = Fable.Core.RustInterop.emitRustExpr v64 v322 
        let v324 : bool = v323 = 0.0
        let v326 : bool =
            if v324 then
                true
            else
                method18(v324)
        let v327 : string = method19()
        let v328 : Mut3 = {l0 = v327} : Mut3
        let v330 : string = $"{v74}"
        let v338 : unit = ()
        let v339 : (unit -> unit) = closure2(v328, v330)
        let v340 : unit = (fun () -> v339 (); v338) ()
        let v347 : string = $"{v93}"
        let v355 : unit = ()
        let v356 : (unit -> unit) = closure2(v328, v347)
        let v357 : unit = (fun () -> v356 (); v355) ()
        let v364 : string = $"{v112}"
        let v372 : unit = ()
        let v373 : (unit -> unit) = closure2(v328, v364)
        let v374 : unit = (fun () -> v373 (); v372) ()
        let v382 : string = "__assert_eq"
        let v383 : string = $"{v382}"
        let v391 : unit = ()
        let v392 : (unit -> unit) = closure2(v328, v383)
        let v393 : unit = (fun () -> v392 (); v391) ()
        let v400 : string = $"{v150}"
        let v408 : unit = ()
        let v409 : (unit -> unit) = closure2(v328, v400)
        let v410 : unit = (fun () -> v409 (); v408) ()
        let v417 : string = $"{v169}"
        let v425 : unit = ()
        let v426 : (unit -> unit) = closure2(v328, v417)
        let v427 : unit = (fun () -> v426 (); v425) ()
        let v434 : string = $"{v112}"
        let v442 : unit = ()
        let v443 : (unit -> unit) = closure2(v328, v434)
        let v444 : unit = (fun () -> v443 (); v442) ()
        let v454 : string = $"%+.6f{v323}"
        let v462 : unit = ()
        let v463 : (unit -> unit) = closure2(v328, v454)
        let v464 : unit = (fun () -> v463 (); v462) ()
        let v471 : string = $"{v150}"
        let v479 : unit = ()
        let v480 : (unit -> unit) = closure2(v328, v471)
        let v481 : unit = (fun () -> v480 (); v479) ()
        let v488 : string = $"{v242}"
        let v496 : unit = ()
        let v497 : (unit -> unit) = closure2(v328, v488)
        let v498 : unit = (fun () -> v497 (); v496) ()
        let v505 : string = $"{v112}"
        let v513 : unit = ()
        let v514 : (unit -> unit) = closure2(v328, v505)
        let v515 : unit = (fun () -> v514 (); v513) ()
        let v525 : string = $"%+.6f{0.0}"
        let v533 : unit = ()
        let v534 : (unit -> unit) = closure2(v328, v525)
        let v535 : unit = (fun () -> v534 (); v533) ()
        let v542 : string = $"{v298}"
        let v550 : unit = ()
        let v551 : (unit -> unit) = closure2(v328, v542)
        let v552 : unit = (fun () -> v551 (); v550) ()
        let v558 : string = v328.l0
        let v560 : unit = ()
        let v561 : (unit -> unit) = closure3(v558)
        let v562 : unit = (fun () -> v561 (); v560) ()
        let v564 : bool = v326 = false
        if v564 then
            failwith<unit> v558
        let v565 : int32 = v5 + 1
        v3.l0 <- v565
        ()
    ()
and method29 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method30(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method20(v5)
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
    let v25 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr () v25 
    let v27 : string = "__run_test"
    let v28 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v27 
    (* run_target_args'
    let v29 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v30 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method32 (v0 : pyo3_Python) : unit =
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
    let v45 : US0 = US0_1
    let v46 : US0 = v25 |> Option.defaultValue v45 
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
    let v61 : bool = v60 = infinity
    let v63 : bool =
        if v61 then
            true
        else
            method18(v61)
    let v64 : string = method19()
    let v65 : Mut3 = {l0 = v64} : Mut3
    let v68 : string = "{ "
    let v69 : string = $"{v68}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure2(v65, v69)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v87 : string = "name"
    let v88 : string = $"{v87}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure2(v65, v88)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v106 : string = " = "
    let v107 : string = $"{v106}"
    let v115 : unit = ()
    let v116 : (unit -> unit) = closure2(v65, v107)
    let v117 : unit = (fun () -> v116 (); v115) ()
    let v125 : string = "__assert_eq"
    let v126 : string = $"{v125}"
    let v134 : unit = ()
    let v135 : (unit -> unit) = closure2(v65, v126)
    let v136 : unit = (fun () -> v135 (); v134) ()
    let v144 : string = "; "
    let v145 : string = $"{v144}"
    let v153 : unit = ()
    let v154 : (unit -> unit) = closure2(v65, v145)
    let v155 : unit = (fun () -> v154 (); v153) ()
    let v163 : string = "actual"
    let v164 : string = $"{v163}"
    let v172 : unit = ()
    let v173 : (unit -> unit) = closure2(v65, v164)
    let v174 : unit = (fun () -> v173 (); v172) ()
    let v181 : string = $"{v106}"
    let v189 : unit = ()
    let v190 : (unit -> unit) = closure2(v65, v181)
    let v191 : unit = (fun () -> v190 (); v189) ()
    let v201 : string = $"%+.6f{v60}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure2(v65, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v218 : string = $"{v144}"
    let v226 : unit = ()
    let v227 : (unit -> unit) = closure2(v65, v218)
    let v228 : unit = (fun () -> v227 (); v226) ()
    let v236 : string = "expected"
    let v237 : string = $"{v236}"
    let v245 : unit = ()
    let v246 : (unit -> unit) = closure2(v65, v237)
    let v247 : unit = (fun () -> v246 (); v245) ()
    let v254 : string = $"{v106}"
    let v262 : unit = ()
    let v263 : (unit -> unit) = closure2(v65, v254)
    let v264 : unit = (fun () -> v263 (); v262) ()
    let v274 : string = $"%+.6f{infinity}"
    let v282 : unit = ()
    let v283 : (unit -> unit) = closure2(v65, v274)
    let v284 : unit = (fun () -> v283 (); v282) ()
    let v292 : string = " }"
    let v293 : string = $"{v292}"
    let v301 : unit = ()
    let v302 : (unit -> unit) = closure2(v65, v293)
    let v303 : unit = (fun () -> v302 (); v301) ()
    let v309 : string = v65.l0
    let v311 : unit = ()
    let v312 : (unit -> unit) = closure3(v309)
    let v313 : unit = (fun () -> v312 (); v311) ()
    let v315 : bool = v63 = false
    if v315 then
        failwith<unit> v309
    let v316 : string = "$0.im"
    let v317 : float = Fable.Core.RustInterop.emitRustExpr v58 v316 
    let v318 : bool = v317 = 0.0
    let v320 : bool =
        if v318 then
            true
        else
            method18(v318)
    let v321 : string = method19()
    let v322 : Mut3 = {l0 = v321} : Mut3
    let v324 : string = $"{v68}"
    let v332 : unit = ()
    let v333 : (unit -> unit) = closure2(v322, v324)
    let v334 : unit = (fun () -> v333 (); v332) ()
    let v341 : string = $"{v87}"
    let v349 : unit = ()
    let v350 : (unit -> unit) = closure2(v322, v341)
    let v351 : unit = (fun () -> v350 (); v349) ()
    let v358 : string = $"{v106}"
    let v366 : unit = ()
    let v367 : (unit -> unit) = closure2(v322, v358)
    let v368 : unit = (fun () -> v367 (); v366) ()
    let v375 : string = $"{v125}"
    let v383 : unit = ()
    let v384 : (unit -> unit) = closure2(v322, v375)
    let v385 : unit = (fun () -> v384 (); v383) ()
    let v392 : string = $"{v144}"
    let v400 : unit = ()
    let v401 : (unit -> unit) = closure2(v322, v392)
    let v402 : unit = (fun () -> v401 (); v400) ()
    let v409 : string = $"{v163}"
    let v417 : unit = ()
    let v418 : (unit -> unit) = closure2(v322, v409)
    let v419 : unit = (fun () -> v418 (); v417) ()
    let v426 : string = $"{v106}"
    let v434 : unit = ()
    let v435 : (unit -> unit) = closure2(v322, v426)
    let v436 : unit = (fun () -> v435 (); v434) ()
    let v446 : string = $"%+.6f{v317}"
    let v454 : unit = ()
    let v455 : (unit -> unit) = closure2(v322, v446)
    let v456 : unit = (fun () -> v455 (); v454) ()
    let v463 : string = $"{v144}"
    let v471 : unit = ()
    let v472 : (unit -> unit) = closure2(v322, v463)
    let v473 : unit = (fun () -> v472 (); v471) ()
    let v480 : string = $"{v236}"
    let v488 : unit = ()
    let v489 : (unit -> unit) = closure2(v322, v480)
    let v490 : unit = (fun () -> v489 (); v488) ()
    let v497 : string = $"{v106}"
    let v505 : unit = ()
    let v506 : (unit -> unit) = closure2(v322, v497)
    let v507 : unit = (fun () -> v506 (); v505) ()
    let v517 : string = $"%+.6f{0.0}"
    let v525 : unit = ()
    let v526 : (unit -> unit) = closure2(v322, v517)
    let v527 : unit = (fun () -> v526 (); v525) ()
    let v534 : string = $"{v292}"
    let v542 : unit = ()
    let v543 : (unit -> unit) = closure2(v322, v534)
    let v544 : unit = (fun () -> v543 (); v542) ()
    let v550 : string = v322.l0
    let v552 : unit = ()
    let v553 : (unit -> unit) = closure3(v550)
    let v554 : unit = (fun () -> v553 (); v552) ()
    let v556 : bool = v320 = false
    if v556 then
        failwith<unit> v550
and method31 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method32(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method20(v5)
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
    let v25 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr () v25 
    let v27 : string = "__run_test"
    let v28 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v27 
    (* run_target_args'
    let v29 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v30 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method34 (v0 : pyo3_Python) : unit =
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
    let v45 : US0 = US0_1
    let v46 : US0 = v25 |> Option.defaultValue v45 
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
    let v60 : float = Fable.Core.RustInterop.emitRustExpr v2 v59 
    let v61 : string = "$0.im"
    let v62 : float = Fable.Core.RustInterop.emitRustExpr v2 v61 
    let v63 : float =  -v62
    let v64 : string = "num_complex::Complex::new($0, $1)"
    let v65 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v60, v63) v64 
    let v66 : string = $"        s = mpmath.zeta(s)"
    let v67 : num_complex_Complex<float> = method3(v65)
    let v68 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v66, v67)
    let v69 : num_complex_Complex<float> = method13(v0, v65)
    (* run_target_args'
    let v71 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v72 : string = "$0.ok()"
    let v73 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v68 v72 
    let _run_target_args'_v71 = v73 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v74 : string = "$0.ok()"
    let v75 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v68 v74 
    let _run_target_args'_v71 = v75 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v76 : string = "$0.ok()"
    let v77 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v68 v76 
    let _run_target_args'_v71 = v77 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v78 : num_complex_Complex<float> option = match v68 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v71 = v78 
    #endif
#if FABLE_COMPILER_PYTHON
    let v79 : num_complex_Complex<float> option = match v68 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v71 = v79 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v80 : num_complex_Complex<float> option = match v68 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v71 = v80 
    #endif
#else
    let v81 : num_complex_Complex<float> option = match v68 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v71 = v81 
    #endif
    let v82 : num_complex_Complex<float> option = _run_target_args'_v71 
    let v87 : (num_complex_Complex<float> -> US0) = method17()
    let v88 : US0 option = v82 |> Option.map v87 
    let v108 : US0 = US0_1
    let v109 : US0 = v88 |> Option.defaultValue v108 
    let v113 : string = "f64::NAN"
    let v114 : float = Fable.Core.RustInterop.emitRustExpr () v113 
    let v115 : string = "f64::NAN"
    let v116 : float = Fable.Core.RustInterop.emitRustExpr () v115 
    let v117 : string = "num_complex::Complex::new($0, $1)"
    let v118 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v114, v116) v117 
    let v121 : num_complex_Complex<float> =
        match v109 with
        | US0_1 -> (* None *)
            v118
        | US0_0(v119) -> (* Some *)
            v119
    let v122 : string = "$0.conj()"
    let v123 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v121 v122 
    let v124 : string = "$0.re"
    let v125 : float = Fable.Core.RustInterop.emitRustExpr v58 v124 
    let v126 : string = "$0.re"
    let v127 : float = Fable.Core.RustInterop.emitRustExpr v123 v126 
    let v128 : bool = v125 = v127
    let v130 : bool =
        if v128 then
            true
        else
            method18(v128)
    let v131 : string = method19()
    let v132 : Mut3 = {l0 = v131} : Mut3
    let v135 : string = "{ "
    let v136 : string = $"{v135}"
    let v144 : unit = ()
    let v145 : (unit -> unit) = closure2(v132, v136)
    let v146 : unit = (fun () -> v145 (); v144) ()
    let v154 : string = "name"
    let v155 : string = $"{v154}"
    let v163 : unit = ()
    let v164 : (unit -> unit) = closure2(v132, v155)
    let v165 : unit = (fun () -> v164 (); v163) ()
    let v173 : string = " = "
    let v174 : string = $"{v173}"
    let v182 : unit = ()
    let v183 : (unit -> unit) = closure2(v132, v174)
    let v184 : unit = (fun () -> v183 (); v182) ()
    let v192 : string = "__assert_eq"
    let v193 : string = $"{v192}"
    let v201 : unit = ()
    let v202 : (unit -> unit) = closure2(v132, v193)
    let v203 : unit = (fun () -> v202 (); v201) ()
    let v211 : string = "; "
    let v212 : string = $"{v211}"
    let v220 : unit = ()
    let v221 : (unit -> unit) = closure2(v132, v212)
    let v222 : unit = (fun () -> v221 (); v220) ()
    let v230 : string = "actual"
    let v231 : string = $"{v230}"
    let v239 : unit = ()
    let v240 : (unit -> unit) = closure2(v132, v231)
    let v241 : unit = (fun () -> v240 (); v239) ()
    let v248 : string = $"{v173}"
    let v256 : unit = ()
    let v257 : (unit -> unit) = closure2(v132, v248)
    let v258 : unit = (fun () -> v257 (); v256) ()
    let v268 : string = $"%+.6f{v125}"
    let v276 : unit = ()
    let v277 : (unit -> unit) = closure2(v132, v268)
    let v278 : unit = (fun () -> v277 (); v276) ()
    let v285 : string = $"{v211}"
    let v293 : unit = ()
    let v294 : (unit -> unit) = closure2(v132, v285)
    let v295 : unit = (fun () -> v294 (); v293) ()
    let v303 : string = "expected"
    let v304 : string = $"{v303}"
    let v312 : unit = ()
    let v313 : (unit -> unit) = closure2(v132, v304)
    let v314 : unit = (fun () -> v313 (); v312) ()
    let v321 : string = $"{v173}"
    let v329 : unit = ()
    let v330 : (unit -> unit) = closure2(v132, v321)
    let v331 : unit = (fun () -> v330 (); v329) ()
    let v341 : string = $"%+.6f{v127}"
    let v349 : unit = ()
    let v350 : (unit -> unit) = closure2(v132, v341)
    let v351 : unit = (fun () -> v350 (); v349) ()
    let v359 : string = " }"
    let v360 : string = $"{v359}"
    let v368 : unit = ()
    let v369 : (unit -> unit) = closure2(v132, v360)
    let v370 : unit = (fun () -> v369 (); v368) ()
    let v376 : string = v132.l0
    let v378 : unit = ()
    let v379 : (unit -> unit) = closure3(v376)
    let v380 : unit = (fun () -> v379 (); v378) ()
    let v382 : bool = v130 = false
    if v382 then
        failwith<unit> v376
    let v383 : string = "$0.im"
    let v384 : float = Fable.Core.RustInterop.emitRustExpr v58 v383 
    let v385 : string = "$0.im"
    let v386 : float = Fable.Core.RustInterop.emitRustExpr v123 v385 
    let v387 : bool = v384 = v386
    let v389 : bool =
        if v387 then
            true
        else
            method18(v387)
    let v390 : string = method19()
    let v391 : Mut3 = {l0 = v390} : Mut3
    let v393 : string = $"{v135}"
    let v401 : unit = ()
    let v402 : (unit -> unit) = closure2(v391, v393)
    let v403 : unit = (fun () -> v402 (); v401) ()
    let v410 : string = $"{v154}"
    let v418 : unit = ()
    let v419 : (unit -> unit) = closure2(v391, v410)
    let v420 : unit = (fun () -> v419 (); v418) ()
    let v427 : string = $"{v173}"
    let v435 : unit = ()
    let v436 : (unit -> unit) = closure2(v391, v427)
    let v437 : unit = (fun () -> v436 (); v435) ()
    let v444 : string = $"{v192}"
    let v452 : unit = ()
    let v453 : (unit -> unit) = closure2(v391, v444)
    let v454 : unit = (fun () -> v453 (); v452) ()
    let v461 : string = $"{v211}"
    let v469 : unit = ()
    let v470 : (unit -> unit) = closure2(v391, v461)
    let v471 : unit = (fun () -> v470 (); v469) ()
    let v478 : string = $"{v230}"
    let v486 : unit = ()
    let v487 : (unit -> unit) = closure2(v391, v478)
    let v488 : unit = (fun () -> v487 (); v486) ()
    let v495 : string = $"{v173}"
    let v503 : unit = ()
    let v504 : (unit -> unit) = closure2(v391, v495)
    let v505 : unit = (fun () -> v504 (); v503) ()
    let v515 : string = $"%+.6f{v384}"
    let v523 : unit = ()
    let v524 : (unit -> unit) = closure2(v391, v515)
    let v525 : unit = (fun () -> v524 (); v523) ()
    let v532 : string = $"{v211}"
    let v540 : unit = ()
    let v541 : (unit -> unit) = closure2(v391, v532)
    let v542 : unit = (fun () -> v541 (); v540) ()
    let v549 : string = $"{v303}"
    let v557 : unit = ()
    let v558 : (unit -> unit) = closure2(v391, v549)
    let v559 : unit = (fun () -> v558 (); v557) ()
    let v566 : string = $"{v173}"
    let v574 : unit = ()
    let v575 : (unit -> unit) = closure2(v391, v566)
    let v576 : unit = (fun () -> v575 (); v574) ()
    let v586 : string = $"%+.6f{v386}"
    let v594 : unit = ()
    let v595 : (unit -> unit) = closure2(v391, v586)
    let v596 : unit = (fun () -> v595 (); v594) ()
    let v603 : string = $"{v359}"
    let v611 : unit = ()
    let v612 : (unit -> unit) = closure2(v391, v603)
    let v613 : unit = (fun () -> v612 (); v611) ()
    let v619 : string = v391.l0
    let v621 : unit = ()
    let v622 : (unit -> unit) = closure3(v619)
    let v623 : unit = (fun () -> v622 (); v621) ()
    let v625 : bool = v389 = false
    if v625 then
        failwith<unit> v619
and method33 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method34(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method20(v5)
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
    let v25 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr () v25 
    let v27 : string = "__run_test"
    let v28 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v27 
    (* run_target_args'
    let v29 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v30 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method36 (v0 : pyo3_Python) : unit =
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
    let v45 : US0 = US0_1
    let v46 : US0 = v25 |> Option.defaultValue v45 
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
    let v61 : bool = v60 < infinity
    let v63 : bool =
        if v61 then
            true
        else
            method18(v61)
    let v64 : string = method19()
    let v65 : Mut3 = {l0 = v64} : Mut3
    let v68 : string = "{ "
    let v69 : string = $"{v68}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure2(v65, v69)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v87 : string = "name"
    let v88 : string = $"{v87}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure2(v65, v88)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v106 : string = " = "
    let v107 : string = $"{v106}"
    let v115 : unit = ()
    let v116 : (unit -> unit) = closure2(v65, v107)
    let v117 : unit = (fun () -> v116 (); v115) ()
    let v125 : string = "__assert_lt"
    let v126 : string = $"{v125}"
    let v134 : unit = ()
    let v135 : (unit -> unit) = closure2(v65, v126)
    let v136 : unit = (fun () -> v135 (); v134) ()
    let v144 : string = "; "
    let v145 : string = $"{v144}"
    let v153 : unit = ()
    let v154 : (unit -> unit) = closure2(v65, v145)
    let v155 : unit = (fun () -> v154 (); v153) ()
    let v163 : string = "actual"
    let v164 : string = $"{v163}"
    let v172 : unit = ()
    let v173 : (unit -> unit) = closure2(v65, v164)
    let v174 : unit = (fun () -> v173 (); v172) ()
    let v181 : string = $"{v106}"
    let v189 : unit = ()
    let v190 : (unit -> unit) = closure2(v65, v181)
    let v191 : unit = (fun () -> v190 (); v189) ()
    let v201 : string = $"%+.6f{v60}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure2(v65, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v218 : string = $"{v144}"
    let v226 : unit = ()
    let v227 : (unit -> unit) = closure2(v65, v218)
    let v228 : unit = (fun () -> v227 (); v226) ()
    let v236 : string = "expected"
    let v237 : string = $"{v236}"
    let v245 : unit = ()
    let v246 : (unit -> unit) = closure2(v65, v237)
    let v247 : unit = (fun () -> v246 (); v245) ()
    let v254 : string = $"{v106}"
    let v262 : unit = ()
    let v263 : (unit -> unit) = closure2(v65, v254)
    let v264 : unit = (fun () -> v263 (); v262) ()
    let v274 : string = $"%+.6f{infinity}"
    let v282 : unit = ()
    let v283 : (unit -> unit) = closure2(v65, v274)
    let v284 : unit = (fun () -> v283 (); v282) ()
    let v292 : string = " }"
    let v293 : string = $"{v292}"
    let v301 : unit = ()
    let v302 : (unit -> unit) = closure2(v65, v293)
    let v303 : unit = (fun () -> v302 (); v301) ()
    let v309 : string = v65.l0
    let v311 : unit = ()
    let v312 : (unit -> unit) = closure3(v309)
    let v313 : unit = (fun () -> v312 (); v311) ()
    let v315 : bool = v63 = false
    if v315 then
        failwith<unit> v309
    let v316 : string = "$0.im"
    let v317 : float = Fable.Core.RustInterop.emitRustExpr v58 v316 
    let v318 : bool = v317 < infinity
    let v320 : bool =
        if v318 then
            true
        else
            method18(v318)
    let v321 : string = method19()
    let v322 : Mut3 = {l0 = v321} : Mut3
    let v324 : string = $"{v68}"
    let v332 : unit = ()
    let v333 : (unit -> unit) = closure2(v322, v324)
    let v334 : unit = (fun () -> v333 (); v332) ()
    let v341 : string = $"{v87}"
    let v349 : unit = ()
    let v350 : (unit -> unit) = closure2(v322, v341)
    let v351 : unit = (fun () -> v350 (); v349) ()
    let v358 : string = $"{v106}"
    let v366 : unit = ()
    let v367 : (unit -> unit) = closure2(v322, v358)
    let v368 : unit = (fun () -> v367 (); v366) ()
    let v375 : string = $"{v125}"
    let v383 : unit = ()
    let v384 : (unit -> unit) = closure2(v322, v375)
    let v385 : unit = (fun () -> v384 (); v383) ()
    let v392 : string = $"{v144}"
    let v400 : unit = ()
    let v401 : (unit -> unit) = closure2(v322, v392)
    let v402 : unit = (fun () -> v401 (); v400) ()
    let v409 : string = $"{v163}"
    let v417 : unit = ()
    let v418 : (unit -> unit) = closure2(v322, v409)
    let v419 : unit = (fun () -> v418 (); v417) ()
    let v426 : string = $"{v106}"
    let v434 : unit = ()
    let v435 : (unit -> unit) = closure2(v322, v426)
    let v436 : unit = (fun () -> v435 (); v434) ()
    let v446 : string = $"%+.6f{v317}"
    let v454 : unit = ()
    let v455 : (unit -> unit) = closure2(v322, v446)
    let v456 : unit = (fun () -> v455 (); v454) ()
    let v463 : string = $"{v144}"
    let v471 : unit = ()
    let v472 : (unit -> unit) = closure2(v322, v463)
    let v473 : unit = (fun () -> v472 (); v471) ()
    let v480 : string = $"{v236}"
    let v488 : unit = ()
    let v489 : (unit -> unit) = closure2(v322, v480)
    let v490 : unit = (fun () -> v489 (); v488) ()
    let v497 : string = $"{v106}"
    let v505 : unit = ()
    let v506 : (unit -> unit) = closure2(v322, v497)
    let v507 : unit = (fun () -> v506 (); v505) ()
    let v517 : string = $"%+.6f{infinity}"
    let v525 : unit = ()
    let v526 : (unit -> unit) = closure2(v322, v517)
    let v527 : unit = (fun () -> v526 (); v525) ()
    let v534 : string = $"{v292}"
    let v542 : unit = ()
    let v543 : (unit -> unit) = closure2(v322, v534)
    let v544 : unit = (fun () -> v543 (); v542) ()
    let v550 : string = v322.l0
    let v552 : unit = ()
    let v553 : (unit -> unit) = closure3(v550)
    let v554 : unit = (fun () -> v553 (); v552) ()
    let v556 : bool = v320 = false
    if v556 then
        failwith<unit> v550
and method35 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method36(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method20(v5)
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
    let v25 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr () v25 
    let v27 : string = "__run_test"
    let v28 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v27 
    (* run_target_args'
    let v29 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v30 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method39 () : UH0 =
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
and method40 (v0 : pyo3_Python, v1 : UH0) : unit =
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
        let v48 : US0 = US0_1
        let v49 : US0 = v28 |> Option.defaultValue v48 
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
        let v62 : string = "$0.re"
        let v63 : float = Fable.Core.RustInterop.emitRustExpr v61 v62 
        let v65 : bool = v63 <> 0.0 
        let v69 : bool =
            if v65 then
                true
            else
                method18(v65)
        let v70 : string = method19()
        let v71 : Mut3 = {l0 = v70} : Mut3
        let v74 : string = "{ "
        let v75 : string = $"{v74}"
        let v83 : unit = ()
        let v84 : (unit -> unit) = closure2(v71, v75)
        let v85 : unit = (fun () -> v84 (); v83) ()
        let v93 : string = "name"
        let v94 : string = $"{v93}"
        let v102 : unit = ()
        let v103 : (unit -> unit) = closure2(v71, v94)
        let v104 : unit = (fun () -> v103 (); v102) ()
        let v112 : string = " = "
        let v113 : string = $"{v112}"
        let v121 : unit = ()
        let v122 : (unit -> unit) = closure2(v71, v113)
        let v123 : unit = (fun () -> v122 (); v121) ()
        let v131 : string = "__assert_ne"
        let v132 : string = $"{v131}"
        let v140 : unit = ()
        let v141 : (unit -> unit) = closure2(v71, v132)
        let v142 : unit = (fun () -> v141 (); v140) ()
        let v150 : string = "; "
        let v151 : string = $"{v150}"
        let v159 : unit = ()
        let v160 : (unit -> unit) = closure2(v71, v151)
        let v161 : unit = (fun () -> v160 (); v159) ()
        let v169 : string = "actual"
        let v170 : string = $"{v169}"
        let v178 : unit = ()
        let v179 : (unit -> unit) = closure2(v71, v170)
        let v180 : unit = (fun () -> v179 (); v178) ()
        let v187 : string = $"{v112}"
        let v195 : unit = ()
        let v196 : (unit -> unit) = closure2(v71, v187)
        let v197 : unit = (fun () -> v196 (); v195) ()
        let v207 : string = $"%+.6f{v63}"
        let v215 : unit = ()
        let v216 : (unit -> unit) = closure2(v71, v207)
        let v217 : unit = (fun () -> v216 (); v215) ()
        let v224 : string = $"{v150}"
        let v232 : unit = ()
        let v233 : (unit -> unit) = closure2(v71, v224)
        let v234 : unit = (fun () -> v233 (); v232) ()
        let v242 : string = "expected"
        let v243 : string = $"{v242}"
        let v251 : unit = ()
        let v252 : (unit -> unit) = closure2(v71, v243)
        let v253 : unit = (fun () -> v252 (); v251) ()
        let v260 : string = $"{v112}"
        let v268 : unit = ()
        let v269 : (unit -> unit) = closure2(v71, v260)
        let v270 : unit = (fun () -> v269 (); v268) ()
        let v280 : string = $"%+.6f{0.0}"
        let v288 : unit = ()
        let v289 : (unit -> unit) = closure2(v71, v280)
        let v290 : unit = (fun () -> v289 (); v288) ()
        let v298 : string = " }"
        let v299 : string = $"{v298}"
        let v307 : unit = ()
        let v308 : (unit -> unit) = closure2(v71, v299)
        let v309 : unit = (fun () -> v308 (); v307) ()
        let v315 : string = v71.l0
        let v317 : unit = ()
        let v318 : (unit -> unit) = closure3(v315)
        let v319 : unit = (fun () -> v318 (); v317) ()
        let v321 : bool = v69 = false
        if v321 then
            failwith<unit> v315
        let v322 : string = "$0.im"
        let v323 : float = Fable.Core.RustInterop.emitRustExpr v61 v322 
        let v325 : bool = v323 <> 0.0 
        let v329 : bool =
            if v325 then
                true
            else
                method18(v325)
        let v330 : string = method19()
        let v331 : Mut3 = {l0 = v330} : Mut3
        let v333 : string = $"{v74}"
        let v341 : unit = ()
        let v342 : (unit -> unit) = closure2(v331, v333)
        let v343 : unit = (fun () -> v342 (); v341) ()
        let v350 : string = $"{v93}"
        let v358 : unit = ()
        let v359 : (unit -> unit) = closure2(v331, v350)
        let v360 : unit = (fun () -> v359 (); v358) ()
        let v367 : string = $"{v112}"
        let v375 : unit = ()
        let v376 : (unit -> unit) = closure2(v331, v367)
        let v377 : unit = (fun () -> v376 (); v375) ()
        let v384 : string = $"{v131}"
        let v392 : unit = ()
        let v393 : (unit -> unit) = closure2(v331, v384)
        let v394 : unit = (fun () -> v393 (); v392) ()
        let v401 : string = $"{v150}"
        let v409 : unit = ()
        let v410 : (unit -> unit) = closure2(v331, v401)
        let v411 : unit = (fun () -> v410 (); v409) ()
        let v418 : string = $"{v169}"
        let v426 : unit = ()
        let v427 : (unit -> unit) = closure2(v331, v418)
        let v428 : unit = (fun () -> v427 (); v426) ()
        let v435 : string = $"{v112}"
        let v443 : unit = ()
        let v444 : (unit -> unit) = closure2(v331, v435)
        let v445 : unit = (fun () -> v444 (); v443) ()
        let v455 : string = $"%+.6f{v323}"
        let v463 : unit = ()
        let v464 : (unit -> unit) = closure2(v331, v455)
        let v465 : unit = (fun () -> v464 (); v463) ()
        let v472 : string = $"{v150}"
        let v480 : unit = ()
        let v481 : (unit -> unit) = closure2(v331, v472)
        let v482 : unit = (fun () -> v481 (); v480) ()
        let v489 : string = $"{v242}"
        let v497 : unit = ()
        let v498 : (unit -> unit) = closure2(v331, v489)
        let v499 : unit = (fun () -> v498 (); v497) ()
        let v506 : string = $"{v112}"
        let v514 : unit = ()
        let v515 : (unit -> unit) = closure2(v331, v506)
        let v516 : unit = (fun () -> v515 (); v514) ()
        let v526 : string = $"%+.6f{0.0}"
        let v534 : unit = ()
        let v535 : (unit -> unit) = closure2(v331, v526)
        let v536 : unit = (fun () -> v535 (); v534) ()
        let v543 : string = $"{v298}"
        let v551 : unit = ()
        let v552 : (unit -> unit) = closure2(v331, v543)
        let v553 : unit = (fun () -> v552 (); v551) ()
        let v559 : string = v331.l0
        let v561 : unit = ()
        let v562 : (unit -> unit) = closure3(v559)
        let v563 : unit = (fun () -> v562 (); v561) ()
        let v565 : bool = v329 = false
        if v565 then
            failwith<unit> v559
        method40(v0, v3)
    | UH0_0 -> (* Nil *)
        ()
and method38 (v0 : pyo3_Python) : unit =
    let v1 : UH0 = method39()
    method40(v0, v1)
and method37 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method38(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method20(v5)
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
    let v25 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr () v25 
    let v27 : string = "__run_test"
    let v28 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v27 
    (* run_target_args'
    let v29 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v30 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method43 () : UH1 =
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
and method44 (v0 : pyo3_Python, v1 : UH1) : unit =
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
        let v46 : US0 = US0_1
        let v47 : US0 = v26 |> Option.defaultValue v46 
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
        let v60 : string = "$0.re"
        let v61 : float = Fable.Core.RustInterop.emitRustExpr v59 v60 
        let v63 : bool = v61 <> 0.0 
        let v67 : bool =
            if v63 then
                true
            else
                method18(v63)
        let v68 : string = method19()
        let v69 : Mut3 = {l0 = v68} : Mut3
        let v72 : string = "{ "
        let v73 : string = $"{v72}"
        let v81 : unit = ()
        let v82 : (unit -> unit) = closure2(v69, v73)
        let v83 : unit = (fun () -> v82 (); v81) ()
        let v91 : string = "name"
        let v92 : string = $"{v91}"
        let v100 : unit = ()
        let v101 : (unit -> unit) = closure2(v69, v92)
        let v102 : unit = (fun () -> v101 (); v100) ()
        let v110 : string = " = "
        let v111 : string = $"{v110}"
        let v119 : unit = ()
        let v120 : (unit -> unit) = closure2(v69, v111)
        let v121 : unit = (fun () -> v120 (); v119) ()
        let v129 : string = "__assert_ne"
        let v130 : string = $"{v129}"
        let v138 : unit = ()
        let v139 : (unit -> unit) = closure2(v69, v130)
        let v140 : unit = (fun () -> v139 (); v138) ()
        let v148 : string = "; "
        let v149 : string = $"{v148}"
        let v157 : unit = ()
        let v158 : (unit -> unit) = closure2(v69, v149)
        let v159 : unit = (fun () -> v158 (); v157) ()
        let v167 : string = "actual"
        let v168 : string = $"{v167}"
        let v176 : unit = ()
        let v177 : (unit -> unit) = closure2(v69, v168)
        let v178 : unit = (fun () -> v177 (); v176) ()
        let v185 : string = $"{v110}"
        let v193 : unit = ()
        let v194 : (unit -> unit) = closure2(v69, v185)
        let v195 : unit = (fun () -> v194 (); v193) ()
        let v205 : string = $"%+.6f{v61}"
        let v213 : unit = ()
        let v214 : (unit -> unit) = closure2(v69, v205)
        let v215 : unit = (fun () -> v214 (); v213) ()
        let v222 : string = $"{v148}"
        let v230 : unit = ()
        let v231 : (unit -> unit) = closure2(v69, v222)
        let v232 : unit = (fun () -> v231 (); v230) ()
        let v240 : string = "expected"
        let v241 : string = $"{v240}"
        let v249 : unit = ()
        let v250 : (unit -> unit) = closure2(v69, v241)
        let v251 : unit = (fun () -> v250 (); v249) ()
        let v258 : string = $"{v110}"
        let v266 : unit = ()
        let v267 : (unit -> unit) = closure2(v69, v258)
        let v268 : unit = (fun () -> v267 (); v266) ()
        let v278 : string = $"%+.6f{0.0}"
        let v286 : unit = ()
        let v287 : (unit -> unit) = closure2(v69, v278)
        let v288 : unit = (fun () -> v287 (); v286) ()
        let v296 : string = " }"
        let v297 : string = $"{v296}"
        let v305 : unit = ()
        let v306 : (unit -> unit) = closure2(v69, v297)
        let v307 : unit = (fun () -> v306 (); v305) ()
        let v313 : string = v69.l0
        let v315 : unit = ()
        let v316 : (unit -> unit) = closure3(v313)
        let v317 : unit = (fun () -> v316 (); v315) ()
        let v319 : bool = v67 = false
        if v319 then
            failwith<unit> v313
        let v320 : string = "$0.im"
        let v321 : float = Fable.Core.RustInterop.emitRustExpr v59 v320 
        let v323 : bool = v321 <> 0.0 
        let v327 : bool =
            if v323 then
                true
            else
                method18(v323)
        let v328 : string = method19()
        let v329 : Mut3 = {l0 = v328} : Mut3
        let v331 : string = $"{v72}"
        let v339 : unit = ()
        let v340 : (unit -> unit) = closure2(v329, v331)
        let v341 : unit = (fun () -> v340 (); v339) ()
        let v348 : string = $"{v91}"
        let v356 : unit = ()
        let v357 : (unit -> unit) = closure2(v329, v348)
        let v358 : unit = (fun () -> v357 (); v356) ()
        let v365 : string = $"{v110}"
        let v373 : unit = ()
        let v374 : (unit -> unit) = closure2(v329, v365)
        let v375 : unit = (fun () -> v374 (); v373) ()
        let v382 : string = $"{v129}"
        let v390 : unit = ()
        let v391 : (unit -> unit) = closure2(v329, v382)
        let v392 : unit = (fun () -> v391 (); v390) ()
        let v399 : string = $"{v148}"
        let v407 : unit = ()
        let v408 : (unit -> unit) = closure2(v329, v399)
        let v409 : unit = (fun () -> v408 (); v407) ()
        let v416 : string = $"{v167}"
        let v424 : unit = ()
        let v425 : (unit -> unit) = closure2(v329, v416)
        let v426 : unit = (fun () -> v425 (); v424) ()
        let v433 : string = $"{v110}"
        let v441 : unit = ()
        let v442 : (unit -> unit) = closure2(v329, v433)
        let v443 : unit = (fun () -> v442 (); v441) ()
        let v453 : string = $"%+.6f{v321}"
        let v461 : unit = ()
        let v462 : (unit -> unit) = closure2(v329, v453)
        let v463 : unit = (fun () -> v462 (); v461) ()
        let v470 : string = $"{v148}"
        let v478 : unit = ()
        let v479 : (unit -> unit) = closure2(v329, v470)
        let v480 : unit = (fun () -> v479 (); v478) ()
        let v487 : string = $"{v240}"
        let v495 : unit = ()
        let v496 : (unit -> unit) = closure2(v329, v487)
        let v497 : unit = (fun () -> v496 (); v495) ()
        let v504 : string = $"{v110}"
        let v512 : unit = ()
        let v513 : (unit -> unit) = closure2(v329, v504)
        let v514 : unit = (fun () -> v513 (); v512) ()
        let v524 : string = $"%+.6f{0.0}"
        let v532 : unit = ()
        let v533 : (unit -> unit) = closure2(v329, v524)
        let v534 : unit = (fun () -> v533 (); v532) ()
        let v541 : string = $"{v296}"
        let v549 : unit = ()
        let v550 : (unit -> unit) = closure2(v329, v541)
        let v551 : unit = (fun () -> v550 (); v549) ()
        let v557 : string = v329.l0
        let v559 : unit = ()
        let v560 : (unit -> unit) = closure3(v557)
        let v561 : unit = (fun () -> v560 (); v559) ()
        let v563 : bool = v327 = false
        if v563 then
            failwith<unit> v557
        method44(v0, v3)
    | UH1_0 -> (* Nil *)
        ()
and method42 (v0 : pyo3_Python) : unit =
    let v1 : UH1 = method43()
    method44(v0, v1)
and method41 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method42(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method20(v5)
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
    let v25 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr () v25 
    let v27 : string = "__run_test"
    let v28 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v27 
    (* run_target_args'
    let v29 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v30 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method47 () : UH1 =
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
and method48 (v0 : pyo3_Python, v1 : UH1) : unit =
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
        let v46 : US0 = US0_1
        let v47 : US0 = v26 |> Option.defaultValue v46 
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
        let v60 : string = "num_complex::Complex::new($0, $1)"
        let v61 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v60 
        let v62 : string = "num_complex::Complex::powc($0, $1)"
        let v63 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v61, v2) v62 
        let v64 : string = "num_complex::Complex::new($0, $1)"
        let v65 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v64 
        let v66 : string = "num_complex::Complex::new($0, $1)"
        let v67 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v66 
        let v68 : string = "$0 - $1"
        let v69 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v2, v67) v68 
        let v70 : string = "num_complex::Complex::powc($0, $1)"
        let v71 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v65, v69) v70 
        let v72 : string = "$0 * $1"
        let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v63, v71) v72 
        let v74 : string = "num_complex::Complex::new($0, $1)"
        let v75 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v74 
        let v76 : string = "$0 * $1"
        let v77 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v75, v2) v76 
        let v78 : string = "num_complex::Complex::new($0, $1)"
        let v79 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v78 
        let v80 : string = "$0 / $1"
        let v81 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v77, v79) v80 
        let v82 : string = "$0.sin()"
        let v83 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v81 v82 
        let v84 : string = "$0 * $1"
        let v85 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v73, v83) v84 
        let v86 : string = "num_complex::Complex::new($0, $1)"
        let v87 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v86 
        let v88 : string = "$0 - $1"
        let v89 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v87, v2) v88 
        let v90 : string = $"        s = mpmath.gamma(s)"
        let v91 : num_complex_Complex<float> = method3(v89)
        let v92 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v90, v91)
        (* run_target_args'
        let v94 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v95 : string = "$0.ok()"
        let v96 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v92 v95 
        let _run_target_args'_v94 = v96 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v97 : string = "$0.ok()"
        let v98 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v92 v97 
        let _run_target_args'_v94 = v98 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v99 : string = "$0.ok()"
        let v100 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v92 v99 
        let _run_target_args'_v94 = v100 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v101 : num_complex_Complex<float> option = match v92 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v94 = v101 
        #endif
#if FABLE_COMPILER_PYTHON
        let v102 : num_complex_Complex<float> option = match v92 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v94 = v102 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v103 : num_complex_Complex<float> option = match v92 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v94 = v103 
        #endif
#else
        let v104 : num_complex_Complex<float> option = match v92 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v94 = v104 
        #endif
        let v105 : num_complex_Complex<float> option = _run_target_args'_v94 
        let v110 : (num_complex_Complex<float> -> US0) = method17()
        let v111 : US0 option = v105 |> Option.map v110 
        let v131 : US0 = US0_1
        let v132 : US0 = v111 |> Option.defaultValue v131 
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
        let v146 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v85, v144) v145 
        let v147 : string = "$0.re"
        let v148 : float = Fable.Core.RustInterop.emitRustExpr v2 v147 
        let v149 : float = 1.0 - v148
        let v150 : string = "$0.im"
        let v151 : float = Fable.Core.RustInterop.emitRustExpr v2 v150 
        let v152 : float =  -v151
        let v153 : string = "num_complex::Complex::new($0, $1)"
        let v154 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v149, v152) v153 
        let v155 : string = $"        s = mpmath.zeta(s)"
        let v156 : num_complex_Complex<float> = method3(v154)
        let v157 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v155, v156)
        let v158 : num_complex_Complex<float> = method13(v0, v154)
        (* run_target_args'
        let v160 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v161 : string = "$0.ok()"
        let v162 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v157 v161 
        let _run_target_args'_v160 = v162 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v163 : string = "$0.ok()"
        let v164 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v157 v163 
        let _run_target_args'_v160 = v164 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v165 : string = "$0.ok()"
        let v166 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v157 v165 
        let _run_target_args'_v160 = v166 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v167 : num_complex_Complex<float> option = match v157 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v160 = v167 
        #endif
#if FABLE_COMPILER_PYTHON
        let v168 : num_complex_Complex<float> option = match v157 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v160 = v168 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v169 : num_complex_Complex<float> option = match v157 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v160 = v169 
        #endif
#else
        let v170 : num_complex_Complex<float> option = match v157 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v160 = v170 
        #endif
        let v171 : num_complex_Complex<float> option = _run_target_args'_v160 
        let v176 : (num_complex_Complex<float> -> US0) = method17()
        let v177 : US0 option = v171 |> Option.map v176 
        let v197 : US0 = US0_1
        let v198 : US0 = v177 |> Option.defaultValue v197 
        let v202 : string = "f64::NAN"
        let v203 : float = Fable.Core.RustInterop.emitRustExpr () v202 
        let v204 : string = "f64::NAN"
        let v205 : float = Fable.Core.RustInterop.emitRustExpr () v204 
        let v206 : string = "num_complex::Complex::new($0, $1)"
        let v207 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v203, v205) v206 
        let v210 : num_complex_Complex<float> =
            match v198 with
            | US0_1 -> (* None *)
                v207
            | US0_0(v208) -> (* Some *)
                v208
        let v211 : string = "$0 * $1"
        let v212 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v146, v210) v211 
        let v213 : string = "$0.re"
        let v214 : float = Fable.Core.RustInterop.emitRustExpr v59 v213 
        let v215 : string = "$0.re"
        let v216 : float = Fable.Core.RustInterop.emitRustExpr v212 v215 
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
        let v224 : string = method19()
        let v225 : Mut3 = {l0 = v224} : Mut3
        let v228 : string = "{ "
        let v229 : string = $"{v228}"
        let v237 : unit = ()
        let v238 : (unit -> unit) = closure2(v225, v229)
        let v239 : unit = (fun () -> v238 (); v237) ()
        let v247 : string = "name"
        let v248 : string = $"{v247}"
        let v256 : unit = ()
        let v257 : (unit -> unit) = closure2(v225, v248)
        let v258 : unit = (fun () -> v257 (); v256) ()
        let v266 : string = " = "
        let v267 : string = $"{v266}"
        let v275 : unit = ()
        let v276 : (unit -> unit) = closure2(v225, v267)
        let v277 : unit = (fun () -> v276 (); v275) ()
        let v285 : string = "__assert_lt"
        let v286 : string = $"{v285}"
        let v294 : unit = ()
        let v295 : (unit -> unit) = closure2(v225, v286)
        let v296 : unit = (fun () -> v295 (); v294) ()
        let v304 : string = "; "
        let v305 : string = $"{v304}"
        let v313 : unit = ()
        let v314 : (unit -> unit) = closure2(v225, v305)
        let v315 : unit = (fun () -> v314 (); v313) ()
        let v323 : string = "actual"
        let v324 : string = $"{v323}"
        let v332 : unit = ()
        let v333 : (unit -> unit) = closure2(v225, v324)
        let v334 : unit = (fun () -> v333 (); v332) ()
        let v341 : string = $"{v266}"
        let v349 : unit = ()
        let v350 : (unit -> unit) = closure2(v225, v341)
        let v351 : unit = (fun () -> v350 (); v349) ()
        let v361 : string = $"%+.6f{v220}"
        let v369 : unit = ()
        let v370 : (unit -> unit) = closure2(v225, v361)
        let v371 : unit = (fun () -> v370 (); v369) ()
        let v378 : string = $"{v304}"
        let v386 : unit = ()
        let v387 : (unit -> unit) = closure2(v225, v378)
        let v388 : unit = (fun () -> v387 (); v386) ()
        let v396 : string = "expected"
        let v397 : string = $"{v396}"
        let v405 : unit = ()
        let v406 : (unit -> unit) = closure2(v225, v397)
        let v407 : unit = (fun () -> v406 (); v405) ()
        let v414 : string = $"{v266}"
        let v422 : unit = ()
        let v423 : (unit -> unit) = closure2(v225, v414)
        let v424 : unit = (fun () -> v423 (); v422) ()
        let v434 : string = $"%+.6f{0.0001}"
        let v442 : unit = ()
        let v443 : (unit -> unit) = closure2(v225, v434)
        let v444 : unit = (fun () -> v443 (); v442) ()
        let v452 : string = " }"
        let v453 : string = $"{v452}"
        let v461 : unit = ()
        let v462 : (unit -> unit) = closure2(v225, v453)
        let v463 : unit = (fun () -> v462 (); v461) ()
        let v469 : string = v225.l0
        let v471 : unit = ()
        let v472 : (unit -> unit) = closure3(v469)
        let v473 : unit = (fun () -> v472 (); v471) ()
        let v475 : bool = v223 = false
        if v475 then
            failwith<unit> v469
        let v476 : string = "$0.im"
        let v477 : float = Fable.Core.RustInterop.emitRustExpr v59 v476 
        let v478 : string = "$0.im"
        let v479 : float = Fable.Core.RustInterop.emitRustExpr v212 v478 
        let v480 : float = v477 - v479
        let v481 : float =  -v480
        let v482 : bool = v480 >= v481
        let v483 : float =
            if v482 then
                v480
            else
                v481
        let v484 : bool = v483 < 0.0001
        let v486 : bool =
            if v484 then
                true
            else
                method18(v484)
        let v487 : string = method19()
        let v488 : Mut3 = {l0 = v487} : Mut3
        let v490 : string = $"{v228}"
        let v498 : unit = ()
        let v499 : (unit -> unit) = closure2(v488, v490)
        let v500 : unit = (fun () -> v499 (); v498) ()
        let v507 : string = $"{v247}"
        let v515 : unit = ()
        let v516 : (unit -> unit) = closure2(v488, v507)
        let v517 : unit = (fun () -> v516 (); v515) ()
        let v524 : string = $"{v266}"
        let v532 : unit = ()
        let v533 : (unit -> unit) = closure2(v488, v524)
        let v534 : unit = (fun () -> v533 (); v532) ()
        let v541 : string = $"{v285}"
        let v549 : unit = ()
        let v550 : (unit -> unit) = closure2(v488, v541)
        let v551 : unit = (fun () -> v550 (); v549) ()
        let v558 : string = $"{v304}"
        let v566 : unit = ()
        let v567 : (unit -> unit) = closure2(v488, v558)
        let v568 : unit = (fun () -> v567 (); v566) ()
        let v575 : string = $"{v323}"
        let v583 : unit = ()
        let v584 : (unit -> unit) = closure2(v488, v575)
        let v585 : unit = (fun () -> v584 (); v583) ()
        let v592 : string = $"{v266}"
        let v600 : unit = ()
        let v601 : (unit -> unit) = closure2(v488, v592)
        let v602 : unit = (fun () -> v601 (); v600) ()
        let v612 : string = $"%+.6f{v483}"
        let v620 : unit = ()
        let v621 : (unit -> unit) = closure2(v488, v612)
        let v622 : unit = (fun () -> v621 (); v620) ()
        let v629 : string = $"{v304}"
        let v637 : unit = ()
        let v638 : (unit -> unit) = closure2(v488, v629)
        let v639 : unit = (fun () -> v638 (); v637) ()
        let v646 : string = $"{v396}"
        let v654 : unit = ()
        let v655 : (unit -> unit) = closure2(v488, v646)
        let v656 : unit = (fun () -> v655 (); v654) ()
        let v663 : string = $"{v266}"
        let v671 : unit = ()
        let v672 : (unit -> unit) = closure2(v488, v663)
        let v673 : unit = (fun () -> v672 (); v671) ()
        let v683 : string = $"%+.6f{0.0001}"
        let v691 : unit = ()
        let v692 : (unit -> unit) = closure2(v488, v683)
        let v693 : unit = (fun () -> v692 (); v691) ()
        let v700 : string = $"{v452}"
        let v708 : unit = ()
        let v709 : (unit -> unit) = closure2(v488, v700)
        let v710 : unit = (fun () -> v709 (); v708) ()
        let v716 : string = v488.l0
        let v718 : unit = ()
        let v719 : (unit -> unit) = closure3(v716)
        let v720 : unit = (fun () -> v719 (); v718) ()
        let v722 : bool = v486 = false
        if v722 then
            failwith<unit> v716
        method48(v0, v3)
    | UH1_0 -> (* Nil *)
        ()
and method46 (v0 : pyo3_Python) : unit =
    let v1 : UH1 = method47()
    method48(v0, v1)
and method45 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method46(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method20(v5)
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
    let v25 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr () v25 
    let v27 : string = "__run_test"
    let v28 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v27 
    (* run_target_args'
    let v29 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v30 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method51 () : UH0 =
    let v0 : UH0 = UH0_0
    let v1 : UH0 = UH0_1(5.0, v0)
    let v2 : UH0 = UH0_1(4.5, v1)
    let v3 : UH0 = UH0_1(4.0, v2)
    let v4 : UH0 = UH0_1(3.5, v3)
    let v5 : UH0 = UH0_1(3.0, v4)
    let v6 : UH0 = UH0_1(2.5, v5)
    UH0_1(2.0, v6)
and method52 () : UH0 =
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
and method54 (v0 : float, v1 : UH0, v2 : float) : float =
    match v1 with
    | UH0_1(v3, v4) -> (* Cons *)
        let v5 : float =  -v0
        let v6 : float = v3 ** v5
        let v7 : float = 1.0 - v6
        let v8 : float = v2 / v7
        method54(v0, v4, v8)
    | UH0_0 -> (* Nil *)
        v2
and method53 (v0 : pyo3_Python, v1 : UH0, v2 : UH0) : unit =
    match v2 with
    | UH0_1(v3, v4) -> (* Cons *)
        let v5 : string = "num_complex::Complex::new($0, $1)"
        let v6 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v3, 0.0) v5 
        let v7 : float = 1.0
        let v8 : float = method54(v3, v1, v7)
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
        let v51 : US0 = US0_1
        let v52 : US0 = v31 |> Option.defaultValue v51 
        let v56 : string = "f64::NAN"
        let v57 : float = Fable.Core.RustInterop.emitRustExpr () v56 
        let v58 : string = "f64::NAN"
        let v59 : float = Fable.Core.RustInterop.emitRustExpr () v58 
        let v60 : string = "num_complex::Complex::new($0, $1)"
        let v61 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v57, v59) v60 
        let v64 : num_complex_Complex<float> =
            match v52 with
            | US0_1 -> (* None *)
                v61
            | US0_0(v62) -> (* Some *)
                v62
        let v65 : string = "$0.re"
        let v66 : float = Fable.Core.RustInterop.emitRustExpr v64 v65 
        let v67 : float = v66 - v8
        let v68 : float =  -v67
        let v69 : bool = v67 >= v68
        let v70 : float =
            if v69 then
                v67
            else
                v68
        let v71 : bool = v70 < 0.01
        let v73 : bool =
            if v71 then
                true
            else
                method18(v71)
        let v74 : string = method19()
        let v75 : Mut3 = {l0 = v74} : Mut3
        let v78 : string = "{ "
        let v79 : string = $"{v78}"
        let v87 : unit = ()
        let v88 : (unit -> unit) = closure2(v75, v79)
        let v89 : unit = (fun () -> v88 (); v87) ()
        let v97 : string = "name"
        let v98 : string = $"{v97}"
        let v106 : unit = ()
        let v107 : (unit -> unit) = closure2(v75, v98)
        let v108 : unit = (fun () -> v107 (); v106) ()
        let v116 : string = " = "
        let v117 : string = $"{v116}"
        let v125 : unit = ()
        let v126 : (unit -> unit) = closure2(v75, v117)
        let v127 : unit = (fun () -> v126 (); v125) ()
        let v135 : string = "__assert_lt"
        let v136 : string = $"{v135}"
        let v144 : unit = ()
        let v145 : (unit -> unit) = closure2(v75, v136)
        let v146 : unit = (fun () -> v145 (); v144) ()
        let v154 : string = "; "
        let v155 : string = $"{v154}"
        let v163 : unit = ()
        let v164 : (unit -> unit) = closure2(v75, v155)
        let v165 : unit = (fun () -> v164 (); v163) ()
        let v173 : string = "actual"
        let v174 : string = $"{v173}"
        let v182 : unit = ()
        let v183 : (unit -> unit) = closure2(v75, v174)
        let v184 : unit = (fun () -> v183 (); v182) ()
        let v191 : string = $"{v116}"
        let v199 : unit = ()
        let v200 : (unit -> unit) = closure2(v75, v191)
        let v201 : unit = (fun () -> v200 (); v199) ()
        let v211 : string = $"%+.6f{v70}"
        let v219 : unit = ()
        let v220 : (unit -> unit) = closure2(v75, v211)
        let v221 : unit = (fun () -> v220 (); v219) ()
        let v228 : string = $"{v154}"
        let v236 : unit = ()
        let v237 : (unit -> unit) = closure2(v75, v228)
        let v238 : unit = (fun () -> v237 (); v236) ()
        let v246 : string = "expected"
        let v247 : string = $"{v246}"
        let v255 : unit = ()
        let v256 : (unit -> unit) = closure2(v75, v247)
        let v257 : unit = (fun () -> v256 (); v255) ()
        let v264 : string = $"{v116}"
        let v272 : unit = ()
        let v273 : (unit -> unit) = closure2(v75, v264)
        let v274 : unit = (fun () -> v273 (); v272) ()
        let v284 : string = $"%+.6f{0.01}"
        let v292 : unit = ()
        let v293 : (unit -> unit) = closure2(v75, v284)
        let v294 : unit = (fun () -> v293 (); v292) ()
        let v302 : string = " }"
        let v303 : string = $"{v302}"
        let v311 : unit = ()
        let v312 : (unit -> unit) = closure2(v75, v303)
        let v313 : unit = (fun () -> v312 (); v311) ()
        let v319 : string = v75.l0
        let v321 : unit = ()
        let v322 : (unit -> unit) = closure3(v319)
        let v323 : unit = (fun () -> v322 (); v321) ()
        let v325 : bool = v73 = false
        if v325 then
            failwith<unit> v319
        let v326 : string = "$0.im"
        let v327 : float = Fable.Core.RustInterop.emitRustExpr v64 v326 
        let v328 : bool = v327 < 0.01
        let v330 : bool =
            if v328 then
                true
            else
                method18(v328)
        let v331 : string = method19()
        let v332 : Mut3 = {l0 = v331} : Mut3
        let v334 : string = $"{v78}"
        let v342 : unit = ()
        let v343 : (unit -> unit) = closure2(v332, v334)
        let v344 : unit = (fun () -> v343 (); v342) ()
        let v351 : string = $"{v97}"
        let v359 : unit = ()
        let v360 : (unit -> unit) = closure2(v332, v351)
        let v361 : unit = (fun () -> v360 (); v359) ()
        let v368 : string = $"{v116}"
        let v376 : unit = ()
        let v377 : (unit -> unit) = closure2(v332, v368)
        let v378 : unit = (fun () -> v377 (); v376) ()
        let v385 : string = $"{v135}"
        let v393 : unit = ()
        let v394 : (unit -> unit) = closure2(v332, v385)
        let v395 : unit = (fun () -> v394 (); v393) ()
        let v402 : string = $"{v154}"
        let v410 : unit = ()
        let v411 : (unit -> unit) = closure2(v332, v402)
        let v412 : unit = (fun () -> v411 (); v410) ()
        let v419 : string = $"{v173}"
        let v427 : unit = ()
        let v428 : (unit -> unit) = closure2(v332, v419)
        let v429 : unit = (fun () -> v428 (); v427) ()
        let v436 : string = $"{v116}"
        let v444 : unit = ()
        let v445 : (unit -> unit) = closure2(v332, v436)
        let v446 : unit = (fun () -> v445 (); v444) ()
        let v456 : string = $"%+.6f{v327}"
        let v464 : unit = ()
        let v465 : (unit -> unit) = closure2(v332, v456)
        let v466 : unit = (fun () -> v465 (); v464) ()
        let v473 : string = $"{v154}"
        let v481 : unit = ()
        let v482 : (unit -> unit) = closure2(v332, v473)
        let v483 : unit = (fun () -> v482 (); v481) ()
        let v490 : string = $"{v246}"
        let v498 : unit = ()
        let v499 : (unit -> unit) = closure2(v332, v490)
        let v500 : unit = (fun () -> v499 (); v498) ()
        let v507 : string = $"{v116}"
        let v515 : unit = ()
        let v516 : (unit -> unit) = closure2(v332, v507)
        let v517 : unit = (fun () -> v516 (); v515) ()
        let v527 : string = $"%+.6f{0.01}"
        let v535 : unit = ()
        let v536 : (unit -> unit) = closure2(v332, v527)
        let v537 : unit = (fun () -> v536 (); v535) ()
        let v544 : string = $"{v302}"
        let v552 : unit = ()
        let v553 : (unit -> unit) = closure2(v332, v544)
        let v554 : unit = (fun () -> v553 (); v552) ()
        let v560 : string = v332.l0
        let v562 : unit = ()
        let v563 : (unit -> unit) = closure3(v560)
        let v564 : unit = (fun () -> v563 (); v562) ()
        let v566 : bool = v330 = false
        if v566 then
            failwith<unit> v560
        method53(v0, v1, v4)
    | UH0_0 -> (* Nil *)
        ()
and method50 (v0 : pyo3_Python) : unit =
    let v1 : UH0 = method51()
    let v2 : UH0 = method52()
    method53(v0, v2, v1)
and method49 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method50(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method20(v5)
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
    let v25 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr () v25 
    let v27 : string = "__run_test"
    let v28 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v27 
    (* run_target_args'
    let v29 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v30 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v28 v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v28 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
    method21()
    let v10 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v10 
    let v11 : string = "test_trivial_zero_at_negative_even___"
    let v12 : string = $"*/ #[test] fn " + v11 + "() { //"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    method23()
    let v14 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v14 
    let v15 : string = "test_non_trivial_zero___"
    let v16 : string = $"*/ #[test] fn " + v15 + "() { //"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr () v16 
    method27()
    let v18 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v18 
    let v19 : string = "test_real_part_greater_than_one___"
    let v20 : string = $"*/ #[test] fn " + v19 + "() { //"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr () v20 
    method29()
    let v22 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v22 
    let v23 : string = "test_zeta_at_1___"
    let v24 : string = $"*/ #[test] fn " + v23 + "() { //"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr () v24 
    method31()
    let v26 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v26 
    let v27 : string = "test_symmetry_across_real_axis___"
    let v28 : string = $"*/ #[test] fn " + v27 + "() { //"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr () v28 
    method33()
    let v30 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v30 
    let v31 : string = "test_behavior_near_origin___"
    let v32 : string = $"*/ #[test] fn " + v31 + "() { //"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32 
    method35()
    let v34 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v34 
    let v35 : string = "test_imaginary_axis"
    let v36 : string = $"*/ #[test] fn " + v35 + "() { //"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr () v36 
    method37()
    let v38 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v38 
    let v39 : string = "test_critical_strip"
    let v40 : string = $"*/ #[test] fn " + v39 + "() { //"
    let v41 : bool = Fable.Core.RustInterop.emitRustExpr () v40 
    method41()
    let v42 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v42 
    let v43 : string = "test_reflection_formula_for_specific_value"
    let v44 : string = $"*/ #[test] fn " + v43 + "() { //"
    let v45 : bool = Fable.Core.RustInterop.emitRustExpr () v44 
    method45()
    let v46 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v46 
    let v47 : string = "test_euler_product_formula"
    let v48 : string = $"*/ #[test] fn " + v47 + "() { //"
    let v49 : bool = Fable.Core.RustInterop.emitRustExpr () v48 
    method49()
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
and closure4 () (v0 : (string [])) : int32 =
    let v1 : string = $"value: {1}"
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure3(v1)
    let v5 : unit = (fun () -> v4 (); v3) ()
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure4()
let main args = v1 args
()
