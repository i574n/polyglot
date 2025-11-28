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
            let v57: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v2.clone().re, v2.im))));
            let v69: pyo3::Python = Math::method7(v0_1);
            let v254: &str = &*v36;
            let v899: std::string::String = String::from(v254);
            let v1361: std::ffi::CString = std::ffi::CString::new(v899).unwrap();
            let v1547: &str = &*string("");
            let v2192: std::string::String = String::from(v1547);
            let v2654: std::ffi::CString = std::ffi::CString::new(v2192).unwrap();
            let v2656: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code(v69, &v1361, &v2654, &v2654);
            let v2658: bool = true;
            let _result_map_error__ = v2656.map_err(|x| {
                //;
                let v2660: pyo3::PyErr = x;
                let v2691: std::string::String = format!("{}", v2660);
                let v2768: bool = true;
                v2691
            });
            let v2770: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                _result_map_error__;
            let v2772: pyo3::Bound<pyo3::types::PyModule> = v2770.unwrap();
            let v2773: string = Math::method8();
            let v2958: &str = &*v2773;
            let v3419: pyo3::Bound<pyo3::types::PyModule> = Math::method9(v2772);
            let v3421: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v3419.getattr(v2958);
            let v3423: bool = true;
            let _result_map_error__ = v3421.map_err(|x| {
                //;
                let v3425: pyo3::PyErr = x;
                let v3456: std::string::String = format!("{}", v3425);
                let v3533: bool = true;
                v3456
            });
            let v3535: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v3537: pyo3::Bound<pyo3::PyAny> = v3535.unwrap();
            let v3538: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method10(v57.0.clone(), v57.1.clone());
            let v3539: pyo3::Bound<pyo3::PyAny> = Math::method11(v3537);
            let v3541: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                pyo3::prelude::PyAnyMethods::call(&v3539, ((*v3538).0, *(*v3538).1), None);
            let v3543: bool = true;
            let _result_map_error__ = v3541.map_err(|x| {
                //;
                let v3545: pyo3::PyErr = x;
                let v3576: std::string::String = format!("{}", v3545);
                let v3653: bool = true;
                v3576
            });
            let v3655: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v3658: pyo3::Bound<pyo3::PyAny> = Math::method12(v3655?);
            let v3660: Result<(f64, f64), pyo3::PyErr> = v3658.extract();
            let v3662: bool = true;
            let _result_map_error__ = v3660.map_err(|x| {
                //;
                let v3664: pyo3::PyErr = x;
                let v3695: std::string::String = format!("{}", v3664);
                let v3772: bool = true;
                v3695
            });
            let v3774: Result<(f64, f64), std::string::String> = _result_map_error__;
            let patternInput: (f64, f64) = v3774?;
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
            let v57: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v2.clone().re, v2.im))));
            let v69: pyo3::Python = Math::method7(v0_1);
            let v254: &str = &*v36;
            let v899: std::string::String = String::from(v254);
            let v1361: std::ffi::CString = std::ffi::CString::new(v899).unwrap();
            let v1547: &str = &*string("");
            let v2192: std::string::String = String::from(v1547);
            let v2654: std::ffi::CString = std::ffi::CString::new(v2192).unwrap();
            let v2656: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code(v69, &v1361, &v2654, &v2654);
            let v2658: bool = true;
            let _result_map_error__ = v2656.map_err(|x| {
                //;
                let v2660: pyo3::PyErr = x;
                let v2691: std::string::String = format!("{}", v2660);
                let v2768: bool = true;
                v2691
            });
            let v2770: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                _result_map_error__;
            let v2772: pyo3::Bound<pyo3::types::PyModule> = v2770.unwrap();
            let v2773: string = Math::method8();
            let v2958: &str = &*v2773;
            let v3419: pyo3::Bound<pyo3::types::PyModule> = Math::method9(v2772);
            let v3421: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v3419.getattr(v2958);
            let v3423: bool = true;
            let _result_map_error__ = v3421.map_err(|x| {
                //;
                let v3425: pyo3::PyErr = x;
                let v3456: std::string::String = format!("{}", v3425);
                let v3533: bool = true;
                v3456
            });
            let v3535: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v3537: pyo3::Bound<pyo3::PyAny> = v3535.unwrap();
            let v3538: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method10(v57.0.clone(), v57.1.clone());
            let v3539: pyo3::Bound<pyo3::PyAny> = Math::method11(v3537);
            let v3541: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                pyo3::prelude::PyAnyMethods::call(&v3539, ((*v3538).0, *(*v3538).1), None);
            let v3543: bool = true;
            let _result_map_error__ = v3541.map_err(|x| {
                //;
                let v3545: pyo3::PyErr = x;
                let v3576: std::string::String = format!("{}", v3545);
                let v3653: bool = true;
                v3576
            });
            let v3655: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v3658: pyo3::Bound<pyo3::PyAny> = Math::method12(v3655?);
            let v3660: Result<(f64, f64), pyo3::PyErr> = v3658.extract();
            let v3662: bool = true;
            let _result_map_error__ = v3660.map_err(|x| {
                //;
                let v3664: pyo3::PyErr = x;
                let v3695: std::string::String = format!("{}", v3664);
                let v3772: bool = true;
                v3695
            });
            let v3774: Result<(f64, f64), std::string::String> = _result_map_error__;
            let patternInput: (f64, f64) = v3774?;
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
                        let v37: num_complex::Complex<f64> =
                            num_complex::Complex::new(v24, 0.0_f64);
                        let v39: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v37, v1_1.clone());
                        let v41: num_complex::Complex<f64> = v20 / v39;
                        let v43: num_complex::Complex<f64> = v17 + v41;
                        let v44: i32 = (v16) + 1_i32;
                        v14.l0.set(v44);
                        v14.l1.set(v43);
                        ()
                    }
                    v14.l1.get().clone()
                }
            } else {
                let v47: num_complex::Complex<f64> = num_complex::Complex::new(1.0_f64, 0.0_f64);
                let v52: Result<num_complex::Complex<f64>, std::string::String> = Math::method16(
                    v0_1.clone(),
                    string("        s = mpmath.gamma(s)"),
                    Math::method3(v47 - v1_1.clone()),
                );
                let v57: Option<num_complex::Complex<f64>> = v52.ok();
                let v193: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v57));
                let v207: f64 = f64::NAN;
                let v209: f64 = f64::NAN;
                let v211: num_complex::Complex<f64> = num_complex::Complex::new(v207, v209);
                let v214: num_complex::Complex<f64> = match &v193 {
                    Math::US0::US0_0(v193_0_0) => match &v193 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v211.clone(),
                };
                let v216: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v218: num_complex::Complex<f64> = v216 * v1_1.clone();
                let v220: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v222: num_complex::Complex<f64> = v218 / v220;
                let v224: num_complex::Complex<f64> = v222.sin();
                let v227: f64 = 1.0_f64 - (v1_1.clone().re);
                let v230: f64 = -v1_1.clone().im;
                let v232: num_complex::Complex<f64> = num_complex::Complex::new(v227, v230);
                let v1246: num_complex::Complex<f64> = if (v232.clone().re) <= 1.0_f64 {
                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                } else {
                    println!("zeta / count: {:?} / s: {:?}", 1_i32, v232.clone());
                    if (v232.clone().re) > 1.0_f64 {
                        let v243: num_complex::Complex<f64> =
                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                        let v244: Array<i32> = new_init(&0_i32, 10000_i32);
                        let v245: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                            l0: MutCell::new(0_i32),
                        });
                        while Math::method14(v245.clone()) {
                            let v247: i32 = v245.l0.get().clone();
                            v244.get_mut()[v247 as usize] = v247;
                            {
                                let v248: i32 = (v247) + 1_i32;
                                v245.l0.set(v248);
                                ()
                            }
                        }
                        {
                            let v249: i32 = get_Count(v244.clone());
                            let v250: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                l0: MutCell::new(0_i32),
                                l1: MutCell::new(v243),
                            });
                            while Math::method15(v249, v250.clone()) {
                                let v252: i32 = v250.l0.get().clone();
                                let v253: num_complex::Complex<f64> = v250.l1.get().clone();
                                let v254: i32 = v244[v252].clone();
                                let v256: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v260: f64 = v254 as f64;
                                let v273: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v260, 0.0_f64);
                                let v275: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v273, v232.clone());
                                let v277: num_complex::Complex<f64> = v256 / v275;
                                let v279: num_complex::Complex<f64> = v253 + v277;
                                let v280: i32 = (v252) + 1_i32;
                                v250.l0.set(v280);
                                v250.l1.set(v279);
                                ()
                            }
                            v250.l1.get().clone()
                        }
                    } else {
                        let v283: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v288: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method16(
                                v0_1.clone(),
                                string("        s = mpmath.gamma(s)"),
                                Math::method3(v283 - v232.clone()),
                            );
                        let v293: Option<num_complex::Complex<f64>> = v288.ok();
                        let v429: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v293));
                        let v443: f64 = f64::NAN;
                        let v445: f64 = f64::NAN;
                        let v447: num_complex::Complex<f64> = num_complex::Complex::new(v443, v445);
                        let v450: num_complex::Complex<f64> = match &v429 {
                            Math::US0::US0_0(v429_0_0) => match &v429 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v447.clone(),
                        };
                        let v452: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v454: num_complex::Complex<f64> = v452 * v232.clone();
                        let v456: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v458: num_complex::Complex<f64> = v454 / v456;
                        let v460: num_complex::Complex<f64> = v458.sin();
                        let v463: f64 = 1.0_f64 - (v232.clone().re);
                        let v466: f64 = -v232.clone().im;
                        let v468: num_complex::Complex<f64> = num_complex::Complex::new(v463, v466);
                        let v1230: num_complex::Complex<f64> = if (v468.clone().re) <= 1.0_f64 {
                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                        } else {
                            println!("zeta / count: {:?} / s: {:?}", 2_i32, v468.clone());
                            if (v468.clone().re) > 1.0_f64 {
                                let v479: num_complex::Complex<f64> =
                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                let v480: Array<i32> = new_init(&0_i32, 10000_i32);
                                let v481: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Math::method14(v481.clone()) {
                                    let v483: i32 = v481.l0.get().clone();
                                    v480.get_mut()[v483 as usize] = v483;
                                    {
                                        let v484: i32 = (v483) + 1_i32;
                                        v481.l0.set(v484);
                                        ()
                                    }
                                }
                                {
                                    let v485: i32 = get_Count(v480.clone());
                                    let v486: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                        l0: MutCell::new(0_i32),
                                        l1: MutCell::new(v479),
                                    });
                                    while Math::method15(v485, v486.clone()) {
                                        let v488: i32 = v486.l0.get().clone();
                                        let v489: num_complex::Complex<f64> = v486.l1.get().clone();
                                        let v490: i32 = v480[v488].clone();
                                        let v492: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v496: f64 = v490 as f64;
                                        let v509: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v496, 0.0_f64);
                                        let v511: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v509, v468.clone());
                                        let v513: num_complex::Complex<f64> = v492 / v511;
                                        let v515: num_complex::Complex<f64> = v489 + v513;
                                        let v516: i32 = (v488) + 1_i32;
                                        v486.l0.set(v516);
                                        v486.l1.set(v515);
                                        ()
                                    }
                                    v486.l1.get().clone()
                                }
                            } else {
                                let v519: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v524: Result<num_complex::Complex<f64>, std::string::String> =
                                    Math::method16(
                                        v0_1.clone(),
                                        string("        s = mpmath.gamma(s)"),
                                        Math::method3(v519 - v468.clone()),
                                    );
                                let v529: Option<num_complex::Complex<f64>> = v524.ok();
                                let v665: Math::US0 =
                                    defaultValue(Math::US0::US0_1, map(Math::method17(), v529));
                                let v679: f64 = f64::NAN;
                                let v681: f64 = f64::NAN;
                                let v683: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v679, v681);
                                let v686: num_complex::Complex<f64> = match &v665 {
                                    Math::US0::US0_0(v665_0_0) => match &v665 {
                                        Math::US0::US0_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                    _ => v683.clone(),
                                };
                                let v688: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v690: num_complex::Complex<f64> = v688 * v468.clone();
                                let v692: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v694: num_complex::Complex<f64> = v690 / v692;
                                let v696: num_complex::Complex<f64> = v694.sin();
                                let v699: f64 = 1.0_f64 - (v468.clone().re);
                                let v702: f64 = -v468.clone().im;
                                let v704: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v699, v702);
                                let v1214: num_complex::Complex<f64> = if (v704.clone().re)
                                    <= 1.0_f64
                                {
                                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                                } else {
                                    println!("zeta / count: {:?} / s: {:?}", 3_i32, v704.clone());
                                    if (v704.clone().re) > 1.0_f64 {
                                        let v715: num_complex::Complex<f64> =
                                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                                        let v716: Array<i32> = new_init(&0_i32, 10000_i32);
                                        let v717: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                            l0: MutCell::new(0_i32),
                                        });
                                        while Math::method14(v717.clone()) {
                                            let v719: i32 = v717.l0.get().clone();
                                            v716.get_mut()[v719 as usize] = v719;
                                            {
                                                let v720: i32 = (v719) + 1_i32;
                                                v717.l0.set(v720);
                                                ()
                                            }
                                        }
                                        {
                                            let v721: i32 = get_Count(v716.clone());
                                            let v722: LrcPtr<Math::Mut2> =
                                                LrcPtr::new(Math::Mut2 {
                                                    l0: MutCell::new(0_i32),
                                                    l1: MutCell::new(v715),
                                                });
                                            while Math::method15(v721, v722.clone()) {
                                                let v724: i32 = v722.l0.get().clone();
                                                let v725: num_complex::Complex<f64> =
                                                    v722.l1.get().clone();
                                                let v726: i32 = v716[v724].clone();
                                                let v728: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v732: f64 = v726 as f64;
                                                let v745: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v732, 0.0_f64);
                                                let v747: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v745, v704.clone());
                                                let v749: num_complex::Complex<f64> = v728 / v747;
                                                let v751: num_complex::Complex<f64> = v725 + v749;
                                                let v752: i32 = (v724) + 1_i32;
                                                v722.l0.set(v752);
                                                v722.l1.set(v751);
                                                ()
                                            }
                                            v722.l1.get().clone()
                                        }
                                    } else {
                                        let v755: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v760: Result<
                                            num_complex::Complex<f64>,
                                            std::string::String,
                                        > = Math::method16(
                                            v0_1.clone(),
                                            string("        s = mpmath.gamma(s)"),
                                            Math::method3(v755 - v704.clone()),
                                        );
                                        let v765: Option<num_complex::Complex<f64>> = v760.ok();
                                        let v901: Math::US0 = defaultValue(
                                            Math::US0::US0_1,
                                            map(Math::method17(), v765),
                                        );
                                        let v915: f64 = f64::NAN;
                                        let v917: f64 = f64::NAN;
                                        let v919: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v915, v917);
                                        let v922: num_complex::Complex<f64> = match &v901 {
                                            Math::US0::US0_0(v901_0_0) => match &v901 {
                                                Math::US0::US0_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                            _ => v919.clone(),
                                        };
                                        let v924: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v926: num_complex::Complex<f64> = v924 * v704.clone();
                                        let v928: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v930: num_complex::Complex<f64> = v926 / v928;
                                        let v932: num_complex::Complex<f64> = v930.sin();
                                        let v935: f64 = 1.0_f64 - (v704.clone().re);
                                        let v938: f64 = -v704.clone().im;
                                        let v940: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v935, v938);
                                        let v1198: num_complex::Complex<f64> = if (v940.clone().re)
                                            <= 1.0_f64
                                        {
                                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                                        } else {
                                            println!(
                                                "zeta / count: {:?} / s: {:?}",
                                                4_i32,
                                                v940.clone()
                                            );
                                            if (v940.clone().re) > 1.0_f64 {
                                                let v951: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                                let v952: Array<i32> = new_init(&0_i32, 10000_i32);
                                                let v953: LrcPtr<Math::Mut0> =
                                                    LrcPtr::new(Math::Mut0 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Math::method14(v953.clone()) {
                                                    let v955: i32 = v953.l0.get().clone();
                                                    v952.get_mut()[v955 as usize] = v955;
                                                    {
                                                        let v956: i32 = (v955) + 1_i32;
                                                        v953.l0.set(v956);
                                                        ()
                                                    }
                                                }
                                                {
                                                    let v957: i32 = get_Count(v952.clone());
                                                    let v958: LrcPtr<Math::Mut2> =
                                                        LrcPtr::new(Math::Mut2 {
                                                            l0: MutCell::new(0_i32),
                                                            l1: MutCell::new(v951),
                                                        });
                                                    while Math::method15(v957, v958.clone()) {
                                                        let v960: i32 = v958.l0.get().clone();
                                                        let v961: num_complex::Complex<f64> =
                                                            v958.l1.get().clone();
                                                        let v962: i32 = v952[v960].clone();
                                                        let v964: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                1.0_f64, 0.0_f64,
                                                            );
                                                        let v968: f64 = v962 as f64;
                                                        let v981: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                v968, 0.0_f64,
                                                            );
                                                        let v983: num_complex::Complex<f64> =
                                                            num_complex::Complex::powc(
                                                                v981,
                                                                v940.clone(),
                                                            );
                                                        let v985: num_complex::Complex<f64> =
                                                            v964 / v983;
                                                        let v987: num_complex::Complex<f64> =
                                                            v961 + v985;
                                                        let v988: i32 = (v960) + 1_i32;
                                                        v958.l0.set(v988);
                                                        v958.l1.set(v987);
                                                        ()
                                                    }
                                                    v958.l1.get().clone()
                                                }
                                            } else {
                                                let v991: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v996: Result<
                                                    num_complex::Complex<f64>,
                                                    std::string::String,
                                                > = Math::method16(
                                                    v0_1,
                                                    string("        s = mpmath.gamma(s)"),
                                                    Math::method3(v991 - v940.clone()),
                                                );
                                                let v1001: Option<num_complex::Complex<f64>> =
                                                    v996.ok();
                                                let v1137: Math::US0 = defaultValue(
                                                    Math::US0::US0_1,
                                                    map(Math::method17(), v1001),
                                                );
                                                let v1151: f64 = f64::NAN;
                                                let v1153: f64 = f64::NAN;
                                                let v1155: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v1151, v1153);
                                                let v1158: num_complex::Complex<f64> = match &v1137
                                                {
                                                    Math::US0::US0_0(v1137_0_0) => match &v1137 {
                                                        Math::US0::US0_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                    _ => v1155.clone(),
                                                };
                                                let v1160: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(
                                                        3.141592653589793_f64,
                                                        0.0_f64,
                                                    );
                                                let v1162: num_complex::Complex<f64> =
                                                    v1160 * v940.clone();
                                                let v1164: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                let v1166: num_complex::Complex<f64> =
                                                    v1162 / v1164;
                                                let v1168: num_complex::Complex<f64> = v1166.sin();
                                                let v1171: f64 = 1.0_f64 - (v940.clone().re);
                                                let v1174: f64 = -v940.clone().im;
                                                let v1176: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v1171, v1174);
                                                let v1182: num_complex::Complex<f64> =
                                                    if (v1176.clone().re) <= 1.0_f64 {
                                                        num_complex::Complex::new(0.0_f64, 0.0_f64)
                                                    } else {
                                                        v1176
                                                    };
                                                let v1184: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                let v1186: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(
                                                        3.141592653589793_f64,
                                                        0.0_f64,
                                                    );
                                                let v1188: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v1186, v940.clone());
                                                let v1190: num_complex::Complex<f64> =
                                                    v1184 * v1188;
                                                let v1192: num_complex::Complex<f64> =
                                                    v1190 * v1168;
                                                let v1194: num_complex::Complex<f64> =
                                                    v1192 * v1158;
                                                v1194 * v1182
                                            }
                                        };
                                        let v1200: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v1202: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v1204: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v1202, v704.clone());
                                        let v1206: num_complex::Complex<f64> = v1200 * v1204;
                                        let v1208: num_complex::Complex<f64> = v1206 * v932;
                                        let v1210: num_complex::Complex<f64> = v1208 * v922;
                                        v1210 * v1198
                                    }
                                };
                                let v1216: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v1218: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v1220: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v1218, v468.clone());
                                let v1222: num_complex::Complex<f64> = v1216 * v1220;
                                let v1224: num_complex::Complex<f64> = v1222 * v696;
                                let v1226: num_complex::Complex<f64> = v1224 * v686;
                                v1226 * v1214
                            }
                        };
                        let v1232: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v1234: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v1236: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v1234, v232.clone());
                        let v1238: num_complex::Complex<f64> = v1232 * v1236;
                        let v1240: num_complex::Complex<f64> = v1238 * v460;
                        let v1242: num_complex::Complex<f64> = v1240 * v450;
                        v1242 * v1230
                    }
                };
                let v1248: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v1250: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v1252: num_complex::Complex<f64> =
                    num_complex::Complex::powc(v1250, v1_1.clone());
                let v1254: num_complex::Complex<f64> = v1248 * v1252;
                let v1256: num_complex::Complex<f64> = v1254 * v224;
                let v1258: num_complex::Complex<f64> = v1256 * v214;
                v1258 * v1246
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
                let v156: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v20));
                let v170: f64 = f64::NAN;
                let v172: f64 = f64::NAN;
                let v174: num_complex::Complex<f64> = num_complex::Complex::new(v170, v172);
                let v177: num_complex::Complex<f64> = match &v156 {
                    Math::US0::US0_0(v156_0_0) => match &v156 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v174.clone(),
                };
                let v179: f64 = v177.clone().im;
                let v180: bool = (v179) == 0.0_f64;
                let v182: bool = if v180 { true } else { Math::method18(v180) };
                let v187: string = if v180 {
                    Math::method19(0.0_f64)
                } else {
                    Math::method26(v179, 0.0_f64)
                };
                let v215: string = append(
                    string("__assert_eq "),
                    (if v180 {
                        Math::method19(0.0_f64)
                    } else {
                        Math::method26(v179, 0.0_f64)
                    }),
                );
                let v259: () = {
                    Math::closure2(v215.clone(), ());
                    ()
                };
                if (v182) == false {
                    panic!("{}", v215,);
                }
                {
                    let v274: f64 = (v177.re) - (patternInput.1.clone());
                    let v275: f64 = -v274;
                    let v277: f64 = if (v274) >= (v275) { v274 } else { v275 };
                    let v278: bool = (v277) < 0.0001_f64;
                    let v280: bool = if v278 { true } else { Math::method18(v278) };
                    let v285: string = if v278 {
                        Math::method19(0.0001_f64)
                    } else {
                        Math::method26(v277, 0.0001_f64)
                    };
                    let v310: string = append(
                        string("__assert_lt "),
                        (if v278 {
                            Math::method19(0.0001_f64)
                        } else {
                            Math::method26(v277, 0.0001_f64)
                        }),
                    );
                    let v354: () = {
                        Math::closure2(v310.clone(), ());
                        ()
                    };
                    if (v280) == false {
                        panic!("{}", v310,);
                    }
                    {
                        let v367: i32 = (v9) + 1_i32;
                        v7.l0.set(v367);
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
                    let v18: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v22: string = string("}}");
                    let v24: string = string("{");
                    let v29: bool = true;
                    let _fix_closure_v26 = v18;
                    let v35: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v26 "), (v22))),
                                string("); "),
                            )),
                            (v24),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v36: bool = true;
                    _fix_closure_v26
                }
            });
            {
                // rust.fix_closure';
                let v38: Result<(), pyo3::PyErr> = __run_test;
                v38.unwrap();
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
            let v147: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v11));
            let v161: f64 = f64::NAN;
            let v163: f64 = f64::NAN;
            let v165: num_complex::Complex<f64> = num_complex::Complex::new(v161, v163);
            let v168: num_complex::Complex<f64> = match &v147 {
                Math::US0::US0_0(v147_0_0) => match &v147 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v165.clone(),
            };
            let v171: f64 = (v168.clone().re) - 0.8673_f64;
            let v172: f64 = -v171;
            let v174: f64 = if (v171) >= (v172) { v171 } else { v172 };
            let v175: bool = (v174) < 0.001_f64;
            let v177: bool = if v175 { true } else { Math::method18(v175) };
            let v182: string = if v175 {
                Math::method19(0.001_f64)
            } else {
                Math::method26(v174, 0.001_f64)
            };
            let v210: string = append(
                string("__assert_lt "),
                (if v175 {
                    Math::method19(0.001_f64)
                } else {
                    Math::method26(v174, 0.001_f64)
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
                let v269: f64 = (v168.im) - 0.275_f64;
                let v270: f64 = -v269;
                let v272: f64 = if (v269) >= (v270) { v269 } else { v270 };
                let v273: bool = (v272) < 0.001_f64;
                let v275: bool = if v273 { true } else { Math::method18(v273) };
                let v280: string = if v273 {
                    Math::method19(0.001_f64)
                } else {
                    Math::method26(v272, 0.001_f64)
                };
                let v302: string = append(
                    string("__assert_lt "),
                    (if v273 {
                        Math::method19(0.001_f64)
                    } else {
                        Math::method26(v272, 0.001_f64)
                    }),
                );
                let v346: () = {
                    Math::closure2(v302.clone(), ());
                    ()
                };
                if (v275) == false {
                    panic!("{}", v302,);
                }
            }
        }
        pub fn method30() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method31(py);
                {
                    let v18: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v22: string = string("}}");
                    let v24: string = string("{");
                    let v29: bool = true;
                    let _fix_closure_v26 = v18;
                    let v35: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v26 "), (v22))),
                                string("); "),
                            )),
                            (v24),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v36: bool = true;
                    _fix_closure_v26
                }
            });
            {
                // rust.fix_closure';
                let v38: Result<(), pyo3::PyErr> = __run_test;
                v38.unwrap();
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
                        let v150: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v14));
                        let v164: f64 = f64::NAN;
                        let v166: f64 = f64::NAN;
                        let v168: num_complex::Complex<f64> = num_complex::Complex::new(v164, v166);
                        let v171: num_complex::Complex<f64> = match &v150 {
                            Math::US0::US0_0(v150_0_0) => match &v150 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v168.clone(),
                        };
                        let v173: f64 = v171.clone().re;
                        let v174: bool = (v173) == 0.0_f64;
                        let v176: bool = if v174 { true } else { Math::method18(v174) };
                        let v181: string = if v174 {
                            Math::method19(0.0_f64)
                        } else {
                            Math::method26(v173, 0.0_f64)
                        };
                        let v209: string = append(
                            string("__assert_eq "),
                            (if v174 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v173, 0.0_f64)
                            }),
                        );
                        let v253: () = {
                            Math::closure2(v209.clone(), ());
                            ()
                        };
                        if (v176) == false {
                            panic!("{}", v209,);
                        }
                        {
                            let v267: f64 = v171.im;
                            let v268: bool = (v267) == 0.0_f64;
                            let v270: bool = if v268 { true } else { Math::method18(v268) };
                            let v275: string = if v268 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v267, 0.0_f64)
                            };
                            let v297: string = append(
                                string("__assert_eq "),
                                (if v268 {
                                    Math::method19(0.0_f64)
                                } else {
                                    Math::method26(v267, 0.0_f64)
                                }),
                            );
                            let v341: () = {
                                Math::closure2(v297.clone(), ());
                                ()
                            };
                            if (v270) == false {
                                panic!("{}", v297,);
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
                    let v18: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v22: string = string("}}");
                    let v24: string = string("{");
                    let v29: bool = true;
                    let _fix_closure_v26 = v18;
                    let v35: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v26 "), (v22))),
                                string("); "),
                            )),
                            (v24),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v36: bool = true;
                    _fix_closure_v26
                }
            });
            {
                // rust.fix_closure';
                let v38: Result<(), pyo3::PyErr> = __run_test;
                v38.unwrap();
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
                let v163: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v27));
                let v177: f64 = f64::NAN;
                let v179: f64 = f64::NAN;
                let v181: num_complex::Complex<f64> = num_complex::Complex::new(v177, v179);
                let v184: num_complex::Complex<f64> = match &v163 {
                    Math::US0::US0_0(v163_0_0) => match &v163 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v181.clone(),
                };
                let v186: f64 = v184.clone().re;
                let v187: f64 = -v186;
                let v189: f64 = if (v186) >= (v187) { v186 } else { v187 };
                let v190: bool = (v189) < 0.0001_f64;
                let v192: bool = if v190 { true } else { Math::method18(v190) };
                let v197: string = if v190 {
                    Math::method19(0.0001_f64)
                } else {
                    Math::method26(v189, 0.0001_f64)
                };
                let v225: string = append(
                    string("__assert_lt "),
                    (if v190 {
                        Math::method19(0.0001_f64)
                    } else {
                        Math::method26(v189, 0.0001_f64)
                    }),
                );
                let v269: () = {
                    Math::closure2(v225.clone(), ());
                    ()
                };
                if (v192) == false {
                    panic!("{}", v225,);
                }
                {
                    let v283: f64 = v184.im;
                    let v284: f64 = -v283;
                    let v286: f64 = if (v283) >= (v284) { v283 } else { v284 };
                    let v287: bool = (v286) < 0.0001_f64;
                    let v289: bool = if v287 { true } else { Math::method18(v287) };
                    let v294: string = if v287 {
                        Math::method19(0.0001_f64)
                    } else {
                        Math::method26(v286, 0.0001_f64)
                    };
                    let v316: string = append(
                        string("__assert_lt "),
                        (if v287 {
                            Math::method19(0.0001_f64)
                        } else {
                            Math::method26(v286, 0.0001_f64)
                        }),
                    );
                    let v360: () = {
                        Math::closure2(v316.clone(), ());
                        ()
                    };
                    if (v289) == false {
                        panic!("{}", v316,);
                    }
                    {
                        let v373: i32 = (v17) + 1_i32;
                        v15.l0.set(v373);
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
                    let v18: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v22: string = string("}}");
                    let v24: string = string("{");
                    let v29: bool = true;
                    let _fix_closure_v26 = v18;
                    let v35: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v26 "), (v22))),
                                string("); "),
                            )),
                            (v24),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v36: bool = true;
                    _fix_closure_v26
                }
            });
            {
                // rust.fix_closure';
                let v38: Result<(), pyo3::PyErr> = __run_test;
                v38.unwrap();
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
                let v153: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v17));
                let v167: f64 = f64::NAN;
                let v169: f64 = f64::NAN;
                let v171: num_complex::Complex<f64> = num_complex::Complex::new(v167, v169);
                let v174: num_complex::Complex<f64> = match &v153 {
                    Math::US0::US0_0(v153_0_0) => match &v153 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v171.clone(),
                };
                let v176: f64 = v174.clone().re;
                let v177: bool = (v176) > 0.0_f64;
                let v179: bool = if v177 { true } else { Math::method18(v177) };
                let v184: string = if v177 {
                    Math::method19(0.0_f64)
                } else {
                    Math::method26(v176, 0.0_f64)
                };
                let v212: string = append(
                    string("__assert_gt "),
                    (if v177 {
                        Math::method19(0.0_f64)
                    } else {
                        Math::method26(v176, 0.0_f64)
                    }),
                );
                let v256: () = {
                    Math::closure2(v212.clone(), ());
                    ()
                };
                if (v179) == false {
                    panic!("{}", v212,);
                }
                {
                    let v270: f64 = v174.im;
                    let v271: bool = (v270) == 0.0_f64;
                    let v273: bool = if v271 { true } else { Math::method18(v271) };
                    let v278: string = if v271 {
                        Math::method19(0.0_f64)
                    } else {
                        Math::method26(v270, 0.0_f64)
                    };
                    let v303: string = append(
                        string("__assert_eq "),
                        (if v271 {
                            Math::method19(0.0_f64)
                        } else {
                            Math::method26(v270, 0.0_f64)
                        }),
                    );
                    let v347: () = {
                        Math::closure2(v303.clone(), ());
                        ()
                    };
                    if (v273) == false {
                        panic!("{}", v303,);
                    }
                    {
                        let v360: i32 = (v5) + 1_i32;
                        v3.l0.set(v360);
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
                    let v18: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v22: string = string("}}");
                    let v24: string = string("{");
                    let v29: bool = true;
                    let _fix_closure_v26 = v18;
                    let v35: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v26 "), (v22))),
                                string("); "),
                            )),
                            (v24),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v36: bool = true;
                    _fix_closure_v26
                }
            });
            {
                // rust.fix_closure';
                let v38: Result<(), pyo3::PyErr> = __run_test;
                v38.unwrap();
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
            let v147: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v11));
            let v161: f64 = f64::NAN;
            let v163: f64 = f64::NAN;
            let v165: num_complex::Complex<f64> = num_complex::Complex::new(v161, v163);
            let v168: num_complex::Complex<f64> = match &v147 {
                Math::US0::US0_0(v147_0_0) => match &v147 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v165.clone(),
            };
            let v170: f64 = v168.clone().re;
            let v171: bool = (v170) == (f64::INFINITY);
            let v173: bool = if v171 { true } else { Math::method18(v171) };
            let v178: string = if v171 {
                Math::method19(f64::INFINITY)
            } else {
                Math::method26(v170, f64::INFINITY)
            };
            let v206: string = append(
                string("__assert_eq "),
                (if v171 {
                    Math::method19(f64::INFINITY)
                } else {
                    Math::method26(v170, f64::INFINITY)
                }),
            );
            let v250: () = {
                Math::closure2(v206.clone(), ());
                ()
            };
            if (v173) == false {
                panic!("{}", v206,);
            }
            {
                let v264: f64 = v168.im;
                let v265: bool = (v264) == 0.0_f64;
                let v267: bool = if v265 { true } else { Math::method18(v265) };
                let v272: string = if v265 {
                    Math::method19(0.0_f64)
                } else {
                    Math::method26(v264, 0.0_f64)
                };
                let v294: string = append(
                    string("__assert_eq "),
                    (if v265 {
                        Math::method19(0.0_f64)
                    } else {
                        Math::method26(v264, 0.0_f64)
                    }),
                );
                let v338: () = {
                    Math::closure2(v294.clone(), ());
                    ()
                };
                if (v267) == false {
                    panic!("{}", v294,);
                }
            }
        }
        pub fn method40() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method41(py);
                {
                    let v18: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v22: string = string("}}");
                    let v24: string = string("{");
                    let v29: bool = true;
                    let _fix_closure_v26 = v18;
                    let v35: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v26 "), (v22))),
                                string("); "),
                            )),
                            (v24),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v36: bool = true;
                    _fix_closure_v26
                }
            });
            {
                // rust.fix_closure';
                let v38: Result<(), pyo3::PyErr> = __run_test;
                v38.unwrap();
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
            let v147: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v11));
            let v161: f64 = f64::NAN;
            let v163: f64 = f64::NAN;
            let v165: num_complex::Complex<f64> = num_complex::Complex::new(v161, v163);
            let v168: num_complex::Complex<f64> = match &v147 {
                Math::US0::US0_0(v147_0_0) => match &v147 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v165.clone(),
            };
            let v170: f64 = v2.clone().re;
            let v173: f64 = -v2.im;
            let v175: num_complex::Complex<f64> = num_complex::Complex::new(v170, v173);
            let v178: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v175.clone()),
            );
            let v179: num_complex::Complex<f64> = Math::method13(v0_1, v175);
            let v184: Option<num_complex::Complex<f64>> = v178.ok();
            let v320: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v184));
            let v334: f64 = f64::NAN;
            let v336: f64 = f64::NAN;
            let v338: num_complex::Complex<f64> = num_complex::Complex::new(v334, v336);
            let v341: num_complex::Complex<f64> = match &v320 {
                Math::US0::US0_0(v320_0_0) => match &v320 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v338.clone(),
            };
            let v343: num_complex::Complex<f64> = v341.conj();
            let v345: f64 = v168.clone().re;
            let v347: f64 = v343.clone().re;
            let v348: bool = (v345) == (v347);
            let v350: bool = if v348 { true } else { Math::method18(v348) };
            let v353: string = if v348 {
                Math::method19(v347)
            } else {
                Math::method26(v345, v347)
            };
            let v379: string = append(
                string("__assert_eq "),
                (if v348 {
                    Math::method19(v347)
                } else {
                    Math::method26(v345, v347)
                }),
            );
            let v423: () = {
                Math::closure2(v379.clone(), ());
                ()
            };
            if (v350) == false {
                panic!("{}", v379,);
            }
            {
                let v437: f64 = v168.im;
                let v439: f64 = v343.im;
                let v440: bool = (v437) == (v439);
                let v442: bool = if v440 { true } else { Math::method18(v440) };
                let v445: string = if v440 {
                    Math::method19(v439)
                } else {
                    Math::method26(v437, v439)
                };
                let v465: string = append(
                    string("__assert_eq "),
                    (if v440 {
                        Math::method19(v439)
                    } else {
                        Math::method26(v437, v439)
                    }),
                );
                let v509: () = {
                    Math::closure2(v465.clone(), ());
                    ()
                };
                if (v442) == false {
                    panic!("{}", v465,);
                }
            }
        }
        pub fn method42() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method43(py);
                {
                    let v18: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v22: string = string("}}");
                    let v24: string = string("{");
                    let v29: bool = true;
                    let _fix_closure_v26 = v18;
                    let v35: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v26 "), (v22))),
                                string("); "),
                            )),
                            (v24),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v36: bool = true;
                    _fix_closure_v26
                }
            });
            {
                // rust.fix_closure';
                let v38: Result<(), pyo3::PyErr> = __run_test;
                v38.unwrap();
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
            let v147: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v11));
            let v161: f64 = f64::NAN;
            let v163: f64 = f64::NAN;
            let v165: num_complex::Complex<f64> = num_complex::Complex::new(v161, v163);
            let v168: num_complex::Complex<f64> = match &v147 {
                Math::US0::US0_0(v147_0_0) => match &v147 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v165.clone(),
            };
            let v170: f64 = v168.clone().re;
            let v171: bool = (v170) < (f64::INFINITY);
            let v173: bool = if v171 { true } else { Math::method18(v171) };
            let v178: string = if v171 {
                Math::method19(f64::INFINITY)
            } else {
                Math::method26(v170, f64::INFINITY)
            };
            let v206: string = append(
                string("__assert_lt "),
                (if v171 {
                    Math::method19(f64::INFINITY)
                } else {
                    Math::method26(v170, f64::INFINITY)
                }),
            );
            let v250: () = {
                Math::closure2(v206.clone(), ());
                ()
            };
            if (v173) == false {
                panic!("{}", v206,);
            }
            {
                let v264: f64 = v168.im;
                let v265: bool = (v264) < (f64::INFINITY);
                let v267: bool = if v265 { true } else { Math::method18(v265) };
                let v272: string = if v265 {
                    Math::method19(f64::INFINITY)
                } else {
                    Math::method26(v264, f64::INFINITY)
                };
                let v294: string = append(
                    string("__assert_lt "),
                    (if v265 {
                        Math::method19(f64::INFINITY)
                    } else {
                        Math::method26(v264, f64::INFINITY)
                    }),
                );
                let v338: () = {
                    Math::closure2(v294.clone(), ());
                    ()
                };
                if (v267) == false {
                    panic!("{}", v294,);
                }
            }
        }
        pub fn method44() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method45(py);
                {
                    let v18: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v22: string = string("}}");
                    let v24: string = string("{");
                    let v29: bool = true;
                    let _fix_closure_v26 = v18;
                    let v35: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v26 "), (v22))),
                                string("); "),
                            )),
                            (v24),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v36: bool = true;
                    _fix_closure_v26
                }
            });
            {
                // rust.fix_closure';
                let v38: Result<(), pyo3::PyErr> = __run_test;
                v38.unwrap();
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
                        let v150: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v14));
                        let v164: f64 = f64::NAN;
                        let v166: f64 = f64::NAN;
                        let v168: num_complex::Complex<f64> = num_complex::Complex::new(v164, v166);
                        let v171: num_complex::Complex<f64> = match &v150 {
                            Math::US0::US0_0(v150_0_0) => match &v150 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v168.clone(),
                        };
                        let v173: f64 = v171.clone().re;
                        let v176: bool = (v173) != 0.0_f64;
                        let v189: bool = if v176 { true } else { Math::method18(v176) };
                        let v194: string = if v176 {
                            Math::method19(0.0_f64)
                        } else {
                            Math::method26(v173, 0.0_f64)
                        };
                        let v222: string = append(
                            string("__assert_ne "),
                            (if v176 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v173, 0.0_f64)
                            }),
                        );
                        let v266: () = {
                            Math::closure2(v222.clone(), ());
                            ()
                        };
                        if (v189) == false {
                            panic!("{}", v222,);
                        }
                        {
                            let v280: f64 = v171.im;
                            let v283: bool = (v280) != 0.0_f64;
                            let v296: bool = if v283 { true } else { Math::method18(v283) };
                            let v301: string = if v283 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v280, 0.0_f64)
                            };
                            let v323: string = append(
                                string("__assert_ne "),
                                (if v283 {
                                    Math::method19(0.0_f64)
                                } else {
                                    Math::method26(v280, 0.0_f64)
                                }),
                            );
                            let v367: () = {
                                Math::closure2(v323.clone(), ());
                                ()
                            };
                            if (v296) == false {
                                panic!("{}", v323,);
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
                    let v18: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v22: string = string("}}");
                    let v24: string = string("{");
                    let v29: bool = true;
                    let _fix_closure_v26 = v18;
                    let v35: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v26 "), (v22))),
                                string("); "),
                            )),
                            (v24),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v36: bool = true;
                    _fix_closure_v26
                }
            });
            {
                // rust.fix_closure';
                let v38: Result<(), pyo3::PyErr> = __run_test;
                v38.unwrap();
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
                        let v148: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v12));
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
                        let v174: bool = (v171) != 0.0_f64;
                        let v187: bool = if v174 { true } else { Math::method18(v174) };
                        let v192: string = if v174 {
                            Math::method19(0.0_f64)
                        } else {
                            Math::method26(v171, 0.0_f64)
                        };
                        let v220: string = append(
                            string("__assert_ne "),
                            (if v174 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v171, 0.0_f64)
                            }),
                        );
                        let v264: () = {
                            Math::closure2(v220.clone(), ());
                            ()
                        };
                        if (v187) == false {
                            panic!("{}", v220,);
                        }
                        {
                            let v278: f64 = v169.im;
                            let v281: bool = (v278) != 0.0_f64;
                            let v294: bool = if v281 { true } else { Math::method18(v281) };
                            let v299: string = if v281 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v278, 0.0_f64)
                            };
                            let v321: string = append(
                                string("__assert_ne "),
                                (if v281 {
                                    Math::method19(0.0_f64)
                                } else {
                                    Math::method26(v278, 0.0_f64)
                                }),
                            );
                            let v365: () = {
                                Math::closure2(v321.clone(), ());
                                ()
                            };
                            if (v294) == false {
                                panic!("{}", v321,);
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
                    let v18: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v22: string = string("}}");
                    let v24: string = string("{");
                    let v29: bool = true;
                    let _fix_closure_v26 = v18;
                    let v35: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v26 "), (v22))),
                                string("); "),
                            )),
                            (v24),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v36: bool = true;
                    _fix_closure_v26
                }
            });
            {
                // rust.fix_closure';
                let v38: Result<(), pyo3::PyErr> = __run_test;
                v38.unwrap();
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
                        let v148: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v12));
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
                        let v171: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v173: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v171, v2.clone());
                        let v175: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v177: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v179: num_complex::Complex<f64> = v2.clone() - v177;
                        let v181: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v175, v179);
                        let v183: num_complex::Complex<f64> = v173 * v181;
                        let v185: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v187: num_complex::Complex<f64> = v185 * v2.clone();
                        let v189: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v191: num_complex::Complex<f64> = v187 / v189;
                        let v193: num_complex::Complex<f64> = v191.sin();
                        let v195: num_complex::Complex<f64> = v183 * v193;
                        let v197: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v202: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method16(
                                v0_1.get().clone(),
                                string("        s = mpmath.gamma(s)"),
                                Math::method3(v197 - v2.clone()),
                            );
                        let v207: Option<num_complex::Complex<f64>> = v202.ok();
                        let v343: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v207));
                        let v357: f64 = f64::NAN;
                        let v359: f64 = f64::NAN;
                        let v361: num_complex::Complex<f64> = num_complex::Complex::new(v357, v359);
                        let v364: num_complex::Complex<f64> = match &v343 {
                            Math::US0::US0_0(v343_0_0) => match &v343 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v361.clone(),
                        };
                        let v366: num_complex::Complex<f64> = v195 * v364;
                        let v369: f64 = 1.0_f64 - (v2.clone().re);
                        let v372: f64 = -v2.im;
                        let v374: num_complex::Complex<f64> = num_complex::Complex::new(v369, v372);
                        let v377: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(
                                v0_1.get().clone(),
                                string("        s = mpmath.zeta(s)"),
                                Math::method3(v374.clone()),
                            );
                        let v378: num_complex::Complex<f64> =
                            Math::method13(v0_1.get().clone(), v374);
                        let v383: Option<num_complex::Complex<f64>> = v377.ok();
                        let v519: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v383));
                        let v533: f64 = f64::NAN;
                        let v535: f64 = f64::NAN;
                        let v537: num_complex::Complex<f64> = num_complex::Complex::new(v533, v535);
                        let v540: num_complex::Complex<f64> = match &v519 {
                            Math::US0::US0_0(v519_0_0) => match &v519 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v537.clone(),
                        };
                        let v542: num_complex::Complex<f64> = v366 * v540;
                        let v547: f64 = (v169.clone().re) - (v542.clone().re);
                        let v548: f64 = -v547;
                        let v550: f64 = if (v547) >= (v548) { v547 } else { v548 };
                        let v551: bool = (v550) < 0.0001_f64;
                        let v553: bool = if v551 { true } else { Math::method18(v551) };
                        let v558: string = if v551 {
                            Math::method19(0.0001_f64)
                        } else {
                            Math::method26(v550, 0.0001_f64)
                        };
                        let v586: string = append(
                            string("__assert_lt "),
                            (if v551 {
                                Math::method19(0.0001_f64)
                            } else {
                                Math::method26(v550, 0.0001_f64)
                            }),
                        );
                        let v630: () = {
                            Math::closure2(v586.clone(), ());
                            ()
                        };
                        if (v553) == false {
                            panic!("{}", v586,);
                        }
                        {
                            let v647: f64 = (v169.im) - (v542.im);
                            let v648: f64 = -v647;
                            let v650: f64 = if (v647) >= (v648) { v647 } else { v648 };
                            let v651: bool = (v650) < 0.0001_f64;
                            let v653: bool = if v651 { true } else { Math::method18(v651) };
                            let v658: string = if v651 {
                                Math::method19(0.0001_f64)
                            } else {
                                Math::method26(v650, 0.0001_f64)
                            };
                            let v680: string = append(
                                string("__assert_lt "),
                                (if v651 {
                                    Math::method19(0.0001_f64)
                                } else {
                                    Math::method26(v650, 0.0001_f64)
                                }),
                            );
                            let v724: () = {
                                Math::closure2(v680.clone(), ());
                                ()
                            };
                            if (v653) == false {
                                panic!("{}", v680,);
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
                    let v18: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v22: string = string("}}");
                    let v24: string = string("{");
                    let v29: bool = true;
                    let _fix_closure_v26 = v18;
                    let v35: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v26 "), (v22))),
                                string("); "),
                            )),
                            (v24),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v36: bool = true;
                    _fix_closure_v26
                }
            });
            {
                // rust.fix_closure';
                let v38: Result<(), pyo3::PyErr> = __run_test;
                v38.unwrap();
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
                        let v153: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v17));
                        let v167: f64 = f64::NAN;
                        let v169: f64 = f64::NAN;
                        let v171: num_complex::Complex<f64> = num_complex::Complex::new(v167, v169);
                        let v174: num_complex::Complex<f64> = match &v153 {
                            Math::US0::US0_0(v153_0_0) => match &v153 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v171.clone(),
                        };
                        let v177: f64 = (v174.clone().re) - (v8);
                        let v178: f64 = -v177;
                        let v180: f64 = if (v177) >= (v178) { v177 } else { v178 };
                        let v181: bool = (v180) < 0.01_f64;
                        let v183: bool = if v181 { true } else { Math::method18(v181) };
                        let v188: string = if v181 {
                            Math::method19(0.01_f64)
                        } else {
                            Math::method26(v180, 0.01_f64)
                        };
                        let v216: string = append(
                            string("__assert_lt "),
                            (if v181 {
                                Math::method19(0.01_f64)
                            } else {
                                Math::method26(v180, 0.01_f64)
                            }),
                        );
                        let v260: () = {
                            Math::closure2(v216.clone(), ());
                            ()
                        };
                        if (v183) == false {
                            panic!("{}", v216,);
                        }
                        {
                            let v274: f64 = v174.im;
                            let v275: bool = (v274) < 0.01_f64;
                            let v277: bool = if v275 { true } else { Math::method18(v275) };
                            let v282: string = if v275 {
                                Math::method19(0.01_f64)
                            } else {
                                Math::method26(v274, 0.01_f64)
                            };
                            let v304: string = append(
                                string("__assert_lt "),
                                (if v275 {
                                    Math::method19(0.01_f64)
                                } else {
                                    Math::method26(v274, 0.01_f64)
                                }),
                            );
                            let v348: () = {
                                Math::closure2(v304.clone(), ());
                                ()
                            };
                            if (v277) == false {
                                panic!("{}", v304,);
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
                    let v18: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v22: string = string("}}");
                    let v24: string = string("{");
                    let v29: bool = true;
                    let _fix_closure_v26 = v18;
                    let v35: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v26 "), (v22))),
                                string("); "),
                            )),
                            (v24),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v36: bool = true;
                    _fix_closure_v26
                }
            });
            {
                // rust.fix_closure';
                let v38: Result<(), pyo3::PyErr> = __run_test;
                v38.unwrap();
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
