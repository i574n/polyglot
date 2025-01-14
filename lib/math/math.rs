#![allow(dead_code)]
#![allow(non_camel_case_types)]
#![allow(non_snake_case)]
#![allow(non_upper_case_globals)]
#![allow(unreachable_code)]
#![allow(unused_attributes)]
#![allow(unused_imports)]
#![allow(unused_macros)]
#![allow(unused_parens)]
#![allow(unused_variables)]
#![allow(unused_assignments)]
use fable_library_rust::NativeArray_::array_from;
use fable_library_rust::String_::fromString;
mod module_728458a3 {
    pub mod Math {
        use super::*;
        use fable_library_rust::NativeArray_::get_Count;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_init;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::on_startup;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::concat;
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        on_startup!();
        use pyo3::prelude::PyAnyMethods;
        //,);
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut0 {
            pub l0: MutCell<i32>,
        }
        impl core::fmt::Display for Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut1 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<string>,
            pub l2: MutCell<string>,
        }
        impl core::fmt::Display for Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut2 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<num_complex::Complex<f64>>,
        }
        impl core::fmt::Display for Mut2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US0 {
            US0_0(num_complex::Complex<f64>),
            US0_1,
        }
        impl core::fmt::Display for US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd)]
        pub enum UH0 {
            UH0_0,
            UH0_1(f64, LrcPtr<Math::UH0>),
        }
        impl core::fmt::Display for UH0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH1 {
            UH1_0,
            UH1_1(num_complex::Complex<f64>, LrcPtr<Math::UH1>),
        }
        impl core::fmt::Display for UH1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn method2(v0_1: i32, v1_1: LrcPtr<Math::Mut0>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method3(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method6(v0_1: i32, v1_1: LrcPtr<Math::Mut1>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method5(v0_1: Array<string>) -> string {
            let v1_1: i32 = get_Count(v0_1.clone());
            let v3: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                l0: MutCell::new(0_i32),
                l1: MutCell::new(string("")),
                l2: MutCell::new(string("")),
            });
            while Math::method6(v1_1, v3.clone()) {
                let v5: i32 = v3.l0.get().clone();
                let v8: i32 = ((v5.wrapping_neg()) + (v1_1)) - 1_i32;
                let matchValue: string = v3.l1.get().clone();
                let matchValue_1: string = v3.l2.get().clone();
                let v12: string = append(
                    (append((append((v0_1[v8].clone()), (matchValue_1))), (matchValue))),
                    string(""),
                );
                let v13: i32 = (v5) + 1_i32;
                v3.l0.set(v13);
                v3.l1.set(v12);
                v3.l2.set(string("\n"));
                ()
            }
            {
                let matchValue_2: string = v3.l1.get().clone();
                let matchValue_3: string = v3.l2.get().clone();
                matchValue_2
            }
        }
        pub fn method7(v0_1: pyo3::Python) -> pyo3::Python {
            v0_1
        }
        pub fn method8() -> string {
            string("fn")
        }
        pub fn method9(
            v0_1: pyo3::Bound<pyo3::types::PyModule>,
        ) -> pyo3::Bound<pyo3::types::PyModule> {
            v0_1
        }
        pub fn method10(
            v0_: bool,
            v0__1: LrcPtr<(f64, f64)>,
        ) -> LrcPtr<(bool, LrcPtr<(f64, f64)>)> {
            LrcPtr::new((v0_, v0__1))
        }
        pub fn method11(v0_1: pyo3::Bound<pyo3::PyAny>) -> pyo3::Bound<pyo3::PyAny> {
            v0_1
        }
        pub fn method12(v0_1: pyo3::Bound<pyo3::PyAny>) -> pyo3::Bound<pyo3::PyAny> {
            v0_1
        }
        pub fn method4(
            v0_1: pyo3::Python,
            v1_1: string,
            v2: num_complex::Complex<f64>,
        ) -> Result<num_complex::Complex<f64>, std::string::String> {
            let v13: string =
                string("            args = { k: v for k, v in frame.f_locals.items() if frame.f_code.co_name != \'make_mpc\' and k not in [\'ctx\'] and not callable(v) }");
            let v14: string =
                string("            args_str = \', \'.join([ f\"{k}={re.sub(memory_address_pattern, \' at 0x<?>\', repr(v))}\" for k, v in args.items() ])");
            let v36: string =
                Math::method5(new_array(&[string("import sys"),
                                          string("import traceback"),
                                          string("import re"),
                                          string("count = 0"),
                                          string("memory_address_pattern = re.compile(r\' at 0x[0-9a-fA-F]+\')"),
                                          string("def trace_calls(frame, event, arg):"),
                                          string("    global count"),
                                          string("    count += 1"),
                                          string("    if count < 200:"),
                                          string("        try:"), v13, v14,
                                          concat(new_array(&[string("            print(f\"{event}("),
                                                             string("zeta_"),
                                                             string(") / f_code.co_name: {frame.f_code.co_name} / f_locals: {args_str} / f_lineno: {frame.f_lineno} / f_code.co_filename: {frame.f_code.co_filename.split(\'site-packages\')[-1]} / f_back.f_lineno: { \'\' if frame.f_back is None else frame.f_back.f_lineno } / f_back.f_code.co_filename: { \'\' if frame.f_back is None else frame.f_back.f_code.co_filename.split(\'site-packages\')[-1] } / arg: {re.sub(memory_address_pattern, \' at 0x<?>\', repr(arg))}\", flush=True)")])),
                                          string("        except ValueError as e:"),
                                          concat(new_array(&[string("            print(f\'"),
                                                             string("zeta_"),
                                                             string(" / e: {e}\', flush=True)")])),
                                          string("        return trace_calls"),
                                          string("import mpmath"),
                                          string("def fn(log, s):"),
                                          string("    global count"),
                                          string("    if log:"),
                                          concat(new_array(&[string("        print(f\'"),
                                                             string("zeta_"),
                                                             string(" / s: {s} / count: {count}\', flush=True)")])),
                                          string("    s = complex(*s)"),
                                          string("    try:"),
                                          string("        if log: sys.settrace(trace_calls)"),
                                          v1_1, string("        if log:"),
                                          string("            sys.settrace(None)"),
                                          concat(new_array(&[string("            print(f\'"),
                                                             string("zeta_"),
                                                             string(" / result: {s} / count: {count}\', flush=True)")])),
                                          string("    except ValueError as e:"),
                                          string("        if s.real == 1:"),
                                          string("            s = complex(float(\'inf\'), 0)"),
                                          string("    return (s.real, s.imag)")]));
            let v42: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v2.clone().re, v2.im))));
            let v43: pyo3::Python = Math::method7(v0_1);
            let v46: &str = &*v36;
            let v70: std::string::String = String::from(v46);
            let v93: std::ffi::CString = std::ffi::CString::new(v70).unwrap();
            let v97: &str = &*string("");
            let v121: std::string::String = String::from(v97);
            let v144: std::ffi::CString = std::ffi::CString::new(v121).unwrap();
            let v146: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code(v43, &v93, &v144, &v144);
            let v148: bool = true;
            let _result_map_error__ = v146.map_err(|x| {
                //;
                let v150: pyo3::PyErr = x;
                let v153: std::string::String = format!("{}", v150);
                let v176: bool = true;
                v153
            });
            let v178: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                _result_map_error__;
            let v181: pyo3::Bound<pyo3::types::PyModule> = v178.unwrap();
            let v193: string = Math::method8();
            let v196: &str = &*v193;
            let v218: pyo3::Bound<pyo3::types::PyModule> = Math::method9(v181);
            let v220: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v218.getattr(v196);
            let v222: bool = true;
            let _result_map_error__ = v220.map_err(|x| {
                //;
                let v224: pyo3::PyErr = x;
                let v227: std::string::String = format!("{}", v224);
                let v250: bool = true;
                v227
            });
            let v252: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v255: pyo3::Bound<pyo3::PyAny> = v252.unwrap();
            let v267: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method10(v42.0.clone(), v42.1.clone());
            let v268: pyo3::Bound<pyo3::PyAny> = Math::method11(v255);
            let v270: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                pyo3::prelude::PyAnyMethods::call(&v268, ((*v267).0, *(*v267).1), None);
            let v272: bool = true;
            let _result_map_error__ = v270.map_err(|x| {
                //;
                let v274: pyo3::PyErr = x;
                let v277: std::string::String = format!("{}", v274);
                let v300: bool = true;
                v277
            });
            let v302: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v305: pyo3::Bound<pyo3::PyAny> = Math::method12(v302?);
            let v307: Result<(f64, f64), pyo3::PyErr> = v305.extract();
            let v309: bool = true;
            let _result_map_error__ = v307.map_err(|x| {
                //;
                let v311: pyo3::PyErr = x;
                let v314: std::string::String = format!("{}", v311);
                let v337: bool = true;
                v314
            });
            let v339: Result<(f64, f64), std::string::String> = _result_map_error__;
            let patternInput: (f64, f64) = v339?;
            Ok::<num_complex::Complex<f64>, std::string::String>(num_complex::Complex::new(
                patternInput.0.clone(),
                patternInput.1.clone(),
            ))
        }
        pub fn method14(v0_1: LrcPtr<Math::Mut0>) -> bool {
            (v0_1.l0.get().clone()) < 10000_i32
        }
        pub fn method15(v0_1: i32, v1_1: LrcPtr<Math::Mut2>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method16(
            v0_1: pyo3::Python,
            v1_1: string,
            v2: num_complex::Complex<f64>,
        ) -> Result<num_complex::Complex<f64>, std::string::String> {
            let v13: string =
                string("            args = { k: v for k, v in frame.f_locals.items() if frame.f_code.co_name != \'make_mpc\' and k not in [\'ctx\'] and not callable(v) }");
            let v14: string =
                string("            args_str = \', \'.join([ f\"{k}={re.sub(memory_address_pattern, \' at 0x<?>\', repr(v))}\" for k, v in args.items() ])");
            let v36: string =
                Math::method5(new_array(&[string("import sys"),
                                          string("import traceback"),
                                          string("import re"),
                                          string("count = 0"),
                                          string("memory_address_pattern = re.compile(r\' at 0x[0-9a-fA-F]+\')"),
                                          string("def trace_calls(frame, event, arg):"),
                                          string("    global count"),
                                          string("    count += 1"),
                                          string("    if count < 200:"),
                                          string("        try:"), v13, v14,
                                          concat(new_array(&[string("            print(f\"{event}("),
                                                             string("gamma_"),
                                                             string(") / f_code.co_name: {frame.f_code.co_name} / f_locals: {args_str} / f_lineno: {frame.f_lineno} / f_code.co_filename: {frame.f_code.co_filename.split(\'site-packages\')[-1]} / f_back.f_lineno: { \'\' if frame.f_back is None else frame.f_back.f_lineno } / f_back.f_code.co_filename: { \'\' if frame.f_back is None else frame.f_back.f_code.co_filename.split(\'site-packages\')[-1] } / arg: {re.sub(memory_address_pattern, \' at 0x<?>\', repr(arg))}\", flush=True)")])),
                                          string("        except ValueError as e:"),
                                          concat(new_array(&[string("            print(f\'"),
                                                             string("gamma_"),
                                                             string(" / e: {e}\', flush=True)")])),
                                          string("        return trace_calls"),
                                          string("import mpmath"),
                                          string("def fn(log, s):"),
                                          string("    global count"),
                                          string("    if log:"),
                                          concat(new_array(&[string("        print(f\'"),
                                                             string("gamma_"),
                                                             string(" / s: {s} / count: {count}\', flush=True)")])),
                                          string("    s = complex(*s)"),
                                          string("    try:"),
                                          string("        if log: sys.settrace(trace_calls)"),
                                          v1_1, string("        if log:"),
                                          string("            sys.settrace(None)"),
                                          concat(new_array(&[string("            print(f\'"),
                                                             string("gamma_"),
                                                             string(" / result: {s} / count: {count}\', flush=True)")])),
                                          string("    except ValueError as e:"),
                                          string("        if s.real == 1:"),
                                          string("            s = complex(float(\'inf\'), 0)"),
                                          string("    return (s.real, s.imag)")]));
            let v42: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v2.clone().re, v2.im))));
            let v43: pyo3::Python = Math::method7(v0_1);
            let v46: &str = &*v36;
            let v70: std::string::String = String::from(v46);
            let v93: std::ffi::CString = std::ffi::CString::new(v70).unwrap();
            let v97: &str = &*string("");
            let v121: std::string::String = String::from(v97);
            let v144: std::ffi::CString = std::ffi::CString::new(v121).unwrap();
            let v146: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code(v43, &v93, &v144, &v144);
            let v148: bool = true;
            let _result_map_error__ = v146.map_err(|x| {
                //;
                let v150: pyo3::PyErr = x;
                let v153: std::string::String = format!("{}", v150);
                let v176: bool = true;
                v153
            });
            let v178: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                _result_map_error__;
            let v181: pyo3::Bound<pyo3::types::PyModule> = v178.unwrap();
            let v193: string = Math::method8();
            let v196: &str = &*v193;
            let v218: pyo3::Bound<pyo3::types::PyModule> = Math::method9(v181);
            let v220: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v218.getattr(v196);
            let v222: bool = true;
            let _result_map_error__ = v220.map_err(|x| {
                //;
                let v224: pyo3::PyErr = x;
                let v227: std::string::String = format!("{}", v224);
                let v250: bool = true;
                v227
            });
            let v252: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v255: pyo3::Bound<pyo3::PyAny> = v252.unwrap();
            let v267: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method10(v42.0.clone(), v42.1.clone());
            let v268: pyo3::Bound<pyo3::PyAny> = Math::method11(v255);
            let v270: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                pyo3::prelude::PyAnyMethods::call(&v268, ((*v267).0, *(*v267).1), None);
            let v272: bool = true;
            let _result_map_error__ = v270.map_err(|x| {
                //;
                let v274: pyo3::PyErr = x;
                let v277: std::string::String = format!("{}", v274);
                let v300: bool = true;
                v277
            });
            let v302: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v305: pyo3::Bound<pyo3::PyAny> = Math::method12(v302?);
            let v307: Result<(f64, f64), pyo3::PyErr> = v305.extract();
            let v309: bool = true;
            let _result_map_error__ = v307.map_err(|x| {
                //;
                let v311: pyo3::PyErr = x;
                let v314: std::string::String = format!("{}", v311);
                let v337: bool = true;
                v314
            });
            let v339: Result<(f64, f64), std::string::String> = _result_map_error__;
            let patternInput: (f64, f64) = v339?;
            Ok::<num_complex::Complex<f64>, std::string::String>(num_complex::Complex::new(
                patternInput.0.clone(),
                patternInput.1.clone(),
            ))
        }
        pub fn closure1(unitVar: (), v0_1: num_complex::Complex<f64>) -> Math::US0 {
            Math::US0::US0_0(v0_1)
        }
        pub fn method17() -> Func1<num_complex::Complex<f64>, Math::US0> {
            Func1::new(move |v: num_complex::Complex<f64>| Math::closure1((), v))
        }
        pub fn method13(
            v0_1: pyo3::Python,
            v1_1: num_complex::Complex<f64>,
        ) -> num_complex::Complex<f64> {
            println!("zeta / count: {:?} / s: {:?}", 0_i32, v1_1.clone());
            if (v1_1.clone().re) > 1.0_f64 {
                let v7: num_complex::Complex<f64> = num_complex::Complex::new(0.0_f64, 0.0_f64);
                let v8: Array<i32> = new_init(&0_i32, 10000_i32);
                let v9: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                    l0: MutCell::new(0_i32),
                });
                while Math::method14(v9.clone()) {
                    let v11: i32 = v9.l0.get().clone();
                    v8.get_mut()[v11 as usize] = v11;
                    {
                        let v12: i32 = (v11) + 1_i32;
                        v9.l0.set(v12);
                        ()
                    }
                }
                {
                    let v13: i32 = get_Count(v8.clone());
                    let v14: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                        l0: MutCell::new(0_i32),
                        l1: MutCell::new(v7),
                    });
                    while Math::method15(v13, v14.clone()) {
                        let v16: i32 = v14.l0.get().clone();
                        let v17: num_complex::Complex<f64> = v14.l1.get().clone();
                        let v18: i32 = v8[v16].clone();
                        let v20: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v22: f64 = v18 as f64;
                        let v26: num_complex::Complex<f64> =
                            num_complex::Complex::new(v22, 0.0_f64);
                        let v28: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v26, v1_1.clone());
                        let v30: num_complex::Complex<f64> = v20 / v28;
                        let v32: num_complex::Complex<f64> = v17 + v30;
                        let v33: i32 = (v16) + 1_i32;
                        v14.l0.set(v33);
                        v14.l1.set(v32);
                        ()
                    }
                    v14.l1.get().clone()
                }
            } else {
                let v36: num_complex::Complex<f64> = num_complex::Complex::new(1.0_f64, 0.0_f64);
                let v41: Result<num_complex::Complex<f64>, std::string::String> = Math::method16(
                    v0_1.clone(),
                    string("        s = mpmath.gamma(s)"),
                    Math::method3(v36 - v1_1.clone()),
                );
                let v44: Option<num_complex::Complex<f64>> = v41.ok();
                let v69: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v44));
                let v74: f64 = f64::NAN;
                let v76: f64 = f64::NAN;
                let v78: num_complex::Complex<f64> = num_complex::Complex::new(v74, v76);
                let v81: num_complex::Complex<f64> = match &v69 {
                    Math::US0::US0_0(v69_0_0) => match &v69 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v78.clone(),
                };
                let v83: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v85: num_complex::Complex<f64> = v83 * v1_1.clone();
                let v87: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v89: num_complex::Complex<f64> = v85 / v87;
                let v91: num_complex::Complex<f64> = v89.sin();
                let v94: f64 = 1.0_f64 - (v1_1.clone().re);
                let v97: f64 = -v1_1.clone().im;
                let v99: num_complex::Complex<f64> = num_complex::Complex::new(v94, v97);
                let v581: num_complex::Complex<f64> = if (v99.clone().re) <= 1.0_f64 {
                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                } else {
                    println!("zeta / count: {:?} / s: {:?}", 1_i32, v99.clone());
                    if (v99.clone().re) > 1.0_f64 {
                        let v110: num_complex::Complex<f64> =
                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                        let v111: Array<i32> = new_init(&0_i32, 10000_i32);
                        let v112: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                            l0: MutCell::new(0_i32),
                        });
                        while Math::method14(v112.clone()) {
                            let v114: i32 = v112.l0.get().clone();
                            v111.get_mut()[v114 as usize] = v114;
                            {
                                let v115: i32 = (v114) + 1_i32;
                                v112.l0.set(v115);
                                ()
                            }
                        }
                        {
                            let v116: i32 = get_Count(v111.clone());
                            let v117: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                l0: MutCell::new(0_i32),
                                l1: MutCell::new(v110),
                            });
                            while Math::method15(v116, v117.clone()) {
                                let v119: i32 = v117.l0.get().clone();
                                let v120: num_complex::Complex<f64> = v117.l1.get().clone();
                                let v121: i32 = v111[v119].clone();
                                let v123: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v125: f64 = v121 as f64;
                                let v129: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v125, 0.0_f64);
                                let v131: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v129, v99.clone());
                                let v133: num_complex::Complex<f64> = v123 / v131;
                                let v135: num_complex::Complex<f64> = v120 + v133;
                                let v136: i32 = (v119) + 1_i32;
                                v117.l0.set(v136);
                                v117.l1.set(v135);
                                ()
                            }
                            v117.l1.get().clone()
                        }
                    } else {
                        let v139: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v144: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method16(
                                v0_1.clone(),
                                string("        s = mpmath.gamma(s)"),
                                Math::method3(v139 - v99.clone()),
                            );
                        let v147: Option<num_complex::Complex<f64>> = v144.ok();
                        let v172: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v147));
                        let v177: f64 = f64::NAN;
                        let v179: f64 = f64::NAN;
                        let v181: num_complex::Complex<f64> = num_complex::Complex::new(v177, v179);
                        let v184: num_complex::Complex<f64> = match &v172 {
                            Math::US0::US0_0(v172_0_0) => match &v172 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v181.clone(),
                        };
                        let v186: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v188: num_complex::Complex<f64> = v186 * v99.clone();
                        let v190: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v192: num_complex::Complex<f64> = v188 / v190;
                        let v194: num_complex::Complex<f64> = v192.sin();
                        let v197: f64 = 1.0_f64 - (v99.clone().re);
                        let v200: f64 = -v99.clone().im;
                        let v202: num_complex::Complex<f64> = num_complex::Complex::new(v197, v200);
                        let v565: num_complex::Complex<f64> = if (v202.clone().re) <= 1.0_f64 {
                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                        } else {
                            println!("zeta / count: {:?} / s: {:?}", 2_i32, v202.clone());
                            if (v202.clone().re) > 1.0_f64 {
                                let v213: num_complex::Complex<f64> =
                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                let v214: Array<i32> = new_init(&0_i32, 10000_i32);
                                let v215: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Math::method14(v215.clone()) {
                                    let v217: i32 = v215.l0.get().clone();
                                    v214.get_mut()[v217 as usize] = v217;
                                    {
                                        let v218: i32 = (v217) + 1_i32;
                                        v215.l0.set(v218);
                                        ()
                                    }
                                }
                                {
                                    let v219: i32 = get_Count(v214.clone());
                                    let v220: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                        l0: MutCell::new(0_i32),
                                        l1: MutCell::new(v213),
                                    });
                                    while Math::method15(v219, v220.clone()) {
                                        let v222: i32 = v220.l0.get().clone();
                                        let v223: num_complex::Complex<f64> = v220.l1.get().clone();
                                        let v224: i32 = v214[v222].clone();
                                        let v226: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v228: f64 = v224 as f64;
                                        let v232: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v228, 0.0_f64);
                                        let v234: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v232, v202.clone());
                                        let v236: num_complex::Complex<f64> = v226 / v234;
                                        let v238: num_complex::Complex<f64> = v223 + v236;
                                        let v239: i32 = (v222) + 1_i32;
                                        v220.l0.set(v239);
                                        v220.l1.set(v238);
                                        ()
                                    }
                                    v220.l1.get().clone()
                                }
                            } else {
                                let v242: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v247: Result<num_complex::Complex<f64>, std::string::String> =
                                    Math::method16(
                                        v0_1.clone(),
                                        string("        s = mpmath.gamma(s)"),
                                        Math::method3(v242 - v202.clone()),
                                    );
                                let v250: Option<num_complex::Complex<f64>> = v247.ok();
                                let v275: Math::US0 =
                                    defaultValue(Math::US0::US0_1, map(Math::method17(), v250));
                                let v280: f64 = f64::NAN;
                                let v282: f64 = f64::NAN;
                                let v284: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v280, v282);
                                let v287: num_complex::Complex<f64> = match &v275 {
                                    Math::US0::US0_0(v275_0_0) => match &v275 {
                                        Math::US0::US0_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                    _ => v284.clone(),
                                };
                                let v289: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v291: num_complex::Complex<f64> = v289 * v202.clone();
                                let v293: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v295: num_complex::Complex<f64> = v291 / v293;
                                let v297: num_complex::Complex<f64> = v295.sin();
                                let v300: f64 = 1.0_f64 - (v202.clone().re);
                                let v303: f64 = -v202.clone().im;
                                let v305: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v300, v303);
                                let v549: num_complex::Complex<f64> = if (v305.clone().re)
                                    <= 1.0_f64
                                {
                                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                                } else {
                                    println!("zeta / count: {:?} / s: {:?}", 3_i32, v305.clone());
                                    if (v305.clone().re) > 1.0_f64 {
                                        let v316: num_complex::Complex<f64> =
                                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                                        let v317: Array<i32> = new_init(&0_i32, 10000_i32);
                                        let v318: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                            l0: MutCell::new(0_i32),
                                        });
                                        while Math::method14(v318.clone()) {
                                            let v320: i32 = v318.l0.get().clone();
                                            v317.get_mut()[v320 as usize] = v320;
                                            {
                                                let v321: i32 = (v320) + 1_i32;
                                                v318.l0.set(v321);
                                                ()
                                            }
                                        }
                                        {
                                            let v322: i32 = get_Count(v317.clone());
                                            let v323: LrcPtr<Math::Mut2> =
                                                LrcPtr::new(Math::Mut2 {
                                                    l0: MutCell::new(0_i32),
                                                    l1: MutCell::new(v316),
                                                });
                                            while Math::method15(v322, v323.clone()) {
                                                let v325: i32 = v323.l0.get().clone();
                                                let v326: num_complex::Complex<f64> =
                                                    v323.l1.get().clone();
                                                let v327: i32 = v317[v325].clone();
                                                let v329: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v331: f64 = v327 as f64;
                                                let v335: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v331, 0.0_f64);
                                                let v337: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v335, v305.clone());
                                                let v339: num_complex::Complex<f64> = v329 / v337;
                                                let v341: num_complex::Complex<f64> = v326 + v339;
                                                let v342: i32 = (v325) + 1_i32;
                                                v323.l0.set(v342);
                                                v323.l1.set(v341);
                                                ()
                                            }
                                            v323.l1.get().clone()
                                        }
                                    } else {
                                        let v345: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v350: Result<
                                            num_complex::Complex<f64>,
                                            std::string::String,
                                        > = Math::method16(
                                            v0_1.clone(),
                                            string("        s = mpmath.gamma(s)"),
                                            Math::method3(v345 - v305.clone()),
                                        );
                                        let v353: Option<num_complex::Complex<f64>> = v350.ok();
                                        let v378: Math::US0 = defaultValue(
                                            Math::US0::US0_1,
                                            map(Math::method17(), v353),
                                        );
                                        let v383: f64 = f64::NAN;
                                        let v385: f64 = f64::NAN;
                                        let v387: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v383, v385);
                                        let v390: num_complex::Complex<f64> = match &v378 {
                                            Math::US0::US0_0(v378_0_0) => match &v378 {
                                                Math::US0::US0_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                            _ => v387.clone(),
                                        };
                                        let v392: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v394: num_complex::Complex<f64> = v392 * v305.clone();
                                        let v396: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v398: num_complex::Complex<f64> = v394 / v396;
                                        let v400: num_complex::Complex<f64> = v398.sin();
                                        let v403: f64 = 1.0_f64 - (v305.clone().re);
                                        let v406: f64 = -v305.clone().im;
                                        let v408: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v403, v406);
                                        let v533: num_complex::Complex<f64> = if (v408.clone().re)
                                            <= 1.0_f64
                                        {
                                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                                        } else {
                                            println!(
                                                "zeta / count: {:?} / s: {:?}",
                                                4_i32,
                                                v408.clone()
                                            );
                                            if (v408.clone().re) > 1.0_f64 {
                                                let v419: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                                let v420: Array<i32> = new_init(&0_i32, 10000_i32);
                                                let v421: LrcPtr<Math::Mut0> =
                                                    LrcPtr::new(Math::Mut0 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Math::method14(v421.clone()) {
                                                    let v423: i32 = v421.l0.get().clone();
                                                    v420.get_mut()[v423 as usize] = v423;
                                                    {
                                                        let v424: i32 = (v423) + 1_i32;
                                                        v421.l0.set(v424);
                                                        ()
                                                    }
                                                }
                                                {
                                                    let v425: i32 = get_Count(v420.clone());
                                                    let v426: LrcPtr<Math::Mut2> =
                                                        LrcPtr::new(Math::Mut2 {
                                                            l0: MutCell::new(0_i32),
                                                            l1: MutCell::new(v419),
                                                        });
                                                    while Math::method15(v425, v426.clone()) {
                                                        let v428: i32 = v426.l0.get().clone();
                                                        let v429: num_complex::Complex<f64> =
                                                            v426.l1.get().clone();
                                                        let v430: i32 = v420[v428].clone();
                                                        let v432: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                1.0_f64, 0.0_f64,
                                                            );
                                                        let v434: f64 = v430 as f64;
                                                        let v438: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                v434, 0.0_f64,
                                                            );
                                                        let v440: num_complex::Complex<f64> =
                                                            num_complex::Complex::powc(
                                                                v438,
                                                                v408.clone(),
                                                            );
                                                        let v442: num_complex::Complex<f64> =
                                                            v432 / v440;
                                                        let v444: num_complex::Complex<f64> =
                                                            v429 + v442;
                                                        let v445: i32 = (v428) + 1_i32;
                                                        v426.l0.set(v445);
                                                        v426.l1.set(v444);
                                                        ()
                                                    }
                                                    v426.l1.get().clone()
                                                }
                                            } else {
                                                let v448: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v453: Result<
                                                    num_complex::Complex<f64>,
                                                    std::string::String,
                                                > = Math::method16(
                                                    v0_1,
                                                    string("        s = mpmath.gamma(s)"),
                                                    Math::method3(v448 - v408.clone()),
                                                );
                                                let v456: Option<num_complex::Complex<f64>> =
                                                    v453.ok();
                                                let v481: Math::US0 = defaultValue(
                                                    Math::US0::US0_1,
                                                    map(Math::method17(), v456),
                                                );
                                                let v486: f64 = f64::NAN;
                                                let v488: f64 = f64::NAN;
                                                let v490: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v486, v488);
                                                let v493: num_complex::Complex<f64> = match &v481 {
                                                    Math::US0::US0_0(v481_0_0) => match &v481 {
                                                        Math::US0::US0_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                    _ => v490.clone(),
                                                };
                                                let v495: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(
                                                        3.141592653589793_f64,
                                                        0.0_f64,
                                                    );
                                                let v497: num_complex::Complex<f64> =
                                                    v495 * v408.clone();
                                                let v499: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                let v501: num_complex::Complex<f64> = v497 / v499;
                                                let v503: num_complex::Complex<f64> = v501.sin();
                                                let v506: f64 = 1.0_f64 - (v408.clone().re);
                                                let v509: f64 = -v408.clone().im;
                                                let v511: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v506, v509);
                                                let v517: num_complex::Complex<f64> =
                                                    if (v511.clone().re) <= 1.0_f64 {
                                                        num_complex::Complex::new(0.0_f64, 0.0_f64)
                                                    } else {
                                                        v511
                                                    };
                                                let v519: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                let v521: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(
                                                        3.141592653589793_f64,
                                                        0.0_f64,
                                                    );
                                                let v523: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v521, v408.clone());
                                                let v525: num_complex::Complex<f64> = v519 * v523;
                                                let v527: num_complex::Complex<f64> = v525 * v503;
                                                let v529: num_complex::Complex<f64> = v527 * v493;
                                                v529 * v517
                                            }
                                        };
                                        let v535: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v537: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v539: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v537, v305.clone());
                                        let v541: num_complex::Complex<f64> = v535 * v539;
                                        let v543: num_complex::Complex<f64> = v541 * v400;
                                        let v545: num_complex::Complex<f64> = v543 * v390;
                                        v545 * v533
                                    }
                                };
                                let v551: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v553: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v555: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v553, v202.clone());
                                let v557: num_complex::Complex<f64> = v551 * v555;
                                let v559: num_complex::Complex<f64> = v557 * v297;
                                let v561: num_complex::Complex<f64> = v559 * v287;
                                v561 * v549
                            }
                        };
                        let v567: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v569: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v571: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v569, v99.clone());
                        let v573: num_complex::Complex<f64> = v567 * v571;
                        let v575: num_complex::Complex<f64> = v573 * v194;
                        let v577: num_complex::Complex<f64> = v575 * v184;
                        v577 * v565
                    }
                };
                let v583: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v585: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v587: num_complex::Complex<f64> =
                    num_complex::Complex::powc(v585, v1_1.clone());
                let v589: num_complex::Complex<f64> = v583 * v587;
                let v591: num_complex::Complex<f64> = v589 * v91;
                let v593: num_complex::Complex<f64> = v591 * v81;
                v593 * v581
            }
        }
        pub fn method18(v0_1: bool) -> bool {
            v0_1
        }
        pub fn closure2(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn method1(v0_1: pyo3::Python) {
            let v5: Array<(num_complex::Complex<f64>, f64)> = new_array(&[
                (
                    num_complex::Complex::new(2.0_f64, 0.0_f64),
                    1.6449340668482264_f64,
                ),
                (
                    num_complex::Complex::new(-1.0_f64, 0.0_f64),
                    -0.08333333333333333_f64,
                ),
            ]);
            let v6: i32 = get_Count(v5.clone());
            let v7: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method2(v6, v7.clone()) {
                let v9: i32 = v7.l0.get().clone();
                let patternInput: (num_complex::Complex<f64>, f64) = v5[v9].clone();
                let v10: num_complex::Complex<f64> = patternInput.0.clone();
                let v14: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                    v0_1.clone(),
                    string("        s = mpmath.zeta(s)"),
                    Math::method3(v10.clone()),
                );
                let v15: num_complex::Complex<f64> = Math::method13(v0_1.clone(), v10);
                let v18: Option<num_complex::Complex<f64>> = v14.ok();
                let v43: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v18));
                let v48: f64 = f64::NAN;
                let v50: f64 = f64::NAN;
                let v52: num_complex::Complex<f64> = num_complex::Complex::new(v48, v50);
                let v55: num_complex::Complex<f64> = match &v43 {
                    Math::US0::US0_0(v43_0_0) => match &v43 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v52.clone(),
                };
                let v57: f64 = v55.clone().im;
                let v58: bool = (v57) == 0.0_f64;
                let v60: bool = if v58 { true } else { Math::method18(v58) };
                let v62: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_eq"),
                    v57,
                    0.0_f64
                );
                let v67: () = {
                    Math::closure2(v62.clone(), ());
                    ()
                };
                if (v60) == false {
                    panic!("{}", v62,);
                }
                {
                    let v72: f64 = (v55.re) - (patternInput.1.clone());
                    let v73: f64 = -v72;
                    let v75: f64 = if (v72) >= (v73) { v72 } else { v73 };
                    let v76: bool = (v75) < 0.0001_f64;
                    let v78: bool = if v76 { true } else { Math::method18(v76) };
                    let v80: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_lt"),
                        v75,
                        0.0001_f64
                    );
                    let v85: () = {
                        Math::closure2(v80.clone(), ());
                        ()
                    };
                    if (v78) == false {
                        panic!("{}", v80,);
                    }
                    {
                        let v88: i32 = (v9) + 1_i32;
                        v7.l0.set(v88);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method19(v0_1: Result<(), pyo3::PyErr>) -> Result<(), pyo3::PyErr> {
            v0_1
        }
        pub fn method0() {
            pyo3::prepare_freethreaded_python();
            let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method1(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v23: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v24: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v26: Result<(), pyo3::PyErr> = __run_test;
                v26.unwrap();
                ()
            }
        }
        pub fn method21(v0_1: pyo3::Python) {
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, -2.0_f64);
            let v5: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v2.clone()),
            );
            let v6: num_complex::Complex<f64> = Math::method13(v0_1, v2);
            let v9: Option<num_complex::Complex<f64>> = v5.ok();
            let v34: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v9));
            let v39: f64 = f64::NAN;
            let v41: f64 = f64::NAN;
            let v43: num_complex::Complex<f64> = num_complex::Complex::new(v39, v41);
            let v46: num_complex::Complex<f64> = match &v34 {
                Math::US0::US0_0(v34_0_0) => match &v34 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v43.clone(),
            };
            let v49: f64 = (v46.clone().re) - 0.8673_f64;
            let v50: f64 = -v49;
            let v52: f64 = if (v49) >= (v50) { v49 } else { v50 };
            let v53: bool = (v52) < 0.001_f64;
            let v55: bool = if v53 { true } else { Math::method18(v53) };
            let v57: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_lt"),
                v52,
                0.001_f64
            );
            let v62: () = {
                Math::closure2(v57.clone(), ());
                ()
            };
            if (v55) == false {
                panic!("{}", v57,);
            }
            {
                let v67: f64 = (v46.im) - 0.275_f64;
                let v68: f64 = -v67;
                let v70: f64 = if (v67) >= (v68) { v67 } else { v68 };
                let v71: bool = (v70) < 0.001_f64;
                let v73: bool = if v71 { true } else { Math::method18(v71) };
                let v74: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_lt"),
                    v70,
                    0.001_f64
                );
                let v79: () = {
                    Math::closure2(v74.clone(), ());
                    ()
                };
                if (v73) == false {
                    panic!("{}", v74,);
                }
            }
        }
        pub fn method20() {
            pyo3::prepare_freethreaded_python();
            let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method21(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v23: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v24: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v26: Result<(), pyo3::PyErr> = __run_test;
                v26.unwrap();
                ()
            }
        }
        pub fn method24() -> LrcPtr<Math::UH0> {
            LrcPtr::new(Math::UH0::UH0_1(-2.0_f64,
                                         LrcPtr::new(Math::UH0::UH0_1(-4.0_f64,
                                                                      LrcPtr::new(Math::UH0::UH0_1(-6.0_f64,
                                                                                                   LrcPtr::new(Math::UH0::UH0_1(-8.0_f64,
                                                                                                                                LrcPtr::new(Math::UH0::UH0_1(-10.0_f64,
                                                                                                                                                             LrcPtr::new(Math::UH0::UH0_1(-12.0_f64,
                                                                                                                                                                                          LrcPtr::new(Math::UH0::UH0_1(-14.0_f64,
                                                                                                                                                                                                                       LrcPtr::new(Math::UH0::UH0_1(-16.0_f64,
                                                                                                                                                                                                                                                    LrcPtr::new(Math::UH0::UH0_1(-18.0_f64,
                                                                                                                                                                                                                                                                                 LrcPtr::new(Math::UH0::UH0_1(-20.0_f64,
                                                                                                                                                                                                                                                                                                              LrcPtr::new(Math::UH0::UH0_1(-22.0_f64,
                                                                                                                                                                                                                                                                                                                                           LrcPtr::new(Math::UH0::UH0_1(-24.0_f64,
                                                                                                                                                                                                                                                                                                                                                                        LrcPtr::new(Math::UH0::UH0_1(-26.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                     LrcPtr::new(Math::UH0::UH0_1(-28.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                                                  LrcPtr::new(Math::UH0::UH0_1(-30.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                                                                               LrcPtr::new(Math::UH0::UH0_1(-32.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            LrcPtr::new(Math::UH0::UH0_1(-34.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         LrcPtr::new(Math::UH0::UH0_1(-36.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      LrcPtr::new(Math::UH0::UH0_1(-38.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   LrcPtr::new(Math::UH0::UH0_1(-40.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                LrcPtr::new(Math::UH0::UH0_0)))))))))))))))))))))))))))))))))))))))))
        }
        pub fn method25(v0_1: pyo3::Python, v1_1: LrcPtr<Math::UH0>) {
            let v0_1: MutCell<pyo3::Python> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1_1.clone());
            '_method25: loop {
                break '_method25 (match v1_1.get().clone().as_ref() {
                    Math::UH0::UH0_0 => (),
                    Math::UH0::UH0_1(v1_1_1_0, v1_1_1_1) => {
                        let v5: num_complex::Complex<f64> = num_complex::Complex::new(
                            match v1_1.get().clone().as_ref() {
                                Math::UH0::UH0_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            },
                            0.0_f64,
                        );
                        let v8: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(
                                v0_1.get().clone(),
                                string("        s = mpmath.zeta(s)"),
                                Math::method3(v5.clone()),
                            );
                        let v9: num_complex::Complex<f64> = Math::method13(v0_1.get().clone(), v5);
                        let v12: Option<num_complex::Complex<f64>> = v8.ok();
                        let v37: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v12));
                        let v42: f64 = f64::NAN;
                        let v44: f64 = f64::NAN;
                        let v46: num_complex::Complex<f64> = num_complex::Complex::new(v42, v44);
                        let v49: num_complex::Complex<f64> = match &v37 {
                            Math::US0::US0_0(v37_0_0) => match &v37 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v46.clone(),
                        };
                        let v51: f64 = v49.clone().re;
                        let v52: bool = (v51) == 0.0_f64;
                        let v54: bool = if v52 { true } else { Math::method18(v52) };
                        let v56: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_eq"),
                            v51,
                            0.0_f64
                        );
                        let v61: () = {
                            Math::closure2(v56.clone(), ());
                            ()
                        };
                        if (v54) == false {
                            panic!("{}", v56,);
                        }
                        {
                            let v65: f64 = v49.im;
                            let v66: bool = (v65) == 0.0_f64;
                            let v68: bool = if v66 { true } else { Math::method18(v66) };
                            let v69: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_eq"),
                                v65,
                                0.0_f64
                            );
                            let v74: () = {
                                Math::closure2(v69.clone(), ());
                                ()
                            };
                            if (v68) == false {
                                panic!("{}", v69,);
                            }
                            {
                                let v0_1_temp: pyo3::Python = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<Math::UH0> =
                                    match v1_1.get().clone().as_ref() {
                                        Math::UH0::UH0_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                continue '_method25;
                            }
                        }
                    }
                });
            }
        }
        pub fn method23(v0_1: pyo3::Python) {
            Math::method25(v0_1, Math::method24());
        }
        pub fn method22() {
            pyo3::prepare_freethreaded_python();
            let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method23(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v23: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v24: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v26: Result<(), pyo3::PyErr> = __run_test;
                v26.unwrap();
                ()
            }
        }
        pub fn method27(v0_1: pyo3::Python) {
            let v13: Array<num_complex::Complex<f64>> = new_array(&[
                num_complex::Complex::new(0.5_f64, 14.134725_f64),
                num_complex::Complex::new(0.5_f64, 21.02204_f64),
                num_complex::Complex::new(0.5_f64, 25.010857_f64),
                num_complex::Complex::new(0.5_f64, 30.424876_f64),
                num_complex::Complex::new(0.5_f64, 32.935062_f64),
                num_complex::Complex::new(0.5_f64, 37.586178_f64),
            ]);
            let v14: i32 = get_Count(v13.clone());
            let v15: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method2(v14, v15.clone()) {
                let v17: i32 = v15.l0.get().clone();
                let v18: num_complex::Complex<f64> = v13[v17].clone();
                let v21: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                    v0_1.clone(),
                    string("        s = mpmath.zeta(s)"),
                    Math::method3(v18.clone()),
                );
                let v22: num_complex::Complex<f64> = Math::method13(v0_1.clone(), v18);
                let v25: Option<num_complex::Complex<f64>> = v21.ok();
                let v50: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v25));
                let v55: f64 = f64::NAN;
                let v57: f64 = f64::NAN;
                let v59: num_complex::Complex<f64> = num_complex::Complex::new(v55, v57);
                let v62: num_complex::Complex<f64> = match &v50 {
                    Math::US0::US0_0(v50_0_0) => match &v50 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v59.clone(),
                };
                let v64: f64 = v62.clone().re;
                let v65: f64 = -v64;
                let v67: f64 = if (v64) >= (v65) { v64 } else { v65 };
                let v68: bool = (v67) < 0.0001_f64;
                let v70: bool = if v68 { true } else { Math::method18(v68) };
                let v72: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_lt"),
                    v67,
                    0.0001_f64
                );
                let v77: () = {
                    Math::closure2(v72.clone(), ());
                    ()
                };
                if (v70) == false {
                    panic!("{}", v72,);
                }
                {
                    let v81: f64 = v62.im;
                    let v82: f64 = -v81;
                    let v84: f64 = if (v81) >= (v82) { v81 } else { v82 };
                    let v85: bool = (v84) < 0.0001_f64;
                    let v87: bool = if v85 { true } else { Math::method18(v85) };
                    let v88: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_lt"),
                        v84,
                        0.0001_f64
                    );
                    let v93: () = {
                        Math::closure2(v88.clone(), ());
                        ()
                    };
                    if (v87) == false {
                        panic!("{}", v88,);
                    }
                    {
                        let v96: i32 = (v17) + 1_i32;
                        v15.l0.set(v96);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method26() {
            pyo3::prepare_freethreaded_python();
            let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method27(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v23: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v24: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v26: Result<(), pyo3::PyErr> = __run_test;
                v26.unwrap();
                ()
            }
        }
        pub fn method29(v0_1: pyo3::Python) {
            let v1_1: Array<f64> = new_array(&[
                2.0_f64, 3.0_f64, 4.0_f64, 5.0_f64, 10.0_f64, 20.0_f64, 50.0_f64,
            ]);
            let v2: i32 = get_Count(v1_1.clone());
            let v3: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method2(v2, v3.clone()) {
                let v5: i32 = v3.l0.get().clone();
                let v6: f64 = v1_1[v5].clone();
                let v8: num_complex::Complex<f64> = num_complex::Complex::new(v6, 0.0_f64);
                let v11: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                    v0_1.clone(),
                    string("        s = mpmath.zeta(s)"),
                    Math::method3(v8.clone()),
                );
                let v12: num_complex::Complex<f64> = Math::method13(v0_1.clone(), v8);
                let v15: Option<num_complex::Complex<f64>> = v11.ok();
                let v40: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v15));
                let v45: f64 = f64::NAN;
                let v47: f64 = f64::NAN;
                let v49: num_complex::Complex<f64> = num_complex::Complex::new(v45, v47);
                let v52: num_complex::Complex<f64> = match &v40 {
                    Math::US0::US0_0(v40_0_0) => match &v40 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v49.clone(),
                };
                let v54: f64 = v52.clone().re;
                let v55: bool = (v54) > 0.0_f64;
                let v57: bool = if v55 { true } else { Math::method18(v55) };
                let v59: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_gt"),
                    v54,
                    0.0_f64
                );
                let v64: () = {
                    Math::closure2(v59.clone(), ());
                    ()
                };
                if (v57) == false {
                    panic!("{}", v59,);
                }
                {
                    let v68: f64 = v52.im;
                    let v69: bool = (v68) == 0.0_f64;
                    let v71: bool = if v69 { true } else { Math::method18(v69) };
                    let v73: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_eq"),
                        v68,
                        0.0_f64
                    );
                    let v78: () = {
                        Math::closure2(v73.clone(), ());
                        ()
                    };
                    if (v71) == false {
                        panic!("{}", v73,);
                    }
                    {
                        let v81: i32 = (v5) + 1_i32;
                        v3.l0.set(v81);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method28() {
            pyo3::prepare_freethreaded_python();
            let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method29(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v23: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v24: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v26: Result<(), pyo3::PyErr> = __run_test;
                v26.unwrap();
                ()
            }
        }
        pub fn method31(v0_1: pyo3::Python) {
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(1.0_f64, 0.0_f64);
            let v5: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v2.clone()),
            );
            let v6: num_complex::Complex<f64> = Math::method13(v0_1, v2);
            let v9: Option<num_complex::Complex<f64>> = v5.ok();
            let v34: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v9));
            let v39: f64 = f64::NAN;
            let v41: f64 = f64::NAN;
            let v43: num_complex::Complex<f64> = num_complex::Complex::new(v39, v41);
            let v46: num_complex::Complex<f64> = match &v34 {
                Math::US0::US0_0(v34_0_0) => match &v34 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v43.clone(),
            };
            let v48: f64 = v46.clone().re;
            let v49: bool = (v48) == (f64::INFINITY);
            let v51: bool = if v49 { true } else { Math::method18(v49) };
            let v53: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_eq"),
                v48,
                f64::INFINITY
            );
            let v58: () = {
                Math::closure2(v53.clone(), ());
                ()
            };
            if (v51) == false {
                panic!("{}", v53,);
            }
            {
                let v62: f64 = v46.im;
                let v63: bool = (v62) == 0.0_f64;
                let v65: bool = if v63 { true } else { Math::method18(v63) };
                let v66: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_eq"),
                    v62,
                    0.0_f64
                );
                let v71: () = {
                    Math::closure2(v66.clone(), ());
                    ()
                };
                if (v65) == false {
                    panic!("{}", v66,);
                }
            }
        }
        pub fn method30() {
            pyo3::prepare_freethreaded_python();
            let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method31(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v23: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v24: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v26: Result<(), pyo3::PyErr> = __run_test;
                v26.unwrap();
                ()
            }
        }
        pub fn method33(v0_1: pyo3::Python) {
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 10.0_f64);
            let v5: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v2.clone()),
            );
            let v6: num_complex::Complex<f64> = Math::method13(v0_1.clone(), v2.clone());
            let v9: Option<num_complex::Complex<f64>> = v5.ok();
            let v34: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v9));
            let v39: f64 = f64::NAN;
            let v41: f64 = f64::NAN;
            let v43: num_complex::Complex<f64> = num_complex::Complex::new(v39, v41);
            let v46: num_complex::Complex<f64> = match &v34 {
                Math::US0::US0_0(v34_0_0) => match &v34 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v43.clone(),
            };
            let v48: f64 = v2.clone().re;
            let v51: f64 = -v2.im;
            let v53: num_complex::Complex<f64> = num_complex::Complex::new(v48, v51);
            let v56: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v53.clone()),
            );
            let v57: num_complex::Complex<f64> = Math::method13(v0_1, v53);
            let v60: Option<num_complex::Complex<f64>> = v56.ok();
            let v85: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v60));
            let v90: f64 = f64::NAN;
            let v92: f64 = f64::NAN;
            let v94: num_complex::Complex<f64> = num_complex::Complex::new(v90, v92);
            let v97: num_complex::Complex<f64> = match &v85 {
                Math::US0::US0_0(v85_0_0) => match &v85 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v94.clone(),
            };
            let v99: num_complex::Complex<f64> = v97.conj();
            let v101: f64 = v46.clone().re;
            let v103: f64 = v99.clone().re;
            let v104: bool = (v101) == (v103);
            let v106: bool = if v104 { true } else { Math::method18(v104) };
            let v108: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_eq"),
                v101,
                v103
            );
            let v113: () = {
                Math::closure2(v108.clone(), ());
                ()
            };
            if (v106) == false {
                panic!("{}", v108,);
            }
            {
                let v117: f64 = v46.im;
                let v119: f64 = v99.im;
                let v120: bool = (v117) == (v119);
                let v122: bool = if v120 { true } else { Math::method18(v120) };
                let v123: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_eq"),
                    v117,
                    v119
                );
                let v128: () = {
                    Math::closure2(v123.clone(), ());
                    ()
                };
                if (v122) == false {
                    panic!("{}", v123,);
                }
            }
        }
        pub fn method32() {
            pyo3::prepare_freethreaded_python();
            let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method33(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v23: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v24: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v26: Result<(), pyo3::PyErr> = __run_test;
                v26.unwrap();
                ()
            }
        }
        pub fn method35(v0_1: pyo3::Python) {
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(0.01_f64, 0.01_f64);
            let v5: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v2.clone()),
            );
            let v6: num_complex::Complex<f64> = Math::method13(v0_1, v2);
            let v9: Option<num_complex::Complex<f64>> = v5.ok();
            let v34: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v9));
            let v39: f64 = f64::NAN;
            let v41: f64 = f64::NAN;
            let v43: num_complex::Complex<f64> = num_complex::Complex::new(v39, v41);
            let v46: num_complex::Complex<f64> = match &v34 {
                Math::US0::US0_0(v34_0_0) => match &v34 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v43.clone(),
            };
            let v48: f64 = v46.clone().re;
            let v49: bool = (v48) < (f64::INFINITY);
            let v51: bool = if v49 { true } else { Math::method18(v49) };
            let v53: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_lt"),
                v48,
                f64::INFINITY
            );
            let v58: () = {
                Math::closure2(v53.clone(), ());
                ()
            };
            if (v51) == false {
                panic!("{}", v53,);
            }
            {
                let v62: f64 = v46.im;
                let v63: bool = (v62) < (f64::INFINITY);
                let v65: bool = if v63 { true } else { Math::method18(v63) };
                let v66: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_lt"),
                    v62,
                    f64::INFINITY
                );
                let v71: () = {
                    Math::closure2(v66.clone(), ());
                    ()
                };
                if (v65) == false {
                    panic!("{}", v66,);
                }
            }
        }
        pub fn method34() {
            pyo3::prepare_freethreaded_python();
            let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method35(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v23: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v24: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v26: Result<(), pyo3::PyErr> = __run_test;
                v26.unwrap();
                ()
            }
        }
        pub fn method38() -> LrcPtr<Math::UH0> {
            LrcPtr::new(Math::UH0::UH0_1(
                10.0_f64,
                LrcPtr::new(Math::UH0::UH0_1(
                    20.0_f64,
                    LrcPtr::new(Math::UH0::UH0_1(
                        30.0_f64,
                        LrcPtr::new(Math::UH0::UH0_1(
                            40.0_f64,
                            LrcPtr::new(Math::UH0::UH0_1(
                                50.0_f64,
                                LrcPtr::new(Math::UH0::UH0_1(
                                    60.0_f64,
                                    LrcPtr::new(Math::UH0::UH0_1(
                                        70.0_f64,
                                        LrcPtr::new(Math::UH0::UH0_1(
                                            80.0_f64,
                                            LrcPtr::new(Math::UH0::UH0_1(
                                                90.0_f64,
                                                LrcPtr::new(Math::UH0::UH0_1(
                                                    100.0_f64,
                                                    LrcPtr::new(Math::UH0::UH0_0),
                                                )),
                                            )),
                                        )),
                                    )),
                                )),
                            )),
                        )),
                    )),
                )),
            ))
        }
        pub fn method39(v0_1: pyo3::Python, v1_1: LrcPtr<Math::UH0>) {
            let v0_1: MutCell<pyo3::Python> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1_1.clone());
            '_method39: loop {
                break '_method39 (match v1_1.get().clone().as_ref() {
                    Math::UH0::UH0_0 => (),
                    Math::UH0::UH0_1(v1_1_1_0, v1_1_1_1) => {
                        let v5: num_complex::Complex<f64> = num_complex::Complex::new(
                            0.0_f64,
                            match v1_1.get().clone().as_ref() {
                                Math::UH0::UH0_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        let v8: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(
                                v0_1.get().clone(),
                                string("        s = mpmath.zeta(s)"),
                                Math::method3(v5.clone()),
                            );
                        let v9: num_complex::Complex<f64> = Math::method13(v0_1.get().clone(), v5);
                        let v12: Option<num_complex::Complex<f64>> = v8.ok();
                        let v37: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v12));
                        let v42: f64 = f64::NAN;
                        let v44: f64 = f64::NAN;
                        let v46: num_complex::Complex<f64> = num_complex::Complex::new(v42, v44);
                        let v49: num_complex::Complex<f64> = match &v37 {
                            Math::US0::US0_0(v37_0_0) => match &v37 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v46.clone(),
                        };
                        let v51: f64 = v49.clone().re;
                        let v52: bool = (v51) != 0.0_f64;
                        let v56: bool = if v52 { true } else { Math::method18(v52) };
                        let v58: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_ne"),
                            v51,
                            0.0_f64
                        );
                        let v63: () = {
                            Math::closure2(v58.clone(), ());
                            ()
                        };
                        if (v56) == false {
                            panic!("{}", v58,);
                        }
                        {
                            let v67: f64 = v49.im;
                            let v68: bool = (v67) != 0.0_f64;
                            let v72: bool = if v68 { true } else { Math::method18(v68) };
                            let v73: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_ne"),
                                v67,
                                0.0_f64
                            );
                            let v78: () = {
                                Math::closure2(v73.clone(), ());
                                ()
                            };
                            if (v72) == false {
                                panic!("{}", v73,);
                            }
                            {
                                let v0_1_temp: pyo3::Python = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<Math::UH0> =
                                    match v1_1.get().clone().as_ref() {
                                        Math::UH0::UH0_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                continue '_method39;
                            }
                        }
                    }
                });
            }
        }
        pub fn method37(v0_1: pyo3::Python) {
            Math::method39(v0_1, Math::method38());
        }
        pub fn method36() {
            pyo3::prepare_freethreaded_python();
            let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method37(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v23: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v24: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v26: Result<(), pyo3::PyErr> = __run_test;
                v26.unwrap();
                ()
            }
        }
        pub fn method42() -> LrcPtr<Math::UH1> {
            LrcPtr::new(Math::UH1::UH1_1(
                num_complex::Complex::new(0.5_f64, 14.134725_f64),
                LrcPtr::new(Math::UH1::UH1_1(
                    num_complex::Complex::new(0.75_f64, 20.5_f64),
                    LrcPtr::new(Math::UH1::UH1_1(
                        num_complex::Complex::new(1.25_f64, 30.1_f64),
                        LrcPtr::new(Math::UH1::UH1_1(
                            num_complex::Complex::new(0.25_f64, 40.0_f64),
                            LrcPtr::new(Math::UH1::UH1_1(
                                num_complex::Complex::new(1.0_f64, 50.0_f64),
                                LrcPtr::new(Math::UH1::UH1_0),
                            )),
                        )),
                    )),
                )),
            ))
        }
        pub fn method43(v0_1: pyo3::Python, v1_1: LrcPtr<Math::UH1>) {
            let v0_1: MutCell<pyo3::Python> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Math::UH1>> = MutCell::new(v1_1.clone());
            '_method43: loop {
                break '_method43 (match v1_1.get().clone().as_ref() {
                    Math::UH1::UH1_0 => (),
                    Math::UH1::UH1_1(v1_1_1_0, v1_1_1_1) => {
                        let v2: num_complex::Complex<f64> = match v1_1.get().clone().as_ref() {
                            Math::UH1::UH1_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone();
                        let v6: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(
                                v0_1.get().clone(),
                                string("        s = mpmath.zeta(s)"),
                                Math::method3(v2.clone()),
                            );
                        let v7: num_complex::Complex<f64> = Math::method13(v0_1.get().clone(), v2);
                        let v10: Option<num_complex::Complex<f64>> = v6.ok();
                        let v35: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v10));
                        let v40: f64 = f64::NAN;
                        let v42: f64 = f64::NAN;
                        let v44: num_complex::Complex<f64> = num_complex::Complex::new(v40, v42);
                        let v47: num_complex::Complex<f64> = match &v35 {
                            Math::US0::US0_0(v35_0_0) => match &v35 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v44.clone(),
                        };
                        let v49: f64 = v47.clone().re;
                        let v50: bool = (v49) != 0.0_f64;
                        let v54: bool = if v50 { true } else { Math::method18(v50) };
                        let v56: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_ne"),
                            v49,
                            0.0_f64
                        );
                        let v61: () = {
                            Math::closure2(v56.clone(), ());
                            ()
                        };
                        if (v54) == false {
                            panic!("{}", v56,);
                        }
                        {
                            let v65: f64 = v47.im;
                            let v66: bool = (v65) != 0.0_f64;
                            let v70: bool = if v66 { true } else { Math::method18(v66) };
                            let v71: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_ne"),
                                v65,
                                0.0_f64
                            );
                            let v76: () = {
                                Math::closure2(v71.clone(), ());
                                ()
                            };
                            if (v70) == false {
                                panic!("{}", v71,);
                            }
                            {
                                let v0_1_temp: pyo3::Python = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<Math::UH1> =
                                    match v1_1.get().clone().as_ref() {
                                        Math::UH1::UH1_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                continue '_method43;
                            }
                        }
                    }
                });
            }
        }
        pub fn method41(v0_1: pyo3::Python) {
            Math::method43(v0_1, Math::method42());
        }
        pub fn method40() {
            pyo3::prepare_freethreaded_python();
            let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method41(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v23: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v24: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v26: Result<(), pyo3::PyErr> = __run_test;
                v26.unwrap();
                ()
            }
        }
        pub fn method46() -> LrcPtr<Math::UH1> {
            LrcPtr::new(Math::UH1::UH1_1(
                num_complex::Complex::new(3.0_f64, 4.0_f64),
                LrcPtr::new(Math::UH1::UH1_1(
                    num_complex::Complex::new(2.5_f64, -3.5_f64),
                    LrcPtr::new(Math::UH1::UH1_1(
                        num_complex::Complex::new(1.5_f64, 2.5_f64),
                        LrcPtr::new(Math::UH1::UH1_1(
                            num_complex::Complex::new(0.5_f64, 14.134725_f64),
                            LrcPtr::new(Math::UH1::UH1_0),
                        )),
                    )),
                )),
            ))
        }
        pub fn method47(v0_1: pyo3::Python, v1_1: LrcPtr<Math::UH1>) {
            let v0_1: MutCell<pyo3::Python> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Math::UH1>> = MutCell::new(v1_1.clone());
            '_method47: loop {
                break '_method47 (match v1_1.get().clone().as_ref() {
                    Math::UH1::UH1_0 => (),
                    Math::UH1::UH1_1(v1_1_1_0, v1_1_1_1) => {
                        let v2: num_complex::Complex<f64> = match v1_1.get().clone().as_ref() {
                            Math::UH1::UH1_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone();
                        let v6: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(
                                v0_1.get().clone(),
                                string("        s = mpmath.zeta(s)"),
                                Math::method3(v2.clone()),
                            );
                        let v7: num_complex::Complex<f64> =
                            Math::method13(v0_1.get().clone(), v2.clone());
                        let v10: Option<num_complex::Complex<f64>> = v6.ok();
                        let v35: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v10));
                        let v40: f64 = f64::NAN;
                        let v42: f64 = f64::NAN;
                        let v44: num_complex::Complex<f64> = num_complex::Complex::new(v40, v42);
                        let v47: num_complex::Complex<f64> = match &v35 {
                            Math::US0::US0_0(v35_0_0) => match &v35 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v44.clone(),
                        };
                        let v49: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v51: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v49, v2.clone());
                        let v53: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v55: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v57: num_complex::Complex<f64> = v2.clone() - v55;
                        let v59: num_complex::Complex<f64> = num_complex::Complex::powc(v53, v57);
                        let v61: num_complex::Complex<f64> = v51 * v59;
                        let v63: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v65: num_complex::Complex<f64> = v63 * v2.clone();
                        let v67: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v69: num_complex::Complex<f64> = v65 / v67;
                        let v71: num_complex::Complex<f64> = v69.sin();
                        let v73: num_complex::Complex<f64> = v61 * v71;
                        let v75: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v80: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method16(
                                v0_1.get().clone(),
                                string("        s = mpmath.gamma(s)"),
                                Math::method3(v75 - v2.clone()),
                            );
                        let v83: Option<num_complex::Complex<f64>> = v80.ok();
                        let v108: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v83));
                        let v113: f64 = f64::NAN;
                        let v115: f64 = f64::NAN;
                        let v117: num_complex::Complex<f64> = num_complex::Complex::new(v113, v115);
                        let v120: num_complex::Complex<f64> = match &v108 {
                            Math::US0::US0_0(v108_0_0) => match &v108 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v117.clone(),
                        };
                        let v122: num_complex::Complex<f64> = v73 * v120;
                        let v125: f64 = 1.0_f64 - (v2.clone().re);
                        let v128: f64 = -v2.im;
                        let v130: num_complex::Complex<f64> = num_complex::Complex::new(v125, v128);
                        let v133: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(
                                v0_1.get().clone(),
                                string("        s = mpmath.zeta(s)"),
                                Math::method3(v130.clone()),
                            );
                        let v134: num_complex::Complex<f64> =
                            Math::method13(v0_1.get().clone(), v130);
                        let v137: Option<num_complex::Complex<f64>> = v133.ok();
                        let v162: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v137));
                        let v167: f64 = f64::NAN;
                        let v169: f64 = f64::NAN;
                        let v171: num_complex::Complex<f64> = num_complex::Complex::new(v167, v169);
                        let v174: num_complex::Complex<f64> = match &v162 {
                            Math::US0::US0_0(v162_0_0) => match &v162 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v171.clone(),
                        };
                        let v176: num_complex::Complex<f64> = v122 * v174;
                        let v181: f64 = (v47.clone().re) - (v176.clone().re);
                        let v182: f64 = -v181;
                        let v184: f64 = if (v181) >= (v182) { v181 } else { v182 };
                        let v185: bool = (v184) < 0.0001_f64;
                        let v187: bool = if v185 { true } else { Math::method18(v185) };
                        let v189: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_lt"),
                            v184,
                            0.0001_f64
                        );
                        let v194: () = {
                            Math::closure2(v189.clone(), ());
                            ()
                        };
                        if (v187) == false {
                            panic!("{}", v189,);
                        }
                        {
                            let v201: f64 = (v47.im) - (v176.im);
                            let v202: f64 = -v201;
                            let v204: f64 = if (v201) >= (v202) { v201 } else { v202 };
                            let v205: bool = (v204) < 0.0001_f64;
                            let v207: bool = if v205 { true } else { Math::method18(v205) };
                            let v208: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_lt"),
                                v204,
                                0.0001_f64
                            );
                            let v213: () = {
                                Math::closure2(v208.clone(), ());
                                ()
                            };
                            if (v207) == false {
                                panic!("{}", v208,);
                            }
                            {
                                let v0_1_temp: pyo3::Python = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<Math::UH1> =
                                    match v1_1.get().clone().as_ref() {
                                        Math::UH1::UH1_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                continue '_method47;
                            }
                        }
                    }
                });
            }
        }
        pub fn method45(v0_1: pyo3::Python) {
            Math::method47(v0_1, Math::method46());
        }
        pub fn method44() {
            pyo3::prepare_freethreaded_python();
            let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method45(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v23: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v24: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v26: Result<(), pyo3::PyErr> = __run_test;
                v26.unwrap();
                ()
            }
        }
        pub fn method50() -> LrcPtr<Math::UH0> {
            LrcPtr::new(Math::UH0::UH0_1(
                2.0_f64,
                LrcPtr::new(Math::UH0::UH0_1(
                    2.5_f64,
                    LrcPtr::new(Math::UH0::UH0_1(
                        3.0_f64,
                        LrcPtr::new(Math::UH0::UH0_1(
                            3.5_f64,
                            LrcPtr::new(Math::UH0::UH0_1(
                                4.0_f64,
                                LrcPtr::new(Math::UH0::UH0_1(
                                    4.5_f64,
                                    LrcPtr::new(Math::UH0::UH0_1(
                                        5.0_f64,
                                        LrcPtr::new(Math::UH0::UH0_0),
                                    )),
                                )),
                            )),
                        )),
                    )),
                )),
            ))
        }
        pub fn method51() -> LrcPtr<Math::UH0> {
            LrcPtr::new(Math::UH0::UH0_1(2.0_f64,
                                         LrcPtr::new(Math::UH0::UH0_1(3.0_f64,
                                                                      LrcPtr::new(Math::UH0::UH0_1(5.0_f64,
                                                                                                   LrcPtr::new(Math::UH0::UH0_1(7.0_f64,
                                                                                                                                LrcPtr::new(Math::UH0::UH0_1(11.0_f64,
                                                                                                                                                             LrcPtr::new(Math::UH0::UH0_1(13.0_f64,
                                                                                                                                                                                          LrcPtr::new(Math::UH0::UH0_1(17.0_f64,
                                                                                                                                                                                                                       LrcPtr::new(Math::UH0::UH0_1(19.0_f64,
                                                                                                                                                                                                                                                    LrcPtr::new(Math::UH0::UH0_1(23.0_f64,
                                                                                                                                                                                                                                                                                 LrcPtr::new(Math::UH0::UH0_1(29.0_f64,
                                                                                                                                                                                                                                                                                                              LrcPtr::new(Math::UH0::UH0_1(31.0_f64,
                                                                                                                                                                                                                                                                                                                                           LrcPtr::new(Math::UH0::UH0_1(37.0_f64,
                                                                                                                                                                                                                                                                                                                                                                        LrcPtr::new(Math::UH0::UH0_1(41.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                     LrcPtr::new(Math::UH0::UH0_1(43.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                                                  LrcPtr::new(Math::UH0::UH0_1(47.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                                                                               LrcPtr::new(Math::UH0::UH0_1(53.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            LrcPtr::new(Math::UH0::UH0_1(59.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         LrcPtr::new(Math::UH0::UH0_1(61.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      LrcPtr::new(Math::UH0::UH0_1(67.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   LrcPtr::new(Math::UH0::UH0_1(71.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                LrcPtr::new(Math::UH0::UH0_0)))))))))))))))))))))))))))))))))))))))))
        }
        pub fn method53(v0_1: f64, v1_1: LrcPtr<Math::UH0>, v2: f64) -> f64 {
            let v0_1: MutCell<f64> = MutCell::new(v0_1);
            let v1_1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1_1.clone());
            let v2: MutCell<f64> = MutCell::new(v2);
            '_method53: loop {
                break '_method53 (match v1_1.get().clone().as_ref() {
                    Math::UH0::UH0_0 => v2.get().clone(),
                    Math::UH0::UH0_1(v1_1_1_0, v1_1_1_1) => {
                        let v5: f64 = -v0_1.get().clone();
                        {
                            let v0_1_temp: f64 = v0_1.get().clone();
                            let v1_1_temp: LrcPtr<Math::UH0> = match v1_1.get().clone().as_ref() {
                                Math::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone();
                            let v2_temp: f64 = (v2.get().clone())
                                / (1.0_f64
                                    - (match v1_1.get().clone().as_ref() {
                                        Math::UH0::UH0_1(x, _) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .powf(v5)));
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            continue '_method53;
                        }
                    }
                });
            }
        }
        pub fn method52(v0_1: pyo3::Python, v1_1: LrcPtr<Math::UH0>, v2: LrcPtr<Math::UH0>) {
            let v0_1: MutCell<pyo3::Python> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v2.clone());
            '_method52: loop {
                break '_method52 (match v2.get().clone().as_ref() {
                    Math::UH0::UH0_0 => (),
                    Math::UH0::UH0_1(v2_1_0, v2_1_1) => {
                        let v3: f64 = match v2.get().clone().as_ref() {
                            Math::UH0::UH0_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v6: num_complex::Complex<f64> = num_complex::Complex::new(v3, 0.0_f64);
                        let v8: f64 = Math::method53(v3, v1_1.get().clone(), 1.0_f64);
                        let v11: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(
                                v0_1.get().clone(),
                                string("        s = mpmath.zeta(s)"),
                                Math::method3(v6.clone()),
                            );
                        let v12: num_complex::Complex<f64> = Math::method13(v0_1.get().clone(), v6);
                        let v15: Option<num_complex::Complex<f64>> = v11.ok();
                        let v40: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v15));
                        let v45: f64 = f64::NAN;
                        let v47: f64 = f64::NAN;
                        let v49: num_complex::Complex<f64> = num_complex::Complex::new(v45, v47);
                        let v52: num_complex::Complex<f64> = match &v40 {
                            Math::US0::US0_0(v40_0_0) => match &v40 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v49.clone(),
                        };
                        let v55: f64 = (v52.clone().re) - (v8);
                        let v56: f64 = -v55;
                        let v58: f64 = if (v55) >= (v56) { v55 } else { v56 };
                        let v59: bool = (v58) < 0.01_f64;
                        let v61: bool = if v59 { true } else { Math::method18(v59) };
                        let v63: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_lt"),
                            v58,
                            0.01_f64
                        );
                        let v68: () = {
                            Math::closure2(v63.clone(), ());
                            ()
                        };
                        if (v61) == false {
                            panic!("{}", v63,);
                        }
                        {
                            let v72: f64 = v52.im;
                            let v73: bool = (v72) < 0.01_f64;
                            let v75: bool = if v73 { true } else { Math::method18(v73) };
                            let v76: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_lt"),
                                v72,
                                0.01_f64
                            );
                            let v81: () = {
                                Math::closure2(v76.clone(), ());
                                ()
                            };
                            if (v75) == false {
                                panic!("{}", v76,);
                            }
                            {
                                let v0_1_temp: pyo3::Python = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<Math::UH0> = v1_1.get().clone();
                                let v2_temp: LrcPtr<Math::UH0> = match v2.get().clone().as_ref() {
                                    Math::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                continue '_method52;
                            }
                        }
                    }
                });
            }
        }
        pub fn method49(v0_1: pyo3::Python) {
            let v1_1: LrcPtr<Math::UH0> = Math::method50();
            Math::method52(v0_1, Math::method51(), v1_1)
        }
        pub fn method48() {
            pyo3::prepare_freethreaded_python();
            let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method49(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v23: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v24: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v26: Result<(), pyo3::PyErr> = __run_test;
                v26.unwrap();
                ()
            }
        }
        pub fn closure0(unitVar: (), unitVar_1: ()) {
            let v1_1: bool = true;
            () //;
        } /* /*;
          {
              let v4: string =
                  string("*/ #[test] fn test_zeta_at_known_values_() { //");
              let v5: bool =
                  */
        #[test]
        fn test_zeta_at_known_values_() {
            //;
            Math::method0();
        } /* /*;
          {
              let v8: string =
                  string("*/ #[test] fn test_zeta_at_2_minus2() { //");
              let v9: bool = */
        #[test]
        fn test_zeta_at_2_minus2() {
            //;
            Math::method20();
        } /* /*;
          {
              let v12: string =
                  string("*/ #[test] fn test_trivial_zero_at_negative_even___() { //");
              let v13: bool =
                  */
        #[test]
        fn test_trivial_zero_at_negative_even___() {
            //;
            Math::method22();
        } /* /*;
          {
              let v16: string =
                  string("*/ #[test] fn test_non_trivial_zero___() { //");
              let v17: bool =
                  */
        #[test]
        fn test_non_trivial_zero___() {
            //;
            Math::method26();
        } /* /*;
          {
              let v20: string =
                  string("*/ #[test] fn test_real_part_greater_than_one___() { //");
              let v21: bool =
                  */
        #[test]
        fn test_real_part_greater_than_one___() {
            //;
            Math::method28();
        } /* /*;
          {
              let v24: string =
                  string("*/ #[test] fn test_zeta_at_1___() { //");
              let v25: bool =
                  */
        #[test]
        fn test_zeta_at_1___() {
            //;
            Math::method30();
        } /* /*;
          {
              let v28: string =
                  string("*/ #[test] fn test_symmetry_across_real_axis___() { //");
              let v29: bool =
                  */
        #[test]
        fn test_symmetry_across_real_axis___() {
            //;
            Math::method32();
        } /* /*;
          {
              let v32: string =
                  string("*/ #[test] fn test_behavior_near_origin___() { //");
              let v33: bool =
                  */
        #[test]
        fn test_behavior_near_origin___() {
            //;
            Math::method34();
        } /* /*;
          {
              let v36: string =
                  string("*/ #[test] fn test_imaginary_axis() { //");
              let v37: bool =
                  */
        #[test]
        fn test_imaginary_axis() {
            //;
            Math::method36();
        } /* /*;
          {
              let v40: string =
                  string("*/ #[test] fn test_critical_strip() { //");
              let v41: bool =
                  */
        #[test]
        fn test_critical_strip() {
            //;
            Math::method40();
        } /* /*;
          {
              let v44: string =
                  string("*/ #[test] fn test_reflection_formula_for_specific_value() { //");
              let v45: bool =
                  */
        #[test]
        fn test_reflection_formula_for_specific_value() {
            //;
            Math::method44();
        } /* /*;
          {
              let v48: string =
                  string("*/ #[test] fn test_euler_product_formula() { //");
              let v49: bool =
                  */
        #[test]
        fn test_euler_product_formula() {
            //;
            Math::method48();
            {
                //;
                {
                    //;
                    {
                        //;
                        {
                            //;
                            {
                                //;
                                {
                                    //;
                                    {
                                        //;
                                        {
                                            //;
                                            {
                                                //;
                                                {
                                                    //;
                                                    {
                                                        //;
                                                        {
                                                            //;
                                                            ()
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        pub fn closure3(unitVar: (), v0_1: Array<string>) -> i32 {
            let v4: () = {
                Math::closure2(sprintf!("value: {}", 1_i32), ());
                ()
            };
            0_i32
        }
        pub fn v0() -> Func0<()> {
            static v0: OnceInit<Func0<()>> = OnceInit::new();
            v0.get_or_init(|| Func0::new(move || Math::closure0((), ())))
                .clone()
        }
        pub fn tests() {
            (Math::v0())();
        }
        pub fn v1() -> Func1<Array<string>, i32> {
            static v1: OnceInit<Func1<Array<string>, i32>> = OnceInit::new();
            v1.get_or_init(|| Func1::new(move |v: Array<string>| Math::closure3((), v)))
                .clone()
        }
        pub fn main(args: Array<string>) -> i32 {
            (Math::v1())(args)
        }
    }
}
pub use module_728458a3::*;
#[path = "../../deps/spiral/lib/spiral/async_.rs"]
mod module_763b9e6c;
pub use module_763b9e6c::*;
#[path = "../../deps/spiral/lib/spiral/common.rs"]
mod module_18f1c018;
pub use module_18f1c018::*;
#[path = "../../deps/spiral/lib/spiral/crypto.rs"]
mod module_c0301e36;
pub use module_c0301e36::*;
#[path = "../../deps/spiral/lib/spiral/date_time.rs"]
mod module_e5abed0b;
pub use module_e5abed0b::*;
#[path = "../../deps/spiral/lib/spiral/file_system.rs"]
mod module_336d1dc9;
pub use module_336d1dc9::*;
#[path = "../../deps/spiral/lib/spiral/lib.rs"]
mod module_12dde172;
pub use module_12dde172::*;
#[path = "../../deps/spiral/lib/spiral/networking.rs"]
mod module_7e35832b;
pub use module_7e35832b::*;
#[path = "../../deps/spiral/lib/spiral/platform.rs"]
mod module_afd02cca;
pub use module_afd02cca::*;
#[path = "../../deps/spiral/lib/spiral/runtime.rs"]
mod module_a3c64389;
pub use module_a3c64389::*;
#[path = "../../deps/spiral/lib/spiral/sm.rs"]
mod module_8f227ecb;
pub use module_8f227ecb::*;
#[path = "../../deps/spiral/lib/spiral/threading.rs"]
mod module_e08c16fb;
pub use module_e08c16fb::*;
#[path = "../../deps/spiral/lib/spiral/trace.rs"]
mod module_702ddcb4;
pub use module_702ddcb4::*;
#[path = "../../lib/fsharp/Common.rs"]
mod module_eb7e4788;
pub use module_eb7e4788::*;
pub mod Polyglot {
    pub use crate::module_eb7e4788::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Math::main(array_from(args));
}
