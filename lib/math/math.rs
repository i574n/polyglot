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
        let mut v66: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v43));
        let mut v107: Rc<str> = Rc::<str>::from(format!("{}{}", v66, v42));
        let mut v108: i32 = v38.wrapping_add(1i32);
        let mut v109: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
        v36.borrow_mut().l0 = v108;
        v36.borrow_mut().l1 = v107.clone();
        v36.borrow_mut().l2 = v109.clone();
        ()
    };
    let (mut v110, mut v111): (Rc<str>, Rc<str>) = (v36.borrow().l1.clone(), v36.borrow().l2.clone());
    let mut v126: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__NAME__"); } LIT.with(|lit| lit.clone()) };
    let mut v127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("zeta_"); } LIT.with(|lit| lit.clone()) };
    let mut v128: Rc<str> = Rc::<str>::from(v110.replace(&*v126, &*v127));
    let mut v137: Rc<str> = method7(v128.clone());
    let mut v139: f64 = v1.re;
    let mut v141: f64 = v1.im;
    let (mut v163, mut v164): (f64, f64) = method8(v139, v141);
    let mut v165: (f64, f64) = (v163, v164);
    let (mut v247, mut v248): (bool, (f64, f64)) = method9(v165.clone());
    let mut v249: (bool, (f64, f64)) = (v247, v248);
    let mut v310: pyo3::Python = method10(v0.clone());
    let mut v943: &str = &*v137;
    let mut v1255: std::string::String = String::from(v943);
    let mut v1265: std::ffi::CString = std::ffi::CString::new(v1255).unwrap();
    let mut v1267: &str = &*v35;
    let mut v1269: std::string::String = String::from(v1267);
    let mut v1271: std::ffi::CString = std::ffi::CString::new(v1269).unwrap();
    let mut v1273: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> = pyo3::types::PyModule::from_code(v310, &v1265, &v1271, &v1271);
    let mut v1299: bool = true; let _result_map_error__ = v1273.map_err(|x| { //;
    let mut v1301: pyo3::PyErr = x;
    let mut v1334: std::string::String = format!("{}", v1301);
    let mut v1344: bool = true; v1334 });
    let mut v1346: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> = _result_map_error__;
    let mut v1348: pyo3::Bound<pyo3::types::PyModule> = v1346.unwrap();
    let mut v1349: Rc<str> = method11();
    let mut v1351: &str = &*v1349;
    let mut v1352: pyo3::Bound<pyo3::types::PyModule> = method12(v1348.clone());
    let mut v1354: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v1352.getattr(v1351);
    let mut v1356: bool = true; let _result_map_error__ = v1354.map_err(|x| { //;
    let mut v1358: pyo3::PyErr = x;
    let mut v1360: std::string::String = format!("{}", v1358);
    let mut v1362: bool = true; v1360 });
    let mut v1364: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
    let mut v1366: pyo3::Bound<pyo3::PyAny> = v1364.unwrap();
    let mut v1367: (bool, (f64, f64)) = method13(v249.clone());
    let mut v1368: pyo3::Bound<pyo3::PyAny> = method14(v1366.clone());
    let mut v1370: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = pyo3::prelude::PyAnyMethods::call(&v1368, v1367, None);
    let mut v1372: bool = true; let _result_map_error__ = v1370.map_err(|x| { //;
    let mut v1374: pyo3::PyErr = x;
    let mut v1376: std::string::String = format!("{}", v1374);
    let mut v1378: bool = true; v1376 });
    let mut v1380: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
    let mut v1382: pyo3::Bound<pyo3::PyAny> = v1380?;
    let mut v1383: pyo3::Bound<pyo3::PyAny> = method15(v1382.clone());
    let mut v1385: Result<(f64, f64), pyo3::PyErr> = v1383.extract();
    let mut v1387: bool = true; let _result_map_error__ = v1385.map_err(|x| { //;
    let mut v1389: pyo3::PyErr = x;
    let mut v1391: std::string::String = format!("{}", v1389);
    let mut v1393: bool = true; v1391 });
    let mut v1395: Result<(f64, f64), std::string::String> = _result_map_error__;
    let (mut v1397, mut v1398): (f64, f64) = v1395?;
    let mut v1400: num_complex::Complex<f64> = num_complex::Complex::new(v1397, v1398);
    let mut v1422: Result<num_complex::Complex<f64>, std::string::String> = Ok::<num_complex::Complex<f64>, std::string::String>(v1400);
    v1422.clone()
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
    let mut v76: Rc<str> = method7(v67.clone());
    let mut v78: f64 = v1.re;
    let mut v80: f64 = v1.im;
    let (mut v81, mut v82): (f64, f64) = method8(v78, v80);
    let mut v83: (f64, f64) = (v81, v82);
    let (mut v84, mut v85): (bool, (f64, f64)) = method9(v83.clone());
    let mut v86: (bool, (f64, f64)) = (v84, v85);
    let mut v87: pyo3::Python = method10(v0.clone());
    let mut v89: &str = &*v76;
    let mut v91: std::string::String = String::from(v89);
    let mut v93: std::ffi::CString = std::ffi::CString::new(v91).unwrap();
    let mut v95: &str = &*v35;
    let mut v97: std::string::String = String::from(v95);
    let mut v99: std::ffi::CString = std::ffi::CString::new(v97).unwrap();
    let mut v101: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> = pyo3::types::PyModule::from_code(v87, &v93, &v99, &v99);
    let mut v103: bool = true; let _result_map_error__ = v101.map_err(|x| { //;
    let mut v105: pyo3::PyErr = x;
    let mut v107: std::string::String = format!("{}", v105);
    let mut v109: bool = true; v107 });
    let mut v111: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> = _result_map_error__;
    let mut v113: pyo3::Bound<pyo3::types::PyModule> = v111.unwrap();
    let mut v114: Rc<str> = method11();
    let mut v116: &str = &*v114;
    let mut v117: pyo3::Bound<pyo3::types::PyModule> = method12(v113.clone());
    let mut v119: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v117.getattr(v116);
    let mut v121: bool = true; let _result_map_error__ = v119.map_err(|x| { //;
    let mut v123: pyo3::PyErr = x;
    let mut v125: std::string::String = format!("{}", v123);
    let mut v127: bool = true; v125 });
    let mut v129: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
    let mut v131: pyo3::Bound<pyo3::PyAny> = v129.unwrap();
    let mut v132: (bool, (f64, f64)) = method13(v86.clone());
    let mut v133: pyo3::Bound<pyo3::PyAny> = method14(v131.clone());
    let mut v135: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = pyo3::prelude::PyAnyMethods::call(&v133, v132, None);
    let mut v137: bool = true; let _result_map_error__ = v135.map_err(|x| { //;
    let mut v139: pyo3::PyErr = x;
    let mut v141: std::string::String = format!("{}", v139);
    let mut v143: bool = true; v141 });
    let mut v145: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
    let mut v147: pyo3::Bound<pyo3::PyAny> = v145?;
    let mut v148: pyo3::Bound<pyo3::PyAny> = method15(v147.clone());
    let mut v150: Result<(f64, f64), pyo3::PyErr> = v148.extract();
    let mut v152: bool = true; let _result_map_error__ = v150.map_err(|x| { //;
    let mut v154: pyo3::PyErr = x;
    let mut v156: std::string::String = format!("{}", v154);
    let mut v158: bool = true; v156 });
    let mut v160: Result<(f64, f64), std::string::String> = _result_map_error__;
    let (mut v162, mut v163): (f64, f64) = v160?;
    let mut v165: num_complex::Complex<f64> = num_complex::Complex::new(v162, v163);
    let mut v166: Result<num_complex::Complex<f64>, std::string::String> = Ok::<num_complex::Complex<f64>, std::string::String>(v165);
    v166.clone()
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
            let mut v43: f64 = (v18 as f64);
            let mut v95: num_complex::Complex<f64> = num_complex::Complex::new(v43, 0.0f64);
            let mut v97: num_complex::Complex<f64> = num_complex::Complex::powc(v95, v1.clone());
            let mut v99: num_complex::Complex<f64> = v20 / v97;
            let mut v101: num_complex::Complex<f64> = v17 + v99;
            let mut v102: i32 = v16.wrapping_add(1i32);
            v14.borrow_mut().l0 = v102;
            v14.borrow_mut().l1 = v101.clone();
            ()
        };
        let mut v103: num_complex::Complex<f64> = v14.borrow().l1.clone();
        v103.clone()
    } else {
        let mut v105: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
        let mut v107: num_complex::Complex<f64> = v105 - v1;
        let mut v108: num_complex::Complex<f64> = method4(v107.clone());
        let mut v109: Result<num_complex::Complex<f64>, std::string::String> = method19(v0.clone(), v108.clone());
        let mut v111: Option<num_complex::Complex<f64>> = v109.ok();
        let mut v271: Option<num_complex::Complex<f64>> = method20(v111.clone());
        let mut v272: Rc<dyn Fn((num_complex::Complex<f64>)) -> US0> = closure0();
        let mut v273: Option<US0> = v271.map(|x| v272(x));
        let mut v407: US0 = US0::US0_1;
        let mut v408: US0 = v273.unwrap_or(v407);
        let mut v453: f64 = f64::NAN;
        let mut v455: f64 = f64::NAN;
        let mut v457: num_complex::Complex<f64> = num_complex::Complex::new(v453, v455);
        let mut v460: num_complex::Complex<f64> = match &v408 {
            US0::US0_1 => {
                v457.clone()
            }
            US0::US0_0(v458) => {
                let mut v458: num_complex::Complex<f64> = v458.clone();
                v458.clone()
            }
        };
        let mut v462: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
        let mut v464: num_complex::Complex<f64> = v462 * v1;
        let mut v466: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
        let mut v468: num_complex::Complex<f64> = v464 / v466;
        let mut v470: num_complex::Complex<f64> = v468.sin();
        let mut v472: f64 = v1.re;
        let mut v473: f64 = 1.0f64 - v472;
        let mut v475: f64 = v1.im;
        let mut v476: f64 = -(v475);
        let mut v478: num_complex::Complex<f64> = num_complex::Complex::new(v473, v476);
        let mut v480: f64 = v478.re;
        let mut v481: bool = v480 <= 1.0f64;
        let mut v844: num_complex::Complex<f64> = if v481 {
            let mut v483: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
            v483.clone()
        } else {
            println!("zeta / count: {:?} / s: {:?}", 1i32, v478);
            let mut v486: f64 = v478.re;
            let mut v487: bool = v486 > 1.0f64;
            if v487 {
                let mut v489: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                let mut v490: Rc<RefCell<Vec<i32>>> = Rc::new(RefCell::new(vec![<i32>::default(); 10000i32 as usize]));
                let mut v491: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 0i32 }));
                while method17(v491.clone()) {
                    let mut v493: i32 = v491.borrow().l0.clone();
                    v490.clone().borrow_mut()[v493 as usize] = v493;
                    let mut v494: i32 = v493.wrapping_add(1i32);
                    v491.borrow_mut().l0 = v494;
                    ()
                };
                let mut v495: i32 = (v490.clone().borrow().len() as i32);
                let mut v496: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: 0i32, l1: v489.clone() }));
                while method18(v495, v496.clone()) {
                    let mut v498: i32 = v496.borrow().l0.clone();
                    let mut v499: num_complex::Complex<f64> = v496.borrow().l1.clone();
                    let mut v500: i32 = v490.clone().borrow()[v498 as usize].clone();
                    let mut v502: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                    let mut v503: f64 = (v500 as f64);
                    let mut v505: num_complex::Complex<f64> = num_complex::Complex::new(v503, 0.0f64);
                    let mut v507: num_complex::Complex<f64> = num_complex::Complex::powc(v505, v478.clone());
                    let mut v509: num_complex::Complex<f64> = v502 / v507;
                    let mut v511: num_complex::Complex<f64> = v499 + v509;
                    let mut v512: i32 = v498.wrapping_add(1i32);
                    v496.borrow_mut().l0 = v512;
                    v496.borrow_mut().l1 = v511.clone();
                    ()
                };
                let mut v513: num_complex::Complex<f64> = v496.borrow().l1.clone();
                v513.clone()
            } else {
                let mut v515: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                let mut v517: num_complex::Complex<f64> = v515 - v478;
                let mut v518: num_complex::Complex<f64> = method4(v517.clone());
                let mut v519: Result<num_complex::Complex<f64>, std::string::String> = method19(v0.clone(), v518.clone());
                let mut v521: Option<num_complex::Complex<f64>> = v519.ok();
                let mut v522: Option<num_complex::Complex<f64>> = method20(v521.clone());
                let mut v523: Option<US0> = v522.map(|x| v272(x));
                let mut v524: US0 = US0::US0_1;
                let mut v525: US0 = v523.unwrap_or(v524);
                let mut v527: f64 = f64::NAN;
                let mut v529: f64 = f64::NAN;
                let mut v531: num_complex::Complex<f64> = num_complex::Complex::new(v527, v529);
                let mut v534: num_complex::Complex<f64> = match &v525 {
                    US0::US0_1 => {
                        v531.clone()
                    }
                    US0::US0_0(v532) => {
                        let mut v532: num_complex::Complex<f64> = v532.clone();
                        v532.clone()
                    }
                };
                let mut v536: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                let mut v538: num_complex::Complex<f64> = v536 * v478;
                let mut v540: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                let mut v542: num_complex::Complex<f64> = v538 / v540;
                let mut v544: num_complex::Complex<f64> = v542.sin();
                let mut v546: f64 = v478.re;
                let mut v547: f64 = 1.0f64 - v546;
                let mut v549: f64 = v478.im;
                let mut v550: f64 = -(v549);
                let mut v552: num_complex::Complex<f64> = num_complex::Complex::new(v547, v550);
                let mut v554: f64 = v552.re;
                let mut v555: bool = v554 <= 1.0f64;
                let mut v828: num_complex::Complex<f64> = if v555 {
                    let mut v557: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                    v557.clone()
                } else {
                    println!("zeta / count: {:?} / s: {:?}", 2i32, v552);
                    let mut v560: f64 = v552.re;
                    let mut v561: bool = v560 > 1.0f64;
                    if v561 {
                        let mut v563: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                        let mut v564: Rc<RefCell<Vec<i32>>> = Rc::new(RefCell::new(vec![<i32>::default(); 10000i32 as usize]));
                        let mut v565: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 0i32 }));
                        while method17(v565.clone()) {
                            let mut v567: i32 = v565.borrow().l0.clone();
                            v564.clone().borrow_mut()[v567 as usize] = v567;
                            let mut v568: i32 = v567.wrapping_add(1i32);
                            v565.borrow_mut().l0 = v568;
                            ()
                        };
                        let mut v569: i32 = (v564.clone().borrow().len() as i32);
                        let mut v570: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: 0i32, l1: v563.clone() }));
                        while method18(v569, v570.clone()) {
                            let mut v572: i32 = v570.borrow().l0.clone();
                            let mut v573: num_complex::Complex<f64> = v570.borrow().l1.clone();
                            let mut v574: i32 = v564.clone().borrow()[v572 as usize].clone();
                            let mut v576: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                            let mut v577: f64 = (v574 as f64);
                            let mut v579: num_complex::Complex<f64> = num_complex::Complex::new(v577, 0.0f64);
                            let mut v581: num_complex::Complex<f64> = num_complex::Complex::powc(v579, v552.clone());
                            let mut v583: num_complex::Complex<f64> = v576 / v581;
                            let mut v585: num_complex::Complex<f64> = v573 + v583;
                            let mut v586: i32 = v572.wrapping_add(1i32);
                            v570.borrow_mut().l0 = v586;
                            v570.borrow_mut().l1 = v585.clone();
                            ()
                        };
                        let mut v587: num_complex::Complex<f64> = v570.borrow().l1.clone();
                        v587.clone()
                    } else {
                        let mut v589: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                        let mut v591: num_complex::Complex<f64> = v589 - v552;
                        let mut v592: num_complex::Complex<f64> = method4(v591.clone());
                        let mut v593: Result<num_complex::Complex<f64>, std::string::String> = method19(v0.clone(), v592.clone());
                        let mut v595: Option<num_complex::Complex<f64>> = v593.ok();
                        let mut v596: Option<num_complex::Complex<f64>> = method20(v595.clone());
                        let mut v597: Option<US0> = v596.map(|x| v272(x));
                        let mut v598: US0 = US0::US0_1;
                        let mut v599: US0 = v597.unwrap_or(v598);
                        let mut v601: f64 = f64::NAN;
                        let mut v603: f64 = f64::NAN;
                        let mut v605: num_complex::Complex<f64> = num_complex::Complex::new(v601, v603);
                        let mut v608: num_complex::Complex<f64> = match &v599 {
                            US0::US0_1 => {
                                v605.clone()
                            }
                            US0::US0_0(v606) => {
                                let mut v606: num_complex::Complex<f64> = v606.clone();
                                v606.clone()
                            }
                        };
                        let mut v610: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                        let mut v612: num_complex::Complex<f64> = v610 * v552;
                        let mut v614: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                        let mut v616: num_complex::Complex<f64> = v612 / v614;
                        let mut v618: num_complex::Complex<f64> = v616.sin();
                        let mut v620: f64 = v552.re;
                        let mut v621: f64 = 1.0f64 - v620;
                        let mut v623: f64 = v552.im;
                        let mut v624: f64 = -(v623);
                        let mut v626: num_complex::Complex<f64> = num_complex::Complex::new(v621, v624);
                        let mut v628: f64 = v626.re;
                        let mut v629: bool = v628 <= 1.0f64;
                        let mut v812: num_complex::Complex<f64> = if v629 {
                            let mut v631: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                            v631.clone()
                        } else {
                            println!("zeta / count: {:?} / s: {:?}", 3i32, v626);
                            let mut v634: f64 = v626.re;
                            let mut v635: bool = v634 > 1.0f64;
                            if v635 {
                                let mut v637: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                                let mut v638: Rc<RefCell<Vec<i32>>> = Rc::new(RefCell::new(vec![<i32>::default(); 10000i32 as usize]));
                                let mut v639: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 0i32 }));
                                while method17(v639.clone()) {
                                    let mut v641: i32 = v639.borrow().l0.clone();
                                    v638.clone().borrow_mut()[v641 as usize] = v641;
                                    let mut v642: i32 = v641.wrapping_add(1i32);
                                    v639.borrow_mut().l0 = v642;
                                    ()
                                };
                                let mut v643: i32 = (v638.clone().borrow().len() as i32);
                                let mut v644: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: 0i32, l1: v637.clone() }));
                                while method18(v643, v644.clone()) {
                                    let mut v646: i32 = v644.borrow().l0.clone();
                                    let mut v647: num_complex::Complex<f64> = v644.borrow().l1.clone();
                                    let mut v648: i32 = v638.clone().borrow()[v646 as usize].clone();
                                    let mut v650: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                                    let mut v651: f64 = (v648 as f64);
                                    let mut v653: num_complex::Complex<f64> = num_complex::Complex::new(v651, 0.0f64);
                                    let mut v655: num_complex::Complex<f64> = num_complex::Complex::powc(v653, v626.clone());
                                    let mut v657: num_complex::Complex<f64> = v650 / v655;
                                    let mut v659: num_complex::Complex<f64> = v647 + v657;
                                    let mut v660: i32 = v646.wrapping_add(1i32);
                                    v644.borrow_mut().l0 = v660;
                                    v644.borrow_mut().l1 = v659.clone();
                                    ()
                                };
                                let mut v661: num_complex::Complex<f64> = v644.borrow().l1.clone();
                                v661.clone()
                            } else {
                                let mut v663: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                                let mut v665: num_complex::Complex<f64> = v663 - v626;
                                let mut v666: num_complex::Complex<f64> = method4(v665.clone());
                                let mut v667: Result<num_complex::Complex<f64>, std::string::String> = method19(v0.clone(), v666.clone());
                                let mut v669: Option<num_complex::Complex<f64>> = v667.ok();
                                let mut v670: Option<num_complex::Complex<f64>> = method20(v669.clone());
                                let mut v671: Option<US0> = v670.map(|x| v272(x));
                                let mut v672: US0 = US0::US0_1;
                                let mut v673: US0 = v671.unwrap_or(v672);
                                let mut v675: f64 = f64::NAN;
                                let mut v677: f64 = f64::NAN;
                                let mut v679: num_complex::Complex<f64> = num_complex::Complex::new(v675, v677);
                                let mut v682: num_complex::Complex<f64> = match &v673 {
                                    US0::US0_1 => {
                                        v679.clone()
                                    }
                                    US0::US0_0(v680) => {
                                        let mut v680: num_complex::Complex<f64> = v680.clone();
                                        v680.clone()
                                    }
                                };
                                let mut v684: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                                let mut v686: num_complex::Complex<f64> = v684 * v626;
                                let mut v688: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                                let mut v690: num_complex::Complex<f64> = v686 / v688;
                                let mut v692: num_complex::Complex<f64> = v690.sin();
                                let mut v694: f64 = v626.re;
                                let mut v695: f64 = 1.0f64 - v694;
                                let mut v697: f64 = v626.im;
                                let mut v698: f64 = -(v697);
                                let mut v700: num_complex::Complex<f64> = num_complex::Complex::new(v695, v698);
                                let mut v702: f64 = v700.re;
                                let mut v703: bool = v702 <= 1.0f64;
                                let mut v796: num_complex::Complex<f64> = if v703 {
                                    let mut v705: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                                    v705.clone()
                                } else {
                                    println!("zeta / count: {:?} / s: {:?}", 4i32, v700);
                                    let mut v708: f64 = v700.re;
                                    let mut v709: bool = v708 > 1.0f64;
                                    if v709 {
                                        let mut v711: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                                        let mut v712: Rc<RefCell<Vec<i32>>> = Rc::new(RefCell::new(vec![<i32>::default(); 10000i32 as usize]));
                                        let mut v713: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 0i32 }));
                                        while method17(v713.clone()) {
                                            let mut v715: i32 = v713.borrow().l0.clone();
                                            v712.clone().borrow_mut()[v715 as usize] = v715;
                                            let mut v716: i32 = v715.wrapping_add(1i32);
                                            v713.borrow_mut().l0 = v716;
                                            ()
                                        };
                                        let mut v717: i32 = (v712.clone().borrow().len() as i32);
                                        let mut v718: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: 0i32, l1: v711.clone() }));
                                        while method18(v717, v718.clone()) {
                                            let mut v720: i32 = v718.borrow().l0.clone();
                                            let mut v721: num_complex::Complex<f64> = v718.borrow().l1.clone();
                                            let mut v722: i32 = v712.clone().borrow()[v720 as usize].clone();
                                            let mut v724: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                                            let mut v725: f64 = (v722 as f64);
                                            let mut v727: num_complex::Complex<f64> = num_complex::Complex::new(v725, 0.0f64);
                                            let mut v729: num_complex::Complex<f64> = num_complex::Complex::powc(v727, v700.clone());
                                            let mut v731: num_complex::Complex<f64> = v724 / v729;
                                            let mut v733: num_complex::Complex<f64> = v721 + v731;
                                            let mut v734: i32 = v720.wrapping_add(1i32);
                                            v718.borrow_mut().l0 = v734;
                                            v718.borrow_mut().l1 = v733.clone();
                                            ()
                                        };
                                        let mut v735: num_complex::Complex<f64> = v718.borrow().l1.clone();
                                        v735.clone()
                                    } else {
                                        let mut v737: num_complex::Complex<f64> = num_complex::Complex::new(1.0f64, 0.0f64);
                                        let mut v739: num_complex::Complex<f64> = v737 - v700;
                                        let mut v740: num_complex::Complex<f64> = method4(v739.clone());
                                        let mut v741: Result<num_complex::Complex<f64>, std::string::String> = method19(v0.clone(), v740.clone());
                                        let mut v743: Option<num_complex::Complex<f64>> = v741.ok();
                                        let mut v744: Option<num_complex::Complex<f64>> = method20(v743.clone());
                                        let mut v745: Option<US0> = v744.map(|x| v272(x));
                                        let mut v746: US0 = US0::US0_1;
                                        let mut v747: US0 = v745.unwrap_or(v746);
                                        let mut v749: f64 = f64::NAN;
                                        let mut v751: f64 = f64::NAN;
                                        let mut v753: num_complex::Complex<f64> = num_complex::Complex::new(v749, v751);
                                        let mut v756: num_complex::Complex<f64> = match &v747 {
                                            US0::US0_1 => {
                                                v753.clone()
                                            }
                                            US0::US0_0(v754) => {
                                                let mut v754: num_complex::Complex<f64> = v754.clone();
                                                v754.clone()
                                            }
                                        };
                                        let mut v758: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                                        let mut v760: num_complex::Complex<f64> = v758 * v700;
                                        let mut v762: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                                        let mut v764: num_complex::Complex<f64> = v760 / v762;
                                        let mut v766: num_complex::Complex<f64> = v764.sin();
                                        let mut v768: f64 = v700.re;
                                        let mut v769: f64 = 1.0f64 - v768;
                                        let mut v771: f64 = v700.im;
                                        let mut v772: f64 = -(v771);
                                        let mut v774: num_complex::Complex<f64> = num_complex::Complex::new(v769, v772);
                                        let mut v776: f64 = v774.re;
                                        let mut v777: bool = v776 <= 1.0f64;
                                        let mut v780: num_complex::Complex<f64> = if v777 {
                                            let mut v779: num_complex::Complex<f64> = num_complex::Complex::new(0.0f64, 0.0f64);
                                            v779.clone()
                                        } else {
                                            v774.clone()
                                        };
                                        let mut v782: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                                        let mut v784: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                                        let mut v786: num_complex::Complex<f64> = num_complex::Complex::powc(v784, v700);
                                        let mut v788: num_complex::Complex<f64> = v782 * v786;
                                        let mut v790: num_complex::Complex<f64> = v788 * v766;
                                        let mut v792: num_complex::Complex<f64> = v790 * v756;
                                        let mut v794: num_complex::Complex<f64> = v792 * v780;
                                        v794.clone()
                                    }
                                };
                                let mut v798: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                                let mut v800: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                                let mut v802: num_complex::Complex<f64> = num_complex::Complex::powc(v800, v626);
                                let mut v804: num_complex::Complex<f64> = v798 * v802;
                                let mut v806: num_complex::Complex<f64> = v804 * v692;
                                let mut v808: num_complex::Complex<f64> = v806 * v682;
                                let mut v810: num_complex::Complex<f64> = v808 * v796;
                                v810.clone()
                            }
                        };
                        let mut v814: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                        let mut v816: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                        let mut v818: num_complex::Complex<f64> = num_complex::Complex::powc(v816, v552);
                        let mut v820: num_complex::Complex<f64> = v814 * v818;
                        let mut v822: num_complex::Complex<f64> = v820 * v618;
                        let mut v824: num_complex::Complex<f64> = v822 * v608;
                        let mut v826: num_complex::Complex<f64> = v824 * v812;
                        v826.clone()
                    }
                };
                let mut v830: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
                let mut v832: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
                let mut v834: num_complex::Complex<f64> = num_complex::Complex::powc(v832, v478);
                let mut v836: num_complex::Complex<f64> = v830 * v834;
                let mut v838: num_complex::Complex<f64> = v836 * v544;
                let mut v840: num_complex::Complex<f64> = v838 * v534;
                let mut v842: num_complex::Complex<f64> = v840 * v828;
                v842.clone()
            }
        };
        let mut v846: num_complex::Complex<f64> = num_complex::Complex::new(2.0f64, 0.0f64);
        let mut v848: num_complex::Complex<f64> = num_complex::Complex::new(3.141592653589793f64, 0.0f64);
        let mut v850: num_complex::Complex<f64> = num_complex::Complex::powc(v848, v1);
        let mut v852: num_complex::Complex<f64> = v846 * v850;
        let mut v854: num_complex::Complex<f64> = v852 * v470;
        let mut v856: num_complex::Complex<f64> = v854 * v460;
        let mut v858: num_complex::Complex<f64> = v856 * v844;
        v858.clone()
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
fn format_real_22(mut v0: f64) -> Rc<str> {
    let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v10: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v9.clone() }));
    method23(v10.clone());
    method24(v10.clone());
    method25(v10.clone());
    let mut v125: Rc<str> = Rc::<str>::from({ let v = v0; if v.is_finite() { format!("{:+.6}", v) } else if v.is_nan() { String::from("NaN") } else if v > 0.0 { String::from("Infinity") } else { String::from("-Infinity") } });
    method26(v10.clone(), v125.clone());
    method27(v10.clone());
    let mut v172: Rc<str> = v10.borrow().l0.clone();
    v172.clone()
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
fn format_real_28(mut v0: f64, mut v1: f64) -> Rc<str> {
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v2.clone() }));
    method23(v3.clone());
    method29(v3.clone());
    method25(v3.clone());
    let mut v35: Rc<str> = Rc::<str>::from({ let v = v0; if v.is_finite() { format!("{:+.6}", v) } else if v.is_nan() { String::from("NaN") } else if v > 0.0 { String::from("Infinity") } else { String::from("-Infinity") } });
    method26(v3.clone(), v35.clone());
    method30(v3.clone());
    method24(v3.clone());
    method25(v3.clone());
    let mut v67: Rc<str> = Rc::<str>::from({ let v = v1; if v.is_finite() { format!("{:+.6}", v) } else if v.is_nan() { String::from("NaN") } else if v > 0.0 { String::from("Infinity") } else { String::from("-Infinity") } });
    method26(v3.clone(), v67.clone());
    method27(v3.clone());
    let mut v68: Rc<str> = v3.borrow().l0.clone();
    v68.clone()
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
            format_real_22(v36)
        } else {
            let mut v38: f64 = 0.0f64;
            format_real_28(v32, v38)
        };
        let mut v55: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq"); } LIT.with(|lit| lit.clone()) };
        let mut v56: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
        let mut v57: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
        let mut v70: Rc<str> = if v33 {
            let mut v66: f64 = 0.0f64;
            format_real_22(v66)
        } else {
            let mut v68: f64 = 0.0f64;
            format_real_28(v32, v68)
        };
        let mut v71: Rc<str> = Rc::<str>::from(format!("{}{}", v57, v70));
        println!("{}", v71);
        let mut v75: bool = v35 == false;
        if v75 {
            std::panic::panic_any::<std::string::String>(format!("{}", v71.clone()))
        };
        let mut v77: f64 = v30.re;
        let mut v78: f64 = v77 - v11;
        let mut v79: f64 = -(v78);
        let mut v80: bool = v78 >= v79;
        let mut v81: f64 = if v80 {
            v78
        } else {
            v79
        };
        let mut v82: bool = v81 < 0.0001f64;
        let mut v84: bool = if v82 {
            true
        } else {
            method21(v82)
        };
        let mut v89: Rc<str> = if v82 {
            let mut v85: f64 = 0.0001f64;
            format_real_22(v85)
        } else {
            let mut v87: f64 = 0.0001f64;
            format_real_28(v81, v87)
        };
        let mut v100: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt"); } LIT.with(|lit| lit.clone()) };
        let mut v101: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
        let mut v114: Rc<str> = if v82 {
            let mut v110: f64 = 0.0001f64;
            format_real_22(v110)
        } else {
            let mut v112: f64 = 0.0001f64;
            format_real_28(v81, v112)
        };
        let mut v115: Rc<str> = Rc::<str>::from(format!("{}{}", v101, v114));
        println!("{}", v115);
        let mut v116: bool = v84 == false;
        if v116 {
            std::panic::panic_any::<std::string::String>(format!("{}", v115.clone()))
        };
        let mut v117: i32 = v9.wrapping_add(1i32);
        v7.borrow_mut().l0 = v117;
        ()
    };
    ()
}
fn method1() -> () {
    pyo3::Python::initialize();
    let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //;
    let mut v3: pyo3::Python = py;
    method2(v3.clone());
    let mut v25: Result<(), pyo3::PyErr> = Ok::<(), pyo3::PyErr>(());
    let mut v100: bool = true; (v25) }); //;
    let mut v103: Result<(), pyo3::PyErr> = __run_test;
    v103.unwrap();
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
        format_real_22(v31)
    } else {
        let mut v33: f64 = 0.001f64;
        format_real_28(v27, v33)
    };
    let mut v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt"); } LIT.with(|lit| lit.clone()) };
    let mut v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
    let mut v43: Rc<str> = if v28 {
        let mut v39: f64 = 0.001f64;
        format_real_22(v39)
    } else {
        let mut v41: f64 = 0.001f64;
        format_real_28(v27, v41)
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
        format_real_22(v55)
    } else {
        let mut v57: f64 = 0.001f64;
        format_real_28(v51, v57)
    };
    let mut v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
    let mut v65: Rc<str> = if v52 {
        let mut v61: f64 = 0.001f64;
        format_real_22(v61)
    } else {
        let mut v63: f64 = 0.001f64;
        format_real_28(v51, v63)
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
                    format_real_22(v30)
                } else {
                    let mut v32: f64 = 0.0f64;
                    format_real_28(v26, v32)
                };
                let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq"); } LIT.with(|lit| lit.clone()) };
                let mut v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
                let mut v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
                let mut v42: Rc<str> = if v27 {
                    let mut v38: f64 = 0.0f64;
                    format_real_22(v38)
                } else {
                    let mut v40: f64 = 0.0f64;
                    format_real_28(v26, v40)
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
                    format_real_22(v50)
                } else {
                    let mut v52: f64 = 0.0f64;
                    format_real_28(v46, v52)
                };
                let mut v55: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
                let mut v60: Rc<str> = if v47 {
                    let mut v56: f64 = 0.0f64;
                    format_real_22(v56)
                } else {
                    let mut v58: f64 = 0.0f64;
                    format_real_28(v46, v58)
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
            format_real_22(v46)
        } else {
            let mut v48: f64 = 0.0001f64;
            format_real_28(v42, v48)
        };
        let mut v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt"); } LIT.with(|lit| lit.clone()) };
        let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
        let mut v53: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
        let mut v58: Rc<str> = if v43 {
            let mut v54: f64 = 0.0001f64;
            format_real_22(v54)
        } else {
            let mut v56: f64 = 0.0001f64;
            format_real_28(v42, v56)
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
            format_real_22(v69)
        } else {
            let mut v71: f64 = 0.0001f64;
            format_real_28(v65, v71)
        };
        let mut v74: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
        let mut v79: Rc<str> = if v66 {
            let mut v75: f64 = 0.0001f64;
            format_real_22(v75)
        } else {
            let mut v77: f64 = 0.0001f64;
            format_real_28(v65, v77)
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
            format_real_22(v33)
        } else {
            let mut v35: f64 = 0.0f64;
            format_real_28(v29, v35)
        };
        let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_gt"); } LIT.with(|lit| lit.clone()) };
        let mut v53: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
        let mut v54: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_gt "); } LIT.with(|lit| lit.clone()) };
        let mut v67: Rc<str> = if v30 {
            let mut v63: f64 = 0.0f64;
            format_real_22(v63)
        } else {
            let mut v65: f64 = 0.0f64;
            format_real_28(v29, v65)
        };
        let mut v68: Rc<str> = Rc::<str>::from(format!("{}{}", v54, v67));
        println!("{}", v68);
        let mut v69: bool = v32 == false;
        if v69 {
            std::panic::panic_any::<std::string::String>(format!("{}", v68.clone()))
        };
        let mut v71: f64 = v27.im;
        let mut v72: bool = v71 == 0.0f64;
        let mut v74: bool = if v72 {
            true
        } else {
            method21(v72)
        };
        let mut v79: Rc<str> = if v72 {
            let mut v75: f64 = 0.0f64;
            format_real_22(v75)
        } else {
            let mut v77: f64 = 0.0f64;
            format_real_28(v71, v77)
        };
        let mut v80: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq"); } LIT.with(|lit| lit.clone()) };
        let mut v81: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
        let mut v86: Rc<str> = if v72 {
            let mut v82: f64 = 0.0f64;
            format_real_22(v82)
        } else {
            let mut v84: f64 = 0.0f64;
            format_real_28(v71, v84)
        };
        let mut v87: Rc<str> = Rc::<str>::from(format!("{}{}", v81, v86));
        println!("{}", v87);
        let mut v88: bool = v74 == false;
        if v88 {
            std::panic::panic_any::<std::string::String>(format!("{}", v87.clone()))
        };
        let mut v89: i32 = v5.wrapping_add(1i32);
        v3.borrow_mut().l0 = v89;
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
        format_real_22(v27)
    } else {
        let mut v29: f64 = f64::INFINITY;
        format_real_28(v23, v29)
    };
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = if v24 {
        let mut v35: f64 = f64::INFINITY;
        format_real_22(v35)
    } else {
        let mut v37: f64 = f64::INFINITY;
        format_real_28(v23, v37)
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
        format_real_22(v47)
    } else {
        let mut v49: f64 = 0.0f64;
        format_real_28(v43, v49)
    };
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
    let mut v57: Rc<str> = if v44 {
        let mut v53: f64 = 0.0f64;
        format_real_22(v53)
    } else {
        let mut v55: f64 = 0.0f64;
        format_real_28(v43, v55)
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
        format_real_22(v52)
    } else {
        format_real_28(v50, v52)
    };
    let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq"); } LIT.with(|lit| lit.clone()) };
    let mut v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v61: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
    let mut v64: Rc<str> = if v53 {
        format_real_22(v52)
    } else {
        format_real_28(v50, v52)
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
        format_real_22(v70)
    } else {
        format_real_28(v68, v70)
    };
    let mut v77: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_eq "); } LIT.with(|lit| lit.clone()) };
    let mut v80: Rc<str> = if v71 {
        format_real_22(v70)
    } else {
        format_real_28(v68, v70)
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
        format_real_22(v27)
    } else {
        let mut v29: f64 = f64::INFINITY;
        format_real_28(v23, v29)
    };
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
    let mut v39: Rc<str> = if v24 {
        let mut v35: f64 = f64::INFINITY;
        format_real_22(v35)
    } else {
        let mut v37: f64 = f64::INFINITY;
        format_real_28(v23, v37)
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
        format_real_22(v47)
    } else {
        let mut v49: f64 = f64::INFINITY;
        format_real_28(v43, v49)
    };
    let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
    let mut v57: Rc<str> = if v44 {
        let mut v53: f64 = f64::INFINITY;
        format_real_22(v53)
    } else {
        let mut v55: f64 = f64::INFINITY;
        format_real_28(v43, v55)
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
                let mut v43: bool = if v33 {
                    true
                } else {
                    method21(v33)
                };
                let mut v48: Rc<str> = if v33 {
                    let mut v44: f64 = 0.0f64;
                    format_real_22(v44)
                } else {
                    let mut v46: f64 = 0.0f64;
                    format_real_28(v26, v46)
                };
                let mut v63: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_ne"); } LIT.with(|lit| lit.clone()) };
                let mut v64: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
                let mut v65: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_ne "); } LIT.with(|lit| lit.clone()) };
                let mut v78: Rc<str> = if v33 {
                    let mut v74: f64 = 0.0f64;
                    format_real_22(v74)
                } else {
                    let mut v76: f64 = 0.0f64;
                    format_real_28(v26, v76)
                };
                let mut v79: Rc<str> = Rc::<str>::from(format!("{}{}", v65, v78));
                println!("{}", v79);
                let mut v80: bool = v43 == false;
                if v80 {
                    std::panic::panic_any::<std::string::String>(format!("{}", v79.clone()))
                };
                let mut v82: f64 = v24.im;
                let mut v83: bool = v82 != 0.0f64 ;
                let mut v85: bool = if v83 {
                    true
                } else {
                    method21(v83)
                };
                let mut v90: Rc<str> = if v83 {
                    let mut v86: f64 = 0.0f64;
                    format_real_22(v86)
                } else {
                    let mut v88: f64 = 0.0f64;
                    format_real_28(v82, v88)
                };
                let mut v91: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_ne "); } LIT.with(|lit| lit.clone()) };
                let mut v96: Rc<str> = if v83 {
                    let mut v92: f64 = 0.0f64;
                    format_real_22(v92)
                } else {
                    let mut v94: f64 = 0.0f64;
                    format_real_28(v82, v94)
                };
                let mut v97: Rc<str> = Rc::<str>::from(format!("{}{}", v91, v96));
                println!("{}", v97);
                let mut v98: bool = v85 == false;
                if v98 {
                    std::panic::panic_any::<std::string::String>(format!("{}", v97.clone()))
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
                    format_real_22(v28)
                } else {
                    let mut v30: f64 = 0.0f64;
                    format_real_28(v24, v30)
                };
                let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_ne"); } LIT.with(|lit| lit.clone()) };
                let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
                let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_ne "); } LIT.with(|lit| lit.clone()) };
                let mut v40: Rc<str> = if v25 {
                    let mut v36: f64 = 0.0f64;
                    format_real_22(v36)
                } else {
                    let mut v38: f64 = 0.0f64;
                    format_real_28(v24, v38)
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
                    format_real_22(v48)
                } else {
                    let mut v50: f64 = 0.0f64;
                    format_real_28(v44, v50)
                };
                let mut v53: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_ne "); } LIT.with(|lit| lit.clone()) };
                let mut v58: Rc<str> = if v45 {
                    let mut v54: f64 = 0.0f64;
                    format_real_22(v54)
                } else {
                    let mut v56: f64 = 0.0f64;
                    format_real_28(v44, v56)
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
                    format_real_22(v111)
                } else {
                    let mut v113: f64 = 0.0001f64;
                    format_real_28(v107, v113)
                };
                let mut v116: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt"); } LIT.with(|lit| lit.clone()) };
                let mut v117: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
                let mut v118: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
                let mut v123: Rc<str> = if v108 {
                    let mut v119: f64 = 0.0001f64;
                    format_real_22(v119)
                } else {
                    let mut v121: f64 = 0.0001f64;
                    format_real_28(v107, v121)
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
                    format_real_22(v137)
                } else {
                    let mut v139: f64 = 0.0001f64;
                    format_real_28(v133, v139)
                };
                let mut v142: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
                let mut v147: Rc<str> = if v134 {
                    let mut v143: f64 = 0.0001f64;
                    format_real_22(v143)
                } else {
                    let mut v145: f64 = 0.0001f64;
                    format_real_28(v133, v145)
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
                    format_real_22(v37)
                } else {
                    let mut v39: f64 = 0.01f64;
                    format_real_28(v33, v39)
                };
                let mut v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt"); } LIT.with(|lit| lit.clone()) };
                let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
                let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
                let mut v49: Rc<str> = if v34 {
                    let mut v45: f64 = 0.01f64;
                    format_real_22(v45)
                } else {
                    let mut v47: f64 = 0.01f64;
                    format_real_28(v33, v47)
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
                    format_real_22(v57)
                } else {
                    let mut v59: f64 = 0.01f64;
                    format_real_28(v53, v59)
                };
                let mut v62: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("__assert_lt "); } LIT.with(|lit| lit.clone()) };
                let mut v67: Rc<str> = if v54 {
                    let mut v63: f64 = 0.01f64;
                    format_real_22(v63)
                } else {
                    let mut v65: f64 = 0.01f64;
                    format_real_28(v53, v65)
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
    let mut v59: i32 = if v38 {
        0i32
    } else {
        let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("unknown test: "); } LIT.with(|lit| lit.clone()) };
        let mut v50: Rc<str> = Rc::<str>::from(format!("{}{}", v49, v1));
        println!("{}", v50);
        1i32
    };
    if v59 != 0 { std::process::exit(v59) };
    0
}
fn main() { #[cfg(target_arch = "wasm32")] { spiral_main(); return; }
    let main = std::thread::Builder::new().stack_size(1 << 30).spawn(spiral_main).unwrap();
    std::process::exit(match main.join() { Ok(code) => code, Err(_) => 101 });
}
