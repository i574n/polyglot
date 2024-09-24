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
        let v40 : string = "$0.ok()"
        let v41 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v39 v40 
        let v42 : (num_complex_Complex<float> -> US0) = method17()
        let v43 : US0 option = v41 |> Option.map v42 
        let v54 : US0 = US0_1
        let v55 : US0 = v43 |> Option.defaultValue v54 
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
        let v68 : string = "num_complex::Complex::new($0, $1)"
        let v69 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v68 
        let v70 : string = "$0 * $1"
        let v71 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v69, v1) v70 
        let v72 : string = "num_complex::Complex::new($0, $1)"
        let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v72 
        let v74 : string = "$0 / $1"
        let v75 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v71, v73) v74 
        let v76 : string = "$0.sin()"
        let v77 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v75 v76 
        let v78 : string = "$0.re"
        let v79 : float = Fable.Core.RustInterop.emitRustExpr v1 v78 
        let v80 : float = 1.0 - v79
        let v81 : string = "$0.im"
        let v82 : float = Fable.Core.RustInterop.emitRustExpr v1 v81 
        let v83 : float =  -v82
        let v84 : string = "num_complex::Complex::new($0, $1)"
        let v85 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v80, v83) v84 
        let v86 : string = "$0.re"
        let v87 : float = Fable.Core.RustInterop.emitRustExpr v85 v86 
        let v88 : bool = v87 <= 1.0
        let v511 : num_complex_Complex<float> =
            if v88 then
                let v89 : string = "num_complex::Complex::new($0, $1)"
                let v90 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v89 
                v90
            else
                let v91 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                Fable.Core.RustInterop.emitRustExpr struct (1, v85) v91 
                let v92 : string = "$0.re"
                let v93 : float = Fable.Core.RustInterop.emitRustExpr v85 v92 
                let v94 : bool = v93 > 1.0
                if v94 then
                    let v95 : string = "num_complex::Complex::new($0, $1)"
                    let v96 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v95 
                    let v97 : (int32 []) = Array.zeroCreate<int32> (10000)
                    let v98 : Mut0 = {l0 = 0} : Mut0
                    while method14(v98) do
                        let v100 : int32 = v98.l0
                        v97.[int v100] <- v100
                        let v101 : int32 = v100 + 1
                        v98.l0 <- v101
                        ()
                    let v102 : int32 = v97.Length
                    let v103 : Mut2 = {l0 = 0; l1 = v96} : Mut2
                    while method15(v102, v103) do
                        let v105 : int32 = v103.l0
                        let v106 : num_complex_Complex<float> = v103.l1
                        let v107 : int32 = v97.[int v105]
                        let v108 : string = "num_complex::Complex::new($0, $1)"
                        let v109 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v108 
                        let v110 : (int32 -> float) = float
                        let v111 : float = v110 v107
                        let v112 : string = "num_complex::Complex::new($0, $1)"
                        let v113 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v111, 0.0) v112 
                        let v114 : string = "num_complex::Complex::powc($0, $1)"
                        let v115 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v113, v85) v114 
                        let v116 : string = "$0 / $1"
                        let v117 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v109, v115) v116 
                        let v118 : string = "$0 + $1"
                        let v119 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v106, v117) v118 
                        let v120 : int32 = v105 + 1
                        v103.l0 <- v120
                        v103.l1 <- v119
                        ()
                    let v121 : num_complex_Complex<float> = v103.l1
                    v121
                else
                    let v122 : string = "num_complex::Complex::new($0, $1)"
                    let v123 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v122 
                    let v124 : string = "$0 - $1"
                    let v125 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v123, v85) v124 
                    let v126 : string = $"        s = mpmath.gamma(s)"
                    let v127 : num_complex_Complex<float> = method3(v125)
                    let v128 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v126, v127)
                    let v129 : string = "$0.ok()"
                    let v130 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v128 v129 
                    let v131 : (num_complex_Complex<float> -> US0) = method17()
                    let v132 : US0 option = v130 |> Option.map v131 
                    let v143 : US0 = US0_1
                    let v144 : US0 = v132 |> Option.defaultValue v143 
                    let v148 : string = "f64::NAN"
                    let v149 : float = Fable.Core.RustInterop.emitRustExpr () v148 
                    let v150 : string = "f64::NAN"
                    let v151 : float = Fable.Core.RustInterop.emitRustExpr () v150 
                    let v152 : string = "num_complex::Complex::new($0, $1)"
                    let v153 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v149, v151) v152 
                    let v156 : num_complex_Complex<float> =
                        match v144 with
                        | US0_1 -> (* None *)
                            v153
                        | US0_0(v154) -> (* Some *)
                            v154
                    let v157 : string = "num_complex::Complex::new($0, $1)"
                    let v158 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v157 
                    let v159 : string = "$0 * $1"
                    let v160 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v158, v85) v159 
                    let v161 : string = "num_complex::Complex::new($0, $1)"
                    let v162 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v161 
                    let v163 : string = "$0 / $1"
                    let v164 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v160, v162) v163 
                    let v165 : string = "$0.sin()"
                    let v166 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v164 v165 
                    let v167 : string = "$0.re"
                    let v168 : float = Fable.Core.RustInterop.emitRustExpr v85 v167 
                    let v169 : float = 1.0 - v168
                    let v170 : string = "$0.im"
                    let v171 : float = Fable.Core.RustInterop.emitRustExpr v85 v170 
                    let v172 : float =  -v171
                    let v173 : string = "num_complex::Complex::new($0, $1)"
                    let v174 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v169, v172) v173 
                    let v175 : string = "$0.re"
                    let v176 : float = Fable.Core.RustInterop.emitRustExpr v174 v175 
                    let v177 : bool = v176 <= 1.0
                    let v495 : num_complex_Complex<float> =
                        if v177 then
                            let v178 : string = "num_complex::Complex::new($0, $1)"
                            let v179 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v178 
                            v179
                        else
                            let v180 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                            Fable.Core.RustInterop.emitRustExpr struct (2, v174) v180 
                            let v181 : string = "$0.re"
                            let v182 : float = Fable.Core.RustInterop.emitRustExpr v174 v181 
                            let v183 : bool = v182 > 1.0
                            if v183 then
                                let v184 : string = "num_complex::Complex::new($0, $1)"
                                let v185 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v184 
                                let v186 : (int32 []) = Array.zeroCreate<int32> (10000)
                                let v187 : Mut0 = {l0 = 0} : Mut0
                                while method14(v187) do
                                    let v189 : int32 = v187.l0
                                    v186.[int v189] <- v189
                                    let v190 : int32 = v189 + 1
                                    v187.l0 <- v190
                                    ()
                                let v191 : int32 = v186.Length
                                let v192 : Mut2 = {l0 = 0; l1 = v185} : Mut2
                                while method15(v191, v192) do
                                    let v194 : int32 = v192.l0
                                    let v195 : num_complex_Complex<float> = v192.l1
                                    let v196 : int32 = v186.[int v194]
                                    let v197 : string = "num_complex::Complex::new($0, $1)"
                                    let v198 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v197 
                                    let v199 : (int32 -> float) = float
                                    let v200 : float = v199 v196
                                    let v201 : string = "num_complex::Complex::new($0, $1)"
                                    let v202 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v200, 0.0) v201 
                                    let v203 : string = "num_complex::Complex::powc($0, $1)"
                                    let v204 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v202, v174) v203 
                                    let v205 : string = "$0 / $1"
                                    let v206 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v198, v204) v205 
                                    let v207 : string = "$0 + $1"
                                    let v208 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v195, v206) v207 
                                    let v209 : int32 = v194 + 1
                                    v192.l0 <- v209
                                    v192.l1 <- v208
                                    ()
                                let v210 : num_complex_Complex<float> = v192.l1
                                v210
                            else
                                let v211 : string = "num_complex::Complex::new($0, $1)"
                                let v212 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v211 
                                let v213 : string = "$0 - $1"
                                let v214 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v212, v174) v213 
                                let v215 : string = $"        s = mpmath.gamma(s)"
                                let v216 : num_complex_Complex<float> = method3(v214)
                                let v217 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v215, v216)
                                let v218 : string = "$0.ok()"
                                let v219 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v217 v218 
                                let v220 : (num_complex_Complex<float> -> US0) = method17()
                                let v221 : US0 option = v219 |> Option.map v220 
                                let v232 : US0 = US0_1
                                let v233 : US0 = v221 |> Option.defaultValue v232 
                                let v237 : string = "f64::NAN"
                                let v238 : float = Fable.Core.RustInterop.emitRustExpr () v237 
                                let v239 : string = "f64::NAN"
                                let v240 : float = Fable.Core.RustInterop.emitRustExpr () v239 
                                let v241 : string = "num_complex::Complex::new($0, $1)"
                                let v242 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v238, v240) v241 
                                let v245 : num_complex_Complex<float> =
                                    match v233 with
                                    | US0_1 -> (* None *)
                                        v242
                                    | US0_0(v243) -> (* Some *)
                                        v243
                                let v246 : string = "num_complex::Complex::new($0, $1)"
                                let v247 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v246 
                                let v248 : string = "$0 * $1"
                                let v249 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v247, v174) v248 
                                let v250 : string = "num_complex::Complex::new($0, $1)"
                                let v251 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v250 
                                let v252 : string = "$0 / $1"
                                let v253 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v249, v251) v252 
                                let v254 : string = "$0.sin()"
                                let v255 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v253 v254 
                                let v256 : string = "$0.re"
                                let v257 : float = Fable.Core.RustInterop.emitRustExpr v174 v256 
                                let v258 : float = 1.0 - v257
                                let v259 : string = "$0.im"
                                let v260 : float = Fable.Core.RustInterop.emitRustExpr v174 v259 
                                let v261 : float =  -v260
                                let v262 : string = "num_complex::Complex::new($0, $1)"
                                let v263 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v258, v261) v262 
                                let v264 : string = "$0.re"
                                let v265 : float = Fable.Core.RustInterop.emitRustExpr v263 v264 
                                let v266 : bool = v265 <= 1.0
                                let v479 : num_complex_Complex<float> =
                                    if v266 then
                                        let v267 : string = "num_complex::Complex::new($0, $1)"
                                        let v268 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v267 
                                        v268
                                    else
                                        let v269 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                        Fable.Core.RustInterop.emitRustExpr struct (3, v263) v269 
                                        let v270 : string = "$0.re"
                                        let v271 : float = Fable.Core.RustInterop.emitRustExpr v263 v270 
                                        let v272 : bool = v271 > 1.0
                                        if v272 then
                                            let v273 : string = "num_complex::Complex::new($0, $1)"
                                            let v274 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v273 
                                            let v275 : (int32 []) = Array.zeroCreate<int32> (10000)
                                            let v276 : Mut0 = {l0 = 0} : Mut0
                                            while method14(v276) do
                                                let v278 : int32 = v276.l0
                                                v275.[int v278] <- v278
                                                let v279 : int32 = v278 + 1
                                                v276.l0 <- v279
                                                ()
                                            let v280 : int32 = v275.Length
                                            let v281 : Mut2 = {l0 = 0; l1 = v274} : Mut2
                                            while method15(v280, v281) do
                                                let v283 : int32 = v281.l0
                                                let v284 : num_complex_Complex<float> = v281.l1
                                                let v285 : int32 = v275.[int v283]
                                                let v286 : string = "num_complex::Complex::new($0, $1)"
                                                let v287 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v286 
                                                let v288 : (int32 -> float) = float
                                                let v289 : float = v288 v285
                                                let v290 : string = "num_complex::Complex::new($0, $1)"
                                                let v291 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v289, 0.0) v290 
                                                let v292 : string = "num_complex::Complex::powc($0, $1)"
                                                let v293 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v291, v263) v292 
                                                let v294 : string = "$0 / $1"
                                                let v295 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v287, v293) v294 
                                                let v296 : string = "$0 + $1"
                                                let v297 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v284, v295) v296 
                                                let v298 : int32 = v283 + 1
                                                v281.l0 <- v298
                                                v281.l1 <- v297
                                                ()
                                            let v299 : num_complex_Complex<float> = v281.l1
                                            v299
                                        else
                                            let v300 : string = "num_complex::Complex::new($0, $1)"
                                            let v301 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v300 
                                            let v302 : string = "$0 - $1"
                                            let v303 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v301, v263) v302 
                                            let v304 : string = $"        s = mpmath.gamma(s)"
                                            let v305 : num_complex_Complex<float> = method3(v303)
                                            let v306 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v304, v305)
                                            let v307 : string = "$0.ok()"
                                            let v308 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v306 v307 
                                            let v309 : (num_complex_Complex<float> -> US0) = method17()
                                            let v310 : US0 option = v308 |> Option.map v309 
                                            let v321 : US0 = US0_1
                                            let v322 : US0 = v310 |> Option.defaultValue v321 
                                            let v326 : string = "f64::NAN"
                                            let v327 : float = Fable.Core.RustInterop.emitRustExpr () v326 
                                            let v328 : string = "f64::NAN"
                                            let v329 : float = Fable.Core.RustInterop.emitRustExpr () v328 
                                            let v330 : string = "num_complex::Complex::new($0, $1)"
                                            let v331 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v327, v329) v330 
                                            let v334 : num_complex_Complex<float> =
                                                match v322 with
                                                | US0_1 -> (* None *)
                                                    v331
                                                | US0_0(v332) -> (* Some *)
                                                    v332
                                            let v335 : string = "num_complex::Complex::new($0, $1)"
                                            let v336 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v335 
                                            let v337 : string = "$0 * $1"
                                            let v338 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v336, v263) v337 
                                            let v339 : string = "num_complex::Complex::new($0, $1)"
                                            let v340 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v339 
                                            let v341 : string = "$0 / $1"
                                            let v342 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v338, v340) v341 
                                            let v343 : string = "$0.sin()"
                                            let v344 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v342 v343 
                                            let v345 : string = "$0.re"
                                            let v346 : float = Fable.Core.RustInterop.emitRustExpr v263 v345 
                                            let v347 : float = 1.0 - v346
                                            let v348 : string = "$0.im"
                                            let v349 : float = Fable.Core.RustInterop.emitRustExpr v263 v348 
                                            let v350 : float =  -v349
                                            let v351 : string = "num_complex::Complex::new($0, $1)"
                                            let v352 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v347, v350) v351 
                                            let v353 : string = "$0.re"
                                            let v354 : float = Fable.Core.RustInterop.emitRustExpr v352 v353 
                                            let v355 : bool = v354 <= 1.0
                                            let v463 : num_complex_Complex<float> =
                                                if v355 then
                                                    let v356 : string = "num_complex::Complex::new($0, $1)"
                                                    let v357 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v356 
                                                    v357
                                                else
                                                    let v358 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                                    Fable.Core.RustInterop.emitRustExpr struct (4, v352) v358 
                                                    let v359 : string = "$0.re"
                                                    let v360 : float = Fable.Core.RustInterop.emitRustExpr v352 v359 
                                                    let v361 : bool = v360 > 1.0
                                                    if v361 then
                                                        let v362 : string = "num_complex::Complex::new($0, $1)"
                                                        let v363 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v362 
                                                        let v364 : (int32 []) = Array.zeroCreate<int32> (10000)
                                                        let v365 : Mut0 = {l0 = 0} : Mut0
                                                        while method14(v365) do
                                                            let v367 : int32 = v365.l0
                                                            v364.[int v367] <- v367
                                                            let v368 : int32 = v367 + 1
                                                            v365.l0 <- v368
                                                            ()
                                                        let v369 : int32 = v364.Length
                                                        let v370 : Mut2 = {l0 = 0; l1 = v363} : Mut2
                                                        while method15(v369, v370) do
                                                            let v372 : int32 = v370.l0
                                                            let v373 : num_complex_Complex<float> = v370.l1
                                                            let v374 : int32 = v364.[int v372]
                                                            let v375 : string = "num_complex::Complex::new($0, $1)"
                                                            let v376 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v375 
                                                            let v377 : (int32 -> float) = float
                                                            let v378 : float = v377 v374
                                                            let v379 : string = "num_complex::Complex::new($0, $1)"
                                                            let v380 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v378, 0.0) v379 
                                                            let v381 : string = "num_complex::Complex::powc($0, $1)"
                                                            let v382 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v380, v352) v381 
                                                            let v383 : string = "$0 / $1"
                                                            let v384 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v376, v382) v383 
                                                            let v385 : string = "$0 + $1"
                                                            let v386 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v373, v384) v385 
                                                            let v387 : int32 = v372 + 1
                                                            v370.l0 <- v387
                                                            v370.l1 <- v386
                                                            ()
                                                        let v388 : num_complex_Complex<float> = v370.l1
                                                        v388
                                                    else
                                                        let v389 : string = "num_complex::Complex::new($0, $1)"
                                                        let v390 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v389 
                                                        let v391 : string = "$0 - $1"
                                                        let v392 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v390, v352) v391 
                                                        let v393 : string = $"        s = mpmath.gamma(s)"
                                                        let v394 : num_complex_Complex<float> = method3(v392)
                                                        let v395 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v393, v394)
                                                        let v396 : string = "$0.ok()"
                                                        let v397 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v395 v396 
                                                        let v398 : (num_complex_Complex<float> -> US0) = method17()
                                                        let v399 : US0 option = v397 |> Option.map v398 
                                                        let v410 : US0 = US0_1
                                                        let v411 : US0 = v399 |> Option.defaultValue v410 
                                                        let v415 : string = "f64::NAN"
                                                        let v416 : float = Fable.Core.RustInterop.emitRustExpr () v415 
                                                        let v417 : string = "f64::NAN"
                                                        let v418 : float = Fable.Core.RustInterop.emitRustExpr () v417 
                                                        let v419 : string = "num_complex::Complex::new($0, $1)"
                                                        let v420 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v416, v418) v419 
                                                        let v423 : num_complex_Complex<float> =
                                                            match v411 with
                                                            | US0_1 -> (* None *)
                                                                v420
                                                            | US0_0(v421) -> (* Some *)
                                                                v421
                                                        let v424 : string = "num_complex::Complex::new($0, $1)"
                                                        let v425 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v424 
                                                        let v426 : string = "$0 * $1"
                                                        let v427 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v425, v352) v426 
                                                        let v428 : string = "num_complex::Complex::new($0, $1)"
                                                        let v429 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v428 
                                                        let v430 : string = "$0 / $1"
                                                        let v431 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v427, v429) v430 
                                                        let v432 : string = "$0.sin()"
                                                        let v433 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v431 v432 
                                                        let v434 : string = "$0.re"
                                                        let v435 : float = Fable.Core.RustInterop.emitRustExpr v352 v434 
                                                        let v436 : float = 1.0 - v435
                                                        let v437 : string = "$0.im"
                                                        let v438 : float = Fable.Core.RustInterop.emitRustExpr v352 v437 
                                                        let v439 : float =  -v438
                                                        let v440 : string = "num_complex::Complex::new($0, $1)"
                                                        let v441 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v436, v439) v440 
                                                        let v442 : string = "$0.re"
                                                        let v443 : float = Fable.Core.RustInterop.emitRustExpr v441 v442 
                                                        let v444 : bool = v443 <= 1.0
                                                        let v447 : num_complex_Complex<float> =
                                                            if v444 then
                                                                let v445 : string = "num_complex::Complex::new($0, $1)"
                                                                let v446 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v445 
                                                                v446
                                                            else
                                                                v441
                                                        let v448 : string = "num_complex::Complex::new($0, $1)"
                                                        let v449 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v448 
                                                        let v450 : string = "num_complex::Complex::new($0, $1)"
                                                        let v451 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v450 
                                                        let v452 : string = "num_complex::Complex::powc($0, $1)"
                                                        let v453 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v451, v352) v452 
                                                        let v454 : string = "$0 * $1"
                                                        let v455 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v449, v453) v454 
                                                        let v456 : string = "$0 * $1"
                                                        let v457 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v455, v433) v456 
                                                        let v458 : string = "$0 * $1"
                                                        let v459 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v457, v423) v458 
                                                        let v460 : string = "$0 * $1"
                                                        let v461 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v459, v447) v460 
                                                        v461
                                            let v464 : string = "num_complex::Complex::new($0, $1)"
                                            let v465 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v464 
                                            let v466 : string = "num_complex::Complex::new($0, $1)"
                                            let v467 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v466 
                                            let v468 : string = "num_complex::Complex::powc($0, $1)"
                                            let v469 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v467, v263) v468 
                                            let v470 : string = "$0 * $1"
                                            let v471 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v465, v469) v470 
                                            let v472 : string = "$0 * $1"
                                            let v473 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v471, v344) v472 
                                            let v474 : string = "$0 * $1"
                                            let v475 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v473, v334) v474 
                                            let v476 : string = "$0 * $1"
                                            let v477 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v475, v463) v476 
                                            v477
                                let v480 : string = "num_complex::Complex::new($0, $1)"
                                let v481 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v480 
                                let v482 : string = "num_complex::Complex::new($0, $1)"
                                let v483 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v482 
                                let v484 : string = "num_complex::Complex::powc($0, $1)"
                                let v485 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v483, v174) v484 
                                let v486 : string = "$0 * $1"
                                let v487 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v481, v485) v486 
                                let v488 : string = "$0 * $1"
                                let v489 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v487, v255) v488 
                                let v490 : string = "$0 * $1"
                                let v491 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v489, v245) v490 
                                let v492 : string = "$0 * $1"
                                let v493 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v491, v479) v492 
                                v493
                    let v496 : string = "num_complex::Complex::new($0, $1)"
                    let v497 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v496 
                    let v498 : string = "num_complex::Complex::new($0, $1)"
                    let v499 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v498 
                    let v500 : string = "num_complex::Complex::powc($0, $1)"
                    let v501 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v499, v85) v500 
                    let v502 : string = "$0 * $1"
                    let v503 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v497, v501) v502 
                    let v504 : string = "$0 * $1"
                    let v505 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v503, v166) v504 
                    let v506 : string = "$0 * $1"
                    let v507 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v505, v156) v506 
                    let v508 : string = "$0 * $1"
                    let v509 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v507, v495) v508 
                    v509
        let v512 : string = "num_complex::Complex::new($0, $1)"
        let v513 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v512 
        let v514 : string = "num_complex::Complex::new($0, $1)"
        let v515 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v514 
        let v516 : string = "num_complex::Complex::powc($0, $1)"
        let v517 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v515, v1) v516 
        let v518 : string = "$0 * $1"
        let v519 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v513, v517) v518 
        let v520 : string = "$0 * $1"
        let v521 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v519, v77) v520 
        let v522 : string = "$0 * $1"
        let v523 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v521, v67) v522 
        let v524 : string = "$0 * $1"
        let v525 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v523, v511) v524 
        v525
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
        let v16 : string = "$0.ok()"
        let v17 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v14 v16 
        let v18 : (num_complex_Complex<float> -> US0) = method17()
        let v19 : US0 option = v17 |> Option.map v18 
        let v30 : US0 = US0_1
        let v31 : US0 = v19 |> Option.defaultValue v30 
        let v35 : string = "f64::NAN"
        let v36 : float = Fable.Core.RustInterop.emitRustExpr () v35 
        let v37 : string = "f64::NAN"
        let v38 : float = Fable.Core.RustInterop.emitRustExpr () v37 
        let v39 : string = "num_complex::Complex::new($0, $1)"
        let v40 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v36, v38) v39 
        let v43 : num_complex_Complex<float> =
            match v31 with
            | US0_1 -> (* None *)
                v40
            | US0_0(v41) -> (* Some *)
                v41
        let v44 : string = "$0.im"
        let v45 : float = Fable.Core.RustInterop.emitRustExpr v43 v44 
        let v46 : bool = v45 = 0.0
        let v48 : bool =
            if v46 then
                true
            else
                method18(v46)
        let v49 : string = "__assert_eq"
        let v50 : string = $"{v49} / actual: %A{v45} / expected: %A{0.0}"
        let v53 : unit = ()
        let v54 : (unit -> unit) = closure2(v50)
        let v55 : unit = (fun () -> v54 (); v53) ()
        let v57 : bool = v48 = false
        if v57 then
            failwith<unit> v50
        let v58 : string = "$0.re"
        let v59 : float = Fable.Core.RustInterop.emitRustExpr v43 v58 
        let v60 : float = v59 - v11
        let v61 : float =  -v60
        let v62 : bool = v60 >= v61
        let v63 : float =
            if v62 then
                v60
            else
                v61
        let v64 : bool = v63 < 0.0001
        let v66 : bool =
            if v64 then
                true
            else
                method18(v64)
        let v67 : string = "__assert_lt"
        let v68 : string = $"{v67} / actual: %A{v63} / expected: %A{0.0001}"
        let v71 : unit = ()
        let v72 : (unit -> unit) = closure2(v68)
        let v73 : unit = (fun () -> v72 (); v71) ()
        let v75 : bool = v66 = false
        if v75 then
            failwith<unit> v68
        let v76 : int32 = v9 + 1
        v7.l0 <- v76
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
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
    ()
and method21 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, -2.0) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method13(v0, v2)
    let v7 : string = "$0.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v7 
    let v9 : (num_complex_Complex<float> -> US0) = method17()
    let v10 : US0 option = v8 |> Option.map v9 
    let v21 : US0 = US0_1
    let v22 : US0 = v10 |> Option.defaultValue v21 
    let v26 : string = "f64::NAN"
    let v27 : float = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "f64::NAN"
    let v29 : float = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : string = "num_complex::Complex::new($0, $1)"
    let v31 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v27, v29) v30 
    let v34 : num_complex_Complex<float> =
        match v22 with
        | US0_1 -> (* None *)
            v31
        | US0_0(v32) -> (* Some *)
            v32
    let v35 : string = "$0.re"
    let v36 : float = Fable.Core.RustInterop.emitRustExpr v34 v35 
    let v37 : float = v36 - 0.8673
    let v38 : float =  -v37
    let v39 : bool = v37 >= v38
    let v40 : float =
        if v39 then
            v37
        else
            v38
    let v41 : bool = v40 < 0.001
    let v43 : bool =
        if v41 then
            true
        else
            method18(v41)
    let v44 : string = "__assert_lt"
    let v45 : string = $"{v44} / actual: %A{v40} / expected: %A{0.001}"
    let v48 : unit = ()
    let v49 : (unit -> unit) = closure2(v45)
    let v50 : unit = (fun () -> v49 (); v48) ()
    let v52 : bool = v43 = false
    if v52 then
        failwith<unit> v45
    let v53 : string = "$0.im"
    let v54 : float = Fable.Core.RustInterop.emitRustExpr v34 v53 
    let v55 : float = v54 - 0.275
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
    let v62 : string = $"{v44} / actual: %A{v58} / expected: %A{0.001}"
    let v65 : unit = ()
    let v66 : (unit -> unit) = closure2(v62)
    let v67 : unit = (fun () -> v66 (); v65) ()
    let v69 : bool = v61 = false
    if v69 then
        failwith<unit> v62
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
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
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
        let v10 : string = "$0.ok()"
        let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v8 v10 
        let v12 : (num_complex_Complex<float> -> US0) = method17()
        let v13 : US0 option = v11 |> Option.map v12 
        let v24 : US0 = US0_1
        let v25 : US0 = v13 |> Option.defaultValue v24 
        let v29 : string = "f64::NAN"
        let v30 : float = Fable.Core.RustInterop.emitRustExpr () v29 
        let v31 : string = "f64::NAN"
        let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31 
        let v33 : string = "num_complex::Complex::new($0, $1)"
        let v34 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v30, v32) v33 
        let v37 : num_complex_Complex<float> =
            match v25 with
            | US0_1 -> (* None *)
                v34
            | US0_0(v35) -> (* Some *)
                v35
        let v38 : string = "$0.re"
        let v39 : float = Fable.Core.RustInterop.emitRustExpr v37 v38 
        let v40 : bool = v39 = 0.0
        let v42 : bool =
            if v40 then
                true
            else
                method18(v40)
        let v43 : string = "__assert_eq"
        let v44 : string = $"{v43} / actual: %A{v39} / expected: %A{0.0}"
        let v47 : unit = ()
        let v48 : (unit -> unit) = closure2(v44)
        let v49 : unit = (fun () -> v48 (); v47) ()
        let v51 : bool = v42 = false
        if v51 then
            failwith<unit> v44
        let v52 : string = "$0.im"
        let v53 : float = Fable.Core.RustInterop.emitRustExpr v37 v52 
        let v54 : bool = v53 = 0.0
        let v56 : bool =
            if v54 then
                true
            else
                method18(v54)
        let v57 : string = $"{v43} / actual: %A{v53} / expected: %A{0.0}"
        let v60 : unit = ()
        let v61 : (unit -> unit) = closure2(v57)
        let v62 : unit = (fun () -> v61 (); v60) ()
        let v64 : bool = v56 = false
        if v64 then
            failwith<unit> v57
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
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
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
        let v23 : string = "$0.ok()"
        let v24 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v21 v23 
        let v25 : (num_complex_Complex<float> -> US0) = method17()
        let v26 : US0 option = v24 |> Option.map v25 
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
        let v51 : string = "$0.re"
        let v52 : float = Fable.Core.RustInterop.emitRustExpr v50 v51 
        let v53 : float =  -v52
        let v54 : bool = v52 >= v53
        let v55 : float =
            if v54 then
                v52
            else
                v53
        let v56 : bool = v55 < 0.0001
        let v58 : bool =
            if v56 then
                true
            else
                method18(v56)
        let v59 : string = "__assert_lt"
        let v60 : string = $"{v59} / actual: %A{v55} / expected: %A{0.0001}"
        let v63 : unit = ()
        let v64 : (unit -> unit) = closure2(v60)
        let v65 : unit = (fun () -> v64 (); v63) ()
        let v67 : bool = v58 = false
        if v67 then
            failwith<unit> v60
        let v68 : string = "$0.im"
        let v69 : float = Fable.Core.RustInterop.emitRustExpr v50 v68 
        let v70 : float =  -v69
        let v71 : bool = v69 >= v70
        let v72 : float =
            if v71 then
                v69
            else
                v70
        let v73 : bool = v72 < 0.0001
        let v75 : bool =
            if v73 then
                true
            else
                method18(v73)
        let v76 : string = $"{v59} / actual: %A{v72} / expected: %A{0.0001}"
        let v79 : unit = ()
        let v80 : (unit -> unit) = closure2(v76)
        let v81 : unit = (fun () -> v80 (); v79) ()
        let v83 : bool = v75 = false
        if v83 then
            failwith<unit> v76
        let v84 : int32 = v17 + 1
        v15.l0 <- v84
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
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
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
        let v13 : string = "$0.ok()"
        let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v11 v13 
        let v15 : (num_complex_Complex<float> -> US0) = method17()
        let v16 : US0 option = v14 |> Option.map v15 
        let v27 : US0 = US0_1
        let v28 : US0 = v16 |> Option.defaultValue v27 
        let v32 : string = "f64::NAN"
        let v33 : float = Fable.Core.RustInterop.emitRustExpr () v32 
        let v34 : string = "f64::NAN"
        let v35 : float = Fable.Core.RustInterop.emitRustExpr () v34 
        let v36 : string = "num_complex::Complex::new($0, $1)"
        let v37 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v33, v35) v36 
        let v40 : num_complex_Complex<float> =
            match v28 with
            | US0_1 -> (* None *)
                v37
            | US0_0(v38) -> (* Some *)
                v38
        let v41 : string = "$0.re"
        let v42 : float = Fable.Core.RustInterop.emitRustExpr v40 v41 
        let v43 : bool = v42 > 0.0
        let v45 : bool =
            if v43 then
                true
            else
                method18(v43)
        let v46 : string = "__assert_gt"
        let v47 : string = $"{v46} / actual: %A{v42} / expected: %A{0.0}"
        let v50 : unit = ()
        let v51 : (unit -> unit) = closure2(v47)
        let v52 : unit = (fun () -> v51 (); v50) ()
        let v54 : bool = v45 = false
        if v54 then
            failwith<unit> v47
        let v55 : string = "$0.im"
        let v56 : float = Fable.Core.RustInterop.emitRustExpr v40 v55 
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
        let v69 : int32 = v5 + 1
        v3.l0 <- v69
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
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
    ()
and method31 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method13(v0, v2)
    let v7 : string = "$0.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v7 
    let v9 : (num_complex_Complex<float> -> US0) = method17()
    let v10 : US0 option = v8 |> Option.map v9 
    let v21 : US0 = US0_1
    let v22 : US0 = v10 |> Option.defaultValue v21 
    let v26 : string = "f64::NAN"
    let v27 : float = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "f64::NAN"
    let v29 : float = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : string = "num_complex::Complex::new($0, $1)"
    let v31 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v27, v29) v30 
    let v34 : num_complex_Complex<float> =
        match v22 with
        | US0_1 -> (* None *)
            v31
        | US0_0(v32) -> (* Some *)
            v32
    let v35 : string = "$0.re"
    let v36 : float = Fable.Core.RustInterop.emitRustExpr v34 v35 
    let v37 : bool = v36 = infinity
    let v39 : bool =
        if v37 then
            true
        else
            method18(v37)
    let v40 : string = "__assert_eq"
    let v41 : string = $"{v40} / actual: %A{v36} / expected: %A{infinity}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure2(v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v48 : bool = v39 = false
    if v48 then
        failwith<unit> v41
    let v49 : string = "$0.im"
    let v50 : float = Fable.Core.RustInterop.emitRustExpr v34 v49 
    let v51 : bool = v50 = 0.0
    let v53 : bool =
        if v51 then
            true
        else
            method18(v51)
    let v54 : string = $"{v40} / actual: %A{v50} / expected: %A{0.0}"
    let v57 : unit = ()
    let v58 : (unit -> unit) = closure2(v54)
    let v59 : unit = (fun () -> v58 (); v57) ()
    let v61 : bool = v53 = false
    if v61 then
        failwith<unit> v54
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
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
    ()
and method33 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 10.0) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method13(v0, v2)
    let v7 : string = "$0.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v7 
    let v9 : (num_complex_Complex<float> -> US0) = method17()
    let v10 : US0 option = v8 |> Option.map v9 
    let v21 : US0 = US0_1
    let v22 : US0 = v10 |> Option.defaultValue v21 
    let v26 : string = "f64::NAN"
    let v27 : float = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "f64::NAN"
    let v29 : float = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : string = "num_complex::Complex::new($0, $1)"
    let v31 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v27, v29) v30 
    let v34 : num_complex_Complex<float> =
        match v22 with
        | US0_1 -> (* None *)
            v31
        | US0_0(v32) -> (* Some *)
            v32
    let v35 : string = "$0.re"
    let v36 : float = Fable.Core.RustInterop.emitRustExpr v2 v35 
    let v37 : string = "$0.im"
    let v38 : float = Fable.Core.RustInterop.emitRustExpr v2 v37 
    let v39 : float =  -v38
    let v40 : string = "num_complex::Complex::new($0, $1)"
    let v41 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v36, v39) v40 
    let v42 : string = $"        s = mpmath.zeta(s)"
    let v43 : num_complex_Complex<float> = method3(v41)
    let v44 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v42, v43)
    let v45 : num_complex_Complex<float> = method13(v0, v41)
    let v46 : string = "$0.ok()"
    let v47 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v44 v46 
    let v48 : (num_complex_Complex<float> -> US0) = method17()
    let v49 : US0 option = v47 |> Option.map v48 
    let v60 : US0 = US0_1
    let v61 : US0 = v49 |> Option.defaultValue v60 
    let v65 : string = "f64::NAN"
    let v66 : float = Fable.Core.RustInterop.emitRustExpr () v65 
    let v67 : string = "f64::NAN"
    let v68 : float = Fable.Core.RustInterop.emitRustExpr () v67 
    let v69 : string = "num_complex::Complex::new($0, $1)"
    let v70 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v66, v68) v69 
    let v73 : num_complex_Complex<float> =
        match v61 with
        | US0_1 -> (* None *)
            v70
        | US0_0(v71) -> (* Some *)
            v71
    let v74 : string = "$0.conj()"
    let v75 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v73 v74 
    let v76 : string = "$0.re"
    let v77 : float = Fable.Core.RustInterop.emitRustExpr v34 v76 
    let v78 : string = "$0.re"
    let v79 : float = Fable.Core.RustInterop.emitRustExpr v75 v78 
    let v80 : bool = v77 = v79
    let v82 : bool =
        if v80 then
            true
        else
            method18(v80)
    let v83 : string = "__assert_eq"
    let v84 : string = $"{v83} / actual: %A{v77} / expected: %A{v79}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure2(v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v91 : bool = v82 = false
    if v91 then
        failwith<unit> v84
    let v92 : string = "$0.im"
    let v93 : float = Fable.Core.RustInterop.emitRustExpr v34 v92 
    let v94 : string = "$0.im"
    let v95 : float = Fable.Core.RustInterop.emitRustExpr v75 v94 
    let v96 : bool = v93 = v95
    let v98 : bool =
        if v96 then
            true
        else
            method18(v96)
    let v99 : string = $"{v83} / actual: %A{v93} / expected: %A{v95}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure2(v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v106 : bool = v98 = false
    if v106 then
        failwith<unit> v99
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
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
    ()
and method35 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.01, 0.01) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method13(v0, v2)
    let v7 : string = "$0.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v7 
    let v9 : (num_complex_Complex<float> -> US0) = method17()
    let v10 : US0 option = v8 |> Option.map v9 
    let v21 : US0 = US0_1
    let v22 : US0 = v10 |> Option.defaultValue v21 
    let v26 : string = "f64::NAN"
    let v27 : float = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "f64::NAN"
    let v29 : float = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : string = "num_complex::Complex::new($0, $1)"
    let v31 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v27, v29) v30 
    let v34 : num_complex_Complex<float> =
        match v22 with
        | US0_1 -> (* None *)
            v31
        | US0_0(v32) -> (* Some *)
            v32
    let v35 : string = "$0.re"
    let v36 : float = Fable.Core.RustInterop.emitRustExpr v34 v35 
    let v37 : bool = v36 < infinity
    let v39 : bool =
        if v37 then
            true
        else
            method18(v37)
    let v40 : string = "__assert_lt"
    let v41 : string = $"{v40} / actual: %A{v36} / expected: %A{infinity}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure2(v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v48 : bool = v39 = false
    if v48 then
        failwith<unit> v41
    let v49 : string = "$0.im"
    let v50 : float = Fable.Core.RustInterop.emitRustExpr v34 v49 
    let v51 : bool = v50 < infinity
    let v53 : bool =
        if v51 then
            true
        else
            method18(v51)
    let v54 : string = $"{v40} / actual: %A{v50} / expected: %A{infinity}"
    let v57 : unit = ()
    let v58 : (unit -> unit) = closure2(v54)
    let v59 : unit = (fun () -> v58 (); v57) ()
    let v61 : bool = v53 = false
    if v61 then
        failwith<unit> v54
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
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
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
        let v10 : string = "$0.ok()"
        let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v8 v10 
        let v12 : (num_complex_Complex<float> -> US0) = method17()
        let v13 : US0 option = v11 |> Option.map v12 
        let v24 : US0 = US0_1
        let v25 : US0 = v13 |> Option.defaultValue v24 
        let v29 : string = "f64::NAN"
        let v30 : float = Fable.Core.RustInterop.emitRustExpr () v29 
        let v31 : string = "f64::NAN"
        let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31 
        let v33 : string = "num_complex::Complex::new($0, $1)"
        let v34 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v30, v32) v33 
        let v37 : num_complex_Complex<float> =
            match v25 with
            | US0_1 -> (* None *)
                v34
            | US0_0(v35) -> (* Some *)
                v35
        let v38 : string = "$0.re"
        let v39 : float = Fable.Core.RustInterop.emitRustExpr v37 v38 
        let v40 : bool = v39 <> 0.0 
        let v44 : bool =
            if v40 then
                true
            else
                method18(v40)
        let v45 : string = "__assert_ne"
        let v46 : string = $"{v45} / actual: %A{v39} / expected: %A{0.0}"
        let v49 : unit = ()
        let v50 : (unit -> unit) = closure2(v46)
        let v51 : unit = (fun () -> v50 (); v49) ()
        let v53 : bool = v44 = false
        if v53 then
            failwith<unit> v46
        let v54 : string = "$0.im"
        let v55 : float = Fable.Core.RustInterop.emitRustExpr v37 v54 
        let v56 : bool = v55 <> 0.0 
        let v60 : bool =
            if v56 then
                true
            else
                method18(v56)
        let v61 : string = $"{v45} / actual: %A{v55} / expected: %A{0.0}"
        let v64 : unit = ()
        let v65 : (unit -> unit) = closure2(v61)
        let v66 : unit = (fun () -> v65 (); v64) ()
        let v68 : bool = v60 = false
        if v68 then
            failwith<unit> v61
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
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
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
        let v8 : string = "$0.ok()"
        let v9 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v6 v8 
        let v10 : (num_complex_Complex<float> -> US0) = method17()
        let v11 : US0 option = v9 |> Option.map v10 
        let v22 : US0 = US0_1
        let v23 : US0 = v11 |> Option.defaultValue v22 
        let v27 : string = "f64::NAN"
        let v28 : float = Fable.Core.RustInterop.emitRustExpr () v27 
        let v29 : string = "f64::NAN"
        let v30 : float = Fable.Core.RustInterop.emitRustExpr () v29 
        let v31 : string = "num_complex::Complex::new($0, $1)"
        let v32 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v28, v30) v31 
        let v35 : num_complex_Complex<float> =
            match v23 with
            | US0_1 -> (* None *)
                v32
            | US0_0(v33) -> (* Some *)
                v33
        let v36 : string = "$0.re"
        let v37 : float = Fable.Core.RustInterop.emitRustExpr v35 v36 
        let v38 : bool = v37 <> 0.0 
        let v42 : bool =
            if v38 then
                true
            else
                method18(v38)
        let v43 : string = "__assert_ne"
        let v44 : string = $"{v43} / actual: %A{v37} / expected: %A{0.0}"
        let v47 : unit = ()
        let v48 : (unit -> unit) = closure2(v44)
        let v49 : unit = (fun () -> v48 (); v47) ()
        let v51 : bool = v42 = false
        if v51 then
            failwith<unit> v44
        let v52 : string = "$0.im"
        let v53 : float = Fable.Core.RustInterop.emitRustExpr v35 v52 
        let v54 : bool = v53 <> 0.0 
        let v58 : bool =
            if v54 then
                true
            else
                method18(v54)
        let v59 : string = $"{v43} / actual: %A{v53} / expected: %A{0.0}"
        let v62 : unit = ()
        let v63 : (unit -> unit) = closure2(v59)
        let v64 : unit = (fun () -> v63 (); v62) ()
        let v66 : bool = v58 = false
        if v66 then
            failwith<unit> v59
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
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
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
        let v8 : string = "$0.ok()"
        let v9 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v6 v8 
        let v10 : (num_complex_Complex<float> -> US0) = method17()
        let v11 : US0 option = v9 |> Option.map v10 
        let v22 : US0 = US0_1
        let v23 : US0 = v11 |> Option.defaultValue v22 
        let v27 : string = "f64::NAN"
        let v28 : float = Fable.Core.RustInterop.emitRustExpr () v27 
        let v29 : string = "f64::NAN"
        let v30 : float = Fable.Core.RustInterop.emitRustExpr () v29 
        let v31 : string = "num_complex::Complex::new($0, $1)"
        let v32 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v28, v30) v31 
        let v35 : num_complex_Complex<float> =
            match v23 with
            | US0_1 -> (* None *)
                v32
            | US0_0(v33) -> (* Some *)
                v33
        let v36 : string = "num_complex::Complex::new($0, $1)"
        let v37 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v36 
        let v38 : string = "num_complex::Complex::powc($0, $1)"
        let v39 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v37, v2) v38 
        let v40 : string = "num_complex::Complex::new($0, $1)"
        let v41 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v40 
        let v42 : string = "num_complex::Complex::new($0, $1)"
        let v43 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v42 
        let v44 : string = "$0 - $1"
        let v45 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v2, v43) v44 
        let v46 : string = "num_complex::Complex::powc($0, $1)"
        let v47 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v41, v45) v46 
        let v48 : string = "$0 * $1"
        let v49 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v39, v47) v48 
        let v50 : string = "num_complex::Complex::new($0, $1)"
        let v51 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v50 
        let v52 : string = "$0 * $1"
        let v53 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v51, v2) v52 
        let v54 : string = "num_complex::Complex::new($0, $1)"
        let v55 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v54 
        let v56 : string = "$0 / $1"
        let v57 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v53, v55) v56 
        let v58 : string = "$0.sin()"
        let v59 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v57 v58 
        let v60 : string = "$0 * $1"
        let v61 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v49, v59) v60 
        let v62 : string = "num_complex::Complex::new($0, $1)"
        let v63 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v62 
        let v64 : string = "$0 - $1"
        let v65 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v63, v2) v64 
        let v66 : string = $"        s = mpmath.gamma(s)"
        let v67 : num_complex_Complex<float> = method3(v65)
        let v68 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v66, v67)
        let v69 : string = "$0.ok()"
        let v70 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v68 v69 
        let v71 : (num_complex_Complex<float> -> US0) = method17()
        let v72 : US0 option = v70 |> Option.map v71 
        let v83 : US0 = US0_1
        let v84 : US0 = v72 |> Option.defaultValue v83 
        let v88 : string = "f64::NAN"
        let v89 : float = Fable.Core.RustInterop.emitRustExpr () v88 
        let v90 : string = "f64::NAN"
        let v91 : float = Fable.Core.RustInterop.emitRustExpr () v90 
        let v92 : string = "num_complex::Complex::new($0, $1)"
        let v93 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v89, v91) v92 
        let v96 : num_complex_Complex<float> =
            match v84 with
            | US0_1 -> (* None *)
                v93
            | US0_0(v94) -> (* Some *)
                v94
        let v97 : string = "$0 * $1"
        let v98 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v61, v96) v97 
        let v99 : string = "$0.re"
        let v100 : float = Fable.Core.RustInterop.emitRustExpr v2 v99 
        let v101 : float = 1.0 - v100
        let v102 : string = "$0.im"
        let v103 : float = Fable.Core.RustInterop.emitRustExpr v2 v102 
        let v104 : float =  -v103
        let v105 : string = "num_complex::Complex::new($0, $1)"
        let v106 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v101, v104) v105 
        let v107 : string = $"        s = mpmath.zeta(s)"
        let v108 : num_complex_Complex<float> = method3(v106)
        let v109 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v107, v108)
        let v110 : num_complex_Complex<float> = method13(v0, v106)
        let v111 : string = "$0.ok()"
        let v112 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v109 v111 
        let v113 : (num_complex_Complex<float> -> US0) = method17()
        let v114 : US0 option = v112 |> Option.map v113 
        let v125 : US0 = US0_1
        let v126 : US0 = v114 |> Option.defaultValue v125 
        let v130 : string = "f64::NAN"
        let v131 : float = Fable.Core.RustInterop.emitRustExpr () v130 
        let v132 : string = "f64::NAN"
        let v133 : float = Fable.Core.RustInterop.emitRustExpr () v132 
        let v134 : string = "num_complex::Complex::new($0, $1)"
        let v135 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v131, v133) v134 
        let v138 : num_complex_Complex<float> =
            match v126 with
            | US0_1 -> (* None *)
                v135
            | US0_0(v136) -> (* Some *)
                v136
        let v139 : string = "$0 * $1"
        let v140 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v98, v138) v139 
        let v141 : string = "$0.re"
        let v142 : float = Fable.Core.RustInterop.emitRustExpr v35 v141 
        let v143 : string = "$0.re"
        let v144 : float = Fable.Core.RustInterop.emitRustExpr v140 v143 
        let v145 : float = v142 - v144
        let v146 : float =  -v145
        let v147 : bool = v145 >= v146
        let v148 : float =
            if v147 then
                v145
            else
                v146
        let v149 : bool = v148 < 0.0001
        let v151 : bool =
            if v149 then
                true
            else
                method18(v149)
        let v152 : string = "__assert_lt"
        let v153 : string = $"{v152} / actual: %A{v148} / expected: %A{0.0001}"
        let v156 : unit = ()
        let v157 : (unit -> unit) = closure2(v153)
        let v158 : unit = (fun () -> v157 (); v156) ()
        let v160 : bool = v151 = false
        if v160 then
            failwith<unit> v153
        let v161 : string = "$0.im"
        let v162 : float = Fable.Core.RustInterop.emitRustExpr v35 v161 
        let v163 : string = "$0.im"
        let v164 : float = Fable.Core.RustInterop.emitRustExpr v140 v163 
        let v165 : float = v162 - v164
        let v166 : float =  -v165
        let v167 : bool = v165 >= v166
        let v168 : float =
            if v167 then
                v165
            else
                v166
        let v169 : bool = v168 < 0.0001
        let v171 : bool =
            if v169 then
                true
            else
                method18(v169)
        let v172 : string = $"{v152} / actual: %A{v168} / expected: %A{0.0001}"
        let v175 : unit = ()
        let v176 : (unit -> unit) = closure2(v172)
        let v177 : unit = (fun () -> v176 (); v175) ()
        let v179 : bool = v171 = false
        if v179 then
            failwith<unit> v172
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
    let v12 : string = "true; v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "__run_test"
    let v15 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v15 v16 
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
        let v13 : string = "$0.ok()"
        let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v11 v13 
        let v15 : (num_complex_Complex<float> -> US0) = method17()
        let v16 : US0 option = v14 |> Option.map v15 
        let v27 : US0 = US0_1
        let v28 : US0 = v16 |> Option.defaultValue v27 
        let v32 : string = "f64::NAN"
        let v33 : float = Fable.Core.RustInterop.emitRustExpr () v32 
        let v34 : string = "f64::NAN"
        let v35 : float = Fable.Core.RustInterop.emitRustExpr () v34 
        let v36 : string = "num_complex::Complex::new($0, $1)"
        let v37 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v33, v35) v36 
        let v40 : num_complex_Complex<float> =
            match v28 with
            | US0_1 -> (* None *)
                v37
            | US0_0(v38) -> (* Some *)
                v38
        let v41 : string = "$0.re"
        let v42 : float = Fable.Core.RustInterop.emitRustExpr v40 v41 
        let v43 : float = v42 - v8
        let v44 : float =  -v43
        let v45 : bool = v43 >= v44
        let v46 : float =
            if v45 then
                v43
            else
                v44
        let v47 : bool = v46 < 0.01
        let v49 : bool =
            if v47 then
                true
            else
                method18(v47)
        let v50 : string = "__assert_lt"
        let v51 : string = $"{v50} / actual: %A{v46} / expected: %A{0.01}"
        let v54 : unit = ()
        let v55 : (unit -> unit) = closure2(v51)
        let v56 : unit = (fun () -> v55 (); v54) ()
        let v58 : bool = v49 = false
        if v58 then
            failwith<unit> v51
        let v59 : string = "$0.im"
        let v60 : float = Fable.Core.RustInterop.emitRustExpr v40 v59 
        let v61 : bool = v60 < 0.01
        let v63 : bool =
            if v61 then
                true
            else
                method18(v61)
        let v64 : string = $"{v50} / actual: %A{v60} / expected: %A{0.01}"
        let v67 : unit = ()
        let v68 : (unit -> unit) = closure2(v64)
        let v69 : unit = (fun () -> v68 (); v67) ()
        let v71 : bool = v63 = false
        if v71 then
            failwith<unit> v64
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
