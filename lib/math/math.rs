#![allow(unused_mut, unused_variables, unused_imports, unused_parens, unused_braces, unused_assignments, dead_code, non_snake_case, non_camel_case_types, unreachable_code, while_true)]
use std::cell::RefCell;
use std::rc::Rc;
thread_local! { static SPIRAL_TEST_NAME: std::cell::RefCell<Option<std::rc::Rc<str>>> = const { std::cell::RefCell::new(None) }; }
#[cfg(test)]
fn spiral_test(name: &'static str) {
    let code = std::thread::Builder::new().stack_size(1 << 30).spawn(move || { SPIRAL_TEST_NAME.with(|x| *x.borrow_mut() = Some(std::rc::Rc::from(name))); spiral_main() }).unwrap().join().unwrap();
    assert_eq!(code, 0);
}
#[cfg(test)]
mod spiral_tests {
    macro_rules! tests { ($($name:ident),*) => { $(#[test] fn $name() { super::spiral_test(stringify!($name)) })* } }
    tests!(test_zeta_at_known_values_, test_zeta_at_2_minus2, test_trivial_zero_at_negative_even___, test_non_trivial_zero___, test_real_part_greater_than_one___, test_zeta_at_1___, test_symmetry_across_real_axis___, test_behavior_near_origin___, test_imaginary_axis, test_critical_strip, test_reflection_formula_for_specific_value, test_euler_product_formula);
}
use pyo3::prelude::PyAnyMethods;
struct Mut0 { l0: i32 }
struct Mut1 { l0: i32, l1: Rc<str>, l2: Rc<str> }
struct Mut2 { l0: i32, l1: num_complex::Complex<f64> }
#[derive(Clone)]
enum US0 {
    US0_Some(num_complex::Complex<f64>),
    US0_None,
}
struct Mut3 { l0: Rc<str> }
#[derive(Clone)]
enum UH0 {
    UH0_Nil,
    UH0_Cons(f64, Rc<UH0>),
}
#[derive(Clone)]
enum UH1 {
    UH1_Nil,
    UH1_Cons(num_complex::Complex<f64>, Rc<UH1>),
}
fn method0(mut v0: Rc<str>) -> Rc<str> {
    v0.clone()
}
fn method3(mut v0: i32, mut v1: Rc<RefCell<Mut0>>) -> bool {
    let mut v2: i32 = v1.borrow().l0.clone();
    let mut v3: bool = v2 < v0;
    v3
}
fn method4(mut v0: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
    v0.clone()
}
fn method6(mut v0: i32, mut v1: Rc<RefCell<Mut1>>) -> bool {
    let mut v2: i32 = v1.borrow().l0.clone();
    let mut v3: bool = v2 < v0;
    v3
}
fn method7(mut v0: Rc<str>) -> Rc<str> {
    v0.clone()
}
fn method8(mut v0: f64, mut v1: f64) -> (f64, f64) {
    (v0, v1)
}
fn method9(mut v0: (f64, f64)) -> (bool, (f64, f64)) {
    (false, v0.clone())
}
fn method10(mut v0: pyo3::Python) -> pyo3::Python {
    v0.clone()
}
fn method11() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("fn"); } LIT.with(|lit| lit.clone()) };
    v0.clone()
}
fn method12(mut v0: pyo3::Bound<pyo3::types::PyModule>) -> pyo3::Bound<pyo3::types::PyModule> {
    v0.clone()
}
fn method13(mut v0: (bool, (f64, f64))) -> (bool, (f64, f64)) {
    v0.clone()
}
fn method14(mut v0: pyo3::Bound<pyo3::PyAny>) -> pyo3::Bound<pyo3::PyAny> {
    v0.clone()
}
fn method15(mut v0: pyo3::Bound<pyo3::PyAny>) -> pyo3::Bound<pyo3::PyAny> {
    v0.clone()
}
fn method5(mut v0: pyo3::Python, mut v1: num_complex::Complex<f64>) -> Result<num_complex::Complex<f64>, std::string::String> {
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("import sys"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("import traceback"); } LIT.with(|lit| lit.clone()) };
    let mut v4: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("import re"); } LIT.with(|lit| lit.clone()) };
    let mut v5: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("count = 0"); } LIT.with(|lit| lit.clone()) };
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("memory_address_pattern = re.compile(r' at 0x[0-9a-fA-F]+')"); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("def trace_calls(frame, event, arg):"); } LIT.with(|lit| lit.clone()) };
    let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("    global count"); } LIT.with(|lit| lit.clone()) };
    let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("    count += 1"); } LIT.with(|lit| lit.clone()) };
    let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("    if count < 200:"); } LIT.with(|lit| lit.clone()) };
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("        try:"); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("            args = { k: v for k, v in frame.f_locals.items() if frame.f_code.co_name != 'make_mpc' and k not in ['ctx'] and not callable(v) }"); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("            args_str = ', '.join([ f\"{k}={re.sub(memory_address_pattern, ' at 0x<?>', repr(v))}\" for k, v in args.items() ])"); } LIT.with(|lit| lit.clone()) };
    let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("            print(f\"{event}(__NAME__) / f_code.co_name: {frame.f_code.co_name} / f_locals: {args_str} / f_lineno: {frame.f_lineno} / f_code.co_filename: {frame.f_code.co_filename.split('site-packages')[-1]} / f_back.f_lineno: { '' if frame.f_back is None else frame.f_back.f_lineno } / f_back.f_code.co_filename: { '' if frame.f_back is None else frame.f_back.f_code.co_filename.split('site-packages')[-1] } / arg: {re.sub(memory_address_pattern, ' at 0x<?>', repr(arg))}\", flush=True)"); } LIT.with(|lit| lit.clone()) };
    let mut v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("        except ValueError as e:"); } LIT.with(|lit| lit.clone()) };
    let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("            print(f'__NAME__ / e: {e}', flush=True)"); } LIT.with(|lit| lit.clone()) };
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("        return trace_calls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("import mpmath"); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("def fn(log, s):"); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("    if log:"); } LIT.with(|lit| lit.clone()) };
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("        print(f'__NAME__ / s: {s} / count: {count}', flush=True)"); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("    s = complex(*s)"); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("    try:"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("        if log: sys.settrace(trace_calls)"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("        s = mpmath.zeta(s)"); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("        if log:"); } LIT.with(|lit| lit.clone()) };
    let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("            sys.settrace(None)"); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("            print(f'__NAME__ / result: {s} / count: {count}', flush=True)"); } LIT.with(|lit| lit.clone()) };
    let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("    except ValueError as e:"); } LIT.with(|lit| lit.clone()) };
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("        if s.real == 1:"); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("            s = complex(float('inf'), 0)"); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("    return (s.real, s.imag)"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![v2.clone(), v3.clone(), v4.clone(), v5.clone(), v6.clone(), v7.clone(), v8.clone(), v9.clone(), v10.clone(), v11.clone(), v12.clone(), v13.clone(), v14.clone(), v15.clone(), v16.clone(), v17.clone(), v18.clone(), v19.clone(), v8.clone(), v20.clone(), v21.clone(), v22.clone(), v23.clone(), v24.clone(), v25.clone(), v26.clone(), v27.clone(), v28.clone(), v29.clone(), v30.clone(), v31.clone(), v32.clone()]));
    let mut v34: i32 = (v33.clone().borrow().len() as i32);
    let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v36: Rc<RefCell<Mut1>> = Rc::new(RefCell::new(Mut1 { l0: 0i32, l1: v35.clone(), l2: v35.clone() }));
    while method6(v34, v36.clone()) {
        let mut v38: i32 = v36.borrow().l0.clone();
        let mut v39: i32 = v38.wrapping_neg();
        let mut v40: i32 = v39.wrapping_add(v34);
        let mut v41: i32 = v40.wrapping_sub(1i32);
        let (mut v42, mut v43): (Rc<str>, Rc<str>) = (v36.borrow().l1.clone(), v36.borrow().l2.clone());
        let mut v44: Rc<str> = v33.clone().borrow()[v41 as usize].clone();
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v43));
        let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v45, v42));
        let mut v47: i32 = v38.wrapping_add(1i32);
        let mut v48: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
        v36.borrow_mut().l0 = v47;
        v36.borrow_mut().l1 = v46.clone();
        v36.borrow_mut().l2 = v48.clone();
        ()
    };
    let (mut v49, mut v50): (Rc<str>, Rc<str>) = (v36.borrow().l1.clone(), v36.borrow().l2.clone());
    let mut v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__NAME__"); } LIT.with(|lit| lit.clone()) };
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("zeta_"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(v49.replace(&*v51, &*v52));
    let mut v54: Rc<str> = method7(v53.clone());
    let mut v56: f64 = v1.re;
    let mut v58: f64 = v1.im;
    let (mut v59, mut v60): (f64, f64) = method8(v56, v58);
    let mut v61: (f64, f64) = (v59, v60);
    let (mut v62, mut v63): (bool, (f64, f64)) = method9(v61.clone());
    let mut v64: (bool, (f64, f64)) = (v62, v63);
    let mut v65: pyo3::Python = method10(v0.clone());
    let mut v67: &str = &*v54;
    let mut v69: std::string::String = String::from(v67);
    let mut v71: std::ffi::CString = std::ffi::CString::new(v69).unwrap();
    let mut v73: &str = &*v35;
    let mut v75: std::string::String = String::from(v73);
    let mut v77: std::ffi::CString = std::ffi::CString::new(v75).unwrap();
    let mut v79: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> = pyo3::types::PyModule::from_code(v65, &v71, &v77, &v77);
    let mut v81: bool = true; let _result_map_error__ = v79.map_err(|x| { //;
    let mut v83: pyo3::PyErr = x;
    let mut v85: std::string::String = format!("{}", v83);
    let mut v87: bool = true; v85 });
    let mut v89: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> = _result_map_error__;
    let mut v91: pyo3::Bound<pyo3::types::PyModule> = v89.unwrap();
    let mut v92: Rc<str> = method11();
    let mut v94: &str = &*v92;
    let mut v95: pyo3::Bound<pyo3::types::PyModule> = method12(v91.clone());
    let mut v97: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v95.getattr(v94);
    let mut v99: bool = true; let _result_map_error__ = v97.map_err(|x| { //;
    let mut v101: pyo3::PyErr = x;
    let mut v103: std::string::String = format!("{}", v101);
    let mut v105: bool = true; v103 });
    let mut v107: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
    let mut v109: pyo3::Bound<pyo3::PyAny> = v107.unwrap();
    let mut v110: (bool, (f64, f64)) = method13(v64.clone());
    let mut v111: pyo3::Bound<pyo3::PyAny> = method14(v109.clone());
    let mut v113: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = pyo3::prelude::PyAnyMethods::call(&v111, v110, None);
    let mut v115: bool = true; let _result_map_error__ = v113.map_err(|x| { //;
    let mut v117: pyo3::PyErr = x;
    let mut v119: std::string::String = format!("{}", v117);
    let mut v121: bool = true; v119 });
    let mut v123: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
    let mut v125: pyo3::Bound<pyo3::PyAny> = v123?;
    let mut v126: pyo3::Bound<pyo3::PyAny> = method15(v125.clone());
    let mut v128: Result<(f64, f64), pyo3::PyErr> = v126.extract();
    let mut v130: bool = true; let _result_map_error__ = v128.map_err(|x| { //;
    let mut v132: pyo3::PyErr = x;
    let mut v134: std::string::String = format!("{}", v132);
    let mut v136: bool = true; v134 });
    let mut v138: Result<(f64, f64), std::string::String> = _result_map_error__;
    let (mut v140, mut v141): (f64, f64) = v138?;
    let mut v143: num_complex::Complex<f64> = num_complex::Complex::new(v140, v141);
    let mut v144: Result<num_complex::Complex<f64>, std::string::String> = Ok::<num_complex::Complex<f64>, std::string::String>(v143);
    v144.clone()
}
fn method17(mut v0: Rc<RefCell<Mut0>>) -> bool {
    let mut v1: i32 = v0.borrow().l0.clone();
    let mut v2: bool = v1 < 10000i32;
    v2
}
fn method18(mut v0: i32, mut v1: Rc<RefCell<Mut2>>) -> bool {
    let mut v2: i32 = v1.borrow().l0.clone();
    let mut v3: bool = v2 < v0;
    v3
}
fn method19(mut v0: pyo3::Python, mut v1: num_complex::Complex<f64>) -> Result<num_complex::Complex<f64>, std::string::String> {
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("import sys"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("import traceback"); } LIT.with(|lit| lit.clone()) };
    let mut v4: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("import re"); } LIT.with(|lit| lit.clone()) };
    let mut v5: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("count = 0"); } LIT.with(|lit| lit.clone()) };
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("memory_address_pattern = re.compile(r' at 0x[0-9a-fA-F]+')"); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("def trace_calls(frame, event, arg):"); } LIT.with(|lit| lit.clone()) };
    let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("    global count"); } LIT.with(|lit| lit.clone()) };
    let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("    count += 1"); } LIT.with(|lit| lit.clone()) };
    let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("    if count < 200:"); } LIT.with(|lit| lit.clone()) };
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("        try:"); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("            args = { k: v for k, v in frame.f_locals.items() if frame.f_code.co_name != 'make_mpc' and k not in ['ctx'] and not callable(v) }"); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("            args_str = ', '.join([ f\"{k}={re.sub(memory_address_pattern, ' at 0x<?>', repr(v))}\" for k, v in args.items() ])"); } LIT.with(|lit| lit.clone()) };
    let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("            print(f\"{event}(__NAME__) / f_code.co_name: {frame.f_code.co_name} / f_locals: {args_str} / f_lineno: {frame.f_lineno} / f_code.co_filename: {frame.f_code.co_filename.split('site-packages')[-1]} / f_back.f_lineno: { '' if frame.f_back is None else frame.f_back.f_lineno } / f_back.f_code.co_filename: { '' if frame.f_back is None else frame.f_back.f_code.co_filename.split('site-packages')[-1] } / arg: {re.sub(memory_address_pattern, ' at 0x<?>', repr(arg))}\", flush=True)"); } LIT.with(|lit| lit.clone()) };
    let mut v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("        except ValueError as e:"); } LIT.with(|lit| lit.clone()) };
    let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("            print(f'__NAME__ / e: {e}', flush=True)"); } LIT.with(|lit| lit.clone()) };
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("        return trace_calls"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("import mpmath"); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("def fn(log, s):"); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("    if log:"); } LIT.with(|lit| lit.clone()) };
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("        print(f'__NAME__ / s: {s} / count: {count}', flush=True)"); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("    s = complex(*s)"); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("    try:"); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("        if log: sys.settrace(trace_calls)"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("        s = mpmath.gamma(s)"); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("        if log:"); } LIT.with(|lit| lit.clone()) };
    let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("            sys.settrace(None)"); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("            print(f'__NAME__ / result: {s} / count: {count}', flush=True)"); } LIT.with(|lit| lit.clone()) };
    let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("    except ValueError as e:"); } LIT.with(|lit| lit.clone()) };
    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("        if s.real == 1:"); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("            s = complex(float('inf'), 0)"); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("    return (s.real, s.imag)"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![v2.clone(), v3.clone(), v4.clone(), v5.clone(), v6.clone(), v7.clone(), v8.clone(), v9.clone(), v10.clone(), v11.clone(), v12.clone(), v13.clone(), v14.clone(), v15.clone(), v16.clone(), v17.clone(), v18.clone(), v19.clone(), v8.clone(), v20.clone(), v21.clone(), v22.clone(), v23.clone(), v24.clone(), v25.clone(), v26.clone(), v27.clone(), v28.clone(), v29.clone(), v30.clone(), v31.clone(), v32.clone()]));
    let mut v34: i32 = (v33.clone().borrow().len() as i32);
    let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v36: Rc<RefCell<Mut1>> = Rc::new(RefCell::new(Mut1 { l0: 0i32, l1: v35.clone(), l2: v35.clone() }));
    while method6(v34, v36.clone()) {
        let mut v38: i32 = v36.borrow().l0.clone();
        let mut v39: i32 = v38.wrapping_neg();
        let mut v40: i32 = v39.wrapping_add(v34);
        let mut v41: i32 = v40.wrapping_sub(1i32);
        let (mut v42, mut v43): (Rc<str>, Rc<str>) = (v36.borrow().l1.clone(), v36.borrow().l2.clone());
        let mut v44: Rc<str> = v33.clone().borrow()[v41 as usize].clone();
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v43));
        let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v45, v42));
        let mut v47: i32 = v38.wrapping_add(1i32);
        let mut v48: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
        v36.borrow_mut().l0 = v47;
        v36.borrow_mut().l1 = v46.clone();
        v36.borrow_mut().l2 = v48.clone();
        ()
    };
    let (mut v49, mut v50): (Rc<str>, Rc<str>) = (v36.borrow().l1.clone(), v36.borrow().l2.clone());
    let mut v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__NAME__"); } LIT.with(|lit| lit.clone()) };
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("gamma_"); } LIT.with(|lit| lit.clone()) };
    let mut v53: Rc<str> = Rc::<str>::from(v49.replace(&*v51, &*v52));
    let mut v54: Rc<str> = method7(v53.clone());
    let mut v56: f64 = v1.re;
    let mut v58: f64 = v1.im;
    let (mut v59, mut v60): (f64, f64) = method8(v56, v58);
    let mut v61: (f64, f64) = (v59, v60);
    let (mut v62, mut v63): (bool, (f64, f64)) = method9(v61.clone());
    let mut v64: (bool, (f64, f64)) = (v62, v63);
    let mut v65: pyo3::Python = method10(v0.clone());
    let mut v67: &str = &*v54;
    let mut v69: std::string::String = String::from(v67);
    let mut v71: std::ffi::CString = std::ffi::CString::new(v69).unwrap();
    let mut v73: &str = &*v35;
    let mut v75: std::string::String = String::from(v73);
    let mut v77: std::ffi::CString = std::ffi::CString::new(v75).unwrap();
    let mut v79: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> = pyo3::types::PyModule::from_code(v65, &v71, &v77, &v77);
    let mut v81: bool = true; let _result_map_error__ = v79.map_err(|x| { //;
    let mut v83: pyo3::PyErr = x;
    let mut v85: std::string::String = format!("{}", v83);
    let mut v87: bool = true; v85 });
    let mut v89: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> = _result_map_error__;
    let mut v91: pyo3::Bound<pyo3::types::PyModule> = v89.unwrap();
    let mut v92: Rc<str> = method11();
    let mut v94: &str = &*v92;
    let mut v95: pyo3::Bound<pyo3::types::PyModule> = method12(v91.clone());
    let mut v97: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v95.getattr(v94);
    let mut v99: bool = true; let _result_map_error__ = v97.map_err(|x| { //;
    let mut v101: pyo3::PyErr = x;
    let mut v103: std::string::String = format!("{}", v101);
    let mut v105: bool = true; v103 });
    let mut v107: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
    let mut v109: pyo3::Bound<pyo3::PyAny> = v107.unwrap();
    let mut v110: (bool, (f64, f64)) = method13(v64.clone());
    let mut v111: pyo3::Bound<pyo3::PyAny> = method14(v109.clone());
    let mut v113: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = pyo3::prelude::PyAnyMethods::call(&v111, v110, None);
    let mut v115: bool = true; let _result_map_error__ = v113.map_err(|x| { //;
    let mut v117: pyo3::PyErr = x;
    let mut v119: std::string::String = format!("{}", v117);
    let mut v121: bool = true; v119 });
    let mut v123: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
    let mut v125: pyo3::Bound<pyo3::PyAny> = v123?;
    let mut v126: pyo3::Bound<pyo3::PyAny> = method15(v125.clone());
    let mut v128: Result<(f64, f64), pyo3::PyErr> = v126.extract();
    let mut v130: bool = true; let _result_map_error__ = v128.map_err(|x| { //;
    let mut v132: pyo3::PyErr = x;
    let mut v134: std::string::String = format!("{}", v132);
    let mut v136: bool = true; v134 });
    let mut v138: Result<(f64, f64), std::string::String> = _result_map_error__;
    let (mut v140, mut v141): (f64, f64) = v138?;
    let mut v143: num_complex::Complex<f64> = num_complex::Complex::new(v140, v141);
    let mut v144: Result<num_complex::Complex<f64>, std::string::String> = Ok::<num_complex::Complex<f64>, std::string::String>(v143);
    v144.clone()
}
fn method20(mut v0: Option<num_complex::Complex<f64>>) -> Option<num_complex::Complex<f64>> {
    v0.clone()
}
fn closure0() -> Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = Rc::new(move |mut v0: (num_complex::Complex<f64>)| -> US0 {
        let mut v1: num_complex::Complex<f64> = (v0);
        US0::US0_Some(v1.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method16(mut v0: pyo3::Python, mut v1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
    println!("zeta / count: {:?} / s: {:?}", 0i32, v1);
    let mut v4: f64 = v1.re;
    let mut v5: bool = v4 > 1.0f64;
    if v5 {
        let mut v7: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
        let mut v8: Rc<RefCell<Vec<i32>>> = Rc::new(RefCell::new(vec![<i32>::default(); 10000i32 as usize]));
        let mut v9: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 0i32 }));
        while method17(v9.clone()) {
            let mut v11: i32 = v9.borrow().l0.clone();
            v8.clone().borrow_mut()[v11 as usize] = v11;
            let mut v12: i32 = v11.wrapping_add(1i32);
            v9.borrow_mut().l0 = v12;
            ()
        };
        let mut v13: i32 = (v8.clone().borrow().len() as i32);
        let mut v14: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: 0i32, l1: v7.clone() }));
        while method18(v13, v14.clone()) {
            let mut v16: i32 = v14.borrow().l0.clone();
            let mut v17: num_complex::Complex<f64> = v14.borrow().l1.clone();
            let mut v18: i32 = v8.clone().borrow()[v16 as usize].clone();
            let mut v20: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
            let mut v21: f64 = (v18 as f64);
            let mut v23: num_complex::Complex<f64> = num_complex::Complex::new(v21, 0.0f64);
            let mut v25: num_complex::Complex<f64> = num_complex::Complex::powc(v23, v1.clone());
            let mut v27: num_complex::Complex<f64> = v20 / v25;
            let mut v29: num_complex::Complex<f64> = v17 + v27;
            let mut v30: i32 = v16.wrapping_add(1i32);
            v14.borrow_mut().l0 = v30;
            v14.borrow_mut().l1 = v29.clone();
            ()
        };
        let mut v31: num_complex::Complex<f64> = v14.borrow().l1.clone();
        v31.clone()
    } else {
        let mut v33: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
        let mut v35: num_complex::Complex<f64> = v33 - v1;
        let mut v36: num_complex::Complex<f64> = method4(v35.clone());
        let mut v37: Result<num_complex::Complex<f64>, std::string::String> = method19(v0.clone(), v36.clone());
        let mut v39: Option<num_complex::Complex<f64>> = v37.ok();
        let mut v40: Option<num_complex::Complex<f64>> = method20(v39.clone());
        let mut v41: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = closure0();
        let mut v42: Option<US0> = v40.map(|x| v41(x));
        let mut v43: US0 = US0::US0_None;
        let mut v44: US0 = v42.unwrap_or(v43);
        let mut v46: f64 = f64::NAN;
        let mut v48: f64 = f64::NAN;
        let mut v50: num_complex::Complex<f64> = num_complex::Complex::new(v46, v48);
        let mut v53: num_complex::Complex<f64> = match &v44 {
            US0::US0_None => {
                v50.clone()
            }
            US0::US0_Some(v51) => {
                let mut v51: num_complex::Complex<f64> = v51.clone();
                v51.clone()
            }
        };
        let mut v55: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
        let mut v57: num_complex::Complex<f64> = v55 * v1;
        let mut v59: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
        let mut v61: num_complex::Complex<f64> = v57 / v59;
        let mut v63: num_complex::Complex<f64> = v61.sin();
        let mut v65: f64 = v1.re;
        let mut v66: f64 = 1.0f64 - v65;
        let mut v68: f64 = v1.im;
        let mut v69: f64 = -(v68);
        let mut v71: num_complex::Complex<f64> = num_complex::Complex::new(v66, v69);
        let mut v73: f64 = v71.re;
        let mut v74: bool = v73 <= 1.0f64;
        let mut v437: num_complex::Complex<f64> = if v74 {
            let mut v76: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
            v76.clone()
        } else {
            println!("zeta / count: {:?} / s: {:?}", 1i32, v71);
            let mut v79: f64 = v71.re;
            let mut v80: bool = v79 > 1.0f64;
            if v80 {
                let mut v82: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                let mut v83: Rc<RefCell<Vec<i32>>> = Rc::new(RefCell::new(vec![<i32>::default(); 10000i32 as usize]));
                let mut v84: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 0i32 }));
                while method17(v84.clone()) {
                    let mut v86: i32 = v84.borrow().l0.clone();
                    v83.clone().borrow_mut()[v86 as usize] = v86;
                    let mut v87: i32 = v86.wrapping_add(1i32);
                    v84.borrow_mut().l0 = v87;
                    ()
                };
                let mut v88: i32 = (v83.clone().borrow().len() as i32);
                let mut v89: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: 0i32, l1: v82.clone() }));
                while method18(v88, v89.clone()) {
                    let mut v91: i32 = v89.borrow().l0.clone();
                    let mut v92: num_complex::Complex<f64> = v89.borrow().l1.clone();
                    let mut v93: i32 = v83.clone().borrow()[v91 as usize].clone();
                    let mut v95: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                    let mut v96: f64 = (v93 as f64);
                    let mut v98: num_complex::Complex<f64> = num_complex::Complex::new(v96, 0.0f64);
                    let mut v100: num_complex::Complex<f64> = num_complex::Complex::powc(v98, v71.clone());
                    let mut v102: num_complex::Complex<f64> = v95 / v100;
                    let mut v104: num_complex::Complex<f64> = v92 + v102;
                    let mut v105: i32 = v91.wrapping_add(1i32);
                    v89.borrow_mut().l0 = v105;
                    v89.borrow_mut().l1 = v104.clone();
                    ()
                };
                let mut v106: num_complex::Complex<f64> = v89.borrow().l1.clone();
                v106.clone()
            } else {
                let mut v108: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                let mut v110: num_complex::Complex<f64> = v108 - v71;
                let mut v111: num_complex::Complex<f64> = method4(v110.clone());
                let mut v112: Result<num_complex::Complex<f64>, std::string::String> = method19(v0.clone(), v111.clone());
                let mut v114: Option<num_complex::Complex<f64>> = v112.ok();
                let mut v115: Option<num_complex::Complex<f64>> = method20(v114.clone());
                let mut v116: Option<US0> = v115.map(|x| v41(x));
                let mut v117: US0 = US0::US0_None;
                let mut v118: US0 = v116.unwrap_or(v117);
                let mut v120: f64 = f64::NAN;
                let mut v122: f64 = f64::NAN;
                let mut v124: num_complex::Complex<f64> = num_complex::Complex::new(v120, v122);
                let mut v127: num_complex::Complex<f64> = match &v118 {
                    US0::US0_None => {
                        v124.clone()
                    }
                    US0::US0_Some(v125) => {
                        let mut v125: num_complex::Complex<f64> = v125.clone();
                        v125.clone()
                    }
                };
                let mut v129: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                let mut v131: num_complex::Complex<f64> = v129 * v71;
                let mut v133: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                let mut v135: num_complex::Complex<f64> = v131 / v133;
                let mut v137: num_complex::Complex<f64> = v135.sin();
                let mut v139: f64 = v71.re;
                let mut v140: f64 = 1.0f64 - v139;
                let mut v142: f64 = v71.im;
                let mut v143: f64 = -(v142);
                let mut v145: num_complex::Complex<f64> = num_complex::Complex::new(v140, v143);
                let mut v147: f64 = v145.re;
                let mut v148: bool = v147 <= 1.0f64;
                let mut v421: num_complex::Complex<f64> = if v148 {
                    let mut v150: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                    v150.clone()
                } else {
                    println!("zeta / count: {:?} / s: {:?}", 2i32, v145);
                    let mut v153: f64 = v145.re;
                    let mut v154: bool = v153 > 1.0f64;
                    if v154 {
                        let mut v156: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                        let mut v157: Rc<RefCell<Vec<i32>>> = Rc::new(RefCell::new(vec![<i32>::default(); 10000i32 as usize]));
                        let mut v158: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 0i32 }));
                        while method17(v158.clone()) {
                            let mut v160: i32 = v158.borrow().l0.clone();
                            v157.clone().borrow_mut()[v160 as usize] = v160;
                            let mut v161: i32 = v160.wrapping_add(1i32);
                            v158.borrow_mut().l0 = v161;
                            ()
                        };
                        let mut v162: i32 = (v157.clone().borrow().len() as i32);
                        let mut v163: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: 0i32, l1: v156.clone() }));
                        while method18(v162, v163.clone()) {
                            let mut v165: i32 = v163.borrow().l0.clone();
                            let mut v166: num_complex::Complex<f64> = v163.borrow().l1.clone();
                            let mut v167: i32 = v157.clone().borrow()[v165 as usize].clone();
                            let mut v169: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                            let mut v170: f64 = (v167 as f64);
                            let mut v172: num_complex::Complex<f64> = num_complex::Complex::new(v170, 0.0f64);
                            let mut v174: num_complex::Complex<f64> = num_complex::Complex::powc(v172, v145.clone());
                            let mut v176: num_complex::Complex<f64> = v169 / v174;
                            let mut v178: num_complex::Complex<f64> = v166 + v176;
                            let mut v179: i32 = v165.wrapping_add(1i32);
                            v163.borrow_mut().l0 = v179;
                            v163.borrow_mut().l1 = v178.clone();
                            ()
                        };
                        let mut v180: num_complex::Complex<f64> = v163.borrow().l1.clone();
                        v180.clone()
                    } else {
                        let mut v182: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                        let mut v184: num_complex::Complex<f64> = v182 - v145;
                        let mut v185: num_complex::Complex<f64> = method4(v184.clone());
                        let mut v186: Result<num_complex::Complex<f64>, std::string::String> = method19(v0.clone(), v185.clone());
                        let mut v188: Option<num_complex::Complex<f64>> = v186.ok();
                        let mut v189: Option<num_complex::Complex<f64>> = method20(v188.clone());
                        let mut v190: Option<US0> = v189.map(|x| v41(x));
                        let mut v191: US0 = US0::US0_None;
                        let mut v192: US0 = v190.unwrap_or(v191);
                        let mut v194: f64 = f64::NAN;
                        let mut v196: f64 = f64::NAN;
                        let mut v198: num_complex::Complex<f64> = num_complex::Complex::new(v194, v196);
                        let mut v201: num_complex::Complex<f64> = match &v192 {
                            US0::US0_None => {
                                v198.clone()
                            }
                            US0::US0_Some(v199) => {
                                let mut v199: num_complex::Complex<f64> = v199.clone();
                                v199.clone()
                            }
                        };
                        let mut v203: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                        let mut v205: num_complex::Complex<f64> = v203 * v145;
                        let mut v207: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                        let mut v209: num_complex::Complex<f64> = v205 / v207;
                        let mut v211: num_complex::Complex<f64> = v209.sin();
                        let mut v213: f64 = v145.re;
                        let mut v214: f64 = 1.0f64 - v213;
                        let mut v216: f64 = v145.im;
                        let mut v217: f64 = -(v216);
                        let mut v219: num_complex::Complex<f64> = num_complex::Complex::new(v214, v217);
                        let mut v221: f64 = v219.re;
                        let mut v222: bool = v221 <= 1.0f64;
                        let mut v405: num_complex::Complex<f64> = if v222 {
                            let mut v224: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                            v224.clone()
                        } else {
                            println!("zeta / count: {:?} / s: {:?}", 3i32, v219);
                            let mut v227: f64 = v219.re;
                            let mut v228: bool = v227 > 1.0f64;
                            if v228 {
                                let mut v230: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                                let mut v231: Rc<RefCell<Vec<i32>>> = Rc::new(RefCell::new(vec![<i32>::default(); 10000i32 as usize]));
                                let mut v232: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 0i32 }));
                                while method17(v232.clone()) {
                                    let mut v234: i32 = v232.borrow().l0.clone();
                                    v231.clone().borrow_mut()[v234 as usize] = v234;
                                    let mut v235: i32 = v234.wrapping_add(1i32);
                                    v232.borrow_mut().l0 = v235;
                                    ()
                                };
                                let mut v236: i32 = (v231.clone().borrow().len() as i32);
                                let mut v237: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: 0i32, l1: v230.clone() }));
                                while method18(v236, v237.clone()) {
                                    let mut v239: i32 = v237.borrow().l0.clone();
                                    let mut v240: num_complex::Complex<f64> = v237.borrow().l1.clone();
                                    let mut v241: i32 = v231.clone().borrow()[v239 as usize].clone();
                                    let mut v243: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                                    let mut v244: f64 = (v241 as f64);
                                    let mut v246: num_complex::Complex<f64> = num_complex::Complex::new(v244, 0.0f64);
                                    let mut v248: num_complex::Complex<f64> = num_complex::Complex::powc(v246, v219.clone());
                                    let mut v250: num_complex::Complex<f64> = v243 / v248;
                                    let mut v252: num_complex::Complex<f64> = v240 + v250;
                                    let mut v253: i32 = v239.wrapping_add(1i32);
                                    v237.borrow_mut().l0 = v253;
                                    v237.borrow_mut().l1 = v252.clone();
                                    ()
                                };
                                let mut v254: num_complex::Complex<f64> = v237.borrow().l1.clone();
                                v254.clone()
                            } else {
                                let mut v256: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                                let mut v258: num_complex::Complex<f64> = v256 - v219;
                                let mut v259: num_complex::Complex<f64> = method4(v258.clone());
                                let mut v260: Result<num_complex::Complex<f64>, std::string::String> = method19(v0.clone(), v259.clone());
                                let mut v262: Option<num_complex::Complex<f64>> = v260.ok();
                                let mut v263: Option<num_complex::Complex<f64>> = method20(v262.clone());
                                let mut v264: Option<US0> = v263.map(|x| v41(x));
                                let mut v265: US0 = US0::US0_None;
                                let mut v266: US0 = v264.unwrap_or(v265);
                                let mut v268: f64 = f64::NAN;
                                let mut v270: f64 = f64::NAN;
                                let mut v272: num_complex::Complex<f64> = num_complex::Complex::new(v268, v270);
                                let mut v275: num_complex::Complex<f64> = match &v266 {
                                    US0::US0_None => {
                                        v272.clone()
                                    }
                                    US0::US0_Some(v273) => {
                                        let mut v273: num_complex::Complex<f64> = v273.clone();
                                        v273.clone()
                                    }
                                };
                                let mut v277: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                                let mut v279: num_complex::Complex<f64> = v277 * v219;
                                let mut v281: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                                let mut v283: num_complex::Complex<f64> = v279 / v281;
                                let mut v285: num_complex::Complex<f64> = v283.sin();
                                let mut v287: f64 = v219.re;
                                let mut v288: f64 = 1.0f64 - v287;
                                let mut v290: f64 = v219.im;
                                let mut v291: f64 = -(v290);
                                let mut v293: num_complex::Complex<f64> = num_complex::Complex::new(v288, v291);
                                let mut v295: f64 = v293.re;
                                let mut v296: bool = v295 <= 1.0f64;
                                let mut v389: num_complex::Complex<f64> = if v296 {
                                    let mut v298: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                                    v298.clone()
                                } else {
                                    println!("zeta / count: {:?} / s: {:?}", 4i32, v293);
                                    let mut v301: f64 = v293.re;
                                    let mut v302: bool = v301 > 1.0f64;
                                    if v302 {
                                        let mut v304: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                                        let mut v305: Rc<RefCell<Vec<i32>>> = Rc::new(RefCell::new(vec![<i32>::default(); 10000i32 as usize]));
                                        let mut v306: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 0i32 }));
                                        while method17(v306.clone()) {
                                            let mut v308: i32 = v306.borrow().l0.clone();
                                            v305.clone().borrow_mut()[v308 as usize] = v308;
                                            let mut v309: i32 = v308.wrapping_add(1i32);
                                            v306.borrow_mut().l0 = v309;
                                            ()
                                        };
                                        let mut v310: i32 = (v305.clone().borrow().len() as i32);
                                        let mut v311: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: 0i32, l1: v304.clone() }));
                                        while method18(v310, v311.clone()) {
                                            let mut v313: i32 = v311.borrow().l0.clone();
                                            let mut v314: num_complex::Complex<f64> = v311.borrow().l1.clone();
                                            let mut v315: i32 = v305.clone().borrow()[v313 as usize].clone();
                                            let mut v317: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                                            let mut v318: f64 = (v315 as f64);
                                            let mut v320: num_complex::Complex<f64> = num_complex::Complex::new(v318, 0.0f64);
                                            let mut v322: num_complex::Complex<f64> = num_complex::Complex::powc(v320, v293.clone());
                                            let mut v324: num_complex::Complex<f64> = v317 / v322;
                                            let mut v326: num_complex::Complex<f64> = v314 + v324;
                                            let mut v327: i32 = v313.wrapping_add(1i32);
                                            v311.borrow_mut().l0 = v327;
                                            v311.borrow_mut().l1 = v326.clone();
                                            ()
                                        };
                                        let mut v328: num_complex::Complex<f64> = v311.borrow().l1.clone();
                                        v328.clone()
                                    } else {
                                        let mut v330: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                                        let mut v332: num_complex::Complex<f64> = v330 - v293;
                                        let mut v333: num_complex::Complex<f64> = method4(v332.clone());
                                        let mut v334: Result<num_complex::Complex<f64>, std::string::String> = method19(v0.clone(), v333.clone());
                                        let mut v336: Option<num_complex::Complex<f64>> = v334.ok();
                                        let mut v337: Option<num_complex::Complex<f64>> = method20(v336.clone());
                                        let mut v338: Option<US0> = v337.map(|x| v41(x));
                                        let mut v339: US0 = US0::US0_None;
                                        let mut v340: US0 = v338.unwrap_or(v339);
                                        let mut v342: f64 = f64::NAN;
                                        let mut v344: f64 = f64::NAN;
                                        let mut v346: num_complex::Complex<f64> = num_complex::Complex::new(v342, v344);
                                        let mut v349: num_complex::Complex<f64> = match &v340 {
                                            US0::US0_None => {
                                                v346.clone()
                                            }
                                            US0::US0_Some(v347) => {
                                                let mut v347: num_complex::Complex<f64> = v347.clone();
                                                v347.clone()
                                            }
                                        };
                                        let mut v351: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                                        let mut v353: num_complex::Complex<f64> = v351 * v293;
                                        let mut v355: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                                        let mut v357: num_complex::Complex<f64> = v353 / v355;
                                        let mut v359: num_complex::Complex<f64> = v357.sin();
                                        let mut v361: f64 = v293.re;
                                        let mut v362: f64 = 1.0f64 - v361;
                                        let mut v364: f64 = v293.im;
                                        let mut v365: f64 = -(v364);
                                        let mut v367: num_complex::Complex<f64> = num_complex::Complex::new(v362, v365);
                                        let mut v369: f64 = v367.re;
                                        let mut v370: bool = v369 <= 1.0f64;
                                        let mut v373: num_complex::Complex<f64> = if v370 {
                                            let mut v372: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                                            v372.clone()
                                        } else {
                                            v367.clone()
                                        };
                                        let mut v375: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                                        let mut v377: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                                        let mut v379: num_complex::Complex<f64> = num_complex::Complex::powc(v377, v293);
                                        let mut v381: num_complex::Complex<f64> = v375 * v379;
                                        let mut v383: num_complex::Complex<f64> = v381 * v359;
                                        let mut v385: num_complex::Complex<f64> = v383 * v349;
                                        let mut v387: num_complex::Complex<f64> = v385 * v373;
                                        v387.clone()
                                    }
                                };
                                let mut v391: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                                let mut v393: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                                let mut v395: num_complex::Complex<f64> = num_complex::Complex::powc(v393, v219);
                                let mut v397: num_complex::Complex<f64> = v391 * v395;
                                let mut v399: num_complex::Complex<f64> = v397 * v285;
                                let mut v401: num_complex::Complex<f64> = v399 * v275;
                                let mut v403: num_complex::Complex<f64> = v401 * v389;
                                v403.clone()
                            }
                        };
                        let mut v407: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                        let mut v409: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                        let mut v411: num_complex::Complex<f64> = num_complex::Complex::powc(v409, v145);
                        let mut v413: num_complex::Complex<f64> = v407 * v411;
                        let mut v415: num_complex::Complex<f64> = v413 * v211;
                        let mut v417: num_complex::Complex<f64> = v415 * v201;
                        let mut v419: num_complex::Complex<f64> = v417 * v405;
                        v419.clone()
                    }
                };
                let mut v423: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                let mut v425: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                let mut v427: num_complex::Complex<f64> = num_complex::Complex::powc(v425, v71);
                let mut v429: num_complex::Complex<f64> = v423 * v427;
                let mut v431: num_complex::Complex<f64> = v429 * v137;
                let mut v433: num_complex::Complex<f64> = v431 * v127;
                let mut v435: num_complex::Complex<f64> = v433 * v421;
                v435.clone()
            }
        };
        let mut v439: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
        let mut v441: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
        let mut v443: num_complex::Complex<f64> = num_complex::Complex::powc(v441, v1);
        let mut v445: num_complex::Complex<f64> = v439 * v443;
        let mut v447: num_complex::Complex<f64> = v445 * v63;
        let mut v449: num_complex::Complex<f64> = v447 * v53;
        let mut v451: num_complex::Complex<f64> = v449 * v437;
        v451.clone()
    }
}
fn method21(mut v0: bool) -> bool {
    v0
}
fn method23(mut v0: Rc<RefCell<Mut3>>, mut v1: Rc<str>) -> () {
    let mut v2: Rc<str> = v0.borrow().l0.clone();
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v2, v1));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn format_real_22(mut v0: f64) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    let mut v3: Rc<str> = Rc::<str>::from({ let v = v0; if v.is_nan() { String::from("NaN") } else if v.is_infinite() { String::from(if v > 0.0 { "Infinity" } else { "-Infinity" }) } else { format!("{:?}", v) } });
    method23(v2.clone(), v3.clone());
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4.clone()
}
fn method2(mut v0: pyo3::Python) -> () {
    let mut v2: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
    let mut v4: num_complex::Complex<f64> = num_complex::Complex::new(-1.0f64, 0.0f64);
    let mut v5: Rc<RefCell<Vec<(num_complex::Complex<f64>, f64)>>> = Rc::new(RefCell::new(vec![(v2.clone(), 1.6449340668482264f64), (v4.clone(), -0.08333333333333333f64)]));
    let mut v6: i32 = (v5.clone().borrow().len() as i32);
    let mut v7: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 0i32 }));
    while method3(v6, v7.clone()) {
        let mut v9: i32 = v7.borrow().l0.clone();
        let (mut v10, mut v11): (num_complex::Complex<f64>, f64) = v5.clone().borrow()[v9 as usize].clone();
        let mut v12: num_complex::Complex<f64> = method4(v10.clone());
        let mut v13: Result<num_complex::Complex<f64>, std::string::String> = method5(v0.clone(), v12.clone());
        let mut v14: num_complex::Complex<f64> = method16(v0.clone(), v10.clone());
        let mut v16: Option<num_complex::Complex<f64>> = v13.ok();
        let mut v17: Option<num_complex::Complex<f64>> = method20(v16.clone());
        let mut v18: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = closure0();
        let mut v19: Option<US0> = v17.map(|x| v18(x));
        let mut v20: US0 = US0::US0_None;
        let mut v21: US0 = v19.unwrap_or(v20);
        let mut v23: f64 = f64::NAN;
        let mut v25: f64 = f64::NAN;
        let mut v27: num_complex::Complex<f64> = num_complex::Complex::new(v23, v25);
        let mut v30: num_complex::Complex<f64> = match &v21 {
            US0::US0_None => {
                v27.clone()
            }
            US0::US0_Some(v28) => {
                let mut v28: num_complex::Complex<f64> = v28.clone();
                v28.clone()
            }
        };
        let mut v32: f64 = v30.im;
        let mut v33: bool = v32 == 0.0f64;
        let mut v35: bool = if v33 {
            true
        } else {
            method21(v33)
        };
        let mut v69: Rc<str> = if v33 {
            let mut v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
            let mut v42: f64 = 0.0f64;
            let mut v43: Rc<str> = format_real_22(v42);
            let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v43));
            let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v45, v44));
            let mut v47: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v47));
            v48.clone()
        } else {
            let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v53: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v54: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
            let mut v55: Rc<str> = format_real_22(v32);
            let mut v56: Rc<str> = Rc::<str>::from(format!("{}{}", v54, v55));
            let mut v57: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
            let mut v58: Rc<str> = Rc::<str>::from(format!("{}{}", v56, v57));
            let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
            let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v53));
            let mut v62: f64 = 0.0f64;
            let mut v63: Rc<str> = format_real_22(v62);
            let mut v64: Rc<str> = Rc::<str>::from(format!("{}{}", v61, v63));
            let mut v65: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v66: Rc<str> = Rc::<str>::from(format!("{}{}", v65, v64));
            let mut v67: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v68: Rc<str> = Rc::<str>::from(format!("{}{}", v66, v67));
            v68.clone()
        };
        let mut v70: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq"); } LIT.with(|lit| lit.clone()) };
        let mut v71: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
        let mut v106: Rc<str> = if v33 {
            let mut v73: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v74: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v75: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v76: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v77: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v78: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
            let mut v79: f64 = 0.0f64;
            let mut v80: Rc<str> = format_real_22(v79);
            let mut v81: Rc<str> = Rc::<str>::from(format!("{}{}", v78, v80));
            let mut v82: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v83: Rc<str> = Rc::<str>::from(format!("{}{}", v82, v81));
            let mut v84: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v85: Rc<str> = Rc::<str>::from(format!("{}{}", v83, v84));
            v85.clone()
        } else {
            let mut v86: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v87: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v88: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v89: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v90: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v91: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
            let mut v92: Rc<str> = format_real_22(v32);
            let mut v93: Rc<str> = Rc::<str>::from(format!("{}{}", v91, v92));
            let mut v94: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
            let mut v95: Rc<str> = Rc::<str>::from(format!("{}{}", v93, v94));
            let mut v96: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v97: Rc<str> = Rc::<str>::from(format!("{}{}", v95, v96));
            let mut v98: Rc<str> = Rc::<str>::from(format!("{}{}", v97, v90));
            let mut v99: f64 = 0.0f64;
            let mut v100: Rc<str> = format_real_22(v99);
            let mut v101: Rc<str> = Rc::<str>::from(format!("{}{}", v98, v100));
            let mut v102: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v103: Rc<str> = Rc::<str>::from(format!("{}{}", v102, v101));
            let mut v104: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v105: Rc<str> = Rc::<str>::from(format!("{}{}", v103, v104));
            v105.clone()
        };
        let mut v107: Rc<str> = Rc::<str>::from(format!("{}{}", v72, v106));
        println!("{}", v107);
        let mut v108: bool = v35 == false;
        if v108 {
            std::panic::panic_any::<std::string::String>(format!("{}", v107.clone()))
        };
        let mut v110: f64 = v30.re;
        let mut v111: f64 = v110 - v11;
        let mut v112: f64 = -(v111);
        let mut v113: bool = v111 >= v112;
        let mut v114: f64 = if v113 {
            v111
        } else {
            v112
        };
        let mut v115: bool = v114 < 0.0001f64;
        let mut v117: bool = if v115 {
            true
        } else {
            method21(v115)
        };
        let mut v151: Rc<str> = if v115 {
            let mut v118: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v119: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v120: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v121: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v122: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v123: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
            let mut v124: f64 = 0.0001f64;
            let mut v125: Rc<str> = format_real_22(v124);
            let mut v126: Rc<str> = Rc::<str>::from(format!("{}{}", v123, v125));
            let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v127, v126));
            let mut v129: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v130: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v129));
            v130.clone()
        } else {
            let mut v131: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v132: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v133: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v135: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v136: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
            let mut v137: Rc<str> = format_real_22(v114);
            let mut v138: Rc<str> = Rc::<str>::from(format!("{}{}", v136, v137));
            let mut v139: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
            let mut v140: Rc<str> = Rc::<str>::from(format!("{}{}", v138, v139));
            let mut v141: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v142: Rc<str> = Rc::<str>::from(format!("{}{}", v140, v141));
            let mut v143: Rc<str> = Rc::<str>::from(format!("{}{}", v142, v135));
            let mut v144: f64 = 0.0001f64;
            let mut v145: Rc<str> = format_real_22(v144);
            let mut v146: Rc<str> = Rc::<str>::from(format!("{}{}", v143, v145));
            let mut v147: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v148: Rc<str> = Rc::<str>::from(format!("{}{}", v147, v146));
            let mut v149: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v150: Rc<str> = Rc::<str>::from(format!("{}{}", v148, v149));
            v150.clone()
        };
        let mut v152: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt"); } LIT.with(|lit| lit.clone()) };
        let mut v153: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
        let mut v187: Rc<str> = if v115 {
            let mut v154: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v155: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v156: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v157: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v158: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v159: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
            let mut v160: f64 = 0.0001f64;
            let mut v161: Rc<str> = format_real_22(v160);
            let mut v162: Rc<str> = Rc::<str>::from(format!("{}{}", v159, v161));
            let mut v163: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v164: Rc<str> = Rc::<str>::from(format!("{}{}", v163, v162));
            let mut v165: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v166: Rc<str> = Rc::<str>::from(format!("{}{}", v164, v165));
            v166.clone()
        } else {
            let mut v167: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v168: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v169: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v170: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v171: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v172: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
            let mut v173: Rc<str> = format_real_22(v114);
            let mut v174: Rc<str> = Rc::<str>::from(format!("{}{}", v172, v173));
            let mut v175: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
            let mut v176: Rc<str> = Rc::<str>::from(format!("{}{}", v174, v175));
            let mut v177: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v178: Rc<str> = Rc::<str>::from(format!("{}{}", v176, v177));
            let mut v179: Rc<str> = Rc::<str>::from(format!("{}{}", v178, v171));
            let mut v180: f64 = 0.0001f64;
            let mut v181: Rc<str> = format_real_22(v180);
            let mut v182: Rc<str> = Rc::<str>::from(format!("{}{}", v179, v181));
            let mut v183: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v184: Rc<str> = Rc::<str>::from(format!("{}{}", v183, v182));
            let mut v185: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v186: Rc<str> = Rc::<str>::from(format!("{}{}", v184, v185));
            v186.clone()
        };
        let mut v188: Rc<str> = Rc::<str>::from(format!("{}{}", v153, v187));
        println!("{}", v188);
        let mut v189: bool = v117 == false;
        if v189 {
            std::panic::panic_any::<std::string::String>(format!("{}", v188.clone()))
        };
        let mut v190: i32 = v9.wrapping_add(1i32);
        v7.borrow_mut().l0 = v190;
        ()
    };
    ()
}
fn method1() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method2(v3.clone());
    let mut v4: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v5: bool = true; (v4) }); //;
    let mut v7: Result<(), pyo3::PyErr> = __run_test;
    v7.unwrap();
    ()
}
fn method25(mut v0: pyo3::Python) -> () {
    let mut v2: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, -2.0f64);
    let mut v3: num_complex::Complex<f64> = method4(v2.clone());
    let mut v4: Result<num_complex::Complex<f64>, std::string::String> = method5(v0.clone(), v3.clone());
    let mut v5: num_complex::Complex<f64> = method16(v0.clone(), v2.clone());
    let mut v7: Option<num_complex::Complex<f64>> = v4.ok();
    let mut v8: Option<num_complex::Complex<f64>> = method20(v7.clone());
    let mut v9: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = closure0();
    let mut v10: Option<US0> = v8.map(|x| v9(x));
    let mut v11: US0 = US0::US0_None;
    let mut v12: US0 = v10.unwrap_or(v11);
    let mut v14: f64 = f64::NAN;
    let mut v16: f64 = f64::NAN;
    let mut v18: num_complex::Complex<f64> = num_complex::Complex::new(v14, v16);
    let mut v21: num_complex::Complex<f64> = match &v12 {
        US0::US0_None => {
            v18.clone()
        }
        US0::US0_Some(v19) => {
            let mut v19: num_complex::Complex<f64> = v19.clone();
            v19.clone()
        }
    };
    let mut v23: f64 = v21.re;
    let mut v24: f64 = v23 - 0.8673f64;
    let mut v25: f64 = -(v24);
    let mut v26: bool = v24 >= v25;
    let mut v27: f64 = if v26 {
        v24
    } else {
        v25
    };
    let mut v28: bool = v27 < 0.001f64;
    let mut v30: bool = if v28 {
        true
    } else {
        method21(v28)
    };
    let mut v64: Rc<str> = if v28 {
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v37: f64 = 0.001f64;
        let mut v38: Rc<str> = format_real_22(v37);
        let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v38));
        let mut v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v39));
        let mut v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
        v43.clone()
    } else {
        let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v47: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v48: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
        let mut v50: Rc<str> = format_real_22(v27);
        let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v49, v50));
        let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
        let mut v54: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v55: Rc<str> = Rc::<str>::from(format!("{}{}", v53, v54));
        let mut v56: Rc<str> = Rc::<str>::from(format!("{}{}", v55, v48));
        let mut v57: f64 = 0.001f64;
        let mut v58: Rc<str> = format_real_22(v57);
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v56, v58));
        let mut v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v59));
        let mut v62: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v63: Rc<str> = Rc::<str>::from(format!("{}{}", v61, v62));
        v63.clone()
    };
    let mut v65: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt"); } LIT.with(|lit| lit.clone()) };
    let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v67: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
    let mut v101: Rc<str> = if v28 {
        let mut v68: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v69: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v70: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v71: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v73: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v74: f64 = 0.001f64;
        let mut v75: Rc<str> = format_real_22(v74);
        let mut v76: Rc<str> = Rc::<str>::from(format!("{}{}", v73, v75));
        let mut v77: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v78: Rc<str> = Rc::<str>::from(format!("{}{}", v77, v76));
        let mut v79: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v80: Rc<str> = Rc::<str>::from(format!("{}{}", v78, v79));
        v80.clone()
    } else {
        let mut v81: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v82: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v83: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v84: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v85: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v86: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
        let mut v87: Rc<str> = format_real_22(v27);
        let mut v88: Rc<str> = Rc::<str>::from(format!("{}{}", v86, v87));
        let mut v89: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v90: Rc<str> = Rc::<str>::from(format!("{}{}", v88, v89));
        let mut v91: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v92: Rc<str> = Rc::<str>::from(format!("{}{}", v90, v91));
        let mut v93: Rc<str> = Rc::<str>::from(format!("{}{}", v92, v85));
        let mut v94: f64 = 0.001f64;
        let mut v95: Rc<str> = format_real_22(v94);
        let mut v96: Rc<str> = Rc::<str>::from(format!("{}{}", v93, v95));
        let mut v97: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v98: Rc<str> = Rc::<str>::from(format!("{}{}", v97, v96));
        let mut v99: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v100: Rc<str> = Rc::<str>::from(format!("{}{}", v98, v99));
        v100.clone()
    };
    let mut v102: Rc<str> = Rc::<str>::from(format!("{}{}", v67, v101));
    println!("{}", v102);
    let mut v103: bool = v30 == false;
    if v103 {
        std::panic::panic_any::<std::string::String>(format!("{}", v102.clone()))
    };
    let mut v105: f64 = v21.im;
    let mut v106: f64 = v105 - 0.275f64;
    let mut v107: f64 = -(v106);
    let mut v108: bool = v106 >= v107;
    let mut v109: f64 = if v108 {
        v106
    } else {
        v107
    };
    let mut v110: bool = v109 < 0.001f64;
    let mut v112: bool = if v110 {
        true
    } else {
        method21(v110)
    };
    let mut v146: Rc<str> = if v110 {
        let mut v113: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v114: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v115: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v116: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v117: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v118: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v119: f64 = 0.001f64;
        let mut v120: Rc<str> = format_real_22(v119);
        let mut v121: Rc<str> = Rc::<str>::from(format!("{}{}", v118, v120));
        let mut v122: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v123: Rc<str> = Rc::<str>::from(format!("{}{}", v122, v121));
        let mut v124: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v125: Rc<str> = Rc::<str>::from(format!("{}{}", v123, v124));
        v125.clone()
    } else {
        let mut v126: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v128: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v129: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v130: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v131: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
        let mut v132: Rc<str> = format_real_22(v109);
        let mut v133: Rc<str> = Rc::<str>::from(format!("{}{}", v131, v132));
        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v135: Rc<str> = Rc::<str>::from(format!("{}{}", v133, v134));
        let mut v136: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v137: Rc<str> = Rc::<str>::from(format!("{}{}", v135, v136));
        let mut v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v130));
        let mut v139: f64 = 0.001f64;
        let mut v140: Rc<str> = format_real_22(v139);
        let mut v141: Rc<str> = Rc::<str>::from(format!("{}{}", v138, v140));
        let mut v142: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v143: Rc<str> = Rc::<str>::from(format!("{}{}", v142, v141));
        let mut v144: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v145: Rc<str> = Rc::<str>::from(format!("{}{}", v143, v144));
        v145.clone()
    };
    let mut v147: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
    let mut v181: Rc<str> = if v110 {
        let mut v148: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v149: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v150: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v151: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v152: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v153: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v154: f64 = 0.001f64;
        let mut v155: Rc<str> = format_real_22(v154);
        let mut v156: Rc<str> = Rc::<str>::from(format!("{}{}", v153, v155));
        let mut v157: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v158: Rc<str> = Rc::<str>::from(format!("{}{}", v157, v156));
        let mut v159: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v160: Rc<str> = Rc::<str>::from(format!("{}{}", v158, v159));
        v160.clone()
    } else {
        let mut v161: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v162: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v163: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v164: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v165: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v166: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
        let mut v167: Rc<str> = format_real_22(v109);
        let mut v168: Rc<str> = Rc::<str>::from(format!("{}{}", v166, v167));
        let mut v169: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v170: Rc<str> = Rc::<str>::from(format!("{}{}", v168, v169));
        let mut v171: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v172: Rc<str> = Rc::<str>::from(format!("{}{}", v170, v171));
        let mut v173: Rc<str> = Rc::<str>::from(format!("{}{}", v172, v165));
        let mut v174: f64 = 0.001f64;
        let mut v175: Rc<str> = format_real_22(v174);
        let mut v176: Rc<str> = Rc::<str>::from(format!("{}{}", v173, v175));
        let mut v177: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v178: Rc<str> = Rc::<str>::from(format!("{}{}", v177, v176));
        let mut v179: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v180: Rc<str> = Rc::<str>::from(format!("{}{}", v178, v179));
        v180.clone()
    };
    let mut v182: Rc<str> = Rc::<str>::from(format!("{}{}", v147, v181));
    println!("{}", v182);
    let mut v183: bool = v112 == false;
    if v183 {
        std::panic::panic_any::<std::string::String>(format!("{}", v182.clone()))
    }
}
fn method24() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method25(v3.clone());
    let mut v4: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v5: bool = true; (v4) }); //;
    let mut v7: Result<(), pyo3::PyErr> = __run_test;
    v7.unwrap();
    ()
}
fn method28(mut v0: pyo3::Python, mut v1: Rc<UH0>) -> () {
    loop {
        match &*v1 {
            UH0::UH0_Cons(v2, v3) => {
                let mut v2: f64 = *v2;
                let mut v3: Rc<UH0> = v3.clone();
                let mut v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, 0.0f64);
                let mut v6: num_complex::Complex<f64> = method4(v5.clone());
                let mut v7: Result<num_complex::Complex<f64>, std::string::String> = method5(v0.clone(), v6.clone());
                let mut v8: num_complex::Complex<f64> = method16(v0.clone(), v5.clone());
                let mut v10: Option<num_complex::Complex<f64>> = v7.ok();
                let mut v11: Option<num_complex::Complex<f64>> = method20(v10.clone());
                let mut v12: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = closure0();
                let mut v13: Option<US0> = v11.map(|x| v12(x));
                let mut v14: US0 = US0::US0_None;
                let mut v15: US0 = v13.unwrap_or(v14);
                let mut v17: f64 = f64::NAN;
                let mut v19: f64 = f64::NAN;
                let mut v21: num_complex::Complex<f64> = num_complex::Complex::new(v17, v19);
                let mut v24: num_complex::Complex<f64> = match &v15 {
                    US0::US0_None => {
                        v21.clone()
                    }
                    US0::US0_Some(v22) => {
                        let mut v22: num_complex::Complex<f64> = v22.clone();
                        v22.clone()
                    }
                };
                let mut v26: f64 = v24.re;
                let mut v27: bool = v26 == 0.0f64;
                let mut v29: bool = if v27 {
                    true
                } else {
                    method21(v27)
                };
                let mut v63: Rc<str> = if v27 {
                    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
                    let mut v36: f64 = 0.0f64;
                    let mut v37: Rc<str> = format_real_22(v36);
                    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v37));
                    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v38));
                    let mut v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
                    v42.clone()
                } else {
                    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v47: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v48: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
                    let mut v49: Rc<str> = format_real_22(v26);
                    let mut v50: Rc<str> = Rc::<str>::from(format!("{}{}", v48, v49));
                    let mut v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
                    let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v51));
                    let mut v53: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v52, v53));
                    let mut v55: Rc<str> = Rc::<str>::from(format!("{}{}", v54, v47));
                    let mut v56: f64 = 0.0f64;
                    let mut v57: Rc<str> = format_real_22(v56);
                    let mut v58: Rc<str> = Rc::<str>::from(format!("{}{}", v55, v57));
                    let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v59, v58));
                    let mut v61: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v62: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v61));
                    v62.clone()
                };
                let mut v64: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq"); } LIT.with(|lit| lit.clone()) };
                let mut v65: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
                let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
                let mut v100: Rc<str> = if v27 {
                    let mut v67: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v68: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v69: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v70: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v71: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
                    let mut v73: f64 = 0.0f64;
                    let mut v74: Rc<str> = format_real_22(v73);
                    let mut v75: Rc<str> = Rc::<str>::from(format!("{}{}", v72, v74));
                    let mut v76: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v77: Rc<str> = Rc::<str>::from(format!("{}{}", v76, v75));
                    let mut v78: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v79: Rc<str> = Rc::<str>::from(format!("{}{}", v77, v78));
                    v79.clone()
                } else {
                    let mut v80: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v81: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v82: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v83: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v84: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v85: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
                    let mut v86: Rc<str> = format_real_22(v26);
                    let mut v87: Rc<str> = Rc::<str>::from(format!("{}{}", v85, v86));
                    let mut v88: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
                    let mut v89: Rc<str> = Rc::<str>::from(format!("{}{}", v87, v88));
                    let mut v90: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v91: Rc<str> = Rc::<str>::from(format!("{}{}", v89, v90));
                    let mut v92: Rc<str> = Rc::<str>::from(format!("{}{}", v91, v84));
                    let mut v93: f64 = 0.0f64;
                    let mut v94: Rc<str> = format_real_22(v93);
                    let mut v95: Rc<str> = Rc::<str>::from(format!("{}{}", v92, v94));
                    let mut v96: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v97: Rc<str> = Rc::<str>::from(format!("{}{}", v96, v95));
                    let mut v98: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v99: Rc<str> = Rc::<str>::from(format!("{}{}", v97, v98));
                    v99.clone()
                };
                let mut v101: Rc<str> = Rc::<str>::from(format!("{}{}", v66, v100));
                println!("{}", v101);
                let mut v102: bool = v29 == false;
                if v102 {
                    std::panic::panic_any::<std::string::String>(format!("{}", v101.clone()))
                };
                let mut v104: f64 = v24.im;
                let mut v105: bool = v104 == 0.0f64;
                let mut v107: bool = if v105 {
                    true
                } else {
                    method21(v105)
                };
                let mut v141: Rc<str> = if v105 {
                    let mut v108: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v109: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v110: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v111: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v112: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v113: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
                    let mut v114: f64 = 0.0f64;
                    let mut v115: Rc<str> = format_real_22(v114);
                    let mut v116: Rc<str> = Rc::<str>::from(format!("{}{}", v113, v115));
                    let mut v117: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v118: Rc<str> = Rc::<str>::from(format!("{}{}", v117, v116));
                    let mut v119: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v120: Rc<str> = Rc::<str>::from(format!("{}{}", v118, v119));
                    v120.clone()
                } else {
                    let mut v121: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v122: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v123: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v124: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v125: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v126: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
                    let mut v127: Rc<str> = format_real_22(v104);
                    let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                    let mut v129: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
                    let mut v130: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v129));
                    let mut v131: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v132: Rc<str> = Rc::<str>::from(format!("{}{}", v130, v131));
                    let mut v133: Rc<str> = Rc::<str>::from(format!("{}{}", v132, v125));
                    let mut v134: f64 = 0.0f64;
                    let mut v135: Rc<str> = format_real_22(v134);
                    let mut v136: Rc<str> = Rc::<str>::from(format!("{}{}", v133, v135));
                    let mut v137: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v136));
                    let mut v139: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v140: Rc<str> = Rc::<str>::from(format!("{}{}", v138, v139));
                    v140.clone()
                };
                let mut v142: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
                let mut v176: Rc<str> = if v105 {
                    let mut v143: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v144: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v145: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v147: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v148: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
                    let mut v149: f64 = 0.0f64;
                    let mut v150: Rc<str> = format_real_22(v149);
                    let mut v151: Rc<str> = Rc::<str>::from(format!("{}{}", v148, v150));
                    let mut v152: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v153: Rc<str> = Rc::<str>::from(format!("{}{}", v152, v151));
                    let mut v154: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v155: Rc<str> = Rc::<str>::from(format!("{}{}", v153, v154));
                    v155.clone()
                } else {
                    let mut v156: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v157: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v158: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v159: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v160: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v161: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
                    let mut v162: Rc<str> = format_real_22(v104);
                    let mut v163: Rc<str> = Rc::<str>::from(format!("{}{}", v161, v162));
                    let mut v164: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
                    let mut v165: Rc<str> = Rc::<str>::from(format!("{}{}", v163, v164));
                    let mut v166: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v167: Rc<str> = Rc::<str>::from(format!("{}{}", v165, v166));
                    let mut v168: Rc<str> = Rc::<str>::from(format!("{}{}", v167, v160));
                    let mut v169: f64 = 0.0f64;
                    let mut v170: Rc<str> = format_real_22(v169);
                    let mut v171: Rc<str> = Rc::<str>::from(format!("{}{}", v168, v170));
                    let mut v172: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v173: Rc<str> = Rc::<str>::from(format!("{}{}", v172, v171));
                    let mut v174: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v175: Rc<str> = Rc::<str>::from(format!("{}{}", v173, v174));
                    v175.clone()
                };
                let mut v177: Rc<str> = Rc::<str>::from(format!("{}{}", v142, v176));
                println!("{}", v177);
                let mut v178: bool = v107 == false;
                if v178 {
                    std::panic::panic_any::<std::string::String>(format!("{}", v177.clone()))
                };
                (v0, v1) = (v0.clone(), v3.clone());
                continue;
            }
            UH0::UH0_Nil => {
                return ();
            }
        }
        return ();
    }
}
fn method29() -> Rc<UH0> {
    let mut v0: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
    let mut v1: Rc<UH0> = Rc::new(UH0::UH0_Cons(-40.0f64, v0.clone()));
    let mut v2: Rc<UH0> = Rc::new(UH0::UH0_Cons(-38.0f64, v1.clone()));
    let mut v3: Rc<UH0> = Rc::new(UH0::UH0_Cons(-36.0f64, v2.clone()));
    let mut v4: Rc<UH0> = Rc::new(UH0::UH0_Cons(-34.0f64, v3.clone()));
    let mut v5: Rc<UH0> = Rc::new(UH0::UH0_Cons(-32.0f64, v4.clone()));
    let mut v6: Rc<UH0> = Rc::new(UH0::UH0_Cons(-30.0f64, v5.clone()));
    let mut v7: Rc<UH0> = Rc::new(UH0::UH0_Cons(-28.0f64, v6.clone()));
    let mut v8: Rc<UH0> = Rc::new(UH0::UH0_Cons(-26.0f64, v7.clone()));
    let mut v9: Rc<UH0> = Rc::new(UH0::UH0_Cons(-24.0f64, v8.clone()));
    let mut v10: Rc<UH0> = Rc::new(UH0::UH0_Cons(-22.0f64, v9.clone()));
    let mut v11: Rc<UH0> = Rc::new(UH0::UH0_Cons(-20.0f64, v10.clone()));
    let mut v12: Rc<UH0> = Rc::new(UH0::UH0_Cons(-18.0f64, v11.clone()));
    let mut v13: Rc<UH0> = Rc::new(UH0::UH0_Cons(-16.0f64, v12.clone()));
    let mut v14: Rc<UH0> = Rc::new(UH0::UH0_Cons(-14.0f64, v13.clone()));
    let mut v15: Rc<UH0> = Rc::new(UH0::UH0_Cons(-12.0f64, v14.clone()));
    let mut v16: Rc<UH0> = Rc::new(UH0::UH0_Cons(-10.0f64, v15.clone()));
    let mut v17: Rc<UH0> = Rc::new(UH0::UH0_Cons(-8.0f64, v16.clone()));
    let mut v18: Rc<UH0> = Rc::new(UH0::UH0_Cons(-6.0f64, v17.clone()));
    let mut v19: Rc<UH0> = Rc::new(UH0::UH0_Cons(-4.0f64, v18.clone()));
    Rc::new(UH0::UH0_Cons(-2.0f64, v19.clone()))
}
fn method27(mut v0: pyo3::Python) -> () {
    let mut v1: Rc<UH0> = method29();
    method28(v0.clone(), v1.clone())
}
fn method26() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method27(v3.clone());
    let mut v4: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v5: bool = true; (v4) }); //;
    let mut v7: Result<(), pyo3::PyErr> = __run_test;
    v7.unwrap();
    ()
}
fn method31(mut v0: pyo3::Python) -> () {
    let mut v2: num_complex::Complex<f64> = num_complex::Complex::new(0.5f64, 14.134725f64);
    let mut v4: num_complex::Complex<f64> = num_complex::Complex::new(0.5f64, 21.02204f64);
    let mut v6: num_complex::Complex<f64> = num_complex::Complex::new(0.5f64, 25.010857f64);
    let mut v8: num_complex::Complex<f64> = num_complex::Complex::new(0.5f64, 30.424876f64);
    let mut v10: num_complex::Complex<f64> = num_complex::Complex::new(0.5f64, 32.935062f64);
    let mut v12: num_complex::Complex<f64> = num_complex::Complex::new(0.5f64, 37.586178f64);
    let mut v13: Rc<RefCell<Vec<num_complex::Complex<f64>>>> = Rc::new(RefCell::new(vec![v2.clone(), v4.clone(), v6.clone(), v8.clone(), v10.clone(), v12.clone()]));
    let mut v14: i32 = (v13.clone().borrow().len() as i32);
    let mut v15: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 0i32 }));
    while method3(v14, v15.clone()) {
        let mut v17: i32 = v15.borrow().l0.clone();
        let mut v18: num_complex::Complex<f64> = v13.clone().borrow()[v17 as usize].clone();
        let mut v19: num_complex::Complex<f64> = method4(v18.clone());
        let mut v20: Result<num_complex::Complex<f64>, std::string::String> = method5(v0.clone(), v19.clone());
        let mut v21: num_complex::Complex<f64> = method16(v0.clone(), v18.clone());
        let mut v23: Option<num_complex::Complex<f64>> = v20.ok();
        let mut v24: Option<num_complex::Complex<f64>> = method20(v23.clone());
        let mut v25: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = closure0();
        let mut v26: Option<US0> = v24.map(|x| v25(x));
        let mut v27: US0 = US0::US0_None;
        let mut v28: US0 = v26.unwrap_or(v27);
        let mut v30: f64 = f64::NAN;
        let mut v32: f64 = f64::NAN;
        let mut v34: num_complex::Complex<f64> = num_complex::Complex::new(v30, v32);
        let mut v37: num_complex::Complex<f64> = match &v28 {
            US0::US0_None => {
                v34.clone()
            }
            US0::US0_Some(v35) => {
                let mut v35: num_complex::Complex<f64> = v35.clone();
                v35.clone()
            }
        };
        let mut v39: f64 = v37.re;
        let mut v40: f64 = -(v39);
        let mut v41: bool = v39 >= v40;
        let mut v42: f64 = if v41 {
            v39
        } else {
            v40
        };
        let mut v43: bool = v42 < 0.0001f64;
        let mut v45: bool = if v43 {
            true
        } else {
            method21(v43)
        };
        let mut v79: Rc<str> = if v43 {
            let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v47: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v48: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
            let mut v52: f64 = 0.0001f64;
            let mut v53: Rc<str> = format_real_22(v52);
            let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v53));
            let mut v55: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v56: Rc<str> = Rc::<str>::from(format!("{}{}", v55, v54));
            let mut v57: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v58: Rc<str> = Rc::<str>::from(format!("{}{}", v56, v57));
            v58.clone()
        } else {
            let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v61: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v62: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v63: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v64: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
            let mut v65: Rc<str> = format_real_22(v42);
            let mut v66: Rc<str> = Rc::<str>::from(format!("{}{}", v64, v65));
            let mut v67: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
            let mut v68: Rc<str> = Rc::<str>::from(format!("{}{}", v66, v67));
            let mut v69: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v70: Rc<str> = Rc::<str>::from(format!("{}{}", v68, v69));
            let mut v71: Rc<str> = Rc::<str>::from(format!("{}{}", v70, v63));
            let mut v72: f64 = 0.0001f64;
            let mut v73: Rc<str> = format_real_22(v72);
            let mut v74: Rc<str> = Rc::<str>::from(format!("{}{}", v71, v73));
            let mut v75: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v76: Rc<str> = Rc::<str>::from(format!("{}{}", v75, v74));
            let mut v77: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v78: Rc<str> = Rc::<str>::from(format!("{}{}", v76, v77));
            v78.clone()
        };
        let mut v80: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt"); } LIT.with(|lit| lit.clone()) };
        let mut v81: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
        let mut v82: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
        let mut v116: Rc<str> = if v43 {
            let mut v83: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v84: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v85: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v86: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v87: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v88: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
            let mut v89: f64 = 0.0001f64;
            let mut v90: Rc<str> = format_real_22(v89);
            let mut v91: Rc<str> = Rc::<str>::from(format!("{}{}", v88, v90));
            let mut v92: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v93: Rc<str> = Rc::<str>::from(format!("{}{}", v92, v91));
            let mut v94: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v95: Rc<str> = Rc::<str>::from(format!("{}{}", v93, v94));
            v95.clone()
        } else {
            let mut v96: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v97: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v98: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v99: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v100: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v101: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
            let mut v102: Rc<str> = format_real_22(v42);
            let mut v103: Rc<str> = Rc::<str>::from(format!("{}{}", v101, v102));
            let mut v104: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
            let mut v105: Rc<str> = Rc::<str>::from(format!("{}{}", v103, v104));
            let mut v106: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v107: Rc<str> = Rc::<str>::from(format!("{}{}", v105, v106));
            let mut v108: Rc<str> = Rc::<str>::from(format!("{}{}", v107, v100));
            let mut v109: f64 = 0.0001f64;
            let mut v110: Rc<str> = format_real_22(v109);
            let mut v111: Rc<str> = Rc::<str>::from(format!("{}{}", v108, v110));
            let mut v112: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v113: Rc<str> = Rc::<str>::from(format!("{}{}", v112, v111));
            let mut v114: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v115: Rc<str> = Rc::<str>::from(format!("{}{}", v113, v114));
            v115.clone()
        };
        let mut v117: Rc<str> = Rc::<str>::from(format!("{}{}", v82, v116));
        println!("{}", v117);
        let mut v118: bool = v45 == false;
        if v118 {
            std::panic::panic_any::<std::string::String>(format!("{}", v117.clone()))
        };
        let mut v120: f64 = v37.im;
        let mut v121: f64 = -(v120);
        let mut v122: bool = v120 >= v121;
        let mut v123: f64 = if v122 {
            v120
        } else {
            v121
        };
        let mut v124: bool = v123 < 0.0001f64;
        let mut v126: bool = if v124 {
            true
        } else {
            method21(v124)
        };
        let mut v160: Rc<str> = if v124 {
            let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v128: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v129: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v130: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v131: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v132: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
            let mut v133: f64 = 0.0001f64;
            let mut v134: Rc<str> = format_real_22(v133);
            let mut v135: Rc<str> = Rc::<str>::from(format!("{}{}", v132, v134));
            let mut v136: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136, v135));
            let mut v138: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v139: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v138));
            v139.clone()
        } else {
            let mut v140: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v141: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v142: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v143: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v144: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v145: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
            let mut v146: Rc<str> = format_real_22(v123);
            let mut v147: Rc<str> = Rc::<str>::from(format!("{}{}", v145, v146));
            let mut v148: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
            let mut v149: Rc<str> = Rc::<str>::from(format!("{}{}", v147, v148));
            let mut v150: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v151: Rc<str> = Rc::<str>::from(format!("{}{}", v149, v150));
            let mut v152: Rc<str> = Rc::<str>::from(format!("{}{}", v151, v144));
            let mut v153: f64 = 0.0001f64;
            let mut v154: Rc<str> = format_real_22(v153);
            let mut v155: Rc<str> = Rc::<str>::from(format!("{}{}", v152, v154));
            let mut v156: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v157: Rc<str> = Rc::<str>::from(format!("{}{}", v156, v155));
            let mut v158: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v159: Rc<str> = Rc::<str>::from(format!("{}{}", v157, v158));
            v159.clone()
        };
        let mut v161: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
        let mut v195: Rc<str> = if v124 {
            let mut v162: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v163: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v164: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v165: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v166: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v167: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
            let mut v168: f64 = 0.0001f64;
            let mut v169: Rc<str> = format_real_22(v168);
            let mut v170: Rc<str> = Rc::<str>::from(format!("{}{}", v167, v169));
            let mut v171: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v172: Rc<str> = Rc::<str>::from(format!("{}{}", v171, v170));
            let mut v173: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v174: Rc<str> = Rc::<str>::from(format!("{}{}", v172, v173));
            v174.clone()
        } else {
            let mut v175: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v176: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v177: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v178: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v179: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v180: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
            let mut v181: Rc<str> = format_real_22(v123);
            let mut v182: Rc<str> = Rc::<str>::from(format!("{}{}", v180, v181));
            let mut v183: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
            let mut v184: Rc<str> = Rc::<str>::from(format!("{}{}", v182, v183));
            let mut v185: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v186: Rc<str> = Rc::<str>::from(format!("{}{}", v184, v185));
            let mut v187: Rc<str> = Rc::<str>::from(format!("{}{}", v186, v179));
            let mut v188: f64 = 0.0001f64;
            let mut v189: Rc<str> = format_real_22(v188);
            let mut v190: Rc<str> = Rc::<str>::from(format!("{}{}", v187, v189));
            let mut v191: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v192: Rc<str> = Rc::<str>::from(format!("{}{}", v191, v190));
            let mut v193: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v194: Rc<str> = Rc::<str>::from(format!("{}{}", v192, v193));
            v194.clone()
        };
        let mut v196: Rc<str> = Rc::<str>::from(format!("{}{}", v161, v195));
        println!("{}", v196);
        let mut v197: bool = v126 == false;
        if v197 {
            std::panic::panic_any::<std::string::String>(format!("{}", v196.clone()))
        };
        let mut v198: i32 = v17.wrapping_add(1i32);
        v15.borrow_mut().l0 = v198;
        ()
    };
    ()
}
fn method30() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method31(v3.clone());
    let mut v4: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v5: bool = true; (v4) }); //;
    let mut v7: Result<(), pyo3::PyErr> = __run_test;
    v7.unwrap();
    ()
}
fn method33(mut v0: pyo3::Python) -> () {
    let mut v1: Rc<RefCell<Vec<f64>>> = Rc::new(RefCell::new(vec![2.0f64, 3.0f64, 4.0f64, 5.0f64, 10.0f64, 20.0f64, 50.0f64]));
    let mut v2: i32 = (v1.clone().borrow().len() as i32);
    let mut v3: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 0i32 }));
    while method3(v2, v3.clone()) {
        let mut v5: i32 = v3.borrow().l0.clone();
        let mut v6: f64 = v1.clone().borrow()[v5 as usize].clone();
        let mut v8: num_complex::Complex<f64> = num_complex::Complex::new(v6, 0.0f64);
        let mut v9: num_complex::Complex<f64> = method4(v8.clone());
        let mut v10: Result<num_complex::Complex<f64>, std::string::String> = method5(v0.clone(), v9.clone());
        let mut v11: num_complex::Complex<f64> = method16(v0.clone(), v8.clone());
        let mut v13: Option<num_complex::Complex<f64>> = v10.ok();
        let mut v14: Option<num_complex::Complex<f64>> = method20(v13.clone());
        let mut v15: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = closure0();
        let mut v16: Option<US0> = v14.map(|x| v15(x));
        let mut v17: US0 = US0::US0_None;
        let mut v18: US0 = v16.unwrap_or(v17);
        let mut v20: f64 = f64::NAN;
        let mut v22: f64 = f64::NAN;
        let mut v24: num_complex::Complex<f64> = num_complex::Complex::new(v20, v22);
        let mut v27: num_complex::Complex<f64> = match &v18 {
            US0::US0_None => {
                v24.clone()
            }
            US0::US0_Some(v25) => {
                let mut v25: num_complex::Complex<f64> = v25.clone();
                v25.clone()
            }
        };
        let mut v29: f64 = v27.re;
        let mut v30: bool = v29 > 0.0f64;
        let mut v32: bool = if v30 {
            true
        } else {
            method21(v30)
        };
        let mut v66: Rc<str> = if v30 {
            let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
            let mut v39: f64 = 0.0f64;
            let mut v40: Rc<str> = format_real_22(v39);
            let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v40));
            let mut v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v42, v41));
            let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v44));
            v45.clone()
        } else {
            let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v47: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v48: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
            let mut v52: Rc<str> = format_real_22(v29);
            let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
            let mut v54: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
            let mut v55: Rc<str> = Rc::<str>::from(format!("{}{}", v53, v54));
            let mut v56: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", v55, v56));
            let mut v58: Rc<str> = Rc::<str>::from(format!("{}{}", v57, v50));
            let mut v59: f64 = 0.0f64;
            let mut v60: Rc<str> = format_real_22(v59);
            let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v60));
            let mut v62: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, v61));
            let mut v64: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v65: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v64));
            v65.clone()
        };
        let mut v67: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_gt"); } LIT.with(|lit| lit.clone()) };
        let mut v68: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
        let mut v69: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_gt "); } LIT.with(|lit| lit.clone()) };
        let mut v103: Rc<str> = if v30 {
            let mut v70: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v71: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v73: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v74: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v75: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
            let mut v76: f64 = 0.0f64;
            let mut v77: Rc<str> = format_real_22(v76);
            let mut v78: Rc<str> = Rc::<str>::from(format!("{}{}", v75, v77));
            let mut v79: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v80: Rc<str> = Rc::<str>::from(format!("{}{}", v79, v78));
            let mut v81: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v82: Rc<str> = Rc::<str>::from(format!("{}{}", v80, v81));
            v82.clone()
        } else {
            let mut v83: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v84: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v85: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v86: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v87: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v88: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
            let mut v89: Rc<str> = format_real_22(v29);
            let mut v90: Rc<str> = Rc::<str>::from(format!("{}{}", v88, v89));
            let mut v91: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
            let mut v92: Rc<str> = Rc::<str>::from(format!("{}{}", v90, v91));
            let mut v93: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v94: Rc<str> = Rc::<str>::from(format!("{}{}", v92, v93));
            let mut v95: Rc<str> = Rc::<str>::from(format!("{}{}", v94, v87));
            let mut v96: f64 = 0.0f64;
            let mut v97: Rc<str> = format_real_22(v96);
            let mut v98: Rc<str> = Rc::<str>::from(format!("{}{}", v95, v97));
            let mut v99: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v100: Rc<str> = Rc::<str>::from(format!("{}{}", v99, v98));
            let mut v101: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v102: Rc<str> = Rc::<str>::from(format!("{}{}", v100, v101));
            v102.clone()
        };
        let mut v104: Rc<str> = Rc::<str>::from(format!("{}{}", v69, v103));
        println!("{}", v104);
        let mut v105: bool = v32 == false;
        if v105 {
            std::panic::panic_any::<std::string::String>(format!("{}", v104.clone()))
        };
        let mut v107: f64 = v27.im;
        let mut v108: bool = v107 == 0.0f64;
        let mut v110: bool = if v108 {
            true
        } else {
            method21(v108)
        };
        let mut v144: Rc<str> = if v108 {
            let mut v111: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v112: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v113: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v114: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v115: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v116: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
            let mut v117: f64 = 0.0f64;
            let mut v118: Rc<str> = format_real_22(v117);
            let mut v119: Rc<str> = Rc::<str>::from(format!("{}{}", v116, v118));
            let mut v120: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v121: Rc<str> = Rc::<str>::from(format!("{}{}", v120, v119));
            let mut v122: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v123: Rc<str> = Rc::<str>::from(format!("{}{}", v121, v122));
            v123.clone()
        } else {
            let mut v124: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v125: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v126: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v128: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v129: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
            let mut v130: Rc<str> = format_real_22(v107);
            let mut v131: Rc<str> = Rc::<str>::from(format!("{}{}", v129, v130));
            let mut v132: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
            let mut v133: Rc<str> = Rc::<str>::from(format!("{}{}", v131, v132));
            let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v135: Rc<str> = Rc::<str>::from(format!("{}{}", v133, v134));
            let mut v136: Rc<str> = Rc::<str>::from(format!("{}{}", v135, v128));
            let mut v137: f64 = 0.0f64;
            let mut v138: Rc<str> = format_real_22(v137);
            let mut v139: Rc<str> = Rc::<str>::from(format!("{}{}", v136, v138));
            let mut v140: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v141: Rc<str> = Rc::<str>::from(format!("{}{}", v140, v139));
            let mut v142: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v143: Rc<str> = Rc::<str>::from(format!("{}{}", v141, v142));
            v143.clone()
        };
        let mut v145: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq"); } LIT.with(|lit| lit.clone()) };
        let mut v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
        let mut v180: Rc<str> = if v108 {
            let mut v147: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v148: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v149: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v150: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v151: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v152: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
            let mut v153: f64 = 0.0f64;
            let mut v154: Rc<str> = format_real_22(v153);
            let mut v155: Rc<str> = Rc::<str>::from(format!("{}{}", v152, v154));
            let mut v156: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v157: Rc<str> = Rc::<str>::from(format!("{}{}", v156, v155));
            let mut v158: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v159: Rc<str> = Rc::<str>::from(format!("{}{}", v157, v158));
            v159.clone()
        } else {
            let mut v160: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v161: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v162: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v163: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
            let mut v164: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
            let mut v165: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
            let mut v166: Rc<str> = format_real_22(v107);
            let mut v167: Rc<str> = Rc::<str>::from(format!("{}{}", v165, v166));
            let mut v168: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
            let mut v169: Rc<str> = Rc::<str>::from(format!("{}{}", v167, v168));
            let mut v170: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
            let mut v171: Rc<str> = Rc::<str>::from(format!("{}{}", v169, v170));
            let mut v172: Rc<str> = Rc::<str>::from(format!("{}{}", v171, v164));
            let mut v173: f64 = 0.0f64;
            let mut v174: Rc<str> = format_real_22(v173);
            let mut v175: Rc<str> = Rc::<str>::from(format!("{}{}", v172, v174));
            let mut v176: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
            let mut v177: Rc<str> = Rc::<str>::from(format!("{}{}", v176, v175));
            let mut v178: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
            let mut v179: Rc<str> = Rc::<str>::from(format!("{}{}", v177, v178));
            v179.clone()
        };
        let mut v181: Rc<str> = Rc::<str>::from(format!("{}{}", v146, v180));
        println!("{}", v181);
        let mut v182: bool = v110 == false;
        if v182 {
            std::panic::panic_any::<std::string::String>(format!("{}", v181.clone()))
        };
        let mut v183: i32 = v5.wrapping_add(1i32);
        v3.borrow_mut().l0 = v183;
        ()
    };
    ()
}
fn method32() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method33(v3.clone());
    let mut v4: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v5: bool = true; (v4) }); //;
    let mut v7: Result<(), pyo3::PyErr> = __run_test;
    v7.unwrap();
    ()
}
fn method35(mut v0: pyo3::Python) -> () {
    let mut v2: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
    let mut v3: num_complex::Complex<f64> = method4(v2.clone());
    let mut v4: Result<num_complex::Complex<f64>, std::string::String> = method5(v0.clone(), v3.clone());
    let mut v5: num_complex::Complex<f64> = method16(v0.clone(), v2.clone());
    let mut v7: Option<num_complex::Complex<f64>> = v4.ok();
    let mut v8: Option<num_complex::Complex<f64>> = method20(v7.clone());
    let mut v9: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = closure0();
    let mut v10: Option<US0> = v8.map(|x| v9(x));
    let mut v11: US0 = US0::US0_None;
    let mut v12: US0 = v10.unwrap_or(v11);
    let mut v14: f64 = f64::NAN;
    let mut v16: f64 = f64::NAN;
    let mut v18: num_complex::Complex<f64> = num_complex::Complex::new(v14, v16);
    let mut v21: num_complex::Complex<f64> = match &v12 {
        US0::US0_None => {
            v18.clone()
        }
        US0::US0_Some(v19) => {
            let mut v19: num_complex::Complex<f64> = v19.clone();
            v19.clone()
        }
    };
    let mut v23: f64 = v21.re;
    let mut v24: bool = v23 == f64::INFINITY;
    let mut v26: bool = if v24 {
        true
    } else {
        method21(v24)
    };
    let mut v60: Rc<str> = if v24 {
        let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v33: f64 = f64::INFINITY;
        let mut v34: Rc<str> = format_real_22(v33);
        let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v34));
        let mut v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v35));
        let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
        v39.clone()
    } else {
        let mut v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
        let mut v46: Rc<str> = format_real_22(v23);
        let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v45, v46));
        let mut v48: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
        let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v49, v50));
        let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v44));
        let mut v53: f64 = f64::INFINITY;
        let mut v54: Rc<str> = format_real_22(v53);
        let mut v55: Rc<str> = Rc::<str>::from(format!("{}{}", v52, v54));
        let mut v56: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", v56, v55));
        let mut v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v57, v58));
        v59.clone()
    };
    let mut v61: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq"); } LIT.with(|lit| lit.clone()) };
    let mut v62: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v63: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
    let mut v97: Rc<str> = if v24 {
        let mut v64: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v65: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v67: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v68: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v69: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v70: f64 = f64::INFINITY;
        let mut v71: Rc<str> = format_real_22(v70);
        let mut v72: Rc<str> = Rc::<str>::from(format!("{}{}", v69, v71));
        let mut v73: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v74: Rc<str> = Rc::<str>::from(format!("{}{}", v73, v72));
        let mut v75: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v76: Rc<str> = Rc::<str>::from(format!("{}{}", v74, v75));
        v76.clone()
    } else {
        let mut v77: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v78: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v79: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v80: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v81: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v82: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
        let mut v83: Rc<str> = format_real_22(v23);
        let mut v84: Rc<str> = Rc::<str>::from(format!("{}{}", v82, v83));
        let mut v85: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v86: Rc<str> = Rc::<str>::from(format!("{}{}", v84, v85));
        let mut v87: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v88: Rc<str> = Rc::<str>::from(format!("{}{}", v86, v87));
        let mut v89: Rc<str> = Rc::<str>::from(format!("{}{}", v88, v81));
        let mut v90: f64 = f64::INFINITY;
        let mut v91: Rc<str> = format_real_22(v90);
        let mut v92: Rc<str> = Rc::<str>::from(format!("{}{}", v89, v91));
        let mut v93: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v94: Rc<str> = Rc::<str>::from(format!("{}{}", v93, v92));
        let mut v95: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v96: Rc<str> = Rc::<str>::from(format!("{}{}", v94, v95));
        v96.clone()
    };
    let mut v98: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v97));
    println!("{}", v98);
    let mut v99: bool = v26 == false;
    if v99 {
        std::panic::panic_any::<std::string::String>(format!("{}", v98.clone()))
    };
    let mut v101: f64 = v21.im;
    let mut v102: bool = v101 == 0.0f64;
    let mut v104: bool = if v102 {
        true
    } else {
        method21(v102)
    };
    let mut v138: Rc<str> = if v102 {
        let mut v105: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v106: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v107: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v108: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v109: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v110: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v111: f64 = 0.0f64;
        let mut v112: Rc<str> = format_real_22(v111);
        let mut v113: Rc<str> = Rc::<str>::from(format!("{}{}", v110, v112));
        let mut v114: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v115: Rc<str> = Rc::<str>::from(format!("{}{}", v114, v113));
        let mut v116: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v117: Rc<str> = Rc::<str>::from(format!("{}{}", v115, v116));
        v117.clone()
    } else {
        let mut v118: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v119: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v120: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v121: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v122: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v123: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
        let mut v124: Rc<str> = format_real_22(v101);
        let mut v125: Rc<str> = Rc::<str>::from(format!("{}{}", v123, v124));
        let mut v126: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v127: Rc<str> = Rc::<str>::from(format!("{}{}", v125, v126));
        let mut v128: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v127, v128));
        let mut v130: Rc<str> = Rc::<str>::from(format!("{}{}", v129, v122));
        let mut v131: f64 = 0.0f64;
        let mut v132: Rc<str> = format_real_22(v131);
        let mut v133: Rc<str> = Rc::<str>::from(format!("{}{}", v130, v132));
        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v135: Rc<str> = Rc::<str>::from(format!("{}{}", v134, v133));
        let mut v136: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v137: Rc<str> = Rc::<str>::from(format!("{}{}", v135, v136));
        v137.clone()
    };
    let mut v139: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
    let mut v173: Rc<str> = if v102 {
        let mut v140: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v141: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v142: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v143: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v144: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v145: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v146: f64 = 0.0f64;
        let mut v147: Rc<str> = format_real_22(v146);
        let mut v148: Rc<str> = Rc::<str>::from(format!("{}{}", v145, v147));
        let mut v149: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v150: Rc<str> = Rc::<str>::from(format!("{}{}", v149, v148));
        let mut v151: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v152: Rc<str> = Rc::<str>::from(format!("{}{}", v150, v151));
        v152.clone()
    } else {
        let mut v153: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v154: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v155: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v156: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v157: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v158: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
        let mut v159: Rc<str> = format_real_22(v101);
        let mut v160: Rc<str> = Rc::<str>::from(format!("{}{}", v158, v159));
        let mut v161: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v162: Rc<str> = Rc::<str>::from(format!("{}{}", v160, v161));
        let mut v163: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v164: Rc<str> = Rc::<str>::from(format!("{}{}", v162, v163));
        let mut v165: Rc<str> = Rc::<str>::from(format!("{}{}", v164, v157));
        let mut v166: f64 = 0.0f64;
        let mut v167: Rc<str> = format_real_22(v166);
        let mut v168: Rc<str> = Rc::<str>::from(format!("{}{}", v165, v167));
        let mut v169: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v170: Rc<str> = Rc::<str>::from(format!("{}{}", v169, v168));
        let mut v171: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v172: Rc<str> = Rc::<str>::from(format!("{}{}", v170, v171));
        v172.clone()
    };
    let mut v174: Rc<str> = Rc::<str>::from(format!("{}{}", v139, v173));
    println!("{}", v174);
    let mut v175: bool = v104 == false;
    if v175 {
        std::panic::panic_any::<std::string::String>(format!("{}", v174.clone()))
    }
}
fn method34() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method35(v3.clone());
    let mut v4: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v5: bool = true; (v4) }); //;
    let mut v7: Result<(), pyo3::PyErr> = __run_test;
    v7.unwrap();
    ()
}
fn method37(mut v0: pyo3::Python) -> () {
    let mut v2: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 10.0f64);
    let mut v3: num_complex::Complex<f64> = method4(v2.clone());
    let mut v4: Result<num_complex::Complex<f64>, std::string::String> = method5(v0.clone(), v3.clone());
    let mut v5: num_complex::Complex<f64> = method16(v0.clone(), v2.clone());
    let mut v7: Option<num_complex::Complex<f64>> = v4.ok();
    let mut v8: Option<num_complex::Complex<f64>> = method20(v7.clone());
    let mut v9: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = closure0();
    let mut v10: Option<US0> = v8.map(|x| v9(x));
    let mut v11: US0 = US0::US0_None;
    let mut v12: US0 = v10.unwrap_or(v11);
    let mut v14: f64 = f64::NAN;
    let mut v16: f64 = f64::NAN;
    let mut v18: num_complex::Complex<f64> = num_complex::Complex::new(v14, v16);
    let mut v21: num_complex::Complex<f64> = match &v12 {
        US0::US0_None => {
            v18.clone()
        }
        US0::US0_Some(v19) => {
            let mut v19: num_complex::Complex<f64> = v19.clone();
            v19.clone()
        }
    };
    let mut v23: f64 = v2.re;
    let mut v25: f64 = v2.im;
    let mut v26: f64 = -(v25);
    let mut v28: num_complex::Complex<f64> = num_complex::Complex::new(v23, v26);
    let mut v29: num_complex::Complex<f64> = method4(v28.clone());
    let mut v30: Result<num_complex::Complex<f64>, std::string::String> = method5(v0.clone(), v29.clone());
    let mut v31: num_complex::Complex<f64> = method16(v0.clone(), v28.clone());
    let mut v33: Option<num_complex::Complex<f64>> = v30.ok();
    let mut v34: Option<num_complex::Complex<f64>> = method20(v33.clone());
    let mut v35: Option<US0> = v34.map(|x| v9(x));
    let mut v36: US0 = US0::US0_None;
    let mut v37: US0 = v35.unwrap_or(v36);
    let mut v39: f64 = f64::NAN;
    let mut v41: f64 = f64::NAN;
    let mut v43: num_complex::Complex<f64> = num_complex::Complex::new(v39, v41);
    let mut v46: num_complex::Complex<f64> = match &v37 {
        US0::US0_None => {
            v43.clone()
        }
        US0::US0_Some(v44) => {
            let mut v44: num_complex::Complex<f64> = v44.clone();
            v44.clone()
        }
    };
    let mut v48: num_complex::Complex<f64> = v46.conj();
    let mut v50: f64 = v21.re;
    let mut v52: f64 = v48.re;
    let mut v53: bool = v50 == v52;
    let mut v55: bool = if v53 {
        true
    } else {
        method21(v53)
    };
    let mut v87: Rc<str> = if v53 {
        let mut v56: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v57: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v61: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v62: Rc<str> = format_real_22(v52);
        let mut v63: Rc<str> = Rc::<str>::from(format!("{}{}", v61, v62));
        let mut v64: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v65: Rc<str> = Rc::<str>::from(format!("{}{}", v64, v63));
        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v67: Rc<str> = Rc::<str>::from(format!("{}{}", v65, v66));
        v67.clone()
    } else {
        let mut v68: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v69: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v70: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v71: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v73: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
        let mut v74: Rc<str> = format_real_22(v50);
        let mut v75: Rc<str> = Rc::<str>::from(format!("{}{}", v73, v74));
        let mut v76: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v77: Rc<str> = Rc::<str>::from(format!("{}{}", v75, v76));
        let mut v78: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v79: Rc<str> = Rc::<str>::from(format!("{}{}", v77, v78));
        let mut v80: Rc<str> = Rc::<str>::from(format!("{}{}", v79, v72));
        let mut v81: Rc<str> = format_real_22(v52);
        let mut v82: Rc<str> = Rc::<str>::from(format!("{}{}", v80, v81));
        let mut v83: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v84: Rc<str> = Rc::<str>::from(format!("{}{}", v83, v82));
        let mut v85: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v86: Rc<str> = Rc::<str>::from(format!("{}{}", v84, v85));
        v86.clone()
    };
    let mut v88: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq"); } LIT.with(|lit| lit.clone()) };
    let mut v89: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v90: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
    let mut v122: Rc<str> = if v53 {
        let mut v91: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v92: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v93: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v94: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v95: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v96: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v97: Rc<str> = format_real_22(v52);
        let mut v98: Rc<str> = Rc::<str>::from(format!("{}{}", v96, v97));
        let mut v99: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v100: Rc<str> = Rc::<str>::from(format!("{}{}", v99, v98));
        let mut v101: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v102: Rc<str> = Rc::<str>::from(format!("{}{}", v100, v101));
        v102.clone()
    } else {
        let mut v103: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v104: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v105: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v106: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v107: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v108: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
        let mut v109: Rc<str> = format_real_22(v50);
        let mut v110: Rc<str> = Rc::<str>::from(format!("{}{}", v108, v109));
        let mut v111: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v112: Rc<str> = Rc::<str>::from(format!("{}{}", v110, v111));
        let mut v113: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v114: Rc<str> = Rc::<str>::from(format!("{}{}", v112, v113));
        let mut v115: Rc<str> = Rc::<str>::from(format!("{}{}", v114, v107));
        let mut v116: Rc<str> = format_real_22(v52);
        let mut v117: Rc<str> = Rc::<str>::from(format!("{}{}", v115, v116));
        let mut v118: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v119: Rc<str> = Rc::<str>::from(format!("{}{}", v118, v117));
        let mut v120: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v121: Rc<str> = Rc::<str>::from(format!("{}{}", v119, v120));
        v121.clone()
    };
    let mut v123: Rc<str> = Rc::<str>::from(format!("{}{}", v90, v122));
    println!("{}", v123);
    let mut v124: bool = v55 == false;
    if v124 {
        std::panic::panic_any::<std::string::String>(format!("{}", v123.clone()))
    };
    let mut v126: f64 = v21.im;
    let mut v128: f64 = v48.im;
    let mut v129: bool = v126 == v128;
    let mut v131: bool = if v129 {
        true
    } else {
        method21(v129)
    };
    let mut v163: Rc<str> = if v129 {
        let mut v132: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v133: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v135: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v136: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v137: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v138: Rc<str> = format_real_22(v128);
        let mut v139: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v138));
        let mut v140: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v141: Rc<str> = Rc::<str>::from(format!("{}{}", v140, v139));
        let mut v142: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v143: Rc<str> = Rc::<str>::from(format!("{}{}", v141, v142));
        v143.clone()
    } else {
        let mut v144: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v145: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v147: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v148: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v149: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
        let mut v150: Rc<str> = format_real_22(v126);
        let mut v151: Rc<str> = Rc::<str>::from(format!("{}{}", v149, v150));
        let mut v152: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v153: Rc<str> = Rc::<str>::from(format!("{}{}", v151, v152));
        let mut v154: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v155: Rc<str> = Rc::<str>::from(format!("{}{}", v153, v154));
        let mut v156: Rc<str> = Rc::<str>::from(format!("{}{}", v155, v148));
        let mut v157: Rc<str> = format_real_22(v128);
        let mut v158: Rc<str> = Rc::<str>::from(format!("{}{}", v156, v157));
        let mut v159: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v160: Rc<str> = Rc::<str>::from(format!("{}{}", v159, v158));
        let mut v161: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v162: Rc<str> = Rc::<str>::from(format!("{}{}", v160, v161));
        v162.clone()
    };
    let mut v164: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
    let mut v196: Rc<str> = if v129 {
        let mut v165: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v166: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v167: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v168: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v169: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v170: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v171: Rc<str> = format_real_22(v128);
        let mut v172: Rc<str> = Rc::<str>::from(format!("{}{}", v170, v171));
        let mut v173: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v174: Rc<str> = Rc::<str>::from(format!("{}{}", v173, v172));
        let mut v175: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v176: Rc<str> = Rc::<str>::from(format!("{}{}", v174, v175));
        v176.clone()
    } else {
        let mut v177: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v178: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v179: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v180: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v181: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v182: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
        let mut v183: Rc<str> = format_real_22(v126);
        let mut v184: Rc<str> = Rc::<str>::from(format!("{}{}", v182, v183));
        let mut v185: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v186: Rc<str> = Rc::<str>::from(format!("{}{}", v184, v185));
        let mut v187: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v188: Rc<str> = Rc::<str>::from(format!("{}{}", v186, v187));
        let mut v189: Rc<str> = Rc::<str>::from(format!("{}{}", v188, v181));
        let mut v190: Rc<str> = format_real_22(v128);
        let mut v191: Rc<str> = Rc::<str>::from(format!("{}{}", v189, v190));
        let mut v192: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v193: Rc<str> = Rc::<str>::from(format!("{}{}", v192, v191));
        let mut v194: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v195: Rc<str> = Rc::<str>::from(format!("{}{}", v193, v194));
        v195.clone()
    };
    let mut v197: Rc<str> = Rc::<str>::from(format!("{}{}", v164, v196));
    println!("{}", v197);
    let mut v198: bool = v131 == false;
    if v198 {
        std::panic::panic_any::<std::string::String>(format!("{}", v197.clone()))
    }
}
fn method36() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method37(v3.clone());
    let mut v4: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v5: bool = true; (v4) }); //;
    let mut v7: Result<(), pyo3::PyErr> = __run_test;
    v7.unwrap();
    ()
}
fn method39(mut v0: pyo3::Python) -> () {
    let mut v2: num_complex::Complex<f64> = num_complex::Complex::new(0.01f64, 0.01f64);
    let mut v3: num_complex::Complex<f64> = method4(v2.clone());
    let mut v4: Result<num_complex::Complex<f64>, std::string::String> = method5(v0.clone(), v3.clone());
    let mut v5: num_complex::Complex<f64> = method16(v0.clone(), v2.clone());
    let mut v7: Option<num_complex::Complex<f64>> = v4.ok();
    let mut v8: Option<num_complex::Complex<f64>> = method20(v7.clone());
    let mut v9: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = closure0();
    let mut v10: Option<US0> = v8.map(|x| v9(x));
    let mut v11: US0 = US0::US0_None;
    let mut v12: US0 = v10.unwrap_or(v11);
    let mut v14: f64 = f64::NAN;
    let mut v16: f64 = f64::NAN;
    let mut v18: num_complex::Complex<f64> = num_complex::Complex::new(v14, v16);
    let mut v21: num_complex::Complex<f64> = match &v12 {
        US0::US0_None => {
            v18.clone()
        }
        US0::US0_Some(v19) => {
            let mut v19: num_complex::Complex<f64> = v19.clone();
            v19.clone()
        }
    };
    let mut v23: f64 = v21.re;
    let mut v24: bool = v23 < f64::INFINITY;
    let mut v26: bool = if v24 {
        true
    } else {
        method21(v24)
    };
    let mut v60: Rc<str> = if v24 {
        let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v33: f64 = f64::INFINITY;
        let mut v34: Rc<str> = format_real_22(v33);
        let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v34));
        let mut v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v35));
        let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v38));
        v39.clone()
    } else {
        let mut v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
        let mut v46: Rc<str> = format_real_22(v23);
        let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v45, v46));
        let mut v48: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
        let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v49, v50));
        let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v44));
        let mut v53: f64 = f64::INFINITY;
        let mut v54: Rc<str> = format_real_22(v53);
        let mut v55: Rc<str> = Rc::<str>::from(format!("{}{}", v52, v54));
        let mut v56: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", v56, v55));
        let mut v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v57, v58));
        v59.clone()
    };
    let mut v61: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt"); } LIT.with(|lit| lit.clone()) };
    let mut v62: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v63: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
    let mut v97: Rc<str> = if v24 {
        let mut v64: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v65: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v67: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v68: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v69: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v70: f64 = f64::INFINITY;
        let mut v71: Rc<str> = format_real_22(v70);
        let mut v72: Rc<str> = Rc::<str>::from(format!("{}{}", v69, v71));
        let mut v73: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v74: Rc<str> = Rc::<str>::from(format!("{}{}", v73, v72));
        let mut v75: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v76: Rc<str> = Rc::<str>::from(format!("{}{}", v74, v75));
        v76.clone()
    } else {
        let mut v77: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v78: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v79: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v80: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v81: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v82: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
        let mut v83: Rc<str> = format_real_22(v23);
        let mut v84: Rc<str> = Rc::<str>::from(format!("{}{}", v82, v83));
        let mut v85: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v86: Rc<str> = Rc::<str>::from(format!("{}{}", v84, v85));
        let mut v87: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v88: Rc<str> = Rc::<str>::from(format!("{}{}", v86, v87));
        let mut v89: Rc<str> = Rc::<str>::from(format!("{}{}", v88, v81));
        let mut v90: f64 = f64::INFINITY;
        let mut v91: Rc<str> = format_real_22(v90);
        let mut v92: Rc<str> = Rc::<str>::from(format!("{}{}", v89, v91));
        let mut v93: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v94: Rc<str> = Rc::<str>::from(format!("{}{}", v93, v92));
        let mut v95: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v96: Rc<str> = Rc::<str>::from(format!("{}{}", v94, v95));
        v96.clone()
    };
    let mut v98: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v97));
    println!("{}", v98);
    let mut v99: bool = v26 == false;
    if v99 {
        std::panic::panic_any::<std::string::String>(format!("{}", v98.clone()))
    };
    let mut v101: f64 = v21.im;
    let mut v102: bool = v101 < f64::INFINITY;
    let mut v104: bool = if v102 {
        true
    } else {
        method21(v102)
    };
    let mut v138: Rc<str> = if v102 {
        let mut v105: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v106: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v107: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v108: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v109: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v110: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v111: f64 = f64::INFINITY;
        let mut v112: Rc<str> = format_real_22(v111);
        let mut v113: Rc<str> = Rc::<str>::from(format!("{}{}", v110, v112));
        let mut v114: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v115: Rc<str> = Rc::<str>::from(format!("{}{}", v114, v113));
        let mut v116: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v117: Rc<str> = Rc::<str>::from(format!("{}{}", v115, v116));
        v117.clone()
    } else {
        let mut v118: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v119: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v120: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v121: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v122: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v123: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
        let mut v124: Rc<str> = format_real_22(v101);
        let mut v125: Rc<str> = Rc::<str>::from(format!("{}{}", v123, v124));
        let mut v126: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v127: Rc<str> = Rc::<str>::from(format!("{}{}", v125, v126));
        let mut v128: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v129: Rc<str> = Rc::<str>::from(format!("{}{}", v127, v128));
        let mut v130: Rc<str> = Rc::<str>::from(format!("{}{}", v129, v122));
        let mut v131: f64 = f64::INFINITY;
        let mut v132: Rc<str> = format_real_22(v131);
        let mut v133: Rc<str> = Rc::<str>::from(format!("{}{}", v130, v132));
        let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v135: Rc<str> = Rc::<str>::from(format!("{}{}", v134, v133));
        let mut v136: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v137: Rc<str> = Rc::<str>::from(format!("{}{}", v135, v136));
        v137.clone()
    };
    let mut v139: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
    let mut v173: Rc<str> = if v102 {
        let mut v140: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v141: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v142: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v143: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v144: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v145: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v146: f64 = f64::INFINITY;
        let mut v147: Rc<str> = format_real_22(v146);
        let mut v148: Rc<str> = Rc::<str>::from(format!("{}{}", v145, v147));
        let mut v149: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v150: Rc<str> = Rc::<str>::from(format!("{}{}", v149, v148));
        let mut v151: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v152: Rc<str> = Rc::<str>::from(format!("{}{}", v150, v151));
        v152.clone()
    } else {
        let mut v153: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v154: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v155: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v156: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
        let mut v157: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v158: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
        let mut v159: Rc<str> = format_real_22(v101);
        let mut v160: Rc<str> = Rc::<str>::from(format!("{}{}", v158, v159));
        let mut v161: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v162: Rc<str> = Rc::<str>::from(format!("{}{}", v160, v161));
        let mut v163: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v164: Rc<str> = Rc::<str>::from(format!("{}{}", v162, v163));
        let mut v165: Rc<str> = Rc::<str>::from(format!("{}{}", v164, v157));
        let mut v166: f64 = f64::INFINITY;
        let mut v167: Rc<str> = format_real_22(v166);
        let mut v168: Rc<str> = Rc::<str>::from(format!("{}{}", v165, v167));
        let mut v169: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v170: Rc<str> = Rc::<str>::from(format!("{}{}", v169, v168));
        let mut v171: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v172: Rc<str> = Rc::<str>::from(format!("{}{}", v170, v171));
        v172.clone()
    };
    let mut v174: Rc<str> = Rc::<str>::from(format!("{}{}", v139, v173));
    println!("{}", v174);
    let mut v175: bool = v104 == false;
    if v175 {
        std::panic::panic_any::<std::string::String>(format!("{}", v174.clone()))
    }
}
fn method38() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method39(v3.clone());
    let mut v4: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v5: bool = true; (v4) }); //;
    let mut v7: Result<(), pyo3::PyErr> = __run_test;
    v7.unwrap();
    ()
}
fn method42(mut v0: pyo3::Python, mut v1: Rc<UH0>) -> () {
    loop {
        match &*v1 {
            UH0::UH0_Cons(v2, v3) => {
                let mut v2: f64 = *v2;
                let mut v3: Rc<UH0> = v3.clone();
                let mut v5: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, v2);
                let mut v6: num_complex::Complex<f64> = method4(v5.clone());
                let mut v7: Result<num_complex::Complex<f64>, std::string::String> = method5(v0.clone(), v6.clone());
                let mut v8: num_complex::Complex<f64> = method16(v0.clone(), v5.clone());
                let mut v10: Option<num_complex::Complex<f64>> = v7.ok();
                let mut v11: Option<num_complex::Complex<f64>> = method20(v10.clone());
                let mut v12: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = closure0();
                let mut v13: Option<US0> = v11.map(|x| v12(x));
                let mut v14: US0 = US0::US0_None;
                let mut v15: US0 = v13.unwrap_or(v14);
                let mut v17: f64 = f64::NAN;
                let mut v19: f64 = f64::NAN;
                let mut v21: num_complex::Complex<f64> = num_complex::Complex::new(v17, v19);
                let mut v24: num_complex::Complex<f64> = match &v15 {
                    US0::US0_None => {
                        v21.clone()
                    }
                    US0::US0_Some(v22) => {
                        let mut v22: num_complex::Complex<f64> = v22.clone();
                        v22.clone()
                    }
                };
                let mut v26: f64 = v24.re;
                let mut v27: bool = v26 != 0.0f64 ;
                let mut v29: bool = if v27 {
                    true
                } else {
                    method21(v27)
                };
                let mut v63: Rc<str> = if v27 {
                    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
                    let mut v36: f64 = 0.0f64;
                    let mut v37: Rc<str> = format_real_22(v36);
                    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v37));
                    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v38));
                    let mut v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
                    v42.clone()
                } else {
                    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v47: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v48: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
                    let mut v49: Rc<str> = format_real_22(v26);
                    let mut v50: Rc<str> = Rc::<str>::from(format!("{}{}", v48, v49));
                    let mut v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
                    let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v51));
                    let mut v53: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v52, v53));
                    let mut v55: Rc<str> = Rc::<str>::from(format!("{}{}", v54, v47));
                    let mut v56: f64 = 0.0f64;
                    let mut v57: Rc<str> = format_real_22(v56);
                    let mut v58: Rc<str> = Rc::<str>::from(format!("{}{}", v55, v57));
                    let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v59, v58));
                    let mut v61: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v62: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v61));
                    v62.clone()
                };
                let mut v64: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_ne"); } LIT.with(|lit| lit.clone()) };
                let mut v65: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
                let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_ne "); } LIT.with(|lit| lit.clone()) };
                let mut v100: Rc<str> = if v27 {
                    let mut v67: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v68: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v69: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v70: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v71: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
                    let mut v73: f64 = 0.0f64;
                    let mut v74: Rc<str> = format_real_22(v73);
                    let mut v75: Rc<str> = Rc::<str>::from(format!("{}{}", v72, v74));
                    let mut v76: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v77: Rc<str> = Rc::<str>::from(format!("{}{}", v76, v75));
                    let mut v78: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v79: Rc<str> = Rc::<str>::from(format!("{}{}", v77, v78));
                    v79.clone()
                } else {
                    let mut v80: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v81: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v82: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v83: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v84: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v85: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
                    let mut v86: Rc<str> = format_real_22(v26);
                    let mut v87: Rc<str> = Rc::<str>::from(format!("{}{}", v85, v86));
                    let mut v88: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
                    let mut v89: Rc<str> = Rc::<str>::from(format!("{}{}", v87, v88));
                    let mut v90: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v91: Rc<str> = Rc::<str>::from(format!("{}{}", v89, v90));
                    let mut v92: Rc<str> = Rc::<str>::from(format!("{}{}", v91, v84));
                    let mut v93: f64 = 0.0f64;
                    let mut v94: Rc<str> = format_real_22(v93);
                    let mut v95: Rc<str> = Rc::<str>::from(format!("{}{}", v92, v94));
                    let mut v96: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v97: Rc<str> = Rc::<str>::from(format!("{}{}", v96, v95));
                    let mut v98: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v99: Rc<str> = Rc::<str>::from(format!("{}{}", v97, v98));
                    v99.clone()
                };
                let mut v101: Rc<str> = Rc::<str>::from(format!("{}{}", v66, v100));
                println!("{}", v101);
                let mut v102: bool = v29 == false;
                if v102 {
                    std::panic::panic_any::<std::string::String>(format!("{}", v101.clone()))
                };
                let mut v104: f64 = v24.im;
                let mut v105: bool = v104 != 0.0f64 ;
                let mut v107: bool = if v105 {
                    true
                } else {
                    method21(v105)
                };
                let mut v141: Rc<str> = if v105 {
                    let mut v108: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v109: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v110: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v111: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v112: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v113: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
                    let mut v114: f64 = 0.0f64;
                    let mut v115: Rc<str> = format_real_22(v114);
                    let mut v116: Rc<str> = Rc::<str>::from(format!("{}{}", v113, v115));
                    let mut v117: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v118: Rc<str> = Rc::<str>::from(format!("{}{}", v117, v116));
                    let mut v119: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v120: Rc<str> = Rc::<str>::from(format!("{}{}", v118, v119));
                    v120.clone()
                } else {
                    let mut v121: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v122: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v123: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v124: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v125: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v126: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
                    let mut v127: Rc<str> = format_real_22(v104);
                    let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                    let mut v129: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
                    let mut v130: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v129));
                    let mut v131: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v132: Rc<str> = Rc::<str>::from(format!("{}{}", v130, v131));
                    let mut v133: Rc<str> = Rc::<str>::from(format!("{}{}", v132, v125));
                    let mut v134: f64 = 0.0f64;
                    let mut v135: Rc<str> = format_real_22(v134);
                    let mut v136: Rc<str> = Rc::<str>::from(format!("{}{}", v133, v135));
                    let mut v137: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v136));
                    let mut v139: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v140: Rc<str> = Rc::<str>::from(format!("{}{}", v138, v139));
                    v140.clone()
                };
                let mut v142: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_ne "); } LIT.with(|lit| lit.clone()) };
                let mut v176: Rc<str> = if v105 {
                    let mut v143: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v144: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v145: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v147: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v148: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
                    let mut v149: f64 = 0.0f64;
                    let mut v150: Rc<str> = format_real_22(v149);
                    let mut v151: Rc<str> = Rc::<str>::from(format!("{}{}", v148, v150));
                    let mut v152: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v153: Rc<str> = Rc::<str>::from(format!("{}{}", v152, v151));
                    let mut v154: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v155: Rc<str> = Rc::<str>::from(format!("{}{}", v153, v154));
                    v155.clone()
                } else {
                    let mut v156: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v157: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v158: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v159: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v160: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v161: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
                    let mut v162: Rc<str> = format_real_22(v104);
                    let mut v163: Rc<str> = Rc::<str>::from(format!("{}{}", v161, v162));
                    let mut v164: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
                    let mut v165: Rc<str> = Rc::<str>::from(format!("{}{}", v163, v164));
                    let mut v166: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v167: Rc<str> = Rc::<str>::from(format!("{}{}", v165, v166));
                    let mut v168: Rc<str> = Rc::<str>::from(format!("{}{}", v167, v160));
                    let mut v169: f64 = 0.0f64;
                    let mut v170: Rc<str> = format_real_22(v169);
                    let mut v171: Rc<str> = Rc::<str>::from(format!("{}{}", v168, v170));
                    let mut v172: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v173: Rc<str> = Rc::<str>::from(format!("{}{}", v172, v171));
                    let mut v174: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v175: Rc<str> = Rc::<str>::from(format!("{}{}", v173, v174));
                    v175.clone()
                };
                let mut v177: Rc<str> = Rc::<str>::from(format!("{}{}", v142, v176));
                println!("{}", v177);
                let mut v178: bool = v107 == false;
                if v178 {
                    std::panic::panic_any::<std::string::String>(format!("{}", v177.clone()))
                };
                (v0, v1) = (v0.clone(), v3.clone());
                continue;
            }
            UH0::UH0_Nil => {
                return ();
            }
        }
        return ();
    }
}
fn method43() -> Rc<UH0> {
    let mut v0: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
    let mut v1: Rc<UH0> = Rc::new(UH0::UH0_Cons(100.0f64, v0.clone()));
    let mut v2: Rc<UH0> = Rc::new(UH0::UH0_Cons(90.0f64, v1.clone()));
    let mut v3: Rc<UH0> = Rc::new(UH0::UH0_Cons(80.0f64, v2.clone()));
    let mut v4: Rc<UH0> = Rc::new(UH0::UH0_Cons(70.0f64, v3.clone()));
    let mut v5: Rc<UH0> = Rc::new(UH0::UH0_Cons(60.0f64, v4.clone()));
    let mut v6: Rc<UH0> = Rc::new(UH0::UH0_Cons(50.0f64, v5.clone()));
    let mut v7: Rc<UH0> = Rc::new(UH0::UH0_Cons(40.0f64, v6.clone()));
    let mut v8: Rc<UH0> = Rc::new(UH0::UH0_Cons(30.0f64, v7.clone()));
    let mut v9: Rc<UH0> = Rc::new(UH0::UH0_Cons(20.0f64, v8.clone()));
    Rc::new(UH0::UH0_Cons(10.0f64, v9.clone()))
}
fn method41(mut v0: pyo3::Python) -> () {
    let mut v1: Rc<UH0> = method43();
    method42(v0.clone(), v1.clone())
}
fn method40() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method41(v3.clone());
    let mut v4: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v5: bool = true; (v4) }); //;
    let mut v7: Result<(), pyo3::PyErr> = __run_test;
    v7.unwrap();
    ()
}
fn method46(mut v0: pyo3::Python, mut v1: Rc<UH1>) -> () {
    loop {
        match &*v1 {
            UH1::UH1_Cons(v2, v3) => {
                let mut v2: num_complex::Complex<f64> = v2.clone();
                let mut v3: Rc<UH1> = v3.clone();
                let mut v4: num_complex::Complex<f64> = method4(v2.clone());
                let mut v5: Result<num_complex::Complex<f64>, std::string::String> = method5(v0.clone(), v4.clone());
                let mut v6: num_complex::Complex<f64> = method16(v0.clone(), v2.clone());
                let mut v8: Option<num_complex::Complex<f64>> = v5.ok();
                let mut v9: Option<num_complex::Complex<f64>> = method20(v8.clone());
                let mut v10: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = closure0();
                let mut v11: Option<US0> = v9.map(|x| v10(x));
                let mut v12: US0 = US0::US0_None;
                let mut v13: US0 = v11.unwrap_or(v12);
                let mut v15: f64 = f64::NAN;
                let mut v17: f64 = f64::NAN;
                let mut v19: num_complex::Complex<f64> = num_complex::Complex::new(v15, v17);
                let mut v22: num_complex::Complex<f64> = match &v13 {
                    US0::US0_None => {
                        v19.clone()
                    }
                    US0::US0_Some(v20) => {
                        let mut v20: num_complex::Complex<f64> = v20.clone();
                        v20.clone()
                    }
                };
                let mut v24: f64 = v22.re;
                let mut v25: bool = v24 != 0.0f64 ;
                let mut v27: bool = if v25 {
                    true
                } else {
                    method21(v25)
                };
                let mut v61: Rc<str> = if v25 {
                    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
                    let mut v34: f64 = 0.0f64;
                    let mut v35: Rc<str> = format_real_22(v34);
                    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v35));
                    let mut v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v36));
                    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
                    v40.clone()
                } else {
                    let mut v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
                    let mut v47: Rc<str> = format_real_22(v24);
                    let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v47));
                    let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
                    let mut v50: Rc<str> = Rc::<str>::from(format!("{}{}", v48, v49));
                    let mut v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v50, v51));
                    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v52, v45));
                    let mut v54: f64 = 0.0f64;
                    let mut v55: Rc<str> = format_real_22(v54);
                    let mut v56: Rc<str> = Rc::<str>::from(format!("{}{}", v53, v55));
                    let mut v57: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v58: Rc<str> = Rc::<str>::from(format!("{}{}", v57, v56));
                    let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                    v60.clone()
                };
                let mut v62: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_ne"); } LIT.with(|lit| lit.clone()) };
                let mut v63: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
                let mut v64: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_ne "); } LIT.with(|lit| lit.clone()) };
                let mut v98: Rc<str> = if v25 {
                    let mut v65: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v67: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v68: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v69: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v70: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
                    let mut v71: f64 = 0.0f64;
                    let mut v72: Rc<str> = format_real_22(v71);
                    let mut v73: Rc<str> = Rc::<str>::from(format!("{}{}", v70, v72));
                    let mut v74: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v75: Rc<str> = Rc::<str>::from(format!("{}{}", v74, v73));
                    let mut v76: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v77: Rc<str> = Rc::<str>::from(format!("{}{}", v75, v76));
                    v77.clone()
                } else {
                    let mut v78: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v79: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v80: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v81: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v82: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v83: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
                    let mut v84: Rc<str> = format_real_22(v24);
                    let mut v85: Rc<str> = Rc::<str>::from(format!("{}{}", v83, v84));
                    let mut v86: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
                    let mut v87: Rc<str> = Rc::<str>::from(format!("{}{}", v85, v86));
                    let mut v88: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v89: Rc<str> = Rc::<str>::from(format!("{}{}", v87, v88));
                    let mut v90: Rc<str> = Rc::<str>::from(format!("{}{}", v89, v82));
                    let mut v91: f64 = 0.0f64;
                    let mut v92: Rc<str> = format_real_22(v91);
                    let mut v93: Rc<str> = Rc::<str>::from(format!("{}{}", v90, v92));
                    let mut v94: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v95: Rc<str> = Rc::<str>::from(format!("{}{}", v94, v93));
                    let mut v96: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v97: Rc<str> = Rc::<str>::from(format!("{}{}", v95, v96));
                    v97.clone()
                };
                let mut v99: Rc<str> = Rc::<str>::from(format!("{}{}", v64, v98));
                println!("{}", v99);
                let mut v100: bool = v27 == false;
                if v100 {
                    std::panic::panic_any::<std::string::String>(format!("{}", v99.clone()))
                };
                let mut v102: f64 = v22.im;
                let mut v103: bool = v102 != 0.0f64 ;
                let mut v105: bool = if v103 {
                    true
                } else {
                    method21(v103)
                };
                let mut v139: Rc<str> = if v103 {
                    let mut v106: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v107: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v108: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v109: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v110: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v111: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
                    let mut v112: f64 = 0.0f64;
                    let mut v113: Rc<str> = format_real_22(v112);
                    let mut v114: Rc<str> = Rc::<str>::from(format!("{}{}", v111, v113));
                    let mut v115: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v116: Rc<str> = Rc::<str>::from(format!("{}{}", v115, v114));
                    let mut v117: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v118: Rc<str> = Rc::<str>::from(format!("{}{}", v116, v117));
                    v118.clone()
                } else {
                    let mut v119: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v120: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v121: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v122: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v123: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v124: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
                    let mut v125: Rc<str> = format_real_22(v102);
                    let mut v126: Rc<str> = Rc::<str>::from(format!("{}{}", v124, v125));
                    let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
                    let mut v128: Rc<str> = Rc::<str>::from(format!("{}{}", v126, v127));
                    let mut v129: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v130: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v129));
                    let mut v131: Rc<str> = Rc::<str>::from(format!("{}{}", v130, v123));
                    let mut v132: f64 = 0.0f64;
                    let mut v133: Rc<str> = format_real_22(v132);
                    let mut v134: Rc<str> = Rc::<str>::from(format!("{}{}", v131, v133));
                    let mut v135: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v136: Rc<str> = Rc::<str>::from(format!("{}{}", v135, v134));
                    let mut v137: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v138: Rc<str> = Rc::<str>::from(format!("{}{}", v136, v137));
                    v138.clone()
                };
                let mut v140: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_ne "); } LIT.with(|lit| lit.clone()) };
                let mut v174: Rc<str> = if v103 {
                    let mut v141: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v142: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v143: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v144: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v145: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
                    let mut v147: f64 = 0.0f64;
                    let mut v148: Rc<str> = format_real_22(v147);
                    let mut v149: Rc<str> = Rc::<str>::from(format!("{}{}", v146, v148));
                    let mut v150: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v151: Rc<str> = Rc::<str>::from(format!("{}{}", v150, v149));
                    let mut v152: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v153: Rc<str> = Rc::<str>::from(format!("{}{}", v151, v152));
                    v153.clone()
                } else {
                    let mut v154: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v155: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v156: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v157: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v158: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v159: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
                    let mut v160: Rc<str> = format_real_22(v102);
                    let mut v161: Rc<str> = Rc::<str>::from(format!("{}{}", v159, v160));
                    let mut v162: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
                    let mut v163: Rc<str> = Rc::<str>::from(format!("{}{}", v161, v162));
                    let mut v164: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v165: Rc<str> = Rc::<str>::from(format!("{}{}", v163, v164));
                    let mut v166: Rc<str> = Rc::<str>::from(format!("{}{}", v165, v158));
                    let mut v167: f64 = 0.0f64;
                    let mut v168: Rc<str> = format_real_22(v167);
                    let mut v169: Rc<str> = Rc::<str>::from(format!("{}{}", v166, v168));
                    let mut v170: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v171: Rc<str> = Rc::<str>::from(format!("{}{}", v170, v169));
                    let mut v172: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v173: Rc<str> = Rc::<str>::from(format!("{}{}", v171, v172));
                    v173.clone()
                };
                let mut v175: Rc<str> = Rc::<str>::from(format!("{}{}", v140, v174));
                println!("{}", v175);
                let mut v176: bool = v105 == false;
                if v176 {
                    std::panic::panic_any::<std::string::String>(format!("{}", v175.clone()))
                };
                (v0, v1) = (v0.clone(), v3.clone());
                continue;
            }
            UH1::UH1_Nil => {
                return ();
            }
        }
        return ();
    }
}
fn method47() -> Rc<UH1> {
    let mut v1: num_complex::Complex<f64> = num_complex::Complex::new(0.5f64, 14.134725f64);
    let mut v3: num_complex::Complex<f64> = num_complex::Complex::new(0.75f64, 20.5f64);
    let mut v5: num_complex::Complex<f64> = num_complex::Complex::new(1.25f64, 30.1f64);
    let mut v7: num_complex::Complex<f64> = num_complex::Complex::new(0.25f64, 40.0f64);
    let mut v9: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 50.0f64);
    let mut v10: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_Nil); } CASE.with(|case| case.clone()) };
    let mut v11: Rc<UH1> = Rc::new(UH1::UH1_Cons(v9.clone(), v10.clone()));
    let mut v12: Rc<UH1> = Rc::new(UH1::UH1_Cons(v7.clone(), v11.clone()));
    let mut v13: Rc<UH1> = Rc::new(UH1::UH1_Cons(v5.clone(), v12.clone()));
    let mut v14: Rc<UH1> = Rc::new(UH1::UH1_Cons(v3.clone(), v13.clone()));
    Rc::new(UH1::UH1_Cons(v1.clone(), v14.clone()))
}
fn method45(mut v0: pyo3::Python) -> () {
    let mut v1: Rc<UH1> = method47();
    method46(v0.clone(), v1.clone())
}
fn method44() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method45(v3.clone());
    let mut v4: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v5: bool = true; (v4) }); //;
    let mut v7: Result<(), pyo3::PyErr> = __run_test;
    v7.unwrap();
    ()
}
fn method50(mut v0: pyo3::Python, mut v1: Rc<UH1>) -> () {
    loop {
        match &*v1 {
            UH1::UH1_Cons(v2, v3) => {
                let mut v2: num_complex::Complex<f64> = v2.clone();
                let mut v3: Rc<UH1> = v3.clone();
                let mut v4: num_complex::Complex<f64> = method4(v2.clone());
                let mut v5: Result<num_complex::Complex<f64>, std::string::String> = method5(v0.clone(), v4.clone());
                let mut v6: num_complex::Complex<f64> = method16(v0.clone(), v2.clone());
                let mut v8: Option<num_complex::Complex<f64>> = v5.ok();
                let mut v9: Option<num_complex::Complex<f64>> = method20(v8.clone());
                let mut v10: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = closure0();
                let mut v11: Option<US0> = v9.map(|x| v10(x));
                let mut v12: US0 = US0::US0_None;
                let mut v13: US0 = v11.unwrap_or(v12);
                let mut v15: f64 = f64::NAN;
                let mut v17: f64 = f64::NAN;
                let mut v19: num_complex::Complex<f64> = num_complex::Complex::new(v15, v17);
                let mut v22: num_complex::Complex<f64> = match &v13 {
                    US0::US0_None => {
                        v19.clone()
                    }
                    US0::US0_Some(v20) => {
                        let mut v20: num_complex::Complex<f64> = v20.clone();
                        v20.clone()
                    }
                };
                let mut v24: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                let mut v26: num_complex::Complex<f64> = num_complex::Complex::powc(v24, v2.clone());
                let mut v28: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                let mut v30: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                let mut v32: num_complex::Complex<f64> = v2 - v30;
                let mut v34: num_complex::Complex<f64> = num_complex::Complex::powc(v28, v32);
                let mut v36: num_complex::Complex<f64> = v26 * v34;
                let mut v38: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                let mut v40: num_complex::Complex<f64> = v38 * v2;
                let mut v42: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                let mut v44: num_complex::Complex<f64> = v40 / v42;
                let mut v46: num_complex::Complex<f64> = v44.sin();
                let mut v48: num_complex::Complex<f64> = v36 * v46;
                let mut v50: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                let mut v52: num_complex::Complex<f64> = v50 - v2;
                let mut v53: num_complex::Complex<f64> = method4(v52.clone());
                let mut v54: Result<num_complex::Complex<f64>, std::string::String> = method19(v0.clone(), v53.clone());
                let mut v56: Option<num_complex::Complex<f64>> = v54.ok();
                let mut v57: Option<num_complex::Complex<f64>> = method20(v56.clone());
                let mut v58: Option<US0> = v57.map(|x| v10(x));
                let mut v59: US0 = US0::US0_None;
                let mut v60: US0 = v58.unwrap_or(v59);
                let mut v62: f64 = f64::NAN;
                let mut v64: f64 = f64::NAN;
                let mut v66: num_complex::Complex<f64> = num_complex::Complex::new(v62, v64);
                let mut v69: num_complex::Complex<f64> = match &v60 {
                    US0::US0_None => {
                        v66.clone()
                    }
                    US0::US0_Some(v67) => {
                        let mut v67: num_complex::Complex<f64> = v67.clone();
                        v67.clone()
                    }
                };
                let mut v71: num_complex::Complex<f64> = v48 * v69;
                let mut v73: f64 = v2.re;
                let mut v74: f64 = 1.0f64 - v73;
                let mut v76: f64 = v2.im;
                let mut v77: f64 = -(v76);
                let mut v79: num_complex::Complex<f64> = num_complex::Complex::new(v74, v77);
                let mut v80: num_complex::Complex<f64> = method4(v79.clone());
                let mut v81: Result<num_complex::Complex<f64>, std::string::String> = method5(v0.clone(), v80.clone());
                let mut v82: num_complex::Complex<f64> = method16(v0.clone(), v79.clone());
                let mut v84: Option<num_complex::Complex<f64>> = v81.ok();
                let mut v85: Option<num_complex::Complex<f64>> = method20(v84.clone());
                let mut v86: Option<US0> = v85.map(|x| v10(x));
                let mut v87: US0 = US0::US0_None;
                let mut v88: US0 = v86.unwrap_or(v87);
                let mut v90: f64 = f64::NAN;
                let mut v92: f64 = f64::NAN;
                let mut v94: num_complex::Complex<f64> = num_complex::Complex::new(v90, v92);
                let mut v97: num_complex::Complex<f64> = match &v88 {
                    US0::US0_None => {
                        v94.clone()
                    }
                    US0::US0_Some(v95) => {
                        let mut v95: num_complex::Complex<f64> = v95.clone();
                        v95.clone()
                    }
                };
                let mut v99: num_complex::Complex<f64> = v71 * v97;
                let mut v101: f64 = v22.re;
                let mut v103: f64 = v99.re;
                let mut v104: f64 = v101 - v103;
                let mut v105: f64 = -(v104);
                let mut v106: bool = v104 >= v105;
                let mut v107: f64 = if v106 {
                    v104
                } else {
                    v105
                };
                let mut v108: bool = v107 < 0.0001f64;
                let mut v110: bool = if v108 {
                    true
                } else {
                    method21(v108)
                };
                let mut v144: Rc<str> = if v108 {
                    let mut v111: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v112: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v113: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v114: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v115: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v116: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
                    let mut v117: f64 = 0.0001f64;
                    let mut v118: Rc<str> = format_real_22(v117);
                    let mut v119: Rc<str> = Rc::<str>::from(format!("{}{}", v116, v118));
                    let mut v120: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v121: Rc<str> = Rc::<str>::from(format!("{}{}", v120, v119));
                    let mut v122: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v123: Rc<str> = Rc::<str>::from(format!("{}{}", v121, v122));
                    v123.clone()
                } else {
                    let mut v124: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v125: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v126: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v128: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v129: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
                    let mut v130: Rc<str> = format_real_22(v107);
                    let mut v131: Rc<str> = Rc::<str>::from(format!("{}{}", v129, v130));
                    let mut v132: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
                    let mut v133: Rc<str> = Rc::<str>::from(format!("{}{}", v131, v132));
                    let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v135: Rc<str> = Rc::<str>::from(format!("{}{}", v133, v134));
                    let mut v136: Rc<str> = Rc::<str>::from(format!("{}{}", v135, v128));
                    let mut v137: f64 = 0.0001f64;
                    let mut v138: Rc<str> = format_real_22(v137);
                    let mut v139: Rc<str> = Rc::<str>::from(format!("{}{}", v136, v138));
                    let mut v140: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v141: Rc<str> = Rc::<str>::from(format!("{}{}", v140, v139));
                    let mut v142: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v143: Rc<str> = Rc::<str>::from(format!("{}{}", v141, v142));
                    v143.clone()
                };
                let mut v145: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt"); } LIT.with(|lit| lit.clone()) };
                let mut v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
                let mut v147: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
                let mut v181: Rc<str> = if v108 {
                    let mut v148: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v149: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v150: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v151: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v152: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v153: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
                    let mut v154: f64 = 0.0001f64;
                    let mut v155: Rc<str> = format_real_22(v154);
                    let mut v156: Rc<str> = Rc::<str>::from(format!("{}{}", v153, v155));
                    let mut v157: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v158: Rc<str> = Rc::<str>::from(format!("{}{}", v157, v156));
                    let mut v159: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v160: Rc<str> = Rc::<str>::from(format!("{}{}", v158, v159));
                    v160.clone()
                } else {
                    let mut v161: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v162: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v163: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v164: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v165: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v166: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
                    let mut v167: Rc<str> = format_real_22(v107);
                    let mut v168: Rc<str> = Rc::<str>::from(format!("{}{}", v166, v167));
                    let mut v169: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
                    let mut v170: Rc<str> = Rc::<str>::from(format!("{}{}", v168, v169));
                    let mut v171: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v172: Rc<str> = Rc::<str>::from(format!("{}{}", v170, v171));
                    let mut v173: Rc<str> = Rc::<str>::from(format!("{}{}", v172, v165));
                    let mut v174: f64 = 0.0001f64;
                    let mut v175: Rc<str> = format_real_22(v174);
                    let mut v176: Rc<str> = Rc::<str>::from(format!("{}{}", v173, v175));
                    let mut v177: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v178: Rc<str> = Rc::<str>::from(format!("{}{}", v177, v176));
                    let mut v179: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v180: Rc<str> = Rc::<str>::from(format!("{}{}", v178, v179));
                    v180.clone()
                };
                let mut v182: Rc<str> = Rc::<str>::from(format!("{}{}", v147, v181));
                println!("{}", v182);
                let mut v183: bool = v110 == false;
                if v183 {
                    std::panic::panic_any::<std::string::String>(format!("{}", v182.clone()))
                };
                let mut v185: f64 = v22.im;
                let mut v187: f64 = v99.im;
                let mut v188: f64 = v185 - v187;
                let mut v189: f64 = -(v188);
                let mut v190: bool = v188 >= v189;
                let mut v191: f64 = if v190 {
                    v188
                } else {
                    v189
                };
                let mut v192: bool = v191 < 0.0001f64;
                let mut v194: bool = if v192 {
                    true
                } else {
                    method21(v192)
                };
                let mut v228: Rc<str> = if v192 {
                    let mut v195: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v196: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v197: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v198: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v199: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v200: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
                    let mut v201: f64 = 0.0001f64;
                    let mut v202: Rc<str> = format_real_22(v201);
                    let mut v203: Rc<str> = Rc::<str>::from(format!("{}{}", v200, v202));
                    let mut v204: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v205: Rc<str> = Rc::<str>::from(format!("{}{}", v204, v203));
                    let mut v206: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v207: Rc<str> = Rc::<str>::from(format!("{}{}", v205, v206));
                    v207.clone()
                } else {
                    let mut v208: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v209: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v210: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v211: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v212: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v213: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
                    let mut v214: Rc<str> = format_real_22(v191);
                    let mut v215: Rc<str> = Rc::<str>::from(format!("{}{}", v213, v214));
                    let mut v216: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
                    let mut v217: Rc<str> = Rc::<str>::from(format!("{}{}", v215, v216));
                    let mut v218: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v219: Rc<str> = Rc::<str>::from(format!("{}{}", v217, v218));
                    let mut v220: Rc<str> = Rc::<str>::from(format!("{}{}", v219, v212));
                    let mut v221: f64 = 0.0001f64;
                    let mut v222: Rc<str> = format_real_22(v221);
                    let mut v223: Rc<str> = Rc::<str>::from(format!("{}{}", v220, v222));
                    let mut v224: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v225: Rc<str> = Rc::<str>::from(format!("{}{}", v224, v223));
                    let mut v226: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v227: Rc<str> = Rc::<str>::from(format!("{}{}", v225, v226));
                    v227.clone()
                };
                let mut v229: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
                let mut v263: Rc<str> = if v192 {
                    let mut v230: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v231: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v232: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v233: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v234: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v235: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
                    let mut v236: f64 = 0.0001f64;
                    let mut v237: Rc<str> = format_real_22(v236);
                    let mut v238: Rc<str> = Rc::<str>::from(format!("{}{}", v235, v237));
                    let mut v239: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v240: Rc<str> = Rc::<str>::from(format!("{}{}", v239, v238));
                    let mut v241: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v242: Rc<str> = Rc::<str>::from(format!("{}{}", v240, v241));
                    v242.clone()
                } else {
                    let mut v243: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v244: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v245: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v246: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v247: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v248: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
                    let mut v249: Rc<str> = format_real_22(v191);
                    let mut v250: Rc<str> = Rc::<str>::from(format!("{}{}", v248, v249));
                    let mut v251: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
                    let mut v252: Rc<str> = Rc::<str>::from(format!("{}{}", v250, v251));
                    let mut v253: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v254: Rc<str> = Rc::<str>::from(format!("{}{}", v252, v253));
                    let mut v255: Rc<str> = Rc::<str>::from(format!("{}{}", v254, v247));
                    let mut v256: f64 = 0.0001f64;
                    let mut v257: Rc<str> = format_real_22(v256);
                    let mut v258: Rc<str> = Rc::<str>::from(format!("{}{}", v255, v257));
                    let mut v259: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v260: Rc<str> = Rc::<str>::from(format!("{}{}", v259, v258));
                    let mut v261: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v262: Rc<str> = Rc::<str>::from(format!("{}{}", v260, v261));
                    v262.clone()
                };
                let mut v264: Rc<str> = Rc::<str>::from(format!("{}{}", v229, v263));
                println!("{}", v264);
                let mut v265: bool = v194 == false;
                if v265 {
                    std::panic::panic_any::<std::string::String>(format!("{}", v264.clone()))
                };
                (v0, v1) = (v0.clone(), v3.clone());
                continue;
            }
            UH1::UH1_Nil => {
                return ();
            }
        }
        return ();
    }
}
fn method51() -> Rc<UH1> {
    let mut v1: num_complex::Complex<f64> = num_complex::Complex::new(3.0f64, 4.0f64);
    let mut v3: num_complex::Complex<f64> = num_complex::Complex::new(2.5f64, -3.5f64);
    let mut v5: num_complex::Complex<f64> = num_complex::Complex::new(1.5f64, 2.5f64);
    let mut v7: num_complex::Complex<f64> = num_complex::Complex::new(0.5f64, 14.134725f64);
    let mut v8: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_Nil); } CASE.with(|case| case.clone()) };
    let mut v9: Rc<UH1> = Rc::new(UH1::UH1_Cons(v7.clone(), v8.clone()));
    let mut v10: Rc<UH1> = Rc::new(UH1::UH1_Cons(v5.clone(), v9.clone()));
    let mut v11: Rc<UH1> = Rc::new(UH1::UH1_Cons(v3.clone(), v10.clone()));
    Rc::new(UH1::UH1_Cons(v1.clone(), v11.clone()))
}
fn method49(mut v0: pyo3::Python) -> () {
    let mut v1: Rc<UH1> = method51();
    method50(v0.clone(), v1.clone())
}
fn method48() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method49(v3.clone());
    let mut v4: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v5: bool = true; (v4) }); //;
    let mut v7: Result<(), pyo3::PyErr> = __run_test;
    v7.unwrap();
    ()
}
fn method55(mut v0: f64, mut v1: Rc<UH0>, mut v2: f64) -> f64 {
    loop {
        match &*v1 {
            UH0::UH0_Cons(v3, v4) => {
                let mut v3: f64 = *v3;
                let mut v4: Rc<UH0> = v4.clone();
                let mut v5: f64 = -(v0);
                let mut v6: f64 = v3.powf(v5);
                let mut v7: f64 = 1.0f64 - v6;
                let mut v8: f64 = v2 / v7;
                (v0, v1, v2) = (v0, v4.clone(), v8);
                continue;
            }
            UH0::UH0_Nil => {
                return v2;
            }
        }
    }
}
fn method54(mut v0: pyo3::Python, mut v1: Rc<UH0>, mut v2: Rc<UH0>) -> () {
    loop {
        match &*v2 {
            UH0::UH0_Cons(v3, v4) => {
                let mut v3: f64 = *v3;
                let mut v4: Rc<UH0> = v4.clone();
                let mut v6: num_complex::Complex<f64> = num_complex::Complex::new(v3, 0.0f64);
                let mut v7: f64 = 1.0f64;
                let mut v8: f64 = method55(v3, v1.clone(), v7);
                let mut v9: num_complex::Complex<f64> = method4(v6.clone());
                let mut v10: Result<num_complex::Complex<f64>, std::string::String> = method5(v0.clone(), v9.clone());
                let mut v11: num_complex::Complex<f64> = method16(v0.clone(), v6.clone());
                let mut v13: Option<num_complex::Complex<f64>> = v10.ok();
                let mut v14: Option<num_complex::Complex<f64>> = method20(v13.clone());
                let mut v15: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = closure0();
                let mut v16: Option<US0> = v14.map(|x| v15(x));
                let mut v17: US0 = US0::US0_None;
                let mut v18: US0 = v16.unwrap_or(v17);
                let mut v20: f64 = f64::NAN;
                let mut v22: f64 = f64::NAN;
                let mut v24: num_complex::Complex<f64> = num_complex::Complex::new(v20, v22);
                let mut v27: num_complex::Complex<f64> = match &v18 {
                    US0::US0_None => {
                        v24.clone()
                    }
                    US0::US0_Some(v25) => {
                        let mut v25: num_complex::Complex<f64> = v25.clone();
                        v25.clone()
                    }
                };
                let mut v29: f64 = v27.re;
                let mut v30: f64 = v29 - v8;
                let mut v31: f64 = -(v30);
                let mut v32: bool = v30 >= v31;
                let mut v33: f64 = if v32 {
                    v30
                } else {
                    v31
                };
                let mut v34: bool = v33 < 0.01f64;
                let mut v36: bool = if v34 {
                    true
                } else {
                    method21(v34)
                };
                let mut v70: Rc<str> = if v34 {
                    let mut v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
                    let mut v43: f64 = 0.01f64;
                    let mut v44: Rc<str> = format_real_22(v43);
                    let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v42, v44));
                    let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46, v45));
                    let mut v48: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
                    v49.clone()
                } else {
                    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v53: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v54: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v55: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
                    let mut v56: Rc<str> = format_real_22(v33);
                    let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", v55, v56));
                    let mut v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
                    let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v57, v58));
                    let mut v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v59, v60));
                    let mut v62: Rc<str> = Rc::<str>::from(format!("{}{}", v61, v54));
                    let mut v63: f64 = 0.01f64;
                    let mut v64: Rc<str> = format_real_22(v63);
                    let mut v65: Rc<str> = Rc::<str>::from(format!("{}{}", v62, v64));
                    let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v67: Rc<str> = Rc::<str>::from(format!("{}{}", v66, v65));
                    let mut v68: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v69: Rc<str> = Rc::<str>::from(format!("{}{}", v67, v68));
                    v69.clone()
                };
                let mut v71: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt"); } LIT.with(|lit| lit.clone()) };
                let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
                let mut v73: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
                let mut v107: Rc<str> = if v34 {
                    let mut v74: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v75: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v76: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v77: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v78: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v79: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
                    let mut v80: f64 = 0.01f64;
                    let mut v81: Rc<str> = format_real_22(v80);
                    let mut v82: Rc<str> = Rc::<str>::from(format!("{}{}", v79, v81));
                    let mut v83: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v84: Rc<str> = Rc::<str>::from(format!("{}{}", v83, v82));
                    let mut v85: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v86: Rc<str> = Rc::<str>::from(format!("{}{}", v84, v85));
                    v86.clone()
                } else {
                    let mut v87: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v88: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v89: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v90: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v91: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v92: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
                    let mut v93: Rc<str> = format_real_22(v33);
                    let mut v94: Rc<str> = Rc::<str>::from(format!("{}{}", v92, v93));
                    let mut v95: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
                    let mut v96: Rc<str> = Rc::<str>::from(format!("{}{}", v94, v95));
                    let mut v97: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v98: Rc<str> = Rc::<str>::from(format!("{}{}", v96, v97));
                    let mut v99: Rc<str> = Rc::<str>::from(format!("{}{}", v98, v91));
                    let mut v100: f64 = 0.01f64;
                    let mut v101: Rc<str> = format_real_22(v100);
                    let mut v102: Rc<str> = Rc::<str>::from(format!("{}{}", v99, v101));
                    let mut v103: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v104: Rc<str> = Rc::<str>::from(format!("{}{}", v103, v102));
                    let mut v105: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v106: Rc<str> = Rc::<str>::from(format!("{}{}", v104, v105));
                    v106.clone()
                };
                let mut v108: Rc<str> = Rc::<str>::from(format!("{}{}", v73, v107));
                println!("{}", v108);
                let mut v109: bool = v36 == false;
                if v109 {
                    std::panic::panic_any::<std::string::String>(format!("{}", v108.clone()))
                };
                let mut v111: f64 = v27.im;
                let mut v112: bool = v111 < 0.01f64;
                let mut v114: bool = if v112 {
                    true
                } else {
                    method21(v112)
                };
                let mut v148: Rc<str> = if v112 {
                    let mut v115: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v116: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v117: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v118: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v119: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v120: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
                    let mut v121: f64 = 0.01f64;
                    let mut v122: Rc<str> = format_real_22(v121);
                    let mut v123: Rc<str> = Rc::<str>::from(format!("{}{}", v120, v122));
                    let mut v124: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v125: Rc<str> = Rc::<str>::from(format!("{}{}", v124, v123));
                    let mut v126: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v127: Rc<str> = Rc::<str>::from(format!("{}{}", v125, v126));
                    v127.clone()
                } else {
                    let mut v128: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v129: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v130: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v131: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v132: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v133: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
                    let mut v134: Rc<str> = format_real_22(v111);
                    let mut v135: Rc<str> = Rc::<str>::from(format!("{}{}", v133, v134));
                    let mut v136: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
                    let mut v137: Rc<str> = Rc::<str>::from(format!("{}{}", v135, v136));
                    let mut v138: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v139: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v138));
                    let mut v140: Rc<str> = Rc::<str>::from(format!("{}{}", v139, v132));
                    let mut v141: f64 = 0.01f64;
                    let mut v142: Rc<str> = format_real_22(v141);
                    let mut v143: Rc<str> = Rc::<str>::from(format!("{}{}", v140, v142));
                    let mut v144: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v145: Rc<str> = Rc::<str>::from(format!("{}{}", v144, v143));
                    let mut v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v147: Rc<str> = Rc::<str>::from(format!("{}{}", v145, v146));
                    v147.clone()
                };
                let mut v149: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
                let mut v183: Rc<str> = if v112 {
                    let mut v150: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v151: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v152: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v153: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v154: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v155: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
                    let mut v156: f64 = 0.01f64;
                    let mut v157: Rc<str> = format_real_22(v156);
                    let mut v158: Rc<str> = Rc::<str>::from(format!("{}{}", v155, v157));
                    let mut v159: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v160: Rc<str> = Rc::<str>::from(format!("{}{}", v159, v158));
                    let mut v161: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v162: Rc<str> = Rc::<str>::from(format!("{}{}", v160, v161));
                    v162.clone()
                } else {
                    let mut v163: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v164: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v165: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v166: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
                    let mut v167: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
                    let mut v168: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual = "); } LIT.with(|lit| lit.clone()) };
                    let mut v169: Rc<str> = format_real_22(v111);
                    let mut v170: Rc<str> = Rc::<str>::from(format!("{}{}", v168, v169));
                    let mut v171: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
                    let mut v172: Rc<str> = Rc::<str>::from(format!("{}{}", v170, v171));
                    let mut v173: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
                    let mut v174: Rc<str> = Rc::<str>::from(format!("{}{}", v172, v173));
                    let mut v175: Rc<str> = Rc::<str>::from(format!("{}{}", v174, v167));
                    let mut v176: f64 = 0.01f64;
                    let mut v177: Rc<str> = format_real_22(v176);
                    let mut v178: Rc<str> = Rc::<str>::from(format!("{}{}", v175, v177));
                    let mut v179: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
                    let mut v180: Rc<str> = Rc::<str>::from(format!("{}{}", v179, v178));
                    let mut v181: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
                    let mut v182: Rc<str> = Rc::<str>::from(format!("{}{}", v180, v181));
                    v182.clone()
                };
                let mut v184: Rc<str> = Rc::<str>::from(format!("{}{}", v149, v183));
                println!("{}", v184);
                let mut v185: bool = v114 == false;
                if v185 {
                    std::panic::panic_any::<std::string::String>(format!("{}", v184.clone()))
                };
                (v0, v1, v2) = (v0.clone(), v1.clone(), v4.clone());
                continue;
            }
            UH0::UH0_Nil => {
                return ();
            }
        }
        return ();
    }
}
fn method56() -> Rc<UH0> {
    let mut v0: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
    let mut v1: Rc<UH0> = Rc::new(UH0::UH0_Cons(5.0f64, v0.clone()));
    let mut v2: Rc<UH0> = Rc::new(UH0::UH0_Cons(4.5f64, v1.clone()));
    let mut v3: Rc<UH0> = Rc::new(UH0::UH0_Cons(4.0f64, v2.clone()));
    let mut v4: Rc<UH0> = Rc::new(UH0::UH0_Cons(3.5f64, v3.clone()));
    let mut v5: Rc<UH0> = Rc::new(UH0::UH0_Cons(3.0f64, v4.clone()));
    let mut v6: Rc<UH0> = Rc::new(UH0::UH0_Cons(2.5f64, v5.clone()));
    Rc::new(UH0::UH0_Cons(2.0f64, v6.clone()))
}
fn method57() -> Rc<UH0> {
    let mut v0: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
    let mut v1: Rc<UH0> = Rc::new(UH0::UH0_Cons(71.0f64, v0.clone()));
    let mut v2: Rc<UH0> = Rc::new(UH0::UH0_Cons(67.0f64, v1.clone()));
    let mut v3: Rc<UH0> = Rc::new(UH0::UH0_Cons(61.0f64, v2.clone()));
    let mut v4: Rc<UH0> = Rc::new(UH0::UH0_Cons(59.0f64, v3.clone()));
    let mut v5: Rc<UH0> = Rc::new(UH0::UH0_Cons(53.0f64, v4.clone()));
    let mut v6: Rc<UH0> = Rc::new(UH0::UH0_Cons(47.0f64, v5.clone()));
    let mut v7: Rc<UH0> = Rc::new(UH0::UH0_Cons(43.0f64, v6.clone()));
    let mut v8: Rc<UH0> = Rc::new(UH0::UH0_Cons(41.0f64, v7.clone()));
    let mut v9: Rc<UH0> = Rc::new(UH0::UH0_Cons(37.0f64, v8.clone()));
    let mut v10: Rc<UH0> = Rc::new(UH0::UH0_Cons(31.0f64, v9.clone()));
    let mut v11: Rc<UH0> = Rc::new(UH0::UH0_Cons(29.0f64, v10.clone()));
    let mut v12: Rc<UH0> = Rc::new(UH0::UH0_Cons(23.0f64, v11.clone()));
    let mut v13: Rc<UH0> = Rc::new(UH0::UH0_Cons(19.0f64, v12.clone()));
    let mut v14: Rc<UH0> = Rc::new(UH0::UH0_Cons(17.0f64, v13.clone()));
    let mut v15: Rc<UH0> = Rc::new(UH0::UH0_Cons(13.0f64, v14.clone()));
    let mut v16: Rc<UH0> = Rc::new(UH0::UH0_Cons(11.0f64, v15.clone()));
    let mut v17: Rc<UH0> = Rc::new(UH0::UH0_Cons(7.0f64, v16.clone()));
    let mut v18: Rc<UH0> = Rc::new(UH0::UH0_Cons(5.0f64, v17.clone()));
    let mut v19: Rc<UH0> = Rc::new(UH0::UH0_Cons(3.0f64, v18.clone()));
    Rc::new(UH0::UH0_Cons(2.0f64, v19.clone()))
}
fn method53(mut v0: pyo3::Python) -> () {
    let mut v1: Rc<UH0> = method56();
    let mut v2: Rc<UH0> = method57();
    method54(v0.clone(), v2.clone(), v1.clone())
}
fn method52() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method53(v3.clone());
    let mut v4: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v5: bool = true; (v4) }); //;
    let mut v7: Result<(), pyo3::PyErr> = __run_test;
    v7.unwrap();
    ()
}
fn spiral_main() -> i32 {
    let mut v0: Rc<str> = SPIRAL_TEST_NAME.with(|x| x.borrow().clone()).unwrap_or_else(|| Rc::<str>::from(std::env::args().nth(1).unwrap_or_default()));
    let mut v1: Rc<str> = method0(v0.clone());
    let mut v2: bool = v1.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v4: bool = if v2 {
        true
    } else {
        let mut v3: bool = v1.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("test_zeta_at_known_values_"); } LIT.with(|lit| lit.clone()) };
        v3
    };
    let mut v5: bool = if v4 {
        method1();
        true
    } else {
        false
    };
    let mut v7: bool = if v2 {
        true
    } else {
        let mut v6: bool = v1.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("test_zeta_at_2_minus2"); } LIT.with(|lit| lit.clone()) };
        v6
    };
    let mut v8: bool = if v7 {
        method24();
        true
    } else {
        v5
    };
    let mut v10: bool = if v2 {
        true
    } else {
        let mut v9: bool = v1.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("test_trivial_zero_at_negative_even___"); } LIT.with(|lit| lit.clone()) };
        v9
    };
    let mut v11: bool = if v10 {
        method26();
        true
    } else {
        v8
    };
    let mut v13: bool = if v2 {
        true
    } else {
        let mut v12: bool = v1.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("test_non_trivial_zero___"); } LIT.with(|lit| lit.clone()) };
        v12
    };
    let mut v14: bool = if v13 {
        method30();
        true
    } else {
        v11
    };
    let mut v16: bool = if v2 {
        true
    } else {
        let mut v15: bool = v1.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("test_real_part_greater_than_one___"); } LIT.with(|lit| lit.clone()) };
        v15
    };
    let mut v17: bool = if v16 {
        method32();
        true
    } else {
        v14
    };
    let mut v19: bool = if v2 {
        true
    } else {
        let mut v18: bool = v1.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("test_zeta_at_1___"); } LIT.with(|lit| lit.clone()) };
        v18
    };
    let mut v20: bool = if v19 {
        method34();
        true
    } else {
        v17
    };
    let mut v22: bool = if v2 {
        true
    } else {
        let mut v21: bool = v1.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("test_symmetry_across_real_axis___"); } LIT.with(|lit| lit.clone()) };
        v21
    };
    let mut v23: bool = if v22 {
        method36();
        true
    } else {
        v20
    };
    let mut v25: bool = if v2 {
        true
    } else {
        let mut v24: bool = v1.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("test_behavior_near_origin___"); } LIT.with(|lit| lit.clone()) };
        v24
    };
    let mut v26: bool = if v25 {
        method38();
        true
    } else {
        v23
    };
    let mut v28: bool = if v2 {
        true
    } else {
        let mut v27: bool = v1.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("test_imaginary_axis"); } LIT.with(|lit| lit.clone()) };
        v27
    };
    let mut v29: bool = if v28 {
        method40();
        true
    } else {
        v26
    };
    let mut v31: bool = if v2 {
        true
    } else {
        let mut v30: bool = v1.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("test_critical_strip"); } LIT.with(|lit| lit.clone()) };
        v30
    };
    let mut v32: bool = if v31 {
        method44();
        true
    } else {
        v29
    };
    let mut v34: bool = if v2 {
        true
    } else {
        let mut v33: bool = v1.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("test_reflection_formula_for_specific_value"); } LIT.with(|lit| lit.clone()) };
        v33
    };
    let mut v35: bool = if v34 {
        method48();
        true
    } else {
        v32
    };
    let mut v37: bool = if v2 {
        true
    } else {
        let mut v36: bool = v1.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("test_euler_product_formula"); } LIT.with(|lit| lit.clone()) };
        v36
    };
    let mut v38: bool = if v37 {
        method52();
        true
    } else {
        v35
    };
    let mut v41: i32 = if v38 {
        0i32
    } else {
        let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("unknown test: "); } LIT.with(|lit| lit.clone()) };
        let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v1));
        println!("{}", v40);
        1i32
    };
    if v41 != 0 { std::process::exit(v41) };
    0
}
fn main() { #[cfg(target_arch = "wasm32")] { spiral_main(); return; }
    let main = std::thread::Builder::new().stack_size(1 << 30).spawn(spiral_main).unwrap();
    std::process::exit(match main.join() { Ok(code) => code, Err(_) => 1 });
}
