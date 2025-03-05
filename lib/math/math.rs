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
                let v76: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v46));
                let v81: f64 = f64::NAN;
                let v83: f64 = f64::NAN;
                let v85: num_complex::Complex<f64> = num_complex::Complex::new(v81, v83);
                let v88: num_complex::Complex<f64> = match &v76 {
                    Math::US0::US0_0(v76_0_0) => match &v76 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v85.clone(),
                };
                let v90: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v92: num_complex::Complex<f64> = v90 * v1_1.clone();
                let v94: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v96: num_complex::Complex<f64> = v92 / v94;
                let v98: num_complex::Complex<f64> = v96.sin();
                let v101: f64 = 1.0_f64 - (v1_1.clone().re);
                let v104: f64 = -v1_1.clone().im;
                let v106: num_complex::Complex<f64> = num_complex::Complex::new(v101, v104);
                let v616: num_complex::Complex<f64> = if (v106.clone().re) <= 1.0_f64 {
                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                } else {
                    println!("zeta / count: {:?} / s: {:?}", 1_i32, v106.clone());
                    if (v106.clone().re) > 1.0_f64 {
                        let v117: num_complex::Complex<f64> =
                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                        let v118: Array<i32> = new_init(&0_i32, 10000_i32);
                        let v119: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                            l0: MutCell::new(0_i32),
                        });
                        while Math::method14(v119.clone()) {
                            let v121: i32 = v119.l0.get().clone();
                            v118.get_mut()[v121 as usize] = v121;
                            {
                                let v122: i32 = (v121) + 1_i32;
                                v119.l0.set(v122);
                                ()
                            }
                        }
                        {
                            let v123: i32 = get_Count(v118.clone());
                            let v124: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                l0: MutCell::new(0_i32),
                                l1: MutCell::new(v117),
                            });
                            while Math::method15(v123, v124.clone()) {
                                let v126: i32 = v124.l0.get().clone();
                                let v127: num_complex::Complex<f64> = v124.l1.get().clone();
                                let v128: i32 = v118[v126].clone();
                                let v130: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v133: f64 = v128 as f64;
                                let v137: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v133, 0.0_f64);
                                let v139: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v137, v106.clone());
                                let v141: num_complex::Complex<f64> = v130 / v139;
                                let v143: num_complex::Complex<f64> = v127 + v141;
                                let v144: i32 = (v126) + 1_i32;
                                v124.l0.set(v144);
                                v124.l1.set(v143);
                                ()
                            }
                            v124.l1.get().clone()
                        }
                    } else {
                        let v147: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v152: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method16(
                                v0_1.clone(),
                                string("        s = mpmath.gamma(s)"),
                                Math::method3(v147 - v106.clone()),
                            );
                        let v156: Option<num_complex::Complex<f64>> = v152.ok();
                        let v186: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v156));
                        let v191: f64 = f64::NAN;
                        let v193: f64 = f64::NAN;
                        let v195: num_complex::Complex<f64> = num_complex::Complex::new(v191, v193);
                        let v198: num_complex::Complex<f64> = match &v186 {
                            Math::US0::US0_0(v186_0_0) => match &v186 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v195.clone(),
                        };
                        let v200: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v202: num_complex::Complex<f64> = v200 * v106.clone();
                        let v204: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v206: num_complex::Complex<f64> = v202 / v204;
                        let v208: num_complex::Complex<f64> = v206.sin();
                        let v211: f64 = 1.0_f64 - (v106.clone().re);
                        let v214: f64 = -v106.clone().im;
                        let v216: num_complex::Complex<f64> = num_complex::Complex::new(v211, v214);
                        let v600: num_complex::Complex<f64> = if (v216.clone().re) <= 1.0_f64 {
                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                        } else {
                            println!("zeta / count: {:?} / s: {:?}", 2_i32, v216.clone());
                            if (v216.clone().re) > 1.0_f64 {
                                let v227: num_complex::Complex<f64> =
                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                let v228: Array<i32> = new_init(&0_i32, 10000_i32);
                                let v229: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Math::method14(v229.clone()) {
                                    let v231: i32 = v229.l0.get().clone();
                                    v228.get_mut()[v231 as usize] = v231;
                                    {
                                        let v232: i32 = (v231) + 1_i32;
                                        v229.l0.set(v232);
                                        ()
                                    }
                                }
                                {
                                    let v233: i32 = get_Count(v228.clone());
                                    let v234: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                        l0: MutCell::new(0_i32),
                                        l1: MutCell::new(v227),
                                    });
                                    while Math::method15(v233, v234.clone()) {
                                        let v236: i32 = v234.l0.get().clone();
                                        let v237: num_complex::Complex<f64> = v234.l1.get().clone();
                                        let v238: i32 = v228[v236].clone();
                                        let v240: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v243: f64 = v238 as f64;
                                        let v247: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v243, 0.0_f64);
                                        let v249: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v247, v216.clone());
                                        let v251: num_complex::Complex<f64> = v240 / v249;
                                        let v253: num_complex::Complex<f64> = v237 + v251;
                                        let v254: i32 = (v236) + 1_i32;
                                        v234.l0.set(v254);
                                        v234.l1.set(v253);
                                        ()
                                    }
                                    v234.l1.get().clone()
                                }
                            } else {
                                let v257: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v262: Result<num_complex::Complex<f64>, std::string::String> =
                                    Math::method16(
                                        v0_1.clone(),
                                        string("        s = mpmath.gamma(s)"),
                                        Math::method3(v257 - v216.clone()),
                                    );
                                let v266: Option<num_complex::Complex<f64>> = v262.ok();
                                let v296: Math::US0 =
                                    defaultValue(Math::US0::US0_1, map(Math::method17(), v266));
                                let v301: f64 = f64::NAN;
                                let v303: f64 = f64::NAN;
                                let v305: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v301, v303);
                                let v308: num_complex::Complex<f64> = match &v296 {
                                    Math::US0::US0_0(v296_0_0) => match &v296 {
                                        Math::US0::US0_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                    _ => v305.clone(),
                                };
                                let v310: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v312: num_complex::Complex<f64> = v310 * v216.clone();
                                let v314: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v316: num_complex::Complex<f64> = v312 / v314;
                                let v318: num_complex::Complex<f64> = v316.sin();
                                let v321: f64 = 1.0_f64 - (v216.clone().re);
                                let v324: f64 = -v216.clone().im;
                                let v326: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v321, v324);
                                let v584: num_complex::Complex<f64> = if (v326.clone().re)
                                    <= 1.0_f64
                                {
                                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                                } else {
                                    println!("zeta / count: {:?} / s: {:?}", 3_i32, v326.clone());
                                    if (v326.clone().re) > 1.0_f64 {
                                        let v337: num_complex::Complex<f64> =
                                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                                        let v338: Array<i32> = new_init(&0_i32, 10000_i32);
                                        let v339: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                            l0: MutCell::new(0_i32),
                                        });
                                        while Math::method14(v339.clone()) {
                                            let v341: i32 = v339.l0.get().clone();
                                            v338.get_mut()[v341 as usize] = v341;
                                            {
                                                let v342: i32 = (v341) + 1_i32;
                                                v339.l0.set(v342);
                                                ()
                                            }
                                        }
                                        {
                                            let v343: i32 = get_Count(v338.clone());
                                            let v344: LrcPtr<Math::Mut2> =
                                                LrcPtr::new(Math::Mut2 {
                                                    l0: MutCell::new(0_i32),
                                                    l1: MutCell::new(v337),
                                                });
                                            while Math::method15(v343, v344.clone()) {
                                                let v346: i32 = v344.l0.get().clone();
                                                let v347: num_complex::Complex<f64> =
                                                    v344.l1.get().clone();
                                                let v348: i32 = v338[v346].clone();
                                                let v350: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v353: f64 = v348 as f64;
                                                let v357: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v353, 0.0_f64);
                                                let v359: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v357, v326.clone());
                                                let v361: num_complex::Complex<f64> = v350 / v359;
                                                let v363: num_complex::Complex<f64> = v347 + v361;
                                                let v364: i32 = (v346) + 1_i32;
                                                v344.l0.set(v364);
                                                v344.l1.set(v363);
                                                ()
                                            }
                                            v344.l1.get().clone()
                                        }
                                    } else {
                                        let v367: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v372: Result<
                                            num_complex::Complex<f64>,
                                            std::string::String,
                                        > = Math::method16(
                                            v0_1.clone(),
                                            string("        s = mpmath.gamma(s)"),
                                            Math::method3(v367 - v326.clone()),
                                        );
                                        let v376: Option<num_complex::Complex<f64>> = v372.ok();
                                        let v406: Math::US0 = defaultValue(
                                            Math::US0::US0_1,
                                            map(Math::method17(), v376),
                                        );
                                        let v411: f64 = f64::NAN;
                                        let v413: f64 = f64::NAN;
                                        let v415: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v411, v413);
                                        let v418: num_complex::Complex<f64> = match &v406 {
                                            Math::US0::US0_0(v406_0_0) => match &v406 {
                                                Math::US0::US0_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                            _ => v415.clone(),
                                        };
                                        let v420: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v422: num_complex::Complex<f64> = v420 * v326.clone();
                                        let v424: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v426: num_complex::Complex<f64> = v422 / v424;
                                        let v428: num_complex::Complex<f64> = v426.sin();
                                        let v431: f64 = 1.0_f64 - (v326.clone().re);
                                        let v434: f64 = -v326.clone().im;
                                        let v436: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v431, v434);
                                        let v568: num_complex::Complex<f64> = if (v436.clone().re)
                                            <= 1.0_f64
                                        {
                                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                                        } else {
                                            println!(
                                                "zeta / count: {:?} / s: {:?}",
                                                4_i32,
                                                v436.clone()
                                            );
                                            if (v436.clone().re) > 1.0_f64 {
                                                let v447: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                                let v448: Array<i32> = new_init(&0_i32, 10000_i32);
                                                let v449: LrcPtr<Math::Mut0> =
                                                    LrcPtr::new(Math::Mut0 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Math::method14(v449.clone()) {
                                                    let v451: i32 = v449.l0.get().clone();
                                                    v448.get_mut()[v451 as usize] = v451;
                                                    {
                                                        let v452: i32 = (v451) + 1_i32;
                                                        v449.l0.set(v452);
                                                        ()
                                                    }
                                                }
                                                {
                                                    let v453: i32 = get_Count(v448.clone());
                                                    let v454: LrcPtr<Math::Mut2> =
                                                        LrcPtr::new(Math::Mut2 {
                                                            l0: MutCell::new(0_i32),
                                                            l1: MutCell::new(v447),
                                                        });
                                                    while Math::method15(v453, v454.clone()) {
                                                        let v456: i32 = v454.l0.get().clone();
                                                        let v457: num_complex::Complex<f64> =
                                                            v454.l1.get().clone();
                                                        let v458: i32 = v448[v456].clone();
                                                        let v460: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                1.0_f64, 0.0_f64,
                                                            );
                                                        let v463: f64 = v458 as f64;
                                                        let v467: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                v463, 0.0_f64,
                                                            );
                                                        let v469: num_complex::Complex<f64> =
                                                            num_complex::Complex::powc(
                                                                v467,
                                                                v436.clone(),
                                                            );
                                                        let v471: num_complex::Complex<f64> =
                                                            v460 / v469;
                                                        let v473: num_complex::Complex<f64> =
                                                            v457 + v471;
                                                        let v474: i32 = (v456) + 1_i32;
                                                        v454.l0.set(v474);
                                                        v454.l1.set(v473);
                                                        ()
                                                    }
                                                    v454.l1.get().clone()
                                                }
                                            } else {
                                                let v477: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v482: Result<
                                                    num_complex::Complex<f64>,
                                                    std::string::String,
                                                > = Math::method16(
                                                    v0_1,
                                                    string("        s = mpmath.gamma(s)"),
                                                    Math::method3(v477 - v436.clone()),
                                                );
                                                let v486: Option<num_complex::Complex<f64>> =
                                                    v482.ok();
                                                let v516: Math::US0 = defaultValue(
                                                    Math::US0::US0_1,
                                                    map(Math::method17(), v486),
                                                );
                                                let v521: f64 = f64::NAN;
                                                let v523: f64 = f64::NAN;
                                                let v525: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v521, v523);
                                                let v528: num_complex::Complex<f64> = match &v516 {
                                                    Math::US0::US0_0(v516_0_0) => match &v516 {
                                                        Math::US0::US0_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                    _ => v525.clone(),
                                                };
                                                let v530: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(
                                                        3.141592653589793_f64,
                                                        0.0_f64,
                                                    );
                                                let v532: num_complex::Complex<f64> =
                                                    v530 * v436.clone();
                                                let v534: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                let v536: num_complex::Complex<f64> = v532 / v534;
                                                let v538: num_complex::Complex<f64> = v536.sin();
                                                let v541: f64 = 1.0_f64 - (v436.clone().re);
                                                let v544: f64 = -v436.clone().im;
                                                let v546: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v541, v544);
                                                let v552: num_complex::Complex<f64> =
                                                    if (v546.clone().re) <= 1.0_f64 {
                                                        num_complex::Complex::new(0.0_f64, 0.0_f64)
                                                    } else {
                                                        v546
                                                    };
                                                let v554: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                let v556: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(
                                                        3.141592653589793_f64,
                                                        0.0_f64,
                                                    );
                                                let v558: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v556, v436.clone());
                                                let v560: num_complex::Complex<f64> = v554 * v558;
                                                let v562: num_complex::Complex<f64> = v560 * v538;
                                                let v564: num_complex::Complex<f64> = v562 * v528;
                                                v564 * v552
                                            }
                                        };
                                        let v570: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v572: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v574: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v572, v326.clone());
                                        let v576: num_complex::Complex<f64> = v570 * v574;
                                        let v578: num_complex::Complex<f64> = v576 * v428;
                                        let v580: num_complex::Complex<f64> = v578 * v418;
                                        v580 * v568
                                    }
                                };
                                let v586: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v588: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v590: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v588, v216.clone());
                                let v592: num_complex::Complex<f64> = v586 * v590;
                                let v594: num_complex::Complex<f64> = v592 * v318;
                                let v596: num_complex::Complex<f64> = v594 * v308;
                                v596 * v584
                            }
                        };
                        let v602: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v604: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v606: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v604, v106.clone());
                        let v608: num_complex::Complex<f64> = v602 * v606;
                        let v610: num_complex::Complex<f64> = v608 * v208;
                        let v612: num_complex::Complex<f64> = v610 * v198;
                        v612 * v600
                    }
                };
                let v618: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v620: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v622: num_complex::Complex<f64> =
                    num_complex::Complex::powc(v620, v1_1.clone());
                let v624: num_complex::Complex<f64> = v618 * v622;
                let v626: num_complex::Complex<f64> = v624 * v98;
                let v628: num_complex::Complex<f64> = v626 * v88;
                v628 * v616
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
                let v49: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v19));
                let v54: f64 = f64::NAN;
                let v56: f64 = f64::NAN;
                let v58: num_complex::Complex<f64> = num_complex::Complex::new(v54, v56);
                let v61: num_complex::Complex<f64> = match &v49 {
                    Math::US0::US0_0(v49_0_0) => match &v49 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v58.clone(),
                };
                let v63: f64 = v61.clone().im;
                let v64: bool = (v63) == 0.0_f64;
                let v66: bool = if v64 { true } else { Math::method18(v64) };
                let v72: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_eq"),
                    v63,
                    0.0_f64
                );
                let v77: () = {
                    Math::closure2(v72.clone(), ());
                    ()
                };
                if (v66) == false {
                    panic!("{}", v72,);
                }
                {
                    let v82: f64 = (v61.re) - (patternInput.1.clone());
                    let v83: f64 = -v82;
                    let v85: f64 = if (v82) >= (v83) { v82 } else { v83 };
                    let v86: bool = (v85) < 0.0001_f64;
                    let v88: bool = if v86 { true } else { Math::method18(v86) };
                    let v94: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_lt"),
                        v85,
                        0.0001_f64
                    );
                    let v99: () = {
                        Math::closure2(v94.clone(), ());
                        ()
                    };
                    if (v88) == false {
                        panic!("{}", v94,);
                    }
                    {
                        let v102: i32 = (v9) + 1_i32;
                        v7.l0.set(v102);
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
                    let v8: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("}}");
                    let v14: string = string("{");
                    let v19: bool = true;
                    let _fix_closure_v16 = v8;
                    let v26: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v16 "), (v12))),
                                string("); "),
                            )),
                            (v14),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    _fix_closure_v16
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
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
            let v40: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v10));
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
            let v55: f64 = (v52.clone().re) - 0.8673_f64;
            let v56: f64 = -v55;
            let v58: f64 = if (v55) >= (v56) { v55 } else { v56 };
            let v59: bool = (v58) < 0.001_f64;
            let v61: bool = if v59 { true } else { Math::method18(v59) };
            let v67: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_lt"),
                v58,
                0.001_f64
            );
            let v72: () = {
                Math::closure2(v67.clone(), ());
                ()
            };
            if (v61) == false {
                panic!("{}", v67,);
            }
            {
                let v77: f64 = (v52.im) - 0.275_f64;
                let v78: f64 = -v77;
                let v80: f64 = if (v77) >= (v78) { v77 } else { v78 };
                let v81: bool = (v80) < 0.001_f64;
                let v83: bool = if v81 { true } else { Math::method18(v81) };
                let v87: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_lt"),
                    v80,
                    0.001_f64
                );
                let v92: () = {
                    Math::closure2(v87.clone(), ());
                    ()
                };
                if (v83) == false {
                    panic!("{}", v87,);
                }
            }
        }
        pub fn method20() {
            pyo3::prepare_freethreaded_python();
            let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method21(py);
                {
                    let v8: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("}}");
                    let v14: string = string("{");
                    let v19: bool = true;
                    let _fix_closure_v16 = v8;
                    let v26: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v16 "), (v12))),
                                string("); "),
                            )),
                            (v14),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    _fix_closure_v16
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
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
                        let v43: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v13));
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
                        let v57: f64 = v55.clone().re;
                        let v58: bool = (v57) == 0.0_f64;
                        let v60: bool = if v58 { true } else { Math::method18(v58) };
                        let v66: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_eq"),
                            v57,
                            0.0_f64
                        );
                        let v71: () = {
                            Math::closure2(v66.clone(), ());
                            ()
                        };
                        if (v60) == false {
                            panic!("{}", v66,);
                        }
                        {
                            let v75: f64 = v55.im;
                            let v76: bool = (v75) == 0.0_f64;
                            let v78: bool = if v76 { true } else { Math::method18(v76) };
                            let v82: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_eq"),
                                v75,
                                0.0_f64
                            );
                            let v87: () = {
                                Math::closure2(v82.clone(), ());
                                ()
                            };
                            if (v78) == false {
                                panic!("{}", v82,);
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
                    let v8: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("}}");
                    let v14: string = string("{");
                    let v19: bool = true;
                    let _fix_closure_v16 = v8;
                    let v26: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v16 "), (v12))),
                                string("); "),
                            )),
                            (v14),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    _fix_closure_v16
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
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
                let v56: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v26));
                let v61: f64 = f64::NAN;
                let v63: f64 = f64::NAN;
                let v65: num_complex::Complex<f64> = num_complex::Complex::new(v61, v63);
                let v68: num_complex::Complex<f64> = match &v56 {
                    Math::US0::US0_0(v56_0_0) => match &v56 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v65.clone(),
                };
                let v70: f64 = v68.clone().re;
                let v71: f64 = -v70;
                let v73: f64 = if (v70) >= (v71) { v70 } else { v71 };
                let v74: bool = (v73) < 0.0001_f64;
                let v76: bool = if v74 { true } else { Math::method18(v74) };
                let v82: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_lt"),
                    v73,
                    0.0001_f64
                );
                let v87: () = {
                    Math::closure2(v82.clone(), ());
                    ()
                };
                if (v76) == false {
                    panic!("{}", v82,);
                }
                {
                    let v91: f64 = v68.im;
                    let v92: f64 = -v91;
                    let v94: f64 = if (v91) >= (v92) { v91 } else { v92 };
                    let v95: bool = (v94) < 0.0001_f64;
                    let v97: bool = if v95 { true } else { Math::method18(v95) };
                    let v101: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_lt"),
                        v94,
                        0.0001_f64
                    );
                    let v106: () = {
                        Math::closure2(v101.clone(), ());
                        ()
                    };
                    if (v97) == false {
                        panic!("{}", v101,);
                    }
                    {
                        let v109: i32 = (v17) + 1_i32;
                        v15.l0.set(v109);
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
                    let v8: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("}}");
                    let v14: string = string("{");
                    let v19: bool = true;
                    let _fix_closure_v16 = v8;
                    let v26: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v16 "), (v12))),
                                string("); "),
                            )),
                            (v14),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    _fix_closure_v16
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
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
                let v46: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v16));
                let v51: f64 = f64::NAN;
                let v53: f64 = f64::NAN;
                let v55: num_complex::Complex<f64> = num_complex::Complex::new(v51, v53);
                let v58: num_complex::Complex<f64> = match &v46 {
                    Math::US0::US0_0(v46_0_0) => match &v46 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v55.clone(),
                };
                let v60: f64 = v58.clone().re;
                let v61: bool = (v60) > 0.0_f64;
                let v63: bool = if v61 { true } else { Math::method18(v61) };
                let v69: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_gt"),
                    v60,
                    0.0_f64
                );
                let v74: () = {
                    Math::closure2(v69.clone(), ());
                    ()
                };
                if (v63) == false {
                    panic!("{}", v69,);
                }
                {
                    let v78: f64 = v58.im;
                    let v79: bool = (v78) == 0.0_f64;
                    let v81: bool = if v79 { true } else { Math::method18(v79) };
                    let v87: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_eq"),
                        v78,
                        0.0_f64
                    );
                    let v92: () = {
                        Math::closure2(v87.clone(), ());
                        ()
                    };
                    if (v81) == false {
                        panic!("{}", v87,);
                    }
                    {
                        let v95: i32 = (v5) + 1_i32;
                        v3.l0.set(v95);
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
                    let v8: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("}}");
                    let v14: string = string("{");
                    let v19: bool = true;
                    let _fix_closure_v16 = v8;
                    let v26: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v16 "), (v12))),
                                string("); "),
                            )),
                            (v14),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    _fix_closure_v16
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
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
            let v40: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v10));
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
            let v55: bool = (v54) == (f64::INFINITY);
            let v57: bool = if v55 { true } else { Math::method18(v55) };
            let v63: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_eq"),
                v54,
                f64::INFINITY
            );
            let v68: () = {
                Math::closure2(v63.clone(), ());
                ()
            };
            if (v57) == false {
                panic!("{}", v63,);
            }
            {
                let v72: f64 = v52.im;
                let v73: bool = (v72) == 0.0_f64;
                let v75: bool = if v73 { true } else { Math::method18(v73) };
                let v79: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_eq"),
                    v72,
                    0.0_f64
                );
                let v84: () = {
                    Math::closure2(v79.clone(), ());
                    ()
                };
                if (v75) == false {
                    panic!("{}", v79,);
                }
            }
        }
        pub fn method30() {
            pyo3::prepare_freethreaded_python();
            let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method31(py);
                {
                    let v8: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("}}");
                    let v14: string = string("{");
                    let v19: bool = true;
                    let _fix_closure_v16 = v8;
                    let v26: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v16 "), (v12))),
                                string("); "),
                            )),
                            (v14),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    _fix_closure_v16
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
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
            let v40: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v10));
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
            let v54: f64 = v2.clone().re;
            let v57: f64 = -v2.im;
            let v59: num_complex::Complex<f64> = num_complex::Complex::new(v54, v57);
            let v62: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v59.clone()),
            );
            let v63: num_complex::Complex<f64> = Math::method13(v0_1, v59);
            let v67: Option<num_complex::Complex<f64>> = v62.ok();
            let v97: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v67));
            let v102: f64 = f64::NAN;
            let v104: f64 = f64::NAN;
            let v106: num_complex::Complex<f64> = num_complex::Complex::new(v102, v104);
            let v109: num_complex::Complex<f64> = match &v97 {
                Math::US0::US0_0(v97_0_0) => match &v97 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v106.clone(),
            };
            let v111: num_complex::Complex<f64> = v109.conj();
            let v113: f64 = v52.clone().re;
            let v115: f64 = v111.clone().re;
            let v116: bool = (v113) == (v115);
            let v118: bool = if v116 { true } else { Math::method18(v116) };
            let v124: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_eq"),
                v113,
                v115
            );
            let v129: () = {
                Math::closure2(v124.clone(), ());
                ()
            };
            if (v118) == false {
                panic!("{}", v124,);
            }
            {
                let v133: f64 = v52.im;
                let v135: f64 = v111.im;
                let v136: bool = (v133) == (v135);
                let v138: bool = if v136 { true } else { Math::method18(v136) };
                let v142: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_eq"),
                    v133,
                    v135
                );
                let v147: () = {
                    Math::closure2(v142.clone(), ());
                    ()
                };
                if (v138) == false {
                    panic!("{}", v142,);
                }
            }
        }
        pub fn method32() {
            pyo3::prepare_freethreaded_python();
            let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method33(py);
                {
                    let v8: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("}}");
                    let v14: string = string("{");
                    let v19: bool = true;
                    let _fix_closure_v16 = v8;
                    let v26: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v16 "), (v12))),
                                string("); "),
                            )),
                            (v14),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    _fix_closure_v16
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
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
            let v40: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v10));
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
            let v55: bool = (v54) < (f64::INFINITY);
            let v57: bool = if v55 { true } else { Math::method18(v55) };
            let v63: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_lt"),
                v54,
                f64::INFINITY
            );
            let v68: () = {
                Math::closure2(v63.clone(), ());
                ()
            };
            if (v57) == false {
                panic!("{}", v63,);
            }
            {
                let v72: f64 = v52.im;
                let v73: bool = (v72) < (f64::INFINITY);
                let v75: bool = if v73 { true } else { Math::method18(v73) };
                let v79: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_lt"),
                    v72,
                    f64::INFINITY
                );
                let v84: () = {
                    Math::closure2(v79.clone(), ());
                    ()
                };
                if (v75) == false {
                    panic!("{}", v79,);
                }
            }
        }
        pub fn method34() {
            pyo3::prepare_freethreaded_python();
            let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method35(py);
                {
                    let v8: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("}}");
                    let v14: string = string("{");
                    let v19: bool = true;
                    let _fix_closure_v16 = v8;
                    let v26: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v16 "), (v12))),
                                string("); "),
                            )),
                            (v14),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    _fix_closure_v16
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
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
                        let v43: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v13));
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
                        let v57: f64 = v55.clone().re;
                        let v59: bool = (v57) != 0.0_f64;
                        let v63: bool = if v59 { true } else { Math::method18(v59) };
                        let v69: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_ne"),
                            v57,
                            0.0_f64
                        );
                        let v74: () = {
                            Math::closure2(v69.clone(), ());
                            ()
                        };
                        if (v63) == false {
                            panic!("{}", v69,);
                        }
                        {
                            let v78: f64 = v55.im;
                            let v80: bool = (v78) != 0.0_f64;
                            let v84: bool = if v80 { true } else { Math::method18(v80) };
                            let v88: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_ne"),
                                v78,
                                0.0_f64
                            );
                            let v93: () = {
                                Math::closure2(v88.clone(), ());
                                ()
                            };
                            if (v84) == false {
                                panic!("{}", v88,);
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
                    let v8: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("}}");
                    let v14: string = string("{");
                    let v19: bool = true;
                    let _fix_closure_v16 = v8;
                    let v26: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v16 "), (v12))),
                                string("); "),
                            )),
                            (v14),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    _fix_closure_v16
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
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
                        let v41: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v11));
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
                    let v8: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("}}");
                    let v14: string = string("{");
                    let v19: bool = true;
                    let _fix_closure_v16 = v8;
                    let v26: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v16 "), (v12))),
                                string("); "),
                            )),
                            (v14),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    _fix_closure_v16
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
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
                        let v41: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v11));
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
                        let v55: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v57: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v55, v2.clone());
                        let v59: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v61: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v63: num_complex::Complex<f64> = v2.clone() - v61;
                        let v65: num_complex::Complex<f64> = num_complex::Complex::powc(v59, v63);
                        let v67: num_complex::Complex<f64> = v57 * v65;
                        let v69: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v71: num_complex::Complex<f64> = v69 * v2.clone();
                        let v73: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v75: num_complex::Complex<f64> = v71 / v73;
                        let v77: num_complex::Complex<f64> = v75.sin();
                        let v79: num_complex::Complex<f64> = v67 * v77;
                        let v81: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v86: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method16(
                                v0_1.get().clone(),
                                string("        s = mpmath.gamma(s)"),
                                Math::method3(v81 - v2.clone()),
                            );
                        let v90: Option<num_complex::Complex<f64>> = v86.ok();
                        let v120: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v90));
                        let v125: f64 = f64::NAN;
                        let v127: f64 = f64::NAN;
                        let v129: num_complex::Complex<f64> = num_complex::Complex::new(v125, v127);
                        let v132: num_complex::Complex<f64> = match &v120 {
                            Math::US0::US0_0(v120_0_0) => match &v120 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v129.clone(),
                        };
                        let v134: num_complex::Complex<f64> = v79 * v132;
                        let v137: f64 = 1.0_f64 - (v2.clone().re);
                        let v140: f64 = -v2.im;
                        let v142: num_complex::Complex<f64> = num_complex::Complex::new(v137, v140);
                        let v145: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(
                                v0_1.get().clone(),
                                string("        s = mpmath.zeta(s)"),
                                Math::method3(v142.clone()),
                            );
                        let v146: num_complex::Complex<f64> =
                            Math::method13(v0_1.get().clone(), v142);
                        let v150: Option<num_complex::Complex<f64>> = v145.ok();
                        let v180: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v150));
                        let v185: f64 = f64::NAN;
                        let v187: f64 = f64::NAN;
                        let v189: num_complex::Complex<f64> = num_complex::Complex::new(v185, v187);
                        let v192: num_complex::Complex<f64> = match &v180 {
                            Math::US0::US0_0(v180_0_0) => match &v180 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v189.clone(),
                        };
                        let v194: num_complex::Complex<f64> = v134 * v192;
                        let v199: f64 = (v53.clone().re) - (v194.clone().re);
                        let v200: f64 = -v199;
                        let v202: f64 = if (v199) >= (v200) { v199 } else { v200 };
                        let v203: bool = (v202) < 0.0001_f64;
                        let v205: bool = if v203 { true } else { Math::method18(v203) };
                        let v211: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_lt"),
                            v202,
                            0.0001_f64
                        );
                        let v216: () = {
                            Math::closure2(v211.clone(), ());
                            ()
                        };
                        if (v205) == false {
                            panic!("{}", v211,);
                        }
                        {
                            let v223: f64 = (v53.im) - (v194.im);
                            let v224: f64 = -v223;
                            let v226: f64 = if (v223) >= (v224) { v223 } else { v224 };
                            let v227: bool = (v226) < 0.0001_f64;
                            let v229: bool = if v227 { true } else { Math::method18(v227) };
                            let v233: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_lt"),
                                v226,
                                0.0001_f64
                            );
                            let v238: () = {
                                Math::closure2(v233.clone(), ());
                                ()
                            };
                            if (v229) == false {
                                panic!("{}", v233,);
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
                    let v8: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("}}");
                    let v14: string = string("{");
                    let v19: bool = true;
                    let _fix_closure_v16 = v8;
                    let v26: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v16 "), (v12))),
                                string("); "),
                            )),
                            (v14),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    _fix_closure_v16
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
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
                        let v46: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v16));
                        let v51: f64 = f64::NAN;
                        let v53: f64 = f64::NAN;
                        let v55: num_complex::Complex<f64> = num_complex::Complex::new(v51, v53);
                        let v58: num_complex::Complex<f64> = match &v46 {
                            Math::US0::US0_0(v46_0_0) => match &v46 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v55.clone(),
                        };
                        let v61: f64 = (v58.clone().re) - (v8);
                        let v62: f64 = -v61;
                        let v64: f64 = if (v61) >= (v62) { v61 } else { v62 };
                        let v65: bool = (v64) < 0.01_f64;
                        let v67: bool = if v65 { true } else { Math::method18(v65) };
                        let v73: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_lt"),
                            v64,
                            0.01_f64
                        );
                        let v78: () = {
                            Math::closure2(v73.clone(), ());
                            ()
                        };
                        if (v67) == false {
                            panic!("{}", v73,);
                        }
                        {
                            let v82: f64 = v58.im;
                            let v83: bool = (v82) < 0.01_f64;
                            let v85: bool = if v83 { true } else { Math::method18(v83) };
                            let v89: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_lt"),
                                v82,
                                0.01_f64
                            );
                            let v94: () = {
                                Math::closure2(v89.clone(), ());
                                ()
                            };
                            if (v85) == false {
                                panic!("{}", v89,);
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
                    let v8: Result<(), pyo3::PyErr> = Math::method19(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("}}");
                    let v14: string = string("{");
                    let v19: bool = true;
                    let _fix_closure_v16 = v8;
                    let v26: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v16 "), (v12))),
                                string("); "),
                            )),
                            (v14),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    _fix_closure_v16
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
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
