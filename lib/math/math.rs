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
            let v46: &str = &*v36;
            let v66: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code_bound(v43, v46, "", "");
            let v68: bool = true;
            let _result_map_error__ = v66.map_err(|x| {
                //;
                let v70: pyo3::PyErr = x;
                let v73: std::string::String = format!("{}", v70);
                let v93: bool = true;
                v73
            });
            let v95: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                _result_map_error__;
            let v98: pyo3::Bound<pyo3::types::PyModule> = v95.unwrap();
            let v109: string = Math::method8();
            let v112: &str = &*v109;
            let v131: pyo3::Bound<pyo3::types::PyModule> = Math::method9(v98);
            let v133: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v131.getattr(v112);
            let v135: bool = true;
            let _result_map_error__ = v133.map_err(|x| {
                //;
                let v137: pyo3::PyErr = x;
                let v140: std::string::String = format!("{}", v137);
                let v160: bool = true;
                v140
            });
            let v162: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v165: pyo3::Bound<pyo3::PyAny> = v162.unwrap();
            let v176: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method10(v42.0.clone(), v42.1.clone());
            let v177: pyo3::Bound<pyo3::PyAny> = Math::method11(v165);
            let v179: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                pyo3::prelude::PyAnyMethods::call(&v177, ((*v176).0, *(*v176).1), None);
            let v181: bool = true;
            let _result_map_error__ = v179.map_err(|x| {
                //;
                let v183: pyo3::PyErr = x;
                let v186: std::string::String = format!("{}", v183);
                let v206: bool = true;
                v186
            });
            let v208: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v211: pyo3::Bound<pyo3::PyAny> = Math::method12(v208?);
            let v213: Result<(f64, f64), pyo3::PyErr> = v211.extract();
            let v215: bool = true;
            let _result_map_error__ = v213.map_err(|x| {
                //;
                let v217: pyo3::PyErr = x;
                let v220: std::string::String = format!("{}", v217);
                let v240: bool = true;
                v220
            });
            let v242: Result<(f64, f64), std::string::String> = _result_map_error__;
            let patternInput: (f64, f64) = v242?;
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
            let v46: &str = &*v36;
            let v66: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code_bound(v43, v46, "", "");
            let v68: bool = true;
            let _result_map_error__ = v66.map_err(|x| {
                //;
                let v70: pyo3::PyErr = x;
                let v73: std::string::String = format!("{}", v70);
                let v93: bool = true;
                v73
            });
            let v95: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                _result_map_error__;
            let v98: pyo3::Bound<pyo3::types::PyModule> = v95.unwrap();
            let v109: string = Math::method8();
            let v112: &str = &*v109;
            let v131: pyo3::Bound<pyo3::types::PyModule> = Math::method9(v98);
            let v133: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v131.getattr(v112);
            let v135: bool = true;
            let _result_map_error__ = v133.map_err(|x| {
                //;
                let v137: pyo3::PyErr = x;
                let v140: std::string::String = format!("{}", v137);
                let v160: bool = true;
                v140
            });
            let v162: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v165: pyo3::Bound<pyo3::PyAny> = v162.unwrap();
            let v176: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method10(v42.0.clone(), v42.1.clone());
            let v177: pyo3::Bound<pyo3::PyAny> = Math::method11(v165);
            let v179: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                pyo3::prelude::PyAnyMethods::call(&v177, ((*v176).0, *(*v176).1), None);
            let v181: bool = true;
            let _result_map_error__ = v179.map_err(|x| {
                //;
                let v183: pyo3::PyErr = x;
                let v186: std::string::String = format!("{}", v183);
                let v206: bool = true;
                v186
            });
            let v208: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> = _result_map_error__;
            let v211: pyo3::Bound<pyo3::PyAny> = Math::method12(v208?);
            let v213: Result<(f64, f64), pyo3::PyErr> = v211.extract();
            let v215: bool = true;
            let _result_map_error__ = v213.map_err(|x| {
                //;
                let v217: pyo3::PyErr = x;
                let v220: std::string::String = format!("{}", v217);
                let v240: bool = true;
                v220
            });
            let v242: Result<(f64, f64), std::string::String> = _result_map_error__;
            let patternInput: (f64, f64) = v242?;
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
                let v42: Option<num_complex::Complex<f64>> = v39.ok();
                let v66: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v42));
                let v71: f64 = f64::NAN;
                let v73: f64 = f64::NAN;
                let v75: num_complex::Complex<f64> = num_complex::Complex::new(v71, v73);
                let v78: num_complex::Complex<f64> = match &v66 {
                    Math::US0::US0_0(v66_0_0) => match &v66 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v75,
                };
                let v80: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v82: num_complex::Complex<f64> = v80 * v1_1.clone();
                let v84: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v86: num_complex::Complex<f64> = v82 / v84;
                let v88: num_complex::Complex<f64> = v86.sin();
                let v91: f64 = 1.0_f64 - v1_1.clone().re;
                let v94: f64 = -v1_1.clone().im;
                let v96: num_complex::Complex<f64> = num_complex::Complex::new(v91, v94);
                let v566: num_complex::Complex<f64> = if v96.clone().re <= 1.0_f64 {
                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                } else {
                    println!("zeta / count: {:?} / s: {:?}", 1_i32, v96.clone());
                    if v96.clone().re > 1.0_f64 {
                        let v107: num_complex::Complex<f64> =
                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                        let v108: Array<i32> = new_init(&0_i32, 10000_i32);
                        let v109: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                            l0: MutCell::new(0_i32),
                        });
                        while Math::method14(v109.clone()) {
                            let v111: i32 = v109.l0.get().clone();
                            v108.get_mut()[v111 as usize] = v111;
                            {
                                let v112: i32 = v111 + 1_i32;
                                v109.l0.set(v112);
                                ()
                            }
                        }
                        {
                            let v113: i32 = count(v108.clone());
                            let v114: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                l0: MutCell::new(0_i32),
                                l1: MutCell::new(v107),
                            });
                            while Math::method15(v113, v114.clone()) {
                                let v116: i32 = v114.l0.get().clone();
                                let v117: num_complex::Complex<f64> = v114.l1.get().clone();
                                let v118: i32 = v108[v116].clone();
                                let v120: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v122: f64 = v118 as f64;
                                let v124: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v122, 0.0_f64);
                                let v126: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v124, v96.clone());
                                let v128: num_complex::Complex<f64> = v120 / v126;
                                let v130: num_complex::Complex<f64> = v117 + v128;
                                let v131: i32 = v116 + 1_i32;
                                v114.l0.set(v131);
                                v114.l1.set(v130);
                                ()
                            }
                            v114.l1.get().clone()
                        }
                    } else {
                        let v134: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v139: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method16(
                                v0_1.clone(),
                                string("        s = mpmath.gamma(s)"),
                                Math::method3(v134 - v96.clone()),
                            );
                        let v142: Option<num_complex::Complex<f64>> = v139.ok();
                        let v166: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v142));
                        let v171: f64 = f64::NAN;
                        let v173: f64 = f64::NAN;
                        let v175: num_complex::Complex<f64> = num_complex::Complex::new(v171, v173);
                        let v178: num_complex::Complex<f64> = match &v166 {
                            Math::US0::US0_0(v166_0_0) => match &v166 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v175,
                        };
                        let v180: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v182: num_complex::Complex<f64> = v180 * v96.clone();
                        let v184: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v186: num_complex::Complex<f64> = v182 / v184;
                        let v188: num_complex::Complex<f64> = v186.sin();
                        let v191: f64 = 1.0_f64 - v96.clone().re;
                        let v194: f64 = -v96.clone().im;
                        let v196: num_complex::Complex<f64> = num_complex::Complex::new(v191, v194);
                        let v550: num_complex::Complex<f64> = if v196.clone().re <= 1.0_f64 {
                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                        } else {
                            println!("zeta / count: {:?} / s: {:?}", 2_i32, v196.clone());
                            if v196.clone().re > 1.0_f64 {
                                let v207: num_complex::Complex<f64> =
                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                let v208: Array<i32> = new_init(&0_i32, 10000_i32);
                                let v209: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Math::method14(v209.clone()) {
                                    let v211: i32 = v209.l0.get().clone();
                                    v208.get_mut()[v211 as usize] = v211;
                                    {
                                        let v212: i32 = v211 + 1_i32;
                                        v209.l0.set(v212);
                                        ()
                                    }
                                }
                                {
                                    let v213: i32 = count(v208.clone());
                                    let v214: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                        l0: MutCell::new(0_i32),
                                        l1: MutCell::new(v207),
                                    });
                                    while Math::method15(v213, v214.clone()) {
                                        let v216: i32 = v214.l0.get().clone();
                                        let v217: num_complex::Complex<f64> = v214.l1.get().clone();
                                        let v218: i32 = v208[v216].clone();
                                        let v220: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v222: f64 = v218 as f64;
                                        let v224: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v222, 0.0_f64);
                                        let v226: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v224, v196.clone());
                                        let v228: num_complex::Complex<f64> = v220 / v226;
                                        let v230: num_complex::Complex<f64> = v217 + v228;
                                        let v231: i32 = v216 + 1_i32;
                                        v214.l0.set(v231);
                                        v214.l1.set(v230);
                                        ()
                                    }
                                    v214.l1.get().clone()
                                }
                            } else {
                                let v234: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v239: Result<num_complex::Complex<f64>, std::string::String> =
                                    Math::method16(
                                        v0_1.clone(),
                                        string("        s = mpmath.gamma(s)"),
                                        Math::method3(v234 - v196.clone()),
                                    );
                                let v242: Option<num_complex::Complex<f64>> = v239.ok();
                                let v266: Math::US0 =
                                    defaultValue(Math::US0::US0_1, map(Math::method17(), v242));
                                let v271: f64 = f64::NAN;
                                let v273: f64 = f64::NAN;
                                let v275: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v271, v273);
                                let v278: num_complex::Complex<f64> = match &v266 {
                                    Math::US0::US0_0(v266_0_0) => match &v266 {
                                        Math::US0::US0_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => v275,
                                };
                                let v280: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v282: num_complex::Complex<f64> = v280 * v196.clone();
                                let v284: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v286: num_complex::Complex<f64> = v282 / v284;
                                let v288: num_complex::Complex<f64> = v286.sin();
                                let v291: f64 = 1.0_f64 - v196.clone().re;
                                let v294: f64 = -v196.clone().im;
                                let v296: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v291, v294);
                                let v534: num_complex::Complex<f64> = if v296.clone().re <= 1.0_f64
                                {
                                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                                } else {
                                    println!("zeta / count: {:?} / s: {:?}", 3_i32, v296.clone());
                                    if v296.clone().re > 1.0_f64 {
                                        let v307: num_complex::Complex<f64> =
                                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                                        let v308: Array<i32> = new_init(&0_i32, 10000_i32);
                                        let v309: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                            l0: MutCell::new(0_i32),
                                        });
                                        while Math::method14(v309.clone()) {
                                            let v311: i32 = v309.l0.get().clone();
                                            v308.get_mut()[v311 as usize] = v311;
                                            {
                                                let v312: i32 = v311 + 1_i32;
                                                v309.l0.set(v312);
                                                ()
                                            }
                                        }
                                        {
                                            let v313: i32 = count(v308.clone());
                                            let v314: LrcPtr<Math::Mut2> =
                                                LrcPtr::new(Math::Mut2 {
                                                    l0: MutCell::new(0_i32),
                                                    l1: MutCell::new(v307),
                                                });
                                            while Math::method15(v313, v314.clone()) {
                                                let v316: i32 = v314.l0.get().clone();
                                                let v317: num_complex::Complex<f64> =
                                                    v314.l1.get().clone();
                                                let v318: i32 = v308[v316].clone();
                                                let v320: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v322: f64 = v318 as f64;
                                                let v324: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v322, 0.0_f64);
                                                let v326: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v324, v296.clone());
                                                let v328: num_complex::Complex<f64> = v320 / v326;
                                                let v330: num_complex::Complex<f64> = v317 + v328;
                                                let v331: i32 = v316 + 1_i32;
                                                v314.l0.set(v331);
                                                v314.l1.set(v330);
                                                ()
                                            }
                                            v314.l1.get().clone()
                                        }
                                    } else {
                                        let v334: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v339: Result<
                                            num_complex::Complex<f64>,
                                            std::string::String,
                                        > = Math::method16(
                                            v0_1.clone(),
                                            string("        s = mpmath.gamma(s)"),
                                            Math::method3(v334 - v296.clone()),
                                        );
                                        let v342: Option<num_complex::Complex<f64>> = v339.ok();
                                        let v366: Math::US0 = defaultValue(
                                            Math::US0::US0_1,
                                            map(Math::method17(), v342),
                                        );
                                        let v371: f64 = f64::NAN;
                                        let v373: f64 = f64::NAN;
                                        let v375: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v371, v373);
                                        let v378: num_complex::Complex<f64> = match &v366 {
                                            Math::US0::US0_0(v366_0_0) => match &v366 {
                                                Math::US0::US0_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => v375,
                                        };
                                        let v380: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v382: num_complex::Complex<f64> = v380 * v296.clone();
                                        let v384: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v386: num_complex::Complex<f64> = v382 / v384;
                                        let v388: num_complex::Complex<f64> = v386.sin();
                                        let v391: f64 = 1.0_f64 - v296.clone().re;
                                        let v394: f64 = -v296.clone().im;
                                        let v396: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v391, v394);
                                        let v518: num_complex::Complex<f64> = if v396.clone().re
                                            <= 1.0_f64
                                        {
                                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                                        } else {
                                            println!(
                                                "zeta / count: {:?} / s: {:?}",
                                                4_i32,
                                                v396.clone()
                                            );
                                            if v396.clone().re > 1.0_f64 {
                                                let v407: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                                let v408: Array<i32> = new_init(&0_i32, 10000_i32);
                                                let v409: LrcPtr<Math::Mut0> =
                                                    LrcPtr::new(Math::Mut0 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Math::method14(v409.clone()) {
                                                    let v411: i32 = v409.l0.get().clone();
                                                    v408.get_mut()[v411 as usize] = v411;
                                                    {
                                                        let v412: i32 = v411 + 1_i32;
                                                        v409.l0.set(v412);
                                                        ()
                                                    }
                                                }
                                                {
                                                    let v413: i32 = count(v408.clone());
                                                    let v414: LrcPtr<Math::Mut2> =
                                                        LrcPtr::new(Math::Mut2 {
                                                            l0: MutCell::new(0_i32),
                                                            l1: MutCell::new(v407),
                                                        });
                                                    while Math::method15(v413, v414.clone()) {
                                                        let v416: i32 = v414.l0.get().clone();
                                                        let v417: num_complex::Complex<f64> =
                                                            v414.l1.get().clone();
                                                        let v418: i32 = v408[v416].clone();
                                                        let v420: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                1.0_f64, 0.0_f64,
                                                            );
                                                        let v422: f64 = v418 as f64;
                                                        let v424: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                v422, 0.0_f64,
                                                            );
                                                        let v426: num_complex::Complex<f64> =
                                                            num_complex::Complex::powc(
                                                                v424,
                                                                v396.clone(),
                                                            );
                                                        let v428: num_complex::Complex<f64> =
                                                            v420 / v426;
                                                        let v430: num_complex::Complex<f64> =
                                                            v417 + v428;
                                                        let v431: i32 = v416 + 1_i32;
                                                        v414.l0.set(v431);
                                                        v414.l1.set(v430);
                                                        ()
                                                    }
                                                    v414.l1.get().clone()
                                                }
                                            } else {
                                                let v434: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v439: Result<
                                                    num_complex::Complex<f64>,
                                                    std::string::String,
                                                > = Math::method16(
                                                    v0_1,
                                                    string("        s = mpmath.gamma(s)"),
                                                    Math::method3(v434 - v396.clone()),
                                                );
                                                let v442: Option<num_complex::Complex<f64>> =
                                                    v439.ok();
                                                let v466: Math::US0 = defaultValue(
                                                    Math::US0::US0_1,
                                                    map(Math::method17(), v442),
                                                );
                                                let v471: f64 = f64::NAN;
                                                let v473: f64 = f64::NAN;
                                                let v475: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v471, v473);
                                                let v478: num_complex::Complex<f64> = match &v466 {
                                                    Math::US0::US0_0(v466_0_0) => match &v466 {
                                                        Math::US0::US0_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    },
                                                    _ => v475,
                                                };
                                                let v480: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(
                                                        3.141592653589793_f64,
                                                        0.0_f64,
                                                    );
                                                let v482: num_complex::Complex<f64> =
                                                    v480 * v396.clone();
                                                let v484: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                let v486: num_complex::Complex<f64> = v482 / v484;
                                                let v488: num_complex::Complex<f64> = v486.sin();
                                                let v491: f64 = 1.0_f64 - v396.clone().re;
                                                let v494: f64 = -v396.clone().im;
                                                let v496: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v491, v494);
                                                let v502: num_complex::Complex<f64> =
                                                    if v496.clone().re <= 1.0_f64 {
                                                        num_complex::Complex::new(0.0_f64, 0.0_f64)
                                                    } else {
                                                        v496
                                                    };
                                                let v504: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                let v506: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(
                                                        3.141592653589793_f64,
                                                        0.0_f64,
                                                    );
                                                let v508: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v506, v396.clone());
                                                let v510: num_complex::Complex<f64> = v504 * v508;
                                                let v512: num_complex::Complex<f64> = v510 * v488;
                                                let v514: num_complex::Complex<f64> = v512 * v478;
                                                v514 * v502
                                            }
                                        };
                                        let v520: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v522: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v524: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v522, v296.clone());
                                        let v526: num_complex::Complex<f64> = v520 * v524;
                                        let v528: num_complex::Complex<f64> = v526 * v388;
                                        let v530: num_complex::Complex<f64> = v528 * v378;
                                        v530 * v518
                                    }
                                };
                                let v536: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v538: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v540: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v538, v196.clone());
                                let v542: num_complex::Complex<f64> = v536 * v540;
                                let v544: num_complex::Complex<f64> = v542 * v288;
                                let v546: num_complex::Complex<f64> = v544 * v278;
                                v546 * v534
                            }
                        };
                        let v552: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v554: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v556: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v554, v96.clone());
                        let v558: num_complex::Complex<f64> = v552 * v556;
                        let v560: num_complex::Complex<f64> = v558 * v188;
                        let v562: num_complex::Complex<f64> = v560 * v178;
                        v562 * v550
                    }
                };
                let v568: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v570: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v572: num_complex::Complex<f64> =
                    num_complex::Complex::powc(v570, v1_1.clone());
                let v574: num_complex::Complex<f64> = v568 * v572;
                let v576: num_complex::Complex<f64> = v574 * v88;
                let v578: num_complex::Complex<f64> = v576 * v78;
                v578 * v566
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
                let v18: Option<num_complex::Complex<f64>> = v14.ok();
                let v42: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v18));
                let v47: f64 = f64::NAN;
                let v49: f64 = f64::NAN;
                let v51: num_complex::Complex<f64> = num_complex::Complex::new(v47, v49);
                let v54: num_complex::Complex<f64> = match &v42 {
                    Math::US0::US0_0(v42_0_0) => match &v42 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v51,
                };
                let v56: f64 = v54.clone().im;
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
                    let v71: f64 = v54.re - patternInput.1.clone();
                    let v72: f64 = -v71;
                    let v74: f64 = if v71 >= v72 { v71 } else { v72 };
                    let v75: bool = v74 < 0.0001_f64;
                    let v77: bool = if v75 { true } else { Math::method18(v75) };
                    let v79: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_lt"),
                        v74,
                        0.0001_f64
                    );
                    let v84: () = {
                        Math::closure2(v79.clone(), ());
                        ()
                    };
                    if v77 == false {
                        panic!("{}", v79,);
                    }
                    {
                        let v87: i32 = v9 + 1_i32;
                        v7.l0.set(v87);
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
                    let v15: bool = true;
                    let v12 = v5;
                    let v26: string = append(
                        append(append(append(string("true; v12 "), v9), string("); ")), v11),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    v12
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
                ();
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
            let v33: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v9));
            let v38: f64 = f64::NAN;
            let v40: f64 = f64::NAN;
            let v42: num_complex::Complex<f64> = num_complex::Complex::new(v38, v40);
            let v45: num_complex::Complex<f64> = match &v33 {
                Math::US0::US0_0(v33_0_0) => match &v33 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v42,
            };
            let v48: f64 = v45.clone().re - 0.8673_f64;
            let v49: f64 = -v48;
            let v51: f64 = if v48 >= v49 { v48 } else { v49 };
            let v52: bool = v51 < 0.001_f64;
            let v54: bool = if v52 { true } else { Math::method18(v52) };
            let v56: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_lt"),
                v51,
                0.001_f64
            );
            let v61: () = {
                Math::closure2(v56.clone(), ());
                ()
            };
            if v54 == false {
                panic!("{}", v56,);
            }
            {
                let v66: f64 = v45.im - 0.275_f64;
                let v67: f64 = -v66;
                let v69: f64 = if v66 >= v67 { v66 } else { v67 };
                let v70: bool = v69 < 0.001_f64;
                let v72: bool = if v70 { true } else { Math::method18(v70) };
                let v73: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_lt"),
                    v69,
                    0.001_f64
                );
                let v78: () = {
                    Math::closure2(v73.clone(), ());
                    ()
                };
                if v72 == false {
                    panic!("{}", v73,);
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
                    let v15: bool = true;
                    let v12 = v5;
                    let v26: string = append(
                        append(append(append(string("true; v12 "), v9), string("); ")), v11),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    v12
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
                ();
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
                        let v36: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v12));
                        let v41: f64 = f64::NAN;
                        let v43: f64 = f64::NAN;
                        let v45: num_complex::Complex<f64> = num_complex::Complex::new(v41, v43);
                        let v48: num_complex::Complex<f64> = match &v36 {
                            Math::US0::US0_0(v36_0_0) => match &v36 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v45,
                        };
                        let v50: f64 = v48.clone().re;
                        let v51: bool = v50 == 0.0_f64;
                        let v53: bool = if v51 { true } else { Math::method18(v51) };
                        let v55: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_eq"),
                            v50,
                            0.0_f64
                        );
                        let v60: () = {
                            Math::closure2(v55.clone(), ());
                            ()
                        };
                        if v53 == false {
                            panic!("{}", v55,);
                        }
                        {
                            let v64: f64 = v48.im;
                            let v65: bool = v64 == 0.0_f64;
                            let v67: bool = if v65 { true } else { Math::method18(v65) };
                            let v68: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_eq"),
                                v64,
                                0.0_f64
                            );
                            let v73: () = {
                                Math::closure2(v68.clone(), ());
                                ()
                            };
                            if v67 == false {
                                panic!("{}", v68,);
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
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v15: bool = true;
                    let v12 = v5;
                    let v26: string = append(
                        append(append(append(string("true; v12 "), v9), string("); ")), v11),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    v12
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
                ();
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
                let v25: Option<num_complex::Complex<f64>> = v21.ok();
                let v49: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v25));
                let v54: f64 = f64::NAN;
                let v56: f64 = f64::NAN;
                let v58: num_complex::Complex<f64> = num_complex::Complex::new(v54, v56);
                let v61: num_complex::Complex<f64> = match &v49 {
                    Math::US0::US0_0(v49_0_0) => match &v49 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v58,
                };
                let v63: f64 = v61.clone().re;
                let v64: f64 = -v63;
                let v66: f64 = if v63 >= v64 { v63 } else { v64 };
                let v67: bool = v66 < 0.0001_f64;
                let v69: bool = if v67 { true } else { Math::method18(v67) };
                let v71: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_lt"),
                    v66,
                    0.0001_f64
                );
                let v76: () = {
                    Math::closure2(v71.clone(), ());
                    ()
                };
                if v69 == false {
                    panic!("{}", v71,);
                }
                {
                    let v80: f64 = v61.im;
                    let v81: f64 = -v80;
                    let v83: f64 = if v80 >= v81 { v80 } else { v81 };
                    let v84: bool = v83 < 0.0001_f64;
                    let v86: bool = if v84 { true } else { Math::method18(v84) };
                    let v87: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_lt"),
                        v83,
                        0.0001_f64
                    );
                    let v92: () = {
                        Math::closure2(v87.clone(), ());
                        ()
                    };
                    if v86 == false {
                        panic!("{}", v87,);
                    }
                    {
                        let v95: i32 = v17 + 1_i32;
                        v15.l0.set(v95);
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
                    let v15: bool = true;
                    let v12 = v5;
                    let v26: string = append(
                        append(append(append(string("true; v12 "), v9), string("); ")), v11),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    v12
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
                ();
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
                let v15: Option<num_complex::Complex<f64>> = v11.ok();
                let v39: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v15));
                let v44: f64 = f64::NAN;
                let v46: f64 = f64::NAN;
                let v48: num_complex::Complex<f64> = num_complex::Complex::new(v44, v46);
                let v51: num_complex::Complex<f64> = match &v39 {
                    Math::US0::US0_0(v39_0_0) => match &v39 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v48,
                };
                let v53: f64 = v51.clone().re;
                let v54: bool = v53 > 0.0_f64;
                let v56: bool = if v54 { true } else { Math::method18(v54) };
                let v58: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_gt"),
                    v53,
                    0.0_f64
                );
                let v63: () = {
                    Math::closure2(v58.clone(), ());
                    ()
                };
                if v56 == false {
                    panic!("{}", v58,);
                }
                {
                    let v67: f64 = v51.im;
                    let v68: bool = v67 == 0.0_f64;
                    let v70: bool = if v68 { true } else { Math::method18(v68) };
                    let v72: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_eq"),
                        v67,
                        0.0_f64
                    );
                    let v77: () = {
                        Math::closure2(v72.clone(), ());
                        ()
                    };
                    if v70 == false {
                        panic!("{}", v72,);
                    }
                    {
                        let v80: i32 = v5 + 1_i32;
                        v3.l0.set(v80);
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
                    let v15: bool = true;
                    let v12 = v5;
                    let v26: string = append(
                        append(append(append(string("true; v12 "), v9), string("); ")), v11),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    v12
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
                ();
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
            let v33: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v9));
            let v38: f64 = f64::NAN;
            let v40: f64 = f64::NAN;
            let v42: num_complex::Complex<f64> = num_complex::Complex::new(v38, v40);
            let v45: num_complex::Complex<f64> = match &v33 {
                Math::US0::US0_0(v33_0_0) => match &v33 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v42,
            };
            let v47: f64 = v45.clone().re;
            let v48: bool = v47 == f64::INFINITY;
            let v50: bool = if v48 { true } else { Math::method18(v48) };
            let v52: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_eq"),
                v47,
                f64::INFINITY
            );
            let v57: () = {
                Math::closure2(v52.clone(), ());
                ()
            };
            if v50 == false {
                panic!("{}", v52,);
            }
            {
                let v61: f64 = v45.im;
                let v62: bool = v61 == 0.0_f64;
                let v64: bool = if v62 { true } else { Math::method18(v62) };
                let v65: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_eq"),
                    v61,
                    0.0_f64
                );
                let v70: () = {
                    Math::closure2(v65.clone(), ());
                    ()
                };
                if v64 == false {
                    panic!("{}", v65,);
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
                    let v15: bool = true;
                    let v12 = v5;
                    let v26: string = append(
                        append(append(append(string("true; v12 "), v9), string("); ")), v11),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    v12
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
                ();
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
            let v33: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v9));
            let v38: f64 = f64::NAN;
            let v40: f64 = f64::NAN;
            let v42: num_complex::Complex<f64> = num_complex::Complex::new(v38, v40);
            let v45: num_complex::Complex<f64> = match &v33 {
                Math::US0::US0_0(v33_0_0) => match &v33 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v42,
            };
            let v47: f64 = v2.clone().re;
            let v50: f64 = -v2.im;
            let v52: num_complex::Complex<f64> = num_complex::Complex::new(v47, v50);
            let v55: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v52.clone()),
            );
            let v56: num_complex::Complex<f64> = Math::method13(v0_1, v52);
            let v59: Option<num_complex::Complex<f64>> = v55.ok();
            let v83: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v59));
            let v88: f64 = f64::NAN;
            let v90: f64 = f64::NAN;
            let v92: num_complex::Complex<f64> = num_complex::Complex::new(v88, v90);
            let v95: num_complex::Complex<f64> = match &v83 {
                Math::US0::US0_0(v83_0_0) => match &v83 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v92,
            };
            let v97: num_complex::Complex<f64> = v95.conj();
            let v99: f64 = v45.clone().re;
            let v101: f64 = v97.clone().re;
            let v102: bool = v99 == v101;
            let v104: bool = if v102 { true } else { Math::method18(v102) };
            let v106: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_eq"),
                v99,
                v101
            );
            let v111: () = {
                Math::closure2(v106.clone(), ());
                ()
            };
            if v104 == false {
                panic!("{}", v106,);
            }
            {
                let v115: f64 = v45.im;
                let v117: f64 = v97.im;
                let v118: bool = v115 == v117;
                let v120: bool = if v118 { true } else { Math::method18(v118) };
                let v121: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_eq"),
                    v115,
                    v117
                );
                let v126: () = {
                    Math::closure2(v121.clone(), ());
                    ()
                };
                if v120 == false {
                    panic!("{}", v121,);
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
                    let v15: bool = true;
                    let v12 = v5;
                    let v26: string = append(
                        append(append(append(string("true; v12 "), v9), string("); ")), v11),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    v12
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
                ();
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
            let v33: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v9));
            let v38: f64 = f64::NAN;
            let v40: f64 = f64::NAN;
            let v42: num_complex::Complex<f64> = num_complex::Complex::new(v38, v40);
            let v45: num_complex::Complex<f64> = match &v33 {
                Math::US0::US0_0(v33_0_0) => match &v33 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v42,
            };
            let v47: f64 = v45.clone().re;
            let v48: bool = v47 < f64::INFINITY;
            let v50: bool = if v48 { true } else { Math::method18(v48) };
            let v52: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_lt"),
                v47,
                f64::INFINITY
            );
            let v57: () = {
                Math::closure2(v52.clone(), ());
                ()
            };
            if v50 == false {
                panic!("{}", v52,);
            }
            {
                let v61: f64 = v45.im;
                let v62: bool = v61 < f64::INFINITY;
                let v64: bool = if v62 { true } else { Math::method18(v62) };
                let v65: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_lt"),
                    v61,
                    f64::INFINITY
                );
                let v70: () = {
                    Math::closure2(v65.clone(), ());
                    ()
                };
                if v64 == false {
                    panic!("{}", v65,);
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
                    let v15: bool = true;
                    let v12 = v5;
                    let v26: string = append(
                        append(append(append(string("true; v12 "), v9), string("); ")), v11),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    v12
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
                ();
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
                        let v36: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v12));
                        let v41: f64 = f64::NAN;
                        let v43: f64 = f64::NAN;
                        let v45: num_complex::Complex<f64> = num_complex::Complex::new(v41, v43);
                        let v48: num_complex::Complex<f64> = match &v36 {
                            Math::US0::US0_0(v36_0_0) => match &v36 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v45,
                        };
                        let v50: f64 = v48.clone().re;
                        let v51: bool = v50 != 0.0_f64;
                        let v55: bool = if v51 { true } else { Math::method18(v51) };
                        let v57: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_ne"),
                            v50,
                            0.0_f64
                        );
                        let v62: () = {
                            Math::closure2(v57.clone(), ());
                            ()
                        };
                        if v55 == false {
                            panic!("{}", v57,);
                        }
                        {
                            let v66: f64 = v48.im;
                            let v67: bool = v66 != 0.0_f64;
                            let v71: bool = if v67 { true } else { Math::method18(v67) };
                            let v72: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_ne"),
                                v66,
                                0.0_f64
                            );
                            let v77: () = {
                                Math::closure2(v72.clone(), ());
                                ()
                            };
                            if v71 == false {
                                panic!("{}", v72,);
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
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v15: bool = true;
                    let v12 = v5;
                    let v26: string = append(
                        append(append(append(string("true; v12 "), v9), string("); ")), v11),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    v12
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
                ();
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
                        let v10: Option<num_complex::Complex<f64>> = v6.ok();
                        let v34: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v10));
                        let v39: f64 = f64::NAN;
                        let v41: f64 = f64::NAN;
                        let v43: num_complex::Complex<f64> = num_complex::Complex::new(v39, v41);
                        let v46: num_complex::Complex<f64> = match &v34 {
                            Math::US0::US0_0(v34_0_0) => match &v34 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v43,
                        };
                        let v48: f64 = v46.clone().re;
                        let v49: bool = v48 != 0.0_f64;
                        let v53: bool = if v49 { true } else { Math::method18(v49) };
                        let v55: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_ne"),
                            v48,
                            0.0_f64
                        );
                        let v60: () = {
                            Math::closure2(v55.clone(), ());
                            ()
                        };
                        if v53 == false {
                            panic!("{}", v55,);
                        }
                        {
                            let v64: f64 = v46.im;
                            let v65: bool = v64 != 0.0_f64;
                            let v69: bool = if v65 { true } else { Math::method18(v65) };
                            let v70: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_ne"),
                                v64,
                                0.0_f64
                            );
                            let v75: () = {
                                Math::closure2(v70.clone(), ());
                                ()
                            };
                            if v69 == false {
                                panic!("{}", v70,);
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
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v15: bool = true;
                    let v12 = v5;
                    let v26: string = append(
                        append(append(append(string("true; v12 "), v9), string("); ")), v11),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    v12
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
                ();
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
                        let v10: Option<num_complex::Complex<f64>> = v6.ok();
                        let v34: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v10));
                        let v39: f64 = f64::NAN;
                        let v41: f64 = f64::NAN;
                        let v43: num_complex::Complex<f64> = num_complex::Complex::new(v39, v41);
                        let v46: num_complex::Complex<f64> = match &v34 {
                            Math::US0::US0_0(v34_0_0) => match &v34 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v43,
                        };
                        let v48: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v50: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v48, v2.clone());
                        let v52: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v54: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v56: num_complex::Complex<f64> = v2.clone() - v54;
                        let v58: num_complex::Complex<f64> = num_complex::Complex::powc(v52, v56);
                        let v60: num_complex::Complex<f64> = v50 * v58;
                        let v62: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v64: num_complex::Complex<f64> = v62 * v2.clone();
                        let v66: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v68: num_complex::Complex<f64> = v64 / v66;
                        let v70: num_complex::Complex<f64> = v68.sin();
                        let v72: num_complex::Complex<f64> = v60 * v70;
                        let v74: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v79: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method16(
                                v0_1.get().clone(),
                                string("        s = mpmath.gamma(s)"),
                                Math::method3(v74 - v2.clone()),
                            );
                        let v82: Option<num_complex::Complex<f64>> = v79.ok();
                        let v106: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v82));
                        let v111: f64 = f64::NAN;
                        let v113: f64 = f64::NAN;
                        let v115: num_complex::Complex<f64> = num_complex::Complex::new(v111, v113);
                        let v118: num_complex::Complex<f64> = match &v106 {
                            Math::US0::US0_0(v106_0_0) => match &v106 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v115,
                        };
                        let v120: num_complex::Complex<f64> = v72 * v118;
                        let v123: f64 = 1.0_f64 - v2.clone().re;
                        let v126: f64 = -v2.im;
                        let v128: num_complex::Complex<f64> = num_complex::Complex::new(v123, v126);
                        let v131: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(
                                v0_1.get().clone(),
                                string("        s = mpmath.zeta(s)"),
                                Math::method3(v128.clone()),
                            );
                        let v132: num_complex::Complex<f64> =
                            Math::method13(v0_1.get().clone(), v128);
                        let v135: Option<num_complex::Complex<f64>> = v131.ok();
                        let v159: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v135));
                        let v164: f64 = f64::NAN;
                        let v166: f64 = f64::NAN;
                        let v168: num_complex::Complex<f64> = num_complex::Complex::new(v164, v166);
                        let v171: num_complex::Complex<f64> = match &v159 {
                            Math::US0::US0_0(v159_0_0) => match &v159 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v168,
                        };
                        let v173: num_complex::Complex<f64> = v120 * v171;
                        let v178: f64 = v46.clone().re - v173.clone().re;
                        let v179: f64 = -v178;
                        let v181: f64 = if v178 >= v179 { v178 } else { v179 };
                        let v182: bool = v181 < 0.0001_f64;
                        let v184: bool = if v182 { true } else { Math::method18(v182) };
                        let v186: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_lt"),
                            v181,
                            0.0001_f64
                        );
                        let v191: () = {
                            Math::closure2(v186.clone(), ());
                            ()
                        };
                        if v184 == false {
                            panic!("{}", v186,);
                        }
                        {
                            let v198: f64 = v46.im - v173.im;
                            let v199: f64 = -v198;
                            let v201: f64 = if v198 >= v199 { v198 } else { v199 };
                            let v202: bool = v201 < 0.0001_f64;
                            let v204: bool = if v202 { true } else { Math::method18(v202) };
                            let v205: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_lt"),
                                v201,
                                0.0001_f64
                            );
                            let v210: () = {
                                Math::closure2(v205.clone(), ());
                                ()
                            };
                            if v204 == false {
                                panic!("{}", v205,);
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
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v15: bool = true;
                    let v12 = v5;
                    let v26: string = append(
                        append(append(append(string("true; v12 "), v9), string("); ")), v11),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    v12
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
                ();
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
                        let v15: Option<num_complex::Complex<f64>> = v11.ok();
                        let v39: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v15));
                        let v44: f64 = f64::NAN;
                        let v46: f64 = f64::NAN;
                        let v48: num_complex::Complex<f64> = num_complex::Complex::new(v44, v46);
                        let v51: num_complex::Complex<f64> = match &v39 {
                            Math::US0::US0_0(v39_0_0) => match &v39 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v48,
                        };
                        let v54: f64 = v51.clone().re - v8;
                        let v55: f64 = -v54;
                        let v57: f64 = if v54 >= v55 { v54 } else { v55 };
                        let v58: bool = v57 < 0.01_f64;
                        let v60: bool = if v58 { true } else { Math::method18(v58) };
                        let v62: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_lt"),
                            v57,
                            0.01_f64
                        );
                        let v67: () = {
                            Math::closure2(v62.clone(), ());
                            ()
                        };
                        if v60 == false {
                            panic!("{}", v62,);
                        }
                        {
                            let v71: f64 = v51.im;
                            let v72: bool = v71 < 0.01_f64;
                            let v74: bool = if v72 { true } else { Math::method18(v72) };
                            let v75: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_lt"),
                                v71,
                                0.01_f64
                            );
                            let v80: () = {
                                Math::closure2(v75.clone(), ());
                                ()
                            };
                            if v74 == false {
                                panic!("{}", v75,);
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
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v15: bool = true;
                    let v12 = v5;
                    let v26: string = append(
                        append(append(append(string("true; v12 "), v9), string("); ")), v11),
                        string(" // rust.fix_closure\'"),
                    );
                    let v27: bool = true;
                    v12
                }
            });
            {
                // rust.fix_closure';
                let v29: Result<(), pyo3::PyErr> = __run_test;
                v29.unwrap();
                ();
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
