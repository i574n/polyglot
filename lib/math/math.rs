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
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Native_::on_startup;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::NativeArray_::get_Count;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_init;
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
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut3 {
            pub l0: MutCell<string>,
        }
        impl core::fmt::Display for Mut3 {
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
                let v28: string =
                    append((append((v0_1[v8].clone()), (matchValue_1))), (matchValue));
                let v40: i32 = (v5) + 1_i32;
                v3.l0.set(v40);
                v3.l1.set(v28);
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
            let v13: string = string(
                "            args = { k: v for k, v in frame.f_locals.items() if frame.f_code.co_name != \'make_mpc\' and k not in [\'ctx\'] and not callable(v) }",
            );
            let v14: string = string(
                "            args_str = \', \'.join([ f\"{k}={re.sub(memory_address_pattern, \' at 0x<?>\', repr(v))}\" for k, v in args.items() ])",
            );
            let v36: string = Math::method5(new_array(&[
                string("import sys"),
                string("import traceback"),
                string("import re"),
                string("count = 0"),
                string("memory_address_pattern = re.compile(r\' at 0x[0-9a-fA-F]+\')"),
                string("def trace_calls(frame, event, arg):"),
                string("    global count"),
                string("    count += 1"),
                string("    if count < 200:"),
                string("        try:"),
                v13,
                v14,
                concat(new_array(&[
                    string("            print(f\"{event}("),
                    string("zeta_"),
                    string(
                        ") / f_code.co_name: {frame.f_code.co_name} / f_locals: {args_str} / f_lineno: {frame.f_lineno} / f_code.co_filename: {frame.f_code.co_filename.split(\'site-packages\')[-1]} / f_back.f_lineno: { \'\' if frame.f_back is None else frame.f_back.f_lineno } / f_back.f_code.co_filename: { \'\' if frame.f_back is None else frame.f_back.f_code.co_filename.split(\'site-packages\')[-1] } / arg: {re.sub(memory_address_pattern, \' at 0x<?>\', repr(arg))}\", flush=True)",
                    ),
                ])),
                string("        except ValueError as e:"),
                concat(new_array(&[
                    string("            print(f\'"),
                    string("zeta_"),
                    string(" / e: {e}\', flush=True)"),
                ])),
                string("        return trace_calls"),
                string("import mpmath"),
                string("def fn(log, s):"),
                string("    global count"),
                string("    if log:"),
                concat(new_array(&[
                    string("        print(f\'"),
                    string("zeta_"),
                    string(" / s: {s} / count: {count}\', flush=True)"),
                ])),
                string("    s = complex(*s)"),
                string("    try:"),
                string("        if log: sys.settrace(trace_calls)"),
                v1_1,
                string("        if log:"),
                string("            sys.settrace(None)"),
                concat(new_array(&[
                    string("            print(f\'"),
                    string("zeta_"),
                    string(" / result: {s} / count: {count}\', flush=True)"),
                ])),
                string("    except ValueError as e:"),
                string("        if s.real == 1:"),
                string("            s = complex(float(\'inf\'), 0)"),
                string("    return (s.real, s.imag)"),
            ]));
            let v69: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v2.clone().re, v2.im))));
            let v81: pyo3::Python = Math::method7(v0_1);
            let v124: &str = &*v36;
            let v292: std::string::String = String::from(v124);
            let v419: std::ffi::CString = std::ffi::CString::new(v292).unwrap();
            let v463: &str = &*string("");
            let v631: std::string::String = String::from(v463);
            let v758: std::ffi::CString = std::ffi::CString::new(v631).unwrap();
            let v760: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code(v81, &v419, &v758, &v758);
            let v762: bool = true;
            let _result_map_error__ = v760.map_err(|x| {
                //;
                let v764: pyo3::PyErr = x;
                let v807: std::string::String = format!("{}", v764);
                let v934: bool = true;
                v807
            });
            let v936: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                _result_map_error__;
            let v941: pyo3::Bound<pyo3::types::PyModule> = v936.unwrap();
            let v953: string = Math::method8();
            let v996: &str = &*v953;
            let v1122: pyo3::Bound<pyo3::types::PyModule> = Math::method9(v941);
            let v1124: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v1122.getattr(v996);
            let v1126: bool = true;
            let _result_map_error__ = v1124.map_err(|x| {
                //;
                let v1128: pyo3::PyErr = x;
                let v1171: std::string::String = format!("{}", v1128);
                let v1298: bool = true;
                v1171
            });
            let v1300: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v1305: pyo3::Bound<pyo3::PyAny> = v1300.unwrap();
            let v1317: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method10(v69.0.clone(), v69.1.clone());
            let v1318: pyo3::Bound<pyo3::PyAny> = Math::method11(v1305);
            let v1320: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                pyo3::prelude::PyAnyMethods::call(&v1318, ((*v1317).0, *(*v1317).1), None);
            let v1322: bool = true;
            let _result_map_error__ = v1320.map_err(|x| {
                //;
                let v1324: pyo3::PyErr = x;
                let v1367: std::string::String = format!("{}", v1324);
                let v1494: bool = true;
                v1367
            });
            let v1496: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v1499: pyo3::Bound<pyo3::PyAny> = Math::method12(v1496?);
            let v1501: Result<(f64, f64), pyo3::PyErr> = v1499.extract();
            let v1503: bool = true;
            let _result_map_error__ = v1501.map_err(|x| {
                //;
                let v1505: pyo3::PyErr = x;
                let v1548: std::string::String = format!("{}", v1505);
                let v1675: bool = true;
                v1548
            });
            let v1677: Result<(f64, f64), std::string::String> = _result_map_error__;
            let patternInput: (f64, f64) = v1677?;
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
            let v13: string = string(
                "            args = { k: v for k, v in frame.f_locals.items() if frame.f_code.co_name != \'make_mpc\' and k not in [\'ctx\'] and not callable(v) }",
            );
            let v14: string = string(
                "            args_str = \', \'.join([ f\"{k}={re.sub(memory_address_pattern, \' at 0x<?>\', repr(v))}\" for k, v in args.items() ])",
            );
            let v36: string = Math::method5(new_array(&[
                string("import sys"),
                string("import traceback"),
                string("import re"),
                string("count = 0"),
                string("memory_address_pattern = re.compile(r\' at 0x[0-9a-fA-F]+\')"),
                string("def trace_calls(frame, event, arg):"),
                string("    global count"),
                string("    count += 1"),
                string("    if count < 200:"),
                string("        try:"),
                v13,
                v14,
                concat(new_array(&[
                    string("            print(f\"{event}("),
                    string("gamma_"),
                    string(
                        ") / f_code.co_name: {frame.f_code.co_name} / f_locals: {args_str} / f_lineno: {frame.f_lineno} / f_code.co_filename: {frame.f_code.co_filename.split(\'site-packages\')[-1]} / f_back.f_lineno: { \'\' if frame.f_back is None else frame.f_back.f_lineno } / f_back.f_code.co_filename: { \'\' if frame.f_back is None else frame.f_back.f_code.co_filename.split(\'site-packages\')[-1] } / arg: {re.sub(memory_address_pattern, \' at 0x<?>\', repr(arg))}\", flush=True)",
                    ),
                ])),
                string("        except ValueError as e:"),
                concat(new_array(&[
                    string("            print(f\'"),
                    string("gamma_"),
                    string(" / e: {e}\', flush=True)"),
                ])),
                string("        return trace_calls"),
                string("import mpmath"),
                string("def fn(log, s):"),
                string("    global count"),
                string("    if log:"),
                concat(new_array(&[
                    string("        print(f\'"),
                    string("gamma_"),
                    string(" / s: {s} / count: {count}\', flush=True)"),
                ])),
                string("    s = complex(*s)"),
                string("    try:"),
                string("        if log: sys.settrace(trace_calls)"),
                v1_1,
                string("        if log:"),
                string("            sys.settrace(None)"),
                concat(new_array(&[
                    string("            print(f\'"),
                    string("gamma_"),
                    string(" / result: {s} / count: {count}\', flush=True)"),
                ])),
                string("    except ValueError as e:"),
                string("        if s.real == 1:"),
                string("            s = complex(float(\'inf\'), 0)"),
                string("    return (s.real, s.imag)"),
            ]));
            let v69: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v2.clone().re, v2.im))));
            let v81: pyo3::Python = Math::method7(v0_1);
            let v124: &str = &*v36;
            let v292: std::string::String = String::from(v124);
            let v419: std::ffi::CString = std::ffi::CString::new(v292).unwrap();
            let v463: &str = &*string("");
            let v631: std::string::String = String::from(v463);
            let v758: std::ffi::CString = std::ffi::CString::new(v631).unwrap();
            let v760: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code(v81, &v419, &v758, &v758);
            let v762: bool = true;
            let _result_map_error__ = v760.map_err(|x| {
                //;
                let v764: pyo3::PyErr = x;
                let v807: std::string::String = format!("{}", v764);
                let v934: bool = true;
                v807
            });
            let v936: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                _result_map_error__;
            let v941: pyo3::Bound<pyo3::types::PyModule> = v936.unwrap();
            let v953: string = Math::method8();
            let v996: &str = &*v953;
            let v1122: pyo3::Bound<pyo3::types::PyModule> = Math::method9(v941);
            let v1124: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v1122.getattr(v996);
            let v1126: bool = true;
            let _result_map_error__ = v1124.map_err(|x| {
                //;
                let v1128: pyo3::PyErr = x;
                let v1171: std::string::String = format!("{}", v1128);
                let v1298: bool = true;
                v1171
            });
            let v1300: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v1305: pyo3::Bound<pyo3::PyAny> = v1300.unwrap();
            let v1317: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method10(v69.0.clone(), v69.1.clone());
            let v1318: pyo3::Bound<pyo3::PyAny> = Math::method11(v1305);
            let v1320: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                pyo3::prelude::PyAnyMethods::call(&v1318, ((*v1317).0, *(*v1317).1), None);
            let v1322: bool = true;
            let _result_map_error__ = v1320.map_err(|x| {
                //;
                let v1324: pyo3::PyErr = x;
                let v1367: std::string::String = format!("{}", v1324);
                let v1494: bool = true;
                v1367
            });
            let v1496: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v1499: pyo3::Bound<pyo3::PyAny> = Math::method12(v1496?);
            let v1501: Result<(f64, f64), pyo3::PyErr> = v1499.extract();
            let v1503: bool = true;
            let _result_map_error__ = v1501.map_err(|x| {
                //;
                let v1505: pyo3::PyErr = x;
                let v1548: std::string::String = format!("{}", v1505);
                let v1675: bool = true;
                v1548
            });
            let v1677: Result<(f64, f64), std::string::String> = _result_map_error__;
            let patternInput: (f64, f64) = v1677?;
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
                        let v30: f64 = v18 as f64;
                        let v43: num_complex::Complex<f64> =
                            num_complex::Complex::new(v30, 0.0_f64);
                        let v45: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v43, v1_1.clone());
                        let v47: num_complex::Complex<f64> = v20 / v45;
                        let v49: num_complex::Complex<f64> = v17 + v47;
                        let v50: i32 = (v16) + 1_i32;
                        v14.l0.set(v50);
                        v14.l1.set(v49);
                        ()
                    }
                    v14.l1.get().clone()
                }
            } else {
                let v53: num_complex::Complex<f64> = num_complex::Complex::new(1.0_f64, 0.0_f64);
                let v58: Result<num_complex::Complex<f64>, std::string::String> = Math::method16(
                    v0_1.clone(),
                    string("        s = mpmath.gamma(s)"),
                    Math::method3(v53 - v1_1.clone()),
                );
                let v63: Option<num_complex::Complex<f64>> = v58.ok();
                let v184: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v63));
                let v198: f64 = f64::NAN;
                let v200: f64 = f64::NAN;
                let v202: num_complex::Complex<f64> = num_complex::Complex::new(v198, v200);
                let v205: num_complex::Complex<f64> = match &v184 {
                    Math::US0::US0_0(v184_0_0) => match &v184 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v202.clone(),
                };
                let v207: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v209: num_complex::Complex<f64> = v207 * v1_1.clone();
                let v211: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v213: num_complex::Complex<f64> = v209 / v211;
                let v215: num_complex::Complex<f64> = v213.sin();
                let v218: f64 = 1.0_f64 - (v1_1.clone().re);
                let v221: f64 = -v1_1.clone().im;
                let v223: num_complex::Complex<f64> = num_complex::Complex::new(v218, v221);
                let v1201: num_complex::Complex<f64> = if (v223.clone().re) <= 1.0_f64 {
                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                } else {
                    println!("zeta / count: {:?} / s: {:?}", 1_i32, v223.clone());
                    if (v223.clone().re) > 1.0_f64 {
                        let v234: num_complex::Complex<f64> =
                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                        let v235: Array<i32> = new_init(&0_i32, 10000_i32);
                        let v236: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                            l0: MutCell::new(0_i32),
                        });
                        while Math::method14(v236.clone()) {
                            let v238: i32 = v236.l0.get().clone();
                            v235.get_mut()[v238 as usize] = v238;
                            {
                                let v239: i32 = (v238) + 1_i32;
                                v236.l0.set(v239);
                                ()
                            }
                        }
                        {
                            let v240: i32 = get_Count(v235.clone());
                            let v241: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                l0: MutCell::new(0_i32),
                                l1: MutCell::new(v234),
                            });
                            while Math::method15(v240, v241.clone()) {
                                let v243: i32 = v241.l0.get().clone();
                                let v244: num_complex::Complex<f64> = v241.l1.get().clone();
                                let v245: i32 = v235[v243].clone();
                                let v247: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v257: f64 = v245 as f64;
                                let v270: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v257, 0.0_f64);
                                let v272: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v270, v223.clone());
                                let v274: num_complex::Complex<f64> = v247 / v272;
                                let v276: num_complex::Complex<f64> = v244 + v274;
                                let v277: i32 = (v243) + 1_i32;
                                v241.l0.set(v277);
                                v241.l1.set(v276);
                                ()
                            }
                            v241.l1.get().clone()
                        }
                    } else {
                        let v280: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v285: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method16(
                                v0_1.clone(),
                                string("        s = mpmath.gamma(s)"),
                                Math::method3(v280 - v223.clone()),
                            );
                        let v290: Option<num_complex::Complex<f64>> = v285.ok();
                        let v411: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v290));
                        let v425: f64 = f64::NAN;
                        let v427: f64 = f64::NAN;
                        let v429: num_complex::Complex<f64> = num_complex::Complex::new(v425, v427);
                        let v432: num_complex::Complex<f64> = match &v411 {
                            Math::US0::US0_0(v411_0_0) => match &v411 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v429.clone(),
                        };
                        let v434: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v436: num_complex::Complex<f64> = v434 * v223.clone();
                        let v438: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v440: num_complex::Complex<f64> = v436 / v438;
                        let v442: num_complex::Complex<f64> = v440.sin();
                        let v445: f64 = 1.0_f64 - (v223.clone().re);
                        let v448: f64 = -v223.clone().im;
                        let v450: num_complex::Complex<f64> = num_complex::Complex::new(v445, v448);
                        let v1185: num_complex::Complex<f64> = if (v450.clone().re) <= 1.0_f64 {
                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                        } else {
                            println!("zeta / count: {:?} / s: {:?}", 2_i32, v450.clone());
                            if (v450.clone().re) > 1.0_f64 {
                                let v461: num_complex::Complex<f64> =
                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                let v462: Array<i32> = new_init(&0_i32, 10000_i32);
                                let v463: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Math::method14(v463.clone()) {
                                    let v465: i32 = v463.l0.get().clone();
                                    v462.get_mut()[v465 as usize] = v465;
                                    {
                                        let v466: i32 = (v465) + 1_i32;
                                        v463.l0.set(v466);
                                        ()
                                    }
                                }
                                {
                                    let v467: i32 = get_Count(v462.clone());
                                    let v468: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                        l0: MutCell::new(0_i32),
                                        l1: MutCell::new(v461),
                                    });
                                    while Math::method15(v467, v468.clone()) {
                                        let v470: i32 = v468.l0.get().clone();
                                        let v471: num_complex::Complex<f64> = v468.l1.get().clone();
                                        let v472: i32 = v462[v470].clone();
                                        let v474: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v484: f64 = v472 as f64;
                                        let v497: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v484, 0.0_f64);
                                        let v499: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v497, v450.clone());
                                        let v501: num_complex::Complex<f64> = v474 / v499;
                                        let v503: num_complex::Complex<f64> = v471 + v501;
                                        let v504: i32 = (v470) + 1_i32;
                                        v468.l0.set(v504);
                                        v468.l1.set(v503);
                                        ()
                                    }
                                    v468.l1.get().clone()
                                }
                            } else {
                                let v507: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v512: Result<num_complex::Complex<f64>, std::string::String> =
                                    Math::method16(
                                        v0_1.clone(),
                                        string("        s = mpmath.gamma(s)"),
                                        Math::method3(v507 - v450.clone()),
                                    );
                                let v517: Option<num_complex::Complex<f64>> = v512.ok();
                                let v638: Math::US0 =
                                    defaultValue(Math::US0::US0_1, map(Math::method17(), v517));
                                let v652: f64 = f64::NAN;
                                let v654: f64 = f64::NAN;
                                let v656: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v652, v654);
                                let v659: num_complex::Complex<f64> = match &v638 {
                                    Math::US0::US0_0(v638_0_0) => match &v638 {
                                        Math::US0::US0_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                    _ => v656.clone(),
                                };
                                let v661: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v663: num_complex::Complex<f64> = v661 * v450.clone();
                                let v665: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v667: num_complex::Complex<f64> = v663 / v665;
                                let v669: num_complex::Complex<f64> = v667.sin();
                                let v672: f64 = 1.0_f64 - (v450.clone().re);
                                let v675: f64 = -v450.clone().im;
                                let v677: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v672, v675);
                                let v1169: num_complex::Complex<f64> = if (v677.clone().re)
                                    <= 1.0_f64
                                {
                                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                                } else {
                                    println!("zeta / count: {:?} / s: {:?}", 3_i32, v677.clone());
                                    if (v677.clone().re) > 1.0_f64 {
                                        let v688: num_complex::Complex<f64> =
                                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                                        let v689: Array<i32> = new_init(&0_i32, 10000_i32);
                                        let v690: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                            l0: MutCell::new(0_i32),
                                        });
                                        while Math::method14(v690.clone()) {
                                            let v692: i32 = v690.l0.get().clone();
                                            v689.get_mut()[v692 as usize] = v692;
                                            {
                                                let v693: i32 = (v692) + 1_i32;
                                                v690.l0.set(v693);
                                                ()
                                            }
                                        }
                                        {
                                            let v694: i32 = get_Count(v689.clone());
                                            let v695: LrcPtr<Math::Mut2> =
                                                LrcPtr::new(Math::Mut2 {
                                                    l0: MutCell::new(0_i32),
                                                    l1: MutCell::new(v688),
                                                });
                                            while Math::method15(v694, v695.clone()) {
                                                let v697: i32 = v695.l0.get().clone();
                                                let v698: num_complex::Complex<f64> =
                                                    v695.l1.get().clone();
                                                let v699: i32 = v689[v697].clone();
                                                let v701: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v711: f64 = v699 as f64;
                                                let v724: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v711, 0.0_f64);
                                                let v726: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v724, v677.clone());
                                                let v728: num_complex::Complex<f64> = v701 / v726;
                                                let v730: num_complex::Complex<f64> = v698 + v728;
                                                let v731: i32 = (v697) + 1_i32;
                                                v695.l0.set(v731);
                                                v695.l1.set(v730);
                                                ()
                                            }
                                            v695.l1.get().clone()
                                        }
                                    } else {
                                        let v734: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v739: Result<
                                            num_complex::Complex<f64>,
                                            std::string::String,
                                        > = Math::method16(
                                            v0_1.clone(),
                                            string("        s = mpmath.gamma(s)"),
                                            Math::method3(v734 - v677.clone()),
                                        );
                                        let v744: Option<num_complex::Complex<f64>> = v739.ok();
                                        let v865: Math::US0 = defaultValue(
                                            Math::US0::US0_1,
                                            map(Math::method17(), v744),
                                        );
                                        let v879: f64 = f64::NAN;
                                        let v881: f64 = f64::NAN;
                                        let v883: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v879, v881);
                                        let v886: num_complex::Complex<f64> = match &v865 {
                                            Math::US0::US0_0(v865_0_0) => match &v865 {
                                                Math::US0::US0_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                            _ => v883.clone(),
                                        };
                                        let v888: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v890: num_complex::Complex<f64> = v888 * v677.clone();
                                        let v892: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v894: num_complex::Complex<f64> = v890 / v892;
                                        let v896: num_complex::Complex<f64> = v894.sin();
                                        let v899: f64 = 1.0_f64 - (v677.clone().re);
                                        let v902: f64 = -v677.clone().im;
                                        let v904: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v899, v902);
                                        let v1153: num_complex::Complex<f64> = if (v904.clone().re)
                                            <= 1.0_f64
                                        {
                                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                                        } else {
                                            println!(
                                                "zeta / count: {:?} / s: {:?}",
                                                4_i32,
                                                v904.clone()
                                            );
                                            if (v904.clone().re) > 1.0_f64 {
                                                let v915: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                                let v916: Array<i32> = new_init(&0_i32, 10000_i32);
                                                let v917: LrcPtr<Math::Mut0> =
                                                    LrcPtr::new(Math::Mut0 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Math::method14(v917.clone()) {
                                                    let v919: i32 = v917.l0.get().clone();
                                                    v916.get_mut()[v919 as usize] = v919;
                                                    {
                                                        let v920: i32 = (v919) + 1_i32;
                                                        v917.l0.set(v920);
                                                        ()
                                                    }
                                                }
                                                {
                                                    let v921: i32 = get_Count(v916.clone());
                                                    let v922: LrcPtr<Math::Mut2> =
                                                        LrcPtr::new(Math::Mut2 {
                                                            l0: MutCell::new(0_i32),
                                                            l1: MutCell::new(v915),
                                                        });
                                                    while Math::method15(v921, v922.clone()) {
                                                        let v924: i32 = v922.l0.get().clone();
                                                        let v925: num_complex::Complex<f64> =
                                                            v922.l1.get().clone();
                                                        let v926: i32 = v916[v924].clone();
                                                        let v928: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                1.0_f64, 0.0_f64,
                                                            );
                                                        let v938: f64 = v926 as f64;
                                                        let v951: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                v938, 0.0_f64,
                                                            );
                                                        let v953: num_complex::Complex<f64> =
                                                            num_complex::Complex::powc(
                                                                v951,
                                                                v904.clone(),
                                                            );
                                                        let v955: num_complex::Complex<f64> =
                                                            v928 / v953;
                                                        let v957: num_complex::Complex<f64> =
                                                            v925 + v955;
                                                        let v958: i32 = (v924) + 1_i32;
                                                        v922.l0.set(v958);
                                                        v922.l1.set(v957);
                                                        ()
                                                    }
                                                    v922.l1.get().clone()
                                                }
                                            } else {
                                                let v961: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v966: Result<
                                                    num_complex::Complex<f64>,
                                                    std::string::String,
                                                > = Math::method16(
                                                    v0_1,
                                                    string("        s = mpmath.gamma(s)"),
                                                    Math::method3(v961 - v904.clone()),
                                                );
                                                let v971: Option<num_complex::Complex<f64>> =
                                                    v966.ok();
                                                let v1092: Math::US0 = defaultValue(
                                                    Math::US0::US0_1,
                                                    map(Math::method17(), v971),
                                                );
                                                let v1106: f64 = f64::NAN;
                                                let v1108: f64 = f64::NAN;
                                                let v1110: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v1106, v1108);
                                                let v1113: num_complex::Complex<f64> = match &v1092
                                                {
                                                    Math::US0::US0_0(v1092_0_0) => match &v1092 {
                                                        Math::US0::US0_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                    _ => v1110.clone(),
                                                };
                                                let v1115: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(
                                                        3.141592653589793_f64,
                                                        0.0_f64,
                                                    );
                                                let v1117: num_complex::Complex<f64> =
                                                    v1115 * v904.clone();
                                                let v1119: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                let v1121: num_complex::Complex<f64> =
                                                    v1117 / v1119;
                                                let v1123: num_complex::Complex<f64> = v1121.sin();
                                                let v1126: f64 = 1.0_f64 - (v904.clone().re);
                                                let v1129: f64 = -v904.clone().im;
                                                let v1131: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v1126, v1129);
                                                let v1137: num_complex::Complex<f64> =
                                                    if (v1131.clone().re) <= 1.0_f64 {
                                                        num_complex::Complex::new(0.0_f64, 0.0_f64)
                                                    } else {
                                                        v1131
                                                    };
                                                let v1139: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                let v1141: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(
                                                        3.141592653589793_f64,
                                                        0.0_f64,
                                                    );
                                                let v1143: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v1141, v904.clone());
                                                let v1145: num_complex::Complex<f64> =
                                                    v1139 * v1143;
                                                let v1147: num_complex::Complex<f64> =
                                                    v1145 * v1123;
                                                let v1149: num_complex::Complex<f64> =
                                                    v1147 * v1113;
                                                v1149 * v1137
                                            }
                                        };
                                        let v1155: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v1157: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v1159: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v1157, v677.clone());
                                        let v1161: num_complex::Complex<f64> = v1155 * v1159;
                                        let v1163: num_complex::Complex<f64> = v1161 * v896;
                                        let v1165: num_complex::Complex<f64> = v1163 * v886;
                                        v1165 * v1153
                                    }
                                };
                                let v1171: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v1173: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v1175: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v1173, v450.clone());
                                let v1177: num_complex::Complex<f64> = v1171 * v1175;
                                let v1179: num_complex::Complex<f64> = v1177 * v669;
                                let v1181: num_complex::Complex<f64> = v1179 * v659;
                                v1181 * v1169
                            }
                        };
                        let v1187: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v1189: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v1191: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v1189, v223.clone());
                        let v1193: num_complex::Complex<f64> = v1187 * v1191;
                        let v1195: num_complex::Complex<f64> = v1193 * v442;
                        let v1197: num_complex::Complex<f64> = v1195 * v432;
                        v1197 * v1185
                    }
                };
                let v1203: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v1205: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v1207: num_complex::Complex<f64> =
                    num_complex::Complex::powc(v1205, v1_1.clone());
                let v1209: num_complex::Complex<f64> = v1203 * v1207;
                let v1211: num_complex::Complex<f64> = v1209 * v215;
                let v1213: num_complex::Complex<f64> = v1211 * v205;
                v1213 * v1201
            }
        }
        pub fn method18(v0_1: bool) -> bool {
            v0_1
        }
        pub fn method20() -> string {
            string("")
        }
        pub fn method21(v0_1: LrcPtr<Math::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("{ "));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method22(v0_1: LrcPtr<Math::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("expected"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method23(v0_1: LrcPtr<Math::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string(" = "));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method24(v0_1: LrcPtr<Math::Mut3>, v1_1: string) {
            let v5: string = append((v0_1.l0.get().clone()), (v1_1));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method25(v0_1: LrcPtr<Math::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string(" }"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method19(v0_1: f64) -> string {
            let v12: LrcPtr<Math::Mut3> = LrcPtr::new(Math::Mut3 {
                l0: MutCell::new(Math::method20()),
            });
            Math::method21(v12.clone());
            Math::method22(v12.clone());
            Math::method23(v12.clone());
            Math::method24(v12.clone(), sprintf!("{:+.6}", v0_1));
            Math::method25(v12.clone());
            v12.l0.get().clone()
        }
        pub fn method27(v0_1: LrcPtr<Math::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("actual"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method28(v0_1: LrcPtr<Math::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("; "));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method26(v0_1: f64, v1_1: f64) -> string {
            let v13: LrcPtr<Math::Mut3> = LrcPtr::new(Math::Mut3 {
                l0: MutCell::new(Math::method20()),
            });
            Math::method21(v13.clone());
            Math::method27(v13.clone());
            Math::method23(v13.clone());
            Math::method24(v13.clone(), sprintf!("{:+.6}", v0_1));
            Math::method28(v13.clone());
            Math::method22(v13.clone());
            Math::method23(v13.clone());
            Math::method24(v13.clone(), sprintf!("{:+.6}", v1_1));
            Math::method25(v13.clone());
            v13.l0.get().clone()
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
                let v20: Option<num_complex::Complex<f64>> = v14.ok();
                let v141: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v20));
                let v155: f64 = f64::NAN;
                let v157: f64 = f64::NAN;
                let v159: num_complex::Complex<f64> = num_complex::Complex::new(v155, v157);
                let v162: num_complex::Complex<f64> = match &v141 {
                    Math::US0::US0_0(v141_0_0) => match &v141 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v159.clone(),
                };
                let v164: f64 = v162.clone().im;
                let v165: bool = (v164) == 0.0_f64;
                let v167: bool = if v165 { true } else { Math::method18(v165) };
                let v172: string = if v165 {
                    Math::method19(0.0_f64)
                } else {
                    Math::method26(v164, 0.0_f64)
                };
                let v200: string = append(
                    string("__assert_eq "),
                    (if v165 {
                        Math::method19(0.0_f64)
                    } else {
                        Math::method26(v164, 0.0_f64)
                    }),
                );
                let v244: () = {
                    Math::closure2(v200.clone(), ());
                    ()
                };
                if (v167) == false {
                    panic!("{}", v200,);
                }
                {
                    let v259: f64 = (v162.re) - (patternInput.1.clone());
                    let v260: f64 = -v259;
                    let v262: f64 = if (v259) >= (v260) { v259 } else { v260 };
                    let v263: bool = (v262) < 0.0001_f64;
                    let v265: bool = if v263 { true } else { Math::method18(v263) };
                    let v270: string = if v263 {
                        Math::method19(0.0001_f64)
                    } else {
                        Math::method26(v262, 0.0001_f64)
                    };
                    let v295: string = append(
                        string("__assert_lt "),
                        (if v263 {
                            Math::method19(0.0001_f64)
                        } else {
                            Math::method26(v262, 0.0001_f64)
                        }),
                    );
                    let v339: () = {
                        Math::closure2(v295.clone(), ());
                        ()
                    };
                    if (v265) == false {
                        panic!("{}", v295,);
                    }
                    {
                        let v352: i32 = (v9) + 1_i32;
                        v7.l0.set(v352);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method29(v0_1: Result<(), pyo3::PyErr>) -> Result<(), pyo3::PyErr> {
            v0_1
        }
        pub fn method0() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method1(py);
                {
                    let v24: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v28: string = string("}}");
                    let v30: string = string("{");
                    let v35: bool = true;
                    let _fix_closure_v32 = v24;
                    let v41: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v32 "), (v28))),
                                string("); "),
                            )),
                            (v30),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v42: bool = true;
                    _fix_closure_v32
                }
            });
            {
                // rust.fix_closure';
                let v44: Result<(), pyo3::PyErr> = __run_test;
                v44.unwrap();
                ()
            }
        }
        pub fn method31(v0_1: pyo3::Python) {
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, -2.0_f64);
            let v5: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v2.clone()),
            );
            let v6: num_complex::Complex<f64> = Math::method13(v0_1, v2);
            let v11: Option<num_complex::Complex<f64>> = v5.ok();
            let v132: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v11));
            let v146: f64 = f64::NAN;
            let v148: f64 = f64::NAN;
            let v150: num_complex::Complex<f64> = num_complex::Complex::new(v146, v148);
            let v153: num_complex::Complex<f64> = match &v132 {
                Math::US0::US0_0(v132_0_0) => match &v132 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v150.clone(),
            };
            let v156: f64 = (v153.clone().re) - 0.8673_f64;
            let v157: f64 = -v156;
            let v159: f64 = if (v156) >= (v157) { v156 } else { v157 };
            let v160: bool = (v159) < 0.001_f64;
            let v162: bool = if v160 { true } else { Math::method18(v160) };
            let v167: string = if v160 {
                Math::method19(0.001_f64)
            } else {
                Math::method26(v159, 0.001_f64)
            };
            let v195: string = append(
                string("__assert_lt "),
                (if v160 {
                    Math::method19(0.001_f64)
                } else {
                    Math::method26(v159, 0.001_f64)
                }),
            );
            let v239: () = {
                Math::closure2(v195.clone(), ());
                ()
            };
            if (v162) == false {
                panic!("{}", v195,);
            }
            {
                let v254: f64 = (v153.im) - 0.275_f64;
                let v255: f64 = -v254;
                let v257: f64 = if (v254) >= (v255) { v254 } else { v255 };
                let v258: bool = (v257) < 0.001_f64;
                let v260: bool = if v258 { true } else { Math::method18(v258) };
                let v265: string = if v258 {
                    Math::method19(0.001_f64)
                } else {
                    Math::method26(v257, 0.001_f64)
                };
                let v287: string = append(
                    string("__assert_lt "),
                    (if v258 {
                        Math::method19(0.001_f64)
                    } else {
                        Math::method26(v257, 0.001_f64)
                    }),
                );
                let v331: () = {
                    Math::closure2(v287.clone(), ());
                    ()
                };
                if (v260) == false {
                    panic!("{}", v287,);
                }
            }
        }
        pub fn method30() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method31(py);
                {
                    let v24: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v28: string = string("}}");
                    let v30: string = string("{");
                    let v35: bool = true;
                    let _fix_closure_v32 = v24;
                    let v41: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v32 "), (v28))),
                                string("); "),
                            )),
                            (v30),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v42: bool = true;
                    _fix_closure_v32
                }
            });
            {
                // rust.fix_closure';
                let v44: Result<(), pyo3::PyErr> = __run_test;
                v44.unwrap();
                ()
            }
        }
        pub fn method34() -> LrcPtr<Math::UH0> {
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
        pub fn method35(v0_1: pyo3::Python, v1_1: LrcPtr<Math::UH0>) {
            let v0_1: MutCell<pyo3::Python> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1_1.clone());
            '_method35: loop {
                break '_method35 (match v1_1.get().clone().as_ref() {
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
                        let v14: Option<num_complex::Complex<f64>> = v8.ok();
                        let v135: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v14));
                        let v149: f64 = f64::NAN;
                        let v151: f64 = f64::NAN;
                        let v153: num_complex::Complex<f64> = num_complex::Complex::new(v149, v151);
                        let v156: num_complex::Complex<f64> = match &v135 {
                            Math::US0::US0_0(v135_0_0) => match &v135 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v153.clone(),
                        };
                        let v158: f64 = v156.clone().re;
                        let v159: bool = (v158) == 0.0_f64;
                        let v161: bool = if v159 { true } else { Math::method18(v159) };
                        let v166: string = if v159 {
                            Math::method19(0.0_f64)
                        } else {
                            Math::method26(v158, 0.0_f64)
                        };
                        let v194: string = append(
                            string("__assert_eq "),
                            (if v159 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v158, 0.0_f64)
                            }),
                        );
                        let v238: () = {
                            Math::closure2(v194.clone(), ());
                            ()
                        };
                        if (v161) == false {
                            panic!("{}", v194,);
                        }
                        {
                            let v252: f64 = v156.im;
                            let v253: bool = (v252) == 0.0_f64;
                            let v255: bool = if v253 { true } else { Math::method18(v253) };
                            let v260: string = if v253 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v252, 0.0_f64)
                            };
                            let v282: string = append(
                                string("__assert_eq "),
                                (if v253 {
                                    Math::method19(0.0_f64)
                                } else {
                                    Math::method26(v252, 0.0_f64)
                                }),
                            );
                            let v326: () = {
                                Math::closure2(v282.clone(), ());
                                ()
                            };
                            if (v255) == false {
                                panic!("{}", v282,);
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
                                continue '_method35;
                            }
                        }
                    }
                });
            }
        }
        pub fn method33(v0_1: pyo3::Python) {
            Math::method35(v0_1, Math::method34());
        }
        pub fn method32() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method33(py);
                {
                    let v24: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v28: string = string("}}");
                    let v30: string = string("{");
                    let v35: bool = true;
                    let _fix_closure_v32 = v24;
                    let v41: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v32 "), (v28))),
                                string("); "),
                            )),
                            (v30),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v42: bool = true;
                    _fix_closure_v32
                }
            });
            {
                // rust.fix_closure';
                let v44: Result<(), pyo3::PyErr> = __run_test;
                v44.unwrap();
                ()
            }
        }
        pub fn method37(v0_1: pyo3::Python) {
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
                let v27: Option<num_complex::Complex<f64>> = v21.ok();
                let v148: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v27));
                let v162: f64 = f64::NAN;
                let v164: f64 = f64::NAN;
                let v166: num_complex::Complex<f64> = num_complex::Complex::new(v162, v164);
                let v169: num_complex::Complex<f64> = match &v148 {
                    Math::US0::US0_0(v148_0_0) => match &v148 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v166.clone(),
                };
                let v171: f64 = v169.clone().re;
                let v172: f64 = -v171;
                let v174: f64 = if (v171) >= (v172) { v171 } else { v172 };
                let v175: bool = (v174) < 0.0001_f64;
                let v177: bool = if v175 { true } else { Math::method18(v175) };
                let v182: string = if v175 {
                    Math::method19(0.0001_f64)
                } else {
                    Math::method26(v174, 0.0001_f64)
                };
                let v210: string = append(
                    string("__assert_lt "),
                    (if v175 {
                        Math::method19(0.0001_f64)
                    } else {
                        Math::method26(v174, 0.0001_f64)
                    }),
                );
                let v254: () = {
                    Math::closure2(v210.clone(), ());
                    ()
                };
                if (v177) == false {
                    panic!("{}", v210,);
                }
                {
                    let v268: f64 = v169.im;
                    let v269: f64 = -v268;
                    let v271: f64 = if (v268) >= (v269) { v268 } else { v269 };
                    let v272: bool = (v271) < 0.0001_f64;
                    let v274: bool = if v272 { true } else { Math::method18(v272) };
                    let v279: string = if v272 {
                        Math::method19(0.0001_f64)
                    } else {
                        Math::method26(v271, 0.0001_f64)
                    };
                    let v301: string = append(
                        string("__assert_lt "),
                        (if v272 {
                            Math::method19(0.0001_f64)
                        } else {
                            Math::method26(v271, 0.0001_f64)
                        }),
                    );
                    let v345: () = {
                        Math::closure2(v301.clone(), ());
                        ()
                    };
                    if (v274) == false {
                        panic!("{}", v301,);
                    }
                    {
                        let v358: i32 = (v17) + 1_i32;
                        v15.l0.set(v358);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method36() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method37(py);
                {
                    let v24: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v28: string = string("}}");
                    let v30: string = string("{");
                    let v35: bool = true;
                    let _fix_closure_v32 = v24;
                    let v41: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v32 "), (v28))),
                                string("); "),
                            )),
                            (v30),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v42: bool = true;
                    _fix_closure_v32
                }
            });
            {
                // rust.fix_closure';
                let v44: Result<(), pyo3::PyErr> = __run_test;
                v44.unwrap();
                ()
            }
        }
        pub fn method39(v0_1: pyo3::Python) {
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
                let v17: Option<num_complex::Complex<f64>> = v11.ok();
                let v138: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v17));
                let v152: f64 = f64::NAN;
                let v154: f64 = f64::NAN;
                let v156: num_complex::Complex<f64> = num_complex::Complex::new(v152, v154);
                let v159: num_complex::Complex<f64> = match &v138 {
                    Math::US0::US0_0(v138_0_0) => match &v138 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v156.clone(),
                };
                let v161: f64 = v159.clone().re;
                let v162: bool = (v161) > 0.0_f64;
                let v164: bool = if v162 { true } else { Math::method18(v162) };
                let v169: string = if v162 {
                    Math::method19(0.0_f64)
                } else {
                    Math::method26(v161, 0.0_f64)
                };
                let v197: string = append(
                    string("__assert_gt "),
                    (if v162 {
                        Math::method19(0.0_f64)
                    } else {
                        Math::method26(v161, 0.0_f64)
                    }),
                );
                let v241: () = {
                    Math::closure2(v197.clone(), ());
                    ()
                };
                if (v164) == false {
                    panic!("{}", v197,);
                }
                {
                    let v255: f64 = v159.im;
                    let v256: bool = (v255) == 0.0_f64;
                    let v258: bool = if v256 { true } else { Math::method18(v256) };
                    let v263: string = if v256 {
                        Math::method19(0.0_f64)
                    } else {
                        Math::method26(v255, 0.0_f64)
                    };
                    let v288: string = append(
                        string("__assert_eq "),
                        (if v256 {
                            Math::method19(0.0_f64)
                        } else {
                            Math::method26(v255, 0.0_f64)
                        }),
                    );
                    let v332: () = {
                        Math::closure2(v288.clone(), ());
                        ()
                    };
                    if (v258) == false {
                        panic!("{}", v288,);
                    }
                    {
                        let v345: i32 = (v5) + 1_i32;
                        v3.l0.set(v345);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method38() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method39(py);
                {
                    let v24: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v28: string = string("}}");
                    let v30: string = string("{");
                    let v35: bool = true;
                    let _fix_closure_v32 = v24;
                    let v41: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v32 "), (v28))),
                                string("); "),
                            )),
                            (v30),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v42: bool = true;
                    _fix_closure_v32
                }
            });
            {
                // rust.fix_closure';
                let v44: Result<(), pyo3::PyErr> = __run_test;
                v44.unwrap();
                ()
            }
        }
        pub fn method41(v0_1: pyo3::Python) {
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(1.0_f64, 0.0_f64);
            let v5: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v2.clone()),
            );
            let v6: num_complex::Complex<f64> = Math::method13(v0_1, v2);
            let v11: Option<num_complex::Complex<f64>> = v5.ok();
            let v132: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v11));
            let v146: f64 = f64::NAN;
            let v148: f64 = f64::NAN;
            let v150: num_complex::Complex<f64> = num_complex::Complex::new(v146, v148);
            let v153: num_complex::Complex<f64> = match &v132 {
                Math::US0::US0_0(v132_0_0) => match &v132 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v150.clone(),
            };
            let v155: f64 = v153.clone().re;
            let v156: bool = (v155) == (f64::INFINITY);
            let v158: bool = if v156 { true } else { Math::method18(v156) };
            let v163: string = if v156 {
                Math::method19(f64::INFINITY)
            } else {
                Math::method26(v155, f64::INFINITY)
            };
            let v191: string = append(
                string("__assert_eq "),
                (if v156 {
                    Math::method19(f64::INFINITY)
                } else {
                    Math::method26(v155, f64::INFINITY)
                }),
            );
            let v235: () = {
                Math::closure2(v191.clone(), ());
                ()
            };
            if (v158) == false {
                panic!("{}", v191,);
            }
            {
                let v249: f64 = v153.im;
                let v250: bool = (v249) == 0.0_f64;
                let v252: bool = if v250 { true } else { Math::method18(v250) };
                let v257: string = if v250 {
                    Math::method19(0.0_f64)
                } else {
                    Math::method26(v249, 0.0_f64)
                };
                let v279: string = append(
                    string("__assert_eq "),
                    (if v250 {
                        Math::method19(0.0_f64)
                    } else {
                        Math::method26(v249, 0.0_f64)
                    }),
                );
                let v323: () = {
                    Math::closure2(v279.clone(), ());
                    ()
                };
                if (v252) == false {
                    panic!("{}", v279,);
                }
            }
        }
        pub fn method40() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method41(py);
                {
                    let v24: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v28: string = string("}}");
                    let v30: string = string("{");
                    let v35: bool = true;
                    let _fix_closure_v32 = v24;
                    let v41: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v32 "), (v28))),
                                string("); "),
                            )),
                            (v30),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v42: bool = true;
                    _fix_closure_v32
                }
            });
            {
                // rust.fix_closure';
                let v44: Result<(), pyo3::PyErr> = __run_test;
                v44.unwrap();
                ()
            }
        }
        pub fn method43(v0_1: pyo3::Python) {
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 10.0_f64);
            let v5: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v2.clone()),
            );
            let v6: num_complex::Complex<f64> = Math::method13(v0_1.clone(), v2.clone());
            let v11: Option<num_complex::Complex<f64>> = v5.ok();
            let v132: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v11));
            let v146: f64 = f64::NAN;
            let v148: f64 = f64::NAN;
            let v150: num_complex::Complex<f64> = num_complex::Complex::new(v146, v148);
            let v153: num_complex::Complex<f64> = match &v132 {
                Math::US0::US0_0(v132_0_0) => match &v132 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v150.clone(),
            };
            let v155: f64 = v2.clone().re;
            let v158: f64 = -v2.im;
            let v160: num_complex::Complex<f64> = num_complex::Complex::new(v155, v158);
            let v163: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v160.clone()),
            );
            let v164: num_complex::Complex<f64> = Math::method13(v0_1, v160);
            let v169: Option<num_complex::Complex<f64>> = v163.ok();
            let v290: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v169));
            let v304: f64 = f64::NAN;
            let v306: f64 = f64::NAN;
            let v308: num_complex::Complex<f64> = num_complex::Complex::new(v304, v306);
            let v311: num_complex::Complex<f64> = match &v290 {
                Math::US0::US0_0(v290_0_0) => match &v290 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v308.clone(),
            };
            let v313: num_complex::Complex<f64> = v311.conj();
            let v315: f64 = v153.clone().re;
            let v317: f64 = v313.clone().re;
            let v318: bool = (v315) == (v317);
            let v320: bool = if v318 { true } else { Math::method18(v318) };
            let v323: string = if v318 {
                Math::method19(v317)
            } else {
                Math::method26(v315, v317)
            };
            let v349: string = append(
                string("__assert_eq "),
                (if v318 {
                    Math::method19(v317)
                } else {
                    Math::method26(v315, v317)
                }),
            );
            let v393: () = {
                Math::closure2(v349.clone(), ());
                ()
            };
            if (v320) == false {
                panic!("{}", v349,);
            }
            {
                let v407: f64 = v153.im;
                let v409: f64 = v313.im;
                let v410: bool = (v407) == (v409);
                let v412: bool = if v410 { true } else { Math::method18(v410) };
                let v415: string = if v410 {
                    Math::method19(v409)
                } else {
                    Math::method26(v407, v409)
                };
                let v435: string = append(
                    string("__assert_eq "),
                    (if v410 {
                        Math::method19(v409)
                    } else {
                        Math::method26(v407, v409)
                    }),
                );
                let v479: () = {
                    Math::closure2(v435.clone(), ());
                    ()
                };
                if (v412) == false {
                    panic!("{}", v435,);
                }
            }
        }
        pub fn method42() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method43(py);
                {
                    let v24: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v28: string = string("}}");
                    let v30: string = string("{");
                    let v35: bool = true;
                    let _fix_closure_v32 = v24;
                    let v41: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v32 "), (v28))),
                                string("); "),
                            )),
                            (v30),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v42: bool = true;
                    _fix_closure_v32
                }
            });
            {
                // rust.fix_closure';
                let v44: Result<(), pyo3::PyErr> = __run_test;
                v44.unwrap();
                ()
            }
        }
        pub fn method45(v0_1: pyo3::Python) {
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(0.01_f64, 0.01_f64);
            let v5: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v2.clone()),
            );
            let v6: num_complex::Complex<f64> = Math::method13(v0_1, v2);
            let v11: Option<num_complex::Complex<f64>> = v5.ok();
            let v132: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v11));
            let v146: f64 = f64::NAN;
            let v148: f64 = f64::NAN;
            let v150: num_complex::Complex<f64> = num_complex::Complex::new(v146, v148);
            let v153: num_complex::Complex<f64> = match &v132 {
                Math::US0::US0_0(v132_0_0) => match &v132 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v150.clone(),
            };
            let v155: f64 = v153.clone().re;
            let v156: bool = (v155) < (f64::INFINITY);
            let v158: bool = if v156 { true } else { Math::method18(v156) };
            let v163: string = if v156 {
                Math::method19(f64::INFINITY)
            } else {
                Math::method26(v155, f64::INFINITY)
            };
            let v191: string = append(
                string("__assert_lt "),
                (if v156 {
                    Math::method19(f64::INFINITY)
                } else {
                    Math::method26(v155, f64::INFINITY)
                }),
            );
            let v235: () = {
                Math::closure2(v191.clone(), ());
                ()
            };
            if (v158) == false {
                panic!("{}", v191,);
            }
            {
                let v249: f64 = v153.im;
                let v250: bool = (v249) < (f64::INFINITY);
                let v252: bool = if v250 { true } else { Math::method18(v250) };
                let v257: string = if v250 {
                    Math::method19(f64::INFINITY)
                } else {
                    Math::method26(v249, f64::INFINITY)
                };
                let v279: string = append(
                    string("__assert_lt "),
                    (if v250 {
                        Math::method19(f64::INFINITY)
                    } else {
                        Math::method26(v249, f64::INFINITY)
                    }),
                );
                let v323: () = {
                    Math::closure2(v279.clone(), ());
                    ()
                };
                if (v252) == false {
                    panic!("{}", v279,);
                }
            }
        }
        pub fn method44() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method45(py);
                {
                    let v24: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v28: string = string("}}");
                    let v30: string = string("{");
                    let v35: bool = true;
                    let _fix_closure_v32 = v24;
                    let v41: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v32 "), (v28))),
                                string("); "),
                            )),
                            (v30),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v42: bool = true;
                    _fix_closure_v32
                }
            });
            {
                // rust.fix_closure';
                let v44: Result<(), pyo3::PyErr> = __run_test;
                v44.unwrap();
                ()
            }
        }
        pub fn method48() -> LrcPtr<Math::UH0> {
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
        pub fn method49(v0_1: pyo3::Python, v1_1: LrcPtr<Math::UH0>) {
            let v0_1: MutCell<pyo3::Python> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1_1.clone());
            '_method49: loop {
                break '_method49 (match v1_1.get().clone().as_ref() {
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
                        let v14: Option<num_complex::Complex<f64>> = v8.ok();
                        let v135: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v14));
                        let v149: f64 = f64::NAN;
                        let v151: f64 = f64::NAN;
                        let v153: num_complex::Complex<f64> = num_complex::Complex::new(v149, v151);
                        let v156: num_complex::Complex<f64> = match &v135 {
                            Math::US0::US0_0(v135_0_0) => match &v135 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v153.clone(),
                        };
                        let v158: f64 = v156.clone().re;
                        let v167: bool = (v158) != 0.0_f64;
                        let v180: bool = if v167 { true } else { Math::method18(v167) };
                        let v185: string = if v167 {
                            Math::method19(0.0_f64)
                        } else {
                            Math::method26(v158, 0.0_f64)
                        };
                        let v213: string = append(
                            string("__assert_ne "),
                            (if v167 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v158, 0.0_f64)
                            }),
                        );
                        let v257: () = {
                            Math::closure2(v213.clone(), ());
                            ()
                        };
                        if (v180) == false {
                            panic!("{}", v213,);
                        }
                        {
                            let v271: f64 = v156.im;
                            let v280: bool = (v271) != 0.0_f64;
                            let v293: bool = if v280 { true } else { Math::method18(v280) };
                            let v298: string = if v280 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v271, 0.0_f64)
                            };
                            let v320: string = append(
                                string("__assert_ne "),
                                (if v280 {
                                    Math::method19(0.0_f64)
                                } else {
                                    Math::method26(v271, 0.0_f64)
                                }),
                            );
                            let v364: () = {
                                Math::closure2(v320.clone(), ());
                                ()
                            };
                            if (v293) == false {
                                panic!("{}", v320,);
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
                                continue '_method49;
                            }
                        }
                    }
                });
            }
        }
        pub fn method47(v0_1: pyo3::Python) {
            Math::method49(v0_1, Math::method48());
        }
        pub fn method46() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method47(py);
                {
                    let v24: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v28: string = string("}}");
                    let v30: string = string("{");
                    let v35: bool = true;
                    let _fix_closure_v32 = v24;
                    let v41: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v32 "), (v28))),
                                string("); "),
                            )),
                            (v30),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v42: bool = true;
                    _fix_closure_v32
                }
            });
            {
                // rust.fix_closure';
                let v44: Result<(), pyo3::PyErr> = __run_test;
                v44.unwrap();
                ()
            }
        }
        pub fn method52() -> LrcPtr<Math::UH1> {
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
        pub fn method53(v0_1: pyo3::Python, v1_1: LrcPtr<Math::UH1>) {
            let v0_1: MutCell<pyo3::Python> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Math::UH1>> = MutCell::new(v1_1.clone());
            '_method53: loop {
                break '_method53 (match v1_1.get().clone().as_ref() {
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
                        let v12: Option<num_complex::Complex<f64>> = v6.ok();
                        let v133: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v12));
                        let v147: f64 = f64::NAN;
                        let v149: f64 = f64::NAN;
                        let v151: num_complex::Complex<f64> = num_complex::Complex::new(v147, v149);
                        let v154: num_complex::Complex<f64> = match &v133 {
                            Math::US0::US0_0(v133_0_0) => match &v133 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v151.clone(),
                        };
                        let v156: f64 = v154.clone().re;
                        let v165: bool = (v156) != 0.0_f64;
                        let v178: bool = if v165 { true } else { Math::method18(v165) };
                        let v183: string = if v165 {
                            Math::method19(0.0_f64)
                        } else {
                            Math::method26(v156, 0.0_f64)
                        };
                        let v211: string = append(
                            string("__assert_ne "),
                            (if v165 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v156, 0.0_f64)
                            }),
                        );
                        let v255: () = {
                            Math::closure2(v211.clone(), ());
                            ()
                        };
                        if (v178) == false {
                            panic!("{}", v211,);
                        }
                        {
                            let v269: f64 = v154.im;
                            let v278: bool = (v269) != 0.0_f64;
                            let v291: bool = if v278 { true } else { Math::method18(v278) };
                            let v296: string = if v278 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v269, 0.0_f64)
                            };
                            let v318: string = append(
                                string("__assert_ne "),
                                (if v278 {
                                    Math::method19(0.0_f64)
                                } else {
                                    Math::method26(v269, 0.0_f64)
                                }),
                            );
                            let v362: () = {
                                Math::closure2(v318.clone(), ());
                                ()
                            };
                            if (v291) == false {
                                panic!("{}", v318,);
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
                                continue '_method53;
                            }
                        }
                    }
                });
            }
        }
        pub fn method51(v0_1: pyo3::Python) {
            Math::method53(v0_1, Math::method52());
        }
        pub fn method50() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method51(py);
                {
                    let v24: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v28: string = string("}}");
                    let v30: string = string("{");
                    let v35: bool = true;
                    let _fix_closure_v32 = v24;
                    let v41: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v32 "), (v28))),
                                string("); "),
                            )),
                            (v30),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v42: bool = true;
                    _fix_closure_v32
                }
            });
            {
                // rust.fix_closure';
                let v44: Result<(), pyo3::PyErr> = __run_test;
                v44.unwrap();
                ()
            }
        }
        pub fn method56() -> LrcPtr<Math::UH1> {
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
        pub fn method57(v0_1: pyo3::Python, v1_1: LrcPtr<Math::UH1>) {
            let v0_1: MutCell<pyo3::Python> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Math::UH1>> = MutCell::new(v1_1.clone());
            '_method57: loop {
                break '_method57 (match v1_1.get().clone().as_ref() {
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
                        let v12: Option<num_complex::Complex<f64>> = v6.ok();
                        let v133: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v12));
                        let v147: f64 = f64::NAN;
                        let v149: f64 = f64::NAN;
                        let v151: num_complex::Complex<f64> = num_complex::Complex::new(v147, v149);
                        let v154: num_complex::Complex<f64> = match &v133 {
                            Math::US0::US0_0(v133_0_0) => match &v133 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v151.clone(),
                        };
                        let v156: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v158: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v156, v2.clone());
                        let v160: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v162: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v164: num_complex::Complex<f64> = v2.clone() - v162;
                        let v166: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v160, v164);
                        let v168: num_complex::Complex<f64> = v158 * v166;
                        let v170: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v172: num_complex::Complex<f64> = v170 * v2.clone();
                        let v174: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v176: num_complex::Complex<f64> = v172 / v174;
                        let v178: num_complex::Complex<f64> = v176.sin();
                        let v180: num_complex::Complex<f64> = v168 * v178;
                        let v182: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v187: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method16(
                                v0_1.get().clone(),
                                string("        s = mpmath.gamma(s)"),
                                Math::method3(v182 - v2.clone()),
                            );
                        let v192: Option<num_complex::Complex<f64>> = v187.ok();
                        let v313: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v192));
                        let v327: f64 = f64::NAN;
                        let v329: f64 = f64::NAN;
                        let v331: num_complex::Complex<f64> = num_complex::Complex::new(v327, v329);
                        let v334: num_complex::Complex<f64> = match &v313 {
                            Math::US0::US0_0(v313_0_0) => match &v313 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v331.clone(),
                        };
                        let v336: num_complex::Complex<f64> = v180 * v334;
                        let v339: f64 = 1.0_f64 - (v2.clone().re);
                        let v342: f64 = -v2.im;
                        let v344: num_complex::Complex<f64> = num_complex::Complex::new(v339, v342);
                        let v347: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(
                                v0_1.get().clone(),
                                string("        s = mpmath.zeta(s)"),
                                Math::method3(v344.clone()),
                            );
                        let v348: num_complex::Complex<f64> =
                            Math::method13(v0_1.get().clone(), v344);
                        let v353: Option<num_complex::Complex<f64>> = v347.ok();
                        let v474: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v353));
                        let v488: f64 = f64::NAN;
                        let v490: f64 = f64::NAN;
                        let v492: num_complex::Complex<f64> = num_complex::Complex::new(v488, v490);
                        let v495: num_complex::Complex<f64> = match &v474 {
                            Math::US0::US0_0(v474_0_0) => match &v474 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v492.clone(),
                        };
                        let v497: num_complex::Complex<f64> = v336 * v495;
                        let v502: f64 = (v154.clone().re) - (v497.clone().re);
                        let v503: f64 = -v502;
                        let v505: f64 = if (v502) >= (v503) { v502 } else { v503 };
                        let v506: bool = (v505) < 0.0001_f64;
                        let v508: bool = if v506 { true } else { Math::method18(v506) };
                        let v513: string = if v506 {
                            Math::method19(0.0001_f64)
                        } else {
                            Math::method26(v505, 0.0001_f64)
                        };
                        let v541: string = append(
                            string("__assert_lt "),
                            (if v506 {
                                Math::method19(0.0001_f64)
                            } else {
                                Math::method26(v505, 0.0001_f64)
                            }),
                        );
                        let v585: () = {
                            Math::closure2(v541.clone(), ());
                            ()
                        };
                        if (v508) == false {
                            panic!("{}", v541,);
                        }
                        {
                            let v602: f64 = (v154.im) - (v497.im);
                            let v603: f64 = -v602;
                            let v605: f64 = if (v602) >= (v603) { v602 } else { v603 };
                            let v606: bool = (v605) < 0.0001_f64;
                            let v608: bool = if v606 { true } else { Math::method18(v606) };
                            let v613: string = if v606 {
                                Math::method19(0.0001_f64)
                            } else {
                                Math::method26(v605, 0.0001_f64)
                            };
                            let v635: string = append(
                                string("__assert_lt "),
                                (if v606 {
                                    Math::method19(0.0001_f64)
                                } else {
                                    Math::method26(v605, 0.0001_f64)
                                }),
                            );
                            let v679: () = {
                                Math::closure2(v635.clone(), ());
                                ()
                            };
                            if (v608) == false {
                                panic!("{}", v635,);
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
                                continue '_method57;
                            }
                        }
                    }
                });
            }
        }
        pub fn method55(v0_1: pyo3::Python) {
            Math::method57(v0_1, Math::method56());
        }
        pub fn method54() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method55(py);
                {
                    let v24: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v28: string = string("}}");
                    let v30: string = string("{");
                    let v35: bool = true;
                    let _fix_closure_v32 = v24;
                    let v41: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v32 "), (v28))),
                                string("); "),
                            )),
                            (v30),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v42: bool = true;
                    _fix_closure_v32
                }
            });
            {
                // rust.fix_closure';
                let v44: Result<(), pyo3::PyErr> = __run_test;
                v44.unwrap();
                ()
            }
        }
        pub fn method60() -> LrcPtr<Math::UH0> {
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
        pub fn method61() -> LrcPtr<Math::UH0> {
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
        pub fn method63(v0_1: f64, v1_1: LrcPtr<Math::UH0>, v2: f64) -> f64 {
            let v0_1: MutCell<f64> = MutCell::new(v0_1);
            let v1_1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1_1.clone());
            let v2: MutCell<f64> = MutCell::new(v2);
            '_method63: loop {
                break '_method63 (match v1_1.get().clone().as_ref() {
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
                            continue '_method63;
                        }
                    }
                });
            }
        }
        pub fn method62(v0_1: pyo3::Python, v1_1: LrcPtr<Math::UH0>, v2: LrcPtr<Math::UH0>) {
            let v0_1: MutCell<pyo3::Python> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v2.clone());
            '_method62: loop {
                break '_method62 (match v2.get().clone().as_ref() {
                    Math::UH0::UH0_0 => (),
                    Math::UH0::UH0_1(v2_1_0, v2_1_1) => {
                        let v3: f64 = match v2.get().clone().as_ref() {
                            Math::UH0::UH0_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v6: num_complex::Complex<f64> = num_complex::Complex::new(v3, 0.0_f64);
                        let v8: f64 = Math::method63(v3, v1_1.get().clone(), 1.0_f64);
                        let v11: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(
                                v0_1.get().clone(),
                                string("        s = mpmath.zeta(s)"),
                                Math::method3(v6.clone()),
                            );
                        let v12: num_complex::Complex<f64> = Math::method13(v0_1.get().clone(), v6);
                        let v17: Option<num_complex::Complex<f64>> = v11.ok();
                        let v138: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v17));
                        let v152: f64 = f64::NAN;
                        let v154: f64 = f64::NAN;
                        let v156: num_complex::Complex<f64> = num_complex::Complex::new(v152, v154);
                        let v159: num_complex::Complex<f64> = match &v138 {
                            Math::US0::US0_0(v138_0_0) => match &v138 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v156.clone(),
                        };
                        let v162: f64 = (v159.clone().re) - (v8);
                        let v163: f64 = -v162;
                        let v165: f64 = if (v162) >= (v163) { v162 } else { v163 };
                        let v166: bool = (v165) < 0.01_f64;
                        let v168: bool = if v166 { true } else { Math::method18(v166) };
                        let v173: string = if v166 {
                            Math::method19(0.01_f64)
                        } else {
                            Math::method26(v165, 0.01_f64)
                        };
                        let v201: string = append(
                            string("__assert_lt "),
                            (if v166 {
                                Math::method19(0.01_f64)
                            } else {
                                Math::method26(v165, 0.01_f64)
                            }),
                        );
                        let v245: () = {
                            Math::closure2(v201.clone(), ());
                            ()
                        };
                        if (v168) == false {
                            panic!("{}", v201,);
                        }
                        {
                            let v259: f64 = v159.im;
                            let v260: bool = (v259) < 0.01_f64;
                            let v262: bool = if v260 { true } else { Math::method18(v260) };
                            let v267: string = if v260 {
                                Math::method19(0.01_f64)
                            } else {
                                Math::method26(v259, 0.01_f64)
                            };
                            let v289: string = append(
                                string("__assert_lt "),
                                (if v260 {
                                    Math::method19(0.01_f64)
                                } else {
                                    Math::method26(v259, 0.01_f64)
                                }),
                            );
                            let v333: () = {
                                Math::closure2(v289.clone(), ());
                                ()
                            };
                            if (v262) == false {
                                panic!("{}", v289,);
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
                                continue '_method62;
                            }
                        }
                    }
                });
            }
        }
        pub fn method59(v0_1: pyo3::Python) {
            let v1_1: LrcPtr<Math::UH0> = Math::method60();
            Math::method62(v0_1, Math::method61(), v1_1)
        }
        pub fn method58() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method59(py);
                {
                    let v24: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v28: string = string("}}");
                    let v30: string = string("{");
                    let v35: bool = true;
                    let _fix_closure_v32 = v24;
                    let v41: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v32 "), (v28))),
                                string("); "),
                            )),
                            (v30),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v42: bool = true;
                    _fix_closure_v32
                }
            });
            {
                // rust.fix_closure';
                let v44: Result<(), pyo3::PyErr> = __run_test;
                v44.unwrap();
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
            Math::method30();
        } /* /*;
        {
        let v12: string =
        string("*/ #[test] fn test_trivial_zero_at_negative_even___() { //");
        let v13: bool =
         */
        #[test]
        fn test_trivial_zero_at_negative_even___() {
            //;
            Math::method32();
        } /* /*;
        {
        let v16: string =
        string("*/ #[test] fn test_non_trivial_zero___() { //");
        let v17: bool =
         */
        #[test]
        fn test_non_trivial_zero___() {
            //;
            Math::method36();
        } /* /*;
        {
        let v20: string =
        string("*/ #[test] fn test_real_part_greater_than_one___() { //");
        let v21: bool =
         */
        #[test]
        fn test_real_part_greater_than_one___() {
            //;
            Math::method38();
        } /* /*;
        {
        let v24: string =
        string("*/ #[test] fn test_zeta_at_1___() { //");
        let v25: bool =
         */
        #[test]
        fn test_zeta_at_1___() {
            //;
            Math::method40();
        } /* /*;
        {
        let v28: string =
        string("*/ #[test] fn test_symmetry_across_real_axis___() { //");
        let v29: bool =
         */
        #[test]
        fn test_symmetry_across_real_axis___() {
            //;
            Math::method42();
        } /* /*;
        {
        let v32: string =
        string("*/ #[test] fn test_behavior_near_origin___() { //");
        let v33: bool =
         */
        #[test]
        fn test_behavior_near_origin___() {
            //;
            Math::method44();
        } /* /*;
        {
        let v36: string =
        string("*/ #[test] fn test_imaginary_axis() { //");
        let v37: bool =
         */
        #[test]
        fn test_imaginary_axis() {
            //;
            Math::method46();
        } /* /*;
        {
        let v40: string =
        string("*/ #[test] fn test_critical_strip() { //");
        let v41: bool =
         */
        #[test]
        fn test_critical_strip() {
            //;
            Math::method50();
        } /* /*;
        {
        let v44: string =
        string("*/ #[test] fn test_reflection_formula_for_specific_value() { //");
        let v45: bool =
         */
        #[test]
        fn test_reflection_formula_for_specific_value() {
            //;
            Math::method54();
        } /* /*;
        {
        let v48: string =
        string("*/ #[test] fn test_euler_product_formula() { //");
        let v49: bool =
         */
        #[test]
        fn test_euler_product_formula() {
            //;
            Math::method58();
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
            let v34: () = {
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
