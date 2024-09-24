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
use fable_library_rust::NativeArray_::array_from;
use fable_library_rust::String_::fromString;
mod module_b7a9935b {
    pub mod Math {
        use super::*;
        use fable_library_rust::NativeArray_::count;
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
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        on_startup!();
        use pyo3::prelude::PyAnyMethods;
        //,);
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut0 {
            pub l0: MutCell<i32>,
        }
        impl core::fmt::Display for Math::Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut1 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<string>,
        }
        impl core::fmt::Display for Math::Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default)]
        pub struct Mut2 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<num_complex::Complex<f64>>,
        }
        impl core::fmt::Display for Math::Mut2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US0 {
            US0_0(num_complex::Complex<f64>),
            US0_1,
        }
        impl core::fmt::Display for Math::US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd)]
        pub enum UH0 {
            UH0_0,
            UH0_1(f64, LrcPtr<Math::UH0>),
        }
        impl core::fmt::Display for Math::UH0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH1 {
            UH1_0,
            UH1_1(num_complex::Complex<f64>, LrcPtr<Math::UH1>),
        }
        impl core::fmt::Display for Math::UH1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn method2(v0_1: i32, v1_1: LrcPtr<Math::Mut0>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method3(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method6(v0_1: i32, v1_1: LrcPtr<Math::Mut1>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method5(v0_1: Array<string>) -> string {
            let v1_1: i32 = count(v0_1.clone());
            let v3: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                l0: MutCell::new(0_i32),
                l1: MutCell::new(string("")),
            });
            while Math::method6(v1_1, v3.clone()) {
                let v5: i32 = v3.l0.get().clone();
                let v9: string = append(
                    append(append(v3.l1.get().clone(), v0_1[v5].clone()), string("\n")),
                    string(""),
                );
                let v10: i32 = v5 + 1_i32;
                v3.l0.set(v10);
                v3.l1.set(v9);
                ()
            }
            v3.l1.get().clone()
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
                                          sprintf!("            print(f\"{{event}}({}) / f_code.co_name: {{frame.f_code.co_name}} / f_locals: {{args_str}} / f_lineno: {{frame.f_lineno}} / f_code.co_filename: {{frame.f_code.co_filename.split(\'site-packages\')[-1]}} / f_back.f_lineno: {{ \'\' if frame.f_back is None else frame.f_back.f_lineno }} / f_back.f_code.co_filename: {{ \'\' if frame.f_back is None else frame.f_back.f_code.co_filename.split(\'site-packages\')[-1] }} / arg: {{re.sub(memory_address_pattern, \' at 0x<?>\', repr(arg))}}\", flush=True)",
                                                   string("zeta_")),
                                          string("        except ValueError as e:"),
                                          sprintf!("            print(f\'{} / e: {{e}}\', flush=True)",
                                                   string("zeta_")),
                                          string("        return trace_calls"),
                                          string("import mpmath"),
                                          string("def fn(log, s):"),
                                          string("    global count"),
                                          string("    if log:"),
                                          sprintf!("        print(f\'{} / s: {{s}} / count: {{count}}\', flush=True)",
                                                   string("zeta_")),
                                          string("    s = complex(*s)"),
                                          string("    try:"),
                                          string("        if log: sys.settrace(trace_calls)"),
                                          v1_1, string("        if log:"),
                                          string("            sys.settrace(None)"),
                                          sprintf!("            print(f\'{} / result: {{s}} / count: {{count}}\', flush=True)",
                                                   string("zeta_")),
                                          string("    except ValueError as e:"),
                                          string("        if s.real == 1:"),
                                          string("            s = complex(float(\'inf\'), 0)"),
                                          string("    return (s.real, s.imag)")]));
            let v42: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v2.clone().re, v2.im))));
            let v43: pyo3::Python = Math::method7(v0_1);
            let v45: &str = &*v36;
            let v47: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code_bound(v43, v45, "", "");
            let v49: bool = true;
            let _result_map_error__ = v47.map_err(|x| {
                //;
                let v51: pyo3::PyErr = x;
                let v54: std::string::String = format!("{}", v51);
                let v74: bool = true;
                v54
            });
            let v76: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                _result_map_error__;
            let v78: pyo3::Bound<pyo3::types::PyModule> = v76.unwrap();
            let v79: string = Math::method8();
            let v81: &str = &*v79;
            let v82: pyo3::Bound<pyo3::types::PyModule> = Math::method9(v78);
            let v84: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v82.getattr(v81);
            let v86: bool = true;
            let _result_map_error__ = v84.map_err(|x| {
                //;
                let v88: pyo3::PyErr = x;
                let v91: std::string::String = format!("{}", v88);
                let v111: bool = true;
                v91
            });
            let v113: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v115: pyo3::Bound<pyo3::PyAny> = v113.unwrap();
            let v116: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method10(v42.0.clone(), v42.1.clone());
            let v117: pyo3::Bound<pyo3::PyAny> = Math::method11(v115);
            let v119: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                pyo3::prelude::PyAnyMethods::call(&v117, ((*v116).0, *(*v116).1), None);
            let v121: bool = true;
            let _result_map_error__ = v119.map_err(|x| {
                //;
                let v123: pyo3::PyErr = x;
                let v126: std::string::String = format!("{}", v123);
                let v146: bool = true;
                v126
            });
            let v148: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v151: pyo3::Bound<pyo3::PyAny> = Math::method12(v148?);
            let v153: Result<(f64, f64), pyo3::PyErr> = v151.extract();
            let v155: bool = true;
            let _result_map_error__ = v153.map_err(|x| {
                //;
                let v157: pyo3::PyErr = x;
                let v160: std::string::String = format!("{}", v157);
                let v180: bool = true;
                v160
            });
            let v182: Result<(f64, f64), std::string::String> = _result_map_error__;
            let patternInput: (f64, f64) = v182?;
            Ok::<num_complex::Complex<f64>, std::string::String>(num_complex::Complex::new(
                patternInput.0.clone(),
                patternInput.1.clone(),
            ))
        }
        pub fn method14(v0_1: LrcPtr<Math::Mut0>) -> bool {
            v0_1.l0.get().clone() < 10000_i32
        }
        pub fn method15(v0_1: i32, v1_1: LrcPtr<Math::Mut2>) -> bool {
            v1_1.l0.get().clone() < v0_1
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
                                          sprintf!("            print(f\"{{event}}({}) / f_code.co_name: {{frame.f_code.co_name}} / f_locals: {{args_str}} / f_lineno: {{frame.f_lineno}} / f_code.co_filename: {{frame.f_code.co_filename.split(\'site-packages\')[-1]}} / f_back.f_lineno: {{ \'\' if frame.f_back is None else frame.f_back.f_lineno }} / f_back.f_code.co_filename: {{ \'\' if frame.f_back is None else frame.f_back.f_code.co_filename.split(\'site-packages\')[-1] }} / arg: {{re.sub(memory_address_pattern, \' at 0x<?>\', repr(arg))}}\", flush=True)",
                                                   string("gamma_")),
                                          string("        except ValueError as e:"),
                                          sprintf!("            print(f\'{} / e: {{e}}\', flush=True)",
                                                   string("gamma_")),
                                          string("        return trace_calls"),
                                          string("import mpmath"),
                                          string("def fn(log, s):"),
                                          string("    global count"),
                                          string("    if log:"),
                                          sprintf!("        print(f\'{} / s: {{s}} / count: {{count}}\', flush=True)",
                                                   string("gamma_")),
                                          string("    s = complex(*s)"),
                                          string("    try:"),
                                          string("        if log: sys.settrace(trace_calls)"),
                                          v1_1, string("        if log:"),
                                          string("            sys.settrace(None)"),
                                          sprintf!("            print(f\'{} / result: {{s}} / count: {{count}}\', flush=True)",
                                                   string("gamma_")),
                                          string("    except ValueError as e:"),
                                          string("        if s.real == 1:"),
                                          string("            s = complex(float(\'inf\'), 0)"),
                                          string("    return (s.real, s.imag)")]));
            let v42: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v2.clone().re, v2.im))));
            let v43: pyo3::Python = Math::method7(v0_1);
            let v45: &str = &*v36;
            let v47: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code_bound(v43, v45, "", "");
            let v49: bool = true;
            let _result_map_error__ = v47.map_err(|x| {
                //;
                let v51: pyo3::PyErr = x;
                let v54: std::string::String = format!("{}", v51);
                let v74: bool = true;
                v54
            });
            let v76: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                _result_map_error__;
            let v78: pyo3::Bound<pyo3::types::PyModule> = v76.unwrap();
            let v79: string = Math::method8();
            let v81: &str = &*v79;
            let v82: pyo3::Bound<pyo3::types::PyModule> = Math::method9(v78);
            let v84: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v82.getattr(v81);
            let v86: bool = true;
            let _result_map_error__ = v84.map_err(|x| {
                //;
                let v88: pyo3::PyErr = x;
                let v91: std::string::String = format!("{}", v88);
                let v111: bool = true;
                v91
            });
            let v113: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v115: pyo3::Bound<pyo3::PyAny> = v113.unwrap();
            let v116: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method10(v42.0.clone(), v42.1.clone());
            let v117: pyo3::Bound<pyo3::PyAny> = Math::method11(v115);
            let v119: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                pyo3::prelude::PyAnyMethods::call(&v117, ((*v116).0, *(*v116).1), None);
            let v121: bool = true;
            let _result_map_error__ = v119.map_err(|x| {
                //;
                let v123: pyo3::PyErr = x;
                let v126: std::string::String = format!("{}", v123);
                let v146: bool = true;
                v126
            });
            let v148: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v151: pyo3::Bound<pyo3::PyAny> = Math::method12(v148?);
            let v153: Result<(f64, f64), pyo3::PyErr> = v151.extract();
            let v155: bool = true;
            let _result_map_error__ = v153.map_err(|x| {
                //;
                let v157: pyo3::PyErr = x;
                let v160: std::string::String = format!("{}", v157);
                let v180: bool = true;
                v160
            });
            let v182: Result<(f64, f64), std::string::String> = _result_map_error__;
            let patternInput: (f64, f64) = v182?;
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
            if v1_1.clone().re > 1.0_f64 {
                let v7: num_complex::Complex<f64> = num_complex::Complex::new(0.0_f64, 0.0_f64);
                let v8: Array<i32> = new_init(&0_i32, 10000_i32);
                let v9: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                    l0: MutCell::new(0_i32),
                });
                while Math::method14(v9.clone()) {
                    let v11: i32 = v9.l0.get().clone();
                    v8.get_mut()[v11 as usize] = v11;
                    {
                        let v12: i32 = v11 + 1_i32;
                        v9.l0.set(v12);
                        ()
                    }
                }
                {
                    let v13: i32 = count(v8.clone());
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
                        let v24: num_complex::Complex<f64> =
                            num_complex::Complex::new(v22, 0.0_f64);
                        let v26: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v24, v1_1.clone());
                        let v28: num_complex::Complex<f64> = v20 / v26;
                        let v30: num_complex::Complex<f64> = v17 + v28;
                        let v31: i32 = v16 + 1_i32;
                        v14.l0.set(v31);
                        v14.l1.set(v30);
                        ()
                    }
                    v14.l1.get().clone()
                }
            } else {
                let v34: num_complex::Complex<f64> = num_complex::Complex::new(1.0_f64, 0.0_f64);
                let v39: Result<num_complex::Complex<f64>, std::string::String> = Math::method16(
                    v0_1.clone(),
                    string("        s = mpmath.gamma(s)"),
                    Math::method3(v34 - v1_1.clone()),
                );
                let v41: Option<num_complex::Complex<f64>> = v39.ok();
                let v55: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v41));
                let v60: f64 = f64::NAN;
                let v62: f64 = f64::NAN;
                let v64: num_complex::Complex<f64> = num_complex::Complex::new(v60, v62);
                let v67: num_complex::Complex<f64> = match &v55 {
                    Math::US0::US0_0(v55_0_0) => match &v55 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v64,
                };
                let v69: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v71: num_complex::Complex<f64> = v69 * v1_1.clone();
                let v73: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v75: num_complex::Complex<f64> = v71 / v73;
                let v77: num_complex::Complex<f64> = v75.sin();
                let v80: f64 = 1.0_f64 - v1_1.clone().re;
                let v83: f64 = -v1_1.clone().im;
                let v85: num_complex::Complex<f64> = num_complex::Complex::new(v80, v83);
                let v511: num_complex::Complex<f64> = if v85.clone().re <= 1.0_f64 {
                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                } else {
                    println!("zeta / count: {:?} / s: {:?}", 1_i32, v85.clone());
                    if v85.clone().re > 1.0_f64 {
                        let v96: num_complex::Complex<f64> =
                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                        let v97: Array<i32> = new_init(&0_i32, 10000_i32);
                        let v98: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                            l0: MutCell::new(0_i32),
                        });
                        while Math::method14(v98.clone()) {
                            let v100: i32 = v98.l0.get().clone();
                            v97.get_mut()[v100 as usize] = v100;
                            {
                                let v101: i32 = v100 + 1_i32;
                                v98.l0.set(v101);
                                ()
                            }
                        }
                        {
                            let v102: i32 = count(v97.clone());
                            let v103: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                l0: MutCell::new(0_i32),
                                l1: MutCell::new(v96),
                            });
                            while Math::method15(v102, v103.clone()) {
                                let v105: i32 = v103.l0.get().clone();
                                let v106: num_complex::Complex<f64> = v103.l1.get().clone();
                                let v107: i32 = v97[v105].clone();
                                let v109: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v111: f64 = v107 as f64;
                                let v113: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v111, 0.0_f64);
                                let v115: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v113, v85.clone());
                                let v117: num_complex::Complex<f64> = v109 / v115;
                                let v119: num_complex::Complex<f64> = v106 + v117;
                                let v120: i32 = v105 + 1_i32;
                                v103.l0.set(v120);
                                v103.l1.set(v119);
                                ()
                            }
                            v103.l1.get().clone()
                        }
                    } else {
                        let v123: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v128: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method16(
                                v0_1.clone(),
                                string("        s = mpmath.gamma(s)"),
                                Math::method3(v123 - v85.clone()),
                            );
                        let v130: Option<num_complex::Complex<f64>> = v128.ok();
                        let v144: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v130));
                        let v149: f64 = f64::NAN;
                        let v151: f64 = f64::NAN;
                        let v153: num_complex::Complex<f64> = num_complex::Complex::new(v149, v151);
                        let v156: num_complex::Complex<f64> = match &v144 {
                            Math::US0::US0_0(v144_0_0) => match &v144 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v153,
                        };
                        let v158: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v160: num_complex::Complex<f64> = v158 * v85.clone();
                        let v162: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v164: num_complex::Complex<f64> = v160 / v162;
                        let v166: num_complex::Complex<f64> = v164.sin();
                        let v169: f64 = 1.0_f64 - v85.clone().re;
                        let v172: f64 = -v85.clone().im;
                        let v174: num_complex::Complex<f64> = num_complex::Complex::new(v169, v172);
                        let v495: num_complex::Complex<f64> = if v174.clone().re <= 1.0_f64 {
                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                        } else {
                            println!("zeta / count: {:?} / s: {:?}", 2_i32, v174.clone());
                            if v174.clone().re > 1.0_f64 {
                                let v185: num_complex::Complex<f64> =
                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                let v186: Array<i32> = new_init(&0_i32, 10000_i32);
                                let v187: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Math::method14(v187.clone()) {
                                    let v189: i32 = v187.l0.get().clone();
                                    v186.get_mut()[v189 as usize] = v189;
                                    {
                                        let v190: i32 = v189 + 1_i32;
                                        v187.l0.set(v190);
                                        ()
                                    }
                                }
                                {
                                    let v191: i32 = count(v186.clone());
                                    let v192: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                        l0: MutCell::new(0_i32),
                                        l1: MutCell::new(v185),
                                    });
                                    while Math::method15(v191, v192.clone()) {
                                        let v194: i32 = v192.l0.get().clone();
                                        let v195: num_complex::Complex<f64> = v192.l1.get().clone();
                                        let v196: i32 = v186[v194].clone();
                                        let v198: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v200: f64 = v196 as f64;
                                        let v202: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v200, 0.0_f64);
                                        let v204: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v202, v174.clone());
                                        let v206: num_complex::Complex<f64> = v198 / v204;
                                        let v208: num_complex::Complex<f64> = v195 + v206;
                                        let v209: i32 = v194 + 1_i32;
                                        v192.l0.set(v209);
                                        v192.l1.set(v208);
                                        ()
                                    }
                                    v192.l1.get().clone()
                                }
                            } else {
                                let v212: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v217: Result<num_complex::Complex<f64>, std::string::String> =
                                    Math::method16(
                                        v0_1.clone(),
                                        string("        s = mpmath.gamma(s)"),
                                        Math::method3(v212 - v174.clone()),
                                    );
                                let v219: Option<num_complex::Complex<f64>> = v217.ok();
                                let v233: Math::US0 =
                                    defaultValue(Math::US0::US0_1, map(Math::method17(), v219));
                                let v238: f64 = f64::NAN;
                                let v240: f64 = f64::NAN;
                                let v242: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v238, v240);
                                let v245: num_complex::Complex<f64> = match &v233 {
                                    Math::US0::US0_0(v233_0_0) => match &v233 {
                                        Math::US0::US0_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => v242,
                                };
                                let v247: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v249: num_complex::Complex<f64> = v247 * v174.clone();
                                let v251: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v253: num_complex::Complex<f64> = v249 / v251;
                                let v255: num_complex::Complex<f64> = v253.sin();
                                let v258: f64 = 1.0_f64 - v174.clone().re;
                                let v261: f64 = -v174.clone().im;
                                let v263: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v258, v261);
                                let v479: num_complex::Complex<f64> = if v263.clone().re <= 1.0_f64
                                {
                                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                                } else {
                                    println!("zeta / count: {:?} / s: {:?}", 3_i32, v263.clone());
                                    if v263.clone().re > 1.0_f64 {
                                        let v274: num_complex::Complex<f64> =
                                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                                        let v275: Array<i32> = new_init(&0_i32, 10000_i32);
                                        let v276: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                            l0: MutCell::new(0_i32),
                                        });
                                        while Math::method14(v276.clone()) {
                                            let v278: i32 = v276.l0.get().clone();
                                            v275.get_mut()[v278 as usize] = v278;
                                            {
                                                let v279: i32 = v278 + 1_i32;
                                                v276.l0.set(v279);
                                                ()
                                            }
                                        }
                                        {
                                            let v280: i32 = count(v275.clone());
                                            let v281: LrcPtr<Math::Mut2> =
                                                LrcPtr::new(Math::Mut2 {
                                                    l0: MutCell::new(0_i32),
                                                    l1: MutCell::new(v274),
                                                });
                                            while Math::method15(v280, v281.clone()) {
                                                let v283: i32 = v281.l0.get().clone();
                                                let v284: num_complex::Complex<f64> =
                                                    v281.l1.get().clone();
                                                let v285: i32 = v275[v283].clone();
                                                let v287: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v289: f64 = v285 as f64;
                                                let v291: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v289, 0.0_f64);
                                                let v293: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v291, v263.clone());
                                                let v295: num_complex::Complex<f64> = v287 / v293;
                                                let v297: num_complex::Complex<f64> = v284 + v295;
                                                let v298: i32 = v283 + 1_i32;
                                                v281.l0.set(v298);
                                                v281.l1.set(v297);
                                                ()
                                            }
                                            v281.l1.get().clone()
                                        }
                                    } else {
                                        let v301: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v306: Result<
                                            num_complex::Complex<f64>,
                                            std::string::String,
                                        > = Math::method16(
                                            v0_1.clone(),
                                            string("        s = mpmath.gamma(s)"),
                                            Math::method3(v301 - v263.clone()),
                                        );
                                        let v308: Option<num_complex::Complex<f64>> = v306.ok();
                                        let v322: Math::US0 = defaultValue(
                                            Math::US0::US0_1,
                                            map(Math::method17(), v308),
                                        );
                                        let v327: f64 = f64::NAN;
                                        let v329: f64 = f64::NAN;
                                        let v331: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v327, v329);
                                        let v334: num_complex::Complex<f64> = match &v322 {
                                            Math::US0::US0_0(v322_0_0) => match &v322 {
                                                Math::US0::US0_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => v331,
                                        };
                                        let v336: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v338: num_complex::Complex<f64> = v336 * v263.clone();
                                        let v340: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v342: num_complex::Complex<f64> = v338 / v340;
                                        let v344: num_complex::Complex<f64> = v342.sin();
                                        let v347: f64 = 1.0_f64 - v263.clone().re;
                                        let v350: f64 = -v263.clone().im;
                                        let v352: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v347, v350);
                                        let v463: num_complex::Complex<f64> = if v352.clone().re
                                            <= 1.0_f64
                                        {
                                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                                        } else {
                                            println!(
                                                "zeta / count: {:?} / s: {:?}",
                                                4_i32,
                                                v352.clone()
                                            );
                                            if v352.clone().re > 1.0_f64 {
                                                let v363: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                                let v364: Array<i32> = new_init(&0_i32, 10000_i32);
                                                let v365: LrcPtr<Math::Mut0> =
                                                    LrcPtr::new(Math::Mut0 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Math::method14(v365.clone()) {
                                                    let v367: i32 = v365.l0.get().clone();
                                                    v364.get_mut()[v367 as usize] = v367;
                                                    {
                                                        let v368: i32 = v367 + 1_i32;
                                                        v365.l0.set(v368);
                                                        ()
                                                    }
                                                }
                                                {
                                                    let v369: i32 = count(v364.clone());
                                                    let v370: LrcPtr<Math::Mut2> =
                                                        LrcPtr::new(Math::Mut2 {
                                                            l0: MutCell::new(0_i32),
                                                            l1: MutCell::new(v363),
                                                        });
                                                    while Math::method15(v369, v370.clone()) {
                                                        let v372: i32 = v370.l0.get().clone();
                                                        let v373: num_complex::Complex<f64> =
                                                            v370.l1.get().clone();
                                                        let v374: i32 = v364[v372].clone();
                                                        let v376: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                1.0_f64, 0.0_f64,
                                                            );
                                                        let v378: f64 = v374 as f64;
                                                        let v380: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                v378, 0.0_f64,
                                                            );
                                                        let v382: num_complex::Complex<f64> =
                                                            num_complex::Complex::powc(
                                                                v380,
                                                                v352.clone(),
                                                            );
                                                        let v384: num_complex::Complex<f64> =
                                                            v376 / v382;
                                                        let v386: num_complex::Complex<f64> =
                                                            v373 + v384;
                                                        let v387: i32 = v372 + 1_i32;
                                                        v370.l0.set(v387);
                                                        v370.l1.set(v386);
                                                        ()
                                                    }
                                                    v370.l1.get().clone()
                                                }
                                            } else {
                                                let v390: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v395: Result<
                                                    num_complex::Complex<f64>,
                                                    std::string::String,
                                                > = Math::method16(
                                                    v0_1,
                                                    string("        s = mpmath.gamma(s)"),
                                                    Math::method3(v390 - v352.clone()),
                                                );
                                                let v397: Option<num_complex::Complex<f64>> =
                                                    v395.ok();
                                                let v411: Math::US0 = defaultValue(
                                                    Math::US0::US0_1,
                                                    map(Math::method17(), v397),
                                                );
                                                let v416: f64 = f64::NAN;
                                                let v418: f64 = f64::NAN;
                                                let v420: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v416, v418);
                                                let v423: num_complex::Complex<f64> = match &v411 {
                                                    Math::US0::US0_0(v411_0_0) => match &v411 {
                                                        Math::US0::US0_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    },
                                                    _ => v420,
                                                };
                                                let v425: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(
                                                        3.141592653589793_f64,
                                                        0.0_f64,
                                                    );
                                                let v427: num_complex::Complex<f64> =
                                                    v425 * v352.clone();
                                                let v429: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                let v431: num_complex::Complex<f64> = v427 / v429;
                                                let v433: num_complex::Complex<f64> = v431.sin();
                                                let v436: f64 = 1.0_f64 - v352.clone().re;
                                                let v439: f64 = -v352.clone().im;
                                                let v441: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v436, v439);
                                                let v447: num_complex::Complex<f64> =
                                                    if v441.clone().re <= 1.0_f64 {
                                                        num_complex::Complex::new(0.0_f64, 0.0_f64)
                                                    } else {
                                                        v441
                                                    };
                                                let v449: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                let v451: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(
                                                        3.141592653589793_f64,
                                                        0.0_f64,
                                                    );
                                                let v453: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v451, v352.clone());
                                                let v455: num_complex::Complex<f64> = v449 * v453;
                                                let v457: num_complex::Complex<f64> = v455 * v433;
                                                let v459: num_complex::Complex<f64> = v457 * v423;
                                                v459 * v447
                                            }
                                        };
                                        let v465: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v467: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v469: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v467, v263.clone());
                                        let v471: num_complex::Complex<f64> = v465 * v469;
                                        let v473: num_complex::Complex<f64> = v471 * v344;
                                        let v475: num_complex::Complex<f64> = v473 * v334;
                                        v475 * v463
                                    }
                                };
                                let v481: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v483: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v485: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v483, v174.clone());
                                let v487: num_complex::Complex<f64> = v481 * v485;
                                let v489: num_complex::Complex<f64> = v487 * v255;
                                let v491: num_complex::Complex<f64> = v489 * v245;
                                v491 * v479
                            }
                        };
                        let v497: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v499: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v501: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v499, v85.clone());
                        let v503: num_complex::Complex<f64> = v497 * v501;
                        let v505: num_complex::Complex<f64> = v503 * v166;
                        let v507: num_complex::Complex<f64> = v505 * v156;
                        v507 * v495
                    }
                };
                let v513: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v515: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v517: num_complex::Complex<f64> =
                    num_complex::Complex::powc(v515, v1_1.clone());
                let v519: num_complex::Complex<f64> = v513 * v517;
                let v521: num_complex::Complex<f64> = v519 * v77;
                let v523: num_complex::Complex<f64> = v521 * v67;
                v523 * v511
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
            let v6: i32 = count(v5.clone());
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
                let v17: Option<num_complex::Complex<f64>> = v14.ok();
                let v31: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v17));
                let v36: f64 = f64::NAN;
                let v38: f64 = f64::NAN;
                let v40: num_complex::Complex<f64> = num_complex::Complex::new(v36, v38);
                let v43: num_complex::Complex<f64> = match &v31 {
                    Math::US0::US0_0(v31_0_0) => match &v31 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v40,
                };
                let v45: f64 = v43.clone().im;
                let v46: bool = v45 == 0.0_f64;
                let v48: bool = if v46 { true } else { Math::method18(v46) };
                let v50: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_eq"),
                    v45,
                    0.0_f64
                );
                let v55: () = {
                    Math::closure2(v50.clone(), ());
                    ()
                };
                if v48 == false {
                    panic!("{}", v50,);
                }
                {
                    let v60: f64 = v43.re - patternInput.1.clone();
                    let v61: f64 = -v60;
                    let v63: f64 = if v60 >= v61 { v60 } else { v61 };
                    let v64: bool = v63 < 0.0001_f64;
                    let v66: bool = if v64 { true } else { Math::method18(v64) };
                    let v68: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_lt"),
                        v63,
                        0.0001_f64
                    );
                    let v73: () = {
                        Math::closure2(v68.clone(), ());
                        ()
                    };
                    if v66 == false {
                        panic!("{}", v68,);
                    }
                    {
                        let v76: i32 = v9 + 1_i32;
                        v7.l0.set(v76);
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __run_test;
                v15.unwrap();
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
            let v8: Option<num_complex::Complex<f64>> = v5.ok();
            let v22: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v8));
            let v27: f64 = f64::NAN;
            let v29: f64 = f64::NAN;
            let v31: num_complex::Complex<f64> = num_complex::Complex::new(v27, v29);
            let v34: num_complex::Complex<f64> = match &v22 {
                Math::US0::US0_0(v22_0_0) => match &v22 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v31,
            };
            let v37: f64 = v34.clone().re - 0.8673_f64;
            let v38: f64 = -v37;
            let v40: f64 = if v37 >= v38 { v37 } else { v38 };
            let v41: bool = v40 < 0.001_f64;
            let v43: bool = if v41 { true } else { Math::method18(v41) };
            let v45: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_lt"),
                v40,
                0.001_f64
            );
            let v50: () = {
                Math::closure2(v45.clone(), ());
                ()
            };
            if v43 == false {
                panic!("{}", v45,);
            }
            {
                let v55: f64 = v34.im - 0.275_f64;
                let v56: f64 = -v55;
                let v58: f64 = if v55 >= v56 { v55 } else { v56 };
                let v59: bool = v58 < 0.001_f64;
                let v61: bool = if v59 { true } else { Math::method18(v59) };
                let v62: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_lt"),
                    v58,
                    0.001_f64
                );
                let v67: () = {
                    Math::closure2(v62.clone(), ());
                    ()
                };
                if v61 == false {
                    panic!("{}", v62,);
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __run_test;
                v15.unwrap();
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
                        let v11: Option<num_complex::Complex<f64>> = v8.ok();
                        let v25: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v11));
                        let v30: f64 = f64::NAN;
                        let v32: f64 = f64::NAN;
                        let v34: num_complex::Complex<f64> = num_complex::Complex::new(v30, v32);
                        let v37: num_complex::Complex<f64> = match &v25 {
                            Math::US0::US0_0(v25_0_0) => match &v25 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v34,
                        };
                        let v39: f64 = v37.clone().re;
                        let v40: bool = v39 == 0.0_f64;
                        let v42: bool = if v40 { true } else { Math::method18(v40) };
                        let v44: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_eq"),
                            v39,
                            0.0_f64
                        );
                        let v49: () = {
                            Math::closure2(v44.clone(), ());
                            ()
                        };
                        if v42 == false {
                            panic!("{}", v44,);
                        }
                        {
                            let v53: f64 = v37.im;
                            let v54: bool = v53 == 0.0_f64;
                            let v56: bool = if v54 { true } else { Math::method18(v54) };
                            let v57: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_eq"),
                                v53,
                                0.0_f64
                            );
                            let v62: () = {
                                Math::closure2(v57.clone(), ());
                                ()
                            };
                            if v56 == false {
                                panic!("{}", v57,);
                            }
                            {
                                let v0_1_temp: pyo3::Python = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<Math::UH0> = match v1_1.get().clone().as_ref()
                                {
                                    Math::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                };
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __run_test;
                v15.unwrap();
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
            let v14: i32 = count(v13.clone());
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
                let v24: Option<num_complex::Complex<f64>> = v21.ok();
                let v38: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v24));
                let v43: f64 = f64::NAN;
                let v45: f64 = f64::NAN;
                let v47: num_complex::Complex<f64> = num_complex::Complex::new(v43, v45);
                let v50: num_complex::Complex<f64> = match &v38 {
                    Math::US0::US0_0(v38_0_0) => match &v38 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v47,
                };
                let v52: f64 = v50.clone().re;
                let v53: f64 = -v52;
                let v55: f64 = if v52 >= v53 { v52 } else { v53 };
                let v56: bool = v55 < 0.0001_f64;
                let v58: bool = if v56 { true } else { Math::method18(v56) };
                let v60: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_lt"),
                    v55,
                    0.0001_f64
                );
                let v65: () = {
                    Math::closure2(v60.clone(), ());
                    ()
                };
                if v58 == false {
                    panic!("{}", v60,);
                }
                {
                    let v69: f64 = v50.im;
                    let v70: f64 = -v69;
                    let v72: f64 = if v69 >= v70 { v69 } else { v70 };
                    let v73: bool = v72 < 0.0001_f64;
                    let v75: bool = if v73 { true } else { Math::method18(v73) };
                    let v76: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_lt"),
                        v72,
                        0.0001_f64
                    );
                    let v81: () = {
                        Math::closure2(v76.clone(), ());
                        ()
                    };
                    if v75 == false {
                        panic!("{}", v76,);
                    }
                    {
                        let v84: i32 = v17 + 1_i32;
                        v15.l0.set(v84);
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __run_test;
                v15.unwrap();
                ()
            }
        }
        pub fn method29(v0_1: pyo3::Python) {
            let v1_1: Array<f64> = new_array(&[
                2.0_f64, 3.0_f64, 4.0_f64, 5.0_f64, 10.0_f64, 20.0_f64, 50.0_f64,
            ]);
            let v2: i32 = count(v1_1.clone());
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
                let v14: Option<num_complex::Complex<f64>> = v11.ok();
                let v28: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v14));
                let v33: f64 = f64::NAN;
                let v35: f64 = f64::NAN;
                let v37: num_complex::Complex<f64> = num_complex::Complex::new(v33, v35);
                let v40: num_complex::Complex<f64> = match &v28 {
                    Math::US0::US0_0(v28_0_0) => match &v28 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v37,
                };
                let v42: f64 = v40.clone().re;
                let v43: bool = v42 > 0.0_f64;
                let v45: bool = if v43 { true } else { Math::method18(v43) };
                let v47: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_gt"),
                    v42,
                    0.0_f64
                );
                let v52: () = {
                    Math::closure2(v47.clone(), ());
                    ()
                };
                if v45 == false {
                    panic!("{}", v47,);
                }
                {
                    let v56: f64 = v40.im;
                    let v57: bool = v56 == 0.0_f64;
                    let v59: bool = if v57 { true } else { Math::method18(v57) };
                    let v61: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_eq"),
                        v56,
                        0.0_f64
                    );
                    let v66: () = {
                        Math::closure2(v61.clone(), ());
                        ()
                    };
                    if v59 == false {
                        panic!("{}", v61,);
                    }
                    {
                        let v69: i32 = v5 + 1_i32;
                        v3.l0.set(v69);
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __run_test;
                v15.unwrap();
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
            let v8: Option<num_complex::Complex<f64>> = v5.ok();
            let v22: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v8));
            let v27: f64 = f64::NAN;
            let v29: f64 = f64::NAN;
            let v31: num_complex::Complex<f64> = num_complex::Complex::new(v27, v29);
            let v34: num_complex::Complex<f64> = match &v22 {
                Math::US0::US0_0(v22_0_0) => match &v22 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v31,
            };
            let v36: f64 = v34.clone().re;
            let v37: bool = v36 == f64::INFINITY;
            let v39: bool = if v37 { true } else { Math::method18(v37) };
            let v41: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_eq"),
                v36,
                f64::INFINITY
            );
            let v46: () = {
                Math::closure2(v41.clone(), ());
                ()
            };
            if v39 == false {
                panic!("{}", v41,);
            }
            {
                let v50: f64 = v34.im;
                let v51: bool = v50 == 0.0_f64;
                let v53: bool = if v51 { true } else { Math::method18(v51) };
                let v54: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_eq"),
                    v50,
                    0.0_f64
                );
                let v59: () = {
                    Math::closure2(v54.clone(), ());
                    ()
                };
                if v53 == false {
                    panic!("{}", v54,);
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __run_test;
                v15.unwrap();
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
            let v8: Option<num_complex::Complex<f64>> = v5.ok();
            let v22: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v8));
            let v27: f64 = f64::NAN;
            let v29: f64 = f64::NAN;
            let v31: num_complex::Complex<f64> = num_complex::Complex::new(v27, v29);
            let v34: num_complex::Complex<f64> = match &v22 {
                Math::US0::US0_0(v22_0_0) => match &v22 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v31,
            };
            let v36: f64 = v2.clone().re;
            let v39: f64 = -v2.im;
            let v41: num_complex::Complex<f64> = num_complex::Complex::new(v36, v39);
            let v44: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v41.clone()),
            );
            let v45: num_complex::Complex<f64> = Math::method13(v0_1, v41);
            let v47: Option<num_complex::Complex<f64>> = v44.ok();
            let v61: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v47));
            let v66: f64 = f64::NAN;
            let v68: f64 = f64::NAN;
            let v70: num_complex::Complex<f64> = num_complex::Complex::new(v66, v68);
            let v73: num_complex::Complex<f64> = match &v61 {
                Math::US0::US0_0(v61_0_0) => match &v61 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v70,
            };
            let v75: num_complex::Complex<f64> = v73.conj();
            let v77: f64 = v34.clone().re;
            let v79: f64 = v75.clone().re;
            let v80: bool = v77 == v79;
            let v82: bool = if v80 { true } else { Math::method18(v80) };
            let v84: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_eq"),
                v77,
                v79
            );
            let v89: () = {
                Math::closure2(v84.clone(), ());
                ()
            };
            if v82 == false {
                panic!("{}", v84,);
            }
            {
                let v93: f64 = v34.im;
                let v95: f64 = v75.im;
                let v96: bool = v93 == v95;
                let v98: bool = if v96 { true } else { Math::method18(v96) };
                let v99: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_eq"),
                    v93,
                    v95
                );
                let v104: () = {
                    Math::closure2(v99.clone(), ());
                    ()
                };
                if v98 == false {
                    panic!("{}", v99,);
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __run_test;
                v15.unwrap();
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
            let v8: Option<num_complex::Complex<f64>> = v5.ok();
            let v22: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v8));
            let v27: f64 = f64::NAN;
            let v29: f64 = f64::NAN;
            let v31: num_complex::Complex<f64> = num_complex::Complex::new(v27, v29);
            let v34: num_complex::Complex<f64> = match &v22 {
                Math::US0::US0_0(v22_0_0) => match &v22 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v31,
            };
            let v36: f64 = v34.clone().re;
            let v37: bool = v36 < f64::INFINITY;
            let v39: bool = if v37 { true } else { Math::method18(v37) };
            let v41: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_lt"),
                v36,
                f64::INFINITY
            );
            let v46: () = {
                Math::closure2(v41.clone(), ());
                ()
            };
            if v39 == false {
                panic!("{}", v41,);
            }
            {
                let v50: f64 = v34.im;
                let v51: bool = v50 < f64::INFINITY;
                let v53: bool = if v51 { true } else { Math::method18(v51) };
                let v54: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_lt"),
                    v50,
                    f64::INFINITY
                );
                let v59: () = {
                    Math::closure2(v54.clone(), ());
                    ()
                };
                if v53 == false {
                    panic!("{}", v54,);
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __run_test;
                v15.unwrap();
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
                        let v11: Option<num_complex::Complex<f64>> = v8.ok();
                        let v25: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v11));
                        let v30: f64 = f64::NAN;
                        let v32: f64 = f64::NAN;
                        let v34: num_complex::Complex<f64> = num_complex::Complex::new(v30, v32);
                        let v37: num_complex::Complex<f64> = match &v25 {
                            Math::US0::US0_0(v25_0_0) => match &v25 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v34,
                        };
                        let v39: f64 = v37.clone().re;
                        let v40: bool = v39 != 0.0_f64;
                        let v44: bool = if v40 { true } else { Math::method18(v40) };
                        let v46: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_ne"),
                            v39,
                            0.0_f64
                        );
                        let v51: () = {
                            Math::closure2(v46.clone(), ());
                            ()
                        };
                        if v44 == false {
                            panic!("{}", v46,);
                        }
                        {
                            let v55: f64 = v37.im;
                            let v56: bool = v55 != 0.0_f64;
                            let v60: bool = if v56 { true } else { Math::method18(v56) };
                            let v61: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_ne"),
                                v55,
                                0.0_f64
                            );
                            let v66: () = {
                                Math::closure2(v61.clone(), ());
                                ()
                            };
                            if v60 == false {
                                panic!("{}", v61,);
                            }
                            {
                                let v0_1_temp: pyo3::Python = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<Math::UH0> = match v1_1.get().clone().as_ref()
                                {
                                    Math::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                };
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __run_test;
                v15.unwrap();
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
                        };
                        let v6: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(
                                v0_1.get().clone(),
                                string("        s = mpmath.zeta(s)"),
                                Math::method3(v2.clone()),
                            );
                        let v7: num_complex::Complex<f64> = Math::method13(v0_1.get().clone(), v2);
                        let v9: Option<num_complex::Complex<f64>> = v6.ok();
                        let v23: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v9));
                        let v28: f64 = f64::NAN;
                        let v30: f64 = f64::NAN;
                        let v32: num_complex::Complex<f64> = num_complex::Complex::new(v28, v30);
                        let v35: num_complex::Complex<f64> = match &v23 {
                            Math::US0::US0_0(v23_0_0) => match &v23 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v32,
                        };
                        let v37: f64 = v35.clone().re;
                        let v38: bool = v37 != 0.0_f64;
                        let v42: bool = if v38 { true } else { Math::method18(v38) };
                        let v44: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_ne"),
                            v37,
                            0.0_f64
                        );
                        let v49: () = {
                            Math::closure2(v44.clone(), ());
                            ()
                        };
                        if v42 == false {
                            panic!("{}", v44,);
                        }
                        {
                            let v53: f64 = v35.im;
                            let v54: bool = v53 != 0.0_f64;
                            let v58: bool = if v54 { true } else { Math::method18(v54) };
                            let v59: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_ne"),
                                v53,
                                0.0_f64
                            );
                            let v64: () = {
                                Math::closure2(v59.clone(), ());
                                ()
                            };
                            if v58 == false {
                                panic!("{}", v59,);
                            }
                            {
                                let v0_1_temp: pyo3::Python = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<Math::UH1> = match v1_1.get().clone().as_ref()
                                {
                                    Math::UH1::UH1_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                };
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __run_test;
                v15.unwrap();
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
                        };
                        let v6: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(
                                v0_1.get().clone(),
                                string("        s = mpmath.zeta(s)"),
                                Math::method3(v2.clone()),
                            );
                        let v7: num_complex::Complex<f64> =
                            Math::method13(v0_1.get().clone(), v2.clone());
                        let v9: Option<num_complex::Complex<f64>> = v6.ok();
                        let v23: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v9));
                        let v28: f64 = f64::NAN;
                        let v30: f64 = f64::NAN;
                        let v32: num_complex::Complex<f64> = num_complex::Complex::new(v28, v30);
                        let v35: num_complex::Complex<f64> = match &v23 {
                            Math::US0::US0_0(v23_0_0) => match &v23 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v32,
                        };
                        let v37: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v39: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v37, v2.clone());
                        let v41: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v43: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v45: num_complex::Complex<f64> = v2.clone() - v43;
                        let v47: num_complex::Complex<f64> = num_complex::Complex::powc(v41, v45);
                        let v49: num_complex::Complex<f64> = v39 * v47;
                        let v51: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v53: num_complex::Complex<f64> = v51 * v2.clone();
                        let v55: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v57: num_complex::Complex<f64> = v53 / v55;
                        let v59: num_complex::Complex<f64> = v57.sin();
                        let v61: num_complex::Complex<f64> = v49 * v59;
                        let v63: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v68: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method16(
                                v0_1.get().clone(),
                                string("        s = mpmath.gamma(s)"),
                                Math::method3(v63 - v2.clone()),
                            );
                        let v70: Option<num_complex::Complex<f64>> = v68.ok();
                        let v84: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v70));
                        let v89: f64 = f64::NAN;
                        let v91: f64 = f64::NAN;
                        let v93: num_complex::Complex<f64> = num_complex::Complex::new(v89, v91);
                        let v96: num_complex::Complex<f64> = match &v84 {
                            Math::US0::US0_0(v84_0_0) => match &v84 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v93,
                        };
                        let v98: num_complex::Complex<f64> = v61 * v96;
                        let v101: f64 = 1.0_f64 - v2.clone().re;
                        let v104: f64 = -v2.im;
                        let v106: num_complex::Complex<f64> = num_complex::Complex::new(v101, v104);
                        let v109: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(
                                v0_1.get().clone(),
                                string("        s = mpmath.zeta(s)"),
                                Math::method3(v106.clone()),
                            );
                        let v110: num_complex::Complex<f64> =
                            Math::method13(v0_1.get().clone(), v106);
                        let v112: Option<num_complex::Complex<f64>> = v109.ok();
                        let v126: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v112));
                        let v131: f64 = f64::NAN;
                        let v133: f64 = f64::NAN;
                        let v135: num_complex::Complex<f64> = num_complex::Complex::new(v131, v133);
                        let v138: num_complex::Complex<f64> = match &v126 {
                            Math::US0::US0_0(v126_0_0) => match &v126 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v135,
                        };
                        let v140: num_complex::Complex<f64> = v98 * v138;
                        let v145: f64 = v35.clone().re - v140.clone().re;
                        let v146: f64 = -v145;
                        let v148: f64 = if v145 >= v146 { v145 } else { v146 };
                        let v149: bool = v148 < 0.0001_f64;
                        let v151: bool = if v149 { true } else { Math::method18(v149) };
                        let v153: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_lt"),
                            v148,
                            0.0001_f64
                        );
                        let v158: () = {
                            Math::closure2(v153.clone(), ());
                            ()
                        };
                        if v151 == false {
                            panic!("{}", v153,);
                        }
                        {
                            let v165: f64 = v35.im - v140.im;
                            let v166: f64 = -v165;
                            let v168: f64 = if v165 >= v166 { v165 } else { v166 };
                            let v169: bool = v168 < 0.0001_f64;
                            let v171: bool = if v169 { true } else { Math::method18(v169) };
                            let v172: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_lt"),
                                v168,
                                0.0001_f64
                            );
                            let v177: () = {
                                Math::closure2(v172.clone(), ());
                                ()
                            };
                            if v171 == false {
                                panic!("{}", v172,);
                            }
                            {
                                let v0_1_temp: pyo3::Python = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<Math::UH1> = match v1_1.get().clone().as_ref()
                                {
                                    Math::UH1::UH1_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                };
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __run_test;
                v15.unwrap();
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
                            };
                            let v2_temp: f64 = v2.get().clone()
                                / (1.0_f64
                                    - match v1_1.get().clone().as_ref() {
                                        Math::UH0::UH0_1(x, _) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .powf(v5));
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
                        let v14: Option<num_complex::Complex<f64>> = v11.ok();
                        let v28: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v14));
                        let v33: f64 = f64::NAN;
                        let v35: f64 = f64::NAN;
                        let v37: num_complex::Complex<f64> = num_complex::Complex::new(v33, v35);
                        let v40: num_complex::Complex<f64> = match &v28 {
                            Math::US0::US0_0(v28_0_0) => match &v28 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v37,
                        };
                        let v43: f64 = v40.clone().re - v8;
                        let v44: f64 = -v43;
                        let v46: f64 = if v43 >= v44 { v43 } else { v44 };
                        let v47: bool = v46 < 0.01_f64;
                        let v49: bool = if v47 { true } else { Math::method18(v47) };
                        let v51: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_lt"),
                            v46,
                            0.01_f64
                        );
                        let v56: () = {
                            Math::closure2(v51.clone(), ());
                            ()
                        };
                        if v49 == false {
                            panic!("{}", v51,);
                        }
                        {
                            let v60: f64 = v40.im;
                            let v61: bool = v60 < 0.01_f64;
                            let v63: bool = if v61 { true } else { Math::method18(v61) };
                            let v64: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_lt"),
                                v60,
                                0.01_f64
                            );
                            let v69: () = {
                                Math::closure2(v64.clone(), ());
                                ()
                            };
                            if v63 == false {
                                panic!("{}", v64,);
                            }
                            {
                                let v0_1_temp: pyo3::Python = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<Math::UH0> = v1_1.get().clone();
                                let v2_temp: LrcPtr<Math::UH0> = match v2.get().clone().as_ref() {
                                    Math::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                };
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __run_test;
                v15.unwrap();
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
pub use module_b7a9935b::*;
#[path = "../../lib/fsharp/Common.rs"]
mod module_ad43931;
pub use module_ad43931::*;
#[path = "../../lib/spiral/async_.rs"]
mod module_67c461a2;
pub use module_67c461a2::*;
#[path = "../../lib/spiral/common.rs"]
mod module_181b15d6;
pub use module_181b15d6::*;
#[path = "../../lib/spiral/crypto.rs"]
mod module_90d9c778;
pub use module_90d9c778::*;
#[path = "../../lib/spiral/date_time.rs"]
mod module_e43a8385;
pub use module_e43a8385::*;
#[path = "../../lib/spiral/file_system.rs"]
mod module_a7db9b47;
pub use module_a7db9b47::*;
#[path = "../../lib/spiral/lib.rs"]
mod module_98e448fc;
pub use module_98e448fc::*;
#[path = "../../lib/spiral/networking.rs"]
mod module_268024e5;
pub use module_268024e5::*;
#[path = "../../lib/spiral/platform.rs"]
mod module_7d8ad484;
pub use module_7d8ad484::*;
#[path = "../../lib/spiral/runtime.rs"]
mod module_485aae07;
pub use module_485aae07::*;
#[path = "../../lib/spiral/sm.rs"]
mod module_582b4305;
pub use module_582b4305::*;
#[path = "../../lib/spiral/threading.rs"]
mod module_d5afb6f5;
pub use module_d5afb6f5::*;
#[path = "../../lib/spiral/trace.rs"]
mod module_9e77af3a;
pub use module_9e77af3a::*;
pub mod Polyglot {
    pub use crate::module_ad43931::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Math::main(array_from(args));
}
