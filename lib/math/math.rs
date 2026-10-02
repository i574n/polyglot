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
mod module_b7a9935b {
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
                let v27: string =
                    append((append((v0_1[v8].clone()), (matchValue_1))), (matchValue));
                let v38: i32 = (v5) + 1_i32;
                v3.l0.set(v38);
                v3.l1.set(v27);
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
            let v56: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v2.clone().re, v2.im))));
            let v67: pyo3::Python = Math::method7(v0_1);
            let v244: &str = &*v36;
            let v861: std::string::String = String::from(v244);
            let v1303: std::ffi::CString = std::ffi::CString::new(v861).unwrap();
            let v1481: &str = &*string("");
            let v2098: std::string::String = String::from(v1481);
            let v2540: std::ffi::CString = std::ffi::CString::new(v2098).unwrap();
            let v2542: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code(v67, &v1303, &v2540, &v2540);
            let v2544: bool = true;
            let _result_map_error__ = v2542.map_err(|x| {
                //;
                let v2546: pyo3::PyErr = x;
                let v2575: std::string::String = format!("{}", v2546);
                let v2647: bool = true;
                v2575
            });
            let v2649: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                _result_map_error__;
            let v2651: pyo3::Bound<pyo3::types::PyModule> = v2649.unwrap();
            let v2652: string = Math::method8();
            let v2829: &str = &*v2652;
            let v3270: pyo3::Bound<pyo3::types::PyModule> = Math::method9(v2651);
            let v3272: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v3270.getattr(v2829);
            let v3274: bool = true;
            let _result_map_error__ = v3272.map_err(|x| {
                //;
                let v3276: pyo3::PyErr = x;
                let v3305: std::string::String = format!("{}", v3276);
                let v3377: bool = true;
                v3305
            });
            let v3379: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v3381: pyo3::Bound<pyo3::PyAny> = v3379.unwrap();
            let v3382: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method10(v56.0.clone(), v56.1.clone());
            let v3383: pyo3::Bound<pyo3::PyAny> = Math::method11(v3381);
            let v3385: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                pyo3::prelude::PyAnyMethods::call(&v3383, ((*v3382).0, *(*v3382).1), None);
            let v3387: bool = true;
            let _result_map_error__ = v3385.map_err(|x| {
                //;
                let v3389: pyo3::PyErr = x;
                let v3418: std::string::String = format!("{}", v3389);
                let v3490: bool = true;
                v3418
            });
            let v3492: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v3495: pyo3::Bound<pyo3::PyAny> = Math::method12(v3492?);
            let v3497: Result<(f64, f64), pyo3::PyErr> = v3495.extract();
            let v3499: bool = true;
            let _result_map_error__ = v3497.map_err(|x| {
                //;
                let v3501: pyo3::PyErr = x;
                let v3530: std::string::String = format!("{}", v3501);
                let v3602: bool = true;
                v3530
            });
            let v3604: Result<(f64, f64), std::string::String> = _result_map_error__;
            let patternInput: (f64, f64) = v3604?;
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
            let v56: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v2.clone().re, v2.im))));
            let v67: pyo3::Python = Math::method7(v0_1);
            let v244: &str = &*v36;
            let v861: std::string::String = String::from(v244);
            let v1303: std::ffi::CString = std::ffi::CString::new(v861).unwrap();
            let v1481: &str = &*string("");
            let v2098: std::string::String = String::from(v1481);
            let v2540: std::ffi::CString = std::ffi::CString::new(v2098).unwrap();
            let v2542: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code(v67, &v1303, &v2540, &v2540);
            let v2544: bool = true;
            let _result_map_error__ = v2542.map_err(|x| {
                //;
                let v2546: pyo3::PyErr = x;
                let v2575: std::string::String = format!("{}", v2546);
                let v2647: bool = true;
                v2575
            });
            let v2649: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                _result_map_error__;
            let v2651: pyo3::Bound<pyo3::types::PyModule> = v2649.unwrap();
            let v2652: string = Math::method8();
            let v2829: &str = &*v2652;
            let v3270: pyo3::Bound<pyo3::types::PyModule> = Math::method9(v2651);
            let v3272: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v3270.getattr(v2829);
            let v3274: bool = true;
            let _result_map_error__ = v3272.map_err(|x| {
                //;
                let v3276: pyo3::PyErr = x;
                let v3305: std::string::String = format!("{}", v3276);
                let v3377: bool = true;
                v3305
            });
            let v3379: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v3381: pyo3::Bound<pyo3::PyAny> = v3379.unwrap();
            let v3382: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method10(v56.0.clone(), v56.1.clone());
            let v3383: pyo3::Bound<pyo3::PyAny> = Math::method11(v3381);
            let v3385: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                pyo3::prelude::PyAnyMethods::call(&v3383, ((*v3382).0, *(*v3382).1), None);
            let v3387: bool = true;
            let _result_map_error__ = v3385.map_err(|x| {
                //;
                let v3389: pyo3::PyErr = x;
                let v3418: std::string::String = format!("{}", v3389);
                let v3490: bool = true;
                v3418
            });
            let v3492: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v3495: pyo3::Bound<pyo3::PyAny> = Math::method12(v3492?);
            let v3497: Result<(f64, f64), pyo3::PyErr> = v3495.extract();
            let v3499: bool = true;
            let _result_map_error__ = v3497.map_err(|x| {
                //;
                let v3501: pyo3::PyErr = x;
                let v3530: std::string::String = format!("{}", v3501);
                let v3602: bool = true;
                v3530
            });
            let v3604: Result<(f64, f64), std::string::String> = _result_map_error__;
            let patternInput: (f64, f64) = v3604?;
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
                        let v24: f64 = v18 as f64;
                        let v36: num_complex::Complex<f64> =
                            num_complex::Complex::new(v24, 0.0_f64);
                        let v38: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v36, v1_1.clone());
                        let v40: num_complex::Complex<f64> = v20 / v38;
                        let v42: num_complex::Complex<f64> = v17 + v40;
                        let v43: i32 = (v16) + 1_i32;
                        v14.l0.set(v43);
                        v14.l1.set(v42);
                        ()
                    }
                    v14.l1.get().clone()
                }
            } else {
                let v46: num_complex::Complex<f64> = num_complex::Complex::new(1.0_f64, 0.0_f64);
                let v51: Result<num_complex::Complex<f64>, std::string::String> = Math::method16(
                    v0_1.clone(),
                    string("        s = mpmath.gamma(s)"),
                    Math::method3(v46 - v1_1.clone()),
                );
                let v56: Option<num_complex::Complex<f64>> = v51.ok();
                let v184: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v56));
                let v197: f64 = f64::NAN;
                let v199: f64 = f64::NAN;
                let v201: num_complex::Complex<f64> = num_complex::Complex::new(v197, v199);
                let v204: num_complex::Complex<f64> = match &v184 {
                    Math::US0::US0_0(v184_0_0) => match &v184 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v201.clone(),
                };
                let v206: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v208: num_complex::Complex<f64> = v206 * v1_1.clone();
                let v210: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v212: num_complex::Complex<f64> = v208 / v210;
                let v214: num_complex::Complex<f64> = v212.sin();
                let v217: f64 = 1.0_f64 - (v1_1.clone().re);
                let v220: f64 = -v1_1.clone().im;
                let v222: num_complex::Complex<f64> = num_complex::Complex::new(v217, v220);
                let v1196: num_complex::Complex<f64> = if (v222.clone().re) <= 1.0_f64 {
                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                } else {
                    println!("zeta / count: {:?} / s: {:?}", 1_i32, v222.clone());
                    if (v222.clone().re) > 1.0_f64 {
                        let v233: num_complex::Complex<f64> =
                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                        let v234: Array<i32> = new_init(&0_i32, 10000_i32);
                        let v235: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                            l0: MutCell::new(0_i32),
                        });
                        while Math::method14(v235.clone()) {
                            let v237: i32 = v235.l0.get().clone();
                            v234.get_mut()[v237 as usize] = v237;
                            {
                                let v238: i32 = (v237) + 1_i32;
                                v235.l0.set(v238);
                                ()
                            }
                        }
                        {
                            let v239: i32 = get_Count(v234.clone());
                            let v240: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                l0: MutCell::new(0_i32),
                                l1: MutCell::new(v233),
                            });
                            while Math::method15(v239, v240.clone()) {
                                let v242: i32 = v240.l0.get().clone();
                                let v243: num_complex::Complex<f64> = v240.l1.get().clone();
                                let v244: i32 = v234[v242].clone();
                                let v246: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v250: f64 = v244 as f64;
                                let v262: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v250, 0.0_f64);
                                let v264: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v262, v222.clone());
                                let v266: num_complex::Complex<f64> = v246 / v264;
                                let v268: num_complex::Complex<f64> = v243 + v266;
                                let v269: i32 = (v242) + 1_i32;
                                v240.l0.set(v269);
                                v240.l1.set(v268);
                                ()
                            }
                            v240.l1.get().clone()
                        }
                    } else {
                        let v272: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v277: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method16(
                                v0_1.clone(),
                                string("        s = mpmath.gamma(s)"),
                                Math::method3(v272 - v222.clone()),
                            );
                        let v282: Option<num_complex::Complex<f64>> = v277.ok();
                        let v410: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v282));
                        let v423: f64 = f64::NAN;
                        let v425: f64 = f64::NAN;
                        let v427: num_complex::Complex<f64> = num_complex::Complex::new(v423, v425);
                        let v430: num_complex::Complex<f64> = match &v410 {
                            Math::US0::US0_0(v410_0_0) => match &v410 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v427.clone(),
                        };
                        let v432: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v434: num_complex::Complex<f64> = v432 * v222.clone();
                        let v436: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v438: num_complex::Complex<f64> = v434 / v436;
                        let v440: num_complex::Complex<f64> = v438.sin();
                        let v443: f64 = 1.0_f64 - (v222.clone().re);
                        let v446: f64 = -v222.clone().im;
                        let v448: num_complex::Complex<f64> = num_complex::Complex::new(v443, v446);
                        let v1180: num_complex::Complex<f64> = if (v448.clone().re) <= 1.0_f64 {
                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                        } else {
                            println!("zeta / count: {:?} / s: {:?}", 2_i32, v448.clone());
                            if (v448.clone().re) > 1.0_f64 {
                                let v459: num_complex::Complex<f64> =
                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                let v460: Array<i32> = new_init(&0_i32, 10000_i32);
                                let v461: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Math::method14(v461.clone()) {
                                    let v463: i32 = v461.l0.get().clone();
                                    v460.get_mut()[v463 as usize] = v463;
                                    {
                                        let v464: i32 = (v463) + 1_i32;
                                        v461.l0.set(v464);
                                        ()
                                    }
                                }
                                {
                                    let v465: i32 = get_Count(v460.clone());
                                    let v466: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                        l0: MutCell::new(0_i32),
                                        l1: MutCell::new(v459),
                                    });
                                    while Math::method15(v465, v466.clone()) {
                                        let v468: i32 = v466.l0.get().clone();
                                        let v469: num_complex::Complex<f64> = v466.l1.get().clone();
                                        let v470: i32 = v460[v468].clone();
                                        let v472: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v476: f64 = v470 as f64;
                                        let v488: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v476, 0.0_f64);
                                        let v490: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v488, v448.clone());
                                        let v492: num_complex::Complex<f64> = v472 / v490;
                                        let v494: num_complex::Complex<f64> = v469 + v492;
                                        let v495: i32 = (v468) + 1_i32;
                                        v466.l0.set(v495);
                                        v466.l1.set(v494);
                                        ()
                                    }
                                    v466.l1.get().clone()
                                }
                            } else {
                                let v498: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v503: Result<num_complex::Complex<f64>, std::string::String> =
                                    Math::method16(
                                        v0_1.clone(),
                                        string("        s = mpmath.gamma(s)"),
                                        Math::method3(v498 - v448.clone()),
                                    );
                                let v508: Option<num_complex::Complex<f64>> = v503.ok();
                                let v636: Math::US0 =
                                    defaultValue(Math::US0::US0_1, map(Math::method17(), v508));
                                let v649: f64 = f64::NAN;
                                let v651: f64 = f64::NAN;
                                let v653: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v649, v651);
                                let v656: num_complex::Complex<f64> = match &v636 {
                                    Math::US0::US0_0(v636_0_0) => match &v636 {
                                        Math::US0::US0_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                    _ => v653.clone(),
                                };
                                let v658: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v660: num_complex::Complex<f64> = v658 * v448.clone();
                                let v662: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v664: num_complex::Complex<f64> = v660 / v662;
                                let v666: num_complex::Complex<f64> = v664.sin();
                                let v669: f64 = 1.0_f64 - (v448.clone().re);
                                let v672: f64 = -v448.clone().im;
                                let v674: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v669, v672);
                                let v1164: num_complex::Complex<f64> = if (v674.clone().re)
                                    <= 1.0_f64
                                {
                                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                                } else {
                                    println!("zeta / count: {:?} / s: {:?}", 3_i32, v674.clone());
                                    if (v674.clone().re) > 1.0_f64 {
                                        let v685: num_complex::Complex<f64> =
                                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                                        let v686: Array<i32> = new_init(&0_i32, 10000_i32);
                                        let v687: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                            l0: MutCell::new(0_i32),
                                        });
                                        while Math::method14(v687.clone()) {
                                            let v689: i32 = v687.l0.get().clone();
                                            v686.get_mut()[v689 as usize] = v689;
                                            {
                                                let v690: i32 = (v689) + 1_i32;
                                                v687.l0.set(v690);
                                                ()
                                            }
                                        }
                                        {
                                            let v691: i32 = get_Count(v686.clone());
                                            let v692: LrcPtr<Math::Mut2> =
                                                LrcPtr::new(Math::Mut2 {
                                                    l0: MutCell::new(0_i32),
                                                    l1: MutCell::new(v685),
                                                });
                                            while Math::method15(v691, v692.clone()) {
                                                let v694: i32 = v692.l0.get().clone();
                                                let v695: num_complex::Complex<f64> =
                                                    v692.l1.get().clone();
                                                let v696: i32 = v686[v694].clone();
                                                let v698: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v702: f64 = v696 as f64;
                                                let v714: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v702, 0.0_f64);
                                                let v716: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v714, v674.clone());
                                                let v718: num_complex::Complex<f64> = v698 / v716;
                                                let v720: num_complex::Complex<f64> = v695 + v718;
                                                let v721: i32 = (v694) + 1_i32;
                                                v692.l0.set(v721);
                                                v692.l1.set(v720);
                                                ()
                                            }
                                            v692.l1.get().clone()
                                        }
                                    } else {
                                        let v724: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v729: Result<
                                            num_complex::Complex<f64>,
                                            std::string::String,
                                        > = Math::method16(
                                            v0_1.clone(),
                                            string("        s = mpmath.gamma(s)"),
                                            Math::method3(v724 - v674.clone()),
                                        );
                                        let v734: Option<num_complex::Complex<f64>> = v729.ok();
                                        let v862: Math::US0 = defaultValue(
                                            Math::US0::US0_1,
                                            map(Math::method17(), v734),
                                        );
                                        let v875: f64 = f64::NAN;
                                        let v877: f64 = f64::NAN;
                                        let v879: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v875, v877);
                                        let v882: num_complex::Complex<f64> = match &v862 {
                                            Math::US0::US0_0(v862_0_0) => match &v862 {
                                                Math::US0::US0_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                            _ => v879.clone(),
                                        };
                                        let v884: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v886: num_complex::Complex<f64> = v884 * v674.clone();
                                        let v888: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v890: num_complex::Complex<f64> = v886 / v888;
                                        let v892: num_complex::Complex<f64> = v890.sin();
                                        let v895: f64 = 1.0_f64 - (v674.clone().re);
                                        let v898: f64 = -v674.clone().im;
                                        let v900: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v895, v898);
                                        let v1148: num_complex::Complex<f64> = if (v900.clone().re)
                                            <= 1.0_f64
                                        {
                                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                                        } else {
                                            println!(
                                                "zeta / count: {:?} / s: {:?}",
                                                4_i32,
                                                v900.clone()
                                            );
                                            if (v900.clone().re) > 1.0_f64 {
                                                let v911: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                                let v912: Array<i32> = new_init(&0_i32, 10000_i32);
                                                let v913: LrcPtr<Math::Mut0> =
                                                    LrcPtr::new(Math::Mut0 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Math::method14(v913.clone()) {
                                                    let v915: i32 = v913.l0.get().clone();
                                                    v912.get_mut()[v915 as usize] = v915;
                                                    {
                                                        let v916: i32 = (v915) + 1_i32;
                                                        v913.l0.set(v916);
                                                        ()
                                                    }
                                                }
                                                {
                                                    let v917: i32 = get_Count(v912.clone());
                                                    let v918: LrcPtr<Math::Mut2> =
                                                        LrcPtr::new(Math::Mut2 {
                                                            l0: MutCell::new(0_i32),
                                                            l1: MutCell::new(v911),
                                                        });
                                                    while Math::method15(v917, v918.clone()) {
                                                        let v920: i32 = v918.l0.get().clone();
                                                        let v921: num_complex::Complex<f64> =
                                                            v918.l1.get().clone();
                                                        let v922: i32 = v912[v920].clone();
                                                        let v924: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                1.0_f64, 0.0_f64,
                                                            );
                                                        let v928: f64 = v922 as f64;
                                                        let v940: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                v928, 0.0_f64,
                                                            );
                                                        let v942: num_complex::Complex<f64> =
                                                            num_complex::Complex::powc(
                                                                v940,
                                                                v900.clone(),
                                                            );
                                                        let v944: num_complex::Complex<f64> =
                                                            v924 / v942;
                                                        let v946: num_complex::Complex<f64> =
                                                            v921 + v944;
                                                        let v947: i32 = (v920) + 1_i32;
                                                        v918.l0.set(v947);
                                                        v918.l1.set(v946);
                                                        ()
                                                    }
                                                    v918.l1.get().clone()
                                                }
                                            } else {
                                                let v950: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v955: Result<
                                                    num_complex::Complex<f64>,
                                                    std::string::String,
                                                > = Math::method16(
                                                    v0_1,
                                                    string("        s = mpmath.gamma(s)"),
                                                    Math::method3(v950 - v900.clone()),
                                                );
                                                let v960: Option<num_complex::Complex<f64>> =
                                                    v955.ok();
                                                let v1088: Math::US0 = defaultValue(
                                                    Math::US0::US0_1,
                                                    map(Math::method17(), v960),
                                                );
                                                let v1101: f64 = f64::NAN;
                                                let v1103: f64 = f64::NAN;
                                                let v1105: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v1101, v1103);
                                                let v1108: num_complex::Complex<f64> = match &v1088
                                                {
                                                    Math::US0::US0_0(v1088_0_0) => match &v1088 {
                                                        Math::US0::US0_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                    _ => v1105.clone(),
                                                };
                                                let v1110: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(
                                                        3.141592653589793_f64,
                                                        0.0_f64,
                                                    );
                                                let v1112: num_complex::Complex<f64> =
                                                    v1110 * v900.clone();
                                                let v1114: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                let v1116: num_complex::Complex<f64> =
                                                    v1112 / v1114;
                                                let v1118: num_complex::Complex<f64> = v1116.sin();
                                                let v1121: f64 = 1.0_f64 - (v900.clone().re);
                                                let v1124: f64 = -v900.clone().im;
                                                let v1126: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v1121, v1124);
                                                let v1132: num_complex::Complex<f64> =
                                                    if (v1126.clone().re) <= 1.0_f64 {
                                                        num_complex::Complex::new(0.0_f64, 0.0_f64)
                                                    } else {
                                                        v1126
                                                    };
                                                let v1134: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                let v1136: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(
                                                        3.141592653589793_f64,
                                                        0.0_f64,
                                                    );
                                                let v1138: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v1136, v900.clone());
                                                let v1140: num_complex::Complex<f64> =
                                                    v1134 * v1138;
                                                let v1142: num_complex::Complex<f64> =
                                                    v1140 * v1118;
                                                let v1144: num_complex::Complex<f64> =
                                                    v1142 * v1108;
                                                v1144 * v1132
                                            }
                                        };
                                        let v1150: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v1152: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v1154: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v1152, v674.clone());
                                        let v1156: num_complex::Complex<f64> = v1150 * v1154;
                                        let v1158: num_complex::Complex<f64> = v1156 * v892;
                                        let v1160: num_complex::Complex<f64> = v1158 * v882;
                                        v1160 * v1148
                                    }
                                };
                                let v1166: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v1168: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v1170: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v1168, v448.clone());
                                let v1172: num_complex::Complex<f64> = v1166 * v1170;
                                let v1174: num_complex::Complex<f64> = v1172 * v666;
                                let v1176: num_complex::Complex<f64> = v1174 * v656;
                                v1176 * v1164
                            }
                        };
                        let v1182: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v1184: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v1186: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v1184, v222.clone());
                        let v1188: num_complex::Complex<f64> = v1182 * v1186;
                        let v1190: num_complex::Complex<f64> = v1188 * v440;
                        let v1192: num_complex::Complex<f64> = v1190 * v430;
                        v1192 * v1180
                    }
                };
                let v1198: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v1200: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v1202: num_complex::Complex<f64> =
                    num_complex::Complex::powc(v1200, v1_1.clone());
                let v1204: num_complex::Complex<f64> = v1198 * v1202;
                let v1206: num_complex::Complex<f64> = v1204 * v214;
                let v1208: num_complex::Complex<f64> = v1206 * v204;
                v1208 * v1196
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
            let v11: LrcPtr<Math::Mut3> = LrcPtr::new(Math::Mut3 {
                l0: MutCell::new(Math::method20()),
            });
            Math::method21(v11.clone());
            Math::method22(v11.clone());
            Math::method23(v11.clone());
            Math::method24(v11.clone(), sprintf!("{:+.6}", v0_1));
            Math::method25(v11.clone());
            v11.l0.get().clone()
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
            let v12: LrcPtr<Math::Mut3> = LrcPtr::new(Math::Mut3 {
                l0: MutCell::new(Math::method20()),
            });
            Math::method21(v12.clone());
            Math::method27(v12.clone());
            Math::method23(v12.clone());
            Math::method24(v12.clone(), sprintf!("{:+.6}", v0_1));
            Math::method28(v12.clone());
            Math::method22(v12.clone());
            Math::method23(v12.clone());
            Math::method24(v12.clone(), sprintf!("{:+.6}", v1_1));
            Math::method25(v12.clone());
            v12.l0.get().clone()
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
                let v148: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v20));
                let v161: f64 = f64::NAN;
                let v163: f64 = f64::NAN;
                let v165: num_complex::Complex<f64> = num_complex::Complex::new(v161, v163);
                let v168: num_complex::Complex<f64> = match &v148 {
                    Math::US0::US0_0(v148_0_0) => match &v148 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v165.clone(),
                };
                let v170: f64 = v168.clone().im;
                let v171: bool = (v170) == 0.0_f64;
                let v173: bool = if v171 { true } else { Math::method18(v171) };
                let v178: string = if v171 {
                    Math::method19(0.0_f64)
                } else {
                    Math::method26(v170, 0.0_f64)
                };
                let v205: string = append(
                    string("__assert_eq "),
                    (if v171 {
                        Math::method19(0.0_f64)
                    } else {
                        Math::method26(v170, 0.0_f64)
                    }),
                );
                let v220: () = {
                    Math::closure2(v205.clone(), ());
                    ()
                };
                if (v173) == false {
                    panic!("{}", v205,);
                }
                {
                    let v233: f64 = (v168.re) - (patternInput.1.clone());
                    let v234: f64 = -v233;
                    let v236: f64 = if (v233) >= (v234) { v233 } else { v234 };
                    let v237: bool = (v236) < 0.0001_f64;
                    let v239: bool = if v237 { true } else { Math::method18(v237) };
                    let v244: string = if v237 {
                        Math::method19(0.0001_f64)
                    } else {
                        Math::method26(v236, 0.0001_f64)
                    };
                    let v268: string = append(
                        string("__assert_lt "),
                        (if v237 {
                            Math::method19(0.0001_f64)
                        } else {
                            Math::method26(v236, 0.0001_f64)
                        }),
                    );
                    let v283: () = {
                        Math::closure2(v268.clone(), ());
                        ()
                    };
                    if (v239) == false {
                        panic!("{}", v268,);
                    }
                    {
                        let v294: i32 = (v9) + 1_i32;
                        v7.l0.set(v294);
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
                    let v17: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v21: string = string("}}");
                    let v23: string = string("{");
                    let v28: bool = true;
                    let _fix_closure_v25 = v17;
                    let v34: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v25 "), (v21))),
                                string("); "),
                            )),
                            (v23),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v35: bool = true;
                    _fix_closure_v25
                }
            });
            {
                // rust.fix_closure';
                let v37: Result<(), pyo3::PyErr> = __run_test;
                v37.unwrap();
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
            let v139: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v11));
            let v152: f64 = f64::NAN;
            let v154: f64 = f64::NAN;
            let v156: num_complex::Complex<f64> = num_complex::Complex::new(v152, v154);
            let v159: num_complex::Complex<f64> = match &v139 {
                Math::US0::US0_0(v139_0_0) => match &v139 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v156.clone(),
            };
            let v162: f64 = (v159.clone().re) - 0.8673_f64;
            let v163: f64 = -v162;
            let v165: f64 = if (v162) >= (v163) { v162 } else { v163 };
            let v166: bool = (v165) < 0.001_f64;
            let v168: bool = if v166 { true } else { Math::method18(v166) };
            let v173: string = if v166 {
                Math::method19(0.001_f64)
            } else {
                Math::method26(v165, 0.001_f64)
            };
            let v200: string = append(
                string("__assert_lt "),
                (if v166 {
                    Math::method19(0.001_f64)
                } else {
                    Math::method26(v165, 0.001_f64)
                }),
            );
            let v215: () = {
                Math::closure2(v200.clone(), ());
                ()
            };
            if (v168) == false {
                panic!("{}", v200,);
            }
            {
                let v228: f64 = (v159.im) - 0.275_f64;
                let v229: f64 = -v228;
                let v231: f64 = if (v228) >= (v229) { v228 } else { v229 };
                let v232: bool = (v231) < 0.001_f64;
                let v234: bool = if v232 { true } else { Math::method18(v232) };
                let v239: string = if v232 {
                    Math::method19(0.001_f64)
                } else {
                    Math::method26(v231, 0.001_f64)
                };
                let v260: string = append(
                    string("__assert_lt "),
                    (if v232 {
                        Math::method19(0.001_f64)
                    } else {
                        Math::method26(v231, 0.001_f64)
                    }),
                );
                let v275: () = {
                    Math::closure2(v260.clone(), ());
                    ()
                };
                if (v234) == false {
                    panic!("{}", v260,);
                }
            }
        }
        pub fn method30() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method31(py);
                {
                    let v17: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v21: string = string("}}");
                    let v23: string = string("{");
                    let v28: bool = true;
                    let _fix_closure_v25 = v17;
                    let v34: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v25 "), (v21))),
                                string("); "),
                            )),
                            (v23),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v35: bool = true;
                    _fix_closure_v25
                }
            });
            {
                // rust.fix_closure';
                let v37: Result<(), pyo3::PyErr> = __run_test;
                v37.unwrap();
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
                        let v142: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v14));
                        let v155: f64 = f64::NAN;
                        let v157: f64 = f64::NAN;
                        let v159: num_complex::Complex<f64> = num_complex::Complex::new(v155, v157);
                        let v162: num_complex::Complex<f64> = match &v142 {
                            Math::US0::US0_0(v142_0_0) => match &v142 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v159.clone(),
                        };
                        let v164: f64 = v162.clone().re;
                        let v165: bool = (v164) == 0.0_f64;
                        let v167: bool = if v165 { true } else { Math::method18(v165) };
                        let v172: string = if v165 {
                            Math::method19(0.0_f64)
                        } else {
                            Math::method26(v164, 0.0_f64)
                        };
                        let v199: string = append(
                            string("__assert_eq "),
                            (if v165 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v164, 0.0_f64)
                            }),
                        );
                        let v214: () = {
                            Math::closure2(v199.clone(), ());
                            ()
                        };
                        if (v167) == false {
                            panic!("{}", v199,);
                        }
                        {
                            let v226: f64 = v162.im;
                            let v227: bool = (v226) == 0.0_f64;
                            let v229: bool = if v227 { true } else { Math::method18(v227) };
                            let v234: string = if v227 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v226, 0.0_f64)
                            };
                            let v255: string = append(
                                string("__assert_eq "),
                                (if v227 {
                                    Math::method19(0.0_f64)
                                } else {
                                    Math::method26(v226, 0.0_f64)
                                }),
                            );
                            let v270: () = {
                                Math::closure2(v255.clone(), ());
                                ()
                            };
                            if (v229) == false {
                                panic!("{}", v255,);
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
                    let v17: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v21: string = string("}}");
                    let v23: string = string("{");
                    let v28: bool = true;
                    let _fix_closure_v25 = v17;
                    let v34: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v25 "), (v21))),
                                string("); "),
                            )),
                            (v23),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v35: bool = true;
                    _fix_closure_v25
                }
            });
            {
                // rust.fix_closure';
                let v37: Result<(), pyo3::PyErr> = __run_test;
                v37.unwrap();
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
                let v155: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v27));
                let v168: f64 = f64::NAN;
                let v170: f64 = f64::NAN;
                let v172: num_complex::Complex<f64> = num_complex::Complex::new(v168, v170);
                let v175: num_complex::Complex<f64> = match &v155 {
                    Math::US0::US0_0(v155_0_0) => match &v155 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v172.clone(),
                };
                let v177: f64 = v175.clone().re;
                let v178: f64 = -v177;
                let v180: f64 = if (v177) >= (v178) { v177 } else { v178 };
                let v181: bool = (v180) < 0.0001_f64;
                let v183: bool = if v181 { true } else { Math::method18(v181) };
                let v188: string = if v181 {
                    Math::method19(0.0001_f64)
                } else {
                    Math::method26(v180, 0.0001_f64)
                };
                let v215: string = append(
                    string("__assert_lt "),
                    (if v181 {
                        Math::method19(0.0001_f64)
                    } else {
                        Math::method26(v180, 0.0001_f64)
                    }),
                );
                let v230: () = {
                    Math::closure2(v215.clone(), ());
                    ()
                };
                if (v183) == false {
                    panic!("{}", v215,);
                }
                {
                    let v242: f64 = v175.im;
                    let v243: f64 = -v242;
                    let v245: f64 = if (v242) >= (v243) { v242 } else { v243 };
                    let v246: bool = (v245) < 0.0001_f64;
                    let v248: bool = if v246 { true } else { Math::method18(v246) };
                    let v253: string = if v246 {
                        Math::method19(0.0001_f64)
                    } else {
                        Math::method26(v245, 0.0001_f64)
                    };
                    let v274: string = append(
                        string("__assert_lt "),
                        (if v246 {
                            Math::method19(0.0001_f64)
                        } else {
                            Math::method26(v245, 0.0001_f64)
                        }),
                    );
                    let v289: () = {
                        Math::closure2(v274.clone(), ());
                        ()
                    };
                    if (v248) == false {
                        panic!("{}", v274,);
                    }
                    {
                        let v300: i32 = (v17) + 1_i32;
                        v15.l0.set(v300);
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
                    let v17: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v21: string = string("}}");
                    let v23: string = string("{");
                    let v28: bool = true;
                    let _fix_closure_v25 = v17;
                    let v34: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v25 "), (v21))),
                                string("); "),
                            )),
                            (v23),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v35: bool = true;
                    _fix_closure_v25
                }
            });
            {
                // rust.fix_closure';
                let v37: Result<(), pyo3::PyErr> = __run_test;
                v37.unwrap();
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
                let v145: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v17));
                let v158: f64 = f64::NAN;
                let v160: f64 = f64::NAN;
                let v162: num_complex::Complex<f64> = num_complex::Complex::new(v158, v160);
                let v165: num_complex::Complex<f64> = match &v145 {
                    Math::US0::US0_0(v145_0_0) => match &v145 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v162.clone(),
                };
                let v167: f64 = v165.clone().re;
                let v168: bool = (v167) > 0.0_f64;
                let v170: bool = if v168 { true } else { Math::method18(v168) };
                let v175: string = if v168 {
                    Math::method19(0.0_f64)
                } else {
                    Math::method26(v167, 0.0_f64)
                };
                let v202: string = append(
                    string("__assert_gt "),
                    (if v168 {
                        Math::method19(0.0_f64)
                    } else {
                        Math::method26(v167, 0.0_f64)
                    }),
                );
                let v217: () = {
                    Math::closure2(v202.clone(), ());
                    ()
                };
                if (v170) == false {
                    panic!("{}", v202,);
                }
                {
                    let v229: f64 = v165.im;
                    let v230: bool = (v229) == 0.0_f64;
                    let v232: bool = if v230 { true } else { Math::method18(v230) };
                    let v237: string = if v230 {
                        Math::method19(0.0_f64)
                    } else {
                        Math::method26(v229, 0.0_f64)
                    };
                    let v261: string = append(
                        string("__assert_eq "),
                        (if v230 {
                            Math::method19(0.0_f64)
                        } else {
                            Math::method26(v229, 0.0_f64)
                        }),
                    );
                    let v276: () = {
                        Math::closure2(v261.clone(), ());
                        ()
                    };
                    if (v232) == false {
                        panic!("{}", v261,);
                    }
                    {
                        let v287: i32 = (v5) + 1_i32;
                        v3.l0.set(v287);
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
                    let v17: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v21: string = string("}}");
                    let v23: string = string("{");
                    let v28: bool = true;
                    let _fix_closure_v25 = v17;
                    let v34: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v25 "), (v21))),
                                string("); "),
                            )),
                            (v23),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v35: bool = true;
                    _fix_closure_v25
                }
            });
            {
                // rust.fix_closure';
                let v37: Result<(), pyo3::PyErr> = __run_test;
                v37.unwrap();
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
            let v139: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v11));
            let v152: f64 = f64::NAN;
            let v154: f64 = f64::NAN;
            let v156: num_complex::Complex<f64> = num_complex::Complex::new(v152, v154);
            let v159: num_complex::Complex<f64> = match &v139 {
                Math::US0::US0_0(v139_0_0) => match &v139 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v156.clone(),
            };
            let v161: f64 = v159.clone().re;
            let v162: bool = (v161) == (f64::INFINITY);
            let v164: bool = if v162 { true } else { Math::method18(v162) };
            let v169: string = if v162 {
                Math::method19(f64::INFINITY)
            } else {
                Math::method26(v161, f64::INFINITY)
            };
            let v196: string = append(
                string("__assert_eq "),
                (if v162 {
                    Math::method19(f64::INFINITY)
                } else {
                    Math::method26(v161, f64::INFINITY)
                }),
            );
            let v211: () = {
                Math::closure2(v196.clone(), ());
                ()
            };
            if (v164) == false {
                panic!("{}", v196,);
            }
            {
                let v223: f64 = v159.im;
                let v224: bool = (v223) == 0.0_f64;
                let v226: bool = if v224 { true } else { Math::method18(v224) };
                let v231: string = if v224 {
                    Math::method19(0.0_f64)
                } else {
                    Math::method26(v223, 0.0_f64)
                };
                let v252: string = append(
                    string("__assert_eq "),
                    (if v224 {
                        Math::method19(0.0_f64)
                    } else {
                        Math::method26(v223, 0.0_f64)
                    }),
                );
                let v267: () = {
                    Math::closure2(v252.clone(), ());
                    ()
                };
                if (v226) == false {
                    panic!("{}", v252,);
                }
            }
        }
        pub fn method40() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method41(py);
                {
                    let v17: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v21: string = string("}}");
                    let v23: string = string("{");
                    let v28: bool = true;
                    let _fix_closure_v25 = v17;
                    let v34: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v25 "), (v21))),
                                string("); "),
                            )),
                            (v23),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v35: bool = true;
                    _fix_closure_v25
                }
            });
            {
                // rust.fix_closure';
                let v37: Result<(), pyo3::PyErr> = __run_test;
                v37.unwrap();
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
            let v139: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v11));
            let v152: f64 = f64::NAN;
            let v154: f64 = f64::NAN;
            let v156: num_complex::Complex<f64> = num_complex::Complex::new(v152, v154);
            let v159: num_complex::Complex<f64> = match &v139 {
                Math::US0::US0_0(v139_0_0) => match &v139 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v156.clone(),
            };
            let v161: f64 = v2.clone().re;
            let v164: f64 = -v2.im;
            let v166: num_complex::Complex<f64> = num_complex::Complex::new(v161, v164);
            let v169: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v166.clone()),
            );
            let v170: num_complex::Complex<f64> = Math::method13(v0_1, v166);
            let v175: Option<num_complex::Complex<f64>> = v169.ok();
            let v303: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v175));
            let v316: f64 = f64::NAN;
            let v318: f64 = f64::NAN;
            let v320: num_complex::Complex<f64> = num_complex::Complex::new(v316, v318);
            let v323: num_complex::Complex<f64> = match &v303 {
                Math::US0::US0_0(v303_0_0) => match &v303 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v320.clone(),
            };
            let v325: num_complex::Complex<f64> = v323.conj();
            let v327: f64 = v159.clone().re;
            let v329: f64 = v325.clone().re;
            let v330: bool = (v327) == (v329);
            let v332: bool = if v330 { true } else { Math::method18(v330) };
            let v335: string = if v330 {
                Math::method19(v329)
            } else {
                Math::method26(v327, v329)
            };
            let v360: string = append(
                string("__assert_eq "),
                (if v330 {
                    Math::method19(v329)
                } else {
                    Math::method26(v327, v329)
                }),
            );
            let v375: () = {
                Math::closure2(v360.clone(), ());
                ()
            };
            if (v332) == false {
                panic!("{}", v360,);
            }
            {
                let v387: f64 = v159.im;
                let v389: f64 = v325.im;
                let v390: bool = (v387) == (v389);
                let v392: bool = if v390 { true } else { Math::method18(v390) };
                let v395: string = if v390 {
                    Math::method19(v389)
                } else {
                    Math::method26(v387, v389)
                };
                let v414: string = append(
                    string("__assert_eq "),
                    (if v390 {
                        Math::method19(v389)
                    } else {
                        Math::method26(v387, v389)
                    }),
                );
                let v429: () = {
                    Math::closure2(v414.clone(), ());
                    ()
                };
                if (v392) == false {
                    panic!("{}", v414,);
                }
            }
        }
        pub fn method42() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method43(py);
                {
                    let v17: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v21: string = string("}}");
                    let v23: string = string("{");
                    let v28: bool = true;
                    let _fix_closure_v25 = v17;
                    let v34: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v25 "), (v21))),
                                string("); "),
                            )),
                            (v23),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v35: bool = true;
                    _fix_closure_v25
                }
            });
            {
                // rust.fix_closure';
                let v37: Result<(), pyo3::PyErr> = __run_test;
                v37.unwrap();
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
            let v139: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v11));
            let v152: f64 = f64::NAN;
            let v154: f64 = f64::NAN;
            let v156: num_complex::Complex<f64> = num_complex::Complex::new(v152, v154);
            let v159: num_complex::Complex<f64> = match &v139 {
                Math::US0::US0_0(v139_0_0) => match &v139 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v156.clone(),
            };
            let v161: f64 = v159.clone().re;
            let v162: bool = (v161) < (f64::INFINITY);
            let v164: bool = if v162 { true } else { Math::method18(v162) };
            let v169: string = if v162 {
                Math::method19(f64::INFINITY)
            } else {
                Math::method26(v161, f64::INFINITY)
            };
            let v196: string = append(
                string("__assert_lt "),
                (if v162 {
                    Math::method19(f64::INFINITY)
                } else {
                    Math::method26(v161, f64::INFINITY)
                }),
            );
            let v211: () = {
                Math::closure2(v196.clone(), ());
                ()
            };
            if (v164) == false {
                panic!("{}", v196,);
            }
            {
                let v223: f64 = v159.im;
                let v224: bool = (v223) < (f64::INFINITY);
                let v226: bool = if v224 { true } else { Math::method18(v224) };
                let v231: string = if v224 {
                    Math::method19(f64::INFINITY)
                } else {
                    Math::method26(v223, f64::INFINITY)
                };
                let v252: string = append(
                    string("__assert_lt "),
                    (if v224 {
                        Math::method19(f64::INFINITY)
                    } else {
                        Math::method26(v223, f64::INFINITY)
                    }),
                );
                let v267: () = {
                    Math::closure2(v252.clone(), ());
                    ()
                };
                if (v226) == false {
                    panic!("{}", v252,);
                }
            }
        }
        pub fn method44() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method45(py);
                {
                    let v17: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v21: string = string("}}");
                    let v23: string = string("{");
                    let v28: bool = true;
                    let _fix_closure_v25 = v17;
                    let v34: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v25 "), (v21))),
                                string("); "),
                            )),
                            (v23),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v35: bool = true;
                    _fix_closure_v25
                }
            });
            {
                // rust.fix_closure';
                let v37: Result<(), pyo3::PyErr> = __run_test;
                v37.unwrap();
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
                        let v142: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v14));
                        let v155: f64 = f64::NAN;
                        let v157: f64 = f64::NAN;
                        let v159: num_complex::Complex<f64> = num_complex::Complex::new(v155, v157);
                        let v162: num_complex::Complex<f64> = match &v142 {
                            Math::US0::US0_0(v142_0_0) => match &v142 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v159.clone(),
                        };
                        let v164: f64 = v162.clone().re;
                        let v167: bool = (v164) != 0.0_f64;
                        let v179: bool = if v167 { true } else { Math::method18(v167) };
                        let v184: string = if v167 {
                            Math::method19(0.0_f64)
                        } else {
                            Math::method26(v164, 0.0_f64)
                        };
                        let v211: string = append(
                            string("__assert_ne "),
                            (if v167 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v164, 0.0_f64)
                            }),
                        );
                        let v226: () = {
                            Math::closure2(v211.clone(), ());
                            ()
                        };
                        if (v179) == false {
                            panic!("{}", v211,);
                        }
                        {
                            let v238: f64 = v162.im;
                            let v241: bool = (v238) != 0.0_f64;
                            let v253: bool = if v241 { true } else { Math::method18(v241) };
                            let v258: string = if v241 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v238, 0.0_f64)
                            };
                            let v279: string = append(
                                string("__assert_ne "),
                                (if v241 {
                                    Math::method19(0.0_f64)
                                } else {
                                    Math::method26(v238, 0.0_f64)
                                }),
                            );
                            let v294: () = {
                                Math::closure2(v279.clone(), ());
                                ()
                            };
                            if (v253) == false {
                                panic!("{}", v279,);
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
                    let v17: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v21: string = string("}}");
                    let v23: string = string("{");
                    let v28: bool = true;
                    let _fix_closure_v25 = v17;
                    let v34: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v25 "), (v21))),
                                string("); "),
                            )),
                            (v23),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v35: bool = true;
                    _fix_closure_v25
                }
            });
            {
                // rust.fix_closure';
                let v37: Result<(), pyo3::PyErr> = __run_test;
                v37.unwrap();
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
                        let v140: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v12));
                        let v153: f64 = f64::NAN;
                        let v155: f64 = f64::NAN;
                        let v157: num_complex::Complex<f64> = num_complex::Complex::new(v153, v155);
                        let v160: num_complex::Complex<f64> = match &v140 {
                            Math::US0::US0_0(v140_0_0) => match &v140 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v157.clone(),
                        };
                        let v162: f64 = v160.clone().re;
                        let v165: bool = (v162) != 0.0_f64;
                        let v177: bool = if v165 { true } else { Math::method18(v165) };
                        let v182: string = if v165 {
                            Math::method19(0.0_f64)
                        } else {
                            Math::method26(v162, 0.0_f64)
                        };
                        let v209: string = append(
                            string("__assert_ne "),
                            (if v165 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v162, 0.0_f64)
                            }),
                        );
                        let v224: () = {
                            Math::closure2(v209.clone(), ());
                            ()
                        };
                        if (v177) == false {
                            panic!("{}", v209,);
                        }
                        {
                            let v236: f64 = v160.im;
                            let v239: bool = (v236) != 0.0_f64;
                            let v251: bool = if v239 { true } else { Math::method18(v239) };
                            let v256: string = if v239 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v236, 0.0_f64)
                            };
                            let v277: string = append(
                                string("__assert_ne "),
                                (if v239 {
                                    Math::method19(0.0_f64)
                                } else {
                                    Math::method26(v236, 0.0_f64)
                                }),
                            );
                            let v292: () = {
                                Math::closure2(v277.clone(), ());
                                ()
                            };
                            if (v251) == false {
                                panic!("{}", v277,);
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
                    let v17: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v21: string = string("}}");
                    let v23: string = string("{");
                    let v28: bool = true;
                    let _fix_closure_v25 = v17;
                    let v34: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v25 "), (v21))),
                                string("); "),
                            )),
                            (v23),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v35: bool = true;
                    _fix_closure_v25
                }
            });
            {
                // rust.fix_closure';
                let v37: Result<(), pyo3::PyErr> = __run_test;
                v37.unwrap();
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
                        let v140: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v12));
                        let v153: f64 = f64::NAN;
                        let v155: f64 = f64::NAN;
                        let v157: num_complex::Complex<f64> = num_complex::Complex::new(v153, v155);
                        let v160: num_complex::Complex<f64> = match &v140 {
                            Math::US0::US0_0(v140_0_0) => match &v140 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v157.clone(),
                        };
                        let v162: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v164: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v162, v2.clone());
                        let v166: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v168: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v170: num_complex::Complex<f64> = v2.clone() - v168;
                        let v172: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v166, v170);
                        let v174: num_complex::Complex<f64> = v164 * v172;
                        let v176: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v178: num_complex::Complex<f64> = v176 * v2.clone();
                        let v180: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v182: num_complex::Complex<f64> = v178 / v180;
                        let v184: num_complex::Complex<f64> = v182.sin();
                        let v186: num_complex::Complex<f64> = v174 * v184;
                        let v188: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v193: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method16(
                                v0_1.get().clone(),
                                string("        s = mpmath.gamma(s)"),
                                Math::method3(v188 - v2.clone()),
                            );
                        let v198: Option<num_complex::Complex<f64>> = v193.ok();
                        let v326: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v198));
                        let v339: f64 = f64::NAN;
                        let v341: f64 = f64::NAN;
                        let v343: num_complex::Complex<f64> = num_complex::Complex::new(v339, v341);
                        let v346: num_complex::Complex<f64> = match &v326 {
                            Math::US0::US0_0(v326_0_0) => match &v326 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v343.clone(),
                        };
                        let v348: num_complex::Complex<f64> = v186 * v346;
                        let v351: f64 = 1.0_f64 - (v2.clone().re);
                        let v354: f64 = -v2.im;
                        let v356: num_complex::Complex<f64> = num_complex::Complex::new(v351, v354);
                        let v359: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(
                                v0_1.get().clone(),
                                string("        s = mpmath.zeta(s)"),
                                Math::method3(v356.clone()),
                            );
                        let v360: num_complex::Complex<f64> =
                            Math::method13(v0_1.get().clone(), v356);
                        let v365: Option<num_complex::Complex<f64>> = v359.ok();
                        let v493: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v365));
                        let v506: f64 = f64::NAN;
                        let v508: f64 = f64::NAN;
                        let v510: num_complex::Complex<f64> = num_complex::Complex::new(v506, v508);
                        let v513: num_complex::Complex<f64> = match &v493 {
                            Math::US0::US0_0(v493_0_0) => match &v493 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v510.clone(),
                        };
                        let v515: num_complex::Complex<f64> = v348 * v513;
                        let v520: f64 = (v160.clone().re) - (v515.clone().re);
                        let v521: f64 = -v520;
                        let v523: f64 = if (v520) >= (v521) { v520 } else { v521 };
                        let v524: bool = (v523) < 0.0001_f64;
                        let v526: bool = if v524 { true } else { Math::method18(v524) };
                        let v531: string = if v524 {
                            Math::method19(0.0001_f64)
                        } else {
                            Math::method26(v523, 0.0001_f64)
                        };
                        let v558: string = append(
                            string("__assert_lt "),
                            (if v524 {
                                Math::method19(0.0001_f64)
                            } else {
                                Math::method26(v523, 0.0001_f64)
                            }),
                        );
                        let v573: () = {
                            Math::closure2(v558.clone(), ());
                            ()
                        };
                        if (v526) == false {
                            panic!("{}", v558,);
                        }
                        {
                            let v588: f64 = (v160.im) - (v515.im);
                            let v589: f64 = -v588;
                            let v591: f64 = if (v588) >= (v589) { v588 } else { v589 };
                            let v592: bool = (v591) < 0.0001_f64;
                            let v594: bool = if v592 { true } else { Math::method18(v592) };
                            let v599: string = if v592 {
                                Math::method19(0.0001_f64)
                            } else {
                                Math::method26(v591, 0.0001_f64)
                            };
                            let v620: string = append(
                                string("__assert_lt "),
                                (if v592 {
                                    Math::method19(0.0001_f64)
                                } else {
                                    Math::method26(v591, 0.0001_f64)
                                }),
                            );
                            let v635: () = {
                                Math::closure2(v620.clone(), ());
                                ()
                            };
                            if (v594) == false {
                                panic!("{}", v620,);
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
                    let v17: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v21: string = string("}}");
                    let v23: string = string("{");
                    let v28: bool = true;
                    let _fix_closure_v25 = v17;
                    let v34: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v25 "), (v21))),
                                string("); "),
                            )),
                            (v23),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v35: bool = true;
                    _fix_closure_v25
                }
            });
            {
                // rust.fix_closure';
                let v37: Result<(), pyo3::PyErr> = __run_test;
                v37.unwrap();
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
                        let v145: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v17));
                        let v158: f64 = f64::NAN;
                        let v160: f64 = f64::NAN;
                        let v162: num_complex::Complex<f64> = num_complex::Complex::new(v158, v160);
                        let v165: num_complex::Complex<f64> = match &v145 {
                            Math::US0::US0_0(v145_0_0) => match &v145 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v162.clone(),
                        };
                        let v168: f64 = (v165.clone().re) - (v8);
                        let v169: f64 = -v168;
                        let v171: f64 = if (v168) >= (v169) { v168 } else { v169 };
                        let v172: bool = (v171) < 0.01_f64;
                        let v174: bool = if v172 { true } else { Math::method18(v172) };
                        let v179: string = if v172 {
                            Math::method19(0.01_f64)
                        } else {
                            Math::method26(v171, 0.01_f64)
                        };
                        let v206: string = append(
                            string("__assert_lt "),
                            (if v172 {
                                Math::method19(0.01_f64)
                            } else {
                                Math::method26(v171, 0.01_f64)
                            }),
                        );
                        let v221: () = {
                            Math::closure2(v206.clone(), ());
                            ()
                        };
                        if (v174) == false {
                            panic!("{}", v206,);
                        }
                        {
                            let v233: f64 = v165.im;
                            let v234: bool = (v233) < 0.01_f64;
                            let v236: bool = if v234 { true } else { Math::method18(v234) };
                            let v241: string = if v234 {
                                Math::method19(0.01_f64)
                            } else {
                                Math::method26(v233, 0.01_f64)
                            };
                            let v262: string = append(
                                string("__assert_lt "),
                                (if v234 {
                                    Math::method19(0.01_f64)
                                } else {
                                    Math::method26(v233, 0.01_f64)
                                }),
                            );
                            let v277: () = {
                                Math::closure2(v262.clone(), ());
                                ()
                            };
                            if (v236) == false {
                                panic!("{}", v262,);
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
                    let v17: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v21: string = string("}}");
                    let v23: string = string("{");
                    let v28: bool = true;
                    let _fix_closure_v25 = v17;
                    let v34: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v25 "), (v21))),
                                string("); "),
                            )),
                            (v23),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v35: bool = true;
                    _fix_closure_v25
                }
            });
            {
                // rust.fix_closure';
                let v37: Result<(), pyo3::PyErr> = __run_test;
                v37.unwrap();
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
            let v6: () = {
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
pub use module_b7a9935b::*;
#[path = "../../deps/spiral/lib/spiral/async_.rs"]
mod module_2335f2f5;
pub use module_2335f2f5::*;
#[path = "../../deps/spiral/lib/spiral/common.rs"]
mod module_652e6d81;
pub use module_652e6d81::*;
#[path = "../../deps/spiral/lib/spiral/crypto.rs"]
mod module_dd5f95ef;
pub use module_dd5f95ef::*;
#[path = "../../deps/spiral/lib/spiral/date_time.rs"]
mod module_ca5e6cb2;
pub use module_ca5e6cb2::*;
#[path = "../../deps/spiral/lib/spiral/file_system.rs"]
mod module_5ab1faf0;
pub use module_5ab1faf0::*;
#[path = "../../deps/spiral/lib/spiral/lib.rs"]
mod module_b386774b;
pub use module_b386774b::*;
#[path = "../../deps/spiral/lib/spiral/networking.rs"]
mod module_ce497f72;
pub use module_ce497f72::*;
#[path = "../../deps/spiral/lib/spiral/platform.rs"]
mod module_9a61edd3;
pub use module_9a61edd3::*;
#[path = "../../deps/spiral/lib/spiral/runtime.rs"]
mod module_502d7e30;
pub use module_502d7e30::*;
#[path = "../../deps/spiral/lib/spiral/sm.rs"]
mod module_34f67952;
pub use module_34f67952::*;
#[path = "../../deps/spiral/lib/spiral/threading.rs"]
mod module_11c0c5c2;
pub use module_11c0c5c2::*;
#[path = "../../deps/spiral/lib/spiral/trace.rs"]
mod module_28ecba0d;
pub use module_28ecba0d::*;
#[path = "../../lib/fsharp/Common.rs"]
mod module_ad43931;
pub use module_ad43931::*;
pub mod Polyglot {
    pub use crate::module_ad43931::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Math::main(array_from(args));
}
