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
[<Fable.Core.Erase; Fable.Core.Emit("pyo3::PyErr")>]
#endif
type pyo3_PyErr = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
type std_string_String = class end
#else
type std_string_String = string
#endif

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
    let v41 : (float * float) = v38, v40 
    let v42 : (bool * (float * float)) = false, v41 
    let v43 : pyo3_Python = method7(v0)
    let v44 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v45 : string = "&*$0"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v45 
    let _v44 = v46 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : string = "&*$0"
    let v48 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v47 
    let _v44 = v48 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v49 : string = "&*$0"
    let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v49 
    let _v44 = v50 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v51 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _v44 = v51 
    #endif
#if FABLE_COMPILER_PYTHON
    let v54 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _v44 = v54 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v57 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _v44 = v57 
    #endif
#else
    let v60 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _v44 = v60 
    #endif
    let v63 : Ref<Str> = _v44 
    let v68 : string = "pyo3::types::PyModule::from_code_bound(v43, $0, \"\", \"\")"
    let v69 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v63 v68 
    let v70 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v71 : bool = Fable.Core.RustInterop.emitRustExpr v69 v70 
    let v72 : string = "x"
    let v73 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v75 : string = "format!(\"{}\", $0)"
    let v76 : std_string_String = Fable.Core.RustInterop.emitRustExpr v73 v75 
    let _v74 = v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : string = "format!(\"{}\", $0)"
    let v78 : std_string_String = Fable.Core.RustInterop.emitRustExpr v73 v77 
    let _v74 = v78 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v79 : string = "format!(\"{}\", $0)"
    let v80 : std_string_String = Fable.Core.RustInterop.emitRustExpr v73 v79 
    let _v74 = v80 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : std_string_String = null |> unbox<std_string_String>
    let _v74 = v81 
    #endif
#if FABLE_COMPILER_PYTHON
    let v84 : std_string_String = null |> unbox<std_string_String>
    let _v74 = v84 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v87 : std_string_String = null |> unbox<std_string_String>
    let _v74 = v87 
    #endif
#else
    let v90 : std_string_String = null |> unbox<std_string_String>
    let _v74 = v90 
    #endif
    let v93 : std_string_String = _v74 
    let v98 : string = "true; $0 })"
    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v93 v98 
    let v100 : string = "_result_map_error__"
    let v101 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v100 
    let v102 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v103 : string = "$0.unwrap()"
    let v104 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v101 v103 
    let _v102 = v104 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v105 : string = "$0.unwrap()"
    let v106 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v101 v105 
    let _v102 = v106 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v107 : string = "$0.unwrap()"
    let v108 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v101 v107 
    let _v102 = v108 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v109 : pyo3_Bound<pyo3_types_PyModule> = match v101 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v102 = v109 
    #endif
#if FABLE_COMPILER_PYTHON
    let v110 : pyo3_Bound<pyo3_types_PyModule> = match v101 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v102 = v110 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v111 : pyo3_Bound<pyo3_types_PyModule> = match v101 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v102 = v111 
    #endif
#else
    let v112 : pyo3_Bound<pyo3_types_PyModule> = match v101 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v102 = v112 
    #endif
    let v113 : pyo3_Bound<pyo3_types_PyModule> = _v102 
    let v116 : string = method8()
    let v117 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v118 : string = "&*$0"
    let v119 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v116 v118 
    let _v117 = v119 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v120 : string = "&*$0"
    let v121 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v116 v120 
    let _v117 = v121 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v122 : string = "&*$0"
    let v123 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v116 v122 
    let _v117 = v123 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v124 : Ref<Str> = v116 |> unbox<Ref<Str>>
    let _v117 = v124 
    #endif
#if FABLE_COMPILER_PYTHON
    let v127 : Ref<Str> = v116 |> unbox<Ref<Str>>
    let _v117 = v127 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v130 : Ref<Str> = v116 |> unbox<Ref<Str>>
    let _v117 = v130 
    #endif
#else
    let v133 : Ref<Str> = v116 |> unbox<Ref<Str>>
    let _v117 = v133 
    #endif
    let v136 : Ref<Str> = _v117 
    let v141 : pyo3_Bound<pyo3_types_PyModule> = method9(v113)
    let v142 : string = "v141.getattr($0)"
    let v143 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v136 v142 
    let v144 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v145 : bool = Fable.Core.RustInterop.emitRustExpr v143 v144 
    let v146 : string = "x"
    let v147 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v146 
    let v148 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v149 : string = "format!(\"{}\", $0)"
    let v150 : std_string_String = Fable.Core.RustInterop.emitRustExpr v147 v149 
    let _v148 = v150 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v151 : string = "format!(\"{}\", $0)"
    let v152 : std_string_String = Fable.Core.RustInterop.emitRustExpr v147 v151 
    let _v148 = v152 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v153 : string = "format!(\"{}\", $0)"
    let v154 : std_string_String = Fable.Core.RustInterop.emitRustExpr v147 v153 
    let _v148 = v154 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v155 : std_string_String = null |> unbox<std_string_String>
    let _v148 = v155 
    #endif
#if FABLE_COMPILER_PYTHON
    let v158 : std_string_String = null |> unbox<std_string_String>
    let _v148 = v158 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v161 : std_string_String = null |> unbox<std_string_String>
    let _v148 = v161 
    #endif
#else
    let v164 : std_string_String = null |> unbox<std_string_String>
    let _v148 = v164 
    #endif
    let v167 : std_string_String = _v148 
    let v172 : string = "true; $0 })"
    let v173 : bool = Fable.Core.RustInterop.emitRustExpr v167 v172 
    let v174 : string = "_result_map_error__"
    let v175 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v174 
    let v176 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v177 : string = "$0.unwrap()"
    let v178 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v175 v177 
    let _v176 = v178 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v179 : string = "$0.unwrap()"
    let v180 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v175 v179 
    let _v176 = v180 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v181 : string = "$0.unwrap()"
    let v182 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v175 v181 
    let _v176 = v182 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v183 : pyo3_Bound<pyo3_PyAny> = match v175 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v176 = v183 
    #endif
#if FABLE_COMPILER_PYTHON
    let v184 : pyo3_Bound<pyo3_PyAny> = match v175 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v176 = v184 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v185 : pyo3_Bound<pyo3_PyAny> = match v175 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v176 = v185 
    #endif
#else
    let v186 : pyo3_Bound<pyo3_PyAny> = match v175 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v176 = v186 
    #endif
    let v187 : pyo3_Bound<pyo3_PyAny> = _v176 
    let v190 : (bool * (float * float)) = method10(v42)
    let v191 : pyo3_Bound<pyo3_PyAny> = method11(v187)
    let v192 : string = "pyo3::prelude::PyAnyMethods::call(&v191, ((*v190).0, *(*v190).1), None)"
    let v193 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v192 
    let v194 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v195 : bool = Fable.Core.RustInterop.emitRustExpr v193 v194 
    let v196 : string = "x"
    let v197 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v196 
    let v198 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v199 : string = "format!(\"{}\", $0)"
    let v200 : std_string_String = Fable.Core.RustInterop.emitRustExpr v197 v199 
    let _v198 = v200 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v201 : string = "format!(\"{}\", $0)"
    let v202 : std_string_String = Fable.Core.RustInterop.emitRustExpr v197 v201 
    let _v198 = v202 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v203 : string = "format!(\"{}\", $0)"
    let v204 : std_string_String = Fable.Core.RustInterop.emitRustExpr v197 v203 
    let _v198 = v204 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v205 : std_string_String = null |> unbox<std_string_String>
    let _v198 = v205 
    #endif
#if FABLE_COMPILER_PYTHON
    let v208 : std_string_String = null |> unbox<std_string_String>
    let _v198 = v208 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v211 : std_string_String = null |> unbox<std_string_String>
    let _v198 = v211 
    #endif
#else
    let v214 : std_string_String = null |> unbox<std_string_String>
    let _v198 = v214 
    #endif
    let v217 : std_string_String = _v198 
    let v222 : string = "true; $0 })"
    let v223 : bool = Fable.Core.RustInterop.emitRustExpr v217 v222 
    let v224 : string = "_result_map_error__"
    let v225 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v224 
    let v226 : string = "$0?"
    let v227 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v225 v226 
    let v228 : pyo3_Bound<pyo3_PyAny> = method12(v227)
    let v229 : string = "v228.extract()"
    let v230 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v229 
    let v231 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v232 : bool = Fable.Core.RustInterop.emitRustExpr v230 v231 
    let v233 : string = "x"
    let v234 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v233 
    let v235 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v236 : string = "format!(\"{}\", $0)"
    let v237 : std_string_String = Fable.Core.RustInterop.emitRustExpr v234 v236 
    let _v235 = v237 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v238 : string = "format!(\"{}\", $0)"
    let v239 : std_string_String = Fable.Core.RustInterop.emitRustExpr v234 v238 
    let _v235 = v239 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v240 : string = "format!(\"{}\", $0)"
    let v241 : std_string_String = Fable.Core.RustInterop.emitRustExpr v234 v240 
    let _v235 = v241 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v242 : std_string_String = null |> unbox<std_string_String>
    let _v235 = v242 
    #endif
#if FABLE_COMPILER_PYTHON
    let v245 : std_string_String = null |> unbox<std_string_String>
    let _v235 = v245 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v248 : std_string_String = null |> unbox<std_string_String>
    let _v235 = v248 
    #endif
#else
    let v251 : std_string_String = null |> unbox<std_string_String>
    let _v235 = v251 
    #endif
    let v254 : std_string_String = _v235 
    let v259 : string = "true; $0 })"
    let v260 : bool = Fable.Core.RustInterop.emitRustExpr v254 v259 
    let v261 : string = "_result_map_error__"
    let v262 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v261 
    let v263 : string = "$0?"
    let struct (v264 : float, v265 : float) = Fable.Core.RustInterop.emitRustExpr v262 v263 
    let v266 : string = "num_complex::Complex::new($0, $1)"
    let v267 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v264, v265) v266 
    let v268 : Result<num_complex_Complex<float>, std_string_String> = Ok v267 
    v268
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
    let v41 : (float * float) = v38, v40 
    let v42 : (bool * (float * float)) = false, v41 
    let v43 : pyo3_Python = method7(v0)
    let v44 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v45 : string = "&*$0"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v45 
    let _v44 = v46 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : string = "&*$0"
    let v48 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v47 
    let _v44 = v48 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v49 : string = "&*$0"
    let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v49 
    let _v44 = v50 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v51 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _v44 = v51 
    #endif
#if FABLE_COMPILER_PYTHON
    let v54 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _v44 = v54 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v57 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _v44 = v57 
    #endif
#else
    let v60 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _v44 = v60 
    #endif
    let v63 : Ref<Str> = _v44 
    let v68 : string = "pyo3::types::PyModule::from_code_bound(v43, $0, \"\", \"\")"
    let v69 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v63 v68 
    let v70 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v71 : bool = Fable.Core.RustInterop.emitRustExpr v69 v70 
    let v72 : string = "x"
    let v73 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v75 : string = "format!(\"{}\", $0)"
    let v76 : std_string_String = Fable.Core.RustInterop.emitRustExpr v73 v75 
    let _v74 = v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : string = "format!(\"{}\", $0)"
    let v78 : std_string_String = Fable.Core.RustInterop.emitRustExpr v73 v77 
    let _v74 = v78 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v79 : string = "format!(\"{}\", $0)"
    let v80 : std_string_String = Fable.Core.RustInterop.emitRustExpr v73 v79 
    let _v74 = v80 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : std_string_String = null |> unbox<std_string_String>
    let _v74 = v81 
    #endif
#if FABLE_COMPILER_PYTHON
    let v84 : std_string_String = null |> unbox<std_string_String>
    let _v74 = v84 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v87 : std_string_String = null |> unbox<std_string_String>
    let _v74 = v87 
    #endif
#else
    let v90 : std_string_String = null |> unbox<std_string_String>
    let _v74 = v90 
    #endif
    let v93 : std_string_String = _v74 
    let v98 : string = "true; $0 })"
    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v93 v98 
    let v100 : string = "_result_map_error__"
    let v101 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v100 
    let v102 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v103 : string = "$0.unwrap()"
    let v104 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v101 v103 
    let _v102 = v104 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v105 : string = "$0.unwrap()"
    let v106 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v101 v105 
    let _v102 = v106 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v107 : string = "$0.unwrap()"
    let v108 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v101 v107 
    let _v102 = v108 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v109 : pyo3_Bound<pyo3_types_PyModule> = match v101 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v102 = v109 
    #endif
#if FABLE_COMPILER_PYTHON
    let v110 : pyo3_Bound<pyo3_types_PyModule> = match v101 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v102 = v110 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v111 : pyo3_Bound<pyo3_types_PyModule> = match v101 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v102 = v111 
    #endif
#else
    let v112 : pyo3_Bound<pyo3_types_PyModule> = match v101 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v102 = v112 
    #endif
    let v113 : pyo3_Bound<pyo3_types_PyModule> = _v102 
    let v116 : string = method8()
    let v117 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v118 : string = "&*$0"
    let v119 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v116 v118 
    let _v117 = v119 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v120 : string = "&*$0"
    let v121 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v116 v120 
    let _v117 = v121 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v122 : string = "&*$0"
    let v123 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v116 v122 
    let _v117 = v123 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v124 : Ref<Str> = v116 |> unbox<Ref<Str>>
    let _v117 = v124 
    #endif
#if FABLE_COMPILER_PYTHON
    let v127 : Ref<Str> = v116 |> unbox<Ref<Str>>
    let _v117 = v127 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v130 : Ref<Str> = v116 |> unbox<Ref<Str>>
    let _v117 = v130 
    #endif
#else
    let v133 : Ref<Str> = v116 |> unbox<Ref<Str>>
    let _v117 = v133 
    #endif
    let v136 : Ref<Str> = _v117 
    let v141 : pyo3_Bound<pyo3_types_PyModule> = method9(v113)
    let v142 : string = "v141.getattr($0)"
    let v143 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v136 v142 
    let v144 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v145 : bool = Fable.Core.RustInterop.emitRustExpr v143 v144 
    let v146 : string = "x"
    let v147 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v146 
    let v148 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v149 : string = "format!(\"{}\", $0)"
    let v150 : std_string_String = Fable.Core.RustInterop.emitRustExpr v147 v149 
    let _v148 = v150 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v151 : string = "format!(\"{}\", $0)"
    let v152 : std_string_String = Fable.Core.RustInterop.emitRustExpr v147 v151 
    let _v148 = v152 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v153 : string = "format!(\"{}\", $0)"
    let v154 : std_string_String = Fable.Core.RustInterop.emitRustExpr v147 v153 
    let _v148 = v154 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v155 : std_string_String = null |> unbox<std_string_String>
    let _v148 = v155 
    #endif
#if FABLE_COMPILER_PYTHON
    let v158 : std_string_String = null |> unbox<std_string_String>
    let _v148 = v158 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v161 : std_string_String = null |> unbox<std_string_String>
    let _v148 = v161 
    #endif
#else
    let v164 : std_string_String = null |> unbox<std_string_String>
    let _v148 = v164 
    #endif
    let v167 : std_string_String = _v148 
    let v172 : string = "true; $0 })"
    let v173 : bool = Fable.Core.RustInterop.emitRustExpr v167 v172 
    let v174 : string = "_result_map_error__"
    let v175 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v174 
    let v176 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v177 : string = "$0.unwrap()"
    let v178 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v175 v177 
    let _v176 = v178 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v179 : string = "$0.unwrap()"
    let v180 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v175 v179 
    let _v176 = v180 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v181 : string = "$0.unwrap()"
    let v182 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v175 v181 
    let _v176 = v182 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v183 : pyo3_Bound<pyo3_PyAny> = match v175 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v176 = v183 
    #endif
#if FABLE_COMPILER_PYTHON
    let v184 : pyo3_Bound<pyo3_PyAny> = match v175 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v176 = v184 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v185 : pyo3_Bound<pyo3_PyAny> = match v175 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v176 = v185 
    #endif
#else
    let v186 : pyo3_Bound<pyo3_PyAny> = match v175 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v176 = v186 
    #endif
    let v187 : pyo3_Bound<pyo3_PyAny> = _v176 
    let v190 : (bool * (float * float)) = method10(v42)
    let v191 : pyo3_Bound<pyo3_PyAny> = method11(v187)
    let v192 : string = "pyo3::prelude::PyAnyMethods::call(&v191, ((*v190).0, *(*v190).1), None)"
    let v193 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v192 
    let v194 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v195 : bool = Fable.Core.RustInterop.emitRustExpr v193 v194 
    let v196 : string = "x"
    let v197 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v196 
    let v198 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v199 : string = "format!(\"{}\", $0)"
    let v200 : std_string_String = Fable.Core.RustInterop.emitRustExpr v197 v199 
    let _v198 = v200 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v201 : string = "format!(\"{}\", $0)"
    let v202 : std_string_String = Fable.Core.RustInterop.emitRustExpr v197 v201 
    let _v198 = v202 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v203 : string = "format!(\"{}\", $0)"
    let v204 : std_string_String = Fable.Core.RustInterop.emitRustExpr v197 v203 
    let _v198 = v204 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v205 : std_string_String = null |> unbox<std_string_String>
    let _v198 = v205 
    #endif
#if FABLE_COMPILER_PYTHON
    let v208 : std_string_String = null |> unbox<std_string_String>
    let _v198 = v208 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v211 : std_string_String = null |> unbox<std_string_String>
    let _v198 = v211 
    #endif
#else
    let v214 : std_string_String = null |> unbox<std_string_String>
    let _v198 = v214 
    #endif
    let v217 : std_string_String = _v198 
    let v222 : string = "true; $0 })"
    let v223 : bool = Fable.Core.RustInterop.emitRustExpr v217 v222 
    let v224 : string = "_result_map_error__"
    let v225 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v224 
    let v226 : string = "$0?"
    let v227 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v225 v226 
    let v228 : pyo3_Bound<pyo3_PyAny> = method12(v227)
    let v229 : string = "v228.extract()"
    let v230 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v229 
    let v231 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v232 : bool = Fable.Core.RustInterop.emitRustExpr v230 v231 
    let v233 : string = "x"
    let v234 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v233 
    let v235 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v236 : string = "format!(\"{}\", $0)"
    let v237 : std_string_String = Fable.Core.RustInterop.emitRustExpr v234 v236 
    let _v235 = v237 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v238 : string = "format!(\"{}\", $0)"
    let v239 : std_string_String = Fable.Core.RustInterop.emitRustExpr v234 v238 
    let _v235 = v239 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v240 : string = "format!(\"{}\", $0)"
    let v241 : std_string_String = Fable.Core.RustInterop.emitRustExpr v234 v240 
    let _v235 = v241 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v242 : std_string_String = null |> unbox<std_string_String>
    let _v235 = v242 
    #endif
#if FABLE_COMPILER_PYTHON
    let v245 : std_string_String = null |> unbox<std_string_String>
    let _v235 = v245 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v248 : std_string_String = null |> unbox<std_string_String>
    let _v235 = v248 
    #endif
#else
    let v251 : std_string_String = null |> unbox<std_string_String>
    let _v235 = v251 
    #endif
    let v254 : std_string_String = _v235 
    let v259 : string = "true; $0 })"
    let v260 : bool = Fable.Core.RustInterop.emitRustExpr v254 v259 
    let v261 : string = "_result_map_error__"
    let v262 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v261 
    let v263 : string = "$0?"
    let struct (v264 : float, v265 : float) = Fable.Core.RustInterop.emitRustExpr v262 v263 
    let v266 : string = "num_complex::Complex::new($0, $1)"
    let v267 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v264, v265) v266 
    let v268 : Result<num_complex_Complex<float>, std_string_String> = Ok v267 
    v268
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
        let v39 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v37, v38)
        let v40 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v41 : string = "$0.ok()"
        let v42 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v39 v41 
        let _v40 = v42 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v43 : string = "$0.ok()"
        let v44 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v39 v43 
        let _v40 = v44 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v45 : string = "$0.ok()"
        let v46 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v39 v45 
        let _v40 = v46 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v47 : num_complex_Complex<float> option = match v39 with Ok x -> Some x | Error _ -> None
        let _v40 = v47 
        #endif
#if FABLE_COMPILER_PYTHON
        let v48 : num_complex_Complex<float> option = match v39 with Ok x -> Some x | Error _ -> None
        let _v40 = v48 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v49 : num_complex_Complex<float> option = match v39 with Ok x -> Some x | Error _ -> None
        let _v40 = v49 
        #endif
#else
        let v50 : num_complex_Complex<float> option = match v39 with Ok x -> Some x | Error _ -> None
        let _v40 = v50 
        #endif
        let v51 : num_complex_Complex<float> option = _v40 
        let v54 : (num_complex_Complex<float> -> US0) = method17()
        let v55 : US0 option = v51 |> Option.map v54 
        let v66 : US0 = US0_1
        let v67 : US0 = v55 |> Option.defaultValue v66 
        let v71 : string = "f64::NAN"
        let v72 : float = Fable.Core.RustInterop.emitRustExpr () v71 
        let v73 : string = "f64::NAN"
        let v74 : float = Fable.Core.RustInterop.emitRustExpr () v73 
        let v75 : string = "num_complex::Complex::new($0, $1)"
        let v76 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v72, v74) v75 
        let v79 : num_complex_Complex<float> =
            match v67 with
            | US0_1 -> (* None *)
                v76
            | US0_0(v77) -> (* Some *)
                v77
        let v80 : string = "num_complex::Complex::new($0, $1)"
        let v81 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v80 
        let v82 : string = "$0 * $1"
        let v83 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v81, v1) v82 
        let v84 : string = "num_complex::Complex::new($0, $1)"
        let v85 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v84 
        let v86 : string = "$0 / $1"
        let v87 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v83, v85) v86 
        let v88 : string = "$0.sin()"
        let v89 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v87 v88 
        let v90 : string = "$0.re"
        let v91 : float = Fable.Core.RustInterop.emitRustExpr v1 v90 
        let v92 : float = 1.0 - v91
        let v93 : string = "$0.im"
        let v94 : float = Fable.Core.RustInterop.emitRustExpr v1 v93 
        let v95 : float =  -v94
        let v96 : string = "num_complex::Complex::new($0, $1)"
        let v97 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v92, v95) v96 
        let v98 : string = "$0.re"
        let v99 : float = Fable.Core.RustInterop.emitRustExpr v97 v98 
        let v100 : bool = v99 <= 1.0
        let v571 : num_complex_Complex<float> =
            if v100 then
                let v101 : string = "num_complex::Complex::new($0, $1)"
                let v102 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v101 
                v102
            else
                let v103 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                Fable.Core.RustInterop.emitRustExpr struct (1, v97) v103 
                let v104 : string = "$0.re"
                let v105 : float = Fable.Core.RustInterop.emitRustExpr v97 v104 
                let v106 : bool = v105 > 1.0
                if v106 then
                    let v107 : string = "num_complex::Complex::new($0, $1)"
                    let v108 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v107 
                    let v109 : (int32 []) = Array.zeroCreate<int32> (10000)
                    let v110 : Mut0 = {l0 = 0} : Mut0
                    while method14(v110) do
                        let v112 : int32 = v110.l0
                        v109.[int v112] <- v112
                        let v113 : int32 = v112 + 1
                        v110.l0 <- v113
                        ()
                    let v114 : int32 = v109.Length
                    let v115 : Mut2 = {l0 = 0; l1 = v108} : Mut2
                    while method15(v114, v115) do
                        let v117 : int32 = v115.l0
                        let v118 : num_complex_Complex<float> = v115.l1
                        let v119 : int32 = v109.[int v117]
                        let v120 : string = "num_complex::Complex::new($0, $1)"
                        let v121 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v120 
                        let v122 : (int32 -> float) = float
                        let v123 : float = v122 v119
                        let v124 : string = "num_complex::Complex::new($0, $1)"
                        let v125 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v123, 0.0) v124 
                        let v126 : string = "num_complex::Complex::powc($0, $1)"
                        let v127 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v125, v97) v126 
                        let v128 : string = "$0 / $1"
                        let v129 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v121, v127) v128 
                        let v130 : string = "$0 + $1"
                        let v131 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v118, v129) v130 
                        let v132 : int32 = v117 + 1
                        v115.l0 <- v132
                        v115.l1 <- v131
                        ()
                    let v133 : num_complex_Complex<float> = v115.l1
                    v133
                else
                    let v134 : string = "num_complex::Complex::new($0, $1)"
                    let v135 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v134 
                    let v136 : string = "$0 - $1"
                    let v137 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v135, v97) v136 
                    let v138 : string = $"        s = mpmath.gamma(s)"
                    let v139 : num_complex_Complex<float> = method3(v137)
                    let v140 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v138, v139)
                    let v141 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v142 : string = "$0.ok()"
                    let v143 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v140 v142 
                    let _v141 = v143 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v144 : string = "$0.ok()"
                    let v145 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v140 v144 
                    let _v141 = v145 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v146 : string = "$0.ok()"
                    let v147 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v140 v146 
                    let _v141 = v147 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v148 : num_complex_Complex<float> option = match v140 with Ok x -> Some x | Error _ -> None
                    let _v141 = v148 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v149 : num_complex_Complex<float> option = match v140 with Ok x -> Some x | Error _ -> None
                    let _v141 = v149 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v150 : num_complex_Complex<float> option = match v140 with Ok x -> Some x | Error _ -> None
                    let _v141 = v150 
                    #endif
#else
                    let v151 : num_complex_Complex<float> option = match v140 with Ok x -> Some x | Error _ -> None
                    let _v141 = v151 
                    #endif
                    let v152 : num_complex_Complex<float> option = _v141 
                    let v155 : (num_complex_Complex<float> -> US0) = method17()
                    let v156 : US0 option = v152 |> Option.map v155 
                    let v167 : US0 = US0_1
                    let v168 : US0 = v156 |> Option.defaultValue v167 
                    let v172 : string = "f64::NAN"
                    let v173 : float = Fable.Core.RustInterop.emitRustExpr () v172 
                    let v174 : string = "f64::NAN"
                    let v175 : float = Fable.Core.RustInterop.emitRustExpr () v174 
                    let v176 : string = "num_complex::Complex::new($0, $1)"
                    let v177 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v173, v175) v176 
                    let v180 : num_complex_Complex<float> =
                        match v168 with
                        | US0_1 -> (* None *)
                            v177
                        | US0_0(v178) -> (* Some *)
                            v178
                    let v181 : string = "num_complex::Complex::new($0, $1)"
                    let v182 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v181 
                    let v183 : string = "$0 * $1"
                    let v184 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v182, v97) v183 
                    let v185 : string = "num_complex::Complex::new($0, $1)"
                    let v186 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v185 
                    let v187 : string = "$0 / $1"
                    let v188 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v184, v186) v187 
                    let v189 : string = "$0.sin()"
                    let v190 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v188 v189 
                    let v191 : string = "$0.re"
                    let v192 : float = Fable.Core.RustInterop.emitRustExpr v97 v191 
                    let v193 : float = 1.0 - v192
                    let v194 : string = "$0.im"
                    let v195 : float = Fable.Core.RustInterop.emitRustExpr v97 v194 
                    let v196 : float =  -v195
                    let v197 : string = "num_complex::Complex::new($0, $1)"
                    let v198 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v193, v196) v197 
                    let v199 : string = "$0.re"
                    let v200 : float = Fable.Core.RustInterop.emitRustExpr v198 v199 
                    let v201 : bool = v200 <= 1.0
                    let v555 : num_complex_Complex<float> =
                        if v201 then
                            let v202 : string = "num_complex::Complex::new($0, $1)"
                            let v203 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v202 
                            v203
                        else
                            let v204 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                            Fable.Core.RustInterop.emitRustExpr struct (2, v198) v204 
                            let v205 : string = "$0.re"
                            let v206 : float = Fable.Core.RustInterop.emitRustExpr v198 v205 
                            let v207 : bool = v206 > 1.0
                            if v207 then
                                let v208 : string = "num_complex::Complex::new($0, $1)"
                                let v209 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v208 
                                let v210 : (int32 []) = Array.zeroCreate<int32> (10000)
                                let v211 : Mut0 = {l0 = 0} : Mut0
                                while method14(v211) do
                                    let v213 : int32 = v211.l0
                                    v210.[int v213] <- v213
                                    let v214 : int32 = v213 + 1
                                    v211.l0 <- v214
                                    ()
                                let v215 : int32 = v210.Length
                                let v216 : Mut2 = {l0 = 0; l1 = v209} : Mut2
                                while method15(v215, v216) do
                                    let v218 : int32 = v216.l0
                                    let v219 : num_complex_Complex<float> = v216.l1
                                    let v220 : int32 = v210.[int v218]
                                    let v221 : string = "num_complex::Complex::new($0, $1)"
                                    let v222 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v221 
                                    let v223 : (int32 -> float) = float
                                    let v224 : float = v223 v220
                                    let v225 : string = "num_complex::Complex::new($0, $1)"
                                    let v226 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v224, 0.0) v225 
                                    let v227 : string = "num_complex::Complex::powc($0, $1)"
                                    let v228 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v226, v198) v227 
                                    let v229 : string = "$0 / $1"
                                    let v230 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v222, v228) v229 
                                    let v231 : string = "$0 + $1"
                                    let v232 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v219, v230) v231 
                                    let v233 : int32 = v218 + 1
                                    v216.l0 <- v233
                                    v216.l1 <- v232
                                    ()
                                let v234 : num_complex_Complex<float> = v216.l1
                                v234
                            else
                                let v235 : string = "num_complex::Complex::new($0, $1)"
                                let v236 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v235 
                                let v237 : string = "$0 - $1"
                                let v238 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v236, v198) v237 
                                let v239 : string = $"        s = mpmath.gamma(s)"
                                let v240 : num_complex_Complex<float> = method3(v238)
                                let v241 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v239, v240)
                                let v242 : unit = ()
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v243 : string = "$0.ok()"
                                let v244 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v241 v243 
                                let _v242 = v244 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v245 : string = "$0.ok()"
                                let v246 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v241 v245 
                                let _v242 = v246 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v247 : string = "$0.ok()"
                                let v248 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v241 v247 
                                let _v242 = v248 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v249 : num_complex_Complex<float> option = match v241 with Ok x -> Some x | Error _ -> None
                                let _v242 = v249 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v250 : num_complex_Complex<float> option = match v241 with Ok x -> Some x | Error _ -> None
                                let _v242 = v250 
                                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                                let v251 : num_complex_Complex<float> option = match v241 with Ok x -> Some x | Error _ -> None
                                let _v242 = v251 
                                #endif
#else
                                let v252 : num_complex_Complex<float> option = match v241 with Ok x -> Some x | Error _ -> None
                                let _v242 = v252 
                                #endif
                                let v253 : num_complex_Complex<float> option = _v242 
                                let v256 : (num_complex_Complex<float> -> US0) = method17()
                                let v257 : US0 option = v253 |> Option.map v256 
                                let v268 : US0 = US0_1
                                let v269 : US0 = v257 |> Option.defaultValue v268 
                                let v273 : string = "f64::NAN"
                                let v274 : float = Fable.Core.RustInterop.emitRustExpr () v273 
                                let v275 : string = "f64::NAN"
                                let v276 : float = Fable.Core.RustInterop.emitRustExpr () v275 
                                let v277 : string = "num_complex::Complex::new($0, $1)"
                                let v278 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v274, v276) v277 
                                let v281 : num_complex_Complex<float> =
                                    match v269 with
                                    | US0_1 -> (* None *)
                                        v278
                                    | US0_0(v279) -> (* Some *)
                                        v279
                                let v282 : string = "num_complex::Complex::new($0, $1)"
                                let v283 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v282 
                                let v284 : string = "$0 * $1"
                                let v285 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v283, v198) v284 
                                let v286 : string = "num_complex::Complex::new($0, $1)"
                                let v287 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v286 
                                let v288 : string = "$0 / $1"
                                let v289 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v285, v287) v288 
                                let v290 : string = "$0.sin()"
                                let v291 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v289 v290 
                                let v292 : string = "$0.re"
                                let v293 : float = Fable.Core.RustInterop.emitRustExpr v198 v292 
                                let v294 : float = 1.0 - v293
                                let v295 : string = "$0.im"
                                let v296 : float = Fable.Core.RustInterop.emitRustExpr v198 v295 
                                let v297 : float =  -v296
                                let v298 : string = "num_complex::Complex::new($0, $1)"
                                let v299 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v294, v297) v298 
                                let v300 : string = "$0.re"
                                let v301 : float = Fable.Core.RustInterop.emitRustExpr v299 v300 
                                let v302 : bool = v301 <= 1.0
                                let v539 : num_complex_Complex<float> =
                                    if v302 then
                                        let v303 : string = "num_complex::Complex::new($0, $1)"
                                        let v304 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v303 
                                        v304
                                    else
                                        let v305 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                        Fable.Core.RustInterop.emitRustExpr struct (3, v299) v305 
                                        let v306 : string = "$0.re"
                                        let v307 : float = Fable.Core.RustInterop.emitRustExpr v299 v306 
                                        let v308 : bool = v307 > 1.0
                                        if v308 then
                                            let v309 : string = "num_complex::Complex::new($0, $1)"
                                            let v310 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v309 
                                            let v311 : (int32 []) = Array.zeroCreate<int32> (10000)
                                            let v312 : Mut0 = {l0 = 0} : Mut0
                                            while method14(v312) do
                                                let v314 : int32 = v312.l0
                                                v311.[int v314] <- v314
                                                let v315 : int32 = v314 + 1
                                                v312.l0 <- v315
                                                ()
                                            let v316 : int32 = v311.Length
                                            let v317 : Mut2 = {l0 = 0; l1 = v310} : Mut2
                                            while method15(v316, v317) do
                                                let v319 : int32 = v317.l0
                                                let v320 : num_complex_Complex<float> = v317.l1
                                                let v321 : int32 = v311.[int v319]
                                                let v322 : string = "num_complex::Complex::new($0, $1)"
                                                let v323 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v322 
                                                let v324 : (int32 -> float) = float
                                                let v325 : float = v324 v321
                                                let v326 : string = "num_complex::Complex::new($0, $1)"
                                                let v327 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v325, 0.0) v326 
                                                let v328 : string = "num_complex::Complex::powc($0, $1)"
                                                let v329 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v327, v299) v328 
                                                let v330 : string = "$0 / $1"
                                                let v331 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v323, v329) v330 
                                                let v332 : string = "$0 + $1"
                                                let v333 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v320, v331) v332 
                                                let v334 : int32 = v319 + 1
                                                v317.l0 <- v334
                                                v317.l1 <- v333
                                                ()
                                            let v335 : num_complex_Complex<float> = v317.l1
                                            v335
                                        else
                                            let v336 : string = "num_complex::Complex::new($0, $1)"
                                            let v337 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v336 
                                            let v338 : string = "$0 - $1"
                                            let v339 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v337, v299) v338 
                                            let v340 : string = $"        s = mpmath.gamma(s)"
                                            let v341 : num_complex_Complex<float> = method3(v339)
                                            let v342 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v340, v341)
                                            let v343 : unit = ()
                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                            let v344 : string = "$0.ok()"
                                            let v345 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v342 v344 
                                            let _v343 = v345 
                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                            let v346 : string = "$0.ok()"
                                            let v347 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v342 v346 
                                            let _v343 = v347 
                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                            let v348 : string = "$0.ok()"
                                            let v349 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v342 v348 
                                            let _v343 = v349 
                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                            let v350 : num_complex_Complex<float> option = match v342 with Ok x -> Some x | Error _ -> None
                                            let _v343 = v350 
                                            #endif
#if FABLE_COMPILER_PYTHON
                                            let v351 : num_complex_Complex<float> option = match v342 with Ok x -> Some x | Error _ -> None
                                            let _v343 = v351 
                                            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                                            let v352 : num_complex_Complex<float> option = match v342 with Ok x -> Some x | Error _ -> None
                                            let _v343 = v352 
                                            #endif
#else
                                            let v353 : num_complex_Complex<float> option = match v342 with Ok x -> Some x | Error _ -> None
                                            let _v343 = v353 
                                            #endif
                                            let v354 : num_complex_Complex<float> option = _v343 
                                            let v357 : (num_complex_Complex<float> -> US0) = method17()
                                            let v358 : US0 option = v354 |> Option.map v357 
                                            let v369 : US0 = US0_1
                                            let v370 : US0 = v358 |> Option.defaultValue v369 
                                            let v374 : string = "f64::NAN"
                                            let v375 : float = Fable.Core.RustInterop.emitRustExpr () v374 
                                            let v376 : string = "f64::NAN"
                                            let v377 : float = Fable.Core.RustInterop.emitRustExpr () v376 
                                            let v378 : string = "num_complex::Complex::new($0, $1)"
                                            let v379 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v375, v377) v378 
                                            let v382 : num_complex_Complex<float> =
                                                match v370 with
                                                | US0_1 -> (* None *)
                                                    v379
                                                | US0_0(v380) -> (* Some *)
                                                    v380
                                            let v383 : string = "num_complex::Complex::new($0, $1)"
                                            let v384 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v383 
                                            let v385 : string = "$0 * $1"
                                            let v386 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v384, v299) v385 
                                            let v387 : string = "num_complex::Complex::new($0, $1)"
                                            let v388 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v387 
                                            let v389 : string = "$0 / $1"
                                            let v390 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v386, v388) v389 
                                            let v391 : string = "$0.sin()"
                                            let v392 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v390 v391 
                                            let v393 : string = "$0.re"
                                            let v394 : float = Fable.Core.RustInterop.emitRustExpr v299 v393 
                                            let v395 : float = 1.0 - v394
                                            let v396 : string = "$0.im"
                                            let v397 : float = Fable.Core.RustInterop.emitRustExpr v299 v396 
                                            let v398 : float =  -v397
                                            let v399 : string = "num_complex::Complex::new($0, $1)"
                                            let v400 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v395, v398) v399 
                                            let v401 : string = "$0.re"
                                            let v402 : float = Fable.Core.RustInterop.emitRustExpr v400 v401 
                                            let v403 : bool = v402 <= 1.0
                                            let v523 : num_complex_Complex<float> =
                                                if v403 then
                                                    let v404 : string = "num_complex::Complex::new($0, $1)"
                                                    let v405 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v404 
                                                    v405
                                                else
                                                    let v406 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                                    Fable.Core.RustInterop.emitRustExpr struct (4, v400) v406 
                                                    let v407 : string = "$0.re"
                                                    let v408 : float = Fable.Core.RustInterop.emitRustExpr v400 v407 
                                                    let v409 : bool = v408 > 1.0
                                                    if v409 then
                                                        let v410 : string = "num_complex::Complex::new($0, $1)"
                                                        let v411 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v410 
                                                        let v412 : (int32 []) = Array.zeroCreate<int32> (10000)
                                                        let v413 : Mut0 = {l0 = 0} : Mut0
                                                        while method14(v413) do
                                                            let v415 : int32 = v413.l0
                                                            v412.[int v415] <- v415
                                                            let v416 : int32 = v415 + 1
                                                            v413.l0 <- v416
                                                            ()
                                                        let v417 : int32 = v412.Length
                                                        let v418 : Mut2 = {l0 = 0; l1 = v411} : Mut2
                                                        while method15(v417, v418) do
                                                            let v420 : int32 = v418.l0
                                                            let v421 : num_complex_Complex<float> = v418.l1
                                                            let v422 : int32 = v412.[int v420]
                                                            let v423 : string = "num_complex::Complex::new($0, $1)"
                                                            let v424 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v423 
                                                            let v425 : (int32 -> float) = float
                                                            let v426 : float = v425 v422
                                                            let v427 : string = "num_complex::Complex::new($0, $1)"
                                                            let v428 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v426, 0.0) v427 
                                                            let v429 : string = "num_complex::Complex::powc($0, $1)"
                                                            let v430 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v428, v400) v429 
                                                            let v431 : string = "$0 / $1"
                                                            let v432 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v424, v430) v431 
                                                            let v433 : string = "$0 + $1"
                                                            let v434 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v421, v432) v433 
                                                            let v435 : int32 = v420 + 1
                                                            v418.l0 <- v435
                                                            v418.l1 <- v434
                                                            ()
                                                        let v436 : num_complex_Complex<float> = v418.l1
                                                        v436
                                                    else
                                                        let v437 : string = "num_complex::Complex::new($0, $1)"
                                                        let v438 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v437 
                                                        let v439 : string = "$0 - $1"
                                                        let v440 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v438, v400) v439 
                                                        let v441 : string = $"        s = mpmath.gamma(s)"
                                                        let v442 : num_complex_Complex<float> = method3(v440)
                                                        let v443 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v441, v442)
                                                        let v444 : unit = ()
                                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                        let v445 : string = "$0.ok()"
                                                        let v446 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v443 v445 
                                                        let _v444 = v446 
                                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                                        let v447 : string = "$0.ok()"
                                                        let v448 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v443 v447 
                                                        let _v444 = v448 
                                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                        let v449 : string = "$0.ok()"
                                                        let v450 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v443 v449 
                                                        let _v444 = v450 
                                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                        let v451 : num_complex_Complex<float> option = match v443 with Ok x -> Some x | Error _ -> None
                                                        let _v444 = v451 
                                                        #endif
#if FABLE_COMPILER_PYTHON
                                                        let v452 : num_complex_Complex<float> option = match v443 with Ok x -> Some x | Error _ -> None
                                                        let _v444 = v452 
                                                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                                                        let v453 : num_complex_Complex<float> option = match v443 with Ok x -> Some x | Error _ -> None
                                                        let _v444 = v453 
                                                        #endif
#else
                                                        let v454 : num_complex_Complex<float> option = match v443 with Ok x -> Some x | Error _ -> None
                                                        let _v444 = v454 
                                                        #endif
                                                        let v455 : num_complex_Complex<float> option = _v444 
                                                        let v458 : (num_complex_Complex<float> -> US0) = method17()
                                                        let v459 : US0 option = v455 |> Option.map v458 
                                                        let v470 : US0 = US0_1
                                                        let v471 : US0 = v459 |> Option.defaultValue v470 
                                                        let v475 : string = "f64::NAN"
                                                        let v476 : float = Fable.Core.RustInterop.emitRustExpr () v475 
                                                        let v477 : string = "f64::NAN"
                                                        let v478 : float = Fable.Core.RustInterop.emitRustExpr () v477 
                                                        let v479 : string = "num_complex::Complex::new($0, $1)"
                                                        let v480 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v476, v478) v479 
                                                        let v483 : num_complex_Complex<float> =
                                                            match v471 with
                                                            | US0_1 -> (* None *)
                                                                v480
                                                            | US0_0(v481) -> (* Some *)
                                                                v481
                                                        let v484 : string = "num_complex::Complex::new($0, $1)"
                                                        let v485 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v484 
                                                        let v486 : string = "$0 * $1"
                                                        let v487 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v485, v400) v486 
                                                        let v488 : string = "num_complex::Complex::new($0, $1)"
                                                        let v489 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v488 
                                                        let v490 : string = "$0 / $1"
                                                        let v491 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v487, v489) v490 
                                                        let v492 : string = "$0.sin()"
                                                        let v493 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v491 v492 
                                                        let v494 : string = "$0.re"
                                                        let v495 : float = Fable.Core.RustInterop.emitRustExpr v400 v494 
                                                        let v496 : float = 1.0 - v495
                                                        let v497 : string = "$0.im"
                                                        let v498 : float = Fable.Core.RustInterop.emitRustExpr v400 v497 
                                                        let v499 : float =  -v498
                                                        let v500 : string = "num_complex::Complex::new($0, $1)"
                                                        let v501 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v496, v499) v500 
                                                        let v502 : string = "$0.re"
                                                        let v503 : float = Fable.Core.RustInterop.emitRustExpr v501 v502 
                                                        let v504 : bool = v503 <= 1.0
                                                        let v507 : num_complex_Complex<float> =
                                                            if v504 then
                                                                let v505 : string = "num_complex::Complex::new($0, $1)"
                                                                let v506 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v505 
                                                                v506
                                                            else
                                                                v501
                                                        let v508 : string = "num_complex::Complex::new($0, $1)"
                                                        let v509 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v508 
                                                        let v510 : string = "num_complex::Complex::new($0, $1)"
                                                        let v511 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v510 
                                                        let v512 : string = "num_complex::Complex::powc($0, $1)"
                                                        let v513 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v511, v400) v512 
                                                        let v514 : string = "$0 * $1"
                                                        let v515 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v509, v513) v514 
                                                        let v516 : string = "$0 * $1"
                                                        let v517 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v515, v493) v516 
                                                        let v518 : string = "$0 * $1"
                                                        let v519 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v517, v483) v518 
                                                        let v520 : string = "$0 * $1"
                                                        let v521 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v519, v507) v520 
                                                        v521
                                            let v524 : string = "num_complex::Complex::new($0, $1)"
                                            let v525 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v524 
                                            let v526 : string = "num_complex::Complex::new($0, $1)"
                                            let v527 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v526 
                                            let v528 : string = "num_complex::Complex::powc($0, $1)"
                                            let v529 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v527, v299) v528 
                                            let v530 : string = "$0 * $1"
                                            let v531 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v525, v529) v530 
                                            let v532 : string = "$0 * $1"
                                            let v533 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v531, v392) v532 
                                            let v534 : string = "$0 * $1"
                                            let v535 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v533, v382) v534 
                                            let v536 : string = "$0 * $1"
                                            let v537 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v535, v523) v536 
                                            v537
                                let v540 : string = "num_complex::Complex::new($0, $1)"
                                let v541 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v540 
                                let v542 : string = "num_complex::Complex::new($0, $1)"
                                let v543 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v542 
                                let v544 : string = "num_complex::Complex::powc($0, $1)"
                                let v545 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v543, v198) v544 
                                let v546 : string = "$0 * $1"
                                let v547 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v541, v545) v546 
                                let v548 : string = "$0 * $1"
                                let v549 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v547, v291) v548 
                                let v550 : string = "$0 * $1"
                                let v551 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v549, v281) v550 
                                let v552 : string = "$0 * $1"
                                let v553 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v551, v539) v552 
                                v553
                    let v556 : string = "num_complex::Complex::new($0, $1)"
                    let v557 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v556 
                    let v558 : string = "num_complex::Complex::new($0, $1)"
                    let v559 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v558 
                    let v560 : string = "num_complex::Complex::powc($0, $1)"
                    let v561 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v559, v97) v560 
                    let v562 : string = "$0 * $1"
                    let v563 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v557, v561) v562 
                    let v564 : string = "$0 * $1"
                    let v565 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v563, v190) v564 
                    let v566 : string = "$0 * $1"
                    let v567 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v565, v180) v566 
                    let v568 : string = "$0 * $1"
                    let v569 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v567, v555) v568 
                    v569
        let v572 : string = "num_complex::Complex::new($0, $1)"
        let v573 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v572 
        let v574 : string = "num_complex::Complex::new($0, $1)"
        let v575 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v574 
        let v576 : string = "num_complex::Complex::powc($0, $1)"
        let v577 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v575, v1) v576 
        let v578 : string = "$0 * $1"
        let v579 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v573, v577) v578 
        let v580 : string = "$0 * $1"
        let v581 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v579, v89) v580 
        let v582 : string = "$0 * $1"
        let v583 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v581, v79) v582 
        let v584 : string = "$0 * $1"
        let v585 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v583, v571) v584 
        v585
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
        let v16 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v17 : string = "$0.ok()"
        let v18 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v14 v17 
        let _v16 = v18 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v19 : string = "$0.ok()"
        let v20 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v14 v19 
        let _v16 = v20 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v21 : string = "$0.ok()"
        let v22 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v14 v21 
        let _v16 = v22 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v23 : num_complex_Complex<float> option = match v14 with Ok x -> Some x | Error _ -> None
        let _v16 = v23 
        #endif
#if FABLE_COMPILER_PYTHON
        let v24 : num_complex_Complex<float> option = match v14 with Ok x -> Some x | Error _ -> None
        let _v16 = v24 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v25 : num_complex_Complex<float> option = match v14 with Ok x -> Some x | Error _ -> None
        let _v16 = v25 
        #endif
#else
        let v26 : num_complex_Complex<float> option = match v14 with Ok x -> Some x | Error _ -> None
        let _v16 = v26 
        #endif
        let v27 : num_complex_Complex<float> option = _v16 
        let v30 : (num_complex_Complex<float> -> US0) = method17()
        let v31 : US0 option = v27 |> Option.map v30 
        let v42 : US0 = US0_1
        let v43 : US0 = v31 |> Option.defaultValue v42 
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
        let v56 : string = "$0.im"
        let v57 : float = Fable.Core.RustInterop.emitRustExpr v55 v56 
        let v58 : bool = v57 = 0.0
        let v60 : bool =
            if v58 then
                true
            else
                method18(v58)
        let v61 : string = "__assert_eq"
        let v62 : string = $"{v61} / actual: %A{v57} / expected: %A{0.0}"
        let v65 : unit = ()
        let v66 : (unit -> unit) = closure2(v62)
        let v67 : unit = (fun () -> v66 (); v65) ()
        let v69 : bool = v60 = false
        if v69 then
            failwith<unit> v62
        let v70 : string = "$0.re"
        let v71 : float = Fable.Core.RustInterop.emitRustExpr v55 v70 
        let v72 : float = v71 - v11
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
                method18(v76)
        let v79 : string = "__assert_lt"
        let v80 : string = $"{v79} / actual: %A{v75} / expected: %A{0.0001}"
        let v83 : unit = ()
        let v84 : (unit -> unit) = closure2(v80)
        let v85 : unit = (fun () -> v84 (); v83) ()
        let v87 : bool = v78 = false
        if v87 then
            failwith<unit> v80
        let v88 : int32 = v9 + 1
        v7.l0 <- v88
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
    let v12 : _ = v5 
    let v13 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = $"true; let v12 = $0"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr v12 v14 
    let _v13 = v15 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : string = $"true; let v12 = $0"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr v12 v16 
    let _v13 = v17 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v18 : string = $"true; let v12 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v12 v18 
    let _v13 = v19 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : bool = true
    let _v13 = v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : bool = true
    let _v13 = v21 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v22 : bool = true
    let _v13 = v22 
    #endif
#else
    let v23 : bool = true
    let _v13 = v23 
    #endif
    let v24 : bool = _v13 
    let v27 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "__run_test"
    let v30 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v29 
    let v31 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v32 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v33 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v34 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#else
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
    _v31 
    ()
and method21 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, -2.0) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method13(v0, v2)
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "$0.ok()"
    let v9 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v8 
    let _v7 = v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : string = "$0.ok()"
    let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v10 
    let _v7 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : string = "$0.ok()"
    let v13 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v12 
    let _v7 = v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _v7 = v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _v7 = v15 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v16 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _v7 = v16 
    #endif
#else
    let v17 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _v7 = v17 
    #endif
    let v18 : num_complex_Complex<float> option = _v7 
    let v21 : (num_complex_Complex<float> -> US0) = method17()
    let v22 : US0 option = v18 |> Option.map v21 
    let v33 : US0 = US0_1
    let v34 : US0 = v22 |> Option.defaultValue v33 
    let v38 : string = "f64::NAN"
    let v39 : float = Fable.Core.RustInterop.emitRustExpr () v38 
    let v40 : string = "f64::NAN"
    let v41 : float = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : string = "num_complex::Complex::new($0, $1)"
    let v43 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v39, v41) v42 
    let v46 : num_complex_Complex<float> =
        match v34 with
        | US0_1 -> (* None *)
            v43
        | US0_0(v44) -> (* Some *)
            v44
    let v47 : string = "$0.re"
    let v48 : float = Fable.Core.RustInterop.emitRustExpr v46 v47 
    let v49 : float = v48 - 0.8673
    let v50 : float =  -v49
    let v51 : bool = v49 >= v50
    let v52 : float =
        if v51 then
            v49
        else
            v50
    let v53 : bool = v52 < 0.001
    let v55 : bool =
        if v53 then
            true
        else
            method18(v53)
    let v56 : string = "__assert_lt"
    let v57 : string = $"{v56} / actual: %A{v52} / expected: %A{0.001}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure2(v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v64 : bool = v55 = false
    if v64 then
        failwith<unit> v57
    let v65 : string = "$0.im"
    let v66 : float = Fable.Core.RustInterop.emitRustExpr v46 v65 
    let v67 : float = v66 - 0.275
    let v68 : float =  -v67
    let v69 : bool = v67 >= v68
    let v70 : float =
        if v69 then
            v67
        else
            v68
    let v71 : bool = v70 < 0.001
    let v73 : bool =
        if v71 then
            true
        else
            method18(v71)
    let v74 : string = $"{v56} / actual: %A{v70} / expected: %A{0.001}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure2(v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v81 : bool = v73 = false
    if v81 then
        failwith<unit> v74
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
    let v12 : _ = v5 
    let v13 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = $"true; let v12 = $0"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr v12 v14 
    let _v13 = v15 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : string = $"true; let v12 = $0"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr v12 v16 
    let _v13 = v17 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v18 : string = $"true; let v12 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v12 v18 
    let _v13 = v19 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : bool = true
    let _v13 = v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : bool = true
    let _v13 = v21 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v22 : bool = true
    let _v13 = v22 
    #endif
#else
    let v23 : bool = true
    let _v13 = v23 
    #endif
    let v24 : bool = _v13 
    let v27 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "__run_test"
    let v30 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v29 
    let v31 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v32 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v33 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v34 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#else
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
    _v31 
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
        let v10 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v11 : string = "$0.ok()"
        let v12 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v8 v11 
        let _v10 = v12 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v13 : string = "$0.ok()"
        let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v8 v13 
        let _v10 = v14 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v15 : string = "$0.ok()"
        let v16 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v8 v15 
        let _v10 = v16 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v17 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _v10 = v17 
        #endif
#if FABLE_COMPILER_PYTHON
        let v18 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _v10 = v18 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v19 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _v10 = v19 
        #endif
#else
        let v20 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _v10 = v20 
        #endif
        let v21 : num_complex_Complex<float> option = _v10 
        let v24 : (num_complex_Complex<float> -> US0) = method17()
        let v25 : US0 option = v21 |> Option.map v24 
        let v36 : US0 = US0_1
        let v37 : US0 = v25 |> Option.defaultValue v36 
        let v41 : string = "f64::NAN"
        let v42 : float = Fable.Core.RustInterop.emitRustExpr () v41 
        let v43 : string = "f64::NAN"
        let v44 : float = Fable.Core.RustInterop.emitRustExpr () v43 
        let v45 : string = "num_complex::Complex::new($0, $1)"
        let v46 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v42, v44) v45 
        let v49 : num_complex_Complex<float> =
            match v37 with
            | US0_1 -> (* None *)
                v46
            | US0_0(v47) -> (* Some *)
                v47
        let v50 : string = "$0.re"
        let v51 : float = Fable.Core.RustInterop.emitRustExpr v49 v50 
        let v52 : bool = v51 = 0.0
        let v54 : bool =
            if v52 then
                true
            else
                method18(v52)
        let v55 : string = "__assert_eq"
        let v56 : string = $"{v55} / actual: %A{v51} / expected: %A{0.0}"
        let v59 : unit = ()
        let v60 : (unit -> unit) = closure2(v56)
        let v61 : unit = (fun () -> v60 (); v59) ()
        let v63 : bool = v54 = false
        if v63 then
            failwith<unit> v56
        let v64 : string = "$0.im"
        let v65 : float = Fable.Core.RustInterop.emitRustExpr v49 v64 
        let v66 : bool = v65 = 0.0
        let v68 : bool =
            if v66 then
                true
            else
                method18(v66)
        let v69 : string = $"{v55} / actual: %A{v65} / expected: %A{0.0}"
        let v72 : unit = ()
        let v73 : (unit -> unit) = closure2(v69)
        let v74 : unit = (fun () -> v73 (); v72) ()
        let v76 : bool = v68 = false
        if v76 then
            failwith<unit> v69
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
    let v12 : _ = v5 
    let v13 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = $"true; let v12 = $0"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr v12 v14 
    let _v13 = v15 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : string = $"true; let v12 = $0"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr v12 v16 
    let _v13 = v17 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v18 : string = $"true; let v12 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v12 v18 
    let _v13 = v19 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : bool = true
    let _v13 = v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : bool = true
    let _v13 = v21 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v22 : bool = true
    let _v13 = v22 
    #endif
#else
    let v23 : bool = true
    let _v13 = v23 
    #endif
    let v24 : bool = _v13 
    let v27 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "__run_test"
    let v30 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v29 
    let v31 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v32 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v33 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v34 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#else
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
    _v31 
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
        let v23 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v24 : string = "$0.ok()"
        let v25 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v21 v24 
        let _v23 = v25 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v26 : string = "$0.ok()"
        let v27 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v21 v26 
        let _v23 = v27 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v28 : string = "$0.ok()"
        let v29 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v21 v28 
        let _v23 = v29 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v30 : num_complex_Complex<float> option = match v21 with Ok x -> Some x | Error _ -> None
        let _v23 = v30 
        #endif
#if FABLE_COMPILER_PYTHON
        let v31 : num_complex_Complex<float> option = match v21 with Ok x -> Some x | Error _ -> None
        let _v23 = v31 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v32 : num_complex_Complex<float> option = match v21 with Ok x -> Some x | Error _ -> None
        let _v23 = v32 
        #endif
#else
        let v33 : num_complex_Complex<float> option = match v21 with Ok x -> Some x | Error _ -> None
        let _v23 = v33 
        #endif
        let v34 : num_complex_Complex<float> option = _v23 
        let v37 : (num_complex_Complex<float> -> US0) = method17()
        let v38 : US0 option = v34 |> Option.map v37 
        let v49 : US0 = US0_1
        let v50 : US0 = v38 |> Option.defaultValue v49 
        let v54 : string = "f64::NAN"
        let v55 : float = Fable.Core.RustInterop.emitRustExpr () v54 
        let v56 : string = "f64::NAN"
        let v57 : float = Fable.Core.RustInterop.emitRustExpr () v56 
        let v58 : string = "num_complex::Complex::new($0, $1)"
        let v59 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v55, v57) v58 
        let v62 : num_complex_Complex<float> =
            match v50 with
            | US0_1 -> (* None *)
                v59
            | US0_0(v60) -> (* Some *)
                v60
        let v63 : string = "$0.re"
        let v64 : float = Fable.Core.RustInterop.emitRustExpr v62 v63 
        let v65 : float =  -v64
        let v66 : bool = v64 >= v65
        let v67 : float =
            if v66 then
                v64
            else
                v65
        let v68 : bool = v67 < 0.0001
        let v70 : bool =
            if v68 then
                true
            else
                method18(v68)
        let v71 : string = "__assert_lt"
        let v72 : string = $"{v71} / actual: %A{v67} / expected: %A{0.0001}"
        let v75 : unit = ()
        let v76 : (unit -> unit) = closure2(v72)
        let v77 : unit = (fun () -> v76 (); v75) ()
        let v79 : bool = v70 = false
        if v79 then
            failwith<unit> v72
        let v80 : string = "$0.im"
        let v81 : float = Fable.Core.RustInterop.emitRustExpr v62 v80 
        let v82 : float =  -v81
        let v83 : bool = v81 >= v82
        let v84 : float =
            if v83 then
                v81
            else
                v82
        let v85 : bool = v84 < 0.0001
        let v87 : bool =
            if v85 then
                true
            else
                method18(v85)
        let v88 : string = $"{v71} / actual: %A{v84} / expected: %A{0.0001}"
        let v91 : unit = ()
        let v92 : (unit -> unit) = closure2(v88)
        let v93 : unit = (fun () -> v92 (); v91) ()
        let v95 : bool = v87 = false
        if v95 then
            failwith<unit> v88
        let v96 : int32 = v17 + 1
        v15.l0 <- v96
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
    let v12 : _ = v5 
    let v13 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = $"true; let v12 = $0"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr v12 v14 
    let _v13 = v15 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : string = $"true; let v12 = $0"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr v12 v16 
    let _v13 = v17 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v18 : string = $"true; let v12 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v12 v18 
    let _v13 = v19 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : bool = true
    let _v13 = v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : bool = true
    let _v13 = v21 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v22 : bool = true
    let _v13 = v22 
    #endif
#else
    let v23 : bool = true
    let _v13 = v23 
    #endif
    let v24 : bool = _v13 
    let v27 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "__run_test"
    let v30 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v29 
    let v31 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v32 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v33 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v34 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#else
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
    _v31 
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
        let v13 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v14 : string = "$0.ok()"
        let v15 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v11 v14 
        let _v13 = v15 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v16 : string = "$0.ok()"
        let v17 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v11 v16 
        let _v13 = v17 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v18 : string = "$0.ok()"
        let v19 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v11 v18 
        let _v13 = v19 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v20 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _v13 = v20 
        #endif
#if FABLE_COMPILER_PYTHON
        let v21 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _v13 = v21 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v22 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _v13 = v22 
        #endif
#else
        let v23 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _v13 = v23 
        #endif
        let v24 : num_complex_Complex<float> option = _v13 
        let v27 : (num_complex_Complex<float> -> US0) = method17()
        let v28 : US0 option = v24 |> Option.map v27 
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
        let v55 : bool = v54 > 0.0
        let v57 : bool =
            if v55 then
                true
            else
                method18(v55)
        let v58 : string = "__assert_gt"
        let v59 : string = $"{v58} / actual: %A{v54} / expected: %A{0.0}"
        let v62 : unit = ()
        let v63 : (unit -> unit) = closure2(v59)
        let v64 : unit = (fun () -> v63 (); v62) ()
        let v66 : bool = v57 = false
        if v66 then
            failwith<unit> v59
        let v67 : string = "$0.im"
        let v68 : float = Fable.Core.RustInterop.emitRustExpr v52 v67 
        let v69 : bool = v68 = 0.0
        let v71 : bool =
            if v69 then
                true
            else
                method18(v69)
        let v72 : string = "__assert_eq"
        let v73 : string = $"{v72} / actual: %A{v68} / expected: %A{0.0}"
        let v76 : unit = ()
        let v77 : (unit -> unit) = closure2(v73)
        let v78 : unit = (fun () -> v77 (); v76) ()
        let v80 : bool = v71 = false
        if v80 then
            failwith<unit> v73
        let v81 : int32 = v5 + 1
        v3.l0 <- v81
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
    let v12 : _ = v5 
    let v13 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = $"true; let v12 = $0"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr v12 v14 
    let _v13 = v15 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : string = $"true; let v12 = $0"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr v12 v16 
    let _v13 = v17 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v18 : string = $"true; let v12 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v12 v18 
    let _v13 = v19 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : bool = true
    let _v13 = v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : bool = true
    let _v13 = v21 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v22 : bool = true
    let _v13 = v22 
    #endif
#else
    let v23 : bool = true
    let _v13 = v23 
    #endif
    let v24 : bool = _v13 
    let v27 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "__run_test"
    let v30 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v29 
    let v31 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v32 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v33 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v34 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#else
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
    _v31 
    ()
and method31 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method13(v0, v2)
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "$0.ok()"
    let v9 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v8 
    let _v7 = v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : string = "$0.ok()"
    let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v10 
    let _v7 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : string = "$0.ok()"
    let v13 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v12 
    let _v7 = v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _v7 = v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _v7 = v15 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v16 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _v7 = v16 
    #endif
#else
    let v17 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _v7 = v17 
    #endif
    let v18 : num_complex_Complex<float> option = _v7 
    let v21 : (num_complex_Complex<float> -> US0) = method17()
    let v22 : US0 option = v18 |> Option.map v21 
    let v33 : US0 = US0_1
    let v34 : US0 = v22 |> Option.defaultValue v33 
    let v38 : string = "f64::NAN"
    let v39 : float = Fable.Core.RustInterop.emitRustExpr () v38 
    let v40 : string = "f64::NAN"
    let v41 : float = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : string = "num_complex::Complex::new($0, $1)"
    let v43 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v39, v41) v42 
    let v46 : num_complex_Complex<float> =
        match v34 with
        | US0_1 -> (* None *)
            v43
        | US0_0(v44) -> (* Some *)
            v44
    let v47 : string = "$0.re"
    let v48 : float = Fable.Core.RustInterop.emitRustExpr v46 v47 
    let v49 : bool = v48 = infinity
    let v51 : bool =
        if v49 then
            true
        else
            method18(v49)
    let v52 : string = "__assert_eq"
    let v53 : string = $"{v52} / actual: %A{v48} / expected: %A{infinity}"
    let v56 : unit = ()
    let v57 : (unit -> unit) = closure2(v53)
    let v58 : unit = (fun () -> v57 (); v56) ()
    let v60 : bool = v51 = false
    if v60 then
        failwith<unit> v53
    let v61 : string = "$0.im"
    let v62 : float = Fable.Core.RustInterop.emitRustExpr v46 v61 
    let v63 : bool = v62 = 0.0
    let v65 : bool =
        if v63 then
            true
        else
            method18(v63)
    let v66 : string = $"{v52} / actual: %A{v62} / expected: %A{0.0}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure2(v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v73 : bool = v65 = false
    if v73 then
        failwith<unit> v66
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
    let v12 : _ = v5 
    let v13 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = $"true; let v12 = $0"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr v12 v14 
    let _v13 = v15 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : string = $"true; let v12 = $0"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr v12 v16 
    let _v13 = v17 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v18 : string = $"true; let v12 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v12 v18 
    let _v13 = v19 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : bool = true
    let _v13 = v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : bool = true
    let _v13 = v21 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v22 : bool = true
    let _v13 = v22 
    #endif
#else
    let v23 : bool = true
    let _v13 = v23 
    #endif
    let v24 : bool = _v13 
    let v27 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "__run_test"
    let v30 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v29 
    let v31 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v32 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v33 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v34 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#else
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
    _v31 
    ()
and method33 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 10.0) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method13(v0, v2)
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "$0.ok()"
    let v9 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v8 
    let _v7 = v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : string = "$0.ok()"
    let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v10 
    let _v7 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : string = "$0.ok()"
    let v13 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v12 
    let _v7 = v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _v7 = v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _v7 = v15 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v16 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _v7 = v16 
    #endif
#else
    let v17 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _v7 = v17 
    #endif
    let v18 : num_complex_Complex<float> option = _v7 
    let v21 : (num_complex_Complex<float> -> US0) = method17()
    let v22 : US0 option = v18 |> Option.map v21 
    let v33 : US0 = US0_1
    let v34 : US0 = v22 |> Option.defaultValue v33 
    let v38 : string = "f64::NAN"
    let v39 : float = Fable.Core.RustInterop.emitRustExpr () v38 
    let v40 : string = "f64::NAN"
    let v41 : float = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : string = "num_complex::Complex::new($0, $1)"
    let v43 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v39, v41) v42 
    let v46 : num_complex_Complex<float> =
        match v34 with
        | US0_1 -> (* None *)
            v43
        | US0_0(v44) -> (* Some *)
            v44
    let v47 : string = "$0.re"
    let v48 : float = Fable.Core.RustInterop.emitRustExpr v2 v47 
    let v49 : string = "$0.im"
    let v50 : float = Fable.Core.RustInterop.emitRustExpr v2 v49 
    let v51 : float =  -v50
    let v52 : string = "num_complex::Complex::new($0, $1)"
    let v53 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v48, v51) v52 
    let v54 : string = $"        s = mpmath.zeta(s)"
    let v55 : num_complex_Complex<float> = method3(v53)
    let v56 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v54, v55)
    let v57 : num_complex_Complex<float> = method13(v0, v53)
    let v58 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v59 : string = "$0.ok()"
    let v60 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v56 v59 
    let _v58 = v60 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v61 : string = "$0.ok()"
    let v62 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v56 v61 
    let _v58 = v62 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v63 : string = "$0.ok()"
    let v64 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v56 v63 
    let _v58 = v64 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v65 : num_complex_Complex<float> option = match v56 with Ok x -> Some x | Error _ -> None
    let _v58 = v65 
    #endif
#if FABLE_COMPILER_PYTHON
    let v66 : num_complex_Complex<float> option = match v56 with Ok x -> Some x | Error _ -> None
    let _v58 = v66 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v67 : num_complex_Complex<float> option = match v56 with Ok x -> Some x | Error _ -> None
    let _v58 = v67 
    #endif
#else
    let v68 : num_complex_Complex<float> option = match v56 with Ok x -> Some x | Error _ -> None
    let _v58 = v68 
    #endif
    let v69 : num_complex_Complex<float> option = _v58 
    let v72 : (num_complex_Complex<float> -> US0) = method17()
    let v73 : US0 option = v69 |> Option.map v72 
    let v84 : US0 = US0_1
    let v85 : US0 = v73 |> Option.defaultValue v84 
    let v89 : string = "f64::NAN"
    let v90 : float = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = "f64::NAN"
    let v92 : float = Fable.Core.RustInterop.emitRustExpr () v91 
    let v93 : string = "num_complex::Complex::new($0, $1)"
    let v94 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v90, v92) v93 
    let v97 : num_complex_Complex<float> =
        match v85 with
        | US0_1 -> (* None *)
            v94
        | US0_0(v95) -> (* Some *)
            v95
    let v98 : string = "$0.conj()"
    let v99 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v97 v98 
    let v100 : string = "$0.re"
    let v101 : float = Fable.Core.RustInterop.emitRustExpr v46 v100 
    let v102 : string = "$0.re"
    let v103 : float = Fable.Core.RustInterop.emitRustExpr v99 v102 
    let v104 : bool = v101 = v103
    let v106 : bool =
        if v104 then
            true
        else
            method18(v104)
    let v107 : string = "__assert_eq"
    let v108 : string = $"{v107} / actual: %A{v101} / expected: %A{v103}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure2(v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v115 : bool = v106 = false
    if v115 then
        failwith<unit> v108
    let v116 : string = "$0.im"
    let v117 : float = Fable.Core.RustInterop.emitRustExpr v46 v116 
    let v118 : string = "$0.im"
    let v119 : float = Fable.Core.RustInterop.emitRustExpr v99 v118 
    let v120 : bool = v117 = v119
    let v122 : bool =
        if v120 then
            true
        else
            method18(v120)
    let v123 : string = $"{v107} / actual: %A{v117} / expected: %A{v119}"
    let v126 : unit = ()
    let v127 : (unit -> unit) = closure2(v123)
    let v128 : unit = (fun () -> v127 (); v126) ()
    let v130 : bool = v122 = false
    if v130 then
        failwith<unit> v123
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
    let v12 : _ = v5 
    let v13 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = $"true; let v12 = $0"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr v12 v14 
    let _v13 = v15 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : string = $"true; let v12 = $0"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr v12 v16 
    let _v13 = v17 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v18 : string = $"true; let v12 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v12 v18 
    let _v13 = v19 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : bool = true
    let _v13 = v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : bool = true
    let _v13 = v21 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v22 : bool = true
    let _v13 = v22 
    #endif
#else
    let v23 : bool = true
    let _v13 = v23 
    #endif
    let v24 : bool = _v13 
    let v27 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "__run_test"
    let v30 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v29 
    let v31 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v32 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v33 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v34 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#else
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
    _v31 
    ()
and method35 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.01, 0.01) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method13(v0, v2)
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "$0.ok()"
    let v9 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v8 
    let _v7 = v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : string = "$0.ok()"
    let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v10 
    let _v7 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : string = "$0.ok()"
    let v13 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v12 
    let _v7 = v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _v7 = v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _v7 = v15 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v16 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _v7 = v16 
    #endif
#else
    let v17 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _v7 = v17 
    #endif
    let v18 : num_complex_Complex<float> option = _v7 
    let v21 : (num_complex_Complex<float> -> US0) = method17()
    let v22 : US0 option = v18 |> Option.map v21 
    let v33 : US0 = US0_1
    let v34 : US0 = v22 |> Option.defaultValue v33 
    let v38 : string = "f64::NAN"
    let v39 : float = Fable.Core.RustInterop.emitRustExpr () v38 
    let v40 : string = "f64::NAN"
    let v41 : float = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : string = "num_complex::Complex::new($0, $1)"
    let v43 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v39, v41) v42 
    let v46 : num_complex_Complex<float> =
        match v34 with
        | US0_1 -> (* None *)
            v43
        | US0_0(v44) -> (* Some *)
            v44
    let v47 : string = "$0.re"
    let v48 : float = Fable.Core.RustInterop.emitRustExpr v46 v47 
    let v49 : bool = v48 < infinity
    let v51 : bool =
        if v49 then
            true
        else
            method18(v49)
    let v52 : string = "__assert_lt"
    let v53 : string = $"{v52} / actual: %A{v48} / expected: %A{infinity}"
    let v56 : unit = ()
    let v57 : (unit -> unit) = closure2(v53)
    let v58 : unit = (fun () -> v57 (); v56) ()
    let v60 : bool = v51 = false
    if v60 then
        failwith<unit> v53
    let v61 : string = "$0.im"
    let v62 : float = Fable.Core.RustInterop.emitRustExpr v46 v61 
    let v63 : bool = v62 < infinity
    let v65 : bool =
        if v63 then
            true
        else
            method18(v63)
    let v66 : string = $"{v52} / actual: %A{v62} / expected: %A{infinity}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure2(v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v73 : bool = v65 = false
    if v73 then
        failwith<unit> v66
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
    let v12 : _ = v5 
    let v13 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = $"true; let v12 = $0"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr v12 v14 
    let _v13 = v15 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : string = $"true; let v12 = $0"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr v12 v16 
    let _v13 = v17 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v18 : string = $"true; let v12 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v12 v18 
    let _v13 = v19 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : bool = true
    let _v13 = v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : bool = true
    let _v13 = v21 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v22 : bool = true
    let _v13 = v22 
    #endif
#else
    let v23 : bool = true
    let _v13 = v23 
    #endif
    let v24 : bool = _v13 
    let v27 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "__run_test"
    let v30 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v29 
    let v31 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v32 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v33 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v34 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#else
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
    _v31 
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
        let v10 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v11 : string = "$0.ok()"
        let v12 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v8 v11 
        let _v10 = v12 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v13 : string = "$0.ok()"
        let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v8 v13 
        let _v10 = v14 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v15 : string = "$0.ok()"
        let v16 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v8 v15 
        let _v10 = v16 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v17 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _v10 = v17 
        #endif
#if FABLE_COMPILER_PYTHON
        let v18 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _v10 = v18 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v19 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _v10 = v19 
        #endif
#else
        let v20 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _v10 = v20 
        #endif
        let v21 : num_complex_Complex<float> option = _v10 
        let v24 : (num_complex_Complex<float> -> US0) = method17()
        let v25 : US0 option = v21 |> Option.map v24 
        let v36 : US0 = US0_1
        let v37 : US0 = v25 |> Option.defaultValue v36 
        let v41 : string = "f64::NAN"
        let v42 : float = Fable.Core.RustInterop.emitRustExpr () v41 
        let v43 : string = "f64::NAN"
        let v44 : float = Fable.Core.RustInterop.emitRustExpr () v43 
        let v45 : string = "num_complex::Complex::new($0, $1)"
        let v46 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v42, v44) v45 
        let v49 : num_complex_Complex<float> =
            match v37 with
            | US0_1 -> (* None *)
                v46
            | US0_0(v47) -> (* Some *)
                v47
        let v50 : string = "$0.re"
        let v51 : float = Fable.Core.RustInterop.emitRustExpr v49 v50 
        let v52 : bool = v51 <> 0.0 
        let v56 : bool =
            if v52 then
                true
            else
                method18(v52)
        let v57 : string = "__assert_ne"
        let v58 : string = $"{v57} / actual: %A{v51} / expected: %A{0.0}"
        let v61 : unit = ()
        let v62 : (unit -> unit) = closure2(v58)
        let v63 : unit = (fun () -> v62 (); v61) ()
        let v65 : bool = v56 = false
        if v65 then
            failwith<unit> v58
        let v66 : string = "$0.im"
        let v67 : float = Fable.Core.RustInterop.emitRustExpr v49 v66 
        let v68 : bool = v67 <> 0.0 
        let v72 : bool =
            if v68 then
                true
            else
                method18(v68)
        let v73 : string = $"{v57} / actual: %A{v67} / expected: %A{0.0}"
        let v76 : unit = ()
        let v77 : (unit -> unit) = closure2(v73)
        let v78 : unit = (fun () -> v77 (); v76) ()
        let v80 : bool = v72 = false
        if v80 then
            failwith<unit> v73
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
    let v12 : _ = v5 
    let v13 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = $"true; let v12 = $0"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr v12 v14 
    let _v13 = v15 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : string = $"true; let v12 = $0"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr v12 v16 
    let _v13 = v17 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v18 : string = $"true; let v12 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v12 v18 
    let _v13 = v19 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : bool = true
    let _v13 = v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : bool = true
    let _v13 = v21 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v22 : bool = true
    let _v13 = v22 
    #endif
#else
    let v23 : bool = true
    let _v13 = v23 
    #endif
    let v24 : bool = _v13 
    let v27 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "__run_test"
    let v30 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v29 
    let v31 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v32 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v33 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v34 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#else
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
    _v31 
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
        let v8 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v9 : string = "$0.ok()"
        let v10 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v6 v9 
        let _v8 = v10 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v11 : string = "$0.ok()"
        let v12 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v6 v11 
        let _v8 = v12 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v13 : string = "$0.ok()"
        let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v6 v13 
        let _v8 = v14 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v15 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _v8 = v15 
        #endif
#if FABLE_COMPILER_PYTHON
        let v16 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _v8 = v16 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v17 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _v8 = v17 
        #endif
#else
        let v18 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _v8 = v18 
        #endif
        let v19 : num_complex_Complex<float> option = _v8 
        let v22 : (num_complex_Complex<float> -> US0) = method17()
        let v23 : US0 option = v19 |> Option.map v22 
        let v34 : US0 = US0_1
        let v35 : US0 = v23 |> Option.defaultValue v34 
        let v39 : string = "f64::NAN"
        let v40 : float = Fable.Core.RustInterop.emitRustExpr () v39 
        let v41 : string = "f64::NAN"
        let v42 : float = Fable.Core.RustInterop.emitRustExpr () v41 
        let v43 : string = "num_complex::Complex::new($0, $1)"
        let v44 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v40, v42) v43 
        let v47 : num_complex_Complex<float> =
            match v35 with
            | US0_1 -> (* None *)
                v44
            | US0_0(v45) -> (* Some *)
                v45
        let v48 : string = "$0.re"
        let v49 : float = Fable.Core.RustInterop.emitRustExpr v47 v48 
        let v50 : bool = v49 <> 0.0 
        let v54 : bool =
            if v50 then
                true
            else
                method18(v50)
        let v55 : string = "__assert_ne"
        let v56 : string = $"{v55} / actual: %A{v49} / expected: %A{0.0}"
        let v59 : unit = ()
        let v60 : (unit -> unit) = closure2(v56)
        let v61 : unit = (fun () -> v60 (); v59) ()
        let v63 : bool = v54 = false
        if v63 then
            failwith<unit> v56
        let v64 : string = "$0.im"
        let v65 : float = Fable.Core.RustInterop.emitRustExpr v47 v64 
        let v66 : bool = v65 <> 0.0 
        let v70 : bool =
            if v66 then
                true
            else
                method18(v66)
        let v71 : string = $"{v55} / actual: %A{v65} / expected: %A{0.0}"
        let v74 : unit = ()
        let v75 : (unit -> unit) = closure2(v71)
        let v76 : unit = (fun () -> v75 (); v74) ()
        let v78 : bool = v70 = false
        if v78 then
            failwith<unit> v71
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
    let v12 : _ = v5 
    let v13 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = $"true; let v12 = $0"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr v12 v14 
    let _v13 = v15 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : string = $"true; let v12 = $0"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr v12 v16 
    let _v13 = v17 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v18 : string = $"true; let v12 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v12 v18 
    let _v13 = v19 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : bool = true
    let _v13 = v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : bool = true
    let _v13 = v21 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v22 : bool = true
    let _v13 = v22 
    #endif
#else
    let v23 : bool = true
    let _v13 = v23 
    #endif
    let v24 : bool = _v13 
    let v27 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "__run_test"
    let v30 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v29 
    let v31 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v32 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v33 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v34 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#else
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
    _v31 
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
        let v8 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v9 : string = "$0.ok()"
        let v10 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v6 v9 
        let _v8 = v10 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v11 : string = "$0.ok()"
        let v12 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v6 v11 
        let _v8 = v12 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v13 : string = "$0.ok()"
        let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v6 v13 
        let _v8 = v14 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v15 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _v8 = v15 
        #endif
#if FABLE_COMPILER_PYTHON
        let v16 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _v8 = v16 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v17 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _v8 = v17 
        #endif
#else
        let v18 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _v8 = v18 
        #endif
        let v19 : num_complex_Complex<float> option = _v8 
        let v22 : (num_complex_Complex<float> -> US0) = method17()
        let v23 : US0 option = v19 |> Option.map v22 
        let v34 : US0 = US0_1
        let v35 : US0 = v23 |> Option.defaultValue v34 
        let v39 : string = "f64::NAN"
        let v40 : float = Fable.Core.RustInterop.emitRustExpr () v39 
        let v41 : string = "f64::NAN"
        let v42 : float = Fable.Core.RustInterop.emitRustExpr () v41 
        let v43 : string = "num_complex::Complex::new($0, $1)"
        let v44 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v40, v42) v43 
        let v47 : num_complex_Complex<float> =
            match v35 with
            | US0_1 -> (* None *)
                v44
            | US0_0(v45) -> (* Some *)
                v45
        let v48 : string = "num_complex::Complex::new($0, $1)"
        let v49 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v48 
        let v50 : string = "num_complex::Complex::powc($0, $1)"
        let v51 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v49, v2) v50 
        let v52 : string = "num_complex::Complex::new($0, $1)"
        let v53 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v52 
        let v54 : string = "num_complex::Complex::new($0, $1)"
        let v55 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v54 
        let v56 : string = "$0 - $1"
        let v57 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v2, v55) v56 
        let v58 : string = "num_complex::Complex::powc($0, $1)"
        let v59 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v53, v57) v58 
        let v60 : string = "$0 * $1"
        let v61 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v51, v59) v60 
        let v62 : string = "num_complex::Complex::new($0, $1)"
        let v63 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v62 
        let v64 : string = "$0 * $1"
        let v65 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v63, v2) v64 
        let v66 : string = "num_complex::Complex::new($0, $1)"
        let v67 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v66 
        let v68 : string = "$0 / $1"
        let v69 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v65, v67) v68 
        let v70 : string = "$0.sin()"
        let v71 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v69 v70 
        let v72 : string = "$0 * $1"
        let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v61, v71) v72 
        let v74 : string = "num_complex::Complex::new($0, $1)"
        let v75 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v74 
        let v76 : string = "$0 - $1"
        let v77 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v75, v2) v76 
        let v78 : string = $"        s = mpmath.gamma(s)"
        let v79 : num_complex_Complex<float> = method3(v77)
        let v80 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v78, v79)
        let v81 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v82 : string = "$0.ok()"
        let v83 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v80 v82 
        let _v81 = v83 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v84 : string = "$0.ok()"
        let v85 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v80 v84 
        let _v81 = v85 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v86 : string = "$0.ok()"
        let v87 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v80 v86 
        let _v81 = v87 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v88 : num_complex_Complex<float> option = match v80 with Ok x -> Some x | Error _ -> None
        let _v81 = v88 
        #endif
#if FABLE_COMPILER_PYTHON
        let v89 : num_complex_Complex<float> option = match v80 with Ok x -> Some x | Error _ -> None
        let _v81 = v89 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v90 : num_complex_Complex<float> option = match v80 with Ok x -> Some x | Error _ -> None
        let _v81 = v90 
        #endif
#else
        let v91 : num_complex_Complex<float> option = match v80 with Ok x -> Some x | Error _ -> None
        let _v81 = v91 
        #endif
        let v92 : num_complex_Complex<float> option = _v81 
        let v95 : (num_complex_Complex<float> -> US0) = method17()
        let v96 : US0 option = v92 |> Option.map v95 
        let v107 : US0 = US0_1
        let v108 : US0 = v96 |> Option.defaultValue v107 
        let v112 : string = "f64::NAN"
        let v113 : float = Fable.Core.RustInterop.emitRustExpr () v112 
        let v114 : string = "f64::NAN"
        let v115 : float = Fable.Core.RustInterop.emitRustExpr () v114 
        let v116 : string = "num_complex::Complex::new($0, $1)"
        let v117 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v113, v115) v116 
        let v120 : num_complex_Complex<float> =
            match v108 with
            | US0_1 -> (* None *)
                v117
            | US0_0(v118) -> (* Some *)
                v118
        let v121 : string = "$0 * $1"
        let v122 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v73, v120) v121 
        let v123 : string = "$0.re"
        let v124 : float = Fable.Core.RustInterop.emitRustExpr v2 v123 
        let v125 : float = 1.0 - v124
        let v126 : string = "$0.im"
        let v127 : float = Fable.Core.RustInterop.emitRustExpr v2 v126 
        let v128 : float =  -v127
        let v129 : string = "num_complex::Complex::new($0, $1)"
        let v130 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v125, v128) v129 
        let v131 : string = $"        s = mpmath.zeta(s)"
        let v132 : num_complex_Complex<float> = method3(v130)
        let v133 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v131, v132)
        let v134 : num_complex_Complex<float> = method13(v0, v130)
        let v135 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v136 : string = "$0.ok()"
        let v137 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v133 v136 
        let _v135 = v137 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v138 : string = "$0.ok()"
        let v139 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v133 v138 
        let _v135 = v139 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v140 : string = "$0.ok()"
        let v141 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v133 v140 
        let _v135 = v141 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v142 : num_complex_Complex<float> option = match v133 with Ok x -> Some x | Error _ -> None
        let _v135 = v142 
        #endif
#if FABLE_COMPILER_PYTHON
        let v143 : num_complex_Complex<float> option = match v133 with Ok x -> Some x | Error _ -> None
        let _v135 = v143 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v144 : num_complex_Complex<float> option = match v133 with Ok x -> Some x | Error _ -> None
        let _v135 = v144 
        #endif
#else
        let v145 : num_complex_Complex<float> option = match v133 with Ok x -> Some x | Error _ -> None
        let _v135 = v145 
        #endif
        let v146 : num_complex_Complex<float> option = _v135 
        let v149 : (num_complex_Complex<float> -> US0) = method17()
        let v150 : US0 option = v146 |> Option.map v149 
        let v161 : US0 = US0_1
        let v162 : US0 = v150 |> Option.defaultValue v161 
        let v166 : string = "f64::NAN"
        let v167 : float = Fable.Core.RustInterop.emitRustExpr () v166 
        let v168 : string = "f64::NAN"
        let v169 : float = Fable.Core.RustInterop.emitRustExpr () v168 
        let v170 : string = "num_complex::Complex::new($0, $1)"
        let v171 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v167, v169) v170 
        let v174 : num_complex_Complex<float> =
            match v162 with
            | US0_1 -> (* None *)
                v171
            | US0_0(v172) -> (* Some *)
                v172
        let v175 : string = "$0 * $1"
        let v176 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v122, v174) v175 
        let v177 : string = "$0.re"
        let v178 : float = Fable.Core.RustInterop.emitRustExpr v47 v177 
        let v179 : string = "$0.re"
        let v180 : float = Fable.Core.RustInterop.emitRustExpr v176 v179 
        let v181 : float = v178 - v180
        let v182 : float =  -v181
        let v183 : bool = v181 >= v182
        let v184 : float =
            if v183 then
                v181
            else
                v182
        let v185 : bool = v184 < 0.0001
        let v187 : bool =
            if v185 then
                true
            else
                method18(v185)
        let v188 : string = "__assert_lt"
        let v189 : string = $"{v188} / actual: %A{v184} / expected: %A{0.0001}"
        let v192 : unit = ()
        let v193 : (unit -> unit) = closure2(v189)
        let v194 : unit = (fun () -> v193 (); v192) ()
        let v196 : bool = v187 = false
        if v196 then
            failwith<unit> v189
        let v197 : string = "$0.im"
        let v198 : float = Fable.Core.RustInterop.emitRustExpr v47 v197 
        let v199 : string = "$0.im"
        let v200 : float = Fable.Core.RustInterop.emitRustExpr v176 v199 
        let v201 : float = v198 - v200
        let v202 : float =  -v201
        let v203 : bool = v201 >= v202
        let v204 : float =
            if v203 then
                v201
            else
                v202
        let v205 : bool = v204 < 0.0001
        let v207 : bool =
            if v205 then
                true
            else
                method18(v205)
        let v208 : string = $"{v188} / actual: %A{v204} / expected: %A{0.0001}"
        let v211 : unit = ()
        let v212 : (unit -> unit) = closure2(v208)
        let v213 : unit = (fun () -> v212 (); v211) ()
        let v215 : bool = v207 = false
        if v215 then
            failwith<unit> v208
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
    let v12 : _ = v5 
    let v13 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = $"true; let v12 = $0"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr v12 v14 
    let _v13 = v15 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : string = $"true; let v12 = $0"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr v12 v16 
    let _v13 = v17 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v18 : string = $"true; let v12 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v12 v18 
    let _v13 = v19 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : bool = true
    let _v13 = v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : bool = true
    let _v13 = v21 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v22 : bool = true
    let _v13 = v22 
    #endif
#else
    let v23 : bool = true
    let _v13 = v23 
    #endif
    let v24 : bool = _v13 
    let v27 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "__run_test"
    let v30 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v29 
    let v31 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v32 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v33 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v34 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#else
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
    _v31 
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
        let v13 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v14 : string = "$0.ok()"
        let v15 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v11 v14 
        let _v13 = v15 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v16 : string = "$0.ok()"
        let v17 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v11 v16 
        let _v13 = v17 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v18 : string = "$0.ok()"
        let v19 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v11 v18 
        let _v13 = v19 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v20 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _v13 = v20 
        #endif
#if FABLE_COMPILER_PYTHON
        let v21 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _v13 = v21 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v22 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _v13 = v22 
        #endif
#else
        let v23 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _v13 = v23 
        #endif
        let v24 : num_complex_Complex<float> option = _v13 
        let v27 : (num_complex_Complex<float> -> US0) = method17()
        let v28 : US0 option = v24 |> Option.map v27 
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
        let v55 : float = v54 - v8
        let v56 : float =  -v55
        let v57 : bool = v55 >= v56
        let v58 : float =
            if v57 then
                v55
            else
                v56
        let v59 : bool = v58 < 0.01
        let v61 : bool =
            if v59 then
                true
            else
                method18(v59)
        let v62 : string = "__assert_lt"
        let v63 : string = $"{v62} / actual: %A{v58} / expected: %A{0.01}"
        let v66 : unit = ()
        let v67 : (unit -> unit) = closure2(v63)
        let v68 : unit = (fun () -> v67 (); v66) ()
        let v70 : bool = v61 = false
        if v70 then
            failwith<unit> v63
        let v71 : string = "$0.im"
        let v72 : float = Fable.Core.RustInterop.emitRustExpr v52 v71 
        let v73 : bool = v72 < 0.01
        let v75 : bool =
            if v73 then
                true
            else
                method18(v73)
        let v76 : string = $"{v62} / actual: %A{v72} / expected: %A{0.01}"
        let v79 : unit = ()
        let v80 : (unit -> unit) = closure2(v76)
        let v81 : unit = (fun () -> v80 (); v79) ()
        let v83 : bool = v75 = false
        if v83 then
            failwith<unit> v76
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
    let v12 : _ = v5 
    let v13 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = $"true; let v12 = $0"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr v12 v14 
    let _v13 = v15 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : string = $"true; let v12 = $0"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr v12 v16 
    let _v13 = v17 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v18 : string = $"true; let v12 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v12 v18 
    let _v13 = v19 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : bool = true
    let _v13 = v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : bool = true
    let _v13 = v21 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v22 : bool = true
    let _v13 = v22 
    #endif
#else
    let v23 : bool = true
    let _v13 = v23 
    #endif
    let v24 : bool = _v13 
    let v27 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "__run_test"
    let v30 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v29 
    let v31 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v32 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v33 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v30 v34 
    let _v31 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
#else
    match v30 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v31 = () 
    #endif
    _v31 
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
