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
            let v46: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v2.clone().re, v2.im))));
            let v49: pyo3::Python = Math::method7(v0_1);
            let v56: &str = &*v36;
            let v89: std::string::String = String::from(v56);
            let v117: std::ffi::CString = std::ffi::CString::new(v89).unwrap();
            let v125: &str = &*string("");
            let v158: std::string::String = String::from(v125);
            let v186: std::ffi::CString = std::ffi::CString::new(v158).unwrap();
            let v188: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code(v49, &v117, &v186, &v186);
            let v190: bool = true;
            let _result_map_error__ = v188.map_err(|x| {
                //;
                let v192: pyo3::PyErr = x;
                let v199: std::string::String = format!("{}", v192);
                let v227: bool = true;
                v199
            });
            let v229: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                _result_map_error__;
            let v233: pyo3::Bound<pyo3::types::PyModule> = v229.unwrap();
            let v245: string = Math::method8();
            let v252: &str = &*v245;
            let v279: pyo3::Bound<pyo3::types::PyModule> = Math::method9(v233);
            let v281: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v279.getattr(v252);
            let v283: bool = true;
            let _result_map_error__ = v281.map_err(|x| {
                //;
                let v285: pyo3::PyErr = x;
                let v292: std::string::String = format!("{}", v285);
                let v320: bool = true;
                v292
            });
            let v322: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v326: pyo3::Bound<pyo3::PyAny> = v322.unwrap();
            let v338: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method10(v46.0.clone(), v46.1.clone());
            let v339: pyo3::Bound<pyo3::PyAny> = Math::method11(v326);
            let v341: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                pyo3::prelude::PyAnyMethods::call(&v339, ((*v338).0, *(*v338).1), None);
            let v343: bool = true;
            let _result_map_error__ = v341.map_err(|x| {
                //;
                let v345: pyo3::PyErr = x;
                let v352: std::string::String = format!("{}", v345);
                let v380: bool = true;
                v352
            });
            let v382: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v385: pyo3::Bound<pyo3::PyAny> = Math::method12(v382?);
            let v387: Result<(f64, f64), pyo3::PyErr> = v385.extract();
            let v389: bool = true;
            let _result_map_error__ = v387.map_err(|x| {
                //;
                let v391: pyo3::PyErr = x;
                let v398: std::string::String = format!("{}", v391);
                let v426: bool = true;
                v398
            });
            let v428: Result<(f64, f64), std::string::String> = _result_map_error__;
            let patternInput: (f64, f64) = v428?;
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
            let v46: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v2.clone().re, v2.im))));
            let v49: pyo3::Python = Math::method7(v0_1);
            let v56: &str = &*v36;
            let v89: std::string::String = String::from(v56);
            let v117: std::ffi::CString = std::ffi::CString::new(v89).unwrap();
            let v125: &str = &*string("");
            let v158: std::string::String = String::from(v125);
            let v186: std::ffi::CString = std::ffi::CString::new(v158).unwrap();
            let v188: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code(v49, &v117, &v186, &v186);
            let v190: bool = true;
            let _result_map_error__ = v188.map_err(|x| {
                //;
                let v192: pyo3::PyErr = x;
                let v199: std::string::String = format!("{}", v192);
                let v227: bool = true;
                v199
            });
            let v229: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                _result_map_error__;
            let v233: pyo3::Bound<pyo3::types::PyModule> = v229.unwrap();
            let v245: string = Math::method8();
            let v252: &str = &*v245;
            let v279: pyo3::Bound<pyo3::types::PyModule> = Math::method9(v233);
            let v281: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v279.getattr(v252);
            let v283: bool = true;
            let _result_map_error__ = v281.map_err(|x| {
                //;
                let v285: pyo3::PyErr = x;
                let v292: std::string::String = format!("{}", v285);
                let v320: bool = true;
                v292
            });
            let v322: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v326: pyo3::Bound<pyo3::PyAny> = v322.unwrap();
            let v338: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method10(v46.0.clone(), v46.1.clone());
            let v339: pyo3::Bound<pyo3::PyAny> = Math::method11(v326);
            let v341: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                pyo3::prelude::PyAnyMethods::call(&v339, ((*v338).0, *(*v338).1), None);
            let v343: bool = true;
            let _result_map_error__ = v341.map_err(|x| {
                //;
                let v345: pyo3::PyErr = x;
                let v352: std::string::String = format!("{}", v345);
                let v380: bool = true;
                v352
            });
            let v382: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v385: pyo3::Bound<pyo3::PyAny> = Math::method12(v382?);
            let v387: Result<(f64, f64), pyo3::PyErr> = v385.extract();
            let v389: bool = true;
            let _result_map_error__ = v387.map_err(|x| {
                //;
                let v391: pyo3::PyErr = x;
                let v398: std::string::String = format!("{}", v391);
                let v426: bool = true;
                v398
            });
            let v428: Result<(f64, f64), std::string::String> = _result_map_error__;
            let patternInput: (f64, f64) = v428?;
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
                        let v23: f64 = v18 as f64;
                        let v27: num_complex::Complex<f64> =
                            num_complex::Complex::new(v23, 0.0_f64);
                        let v29: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v27, v1_1.clone());
                        let v31: num_complex::Complex<f64> = v20 / v29;
                        let v33: num_complex::Complex<f64> = v17 + v31;
                        let v34: i32 = (v16) + 1_i32;
                        v14.l0.set(v34);
                        v14.l1.set(v33);
                        ()
                    }
                    v14.l1.get().clone()
                }
            } else {
                let v37: num_complex::Complex<f64> = num_complex::Complex::new(1.0_f64, 0.0_f64);
                let v42: Result<num_complex::Complex<f64>, std::string::String> = Math::method16(
                    v0_1.clone(),
                    string("        s = mpmath.gamma(s)"),
                    Math::method3(v37 - v1_1.clone()),
                );
                let v46: Option<num_complex::Complex<f64>> = v42.ok();
                let v74: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v46));
                let v79: f64 = f64::NAN;
                let v81: f64 = f64::NAN;
                let v83: num_complex::Complex<f64> = num_complex::Complex::new(v79, v81);
                let v86: num_complex::Complex<f64> = match &v74 {
                    Math::US0::US0_0(v74_0_0) => match &v74 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v83.clone(),
                };
                let v88: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v90: num_complex::Complex<f64> = v88 * v1_1.clone();
                let v92: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v94: num_complex::Complex<f64> = v90 / v92;
                let v96: num_complex::Complex<f64> = v94.sin();
                let v99: f64 = 1.0_f64 - (v1_1.clone().re);
                let v102: f64 = -v1_1.clone().im;
                let v104: num_complex::Complex<f64> = num_complex::Complex::new(v99, v102);
                let v606: num_complex::Complex<f64> = if (v104.clone().re) <= 1.0_f64 {
                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                } else {
                    println!("zeta / count: {:?} / s: {:?}", 1_i32, v104.clone());
                    if (v104.clone().re) > 1.0_f64 {
                        let v115: num_complex::Complex<f64> =
                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                        let v116: Array<i32> = new_init(&0_i32, 10000_i32);
                        let v117: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                            l0: MutCell::new(0_i32),
                        });
                        while Math::method14(v117.clone()) {
                            let v119: i32 = v117.l0.get().clone();
                            v116.get_mut()[v119 as usize] = v119;
                            {
                                let v120: i32 = (v119) + 1_i32;
                                v117.l0.set(v120);
                                ()
                            }
                        }
                        {
                            let v121: i32 = get_Count(v116.clone());
                            let v122: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                l0: MutCell::new(0_i32),
                                l1: MutCell::new(v115),
                            });
                            while Math::method15(v121, v122.clone()) {
                                let v124: i32 = v122.l0.get().clone();
                                let v125: num_complex::Complex<f64> = v122.l1.get().clone();
                                let v126: i32 = v116[v124].clone();
                                let v128: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v131: f64 = v126 as f64;
                                let v135: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v131, 0.0_f64);
                                let v137: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v135, v104.clone());
                                let v139: num_complex::Complex<f64> = v128 / v137;
                                let v141: num_complex::Complex<f64> = v125 + v139;
                                let v142: i32 = (v124) + 1_i32;
                                v122.l0.set(v142);
                                v122.l1.set(v141);
                                ()
                            }
                            v122.l1.get().clone()
                        }
                    } else {
                        let v145: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v150: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method16(
                                v0_1.clone(),
                                string("        s = mpmath.gamma(s)"),
                                Math::method3(v145 - v104.clone()),
                            );
                        let v154: Option<num_complex::Complex<f64>> = v150.ok();
                        let v182: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v154));
                        let v187: f64 = f64::NAN;
                        let v189: f64 = f64::NAN;
                        let v191: num_complex::Complex<f64> = num_complex::Complex::new(v187, v189);
                        let v194: num_complex::Complex<f64> = match &v182 {
                            Math::US0::US0_0(v182_0_0) => match &v182 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v191.clone(),
                        };
                        let v196: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v198: num_complex::Complex<f64> = v196 * v104.clone();
                        let v200: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v202: num_complex::Complex<f64> = v198 / v200;
                        let v204: num_complex::Complex<f64> = v202.sin();
                        let v207: f64 = 1.0_f64 - (v104.clone().re);
                        let v210: f64 = -v104.clone().im;
                        let v212: num_complex::Complex<f64> = num_complex::Complex::new(v207, v210);
                        let v590: num_complex::Complex<f64> = if (v212.clone().re) <= 1.0_f64 {
                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                        } else {
                            println!("zeta / count: {:?} / s: {:?}", 2_i32, v212.clone());
                            if (v212.clone().re) > 1.0_f64 {
                                let v223: num_complex::Complex<f64> =
                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                let v224: Array<i32> = new_init(&0_i32, 10000_i32);
                                let v225: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Math::method14(v225.clone()) {
                                    let v227: i32 = v225.l0.get().clone();
                                    v224.get_mut()[v227 as usize] = v227;
                                    {
                                        let v228: i32 = (v227) + 1_i32;
                                        v225.l0.set(v228);
                                        ()
                                    }
                                }
                                {
                                    let v229: i32 = get_Count(v224.clone());
                                    let v230: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                        l0: MutCell::new(0_i32),
                                        l1: MutCell::new(v223),
                                    });
                                    while Math::method15(v229, v230.clone()) {
                                        let v232: i32 = v230.l0.get().clone();
                                        let v233: num_complex::Complex<f64> = v230.l1.get().clone();
                                        let v234: i32 = v224[v232].clone();
                                        let v236: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v239: f64 = v234 as f64;
                                        let v243: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v239, 0.0_f64);
                                        let v245: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v243, v212.clone());
                                        let v247: num_complex::Complex<f64> = v236 / v245;
                                        let v249: num_complex::Complex<f64> = v233 + v247;
                                        let v250: i32 = (v232) + 1_i32;
                                        v230.l0.set(v250);
                                        v230.l1.set(v249);
                                        ()
                                    }
                                    v230.l1.get().clone()
                                }
                            } else {
                                let v253: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v258: Result<num_complex::Complex<f64>, std::string::String> =
                                    Math::method16(
                                        v0_1.clone(),
                                        string("        s = mpmath.gamma(s)"),
                                        Math::method3(v253 - v212.clone()),
                                    );
                                let v262: Option<num_complex::Complex<f64>> = v258.ok();
                                let v290: Math::US0 =
                                    defaultValue(Math::US0::US0_1, map(Math::method17(), v262));
                                let v295: f64 = f64::NAN;
                                let v297: f64 = f64::NAN;
                                let v299: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v295, v297);
                                let v302: num_complex::Complex<f64> = match &v290 {
                                    Math::US0::US0_0(v290_0_0) => match &v290 {
                                        Math::US0::US0_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                    _ => v299.clone(),
                                };
                                let v304: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v306: num_complex::Complex<f64> = v304 * v212.clone();
                                let v308: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v310: num_complex::Complex<f64> = v306 / v308;
                                let v312: num_complex::Complex<f64> = v310.sin();
                                let v315: f64 = 1.0_f64 - (v212.clone().re);
                                let v318: f64 = -v212.clone().im;
                                let v320: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v315, v318);
                                let v574: num_complex::Complex<f64> = if (v320.clone().re)
                                    <= 1.0_f64
                                {
                                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                                } else {
                                    println!("zeta / count: {:?} / s: {:?}", 3_i32, v320.clone());
                                    if (v320.clone().re) > 1.0_f64 {
                                        let v331: num_complex::Complex<f64> =
                                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                                        let v332: Array<i32> = new_init(&0_i32, 10000_i32);
                                        let v333: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                            l0: MutCell::new(0_i32),
                                        });
                                        while Math::method14(v333.clone()) {
                                            let v335: i32 = v333.l0.get().clone();
                                            v332.get_mut()[v335 as usize] = v335;
                                            {
                                                let v336: i32 = (v335) + 1_i32;
                                                v333.l0.set(v336);
                                                ()
                                            }
                                        }
                                        {
                                            let v337: i32 = get_Count(v332.clone());
                                            let v338: LrcPtr<Math::Mut2> =
                                                LrcPtr::new(Math::Mut2 {
                                                    l0: MutCell::new(0_i32),
                                                    l1: MutCell::new(v331),
                                                });
                                            while Math::method15(v337, v338.clone()) {
                                                let v340: i32 = v338.l0.get().clone();
                                                let v341: num_complex::Complex<f64> =
                                                    v338.l1.get().clone();
                                                let v342: i32 = v332[v340].clone();
                                                let v344: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v347: f64 = v342 as f64;
                                                let v351: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v347, 0.0_f64);
                                                let v353: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v351, v320.clone());
                                                let v355: num_complex::Complex<f64> = v344 / v353;
                                                let v357: num_complex::Complex<f64> = v341 + v355;
                                                let v358: i32 = (v340) + 1_i32;
                                                v338.l0.set(v358);
                                                v338.l1.set(v357);
                                                ()
                                            }
                                            v338.l1.get().clone()
                                        }
                                    } else {
                                        let v361: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v366: Result<
                                            num_complex::Complex<f64>,
                                            std::string::String,
                                        > = Math::method16(
                                            v0_1.clone(),
                                            string("        s = mpmath.gamma(s)"),
                                            Math::method3(v361 - v320.clone()),
                                        );
                                        let v370: Option<num_complex::Complex<f64>> = v366.ok();
                                        let v398: Math::US0 = defaultValue(
                                            Math::US0::US0_1,
                                            map(Math::method17(), v370),
                                        );
                                        let v403: f64 = f64::NAN;
                                        let v405: f64 = f64::NAN;
                                        let v407: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v403, v405);
                                        let v410: num_complex::Complex<f64> = match &v398 {
                                            Math::US0::US0_0(v398_0_0) => match &v398 {
                                                Math::US0::US0_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                            _ => v407.clone(),
                                        };
                                        let v412: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v414: num_complex::Complex<f64> = v412 * v320.clone();
                                        let v416: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v418: num_complex::Complex<f64> = v414 / v416;
                                        let v420: num_complex::Complex<f64> = v418.sin();
                                        let v423: f64 = 1.0_f64 - (v320.clone().re);
                                        let v426: f64 = -v320.clone().im;
                                        let v428: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v423, v426);
                                        let v558: num_complex::Complex<f64> = if (v428.clone().re)
                                            <= 1.0_f64
                                        {
                                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                                        } else {
                                            println!(
                                                "zeta / count: {:?} / s: {:?}",
                                                4_i32,
                                                v428.clone()
                                            );
                                            if (v428.clone().re) > 1.0_f64 {
                                                let v439: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                                let v440: Array<i32> = new_init(&0_i32, 10000_i32);
                                                let v441: LrcPtr<Math::Mut0> =
                                                    LrcPtr::new(Math::Mut0 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Math::method14(v441.clone()) {
                                                    let v443: i32 = v441.l0.get().clone();
                                                    v440.get_mut()[v443 as usize] = v443;
                                                    {
                                                        let v444: i32 = (v443) + 1_i32;
                                                        v441.l0.set(v444);
                                                        ()
                                                    }
                                                }
                                                {
                                                    let v445: i32 = get_Count(v440.clone());
                                                    let v446: LrcPtr<Math::Mut2> =
                                                        LrcPtr::new(Math::Mut2 {
                                                            l0: MutCell::new(0_i32),
                                                            l1: MutCell::new(v439),
                                                        });
                                                    while Math::method15(v445, v446.clone()) {
                                                        let v448: i32 = v446.l0.get().clone();
                                                        let v449: num_complex::Complex<f64> =
                                                            v446.l1.get().clone();
                                                        let v450: i32 = v440[v448].clone();
                                                        let v452: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                1.0_f64, 0.0_f64,
                                                            );
                                                        let v455: f64 = v450 as f64;
                                                        let v459: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                v455, 0.0_f64,
                                                            );
                                                        let v461: num_complex::Complex<f64> =
                                                            num_complex::Complex::powc(
                                                                v459,
                                                                v428.clone(),
                                                            );
                                                        let v463: num_complex::Complex<f64> =
                                                            v452 / v461;
                                                        let v465: num_complex::Complex<f64> =
                                                            v449 + v463;
                                                        let v466: i32 = (v448) + 1_i32;
                                                        v446.l0.set(v466);
                                                        v446.l1.set(v465);
                                                        ()
                                                    }
                                                    v446.l1.get().clone()
                                                }
                                            } else {
                                                let v469: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v474: Result<
                                                    num_complex::Complex<f64>,
                                                    std::string::String,
                                                > = Math::method16(
                                                    v0_1,
                                                    string("        s = mpmath.gamma(s)"),
                                                    Math::method3(v469 - v428.clone()),
                                                );
                                                let v478: Option<num_complex::Complex<f64>> =
                                                    v474.ok();
                                                let v506: Math::US0 = defaultValue(
                                                    Math::US0::US0_1,
                                                    map(Math::method17(), v478),
                                                );
                                                let v511: f64 = f64::NAN;
                                                let v513: f64 = f64::NAN;
                                                let v515: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v511, v513);
                                                let v518: num_complex::Complex<f64> = match &v506 {
                                                    Math::US0::US0_0(v506_0_0) => match &v506 {
                                                        Math::US0::US0_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                    _ => v515.clone(),
                                                };
                                                let v520: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(
                                                        3.141592653589793_f64,
                                                        0.0_f64,
                                                    );
                                                let v522: num_complex::Complex<f64> =
                                                    v520 * v428.clone();
                                                let v524: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                let v526: num_complex::Complex<f64> = v522 / v524;
                                                let v528: num_complex::Complex<f64> = v526.sin();
                                                let v531: f64 = 1.0_f64 - (v428.clone().re);
                                                let v534: f64 = -v428.clone().im;
                                                let v536: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v531, v534);
                                                let v542: num_complex::Complex<f64> =
                                                    if (v536.clone().re) <= 1.0_f64 {
                                                        num_complex::Complex::new(0.0_f64, 0.0_f64)
                                                    } else {
                                                        v536
                                                    };
                                                let v544: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                let v546: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(
                                                        3.141592653589793_f64,
                                                        0.0_f64,
                                                    );
                                                let v548: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v546, v428.clone());
                                                let v550: num_complex::Complex<f64> = v544 * v548;
                                                let v552: num_complex::Complex<f64> = v550 * v528;
                                                let v554: num_complex::Complex<f64> = v552 * v518;
                                                v554 * v542
                                            }
                                        };
                                        let v560: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v562: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v564: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v562, v320.clone());
                                        let v566: num_complex::Complex<f64> = v560 * v564;
                                        let v568: num_complex::Complex<f64> = v566 * v420;
                                        let v570: num_complex::Complex<f64> = v568 * v410;
                                        v570 * v558
                                    }
                                };
                                let v576: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v578: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v580: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v578, v212.clone());
                                let v582: num_complex::Complex<f64> = v576 * v580;
                                let v584: num_complex::Complex<f64> = v582 * v312;
                                let v586: num_complex::Complex<f64> = v584 * v302;
                                v586 * v574
                            }
                        };
                        let v592: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v594: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v596: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v594, v104.clone());
                        let v598: num_complex::Complex<f64> = v592 * v596;
                        let v600: num_complex::Complex<f64> = v598 * v204;
                        let v602: num_complex::Complex<f64> = v600 * v194;
                        v602 * v590
                    }
                };
                let v608: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v610: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v612: num_complex::Complex<f64> =
                    num_complex::Complex::powc(v610, v1_1.clone());
                let v614: num_complex::Complex<f64> = v608 * v612;
                let v616: num_complex::Complex<f64> = v614 * v96;
                let v618: num_complex::Complex<f64> = v616 * v86;
                v618 * v606
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
                let v19: Option<num_complex::Complex<f64>> = v14.ok();
                let v47: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v19));
                let v52: f64 = f64::NAN;
                let v54: f64 = f64::NAN;
                let v56: num_complex::Complex<f64> = num_complex::Complex::new(v52, v54);
                let v59: num_complex::Complex<f64> = match &v47 {
                    Math::US0::US0_0(v47_0_0) => match &v47 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v56.clone(),
                };
                let v61: f64 = v59.clone().im;
                let v62: bool = (v61) == 0.0_f64;
                let v64: bool = if v62 { true } else { Math::method18(v62) };
                let v70: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_eq"),
                    v61,
                    0.0_f64
                );
                let v75: () = {
                    Math::closure2(v70.clone(), ());
                    ()
                };
                if (v64) == false {
                    panic!("{}", v70,);
                }
                {
                    let v80: f64 = (v59.re) - (patternInput.1.clone());
                    let v81: f64 = -v80;
                    let v83: f64 = if (v80) >= (v81) { v80 } else { v81 };
                    let v84: bool = (v83) < 0.0001_f64;
                    let v86: bool = if v84 { true } else { Math::method18(v84) };
                    let v92: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_lt"),
                        v83,
                        0.0001_f64
                    );
                    let v97: () = {
                        Math::closure2(v92.clone(), ());
                        ()
                    };
                    if (v86) == false {
                        panic!("{}", v92,);
                    }
                    {
                        let v100: i32 = (v9) + 1_i32;
                        v7.l0.set(v100);
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
            let v10: Option<num_complex::Complex<f64>> = v5.ok();
            let v38: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v10));
            let v43: f64 = f64::NAN;
            let v45: f64 = f64::NAN;
            let v47: num_complex::Complex<f64> = num_complex::Complex::new(v43, v45);
            let v50: num_complex::Complex<f64> = match &v38 {
                Math::US0::US0_0(v38_0_0) => match &v38 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v47.clone(),
            };
            let v53: f64 = (v50.clone().re) - 0.8673_f64;
            let v54: f64 = -v53;
            let v56: f64 = if (v53) >= (v54) { v53 } else { v54 };
            let v57: bool = (v56) < 0.001_f64;
            let v59: bool = if v57 { true } else { Math::method18(v57) };
            let v65: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_lt"),
                v56,
                0.001_f64
            );
            let v70: () = {
                Math::closure2(v65.clone(), ());
                ()
            };
            if (v59) == false {
                panic!("{}", v65,);
            }
            {
                let v75: f64 = (v50.im) - 0.275_f64;
                let v76: f64 = -v75;
                let v78: f64 = if (v75) >= (v76) { v75 } else { v76 };
                let v79: bool = (v78) < 0.001_f64;
                let v81: bool = if v79 { true } else { Math::method18(v79) };
                let v85: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_lt"),
                    v78,
                    0.001_f64
                );
                let v90: () = {
                    Math::closure2(v85.clone(), ());
                    ()
                };
                if (v81) == false {
                    panic!("{}", v85,);
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
                        let v13: Option<num_complex::Complex<f64>> = v8.ok();
                        let v41: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v13));
                        let v46: f64 = f64::NAN;
                        let v48: f64 = f64::NAN;
                        let v50: num_complex::Complex<f64> = num_complex::Complex::new(v46, v48);
                        let v53: num_complex::Complex<f64> = match &v41 {
                            Math::US0::US0_0(v41_0_0) => match &v41 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v50.clone(),
                        };
                        let v55: f64 = v53.clone().re;
                        let v56: bool = (v55) == 0.0_f64;
                        let v58: bool = if v56 { true } else { Math::method18(v56) };
                        let v64: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_eq"),
                            v55,
                            0.0_f64
                        );
                        let v69: () = {
                            Math::closure2(v64.clone(), ());
                            ()
                        };
                        if (v58) == false {
                            panic!("{}", v64,);
                        }
                        {
                            let v73: f64 = v53.im;
                            let v74: bool = (v73) == 0.0_f64;
                            let v76: bool = if v74 { true } else { Math::method18(v74) };
                            let v80: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_eq"),
                                v73,
                                0.0_f64
                            );
                            let v85: () = {
                                Math::closure2(v80.clone(), ());
                                ()
                            };
                            if (v76) == false {
                                panic!("{}", v80,);
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
                let v26: Option<num_complex::Complex<f64>> = v21.ok();
                let v54: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v26));
                let v59: f64 = f64::NAN;
                let v61: f64 = f64::NAN;
                let v63: num_complex::Complex<f64> = num_complex::Complex::new(v59, v61);
                let v66: num_complex::Complex<f64> = match &v54 {
                    Math::US0::US0_0(v54_0_0) => match &v54 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v63.clone(),
                };
                let v68: f64 = v66.clone().re;
                let v69: f64 = -v68;
                let v71: f64 = if (v68) >= (v69) { v68 } else { v69 };
                let v72: bool = (v71) < 0.0001_f64;
                let v74: bool = if v72 { true } else { Math::method18(v72) };
                let v80: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_lt"),
                    v71,
                    0.0001_f64
                );
                let v85: () = {
                    Math::closure2(v80.clone(), ());
                    ()
                };
                if (v74) == false {
                    panic!("{}", v80,);
                }
                {
                    let v89: f64 = v66.im;
                    let v90: f64 = -v89;
                    let v92: f64 = if (v89) >= (v90) { v89 } else { v90 };
                    let v93: bool = (v92) < 0.0001_f64;
                    let v95: bool = if v93 { true } else { Math::method18(v93) };
                    let v99: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_lt"),
                        v92,
                        0.0001_f64
                    );
                    let v104: () = {
                        Math::closure2(v99.clone(), ());
                        ()
                    };
                    if (v95) == false {
                        panic!("{}", v99,);
                    }
                    {
                        let v107: i32 = (v17) + 1_i32;
                        v15.l0.set(v107);
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
                let v16: Option<num_complex::Complex<f64>> = v11.ok();
                let v44: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v16));
                let v49: f64 = f64::NAN;
                let v51: f64 = f64::NAN;
                let v53: num_complex::Complex<f64> = num_complex::Complex::new(v49, v51);
                let v56: num_complex::Complex<f64> = match &v44 {
                    Math::US0::US0_0(v44_0_0) => match &v44 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v53.clone(),
                };
                let v58: f64 = v56.clone().re;
                let v59: bool = (v58) > 0.0_f64;
                let v61: bool = if v59 { true } else { Math::method18(v59) };
                let v67: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_gt"),
                    v58,
                    0.0_f64
                );
                let v72: () = {
                    Math::closure2(v67.clone(), ());
                    ()
                };
                if (v61) == false {
                    panic!("{}", v67,);
                }
                {
                    let v76: f64 = v56.im;
                    let v77: bool = (v76) == 0.0_f64;
                    let v79: bool = if v77 { true } else { Math::method18(v77) };
                    let v85: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_eq"),
                        v76,
                        0.0_f64
                    );
                    let v90: () = {
                        Math::closure2(v85.clone(), ());
                        ()
                    };
                    if (v79) == false {
                        panic!("{}", v85,);
                    }
                    {
                        let v93: i32 = (v5) + 1_i32;
                        v3.l0.set(v93);
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
            let v10: Option<num_complex::Complex<f64>> = v5.ok();
            let v38: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v10));
            let v43: f64 = f64::NAN;
            let v45: f64 = f64::NAN;
            let v47: num_complex::Complex<f64> = num_complex::Complex::new(v43, v45);
            let v50: num_complex::Complex<f64> = match &v38 {
                Math::US0::US0_0(v38_0_0) => match &v38 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v47.clone(),
            };
            let v52: f64 = v50.clone().re;
            let v53: bool = (v52) == (f64::INFINITY);
            let v55: bool = if v53 { true } else { Math::method18(v53) };
            let v61: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_eq"),
                v52,
                f64::INFINITY
            );
            let v66: () = {
                Math::closure2(v61.clone(), ());
                ()
            };
            if (v55) == false {
                panic!("{}", v61,);
            }
            {
                let v70: f64 = v50.im;
                let v71: bool = (v70) == 0.0_f64;
                let v73: bool = if v71 { true } else { Math::method18(v71) };
                let v77: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_eq"),
                    v70,
                    0.0_f64
                );
                let v82: () = {
                    Math::closure2(v77.clone(), ());
                    ()
                };
                if (v73) == false {
                    panic!("{}", v77,);
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
            let v10: Option<num_complex::Complex<f64>> = v5.ok();
            let v38: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v10));
            let v43: f64 = f64::NAN;
            let v45: f64 = f64::NAN;
            let v47: num_complex::Complex<f64> = num_complex::Complex::new(v43, v45);
            let v50: num_complex::Complex<f64> = match &v38 {
                Math::US0::US0_0(v38_0_0) => match &v38 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v47.clone(),
            };
            let v52: f64 = v2.clone().re;
            let v55: f64 = -v2.im;
            let v57: num_complex::Complex<f64> = num_complex::Complex::new(v52, v55);
            let v60: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v57.clone()),
            );
            let v61: num_complex::Complex<f64> = Math::method13(v0_1, v57);
            let v65: Option<num_complex::Complex<f64>> = v60.ok();
            let v93: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v65));
            let v98: f64 = f64::NAN;
            let v100: f64 = f64::NAN;
            let v102: num_complex::Complex<f64> = num_complex::Complex::new(v98, v100);
            let v105: num_complex::Complex<f64> = match &v93 {
                Math::US0::US0_0(v93_0_0) => match &v93 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v102.clone(),
            };
            let v107: num_complex::Complex<f64> = v105.conj();
            let v109: f64 = v50.clone().re;
            let v111: f64 = v107.clone().re;
            let v112: bool = (v109) == (v111);
            let v114: bool = if v112 { true } else { Math::method18(v112) };
            let v120: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_eq"),
                v109,
                v111
            );
            let v125: () = {
                Math::closure2(v120.clone(), ());
                ()
            };
            if (v114) == false {
                panic!("{}", v120,);
            }
            {
                let v129: f64 = v50.im;
                let v131: f64 = v107.im;
                let v132: bool = (v129) == (v131);
                let v134: bool = if v132 { true } else { Math::method18(v132) };
                let v138: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_eq"),
                    v129,
                    v131
                );
                let v143: () = {
                    Math::closure2(v138.clone(), ());
                    ()
                };
                if (v134) == false {
                    panic!("{}", v138,);
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
            let v10: Option<num_complex::Complex<f64>> = v5.ok();
            let v38: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v10));
            let v43: f64 = f64::NAN;
            let v45: f64 = f64::NAN;
            let v47: num_complex::Complex<f64> = num_complex::Complex::new(v43, v45);
            let v50: num_complex::Complex<f64> = match &v38 {
                Math::US0::US0_0(v38_0_0) => match &v38 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v47.clone(),
            };
            let v52: f64 = v50.clone().re;
            let v53: bool = (v52) < (f64::INFINITY);
            let v55: bool = if v53 { true } else { Math::method18(v53) };
            let v61: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_lt"),
                v52,
                f64::INFINITY
            );
            let v66: () = {
                Math::closure2(v61.clone(), ());
                ()
            };
            if (v55) == false {
                panic!("{}", v61,);
            }
            {
                let v70: f64 = v50.im;
                let v71: bool = (v70) < (f64::INFINITY);
                let v73: bool = if v71 { true } else { Math::method18(v71) };
                let v77: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_lt"),
                    v70,
                    f64::INFINITY
                );
                let v82: () = {
                    Math::closure2(v77.clone(), ());
                    ()
                };
                if (v73) == false {
                    panic!("{}", v77,);
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
                        let v13: Option<num_complex::Complex<f64>> = v8.ok();
                        let v41: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v13));
                        let v46: f64 = f64::NAN;
                        let v48: f64 = f64::NAN;
                        let v50: num_complex::Complex<f64> = num_complex::Complex::new(v46, v48);
                        let v53: num_complex::Complex<f64> = match &v41 {
                            Math::US0::US0_0(v41_0_0) => match &v41 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v50.clone(),
                        };
                        let v55: f64 = v53.clone().re;
                        let v57: bool = (v55) != 0.0_f64;
                        let v61: bool = if v57 { true } else { Math::method18(v57) };
                        let v67: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_ne"),
                            v55,
                            0.0_f64
                        );
                        let v72: () = {
                            Math::closure2(v67.clone(), ());
                            ()
                        };
                        if (v61) == false {
                            panic!("{}", v67,);
                        }
                        {
                            let v76: f64 = v53.im;
                            let v78: bool = (v76) != 0.0_f64;
                            let v82: bool = if v78 { true } else { Math::method18(v78) };
                            let v86: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_ne"),
                                v76,
                                0.0_f64
                            );
                            let v91: () = {
                                Math::closure2(v86.clone(), ());
                                ()
                            };
                            if (v82) == false {
                                panic!("{}", v86,);
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
                        let v11: Option<num_complex::Complex<f64>> = v6.ok();
                        let v39: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v11));
                        let v44: f64 = f64::NAN;
                        let v46: f64 = f64::NAN;
                        let v48: num_complex::Complex<f64> = num_complex::Complex::new(v44, v46);
                        let v51: num_complex::Complex<f64> = match &v39 {
                            Math::US0::US0_0(v39_0_0) => match &v39 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v48.clone(),
                        };
                        let v53: f64 = v51.clone().re;
                        let v55: bool = (v53) != 0.0_f64;
                        let v59: bool = if v55 { true } else { Math::method18(v55) };
                        let v65: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_ne"),
                            v53,
                            0.0_f64
                        );
                        let v70: () = {
                            Math::closure2(v65.clone(), ());
                            ()
                        };
                        if (v59) == false {
                            panic!("{}", v65,);
                        }
                        {
                            let v74: f64 = v51.im;
                            let v76: bool = (v74) != 0.0_f64;
                            let v80: bool = if v76 { true } else { Math::method18(v76) };
                            let v84: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_ne"),
                                v74,
                                0.0_f64
                            );
                            let v89: () = {
                                Math::closure2(v84.clone(), ());
                                ()
                            };
                            if (v80) == false {
                                panic!("{}", v84,);
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
                        let v11: Option<num_complex::Complex<f64>> = v6.ok();
                        let v39: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v11));
                        let v44: f64 = f64::NAN;
                        let v46: f64 = f64::NAN;
                        let v48: num_complex::Complex<f64> = num_complex::Complex::new(v44, v46);
                        let v51: num_complex::Complex<f64> = match &v39 {
                            Math::US0::US0_0(v39_0_0) => match &v39 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v48.clone(),
                        };
                        let v53: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v55: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v53, v2.clone());
                        let v57: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v59: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v61: num_complex::Complex<f64> = v2.clone() - v59;
                        let v63: num_complex::Complex<f64> = num_complex::Complex::powc(v57, v61);
                        let v65: num_complex::Complex<f64> = v55 * v63;
                        let v67: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v69: num_complex::Complex<f64> = v67 * v2.clone();
                        let v71: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v73: num_complex::Complex<f64> = v69 / v71;
                        let v75: num_complex::Complex<f64> = v73.sin();
                        let v77: num_complex::Complex<f64> = v65 * v75;
                        let v79: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v84: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method16(
                                v0_1.get().clone(),
                                string("        s = mpmath.gamma(s)"),
                                Math::method3(v79 - v2.clone()),
                            );
                        let v88: Option<num_complex::Complex<f64>> = v84.ok();
                        let v116: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v88));
                        let v121: f64 = f64::NAN;
                        let v123: f64 = f64::NAN;
                        let v125: num_complex::Complex<f64> = num_complex::Complex::new(v121, v123);
                        let v128: num_complex::Complex<f64> = match &v116 {
                            Math::US0::US0_0(v116_0_0) => match &v116 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v125.clone(),
                        };
                        let v130: num_complex::Complex<f64> = v77 * v128;
                        let v133: f64 = 1.0_f64 - (v2.clone().re);
                        let v136: f64 = -v2.im;
                        let v138: num_complex::Complex<f64> = num_complex::Complex::new(v133, v136);
                        let v141: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(
                                v0_1.get().clone(),
                                string("        s = mpmath.zeta(s)"),
                                Math::method3(v138.clone()),
                            );
                        let v142: num_complex::Complex<f64> =
                            Math::method13(v0_1.get().clone(), v138);
                        let v146: Option<num_complex::Complex<f64>> = v141.ok();
                        let v174: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v146));
                        let v179: f64 = f64::NAN;
                        let v181: f64 = f64::NAN;
                        let v183: num_complex::Complex<f64> = num_complex::Complex::new(v179, v181);
                        let v186: num_complex::Complex<f64> = match &v174 {
                            Math::US0::US0_0(v174_0_0) => match &v174 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v183.clone(),
                        };
                        let v188: num_complex::Complex<f64> = v130 * v186;
                        let v193: f64 = (v51.clone().re) - (v188.clone().re);
                        let v194: f64 = -v193;
                        let v196: f64 = if (v193) >= (v194) { v193 } else { v194 };
                        let v197: bool = (v196) < 0.0001_f64;
                        let v199: bool = if v197 { true } else { Math::method18(v197) };
                        let v205: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_lt"),
                            v196,
                            0.0001_f64
                        );
                        let v210: () = {
                            Math::closure2(v205.clone(), ());
                            ()
                        };
                        if (v199) == false {
                            panic!("{}", v205,);
                        }
                        {
                            let v217: f64 = (v51.im) - (v188.im);
                            let v218: f64 = -v217;
                            let v220: f64 = if (v217) >= (v218) { v217 } else { v218 };
                            let v221: bool = (v220) < 0.0001_f64;
                            let v223: bool = if v221 { true } else { Math::method18(v221) };
                            let v227: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_lt"),
                                v220,
                                0.0001_f64
                            );
                            let v232: () = {
                                Math::closure2(v227.clone(), ());
                                ()
                            };
                            if (v223) == false {
                                panic!("{}", v227,);
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
                        let v16: Option<num_complex::Complex<f64>> = v11.ok();
                        let v44: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v16));
                        let v49: f64 = f64::NAN;
                        let v51: f64 = f64::NAN;
                        let v53: num_complex::Complex<f64> = num_complex::Complex::new(v49, v51);
                        let v56: num_complex::Complex<f64> = match &v44 {
                            Math::US0::US0_0(v44_0_0) => match &v44 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v53.clone(),
                        };
                        let v59: f64 = (v56.clone().re) - (v8);
                        let v60: f64 = -v59;
                        let v62: f64 = if (v59) >= (v60) { v59 } else { v60 };
                        let v63: bool = (v62) < 0.01_f64;
                        let v65: bool = if v63 { true } else { Math::method18(v63) };
                        let v71: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_lt"),
                            v62,
                            0.01_f64
                        );
                        let v76: () = {
                            Math::closure2(v71.clone(), ());
                            ()
                        };
                        if (v65) == false {
                            panic!("{}", v71,);
                        }
                        {
                            let v80: f64 = v56.im;
                            let v81: bool = (v80) < 0.01_f64;
                            let v83: bool = if v81 { true } else { Math::method18(v81) };
                            let v87: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_lt"),
                                v80,
                                0.01_f64
                            );
                            let v92: () = {
                                Math::closure2(v87.clone(), ());
                                ()
                            };
                            if (v83) == false {
                                panic!("{}", v87,);
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
