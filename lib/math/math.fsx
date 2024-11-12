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
            let v25 : string = "num_complex::Complex::new($0, $1)"
            let v26 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v22, 0.0) v25 
            let v27 : string = "num_complex::Complex::powc($0, $1)"
            let v28 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v26, v1) v27 
            let v29 : string = "$0 / $1"
            let v30 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v20, v28) v29 
            let v31 : string = "$0 + $1"
            let v32 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v17, v30) v31 
            let v33 : int32 = v16 + 1
            v14.l0 <- v33
            v14.l1 <- v32
            ()
        let v34 : num_complex_Complex<float> = v14.l1
        v34
    else
        let v35 : string = "num_complex::Complex::new($0, $1)"
        let v36 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v35 
        let v37 : string = "$0 - $1"
        let v38 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v36, v1) v37 
        let v39 : string = $"        s = mpmath.gamma(s)"
        let v40 : num_complex_Complex<float> = method3(v38)
        let v41 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v39, v40)
        let v42 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v43 : string = "$0.ok()"
        let v44 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v41 v43 
        let _v42 = v44 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v45 : string = "$0.ok()"
        let v46 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v41 v45 
        let _v42 = v46 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v47 : string = "$0.ok()"
        let v48 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v41 v47 
        let _v42 = v48 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v49 : num_complex_Complex<float> option = match v41 with Ok x -> Some x | Error _ -> None
        let _v42 = v49 
        #endif
#if FABLE_COMPILER_PYTHON
        let v50 : num_complex_Complex<float> option = match v41 with Ok x -> Some x | Error _ -> None
        let _v42 = v50 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v51 : num_complex_Complex<float> option = match v41 with Ok x -> Some x | Error _ -> None
        let _v42 = v51 
        #endif
#else
        let v52 : num_complex_Complex<float> option = match v41 with Ok x -> Some x | Error _ -> None
        let _v42 = v52 
        #endif
        let v53 : num_complex_Complex<float> option = _v42 
        let v56 : (num_complex_Complex<float> -> US0) = method17()
        let v57 : US0 option = v53 |> Option.map v56 
        let v68 : US0 = US0_1
        let v69 : US0 = v57 |> Option.defaultValue v68 
        let v73 : string = "f64::NAN"
        let v74 : float = Fable.Core.RustInterop.emitRustExpr () v73 
        let v75 : string = "f64::NAN"
        let v76 : float = Fable.Core.RustInterop.emitRustExpr () v75 
        let v77 : string = "num_complex::Complex::new($0, $1)"
        let v78 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v74, v76) v77 
        let v81 : num_complex_Complex<float> =
            match v69 with
            | US0_1 -> (* None *)
                v78
            | US0_0(v79) -> (* Some *)
                v79
        let v82 : string = "num_complex::Complex::new($0, $1)"
        let v83 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v82 
        let v84 : string = "$0 * $1"
        let v85 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v83, v1) v84 
        let v86 : string = "num_complex::Complex::new($0, $1)"
        let v87 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v86 
        let v88 : string = "$0 / $1"
        let v89 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v85, v87) v88 
        let v90 : string = "$0.sin()"
        let v91 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v89 v90 
        let v92 : string = "$0.re"
        let v93 : float = Fable.Core.RustInterop.emitRustExpr v1 v92 
        let v94 : float = 1.0 - v93
        let v95 : string = "$0.im"
        let v96 : float = Fable.Core.RustInterop.emitRustExpr v1 v95 
        let v97 : float =  -v96
        let v98 : string = "num_complex::Complex::new($0, $1)"
        let v99 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v94, v97) v98 
        let v100 : string = "$0.re"
        let v101 : float = Fable.Core.RustInterop.emitRustExpr v99 v100 
        let v102 : bool = v101 <= 1.0
        let v581 : num_complex_Complex<float> =
            if v102 then
                let v103 : string = "num_complex::Complex::new($0, $1)"
                let v104 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v103 
                v104
            else
                let v105 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                Fable.Core.RustInterop.emitRustExpr struct (1, v99) v105 
                let v106 : string = "$0.re"
                let v107 : float = Fable.Core.RustInterop.emitRustExpr v99 v106 
                let v108 : bool = v107 > 1.0
                if v108 then
                    let v109 : string = "num_complex::Complex::new($0, $1)"
                    let v110 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v109 
                    let v111 : (int32 []) = Array.zeroCreate<int32> (10000)
                    let v112 : Mut0 = {l0 = 0} : Mut0
                    while method14(v112) do
                        let v114 : int32 = v112.l0
                        v111.[int v114] <- v114
                        let v115 : int32 = v114 + 1
                        v112.l0 <- v115
                        ()
                    let v116 : int32 = v111.Length
                    let v117 : Mut2 = {l0 = 0; l1 = v110} : Mut2
                    while method15(v116, v117) do
                        let v119 : int32 = v117.l0
                        let v120 : num_complex_Complex<float> = v117.l1
                        let v121 : int32 = v111.[int v119]
                        let v122 : string = "num_complex::Complex::new($0, $1)"
                        let v123 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v122 
                        let v124 : (int32 -> float) = float
                        let v125 : float = v124 v121
                        let v128 : string = "num_complex::Complex::new($0, $1)"
                        let v129 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v125, 0.0) v128 
                        let v130 : string = "num_complex::Complex::powc($0, $1)"
                        let v131 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v129, v99) v130 
                        let v132 : string = "$0 / $1"
                        let v133 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v123, v131) v132 
                        let v134 : string = "$0 + $1"
                        let v135 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v120, v133) v134 
                        let v136 : int32 = v119 + 1
                        v117.l0 <- v136
                        v117.l1 <- v135
                        ()
                    let v137 : num_complex_Complex<float> = v117.l1
                    v137
                else
                    let v138 : string = "num_complex::Complex::new($0, $1)"
                    let v139 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v138 
                    let v140 : string = "$0 - $1"
                    let v141 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v139, v99) v140 
                    let v142 : string = $"        s = mpmath.gamma(s)"
                    let v143 : num_complex_Complex<float> = method3(v141)
                    let v144 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v142, v143)
                    let v145 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v146 : string = "$0.ok()"
                    let v147 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v144 v146 
                    let _v145 = v147 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v148 : string = "$0.ok()"
                    let v149 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v144 v148 
                    let _v145 = v149 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v150 : string = "$0.ok()"
                    let v151 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v144 v150 
                    let _v145 = v151 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v152 : num_complex_Complex<float> option = match v144 with Ok x -> Some x | Error _ -> None
                    let _v145 = v152 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v153 : num_complex_Complex<float> option = match v144 with Ok x -> Some x | Error _ -> None
                    let _v145 = v153 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v154 : num_complex_Complex<float> option = match v144 with Ok x -> Some x | Error _ -> None
                    let _v145 = v154 
                    #endif
#else
                    let v155 : num_complex_Complex<float> option = match v144 with Ok x -> Some x | Error _ -> None
                    let _v145 = v155 
                    #endif
                    let v156 : num_complex_Complex<float> option = _v145 
                    let v159 : (num_complex_Complex<float> -> US0) = method17()
                    let v160 : US0 option = v156 |> Option.map v159 
                    let v171 : US0 = US0_1
                    let v172 : US0 = v160 |> Option.defaultValue v171 
                    let v176 : string = "f64::NAN"
                    let v177 : float = Fable.Core.RustInterop.emitRustExpr () v176 
                    let v178 : string = "f64::NAN"
                    let v179 : float = Fable.Core.RustInterop.emitRustExpr () v178 
                    let v180 : string = "num_complex::Complex::new($0, $1)"
                    let v181 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v177, v179) v180 
                    let v184 : num_complex_Complex<float> =
                        match v172 with
                        | US0_1 -> (* None *)
                            v181
                        | US0_0(v182) -> (* Some *)
                            v182
                    let v185 : string = "num_complex::Complex::new($0, $1)"
                    let v186 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v185 
                    let v187 : string = "$0 * $1"
                    let v188 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v186, v99) v187 
                    let v189 : string = "num_complex::Complex::new($0, $1)"
                    let v190 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v189 
                    let v191 : string = "$0 / $1"
                    let v192 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v188, v190) v191 
                    let v193 : string = "$0.sin()"
                    let v194 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v192 v193 
                    let v195 : string = "$0.re"
                    let v196 : float = Fable.Core.RustInterop.emitRustExpr v99 v195 
                    let v197 : float = 1.0 - v196
                    let v198 : string = "$0.im"
                    let v199 : float = Fable.Core.RustInterop.emitRustExpr v99 v198 
                    let v200 : float =  -v199
                    let v201 : string = "num_complex::Complex::new($0, $1)"
                    let v202 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v197, v200) v201 
                    let v203 : string = "$0.re"
                    let v204 : float = Fable.Core.RustInterop.emitRustExpr v202 v203 
                    let v205 : bool = v204 <= 1.0
                    let v565 : num_complex_Complex<float> =
                        if v205 then
                            let v206 : string = "num_complex::Complex::new($0, $1)"
                            let v207 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v206 
                            v207
                        else
                            let v208 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                            Fable.Core.RustInterop.emitRustExpr struct (2, v202) v208 
                            let v209 : string = "$0.re"
                            let v210 : float = Fable.Core.RustInterop.emitRustExpr v202 v209 
                            let v211 : bool = v210 > 1.0
                            if v211 then
                                let v212 : string = "num_complex::Complex::new($0, $1)"
                                let v213 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v212 
                                let v214 : (int32 []) = Array.zeroCreate<int32> (10000)
                                let v215 : Mut0 = {l0 = 0} : Mut0
                                while method14(v215) do
                                    let v217 : int32 = v215.l0
                                    v214.[int v217] <- v217
                                    let v218 : int32 = v217 + 1
                                    v215.l0 <- v218
                                    ()
                                let v219 : int32 = v214.Length
                                let v220 : Mut2 = {l0 = 0; l1 = v213} : Mut2
                                while method15(v219, v220) do
                                    let v222 : int32 = v220.l0
                                    let v223 : num_complex_Complex<float> = v220.l1
                                    let v224 : int32 = v214.[int v222]
                                    let v225 : string = "num_complex::Complex::new($0, $1)"
                                    let v226 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v225 
                                    let v227 : (int32 -> float) = float
                                    let v228 : float = v227 v224
                                    let v231 : string = "num_complex::Complex::new($0, $1)"
                                    let v232 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v228, 0.0) v231 
                                    let v233 : string = "num_complex::Complex::powc($0, $1)"
                                    let v234 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v232, v202) v233 
                                    let v235 : string = "$0 / $1"
                                    let v236 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v226, v234) v235 
                                    let v237 : string = "$0 + $1"
                                    let v238 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v223, v236) v237 
                                    let v239 : int32 = v222 + 1
                                    v220.l0 <- v239
                                    v220.l1 <- v238
                                    ()
                                let v240 : num_complex_Complex<float> = v220.l1
                                v240
                            else
                                let v241 : string = "num_complex::Complex::new($0, $1)"
                                let v242 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v241 
                                let v243 : string = "$0 - $1"
                                let v244 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v242, v202) v243 
                                let v245 : string = $"        s = mpmath.gamma(s)"
                                let v246 : num_complex_Complex<float> = method3(v244)
                                let v247 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v245, v246)
                                let v248 : unit = ()
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v249 : string = "$0.ok()"
                                let v250 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v247 v249 
                                let _v248 = v250 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v251 : string = "$0.ok()"
                                let v252 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v247 v251 
                                let _v248 = v252 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v253 : string = "$0.ok()"
                                let v254 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v247 v253 
                                let _v248 = v254 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v255 : num_complex_Complex<float> option = match v247 with Ok x -> Some x | Error _ -> None
                                let _v248 = v255 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v256 : num_complex_Complex<float> option = match v247 with Ok x -> Some x | Error _ -> None
                                let _v248 = v256 
                                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                                let v257 : num_complex_Complex<float> option = match v247 with Ok x -> Some x | Error _ -> None
                                let _v248 = v257 
                                #endif
#else
                                let v258 : num_complex_Complex<float> option = match v247 with Ok x -> Some x | Error _ -> None
                                let _v248 = v258 
                                #endif
                                let v259 : num_complex_Complex<float> option = _v248 
                                let v262 : (num_complex_Complex<float> -> US0) = method17()
                                let v263 : US0 option = v259 |> Option.map v262 
                                let v274 : US0 = US0_1
                                let v275 : US0 = v263 |> Option.defaultValue v274 
                                let v279 : string = "f64::NAN"
                                let v280 : float = Fable.Core.RustInterop.emitRustExpr () v279 
                                let v281 : string = "f64::NAN"
                                let v282 : float = Fable.Core.RustInterop.emitRustExpr () v281 
                                let v283 : string = "num_complex::Complex::new($0, $1)"
                                let v284 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v280, v282) v283 
                                let v287 : num_complex_Complex<float> =
                                    match v275 with
                                    | US0_1 -> (* None *)
                                        v284
                                    | US0_0(v285) -> (* Some *)
                                        v285
                                let v288 : string = "num_complex::Complex::new($0, $1)"
                                let v289 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v288 
                                let v290 : string = "$0 * $1"
                                let v291 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v289, v202) v290 
                                let v292 : string = "num_complex::Complex::new($0, $1)"
                                let v293 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v292 
                                let v294 : string = "$0 / $1"
                                let v295 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v291, v293) v294 
                                let v296 : string = "$0.sin()"
                                let v297 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v295 v296 
                                let v298 : string = "$0.re"
                                let v299 : float = Fable.Core.RustInterop.emitRustExpr v202 v298 
                                let v300 : float = 1.0 - v299
                                let v301 : string = "$0.im"
                                let v302 : float = Fable.Core.RustInterop.emitRustExpr v202 v301 
                                let v303 : float =  -v302
                                let v304 : string = "num_complex::Complex::new($0, $1)"
                                let v305 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v300, v303) v304 
                                let v306 : string = "$0.re"
                                let v307 : float = Fable.Core.RustInterop.emitRustExpr v305 v306 
                                let v308 : bool = v307 <= 1.0
                                let v549 : num_complex_Complex<float> =
                                    if v308 then
                                        let v309 : string = "num_complex::Complex::new($0, $1)"
                                        let v310 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v309 
                                        v310
                                    else
                                        let v311 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                        Fable.Core.RustInterop.emitRustExpr struct (3, v305) v311 
                                        let v312 : string = "$0.re"
                                        let v313 : float = Fable.Core.RustInterop.emitRustExpr v305 v312 
                                        let v314 : bool = v313 > 1.0
                                        if v314 then
                                            let v315 : string = "num_complex::Complex::new($0, $1)"
                                            let v316 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v315 
                                            let v317 : (int32 []) = Array.zeroCreate<int32> (10000)
                                            let v318 : Mut0 = {l0 = 0} : Mut0
                                            while method14(v318) do
                                                let v320 : int32 = v318.l0
                                                v317.[int v320] <- v320
                                                let v321 : int32 = v320 + 1
                                                v318.l0 <- v321
                                                ()
                                            let v322 : int32 = v317.Length
                                            let v323 : Mut2 = {l0 = 0; l1 = v316} : Mut2
                                            while method15(v322, v323) do
                                                let v325 : int32 = v323.l0
                                                let v326 : num_complex_Complex<float> = v323.l1
                                                let v327 : int32 = v317.[int v325]
                                                let v328 : string = "num_complex::Complex::new($0, $1)"
                                                let v329 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v328 
                                                let v330 : (int32 -> float) = float
                                                let v331 : float = v330 v327
                                                let v334 : string = "num_complex::Complex::new($0, $1)"
                                                let v335 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v331, 0.0) v334 
                                                let v336 : string = "num_complex::Complex::powc($0, $1)"
                                                let v337 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v335, v305) v336 
                                                let v338 : string = "$0 / $1"
                                                let v339 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v329, v337) v338 
                                                let v340 : string = "$0 + $1"
                                                let v341 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v326, v339) v340 
                                                let v342 : int32 = v325 + 1
                                                v323.l0 <- v342
                                                v323.l1 <- v341
                                                ()
                                            let v343 : num_complex_Complex<float> = v323.l1
                                            v343
                                        else
                                            let v344 : string = "num_complex::Complex::new($0, $1)"
                                            let v345 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v344 
                                            let v346 : string = "$0 - $1"
                                            let v347 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v345, v305) v346 
                                            let v348 : string = $"        s = mpmath.gamma(s)"
                                            let v349 : num_complex_Complex<float> = method3(v347)
                                            let v350 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v348, v349)
                                            let v351 : unit = ()
                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                            let v352 : string = "$0.ok()"
                                            let v353 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v350 v352 
                                            let _v351 = v353 
                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                            let v354 : string = "$0.ok()"
                                            let v355 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v350 v354 
                                            let _v351 = v355 
                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                            let v356 : string = "$0.ok()"
                                            let v357 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v350 v356 
                                            let _v351 = v357 
                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                            let v358 : num_complex_Complex<float> option = match v350 with Ok x -> Some x | Error _ -> None
                                            let _v351 = v358 
                                            #endif
#if FABLE_COMPILER_PYTHON
                                            let v359 : num_complex_Complex<float> option = match v350 with Ok x -> Some x | Error _ -> None
                                            let _v351 = v359 
                                            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                                            let v360 : num_complex_Complex<float> option = match v350 with Ok x -> Some x | Error _ -> None
                                            let _v351 = v360 
                                            #endif
#else
                                            let v361 : num_complex_Complex<float> option = match v350 with Ok x -> Some x | Error _ -> None
                                            let _v351 = v361 
                                            #endif
                                            let v362 : num_complex_Complex<float> option = _v351 
                                            let v365 : (num_complex_Complex<float> -> US0) = method17()
                                            let v366 : US0 option = v362 |> Option.map v365 
                                            let v377 : US0 = US0_1
                                            let v378 : US0 = v366 |> Option.defaultValue v377 
                                            let v382 : string = "f64::NAN"
                                            let v383 : float = Fable.Core.RustInterop.emitRustExpr () v382 
                                            let v384 : string = "f64::NAN"
                                            let v385 : float = Fable.Core.RustInterop.emitRustExpr () v384 
                                            let v386 : string = "num_complex::Complex::new($0, $1)"
                                            let v387 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v383, v385) v386 
                                            let v390 : num_complex_Complex<float> =
                                                match v378 with
                                                | US0_1 -> (* None *)
                                                    v387
                                                | US0_0(v388) -> (* Some *)
                                                    v388
                                            let v391 : string = "num_complex::Complex::new($0, $1)"
                                            let v392 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v391 
                                            let v393 : string = "$0 * $1"
                                            let v394 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v392, v305) v393 
                                            let v395 : string = "num_complex::Complex::new($0, $1)"
                                            let v396 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v395 
                                            let v397 : string = "$0 / $1"
                                            let v398 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v394, v396) v397 
                                            let v399 : string = "$0.sin()"
                                            let v400 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v398 v399 
                                            let v401 : string = "$0.re"
                                            let v402 : float = Fable.Core.RustInterop.emitRustExpr v305 v401 
                                            let v403 : float = 1.0 - v402
                                            let v404 : string = "$0.im"
                                            let v405 : float = Fable.Core.RustInterop.emitRustExpr v305 v404 
                                            let v406 : float =  -v405
                                            let v407 : string = "num_complex::Complex::new($0, $1)"
                                            let v408 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v403, v406) v407 
                                            let v409 : string = "$0.re"
                                            let v410 : float = Fable.Core.RustInterop.emitRustExpr v408 v409 
                                            let v411 : bool = v410 <= 1.0
                                            let v533 : num_complex_Complex<float> =
                                                if v411 then
                                                    let v412 : string = "num_complex::Complex::new($0, $1)"
                                                    let v413 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v412 
                                                    v413
                                                else
                                                    let v414 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                                    Fable.Core.RustInterop.emitRustExpr struct (4, v408) v414 
                                                    let v415 : string = "$0.re"
                                                    let v416 : float = Fable.Core.RustInterop.emitRustExpr v408 v415 
                                                    let v417 : bool = v416 > 1.0
                                                    if v417 then
                                                        let v418 : string = "num_complex::Complex::new($0, $1)"
                                                        let v419 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v418 
                                                        let v420 : (int32 []) = Array.zeroCreate<int32> (10000)
                                                        let v421 : Mut0 = {l0 = 0} : Mut0
                                                        while method14(v421) do
                                                            let v423 : int32 = v421.l0
                                                            v420.[int v423] <- v423
                                                            let v424 : int32 = v423 + 1
                                                            v421.l0 <- v424
                                                            ()
                                                        let v425 : int32 = v420.Length
                                                        let v426 : Mut2 = {l0 = 0; l1 = v419} : Mut2
                                                        while method15(v425, v426) do
                                                            let v428 : int32 = v426.l0
                                                            let v429 : num_complex_Complex<float> = v426.l1
                                                            let v430 : int32 = v420.[int v428]
                                                            let v431 : string = "num_complex::Complex::new($0, $1)"
                                                            let v432 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v431 
                                                            let v433 : (int32 -> float) = float
                                                            let v434 : float = v433 v430
                                                            let v437 : string = "num_complex::Complex::new($0, $1)"
                                                            let v438 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v434, 0.0) v437 
                                                            let v439 : string = "num_complex::Complex::powc($0, $1)"
                                                            let v440 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v438, v408) v439 
                                                            let v441 : string = "$0 / $1"
                                                            let v442 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v432, v440) v441 
                                                            let v443 : string = "$0 + $1"
                                                            let v444 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v429, v442) v443 
                                                            let v445 : int32 = v428 + 1
                                                            v426.l0 <- v445
                                                            v426.l1 <- v444
                                                            ()
                                                        let v446 : num_complex_Complex<float> = v426.l1
                                                        v446
                                                    else
                                                        let v447 : string = "num_complex::Complex::new($0, $1)"
                                                        let v448 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v447 
                                                        let v449 : string = "$0 - $1"
                                                        let v450 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v448, v408) v449 
                                                        let v451 : string = $"        s = mpmath.gamma(s)"
                                                        let v452 : num_complex_Complex<float> = method3(v450)
                                                        let v453 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v451, v452)
                                                        let v454 : unit = ()
                                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                        let v455 : string = "$0.ok()"
                                                        let v456 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v453 v455 
                                                        let _v454 = v456 
                                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                                        let v457 : string = "$0.ok()"
                                                        let v458 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v453 v457 
                                                        let _v454 = v458 
                                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                        let v459 : string = "$0.ok()"
                                                        let v460 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v453 v459 
                                                        let _v454 = v460 
                                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                        let v461 : num_complex_Complex<float> option = match v453 with Ok x -> Some x | Error _ -> None
                                                        let _v454 = v461 
                                                        #endif
#if FABLE_COMPILER_PYTHON
                                                        let v462 : num_complex_Complex<float> option = match v453 with Ok x -> Some x | Error _ -> None
                                                        let _v454 = v462 
                                                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                                                        let v463 : num_complex_Complex<float> option = match v453 with Ok x -> Some x | Error _ -> None
                                                        let _v454 = v463 
                                                        #endif
#else
                                                        let v464 : num_complex_Complex<float> option = match v453 with Ok x -> Some x | Error _ -> None
                                                        let _v454 = v464 
                                                        #endif
                                                        let v465 : num_complex_Complex<float> option = _v454 
                                                        let v468 : (num_complex_Complex<float> -> US0) = method17()
                                                        let v469 : US0 option = v465 |> Option.map v468 
                                                        let v480 : US0 = US0_1
                                                        let v481 : US0 = v469 |> Option.defaultValue v480 
                                                        let v485 : string = "f64::NAN"
                                                        let v486 : float = Fable.Core.RustInterop.emitRustExpr () v485 
                                                        let v487 : string = "f64::NAN"
                                                        let v488 : float = Fable.Core.RustInterop.emitRustExpr () v487 
                                                        let v489 : string = "num_complex::Complex::new($0, $1)"
                                                        let v490 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v486, v488) v489 
                                                        let v493 : num_complex_Complex<float> =
                                                            match v481 with
                                                            | US0_1 -> (* None *)
                                                                v490
                                                            | US0_0(v491) -> (* Some *)
                                                                v491
                                                        let v494 : string = "num_complex::Complex::new($0, $1)"
                                                        let v495 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v494 
                                                        let v496 : string = "$0 * $1"
                                                        let v497 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v495, v408) v496 
                                                        let v498 : string = "num_complex::Complex::new($0, $1)"
                                                        let v499 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v498 
                                                        let v500 : string = "$0 / $1"
                                                        let v501 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v497, v499) v500 
                                                        let v502 : string = "$0.sin()"
                                                        let v503 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v501 v502 
                                                        let v504 : string = "$0.re"
                                                        let v505 : float = Fable.Core.RustInterop.emitRustExpr v408 v504 
                                                        let v506 : float = 1.0 - v505
                                                        let v507 : string = "$0.im"
                                                        let v508 : float = Fable.Core.RustInterop.emitRustExpr v408 v507 
                                                        let v509 : float =  -v508
                                                        let v510 : string = "num_complex::Complex::new($0, $1)"
                                                        let v511 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v506, v509) v510 
                                                        let v512 : string = "$0.re"
                                                        let v513 : float = Fable.Core.RustInterop.emitRustExpr v511 v512 
                                                        let v514 : bool = v513 <= 1.0
                                                        let v517 : num_complex_Complex<float> =
                                                            if v514 then
                                                                let v515 : string = "num_complex::Complex::new($0, $1)"
                                                                let v516 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v515 
                                                                v516
                                                            else
                                                                v511
                                                        let v518 : string = "num_complex::Complex::new($0, $1)"
                                                        let v519 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v518 
                                                        let v520 : string = "num_complex::Complex::new($0, $1)"
                                                        let v521 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v520 
                                                        let v522 : string = "num_complex::Complex::powc($0, $1)"
                                                        let v523 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v521, v408) v522 
                                                        let v524 : string = "$0 * $1"
                                                        let v525 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v519, v523) v524 
                                                        let v526 : string = "$0 * $1"
                                                        let v527 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v525, v503) v526 
                                                        let v528 : string = "$0 * $1"
                                                        let v529 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v527, v493) v528 
                                                        let v530 : string = "$0 * $1"
                                                        let v531 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v529, v517) v530 
                                                        v531
                                            let v534 : string = "num_complex::Complex::new($0, $1)"
                                            let v535 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v534 
                                            let v536 : string = "num_complex::Complex::new($0, $1)"
                                            let v537 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v536 
                                            let v538 : string = "num_complex::Complex::powc($0, $1)"
                                            let v539 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v537, v305) v538 
                                            let v540 : string = "$0 * $1"
                                            let v541 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v535, v539) v540 
                                            let v542 : string = "$0 * $1"
                                            let v543 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v541, v400) v542 
                                            let v544 : string = "$0 * $1"
                                            let v545 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v543, v390) v544 
                                            let v546 : string = "$0 * $1"
                                            let v547 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v545, v533) v546 
                                            v547
                                let v550 : string = "num_complex::Complex::new($0, $1)"
                                let v551 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v550 
                                let v552 : string = "num_complex::Complex::new($0, $1)"
                                let v553 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v552 
                                let v554 : string = "num_complex::Complex::powc($0, $1)"
                                let v555 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v553, v202) v554 
                                let v556 : string = "$0 * $1"
                                let v557 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v551, v555) v556 
                                let v558 : string = "$0 * $1"
                                let v559 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v557, v297) v558 
                                let v560 : string = "$0 * $1"
                                let v561 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v559, v287) v560 
                                let v562 : string = "$0 * $1"
                                let v563 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v561, v549) v562 
                                v563
                    let v566 : string = "num_complex::Complex::new($0, $1)"
                    let v567 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v566 
                    let v568 : string = "num_complex::Complex::new($0, $1)"
                    let v569 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v568 
                    let v570 : string = "num_complex::Complex::powc($0, $1)"
                    let v571 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v569, v99) v570 
                    let v572 : string = "$0 * $1"
                    let v573 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v567, v571) v572 
                    let v574 : string = "$0 * $1"
                    let v575 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v573, v194) v574 
                    let v576 : string = "$0 * $1"
                    let v577 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v575, v184) v576 
                    let v578 : string = "$0 * $1"
                    let v579 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v577, v565) v578 
                    v579
        let v582 : string = "num_complex::Complex::new($0, $1)"
        let v583 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v582 
        let v584 : string = "num_complex::Complex::new($0, $1)"
        let v585 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v584 
        let v586 : string = "num_complex::Complex::powc($0, $1)"
        let v587 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v585, v1) v586 
        let v588 : string = "$0 * $1"
        let v589 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v583, v587) v588 
        let v590 : string = "$0 * $1"
        let v591 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v589, v91) v590 
        let v592 : string = "$0 * $1"
        let v593 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v591, v81) v592 
        let v594 : string = "$0 * $1"
        let v595 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v593, v581) v594 
        v595
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
