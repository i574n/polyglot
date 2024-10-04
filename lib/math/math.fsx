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
#else
    let v57 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _v44 = v57 
    #endif
    let v60 : Ref<Str> = _v44 
    let v65 : string = "pyo3::types::PyModule::from_code_bound(v43, $0, \"\", \"\")"
    let v66 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v60 v65 
    let v67 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v68 : bool = Fable.Core.RustInterop.emitRustExpr v66 v67 
    let v69 : string = "x"
    let v70 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v69 
    let v71 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v72 : string = "format!(\"{}\", $0)"
    let v73 : std_string_String = Fable.Core.RustInterop.emitRustExpr v70 v72 
    let _v71 = v73 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v74 : string = "format!(\"{}\", $0)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr v70 v74 
    let _v71 = v75 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v76 : string = "format!(\"{}\", $0)"
    let v77 : std_string_String = Fable.Core.RustInterop.emitRustExpr v70 v76 
    let _v71 = v77 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v78 : std_string_String = null |> unbox<std_string_String>
    let _v71 = v78 
    #endif
#if FABLE_COMPILER_PYTHON
    let v81 : std_string_String = null |> unbox<std_string_String>
    let _v71 = v81 
    #endif
#else
    let v84 : std_string_String = null |> unbox<std_string_String>
    let _v71 = v84 
    #endif
    let v87 : std_string_String = _v71 
    let v92 : string = "true; $0 })"
    let v93 : bool = Fable.Core.RustInterop.emitRustExpr v87 v92 
    let v94 : string = "_result_map_error__"
    let v95 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v94 
    let v96 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v97 : string = "$0.unwrap()"
    let v98 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v95 v97 
    let _v96 = v98 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v99 : string = "$0.unwrap()"
    let v100 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v95 v99 
    let _v96 = v100 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v101 : string = "$0.unwrap()"
    let v102 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v95 v101 
    let _v96 = v102 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v103 : pyo3_Bound<pyo3_types_PyModule> = match v95 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v96 = v103 
    #endif
#if FABLE_COMPILER_PYTHON
    let v104 : pyo3_Bound<pyo3_types_PyModule> = match v95 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v96 = v104 
    #endif
#else
    let v105 : pyo3_Bound<pyo3_types_PyModule> = match v95 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v96 = v105 
    #endif
    let v106 : pyo3_Bound<pyo3_types_PyModule> = _v96 
    let v109 : string = method8()
    let v110 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v111 : string = "&*$0"
    let v112 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v109 v111 
    let _v110 = v112 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v113 : string = "&*$0"
    let v114 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v109 v113 
    let _v110 = v114 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v115 : string = "&*$0"
    let v116 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v109 v115 
    let _v110 = v116 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v117 : Ref<Str> = v109 |> unbox<Ref<Str>>
    let _v110 = v117 
    #endif
#if FABLE_COMPILER_PYTHON
    let v120 : Ref<Str> = v109 |> unbox<Ref<Str>>
    let _v110 = v120 
    #endif
#else
    let v123 : Ref<Str> = v109 |> unbox<Ref<Str>>
    let _v110 = v123 
    #endif
    let v126 : Ref<Str> = _v110 
    let v131 : pyo3_Bound<pyo3_types_PyModule> = method9(v106)
    let v132 : string = "v131.getattr($0)"
    let v133 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v126 v132 
    let v134 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v135 : bool = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let v136 : string = "x"
    let v137 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v136 
    let v138 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v139 : string = "format!(\"{}\", $0)"
    let v140 : std_string_String = Fable.Core.RustInterop.emitRustExpr v137 v139 
    let _v138 = v140 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v141 : string = "format!(\"{}\", $0)"
    let v142 : std_string_String = Fable.Core.RustInterop.emitRustExpr v137 v141 
    let _v138 = v142 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v143 : string = "format!(\"{}\", $0)"
    let v144 : std_string_String = Fable.Core.RustInterop.emitRustExpr v137 v143 
    let _v138 = v144 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v145 : std_string_String = null |> unbox<std_string_String>
    let _v138 = v145 
    #endif
#if FABLE_COMPILER_PYTHON
    let v148 : std_string_String = null |> unbox<std_string_String>
    let _v138 = v148 
    #endif
#else
    let v151 : std_string_String = null |> unbox<std_string_String>
    let _v138 = v151 
    #endif
    let v154 : std_string_String = _v138 
    let v159 : string = "true; $0 })"
    let v160 : bool = Fable.Core.RustInterop.emitRustExpr v154 v159 
    let v161 : string = "_result_map_error__"
    let v162 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v161 
    let v163 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v164 : string = "$0.unwrap()"
    let v165 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v162 v164 
    let _v163 = v165 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v166 : string = "$0.unwrap()"
    let v167 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v162 v166 
    let _v163 = v167 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v168 : string = "$0.unwrap()"
    let v169 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v162 v168 
    let _v163 = v169 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v170 : pyo3_Bound<pyo3_PyAny> = match v162 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v163 = v170 
    #endif
#if FABLE_COMPILER_PYTHON
    let v171 : pyo3_Bound<pyo3_PyAny> = match v162 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v163 = v171 
    #endif
#else
    let v172 : pyo3_Bound<pyo3_PyAny> = match v162 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v163 = v172 
    #endif
    let v173 : pyo3_Bound<pyo3_PyAny> = _v163 
    let v176 : (bool * (float * float)) = method10(v42)
    let v177 : pyo3_Bound<pyo3_PyAny> = method11(v173)
    let v178 : string = "pyo3::prelude::PyAnyMethods::call(&v177, ((*v176).0, *(*v176).1), None)"
    let v179 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v178 
    let v180 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v181 : bool = Fable.Core.RustInterop.emitRustExpr v179 v180 
    let v182 : string = "x"
    let v183 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v182 
    let v184 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v185 : string = "format!(\"{}\", $0)"
    let v186 : std_string_String = Fable.Core.RustInterop.emitRustExpr v183 v185 
    let _v184 = v186 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v187 : string = "format!(\"{}\", $0)"
    let v188 : std_string_String = Fable.Core.RustInterop.emitRustExpr v183 v187 
    let _v184 = v188 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v189 : string = "format!(\"{}\", $0)"
    let v190 : std_string_String = Fable.Core.RustInterop.emitRustExpr v183 v189 
    let _v184 = v190 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v191 : std_string_String = null |> unbox<std_string_String>
    let _v184 = v191 
    #endif
#if FABLE_COMPILER_PYTHON
    let v194 : std_string_String = null |> unbox<std_string_String>
    let _v184 = v194 
    #endif
#else
    let v197 : std_string_String = null |> unbox<std_string_String>
    let _v184 = v197 
    #endif
    let v200 : std_string_String = _v184 
    let v205 : string = "true; $0 })"
    let v206 : bool = Fable.Core.RustInterop.emitRustExpr v200 v205 
    let v207 : string = "_result_map_error__"
    let v208 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v207 
    let v209 : string = "$0?"
    let v210 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v208 v209 
    let v211 : pyo3_Bound<pyo3_PyAny> = method12(v210)
    let v212 : string = "v211.extract()"
    let v213 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v212 
    let v214 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v215 : bool = Fable.Core.RustInterop.emitRustExpr v213 v214 
    let v216 : string = "x"
    let v217 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v216 
    let v218 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v219 : string = "format!(\"{}\", $0)"
    let v220 : std_string_String = Fable.Core.RustInterop.emitRustExpr v217 v219 
    let _v218 = v220 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v221 : string = "format!(\"{}\", $0)"
    let v222 : std_string_String = Fable.Core.RustInterop.emitRustExpr v217 v221 
    let _v218 = v222 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v223 : string = "format!(\"{}\", $0)"
    let v224 : std_string_String = Fable.Core.RustInterop.emitRustExpr v217 v223 
    let _v218 = v224 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v225 : std_string_String = null |> unbox<std_string_String>
    let _v218 = v225 
    #endif
#if FABLE_COMPILER_PYTHON
    let v228 : std_string_String = null |> unbox<std_string_String>
    let _v218 = v228 
    #endif
#else
    let v231 : std_string_String = null |> unbox<std_string_String>
    let _v218 = v231 
    #endif
    let v234 : std_string_String = _v218 
    let v239 : string = "true; $0 })"
    let v240 : bool = Fable.Core.RustInterop.emitRustExpr v234 v239 
    let v241 : string = "_result_map_error__"
    let v242 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v241 
    let v243 : string = "$0?"
    let struct (v244 : float, v245 : float) = Fable.Core.RustInterop.emitRustExpr v242 v243 
    let v246 : string = "num_complex::Complex::new($0, $1)"
    let v247 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v244, v245) v246 
    let v248 : Result<num_complex_Complex<float>, std_string_String> = Ok v247 
    v248
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
#else
    let v57 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _v44 = v57 
    #endif
    let v60 : Ref<Str> = _v44 
    let v65 : string = "pyo3::types::PyModule::from_code_bound(v43, $0, \"\", \"\")"
    let v66 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v60 v65 
    let v67 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v68 : bool = Fable.Core.RustInterop.emitRustExpr v66 v67 
    let v69 : string = "x"
    let v70 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v69 
    let v71 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v72 : string = "format!(\"{}\", $0)"
    let v73 : std_string_String = Fable.Core.RustInterop.emitRustExpr v70 v72 
    let _v71 = v73 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v74 : string = "format!(\"{}\", $0)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr v70 v74 
    let _v71 = v75 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v76 : string = "format!(\"{}\", $0)"
    let v77 : std_string_String = Fable.Core.RustInterop.emitRustExpr v70 v76 
    let _v71 = v77 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v78 : std_string_String = null |> unbox<std_string_String>
    let _v71 = v78 
    #endif
#if FABLE_COMPILER_PYTHON
    let v81 : std_string_String = null |> unbox<std_string_String>
    let _v71 = v81 
    #endif
#else
    let v84 : std_string_String = null |> unbox<std_string_String>
    let _v71 = v84 
    #endif
    let v87 : std_string_String = _v71 
    let v92 : string = "true; $0 })"
    let v93 : bool = Fable.Core.RustInterop.emitRustExpr v87 v92 
    let v94 : string = "_result_map_error__"
    let v95 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v94 
    let v96 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v97 : string = "$0.unwrap()"
    let v98 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v95 v97 
    let _v96 = v98 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v99 : string = "$0.unwrap()"
    let v100 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v95 v99 
    let _v96 = v100 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v101 : string = "$0.unwrap()"
    let v102 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v95 v101 
    let _v96 = v102 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v103 : pyo3_Bound<pyo3_types_PyModule> = match v95 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v96 = v103 
    #endif
#if FABLE_COMPILER_PYTHON
    let v104 : pyo3_Bound<pyo3_types_PyModule> = match v95 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v96 = v104 
    #endif
#else
    let v105 : pyo3_Bound<pyo3_types_PyModule> = match v95 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v96 = v105 
    #endif
    let v106 : pyo3_Bound<pyo3_types_PyModule> = _v96 
    let v109 : string = method8()
    let v110 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v111 : string = "&*$0"
    let v112 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v109 v111 
    let _v110 = v112 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v113 : string = "&*$0"
    let v114 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v109 v113 
    let _v110 = v114 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v115 : string = "&*$0"
    let v116 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v109 v115 
    let _v110 = v116 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v117 : Ref<Str> = v109 |> unbox<Ref<Str>>
    let _v110 = v117 
    #endif
#if FABLE_COMPILER_PYTHON
    let v120 : Ref<Str> = v109 |> unbox<Ref<Str>>
    let _v110 = v120 
    #endif
#else
    let v123 : Ref<Str> = v109 |> unbox<Ref<Str>>
    let _v110 = v123 
    #endif
    let v126 : Ref<Str> = _v110 
    let v131 : pyo3_Bound<pyo3_types_PyModule> = method9(v106)
    let v132 : string = "v131.getattr($0)"
    let v133 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v126 v132 
    let v134 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v135 : bool = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let v136 : string = "x"
    let v137 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v136 
    let v138 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v139 : string = "format!(\"{}\", $0)"
    let v140 : std_string_String = Fable.Core.RustInterop.emitRustExpr v137 v139 
    let _v138 = v140 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v141 : string = "format!(\"{}\", $0)"
    let v142 : std_string_String = Fable.Core.RustInterop.emitRustExpr v137 v141 
    let _v138 = v142 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v143 : string = "format!(\"{}\", $0)"
    let v144 : std_string_String = Fable.Core.RustInterop.emitRustExpr v137 v143 
    let _v138 = v144 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v145 : std_string_String = null |> unbox<std_string_String>
    let _v138 = v145 
    #endif
#if FABLE_COMPILER_PYTHON
    let v148 : std_string_String = null |> unbox<std_string_String>
    let _v138 = v148 
    #endif
#else
    let v151 : std_string_String = null |> unbox<std_string_String>
    let _v138 = v151 
    #endif
    let v154 : std_string_String = _v138 
    let v159 : string = "true; $0 })"
    let v160 : bool = Fable.Core.RustInterop.emitRustExpr v154 v159 
    let v161 : string = "_result_map_error__"
    let v162 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v161 
    let v163 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v164 : string = "$0.unwrap()"
    let v165 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v162 v164 
    let _v163 = v165 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v166 : string = "$0.unwrap()"
    let v167 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v162 v166 
    let _v163 = v167 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v168 : string = "$0.unwrap()"
    let v169 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v162 v168 
    let _v163 = v169 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v170 : pyo3_Bound<pyo3_PyAny> = match v162 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v163 = v170 
    #endif
#if FABLE_COMPILER_PYTHON
    let v171 : pyo3_Bound<pyo3_PyAny> = match v162 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v163 = v171 
    #endif
#else
    let v172 : pyo3_Bound<pyo3_PyAny> = match v162 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v163 = v172 
    #endif
    let v173 : pyo3_Bound<pyo3_PyAny> = _v163 
    let v176 : (bool * (float * float)) = method10(v42)
    let v177 : pyo3_Bound<pyo3_PyAny> = method11(v173)
    let v178 : string = "pyo3::prelude::PyAnyMethods::call(&v177, ((*v176).0, *(*v176).1), None)"
    let v179 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v178 
    let v180 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v181 : bool = Fable.Core.RustInterop.emitRustExpr v179 v180 
    let v182 : string = "x"
    let v183 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v182 
    let v184 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v185 : string = "format!(\"{}\", $0)"
    let v186 : std_string_String = Fable.Core.RustInterop.emitRustExpr v183 v185 
    let _v184 = v186 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v187 : string = "format!(\"{}\", $0)"
    let v188 : std_string_String = Fable.Core.RustInterop.emitRustExpr v183 v187 
    let _v184 = v188 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v189 : string = "format!(\"{}\", $0)"
    let v190 : std_string_String = Fable.Core.RustInterop.emitRustExpr v183 v189 
    let _v184 = v190 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v191 : std_string_String = null |> unbox<std_string_String>
    let _v184 = v191 
    #endif
#if FABLE_COMPILER_PYTHON
    let v194 : std_string_String = null |> unbox<std_string_String>
    let _v184 = v194 
    #endif
#else
    let v197 : std_string_String = null |> unbox<std_string_String>
    let _v184 = v197 
    #endif
    let v200 : std_string_String = _v184 
    let v205 : string = "true; $0 })"
    let v206 : bool = Fable.Core.RustInterop.emitRustExpr v200 v205 
    let v207 : string = "_result_map_error__"
    let v208 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v207 
    let v209 : string = "$0?"
    let v210 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v208 v209 
    let v211 : pyo3_Bound<pyo3_PyAny> = method12(v210)
    let v212 : string = "v211.extract()"
    let v213 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v212 
    let v214 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v215 : bool = Fable.Core.RustInterop.emitRustExpr v213 v214 
    let v216 : string = "x"
    let v217 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v216 
    let v218 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v219 : string = "format!(\"{}\", $0)"
    let v220 : std_string_String = Fable.Core.RustInterop.emitRustExpr v217 v219 
    let _v218 = v220 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v221 : string = "format!(\"{}\", $0)"
    let v222 : std_string_String = Fable.Core.RustInterop.emitRustExpr v217 v221 
    let _v218 = v222 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v223 : string = "format!(\"{}\", $0)"
    let v224 : std_string_String = Fable.Core.RustInterop.emitRustExpr v217 v223 
    let _v218 = v224 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v225 : std_string_String = null |> unbox<std_string_String>
    let _v218 = v225 
    #endif
#if FABLE_COMPILER_PYTHON
    let v228 : std_string_String = null |> unbox<std_string_String>
    let _v218 = v228 
    #endif
#else
    let v231 : std_string_String = null |> unbox<std_string_String>
    let _v218 = v231 
    #endif
    let v234 : std_string_String = _v218 
    let v239 : string = "true; $0 })"
    let v240 : bool = Fable.Core.RustInterop.emitRustExpr v234 v239 
    let v241 : string = "_result_map_error__"
    let v242 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v241 
    let v243 : string = "$0?"
    let struct (v244 : float, v245 : float) = Fable.Core.RustInterop.emitRustExpr v242 v243 
    let v246 : string = "num_complex::Complex::new($0, $1)"
    let v247 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v244, v245) v246 
    let v248 : Result<num_complex_Complex<float>, std_string_String> = Ok v247 
    v248
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
#else
        let v49 : num_complex_Complex<float> option = match v39 with Ok x -> Some x | Error _ -> None
        let _v40 = v49 
        #endif
        let v50 : num_complex_Complex<float> option = _v40 
        let v53 : (num_complex_Complex<float> -> US0) = method17()
        let v54 : US0 option = v50 |> Option.map v53 
        let v65 : US0 = US0_1
        let v66 : US0 = v54 |> Option.defaultValue v65 
        let v70 : string = "f64::NAN"
        let v71 : float = Fable.Core.RustInterop.emitRustExpr () v70 
        let v72 : string = "f64::NAN"
        let v73 : float = Fable.Core.RustInterop.emitRustExpr () v72 
        let v74 : string = "num_complex::Complex::new($0, $1)"
        let v75 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v71, v73) v74 
        let v78 : num_complex_Complex<float> =
            match v66 with
            | US0_1 -> (* None *)
                v75
            | US0_0(v76) -> (* Some *)
                v76
        let v79 : string = "num_complex::Complex::new($0, $1)"
        let v80 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v79 
        let v81 : string = "$0 * $1"
        let v82 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v80, v1) v81 
        let v83 : string = "num_complex::Complex::new($0, $1)"
        let v84 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v83 
        let v85 : string = "$0 / $1"
        let v86 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v82, v84) v85 
        let v87 : string = "$0.sin()"
        let v88 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v86 v87 
        let v89 : string = "$0.re"
        let v90 : float = Fable.Core.RustInterop.emitRustExpr v1 v89 
        let v91 : float = 1.0 - v90
        let v92 : string = "$0.im"
        let v93 : float = Fable.Core.RustInterop.emitRustExpr v1 v92 
        let v94 : float =  -v93
        let v95 : string = "num_complex::Complex::new($0, $1)"
        let v96 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v91, v94) v95 
        let v97 : string = "$0.re"
        let v98 : float = Fable.Core.RustInterop.emitRustExpr v96 v97 
        let v99 : bool = v98 <= 1.0
        let v566 : num_complex_Complex<float> =
            if v99 then
                let v100 : string = "num_complex::Complex::new($0, $1)"
                let v101 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v100 
                v101
            else
                let v102 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                Fable.Core.RustInterop.emitRustExpr struct (1, v96) v102 
                let v103 : string = "$0.re"
                let v104 : float = Fable.Core.RustInterop.emitRustExpr v96 v103 
                let v105 : bool = v104 > 1.0
                if v105 then
                    let v106 : string = "num_complex::Complex::new($0, $1)"
                    let v107 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v106 
                    let v108 : (int32 []) = Array.zeroCreate<int32> (10000)
                    let v109 : Mut0 = {l0 = 0} : Mut0
                    while method14(v109) do
                        let v111 : int32 = v109.l0
                        v108.[int v111] <- v111
                        let v112 : int32 = v111 + 1
                        v109.l0 <- v112
                        ()
                    let v113 : int32 = v108.Length
                    let v114 : Mut2 = {l0 = 0; l1 = v107} : Mut2
                    while method15(v113, v114) do
                        let v116 : int32 = v114.l0
                        let v117 : num_complex_Complex<float> = v114.l1
                        let v118 : int32 = v108.[int v116]
                        let v119 : string = "num_complex::Complex::new($0, $1)"
                        let v120 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v119 
                        let v121 : (int32 -> float) = float
                        let v122 : float = v121 v118
                        let v123 : string = "num_complex::Complex::new($0, $1)"
                        let v124 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v122, 0.0) v123 
                        let v125 : string = "num_complex::Complex::powc($0, $1)"
                        let v126 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v124, v96) v125 
                        let v127 : string = "$0 / $1"
                        let v128 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v120, v126) v127 
                        let v129 : string = "$0 + $1"
                        let v130 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v117, v128) v129 
                        let v131 : int32 = v116 + 1
                        v114.l0 <- v131
                        v114.l1 <- v130
                        ()
                    let v132 : num_complex_Complex<float> = v114.l1
                    v132
                else
                    let v133 : string = "num_complex::Complex::new($0, $1)"
                    let v134 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v133 
                    let v135 : string = "$0 - $1"
                    let v136 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v134, v96) v135 
                    let v137 : string = $"        s = mpmath.gamma(s)"
                    let v138 : num_complex_Complex<float> = method3(v136)
                    let v139 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v137, v138)
                    let v140 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v141 : string = "$0.ok()"
                    let v142 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v139 v141 
                    let _v140 = v142 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v143 : string = "$0.ok()"
                    let v144 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v139 v143 
                    let _v140 = v144 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v145 : string = "$0.ok()"
                    let v146 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v139 v145 
                    let _v140 = v146 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v147 : num_complex_Complex<float> option = match v139 with Ok x -> Some x | Error _ -> None
                    let _v140 = v147 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v148 : num_complex_Complex<float> option = match v139 with Ok x -> Some x | Error _ -> None
                    let _v140 = v148 
                    #endif
#else
                    let v149 : num_complex_Complex<float> option = match v139 with Ok x -> Some x | Error _ -> None
                    let _v140 = v149 
                    #endif
                    let v150 : num_complex_Complex<float> option = _v140 
                    let v153 : (num_complex_Complex<float> -> US0) = method17()
                    let v154 : US0 option = v150 |> Option.map v153 
                    let v165 : US0 = US0_1
                    let v166 : US0 = v154 |> Option.defaultValue v165 
                    let v170 : string = "f64::NAN"
                    let v171 : float = Fable.Core.RustInterop.emitRustExpr () v170 
                    let v172 : string = "f64::NAN"
                    let v173 : float = Fable.Core.RustInterop.emitRustExpr () v172 
                    let v174 : string = "num_complex::Complex::new($0, $1)"
                    let v175 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v171, v173) v174 
                    let v178 : num_complex_Complex<float> =
                        match v166 with
                        | US0_1 -> (* None *)
                            v175
                        | US0_0(v176) -> (* Some *)
                            v176
                    let v179 : string = "num_complex::Complex::new($0, $1)"
                    let v180 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v179 
                    let v181 : string = "$0 * $1"
                    let v182 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v180, v96) v181 
                    let v183 : string = "num_complex::Complex::new($0, $1)"
                    let v184 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v183 
                    let v185 : string = "$0 / $1"
                    let v186 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v182, v184) v185 
                    let v187 : string = "$0.sin()"
                    let v188 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v186 v187 
                    let v189 : string = "$0.re"
                    let v190 : float = Fable.Core.RustInterop.emitRustExpr v96 v189 
                    let v191 : float = 1.0 - v190
                    let v192 : string = "$0.im"
                    let v193 : float = Fable.Core.RustInterop.emitRustExpr v96 v192 
                    let v194 : float =  -v193
                    let v195 : string = "num_complex::Complex::new($0, $1)"
                    let v196 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v191, v194) v195 
                    let v197 : string = "$0.re"
                    let v198 : float = Fable.Core.RustInterop.emitRustExpr v196 v197 
                    let v199 : bool = v198 <= 1.0
                    let v550 : num_complex_Complex<float> =
                        if v199 then
                            let v200 : string = "num_complex::Complex::new($0, $1)"
                            let v201 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v200 
                            v201
                        else
                            let v202 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                            Fable.Core.RustInterop.emitRustExpr struct (2, v196) v202 
                            let v203 : string = "$0.re"
                            let v204 : float = Fable.Core.RustInterop.emitRustExpr v196 v203 
                            let v205 : bool = v204 > 1.0
                            if v205 then
                                let v206 : string = "num_complex::Complex::new($0, $1)"
                                let v207 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v206 
                                let v208 : (int32 []) = Array.zeroCreate<int32> (10000)
                                let v209 : Mut0 = {l0 = 0} : Mut0
                                while method14(v209) do
                                    let v211 : int32 = v209.l0
                                    v208.[int v211] <- v211
                                    let v212 : int32 = v211 + 1
                                    v209.l0 <- v212
                                    ()
                                let v213 : int32 = v208.Length
                                let v214 : Mut2 = {l0 = 0; l1 = v207} : Mut2
                                while method15(v213, v214) do
                                    let v216 : int32 = v214.l0
                                    let v217 : num_complex_Complex<float> = v214.l1
                                    let v218 : int32 = v208.[int v216]
                                    let v219 : string = "num_complex::Complex::new($0, $1)"
                                    let v220 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v219 
                                    let v221 : (int32 -> float) = float
                                    let v222 : float = v221 v218
                                    let v223 : string = "num_complex::Complex::new($0, $1)"
                                    let v224 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v222, 0.0) v223 
                                    let v225 : string = "num_complex::Complex::powc($0, $1)"
                                    let v226 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v224, v196) v225 
                                    let v227 : string = "$0 / $1"
                                    let v228 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v220, v226) v227 
                                    let v229 : string = "$0 + $1"
                                    let v230 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v217, v228) v229 
                                    let v231 : int32 = v216 + 1
                                    v214.l0 <- v231
                                    v214.l1 <- v230
                                    ()
                                let v232 : num_complex_Complex<float> = v214.l1
                                v232
                            else
                                let v233 : string = "num_complex::Complex::new($0, $1)"
                                let v234 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v233 
                                let v235 : string = "$0 - $1"
                                let v236 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v234, v196) v235 
                                let v237 : string = $"        s = mpmath.gamma(s)"
                                let v238 : num_complex_Complex<float> = method3(v236)
                                let v239 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v237, v238)
                                let v240 : unit = ()
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v241 : string = "$0.ok()"
                                let v242 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v239 v241 
                                let _v240 = v242 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v243 : string = "$0.ok()"
                                let v244 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v239 v243 
                                let _v240 = v244 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v245 : string = "$0.ok()"
                                let v246 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v239 v245 
                                let _v240 = v246 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v247 : num_complex_Complex<float> option = match v239 with Ok x -> Some x | Error _ -> None
                                let _v240 = v247 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v248 : num_complex_Complex<float> option = match v239 with Ok x -> Some x | Error _ -> None
                                let _v240 = v248 
                                #endif
#else
                                let v249 : num_complex_Complex<float> option = match v239 with Ok x -> Some x | Error _ -> None
                                let _v240 = v249 
                                #endif
                                let v250 : num_complex_Complex<float> option = _v240 
                                let v253 : (num_complex_Complex<float> -> US0) = method17()
                                let v254 : US0 option = v250 |> Option.map v253 
                                let v265 : US0 = US0_1
                                let v266 : US0 = v254 |> Option.defaultValue v265 
                                let v270 : string = "f64::NAN"
                                let v271 : float = Fable.Core.RustInterop.emitRustExpr () v270 
                                let v272 : string = "f64::NAN"
                                let v273 : float = Fable.Core.RustInterop.emitRustExpr () v272 
                                let v274 : string = "num_complex::Complex::new($0, $1)"
                                let v275 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v271, v273) v274 
                                let v278 : num_complex_Complex<float> =
                                    match v266 with
                                    | US0_1 -> (* None *)
                                        v275
                                    | US0_0(v276) -> (* Some *)
                                        v276
                                let v279 : string = "num_complex::Complex::new($0, $1)"
                                let v280 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v279 
                                let v281 : string = "$0 * $1"
                                let v282 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v280, v196) v281 
                                let v283 : string = "num_complex::Complex::new($0, $1)"
                                let v284 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v283 
                                let v285 : string = "$0 / $1"
                                let v286 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v282, v284) v285 
                                let v287 : string = "$0.sin()"
                                let v288 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v286 v287 
                                let v289 : string = "$0.re"
                                let v290 : float = Fable.Core.RustInterop.emitRustExpr v196 v289 
                                let v291 : float = 1.0 - v290
                                let v292 : string = "$0.im"
                                let v293 : float = Fable.Core.RustInterop.emitRustExpr v196 v292 
                                let v294 : float =  -v293
                                let v295 : string = "num_complex::Complex::new($0, $1)"
                                let v296 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v291, v294) v295 
                                let v297 : string = "$0.re"
                                let v298 : float = Fable.Core.RustInterop.emitRustExpr v296 v297 
                                let v299 : bool = v298 <= 1.0
                                let v534 : num_complex_Complex<float> =
                                    if v299 then
                                        let v300 : string = "num_complex::Complex::new($0, $1)"
                                        let v301 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v300 
                                        v301
                                    else
                                        let v302 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                        Fable.Core.RustInterop.emitRustExpr struct (3, v296) v302 
                                        let v303 : string = "$0.re"
                                        let v304 : float = Fable.Core.RustInterop.emitRustExpr v296 v303 
                                        let v305 : bool = v304 > 1.0
                                        if v305 then
                                            let v306 : string = "num_complex::Complex::new($0, $1)"
                                            let v307 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v306 
                                            let v308 : (int32 []) = Array.zeroCreate<int32> (10000)
                                            let v309 : Mut0 = {l0 = 0} : Mut0
                                            while method14(v309) do
                                                let v311 : int32 = v309.l0
                                                v308.[int v311] <- v311
                                                let v312 : int32 = v311 + 1
                                                v309.l0 <- v312
                                                ()
                                            let v313 : int32 = v308.Length
                                            let v314 : Mut2 = {l0 = 0; l1 = v307} : Mut2
                                            while method15(v313, v314) do
                                                let v316 : int32 = v314.l0
                                                let v317 : num_complex_Complex<float> = v314.l1
                                                let v318 : int32 = v308.[int v316]
                                                let v319 : string = "num_complex::Complex::new($0, $1)"
                                                let v320 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v319 
                                                let v321 : (int32 -> float) = float
                                                let v322 : float = v321 v318
                                                let v323 : string = "num_complex::Complex::new($0, $1)"
                                                let v324 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v322, 0.0) v323 
                                                let v325 : string = "num_complex::Complex::powc($0, $1)"
                                                let v326 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v324, v296) v325 
                                                let v327 : string = "$0 / $1"
                                                let v328 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v320, v326) v327 
                                                let v329 : string = "$0 + $1"
                                                let v330 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v317, v328) v329 
                                                let v331 : int32 = v316 + 1
                                                v314.l0 <- v331
                                                v314.l1 <- v330
                                                ()
                                            let v332 : num_complex_Complex<float> = v314.l1
                                            v332
                                        else
                                            let v333 : string = "num_complex::Complex::new($0, $1)"
                                            let v334 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v333 
                                            let v335 : string = "$0 - $1"
                                            let v336 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v334, v296) v335 
                                            let v337 : string = $"        s = mpmath.gamma(s)"
                                            let v338 : num_complex_Complex<float> = method3(v336)
                                            let v339 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v337, v338)
                                            let v340 : unit = ()
                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                            let v341 : string = "$0.ok()"
                                            let v342 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v339 v341 
                                            let _v340 = v342 
                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                            let v343 : string = "$0.ok()"
                                            let v344 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v339 v343 
                                            let _v340 = v344 
                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                            let v345 : string = "$0.ok()"
                                            let v346 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v339 v345 
                                            let _v340 = v346 
                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                            let v347 : num_complex_Complex<float> option = match v339 with Ok x -> Some x | Error _ -> None
                                            let _v340 = v347 
                                            #endif
#if FABLE_COMPILER_PYTHON
                                            let v348 : num_complex_Complex<float> option = match v339 with Ok x -> Some x | Error _ -> None
                                            let _v340 = v348 
                                            #endif
#else
                                            let v349 : num_complex_Complex<float> option = match v339 with Ok x -> Some x | Error _ -> None
                                            let _v340 = v349 
                                            #endif
                                            let v350 : num_complex_Complex<float> option = _v340 
                                            let v353 : (num_complex_Complex<float> -> US0) = method17()
                                            let v354 : US0 option = v350 |> Option.map v353 
                                            let v365 : US0 = US0_1
                                            let v366 : US0 = v354 |> Option.defaultValue v365 
                                            let v370 : string = "f64::NAN"
                                            let v371 : float = Fable.Core.RustInterop.emitRustExpr () v370 
                                            let v372 : string = "f64::NAN"
                                            let v373 : float = Fable.Core.RustInterop.emitRustExpr () v372 
                                            let v374 : string = "num_complex::Complex::new($0, $1)"
                                            let v375 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v371, v373) v374 
                                            let v378 : num_complex_Complex<float> =
                                                match v366 with
                                                | US0_1 -> (* None *)
                                                    v375
                                                | US0_0(v376) -> (* Some *)
                                                    v376
                                            let v379 : string = "num_complex::Complex::new($0, $1)"
                                            let v380 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v379 
                                            let v381 : string = "$0 * $1"
                                            let v382 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v380, v296) v381 
                                            let v383 : string = "num_complex::Complex::new($0, $1)"
                                            let v384 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v383 
                                            let v385 : string = "$0 / $1"
                                            let v386 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v382, v384) v385 
                                            let v387 : string = "$0.sin()"
                                            let v388 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v386 v387 
                                            let v389 : string = "$0.re"
                                            let v390 : float = Fable.Core.RustInterop.emitRustExpr v296 v389 
                                            let v391 : float = 1.0 - v390
                                            let v392 : string = "$0.im"
                                            let v393 : float = Fable.Core.RustInterop.emitRustExpr v296 v392 
                                            let v394 : float =  -v393
                                            let v395 : string = "num_complex::Complex::new($0, $1)"
                                            let v396 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v391, v394) v395 
                                            let v397 : string = "$0.re"
                                            let v398 : float = Fable.Core.RustInterop.emitRustExpr v396 v397 
                                            let v399 : bool = v398 <= 1.0
                                            let v518 : num_complex_Complex<float> =
                                                if v399 then
                                                    let v400 : string = "num_complex::Complex::new($0, $1)"
                                                    let v401 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v400 
                                                    v401
                                                else
                                                    let v402 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                                    Fable.Core.RustInterop.emitRustExpr struct (4, v396) v402 
                                                    let v403 : string = "$0.re"
                                                    let v404 : float = Fable.Core.RustInterop.emitRustExpr v396 v403 
                                                    let v405 : bool = v404 > 1.0
                                                    if v405 then
                                                        let v406 : string = "num_complex::Complex::new($0, $1)"
                                                        let v407 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v406 
                                                        let v408 : (int32 []) = Array.zeroCreate<int32> (10000)
                                                        let v409 : Mut0 = {l0 = 0} : Mut0
                                                        while method14(v409) do
                                                            let v411 : int32 = v409.l0
                                                            v408.[int v411] <- v411
                                                            let v412 : int32 = v411 + 1
                                                            v409.l0 <- v412
                                                            ()
                                                        let v413 : int32 = v408.Length
                                                        let v414 : Mut2 = {l0 = 0; l1 = v407} : Mut2
                                                        while method15(v413, v414) do
                                                            let v416 : int32 = v414.l0
                                                            let v417 : num_complex_Complex<float> = v414.l1
                                                            let v418 : int32 = v408.[int v416]
                                                            let v419 : string = "num_complex::Complex::new($0, $1)"
                                                            let v420 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v419 
                                                            let v421 : (int32 -> float) = float
                                                            let v422 : float = v421 v418
                                                            let v423 : string = "num_complex::Complex::new($0, $1)"
                                                            let v424 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v422, 0.0) v423 
                                                            let v425 : string = "num_complex::Complex::powc($0, $1)"
                                                            let v426 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v424, v396) v425 
                                                            let v427 : string = "$0 / $1"
                                                            let v428 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v420, v426) v427 
                                                            let v429 : string = "$0 + $1"
                                                            let v430 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v417, v428) v429 
                                                            let v431 : int32 = v416 + 1
                                                            v414.l0 <- v431
                                                            v414.l1 <- v430
                                                            ()
                                                        let v432 : num_complex_Complex<float> = v414.l1
                                                        v432
                                                    else
                                                        let v433 : string = "num_complex::Complex::new($0, $1)"
                                                        let v434 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v433 
                                                        let v435 : string = "$0 - $1"
                                                        let v436 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v434, v396) v435 
                                                        let v437 : string = $"        s = mpmath.gamma(s)"
                                                        let v438 : num_complex_Complex<float> = method3(v436)
                                                        let v439 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v437, v438)
                                                        let v440 : unit = ()
                                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                        let v441 : string = "$0.ok()"
                                                        let v442 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v439 v441 
                                                        let _v440 = v442 
                                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                                        let v443 : string = "$0.ok()"
                                                        let v444 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v439 v443 
                                                        let _v440 = v444 
                                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                        let v445 : string = "$0.ok()"
                                                        let v446 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v439 v445 
                                                        let _v440 = v446 
                                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                        let v447 : num_complex_Complex<float> option = match v439 with Ok x -> Some x | Error _ -> None
                                                        let _v440 = v447 
                                                        #endif
#if FABLE_COMPILER_PYTHON
                                                        let v448 : num_complex_Complex<float> option = match v439 with Ok x -> Some x | Error _ -> None
                                                        let _v440 = v448 
                                                        #endif
#else
                                                        let v449 : num_complex_Complex<float> option = match v439 with Ok x -> Some x | Error _ -> None
                                                        let _v440 = v449 
                                                        #endif
                                                        let v450 : num_complex_Complex<float> option = _v440 
                                                        let v453 : (num_complex_Complex<float> -> US0) = method17()
                                                        let v454 : US0 option = v450 |> Option.map v453 
                                                        let v465 : US0 = US0_1
                                                        let v466 : US0 = v454 |> Option.defaultValue v465 
                                                        let v470 : string = "f64::NAN"
                                                        let v471 : float = Fable.Core.RustInterop.emitRustExpr () v470 
                                                        let v472 : string = "f64::NAN"
                                                        let v473 : float = Fable.Core.RustInterop.emitRustExpr () v472 
                                                        let v474 : string = "num_complex::Complex::new($0, $1)"
                                                        let v475 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v471, v473) v474 
                                                        let v478 : num_complex_Complex<float> =
                                                            match v466 with
                                                            | US0_1 -> (* None *)
                                                                v475
                                                            | US0_0(v476) -> (* Some *)
                                                                v476
                                                        let v479 : string = "num_complex::Complex::new($0, $1)"
                                                        let v480 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v479 
                                                        let v481 : string = "$0 * $1"
                                                        let v482 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v480, v396) v481 
                                                        let v483 : string = "num_complex::Complex::new($0, $1)"
                                                        let v484 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v483 
                                                        let v485 : string = "$0 / $1"
                                                        let v486 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v482, v484) v485 
                                                        let v487 : string = "$0.sin()"
                                                        let v488 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v486 v487 
                                                        let v489 : string = "$0.re"
                                                        let v490 : float = Fable.Core.RustInterop.emitRustExpr v396 v489 
                                                        let v491 : float = 1.0 - v490
                                                        let v492 : string = "$0.im"
                                                        let v493 : float = Fable.Core.RustInterop.emitRustExpr v396 v492 
                                                        let v494 : float =  -v493
                                                        let v495 : string = "num_complex::Complex::new($0, $1)"
                                                        let v496 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v491, v494) v495 
                                                        let v497 : string = "$0.re"
                                                        let v498 : float = Fable.Core.RustInterop.emitRustExpr v496 v497 
                                                        let v499 : bool = v498 <= 1.0
                                                        let v502 : num_complex_Complex<float> =
                                                            if v499 then
                                                                let v500 : string = "num_complex::Complex::new($0, $1)"
                                                                let v501 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v500 
                                                                v501
                                                            else
                                                                v496
                                                        let v503 : string = "num_complex::Complex::new($0, $1)"
                                                        let v504 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v503 
                                                        let v505 : string = "num_complex::Complex::new($0, $1)"
                                                        let v506 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v505 
                                                        let v507 : string = "num_complex::Complex::powc($0, $1)"
                                                        let v508 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v506, v396) v507 
                                                        let v509 : string = "$0 * $1"
                                                        let v510 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v504, v508) v509 
                                                        let v511 : string = "$0 * $1"
                                                        let v512 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v510, v488) v511 
                                                        let v513 : string = "$0 * $1"
                                                        let v514 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v512, v478) v513 
                                                        let v515 : string = "$0 * $1"
                                                        let v516 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v514, v502) v515 
                                                        v516
                                            let v519 : string = "num_complex::Complex::new($0, $1)"
                                            let v520 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v519 
                                            let v521 : string = "num_complex::Complex::new($0, $1)"
                                            let v522 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v521 
                                            let v523 : string = "num_complex::Complex::powc($0, $1)"
                                            let v524 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v522, v296) v523 
                                            let v525 : string = "$0 * $1"
                                            let v526 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v520, v524) v525 
                                            let v527 : string = "$0 * $1"
                                            let v528 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v526, v388) v527 
                                            let v529 : string = "$0 * $1"
                                            let v530 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v528, v378) v529 
                                            let v531 : string = "$0 * $1"
                                            let v532 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v530, v518) v531 
                                            v532
                                let v535 : string = "num_complex::Complex::new($0, $1)"
                                let v536 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v535 
                                let v537 : string = "num_complex::Complex::new($0, $1)"
                                let v538 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v537 
                                let v539 : string = "num_complex::Complex::powc($0, $1)"
                                let v540 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v538, v196) v539 
                                let v541 : string = "$0 * $1"
                                let v542 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v536, v540) v541 
                                let v543 : string = "$0 * $1"
                                let v544 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v542, v288) v543 
                                let v545 : string = "$0 * $1"
                                let v546 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v544, v278) v545 
                                let v547 : string = "$0 * $1"
                                let v548 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v546, v534) v547 
                                v548
                    let v551 : string = "num_complex::Complex::new($0, $1)"
                    let v552 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v551 
                    let v553 : string = "num_complex::Complex::new($0, $1)"
                    let v554 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v553 
                    let v555 : string = "num_complex::Complex::powc($0, $1)"
                    let v556 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v554, v96) v555 
                    let v557 : string = "$0 * $1"
                    let v558 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v552, v556) v557 
                    let v559 : string = "$0 * $1"
                    let v560 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v558, v188) v559 
                    let v561 : string = "$0 * $1"
                    let v562 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v560, v178) v561 
                    let v563 : string = "$0 * $1"
                    let v564 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v562, v550) v563 
                    v564
        let v567 : string = "num_complex::Complex::new($0, $1)"
        let v568 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v567 
        let v569 : string = "num_complex::Complex::new($0, $1)"
        let v570 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v569 
        let v571 : string = "num_complex::Complex::powc($0, $1)"
        let v572 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v570, v1) v571 
        let v573 : string = "$0 * $1"
        let v574 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v568, v572) v573 
        let v575 : string = "$0 * $1"
        let v576 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v574, v88) v575 
        let v577 : string = "$0 * $1"
        let v578 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v576, v78) v577 
        let v579 : string = "$0 * $1"
        let v580 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v578, v566) v579 
        v580
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
#else
        let v25 : num_complex_Complex<float> option = match v14 with Ok x -> Some x | Error _ -> None
        let _v16 = v25 
        #endif
        let v26 : num_complex_Complex<float> option = _v16 
        let v29 : (num_complex_Complex<float> -> US0) = method17()
        let v30 : US0 option = v26 |> Option.map v29 
        let v41 : US0 = US0_1
        let v42 : US0 = v30 |> Option.defaultValue v41 
        let v46 : string = "f64::NAN"
        let v47 : float = Fable.Core.RustInterop.emitRustExpr () v46 
        let v48 : string = "f64::NAN"
        let v49 : float = Fable.Core.RustInterop.emitRustExpr () v48 
        let v50 : string = "num_complex::Complex::new($0, $1)"
        let v51 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v47, v49) v50 
        let v54 : num_complex_Complex<float> =
            match v42 with
            | US0_1 -> (* None *)
                v51
            | US0_0(v52) -> (* Some *)
                v52
        let v55 : string = "$0.im"
        let v56 : float = Fable.Core.RustInterop.emitRustExpr v54 v55 
        let v57 : bool = v56 = 0.0
        let v59 : bool =
            if v57 then
                true
            else
                method18(v57)
        let v60 : string = "__assert_eq"
        let v61 : string = $"{v60} / actual: %A{v56} / expected: %A{0.0}"
        let v64 : unit = ()
        let v65 : (unit -> unit) = closure2(v61)
        let v66 : unit = (fun () -> v65 (); v64) ()
        let v68 : bool = v59 = false
        if v68 then
            failwith<unit> v61
        let v69 : string = "$0.re"
        let v70 : float = Fable.Core.RustInterop.emitRustExpr v54 v69 
        let v71 : float = v70 - v11
        let v72 : float =  -v71
        let v73 : bool = v71 >= v72
        let v74 : float =
            if v73 then
                v71
            else
                v72
        let v75 : bool = v74 < 0.0001
        let v77 : bool =
            if v75 then
                true
            else
                method18(v75)
        let v78 : string = "__assert_lt"
        let v79 : string = $"{v78} / actual: %A{v74} / expected: %A{0.0001}"
        let v82 : unit = ()
        let v83 : (unit -> unit) = closure2(v79)
        let v84 : unit = (fun () -> v83 (); v82) ()
        let v86 : bool = v77 = false
        if v86 then
            failwith<unit> v79
        let v87 : int32 = v9 + 1
        v7.l0 <- v87
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
#else
    let v22 : bool = true
    let _v13 = v22 
    #endif
    let v23 : bool = _v13 
    let v26 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
    _v30 
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
#else
    let v16 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _v7 = v16 
    #endif
    let v17 : num_complex_Complex<float> option = _v7 
    let v20 : (num_complex_Complex<float> -> US0) = method17()
    let v21 : US0 option = v17 |> Option.map v20 
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
    let v46 : string = "$0.re"
    let v47 : float = Fable.Core.RustInterop.emitRustExpr v45 v46 
    let v48 : float = v47 - 0.8673
    let v49 : float =  -v48
    let v50 : bool = v48 >= v49
    let v51 : float =
        if v50 then
            v48
        else
            v49
    let v52 : bool = v51 < 0.001
    let v54 : bool =
        if v52 then
            true
        else
            method18(v52)
    let v55 : string = "__assert_lt"
    let v56 : string = $"{v55} / actual: %A{v51} / expected: %A{0.001}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure2(v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v63 : bool = v54 = false
    if v63 then
        failwith<unit> v56
    let v64 : string = "$0.im"
    let v65 : float = Fable.Core.RustInterop.emitRustExpr v45 v64 
    let v66 : float = v65 - 0.275
    let v67 : float =  -v66
    let v68 : bool = v66 >= v67
    let v69 : float =
        if v68 then
            v66
        else
            v67
    let v70 : bool = v69 < 0.001
    let v72 : bool =
        if v70 then
            true
        else
            method18(v70)
    let v73 : string = $"{v55} / actual: %A{v69} / expected: %A{0.001}"
    let v76 : unit = ()
    let v77 : (unit -> unit) = closure2(v73)
    let v78 : unit = (fun () -> v77 (); v76) ()
    let v80 : bool = v72 = false
    if v80 then
        failwith<unit> v73
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
#else
    let v22 : bool = true
    let _v13 = v22 
    #endif
    let v23 : bool = _v13 
    let v26 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
    _v30 
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
#else
        let v19 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _v10 = v19 
        #endif
        let v20 : num_complex_Complex<float> option = _v10 
        let v23 : (num_complex_Complex<float> -> US0) = method17()
        let v24 : US0 option = v20 |> Option.map v23 
        let v35 : US0 = US0_1
        let v36 : US0 = v24 |> Option.defaultValue v35 
        let v40 : string = "f64::NAN"
        let v41 : float = Fable.Core.RustInterop.emitRustExpr () v40 
        let v42 : string = "f64::NAN"
        let v43 : float = Fable.Core.RustInterop.emitRustExpr () v42 
        let v44 : string = "num_complex::Complex::new($0, $1)"
        let v45 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v41, v43) v44 
        let v48 : num_complex_Complex<float> =
            match v36 with
            | US0_1 -> (* None *)
                v45
            | US0_0(v46) -> (* Some *)
                v46
        let v49 : string = "$0.re"
        let v50 : float = Fable.Core.RustInterop.emitRustExpr v48 v49 
        let v51 : bool = v50 = 0.0
        let v53 : bool =
            if v51 then
                true
            else
                method18(v51)
        let v54 : string = "__assert_eq"
        let v55 : string = $"{v54} / actual: %A{v50} / expected: %A{0.0}"
        let v58 : unit = ()
        let v59 : (unit -> unit) = closure2(v55)
        let v60 : unit = (fun () -> v59 (); v58) ()
        let v62 : bool = v53 = false
        if v62 then
            failwith<unit> v55
        let v63 : string = "$0.im"
        let v64 : float = Fable.Core.RustInterop.emitRustExpr v48 v63 
        let v65 : bool = v64 = 0.0
        let v67 : bool =
            if v65 then
                true
            else
                method18(v65)
        let v68 : string = $"{v54} / actual: %A{v64} / expected: %A{0.0}"
        let v71 : unit = ()
        let v72 : (unit -> unit) = closure2(v68)
        let v73 : unit = (fun () -> v72 (); v71) ()
        let v75 : bool = v67 = false
        if v75 then
            failwith<unit> v68
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
#else
    let v22 : bool = true
    let _v13 = v22 
    #endif
    let v23 : bool = _v13 
    let v26 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
    _v30 
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
#else
        let v32 : num_complex_Complex<float> option = match v21 with Ok x -> Some x | Error _ -> None
        let _v23 = v32 
        #endif
        let v33 : num_complex_Complex<float> option = _v23 
        let v36 : (num_complex_Complex<float> -> US0) = method17()
        let v37 : US0 option = v33 |> Option.map v36 
        let v48 : US0 = US0_1
        let v49 : US0 = v37 |> Option.defaultValue v48 
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
        let v64 : float =  -v63
        let v65 : bool = v63 >= v64
        let v66 : float =
            if v65 then
                v63
            else
                v64
        let v67 : bool = v66 < 0.0001
        let v69 : bool =
            if v67 then
                true
            else
                method18(v67)
        let v70 : string = "__assert_lt"
        let v71 : string = $"{v70} / actual: %A{v66} / expected: %A{0.0001}"
        let v74 : unit = ()
        let v75 : (unit -> unit) = closure2(v71)
        let v76 : unit = (fun () -> v75 (); v74) ()
        let v78 : bool = v69 = false
        if v78 then
            failwith<unit> v71
        let v79 : string = "$0.im"
        let v80 : float = Fable.Core.RustInterop.emitRustExpr v61 v79 
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
        let v87 : string = $"{v70} / actual: %A{v83} / expected: %A{0.0001}"
        let v90 : unit = ()
        let v91 : (unit -> unit) = closure2(v87)
        let v92 : unit = (fun () -> v91 (); v90) ()
        let v94 : bool = v86 = false
        if v94 then
            failwith<unit> v87
        let v95 : int32 = v17 + 1
        v15.l0 <- v95
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
#else
    let v22 : bool = true
    let _v13 = v22 
    #endif
    let v23 : bool = _v13 
    let v26 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
    _v30 
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
#else
        let v22 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _v13 = v22 
        #endif
        let v23 : num_complex_Complex<float> option = _v13 
        let v26 : (num_complex_Complex<float> -> US0) = method17()
        let v27 : US0 option = v23 |> Option.map v26 
        let v38 : US0 = US0_1
        let v39 : US0 = v27 |> Option.defaultValue v38 
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
        let v54 : bool = v53 > 0.0
        let v56 : bool =
            if v54 then
                true
            else
                method18(v54)
        let v57 : string = "__assert_gt"
        let v58 : string = $"{v57} / actual: %A{v53} / expected: %A{0.0}"
        let v61 : unit = ()
        let v62 : (unit -> unit) = closure2(v58)
        let v63 : unit = (fun () -> v62 (); v61) ()
        let v65 : bool = v56 = false
        if v65 then
            failwith<unit> v58
        let v66 : string = "$0.im"
        let v67 : float = Fable.Core.RustInterop.emitRustExpr v51 v66 
        let v68 : bool = v67 = 0.0
        let v70 : bool =
            if v68 then
                true
            else
                method18(v68)
        let v71 : string = "__assert_eq"
        let v72 : string = $"{v71} / actual: %A{v67} / expected: %A{0.0}"
        let v75 : unit = ()
        let v76 : (unit -> unit) = closure2(v72)
        let v77 : unit = (fun () -> v76 (); v75) ()
        let v79 : bool = v70 = false
        if v79 then
            failwith<unit> v72
        let v80 : int32 = v5 + 1
        v3.l0 <- v80
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
#else
    let v22 : bool = true
    let _v13 = v22 
    #endif
    let v23 : bool = _v13 
    let v26 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
    _v30 
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
#else
    let v16 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _v7 = v16 
    #endif
    let v17 : num_complex_Complex<float> option = _v7 
    let v20 : (num_complex_Complex<float> -> US0) = method17()
    let v21 : US0 option = v17 |> Option.map v20 
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
    let v46 : string = "$0.re"
    let v47 : float = Fable.Core.RustInterop.emitRustExpr v45 v46 
    let v48 : bool = v47 = infinity
    let v50 : bool =
        if v48 then
            true
        else
            method18(v48)
    let v51 : string = "__assert_eq"
    let v52 : string = $"{v51} / actual: %A{v47} / expected: %A{infinity}"
    let v55 : unit = ()
    let v56 : (unit -> unit) = closure2(v52)
    let v57 : unit = (fun () -> v56 (); v55) ()
    let v59 : bool = v50 = false
    if v59 then
        failwith<unit> v52
    let v60 : string = "$0.im"
    let v61 : float = Fable.Core.RustInterop.emitRustExpr v45 v60 
    let v62 : bool = v61 = 0.0
    let v64 : bool =
        if v62 then
            true
        else
            method18(v62)
    let v65 : string = $"{v51} / actual: %A{v61} / expected: %A{0.0}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure2(v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v72 : bool = v64 = false
    if v72 then
        failwith<unit> v65
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
#else
    let v22 : bool = true
    let _v13 = v22 
    #endif
    let v23 : bool = _v13 
    let v26 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
    _v30 
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
#else
    let v16 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _v7 = v16 
    #endif
    let v17 : num_complex_Complex<float> option = _v7 
    let v20 : (num_complex_Complex<float> -> US0) = method17()
    let v21 : US0 option = v17 |> Option.map v20 
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
    let v46 : string = "$0.re"
    let v47 : float = Fable.Core.RustInterop.emitRustExpr v2 v46 
    let v48 : string = "$0.im"
    let v49 : float = Fable.Core.RustInterop.emitRustExpr v2 v48 
    let v50 : float =  -v49
    let v51 : string = "num_complex::Complex::new($0, $1)"
    let v52 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v47, v50) v51 
    let v53 : string = $"        s = mpmath.zeta(s)"
    let v54 : num_complex_Complex<float> = method3(v52)
    let v55 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v53, v54)
    let v56 : num_complex_Complex<float> = method13(v0, v52)
    let v57 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v58 : string = "$0.ok()"
    let v59 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v55 v58 
    let _v57 = v59 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v60 : string = "$0.ok()"
    let v61 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v55 v60 
    let _v57 = v61 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v62 : string = "$0.ok()"
    let v63 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v55 v62 
    let _v57 = v63 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v64 : num_complex_Complex<float> option = match v55 with Ok x -> Some x | Error _ -> None
    let _v57 = v64 
    #endif
#if FABLE_COMPILER_PYTHON
    let v65 : num_complex_Complex<float> option = match v55 with Ok x -> Some x | Error _ -> None
    let _v57 = v65 
    #endif
#else
    let v66 : num_complex_Complex<float> option = match v55 with Ok x -> Some x | Error _ -> None
    let _v57 = v66 
    #endif
    let v67 : num_complex_Complex<float> option = _v57 
    let v70 : (num_complex_Complex<float> -> US0) = method17()
    let v71 : US0 option = v67 |> Option.map v70 
    let v82 : US0 = US0_1
    let v83 : US0 = v71 |> Option.defaultValue v82 
    let v87 : string = "f64::NAN"
    let v88 : float = Fable.Core.RustInterop.emitRustExpr () v87 
    let v89 : string = "f64::NAN"
    let v90 : float = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = "num_complex::Complex::new($0, $1)"
    let v92 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v88, v90) v91 
    let v95 : num_complex_Complex<float> =
        match v83 with
        | US0_1 -> (* None *)
            v92
        | US0_0(v93) -> (* Some *)
            v93
    let v96 : string = "$0.conj()"
    let v97 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v95 v96 
    let v98 : string = "$0.re"
    let v99 : float = Fable.Core.RustInterop.emitRustExpr v45 v98 
    let v100 : string = "$0.re"
    let v101 : float = Fable.Core.RustInterop.emitRustExpr v97 v100 
    let v102 : bool = v99 = v101
    let v104 : bool =
        if v102 then
            true
        else
            method18(v102)
    let v105 : string = "__assert_eq"
    let v106 : string = $"{v105} / actual: %A{v99} / expected: %A{v101}"
    let v109 : unit = ()
    let v110 : (unit -> unit) = closure2(v106)
    let v111 : unit = (fun () -> v110 (); v109) ()
    let v113 : bool = v104 = false
    if v113 then
        failwith<unit> v106
    let v114 : string = "$0.im"
    let v115 : float = Fable.Core.RustInterop.emitRustExpr v45 v114 
    let v116 : string = "$0.im"
    let v117 : float = Fable.Core.RustInterop.emitRustExpr v97 v116 
    let v118 : bool = v115 = v117
    let v120 : bool =
        if v118 then
            true
        else
            method18(v118)
    let v121 : string = $"{v105} / actual: %A{v115} / expected: %A{v117}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure2(v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v128 : bool = v120 = false
    if v128 then
        failwith<unit> v121
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
#else
    let v22 : bool = true
    let _v13 = v22 
    #endif
    let v23 : bool = _v13 
    let v26 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
    _v30 
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
#else
    let v16 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _v7 = v16 
    #endif
    let v17 : num_complex_Complex<float> option = _v7 
    let v20 : (num_complex_Complex<float> -> US0) = method17()
    let v21 : US0 option = v17 |> Option.map v20 
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
    let v46 : string = "$0.re"
    let v47 : float = Fable.Core.RustInterop.emitRustExpr v45 v46 
    let v48 : bool = v47 < infinity
    let v50 : bool =
        if v48 then
            true
        else
            method18(v48)
    let v51 : string = "__assert_lt"
    let v52 : string = $"{v51} / actual: %A{v47} / expected: %A{infinity}"
    let v55 : unit = ()
    let v56 : (unit -> unit) = closure2(v52)
    let v57 : unit = (fun () -> v56 (); v55) ()
    let v59 : bool = v50 = false
    if v59 then
        failwith<unit> v52
    let v60 : string = "$0.im"
    let v61 : float = Fable.Core.RustInterop.emitRustExpr v45 v60 
    let v62 : bool = v61 < infinity
    let v64 : bool =
        if v62 then
            true
        else
            method18(v62)
    let v65 : string = $"{v51} / actual: %A{v61} / expected: %A{infinity}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure2(v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v72 : bool = v64 = false
    if v72 then
        failwith<unit> v65
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
#else
    let v22 : bool = true
    let _v13 = v22 
    #endif
    let v23 : bool = _v13 
    let v26 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
    _v30 
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
#else
        let v19 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _v10 = v19 
        #endif
        let v20 : num_complex_Complex<float> option = _v10 
        let v23 : (num_complex_Complex<float> -> US0) = method17()
        let v24 : US0 option = v20 |> Option.map v23 
        let v35 : US0 = US0_1
        let v36 : US0 = v24 |> Option.defaultValue v35 
        let v40 : string = "f64::NAN"
        let v41 : float = Fable.Core.RustInterop.emitRustExpr () v40 
        let v42 : string = "f64::NAN"
        let v43 : float = Fable.Core.RustInterop.emitRustExpr () v42 
        let v44 : string = "num_complex::Complex::new($0, $1)"
        let v45 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v41, v43) v44 
        let v48 : num_complex_Complex<float> =
            match v36 with
            | US0_1 -> (* None *)
                v45
            | US0_0(v46) -> (* Some *)
                v46
        let v49 : string = "$0.re"
        let v50 : float = Fable.Core.RustInterop.emitRustExpr v48 v49 
        let v51 : bool = v50 <> 0.0 
        let v55 : bool =
            if v51 then
                true
            else
                method18(v51)
        let v56 : string = "__assert_ne"
        let v57 : string = $"{v56} / actual: %A{v50} / expected: %A{0.0}"
        let v60 : unit = ()
        let v61 : (unit -> unit) = closure2(v57)
        let v62 : unit = (fun () -> v61 (); v60) ()
        let v64 : bool = v55 = false
        if v64 then
            failwith<unit> v57
        let v65 : string = "$0.im"
        let v66 : float = Fable.Core.RustInterop.emitRustExpr v48 v65 
        let v67 : bool = v66 <> 0.0 
        let v71 : bool =
            if v67 then
                true
            else
                method18(v67)
        let v72 : string = $"{v56} / actual: %A{v66} / expected: %A{0.0}"
        let v75 : unit = ()
        let v76 : (unit -> unit) = closure2(v72)
        let v77 : unit = (fun () -> v76 (); v75) ()
        let v79 : bool = v71 = false
        if v79 then
            failwith<unit> v72
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
#else
    let v22 : bool = true
    let _v13 = v22 
    #endif
    let v23 : bool = _v13 
    let v26 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
    _v30 
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
#else
        let v17 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _v8 = v17 
        #endif
        let v18 : num_complex_Complex<float> option = _v8 
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
        let v49 : bool = v48 <> 0.0 
        let v53 : bool =
            if v49 then
                true
            else
                method18(v49)
        let v54 : string = "__assert_ne"
        let v55 : string = $"{v54} / actual: %A{v48} / expected: %A{0.0}"
        let v58 : unit = ()
        let v59 : (unit -> unit) = closure2(v55)
        let v60 : unit = (fun () -> v59 (); v58) ()
        let v62 : bool = v53 = false
        if v62 then
            failwith<unit> v55
        let v63 : string = "$0.im"
        let v64 : float = Fable.Core.RustInterop.emitRustExpr v46 v63 
        let v65 : bool = v64 <> 0.0 
        let v69 : bool =
            if v65 then
                true
            else
                method18(v65)
        let v70 : string = $"{v54} / actual: %A{v64} / expected: %A{0.0}"
        let v73 : unit = ()
        let v74 : (unit -> unit) = closure2(v70)
        let v75 : unit = (fun () -> v74 (); v73) ()
        let v77 : bool = v69 = false
        if v77 then
            failwith<unit> v70
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
#else
    let v22 : bool = true
    let _v13 = v22 
    #endif
    let v23 : bool = _v13 
    let v26 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
    _v30 
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
#else
        let v17 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _v8 = v17 
        #endif
        let v18 : num_complex_Complex<float> option = _v8 
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
        let v47 : string = "num_complex::Complex::new($0, $1)"
        let v48 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v47 
        let v49 : string = "num_complex::Complex::powc($0, $1)"
        let v50 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v48, v2) v49 
        let v51 : string = "num_complex::Complex::new($0, $1)"
        let v52 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v51 
        let v53 : string = "num_complex::Complex::new($0, $1)"
        let v54 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v53 
        let v55 : string = "$0 - $1"
        let v56 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v2, v54) v55 
        let v57 : string = "num_complex::Complex::powc($0, $1)"
        let v58 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v52, v56) v57 
        let v59 : string = "$0 * $1"
        let v60 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v50, v58) v59 
        let v61 : string = "num_complex::Complex::new($0, $1)"
        let v62 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v61 
        let v63 : string = "$0 * $1"
        let v64 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v62, v2) v63 
        let v65 : string = "num_complex::Complex::new($0, $1)"
        let v66 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v65 
        let v67 : string = "$0 / $1"
        let v68 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v64, v66) v67 
        let v69 : string = "$0.sin()"
        let v70 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v68 v69 
        let v71 : string = "$0 * $1"
        let v72 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v60, v70) v71 
        let v73 : string = "num_complex::Complex::new($0, $1)"
        let v74 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v73 
        let v75 : string = "$0 - $1"
        let v76 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v74, v2) v75 
        let v77 : string = $"        s = mpmath.gamma(s)"
        let v78 : num_complex_Complex<float> = method3(v76)
        let v79 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v77, v78)
        let v80 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v81 : string = "$0.ok()"
        let v82 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v79 v81 
        let _v80 = v82 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v83 : string = "$0.ok()"
        let v84 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v79 v83 
        let _v80 = v84 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v85 : string = "$0.ok()"
        let v86 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v79 v85 
        let _v80 = v86 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v87 : num_complex_Complex<float> option = match v79 with Ok x -> Some x | Error _ -> None
        let _v80 = v87 
        #endif
#if FABLE_COMPILER_PYTHON
        let v88 : num_complex_Complex<float> option = match v79 with Ok x -> Some x | Error _ -> None
        let _v80 = v88 
        #endif
#else
        let v89 : num_complex_Complex<float> option = match v79 with Ok x -> Some x | Error _ -> None
        let _v80 = v89 
        #endif
        let v90 : num_complex_Complex<float> option = _v80 
        let v93 : (num_complex_Complex<float> -> US0) = method17()
        let v94 : US0 option = v90 |> Option.map v93 
        let v105 : US0 = US0_1
        let v106 : US0 = v94 |> Option.defaultValue v105 
        let v110 : string = "f64::NAN"
        let v111 : float = Fable.Core.RustInterop.emitRustExpr () v110 
        let v112 : string = "f64::NAN"
        let v113 : float = Fable.Core.RustInterop.emitRustExpr () v112 
        let v114 : string = "num_complex::Complex::new($0, $1)"
        let v115 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v111, v113) v114 
        let v118 : num_complex_Complex<float> =
            match v106 with
            | US0_1 -> (* None *)
                v115
            | US0_0(v116) -> (* Some *)
                v116
        let v119 : string = "$0 * $1"
        let v120 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v72, v118) v119 
        let v121 : string = "$0.re"
        let v122 : float = Fable.Core.RustInterop.emitRustExpr v2 v121 
        let v123 : float = 1.0 - v122
        let v124 : string = "$0.im"
        let v125 : float = Fable.Core.RustInterop.emitRustExpr v2 v124 
        let v126 : float =  -v125
        let v127 : string = "num_complex::Complex::new($0, $1)"
        let v128 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v123, v126) v127 
        let v129 : string = $"        s = mpmath.zeta(s)"
        let v130 : num_complex_Complex<float> = method3(v128)
        let v131 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v129, v130)
        let v132 : num_complex_Complex<float> = method13(v0, v128)
        let v133 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v134 : string = "$0.ok()"
        let v135 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v131 v134 
        let _v133 = v135 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v136 : string = "$0.ok()"
        let v137 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v131 v136 
        let _v133 = v137 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v138 : string = "$0.ok()"
        let v139 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v131 v138 
        let _v133 = v139 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v140 : num_complex_Complex<float> option = match v131 with Ok x -> Some x | Error _ -> None
        let _v133 = v140 
        #endif
#if FABLE_COMPILER_PYTHON
        let v141 : num_complex_Complex<float> option = match v131 with Ok x -> Some x | Error _ -> None
        let _v133 = v141 
        #endif
#else
        let v142 : num_complex_Complex<float> option = match v131 with Ok x -> Some x | Error _ -> None
        let _v133 = v142 
        #endif
        let v143 : num_complex_Complex<float> option = _v133 
        let v146 : (num_complex_Complex<float> -> US0) = method17()
        let v147 : US0 option = v143 |> Option.map v146 
        let v158 : US0 = US0_1
        let v159 : US0 = v147 |> Option.defaultValue v158 
        let v163 : string = "f64::NAN"
        let v164 : float = Fable.Core.RustInterop.emitRustExpr () v163 
        let v165 : string = "f64::NAN"
        let v166 : float = Fable.Core.RustInterop.emitRustExpr () v165 
        let v167 : string = "num_complex::Complex::new($0, $1)"
        let v168 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v164, v166) v167 
        let v171 : num_complex_Complex<float> =
            match v159 with
            | US0_1 -> (* None *)
                v168
            | US0_0(v169) -> (* Some *)
                v169
        let v172 : string = "$0 * $1"
        let v173 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v120, v171) v172 
        let v174 : string = "$0.re"
        let v175 : float = Fable.Core.RustInterop.emitRustExpr v46 v174 
        let v176 : string = "$0.re"
        let v177 : float = Fable.Core.RustInterop.emitRustExpr v173 v176 
        let v178 : float = v175 - v177
        let v179 : float =  -v178
        let v180 : bool = v178 >= v179
        let v181 : float =
            if v180 then
                v178
            else
                v179
        let v182 : bool = v181 < 0.0001
        let v184 : bool =
            if v182 then
                true
            else
                method18(v182)
        let v185 : string = "__assert_lt"
        let v186 : string = $"{v185} / actual: %A{v181} / expected: %A{0.0001}"
        let v189 : unit = ()
        let v190 : (unit -> unit) = closure2(v186)
        let v191 : unit = (fun () -> v190 (); v189) ()
        let v193 : bool = v184 = false
        if v193 then
            failwith<unit> v186
        let v194 : string = "$0.im"
        let v195 : float = Fable.Core.RustInterop.emitRustExpr v46 v194 
        let v196 : string = "$0.im"
        let v197 : float = Fable.Core.RustInterop.emitRustExpr v173 v196 
        let v198 : float = v195 - v197
        let v199 : float =  -v198
        let v200 : bool = v198 >= v199
        let v201 : float =
            if v200 then
                v198
            else
                v199
        let v202 : bool = v201 < 0.0001
        let v204 : bool =
            if v202 then
                true
            else
                method18(v202)
        let v205 : string = $"{v185} / actual: %A{v201} / expected: %A{0.0001}"
        let v208 : unit = ()
        let v209 : (unit -> unit) = closure2(v205)
        let v210 : unit = (fun () -> v209 (); v208) ()
        let v212 : bool = v204 = false
        if v212 then
            failwith<unit> v205
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
#else
    let v22 : bool = true
    let _v13 = v22 
    #endif
    let v23 : bool = _v13 
    let v26 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
    _v30 
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
#else
        let v22 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _v13 = v22 
        #endif
        let v23 : num_complex_Complex<float> option = _v13 
        let v26 : (num_complex_Complex<float> -> US0) = method17()
        let v27 : US0 option = v23 |> Option.map v26 
        let v38 : US0 = US0_1
        let v39 : US0 = v27 |> Option.defaultValue v38 
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
        let v54 : float = v53 - v8
        let v55 : float =  -v54
        let v56 : bool = v54 >= v55
        let v57 : float =
            if v56 then
                v54
            else
                v55
        let v58 : bool = v57 < 0.01
        let v60 : bool =
            if v58 then
                true
            else
                method18(v58)
        let v61 : string = "__assert_lt"
        let v62 : string = $"{v61} / actual: %A{v57} / expected: %A{0.01}"
        let v65 : unit = ()
        let v66 : (unit -> unit) = closure2(v62)
        let v67 : unit = (fun () -> v66 (); v65) ()
        let v69 : bool = v60 = false
        if v69 then
            failwith<unit> v62
        let v70 : string = "$0.im"
        let v71 : float = Fable.Core.RustInterop.emitRustExpr v51 v70 
        let v72 : bool = v71 < 0.01
        let v74 : bool =
            if v72 then
                true
            else
                method18(v72)
        let v75 : string = $"{v61} / actual: %A{v71} / expected: %A{0.01}"
        let v78 : unit = ()
        let v79 : (unit -> unit) = closure2(v75)
        let v80 : unit = (fun () -> v79 (); v78) ()
        let v82 : bool = v74 = false
        if v82 then
            failwith<unit> v75
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
#else
    let v22 : bool = true
    let _v13 = v22 
    #endif
    let v23 : bool = _v13 
    let v26 : string = $"true; v12 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    let _v30 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = () 
    #endif
    _v30 
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
