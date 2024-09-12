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
#endif
type Ref<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("pyo3::PyErr")>]
#endif
type pyo3_PyErr = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
#endif
type std_string_String = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("pyo3::Bound<$0>")>]
#endif
type pyo3_Bound<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("str")>]
#endif
type Str = class end
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
    let v44 : string = "&*$0"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v44 
    let v46 : string = "pyo3::types::PyModule::from_code_bound(v43, v45, \"\", \"\")"
    let v47 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v46 
    let v48 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v49 : bool = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let v50 : string = "x"
    let v51 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v50 
    let v52 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v53 : string = "format!(\"{}\", $0)"
    let v54 : std_string_String = Fable.Core.RustInterop.emitRustExpr v51 v53 
    let _v52 = v54 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v55 : string = "format!(\"{}\", $0)"
    let v56 : std_string_String = Fable.Core.RustInterop.emitRustExpr v51 v55 
    let _v52 = v56 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v57 : string = "format!(\"{}\", $0)"
    let v58 : std_string_String = Fable.Core.RustInterop.emitRustExpr v51 v57 
    let _v52 = v58 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v59 : std_string_String = null |> unbox<std_string_String>
    let _v52 = v59 
    #endif
#if FABLE_COMPILER_PYTHON
    let v62 : std_string_String = null |> unbox<std_string_String>
    let _v52 = v62 
    #endif
#else
    let v65 : std_string_String = null |> unbox<std_string_String>
    let _v52 = v65 
    #endif
    let v68 : std_string_String = _v52 
    let v73 : string = "true; $0 })"
    let v74 : bool = Fable.Core.RustInterop.emitRustExpr v68 v73 
    let v75 : string = "_result_map_error__"
    let v76 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v75 
    let v77 : string = "$0.unwrap()"
    let v78 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v76 v77 
    let v79 : string = method8()
    let v80 : string = "&*$0"
    let v81 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v79 v80 
    let v82 : pyo3_Bound<pyo3_types_PyModule> = method9(v78)
    let v83 : string = "v82.getattr(v81)"
    let v84 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v83 
    let v85 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v86 : bool = Fable.Core.RustInterop.emitRustExpr v84 v85 
    let v87 : string = "x"
    let v88 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v87 
    let v89 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v90 : string = "format!(\"{}\", $0)"
    let v91 : std_string_String = Fable.Core.RustInterop.emitRustExpr v88 v90 
    let _v89 = v91 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v92 : string = "format!(\"{}\", $0)"
    let v93 : std_string_String = Fable.Core.RustInterop.emitRustExpr v88 v92 
    let _v89 = v93 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v94 : string = "format!(\"{}\", $0)"
    let v95 : std_string_String = Fable.Core.RustInterop.emitRustExpr v88 v94 
    let _v89 = v95 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v96 : std_string_String = null |> unbox<std_string_String>
    let _v89 = v96 
    #endif
#if FABLE_COMPILER_PYTHON
    let v99 : std_string_String = null |> unbox<std_string_String>
    let _v89 = v99 
    #endif
#else
    let v102 : std_string_String = null |> unbox<std_string_String>
    let _v89 = v102 
    #endif
    let v105 : std_string_String = _v89 
    let v110 : string = "true; $0 })"
    let v111 : bool = Fable.Core.RustInterop.emitRustExpr v105 v110 
    let v112 : string = "_result_map_error__"
    let v113 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v112 
    let v114 : string = "$0.unwrap()"
    let v115 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v113 v114 
    let v116 : (bool * (float * float)) = method10(v42)
    let v117 : pyo3_Bound<pyo3_PyAny> = method11(v115)
    let v118 : string = "pyo3::prelude::PyAnyMethods::call(&v117, ((*v116).0, *(*v116).1), None)"
    let v119 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v118 
    let v120 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v121 : bool = Fable.Core.RustInterop.emitRustExpr v119 v120 
    let v122 : string = "x"
    let v123 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v122 
    let v124 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v125 : string = "format!(\"{}\", $0)"
    let v126 : std_string_String = Fable.Core.RustInterop.emitRustExpr v123 v125 
    let _v124 = v126 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v127 : string = "format!(\"{}\", $0)"
    let v128 : std_string_String = Fable.Core.RustInterop.emitRustExpr v123 v127 
    let _v124 = v128 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v129 : string = "format!(\"{}\", $0)"
    let v130 : std_string_String = Fable.Core.RustInterop.emitRustExpr v123 v129 
    let _v124 = v130 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v131 : std_string_String = null |> unbox<std_string_String>
    let _v124 = v131 
    #endif
#if FABLE_COMPILER_PYTHON
    let v134 : std_string_String = null |> unbox<std_string_String>
    let _v124 = v134 
    #endif
#else
    let v137 : std_string_String = null |> unbox<std_string_String>
    let _v124 = v137 
    #endif
    let v140 : std_string_String = _v124 
    let v145 : string = "true; $0 })"
    let v146 : bool = Fable.Core.RustInterop.emitRustExpr v140 v145 
    let v147 : string = "_result_map_error__"
    let v148 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v147 
    let v149 : string = "$0?"
    let v150 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v148 v149 
    let v151 : pyo3_Bound<pyo3_PyAny> = method12(v150)
    let v152 : string = "v151.extract()"
    let v153 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v152 
    let v154 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v155 : bool = Fable.Core.RustInterop.emitRustExpr v153 v154 
    let v156 : string = "x"
    let v157 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v156 
    let v158 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v159 : string = "format!(\"{}\", $0)"
    let v160 : std_string_String = Fable.Core.RustInterop.emitRustExpr v157 v159 
    let _v158 = v160 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v161 : string = "format!(\"{}\", $0)"
    let v162 : std_string_String = Fable.Core.RustInterop.emitRustExpr v157 v161 
    let _v158 = v162 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v163 : string = "format!(\"{}\", $0)"
    let v164 : std_string_String = Fable.Core.RustInterop.emitRustExpr v157 v163 
    let _v158 = v164 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v165 : std_string_String = null |> unbox<std_string_String>
    let _v158 = v165 
    #endif
#if FABLE_COMPILER_PYTHON
    let v168 : std_string_String = null |> unbox<std_string_String>
    let _v158 = v168 
    #endif
#else
    let v171 : std_string_String = null |> unbox<std_string_String>
    let _v158 = v171 
    #endif
    let v174 : std_string_String = _v158 
    let v179 : string = "true; $0 })"
    let v180 : bool = Fable.Core.RustInterop.emitRustExpr v174 v179 
    let v181 : string = "_result_map_error__"
    let v182 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v181 
    let v183 : string = "$0?"
    let struct (v184 : float, v185 : float) = Fable.Core.RustInterop.emitRustExpr v182 v183 
    let v186 : string = "num_complex::Complex::new($0, $1)"
    let v187 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v184, v185) v186 
    let v188 : Result<num_complex_Complex<float>, std_string_String> = Ok v187 
    v188
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
    let v44 : string = "&*$0"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v44 
    let v46 : string = "pyo3::types::PyModule::from_code_bound(v43, v45, \"\", \"\")"
    let v47 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v46 
    let v48 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v49 : bool = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let v50 : string = "x"
    let v51 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v50 
    let v52 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v53 : string = "format!(\"{}\", $0)"
    let v54 : std_string_String = Fable.Core.RustInterop.emitRustExpr v51 v53 
    let _v52 = v54 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v55 : string = "format!(\"{}\", $0)"
    let v56 : std_string_String = Fable.Core.RustInterop.emitRustExpr v51 v55 
    let _v52 = v56 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v57 : string = "format!(\"{}\", $0)"
    let v58 : std_string_String = Fable.Core.RustInterop.emitRustExpr v51 v57 
    let _v52 = v58 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v59 : std_string_String = null |> unbox<std_string_String>
    let _v52 = v59 
    #endif
#if FABLE_COMPILER_PYTHON
    let v62 : std_string_String = null |> unbox<std_string_String>
    let _v52 = v62 
    #endif
#else
    let v65 : std_string_String = null |> unbox<std_string_String>
    let _v52 = v65 
    #endif
    let v68 : std_string_String = _v52 
    let v73 : string = "true; $0 })"
    let v74 : bool = Fable.Core.RustInterop.emitRustExpr v68 v73 
    let v75 : string = "_result_map_error__"
    let v76 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v75 
    let v77 : string = "$0.unwrap()"
    let v78 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v76 v77 
    let v79 : string = method8()
    let v80 : string = "&*$0"
    let v81 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v79 v80 
    let v82 : pyo3_Bound<pyo3_types_PyModule> = method9(v78)
    let v83 : string = "v82.getattr(v81)"
    let v84 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v83 
    let v85 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v86 : bool = Fable.Core.RustInterop.emitRustExpr v84 v85 
    let v87 : string = "x"
    let v88 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v87 
    let v89 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v90 : string = "format!(\"{}\", $0)"
    let v91 : std_string_String = Fable.Core.RustInterop.emitRustExpr v88 v90 
    let _v89 = v91 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v92 : string = "format!(\"{}\", $0)"
    let v93 : std_string_String = Fable.Core.RustInterop.emitRustExpr v88 v92 
    let _v89 = v93 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v94 : string = "format!(\"{}\", $0)"
    let v95 : std_string_String = Fable.Core.RustInterop.emitRustExpr v88 v94 
    let _v89 = v95 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v96 : std_string_String = null |> unbox<std_string_String>
    let _v89 = v96 
    #endif
#if FABLE_COMPILER_PYTHON
    let v99 : std_string_String = null |> unbox<std_string_String>
    let _v89 = v99 
    #endif
#else
    let v102 : std_string_String = null |> unbox<std_string_String>
    let _v89 = v102 
    #endif
    let v105 : std_string_String = _v89 
    let v110 : string = "true; $0 })"
    let v111 : bool = Fable.Core.RustInterop.emitRustExpr v105 v110 
    let v112 : string = "_result_map_error__"
    let v113 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v112 
    let v114 : string = "$0.unwrap()"
    let v115 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v113 v114 
    let v116 : (bool * (float * float)) = method10(v42)
    let v117 : pyo3_Bound<pyo3_PyAny> = method11(v115)
    let v118 : string = "pyo3::prelude::PyAnyMethods::call(&v117, ((*v116).0, *(*v116).1), None)"
    let v119 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v118 
    let v120 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v121 : bool = Fable.Core.RustInterop.emitRustExpr v119 v120 
    let v122 : string = "x"
    let v123 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v122 
    let v124 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v125 : string = "format!(\"{}\", $0)"
    let v126 : std_string_String = Fable.Core.RustInterop.emitRustExpr v123 v125 
    let _v124 = v126 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v127 : string = "format!(\"{}\", $0)"
    let v128 : std_string_String = Fable.Core.RustInterop.emitRustExpr v123 v127 
    let _v124 = v128 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v129 : string = "format!(\"{}\", $0)"
    let v130 : std_string_String = Fable.Core.RustInterop.emitRustExpr v123 v129 
    let _v124 = v130 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v131 : std_string_String = null |> unbox<std_string_String>
    let _v124 = v131 
    #endif
#if FABLE_COMPILER_PYTHON
    let v134 : std_string_String = null |> unbox<std_string_String>
    let _v124 = v134 
    #endif
#else
    let v137 : std_string_String = null |> unbox<std_string_String>
    let _v124 = v137 
    #endif
    let v140 : std_string_String = _v124 
    let v145 : string = "true; $0 })"
    let v146 : bool = Fable.Core.RustInterop.emitRustExpr v140 v145 
    let v147 : string = "_result_map_error__"
    let v148 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v147 
    let v149 : string = "$0?"
    let v150 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v148 v149 
    let v151 : pyo3_Bound<pyo3_PyAny> = method12(v150)
    let v152 : string = "v151.extract()"
    let v153 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v152 
    let v154 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v155 : bool = Fable.Core.RustInterop.emitRustExpr v153 v154 
    let v156 : string = "x"
    let v157 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v156 
    let v158 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v159 : string = "format!(\"{}\", $0)"
    let v160 : std_string_String = Fable.Core.RustInterop.emitRustExpr v157 v159 
    let _v158 = v160 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v161 : string = "format!(\"{}\", $0)"
    let v162 : std_string_String = Fable.Core.RustInterop.emitRustExpr v157 v161 
    let _v158 = v162 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v163 : string = "format!(\"{}\", $0)"
    let v164 : std_string_String = Fable.Core.RustInterop.emitRustExpr v157 v163 
    let _v158 = v164 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v165 : std_string_String = null |> unbox<std_string_String>
    let _v158 = v165 
    #endif
#if FABLE_COMPILER_PYTHON
    let v168 : std_string_String = null |> unbox<std_string_String>
    let _v158 = v168 
    #endif
#else
    let v171 : std_string_String = null |> unbox<std_string_String>
    let _v158 = v171 
    #endif
    let v174 : std_string_String = _v158 
    let v179 : string = "true; $0 })"
    let v180 : bool = Fable.Core.RustInterop.emitRustExpr v174 v179 
    let v181 : string = "_result_map_error__"
    let v182 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v181 
    let v183 : string = "$0?"
    let struct (v184 : float, v185 : float) = Fable.Core.RustInterop.emitRustExpr v182 v183 
    let v186 : string = "num_complex::Complex::new($0, $1)"
    let v187 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v184, v185) v186 
    let v188 : Result<num_complex_Complex<float>, std_string_String> = Ok v187 
    v188
and closure1 (v0 : US0 option ref) (v1 : US0 option) : US0 option ref =
    v0.Value <- v1 
    v0
and closure2 (v0 : num_complex_Complex<float> option, v1 : (US0 option -> US0 option ref)) () : unit =
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : num_complex_Complex<float> = x
    let v3 : US0 = US0_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> v1 |> ignore
    ()
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
        let v40 : string = "$0.ok()"
        let v41 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v39 v40 
        let v42 : US0 option = None
        let _v42 = ref v42 
        let v43 : US0 option ref = _v42 
        let v44 : (US0 option -> US0 option ref) = closure1(v43)
        let v45 : unit = ()
        let v46 : (unit -> unit) = closure2(v41, v44)
        let v47 : unit = (fun () -> v46 (); v45) ()
        let v50 : US0 option = _v42.Value 
        let v61 : US0 = US0_1
        let v62 : US0 = v50 |> Option.defaultValue v61 
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
        let v75 : string = "num_complex::Complex::new($0, $1)"
        let v76 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v75 
        let v77 : string = "$0 * $1"
        let v78 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v76, v1) v77 
        let v79 : string = "num_complex::Complex::new($0, $1)"
        let v80 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v79 
        let v81 : string = "$0 / $1"
        let v82 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v78, v80) v81 
        let v83 : string = "$0.sin()"
        let v84 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v82 v83 
        let v85 : string = "$0.re"
        let v86 : float = Fable.Core.RustInterop.emitRustExpr v1 v85 
        let v87 : float = 1.0 - v86
        let v88 : string = "$0.im"
        let v89 : float = Fable.Core.RustInterop.emitRustExpr v1 v88 
        let v90 : float =  -v89
        let v91 : string = "num_complex::Complex::new($0, $1)"
        let v92 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v87, v90) v91 
        let v93 : string = "$0.re"
        let v94 : float = Fable.Core.RustInterop.emitRustExpr v92 v93 
        let v95 : bool = v94 <= 1.0
        let v546 : num_complex_Complex<float> =
            if v95 then
                let v96 : string = "num_complex::Complex::new($0, $1)"
                let v97 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v96 
                v97
            else
                let v98 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                Fable.Core.RustInterop.emitRustExpr struct (1, v92) v98 
                let v99 : string = "$0.re"
                let v100 : float = Fable.Core.RustInterop.emitRustExpr v92 v99 
                let v101 : bool = v100 > 1.0
                if v101 then
                    let v102 : string = "num_complex::Complex::new($0, $1)"
                    let v103 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v102 
                    let v104 : (int32 []) = Array.zeroCreate<int32> (10000)
                    let v105 : Mut0 = {l0 = 0} : Mut0
                    while method14(v105) do
                        let v107 : int32 = v105.l0
                        v104.[int v107] <- v107
                        let v108 : int32 = v107 + 1
                        v105.l0 <- v108
                        ()
                    let v109 : int32 = v104.Length
                    let v110 : Mut2 = {l0 = 0; l1 = v103} : Mut2
                    while method15(v109, v110) do
                        let v112 : int32 = v110.l0
                        let v113 : num_complex_Complex<float> = v110.l1
                        let v114 : int32 = v104.[int v112]
                        let v115 : string = "num_complex::Complex::new($0, $1)"
                        let v116 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v115 
                        let v117 : (int32 -> float) = float
                        let v118 : float = v117 v114
                        let v119 : string = "num_complex::Complex::new($0, $1)"
                        let v120 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v118, 0.0) v119 
                        let v121 : string = "num_complex::Complex::powc($0, $1)"
                        let v122 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v120, v92) v121 
                        let v123 : string = "$0 / $1"
                        let v124 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v116, v122) v123 
                        let v125 : string = "$0 + $1"
                        let v126 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v113, v124) v125 
                        let v127 : int32 = v112 + 1
                        v110.l0 <- v127
                        v110.l1 <- v126
                        ()
                    let v128 : num_complex_Complex<float> = v110.l1
                    v128
                else
                    let v129 : string = "num_complex::Complex::new($0, $1)"
                    let v130 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v129 
                    let v131 : string = "$0 - $1"
                    let v132 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v130, v92) v131 
                    let v133 : string = $"        s = mpmath.gamma(s)"
                    let v134 : num_complex_Complex<float> = method3(v132)
                    let v135 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v133, v134)
                    let v136 : string = "$0.ok()"
                    let v137 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v135 v136 
                    let v138 : US0 option = None
                    let _v138 = ref v138 
                    let v139 : US0 option ref = _v138 
                    let v140 : (US0 option -> US0 option ref) = closure1(v139)
                    let v141 : unit = ()
                    let v142 : (unit -> unit) = closure2(v137, v140)
                    let v143 : unit = (fun () -> v142 (); v141) ()
                    let v146 : US0 option = _v138.Value 
                    let v157 : US0 = US0_1
                    let v158 : US0 = v146 |> Option.defaultValue v157 
                    let v162 : string = "f64::NAN"
                    let v163 : float = Fable.Core.RustInterop.emitRustExpr () v162 
                    let v164 : string = "f64::NAN"
                    let v165 : float = Fable.Core.RustInterop.emitRustExpr () v164 
                    let v166 : string = "num_complex::Complex::new($0, $1)"
                    let v167 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v163, v165) v166 
                    let v170 : num_complex_Complex<float> =
                        match v158 with
                        | US0_1 -> (* None *)
                            v167
                        | US0_0(v168) -> (* Some *)
                            v168
                    let v171 : string = "num_complex::Complex::new($0, $1)"
                    let v172 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v171 
                    let v173 : string = "$0 * $1"
                    let v174 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v172, v92) v173 
                    let v175 : string = "num_complex::Complex::new($0, $1)"
                    let v176 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v175 
                    let v177 : string = "$0 / $1"
                    let v178 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v174, v176) v177 
                    let v179 : string = "$0.sin()"
                    let v180 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v178 v179 
                    let v181 : string = "$0.re"
                    let v182 : float = Fable.Core.RustInterop.emitRustExpr v92 v181 
                    let v183 : float = 1.0 - v182
                    let v184 : string = "$0.im"
                    let v185 : float = Fable.Core.RustInterop.emitRustExpr v92 v184 
                    let v186 : float =  -v185
                    let v187 : string = "num_complex::Complex::new($0, $1)"
                    let v188 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v183, v186) v187 
                    let v189 : string = "$0.re"
                    let v190 : float = Fable.Core.RustInterop.emitRustExpr v188 v189 
                    let v191 : bool = v190 <= 1.0
                    let v530 : num_complex_Complex<float> =
                        if v191 then
                            let v192 : string = "num_complex::Complex::new($0, $1)"
                            let v193 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v192 
                            v193
                        else
                            let v194 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                            Fable.Core.RustInterop.emitRustExpr struct (2, v188) v194 
                            let v195 : string = "$0.re"
                            let v196 : float = Fable.Core.RustInterop.emitRustExpr v188 v195 
                            let v197 : bool = v196 > 1.0
                            if v197 then
                                let v198 : string = "num_complex::Complex::new($0, $1)"
                                let v199 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v198 
                                let v200 : (int32 []) = Array.zeroCreate<int32> (10000)
                                let v201 : Mut0 = {l0 = 0} : Mut0
                                while method14(v201) do
                                    let v203 : int32 = v201.l0
                                    v200.[int v203] <- v203
                                    let v204 : int32 = v203 + 1
                                    v201.l0 <- v204
                                    ()
                                let v205 : int32 = v200.Length
                                let v206 : Mut2 = {l0 = 0; l1 = v199} : Mut2
                                while method15(v205, v206) do
                                    let v208 : int32 = v206.l0
                                    let v209 : num_complex_Complex<float> = v206.l1
                                    let v210 : int32 = v200.[int v208]
                                    let v211 : string = "num_complex::Complex::new($0, $1)"
                                    let v212 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v211 
                                    let v213 : (int32 -> float) = float
                                    let v214 : float = v213 v210
                                    let v215 : string = "num_complex::Complex::new($0, $1)"
                                    let v216 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v214, 0.0) v215 
                                    let v217 : string = "num_complex::Complex::powc($0, $1)"
                                    let v218 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v216, v188) v217 
                                    let v219 : string = "$0 / $1"
                                    let v220 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v212, v218) v219 
                                    let v221 : string = "$0 + $1"
                                    let v222 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v209, v220) v221 
                                    let v223 : int32 = v208 + 1
                                    v206.l0 <- v223
                                    v206.l1 <- v222
                                    ()
                                let v224 : num_complex_Complex<float> = v206.l1
                                v224
                            else
                                let v225 : string = "num_complex::Complex::new($0, $1)"
                                let v226 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v225 
                                let v227 : string = "$0 - $1"
                                let v228 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v226, v188) v227 
                                let v229 : string = $"        s = mpmath.gamma(s)"
                                let v230 : num_complex_Complex<float> = method3(v228)
                                let v231 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v229, v230)
                                let v232 : string = "$0.ok()"
                                let v233 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v231 v232 
                                let v234 : US0 option = None
                                let _v234 = ref v234 
                                let v235 : US0 option ref = _v234 
                                let v236 : (US0 option -> US0 option ref) = closure1(v235)
                                let v237 : unit = ()
                                let v238 : (unit -> unit) = closure2(v233, v236)
                                let v239 : unit = (fun () -> v238 (); v237) ()
                                let v242 : US0 option = _v234.Value 
                                let v253 : US0 = US0_1
                                let v254 : US0 = v242 |> Option.defaultValue v253 
                                let v258 : string = "f64::NAN"
                                let v259 : float = Fable.Core.RustInterop.emitRustExpr () v258 
                                let v260 : string = "f64::NAN"
                                let v261 : float = Fable.Core.RustInterop.emitRustExpr () v260 
                                let v262 : string = "num_complex::Complex::new($0, $1)"
                                let v263 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v259, v261) v262 
                                let v266 : num_complex_Complex<float> =
                                    match v254 with
                                    | US0_1 -> (* None *)
                                        v263
                                    | US0_0(v264) -> (* Some *)
                                        v264
                                let v267 : string = "num_complex::Complex::new($0, $1)"
                                let v268 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v267 
                                let v269 : string = "$0 * $1"
                                let v270 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v268, v188) v269 
                                let v271 : string = "num_complex::Complex::new($0, $1)"
                                let v272 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v271 
                                let v273 : string = "$0 / $1"
                                let v274 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v270, v272) v273 
                                let v275 : string = "$0.sin()"
                                let v276 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v274 v275 
                                let v277 : string = "$0.re"
                                let v278 : float = Fable.Core.RustInterop.emitRustExpr v188 v277 
                                let v279 : float = 1.0 - v278
                                let v280 : string = "$0.im"
                                let v281 : float = Fable.Core.RustInterop.emitRustExpr v188 v280 
                                let v282 : float =  -v281
                                let v283 : string = "num_complex::Complex::new($0, $1)"
                                let v284 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v279, v282) v283 
                                let v285 : string = "$0.re"
                                let v286 : float = Fable.Core.RustInterop.emitRustExpr v284 v285 
                                let v287 : bool = v286 <= 1.0
                                let v514 : num_complex_Complex<float> =
                                    if v287 then
                                        let v288 : string = "num_complex::Complex::new($0, $1)"
                                        let v289 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v288 
                                        v289
                                    else
                                        let v290 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                        Fable.Core.RustInterop.emitRustExpr struct (3, v284) v290 
                                        let v291 : string = "$0.re"
                                        let v292 : float = Fable.Core.RustInterop.emitRustExpr v284 v291 
                                        let v293 : bool = v292 > 1.0
                                        if v293 then
                                            let v294 : string = "num_complex::Complex::new($0, $1)"
                                            let v295 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v294 
                                            let v296 : (int32 []) = Array.zeroCreate<int32> (10000)
                                            let v297 : Mut0 = {l0 = 0} : Mut0
                                            while method14(v297) do
                                                let v299 : int32 = v297.l0
                                                v296.[int v299] <- v299
                                                let v300 : int32 = v299 + 1
                                                v297.l0 <- v300
                                                ()
                                            let v301 : int32 = v296.Length
                                            let v302 : Mut2 = {l0 = 0; l1 = v295} : Mut2
                                            while method15(v301, v302) do
                                                let v304 : int32 = v302.l0
                                                let v305 : num_complex_Complex<float> = v302.l1
                                                let v306 : int32 = v296.[int v304]
                                                let v307 : string = "num_complex::Complex::new($0, $1)"
                                                let v308 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v307 
                                                let v309 : (int32 -> float) = float
                                                let v310 : float = v309 v306
                                                let v311 : string = "num_complex::Complex::new($0, $1)"
                                                let v312 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v310, 0.0) v311 
                                                let v313 : string = "num_complex::Complex::powc($0, $1)"
                                                let v314 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v312, v284) v313 
                                                let v315 : string = "$0 / $1"
                                                let v316 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v308, v314) v315 
                                                let v317 : string = "$0 + $1"
                                                let v318 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v305, v316) v317 
                                                let v319 : int32 = v304 + 1
                                                v302.l0 <- v319
                                                v302.l1 <- v318
                                                ()
                                            let v320 : num_complex_Complex<float> = v302.l1
                                            v320
                                        else
                                            let v321 : string = "num_complex::Complex::new($0, $1)"
                                            let v322 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v321 
                                            let v323 : string = "$0 - $1"
                                            let v324 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v322, v284) v323 
                                            let v325 : string = $"        s = mpmath.gamma(s)"
                                            let v326 : num_complex_Complex<float> = method3(v324)
                                            let v327 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v325, v326)
                                            let v328 : string = "$0.ok()"
                                            let v329 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v327 v328 
                                            let v330 : US0 option = None
                                            let _v330 = ref v330 
                                            let v331 : US0 option ref = _v330 
                                            let v332 : (US0 option -> US0 option ref) = closure1(v331)
                                            let v333 : unit = ()
                                            let v334 : (unit -> unit) = closure2(v329, v332)
                                            let v335 : unit = (fun () -> v334 (); v333) ()
                                            let v338 : US0 option = _v330.Value 
                                            let v349 : US0 = US0_1
                                            let v350 : US0 = v338 |> Option.defaultValue v349 
                                            let v354 : string = "f64::NAN"
                                            let v355 : float = Fable.Core.RustInterop.emitRustExpr () v354 
                                            let v356 : string = "f64::NAN"
                                            let v357 : float = Fable.Core.RustInterop.emitRustExpr () v356 
                                            let v358 : string = "num_complex::Complex::new($0, $1)"
                                            let v359 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v355, v357) v358 
                                            let v362 : num_complex_Complex<float> =
                                                match v350 with
                                                | US0_1 -> (* None *)
                                                    v359
                                                | US0_0(v360) -> (* Some *)
                                                    v360
                                            let v363 : string = "num_complex::Complex::new($0, $1)"
                                            let v364 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v363 
                                            let v365 : string = "$0 * $1"
                                            let v366 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v364, v284) v365 
                                            let v367 : string = "num_complex::Complex::new($0, $1)"
                                            let v368 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v367 
                                            let v369 : string = "$0 / $1"
                                            let v370 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v366, v368) v369 
                                            let v371 : string = "$0.sin()"
                                            let v372 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v370 v371 
                                            let v373 : string = "$0.re"
                                            let v374 : float = Fable.Core.RustInterop.emitRustExpr v284 v373 
                                            let v375 : float = 1.0 - v374
                                            let v376 : string = "$0.im"
                                            let v377 : float = Fable.Core.RustInterop.emitRustExpr v284 v376 
                                            let v378 : float =  -v377
                                            let v379 : string = "num_complex::Complex::new($0, $1)"
                                            let v380 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v375, v378) v379 
                                            let v381 : string = "$0.re"
                                            let v382 : float = Fable.Core.RustInterop.emitRustExpr v380 v381 
                                            let v383 : bool = v382 <= 1.0
                                            let v498 : num_complex_Complex<float> =
                                                if v383 then
                                                    let v384 : string = "num_complex::Complex::new($0, $1)"
                                                    let v385 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v384 
                                                    v385
                                                else
                                                    let v386 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                                    Fable.Core.RustInterop.emitRustExpr struct (4, v380) v386 
                                                    let v387 : string = "$0.re"
                                                    let v388 : float = Fable.Core.RustInterop.emitRustExpr v380 v387 
                                                    let v389 : bool = v388 > 1.0
                                                    if v389 then
                                                        let v390 : string = "num_complex::Complex::new($0, $1)"
                                                        let v391 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v390 
                                                        let v392 : (int32 []) = Array.zeroCreate<int32> (10000)
                                                        let v393 : Mut0 = {l0 = 0} : Mut0
                                                        while method14(v393) do
                                                            let v395 : int32 = v393.l0
                                                            v392.[int v395] <- v395
                                                            let v396 : int32 = v395 + 1
                                                            v393.l0 <- v396
                                                            ()
                                                        let v397 : int32 = v392.Length
                                                        let v398 : Mut2 = {l0 = 0; l1 = v391} : Mut2
                                                        while method15(v397, v398) do
                                                            let v400 : int32 = v398.l0
                                                            let v401 : num_complex_Complex<float> = v398.l1
                                                            let v402 : int32 = v392.[int v400]
                                                            let v403 : string = "num_complex::Complex::new($0, $1)"
                                                            let v404 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v403 
                                                            let v405 : (int32 -> float) = float
                                                            let v406 : float = v405 v402
                                                            let v407 : string = "num_complex::Complex::new($0, $1)"
                                                            let v408 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v406, 0.0) v407 
                                                            let v409 : string = "num_complex::Complex::powc($0, $1)"
                                                            let v410 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v408, v380) v409 
                                                            let v411 : string = "$0 / $1"
                                                            let v412 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v404, v410) v411 
                                                            let v413 : string = "$0 + $1"
                                                            let v414 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v401, v412) v413 
                                                            let v415 : int32 = v400 + 1
                                                            v398.l0 <- v415
                                                            v398.l1 <- v414
                                                            ()
                                                        let v416 : num_complex_Complex<float> = v398.l1
                                                        v416
                                                    else
                                                        let v417 : string = "num_complex::Complex::new($0, $1)"
                                                        let v418 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v417 
                                                        let v419 : string = "$0 - $1"
                                                        let v420 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v418, v380) v419 
                                                        let v421 : string = $"        s = mpmath.gamma(s)"
                                                        let v422 : num_complex_Complex<float> = method3(v420)
                                                        let v423 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v421, v422)
                                                        let v424 : string = "$0.ok()"
                                                        let v425 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v423 v424 
                                                        let v426 : US0 option = None
                                                        let _v426 = ref v426 
                                                        let v427 : US0 option ref = _v426 
                                                        let v428 : (US0 option -> US0 option ref) = closure1(v427)
                                                        let v429 : unit = ()
                                                        let v430 : (unit -> unit) = closure2(v425, v428)
                                                        let v431 : unit = (fun () -> v430 (); v429) ()
                                                        let v434 : US0 option = _v426.Value 
                                                        let v445 : US0 = US0_1
                                                        let v446 : US0 = v434 |> Option.defaultValue v445 
                                                        let v450 : string = "f64::NAN"
                                                        let v451 : float = Fable.Core.RustInterop.emitRustExpr () v450 
                                                        let v452 : string = "f64::NAN"
                                                        let v453 : float = Fable.Core.RustInterop.emitRustExpr () v452 
                                                        let v454 : string = "num_complex::Complex::new($0, $1)"
                                                        let v455 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v451, v453) v454 
                                                        let v458 : num_complex_Complex<float> =
                                                            match v446 with
                                                            | US0_1 -> (* None *)
                                                                v455
                                                            | US0_0(v456) -> (* Some *)
                                                                v456
                                                        let v459 : string = "num_complex::Complex::new($0, $1)"
                                                        let v460 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v459 
                                                        let v461 : string = "$0 * $1"
                                                        let v462 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v460, v380) v461 
                                                        let v463 : string = "num_complex::Complex::new($0, $1)"
                                                        let v464 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v463 
                                                        let v465 : string = "$0 / $1"
                                                        let v466 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v462, v464) v465 
                                                        let v467 : string = "$0.sin()"
                                                        let v468 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v466 v467 
                                                        let v469 : string = "$0.re"
                                                        let v470 : float = Fable.Core.RustInterop.emitRustExpr v380 v469 
                                                        let v471 : float = 1.0 - v470
                                                        let v472 : string = "$0.im"
                                                        let v473 : float = Fable.Core.RustInterop.emitRustExpr v380 v472 
                                                        let v474 : float =  -v473
                                                        let v475 : string = "num_complex::Complex::new($0, $1)"
                                                        let v476 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v471, v474) v475 
                                                        let v477 : string = "$0.re"
                                                        let v478 : float = Fable.Core.RustInterop.emitRustExpr v476 v477 
                                                        let v479 : bool = v478 <= 1.0
                                                        let v482 : num_complex_Complex<float> =
                                                            if v479 then
                                                                let v480 : string = "num_complex::Complex::new($0, $1)"
                                                                let v481 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v480 
                                                                v481
                                                            else
                                                                v476
                                                        let v483 : string = "num_complex::Complex::new($0, $1)"
                                                        let v484 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v483 
                                                        let v485 : string = "num_complex::Complex::new($0, $1)"
                                                        let v486 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v485 
                                                        let v487 : string = "num_complex::Complex::powc($0, $1)"
                                                        let v488 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v486, v380) v487 
                                                        let v489 : string = "$0 * $1"
                                                        let v490 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v484, v488) v489 
                                                        let v491 : string = "$0 * $1"
                                                        let v492 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v490, v468) v491 
                                                        let v493 : string = "$0 * $1"
                                                        let v494 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v492, v458) v493 
                                                        let v495 : string = "$0 * $1"
                                                        let v496 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v494, v482) v495 
                                                        v496
                                            let v499 : string = "num_complex::Complex::new($0, $1)"
                                            let v500 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v499 
                                            let v501 : string = "num_complex::Complex::new($0, $1)"
                                            let v502 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v501 
                                            let v503 : string = "num_complex::Complex::powc($0, $1)"
                                            let v504 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v502, v284) v503 
                                            let v505 : string = "$0 * $1"
                                            let v506 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v500, v504) v505 
                                            let v507 : string = "$0 * $1"
                                            let v508 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v506, v372) v507 
                                            let v509 : string = "$0 * $1"
                                            let v510 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v508, v362) v509 
                                            let v511 : string = "$0 * $1"
                                            let v512 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v510, v498) v511 
                                            v512
                                let v515 : string = "num_complex::Complex::new($0, $1)"
                                let v516 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v515 
                                let v517 : string = "num_complex::Complex::new($0, $1)"
                                let v518 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v517 
                                let v519 : string = "num_complex::Complex::powc($0, $1)"
                                let v520 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v518, v188) v519 
                                let v521 : string = "$0 * $1"
                                let v522 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v516, v520) v521 
                                let v523 : string = "$0 * $1"
                                let v524 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v522, v276) v523 
                                let v525 : string = "$0 * $1"
                                let v526 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v524, v266) v525 
                                let v527 : string = "$0 * $1"
                                let v528 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v526, v514) v527 
                                v528
                    let v531 : string = "num_complex::Complex::new($0, $1)"
                    let v532 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v531 
                    let v533 : string = "num_complex::Complex::new($0, $1)"
                    let v534 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v533 
                    let v535 : string = "num_complex::Complex::powc($0, $1)"
                    let v536 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v534, v92) v535 
                    let v537 : string = "$0 * $1"
                    let v538 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v532, v536) v537 
                    let v539 : string = "$0 * $1"
                    let v540 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v538, v180) v539 
                    let v541 : string = "$0 * $1"
                    let v542 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v540, v170) v541 
                    let v543 : string = "$0 * $1"
                    let v544 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v542, v530) v543 
                    v544
        let v547 : string = "num_complex::Complex::new($0, $1)"
        let v548 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v547 
        let v549 : string = "num_complex::Complex::new($0, $1)"
        let v550 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v549 
        let v551 : string = "num_complex::Complex::powc($0, $1)"
        let v552 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v550, v1) v551 
        let v553 : string = "$0 * $1"
        let v554 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v548, v552) v553 
        let v555 : string = "$0 * $1"
        let v556 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v554, v84) v555 
        let v557 : string = "$0 * $1"
        let v558 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v556, v74) v557 
        let v559 : string = "$0 * $1"
        let v560 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v558, v546) v559 
        v560
and method17 (v0 : bool) : bool =
    v0
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
        let v16 : string = "$0.ok()"
        let v17 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v14 v16 
        let v18 : US0 option = None
        let _v18 = ref v18 
        let v19 : US0 option ref = _v18 
        let v20 : (US0 option -> US0 option ref) = closure1(v19)
        let v21 : unit = ()
        let v22 : (unit -> unit) = closure2(v17, v20)
        let v23 : unit = (fun () -> v22 (); v21) ()
        let v26 : US0 option = _v18.Value 
        let v37 : US0 = US0_1
        let v38 : US0 = v26 |> Option.defaultValue v37 
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
        let v51 : string = "$0.im"
        let v52 : float = Fable.Core.RustInterop.emitRustExpr v50 v51 
        let v53 : bool = v52 = 0.0
        let v55 : bool =
            if v53 then
                true
            else
                method17(v53)
        let v56 : string = "__assert_eq"
        let v57 : string = $"{v56} / actual: %A{v52} / expected: %A{0.0}"
        let v60 : unit = ()
        let v61 : (unit -> unit) = closure3(v57)
        let v62 : unit = (fun () -> v61 (); v60) ()
        let v64 : bool = v55 = false
        if v64 then
            failwith<unit> v57
        let v65 : string = "$0.re"
        let v66 : float = Fable.Core.RustInterop.emitRustExpr v50 v65 
        let v67 : float = v66 - v11
        let v68 : float =  -v67
        let v69 : bool = v67 >= v68
        let v70 : float =
            if v69 then
                v67
            else
                v68
        let v71 : bool = v70 < 0.0001
        let v73 : bool =
            if v71 then
                true
            else
                method17(v71)
        let v74 : string = "__assert_lt"
        let v75 : string = $"{v74} / actual: %A{v70} / expected: %A{0.0001}"
        let v78 : unit = ()
        let v79 : (unit -> unit) = closure3(v75)
        let v80 : unit = (fun () -> v79 (); v78) ()
        let v82 : bool = v73 = false
        if v82 then
            failwith<unit> v75
        let v83 : int32 = v9 + 1
        v7.l0 <- v83
        ()
    ()
and method18 (v0 : Result<unit, pyo3_PyErr>) : Result<unit, pyo3_PyErr> =
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
    let v5 : Result<unit, pyo3_PyErr> = method18(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
    ()
and method20 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, -2.0) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method13(v0, v2)
    let v7 : string = "$0.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v7 
    let v9 : US0 option = None
    let _v9 = ref v9 
    let v10 : US0 option ref = _v9 
    let v11 : (US0 option -> US0 option ref) = closure1(v10)
    let v12 : unit = ()
    let v13 : (unit -> unit) = closure2(v8, v11)
    let v14 : unit = (fun () -> v13 (); v12) ()
    let v17 : US0 option = _v9.Value 
    let v28 : US0 = US0_1
    let v29 : US0 = v17 |> Option.defaultValue v28 
    let v33 : string = "f64::NAN"
    let v34 : float = Fable.Core.RustInterop.emitRustExpr () v33 
    let v35 : string = "f64::NAN"
    let v36 : float = Fable.Core.RustInterop.emitRustExpr () v35 
    let v37 : string = "num_complex::Complex::new($0, $1)"
    let v38 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v34, v36) v37 
    let v41 : num_complex_Complex<float> =
        match v29 with
        | US0_1 -> (* None *)
            v38
        | US0_0(v39) -> (* Some *)
            v39
    let v42 : string = "$0.re"
    let v43 : float = Fable.Core.RustInterop.emitRustExpr v41 v42 
    let v44 : float = v43 - 0.8673
    let v45 : float =  -v44
    let v46 : bool = v44 >= v45
    let v47 : float =
        if v46 then
            v44
        else
            v45
    let v48 : bool = v47 < 0.001
    let v50 : bool =
        if v48 then
            true
        else
            method17(v48)
    let v51 : string = "__assert_lt"
    let v52 : string = $"{v51} / actual: %A{v47} / expected: %A{0.001}"
    let v55 : unit = ()
    let v56 : (unit -> unit) = closure3(v52)
    let v57 : unit = (fun () -> v56 (); v55) ()
    let v59 : bool = v50 = false
    if v59 then
        failwith<unit> v52
    let v60 : string = "$0.im"
    let v61 : float = Fable.Core.RustInterop.emitRustExpr v41 v60 
    let v62 : float = v61 - 0.275
    let v63 : float =  -v62
    let v64 : bool = v62 >= v63
    let v65 : float =
        if v64 then
            v62
        else
            v63
    let v66 : bool = v65 < 0.001
    let v68 : bool =
        if v66 then
            true
        else
            method17(v66)
    let v69 : string = $"{v51} / actual: %A{v65} / expected: %A{0.001}"
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure3(v69)
    let v74 : unit = (fun () -> v73 (); v72) ()
    let v76 : bool = v68 = false
    if v76 then
        failwith<unit> v69
and method19 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method20(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method18(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
    ()
and method23 () : UH0 =
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
and method24 (v0 : pyo3_Python, v1 : UH0) : unit =
    match v1 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : string = "num_complex::Complex::new($0, $1)"
        let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v2, 0.0) v4 
        let v6 : string = $"        s = mpmath.zeta(s)"
        let v7 : num_complex_Complex<float> = method3(v5)
        let v8 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v6, v7)
        let v9 : num_complex_Complex<float> = method13(v0, v5)
        let v10 : string = "$0.ok()"
        let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v8 v10 
        let v12 : US0 option = None
        let _v12 = ref v12 
        let v13 : US0 option ref = _v12 
        let v14 : (US0 option -> US0 option ref) = closure1(v13)
        let v15 : unit = ()
        let v16 : (unit -> unit) = closure2(v11, v14)
        let v17 : unit = (fun () -> v16 (); v15) ()
        let v20 : US0 option = _v12.Value 
        let v31 : US0 = US0_1
        let v32 : US0 = v20 |> Option.defaultValue v31 
        let v36 : string = "f64::NAN"
        let v37 : float = Fable.Core.RustInterop.emitRustExpr () v36 
        let v38 : string = "f64::NAN"
        let v39 : float = Fable.Core.RustInterop.emitRustExpr () v38 
        let v40 : string = "num_complex::Complex::new($0, $1)"
        let v41 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v37, v39) v40 
        let v44 : num_complex_Complex<float> =
            match v32 with
            | US0_1 -> (* None *)
                v41
            | US0_0(v42) -> (* Some *)
                v42
        let v45 : string = "$0.re"
        let v46 : float = Fable.Core.RustInterop.emitRustExpr v44 v45 
        let v47 : bool = v46 = 0.0
        let v49 : bool =
            if v47 then
                true
            else
                method17(v47)
        let v50 : string = "__assert_eq"
        let v51 : string = $"{v50} / actual: %A{v46} / expected: %A{0.0}"
        let v54 : unit = ()
        let v55 : (unit -> unit) = closure3(v51)
        let v56 : unit = (fun () -> v55 (); v54) ()
        let v58 : bool = v49 = false
        if v58 then
            failwith<unit> v51
        let v59 : string = "$0.im"
        let v60 : float = Fable.Core.RustInterop.emitRustExpr v44 v59 
        let v61 : bool = v60 = 0.0
        let v63 : bool =
            if v61 then
                true
            else
                method17(v61)
        let v64 : string = $"{v50} / actual: %A{v60} / expected: %A{0.0}"
        let v67 : unit = ()
        let v68 : (unit -> unit) = closure3(v64)
        let v69 : unit = (fun () -> v68 (); v67) ()
        let v71 : bool = v63 = false
        if v71 then
            failwith<unit> v64
        method24(v0, v3)
    | UH0_0 -> (* Nil *)
        ()
and method22 (v0 : pyo3_Python) : unit =
    let v1 : UH0 = method23()
    method24(v0, v1)
and method21 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method22(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method18(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
    ()
and method26 (v0 : pyo3_Python) : unit =
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
        let v23 : string = "$0.ok()"
        let v24 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v21 v23 
        let v25 : US0 option = None
        let _v25 = ref v25 
        let v26 : US0 option ref = _v25 
        let v27 : (US0 option -> US0 option ref) = closure1(v26)
        let v28 : unit = ()
        let v29 : (unit -> unit) = closure2(v24, v27)
        let v30 : unit = (fun () -> v29 (); v28) ()
        let v33 : US0 option = _v25.Value 
        let v44 : US0 = US0_1
        let v45 : US0 = v33 |> Option.defaultValue v44 
        let v49 : string = "f64::NAN"
        let v50 : float = Fable.Core.RustInterop.emitRustExpr () v49 
        let v51 : string = "f64::NAN"
        let v52 : float = Fable.Core.RustInterop.emitRustExpr () v51 
        let v53 : string = "num_complex::Complex::new($0, $1)"
        let v54 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v50, v52) v53 
        let v57 : num_complex_Complex<float> =
            match v45 with
            | US0_1 -> (* None *)
                v54
            | US0_0(v55) -> (* Some *)
                v55
        let v58 : string = "$0.re"
        let v59 : float = Fable.Core.RustInterop.emitRustExpr v57 v58 
        let v60 : float =  -v59
        let v61 : bool = v59 >= v60
        let v62 : float =
            if v61 then
                v59
            else
                v60
        let v63 : bool = v62 < 0.0001
        let v65 : bool =
            if v63 then
                true
            else
                method17(v63)
        let v66 : string = "__assert_lt"
        let v67 : string = $"{v66} / actual: %A{v62} / expected: %A{0.0001}"
        let v70 : unit = ()
        let v71 : (unit -> unit) = closure3(v67)
        let v72 : unit = (fun () -> v71 (); v70) ()
        let v74 : bool = v65 = false
        if v74 then
            failwith<unit> v67
        let v75 : string = "$0.im"
        let v76 : float = Fable.Core.RustInterop.emitRustExpr v57 v75 
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
                method17(v80)
        let v83 : string = $"{v66} / actual: %A{v79} / expected: %A{0.0001}"
        let v86 : unit = ()
        let v87 : (unit -> unit) = closure3(v83)
        let v88 : unit = (fun () -> v87 (); v86) ()
        let v90 : bool = v82 = false
        if v90 then
            failwith<unit> v83
        let v91 : int32 = v17 + 1
        v15.l0 <- v91
        ()
    ()
and method25 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method26(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method18(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
    ()
and method28 (v0 : pyo3_Python) : unit =
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
        let v13 : string = "$0.ok()"
        let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v11 v13 
        let v15 : US0 option = None
        let _v15 = ref v15 
        let v16 : US0 option ref = _v15 
        let v17 : (US0 option -> US0 option ref) = closure1(v16)
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure2(v14, v17)
        let v20 : unit = (fun () -> v19 (); v18) ()
        let v23 : US0 option = _v15.Value 
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
        let v50 : bool = v49 > 0.0
        let v52 : bool =
            if v50 then
                true
            else
                method17(v50)
        let v53 : string = "__assert_gt"
        let v54 : string = $"{v53} / actual: %A{v49} / expected: %A{0.0}"
        let v57 : unit = ()
        let v58 : (unit -> unit) = closure3(v54)
        let v59 : unit = (fun () -> v58 (); v57) ()
        let v61 : bool = v52 = false
        if v61 then
            failwith<unit> v54
        let v62 : string = "$0.im"
        let v63 : float = Fable.Core.RustInterop.emitRustExpr v47 v62 
        let v64 : bool = v63 = 0.0
        let v66 : bool =
            if v64 then
                true
            else
                method17(v64)
        let v67 : string = "__assert_eq"
        let v68 : string = $"{v67} / actual: %A{v63} / expected: %A{0.0}"
        let v71 : unit = ()
        let v72 : (unit -> unit) = closure3(v68)
        let v73 : unit = (fun () -> v72 (); v71) ()
        let v75 : bool = v66 = false
        if v75 then
            failwith<unit> v68
        let v76 : int32 = v5 + 1
        v3.l0 <- v76
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
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method18(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
    ()
and method30 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method13(v0, v2)
    let v7 : string = "$0.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v7 
    let v9 : US0 option = None
    let _v9 = ref v9 
    let v10 : US0 option ref = _v9 
    let v11 : (US0 option -> US0 option ref) = closure1(v10)
    let v12 : unit = ()
    let v13 : (unit -> unit) = closure2(v8, v11)
    let v14 : unit = (fun () -> v13 (); v12) ()
    let v17 : US0 option = _v9.Value 
    let v28 : US0 = US0_1
    let v29 : US0 = v17 |> Option.defaultValue v28 
    let v33 : string = "f64::NAN"
    let v34 : float = Fable.Core.RustInterop.emitRustExpr () v33 
    let v35 : string = "f64::NAN"
    let v36 : float = Fable.Core.RustInterop.emitRustExpr () v35 
    let v37 : string = "num_complex::Complex::new($0, $1)"
    let v38 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v34, v36) v37 
    let v41 : num_complex_Complex<float> =
        match v29 with
        | US0_1 -> (* None *)
            v38
        | US0_0(v39) -> (* Some *)
            v39
    let v42 : string = "$0.re"
    let v43 : float = Fable.Core.RustInterop.emitRustExpr v41 v42 
    let v44 : bool = v43 = infinity
    let v46 : bool =
        if v44 then
            true
        else
            method17(v44)
    let v47 : string = "__assert_eq"
    let v48 : string = $"{v47} / actual: %A{v43} / expected: %A{infinity}"
    let v51 : unit = ()
    let v52 : (unit -> unit) = closure3(v48)
    let v53 : unit = (fun () -> v52 (); v51) ()
    let v55 : bool = v46 = false
    if v55 then
        failwith<unit> v48
    let v56 : string = "$0.im"
    let v57 : float = Fable.Core.RustInterop.emitRustExpr v41 v56 
    let v58 : bool = v57 = 0.0
    let v60 : bool =
        if v58 then
            true
        else
            method17(v58)
    let v61 : string = $"{v47} / actual: %A{v57} / expected: %A{0.0}"
    let v64 : unit = ()
    let v65 : (unit -> unit) = closure3(v61)
    let v66 : unit = (fun () -> v65 (); v64) ()
    let v68 : bool = v60 = false
    if v68 then
        failwith<unit> v61
and method29 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method30(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method18(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
    ()
and method32 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 10.0) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method13(v0, v2)
    let v7 : string = "$0.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v7 
    let v9 : US0 option = None
    let _v9 = ref v9 
    let v10 : US0 option ref = _v9 
    let v11 : (US0 option -> US0 option ref) = closure1(v10)
    let v12 : unit = ()
    let v13 : (unit -> unit) = closure2(v8, v11)
    let v14 : unit = (fun () -> v13 (); v12) ()
    let v17 : US0 option = _v9.Value 
    let v28 : US0 = US0_1
    let v29 : US0 = v17 |> Option.defaultValue v28 
    let v33 : string = "f64::NAN"
    let v34 : float = Fable.Core.RustInterop.emitRustExpr () v33 
    let v35 : string = "f64::NAN"
    let v36 : float = Fable.Core.RustInterop.emitRustExpr () v35 
    let v37 : string = "num_complex::Complex::new($0, $1)"
    let v38 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v34, v36) v37 
    let v41 : num_complex_Complex<float> =
        match v29 with
        | US0_1 -> (* None *)
            v38
        | US0_0(v39) -> (* Some *)
            v39
    let v42 : string = "$0.re"
    let v43 : float = Fable.Core.RustInterop.emitRustExpr v2 v42 
    let v44 : string = "$0.im"
    let v45 : float = Fable.Core.RustInterop.emitRustExpr v2 v44 
    let v46 : float =  -v45
    let v47 : string = "num_complex::Complex::new($0, $1)"
    let v48 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v43, v46) v47 
    let v49 : string = $"        s = mpmath.zeta(s)"
    let v50 : num_complex_Complex<float> = method3(v48)
    let v51 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v49, v50)
    let v52 : num_complex_Complex<float> = method13(v0, v48)
    let v53 : string = "$0.ok()"
    let v54 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v51 v53 
    let v55 : US0 option = None
    let _v55 = ref v55 
    let v56 : US0 option ref = _v55 
    let v57 : (US0 option -> US0 option ref) = closure1(v56)
    let v58 : unit = ()
    let v59 : (unit -> unit) = closure2(v54, v57)
    let v60 : unit = (fun () -> v59 (); v58) ()
    let v63 : US0 option = _v55.Value 
    let v74 : US0 = US0_1
    let v75 : US0 = v63 |> Option.defaultValue v74 
    let v79 : string = "f64::NAN"
    let v80 : float = Fable.Core.RustInterop.emitRustExpr () v79 
    let v81 : string = "f64::NAN"
    let v82 : float = Fable.Core.RustInterop.emitRustExpr () v81 
    let v83 : string = "num_complex::Complex::new($0, $1)"
    let v84 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v80, v82) v83 
    let v87 : num_complex_Complex<float> =
        match v75 with
        | US0_1 -> (* None *)
            v84
        | US0_0(v85) -> (* Some *)
            v85
    let v88 : string = "$0.conj()"
    let v89 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v87 v88 
    let v90 : string = "$0.re"
    let v91 : float = Fable.Core.RustInterop.emitRustExpr v41 v90 
    let v92 : string = "$0.re"
    let v93 : float = Fable.Core.RustInterop.emitRustExpr v89 v92 
    let v94 : bool = v91 = v93
    let v96 : bool =
        if v94 then
            true
        else
            method17(v94)
    let v97 : string = "__assert_eq"
    let v98 : string = $"{v97} / actual: %A{v91} / expected: %A{v93}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure3(v98)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v105 : bool = v96 = false
    if v105 then
        failwith<unit> v98
    let v106 : string = "$0.im"
    let v107 : float = Fable.Core.RustInterop.emitRustExpr v41 v106 
    let v108 : string = "$0.im"
    let v109 : float = Fable.Core.RustInterop.emitRustExpr v89 v108 
    let v110 : bool = v107 = v109
    let v112 : bool =
        if v110 then
            true
        else
            method17(v110)
    let v113 : string = $"{v97} / actual: %A{v107} / expected: %A{v109}"
    let v116 : unit = ()
    let v117 : (unit -> unit) = closure3(v113)
    let v118 : unit = (fun () -> v117 (); v116) ()
    let v120 : bool = v112 = false
    if v120 then
        failwith<unit> v113
and method31 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method32(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method18(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
    ()
and method34 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.01, 0.01) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method13(v0, v2)
    let v7 : string = "$0.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v7 
    let v9 : US0 option = None
    let _v9 = ref v9 
    let v10 : US0 option ref = _v9 
    let v11 : (US0 option -> US0 option ref) = closure1(v10)
    let v12 : unit = ()
    let v13 : (unit -> unit) = closure2(v8, v11)
    let v14 : unit = (fun () -> v13 (); v12) ()
    let v17 : US0 option = _v9.Value 
    let v28 : US0 = US0_1
    let v29 : US0 = v17 |> Option.defaultValue v28 
    let v33 : string = "f64::NAN"
    let v34 : float = Fable.Core.RustInterop.emitRustExpr () v33 
    let v35 : string = "f64::NAN"
    let v36 : float = Fable.Core.RustInterop.emitRustExpr () v35 
    let v37 : string = "num_complex::Complex::new($0, $1)"
    let v38 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v34, v36) v37 
    let v41 : num_complex_Complex<float> =
        match v29 with
        | US0_1 -> (* None *)
            v38
        | US0_0(v39) -> (* Some *)
            v39
    let v42 : string = "$0.re"
    let v43 : float = Fable.Core.RustInterop.emitRustExpr v41 v42 
    let v44 : bool = v43 < infinity
    let v46 : bool =
        if v44 then
            true
        else
            method17(v44)
    let v47 : string = "__assert_lt"
    let v48 : string = $"{v47} / actual: %A{v43} / expected: %A{infinity}"
    let v51 : unit = ()
    let v52 : (unit -> unit) = closure3(v48)
    let v53 : unit = (fun () -> v52 (); v51) ()
    let v55 : bool = v46 = false
    if v55 then
        failwith<unit> v48
    let v56 : string = "$0.im"
    let v57 : float = Fable.Core.RustInterop.emitRustExpr v41 v56 
    let v58 : bool = v57 < infinity
    let v60 : bool =
        if v58 then
            true
        else
            method17(v58)
    let v61 : string = $"{v47} / actual: %A{v57} / expected: %A{infinity}"
    let v64 : unit = ()
    let v65 : (unit -> unit) = closure3(v61)
    let v66 : unit = (fun () -> v65 (); v64) ()
    let v68 : bool = v60 = false
    if v68 then
        failwith<unit> v61
and method33 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method34(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method18(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
    ()
and method37 () : UH0 =
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
and method38 (v0 : pyo3_Python, v1 : UH0) : unit =
    match v1 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : string = "num_complex::Complex::new($0, $1)"
        let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, v2) v4 
        let v6 : string = $"        s = mpmath.zeta(s)"
        let v7 : num_complex_Complex<float> = method3(v5)
        let v8 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v6, v7)
        let v9 : num_complex_Complex<float> = method13(v0, v5)
        let v10 : string = "$0.ok()"
        let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v8 v10 
        let v12 : US0 option = None
        let _v12 = ref v12 
        let v13 : US0 option ref = _v12 
        let v14 : (US0 option -> US0 option ref) = closure1(v13)
        let v15 : unit = ()
        let v16 : (unit -> unit) = closure2(v11, v14)
        let v17 : unit = (fun () -> v16 (); v15) ()
        let v20 : US0 option = _v12.Value 
        let v31 : US0 = US0_1
        let v32 : US0 = v20 |> Option.defaultValue v31 
        let v36 : string = "f64::NAN"
        let v37 : float = Fable.Core.RustInterop.emitRustExpr () v36 
        let v38 : string = "f64::NAN"
        let v39 : float = Fable.Core.RustInterop.emitRustExpr () v38 
        let v40 : string = "num_complex::Complex::new($0, $1)"
        let v41 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v37, v39) v40 
        let v44 : num_complex_Complex<float> =
            match v32 with
            | US0_1 -> (* None *)
                v41
            | US0_0(v42) -> (* Some *)
                v42
        let v45 : string = "$0.re"
        let v46 : float = Fable.Core.RustInterop.emitRustExpr v44 v45 
        let v47 : bool = v46 <> 0.0 
        let v51 : bool =
            if v47 then
                true
            else
                method17(v47)
        let v52 : string = "__assert_ne"
        let v53 : string = $"{v52} / actual: %A{v46} / expected: %A{0.0}"
        let v56 : unit = ()
        let v57 : (unit -> unit) = closure3(v53)
        let v58 : unit = (fun () -> v57 (); v56) ()
        let v60 : bool = v51 = false
        if v60 then
            failwith<unit> v53
        let v61 : string = "$0.im"
        let v62 : float = Fable.Core.RustInterop.emitRustExpr v44 v61 
        let v63 : bool = v62 <> 0.0 
        let v67 : bool =
            if v63 then
                true
            else
                method17(v63)
        let v68 : string = $"{v52} / actual: %A{v62} / expected: %A{0.0}"
        let v71 : unit = ()
        let v72 : (unit -> unit) = closure3(v68)
        let v73 : unit = (fun () -> v72 (); v71) ()
        let v75 : bool = v67 = false
        if v75 then
            failwith<unit> v68
        method38(v0, v3)
    | UH0_0 -> (* Nil *)
        ()
and method36 (v0 : pyo3_Python) : unit =
    let v1 : UH0 = method37()
    method38(v0, v1)
and method35 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method36(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method18(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
    ()
and method41 () : UH1 =
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
and method42 (v0 : pyo3_Python, v1 : UH1) : unit =
    match v1 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : string = $"        s = mpmath.zeta(s)"
        let v5 : num_complex_Complex<float> = method3(v2)
        let v6 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v4, v5)
        let v7 : num_complex_Complex<float> = method13(v0, v2)
        let v8 : string = "$0.ok()"
        let v9 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v6 v8 
        let v10 : US0 option = None
        let _v10 = ref v10 
        let v11 : US0 option ref = _v10 
        let v12 : (US0 option -> US0 option ref) = closure1(v11)
        let v13 : unit = ()
        let v14 : (unit -> unit) = closure2(v9, v12)
        let v15 : unit = (fun () -> v14 (); v13) ()
        let v18 : US0 option = _v10.Value 
        let v29 : US0 = US0_1
        let v30 : US0 = v18 |> Option.defaultValue v29 
        let v34 : string = "f64::NAN"
        let v35 : float = Fable.Core.RustInterop.emitRustExpr () v34 
        let v36 : string = "f64::NAN"
        let v37 : float = Fable.Core.RustInterop.emitRustExpr () v36 
        let v38 : string = "num_complex::Complex::new($0, $1)"
        let v39 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v35, v37) v38 
        let v42 : num_complex_Complex<float> =
            match v30 with
            | US0_1 -> (* None *)
                v39
            | US0_0(v40) -> (* Some *)
                v40
        let v43 : string = "$0.re"
        let v44 : float = Fable.Core.RustInterop.emitRustExpr v42 v43 
        let v45 : bool = v44 <> 0.0 
        let v49 : bool =
            if v45 then
                true
            else
                method17(v45)
        let v50 : string = "__assert_ne"
        let v51 : string = $"{v50} / actual: %A{v44} / expected: %A{0.0}"
        let v54 : unit = ()
        let v55 : (unit -> unit) = closure3(v51)
        let v56 : unit = (fun () -> v55 (); v54) ()
        let v58 : bool = v49 = false
        if v58 then
            failwith<unit> v51
        let v59 : string = "$0.im"
        let v60 : float = Fable.Core.RustInterop.emitRustExpr v42 v59 
        let v61 : bool = v60 <> 0.0 
        let v65 : bool =
            if v61 then
                true
            else
                method17(v61)
        let v66 : string = $"{v50} / actual: %A{v60} / expected: %A{0.0}"
        let v69 : unit = ()
        let v70 : (unit -> unit) = closure3(v66)
        let v71 : unit = (fun () -> v70 (); v69) ()
        let v73 : bool = v65 = false
        if v73 then
            failwith<unit> v66
        method42(v0, v3)
    | UH1_0 -> (* Nil *)
        ()
and method40 (v0 : pyo3_Python) : unit =
    let v1 : UH1 = method41()
    method42(v0, v1)
and method39 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method40(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method18(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
    ()
and method45 () : UH1 =
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
and method46 (v0 : pyo3_Python, v1 : UH1) : unit =
    match v1 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : string = $"        s = mpmath.zeta(s)"
        let v5 : num_complex_Complex<float> = method3(v2)
        let v6 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v4, v5)
        let v7 : num_complex_Complex<float> = method13(v0, v2)
        let v8 : string = "$0.ok()"
        let v9 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v6 v8 
        let v10 : US0 option = None
        let _v10 = ref v10 
        let v11 : US0 option ref = _v10 
        let v12 : (US0 option -> US0 option ref) = closure1(v11)
        let v13 : unit = ()
        let v14 : (unit -> unit) = closure2(v9, v12)
        let v15 : unit = (fun () -> v14 (); v13) ()
        let v18 : US0 option = _v10.Value 
        let v29 : US0 = US0_1
        let v30 : US0 = v18 |> Option.defaultValue v29 
        let v34 : string = "f64::NAN"
        let v35 : float = Fable.Core.RustInterop.emitRustExpr () v34 
        let v36 : string = "f64::NAN"
        let v37 : float = Fable.Core.RustInterop.emitRustExpr () v36 
        let v38 : string = "num_complex::Complex::new($0, $1)"
        let v39 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v35, v37) v38 
        let v42 : num_complex_Complex<float> =
            match v30 with
            | US0_1 -> (* None *)
                v39
            | US0_0(v40) -> (* Some *)
                v40
        let v43 : string = "num_complex::Complex::new($0, $1)"
        let v44 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v43 
        let v45 : string = "num_complex::Complex::powc($0, $1)"
        let v46 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v44, v2) v45 
        let v47 : string = "num_complex::Complex::new($0, $1)"
        let v48 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v47 
        let v49 : string = "num_complex::Complex::new($0, $1)"
        let v50 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v49 
        let v51 : string = "$0 - $1"
        let v52 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v2, v50) v51 
        let v53 : string = "num_complex::Complex::powc($0, $1)"
        let v54 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v48, v52) v53 
        let v55 : string = "$0 * $1"
        let v56 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v46, v54) v55 
        let v57 : string = "num_complex::Complex::new($0, $1)"
        let v58 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v57 
        let v59 : string = "$0 * $1"
        let v60 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v58, v2) v59 
        let v61 : string = "num_complex::Complex::new($0, $1)"
        let v62 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v61 
        let v63 : string = "$0 / $1"
        let v64 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v60, v62) v63 
        let v65 : string = "$0.sin()"
        let v66 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v64 v65 
        let v67 : string = "$0 * $1"
        let v68 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v56, v66) v67 
        let v69 : string = "num_complex::Complex::new($0, $1)"
        let v70 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v69 
        let v71 : string = "$0 - $1"
        let v72 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v70, v2) v71 
        let v73 : string = $"        s = mpmath.gamma(s)"
        let v74 : num_complex_Complex<float> = method3(v72)
        let v75 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v73, v74)
        let v76 : string = "$0.ok()"
        let v77 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v75 v76 
        let v78 : US0 option = None
        let _v78 = ref v78 
        let v79 : US0 option ref = _v78 
        let v80 : (US0 option -> US0 option ref) = closure1(v79)
        let v81 : unit = ()
        let v82 : (unit -> unit) = closure2(v77, v80)
        let v83 : unit = (fun () -> v82 (); v81) ()
        let v86 : US0 option = _v78.Value 
        let v97 : US0 = US0_1
        let v98 : US0 = v86 |> Option.defaultValue v97 
        let v102 : string = "f64::NAN"
        let v103 : float = Fable.Core.RustInterop.emitRustExpr () v102 
        let v104 : string = "f64::NAN"
        let v105 : float = Fable.Core.RustInterop.emitRustExpr () v104 
        let v106 : string = "num_complex::Complex::new($0, $1)"
        let v107 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v103, v105) v106 
        let v110 : num_complex_Complex<float> =
            match v98 with
            | US0_1 -> (* None *)
                v107
            | US0_0(v108) -> (* Some *)
                v108
        let v111 : string = "$0 * $1"
        let v112 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v68, v110) v111 
        let v113 : string = "$0.re"
        let v114 : float = Fable.Core.RustInterop.emitRustExpr v2 v113 
        let v115 : float = 1.0 - v114
        let v116 : string = "$0.im"
        let v117 : float = Fable.Core.RustInterop.emitRustExpr v2 v116 
        let v118 : float =  -v117
        let v119 : string = "num_complex::Complex::new($0, $1)"
        let v120 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v115, v118) v119 
        let v121 : string = $"        s = mpmath.zeta(s)"
        let v122 : num_complex_Complex<float> = method3(v120)
        let v123 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v121, v122)
        let v124 : num_complex_Complex<float> = method13(v0, v120)
        let v125 : string = "$0.ok()"
        let v126 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v123 v125 
        let v127 : US0 option = None
        let _v127 = ref v127 
        let v128 : US0 option ref = _v127 
        let v129 : (US0 option -> US0 option ref) = closure1(v128)
        let v130 : unit = ()
        let v131 : (unit -> unit) = closure2(v126, v129)
        let v132 : unit = (fun () -> v131 (); v130) ()
        let v135 : US0 option = _v127.Value 
        let v146 : US0 = US0_1
        let v147 : US0 = v135 |> Option.defaultValue v146 
        let v151 : string = "f64::NAN"
        let v152 : float = Fable.Core.RustInterop.emitRustExpr () v151 
        let v153 : string = "f64::NAN"
        let v154 : float = Fable.Core.RustInterop.emitRustExpr () v153 
        let v155 : string = "num_complex::Complex::new($0, $1)"
        let v156 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v152, v154) v155 
        let v159 : num_complex_Complex<float> =
            match v147 with
            | US0_1 -> (* None *)
                v156
            | US0_0(v157) -> (* Some *)
                v157
        let v160 : string = "$0 * $1"
        let v161 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v112, v159) v160 
        let v162 : string = "$0.re"
        let v163 : float = Fable.Core.RustInterop.emitRustExpr v42 v162 
        let v164 : string = "$0.re"
        let v165 : float = Fable.Core.RustInterop.emitRustExpr v161 v164 
        let v166 : float = v163 - v165
        let v167 : float =  -v166
        let v168 : bool = v166 >= v167
        let v169 : float =
            if v168 then
                v166
            else
                v167
        let v170 : bool = v169 < 0.0001
        let v172 : bool =
            if v170 then
                true
            else
                method17(v170)
        let v173 : string = "__assert_lt"
        let v174 : string = $"{v173} / actual: %A{v169} / expected: %A{0.0001}"
        let v177 : unit = ()
        let v178 : (unit -> unit) = closure3(v174)
        let v179 : unit = (fun () -> v178 (); v177) ()
        let v181 : bool = v172 = false
        if v181 then
            failwith<unit> v174
        let v182 : string = "$0.im"
        let v183 : float = Fable.Core.RustInterop.emitRustExpr v42 v182 
        let v184 : string = "$0.im"
        let v185 : float = Fable.Core.RustInterop.emitRustExpr v161 v184 
        let v186 : float = v183 - v185
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
                method17(v190)
        let v193 : string = $"{v173} / actual: %A{v189} / expected: %A{0.0001}"
        let v196 : unit = ()
        let v197 : (unit -> unit) = closure3(v193)
        let v198 : unit = (fun () -> v197 (); v196) ()
        let v200 : bool = v192 = false
        if v200 then
            failwith<unit> v193
        method46(v0, v3)
    | UH1_0 -> (* Nil *)
        ()
and method44 (v0 : pyo3_Python) : unit =
    let v1 : UH1 = method45()
    method46(v0, v1)
and method43 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method44(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method18(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
    ()
and method49 () : UH0 =
    let v0 : UH0 = UH0_0
    let v1 : UH0 = UH0_1(5.0, v0)
    let v2 : UH0 = UH0_1(4.5, v1)
    let v3 : UH0 = UH0_1(4.0, v2)
    let v4 : UH0 = UH0_1(3.5, v3)
    let v5 : UH0 = UH0_1(3.0, v4)
    let v6 : UH0 = UH0_1(2.5, v5)
    UH0_1(2.0, v6)
and method50 () : UH0 =
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
and method52 (v0 : float, v1 : UH0, v2 : float) : float =
    match v1 with
    | UH0_1(v3, v4) -> (* Cons *)
        let v5 : float =  -v0
        let v6 : float = v3 ** v5
        let v7 : float = 1.0 - v6
        let v8 : float = v2 / v7
        method52(v0, v4, v8)
    | UH0_0 -> (* Nil *)
        v2
and method51 (v0 : pyo3_Python, v1 : UH0, v2 : UH0) : unit =
    match v2 with
    | UH0_1(v3, v4) -> (* Cons *)
        let v5 : string = "num_complex::Complex::new($0, $1)"
        let v6 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v3, 0.0) v5 
        let v7 : float = 1.0
        let v8 : float = method52(v3, v1, v7)
        let v9 : string = $"        s = mpmath.zeta(s)"
        let v10 : num_complex_Complex<float> = method3(v6)
        let v11 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v9, v10)
        let v12 : num_complex_Complex<float> = method13(v0, v6)
        let v13 : string = "$0.ok()"
        let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v11 v13 
        let v15 : US0 option = None
        let _v15 = ref v15 
        let v16 : US0 option ref = _v15 
        let v17 : (US0 option -> US0 option ref) = closure1(v16)
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure2(v14, v17)
        let v20 : unit = (fun () -> v19 (); v18) ()
        let v23 : US0 option = _v15.Value 
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
        let v50 : float = v49 - v8
        let v51 : float =  -v50
        let v52 : bool = v50 >= v51
        let v53 : float =
            if v52 then
                v50
            else
                v51
        let v54 : bool = v53 < 0.01
        let v56 : bool =
            if v54 then
                true
            else
                method17(v54)
        let v57 : string = "__assert_lt"
        let v58 : string = $"{v57} / actual: %A{v53} / expected: %A{0.01}"
        let v61 : unit = ()
        let v62 : (unit -> unit) = closure3(v58)
        let v63 : unit = (fun () -> v62 (); v61) ()
        let v65 : bool = v56 = false
        if v65 then
            failwith<unit> v58
        let v66 : string = "$0.im"
        let v67 : float = Fable.Core.RustInterop.emitRustExpr v47 v66 
        let v68 : bool = v67 < 0.01
        let v70 : bool =
            if v68 then
                true
            else
                method17(v68)
        let v71 : string = $"{v57} / actual: %A{v67} / expected: %A{0.01}"
        let v74 : unit = ()
        let v75 : (unit -> unit) = closure3(v71)
        let v76 : unit = (fun () -> v75 (); v74) ()
        let v78 : bool = v70 = false
        if v78 then
            failwith<unit> v71
        method51(v0, v1, v4)
    | UH0_0 -> (* Nil *)
        ()
and method48 (v0 : pyo3_Python) : unit =
    let v1 : UH0 = method49()
    let v2 : UH0 = method50()
    method51(v0, v2, v1)
and method47 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method48(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method18(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
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
    method19()
    let v10 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v10 
    let v11 : string = "test_trivial_zero_at_negative_even___"
    let v12 : string = $"*/ #[test] fn " + v11 + "() { //"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    method21()
    let v14 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v14 
    let v15 : string = "test_non_trivial_zero___"
    let v16 : string = $"*/ #[test] fn " + v15 + "() { //"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr () v16 
    method25()
    let v18 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v18 
    let v19 : string = "test_real_part_greater_than_one___"
    let v20 : string = $"*/ #[test] fn " + v19 + "() { //"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr () v20 
    method27()
    let v22 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v22 
    let v23 : string = "test_zeta_at_1___"
    let v24 : string = $"*/ #[test] fn " + v23 + "() { //"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr () v24 
    method29()
    let v26 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v26 
    let v27 : string = "test_symmetry_across_real_axis___"
    let v28 : string = $"*/ #[test] fn " + v27 + "() { //"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr () v28 
    method31()
    let v30 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v30 
    let v31 : string = "test_behavior_near_origin___"
    let v32 : string = $"*/ #[test] fn " + v31 + "() { //"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32 
    method33()
    let v34 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v34 
    let v35 : string = "test_imaginary_axis"
    let v36 : string = $"*/ #[test] fn " + v35 + "() { //"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr () v36 
    method35()
    let v38 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v38 
    let v39 : string = "test_critical_strip"
    let v40 : string = $"*/ #[test] fn " + v39 + "() { //"
    let v41 : bool = Fable.Core.RustInterop.emitRustExpr () v40 
    method39()
    let v42 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v42 
    let v43 : string = "test_reflection_formula_for_specific_value"
    let v44 : string = $"*/ #[test] fn " + v43 + "() { //"
    let v45 : bool = Fable.Core.RustInterop.emitRustExpr () v44 
    method43()
    let v46 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v46 
    let v47 : string = "test_euler_product_formula"
    let v48 : string = $"*/ #[test] fn " + v47 + "() { //"
    let v49 : bool = Fable.Core.RustInterop.emitRustExpr () v48 
    method47()
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
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure3(v1)
    let v4 : unit = (fun () -> v3 (); v2) ()
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure4()
let main args = v1 args
()
