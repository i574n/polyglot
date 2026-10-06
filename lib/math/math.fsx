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
and method5 (v0 : int32, v1 : Mut1) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method6 (v0 : string) : string =
    v0
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
and method4 (v0 : pyo3_Python, v1 : num_complex_Complex<float>) : Result<num_complex_Complex<float>, std_string_String> =
    let v2 : string = "import sys"
    let v3 : string = "import traceback"
    let v4 : string = "import re"
    let v5 : string = "count = 0"
    let v6 : string = "memory_address_pattern = re.compile(r' at 0x[0-9a-fA-F]+')"
    let v7 : string = "def trace_calls(frame, event, arg):"
    let v8 : string = "    global count"
    let v9 : string = "    count += 1"
    let v10 : string = "    if count < 200:"
    let v11 : string = "        try:"
    let v12 : string = "            args = { k: v for k, v in frame.f_locals.items() if frame.f_code.co_name != 'make_mpc' and k not in ['ctx'] and not callable(v) }"
    let v13 : string = "            args_str = ', '.join([ f\"{k}={re.sub(memory_address_pattern, ' at 0x<?>', repr(v))}\" for k, v in args.items() ])"
    let v14 : string = "            print(f\"{event}(__NAME__) / f_code.co_name: {frame.f_code.co_name} / f_locals: {args_str} / f_lineno: {frame.f_lineno} / f_code.co_filename: {frame.f_code.co_filename.split('site-packages')[-1]} / f_back.f_lineno: { '' if frame.f_back is None else frame.f_back.f_lineno } / f_back.f_code.co_filename: { '' if frame.f_back is None else frame.f_back.f_code.co_filename.split('site-packages')[-1] } / arg: {re.sub(memory_address_pattern, ' at 0x<?>', repr(arg))}\", flush=True)"
    let v15 : string = "        except ValueError as e:"
    let v16 : string = "            print(f'__NAME__ / e: {e}', flush=True)"
    let v17 : string = "        return trace_calls"
    let v18 : string = "import mpmath"
    let v19 : string = "def fn(log, s):"
    let v20 : string = "    if log:"
    let v21 : string = "        print(f'__NAME__ / s: {s} / count: {count}', flush=True)"
    let v22 : string = "    s = complex(*s)"
    let v23 : string = "    try:"
    let v24 : string = "        if log: sys.settrace(trace_calls)"
    let v25 : string = "        s = mpmath.zeta(s)"
    let v26 : string = "        if log:"
    let v27 : string = "            sys.settrace(None)"
    let v28 : string = "            print(f'__NAME__ / result: {s} / count: {count}', flush=True)"
    let v29 : string = "    except ValueError as e:"
    let v30 : string = "        if s.real == 1:"
    let v31 : string = "            s = complex(float('inf'), 0)"
    let v32 : string = "    return (s.real, s.imag)"
    let v33 : (string []) = [|v2; v3; v4; v5; v6; v7; v8; v9; v10; v11; v12; v13; v14; v15; v16; v17; v18; v19; v8; v20; v21; v22; v23; v24; v25; v26; v27; v28; v29; v30; v31; v32|]
    let v34 : int32 = v33.Length
    let v35 : string = ""
    let v36 : Mut1 = {l0 = 0; l1 = v35; l2 = v35} : Mut1
    while method5(v34, v36) do
        let v38 : int32 = v36.l0
        let v39 : int32 =  -v38
        let v40 : int32 = v39 + v34
        let v41 : int32 = v40 - 1
        let struct (v42 : string, v43 : string) = v36.l1, v36.l2
        let v44 : string = v33.[int v41]
        let v47 : string = v44 + v43 
        let v67 : string = v47 + v42 
        let v68 : int32 = v38 + 1
        let v69 : string = "\n"
        v36.l0 <- v68
        v36.l1 <- v67
        v36.l2 <- v69
        ()
    let struct (v70 : string, v71 : string) = v36.l1, v36.l2
    let v78 : string = "__NAME__"
    let v79 : string = "zeta_"
    let v80 : string = v70.Replace (v78, v79)
    let v98 : string = method6(v80)
    let v99 : string = "$0.re"
    let v100 : float = Fable.Core.RustInterop.emitRustExpr v1 v99 
    let v101 : string = "$0.im"
    let v102 : float = Fable.Core.RustInterop.emitRustExpr v1 v101 
    let v105 : (float * float) = v100, v102 
    let v139 : (bool * (float * float)) = false, v105 
    let v171 : pyo3_Python = method7(v0)
    (* run_target_args'
    let v444 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v445 : string = "&*$0"
    let v446 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v98 v445 
    let _run_target_args'_v444 = v446 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v447 : string = "&*$0"
    let v448 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v98 v447 
    let _run_target_args'_v444 = v448 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v449 : string = "&*$0"
    let v450 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v98 v449 
    let _run_target_args'_v444 = v450 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v451 : Ref<Str> = v98 |> unbox<Ref<Str>>
    let _run_target_args'_v444 = v451 
    #endif
#else
    let v452 : Ref<Str> = v98 |> unbox<Ref<Str>>
    let _run_target_args'_v444 = v452 
    #endif
    let v453 : Ref<Str> = _run_target_args'_v444 
    (* run_target_args'
    let v611 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v612 : string = "String::from($0)"
    let v613 : std_string_String = Fable.Core.RustInterop.emitRustExpr v453 v612 
    let _run_target_args'_v611 = v613 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v614 : string = "String::from($0)"
    let v615 : std_string_String = Fable.Core.RustInterop.emitRustExpr v453 v614 
    let _run_target_args'_v611 = v615 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v616 : string = "String::from($0)"
    let v617 : std_string_String = Fable.Core.RustInterop.emitRustExpr v453 v616 
    let _run_target_args'_v611 = v617 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v618 : std_string_String = v453 |> unbox<std_string_String>
    let _run_target_args'_v611 = v618 
    #endif
#else
    let v619 : std_string_String = v453 |> unbox<std_string_String>
    let _run_target_args'_v611 = v619 
    #endif
    let v620 : std_string_String = _run_target_args'_v611 
    let v629 : string = "std::ffi::CString::new($0).unwrap()"
    let v630 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v620 v629 
    (* run_target_args'
    let v631 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v632 : string = "&*$0"
    let v633 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v35 v632 
    let _run_target_args'_v631 = v633 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v634 : string = "&*$0"
    let v635 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v35 v634 
    let _run_target_args'_v631 = v635 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v636 : string = "&*$0"
    let v637 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v35 v636 
    let _run_target_args'_v631 = v637 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v638 : Ref<Str> = v35 |> unbox<Ref<Str>>
    let _run_target_args'_v631 = v638 
    #endif
#else
    let v639 : Ref<Str> = v35 |> unbox<Ref<Str>>
    let _run_target_args'_v631 = v639 
    #endif
    let v640 : Ref<Str> = _run_target_args'_v631 
    (* run_target_args'
    let v641 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v642 : string = "String::from($0)"
    let v643 : std_string_String = Fable.Core.RustInterop.emitRustExpr v640 v642 
    let _run_target_args'_v641 = v643 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v644 : string = "String::from($0)"
    let v645 : std_string_String = Fable.Core.RustInterop.emitRustExpr v640 v644 
    let _run_target_args'_v641 = v645 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v646 : string = "String::from($0)"
    let v647 : std_string_String = Fable.Core.RustInterop.emitRustExpr v640 v646 
    let _run_target_args'_v641 = v647 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v648 : std_string_String = v640 |> unbox<std_string_String>
    let _run_target_args'_v641 = v648 
    #endif
#else
    let v649 : std_string_String = v640 |> unbox<std_string_String>
    let _run_target_args'_v641 = v649 
    #endif
    let v650 : std_string_String = _run_target_args'_v641 
    let v651 : string = "std::ffi::CString::new($0).unwrap()"
    let v652 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v650 v651 
    let v653 : string = "pyo3::types::PyModule::from_code(v171, &$0, &v652, &v652)"
    let v654 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v630 v653 
    let v655 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
    let v657 : string = "x"
    let v658 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v657 
    (* run_target_args'
    let v681 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v682 : string = "format!(\"{}\", $0)"
    let v683 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v682 
    let _run_target_args'_v681 = v683 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v684 : string = "format!(\"{}\", $0)"
    let v685 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v684 
    let _run_target_args'_v681 = v685 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v686 : string = "format!(\"{}\", $0)"
    let v687 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v686 
    let _run_target_args'_v681 = v687 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v688 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v681 = v688 
    #endif
#else
    let v689 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v681 = v689 
    #endif
    let v690 : std_string_String = _run_target_args'_v681 
    let v699 : string = "true; $0 })"
    let v700 : bool = Fable.Core.RustInterop.emitRustExpr v690 v699 
    let v701 : string = "_result_map_error__"
    let v702 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v701 
    let v703 : string = "$0.unwrap()"
    let v704 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v702 v703 
    let v705 : string = method8()
    (* run_target_args'
    let v706 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v707 : string = "&*$0"
    let v708 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v705 v707 
    let _run_target_args'_v706 = v708 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v709 : string = "&*$0"
    let v710 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v705 v709 
    let _run_target_args'_v706 = v710 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v711 : string = "&*$0"
    let v712 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v705 v711 
    let _run_target_args'_v706 = v712 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v713 : Ref<Str> = v705 |> unbox<Ref<Str>>
    let _run_target_args'_v706 = v713 
    #endif
#else
    let v714 : Ref<Str> = v705 |> unbox<Ref<Str>>
    let _run_target_args'_v706 = v714 
    #endif
    let v715 : Ref<Str> = _run_target_args'_v706 
    let v716 : pyo3_Bound<pyo3_types_PyModule> = method9(v704)
    let v721 : string = "v716.getattr($0)"
    let v722 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v715 v721 
    let v723 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v724 : bool = Fable.Core.RustInterop.emitRustExpr v722 v723 
    let v725 : string = "x"
    let v726 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v725 
    (* run_target_args'
    let v727 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v728 : string = "format!(\"{}\", $0)"
    let v729 : std_string_String = Fable.Core.RustInterop.emitRustExpr v726 v728 
    let _run_target_args'_v727 = v729 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v730 : string = "format!(\"{}\", $0)"
    let v731 : std_string_String = Fable.Core.RustInterop.emitRustExpr v726 v730 
    let _run_target_args'_v727 = v731 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v732 : string = "format!(\"{}\", $0)"
    let v733 : std_string_String = Fable.Core.RustInterop.emitRustExpr v726 v732 
    let _run_target_args'_v727 = v733 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v734 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v727 = v734 
    #endif
#else
    let v735 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v727 = v735 
    #endif
    let v736 : std_string_String = _run_target_args'_v727 
    let v737 : string = "true; $0 })"
    let v738 : bool = Fable.Core.RustInterop.emitRustExpr v736 v737 
    let v739 : string = "_result_map_error__"
    let v740 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v739 
    let v741 : string = "$0.unwrap()"
    let v742 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v740 v741 
    let v743 : (bool * (float * float)) = method10(v139)
    let v744 : pyo3_Bound<pyo3_PyAny> = method11(v742)
    let v765 : string = "pyo3::prelude::PyAnyMethods::call(&v744, ((*v743).0, *(*v743).1), None)"
    let v766 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v765 
    let v801 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v802 : bool = Fable.Core.RustInterop.emitRustExpr v766 v801 
    let v803 : string = "x"
    let v804 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v803 
    (* run_target_args'
    let v805 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v806 : string = "format!(\"{}\", $0)"
    let v807 : std_string_String = Fable.Core.RustInterop.emitRustExpr v804 v806 
    let _run_target_args'_v805 = v807 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v808 : string = "format!(\"{}\", $0)"
    let v809 : std_string_String = Fable.Core.RustInterop.emitRustExpr v804 v808 
    let _run_target_args'_v805 = v809 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v810 : string = "format!(\"{}\", $0)"
    let v811 : std_string_String = Fable.Core.RustInterop.emitRustExpr v804 v810 
    let _run_target_args'_v805 = v811 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v812 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v805 = v812 
    #endif
#else
    let v813 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v805 = v813 
    #endif
    let v814 : std_string_String = _run_target_args'_v805 
    let v815 : string = "true; $0 })"
    let v816 : bool = Fable.Core.RustInterop.emitRustExpr v814 v815 
    let v817 : string = "_result_map_error__"
    let v818 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v817 
    let v819 : string = "$0?"
    let v820 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v818 v819 
    let v821 : pyo3_Bound<pyo3_PyAny> = method12(v820)
    let v822 : string = "v821.extract()"
    let v823 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v822 
    let v824 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v825 : bool = Fable.Core.RustInterop.emitRustExpr v823 v824 
    let v826 : string = "x"
    let v827 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v826 
    (* run_target_args'
    let v828 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v829 : string = "format!(\"{}\", $0)"
    let v830 : std_string_String = Fable.Core.RustInterop.emitRustExpr v827 v829 
    let _run_target_args'_v828 = v830 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v831 : string = "format!(\"{}\", $0)"
    let v832 : std_string_String = Fable.Core.RustInterop.emitRustExpr v827 v831 
    let _run_target_args'_v828 = v832 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v833 : string = "format!(\"{}\", $0)"
    let v834 : std_string_String = Fable.Core.RustInterop.emitRustExpr v827 v833 
    let _run_target_args'_v828 = v834 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v835 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v828 = v835 
    #endif
#else
    let v836 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v828 = v836 
    #endif
    let v837 : std_string_String = _run_target_args'_v828 
    let v838 : string = "true; $0 })"
    let v839 : bool = Fable.Core.RustInterop.emitRustExpr v837 v838 
    let v840 : string = "_result_map_error__"
    let v841 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v840 
    let v842 : string = "$0?"
    let struct (v843 : float, v844 : float) = Fable.Core.RustInterop.emitRustExpr v841 v842 
    let v845 : string = "num_complex::Complex::new($0, $1)"
    let v846 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v843, v844) v845 
    let v849 : Result<num_complex_Complex<float>, std_string_String> = Ok v846 
    v849
and method14 (v0 : Mut0) : bool =
    let v1 : int32 = v0.l0
    let v2 : bool = v1 < 10000
    v2
and method15 (v0 : int32, v1 : Mut2) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method16 (v0 : pyo3_Python, v1 : num_complex_Complex<float>) : Result<num_complex_Complex<float>, std_string_String> =
    let v2 : string = "import sys"
    let v3 : string = "import traceback"
    let v4 : string = "import re"
    let v5 : string = "count = 0"
    let v6 : string = "memory_address_pattern = re.compile(r' at 0x[0-9a-fA-F]+')"
    let v7 : string = "def trace_calls(frame, event, arg):"
    let v8 : string = "    global count"
    let v9 : string = "    count += 1"
    let v10 : string = "    if count < 200:"
    let v11 : string = "        try:"
    let v12 : string = "            args = { k: v for k, v in frame.f_locals.items() if frame.f_code.co_name != 'make_mpc' and k not in ['ctx'] and not callable(v) }"
    let v13 : string = "            args_str = ', '.join([ f\"{k}={re.sub(memory_address_pattern, ' at 0x<?>', repr(v))}\" for k, v in args.items() ])"
    let v14 : string = "            print(f\"{event}(__NAME__) / f_code.co_name: {frame.f_code.co_name} / f_locals: {args_str} / f_lineno: {frame.f_lineno} / f_code.co_filename: {frame.f_code.co_filename.split('site-packages')[-1]} / f_back.f_lineno: { '' if frame.f_back is None else frame.f_back.f_lineno } / f_back.f_code.co_filename: { '' if frame.f_back is None else frame.f_back.f_code.co_filename.split('site-packages')[-1] } / arg: {re.sub(memory_address_pattern, ' at 0x<?>', repr(arg))}\", flush=True)"
    let v15 : string = "        except ValueError as e:"
    let v16 : string = "            print(f'__NAME__ / e: {e}', flush=True)"
    let v17 : string = "        return trace_calls"
    let v18 : string = "import mpmath"
    let v19 : string = "def fn(log, s):"
    let v20 : string = "    if log:"
    let v21 : string = "        print(f'__NAME__ / s: {s} / count: {count}', flush=True)"
    let v22 : string = "    s = complex(*s)"
    let v23 : string = "    try:"
    let v24 : string = "        if log: sys.settrace(trace_calls)"
    let v25 : string = "        s = mpmath.gamma(s)"
    let v26 : string = "        if log:"
    let v27 : string = "            sys.settrace(None)"
    let v28 : string = "            print(f'__NAME__ / result: {s} / count: {count}', flush=True)"
    let v29 : string = "    except ValueError as e:"
    let v30 : string = "        if s.real == 1:"
    let v31 : string = "            s = complex(float('inf'), 0)"
    let v32 : string = "    return (s.real, s.imag)"
    let v33 : (string []) = [|v2; v3; v4; v5; v6; v7; v8; v9; v10; v11; v12; v13; v14; v15; v16; v17; v18; v19; v8; v20; v21; v22; v23; v24; v25; v26; v27; v28; v29; v30; v31; v32|]
    let v34 : int32 = v33.Length
    let v35 : string = ""
    let v36 : Mut1 = {l0 = 0; l1 = v35; l2 = v35} : Mut1
    while method5(v34, v36) do
        let v38 : int32 = v36.l0
        let v39 : int32 =  -v38
        let v40 : int32 = v39 + v34
        let v41 : int32 = v40 - 1
        let struct (v42 : string, v43 : string) = v36.l1, v36.l2
        let v44 : string = v33.[int v41]
        let v45 : string = v44 + v43 
        let v46 : string = v45 + v42 
        let v47 : int32 = v38 + 1
        let v48 : string = "\n"
        v36.l0 <- v47
        v36.l1 <- v46
        v36.l2 <- v48
        ()
    let struct (v49 : string, v50 : string) = v36.l1, v36.l2
    let v57 : string = "__NAME__"
    let v58 : string = "gamma_"
    let v59 : string = v49.Replace (v57, v58)
    let v67 : string = method6(v59)
    let v68 : string = "$0.re"
    let v69 : float = Fable.Core.RustInterop.emitRustExpr v1 v68 
    let v70 : string = "$0.im"
    let v71 : float = Fable.Core.RustInterop.emitRustExpr v1 v70 
    let v72 : (float * float) = v69, v71 
    let v73 : (bool * (float * float)) = false, v72 
    let v74 : pyo3_Python = method7(v0)
    (* run_target_args'
    let v75 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v76 : string = "&*$0"
    let v77 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v67 v76 
    let _run_target_args'_v75 = v77 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v78 : string = "&*$0"
    let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v67 v78 
    let _run_target_args'_v75 = v79 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v80 : string = "&*$0"
    let v81 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v67 v80 
    let _run_target_args'_v75 = v81 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v82 : Ref<Str> = v67 |> unbox<Ref<Str>>
    let _run_target_args'_v75 = v82 
    #endif
#else
    let v83 : Ref<Str> = v67 |> unbox<Ref<Str>>
    let _run_target_args'_v75 = v83 
    #endif
    let v84 : Ref<Str> = _run_target_args'_v75 
    (* run_target_args'
    let v85 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v86 : string = "String::from($0)"
    let v87 : std_string_String = Fable.Core.RustInterop.emitRustExpr v84 v86 
    let _run_target_args'_v85 = v87 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v88 : string = "String::from($0)"
    let v89 : std_string_String = Fable.Core.RustInterop.emitRustExpr v84 v88 
    let _run_target_args'_v85 = v89 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v90 : string = "String::from($0)"
    let v91 : std_string_String = Fable.Core.RustInterop.emitRustExpr v84 v90 
    let _run_target_args'_v85 = v91 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v92 : std_string_String = v84 |> unbox<std_string_String>
    let _run_target_args'_v85 = v92 
    #endif
#else
    let v93 : std_string_String = v84 |> unbox<std_string_String>
    let _run_target_args'_v85 = v93 
    #endif
    let v94 : std_string_String = _run_target_args'_v85 
    let v95 : string = "std::ffi::CString::new($0).unwrap()"
    let v96 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v94 v95 
    (* run_target_args'
    let v97 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v98 : string = "&*$0"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v35 v98 
    let _run_target_args'_v97 = v99 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v100 : string = "&*$0"
    let v101 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v35 v100 
    let _run_target_args'_v97 = v101 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v102 : string = "&*$0"
    let v103 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v35 v102 
    let _run_target_args'_v97 = v103 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v104 : Ref<Str> = v35 |> unbox<Ref<Str>>
    let _run_target_args'_v97 = v104 
    #endif
#else
    let v105 : Ref<Str> = v35 |> unbox<Ref<Str>>
    let _run_target_args'_v97 = v105 
    #endif
    let v106 : Ref<Str> = _run_target_args'_v97 
    (* run_target_args'
    let v107 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v108 : string = "String::from($0)"
    let v109 : std_string_String = Fable.Core.RustInterop.emitRustExpr v106 v108 
    let _run_target_args'_v107 = v109 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v110 : string = "String::from($0)"
    let v111 : std_string_String = Fable.Core.RustInterop.emitRustExpr v106 v110 
    let _run_target_args'_v107 = v111 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v112 : string = "String::from($0)"
    let v113 : std_string_String = Fable.Core.RustInterop.emitRustExpr v106 v112 
    let _run_target_args'_v107 = v113 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v114 : std_string_String = v106 |> unbox<std_string_String>
    let _run_target_args'_v107 = v114 
    #endif
#else
    let v115 : std_string_String = v106 |> unbox<std_string_String>
    let _run_target_args'_v107 = v115 
    #endif
    let v116 : std_string_String = _run_target_args'_v107 
    let v117 : string = "std::ffi::CString::new($0).unwrap()"
    let v118 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v116 v117 
    let v119 : string = "pyo3::types::PyModule::from_code(v74, &$0, &v118, &v118)"
    let v120 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v96 v119 
    let v121 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v122 : bool = Fable.Core.RustInterop.emitRustExpr v120 v121 
    let v123 : string = "x"
    let v124 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v123 
    (* run_target_args'
    let v125 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v126 : string = "format!(\"{}\", $0)"
    let v127 : std_string_String = Fable.Core.RustInterop.emitRustExpr v124 v126 
    let _run_target_args'_v125 = v127 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v128 : string = "format!(\"{}\", $0)"
    let v129 : std_string_String = Fable.Core.RustInterop.emitRustExpr v124 v128 
    let _run_target_args'_v125 = v129 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v130 : string = "format!(\"{}\", $0)"
    let v131 : std_string_String = Fable.Core.RustInterop.emitRustExpr v124 v130 
    let _run_target_args'_v125 = v131 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v132 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v125 = v132 
    #endif
#else
    let v133 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v125 = v133 
    #endif
    let v134 : std_string_String = _run_target_args'_v125 
    let v135 : string = "true; $0 })"
    let v136 : bool = Fable.Core.RustInterop.emitRustExpr v134 v135 
    let v137 : string = "_result_map_error__"
    let v138 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v137 
    let v139 : string = "$0.unwrap()"
    let v140 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v138 v139 
    let v141 : string = method8()
    (* run_target_args'
    let v142 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v143 : string = "&*$0"
    let v144 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v141 v143 
    let _run_target_args'_v142 = v144 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v145 : string = "&*$0"
    let v146 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v141 v145 
    let _run_target_args'_v142 = v146 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v147 : string = "&*$0"
    let v148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v141 v147 
    let _run_target_args'_v142 = v148 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v149 : Ref<Str> = v141 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v149 
    #endif
#else
    let v150 : Ref<Str> = v141 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v150 
    #endif
    let v151 : Ref<Str> = _run_target_args'_v142 
    let v152 : pyo3_Bound<pyo3_types_PyModule> = method9(v140)
    let v153 : string = "v152.getattr($0)"
    let v154 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v151 v153 
    let v155 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v156 : bool = Fable.Core.RustInterop.emitRustExpr v154 v155 
    let v157 : string = "x"
    let v158 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v157 
    (* run_target_args'
    let v159 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v160 : string = "format!(\"{}\", $0)"
    let v161 : std_string_String = Fable.Core.RustInterop.emitRustExpr v158 v160 
    let _run_target_args'_v159 = v161 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v162 : string = "format!(\"{}\", $0)"
    let v163 : std_string_String = Fable.Core.RustInterop.emitRustExpr v158 v162 
    let _run_target_args'_v159 = v163 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v164 : string = "format!(\"{}\", $0)"
    let v165 : std_string_String = Fable.Core.RustInterop.emitRustExpr v158 v164 
    let _run_target_args'_v159 = v165 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v166 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v159 = v166 
    #endif
#else
    let v167 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v159 = v167 
    #endif
    let v168 : std_string_String = _run_target_args'_v159 
    let v169 : string = "true; $0 })"
    let v170 : bool = Fable.Core.RustInterop.emitRustExpr v168 v169 
    let v171 : string = "_result_map_error__"
    let v172 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v171 
    let v173 : string = "$0.unwrap()"
    let v174 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v172 v173 
    let v175 : (bool * (float * float)) = method10(v73)
    let v176 : pyo3_Bound<pyo3_PyAny> = method11(v174)
    let v177 : string = "pyo3::prelude::PyAnyMethods::call(&v176, ((*v175).0, *(*v175).1), None)"
    let v178 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v177 
    let v179 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v180 : bool = Fable.Core.RustInterop.emitRustExpr v178 v179 
    let v181 : string = "x"
    let v182 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v181 
    (* run_target_args'
    let v183 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v184 : string = "format!(\"{}\", $0)"
    let v185 : std_string_String = Fable.Core.RustInterop.emitRustExpr v182 v184 
    let _run_target_args'_v183 = v185 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v186 : string = "format!(\"{}\", $0)"
    let v187 : std_string_String = Fable.Core.RustInterop.emitRustExpr v182 v186 
    let _run_target_args'_v183 = v187 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v188 : string = "format!(\"{}\", $0)"
    let v189 : std_string_String = Fable.Core.RustInterop.emitRustExpr v182 v188 
    let _run_target_args'_v183 = v189 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v190 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v183 = v190 
    #endif
#else
    let v191 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v183 = v191 
    #endif
    let v192 : std_string_String = _run_target_args'_v183 
    let v193 : string = "true; $0 })"
    let v194 : bool = Fable.Core.RustInterop.emitRustExpr v192 v193 
    let v195 : string = "_result_map_error__"
    let v196 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v195 
    let v197 : string = "$0?"
    let v198 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v196 v197 
    let v199 : pyo3_Bound<pyo3_PyAny> = method12(v198)
    let v200 : string = "v199.extract()"
    let v201 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v200 
    let v202 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v203 : bool = Fable.Core.RustInterop.emitRustExpr v201 v202 
    let v204 : string = "x"
    let v205 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v204 
    (* run_target_args'
    let v206 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v207 : string = "format!(\"{}\", $0)"
    let v208 : std_string_String = Fable.Core.RustInterop.emitRustExpr v205 v207 
    let _run_target_args'_v206 = v208 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v209 : string = "format!(\"{}\", $0)"
    let v210 : std_string_String = Fable.Core.RustInterop.emitRustExpr v205 v209 
    let _run_target_args'_v206 = v210 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v211 : string = "format!(\"{}\", $0)"
    let v212 : std_string_String = Fable.Core.RustInterop.emitRustExpr v205 v211 
    let _run_target_args'_v206 = v212 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v213 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v206 = v213 
    #endif
#else
    let v214 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v206 = v214 
    #endif
    let v215 : std_string_String = _run_target_args'_v206 
    let v216 : string = "true; $0 })"
    let v217 : bool = Fable.Core.RustInterop.emitRustExpr v215 v216 
    let v218 : string = "_result_map_error__"
    let v219 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v218 
    let v220 : string = "$0?"
    let struct (v221 : float, v222 : float) = Fable.Core.RustInterop.emitRustExpr v219 v220 
    let v223 : string = "num_complex::Complex::new($0, $1)"
    let v224 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v221, v222) v223 
    let v225 : Result<num_complex_Complex<float>, std_string_String> = Ok v224 
    v225
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
            let v23 : (int32 -> float) = float
            let v24 : float = v23 v18
            let v54 : string = "num_complex::Complex::new($0, $1)"
            let v55 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v24, 0.0) v54 
            let v56 : string = "num_complex::Complex::powc($0, $1)"
            let v57 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v55, v1) v56 
            let v58 : string = "$0 / $1"
            let v59 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v20, v57) v58 
            let v60 : string = "$0 + $1"
            let v61 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v17, v59) v60 
            let v62 : int32 = v16 + 1
            v14.l0 <- v62
            v14.l1 <- v61
            ()
        let v63 : num_complex_Complex<float> = v14.l1
        v63
    else
        let v64 : string = "num_complex::Complex::new($0, $1)"
        let v65 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v64 
        let v66 : string = "$0 - $1"
        let v67 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v65, v1) v66 
        let v68 : num_complex_Complex<float> = method3(v67)
        let v69 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v68)
        (* run_target_args'
        let v72 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v73 : string = "$0.ok()"
        let v74 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v69 v73 
        let _run_target_args'_v72 = v74 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v75 : string = "$0.ok()"
        let v76 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v69 v75 
        let _run_target_args'_v72 = v76 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v77 : string = "$0.ok()"
        let v78 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v69 v77 
        let _run_target_args'_v72 = v78 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v79 : num_complex_Complex<float> option = match v69 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v72 = v79 
        #endif
#else
        let v80 : num_complex_Complex<float> option = match v69 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v72 = v80 
        #endif
        let v81 : num_complex_Complex<float> option = _run_target_args'_v72 
        let v148 : (num_complex_Complex<float> -> US0) = method17()
        let v149 : US0 option = v81 |> Option.map v148 
        let v177 : US0 = US0_1
        let v178 : US0 = v149 |> Option.defaultValue v177 
        let v201 : string = "f64::NAN"
        let v202 : float = Fable.Core.RustInterop.emitRustExpr () v201 
        let v203 : string = "f64::NAN"
        let v204 : float = Fable.Core.RustInterop.emitRustExpr () v203 
        let v205 : string = "num_complex::Complex::new($0, $1)"
        let v206 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v202, v204) v205 
        let v209 : num_complex_Complex<float> =
            match v178 with
            | US0_1 -> (* None *)
                v206
            | US0_0(v207) -> (* Some *)
                v207
        let v210 : string = "num_complex::Complex::new($0, $1)"
        let v211 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v210 
        let v212 : string = "$0 * $1"
        let v213 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v211, v1) v212 
        let v214 : string = "num_complex::Complex::new($0, $1)"
        let v215 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v214 
        let v216 : string = "$0 / $1"
        let v217 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v213, v215) v216 
        let v218 : string = "$0.sin()"
        let v219 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v217 v218 
        let v220 : string = "$0.re"
        let v221 : float = Fable.Core.RustInterop.emitRustExpr v1 v220 
        let v222 : float = 1.0 - v221
        let v223 : string = "$0.im"
        let v224 : float = Fable.Core.RustInterop.emitRustExpr v1 v223 
        let v225 : float =  -v224
        let v226 : string = "num_complex::Complex::new($0, $1)"
        let v227 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v222, v225) v226 
        let v228 : string = "$0.re"
        let v229 : float = Fable.Core.RustInterop.emitRustExpr v227 v228 
        let v230 : bool = v229 <= 1.0
        let v629 : num_complex_Complex<float> =
            if v230 then
                let v231 : string = "num_complex::Complex::new($0, $1)"
                let v232 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v231 
                v232
            else
                let v233 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                Fable.Core.RustInterop.emitRustExpr struct (1, v227) v233 
                let v234 : string = "$0.re"
                let v235 : float = Fable.Core.RustInterop.emitRustExpr v227 v234 
                let v236 : bool = v235 > 1.0
                if v236 then
                    let v237 : string = "num_complex::Complex::new($0, $1)"
                    let v238 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v237 
                    let v239 : (int32 []) = Array.zeroCreate<int32> (10000)
                    let v240 : Mut0 = {l0 = 0} : Mut0
                    while method14(v240) do
                        let v242 : int32 = v240.l0
                        v239.[int v242] <- v242
                        let v243 : int32 = v242 + 1
                        v240.l0 <- v243
                        ()
                    let v244 : int32 = v239.Length
                    let v245 : Mut2 = {l0 = 0; l1 = v238} : Mut2
                    while method15(v244, v245) do
                        let v247 : int32 = v245.l0
                        let v248 : num_complex_Complex<float> = v245.l1
                        let v249 : int32 = v239.[int v247]
                        let v250 : string = "num_complex::Complex::new($0, $1)"
                        let v251 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v250 
                        let v252 : (int32 -> float) = float
                        let v253 : float = v252 v249
                        let v254 : string = "num_complex::Complex::new($0, $1)"
                        let v255 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v253, 0.0) v254 
                        let v256 : string = "num_complex::Complex::powc($0, $1)"
                        let v257 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v255, v227) v256 
                        let v258 : string = "$0 / $1"
                        let v259 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v251, v257) v258 
                        let v260 : string = "$0 + $1"
                        let v261 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v248, v259) v260 
                        let v262 : int32 = v247 + 1
                        v245.l0 <- v262
                        v245.l1 <- v261
                        ()
                    let v263 : num_complex_Complex<float> = v245.l1
                    v263
                else
                    let v264 : string = "num_complex::Complex::new($0, $1)"
                    let v265 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v264 
                    let v266 : string = "$0 - $1"
                    let v267 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v265, v227) v266 
                    let v268 : num_complex_Complex<float> = method3(v267)
                    let v269 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v268)
                    (* run_target_args'
                    let v270 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v271 : string = "$0.ok()"
                    let v272 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v269 v271 
                    let _run_target_args'_v270 = v272 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v273 : string = "$0.ok()"
                    let v274 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v269 v273 
                    let _run_target_args'_v270 = v274 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v275 : string = "$0.ok()"
                    let v276 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v269 v275 
                    let _run_target_args'_v270 = v276 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v277 : num_complex_Complex<float> option = match v269 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v270 = v277 
                    #endif
#else
                    let v278 : num_complex_Complex<float> option = match v269 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v270 = v278 
                    #endif
                    let v279 : num_complex_Complex<float> option = _run_target_args'_v270 
                    let v280 : (num_complex_Complex<float> -> US0) = method17()
                    let v281 : US0 option = v279 |> Option.map v280 
                    let v282 : US0 = US0_1
                    let v283 : US0 = v281 |> Option.defaultValue v282 
                    let v284 : string = "f64::NAN"
                    let v285 : float = Fable.Core.RustInterop.emitRustExpr () v284 
                    let v286 : string = "f64::NAN"
                    let v287 : float = Fable.Core.RustInterop.emitRustExpr () v286 
                    let v288 : string = "num_complex::Complex::new($0, $1)"
                    let v289 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v285, v287) v288 
                    let v292 : num_complex_Complex<float> =
                        match v283 with
                        | US0_1 -> (* None *)
                            v289
                        | US0_0(v290) -> (* Some *)
                            v290
                    let v293 : string = "num_complex::Complex::new($0, $1)"
                    let v294 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v293 
                    let v295 : string = "$0 * $1"
                    let v296 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v294, v227) v295 
                    let v297 : string = "num_complex::Complex::new($0, $1)"
                    let v298 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v297 
                    let v299 : string = "$0 / $1"
                    let v300 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v296, v298) v299 
                    let v301 : string = "$0.sin()"
                    let v302 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v300 v301 
                    let v303 : string = "$0.re"
                    let v304 : float = Fable.Core.RustInterop.emitRustExpr v227 v303 
                    let v305 : float = 1.0 - v304
                    let v306 : string = "$0.im"
                    let v307 : float = Fable.Core.RustInterop.emitRustExpr v227 v306 
                    let v308 : float =  -v307
                    let v309 : string = "num_complex::Complex::new($0, $1)"
                    let v310 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v305, v308) v309 
                    let v311 : string = "$0.re"
                    let v312 : float = Fable.Core.RustInterop.emitRustExpr v310 v311 
                    let v313 : bool = v312 <= 1.0
                    let v613 : num_complex_Complex<float> =
                        if v313 then
                            let v314 : string = "num_complex::Complex::new($0, $1)"
                            let v315 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v314 
                            v315
                        else
                            let v316 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                            Fable.Core.RustInterop.emitRustExpr struct (2, v310) v316 
                            let v317 : string = "$0.re"
                            let v318 : float = Fable.Core.RustInterop.emitRustExpr v310 v317 
                            let v319 : bool = v318 > 1.0
                            if v319 then
                                let v320 : string = "num_complex::Complex::new($0, $1)"
                                let v321 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v320 
                                let v322 : (int32 []) = Array.zeroCreate<int32> (10000)
                                let v323 : Mut0 = {l0 = 0} : Mut0
                                while method14(v323) do
                                    let v325 : int32 = v323.l0
                                    v322.[int v325] <- v325
                                    let v326 : int32 = v325 + 1
                                    v323.l0 <- v326
                                    ()
                                let v327 : int32 = v322.Length
                                let v328 : Mut2 = {l0 = 0; l1 = v321} : Mut2
                                while method15(v327, v328) do
                                    let v330 : int32 = v328.l0
                                    let v331 : num_complex_Complex<float> = v328.l1
                                    let v332 : int32 = v322.[int v330]
                                    let v333 : string = "num_complex::Complex::new($0, $1)"
                                    let v334 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v333 
                                    let v335 : (int32 -> float) = float
                                    let v336 : float = v335 v332
                                    let v337 : string = "num_complex::Complex::new($0, $1)"
                                    let v338 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v336, 0.0) v337 
                                    let v339 : string = "num_complex::Complex::powc($0, $1)"
                                    let v340 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v338, v310) v339 
                                    let v341 : string = "$0 / $1"
                                    let v342 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v334, v340) v341 
                                    let v343 : string = "$0 + $1"
                                    let v344 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v331, v342) v343 
                                    let v345 : int32 = v330 + 1
                                    v328.l0 <- v345
                                    v328.l1 <- v344
                                    ()
                                let v346 : num_complex_Complex<float> = v328.l1
                                v346
                            else
                                let v347 : string = "num_complex::Complex::new($0, $1)"
                                let v348 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v347 
                                let v349 : string = "$0 - $1"
                                let v350 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v348, v310) v349 
                                let v351 : num_complex_Complex<float> = method3(v350)
                                let v352 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v351)
                                (* run_target_args'
                                let v353 : unit = ()
                                run_target_args' *)
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v354 : string = "$0.ok()"
                                let v355 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v352 v354 
                                let _run_target_args'_v353 = v355 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v356 : string = "$0.ok()"
                                let v357 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v352 v356 
                                let _run_target_args'_v353 = v357 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v358 : string = "$0.ok()"
                                let v359 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v352 v358 
                                let _run_target_args'_v353 = v359 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v360 : num_complex_Complex<float> option = match v352 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v353 = v360 
                                #endif
#else
                                let v361 : num_complex_Complex<float> option = match v352 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v353 = v361 
                                #endif
                                let v362 : num_complex_Complex<float> option = _run_target_args'_v353 
                                let v363 : (num_complex_Complex<float> -> US0) = method17()
                                let v364 : US0 option = v362 |> Option.map v363 
                                let v365 : US0 = US0_1
                                let v366 : US0 = v364 |> Option.defaultValue v365 
                                let v367 : string = "f64::NAN"
                                let v368 : float = Fable.Core.RustInterop.emitRustExpr () v367 
                                let v369 : string = "f64::NAN"
                                let v370 : float = Fable.Core.RustInterop.emitRustExpr () v369 
                                let v371 : string = "num_complex::Complex::new($0, $1)"
                                let v372 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v368, v370) v371 
                                let v375 : num_complex_Complex<float> =
                                    match v366 with
                                    | US0_1 -> (* None *)
                                        v372
                                    | US0_0(v373) -> (* Some *)
                                        v373
                                let v376 : string = "num_complex::Complex::new($0, $1)"
                                let v377 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v376 
                                let v378 : string = "$0 * $1"
                                let v379 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v377, v310) v378 
                                let v380 : string = "num_complex::Complex::new($0, $1)"
                                let v381 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v380 
                                let v382 : string = "$0 / $1"
                                let v383 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v379, v381) v382 
                                let v384 : string = "$0.sin()"
                                let v385 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v383 v384 
                                let v386 : string = "$0.re"
                                let v387 : float = Fable.Core.RustInterop.emitRustExpr v310 v386 
                                let v388 : float = 1.0 - v387
                                let v389 : string = "$0.im"
                                let v390 : float = Fable.Core.RustInterop.emitRustExpr v310 v389 
                                let v391 : float =  -v390
                                let v392 : string = "num_complex::Complex::new($0, $1)"
                                let v393 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v388, v391) v392 
                                let v394 : string = "$0.re"
                                let v395 : float = Fable.Core.RustInterop.emitRustExpr v393 v394 
                                let v396 : bool = v395 <= 1.0
                                let v597 : num_complex_Complex<float> =
                                    if v396 then
                                        let v397 : string = "num_complex::Complex::new($0, $1)"
                                        let v398 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v397 
                                        v398
                                    else
                                        let v399 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                        Fable.Core.RustInterop.emitRustExpr struct (3, v393) v399 
                                        let v400 : string = "$0.re"
                                        let v401 : float = Fable.Core.RustInterop.emitRustExpr v393 v400 
                                        let v402 : bool = v401 > 1.0
                                        if v402 then
                                            let v403 : string = "num_complex::Complex::new($0, $1)"
                                            let v404 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v403 
                                            let v405 : (int32 []) = Array.zeroCreate<int32> (10000)
                                            let v406 : Mut0 = {l0 = 0} : Mut0
                                            while method14(v406) do
                                                let v408 : int32 = v406.l0
                                                v405.[int v408] <- v408
                                                let v409 : int32 = v408 + 1
                                                v406.l0 <- v409
                                                ()
                                            let v410 : int32 = v405.Length
                                            let v411 : Mut2 = {l0 = 0; l1 = v404} : Mut2
                                            while method15(v410, v411) do
                                                let v413 : int32 = v411.l0
                                                let v414 : num_complex_Complex<float> = v411.l1
                                                let v415 : int32 = v405.[int v413]
                                                let v416 : string = "num_complex::Complex::new($0, $1)"
                                                let v417 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v416 
                                                let v418 : (int32 -> float) = float
                                                let v419 : float = v418 v415
                                                let v420 : string = "num_complex::Complex::new($0, $1)"
                                                let v421 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v419, 0.0) v420 
                                                let v422 : string = "num_complex::Complex::powc($0, $1)"
                                                let v423 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v421, v393) v422 
                                                let v424 : string = "$0 / $1"
                                                let v425 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v417, v423) v424 
                                                let v426 : string = "$0 + $1"
                                                let v427 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v414, v425) v426 
                                                let v428 : int32 = v413 + 1
                                                v411.l0 <- v428
                                                v411.l1 <- v427
                                                ()
                                            let v429 : num_complex_Complex<float> = v411.l1
                                            v429
                                        else
                                            let v430 : string = "num_complex::Complex::new($0, $1)"
                                            let v431 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v430 
                                            let v432 : string = "$0 - $1"
                                            let v433 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v431, v393) v432 
                                            let v434 : num_complex_Complex<float> = method3(v433)
                                            let v435 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v434)
                                            (* run_target_args'
                                            let v436 : unit = ()
                                            run_target_args' *)
                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                            let v437 : string = "$0.ok()"
                                            let v438 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v435 v437 
                                            let _run_target_args'_v436 = v438 
                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                            let v439 : string = "$0.ok()"
                                            let v440 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v435 v439 
                                            let _run_target_args'_v436 = v440 
                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                            let v441 : string = "$0.ok()"
                                            let v442 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v435 v441 
                                            let _run_target_args'_v436 = v442 
                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                            let v443 : num_complex_Complex<float> option = match v435 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v436 = v443 
                                            #endif
#else
                                            let v444 : num_complex_Complex<float> option = match v435 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v436 = v444 
                                            #endif
                                            let v445 : num_complex_Complex<float> option = _run_target_args'_v436 
                                            let v446 : (num_complex_Complex<float> -> US0) = method17()
                                            let v447 : US0 option = v445 |> Option.map v446 
                                            let v448 : US0 = US0_1
                                            let v449 : US0 = v447 |> Option.defaultValue v448 
                                            let v450 : string = "f64::NAN"
                                            let v451 : float = Fable.Core.RustInterop.emitRustExpr () v450 
                                            let v452 : string = "f64::NAN"
                                            let v453 : float = Fable.Core.RustInterop.emitRustExpr () v452 
                                            let v454 : string = "num_complex::Complex::new($0, $1)"
                                            let v455 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v451, v453) v454 
                                            let v458 : num_complex_Complex<float> =
                                                match v449 with
                                                | US0_1 -> (* None *)
                                                    v455
                                                | US0_0(v456) -> (* Some *)
                                                    v456
                                            let v459 : string = "num_complex::Complex::new($0, $1)"
                                            let v460 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v459 
                                            let v461 : string = "$0 * $1"
                                            let v462 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v460, v393) v461 
                                            let v463 : string = "num_complex::Complex::new($0, $1)"
                                            let v464 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v463 
                                            let v465 : string = "$0 / $1"
                                            let v466 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v462, v464) v465 
                                            let v467 : string = "$0.sin()"
                                            let v468 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v466 v467 
                                            let v469 : string = "$0.re"
                                            let v470 : float = Fable.Core.RustInterop.emitRustExpr v393 v469 
                                            let v471 : float = 1.0 - v470
                                            let v472 : string = "$0.im"
                                            let v473 : float = Fable.Core.RustInterop.emitRustExpr v393 v472 
                                            let v474 : float =  -v473
                                            let v475 : string = "num_complex::Complex::new($0, $1)"
                                            let v476 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v471, v474) v475 
                                            let v477 : string = "$0.re"
                                            let v478 : float = Fable.Core.RustInterop.emitRustExpr v476 v477 
                                            let v479 : bool = v478 <= 1.0
                                            let v581 : num_complex_Complex<float> =
                                                if v479 then
                                                    let v480 : string = "num_complex::Complex::new($0, $1)"
                                                    let v481 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v480 
                                                    v481
                                                else
                                                    let v482 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                                    Fable.Core.RustInterop.emitRustExpr struct (4, v476) v482 
                                                    let v483 : string = "$0.re"
                                                    let v484 : float = Fable.Core.RustInterop.emitRustExpr v476 v483 
                                                    let v485 : bool = v484 > 1.0
                                                    if v485 then
                                                        let v486 : string = "num_complex::Complex::new($0, $1)"
                                                        let v487 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v486 
                                                        let v488 : (int32 []) = Array.zeroCreate<int32> (10000)
                                                        let v489 : Mut0 = {l0 = 0} : Mut0
                                                        while method14(v489) do
                                                            let v491 : int32 = v489.l0
                                                            v488.[int v491] <- v491
                                                            let v492 : int32 = v491 + 1
                                                            v489.l0 <- v492
                                                            ()
                                                        let v493 : int32 = v488.Length
                                                        let v494 : Mut2 = {l0 = 0; l1 = v487} : Mut2
                                                        while method15(v493, v494) do
                                                            let v496 : int32 = v494.l0
                                                            let v497 : num_complex_Complex<float> = v494.l1
                                                            let v498 : int32 = v488.[int v496]
                                                            let v499 : string = "num_complex::Complex::new($0, $1)"
                                                            let v500 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v499 
                                                            let v501 : (int32 -> float) = float
                                                            let v502 : float = v501 v498
                                                            let v503 : string = "num_complex::Complex::new($0, $1)"
                                                            let v504 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v502, 0.0) v503 
                                                            let v505 : string = "num_complex::Complex::powc($0, $1)"
                                                            let v506 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v504, v476) v505 
                                                            let v507 : string = "$0 / $1"
                                                            let v508 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v500, v506) v507 
                                                            let v509 : string = "$0 + $1"
                                                            let v510 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v497, v508) v509 
                                                            let v511 : int32 = v496 + 1
                                                            v494.l0 <- v511
                                                            v494.l1 <- v510
                                                            ()
                                                        let v512 : num_complex_Complex<float> = v494.l1
                                                        v512
                                                    else
                                                        let v513 : string = "num_complex::Complex::new($0, $1)"
                                                        let v514 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v513 
                                                        let v515 : string = "$0 - $1"
                                                        let v516 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v514, v476) v515 
                                                        let v517 : num_complex_Complex<float> = method3(v516)
                                                        let v518 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v517)
                                                        (* run_target_args'
                                                        let v519 : unit = ()
                                                        run_target_args' *)
                                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                        let v520 : string = "$0.ok()"
                                                        let v521 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v518 v520 
                                                        let _run_target_args'_v519 = v521 
                                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                                        let v522 : string = "$0.ok()"
                                                        let v523 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v518 v522 
                                                        let _run_target_args'_v519 = v523 
                                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                        let v524 : string = "$0.ok()"
                                                        let v525 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v518 v524 
                                                        let _run_target_args'_v519 = v525 
                                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                        let v526 : num_complex_Complex<float> option = match v518 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v519 = v526 
                                                        #endif
#else
                                                        let v527 : num_complex_Complex<float> option = match v518 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v519 = v527 
                                                        #endif
                                                        let v528 : num_complex_Complex<float> option = _run_target_args'_v519 
                                                        let v529 : (num_complex_Complex<float> -> US0) = method17()
                                                        let v530 : US0 option = v528 |> Option.map v529 
                                                        let v531 : US0 = US0_1
                                                        let v532 : US0 = v530 |> Option.defaultValue v531 
                                                        let v533 : string = "f64::NAN"
                                                        let v534 : float = Fable.Core.RustInterop.emitRustExpr () v533 
                                                        let v535 : string = "f64::NAN"
                                                        let v536 : float = Fable.Core.RustInterop.emitRustExpr () v535 
                                                        let v537 : string = "num_complex::Complex::new($0, $1)"
                                                        let v538 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v534, v536) v537 
                                                        let v541 : num_complex_Complex<float> =
                                                            match v532 with
                                                            | US0_1 -> (* None *)
                                                                v538
                                                            | US0_0(v539) -> (* Some *)
                                                                v539
                                                        let v542 : string = "num_complex::Complex::new($0, $1)"
                                                        let v543 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v542 
                                                        let v544 : string = "$0 * $1"
                                                        let v545 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v543, v476) v544 
                                                        let v546 : string = "num_complex::Complex::new($0, $1)"
                                                        let v547 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v546 
                                                        let v548 : string = "$0 / $1"
                                                        let v549 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v545, v547) v548 
                                                        let v550 : string = "$0.sin()"
                                                        let v551 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v549 v550 
                                                        let v552 : string = "$0.re"
                                                        let v553 : float = Fable.Core.RustInterop.emitRustExpr v476 v552 
                                                        let v554 : float = 1.0 - v553
                                                        let v555 : string = "$0.im"
                                                        let v556 : float = Fable.Core.RustInterop.emitRustExpr v476 v555 
                                                        let v557 : float =  -v556
                                                        let v558 : string = "num_complex::Complex::new($0, $1)"
                                                        let v559 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v554, v557) v558 
                                                        let v560 : string = "$0.re"
                                                        let v561 : float = Fable.Core.RustInterop.emitRustExpr v559 v560 
                                                        let v562 : bool = v561 <= 1.0
                                                        let v565 : num_complex_Complex<float> =
                                                            if v562 then
                                                                let v563 : string = "num_complex::Complex::new($0, $1)"
                                                                let v564 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v563 
                                                                v564
                                                            else
                                                                v559
                                                        let v566 : string = "num_complex::Complex::new($0, $1)"
                                                        let v567 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v566 
                                                        let v568 : string = "num_complex::Complex::new($0, $1)"
                                                        let v569 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v568 
                                                        let v570 : string = "num_complex::Complex::powc($0, $1)"
                                                        let v571 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v569, v476) v570 
                                                        let v572 : string = "$0 * $1"
                                                        let v573 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v567, v571) v572 
                                                        let v574 : string = "$0 * $1"
                                                        let v575 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v573, v551) v574 
                                                        let v576 : string = "$0 * $1"
                                                        let v577 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v575, v541) v576 
                                                        let v578 : string = "$0 * $1"
                                                        let v579 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v577, v565) v578 
                                                        v579
                                            let v582 : string = "num_complex::Complex::new($0, $1)"
                                            let v583 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v582 
                                            let v584 : string = "num_complex::Complex::new($0, $1)"
                                            let v585 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v584 
                                            let v586 : string = "num_complex::Complex::powc($0, $1)"
                                            let v587 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v585, v393) v586 
                                            let v588 : string = "$0 * $1"
                                            let v589 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v583, v587) v588 
                                            let v590 : string = "$0 * $1"
                                            let v591 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v589, v468) v590 
                                            let v592 : string = "$0 * $1"
                                            let v593 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v591, v458) v592 
                                            let v594 : string = "$0 * $1"
                                            let v595 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v593, v581) v594 
                                            v595
                                let v598 : string = "num_complex::Complex::new($0, $1)"
                                let v599 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v598 
                                let v600 : string = "num_complex::Complex::new($0, $1)"
                                let v601 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v600 
                                let v602 : string = "num_complex::Complex::powc($0, $1)"
                                let v603 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v601, v310) v602 
                                let v604 : string = "$0 * $1"
                                let v605 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v599, v603) v604 
                                let v606 : string = "$0 * $1"
                                let v607 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v605, v385) v606 
                                let v608 : string = "$0 * $1"
                                let v609 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v607, v375) v608 
                                let v610 : string = "$0 * $1"
                                let v611 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v609, v597) v610 
                                v611
                    let v614 : string = "num_complex::Complex::new($0, $1)"
                    let v615 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v614 
                    let v616 : string = "num_complex::Complex::new($0, $1)"
                    let v617 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v616 
                    let v618 : string = "num_complex::Complex::powc($0, $1)"
                    let v619 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v617, v227) v618 
                    let v620 : string = "$0 * $1"
                    let v621 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v615, v619) v620 
                    let v622 : string = "$0 * $1"
                    let v623 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v621, v302) v622 
                    let v624 : string = "$0 * $1"
                    let v625 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v623, v292) v624 
                    let v626 : string = "$0 * $1"
                    let v627 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v625, v613) v626 
                    v627
        let v630 : string = "num_complex::Complex::new($0, $1)"
        let v631 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v630 
        let v632 : string = "num_complex::Complex::new($0, $1)"
        let v633 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v632 
        let v634 : string = "num_complex::Complex::powc($0, $1)"
        let v635 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v633, v1) v634 
        let v636 : string = "$0 * $1"
        let v637 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v631, v635) v636 
        let v638 : string = "$0 * $1"
        let v639 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v637, v219) v638 
        let v640 : string = "$0 * $1"
        let v641 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v639, v209) v640 
        let v642 : string = "$0 * $1"
        let v643 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v641, v629) v642 
        v643
and method18 (v0 : bool) : bool =
    v0
and method20 () : string =
    let v0 : string = ""
    v0
and method21 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "{ "
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method22 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "expected"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method23 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = " = "
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method24 (v0 : Mut3, v1 : string) : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method25 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = " }"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method19 (v0 : float) : string =
    let v1 : string = method20()
    let v6 : Mut3 = {l0 = v1} : Mut3
    method21(v6)
    method22(v6)
    method23(v6)
    let v166 : string = $"%+.6f{v0}"
    method24(v6, v166)
    method25(v6)
    let v256 : string = v6.l0
    v256
and method27 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "actual"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method28 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "; "
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method26 (v0 : float, v1 : float) : string =
    let v2 : string = method20()
    let v3 : Mut3 = {l0 = v2} : Mut3
    method21(v3)
    method27(v3)
    method23(v3)
    let v53 : string = $"%+.6f{v0}"
    method24(v3, v53)
    method28(v3)
    method22(v3)
    method23(v3)
    let v103 : string = $"%+.6f{v1}"
    method24(v3, v103)
    method25(v3)
    let v104 : string = v3.l0
    v104
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
        let v12 : num_complex_Complex<float> = method3(v10)
        let v13 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v12)
        let v14 : num_complex_Complex<float> = method13(v0, v10)
        (* run_target_args'
        let v15 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v16 : string = "$0.ok()"
        let v17 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v13 v16 
        let _run_target_args'_v15 = v17 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v18 : string = "$0.ok()"
        let v19 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v13 v18 
        let _run_target_args'_v15 = v19 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v20 : string = "$0.ok()"
        let v21 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v13 v20 
        let _run_target_args'_v15 = v21 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v22 : num_complex_Complex<float> option = match v13 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v15 = v22 
        #endif
#else
        let v23 : num_complex_Complex<float> option = match v13 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v15 = v23 
        #endif
        let v24 : num_complex_Complex<float> option = _run_target_args'_v15 
        let v25 : (num_complex_Complex<float> -> US0) = method17()
        let v26 : US0 option = v24 |> Option.map v25 
        let v27 : US0 = US0_1
        let v28 : US0 = v26 |> Option.defaultValue v27 
        let v29 : string = "f64::NAN"
        let v30 : float = Fable.Core.RustInterop.emitRustExpr () v29 
        let v31 : string = "f64::NAN"
        let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31 
        let v33 : string = "num_complex::Complex::new($0, $1)"
        let v34 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v30, v32) v33 
        let v37 : num_complex_Complex<float> =
            match v28 with
            | US0_1 -> (* None *)
                v34
            | US0_0(v35) -> (* Some *)
                v35
        let v38 : string = "$0.im"
        let v39 : float = Fable.Core.RustInterop.emitRustExpr v37 v38 
        let v40 : bool = v39 = 0.0
        let v42 : bool =
            if v40 then
                true
            else
                method18(v40)
        let v47 : string =
            if v40 then
                let v43 : float = 0.0
                method19(v43)
            else
                let v45 : float = 0.0
                method26(v39, v45)
        let v54 : string = "__assert_eq"
        let v55 : string = " "
        let v56 : string = v54 + v55 
        let v68 : string =
            if v40 then
                let v64 : float = 0.0
                method19(v64)
            else
                let v66 : float = 0.0
                method26(v39, v66)
        let v69 : string = v56 + v68 
        let v72 : unit = ()
        let v73 : (unit -> unit) = closure2(v69)
        let v74 : unit = (fun () -> v73 (); v72) ()
        let v82 : bool = v42 = false
        if v82 then
            failwith<unit> v69
        let v83 : string = "$0.re"
        let v84 : float = Fable.Core.RustInterop.emitRustExpr v37 v83 
        let v85 : float = v84 - v11
        let v86 : float =  -v85
        let v87 : bool = v85 >= v86
        let v88 : float =
            if v87 then
                v85
            else
                v86
        let v89 : bool = v88 < 0.0001
        let v91 : bool =
            if v89 then
                true
            else
                method18(v89)
        let v96 : string =
            if v89 then
                let v92 : float = 0.0001
                method19(v92)
            else
                let v94 : float = 0.0001
                method26(v88, v94)
        let v101 : string = "__assert_lt"
        let v102 : string = v101 + v55 
        let v114 : string =
            if v89 then
                let v110 : float = 0.0001
                method19(v110)
            else
                let v112 : float = 0.0001
                method26(v88, v112)
        let v115 : string = v102 + v114 
        let v116 : unit = ()
        let v117 : (unit -> unit) = closure2(v115)
        let v118 : unit = (fun () -> v117 (); v116) ()
        let v119 : bool = v91 = false
        if v119 then
            failwith<unit> v115
        let v120 : int32 = v9 + 1
        v7.l0 <- v120
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
    let v6 : Result<unit, pyo3_PyErr> = Ok () 
    let v53 : Result<unit, pyo3_PyErr> = method29(v6)
    let v97 : string = ""
    let v98 : string = "}"
    let v99 : string = v97 + v98 
    let v100 : string = v99 + v98 
    let v101 : string = "{"
    let v102 : string = v97 + v101 
    let x = v53 //
    let v103 : _ = x
    let v104 : unit = ()
    (* run_target_args'
    let v105 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v106 : string = $"true; let _fix_closure_v104 = $0"
    let v107 : bool = Fable.Core.RustInterop.emitRustExpr v103 v106 
    let _run_target_args'_v105 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v108 : string = $"true; let _fix_closure_v104 = $0"
    let v109 : bool = Fable.Core.RustInterop.emitRustExpr v103 v108 
    let _run_target_args'_v105 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v110 : string = $"true; let _fix_closure_v104 = $0"
    let v111 : bool = Fable.Core.RustInterop.emitRustExpr v103 v110 
    let _run_target_args'_v105 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v105 = false 
    #endif
#else
    let _run_target_args'_v105 = false 
    #endif
    let v112 : bool = _run_target_args'_v105 
    let v113 : string = $"true; _fix_closure_v104 " + v100 + "); " + v102 + " // rust.fix_closure'"
    let v114 : bool = Fable.Core.RustInterop.emitRustExpr () v113 
    let v144 : string = "__run_test"
    let v145 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v144 
    let v146 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v145 v146 
    ()
and method31 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, -2.0) v1 
    let v3 : num_complex_Complex<float> = method3(v2)
    let v4 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3)
    let v5 : num_complex_Complex<float> = method13(v0, v2)
    (* run_target_args'
    let v6 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = "$0.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v4 v7 
    let _run_target_args'_v6 = v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9 : string = "$0.ok()"
    let v10 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v4 v9 
    let _run_target_args'_v6 = v10 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v11 : string = "$0.ok()"
    let v12 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v4 v11 
    let _run_target_args'_v6 = v12 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : num_complex_Complex<float> option = match v4 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v6 = v13 
    #endif
#else
    let v14 : num_complex_Complex<float> option = match v4 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v6 = v14 
    #endif
    let v15 : num_complex_Complex<float> option = _run_target_args'_v6 
    let v16 : (num_complex_Complex<float> -> US0) = method17()
    let v17 : US0 option = v15 |> Option.map v16 
    let v18 : US0 = US0_1
    let v19 : US0 = v17 |> Option.defaultValue v18 
    let v20 : string = "f64::NAN"
    let v21 : float = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : string = "f64::NAN"
    let v23 : float = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : string = "num_complex::Complex::new($0, $1)"
    let v25 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v21, v23) v24 
    let v28 : num_complex_Complex<float> =
        match v19 with
        | US0_1 -> (* None *)
            v25
        | US0_0(v26) -> (* Some *)
            v26
    let v29 : string = "$0.re"
    let v30 : float = Fable.Core.RustInterop.emitRustExpr v28 v29 
    let v31 : float = v30 - 0.8673
    let v32 : float =  -v31
    let v33 : bool = v31 >= v32
    let v34 : float =
        if v33 then
            v31
        else
            v32
    let v35 : bool = v34 < 0.001
    let v37 : bool =
        if v35 then
            true
        else
            method18(v35)
    let v42 : string =
        if v35 then
            let v38 : float = 0.001
            method19(v38)
        else
            let v40 : float = 0.001
            method26(v34, v40)
    let v43 : string = "__assert_lt"
    let v44 : string = " "
    let v45 : string = v43 + v44 
    let v50 : string =
        if v35 then
            let v46 : float = 0.001
            method19(v46)
        else
            let v48 : float = 0.001
            method26(v34, v48)
    let v51 : string = v45 + v50 
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure2(v51)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v55 : bool = v37 = false
    if v55 then
        failwith<unit> v51
    let v56 : string = "$0.im"
    let v57 : float = Fable.Core.RustInterop.emitRustExpr v28 v56 
    let v58 : float = v57 - 0.275
    let v59 : float =  -v58
    let v60 : bool = v58 >= v59
    let v61 : float =
        if v60 then
            v58
        else
            v59
    let v62 : bool = v61 < 0.001
    let v64 : bool =
        if v62 then
            true
        else
            method18(v62)
    let v69 : string =
        if v62 then
            let v65 : float = 0.001
            method19(v65)
        else
            let v67 : float = 0.001
            method26(v61, v67)
    let v70 : string = v43 + v44 
    let v75 : string =
        if v62 then
            let v71 : float = 0.001
            method19(v71)
        else
            let v73 : float = 0.001
            method26(v61, v73)
    let v76 : string = v70 + v75 
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure2(v76)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v80 : bool = v64 = false
    if v80 then
        failwith<unit> v76
and method30 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method31(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
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
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v22 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : string = "__run_test"
    let v25 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v25 v26 
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
        let v6 : num_complex_Complex<float> = method3(v5)
        let v7 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v6)
        let v8 : num_complex_Complex<float> = method13(v0, v5)
        (* run_target_args'
        let v9 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v10 : string = "$0.ok()"
        let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v7 v10 
        let _run_target_args'_v9 = v11 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v12 : string = "$0.ok()"
        let v13 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v7 v12 
        let _run_target_args'_v9 = v13 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v14 : string = "$0.ok()"
        let v15 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v7 v14 
        let _run_target_args'_v9 = v15 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v16 : num_complex_Complex<float> option = match v7 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v9 = v16 
        #endif
#else
        let v17 : num_complex_Complex<float> option = match v7 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v9 = v17 
        #endif
        let v18 : num_complex_Complex<float> option = _run_target_args'_v9 
        let v19 : (num_complex_Complex<float> -> US0) = method17()
        let v20 : US0 option = v18 |> Option.map v19 
        let v21 : US0 = US0_1
        let v22 : US0 = v20 |> Option.defaultValue v21 
        let v23 : string = "f64::NAN"
        let v24 : float = Fable.Core.RustInterop.emitRustExpr () v23 
        let v25 : string = "f64::NAN"
        let v26 : float = Fable.Core.RustInterop.emitRustExpr () v25 
        let v27 : string = "num_complex::Complex::new($0, $1)"
        let v28 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v24, v26) v27 
        let v31 : num_complex_Complex<float> =
            match v22 with
            | US0_1 -> (* None *)
                v28
            | US0_0(v29) -> (* Some *)
                v29
        let v32 : string = "$0.re"
        let v33 : float = Fable.Core.RustInterop.emitRustExpr v31 v32 
        let v34 : bool = v33 = 0.0
        let v36 : bool =
            if v34 then
                true
            else
                method18(v34)
        let v41 : string =
            if v34 then
                let v37 : float = 0.0
                method19(v37)
            else
                let v39 : float = 0.0
                method26(v33, v39)
        let v42 : string = "__assert_eq"
        let v43 : string = " "
        let v44 : string = v42 + v43 
        let v49 : string =
            if v34 then
                let v45 : float = 0.0
                method19(v45)
            else
                let v47 : float = 0.0
                method26(v33, v47)
        let v50 : string = v44 + v49 
        let v51 : unit = ()
        let v52 : (unit -> unit) = closure2(v50)
        let v53 : unit = (fun () -> v52 (); v51) ()
        let v54 : bool = v36 = false
        if v54 then
            failwith<unit> v50
        let v55 : string = "$0.im"
        let v56 : float = Fable.Core.RustInterop.emitRustExpr v31 v55 
        let v57 : bool = v56 = 0.0
        let v59 : bool =
            if v57 then
                true
            else
                method18(v57)
        let v64 : string =
            if v57 then
                let v60 : float = 0.0
                method19(v60)
            else
                let v62 : float = 0.0
                method26(v56, v62)
        let v65 : string = v42 + v43 
        let v70 : string =
            if v57 then
                let v66 : float = 0.0
                method19(v66)
            else
                let v68 : float = 0.0
                method26(v56, v68)
        let v71 : string = v65 + v70 
        let v72 : unit = ()
        let v73 : (unit -> unit) = closure2(v71)
        let v74 : unit = (fun () -> v73 (); v72) ()
        let v75 : bool = v59 = false
        if v75 then
            failwith<unit> v71
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
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
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
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v22 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : string = "__run_test"
    let v25 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v25 v26 
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
        let v19 : num_complex_Complex<float> = method3(v18)
        let v20 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v19)
        let v21 : num_complex_Complex<float> = method13(v0, v18)
        (* run_target_args'
        let v22 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v23 : string = "$0.ok()"
        let v24 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v20 v23 
        let _run_target_args'_v22 = v24 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v25 : string = "$0.ok()"
        let v26 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v20 v25 
        let _run_target_args'_v22 = v26 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v27 : string = "$0.ok()"
        let v28 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v20 v27 
        let _run_target_args'_v22 = v28 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v29 : num_complex_Complex<float> option = match v20 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v22 = v29 
        #endif
#else
        let v30 : num_complex_Complex<float> option = match v20 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v22 = v30 
        #endif
        let v31 : num_complex_Complex<float> option = _run_target_args'_v22 
        let v32 : (num_complex_Complex<float> -> US0) = method17()
        let v33 : US0 option = v31 |> Option.map v32 
        let v34 : US0 = US0_1
        let v35 : US0 = v33 |> Option.defaultValue v34 
        let v36 : string = "f64::NAN"
        let v37 : float = Fable.Core.RustInterop.emitRustExpr () v36 
        let v38 : string = "f64::NAN"
        let v39 : float = Fable.Core.RustInterop.emitRustExpr () v38 
        let v40 : string = "num_complex::Complex::new($0, $1)"
        let v41 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v37, v39) v40 
        let v44 : num_complex_Complex<float> =
            match v35 with
            | US0_1 -> (* None *)
                v41
            | US0_0(v42) -> (* Some *)
                v42
        let v45 : string = "$0.re"
        let v46 : float = Fable.Core.RustInterop.emitRustExpr v44 v45 
        let v47 : float =  -v46
        let v48 : bool = v46 >= v47
        let v49 : float =
            if v48 then
                v46
            else
                v47
        let v50 : bool = v49 < 0.0001
        let v52 : bool =
            if v50 then
                true
            else
                method18(v50)
        let v57 : string =
            if v50 then
                let v53 : float = 0.0001
                method19(v53)
            else
                let v55 : float = 0.0001
                method26(v49, v55)
        let v58 : string = "__assert_lt"
        let v59 : string = " "
        let v60 : string = v58 + v59 
        let v65 : string =
            if v50 then
                let v61 : float = 0.0001
                method19(v61)
            else
                let v63 : float = 0.0001
                method26(v49, v63)
        let v66 : string = v60 + v65 
        let v67 : unit = ()
        let v68 : (unit -> unit) = closure2(v66)
        let v69 : unit = (fun () -> v68 (); v67) ()
        let v70 : bool = v52 = false
        if v70 then
            failwith<unit> v66
        let v71 : string = "$0.im"
        let v72 : float = Fable.Core.RustInterop.emitRustExpr v44 v71 
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
        let v83 : string =
            if v76 then
                let v79 : float = 0.0001
                method19(v79)
            else
                let v81 : float = 0.0001
                method26(v75, v81)
        let v84 : string = v58 + v59 
        let v89 : string =
            if v76 then
                let v85 : float = 0.0001
                method19(v85)
            else
                let v87 : float = 0.0001
                method26(v75, v87)
        let v90 : string = v84 + v89 
        let v91 : unit = ()
        let v92 : (unit -> unit) = closure2(v90)
        let v93 : unit = (fun () -> v92 (); v91) ()
        let v94 : bool = v78 = false
        if v94 then
            failwith<unit> v90
        let v95 : int32 = v17 + 1
        v15.l0 <- v95
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
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
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
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v22 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : string = "__run_test"
    let v25 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v25 v26 
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
        let v9 : num_complex_Complex<float> = method3(v8)
        let v10 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v9)
        let v11 : num_complex_Complex<float> = method13(v0, v8)
        (* run_target_args'
        let v12 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v13 : string = "$0.ok()"
        let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v10 v13 
        let _run_target_args'_v12 = v14 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v15 : string = "$0.ok()"
        let v16 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v10 v15 
        let _run_target_args'_v12 = v16 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v17 : string = "$0.ok()"
        let v18 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v10 v17 
        let _run_target_args'_v12 = v18 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v19 : num_complex_Complex<float> option = match v10 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v12 = v19 
        #endif
#else
        let v20 : num_complex_Complex<float> option = match v10 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v12 = v20 
        #endif
        let v21 : num_complex_Complex<float> option = _run_target_args'_v12 
        let v22 : (num_complex_Complex<float> -> US0) = method17()
        let v23 : US0 option = v21 |> Option.map v22 
        let v24 : US0 = US0_1
        let v25 : US0 = v23 |> Option.defaultValue v24 
        let v26 : string = "f64::NAN"
        let v27 : float = Fable.Core.RustInterop.emitRustExpr () v26 
        let v28 : string = "f64::NAN"
        let v29 : float = Fable.Core.RustInterop.emitRustExpr () v28 
        let v30 : string = "num_complex::Complex::new($0, $1)"
        let v31 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v27, v29) v30 
        let v34 : num_complex_Complex<float> =
            match v25 with
            | US0_1 -> (* None *)
                v31
            | US0_0(v32) -> (* Some *)
                v32
        let v35 : string = "$0.re"
        let v36 : float = Fable.Core.RustInterop.emitRustExpr v34 v35 
        let v37 : bool = v36 > 0.0
        let v39 : bool =
            if v37 then
                true
            else
                method18(v37)
        let v44 : string =
            if v37 then
                let v40 : float = 0.0
                method19(v40)
            else
                let v42 : float = 0.0
                method26(v36, v42)
        let v51 : string = "__assert_gt"
        let v52 : string = " "
        let v53 : string = v51 + v52 
        let v65 : string =
            if v37 then
                let v61 : float = 0.0
                method19(v61)
            else
                let v63 : float = 0.0
                method26(v36, v63)
        let v66 : string = v53 + v65 
        let v67 : unit = ()
        let v68 : (unit -> unit) = closure2(v66)
        let v69 : unit = (fun () -> v68 (); v67) ()
        let v70 : bool = v39 = false
        if v70 then
            failwith<unit> v66
        let v71 : string = "$0.im"
        let v72 : float = Fable.Core.RustInterop.emitRustExpr v34 v71 
        let v73 : bool = v72 = 0.0
        let v75 : bool =
            if v73 then
                true
            else
                method18(v73)
        let v80 : string =
            if v73 then
                let v76 : float = 0.0
                method19(v76)
            else
                let v78 : float = 0.0
                method26(v72, v78)
        let v81 : string = "__assert_eq"
        let v82 : string = v81 + v52 
        let v87 : string =
            if v73 then
                let v83 : float = 0.0
                method19(v83)
            else
                let v85 : float = 0.0
                method26(v72, v85)
        let v88 : string = v82 + v87 
        let v89 : unit = ()
        let v90 : (unit -> unit) = closure2(v88)
        let v91 : unit = (fun () -> v90 (); v89) ()
        let v92 : bool = v75 = false
        if v92 then
            failwith<unit> v88
        let v93 : int32 = v5 + 1
        v3.l0 <- v93
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
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
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
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v22 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : string = "__run_test"
    let v25 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v25 v26 
    ()
and method41 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v1 
    let v3 : num_complex_Complex<float> = method3(v2)
    let v4 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3)
    let v5 : num_complex_Complex<float> = method13(v0, v2)
    (* run_target_args'
    let v6 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = "$0.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v4 v7 
    let _run_target_args'_v6 = v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9 : string = "$0.ok()"
    let v10 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v4 v9 
    let _run_target_args'_v6 = v10 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v11 : string = "$0.ok()"
    let v12 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v4 v11 
    let _run_target_args'_v6 = v12 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : num_complex_Complex<float> option = match v4 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v6 = v13 
    #endif
#else
    let v14 : num_complex_Complex<float> option = match v4 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v6 = v14 
    #endif
    let v15 : num_complex_Complex<float> option = _run_target_args'_v6 
    let v16 : (num_complex_Complex<float> -> US0) = method17()
    let v17 : US0 option = v15 |> Option.map v16 
    let v18 : US0 = US0_1
    let v19 : US0 = v17 |> Option.defaultValue v18 
    let v20 : string = "f64::NAN"
    let v21 : float = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : string = "f64::NAN"
    let v23 : float = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : string = "num_complex::Complex::new($0, $1)"
    let v25 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v21, v23) v24 
    let v28 : num_complex_Complex<float> =
        match v19 with
        | US0_1 -> (* None *)
            v25
        | US0_0(v26) -> (* Some *)
            v26
    let v29 : string = "$0.re"
    let v30 : float = Fable.Core.RustInterop.emitRustExpr v28 v29 
    let v31 : bool = v30 = infinity
    let v33 : bool =
        if v31 then
            true
        else
            method18(v31)
    let v38 : string =
        if v31 then
            let v34 : float = infinity
            method19(v34)
        else
            let v36 : float = infinity
            method26(v30, v36)
    let v39 : string = "__assert_eq"
    let v40 : string = " "
    let v41 : string = v39 + v40 
    let v46 : string =
        if v31 then
            let v42 : float = infinity
            method19(v42)
        else
            let v44 : float = infinity
            method26(v30, v44)
    let v47 : string = v41 + v46 
    let v48 : unit = ()
    let v49 : (unit -> unit) = closure2(v47)
    let v50 : unit = (fun () -> v49 (); v48) ()
    let v51 : bool = v33 = false
    if v51 then
        failwith<unit> v47
    let v52 : string = "$0.im"
    let v53 : float = Fable.Core.RustInterop.emitRustExpr v28 v52 
    let v54 : bool = v53 = 0.0
    let v56 : bool =
        if v54 then
            true
        else
            method18(v54)
    let v61 : string =
        if v54 then
            let v57 : float = 0.0
            method19(v57)
        else
            let v59 : float = 0.0
            method26(v53, v59)
    let v62 : string = v39 + v40 
    let v67 : string =
        if v54 then
            let v63 : float = 0.0
            method19(v63)
        else
            let v65 : float = 0.0
            method26(v53, v65)
    let v68 : string = v62 + v67 
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure2(v68)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v72 : bool = v56 = false
    if v72 then
        failwith<unit> v68
and method40 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method41(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
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
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v22 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : string = "__run_test"
    let v25 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v25 v26 
    ()
and method43 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 10.0) v1 
    let v3 : num_complex_Complex<float> = method3(v2)
    let v4 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3)
    let v5 : num_complex_Complex<float> = method13(v0, v2)
    (* run_target_args'
    let v6 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = "$0.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v4 v7 
    let _run_target_args'_v6 = v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9 : string = "$0.ok()"
    let v10 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v4 v9 
    let _run_target_args'_v6 = v10 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v11 : string = "$0.ok()"
    let v12 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v4 v11 
    let _run_target_args'_v6 = v12 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : num_complex_Complex<float> option = match v4 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v6 = v13 
    #endif
#else
    let v14 : num_complex_Complex<float> option = match v4 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v6 = v14 
    #endif
    let v15 : num_complex_Complex<float> option = _run_target_args'_v6 
    let v16 : (num_complex_Complex<float> -> US0) = method17()
    let v17 : US0 option = v15 |> Option.map v16 
    let v18 : US0 = US0_1
    let v19 : US0 = v17 |> Option.defaultValue v18 
    let v20 : string = "f64::NAN"
    let v21 : float = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : string = "f64::NAN"
    let v23 : float = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : string = "num_complex::Complex::new($0, $1)"
    let v25 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v21, v23) v24 
    let v28 : num_complex_Complex<float> =
        match v19 with
        | US0_1 -> (* None *)
            v25
        | US0_0(v26) -> (* Some *)
            v26
    let v29 : string = "$0.re"
    let v30 : float = Fable.Core.RustInterop.emitRustExpr v2 v29 
    let v31 : string = "$0.im"
    let v32 : float = Fable.Core.RustInterop.emitRustExpr v2 v31 
    let v33 : float =  -v32
    let v34 : string = "num_complex::Complex::new($0, $1)"
    let v35 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v30, v33) v34 
    let v36 : num_complex_Complex<float> = method3(v35)
    let v37 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v36)
    let v38 : num_complex_Complex<float> = method13(v0, v35)
    (* run_target_args'
    let v39 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v40 : string = "$0.ok()"
    let v41 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v37 v40 
    let _run_target_args'_v39 = v41 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v42 : string = "$0.ok()"
    let v43 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v37 v42 
    let _run_target_args'_v39 = v43 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v44 : string = "$0.ok()"
    let v45 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v37 v44 
    let _run_target_args'_v39 = v45 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v46 : num_complex_Complex<float> option = match v37 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v39 = v46 
    #endif
#else
    let v47 : num_complex_Complex<float> option = match v37 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v39 = v47 
    #endif
    let v48 : num_complex_Complex<float> option = _run_target_args'_v39 
    let v49 : (num_complex_Complex<float> -> US0) = method17()
    let v50 : US0 option = v48 |> Option.map v49 
    let v51 : US0 = US0_1
    let v52 : US0 = v50 |> Option.defaultValue v51 
    let v53 : string = "f64::NAN"
    let v54 : float = Fable.Core.RustInterop.emitRustExpr () v53 
    let v55 : string = "f64::NAN"
    let v56 : float = Fable.Core.RustInterop.emitRustExpr () v55 
    let v57 : string = "num_complex::Complex::new($0, $1)"
    let v58 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v54, v56) v57 
    let v61 : num_complex_Complex<float> =
        match v52 with
        | US0_1 -> (* None *)
            v58
        | US0_0(v59) -> (* Some *)
            v59
    let v62 : string = "$0.conj()"
    let v63 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v61 v62 
    let v64 : string = "$0.re"
    let v65 : float = Fable.Core.RustInterop.emitRustExpr v28 v64 
    let v66 : string = "$0.re"
    let v67 : float = Fable.Core.RustInterop.emitRustExpr v63 v66 
    let v68 : bool = v65 = v67
    let v70 : bool =
        if v68 then
            true
        else
            method18(v68)
    let v73 : string =
        if v68 then
            method19(v67)
        else
            method26(v65, v67)
    let v74 : string = "__assert_eq"
    let v75 : string = " "
    let v76 : string = v74 + v75 
    let v79 : string =
        if v68 then
            method19(v67)
        else
            method26(v65, v67)
    let v80 : string = v76 + v79 
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure2(v80)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v84 : bool = v70 = false
    if v84 then
        failwith<unit> v80
    let v85 : string = "$0.im"
    let v86 : float = Fable.Core.RustInterop.emitRustExpr v28 v85 
    let v87 : string = "$0.im"
    let v88 : float = Fable.Core.RustInterop.emitRustExpr v63 v87 
    let v89 : bool = v86 = v88
    let v91 : bool =
        if v89 then
            true
        else
            method18(v89)
    let v94 : string =
        if v89 then
            method19(v88)
        else
            method26(v86, v88)
    let v95 : string = v74 + v75 
    let v98 : string =
        if v89 then
            method19(v88)
        else
            method26(v86, v88)
    let v99 : string = v95 + v98 
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure2(v99)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v103 : bool = v91 = false
    if v103 then
        failwith<unit> v99
and method42 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method43(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
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
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v22 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : string = "__run_test"
    let v25 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v25 v26 
    ()
and method45 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.01, 0.01) v1 
    let v3 : num_complex_Complex<float> = method3(v2)
    let v4 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3)
    let v5 : num_complex_Complex<float> = method13(v0, v2)
    (* run_target_args'
    let v6 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = "$0.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v4 v7 
    let _run_target_args'_v6 = v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9 : string = "$0.ok()"
    let v10 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v4 v9 
    let _run_target_args'_v6 = v10 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v11 : string = "$0.ok()"
    let v12 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v4 v11 
    let _run_target_args'_v6 = v12 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : num_complex_Complex<float> option = match v4 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v6 = v13 
    #endif
#else
    let v14 : num_complex_Complex<float> option = match v4 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v6 = v14 
    #endif
    let v15 : num_complex_Complex<float> option = _run_target_args'_v6 
    let v16 : (num_complex_Complex<float> -> US0) = method17()
    let v17 : US0 option = v15 |> Option.map v16 
    let v18 : US0 = US0_1
    let v19 : US0 = v17 |> Option.defaultValue v18 
    let v20 : string = "f64::NAN"
    let v21 : float = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : string = "f64::NAN"
    let v23 : float = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : string = "num_complex::Complex::new($0, $1)"
    let v25 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v21, v23) v24 
    let v28 : num_complex_Complex<float> =
        match v19 with
        | US0_1 -> (* None *)
            v25
        | US0_0(v26) -> (* Some *)
            v26
    let v29 : string = "$0.re"
    let v30 : float = Fable.Core.RustInterop.emitRustExpr v28 v29 
    let v31 : bool = v30 < infinity
    let v33 : bool =
        if v31 then
            true
        else
            method18(v31)
    let v38 : string =
        if v31 then
            let v34 : float = infinity
            method19(v34)
        else
            let v36 : float = infinity
            method26(v30, v36)
    let v39 : string = "__assert_lt"
    let v40 : string = " "
    let v41 : string = v39 + v40 
    let v46 : string =
        if v31 then
            let v42 : float = infinity
            method19(v42)
        else
            let v44 : float = infinity
            method26(v30, v44)
    let v47 : string = v41 + v46 
    let v48 : unit = ()
    let v49 : (unit -> unit) = closure2(v47)
    let v50 : unit = (fun () -> v49 (); v48) ()
    let v51 : bool = v33 = false
    if v51 then
        failwith<unit> v47
    let v52 : string = "$0.im"
    let v53 : float = Fable.Core.RustInterop.emitRustExpr v28 v52 
    let v54 : bool = v53 < infinity
    let v56 : bool =
        if v54 then
            true
        else
            method18(v54)
    let v61 : string =
        if v54 then
            let v57 : float = infinity
            method19(v57)
        else
            let v59 : float = infinity
            method26(v53, v59)
    let v62 : string = v39 + v40 
    let v67 : string =
        if v54 then
            let v63 : float = infinity
            method19(v63)
        else
            let v65 : float = infinity
            method26(v53, v65)
    let v68 : string = v62 + v67 
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure2(v68)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v72 : bool = v56 = false
    if v72 then
        failwith<unit> v68
and method44 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method45(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
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
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v22 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : string = "__run_test"
    let v25 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v25 v26 
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
        let v6 : num_complex_Complex<float> = method3(v5)
        let v7 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v6)
        let v8 : num_complex_Complex<float> = method13(v0, v5)
        (* run_target_args'
        let v9 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v10 : string = "$0.ok()"
        let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v7 v10 
        let _run_target_args'_v9 = v11 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v12 : string = "$0.ok()"
        let v13 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v7 v12 
        let _run_target_args'_v9 = v13 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v14 : string = "$0.ok()"
        let v15 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v7 v14 
        let _run_target_args'_v9 = v15 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v16 : num_complex_Complex<float> option = match v7 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v9 = v16 
        #endif
#else
        let v17 : num_complex_Complex<float> option = match v7 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v9 = v17 
        #endif
        let v18 : num_complex_Complex<float> option = _run_target_args'_v9 
        let v19 : (num_complex_Complex<float> -> US0) = method17()
        let v20 : US0 option = v18 |> Option.map v19 
        let v21 : US0 = US0_1
        let v22 : US0 = v20 |> Option.defaultValue v21 
        let v23 : string = "f64::NAN"
        let v24 : float = Fable.Core.RustInterop.emitRustExpr () v23 
        let v25 : string = "f64::NAN"
        let v26 : float = Fable.Core.RustInterop.emitRustExpr () v25 
        let v27 : string = "num_complex::Complex::new($0, $1)"
        let v28 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v24, v26) v27 
        let v31 : num_complex_Complex<float> =
            match v22 with
            | US0_1 -> (* None *)
                v28
            | US0_0(v29) -> (* Some *)
                v29
        let v32 : string = "$0.re"
        let v33 : float = Fable.Core.RustInterop.emitRustExpr v31 v32 
        let v36 : bool = v33 <> 0.0 
        let v45 : bool =
            if v36 then
                true
            else
                method18(v36)
        let v50 : string =
            if v36 then
                let v46 : float = 0.0
                method19(v46)
            else
                let v48 : float = 0.0
                method26(v33, v48)
        let v57 : string = "__assert_ne"
        let v58 : string = " "
        let v59 : string = v57 + v58 
        let v71 : string =
            if v36 then
                let v67 : float = 0.0
                method19(v67)
            else
                let v69 : float = 0.0
                method26(v33, v69)
        let v72 : string = v59 + v71 
        let v73 : unit = ()
        let v74 : (unit -> unit) = closure2(v72)
        let v75 : unit = (fun () -> v74 (); v73) ()
        let v76 : bool = v45 = false
        if v76 then
            failwith<unit> v72
        let v77 : string = "$0.im"
        let v78 : float = Fable.Core.RustInterop.emitRustExpr v31 v77 
        let v79 : bool = v78 <> 0.0 
        let v81 : bool =
            if v79 then
                true
            else
                method18(v79)
        let v86 : string =
            if v79 then
                let v82 : float = 0.0
                method19(v82)
            else
                let v84 : float = 0.0
                method26(v78, v84)
        let v87 : string = v57 + v58 
        let v92 : string =
            if v79 then
                let v88 : float = 0.0
                method19(v88)
            else
                let v90 : float = 0.0
                method26(v78, v90)
        let v93 : string = v87 + v92 
        let v94 : unit = ()
        let v95 : (unit -> unit) = closure2(v93)
        let v96 : unit = (fun () -> v95 (); v94) ()
        let v97 : bool = v81 = false
        if v97 then
            failwith<unit> v93
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
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
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
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v22 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : string = "__run_test"
    let v25 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v25 v26 
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
        let v4 : num_complex_Complex<float> = method3(v2)
        let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v4)
        let v6 : num_complex_Complex<float> = method13(v0, v2)
        (* run_target_args'
        let v7 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v8 : string = "$0.ok()"
        let v9 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v8 
        let _run_target_args'_v7 = v9 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v10 : string = "$0.ok()"
        let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v10 
        let _run_target_args'_v7 = v11 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v12 : string = "$0.ok()"
        let v13 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v12 
        let _run_target_args'_v7 = v13 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v14 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v7 = v14 
        #endif
#else
        let v15 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v7 = v15 
        #endif
        let v16 : num_complex_Complex<float> option = _run_target_args'_v7 
        let v17 : (num_complex_Complex<float> -> US0) = method17()
        let v18 : US0 option = v16 |> Option.map v17 
        let v19 : US0 = US0_1
        let v20 : US0 = v18 |> Option.defaultValue v19 
        let v21 : string = "f64::NAN"
        let v22 : float = Fable.Core.RustInterop.emitRustExpr () v21 
        let v23 : string = "f64::NAN"
        let v24 : float = Fable.Core.RustInterop.emitRustExpr () v23 
        let v25 : string = "num_complex::Complex::new($0, $1)"
        let v26 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v22, v24) v25 
        let v29 : num_complex_Complex<float> =
            match v20 with
            | US0_1 -> (* None *)
                v26
            | US0_0(v27) -> (* Some *)
                v27
        let v30 : string = "$0.re"
        let v31 : float = Fable.Core.RustInterop.emitRustExpr v29 v30 
        let v32 : bool = v31 <> 0.0 
        let v34 : bool =
            if v32 then
                true
            else
                method18(v32)
        let v39 : string =
            if v32 then
                let v35 : float = 0.0
                method19(v35)
            else
                let v37 : float = 0.0
                method26(v31, v37)
        let v40 : string = "__assert_ne"
        let v41 : string = " "
        let v42 : string = v40 + v41 
        let v47 : string =
            if v32 then
                let v43 : float = 0.0
                method19(v43)
            else
                let v45 : float = 0.0
                method26(v31, v45)
        let v48 : string = v42 + v47 
        let v49 : unit = ()
        let v50 : (unit -> unit) = closure2(v48)
        let v51 : unit = (fun () -> v50 (); v49) ()
        let v52 : bool = v34 = false
        if v52 then
            failwith<unit> v48
        let v53 : string = "$0.im"
        let v54 : float = Fable.Core.RustInterop.emitRustExpr v29 v53 
        let v55 : bool = v54 <> 0.0 
        let v57 : bool =
            if v55 then
                true
            else
                method18(v55)
        let v62 : string =
            if v55 then
                let v58 : float = 0.0
                method19(v58)
            else
                let v60 : float = 0.0
                method26(v54, v60)
        let v63 : string = v40 + v41 
        let v68 : string =
            if v55 then
                let v64 : float = 0.0
                method19(v64)
            else
                let v66 : float = 0.0
                method26(v54, v66)
        let v69 : string = v63 + v68 
        let v70 : unit = ()
        let v71 : (unit -> unit) = closure2(v69)
        let v72 : unit = (fun () -> v71 (); v70) ()
        let v73 : bool = v57 = false
        if v73 then
            failwith<unit> v69
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
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
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
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v22 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : string = "__run_test"
    let v25 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v25 v26 
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
        let v4 : num_complex_Complex<float> = method3(v2)
        let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v4)
        let v6 : num_complex_Complex<float> = method13(v0, v2)
        (* run_target_args'
        let v7 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v8 : string = "$0.ok()"
        let v9 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v8 
        let _run_target_args'_v7 = v9 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v10 : string = "$0.ok()"
        let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v10 
        let _run_target_args'_v7 = v11 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v12 : string = "$0.ok()"
        let v13 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v12 
        let _run_target_args'_v7 = v13 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v14 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v7 = v14 
        #endif
#else
        let v15 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v7 = v15 
        #endif
        let v16 : num_complex_Complex<float> option = _run_target_args'_v7 
        let v17 : (num_complex_Complex<float> -> US0) = method17()
        let v18 : US0 option = v16 |> Option.map v17 
        let v19 : US0 = US0_1
        let v20 : US0 = v18 |> Option.defaultValue v19 
        let v21 : string = "f64::NAN"
        let v22 : float = Fable.Core.RustInterop.emitRustExpr () v21 
        let v23 : string = "f64::NAN"
        let v24 : float = Fable.Core.RustInterop.emitRustExpr () v23 
        let v25 : string = "num_complex::Complex::new($0, $1)"
        let v26 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v22, v24) v25 
        let v29 : num_complex_Complex<float> =
            match v20 with
            | US0_1 -> (* None *)
                v26
            | US0_0(v27) -> (* Some *)
                v27
        let v30 : string = "num_complex::Complex::new($0, $1)"
        let v31 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v30 
        let v32 : string = "num_complex::Complex::powc($0, $1)"
        let v33 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v31, v2) v32 
        let v34 : string = "num_complex::Complex::new($0, $1)"
        let v35 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v34 
        let v36 : string = "num_complex::Complex::new($0, $1)"
        let v37 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v36 
        let v38 : string = "$0 - $1"
        let v39 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v2, v37) v38 
        let v40 : string = "num_complex::Complex::powc($0, $1)"
        let v41 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v35, v39) v40 
        let v42 : string = "$0 * $1"
        let v43 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v33, v41) v42 
        let v44 : string = "num_complex::Complex::new($0, $1)"
        let v45 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v44 
        let v46 : string = "$0 * $1"
        let v47 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v45, v2) v46 
        let v48 : string = "num_complex::Complex::new($0, $1)"
        let v49 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v48 
        let v50 : string = "$0 / $1"
        let v51 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v47, v49) v50 
        let v52 : string = "$0.sin()"
        let v53 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v51 v52 
        let v54 : string = "$0 * $1"
        let v55 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v43, v53) v54 
        let v56 : string = "num_complex::Complex::new($0, $1)"
        let v57 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v56 
        let v58 : string = "$0 - $1"
        let v59 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v57, v2) v58 
        let v60 : num_complex_Complex<float> = method3(v59)
        let v61 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v60)
        (* run_target_args'
        let v62 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v63 : string = "$0.ok()"
        let v64 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v61 v63 
        let _run_target_args'_v62 = v64 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v65 : string = "$0.ok()"
        let v66 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v61 v65 
        let _run_target_args'_v62 = v66 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v67 : string = "$0.ok()"
        let v68 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v61 v67 
        let _run_target_args'_v62 = v68 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v69 : num_complex_Complex<float> option = match v61 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v62 = v69 
        #endif
#else
        let v70 : num_complex_Complex<float> option = match v61 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v62 = v70 
        #endif
        let v71 : num_complex_Complex<float> option = _run_target_args'_v62 
        let v72 : (num_complex_Complex<float> -> US0) = method17()
        let v73 : US0 option = v71 |> Option.map v72 
        let v74 : US0 = US0_1
        let v75 : US0 = v73 |> Option.defaultValue v74 
        let v76 : string = "f64::NAN"
        let v77 : float = Fable.Core.RustInterop.emitRustExpr () v76 
        let v78 : string = "f64::NAN"
        let v79 : float = Fable.Core.RustInterop.emitRustExpr () v78 
        let v80 : string = "num_complex::Complex::new($0, $1)"
        let v81 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v77, v79) v80 
        let v84 : num_complex_Complex<float> =
            match v75 with
            | US0_1 -> (* None *)
                v81
            | US0_0(v82) -> (* Some *)
                v82
        let v85 : string = "$0 * $1"
        let v86 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v55, v84) v85 
        let v87 : string = "$0.re"
        let v88 : float = Fable.Core.RustInterop.emitRustExpr v2 v87 
        let v89 : float = 1.0 - v88
        let v90 : string = "$0.im"
        let v91 : float = Fable.Core.RustInterop.emitRustExpr v2 v90 
        let v92 : float =  -v91
        let v93 : string = "num_complex::Complex::new($0, $1)"
        let v94 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v89, v92) v93 
        let v95 : num_complex_Complex<float> = method3(v94)
        let v96 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v95)
        let v97 : num_complex_Complex<float> = method13(v0, v94)
        (* run_target_args'
        let v98 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v99 : string = "$0.ok()"
        let v100 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v96 v99 
        let _run_target_args'_v98 = v100 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v101 : string = "$0.ok()"
        let v102 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v96 v101 
        let _run_target_args'_v98 = v102 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v103 : string = "$0.ok()"
        let v104 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v96 v103 
        let _run_target_args'_v98 = v104 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v105 : num_complex_Complex<float> option = match v96 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v98 = v105 
        #endif
#else
        let v106 : num_complex_Complex<float> option = match v96 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v98 = v106 
        #endif
        let v107 : num_complex_Complex<float> option = _run_target_args'_v98 
        let v108 : (num_complex_Complex<float> -> US0) = method17()
        let v109 : US0 option = v107 |> Option.map v108 
        let v110 : US0 = US0_1
        let v111 : US0 = v109 |> Option.defaultValue v110 
        let v112 : string = "f64::NAN"
        let v113 : float = Fable.Core.RustInterop.emitRustExpr () v112 
        let v114 : string = "f64::NAN"
        let v115 : float = Fable.Core.RustInterop.emitRustExpr () v114 
        let v116 : string = "num_complex::Complex::new($0, $1)"
        let v117 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v113, v115) v116 
        let v120 : num_complex_Complex<float> =
            match v111 with
            | US0_1 -> (* None *)
                v117
            | US0_0(v118) -> (* Some *)
                v118
        let v121 : string = "$0 * $1"
        let v122 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v86, v120) v121 
        let v123 : string = "$0.re"
        let v124 : float = Fable.Core.RustInterop.emitRustExpr v29 v123 
        let v125 : string = "$0.re"
        let v126 : float = Fable.Core.RustInterop.emitRustExpr v122 v125 
        let v127 : float = v124 - v126
        let v128 : float =  -v127
        let v129 : bool = v127 >= v128
        let v130 : float =
            if v129 then
                v127
            else
                v128
        let v131 : bool = v130 < 0.0001
        let v133 : bool =
            if v131 then
                true
            else
                method18(v131)
        let v138 : string =
            if v131 then
                let v134 : float = 0.0001
                method19(v134)
            else
                let v136 : float = 0.0001
                method26(v130, v136)
        let v139 : string = "__assert_lt"
        let v140 : string = " "
        let v141 : string = v139 + v140 
        let v146 : string =
            if v131 then
                let v142 : float = 0.0001
                method19(v142)
            else
                let v144 : float = 0.0001
                method26(v130, v144)
        let v147 : string = v141 + v146 
        let v148 : unit = ()
        let v149 : (unit -> unit) = closure2(v147)
        let v150 : unit = (fun () -> v149 (); v148) ()
        let v151 : bool = v133 = false
        if v151 then
            failwith<unit> v147
        let v152 : string = "$0.im"
        let v153 : float = Fable.Core.RustInterop.emitRustExpr v29 v152 
        let v154 : string = "$0.im"
        let v155 : float = Fable.Core.RustInterop.emitRustExpr v122 v154 
        let v156 : float = v153 - v155
        let v157 : float =  -v156
        let v158 : bool = v156 >= v157
        let v159 : float =
            if v158 then
                v156
            else
                v157
        let v160 : bool = v159 < 0.0001
        let v162 : bool =
            if v160 then
                true
            else
                method18(v160)
        let v167 : string =
            if v160 then
                let v163 : float = 0.0001
                method19(v163)
            else
                let v165 : float = 0.0001
                method26(v159, v165)
        let v168 : string = v139 + v140 
        let v173 : string =
            if v160 then
                let v169 : float = 0.0001
                method19(v169)
            else
                let v171 : float = 0.0001
                method26(v159, v171)
        let v174 : string = v168 + v173 
        let v175 : unit = ()
        let v176 : (unit -> unit) = closure2(v174)
        let v177 : unit = (fun () -> v176 (); v175) ()
        let v178 : bool = v162 = false
        if v178 then
            failwith<unit> v174
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
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
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
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v22 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : string = "__run_test"
    let v25 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v25 v26 
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
        let v9 : num_complex_Complex<float> = method3(v6)
        let v10 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v9)
        let v11 : num_complex_Complex<float> = method13(v0, v6)
        (* run_target_args'
        let v12 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v13 : string = "$0.ok()"
        let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v10 v13 
        let _run_target_args'_v12 = v14 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v15 : string = "$0.ok()"
        let v16 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v10 v15 
        let _run_target_args'_v12 = v16 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v17 : string = "$0.ok()"
        let v18 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v10 v17 
        let _run_target_args'_v12 = v18 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v19 : num_complex_Complex<float> option = match v10 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v12 = v19 
        #endif
#else
        let v20 : num_complex_Complex<float> option = match v10 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v12 = v20 
        #endif
        let v21 : num_complex_Complex<float> option = _run_target_args'_v12 
        let v22 : (num_complex_Complex<float> -> US0) = method17()
        let v23 : US0 option = v21 |> Option.map v22 
        let v24 : US0 = US0_1
        let v25 : US0 = v23 |> Option.defaultValue v24 
        let v26 : string = "f64::NAN"
        let v27 : float = Fable.Core.RustInterop.emitRustExpr () v26 
        let v28 : string = "f64::NAN"
        let v29 : float = Fable.Core.RustInterop.emitRustExpr () v28 
        let v30 : string = "num_complex::Complex::new($0, $1)"
        let v31 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v27, v29) v30 
        let v34 : num_complex_Complex<float> =
            match v25 with
            | US0_1 -> (* None *)
                v31
            | US0_0(v32) -> (* Some *)
                v32
        let v35 : string = "$0.re"
        let v36 : float = Fable.Core.RustInterop.emitRustExpr v34 v35 
        let v37 : float = v36 - v8
        let v38 : float =  -v37
        let v39 : bool = v37 >= v38
        let v40 : float =
            if v39 then
                v37
            else
                v38
        let v41 : bool = v40 < 0.01
        let v43 : bool =
            if v41 then
                true
            else
                method18(v41)
        let v48 : string =
            if v41 then
                let v44 : float = 0.01
                method19(v44)
            else
                let v46 : float = 0.01
                method26(v40, v46)
        let v49 : string = "__assert_lt"
        let v50 : string = " "
        let v51 : string = v49 + v50 
        let v56 : string =
            if v41 then
                let v52 : float = 0.01
                method19(v52)
            else
                let v54 : float = 0.01
                method26(v40, v54)
        let v57 : string = v51 + v56 
        let v58 : unit = ()
        let v59 : (unit -> unit) = closure2(v57)
        let v60 : unit = (fun () -> v59 (); v58) ()
        let v61 : bool = v43 = false
        if v61 then
            failwith<unit> v57
        let v62 : string = "$0.im"
        let v63 : float = Fable.Core.RustInterop.emitRustExpr v34 v62 
        let v64 : bool = v63 < 0.01
        let v66 : bool =
            if v64 then
                true
            else
                method18(v64)
        let v71 : string =
            if v64 then
                let v67 : float = 0.01
                method19(v67)
            else
                let v69 : float = 0.01
                method26(v63, v69)
        let v72 : string = v49 + v50 
        let v77 : string =
            if v64 then
                let v73 : float = 0.01
                method19(v73)
            else
                let v75 : float = 0.01
                method26(v63, v75)
        let v78 : string = v72 + v77 
        let v79 : unit = ()
        let v80 : (unit -> unit) = closure2(v78)
        let v81 : unit = (fun () -> v80 (); v79) ()
        let v82 : bool = v66 = false
        if v82 then
            failwith<unit> v78
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
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
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
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v22 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : string = "__run_test"
    let v25 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v25 v26 
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
    let v13 : string = 1 |> _.ToString()
    let v25 : string = "value: "
    let v26 : string = v25 + v13 
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure2(v26)
    let v36 : unit = (fun () -> v35 (); v34) ()
    0
let v6 : (unit -> unit) = closure0()
let tests () = v6 ()
let v7 : ((string []) -> int32) = closure3()
let main args = v7 args
()
