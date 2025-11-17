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
                let v24: string =
                    append((append((v0_1[v8].clone()), (matchValue_1))), (matchValue));
                let v34: i32 = (v5) + 1_i32;
                v3.l0.set(v34);
                v3.l1.set(v24);
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
            let v53: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v2.clone().re, v2.im))));
            let v63: pyo3::Python = Math::method7(v0_1);
            let v77: &str = &*v36;
            let v162: std::string::String = String::from(v77);
            let v235: std::ffi::CString = std::ffi::CString::new(v162).unwrap();
            let v250: &str = &*string("");
            let v335: std::string::String = String::from(v250);
            let v408: std::ffi::CString = std::ffi::CString::new(v335).unwrap();
            let v410: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code(v63, &v235, &v408, &v408);
            let v412: bool = true;
            let _result_map_error__ = v410.map_err(|x| {
                //;
                let v414: pyo3::PyErr = x;
                let v428: std::string::String = format!("{}", v414);
                let v501: bool = true;
                v428
            });
            let v503: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                _result_map_error__;
            let v507: pyo3::Bound<pyo3::types::PyModule> = v503.unwrap();
            let v519: string = Math::method8();
            let v533: &str = &*v519;
            let v605: pyo3::Bound<pyo3::types::PyModule> = Math::method9(v507);
            let v607: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v605.getattr(v533);
            let v609: bool = true;
            let _result_map_error__ = v607.map_err(|x| {
                //;
                let v611: pyo3::PyErr = x;
                let v625: std::string::String = format!("{}", v611);
                let v698: bool = true;
                v625
            });
            let v700: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v704: pyo3::Bound<pyo3::PyAny> = v700.unwrap();
            let v716: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method10(v53.0.clone(), v53.1.clone());
            let v717: pyo3::Bound<pyo3::PyAny> = Math::method11(v704);
            let v719: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                pyo3::prelude::PyAnyMethods::call(&v717, ((*v716).0, *(*v716).1), None);
            let v721: bool = true;
            let _result_map_error__ = v719.map_err(|x| {
                //;
                let v723: pyo3::PyErr = x;
                let v737: std::string::String = format!("{}", v723);
                let v810: bool = true;
                v737
            });
            let v812: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v815: pyo3::Bound<pyo3::PyAny> = Math::method12(v812?);
            let v817: Result<(f64, f64), pyo3::PyErr> = v815.extract();
            let v819: bool = true;
            let _result_map_error__ = v817.map_err(|x| {
                //;
                let v821: pyo3::PyErr = x;
                let v835: std::string::String = format!("{}", v821);
                let v908: bool = true;
                v835
            });
            let v910: Result<(f64, f64), std::string::String> = _result_map_error__;
            let patternInput: (f64, f64) = v910?;
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
            let v53: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v2.clone().re, v2.im))));
            let v63: pyo3::Python = Math::method7(v0_1);
            let v77: &str = &*v36;
            let v162: std::string::String = String::from(v77);
            let v235: std::ffi::CString = std::ffi::CString::new(v162).unwrap();
            let v250: &str = &*string("");
            let v335: std::string::String = String::from(v250);
            let v408: std::ffi::CString = std::ffi::CString::new(v335).unwrap();
            let v410: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code(v63, &v235, &v408, &v408);
            let v412: bool = true;
            let _result_map_error__ = v410.map_err(|x| {
                //;
                let v414: pyo3::PyErr = x;
                let v428: std::string::String = format!("{}", v414);
                let v501: bool = true;
                v428
            });
            let v503: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                _result_map_error__;
            let v507: pyo3::Bound<pyo3::types::PyModule> = v503.unwrap();
            let v519: string = Math::method8();
            let v533: &str = &*v519;
            let v605: pyo3::Bound<pyo3::types::PyModule> = Math::method9(v507);
            let v607: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v605.getattr(v533);
            let v609: bool = true;
            let _result_map_error__ = v607.map_err(|x| {
                //;
                let v611: pyo3::PyErr = x;
                let v625: std::string::String = format!("{}", v611);
                let v698: bool = true;
                v625
            });
            let v700: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v704: pyo3::Bound<pyo3::PyAny> = v700.unwrap();
            let v716: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method10(v53.0.clone(), v53.1.clone());
            let v717: pyo3::Bound<pyo3::PyAny> = Math::method11(v704);
            let v719: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                pyo3::prelude::PyAnyMethods::call(&v717, ((*v716).0, *(*v716).1), None);
            let v721: bool = true;
            let _result_map_error__ = v719.map_err(|x| {
                //;
                let v723: pyo3::PyErr = x;
                let v737: std::string::String = format!("{}", v723);
                let v810: bool = true;
                v737
            });
            let v812: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v815: pyo3::Bound<pyo3::PyAny> = Math::method12(v812?);
            let v817: Result<(f64, f64), pyo3::PyErr> = v815.extract();
            let v819: bool = true;
            let _result_map_error__ = v817.map_err(|x| {
                //;
                let v821: pyo3::PyErr = x;
                let v835: std::string::String = format!("{}", v821);
                let v908: bool = true;
                v835
            });
            let v910: Result<(f64, f64), std::string::String> = _result_map_error__;
            let patternInput: (f64, f64) = v910?;
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
                        let v34: num_complex::Complex<f64> =
                            num_complex::Complex::new(v23, 0.0_f64);
                        let v36: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v34, v1_1.clone());
                        let v38: num_complex::Complex<f64> = v20 / v36;
                        let v40: num_complex::Complex<f64> = v17 + v38;
                        let v41: i32 = (v16) + 1_i32;
                        v14.l0.set(v41);
                        v14.l1.set(v40);
                        ()
                    }
                    v14.l1.get().clone()
                }
            } else {
                let v44: num_complex::Complex<f64> = num_complex::Complex::new(1.0_f64, 0.0_f64);
                let v49: Result<num_complex::Complex<f64>, std::string::String> = Math::method16(
                    v0_1.clone(),
                    string("        s = mpmath.gamma(s)"),
                    Math::method3(v44 - v1_1.clone()),
                );
                let v53: Option<num_complex::Complex<f64>> = v49.ok();
                let v126: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v53));
                let v138: f64 = f64::NAN;
                let v140: f64 = f64::NAN;
                let v142: num_complex::Complex<f64> = num_complex::Complex::new(v138, v140);
                let v145: num_complex::Complex<f64> = match &v126 {
                    Math::US0::US0_0(v126_0_0) => match &v126 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v142.clone(),
                };
                let v147: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v149: num_complex::Complex<f64> = v147 * v1_1.clone();
                let v151: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v153: num_complex::Complex<f64> = v149 / v151;
                let v155: num_complex::Complex<f64> = v153.sin();
                let v158: f64 = 1.0_f64 - (v1_1.clone().re);
                let v161: f64 = -v1_1.clone().im;
                let v163: num_complex::Complex<f64> = num_complex::Complex::new(v158, v161);
                let v901: num_complex::Complex<f64> = if (v163.clone().re) <= 1.0_f64 {
                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                } else {
                    println!("zeta / count: {:?} / s: {:?}", 1_i32, v163.clone());
                    if (v163.clone().re) > 1.0_f64 {
                        let v174: num_complex::Complex<f64> =
                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                        let v175: Array<i32> = new_init(&0_i32, 10000_i32);
                        let v176: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                            l0: MutCell::new(0_i32),
                        });
                        while Math::method14(v176.clone()) {
                            let v178: i32 = v176.l0.get().clone();
                            v175.get_mut()[v178 as usize] = v178;
                            {
                                let v179: i32 = (v178) + 1_i32;
                                v176.l0.set(v179);
                                ()
                            }
                        }
                        {
                            let v180: i32 = get_Count(v175.clone());
                            let v181: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                l0: MutCell::new(0_i32),
                                l1: MutCell::new(v174),
                            });
                            while Math::method15(v180, v181.clone()) {
                                let v183: i32 = v181.l0.get().clone();
                                let v184: num_complex::Complex<f64> = v181.l1.get().clone();
                                let v185: i32 = v175[v183].clone();
                                let v187: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v190: f64 = v185 as f64;
                                let v201: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v190, 0.0_f64);
                                let v203: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v201, v163.clone());
                                let v205: num_complex::Complex<f64> = v187 / v203;
                                let v207: num_complex::Complex<f64> = v184 + v205;
                                let v208: i32 = (v183) + 1_i32;
                                v181.l0.set(v208);
                                v181.l1.set(v207);
                                ()
                            }
                            v181.l1.get().clone()
                        }
                    } else {
                        let v211: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v216: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method16(
                                v0_1.clone(),
                                string("        s = mpmath.gamma(s)"),
                                Math::method3(v211 - v163.clone()),
                            );
                        let v220: Option<num_complex::Complex<f64>> = v216.ok();
                        let v293: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v220));
                        let v305: f64 = f64::NAN;
                        let v307: f64 = f64::NAN;
                        let v309: num_complex::Complex<f64> = num_complex::Complex::new(v305, v307);
                        let v312: num_complex::Complex<f64> = match &v293 {
                            Math::US0::US0_0(v293_0_0) => match &v293 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v309.clone(),
                        };
                        let v314: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v316: num_complex::Complex<f64> = v314 * v163.clone();
                        let v318: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v320: num_complex::Complex<f64> = v316 / v318;
                        let v322: num_complex::Complex<f64> = v320.sin();
                        let v325: f64 = 1.0_f64 - (v163.clone().re);
                        let v328: f64 = -v163.clone().im;
                        let v330: num_complex::Complex<f64> = num_complex::Complex::new(v325, v328);
                        let v885: num_complex::Complex<f64> = if (v330.clone().re) <= 1.0_f64 {
                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                        } else {
                            println!("zeta / count: {:?} / s: {:?}", 2_i32, v330.clone());
                            if (v330.clone().re) > 1.0_f64 {
                                let v341: num_complex::Complex<f64> =
                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                let v342: Array<i32> = new_init(&0_i32, 10000_i32);
                                let v343: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Math::method14(v343.clone()) {
                                    let v345: i32 = v343.l0.get().clone();
                                    v342.get_mut()[v345 as usize] = v345;
                                    {
                                        let v346: i32 = (v345) + 1_i32;
                                        v343.l0.set(v346);
                                        ()
                                    }
                                }
                                {
                                    let v347: i32 = get_Count(v342.clone());
                                    let v348: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                        l0: MutCell::new(0_i32),
                                        l1: MutCell::new(v341),
                                    });
                                    while Math::method15(v347, v348.clone()) {
                                        let v350: i32 = v348.l0.get().clone();
                                        let v351: num_complex::Complex<f64> = v348.l1.get().clone();
                                        let v352: i32 = v342[v350].clone();
                                        let v354: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v357: f64 = v352 as f64;
                                        let v368: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v357, 0.0_f64);
                                        let v370: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v368, v330.clone());
                                        let v372: num_complex::Complex<f64> = v354 / v370;
                                        let v374: num_complex::Complex<f64> = v351 + v372;
                                        let v375: i32 = (v350) + 1_i32;
                                        v348.l0.set(v375);
                                        v348.l1.set(v374);
                                        ()
                                    }
                                    v348.l1.get().clone()
                                }
                            } else {
                                let v378: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v383: Result<num_complex::Complex<f64>, std::string::String> =
                                    Math::method16(
                                        v0_1.clone(),
                                        string("        s = mpmath.gamma(s)"),
                                        Math::method3(v378 - v330.clone()),
                                    );
                                let v387: Option<num_complex::Complex<f64>> = v383.ok();
                                let v460: Math::US0 =
                                    defaultValue(Math::US0::US0_1, map(Math::method17(), v387));
                                let v472: f64 = f64::NAN;
                                let v474: f64 = f64::NAN;
                                let v476: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v472, v474);
                                let v479: num_complex::Complex<f64> = match &v460 {
                                    Math::US0::US0_0(v460_0_0) => match &v460 {
                                        Math::US0::US0_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                    _ => v476.clone(),
                                };
                                let v481: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v483: num_complex::Complex<f64> = v481 * v330.clone();
                                let v485: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v487: num_complex::Complex<f64> = v483 / v485;
                                let v489: num_complex::Complex<f64> = v487.sin();
                                let v492: f64 = 1.0_f64 - (v330.clone().re);
                                let v495: f64 = -v330.clone().im;
                                let v497: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v492, v495);
                                let v869: num_complex::Complex<f64> = if (v497.clone().re)
                                    <= 1.0_f64
                                {
                                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                                } else {
                                    println!("zeta / count: {:?} / s: {:?}", 3_i32, v497.clone());
                                    if (v497.clone().re) > 1.0_f64 {
                                        let v508: num_complex::Complex<f64> =
                                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                                        let v509: Array<i32> = new_init(&0_i32, 10000_i32);
                                        let v510: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                            l0: MutCell::new(0_i32),
                                        });
                                        while Math::method14(v510.clone()) {
                                            let v512: i32 = v510.l0.get().clone();
                                            v509.get_mut()[v512 as usize] = v512;
                                            {
                                                let v513: i32 = (v512) + 1_i32;
                                                v510.l0.set(v513);
                                                ()
                                            }
                                        }
                                        {
                                            let v514: i32 = get_Count(v509.clone());
                                            let v515: LrcPtr<Math::Mut2> =
                                                LrcPtr::new(Math::Mut2 {
                                                    l0: MutCell::new(0_i32),
                                                    l1: MutCell::new(v508),
                                                });
                                            while Math::method15(v514, v515.clone()) {
                                                let v517: i32 = v515.l0.get().clone();
                                                let v518: num_complex::Complex<f64> =
                                                    v515.l1.get().clone();
                                                let v519: i32 = v509[v517].clone();
                                                let v521: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v524: f64 = v519 as f64;
                                                let v535: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v524, 0.0_f64);
                                                let v537: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v535, v497.clone());
                                                let v539: num_complex::Complex<f64> = v521 / v537;
                                                let v541: num_complex::Complex<f64> = v518 + v539;
                                                let v542: i32 = (v517) + 1_i32;
                                                v515.l0.set(v542);
                                                v515.l1.set(v541);
                                                ()
                                            }
                                            v515.l1.get().clone()
                                        }
                                    } else {
                                        let v545: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v550: Result<
                                            num_complex::Complex<f64>,
                                            std::string::String,
                                        > = Math::method16(
                                            v0_1.clone(),
                                            string("        s = mpmath.gamma(s)"),
                                            Math::method3(v545 - v497.clone()),
                                        );
                                        let v554: Option<num_complex::Complex<f64>> = v550.ok();
                                        let v627: Math::US0 = defaultValue(
                                            Math::US0::US0_1,
                                            map(Math::method17(), v554),
                                        );
                                        let v639: f64 = f64::NAN;
                                        let v641: f64 = f64::NAN;
                                        let v643: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v639, v641);
                                        let v646: num_complex::Complex<f64> = match &v627 {
                                            Math::US0::US0_0(v627_0_0) => match &v627 {
                                                Math::US0::US0_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                            _ => v643.clone(),
                                        };
                                        let v648: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v650: num_complex::Complex<f64> = v648 * v497.clone();
                                        let v652: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v654: num_complex::Complex<f64> = v650 / v652;
                                        let v656: num_complex::Complex<f64> = v654.sin();
                                        let v659: f64 = 1.0_f64 - (v497.clone().re);
                                        let v662: f64 = -v497.clone().im;
                                        let v664: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v659, v662);
                                        let v853: num_complex::Complex<f64> = if (v664.clone().re)
                                            <= 1.0_f64
                                        {
                                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                                        } else {
                                            println!(
                                                "zeta / count: {:?} / s: {:?}",
                                                4_i32,
                                                v664.clone()
                                            );
                                            if (v664.clone().re) > 1.0_f64 {
                                                let v675: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                                let v676: Array<i32> = new_init(&0_i32, 10000_i32);
                                                let v677: LrcPtr<Math::Mut0> =
                                                    LrcPtr::new(Math::Mut0 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Math::method14(v677.clone()) {
                                                    let v679: i32 = v677.l0.get().clone();
                                                    v676.get_mut()[v679 as usize] = v679;
                                                    {
                                                        let v680: i32 = (v679) + 1_i32;
                                                        v677.l0.set(v680);
                                                        ()
                                                    }
                                                }
                                                {
                                                    let v681: i32 = get_Count(v676.clone());
                                                    let v682: LrcPtr<Math::Mut2> =
                                                        LrcPtr::new(Math::Mut2 {
                                                            l0: MutCell::new(0_i32),
                                                            l1: MutCell::new(v675),
                                                        });
                                                    while Math::method15(v681, v682.clone()) {
                                                        let v684: i32 = v682.l0.get().clone();
                                                        let v685: num_complex::Complex<f64> =
                                                            v682.l1.get().clone();
                                                        let v686: i32 = v676[v684].clone();
                                                        let v688: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                1.0_f64, 0.0_f64,
                                                            );
                                                        let v691: f64 = v686 as f64;
                                                        let v702: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                v691, 0.0_f64,
                                                            );
                                                        let v704: num_complex::Complex<f64> =
                                                            num_complex::Complex::powc(
                                                                v702,
                                                                v664.clone(),
                                                            );
                                                        let v706: num_complex::Complex<f64> =
                                                            v688 / v704;
                                                        let v708: num_complex::Complex<f64> =
                                                            v685 + v706;
                                                        let v709: i32 = (v684) + 1_i32;
                                                        v682.l0.set(v709);
                                                        v682.l1.set(v708);
                                                        ()
                                                    }
                                                    v682.l1.get().clone()
                                                }
                                            } else {
                                                let v712: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v717: Result<
                                                    num_complex::Complex<f64>,
                                                    std::string::String,
                                                > = Math::method16(
                                                    v0_1,
                                                    string("        s = mpmath.gamma(s)"),
                                                    Math::method3(v712 - v664.clone()),
                                                );
                                                let v721: Option<num_complex::Complex<f64>> =
                                                    v717.ok();
                                                let v794: Math::US0 = defaultValue(
                                                    Math::US0::US0_1,
                                                    map(Math::method17(), v721),
                                                );
                                                let v806: f64 = f64::NAN;
                                                let v808: f64 = f64::NAN;
                                                let v810: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v806, v808);
                                                let v813: num_complex::Complex<f64> = match &v794 {
                                                    Math::US0::US0_0(v794_0_0) => match &v794 {
                                                        Math::US0::US0_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                    _ => v810.clone(),
                                                };
                                                let v815: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(
                                                        3.141592653589793_f64,
                                                        0.0_f64,
                                                    );
                                                let v817: num_complex::Complex<f64> =
                                                    v815 * v664.clone();
                                                let v819: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                let v821: num_complex::Complex<f64> = v817 / v819;
                                                let v823: num_complex::Complex<f64> = v821.sin();
                                                let v826: f64 = 1.0_f64 - (v664.clone().re);
                                                let v829: f64 = -v664.clone().im;
                                                let v831: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v826, v829);
                                                let v837: num_complex::Complex<f64> =
                                                    if (v831.clone().re) <= 1.0_f64 {
                                                        num_complex::Complex::new(0.0_f64, 0.0_f64)
                                                    } else {
                                                        v831
                                                    };
                                                let v839: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                let v841: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(
                                                        3.141592653589793_f64,
                                                        0.0_f64,
                                                    );
                                                let v843: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v841, v664.clone());
                                                let v845: num_complex::Complex<f64> = v839 * v843;
                                                let v847: num_complex::Complex<f64> = v845 * v823;
                                                let v849: num_complex::Complex<f64> = v847 * v813;
                                                v849 * v837
                                            }
                                        };
                                        let v855: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v857: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v859: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v857, v497.clone());
                                        let v861: num_complex::Complex<f64> = v855 * v859;
                                        let v863: num_complex::Complex<f64> = v861 * v656;
                                        let v865: num_complex::Complex<f64> = v863 * v646;
                                        v865 * v853
                                    }
                                };
                                let v871: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v873: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v875: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v873, v330.clone());
                                let v877: num_complex::Complex<f64> = v871 * v875;
                                let v879: num_complex::Complex<f64> = v877 * v489;
                                let v881: num_complex::Complex<f64> = v879 * v479;
                                v881 * v869
                            }
                        };
                        let v887: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v889: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v891: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v889, v163.clone());
                        let v893: num_complex::Complex<f64> = v887 * v891;
                        let v895: num_complex::Complex<f64> = v893 * v322;
                        let v897: num_complex::Complex<f64> = v895 * v312;
                        v897 * v885
                    }
                };
                let v903: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v905: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v907: num_complex::Complex<f64> =
                    num_complex::Complex::powc(v905, v1_1.clone());
                let v909: num_complex::Complex<f64> = v903 * v907;
                let v911: num_complex::Complex<f64> = v909 * v155;
                let v913: num_complex::Complex<f64> = v911 * v145;
                v913 * v901
            }
        }
        pub fn method18(v0_1: bool) -> bool {
            v0_1
        }
        pub fn method20() -> string {
            string("")
        }
        pub fn method21(v0_1: LrcPtr<Math::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("{ "));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method22(v0_1: LrcPtr<Math::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("expected"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method23(v0_1: LrcPtr<Math::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string(" = "));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method24(v0_1: LrcPtr<Math::Mut3>, v1_1: string) {
            let v4: string = append((v0_1.l0.get().clone()), (v1_1));
            v0_1.l0.set(v4);
            ()
        }
        pub fn method25(v0_1: LrcPtr<Math::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string(" }"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method19(v0_1: f64) -> string {
            let v10: LrcPtr<Math::Mut3> = LrcPtr::new(Math::Mut3 {
                l0: MutCell::new(Math::method20()),
            });
            Math::method21(v10.clone());
            Math::method22(v10.clone());
            Math::method23(v10.clone());
            Math::method24(v10.clone(), sprintf!("{:+.6}", v0_1));
            Math::method25(v10.clone());
            v10.l0.get().clone()
        }
        pub fn method27(v0_1: LrcPtr<Math::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("actual"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method28(v0_1: LrcPtr<Math::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("; "));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method26(v0_1: f64, v1_1: f64) -> string {
            let v11: LrcPtr<Math::Mut3> = LrcPtr::new(Math::Mut3 {
                l0: MutCell::new(Math::method20()),
            });
            Math::method21(v11.clone());
            Math::method27(v11.clone());
            Math::method23(v11.clone());
            Math::method24(v11.clone(), sprintf!("{:+.6}", v0_1));
            Math::method28(v11.clone());
            Math::method22(v11.clone());
            Math::method23(v11.clone());
            Math::method24(v11.clone(), sprintf!("{:+.6}", v1_1));
            Math::method25(v11.clone());
            v11.l0.get().clone()
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
                let v92: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v19));
                let v104: f64 = f64::NAN;
                let v106: f64 = f64::NAN;
                let v108: num_complex::Complex<f64> = num_complex::Complex::new(v104, v106);
                let v111: num_complex::Complex<f64> = match &v92 {
                    Math::US0::US0_0(v92_0_0) => match &v92 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v108.clone(),
                };
                let v113: f64 = v111.clone().im;
                let v114: bool = (v113) == 0.0_f64;
                let v116: bool = if v114 { true } else { Math::method18(v114) };
                let v121: string = if v114 {
                    Math::method19(0.0_f64)
                } else {
                    Math::method26(v113, 0.0_f64)
                };
                let v143: string = append(
                    string("__assert_eq "),
                    (if v114 {
                        Math::method19(0.0_f64)
                    } else {
                        Math::method26(v113, 0.0_f64)
                    }),
                );
                let v174: () = {
                    Math::closure2(v143.clone(), ());
                    ()
                };
                if (v116) == false {
                    panic!("{}", v143,);
                }
                {
                    let v187: f64 = (v111.re) - (patternInput.1.clone());
                    let v188: f64 = -v187;
                    let v190: f64 = if (v187) >= (v188) { v187 } else { v188 };
                    let v191: bool = (v190) < 0.0001_f64;
                    let v193: bool = if v191 { true } else { Math::method18(v191) };
                    let v198: string = if v191 {
                        Math::method19(0.0001_f64)
                    } else {
                        Math::method26(v190, 0.0001_f64)
                    };
                    let v218: string = append(
                        string("__assert_lt "),
                        (if v191 {
                            Math::method19(0.0001_f64)
                        } else {
                            Math::method26(v190, 0.0001_f64)
                        }),
                    );
                    let v249: () = {
                        Math::closure2(v218.clone(), ());
                        ()
                    };
                    if (v193) == false {
                        panic!("{}", v218,);
                    }
                    {
                        let v260: i32 = (v9) + 1_i32;
                        v7.l0.set(v260);
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
                    let v15: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v19: string = string("}}");
                    let v21: string = string("{");
                    let v26: bool = true;
                    let _fix_closure_v23 = v15;
                    let v32: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v23 "), (v19))),
                                string("); "),
                            )),
                            (v21),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v33: bool = true;
                    _fix_closure_v23
                }
            });
            {
                // rust.fix_closure';
                let v35: Result<(), pyo3::PyErr> = __run_test;
                v35.unwrap();
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
            let v10: Option<num_complex::Complex<f64>> = v5.ok();
            let v83: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v10));
            let v95: f64 = f64::NAN;
            let v97: f64 = f64::NAN;
            let v99: num_complex::Complex<f64> = num_complex::Complex::new(v95, v97);
            let v102: num_complex::Complex<f64> = match &v83 {
                Math::US0::US0_0(v83_0_0) => match &v83 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v99.clone(),
            };
            let v105: f64 = (v102.clone().re) - 0.8673_f64;
            let v106: f64 = -v105;
            let v108: f64 = if (v105) >= (v106) { v105 } else { v106 };
            let v109: bool = (v108) < 0.001_f64;
            let v111: bool = if v109 { true } else { Math::method18(v109) };
            let v116: string = if v109 {
                Math::method19(0.001_f64)
            } else {
                Math::method26(v108, 0.001_f64)
            };
            let v138: string = append(
                string("__assert_lt "),
                (if v109 {
                    Math::method19(0.001_f64)
                } else {
                    Math::method26(v108, 0.001_f64)
                }),
            );
            let v169: () = {
                Math::closure2(v138.clone(), ());
                ()
            };
            if (v111) == false {
                panic!("{}", v138,);
            }
            {
                let v182: f64 = (v102.im) - 0.275_f64;
                let v183: f64 = -v182;
                let v185: f64 = if (v182) >= (v183) { v182 } else { v183 };
                let v186: bool = (v185) < 0.001_f64;
                let v188: bool = if v186 { true } else { Math::method18(v186) };
                let v193: string = if v186 {
                    Math::method19(0.001_f64)
                } else {
                    Math::method26(v185, 0.001_f64)
                };
                let v211: string = append(
                    string("__assert_lt "),
                    (if v186 {
                        Math::method19(0.001_f64)
                    } else {
                        Math::method26(v185, 0.001_f64)
                    }),
                );
                let v242: () = {
                    Math::closure2(v211.clone(), ());
                    ()
                };
                if (v188) == false {
                    panic!("{}", v211,);
                }
            }
        }
        pub fn method30() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method31(py);
                {
                    let v15: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v19: string = string("}}");
                    let v21: string = string("{");
                    let v26: bool = true;
                    let _fix_closure_v23 = v15;
                    let v32: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v23 "), (v19))),
                                string("); "),
                            )),
                            (v21),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v33: bool = true;
                    _fix_closure_v23
                }
            });
            {
                // rust.fix_closure';
                let v35: Result<(), pyo3::PyErr> = __run_test;
                v35.unwrap();
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
                        let v13: Option<num_complex::Complex<f64>> = v8.ok();
                        let v86: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v13));
                        let v98: f64 = f64::NAN;
                        let v100: f64 = f64::NAN;
                        let v102: num_complex::Complex<f64> = num_complex::Complex::new(v98, v100);
                        let v105: num_complex::Complex<f64> = match &v86 {
                            Math::US0::US0_0(v86_0_0) => match &v86 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v102.clone(),
                        };
                        let v107: f64 = v105.clone().re;
                        let v108: bool = (v107) == 0.0_f64;
                        let v110: bool = if v108 { true } else { Math::method18(v108) };
                        let v115: string = if v108 {
                            Math::method19(0.0_f64)
                        } else {
                            Math::method26(v107, 0.0_f64)
                        };
                        let v137: string = append(
                            string("__assert_eq "),
                            (if v108 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v107, 0.0_f64)
                            }),
                        );
                        let v168: () = {
                            Math::closure2(v137.clone(), ());
                            ()
                        };
                        if (v110) == false {
                            panic!("{}", v137,);
                        }
                        {
                            let v180: f64 = v105.im;
                            let v181: bool = (v180) == 0.0_f64;
                            let v183: bool = if v181 { true } else { Math::method18(v181) };
                            let v188: string = if v181 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v180, 0.0_f64)
                            };
                            let v206: string = append(
                                string("__assert_eq "),
                                (if v181 {
                                    Math::method19(0.0_f64)
                                } else {
                                    Math::method26(v180, 0.0_f64)
                                }),
                            );
                            let v237: () = {
                                Math::closure2(v206.clone(), ());
                                ()
                            };
                            if (v183) == false {
                                panic!("{}", v206,);
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
                    let v15: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v19: string = string("}}");
                    let v21: string = string("{");
                    let v26: bool = true;
                    let _fix_closure_v23 = v15;
                    let v32: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v23 "), (v19))),
                                string("); "),
                            )),
                            (v21),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v33: bool = true;
                    _fix_closure_v23
                }
            });
            {
                // rust.fix_closure';
                let v35: Result<(), pyo3::PyErr> = __run_test;
                v35.unwrap();
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
                let v26: Option<num_complex::Complex<f64>> = v21.ok();
                let v99: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v26));
                let v111: f64 = f64::NAN;
                let v113: f64 = f64::NAN;
                let v115: num_complex::Complex<f64> = num_complex::Complex::new(v111, v113);
                let v118: num_complex::Complex<f64> = match &v99 {
                    Math::US0::US0_0(v99_0_0) => match &v99 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v115.clone(),
                };
                let v120: f64 = v118.clone().re;
                let v121: f64 = -v120;
                let v123: f64 = if (v120) >= (v121) { v120 } else { v121 };
                let v124: bool = (v123) < 0.0001_f64;
                let v126: bool = if v124 { true } else { Math::method18(v124) };
                let v131: string = if v124 {
                    Math::method19(0.0001_f64)
                } else {
                    Math::method26(v123, 0.0001_f64)
                };
                let v153: string = append(
                    string("__assert_lt "),
                    (if v124 {
                        Math::method19(0.0001_f64)
                    } else {
                        Math::method26(v123, 0.0001_f64)
                    }),
                );
                let v184: () = {
                    Math::closure2(v153.clone(), ());
                    ()
                };
                if (v126) == false {
                    panic!("{}", v153,);
                }
                {
                    let v196: f64 = v118.im;
                    let v197: f64 = -v196;
                    let v199: f64 = if (v196) >= (v197) { v196 } else { v197 };
                    let v200: bool = (v199) < 0.0001_f64;
                    let v202: bool = if v200 { true } else { Math::method18(v200) };
                    let v207: string = if v200 {
                        Math::method19(0.0001_f64)
                    } else {
                        Math::method26(v199, 0.0001_f64)
                    };
                    let v225: string = append(
                        string("__assert_lt "),
                        (if v200 {
                            Math::method19(0.0001_f64)
                        } else {
                            Math::method26(v199, 0.0001_f64)
                        }),
                    );
                    let v256: () = {
                        Math::closure2(v225.clone(), ());
                        ()
                    };
                    if (v202) == false {
                        panic!("{}", v225,);
                    }
                    {
                        let v267: i32 = (v17) + 1_i32;
                        v15.l0.set(v267);
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
                    let v15: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v19: string = string("}}");
                    let v21: string = string("{");
                    let v26: bool = true;
                    let _fix_closure_v23 = v15;
                    let v32: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v23 "), (v19))),
                                string("); "),
                            )),
                            (v21),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v33: bool = true;
                    _fix_closure_v23
                }
            });
            {
                // rust.fix_closure';
                let v35: Result<(), pyo3::PyErr> = __run_test;
                v35.unwrap();
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
                let v16: Option<num_complex::Complex<f64>> = v11.ok();
                let v89: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v16));
                let v101: f64 = f64::NAN;
                let v103: f64 = f64::NAN;
                let v105: num_complex::Complex<f64> = num_complex::Complex::new(v101, v103);
                let v108: num_complex::Complex<f64> = match &v89 {
                    Math::US0::US0_0(v89_0_0) => match &v89 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v105.clone(),
                };
                let v110: f64 = v108.clone().re;
                let v111: bool = (v110) > 0.0_f64;
                let v113: bool = if v111 { true } else { Math::method18(v111) };
                let v118: string = if v111 {
                    Math::method19(0.0_f64)
                } else {
                    Math::method26(v110, 0.0_f64)
                };
                let v140: string = append(
                    string("__assert_gt "),
                    (if v111 {
                        Math::method19(0.0_f64)
                    } else {
                        Math::method26(v110, 0.0_f64)
                    }),
                );
                let v171: () = {
                    Math::closure2(v140.clone(), ());
                    ()
                };
                if (v113) == false {
                    panic!("{}", v140,);
                }
                {
                    let v183: f64 = v108.im;
                    let v184: bool = (v183) == 0.0_f64;
                    let v186: bool = if v184 { true } else { Math::method18(v184) };
                    let v191: string = if v184 {
                        Math::method19(0.0_f64)
                    } else {
                        Math::method26(v183, 0.0_f64)
                    };
                    let v211: string = append(
                        string("__assert_eq "),
                        (if v184 {
                            Math::method19(0.0_f64)
                        } else {
                            Math::method26(v183, 0.0_f64)
                        }),
                    );
                    let v242: () = {
                        Math::closure2(v211.clone(), ());
                        ()
                    };
                    if (v186) == false {
                        panic!("{}", v211,);
                    }
                    {
                        let v253: i32 = (v5) + 1_i32;
                        v3.l0.set(v253);
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
                    let v15: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v19: string = string("}}");
                    let v21: string = string("{");
                    let v26: bool = true;
                    let _fix_closure_v23 = v15;
                    let v32: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v23 "), (v19))),
                                string("); "),
                            )),
                            (v21),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v33: bool = true;
                    _fix_closure_v23
                }
            });
            {
                // rust.fix_closure';
                let v35: Result<(), pyo3::PyErr> = __run_test;
                v35.unwrap();
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
            let v10: Option<num_complex::Complex<f64>> = v5.ok();
            let v83: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v10));
            let v95: f64 = f64::NAN;
            let v97: f64 = f64::NAN;
            let v99: num_complex::Complex<f64> = num_complex::Complex::new(v95, v97);
            let v102: num_complex::Complex<f64> = match &v83 {
                Math::US0::US0_0(v83_0_0) => match &v83 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v99.clone(),
            };
            let v104: f64 = v102.clone().re;
            let v105: bool = (v104) == (f64::INFINITY);
            let v107: bool = if v105 { true } else { Math::method18(v105) };
            let v112: string = if v105 {
                Math::method19(f64::INFINITY)
            } else {
                Math::method26(v104, f64::INFINITY)
            };
            let v134: string = append(
                string("__assert_eq "),
                (if v105 {
                    Math::method19(f64::INFINITY)
                } else {
                    Math::method26(v104, f64::INFINITY)
                }),
            );
            let v165: () = {
                Math::closure2(v134.clone(), ());
                ()
            };
            if (v107) == false {
                panic!("{}", v134,);
            }
            {
                let v177: f64 = v102.im;
                let v178: bool = (v177) == 0.0_f64;
                let v180: bool = if v178 { true } else { Math::method18(v178) };
                let v185: string = if v178 {
                    Math::method19(0.0_f64)
                } else {
                    Math::method26(v177, 0.0_f64)
                };
                let v203: string = append(
                    string("__assert_eq "),
                    (if v178 {
                        Math::method19(0.0_f64)
                    } else {
                        Math::method26(v177, 0.0_f64)
                    }),
                );
                let v234: () = {
                    Math::closure2(v203.clone(), ());
                    ()
                };
                if (v180) == false {
                    panic!("{}", v203,);
                }
            }
        }
        pub fn method40() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method41(py);
                {
                    let v15: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v19: string = string("}}");
                    let v21: string = string("{");
                    let v26: bool = true;
                    let _fix_closure_v23 = v15;
                    let v32: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v23 "), (v19))),
                                string("); "),
                            )),
                            (v21),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v33: bool = true;
                    _fix_closure_v23
                }
            });
            {
                // rust.fix_closure';
                let v35: Result<(), pyo3::PyErr> = __run_test;
                v35.unwrap();
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
            let v10: Option<num_complex::Complex<f64>> = v5.ok();
            let v83: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v10));
            let v95: f64 = f64::NAN;
            let v97: f64 = f64::NAN;
            let v99: num_complex::Complex<f64> = num_complex::Complex::new(v95, v97);
            let v102: num_complex::Complex<f64> = match &v83 {
                Math::US0::US0_0(v83_0_0) => match &v83 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v99.clone(),
            };
            let v104: f64 = v2.clone().re;
            let v107: f64 = -v2.im;
            let v109: num_complex::Complex<f64> = num_complex::Complex::new(v104, v107);
            let v112: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v109.clone()),
            );
            let v113: num_complex::Complex<f64> = Math::method13(v0_1, v109);
            let v117: Option<num_complex::Complex<f64>> = v112.ok();
            let v190: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v117));
            let v202: f64 = f64::NAN;
            let v204: f64 = f64::NAN;
            let v206: num_complex::Complex<f64> = num_complex::Complex::new(v202, v204);
            let v209: num_complex::Complex<f64> = match &v190 {
                Math::US0::US0_0(v190_0_0) => match &v190 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v206.clone(),
            };
            let v211: num_complex::Complex<f64> = v209.conj();
            let v213: f64 = v102.clone().re;
            let v215: f64 = v211.clone().re;
            let v216: bool = (v213) == (v215);
            let v218: bool = if v216 { true } else { Math::method18(v216) };
            let v221: string = if v216 {
                Math::method19(v215)
            } else {
                Math::method26(v213, v215)
            };
            let v241: string = append(
                string("__assert_eq "),
                (if v216 {
                    Math::method19(v215)
                } else {
                    Math::method26(v213, v215)
                }),
            );
            let v272: () = {
                Math::closure2(v241.clone(), ());
                ()
            };
            if (v218) == false {
                panic!("{}", v241,);
            }
            {
                let v284: f64 = v102.im;
                let v286: f64 = v211.im;
                let v287: bool = (v284) == (v286);
                let v289: bool = if v287 { true } else { Math::method18(v287) };
                let v292: string = if v287 {
                    Math::method19(v286)
                } else {
                    Math::method26(v284, v286)
                };
                let v308: string = append(
                    string("__assert_eq "),
                    (if v287 {
                        Math::method19(v286)
                    } else {
                        Math::method26(v284, v286)
                    }),
                );
                let v339: () = {
                    Math::closure2(v308.clone(), ());
                    ()
                };
                if (v289) == false {
                    panic!("{}", v308,);
                }
            }
        }
        pub fn method42() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method43(py);
                {
                    let v15: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v19: string = string("}}");
                    let v21: string = string("{");
                    let v26: bool = true;
                    let _fix_closure_v23 = v15;
                    let v32: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v23 "), (v19))),
                                string("); "),
                            )),
                            (v21),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v33: bool = true;
                    _fix_closure_v23
                }
            });
            {
                // rust.fix_closure';
                let v35: Result<(), pyo3::PyErr> = __run_test;
                v35.unwrap();
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
            let v10: Option<num_complex::Complex<f64>> = v5.ok();
            let v83: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v10));
            let v95: f64 = f64::NAN;
            let v97: f64 = f64::NAN;
            let v99: num_complex::Complex<f64> = num_complex::Complex::new(v95, v97);
            let v102: num_complex::Complex<f64> = match &v83 {
                Math::US0::US0_0(v83_0_0) => match &v83 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v99.clone(),
            };
            let v104: f64 = v102.clone().re;
            let v105: bool = (v104) < (f64::INFINITY);
            let v107: bool = if v105 { true } else { Math::method18(v105) };
            let v112: string = if v105 {
                Math::method19(f64::INFINITY)
            } else {
                Math::method26(v104, f64::INFINITY)
            };
            let v134: string = append(
                string("__assert_lt "),
                (if v105 {
                    Math::method19(f64::INFINITY)
                } else {
                    Math::method26(v104, f64::INFINITY)
                }),
            );
            let v165: () = {
                Math::closure2(v134.clone(), ());
                ()
            };
            if (v107) == false {
                panic!("{}", v134,);
            }
            {
                let v177: f64 = v102.im;
                let v178: bool = (v177) < (f64::INFINITY);
                let v180: bool = if v178 { true } else { Math::method18(v178) };
                let v185: string = if v178 {
                    Math::method19(f64::INFINITY)
                } else {
                    Math::method26(v177, f64::INFINITY)
                };
                let v203: string = append(
                    string("__assert_lt "),
                    (if v178 {
                        Math::method19(f64::INFINITY)
                    } else {
                        Math::method26(v177, f64::INFINITY)
                    }),
                );
                let v234: () = {
                    Math::closure2(v203.clone(), ());
                    ()
                };
                if (v180) == false {
                    panic!("{}", v203,);
                }
            }
        }
        pub fn method44() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method45(py);
                {
                    let v15: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v19: string = string("}}");
                    let v21: string = string("{");
                    let v26: bool = true;
                    let _fix_closure_v23 = v15;
                    let v32: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v23 "), (v19))),
                                string("); "),
                            )),
                            (v21),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v33: bool = true;
                    _fix_closure_v23
                }
            });
            {
                // rust.fix_closure';
                let v35: Result<(), pyo3::PyErr> = __run_test;
                v35.unwrap();
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
                        let v13: Option<num_complex::Complex<f64>> = v8.ok();
                        let v86: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v13));
                        let v98: f64 = f64::NAN;
                        let v100: f64 = f64::NAN;
                        let v102: num_complex::Complex<f64> = num_complex::Complex::new(v98, v100);
                        let v105: num_complex::Complex<f64> = match &v86 {
                            Math::US0::US0_0(v86_0_0) => match &v86 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v102.clone(),
                        };
                        let v107: f64 = v105.clone().re;
                        let v109: bool = (v107) != 0.0_f64;
                        let v120: bool = if v109 { true } else { Math::method18(v109) };
                        let v125: string = if v109 {
                            Math::method19(0.0_f64)
                        } else {
                            Math::method26(v107, 0.0_f64)
                        };
                        let v147: string = append(
                            string("__assert_ne "),
                            (if v109 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v107, 0.0_f64)
                            }),
                        );
                        let v178: () = {
                            Math::closure2(v147.clone(), ());
                            ()
                        };
                        if (v120) == false {
                            panic!("{}", v147,);
                        }
                        {
                            let v190: f64 = v105.im;
                            let v192: bool = (v190) != 0.0_f64;
                            let v203: bool = if v192 { true } else { Math::method18(v192) };
                            let v208: string = if v192 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v190, 0.0_f64)
                            };
                            let v226: string = append(
                                string("__assert_ne "),
                                (if v192 {
                                    Math::method19(0.0_f64)
                                } else {
                                    Math::method26(v190, 0.0_f64)
                                }),
                            );
                            let v257: () = {
                                Math::closure2(v226.clone(), ());
                                ()
                            };
                            if (v203) == false {
                                panic!("{}", v226,);
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
                    let v15: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v19: string = string("}}");
                    let v21: string = string("{");
                    let v26: bool = true;
                    let _fix_closure_v23 = v15;
                    let v32: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v23 "), (v19))),
                                string("); "),
                            )),
                            (v21),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v33: bool = true;
                    _fix_closure_v23
                }
            });
            {
                // rust.fix_closure';
                let v35: Result<(), pyo3::PyErr> = __run_test;
                v35.unwrap();
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
                        let v11: Option<num_complex::Complex<f64>> = v6.ok();
                        let v84: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v11));
                        let v96: f64 = f64::NAN;
                        let v98: f64 = f64::NAN;
                        let v100: num_complex::Complex<f64> = num_complex::Complex::new(v96, v98);
                        let v103: num_complex::Complex<f64> = match &v84 {
                            Math::US0::US0_0(v84_0_0) => match &v84 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v100.clone(),
                        };
                        let v105: f64 = v103.clone().re;
                        let v107: bool = (v105) != 0.0_f64;
                        let v118: bool = if v107 { true } else { Math::method18(v107) };
                        let v123: string = if v107 {
                            Math::method19(0.0_f64)
                        } else {
                            Math::method26(v105, 0.0_f64)
                        };
                        let v145: string = append(
                            string("__assert_ne "),
                            (if v107 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v105, 0.0_f64)
                            }),
                        );
                        let v176: () = {
                            Math::closure2(v145.clone(), ());
                            ()
                        };
                        if (v118) == false {
                            panic!("{}", v145,);
                        }
                        {
                            let v188: f64 = v103.im;
                            let v190: bool = (v188) != 0.0_f64;
                            let v201: bool = if v190 { true } else { Math::method18(v190) };
                            let v206: string = if v190 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v188, 0.0_f64)
                            };
                            let v224: string = append(
                                string("__assert_ne "),
                                (if v190 {
                                    Math::method19(0.0_f64)
                                } else {
                                    Math::method26(v188, 0.0_f64)
                                }),
                            );
                            let v255: () = {
                                Math::closure2(v224.clone(), ());
                                ()
                            };
                            if (v201) == false {
                                panic!("{}", v224,);
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
                    let v15: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v19: string = string("}}");
                    let v21: string = string("{");
                    let v26: bool = true;
                    let _fix_closure_v23 = v15;
                    let v32: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v23 "), (v19))),
                                string("); "),
                            )),
                            (v21),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v33: bool = true;
                    _fix_closure_v23
                }
            });
            {
                // rust.fix_closure';
                let v35: Result<(), pyo3::PyErr> = __run_test;
                v35.unwrap();
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
                        let v11: Option<num_complex::Complex<f64>> = v6.ok();
                        let v84: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v11));
                        let v96: f64 = f64::NAN;
                        let v98: f64 = f64::NAN;
                        let v100: num_complex::Complex<f64> = num_complex::Complex::new(v96, v98);
                        let v103: num_complex::Complex<f64> = match &v84 {
                            Math::US0::US0_0(v84_0_0) => match &v84 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v100.clone(),
                        };
                        let v105: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v107: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v105, v2.clone());
                        let v109: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v111: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v113: num_complex::Complex<f64> = v2.clone() - v111;
                        let v115: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v109, v113);
                        let v117: num_complex::Complex<f64> = v107 * v115;
                        let v119: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v121: num_complex::Complex<f64> = v119 * v2.clone();
                        let v123: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v125: num_complex::Complex<f64> = v121 / v123;
                        let v127: num_complex::Complex<f64> = v125.sin();
                        let v129: num_complex::Complex<f64> = v117 * v127;
                        let v131: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v136: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method16(
                                v0_1.get().clone(),
                                string("        s = mpmath.gamma(s)"),
                                Math::method3(v131 - v2.clone()),
                            );
                        let v140: Option<num_complex::Complex<f64>> = v136.ok();
                        let v213: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v140));
                        let v225: f64 = f64::NAN;
                        let v227: f64 = f64::NAN;
                        let v229: num_complex::Complex<f64> = num_complex::Complex::new(v225, v227);
                        let v232: num_complex::Complex<f64> = match &v213 {
                            Math::US0::US0_0(v213_0_0) => match &v213 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v229.clone(),
                        };
                        let v234: num_complex::Complex<f64> = v129 * v232;
                        let v237: f64 = 1.0_f64 - (v2.clone().re);
                        let v240: f64 = -v2.im;
                        let v242: num_complex::Complex<f64> = num_complex::Complex::new(v237, v240);
                        let v245: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(
                                v0_1.get().clone(),
                                string("        s = mpmath.zeta(s)"),
                                Math::method3(v242.clone()),
                            );
                        let v246: num_complex::Complex<f64> =
                            Math::method13(v0_1.get().clone(), v242);
                        let v250: Option<num_complex::Complex<f64>> = v245.ok();
                        let v323: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v250));
                        let v335: f64 = f64::NAN;
                        let v337: f64 = f64::NAN;
                        let v339: num_complex::Complex<f64> = num_complex::Complex::new(v335, v337);
                        let v342: num_complex::Complex<f64> = match &v323 {
                            Math::US0::US0_0(v323_0_0) => match &v323 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v339.clone(),
                        };
                        let v344: num_complex::Complex<f64> = v234 * v342;
                        let v349: f64 = (v103.clone().re) - (v344.clone().re);
                        let v350: f64 = -v349;
                        let v352: f64 = if (v349) >= (v350) { v349 } else { v350 };
                        let v353: bool = (v352) < 0.0001_f64;
                        let v355: bool = if v353 { true } else { Math::method18(v353) };
                        let v360: string = if v353 {
                            Math::method19(0.0001_f64)
                        } else {
                            Math::method26(v352, 0.0001_f64)
                        };
                        let v382: string = append(
                            string("__assert_lt "),
                            (if v353 {
                                Math::method19(0.0001_f64)
                            } else {
                                Math::method26(v352, 0.0001_f64)
                            }),
                        );
                        let v413: () = {
                            Math::closure2(v382.clone(), ());
                            ()
                        };
                        if (v355) == false {
                            panic!("{}", v382,);
                        }
                        {
                            let v428: f64 = (v103.im) - (v344.im);
                            let v429: f64 = -v428;
                            let v431: f64 = if (v428) >= (v429) { v428 } else { v429 };
                            let v432: bool = (v431) < 0.0001_f64;
                            let v434: bool = if v432 { true } else { Math::method18(v432) };
                            let v439: string = if v432 {
                                Math::method19(0.0001_f64)
                            } else {
                                Math::method26(v431, 0.0001_f64)
                            };
                            let v457: string = append(
                                string("__assert_lt "),
                                (if v432 {
                                    Math::method19(0.0001_f64)
                                } else {
                                    Math::method26(v431, 0.0001_f64)
                                }),
                            );
                            let v488: () = {
                                Math::closure2(v457.clone(), ());
                                ()
                            };
                            if (v434) == false {
                                panic!("{}", v457,);
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
                    let v15: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v19: string = string("}}");
                    let v21: string = string("{");
                    let v26: bool = true;
                    let _fix_closure_v23 = v15;
                    let v32: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v23 "), (v19))),
                                string("); "),
                            )),
                            (v21),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v33: bool = true;
                    _fix_closure_v23
                }
            });
            {
                // rust.fix_closure';
                let v35: Result<(), pyo3::PyErr> = __run_test;
                v35.unwrap();
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
                        let v16: Option<num_complex::Complex<f64>> = v11.ok();
                        let v89: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v16));
                        let v101: f64 = f64::NAN;
                        let v103: f64 = f64::NAN;
                        let v105: num_complex::Complex<f64> = num_complex::Complex::new(v101, v103);
                        let v108: num_complex::Complex<f64> = match &v89 {
                            Math::US0::US0_0(v89_0_0) => match &v89 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v105.clone(),
                        };
                        let v111: f64 = (v108.clone().re) - (v8);
                        let v112: f64 = -v111;
                        let v114: f64 = if (v111) >= (v112) { v111 } else { v112 };
                        let v115: bool = (v114) < 0.01_f64;
                        let v117: bool = if v115 { true } else { Math::method18(v115) };
                        let v122: string = if v115 {
                            Math::method19(0.01_f64)
                        } else {
                            Math::method26(v114, 0.01_f64)
                        };
                        let v144: string = append(
                            string("__assert_lt "),
                            (if v115 {
                                Math::method19(0.01_f64)
                            } else {
                                Math::method26(v114, 0.01_f64)
                            }),
                        );
                        let v175: () = {
                            Math::closure2(v144.clone(), ());
                            ()
                        };
                        if (v117) == false {
                            panic!("{}", v144,);
                        }
                        {
                            let v187: f64 = v108.im;
                            let v188: bool = (v187) < 0.01_f64;
                            let v190: bool = if v188 { true } else { Math::method18(v188) };
                            let v195: string = if v188 {
                                Math::method19(0.01_f64)
                            } else {
                                Math::method26(v187, 0.01_f64)
                            };
                            let v213: string = append(
                                string("__assert_lt "),
                                (if v188 {
                                    Math::method19(0.01_f64)
                                } else {
                                    Math::method26(v187, 0.01_f64)
                                }),
                            );
                            let v244: () = {
                                Math::closure2(v213.clone(), ());
                                ()
                            };
                            if (v190) == false {
                                panic!("{}", v213,);
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
                    let v15: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v19: string = string("}}");
                    let v21: string = string("{");
                    let v26: bool = true;
                    let _fix_closure_v23 = v15;
                    let v32: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v23 "), (v19))),
                                string("); "),
                            )),
                            (v21),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v33: bool = true;
                    _fix_closure_v23
                }
            });
            {
                // rust.fix_closure';
                let v35: Result<(), pyo3::PyErr> = __run_test;
                v35.unwrap();
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
            let v23: () = {
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
