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
    US0_0(num_complex::Complex<f64>),
    US0_1,
}
impl US0 {
    fn tag(&self) -> i32 {
        match self {
            US0::US0_0(..) => 0,
            US0::US0_1 => 1,
        }
    }
}
struct Mut3 { l0: Rc<str> }
#[derive(Clone)]
enum UH0 {
    UH0_0,
    UH0_1(f64, Rc<UH0>),
}
impl UH0 {
    fn tag(&self) -> i32 {
        match self {
            UH0::UH0_0 => 0,
            UH0::UH0_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum UH1 {
    UH1_0,
    UH1_1(num_complex::Complex<f64>, Rc<UH1>),
}
impl UH1 {
    fn tag(&self) -> i32 {
        match self {
            UH1::UH1_0 => 0,
            UH1::UH1_1(..) => 1,
        }
    }
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
        let mut v63: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v43));
        let mut v71: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v42));
        let mut v72: i32 = v38.wrapping_add(1i32);
        let mut v73: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
        v36.borrow_mut().l0 = v72;
        v36.borrow_mut().l1 = v71.clone();
        v36.borrow_mut().l2 = v73.clone();
        ()
    };
    let (mut v74, mut v75): (Rc<str>, Rc<str>) = (v36.borrow().l1.clone(), v36.borrow().l2.clone());
    let mut v90: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__NAME__"); } LIT.with(|lit| lit.clone()) };
    let mut v91: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("zeta_"); } LIT.with(|lit| lit.clone()) };
    let mut v92: Rc<str> = Rc::<str>::from(v74.replace(&*v90, &*v91));
    let mut v98: Rc<str> = method7(v92.clone());
    let mut v100: f64 = v1.re;
    let mut v102: f64 = v1.im;
    let (mut v121, mut v122): (f64, f64) = method8(v100, v102);
    let mut v123: (f64, f64) = (v121, v122);
    let (mut v169, mut v170): (bool, (f64, f64)) = method9(v123.clone());
    let mut v171: (bool, (f64, f64)) = (v169, v170);
    let mut v199: pyo3::Python = method10(v0.clone());
    let mut v604: &str = &*v98;
    let mut v836: std::string::String = String::from(v604);
    let mut v843: std::ffi::CString = std::ffi::CString::new(v836).unwrap();
    let mut v845: &str = &*v35;
    let mut v847: std::string::String = String::from(v845);
    let mut v849: std::ffi::CString = std::ffi::CString::new(v847).unwrap();
    let mut v851: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> = pyo3::types::PyModule::from_code(v199, &v843, &v849, &v849);
    let mut v875: bool = true; let _result_map_error__ = v851.map_err(|x| { //;
    let mut v877: pyo3::PyErr = x;
    let mut v907: std::string::String = format!("{}", v877);
    let mut v914: bool = true; v907 });
    let mut v916: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> = _result_map_error__;
    let mut v918: pyo3::Bound<pyo3::types::PyModule> = v916.unwrap();
    let mut v919: Rc<str> = method11();
    let mut v921: &str = &*v919;
    let mut v922: pyo3::Bound<pyo3::types::PyModule> = method12(v918.clone());
    let mut v924: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v922.getattr(v921);
    let mut v926: bool = true; let _result_map_error__ = v924.map_err(|x| { //;
    let mut v928: pyo3::PyErr = x;
    let mut v930: std::string::String = format!("{}", v928);
    let mut v932: bool = true; v930 });
    let mut v934: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
    let mut v936: pyo3::Bound<pyo3::PyAny> = v934.unwrap();
    let mut v937: (bool, (f64, f64)) = method13(v171.clone());
    let mut v938: pyo3::Bound<pyo3::PyAny> = method14(v936.clone());
    let mut v940: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = pyo3::prelude::PyAnyMethods::call(&v938, v937, None);
    let mut v942: bool = true; let _result_map_error__ = v940.map_err(|x| { //;
    let mut v944: pyo3::PyErr = x;
    let mut v946: std::string::String = format!("{}", v944);
    let mut v948: bool = true; v946 });
    let mut v950: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
    let mut v952: pyo3::Bound<pyo3::PyAny> = v950?;
    let mut v953: pyo3::Bound<pyo3::PyAny> = method15(v952.clone());
    let mut v955: Result<(f64, f64), pyo3::PyErr> = v953.extract();
    let mut v957: bool = true; let _result_map_error__ = v955.map_err(|x| { //;
    let mut v959: pyo3::PyErr = x;
    let mut v961: std::string::String = format!("{}", v959);
    let mut v963: bool = true; v961 });
    let mut v965: Result<(f64, f64), std::string::String> = _result_map_error__;
    let (mut v967, mut v968): (f64, f64) = v965?;
    let mut v970: num_complex::Complex<f64> = num_complex::Complex::new(v967, v968);
    let mut v989: Result<num_complex::Complex<f64>, std::string::String> = Ok::<num_complex::Complex<f64>, std::string::String>(v970);
    v989.clone()
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
    let mut v65: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__NAME__"); } LIT.with(|lit| lit.clone()) };
    let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("gamma_"); } LIT.with(|lit| lit.clone()) };
    let mut v67: Rc<str> = Rc::<str>::from(v49.replace(&*v65, &*v66));
    let mut v73: Rc<str> = method7(v67.clone());
    let mut v75: f64 = v1.re;
    let mut v77: f64 = v1.im;
    let (mut v78, mut v79): (f64, f64) = method8(v75, v77);
    let mut v80: (f64, f64) = (v78, v79);
    let (mut v81, mut v82): (bool, (f64, f64)) = method9(v80.clone());
    let mut v83: (bool, (f64, f64)) = (v81, v82);
    let mut v84: pyo3::Python = method10(v0.clone());
    let mut v86: &str = &*v73;
    let mut v88: std::string::String = String::from(v86);
    let mut v90: std::ffi::CString = std::ffi::CString::new(v88).unwrap();
    let mut v92: &str = &*v35;
    let mut v94: std::string::String = String::from(v92);
    let mut v96: std::ffi::CString = std::ffi::CString::new(v94).unwrap();
    let mut v98: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> = pyo3::types::PyModule::from_code(v84, &v90, &v96, &v96);
    let mut v100: bool = true; let _result_map_error__ = v98.map_err(|x| { //;
    let mut v102: pyo3::PyErr = x;
    let mut v104: std::string::String = format!("{}", v102);
    let mut v106: bool = true; v104 });
    let mut v108: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> = _result_map_error__;
    let mut v110: pyo3::Bound<pyo3::types::PyModule> = v108.unwrap();
    let mut v111: Rc<str> = method11();
    let mut v113: &str = &*v111;
    let mut v114: pyo3::Bound<pyo3::types::PyModule> = method12(v110.clone());
    let mut v116: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v114.getattr(v113);
    let mut v118: bool = true; let _result_map_error__ = v116.map_err(|x| { //;
    let mut v120: pyo3::PyErr = x;
    let mut v122: std::string::String = format!("{}", v120);
    let mut v124: bool = true; v122 });
    let mut v126: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
    let mut v128: pyo3::Bound<pyo3::PyAny> = v126.unwrap();
    let mut v129: (bool, (f64, f64)) = method13(v83.clone());
    let mut v130: pyo3::Bound<pyo3::PyAny> = method14(v128.clone());
    let mut v132: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = pyo3::prelude::PyAnyMethods::call(&v130, v129, None);
    let mut v134: bool = true; let _result_map_error__ = v132.map_err(|x| { //;
    let mut v136: pyo3::PyErr = x;
    let mut v138: std::string::String = format!("{}", v136);
    let mut v140: bool = true; v138 });
    let mut v142: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
    let mut v144: pyo3::Bound<pyo3::PyAny> = v142?;
    let mut v145: pyo3::Bound<pyo3::PyAny> = method15(v144.clone());
    let mut v147: Result<(f64, f64), pyo3::PyErr> = v145.extract();
    let mut v149: bool = true; let _result_map_error__ = v147.map_err(|x| { //;
    let mut v151: pyo3::PyErr = x;
    let mut v153: std::string::String = format!("{}", v151);
    let mut v155: bool = true; v153 });
    let mut v157: Result<(f64, f64), std::string::String> = _result_map_error__;
    let (mut v159, mut v160): (f64, f64) = v157?;
    let mut v162: num_complex::Complex<f64> = num_complex::Complex::new(v159, v160);
    let mut v163: Result<num_complex::Complex<f64>, std::string::String> = Ok::<num_complex::Complex<f64>, std::string::String>(v162);
    v163.clone()
}
fn method20(mut v0: Option<num_complex::Complex<f64>>) -> Option<num_complex::Complex<f64>> {
    v0.clone()
}
fn closure0() -> Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = Rc::new(move |mut v0: (num_complex::Complex<f64>)| -> US0 {
        let mut v1: num_complex::Complex<f64> = (v0);
        US0::US0_0(v1.clone())
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
            let mut v40: f64 = (v18 as f64);
            let mut v59: num_complex::Complex<f64> = num_complex::Complex::new(v40, 0.0f64);
            let mut v61: num_complex::Complex<f64> = num_complex::Complex::powc(v59, v1.clone());
            let mut v63: num_complex::Complex<f64> = v20 / v61;
            let mut v65: num_complex::Complex<f64> = v17 + v63;
            let mut v66: i32 = v16.wrapping_add(1i32);
            v14.borrow_mut().l0 = v66;
            v14.borrow_mut().l1 = v65.clone();
            ()
        };
        let mut v67: num_complex::Complex<f64> = v14.borrow().l1.clone();
        v67.clone()
    } else {
        let mut v69: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
        let mut v71: num_complex::Complex<f64> = v69 - v1;
        let mut v72: num_complex::Complex<f64> = method4(v71.clone());
        let mut v73: Result<num_complex::Complex<f64>, std::string::String> = method19(v0.clone(), v72.clone());
        let mut v75: Option<num_complex::Complex<f64>> = v73.ok();
        let mut v160: Option<num_complex::Complex<f64>> = method20(v75.clone());
        let mut v161: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = closure0();
        let mut v162: Option<US0> = v160.map(|x| v161(x));
        let mut v251: US0 = US0::US0_1;
        let mut v252: US0 = v162.unwrap_or(v251);
        let mut v264: f64 = f64::NAN;
        let mut v266: f64 = f64::NAN;
        let mut v268: num_complex::Complex<f64> = num_complex::Complex::new(v264, v266);
        let mut v271: num_complex::Complex<f64> = match &v252 {
            US0::US0_1 => {
                v268.clone()
            }
            US0::US0_0(v269) => {
                let mut v269: num_complex::Complex<f64> = v269.clone();
                v269.clone()
            }
        };
        let mut v273: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
        let mut v275: num_complex::Complex<f64> = v273 * v1;
        let mut v277: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
        let mut v279: num_complex::Complex<f64> = v275 / v277;
        let mut v281: num_complex::Complex<f64> = v279.sin();
        let mut v283: f64 = v1.re;
        let mut v284: f64 = 1.0f64 - v283;
        let mut v286: f64 = v1.im;
        let mut v287: f64 = -(v286);
        let mut v289: num_complex::Complex<f64> = num_complex::Complex::new(v284, v287);
        let mut v291: f64 = v289.re;
        let mut v292: bool = v291 <= 1.0f64;
        let mut v655: num_complex::Complex<f64> = if v292 {
            let mut v294: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
            v294.clone()
        } else {
            println!("zeta / count: {:?} / s: {:?}", 1i32, v289);
            let mut v297: f64 = v289.re;
            let mut v298: bool = v297 > 1.0f64;
            if v298 {
                let mut v300: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                let mut v301: Rc<RefCell<Vec<i32>>> = Rc::new(RefCell::new(vec![<i32>::default(); 10000i32 as usize]));
                let mut v302: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 0i32 }));
                while method17(v302.clone()) {
                    let mut v304: i32 = v302.borrow().l0.clone();
                    v301.clone().borrow_mut()[v304 as usize] = v304;
                    let mut v305: i32 = v304.wrapping_add(1i32);
                    v302.borrow_mut().l0 = v305;
                    ()
                };
                let mut v306: i32 = (v301.clone().borrow().len() as i32);
                let mut v307: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: 0i32, l1: v300.clone() }));
                while method18(v306, v307.clone()) {
                    let mut v309: i32 = v307.borrow().l0.clone();
                    let mut v310: num_complex::Complex<f64> = v307.borrow().l1.clone();
                    let mut v311: i32 = v301.clone().borrow()[v309 as usize].clone();
                    let mut v313: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                    let mut v314: f64 = (v311 as f64);
                    let mut v316: num_complex::Complex<f64> = num_complex::Complex::new(v314, 0.0f64);
                    let mut v318: num_complex::Complex<f64> = num_complex::Complex::powc(v316, v289.clone());
                    let mut v320: num_complex::Complex<f64> = v313 / v318;
                    let mut v322: num_complex::Complex<f64> = v310 + v320;
                    let mut v323: i32 = v309.wrapping_add(1i32);
                    v307.borrow_mut().l0 = v323;
                    v307.borrow_mut().l1 = v322.clone();
                    ()
                };
                let mut v324: num_complex::Complex<f64> = v307.borrow().l1.clone();
                v324.clone()
            } else {
                let mut v326: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                let mut v328: num_complex::Complex<f64> = v326 - v289;
                let mut v329: num_complex::Complex<f64> = method4(v328.clone());
                let mut v330: Result<num_complex::Complex<f64>, std::string::String> = method19(v0.clone(), v329.clone());
                let mut v332: Option<num_complex::Complex<f64>> = v330.ok();
                let mut v333: Option<num_complex::Complex<f64>> = method20(v332.clone());
                let mut v334: Option<US0> = v333.map(|x| v161(x));
                let mut v335: US0 = US0::US0_1;
                let mut v336: US0 = v334.unwrap_or(v335);
                let mut v338: f64 = f64::NAN;
                let mut v340: f64 = f64::NAN;
                let mut v342: num_complex::Complex<f64> = num_complex::Complex::new(v338, v340);
                let mut v345: num_complex::Complex<f64> = match &v336 {
                    US0::US0_1 => {
                        v342.clone()
                    }
                    US0::US0_0(v343) => {
                        let mut v343: num_complex::Complex<f64> = v343.clone();
                        v343.clone()
                    }
                };
                let mut v347: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                let mut v349: num_complex::Complex<f64> = v347 * v289;
                let mut v351: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                let mut v353: num_complex::Complex<f64> = v349 / v351;
                let mut v355: num_complex::Complex<f64> = v353.sin();
                let mut v357: f64 = v289.re;
                let mut v358: f64 = 1.0f64 - v357;
                let mut v360: f64 = v289.im;
                let mut v361: f64 = -(v360);
                let mut v363: num_complex::Complex<f64> = num_complex::Complex::new(v358, v361);
                let mut v365: f64 = v363.re;
                let mut v366: bool = v365 <= 1.0f64;
                let mut v639: num_complex::Complex<f64> = if v366 {
                    let mut v368: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                    v368.clone()
                } else {
                    println!("zeta / count: {:?} / s: {:?}", 2i32, v363);
                    let mut v371: f64 = v363.re;
                    let mut v372: bool = v371 > 1.0f64;
                    if v372 {
                        let mut v374: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                        let mut v375: Rc<RefCell<Vec<i32>>> = Rc::new(RefCell::new(vec![<i32>::default(); 10000i32 as usize]));
                        let mut v376: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 0i32 }));
                        while method17(v376.clone()) {
                            let mut v378: i32 = v376.borrow().l0.clone();
                            v375.clone().borrow_mut()[v378 as usize] = v378;
                            let mut v379: i32 = v378.wrapping_add(1i32);
                            v376.borrow_mut().l0 = v379;
                            ()
                        };
                        let mut v380: i32 = (v375.clone().borrow().len() as i32);
                        let mut v381: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: 0i32, l1: v374.clone() }));
                        while method18(v380, v381.clone()) {
                            let mut v383: i32 = v381.borrow().l0.clone();
                            let mut v384: num_complex::Complex<f64> = v381.borrow().l1.clone();
                            let mut v385: i32 = v375.clone().borrow()[v383 as usize].clone();
                            let mut v387: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                            let mut v388: f64 = (v385 as f64);
                            let mut v390: num_complex::Complex<f64> = num_complex::Complex::new(v388, 0.0f64);
                            let mut v392: num_complex::Complex<f64> = num_complex::Complex::powc(v390, v363.clone());
                            let mut v394: num_complex::Complex<f64> = v387 / v392;
                            let mut v396: num_complex::Complex<f64> = v384 + v394;
                            let mut v397: i32 = v383.wrapping_add(1i32);
                            v381.borrow_mut().l0 = v397;
                            v381.borrow_mut().l1 = v396.clone();
                            ()
                        };
                        let mut v398: num_complex::Complex<f64> = v381.borrow().l1.clone();
                        v398.clone()
                    } else {
                        let mut v400: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                        let mut v402: num_complex::Complex<f64> = v400 - v363;
                        let mut v403: num_complex::Complex<f64> = method4(v402.clone());
                        let mut v404: Result<num_complex::Complex<f64>, std::string::String> = method19(v0.clone(), v403.clone());
                        let mut v406: Option<num_complex::Complex<f64>> = v404.ok();
                        let mut v407: Option<num_complex::Complex<f64>> = method20(v406.clone());
                        let mut v408: Option<US0> = v407.map(|x| v161(x));
                        let mut v409: US0 = US0::US0_1;
                        let mut v410: US0 = v408.unwrap_or(v409);
                        let mut v412: f64 = f64::NAN;
                        let mut v414: f64 = f64::NAN;
                        let mut v416: num_complex::Complex<f64> = num_complex::Complex::new(v412, v414);
                        let mut v419: num_complex::Complex<f64> = match &v410 {
                            US0::US0_1 => {
                                v416.clone()
                            }
                            US0::US0_0(v417) => {
                                let mut v417: num_complex::Complex<f64> = v417.clone();
                                v417.clone()
                            }
                        };
                        let mut v421: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                        let mut v423: num_complex::Complex<f64> = v421 * v363;
                        let mut v425: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                        let mut v427: num_complex::Complex<f64> = v423 / v425;
                        let mut v429: num_complex::Complex<f64> = v427.sin();
                        let mut v431: f64 = v363.re;
                        let mut v432: f64 = 1.0f64 - v431;
                        let mut v434: f64 = v363.im;
                        let mut v435: f64 = -(v434);
                        let mut v437: num_complex::Complex<f64> = num_complex::Complex::new(v432, v435);
                        let mut v439: f64 = v437.re;
                        let mut v440: bool = v439 <= 1.0f64;
                        let mut v623: num_complex::Complex<f64> = if v440 {
                            let mut v442: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                            v442.clone()
                        } else {
                            println!("zeta / count: {:?} / s: {:?}", 3i32, v437);
                            let mut v445: f64 = v437.re;
                            let mut v446: bool = v445 > 1.0f64;
                            if v446 {
                                let mut v448: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                                let mut v449: Rc<RefCell<Vec<i32>>> = Rc::new(RefCell::new(vec![<i32>::default(); 10000i32 as usize]));
                                let mut v450: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 0i32 }));
                                while method17(v450.clone()) {
                                    let mut v452: i32 = v450.borrow().l0.clone();
                                    v449.clone().borrow_mut()[v452 as usize] = v452;
                                    let mut v453: i32 = v452.wrapping_add(1i32);
                                    v450.borrow_mut().l0 = v453;
                                    ()
                                };
                                let mut v454: i32 = (v449.clone().borrow().len() as i32);
                                let mut v455: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: 0i32, l1: v448.clone() }));
                                while method18(v454, v455.clone()) {
                                    let mut v457: i32 = v455.borrow().l0.clone();
                                    let mut v458: num_complex::Complex<f64> = v455.borrow().l1.clone();
                                    let mut v459: i32 = v449.clone().borrow()[v457 as usize].clone();
                                    let mut v461: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                                    let mut v462: f64 = (v459 as f64);
                                    let mut v464: num_complex::Complex<f64> = num_complex::Complex::new(v462, 0.0f64);
                                    let mut v466: num_complex::Complex<f64> = num_complex::Complex::powc(v464, v437.clone());
                                    let mut v468: num_complex::Complex<f64> = v461 / v466;
                                    let mut v470: num_complex::Complex<f64> = v458 + v468;
                                    let mut v471: i32 = v457.wrapping_add(1i32);
                                    v455.borrow_mut().l0 = v471;
                                    v455.borrow_mut().l1 = v470.clone();
                                    ()
                                };
                                let mut v472: num_complex::Complex<f64> = v455.borrow().l1.clone();
                                v472.clone()
                            } else {
                                let mut v474: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                                let mut v476: num_complex::Complex<f64> = v474 - v437;
                                let mut v477: num_complex::Complex<f64> = method4(v476.clone());
                                let mut v478: Result<num_complex::Complex<f64>, std::string::String> = method19(v0.clone(), v477.clone());
                                let mut v480: Option<num_complex::Complex<f64>> = v478.ok();
                                let mut v481: Option<num_complex::Complex<f64>> = method20(v480.clone());
                                let mut v482: Option<US0> = v481.map(|x| v161(x));
                                let mut v483: US0 = US0::US0_1;
                                let mut v484: US0 = v482.unwrap_or(v483);
                                let mut v486: f64 = f64::NAN;
                                let mut v488: f64 = f64::NAN;
                                let mut v490: num_complex::Complex<f64> = num_complex::Complex::new(v486, v488);
                                let mut v493: num_complex::Complex<f64> = match &v484 {
                                    US0::US0_1 => {
                                        v490.clone()
                                    }
                                    US0::US0_0(v491) => {
                                        let mut v491: num_complex::Complex<f64> = v491.clone();
                                        v491.clone()
                                    }
                                };
                                let mut v495: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                                let mut v497: num_complex::Complex<f64> = v495 * v437;
                                let mut v499: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                                let mut v501: num_complex::Complex<f64> = v497 / v499;
                                let mut v503: num_complex::Complex<f64> = v501.sin();
                                let mut v505: f64 = v437.re;
                                let mut v506: f64 = 1.0f64 - v505;
                                let mut v508: f64 = v437.im;
                                let mut v509: f64 = -(v508);
                                let mut v511: num_complex::Complex<f64> = num_complex::Complex::new(v506, v509);
                                let mut v513: f64 = v511.re;
                                let mut v514: bool = v513 <= 1.0f64;
                                let mut v607: num_complex::Complex<f64> = if v514 {
                                    let mut v516: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                                    v516.clone()
                                } else {
                                    println!("zeta / count: {:?} / s: {:?}", 4i32, v511);
                                    let mut v519: f64 = v511.re;
                                    let mut v520: bool = v519 > 1.0f64;
                                    if v520 {
                                        let mut v522: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                                        let mut v523: Rc<RefCell<Vec<i32>>> = Rc::new(RefCell::new(vec![<i32>::default(); 10000i32 as usize]));
                                        let mut v524: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 0i32 }));
                                        while method17(v524.clone()) {
                                            let mut v526: i32 = v524.borrow().l0.clone();
                                            v523.clone().borrow_mut()[v526 as usize] = v526;
                                            let mut v527: i32 = v526.wrapping_add(1i32);
                                            v524.borrow_mut().l0 = v527;
                                            ()
                                        };
                                        let mut v528: i32 = (v523.clone().borrow().len() as i32);
                                        let mut v529: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: 0i32, l1: v522.clone() }));
                                        while method18(v528, v529.clone()) {
                                            let mut v531: i32 = v529.borrow().l0.clone();
                                            let mut v532: num_complex::Complex<f64> = v529.borrow().l1.clone();
                                            let mut v533: i32 = v523.clone().borrow()[v531 as usize].clone();
                                            let mut v535: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                                            let mut v536: f64 = (v533 as f64);
                                            let mut v538: num_complex::Complex<f64> = num_complex::Complex::new(v536, 0.0f64);
                                            let mut v540: num_complex::Complex<f64> = num_complex::Complex::powc(v538, v511.clone());
                                            let mut v542: num_complex::Complex<f64> = v535 / v540;
                                            let mut v544: num_complex::Complex<f64> = v532 + v542;
                                            let mut v545: i32 = v531.wrapping_add(1i32);
                                            v529.borrow_mut().l0 = v545;
                                            v529.borrow_mut().l1 = v544.clone();
                                            ()
                                        };
                                        let mut v546: num_complex::Complex<f64> = v529.borrow().l1.clone();
                                        v546.clone()
                                    } else {
                                        let mut v548: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                                        let mut v550: num_complex::Complex<f64> = v548 - v511;
                                        let mut v551: num_complex::Complex<f64> = method4(v550.clone());
                                        let mut v552: Result<num_complex::Complex<f64>, std::string::String> = method19(v0.clone(), v551.clone());
                                        let mut v554: Option<num_complex::Complex<f64>> = v552.ok();
                                        let mut v555: Option<num_complex::Complex<f64>> = method20(v554.clone());
                                        let mut v556: Option<US0> = v555.map(|x| v161(x));
                                        let mut v557: US0 = US0::US0_1;
                                        let mut v558: US0 = v556.unwrap_or(v557);
                                        let mut v560: f64 = f64::NAN;
                                        let mut v562: f64 = f64::NAN;
                                        let mut v564: num_complex::Complex<f64> = num_complex::Complex::new(v560, v562);
                                        let mut v567: num_complex::Complex<f64> = match &v558 {
                                            US0::US0_1 => {
                                                v564.clone()
                                            }
                                            US0::US0_0(v565) => {
                                                let mut v565: num_complex::Complex<f64> = v565.clone();
                                                v565.clone()
                                            }
                                        };
                                        let mut v569: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                                        let mut v571: num_complex::Complex<f64> = v569 * v511;
                                        let mut v573: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                                        let mut v575: num_complex::Complex<f64> = v571 / v573;
                                        let mut v577: num_complex::Complex<f64> = v575.sin();
                                        let mut v579: f64 = v511.re;
                                        let mut v580: f64 = 1.0f64 - v579;
                                        let mut v582: f64 = v511.im;
                                        let mut v583: f64 = -(v582);
                                        let mut v585: num_complex::Complex<f64> = num_complex::Complex::new(v580, v583);
                                        let mut v587: f64 = v585.re;
                                        let mut v588: bool = v587 <= 1.0f64;
                                        let mut v591: num_complex::Complex<f64> = if v588 {
                                            let mut v590: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                                            v590.clone()
                                        } else {
                                            v585.clone()
                                        };
                                        let mut v593: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                                        let mut v595: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                                        let mut v597: num_complex::Complex<f64> = num_complex::Complex::powc(v595, v511);
                                        let mut v599: num_complex::Complex<f64> = v593 * v597;
                                        let mut v601: num_complex::Complex<f64> = v599 * v577;
                                        let mut v603: num_complex::Complex<f64> = v601 * v567;
                                        let mut v605: num_complex::Complex<f64> = v603 * v591;
                                        v605.clone()
                                    }
                                };
                                let mut v609: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                                let mut v611: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                                let mut v613: num_complex::Complex<f64> = num_complex::Complex::powc(v611, v437);
                                let mut v615: num_complex::Complex<f64> = v609 * v613;
                                let mut v617: num_complex::Complex<f64> = v615 * v503;
                                let mut v619: num_complex::Complex<f64> = v617 * v493;
                                let mut v621: num_complex::Complex<f64> = v619 * v607;
                                v621.clone()
                            }
                        };
                        let mut v625: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                        let mut v627: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                        let mut v629: num_complex::Complex<f64> = num_complex::Complex::powc(v627, v363);
                        let mut v631: num_complex::Complex<f64> = v625 * v629;
                        let mut v633: num_complex::Complex<f64> = v631 * v429;
                        let mut v635: num_complex::Complex<f64> = v633 * v419;
                        let mut v637: num_complex::Complex<f64> = v635 * v623;
                        v637.clone()
                    }
                };
                let mut v641: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                let mut v643: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                let mut v645: num_complex::Complex<f64> = num_complex::Complex::powc(v643, v289);
                let mut v647: num_complex::Complex<f64> = v641 * v645;
                let mut v649: num_complex::Complex<f64> = v647 * v355;
                let mut v651: num_complex::Complex<f64> = v649 * v345;
                let mut v653: num_complex::Complex<f64> = v651 * v639;
                v653.clone()
            }
        };
        let mut v657: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
        let mut v659: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
        let mut v661: num_complex::Complex<f64> = num_complex::Complex::powc(v659, v1);
        let mut v663: num_complex::Complex<f64> = v657 * v661;
        let mut v665: num_complex::Complex<f64> = v663 * v281;
        let mut v667: num_complex::Complex<f64> = v665 * v271;
        let mut v669: num_complex::Complex<f64> = v667 * v655;
        v669.clone()
    }
}
fn method21(mut v0: bool) -> bool {
    v0
}
fn method23(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method24(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method25(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method26(mut v0: Rc<RefCell<Mut3>>, mut v1: Rc<str>) -> () {
    let mut v2: Rc<str> = v0.borrow().l0.clone();
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v2, v1));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method27(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method22(mut v0: f64) -> Rc<str> {
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v6.clone() }));
    method23(v7.clone());
    method24(v7.clone());
    method25(v7.clone());
    let mut v101: Rc<str> = Rc::<str>::from({ let v = v0; if v.is_finite() { format!("{:+.6}", v) } else if v.is_nan() { String::from("NaN") } else if v > 0.0 { String::from("Infinity") } else { String::from("-Infinity") } });
    method26(v7.clone(), v101.clone());
    method27(v7.clone());
    let mut v139: Rc<str> = v7.borrow().l0.clone();
    v139.clone()
}
fn method29(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("actual"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method30(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method28(mut v0: f64, mut v1: f64) -> Rc<str> {
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v2.clone() }));
    method23(v3.clone());
    method29(v3.clone());
    method25(v3.clone());
    let mut v29: Rc<str> = Rc::<str>::from({ let v = v0; if v.is_finite() { format!("{:+.6}", v) } else if v.is_nan() { String::from("NaN") } else if v > 0.0 { String::from("Infinity") } else { String::from("-Infinity") } });
    method26(v3.clone(), v29.clone());
    method30(v3.clone());
    method24(v3.clone());
    method25(v3.clone());
    let mut v55: Rc<str> = Rc::<str>::from({ let v = v1; if v.is_finite() { format!("{:+.6}", v) } else if v.is_nan() { String::from("NaN") } else if v > 0.0 { String::from("Infinity") } else { String::from("-Infinity") } });
    method26(v3.clone(), v55.clone());
    method27(v3.clone());
    let mut v56: Rc<str> = v3.borrow().l0.clone();
    v56.clone()
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
        let mut v20: US0 = US0::US0_1;
        let mut v21: US0 = v19.unwrap_or(v20);
        let mut v23: f64 = f64::NAN;
        let mut v25: f64 = f64::NAN;
        let mut v27: num_complex::Complex<f64> = num_complex::Complex::new(v23, v25);
        let mut v30: num_complex::Complex<f64> = match &v21 {
            US0::US0_1 => {
                v27.clone()
            }
            US0::US0_0(v28) => {
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
        let mut v40: Rc<str> = if v33 {
            let mut v36: f64 = 0.0f64;
            method22(v36)
        } else {
            let mut v38: f64 = 0.0f64;
            method28(v32, v38)
        };
        let mut v55: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq"); } LIT.with(|lit| lit.clone()) };
        let mut v56: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
        let mut v57: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
        let mut v67: Rc<str> = if v33 {
            let mut v63: f64 = 0.0f64;
            method22(v63)
        } else {
            let mut v65: f64 = 0.0f64;
            method28(v32, v65)
        };
        let mut v68: Rc<str> = Rc::<str>::from(format!("{}{}", v57, v67));
        println!("{}", v68);
        let mut v72: bool = v35 == false;
        if v72 {
            std::panic::panic_any::<std::string::String>(format!("{}", v68.clone()))
        };
        let mut v74: f64 = v30.re;
        let mut v75: f64 = v74 - v11;
        let mut v76: f64 = -(v75);
        let mut v77: bool = v75 >= v76;
        let mut v78: f64 = if v77 {
            v75
        } else {
            v76
        };
        let mut v79: bool = v78 < 0.0001f64;
        let mut v81: bool = if v79 {
            true
        } else {
            method21(v79)
        };
        let mut v86: Rc<str> = if v79 {
            let mut v82: f64 = 0.0001f64;
            method22(v82)
        } else {
            let mut v84: f64 = 0.0001f64;
            method28(v78, v84)
        };
        let mut v97: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt"); } LIT.with(|lit| lit.clone()) };
        let mut v98: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
        let mut v108: Rc<str> = if v79 {
            let mut v104: f64 = 0.0001f64;
            method22(v104)
        } else {
            let mut v106: f64 = 0.0001f64;
            method28(v78, v106)
        };
        let mut v109: Rc<str> = Rc::<str>::from(format!("{}{}", v98, v108));
        println!("{}", v109);
        let mut v110: bool = v81 == false;
        if v110 {
            std::panic::panic_any::<std::string::String>(format!("{}", v109.clone()))
        };
        let mut v111: i32 = v9.wrapping_add(1i32);
        v7.borrow_mut().l0 = v111;
        ()
    };
    ()
}
fn method1() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method2(v3.clone());
    let mut v22: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v64: bool = true; (v22) }); //;
    let mut v67: Result<(), pyo3::PyErr> = __run_test;
    v67.unwrap();
    ()
}
fn method32(mut v0: pyo3::Python) -> () {
    let mut v2: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, -2.0f64);
    let mut v3: num_complex::Complex<f64> = method4(v2.clone());
    let mut v4: Result<num_complex::Complex<f64>, std::string::String> = method5(v0.clone(), v3.clone());
    let mut v5: num_complex::Complex<f64> = method16(v0.clone(), v2.clone());
    let mut v7: Option<num_complex::Complex<f64>> = v4.ok();
    let mut v8: Option<num_complex::Complex<f64>> = method20(v7.clone());
    let mut v9: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = closure0();
    let mut v10: Option<US0> = v8.map(|x| v9(x));
    let mut v11: US0 = US0::US0_1;
    let mut v12: US0 = v10.unwrap_or(v11);
    let mut v14: f64 = f64::NAN;
    let mut v16: f64 = f64::NAN;
    let mut v18: num_complex::Complex<f64> = num_complex::Complex::new(v14, v16);
    let mut v21: num_complex::Complex<f64> = match &v12 {
        US0::US0_1 => {
            v18.clone()
        }
        US0::US0_0(v19) => {
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
    let mut v35: Rc<str> = if v28 {
        let mut v31: f64 = 0.001f64;
        method22(v31)
    } else {
        let mut v33: f64 = 0.001f64;
        method28(v27, v33)
    };
    let mut v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt"); } LIT.with(|lit| lit.clone()) };
    let mut v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
    let mut v43: Rc<str> = if v28 {
        let mut v39: f64 = 0.001f64;
        method22(v39)
    } else {
        let mut v41: f64 = 0.001f64;
        method28(v27, v41)
    };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v43));
    println!("{}", v44);
    let mut v45: bool = v30 == false;
    if v45 {
        std::panic::panic_any::<std::string::String>(format!("{}", v44.clone()))
    };
    let mut v47: f64 = v21.im;
    let mut v48: f64 = v47 - 0.275f64;
    let mut v49: f64 = -(v48);
    let mut v50: bool = v48 >= v49;
    let mut v51: f64 = if v50 {
        v48
    } else {
        v49
    };
    let mut v52: bool = v51 < 0.001f64;
    let mut v54: bool = if v52 {
        true
    } else {
        method21(v52)
    };
    let mut v59: Rc<str> = if v52 {
        let mut v55: f64 = 0.001f64;
        method22(v55)
    } else {
        let mut v57: f64 = 0.001f64;
        method28(v51, v57)
    };
    let mut v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
    let mut v65: Rc<str> = if v52 {
        let mut v61: f64 = 0.001f64;
        method22(v61)
    } else {
        let mut v63: f64 = 0.001f64;
        method28(v51, v63)
    };
    let mut v66: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v65));
    println!("{}", v66);
    let mut v67: bool = v54 == false;
    if v67 {
        std::panic::panic_any::<std::string::String>(format!("{}", v66.clone()))
    }
}
fn method31() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method32(v3.clone());
    let mut v4: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v5: bool = true; (v4) }); //;
    let mut v7: Result<(), pyo3::PyErr> = __run_test;
    v7.unwrap();
    ()
}
fn method35(mut v0: pyo3::Python, mut v1: Rc<UH0>) -> () {
    loop {
        match &*v1 {
            UH0::UH0_1(v2, v3) => {
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
                let mut v14: US0 = US0::US0_1;
                let mut v15: US0 = v13.unwrap_or(v14);
                let mut v17: f64 = f64::NAN;
                let mut v19: f64 = f64::NAN;
                let mut v21: num_complex::Complex<f64> = num_complex::Complex::new(v17, v19);
                let mut v24: num_complex::Complex<f64> = match &v15 {
                    US0::US0_1 => {
                        v21.clone()
                    }
                    US0::US0_0(v22) => {
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
                let mut v34: Rc<str> = if v27 {
                    let mut v30: f64 = 0.0f64;
                    method22(v30)
                } else {
                    let mut v32: f64 = 0.0f64;
                    method28(v26, v32)
                };
                let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq"); } LIT.with(|lit| lit.clone()) };
                let mut v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
                let mut v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
                let mut v42: Rc<str> = if v27 {
                    let mut v38: f64 = 0.0f64;
                    method22(v38)
                } else {
                    let mut v40: f64 = 0.0f64;
                    method28(v26, v40)
                };
                let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v42));
                println!("{}", v43);
                let mut v44: bool = v29 == false;
                if v44 {
                    std::panic::panic_any::<std::string::String>(format!("{}", v43.clone()))
                };
                let mut v46: f64 = v24.im;
                let mut v47: bool = v46 == 0.0f64;
                let mut v49: bool = if v47 {
                    true
                } else {
                    method21(v47)
                };
                let mut v54: Rc<str> = if v47 {
                    let mut v50: f64 = 0.0f64;
                    method22(v50)
                } else {
                    let mut v52: f64 = 0.0f64;
                    method28(v46, v52)
                };
                let mut v55: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
                let mut v60: Rc<str> = if v47 {
                    let mut v56: f64 = 0.0f64;
                    method22(v56)
                } else {
                    let mut v58: f64 = 0.0f64;
                    method28(v46, v58)
                };
                let mut v61: Rc<str> = Rc::<str>::from(format!("{}{}", v55, v60));
                println!("{}", v61);
                let mut v62: bool = v49 == false;
                if v62 {
                    std::panic::panic_any::<std::string::String>(format!("{}", v61.clone()))
                };
                (v0, v1) = (v0.clone(), v3.clone());
                continue;
            }
            UH0::UH0_0 => {
                return ();
            }
        }
        return ();
    }
}
fn method36() -> Rc<UH0> {
    let mut v0: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
    let mut v1: Rc<UH0> = Rc::new(UH0::UH0_1(-40.0f64, v0.clone()));
    let mut v2: Rc<UH0> = Rc::new(UH0::UH0_1(-38.0f64, v1.clone()));
    let mut v3: Rc<UH0> = Rc::new(UH0::UH0_1(-36.0f64, v2.clone()));
    let mut v4: Rc<UH0> = Rc::new(UH0::UH0_1(-34.0f64, v3.clone()));
    let mut v5: Rc<UH0> = Rc::new(UH0::UH0_1(-32.0f64, v4.clone()));
    let mut v6: Rc<UH0> = Rc::new(UH0::UH0_1(-30.0f64, v5.clone()));
    let mut v7: Rc<UH0> = Rc::new(UH0::UH0_1(-28.0f64, v6.clone()));
    let mut v8: Rc<UH0> = Rc::new(UH0::UH0_1(-26.0f64, v7.clone()));
    let mut v9: Rc<UH0> = Rc::new(UH0::UH0_1(-24.0f64, v8.clone()));
    let mut v10: Rc<UH0> = Rc::new(UH0::UH0_1(-22.0f64, v9.clone()));
    let mut v11: Rc<UH0> = Rc::new(UH0::UH0_1(-20.0f64, v10.clone()));
    let mut v12: Rc<UH0> = Rc::new(UH0::UH0_1(-18.0f64, v11.clone()));
    let mut v13: Rc<UH0> = Rc::new(UH0::UH0_1(-16.0f64, v12.clone()));
    let mut v14: Rc<UH0> = Rc::new(UH0::UH0_1(-14.0f64, v13.clone()));
    let mut v15: Rc<UH0> = Rc::new(UH0::UH0_1(-12.0f64, v14.clone()));
    let mut v16: Rc<UH0> = Rc::new(UH0::UH0_1(-10.0f64, v15.clone()));
    let mut v17: Rc<UH0> = Rc::new(UH0::UH0_1(-8.0f64, v16.clone()));
    let mut v18: Rc<UH0> = Rc::new(UH0::UH0_1(-6.0f64, v17.clone()));
    let mut v19: Rc<UH0> = Rc::new(UH0::UH0_1(-4.0f64, v18.clone()));
    Rc::new(UH0::UH0_1(-2.0f64, v19.clone()))
}
fn method34(mut v0: pyo3::Python) -> () {
    let mut v1: Rc<UH0> = method36();
    method35(v0.clone(), v1.clone())
}
fn method33() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method34(v3.clone());
    let mut v4: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v5: bool = true; (v4) }); //;
    let mut v7: Result<(), pyo3::PyErr> = __run_test;
    v7.unwrap();
    ()
}
fn method38(mut v0: pyo3::Python) -> () {
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
        let mut v27: US0 = US0::US0_1;
        let mut v28: US0 = v26.unwrap_or(v27);
        let mut v30: f64 = f64::NAN;
        let mut v32: f64 = f64::NAN;
        let mut v34: num_complex::Complex<f64> = num_complex::Complex::new(v30, v32);
        let mut v37: num_complex::Complex<f64> = match &v28 {
            US0::US0_1 => {
                v34.clone()
            }
            US0::US0_0(v35) => {
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
        let mut v50: Rc<str> = if v43 {
            let mut v46: f64 = 0.0001f64;
            method22(v46)
        } else {
            let mut v48: f64 = 0.0001f64;
            method28(v42, v48)
        };
        let mut v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt"); } LIT.with(|lit| lit.clone()) };
        let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
        let mut v53: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
        let mut v58: Rc<str> = if v43 {
            let mut v54: f64 = 0.0001f64;
            method22(v54)
        } else {
            let mut v56: f64 = 0.0001f64;
            method28(v42, v56)
        };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v53, v58));
        println!("{}", v59);
        let mut v60: bool = v45 == false;
        if v60 {
            std::panic::panic_any::<std::string::String>(format!("{}", v59.clone()))
        };
        let mut v62: f64 = v37.im;
        let mut v63: f64 = -(v62);
        let mut v64: bool = v62 >= v63;
        let mut v65: f64 = if v64 {
            v62
        } else {
            v63
        };
        let mut v66: bool = v65 < 0.0001f64;
        let mut v68: bool = if v66 {
            true
        } else {
            method21(v66)
        };
        let mut v73: Rc<str> = if v66 {
            let mut v69: f64 = 0.0001f64;
            method22(v69)
        } else {
            let mut v71: f64 = 0.0001f64;
            method28(v65, v71)
        };
        let mut v74: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
        let mut v79: Rc<str> = if v66 {
            let mut v75: f64 = 0.0001f64;
            method22(v75)
        } else {
            let mut v77: f64 = 0.0001f64;
            method28(v65, v77)
        };
        let mut v80: Rc<str> = Rc::<str>::from(format!("{}{}", v74, v79));
        println!("{}", v80);
        let mut v81: bool = v68 == false;
        if v81 {
            std::panic::panic_any::<std::string::String>(format!("{}", v80.clone()))
        };
        let mut v82: i32 = v17.wrapping_add(1i32);
        v15.borrow_mut().l0 = v82;
        ()
    };
    ()
}
fn method37() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method38(v3.clone());
    let mut v4: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v5: bool = true; (v4) }); //;
    let mut v7: Result<(), pyo3::PyErr> = __run_test;
    v7.unwrap();
    ()
}
fn method40(mut v0: pyo3::Python) -> () {
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
        let mut v17: US0 = US0::US0_1;
        let mut v18: US0 = v16.unwrap_or(v17);
        let mut v20: f64 = f64::NAN;
        let mut v22: f64 = f64::NAN;
        let mut v24: num_complex::Complex<f64> = num_complex::Complex::new(v20, v22);
        let mut v27: num_complex::Complex<f64> = match &v18 {
            US0::US0_1 => {
                v24.clone()
            }
            US0::US0_0(v25) => {
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
        let mut v37: Rc<str> = if v30 {
            let mut v33: f64 = 0.0f64;
            method22(v33)
        } else {
            let mut v35: f64 = 0.0f64;
            method28(v29, v35)
        };
        let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_gt"); } LIT.with(|lit| lit.clone()) };
        let mut v53: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
        let mut v54: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_gt "); } LIT.with(|lit| lit.clone()) };
        let mut v64: Rc<str> = if v30 {
            let mut v60: f64 = 0.0f64;
            method22(v60)
        } else {
            let mut v62: f64 = 0.0f64;
            method28(v29, v62)
        };
        let mut v65: Rc<str> = Rc::<str>::from(format!("{}{}", v54, v64));
        println!("{}", v65);
        let mut v66: bool = v32 == false;
        if v66 {
            std::panic::panic_any::<std::string::String>(format!("{}", v65.clone()))
        };
        let mut v68: f64 = v27.im;
        let mut v69: bool = v68 == 0.0f64;
        let mut v71: bool = if v69 {
            true
        } else {
            method21(v69)
        };
        let mut v76: Rc<str> = if v69 {
            let mut v72: f64 = 0.0f64;
            method22(v72)
        } else {
            let mut v74: f64 = 0.0f64;
            method28(v68, v74)
        };
        let mut v77: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq"); } LIT.with(|lit| lit.clone()) };
        let mut v78: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
        let mut v83: Rc<str> = if v69 {
            let mut v79: f64 = 0.0f64;
            method22(v79)
        } else {
            let mut v81: f64 = 0.0f64;
            method28(v68, v81)
        };
        let mut v84: Rc<str> = Rc::<str>::from(format!("{}{}", v78, v83));
        println!("{}", v84);
        let mut v85: bool = v71 == false;
        if v85 {
            std::panic::panic_any::<std::string::String>(format!("{}", v84.clone()))
        };
        let mut v86: i32 = v5.wrapping_add(1i32);
        v3.borrow_mut().l0 = v86;
        ()
    };
    ()
}
fn method39() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method40(v3.clone());
    let mut v4: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v5: bool = true; (v4) }); //;
    let mut v7: Result<(), pyo3::PyErr> = __run_test;
    v7.unwrap();
    ()
}
fn method42(mut v0: pyo3::Python) -> () {
    let mut v2: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
    let mut v3: num_complex::Complex<f64> = method4(v2.clone());
    let mut v4: Result<num_complex::Complex<f64>, std::string::String> = method5(v0.clone(), v3.clone());
    let mut v5: num_complex::Complex<f64> = method16(v0.clone(), v2.clone());
    let mut v7: Option<num_complex::Complex<f64>> = v4.ok();
    let mut v8: Option<num_complex::Complex<f64>> = method20(v7.clone());
    let mut v9: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = closure0();
    let mut v10: Option<US0> = v8.map(|x| v9(x));
    let mut v11: US0 = US0::US0_1;
    let mut v12: US0 = v10.unwrap_or(v11);
    let mut v14: f64 = f64::NAN;
    let mut v16: f64 = f64::NAN;
    let mut v18: num_complex::Complex<f64> = num_complex::Complex::new(v14, v16);
    let mut v21: num_complex::Complex<f64> = match &v12 {
        US0::US0_1 => {
            v18.clone()
        }
        US0::US0_0(v19) => {
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
    let mut v31: Rc<str> = if v24 {
        let mut v27: f64 = f64::INFINITY;
        method22(v27)
    } else {
        let mut v29: f64 = f64::INFINITY;
        method28(v23, v29)
    };
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = if v24 {
        let mut v35: f64 = f64::INFINITY;
        method22(v35)
    } else {
        let mut v37: f64 = f64::INFINITY;
        method28(v23, v37)
    };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v39));
    println!("{}", v40);
    let mut v41: bool = v26 == false;
    if v41 {
        std::panic::panic_any::<std::string::String>(format!("{}", v40.clone()))
    };
    let mut v43: f64 = v21.im;
    let mut v44: bool = v43 == 0.0f64;
    let mut v46: bool = if v44 {
        true
    } else {
        method21(v44)
    };
    let mut v51: Rc<str> = if v44 {
        let mut v47: f64 = 0.0f64;
        method22(v47)
    } else {
        let mut v49: f64 = 0.0f64;
        method28(v43, v49)
    };
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
    let mut v57: Rc<str> = if v44 {
        let mut v53: f64 = 0.0f64;
        method22(v53)
    } else {
        let mut v55: f64 = 0.0f64;
        method28(v43, v55)
    };
    let mut v58: Rc<str> = Rc::<str>::from(format!("{}{}", v52, v57));
    println!("{}", v58);
    let mut v59: bool = v46 == false;
    if v59 {
        std::panic::panic_any::<std::string::String>(format!("{}", v58.clone()))
    }
}
fn method41() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method42(v3.clone());
    let mut v4: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v5: bool = true; (v4) }); //;
    let mut v7: Result<(), pyo3::PyErr> = __run_test;
    v7.unwrap();
    ()
}
fn method44(mut v0: pyo3::Python) -> () {
    let mut v2: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 10.0f64);
    let mut v3: num_complex::Complex<f64> = method4(v2.clone());
    let mut v4: Result<num_complex::Complex<f64>, std::string::String> = method5(v0.clone(), v3.clone());
    let mut v5: num_complex::Complex<f64> = method16(v0.clone(), v2.clone());
    let mut v7: Option<num_complex::Complex<f64>> = v4.ok();
    let mut v8: Option<num_complex::Complex<f64>> = method20(v7.clone());
    let mut v9: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = closure0();
    let mut v10: Option<US0> = v8.map(|x| v9(x));
    let mut v11: US0 = US0::US0_1;
    let mut v12: US0 = v10.unwrap_or(v11);
    let mut v14: f64 = f64::NAN;
    let mut v16: f64 = f64::NAN;
    let mut v18: num_complex::Complex<f64> = num_complex::Complex::new(v14, v16);
    let mut v21: num_complex::Complex<f64> = match &v12 {
        US0::US0_1 => {
            v18.clone()
        }
        US0::US0_0(v19) => {
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
    let mut v36: US0 = US0::US0_1;
    let mut v37: US0 = v35.unwrap_or(v36);
    let mut v39: f64 = f64::NAN;
    let mut v41: f64 = f64::NAN;
    let mut v43: num_complex::Complex<f64> = num_complex::Complex::new(v39, v41);
    let mut v46: num_complex::Complex<f64> = match &v37 {
        US0::US0_1 => {
            v43.clone()
        }
        US0::US0_0(v44) => {
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
    let mut v58: Rc<str> = if v53 {
        method22(v52)
    } else {
        method28(v50, v52)
    };
    let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq"); } LIT.with(|lit| lit.clone()) };
    let mut v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v61: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
    let mut v64: Rc<str> = if v53 {
        method22(v52)
    } else {
        method28(v50, v52)
    };
    let mut v65: Rc<str> = Rc::<str>::from(format!("{}{}", v61, v64));
    println!("{}", v65);
    let mut v66: bool = v55 == false;
    if v66 {
        std::panic::panic_any::<std::string::String>(format!("{}", v65.clone()))
    };
    let mut v68: f64 = v21.im;
    let mut v70: f64 = v48.im;
    let mut v71: bool = v68 == v70;
    let mut v73: bool = if v71 {
        true
    } else {
        method21(v71)
    };
    let mut v76: Rc<str> = if v71 {
        method22(v70)
    } else {
        method28(v68, v70)
    };
    let mut v77: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
    let mut v80: Rc<str> = if v71 {
        method22(v70)
    } else {
        method28(v68, v70)
    };
    let mut v81: Rc<str> = Rc::<str>::from(format!("{}{}", v77, v80));
    println!("{}", v81);
    let mut v82: bool = v73 == false;
    if v82 {
        std::panic::panic_any::<std::string::String>(format!("{}", v81.clone()))
    }
}
fn method43() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method44(v3.clone());
    let mut v4: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v5: bool = true; (v4) }); //;
    let mut v7: Result<(), pyo3::PyErr> = __run_test;
    v7.unwrap();
    ()
}
fn method46(mut v0: pyo3::Python) -> () {
    let mut v2: num_complex::Complex<f64> = num_complex::Complex::new(0.01f64, 0.01f64);
    let mut v3: num_complex::Complex<f64> = method4(v2.clone());
    let mut v4: Result<num_complex::Complex<f64>, std::string::String> = method5(v0.clone(), v3.clone());
    let mut v5: num_complex::Complex<f64> = method16(v0.clone(), v2.clone());
    let mut v7: Option<num_complex::Complex<f64>> = v4.ok();
    let mut v8: Option<num_complex::Complex<f64>> = method20(v7.clone());
    let mut v9: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = closure0();
    let mut v10: Option<US0> = v8.map(|x| v9(x));
    let mut v11: US0 = US0::US0_1;
    let mut v12: US0 = v10.unwrap_or(v11);
    let mut v14: f64 = f64::NAN;
    let mut v16: f64 = f64::NAN;
    let mut v18: num_complex::Complex<f64> = num_complex::Complex::new(v14, v16);
    let mut v21: num_complex::Complex<f64> = match &v12 {
        US0::US0_1 => {
            v18.clone()
        }
        US0::US0_0(v19) => {
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
    let mut v31: Rc<str> = if v24 {
        let mut v27: f64 = f64::INFINITY;
        method22(v27)
    } else {
        let mut v29: f64 = f64::INFINITY;
        method28(v23, v29)
    };
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = if v24 {
        let mut v35: f64 = f64::INFINITY;
        method22(v35)
    } else {
        let mut v37: f64 = f64::INFINITY;
        method28(v23, v37)
    };
    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v39));
    println!("{}", v40);
    let mut v41: bool = v26 == false;
    if v41 {
        std::panic::panic_any::<std::string::String>(format!("{}", v40.clone()))
    };
    let mut v43: f64 = v21.im;
    let mut v44: bool = v43 < f64::INFINITY;
    let mut v46: bool = if v44 {
        true
    } else {
        method21(v44)
    };
    let mut v51: Rc<str> = if v44 {
        let mut v47: f64 = f64::INFINITY;
        method22(v47)
    } else {
        let mut v49: f64 = f64::INFINITY;
        method28(v43, v49)
    };
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
    let mut v57: Rc<str> = if v44 {
        let mut v53: f64 = f64::INFINITY;
        method22(v53)
    } else {
        let mut v55: f64 = f64::INFINITY;
        method28(v43, v55)
    };
    let mut v58: Rc<str> = Rc::<str>::from(format!("{}{}", v52, v57));
    println!("{}", v58);
    let mut v59: bool = v46 == false;
    if v59 {
        std::panic::panic_any::<std::string::String>(format!("{}", v58.clone()))
    }
}
fn method45() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method46(v3.clone());
    let mut v4: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v5: bool = true; (v4) }); //;
    let mut v7: Result<(), pyo3::PyErr> = __run_test;
    v7.unwrap();
    ()
}
fn method49(mut v0: pyo3::Python, mut v1: Rc<UH0>) -> () {
    loop {
        match &*v1 {
            UH0::UH0_1(v2, v3) => {
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
                let mut v14: US0 = US0::US0_1;
                let mut v15: US0 = v13.unwrap_or(v14);
                let mut v17: f64 = f64::NAN;
                let mut v19: f64 = f64::NAN;
                let mut v21: num_complex::Complex<f64> = num_complex::Complex::new(v17, v19);
                let mut v24: num_complex::Complex<f64> = match &v15 {
                    US0::US0_1 => {
                        v21.clone()
                    }
                    US0::US0_0(v22) => {
                        let mut v22: num_complex::Complex<f64> = v22.clone();
                        v22.clone()
                    }
                };
                let mut v26: f64 = v24.re;
                let mut v33: bool = v26 != 0.0f64 ;
                let mut v40: bool = if v33 {
                    true
                } else {
                    method21(v33)
                };
                let mut v45: Rc<str> = if v33 {
                    let mut v41: f64 = 0.0f64;
                    method22(v41)
                } else {
                    let mut v43: f64 = 0.0f64;
                    method28(v26, v43)
                };
                let mut v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_ne"); } LIT.with(|lit| lit.clone()) };
                let mut v61: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
                let mut v62: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_ne "); } LIT.with(|lit| lit.clone()) };
                let mut v72: Rc<str> = if v33 {
                    let mut v68: f64 = 0.0f64;
                    method22(v68)
                } else {
                    let mut v70: f64 = 0.0f64;
                    method28(v26, v70)
                };
                let mut v73: Rc<str> = Rc::<str>::from(format!("{}{}", v62, v72));
                println!("{}", v73);
                let mut v74: bool = v40 == false;
                if v74 {
                    std::panic::panic_any::<std::string::String>(format!("{}", v73.clone()))
                };
                let mut v76: f64 = v24.im;
                let mut v77: bool = v76 != 0.0f64 ;
                let mut v79: bool = if v77 {
                    true
                } else {
                    method21(v77)
                };
                let mut v84: Rc<str> = if v77 {
                    let mut v80: f64 = 0.0f64;
                    method22(v80)
                } else {
                    let mut v82: f64 = 0.0f64;
                    method28(v76, v82)
                };
                let mut v85: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_ne "); } LIT.with(|lit| lit.clone()) };
                let mut v90: Rc<str> = if v77 {
                    let mut v86: f64 = 0.0f64;
                    method22(v86)
                } else {
                    let mut v88: f64 = 0.0f64;
                    method28(v76, v88)
                };
                let mut v91: Rc<str> = Rc::<str>::from(format!("{}{}", v85, v90));
                println!("{}", v91);
                let mut v92: bool = v79 == false;
                if v92 {
                    std::panic::panic_any::<std::string::String>(format!("{}", v91.clone()))
                };
                (v0, v1) = (v0.clone(), v3.clone());
                continue;
            }
            UH0::UH0_0 => {
                return ();
            }
        }
        return ();
    }
}
fn method50() -> Rc<UH0> {
    let mut v0: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
    let mut v1: Rc<UH0> = Rc::new(UH0::UH0_1(100.0f64, v0.clone()));
    let mut v2: Rc<UH0> = Rc::new(UH0::UH0_1(90.0f64, v1.clone()));
    let mut v3: Rc<UH0> = Rc::new(UH0::UH0_1(80.0f64, v2.clone()));
    let mut v4: Rc<UH0> = Rc::new(UH0::UH0_1(70.0f64, v3.clone()));
    let mut v5: Rc<UH0> = Rc::new(UH0::UH0_1(60.0f64, v4.clone()));
    let mut v6: Rc<UH0> = Rc::new(UH0::UH0_1(50.0f64, v5.clone()));
    let mut v7: Rc<UH0> = Rc::new(UH0::UH0_1(40.0f64, v6.clone()));
    let mut v8: Rc<UH0> = Rc::new(UH0::UH0_1(30.0f64, v7.clone()));
    let mut v9: Rc<UH0> = Rc::new(UH0::UH0_1(20.0f64, v8.clone()));
    Rc::new(UH0::UH0_1(10.0f64, v9.clone()))
}
fn method48(mut v0: pyo3::Python) -> () {
    let mut v1: Rc<UH0> = method50();
    method49(v0.clone(), v1.clone())
}
fn method47() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method48(v3.clone());
    let mut v4: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v5: bool = true; (v4) }); //;
    let mut v7: Result<(), pyo3::PyErr> = __run_test;
    v7.unwrap();
    ()
}
fn method53(mut v0: pyo3::Python, mut v1: Rc<UH1>) -> () {
    loop {
        match &*v1 {
            UH1::UH1_1(v2, v3) => {
                let mut v2: num_complex::Complex<f64> = v2.clone();
                let mut v3: Rc<UH1> = v3.clone();
                let mut v4: num_complex::Complex<f64> = method4(v2.clone());
                let mut v5: Result<num_complex::Complex<f64>, std::string::String> = method5(v0.clone(), v4.clone());
                let mut v6: num_complex::Complex<f64> = method16(v0.clone(), v2.clone());
                let mut v8: Option<num_complex::Complex<f64>> = v5.ok();
                let mut v9: Option<num_complex::Complex<f64>> = method20(v8.clone());
                let mut v10: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = closure0();
                let mut v11: Option<US0> = v9.map(|x| v10(x));
                let mut v12: US0 = US0::US0_1;
                let mut v13: US0 = v11.unwrap_or(v12);
                let mut v15: f64 = f64::NAN;
                let mut v17: f64 = f64::NAN;
                let mut v19: num_complex::Complex<f64> = num_complex::Complex::new(v15, v17);
                let mut v22: num_complex::Complex<f64> = match &v13 {
                    US0::US0_1 => {
                        v19.clone()
                    }
                    US0::US0_0(v20) => {
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
                let mut v32: Rc<str> = if v25 {
                    let mut v28: f64 = 0.0f64;
                    method22(v28)
                } else {
                    let mut v30: f64 = 0.0f64;
                    method28(v24, v30)
                };
                let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_ne"); } LIT.with(|lit| lit.clone()) };
                let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
                let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_ne "); } LIT.with(|lit| lit.clone()) };
                let mut v40: Rc<str> = if v25 {
                    let mut v36: f64 = 0.0f64;
                    method22(v36)
                } else {
                    let mut v38: f64 = 0.0f64;
                    method28(v24, v38)
                };
                let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v40));
                println!("{}", v41);
                let mut v42: bool = v27 == false;
                if v42 {
                    std::panic::panic_any::<std::string::String>(format!("{}", v41.clone()))
                };
                let mut v44: f64 = v22.im;
                let mut v45: bool = v44 != 0.0f64 ;
                let mut v47: bool = if v45 {
                    true
                } else {
                    method21(v45)
                };
                let mut v52: Rc<str> = if v45 {
                    let mut v48: f64 = 0.0f64;
                    method22(v48)
                } else {
                    let mut v50: f64 = 0.0f64;
                    method28(v44, v50)
                };
                let mut v53: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_ne "); } LIT.with(|lit| lit.clone()) };
                let mut v58: Rc<str> = if v45 {
                    let mut v54: f64 = 0.0f64;
                    method22(v54)
                } else {
                    let mut v56: f64 = 0.0f64;
                    method28(v44, v56)
                };
                let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v53, v58));
                println!("{}", v59);
                let mut v60: bool = v47 == false;
                if v60 {
                    std::panic::panic_any::<std::string::String>(format!("{}", v59.clone()))
                };
                (v0, v1) = (v0.clone(), v3.clone());
                continue;
            }
            UH1::UH1_0 => {
                return ();
            }
        }
        return ();
    }
}
fn method54() -> Rc<UH1> {
    let mut v1: num_complex::Complex<f64> = num_complex::Complex::new(0.5f64, 14.134725f64);
    let mut v3: num_complex::Complex<f64> = num_complex::Complex::new(0.75f64, 20.5f64);
    let mut v5: num_complex::Complex<f64> = num_complex::Complex::new(1.25f64, 30.1f64);
    let mut v7: num_complex::Complex<f64> = num_complex::Complex::new(0.25f64, 40.0f64);
    let mut v9: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 50.0f64);
    let mut v10: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_0); } CASE.with(|case| case.clone()) };
    let mut v11: Rc<UH1> = Rc::new(UH1::UH1_1(v9.clone(), v10.clone()));
    let mut v12: Rc<UH1> = Rc::new(UH1::UH1_1(v7.clone(), v11.clone()));
    let mut v13: Rc<UH1> = Rc::new(UH1::UH1_1(v5.clone(), v12.clone()));
    let mut v14: Rc<UH1> = Rc::new(UH1::UH1_1(v3.clone(), v13.clone()));
    Rc::new(UH1::UH1_1(v1.clone(), v14.clone()))
}
fn method52(mut v0: pyo3::Python) -> () {
    let mut v1: Rc<UH1> = method54();
    method53(v0.clone(), v1.clone())
}
fn method51() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method52(v3.clone());
    let mut v4: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v5: bool = true; (v4) }); //;
    let mut v7: Result<(), pyo3::PyErr> = __run_test;
    v7.unwrap();
    ()
}
fn method57(mut v0: pyo3::Python, mut v1: Rc<UH1>) -> () {
    loop {
        match &*v1 {
            UH1::UH1_1(v2, v3) => {
                let mut v2: num_complex::Complex<f64> = v2.clone();
                let mut v3: Rc<UH1> = v3.clone();
                let mut v4: num_complex::Complex<f64> = method4(v2.clone());
                let mut v5: Result<num_complex::Complex<f64>, std::string::String> = method5(v0.clone(), v4.clone());
                let mut v6: num_complex::Complex<f64> = method16(v0.clone(), v2.clone());
                let mut v8: Option<num_complex::Complex<f64>> = v5.ok();
                let mut v9: Option<num_complex::Complex<f64>> = method20(v8.clone());
                let mut v10: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = closure0();
                let mut v11: Option<US0> = v9.map(|x| v10(x));
                let mut v12: US0 = US0::US0_1;
                let mut v13: US0 = v11.unwrap_or(v12);
                let mut v15: f64 = f64::NAN;
                let mut v17: f64 = f64::NAN;
                let mut v19: num_complex::Complex<f64> = num_complex::Complex::new(v15, v17);
                let mut v22: num_complex::Complex<f64> = match &v13 {
                    US0::US0_1 => {
                        v19.clone()
                    }
                    US0::US0_0(v20) => {
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
                let mut v59: US0 = US0::US0_1;
                let mut v60: US0 = v58.unwrap_or(v59);
                let mut v62: f64 = f64::NAN;
                let mut v64: f64 = f64::NAN;
                let mut v66: num_complex::Complex<f64> = num_complex::Complex::new(v62, v64);
                let mut v69: num_complex::Complex<f64> = match &v60 {
                    US0::US0_1 => {
                        v66.clone()
                    }
                    US0::US0_0(v67) => {
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
                let mut v87: US0 = US0::US0_1;
                let mut v88: US0 = v86.unwrap_or(v87);
                let mut v90: f64 = f64::NAN;
                let mut v92: f64 = f64::NAN;
                let mut v94: num_complex::Complex<f64> = num_complex::Complex::new(v90, v92);
                let mut v97: num_complex::Complex<f64> = match &v88 {
                    US0::US0_1 => {
                        v94.clone()
                    }
                    US0::US0_0(v95) => {
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
                let mut v115: Rc<str> = if v108 {
                    let mut v111: f64 = 0.0001f64;
                    method22(v111)
                } else {
                    let mut v113: f64 = 0.0001f64;
                    method28(v107, v113)
                };
                let mut v116: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt"); } LIT.with(|lit| lit.clone()) };
                let mut v117: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
                let mut v118: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
                let mut v123: Rc<str> = if v108 {
                    let mut v119: f64 = 0.0001f64;
                    method22(v119)
                } else {
                    let mut v121: f64 = 0.0001f64;
                    method28(v107, v121)
                };
                let mut v124: Rc<str> = Rc::<str>::from(format!("{}{}", v118, v123));
                println!("{}", v124);
                let mut v125: bool = v110 == false;
                if v125 {
                    std::panic::panic_any::<std::string::String>(format!("{}", v124.clone()))
                };
                let mut v127: f64 = v22.im;
                let mut v129: f64 = v99.im;
                let mut v130: f64 = v127 - v129;
                let mut v131: f64 = -(v130);
                let mut v132: bool = v130 >= v131;
                let mut v133: f64 = if v132 {
                    v130
                } else {
                    v131
                };
                let mut v134: bool = v133 < 0.0001f64;
                let mut v136: bool = if v134 {
                    true
                } else {
                    method21(v134)
                };
                let mut v141: Rc<str> = if v134 {
                    let mut v137: f64 = 0.0001f64;
                    method22(v137)
                } else {
                    let mut v139: f64 = 0.0001f64;
                    method28(v133, v139)
                };
                let mut v142: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
                let mut v147: Rc<str> = if v134 {
                    let mut v143: f64 = 0.0001f64;
                    method22(v143)
                } else {
                    let mut v145: f64 = 0.0001f64;
                    method28(v133, v145)
                };
                let mut v148: Rc<str> = Rc::<str>::from(format!("{}{}", v142, v147));
                println!("{}", v148);
                let mut v149: bool = v136 == false;
                if v149 {
                    std::panic::panic_any::<std::string::String>(format!("{}", v148.clone()))
                };
                (v0, v1) = (v0.clone(), v3.clone());
                continue;
            }
            UH1::UH1_0 => {
                return ();
            }
        }
        return ();
    }
}
fn method58() -> Rc<UH1> {
    let mut v1: num_complex::Complex<f64> = num_complex::Complex::new(3.0f64, 4.0f64);
    let mut v3: num_complex::Complex<f64> = num_complex::Complex::new(2.5f64, -3.5f64);
    let mut v5: num_complex::Complex<f64> = num_complex::Complex::new(1.5f64, 2.5f64);
    let mut v7: num_complex::Complex<f64> = num_complex::Complex::new(0.5f64, 14.134725f64);
    let mut v8: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_0); } CASE.with(|case| case.clone()) };
    let mut v9: Rc<UH1> = Rc::new(UH1::UH1_1(v7.clone(), v8.clone()));
    let mut v10: Rc<UH1> = Rc::new(UH1::UH1_1(v5.clone(), v9.clone()));
    let mut v11: Rc<UH1> = Rc::new(UH1::UH1_1(v3.clone(), v10.clone()));
    Rc::new(UH1::UH1_1(v1.clone(), v11.clone()))
}
fn method56(mut v0: pyo3::Python) -> () {
    let mut v1: Rc<UH1> = method58();
    method57(v0.clone(), v1.clone())
}
fn method55() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method56(v3.clone());
    let mut v4: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v5: bool = true; (v4) }); //;
    let mut v7: Result<(), pyo3::PyErr> = __run_test;
    v7.unwrap();
    ()
}
fn method62(mut v0: f64, mut v1: Rc<UH0>, mut v2: f64) -> f64 {
    loop {
        match &*v1 {
            UH0::UH0_1(v3, v4) => {
                let mut v3: f64 = *v3;
                let mut v4: Rc<UH0> = v4.clone();
                let mut v5: f64 = -(v0);
                let mut v6: f64 = v3.powf(v5);
                let mut v7: f64 = 1.0f64 - v6;
                let mut v8: f64 = v2 / v7;
                (v0, v1, v2) = (v0, v4.clone(), v8);
                continue;
            }
            UH0::UH0_0 => {
                return v2;
            }
        }
    }
}
fn method61(mut v0: pyo3::Python, mut v1: Rc<UH0>, mut v2: Rc<UH0>) -> () {
    loop {
        match &*v2 {
            UH0::UH0_1(v3, v4) => {
                let mut v3: f64 = *v3;
                let mut v4: Rc<UH0> = v4.clone();
                let mut v6: num_complex::Complex<f64> = num_complex::Complex::new(v3, 0.0f64);
                let mut v7: f64 = 1.0f64;
                let mut v8: f64 = method62(v3, v1.clone(), v7);
                let mut v9: num_complex::Complex<f64> = method4(v6.clone());
                let mut v10: Result<num_complex::Complex<f64>, std::string::String> = method5(v0.clone(), v9.clone());
                let mut v11: num_complex::Complex<f64> = method16(v0.clone(), v6.clone());
                let mut v13: Option<num_complex::Complex<f64>> = v10.ok();
                let mut v14: Option<num_complex::Complex<f64>> = method20(v13.clone());
                let mut v15: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = closure0();
                let mut v16: Option<US0> = v14.map(|x| v15(x));
                let mut v17: US0 = US0::US0_1;
                let mut v18: US0 = v16.unwrap_or(v17);
                let mut v20: f64 = f64::NAN;
                let mut v22: f64 = f64::NAN;
                let mut v24: num_complex::Complex<f64> = num_complex::Complex::new(v20, v22);
                let mut v27: num_complex::Complex<f64> = match &v18 {
                    US0::US0_1 => {
                        v24.clone()
                    }
                    US0::US0_0(v25) => {
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
                let mut v41: Rc<str> = if v34 {
                    let mut v37: f64 = 0.01f64;
                    method22(v37)
                } else {
                    let mut v39: f64 = 0.01f64;
                    method28(v33, v39)
                };
                let mut v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt"); } LIT.with(|lit| lit.clone()) };
                let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
                let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
                let mut v49: Rc<str> = if v34 {
                    let mut v45: f64 = 0.01f64;
                    method22(v45)
                } else {
                    let mut v47: f64 = 0.01f64;
                    method28(v33, v47)
                };
                let mut v50: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v49));
                println!("{}", v50);
                let mut v51: bool = v36 == false;
                if v51 {
                    std::panic::panic_any::<std::string::String>(format!("{}", v50.clone()))
                };
                let mut v53: f64 = v27.im;
                let mut v54: bool = v53 < 0.01f64;
                let mut v56: bool = if v54 {
                    true
                } else {
                    method21(v54)
                };
                let mut v61: Rc<str> = if v54 {
                    let mut v57: f64 = 0.01f64;
                    method22(v57)
                } else {
                    let mut v59: f64 = 0.01f64;
                    method28(v53, v59)
                };
                let mut v62: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
                let mut v67: Rc<str> = if v54 {
                    let mut v63: f64 = 0.01f64;
                    method22(v63)
                } else {
                    let mut v65: f64 = 0.01f64;
                    method28(v53, v65)
                };
                let mut v68: Rc<str> = Rc::<str>::from(format!("{}{}", v62, v67));
                println!("{}", v68);
                let mut v69: bool = v56 == false;
                if v69 {
                    std::panic::panic_any::<std::string::String>(format!("{}", v68.clone()))
                };
                (v0, v1, v2) = (v0.clone(), v1.clone(), v4.clone());
                continue;
            }
            UH0::UH0_0 => {
                return ();
            }
        }
        return ();
    }
}
fn method63() -> Rc<UH0> {
    let mut v0: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
    let mut v1: Rc<UH0> = Rc::new(UH0::UH0_1(5.0f64, v0.clone()));
    let mut v2: Rc<UH0> = Rc::new(UH0::UH0_1(4.5f64, v1.clone()));
    let mut v3: Rc<UH0> = Rc::new(UH0::UH0_1(4.0f64, v2.clone()));
    let mut v4: Rc<UH0> = Rc::new(UH0::UH0_1(3.5f64, v3.clone()));
    let mut v5: Rc<UH0> = Rc::new(UH0::UH0_1(3.0f64, v4.clone()));
    let mut v6: Rc<UH0> = Rc::new(UH0::UH0_1(2.5f64, v5.clone()));
    Rc::new(UH0::UH0_1(2.0f64, v6.clone()))
}
fn method64() -> Rc<UH0> {
    let mut v0: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
    let mut v1: Rc<UH0> = Rc::new(UH0::UH0_1(71.0f64, v0.clone()));
    let mut v2: Rc<UH0> = Rc::new(UH0::UH0_1(67.0f64, v1.clone()));
    let mut v3: Rc<UH0> = Rc::new(UH0::UH0_1(61.0f64, v2.clone()));
    let mut v4: Rc<UH0> = Rc::new(UH0::UH0_1(59.0f64, v3.clone()));
    let mut v5: Rc<UH0> = Rc::new(UH0::UH0_1(53.0f64, v4.clone()));
    let mut v6: Rc<UH0> = Rc::new(UH0::UH0_1(47.0f64, v5.clone()));
    let mut v7: Rc<UH0> = Rc::new(UH0::UH0_1(43.0f64, v6.clone()));
    let mut v8: Rc<UH0> = Rc::new(UH0::UH0_1(41.0f64, v7.clone()));
    let mut v9: Rc<UH0> = Rc::new(UH0::UH0_1(37.0f64, v8.clone()));
    let mut v10: Rc<UH0> = Rc::new(UH0::UH0_1(31.0f64, v9.clone()));
    let mut v11: Rc<UH0> = Rc::new(UH0::UH0_1(29.0f64, v10.clone()));
    let mut v12: Rc<UH0> = Rc::new(UH0::UH0_1(23.0f64, v11.clone()));
    let mut v13: Rc<UH0> = Rc::new(UH0::UH0_1(19.0f64, v12.clone()));
    let mut v14: Rc<UH0> = Rc::new(UH0::UH0_1(17.0f64, v13.clone()));
    let mut v15: Rc<UH0> = Rc::new(UH0::UH0_1(13.0f64, v14.clone()));
    let mut v16: Rc<UH0> = Rc::new(UH0::UH0_1(11.0f64, v15.clone()));
    let mut v17: Rc<UH0> = Rc::new(UH0::UH0_1(7.0f64, v16.clone()));
    let mut v18: Rc<UH0> = Rc::new(UH0::UH0_1(5.0f64, v17.clone()));
    let mut v19: Rc<UH0> = Rc::new(UH0::UH0_1(3.0f64, v18.clone()));
    Rc::new(UH0::UH0_1(2.0f64, v19.clone()))
}
fn method60(mut v0: pyo3::Python) -> () {
    let mut v1: Rc<UH0> = method63();
    let mut v2: Rc<UH0> = method64();
    method61(v0.clone(), v2.clone(), v1.clone())
}
fn method59() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method60(v3.clone());
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
        method31();
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
        method33();
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
        method37();
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
        method39();
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
        method41();
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
        method43();
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
        method45();
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
        method47();
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
        method51();
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
        method55();
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
        method59();
        true
    } else {
        v35
    };
    let mut v56: i32 = if v38 {
        0i32
    } else {
        let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("unknown test: "); } LIT.with(|lit| lit.clone()) };
        let mut v50: Rc<str> = Rc::<str>::from(format!("{}{}", v49, v1));
        println!("{}", v50);
        1i32
    };
    if v56 != 0 { std::process::exit(v56) };
    0
}
fn main() { #[cfg(target_arch = "wasm32")] { spiral_main(); return; }
    let main = std::thread::Builder::new().stack_size(1 << 30).spawn(spiral_main).unwrap();
    std::process::exit(match main.join() { Ok(code) => code, Err(_) => 101 });
}
