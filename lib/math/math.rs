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
        use fable_library_rust::Native_::refCell;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Option_::defaultValue;
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
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd)]
        pub struct Mut3 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<f64>,
        }
        impl core::fmt::Display for Math::Mut3 {
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
        pub fn method7(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method8(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method9(v0_1: pyo3::Python) -> pyo3::Python {
            v0_1
        }
        pub fn closure1(unitVar: (), v0_1: pyo3::PyErr) -> std::string::String {
            let _v1: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v1.set(Some(x))
            }
            match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            }
        }
        pub fn method10() -> Func1<pyo3::PyErr, std::string::String> {
            Func1::new(move |v: pyo3::PyErr| Math::closure1((), v))
        }
        pub fn method11() -> string {
            string("fn")
        }
        pub fn method12(
            v0_1: pyo3::Bound<pyo3::types::PyModule>,
        ) -> pyo3::Bound<pyo3::types::PyModule> {
            v0_1
        }
        pub fn closure2(unitVar: (), v0_1: pyo3::PyErr) -> std::string::String {
            let _v1: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v1.set(Some(x))
            }
            match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            }
        }
        pub fn method13() -> Func1<pyo3::PyErr, std::string::String> {
            Func1::new(move |v: pyo3::PyErr| Math::closure2((), v))
        }
        pub fn method14(
            v0_: bool,
            v0__1: LrcPtr<(f64, f64)>,
        ) -> LrcPtr<(bool, LrcPtr<(f64, f64)>)> {
            LrcPtr::new((v0_, v0__1))
        }
        pub fn method15(v0_1: pyo3::Bound<pyo3::PyAny>) -> pyo3::Bound<pyo3::PyAny> {
            v0_1
        }
        pub fn closure3(unitVar: (), v0_1: pyo3::PyErr) -> std::string::String {
            let _v1: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v1.set(Some(x))
            }
            match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            }
        }
        pub fn method16() -> Func1<pyo3::PyErr, std::string::String> {
            Func1::new(move |v: pyo3::PyErr| Math::closure3((), v))
        }
        pub fn method17(v0_1: pyo3::Bound<pyo3::PyAny>) -> pyo3::Bound<pyo3::PyAny> {
            v0_1
        }
        pub fn closure4(unitVar: (), v0_1: pyo3::PyErr) -> std::string::String {
            let _v1: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v1.set(Some(x))
            }
            match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            }
        }
        pub fn method18() -> Func1<pyo3::PyErr, std::string::String> {
            Func1::new(move |v: pyo3::PyErr| Math::closure4((), v))
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
            let v37: num_complex::Complex<f64> = Math::method7(v2.clone());
            let v39: f64 = v37.re;
            let v40: num_complex::Complex<f64> = Math::method8(v2);
            let v44: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v39, v40.im))));
            let v45: pyo3::Python = Math::method9(v0_1);
            let v47: &str = &*v36;
            let v49: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code_bound(v45, v47, "", "");
            let v50 = Math::method10();
            let v52: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                v49.map_err(|x| v50(x));
            let v54: pyo3::Bound<pyo3::types::PyModule> = v52.unwrap();
            let v55: string = Math::method11();
            let v57: &str = &*v55;
            let v58: pyo3::Bound<pyo3::types::PyModule> = Math::method12(v54);
            let v60: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v58.getattr(v57);
            let v61 = Math::method13();
            let v63: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> =
                v60.map_err(|x| v61(x));
            let v65: pyo3::Bound<pyo3::PyAny> = v63.unwrap();
            let v66: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method14(v44.0.clone(), v44.1.clone());
            let v67: pyo3::Bound<pyo3::PyAny> = Math::method15(v65);
            let v69: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                pyo3::prelude::PyAnyMethods::call(&v67, ((*v66).0, *(*v66).1), None);
            let v70 = Math::method16();
            let v72: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> =
                v69.map_err(|x| v70(x));
            let v75: pyo3::Bound<pyo3::PyAny> = Math::method17(v72?);
            let v77: Result<(f64, f64), pyo3::PyErr> = v75.extract();
            let v78 = Math::method18();
            let v80: Result<(f64, f64), std::string::String> = v77.map_err(|x| v78(x));
            let patternInput: (f64, f64) = v80?;
            Ok::<num_complex::Complex<f64>, std::string::String>(num_complex::Complex::new(
                patternInput.0.clone(),
                patternInput.1.clone(),
            ))
        }
        pub fn method20(v0_1: LrcPtr<Math::Mut0>) -> bool {
            v0_1.l0.get().clone() < 10000_i32
        }
        pub fn method21(v0_1: i32, v1_1: LrcPtr<Math::Mut2>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method22(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method23(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method24(
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
            let v37: num_complex::Complex<f64> = Math::method7(v2.clone());
            let v39: f64 = v37.re;
            let v40: num_complex::Complex<f64> = Math::method8(v2);
            let v44: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v39, v40.im))));
            let v45: pyo3::Python = Math::method9(v0_1);
            let v47: &str = &*v36;
            let v49: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code_bound(v45, v47, "", "");
            let v50 = Math::method10();
            let v52: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                v49.map_err(|x| v50(x));
            let v54: pyo3::Bound<pyo3::types::PyModule> = v52.unwrap();
            let v55: string = Math::method11();
            let v57: &str = &*v55;
            let v58: pyo3::Bound<pyo3::types::PyModule> = Math::method12(v54);
            let v60: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v58.getattr(v57);
            let v61 = Math::method13();
            let v63: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> =
                v60.map_err(|x| v61(x));
            let v65: pyo3::Bound<pyo3::PyAny> = v63.unwrap();
            let v66: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method14(v44.0.clone(), v44.1.clone());
            let v67: pyo3::Bound<pyo3::PyAny> = Math::method15(v65);
            let v69: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                pyo3::prelude::PyAnyMethods::call(&v67, ((*v66).0, *(*v66).1), None);
            let v70 = Math::method16();
            let v72: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> =
                v69.map_err(|x| v70(x));
            let v75: pyo3::Bound<pyo3::PyAny> = Math::method17(v72?);
            let v77: Result<(f64, f64), pyo3::PyErr> = v75.extract();
            let v78 = Math::method18();
            let v80: Result<(f64, f64), std::string::String> = v77.map_err(|x| v78(x));
            let patternInput: (f64, f64) = v80?;
            Ok::<num_complex::Complex<f64>, std::string::String>(num_complex::Complex::new(
                patternInput.0.clone(),
                patternInput.1.clone(),
            ))
        }
        pub fn method19(
            v0_1: pyo3::Python,
            v1_1: num_complex::Complex<f64>,
        ) -> num_complex::Complex<f64> {
            println!("zeta / count: {:?} / s: {:?}", 0, v1_1.clone());
            {
                let v3: num_complex::Complex<f64> = Math::method7(v1_1.clone());
                if v3.re > 1.0_f64 {
                    let v8: num_complex::Complex<f64> = num_complex::Complex::new(0.0_f64, 0.0_f64);
                    let v9: Array<i32> = new_init(&0_i32, 10000_i32);
                    let v10: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                        l0: MutCell::new(0_i32),
                    });
                    while Math::method20(v10.clone()) {
                        let v12: i32 = v10.l0.get().clone();
                        v9.get_mut()[v12 as usize] = v12;
                        {
                            let v13: i32 = v12 + 1_i32;
                            v10.l0.set(v13);
                            ()
                        }
                    }
                    {
                        let v14: i32 = count(v9.clone());
                        let v15: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(v8),
                        });
                        while Math::method21(v14, v15.clone()) {
                            let v17: i32 = v15.l0.get().clone();
                            let v18: num_complex::Complex<f64> = v15.l1.get().clone();
                            let v19: i32 = v9[v17].clone();
                            let v21: num_complex::Complex<f64> =
                                num_complex::Complex::new(1.0_f64, 0.0_f64);
                            let v23: f64 = v19 as f64;
                            let v26: num_complex::Complex<f64> =
                                Math::method22(num_complex::Complex::new(v23, 0.0_f64));
                            let v27: num_complex::Complex<f64> = Math::method23(v1_1.clone());
                            let v29: num_complex::Complex<f64> =
                                num_complex::Complex::powc(v26, v27);
                            let v31: num_complex::Complex<f64> = v21 / v29;
                            let v33: num_complex::Complex<f64> = v18 + v31;
                            let v34: i32 = v17 + 1_i32;
                            v15.l0.set(v34);
                            v15.l1.set(v33);
                            ()
                        }
                        v15.l1.get().clone()
                    }
                } else {
                    let v37: num_complex::Complex<f64> =
                        num_complex::Complex::new(1.0_f64, 0.0_f64);
                    let v42: Result<num_complex::Complex<f64>, std::string::String> =
                        Math::method24(
                            v0_1.clone(),
                            string("        s = mpmath.gamma(s)"),
                            Math::method3(v37 - v1_1.clone()),
                        );
                    let v44: Option<num_complex::Complex<f64>> = v42.ok();
                    let _v45: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
                    {
                        let x_2: Option<Math::US0> = match &v44 {
                            None => None::<Math::US0>,
                            Some(v44_0_0) => {
                                let x: num_complex::Complex<f64> = v44_0_0.clone();
                                Some((Func0::new({
                                    let x = x.clone();
                                    move || Math::US0::US0_0(x.clone())
                                }))())
                            }
                        };
                        _v45.set(x_2)
                    }
                    {
                        let v50: Math::US0 = defaultValue(Math::US0::US0_1, _v45.get().clone());
                        let v52: f64 = f64::NAN;
                        let v54: f64 = f64::NAN;
                        let v56: num_complex::Complex<f64> = num_complex::Complex::new(v52, v54);
                        let v59: num_complex::Complex<f64> = match &v50 {
                            Math::US0::US0_0(v50_0_0) => match &v50 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v56,
                        };
                        let v61: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v63: num_complex::Complex<f64> = v61 * v1_1.clone();
                        let v65: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v67: num_complex::Complex<f64> = v63 / v65;
                        let v69: num_complex::Complex<f64> = v67.sin();
                        let v70: num_complex::Complex<f64> = Math::method7(v1_1.clone());
                        let v73: f64 = 1.0_f64 - v70.re;
                        let v74: num_complex::Complex<f64> = Math::method8(v1_1.clone());
                        let v77: f64 = -v74.im;
                        let v79: num_complex::Complex<f64> = num_complex::Complex::new(v73, v77);
                        let v80: num_complex::Complex<f64> = Math::method7(v79.clone());
                        let v494: num_complex::Complex<f64> = if v80.re <= 1.0_f64 {
                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                        } else {
                            println!("zeta / count: {:?} / s: {:?}", 1, v79.clone());
                            {
                                let v87: num_complex::Complex<f64> = Math::method7(v79.clone());
                                if v87.re > 1.0_f64 {
                                    let v92: num_complex::Complex<f64> =
                                        num_complex::Complex::new(0.0_f64, 0.0_f64);
                                    let v93: Array<i32> = new_init(&0_i32, 10000_i32);
                                    let v94: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                        l0: MutCell::new(0_i32),
                                    });
                                    while Math::method20(v94.clone()) {
                                        let v96: i32 = v94.l0.get().clone();
                                        v93.get_mut()[v96 as usize] = v96;
                                        {
                                            let v97: i32 = v96 + 1_i32;
                                            v94.l0.set(v97);
                                            ()
                                        }
                                    }
                                    {
                                        let v98: i32 = count(v93.clone());
                                        let v99: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                            l0: MutCell::new(0_i32),
                                            l1: MutCell::new(v92),
                                        });
                                        while Math::method21(v98, v99.clone()) {
                                            let v101: i32 = v99.l0.get().clone();
                                            let v102: num_complex::Complex<f64> =
                                                v99.l1.get().clone();
                                            let v103: i32 = v93[v101].clone();
                                            let v105: num_complex::Complex<f64> =
                                                num_complex::Complex::new(1.0_f64, 0.0_f64);
                                            let v107: f64 = v103 as f64;
                                            let v110: num_complex::Complex<f64> = Math::method22(
                                                num_complex::Complex::new(v107, 0.0_f64),
                                            );
                                            let v111: num_complex::Complex<f64> =
                                                Math::method23(v79.clone());
                                            let v113: num_complex::Complex<f64> =
                                                num_complex::Complex::powc(v110, v111);
                                            let v115: num_complex::Complex<f64> = v105 / v113;
                                            let v117: num_complex::Complex<f64> = v102 + v115;
                                            let v118: i32 = v101 + 1_i32;
                                            v99.l0.set(v118);
                                            v99.l1.set(v117);
                                            ()
                                        }
                                        v99.l1.get().clone()
                                    }
                                } else {
                                    let v121: num_complex::Complex<f64> =
                                        num_complex::Complex::new(1.0_f64, 0.0_f64);
                                    let v126: Result<
                                        num_complex::Complex<f64>,
                                        std::string::String,
                                    > = Math::method24(
                                        v0_1.clone(),
                                        string("        s = mpmath.gamma(s)"),
                                        Math::method3(v121 - v79.clone()),
                                    );
                                    let v128: Option<num_complex::Complex<f64>> = v126.ok();
                                    let _v129: LrcPtr<MutCell<Option<Math::US0>>> =
                                        refCell(None::<Math::US0>);
                                    {
                                        let x_5: Option<Math::US0> = match &v128 {
                                            None => None::<Math::US0>,
                                            Some(v128_0_0) => {
                                                let x_3: num_complex::Complex<f64> =
                                                    v128_0_0.clone();
                                                Some((Func0::new({
                                                    let x_3 = x_3.clone();
                                                    move || Math::US0::US0_0(x_3.clone())
                                                }))(
                                                ))
                                            }
                                        };
                                        _v129.set(x_5)
                                    }
                                    {
                                        let v134: Math::US0 =
                                            defaultValue(Math::US0::US0_1, _v129.get().clone());
                                        let v136: f64 = f64::NAN;
                                        let v138: f64 = f64::NAN;
                                        let v140: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v136, v138);
                                        let v143: num_complex::Complex<f64> = match &v134 {
                                            Math::US0::US0_0(v134_0_0) => match &v134 {
                                                Math::US0::US0_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => v140,
                                        };
                                        let v145: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v147: num_complex::Complex<f64> = v145 * v79.clone();
                                        let v149: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v151: num_complex::Complex<f64> = v147 / v149;
                                        let v153: num_complex::Complex<f64> = v151.sin();
                                        let v154: num_complex::Complex<f64> =
                                            Math::method7(v79.clone());
                                        let v157: f64 = 1.0_f64 - v154.re;
                                        let v158: num_complex::Complex<f64> =
                                            Math::method8(v79.clone());
                                        let v161: f64 = -v158.im;
                                        let v163: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v157, v161);
                                        let v164: num_complex::Complex<f64> =
                                            Math::method7(v163.clone());
                                        let v476: num_complex::Complex<f64> = if v164.re <= 1.0_f64
                                        {
                                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                                        } else {
                                            println!(
                                                "zeta / count: {:?} / s: {:?}",
                                                2,
                                                v163.clone()
                                            );
                                            {
                                                let v171: num_complex::Complex<f64> =
                                                    Math::method7(v163.clone());
                                                if v171.re > 1.0_f64 {
                                                    let v176: num_complex::Complex<f64> =
                                                        num_complex::Complex::new(0.0_f64, 0.0_f64);
                                                    let v177: Array<i32> =
                                                        new_init(&0_i32, 10000_i32);
                                                    let v178: LrcPtr<Math::Mut0> =
                                                        LrcPtr::new(Math::Mut0 {
                                                            l0: MutCell::new(0_i32),
                                                        });
                                                    while Math::method20(v178.clone()) {
                                                        let v180: i32 = v178.l0.get().clone();
                                                        v177.get_mut()[v180 as usize] = v180;
                                                        {
                                                            let v181: i32 = v180 + 1_i32;
                                                            v178.l0.set(v181);
                                                            ()
                                                        }
                                                    }
                                                    {
                                                        let v182: i32 = count(v177.clone());
                                                        let v183: LrcPtr<Math::Mut2> =
                                                            LrcPtr::new(Math::Mut2 {
                                                                l0: MutCell::new(0_i32),
                                                                l1: MutCell::new(v176),
                                                            });
                                                        while Math::method21(v182, v183.clone()) {
                                                            let v185: i32 = v183.l0.get().clone();
                                                            let v186: num_complex::Complex<f64> =
                                                                v183.l1.get().clone();
                                                            let v187: i32 = v177[v185].clone();
                                                            let v189: num_complex::Complex<f64> =
                                                                num_complex::Complex::new(
                                                                    1.0_f64, 0.0_f64,
                                                                );
                                                            let v191: f64 = v187 as f64;
                                                            let v194: num_complex::Complex<f64> =
                                                                Math::method22(
                                                                    num_complex::Complex::new(
                                                                        v191, 0.0_f64,
                                                                    ),
                                                                );
                                                            let v195: num_complex::Complex<f64> =
                                                                Math::method23(v163.clone());
                                                            let v197: num_complex::Complex<f64> =
                                                                num_complex::Complex::powc(
                                                                    v194, v195,
                                                                );
                                                            let v199: num_complex::Complex<f64> =
                                                                v189 / v197;
                                                            let v201: num_complex::Complex<f64> =
                                                                v186 + v199;
                                                            let v202: i32 = v185 + 1_i32;
                                                            v183.l0.set(v202);
                                                            v183.l1.set(v201);
                                                            ()
                                                        }
                                                        v183.l1.get().clone()
                                                    }
                                                } else {
                                                    let v205: num_complex::Complex<f64> =
                                                        num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                    let v210: Result<
                                                        num_complex::Complex<f64>,
                                                        std::string::String,
                                                    > = Math::method24(
                                                        v0_1.clone(),
                                                        string("        s = mpmath.gamma(s)"),
                                                        Math::method3(v205 - v163.clone()),
                                                    );
                                                    let v212: Option<num_complex::Complex<f64>> =
                                                        v210.ok();
                                                    let _v213: LrcPtr<MutCell<Option<Math::US0>>> =
                                                        refCell(None::<Math::US0>);
                                                    {
                                                        let x_8: Option<Math::US0> = match &v212 {
                                                            None => None::<Math::US0>,
                                                            Some(v212_0_0) => {
                                                                let x_6: num_complex::Complex<f64> =
                                                                    v212_0_0.clone();
                                                                Some((Func0::new({
                                                                    let x_6 = x_6.clone();
                                                                    move || {
                                                                        Math::US0::US0_0(
                                                                            x_6.clone(),
                                                                        )
                                                                    }
                                                                }))(
                                                                ))
                                                            }
                                                        };
                                                        _v213.set(x_8)
                                                    }
                                                    {
                                                        let v218: Math::US0 = defaultValue(
                                                            Math::US0::US0_1,
                                                            _v213.get().clone(),
                                                        );
                                                        let v220: f64 = f64::NAN;
                                                        let v222: f64 = f64::NAN;
                                                        let v224: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(v220, v222);
                                                        let v227: num_complex::Complex<f64> =
                                                            match &v218 {
                                                                Math::US0::US0_0(v218_0_0) => {
                                                                    match &v218 {
                                                                        Math::US0::US0_0(x) => {
                                                                            x.clone()
                                                                        }
                                                                        _ => unreachable!(),
                                                                    }
                                                                }
                                                                _ => v224,
                                                            };
                                                        let v229: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                3.141592653589793_f64,
                                                                0.0_f64,
                                                            );
                                                        let v231: num_complex::Complex<f64> =
                                                            v229 * v163.clone();
                                                        let v233: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                2.0_f64, 0.0_f64,
                                                            );
                                                        let v235: num_complex::Complex<f64> =
                                                            v231 / v233;
                                                        let v237: num_complex::Complex<f64> =
                                                            v235.sin();
                                                        let v238: num_complex::Complex<f64> =
                                                            Math::method7(v163.clone());
                                                        let v241: f64 = 1.0_f64 - v238.re;
                                                        let v242: num_complex::Complex<f64> =
                                                            Math::method8(v163.clone());
                                                        let v245: f64 = -v242.im;
                                                        let v247: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(v241, v245);
                                                        let v248: num_complex::Complex<f64> =
                                                            Math::method7(v247.clone());
                                                        let v458: num_complex::Complex<f64> =
                                                            if v248.re <= 1.0_f64 {
                                                                num_complex::Complex::new(
                                                                    0.0_f64, 0.0_f64,
                                                                )
                                                            } else {
                                                                println!(
                                                                    "zeta / count: {:?} / s: {:?}",
                                                                    3,
                                                                    v247.clone()
                                                                );
                                                                {
                                                                    let v255: num_complex::Complex<
                                                                        f64,
                                                                    > = Math::method7(v247.clone());
                                                                    if v255.re > 1.0_f64 {
                                                                        let v260:
                                                                                        num_complex::Complex<f64> =
                                                                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                                                        let v261: Array<i32> =
                                                                            new_init(
                                                                                &0_i32, 10000_i32,
                                                                            );
                                                                        let v262: LrcPtr<
                                                                            Math::Mut0,
                                                                        > = LrcPtr::new(
                                                                            Math::Mut0 {
                                                                                l0: MutCell::new(
                                                                                    0_i32,
                                                                                ),
                                                                            },
                                                                        );
                                                                        while Math::method20(
                                                                            v262.clone(),
                                                                        ) {
                                                                            let v264: i32 = v262
                                                                                .l0
                                                                                .get()
                                                                                .clone();
                                                                            v261.get_mut()
                                                                                [v264 as usize] =
                                                                                v264;
                                                                            {
                                                                                let v265: i32 =
                                                                                    v264 + 1_i32;
                                                                                v262.l0.set(v265);
                                                                                ()
                                                                            }
                                                                        }
                                                                        {
                                                                            let v266: i32 =
                                                                                count(v261.clone());
                                                                            let v267: LrcPtr<
                                                                                Math::Mut2,
                                                                            > = LrcPtr::new(
                                                                                Math::Mut2 {
                                                                                    l0:
                                                                                        MutCell::new(
                                                                                            0_i32,
                                                                                        ),
                                                                                    l1:
                                                                                        MutCell::new(
                                                                                            v260,
                                                                                        ),
                                                                                },
                                                                            );
                                                                            while Math::method21(
                                                                                v266,
                                                                                v267.clone(),
                                                                            ) {
                                                                                let v269: i32 =
                                                                                    v267.l0
                                                                                        .get()
                                                                                        .clone();
                                                                                let v270:
                                                                                                num_complex::Complex<f64> =
                                                                                            v267.l1.get().clone();
                                                                                let v271: i32 =
                                                                                    v261[v269]
                                                                                        .clone();
                                                                                let v273:
                                                                                                num_complex::Complex<f64> =
                                                                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                                                let v275: f64 =
                                                                                    v271 as f64;
                                                                                let v278:
                                                                                                num_complex::Complex<f64> =
                                                                                            Math::method22(num_complex::Complex::new(v275, 0.0_f64));
                                                                                let v279:
                                                                                                num_complex::Complex<f64> =
                                                                                            Math::method23(v247.clone());
                                                                                let v281:
                                                                                                num_complex::Complex<f64> =
                                                                                            num_complex::Complex::powc(v278, v279);
                                                                                let v283:
                                                                                                num_complex::Complex<f64> =
                                                                                            v273 / v281;
                                                                                let v285:
                                                                                                num_complex::Complex<f64> =
                                                                                            v270 + v283;
                                                                                let v286: i32 =
                                                                                    v269 + 1_i32;
                                                                                v267.l0.set(v286);
                                                                                v267.l1.set(v285);
                                                                                ()
                                                                            }
                                                                            v267.l1.get().clone()
                                                                        }
                                                                    } else {
                                                                        let v289:
                                                                                        num_complex::Complex<f64> =
                                                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                                        let v294:
                                                                                        Result<num_complex::Complex<f64>,
                                                                                               std::string::String> =
                                                                                    Math::method24(v0_1.clone(),
                                                                                                   string("        s = mpmath.gamma(s)"),
                                                                                                   Math::method3(v289 - v247.clone()));
                                                                        let v296: Option<
                                                                            num_complex::Complex<
                                                                                f64,
                                                                            >,
                                                                        > = v294.ok();
                                                                        let _v297: LrcPtr<
                                                                            MutCell<
                                                                                Option<Math::US0>,
                                                                            >,
                                                                        > = refCell(
                                                                            None::<Math::US0>,
                                                                        );
                                                                        {
                                                                            let x_11: Option<
                                                                                Math::US0,
                                                                            > = match &v296 {
                                                                                None => {
                                                                                    None::<Math::US0>
                                                                                }
                                                                                Some(v296_0_0) => {
                                                                                    let x_9:
                                                                                                        num_complex::Complex<f64> =
                                                                                                    v296_0_0.clone();
                                                                                    Some((Func0::new({
                                                                                                                     let x_9
                                                                                                                         =
                                                                                                                         x_9.clone();
                                                                                                                     move
                                                                                                                         ||
                                                                                                                         Math::US0::US0_0(x_9.clone())
                                                                                                                 }))())
                                                                                }
                                                                            };
                                                                            _v297.set(x_11)
                                                                        }
                                                                        {
                                                                            let v302:
                                                                                            Math::US0 =
                                                                                        defaultValue(Math::US0::US0_1,
                                                                                                     _v297.get().clone());
                                                                            let v304: f64 =
                                                                                f64::NAN;
                                                                            let v306: f64 =
                                                                                f64::NAN;
                                                                            let v308:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(v304, v306);
                                                                            let v311:
                                                                                            num_complex::Complex<f64> =
                                                                                        match &v302
                                                                                            {
                                                                                            Math::US0::US0_0(v302_0_0)
                                                                                            =>
                                                                                            match &v302
                                                                                                {
                                                                                                Math::US0::US0_0(x)
                                                                                                =>
                                                                                                x.clone(),
                                                                                                _
                                                                                                =>
                                                                                                unreachable!(),
                                                                                            },
                                                                                            _
                                                                                            =>
                                                                                            v308,
                                                                                        };
                                                                            let v313:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                                                            let v315:
                                                                                            num_complex::Complex<f64> =
                                                                                        v313 * v247.clone();
                                                                            let v317:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                                            let v319:
                                                                                            num_complex::Complex<f64> =
                                                                                        v315 / v317;
                                                                            let v321:
                                                                                            num_complex::Complex<f64> =
                                                                                        v319.sin();
                                                                            let v322:
                                                                                            num_complex::Complex<f64> =
                                                                                        Math::method7(v247.clone());
                                                                            let v325: f64 =
                                                                                1.0_f64 - v322.re;
                                                                            let v326:
                                                                                            num_complex::Complex<f64> =
                                                                                        Math::method8(v247.clone());
                                                                            let v329: f64 =
                                                                                -v326.im;
                                                                            let v331:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(v325, v329);
                                                                            let v332:
                                                                                            num_complex::Complex<f64> =
                                                                                        Math::method7(v331.clone());
                                                                            let v440:
                                                                                            num_complex::Complex<f64> =
                                                                                        if v332.re
                                                                                               <=
                                                                                               1.0_f64
                                                                                           {
                                                                                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                                                                                        } else {
                                                                                            println!("zeta / count: {:?} / s: {:?}", 4, v331.clone());
                                                                                            {
                                                                                                let v339:
                                                                                                        num_complex::Complex<f64> =
                                                                                                    Math::method7(v331.clone());
                                                                                                if v339.re
                                                                                                       >
                                                                                                       1.0_f64
                                                                                                   {
                                                                                                    let v344:
                                                                                                            num_complex::Complex<f64> =
                                                                                                        num_complex::Complex::new(0.0_f64, 0.0_f64);
                                                                                                    let v345:
                                                                                                            Array<i32> =
                                                                                                        new_init(&0_i32,
                                                                                                                 10000_i32);
                                                                                                    let v346:
                                                                                                            LrcPtr<Math::Mut0> =
                                                                                                        LrcPtr::new(Math::Mut0{l0:
                                                                                                                                   MutCell::new(0_i32),});
                                                                                                    while Math::method20(v346.clone())
                                                                                                          {
                                                                                                        let v348:
                                                                                                                i32 =
                                                                                                            v346.l0.get().clone();
                                                                                                        v345.get_mut()[v348
                                                                                                                           as
                                                                                                                           usize]
                                                                                                            =
                                                                                                            v348;
                                                                                                        {
                                                                                                            let v349:
                                                                                                                    i32 =
                                                                                                                v348
                                                                                                                    +
                                                                                                                    1_i32;
                                                                                                            v346.l0.set(v349);
                                                                                                            ()
                                                                                                        }
                                                                                                    }
                                                                                                    {
                                                                                                        let v350:
                                                                                                                i32 =
                                                                                                            count(v345.clone());
                                                                                                        let v351:
                                                                                                                LrcPtr<Math::Mut2> =
                                                                                                            LrcPtr::new(Math::Mut2{l0:
                                                                                                                                       MutCell::new(0_i32),
                                                                                                                                   l1:
                                                                                                                                       MutCell::new(v344),});
                                                                                                        while Math::method21(v350,
                                                                                                                             v351.clone())
                                                                                                              {
                                                                                                            let v353:
                                                                                                                    i32 =
                                                                                                                v351.l0.get().clone();
                                                                                                            let v354:
                                                                                                                    num_complex::Complex<f64> =
                                                                                                                v351.l1.get().clone();
                                                                                                            let v355:
                                                                                                                    i32 =
                                                                                                                v345[v353].clone();
                                                                                                            let v357:
                                                                                                                    num_complex::Complex<f64> =
                                                                                                                num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                                                                            let v359:
                                                                                                                    f64 =
                                                                                                                v355
                                                                                                                    as
                                                                                                                    f64;
                                                                                                            let v362:
                                                                                                                    num_complex::Complex<f64> =
                                                                                                                Math::method22(num_complex::Complex::new(v359, 0.0_f64));
                                                                                                            let v363:
                                                                                                                    num_complex::Complex<f64> =
                                                                                                                Math::method23(v331.clone());
                                                                                                            let v365:
                                                                                                                    num_complex::Complex<f64> =
                                                                                                                num_complex::Complex::powc(v362, v363);
                                                                                                            let v367:
                                                                                                                    num_complex::Complex<f64> =
                                                                                                                v357 / v365;
                                                                                                            let v369:
                                                                                                                    num_complex::Complex<f64> =
                                                                                                                v354 + v367;
                                                                                                            let v370:
                                                                                                                    i32 =
                                                                                                                v353
                                                                                                                    +
                                                                                                                    1_i32;
                                                                                                            v351.l0.set(v370);
                                                                                                            v351.l1.set(v369);
                                                                                                            ()
                                                                                                        }
                                                                                                        v351.l1.get().clone()
                                                                                                    }
                                                                                                } else {
                                                                                                    let v373:
                                                                                                            num_complex::Complex<f64> =
                                                                                                        num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                                                                    let v378:
                                                                                                            Result<num_complex::Complex<f64>,
                                                                                                                   std::string::String> =
                                                                                                        Math::method24(v0_1,
                                                                                                                       string("        s = mpmath.gamma(s)"),
                                                                                                                       Math::method3(v373 - v331.clone()));
                                                                                                    let v380:
                                                                                                            Option<num_complex::Complex<f64>> =
                                                                                                        v378.ok();
                                                                                                    let _v381:
                                                                                                            LrcPtr<MutCell<Option<Math::US0>>> =
                                                                                                        refCell(None::<Math::US0>);
                                                                                                    {
                                                                                                        let x_14:
                                                                                                                Option<Math::US0> =
                                                                                                            match &v380
                                                                                                                {
                                                                                                                None
                                                                                                                =>
                                                                                                                None::<Math::US0>,
                                                                                                                Some(v380_0_0)
                                                                                                                =>
                                                                                                                {
                                                                                                                    let x_12:
                                                                                                                            num_complex::Complex<f64> =
                                                                                                                        v380_0_0.clone();
                                                                                                                    Some((Func0::new({
                                                                                                                                         let x_12
                                                                                                                                             =
                                                                                                                                             x_12.clone();
                                                                                                                                         move
                                                                                                                                             ||
                                                                                                                                             Math::US0::US0_0(x_12.clone())
                                                                                                                                     }))())
                                                                                                                }
                                                                                                            };
                                                                                                        _v381.set(x_14)
                                                                                                    }
                                                                                                    {
                                                                                                        let v386:
                                                                                                                Math::US0 =
                                                                                                            defaultValue(Math::US0::US0_1,
                                                                                                                         _v381.get().clone());
                                                                                                        let v388:
                                                                                                                f64 =
                                                                                                            f64::NAN;
                                                                                                        let v390:
                                                                                                                f64 =
                                                                                                            f64::NAN;
                                                                                                        let v392:
                                                                                                                num_complex::Complex<f64> =
                                                                                                            num_complex::Complex::new(v388, v390);
                                                                                                        let v395:
                                                                                                                num_complex::Complex<f64> =
                                                                                                            match &v386
                                                                                                                {
                                                                                                                Math::US0::US0_0(v386_0_0)
                                                                                                                =>
                                                                                                                match &v386
                                                                                                                    {
                                                                                                                    Math::US0::US0_0(x)
                                                                                                                    =>
                                                                                                                    x.clone(),
                                                                                                                    _
                                                                                                                    =>
                                                                                                                    unreachable!(),
                                                                                                                },
                                                                                                                _
                                                                                                                =>
                                                                                                                v392,
                                                                                                            };
                                                                                                        let v397:
                                                                                                                num_complex::Complex<f64> =
                                                                                                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                                                                                        let v399:
                                                                                                                num_complex::Complex<f64> =
                                                                                                            v397 * v331.clone();
                                                                                                        let v401:
                                                                                                                num_complex::Complex<f64> =
                                                                                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                                                                        let v403:
                                                                                                                num_complex::Complex<f64> =
                                                                                                            v399 / v401;
                                                                                                        let v405:
                                                                                                                num_complex::Complex<f64> =
                                                                                                            v403.sin();
                                                                                                        let v406:
                                                                                                                num_complex::Complex<f64> =
                                                                                                            Math::method7(v331.clone());
                                                                                                        let v409:
                                                                                                                f64 =
                                                                                                            1.0_f64
                                                                                                                -
                                                                                                                v406.re;
                                                                                                        let v410:
                                                                                                                num_complex::Complex<f64> =
                                                                                                            Math::method8(v331.clone());
                                                                                                        let v413:
                                                                                                                f64 =
                                                                                                            -v410.im;
                                                                                                        let v415:
                                                                                                                num_complex::Complex<f64> =
                                                                                                            num_complex::Complex::new(v409, v413);
                                                                                                        let v416:
                                                                                                                num_complex::Complex<f64> =
                                                                                                            Math::method7(v415.clone());
                                                                                                        let v422:
                                                                                                                num_complex::Complex<f64> =
                                                                                                            if v416.re
                                                                                                                   <=
                                                                                                                   1.0_f64
                                                                                                               {
                                                                                                                num_complex::Complex::new(0.0_f64, 0.0_f64)
                                                                                                            } else {
                                                                                                                v415
                                                                                                            };
                                                                                                        let v424:
                                                                                                                num_complex::Complex<f64> =
                                                                                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                                                                        let v427:
                                                                                                                num_complex::Complex<f64> =
                                                                                                            Math::method22(num_complex::Complex::new(3.141592653589793_f64, 0.0_f64));
                                                                                                        let v428:
                                                                                                                num_complex::Complex<f64> =
                                                                                                            Math::method23(v331.clone());
                                                                                                        let v430:
                                                                                                                num_complex::Complex<f64> =
                                                                                                            num_complex::Complex::powc(v427, v428);
                                                                                                        let v432:
                                                                                                                num_complex::Complex<f64> =
                                                                                                            v424 * v430;
                                                                                                        let v434:
                                                                                                                num_complex::Complex<f64> =
                                                                                                            v432 * v405;
                                                                                                        let v436:
                                                                                                                num_complex::Complex<f64> =
                                                                                                            v434 * v395;
                                                                                                        v436 * v422
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        };
                                                                            let v442:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                                            let v445:
                                                                                            num_complex::Complex<f64> =
                                                                                        Math::method22(num_complex::Complex::new(3.141592653589793_f64, 0.0_f64));
                                                                            let v446:
                                                                                            num_complex::Complex<f64> =
                                                                                        Math::method23(v247.clone());
                                                                            let v448:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::powc(v445, v446);
                                                                            let v450:
                                                                                            num_complex::Complex<f64> =
                                                                                        v442 * v448;
                                                                            let v452:
                                                                                            num_complex::Complex<f64> =
                                                                                        v450 * v321;
                                                                            let v454:
                                                                                            num_complex::Complex<f64> =
                                                                                        v452 * v311;
                                                                            v454 * v440
                                                                        }
                                                                    }
                                                                }
                                                            };
                                                        let v460: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                2.0_f64, 0.0_f64,
                                                            );
                                                        let v463: num_complex::Complex<f64> =
                                                            Math::method22(
                                                                num_complex::Complex::new(
                                                                    3.141592653589793_f64,
                                                                    0.0_f64,
                                                                ),
                                                            );
                                                        let v464: num_complex::Complex<f64> =
                                                            Math::method23(v163.clone());
                                                        let v466: num_complex::Complex<f64> =
                                                            num_complex::Complex::powc(v463, v464);
                                                        let v468: num_complex::Complex<f64> =
                                                            v460 * v466;
                                                        let v470: num_complex::Complex<f64> =
                                                            v468 * v237;
                                                        let v472: num_complex::Complex<f64> =
                                                            v470 * v227;
                                                        v472 * v458
                                                    }
                                                }
                                            }
                                        };
                                        let v478: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v481: num_complex::Complex<f64> =
                                            Math::method22(num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            ));
                                        let v482: num_complex::Complex<f64> =
                                            Math::method23(v79.clone());
                                        let v484: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v481, v482);
                                        let v486: num_complex::Complex<f64> = v478 * v484;
                                        let v488: num_complex::Complex<f64> = v486 * v153;
                                        let v490: num_complex::Complex<f64> = v488 * v143;
                                        v490 * v476
                                    }
                                }
                            }
                        };
                        let v496: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v499: num_complex::Complex<f64> = Math::method22(
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64),
                        );
                        let v500: num_complex::Complex<f64> = Math::method23(v1_1.clone());
                        let v502: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v499, v500);
                        let v504: num_complex::Complex<f64> = v496 * v502;
                        let v506: num_complex::Complex<f64> = v504 * v69;
                        let v508: num_complex::Complex<f64> = v506 * v59;
                        v508 * v494
                    }
                }
            }
        }
        pub fn method25(v0_1: bool) -> bool {
            v0_1
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
                let v15: num_complex::Complex<f64> = Math::method19(v0_1.clone(), v10);
                let v17: Option<num_complex::Complex<f64>> = v14.ok();
                let _v18: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
                {
                    let x_2: Option<Math::US0> = match &v17 {
                        None => None::<Math::US0>,
                        Some(v17_0_0) => {
                            let x: num_complex::Complex<f64> = v17_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Math::US0::US0_0(x.clone())
                            }))())
                        }
                    };
                    _v18.set(x_2)
                }
                {
                    let v23: Math::US0 = defaultValue(Math::US0::US0_1, _v18.get().clone());
                    let v25: f64 = f64::NAN;
                    let v27: f64 = f64::NAN;
                    let v29: num_complex::Complex<f64> = num_complex::Complex::new(v25, v27);
                    let v32: num_complex::Complex<f64> = match &v23 {
                        Math::US0::US0_0(v23_0_0) => match &v23 {
                            Math::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v29,
                    };
                    let v33: num_complex::Complex<f64> = Math::method8(v32.clone());
                    let v35: f64 = v33.im;
                    let v36: bool = v35 == 0.0_f64;
                    let v38: bool = if v36 { true } else { Math::method25(v36) };
                    let v40: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("assert_eq"),
                        v35,
                        0.0_f64
                    );
                    printfn!("{0}", v40.clone());
                    if v38 == false {
                        panic!("{}", v40,);
                    }
                    {
                        let v43: num_complex::Complex<f64> = Math::method7(v32);
                        let v46: f64 = v43.re - patternInput.1.clone();
                        let v47: f64 = -v46;
                        let v49: f64 = if v46 >= v47 { v46 } else { v47 };
                        let v50: bool = v49 < 0.0001_f64;
                        let v52: bool = if v50 { true } else { Math::method25(v50) };
                        let v54: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("assert_lt"),
                            v49,
                            0.0001_f64
                        );
                        printfn!("{0}", v54.clone());
                        if v52 == false {
                            panic!("{}", v54,);
                        }
                        {
                            let v57: i32 = v9 + 1_i32;
                            v7.l0.set(v57);
                            ()
                        }
                    }
                }
            }
            ()
        }
        pub fn method26(v0_1: Result<(), pyo3::PyErr>) -> Result<(), pyo3::PyErr> {
            v0_1
        }
        pub fn method0() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method1(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method26(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("v5 }}); { //");
                    v5
                }
            });
            {
                //;
                {
                    let v14: Result<(), pyo3::PyErr> = __result;
                    v14.unwrap();
                    ()
                }
            }
        }
        pub fn method28(v0_1: pyo3::Python) {
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, -2.0_f64);
            let v5: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v2.clone()),
            );
            let v6: num_complex::Complex<f64> = Math::method19(v0_1, v2);
            let v8: Option<num_complex::Complex<f64>> = v5.ok();
            let _v9: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
            {
                let x_2: Option<Math::US0> = match &v8 {
                    None => None::<Math::US0>,
                    Some(v8_0_0) => {
                        let x: num_complex::Complex<f64> = v8_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Math::US0::US0_0(x.clone())
                        }))())
                    }
                };
                _v9.set(x_2)
            }
            {
                let v14: Math::US0 = defaultValue(Math::US0::US0_1, _v9.get().clone());
                let v16: f64 = f64::NAN;
                let v18: f64 = f64::NAN;
                let v20: num_complex::Complex<f64> = num_complex::Complex::new(v16, v18);
                let v23: num_complex::Complex<f64> = match &v14 {
                    Math::US0::US0_0(v14_0_0) => match &v14 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v20,
                };
                let v24: num_complex::Complex<f64> = Math::method7(v23.clone());
                let v27: f64 = v24.re - 0.8673_f64;
                let v28: f64 = -v27;
                let v30: f64 = if v27 >= v28 { v27 } else { v28 };
                let v31: bool = v30 < 0.001_f64;
                let v33: bool = if v31 { true } else { Math::method25(v31) };
                let v35: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("assert_lt"),
                    v30,
                    0.001_f64
                );
                printfn!("{0}", v35.clone());
                if v33 == false {
                    panic!("{}", v35,);
                }
                {
                    let v38: num_complex::Complex<f64> = Math::method8(v23);
                    let v41: f64 = v38.im - 0.275_f64;
                    let v42: f64 = -v41;
                    let v44: f64 = if v41 >= v42 { v41 } else { v42 };
                    let v45: bool = v44 < 0.001_f64;
                    let v47: bool = if v45 { true } else { Math::method25(v45) };
                    let v48: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("assert_lt"),
                        v44,
                        0.001_f64
                    );
                    printfn!("{0}", v48.clone());
                    if v47 == false {
                        panic!("{}", v48,);
                    }
                }
            }
        }
        pub fn method27() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method28(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method26(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("v5 }}); { //");
                    v5
                }
            });
            {
                //;
                {
                    let v14: Result<(), pyo3::PyErr> = __result;
                    v14.unwrap();
                    ()
                }
            }
        }
        pub fn method31() -> LrcPtr<Math::UH0> {
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
        pub fn method32(v0_1: pyo3::Python, v1_1: LrcPtr<Math::UH0>) {
            let v0_1: MutCell<pyo3::Python> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1_1.clone());
            '_method32: loop {
                break '_method32 (match v1_1.get().clone().as_ref() {
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
                        let v9: num_complex::Complex<f64> = Math::method19(v0_1.get().clone(), v5);
                        let v11: Option<num_complex::Complex<f64>> = v8.ok();
                        let _v12: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
                        {
                            let x_2: Option<Math::US0> = match &v11 {
                                None => None::<Math::US0>,
                                Some(v11_0_0) => {
                                    let x: num_complex::Complex<f64> = v11_0_0.clone();
                                    Some((Func0::new({
                                        let x = x.clone();
                                        move || Math::US0::US0_0(x.clone())
                                    }))())
                                }
                            };
                            _v12.set(x_2)
                        }
                        {
                            let v17: Math::US0 = defaultValue(Math::US0::US0_1, _v12.get().clone());
                            let v19: f64 = f64::NAN;
                            let v21: f64 = f64::NAN;
                            let v23: num_complex::Complex<f64> =
                                num_complex::Complex::new(v19, v21);
                            let v26: num_complex::Complex<f64> = match &v17 {
                                Math::US0::US0_0(v17_0_0) => match &v17 {
                                    Math::US0::US0_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => v23,
                            };
                            let v27: num_complex::Complex<f64> = Math::method7(v26.clone());
                            let v29: f64 = v27.re;
                            let v30: bool = v29 == 0.0_f64;
                            let v32: bool = if v30 { true } else { Math::method25(v30) };
                            let v34: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("assert_eq"),
                                v29,
                                0.0_f64
                            );
                            printfn!("{0}", v34.clone());
                            if v32 == false {
                                panic!("{}", v34,);
                            }
                            {
                                let v37: num_complex::Complex<f64> = Math::method8(v26);
                                let v39: f64 = v37.im;
                                let v40: bool = v39 == 0.0_f64;
                                let v42: bool = if v40 { true } else { Math::method25(v40) };
                                let v43: string = sprintf!(
                                    "{} / actual: {:?} / expected: {:?}",
                                    string("assert_eq"),
                                    v39,
                                    0.0_f64
                                );
                                printfn!("{0}", v43.clone());
                                if v42 == false {
                                    panic!("{}", v43,);
                                }
                                {
                                    let v0_1_temp: pyo3::Python = v0_1.get().clone();
                                    let v1_1_temp: LrcPtr<Math::UH0> =
                                        match v1_1.get().clone().as_ref() {
                                            Math::UH0::UH0_1(_, x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    continue '_method32;
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method30(v0_1: pyo3::Python) {
            Math::method32(v0_1, Math::method31());
        }
        pub fn method29() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method30(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method26(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("v5 }}); { //");
                    v5
                }
            });
            {
                //;
                {
                    let v14: Result<(), pyo3::PyErr> = __result;
                    v14.unwrap();
                    ()
                }
            }
        }
        pub fn method34(v0_1: pyo3::Python) {
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
                let v22: num_complex::Complex<f64> = Math::method19(v0_1.clone(), v18);
                let v24: Option<num_complex::Complex<f64>> = v21.ok();
                let _v25: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
                {
                    let x_2: Option<Math::US0> = match &v24 {
                        None => None::<Math::US0>,
                        Some(v24_0_0) => {
                            let x: num_complex::Complex<f64> = v24_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Math::US0::US0_0(x.clone())
                            }))())
                        }
                    };
                    _v25.set(x_2)
                }
                {
                    let v30: Math::US0 = defaultValue(Math::US0::US0_1, _v25.get().clone());
                    let v32: f64 = f64::NAN;
                    let v34: f64 = f64::NAN;
                    let v36: num_complex::Complex<f64> = num_complex::Complex::new(v32, v34);
                    let v39: num_complex::Complex<f64> = match &v30 {
                        Math::US0::US0_0(v30_0_0) => match &v30 {
                            Math::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v36,
                    };
                    let v40: num_complex::Complex<f64> = Math::method7(v39.clone());
                    let v42: f64 = v40.re;
                    let v43: f64 = -v42;
                    let v45: f64 = if v42 >= v43 { v42 } else { v43 };
                    let v46: bool = v45 < 0.0001_f64;
                    let v48: bool = if v46 { true } else { Math::method25(v46) };
                    let v50: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("assert_lt"),
                        v45,
                        0.0001_f64
                    );
                    printfn!("{0}", v50.clone());
                    if v48 == false {
                        panic!("{}", v50,);
                    }
                    {
                        let v53: num_complex::Complex<f64> = Math::method8(v39);
                        let v55: f64 = v53.im;
                        let v56: f64 = -v55;
                        let v58: f64 = if v55 >= v56 { v55 } else { v56 };
                        let v59: bool = v58 < 0.0001_f64;
                        let v61: bool = if v59 { true } else { Math::method25(v59) };
                        let v62: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("assert_lt"),
                            v58,
                            0.0001_f64
                        );
                        printfn!("{0}", v62.clone());
                        if v61 == false {
                            panic!("{}", v62,);
                        }
                        {
                            let v65: i32 = v17 + 1_i32;
                            v15.l0.set(v65);
                            ()
                        }
                    }
                }
            }
            ()
        }
        pub fn method33() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method34(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method26(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("v5 }}); { //");
                    v5
                }
            });
            {
                //;
                {
                    let v14: Result<(), pyo3::PyErr> = __result;
                    v14.unwrap();
                    ()
                }
            }
        }
        pub fn method36(v0_1: pyo3::Python) {
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
                let v12: num_complex::Complex<f64> = Math::method19(v0_1.clone(), v8);
                let v14: Option<num_complex::Complex<f64>> = v11.ok();
                let _v15: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
                {
                    let x_2: Option<Math::US0> = match &v14 {
                        None => None::<Math::US0>,
                        Some(v14_0_0) => {
                            let x: num_complex::Complex<f64> = v14_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Math::US0::US0_0(x.clone())
                            }))())
                        }
                    };
                    _v15.set(x_2)
                }
                {
                    let v20: Math::US0 = defaultValue(Math::US0::US0_1, _v15.get().clone());
                    let v22: f64 = f64::NAN;
                    let v24: f64 = f64::NAN;
                    let v26: num_complex::Complex<f64> = num_complex::Complex::new(v22, v24);
                    let v29: num_complex::Complex<f64> = match &v20 {
                        Math::US0::US0_0(v20_0_0) => match &v20 {
                            Math::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v26,
                    };
                    let v30: num_complex::Complex<f64> = Math::method7(v29.clone());
                    let v32: f64 = v30.re;
                    let v33: bool = v32 > 0.0_f64;
                    let v35: bool = if v33 { true } else { Math::method25(v33) };
                    let v37: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("assert_gt"),
                        v32,
                        0.0_f64
                    );
                    printfn!("{0}", v37.clone());
                    if v35 == false {
                        panic!("{}", v37,);
                    }
                    {
                        let v40: num_complex::Complex<f64> = Math::method8(v29);
                        let v42: f64 = v40.im;
                        let v43: bool = v42 == 0.0_f64;
                        let v45: bool = if v43 { true } else { Math::method25(v43) };
                        let v47: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("assert_eq"),
                            v42,
                            0.0_f64
                        );
                        printfn!("{0}", v47.clone());
                        if v45 == false {
                            panic!("{}", v47,);
                        }
                        {
                            let v50: i32 = v5 + 1_i32;
                            v3.l0.set(v50);
                            ()
                        }
                    }
                }
            }
            ()
        }
        pub fn method35() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method36(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method26(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("v5 }}); { //");
                    v5
                }
            });
            {
                //;
                {
                    let v14: Result<(), pyo3::PyErr> = __result;
                    v14.unwrap();
                    ()
                }
            }
        }
        pub fn method38(v0_1: pyo3::Python) {
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(1.0_f64, 0.0_f64);
            let v5: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v2.clone()),
            );
            let v6: num_complex::Complex<f64> = Math::method19(v0_1, v2);
            let v8: Option<num_complex::Complex<f64>> = v5.ok();
            let _v9: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
            {
                let x_2: Option<Math::US0> = match &v8 {
                    None => None::<Math::US0>,
                    Some(v8_0_0) => {
                        let x: num_complex::Complex<f64> = v8_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Math::US0::US0_0(x.clone())
                        }))())
                    }
                };
                _v9.set(x_2)
            }
            {
                let v14: Math::US0 = defaultValue(Math::US0::US0_1, _v9.get().clone());
                let v16: f64 = f64::NAN;
                let v18: f64 = f64::NAN;
                let v20: num_complex::Complex<f64> = num_complex::Complex::new(v16, v18);
                let v23: num_complex::Complex<f64> = match &v14 {
                    Math::US0::US0_0(v14_0_0) => match &v14 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v20,
                };
                let v24: num_complex::Complex<f64> = Math::method7(v23.clone());
                let v26: f64 = v24.re;
                let v27: bool = v26 == f64::INFINITY;
                let v29: bool = if v27 { true } else { Math::method25(v27) };
                let v31: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("assert_eq"),
                    v26,
                    f64::INFINITY
                );
                printfn!("{0}", v31.clone());
                if v29 == false {
                    panic!("{}", v31,);
                }
                {
                    let v34: num_complex::Complex<f64> = Math::method8(v23);
                    let v36: f64 = v34.im;
                    let v37: bool = v36 == 0.0_f64;
                    let v39: bool = if v37 { true } else { Math::method25(v37) };
                    let v40: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("assert_eq"),
                        v36,
                        0.0_f64
                    );
                    printfn!("{0}", v40.clone());
                    if v39 == false {
                        panic!("{}", v40,);
                    }
                }
            }
        }
        pub fn method37() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method38(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method26(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("v5 }}); { //");
                    v5
                }
            });
            {
                //;
                {
                    let v14: Result<(), pyo3::PyErr> = __result;
                    v14.unwrap();
                    ()
                }
            }
        }
        pub fn method40(v0_1: pyo3::Python) {
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 10.0_f64);
            let v5: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v2.clone()),
            );
            let v6: num_complex::Complex<f64> = Math::method19(v0_1.clone(), v2.clone());
            let v8: Option<num_complex::Complex<f64>> = v5.ok();
            let _v9: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
            {
                let x_2: Option<Math::US0> = match &v8 {
                    None => None::<Math::US0>,
                    Some(v8_0_0) => {
                        let x: num_complex::Complex<f64> = v8_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Math::US0::US0_0(x.clone())
                        }))())
                    }
                };
                _v9.set(x_2)
            }
            {
                let v14: Math::US0 = defaultValue(Math::US0::US0_1, _v9.get().clone());
                let v16: f64 = f64::NAN;
                let v18: f64 = f64::NAN;
                let v20: num_complex::Complex<f64> = num_complex::Complex::new(v16, v18);
                let v23: num_complex::Complex<f64> = match &v14 {
                    Math::US0::US0_0(v14_0_0) => match &v14 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v20,
                };
                let v24: num_complex::Complex<f64> = Math::method7(v2.clone());
                let v26: f64 = v24.re;
                let v27: num_complex::Complex<f64> = Math::method8(v2);
                let v30: f64 = -v27.im;
                let v32: num_complex::Complex<f64> = num_complex::Complex::new(v26, v30);
                let v35: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                    v0_1.clone(),
                    string("        s = mpmath.zeta(s)"),
                    Math::method3(v32.clone()),
                );
                let v36: num_complex::Complex<f64> = Math::method19(v0_1, v32);
                let v38: Option<num_complex::Complex<f64>> = v35.ok();
                let _v39: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
                {
                    let x_5: Option<Math::US0> = match &v38 {
                        None => None::<Math::US0>,
                        Some(v38_0_0) => {
                            let x_3: num_complex::Complex<f64> = v38_0_0.clone();
                            Some((Func0::new({
                                let x_3 = x_3.clone();
                                move || Math::US0::US0_0(x_3.clone())
                            }))())
                        }
                    };
                    _v39.set(x_5)
                }
                {
                    let v44: Math::US0 = defaultValue(Math::US0::US0_1, _v39.get().clone());
                    let v46: f64 = f64::NAN;
                    let v48: f64 = f64::NAN;
                    let v50: num_complex::Complex<f64> = num_complex::Complex::new(v46, v48);
                    let v53: num_complex::Complex<f64> = match &v44 {
                        Math::US0::US0_0(v44_0_0) => match &v44 {
                            Math::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v50,
                    };
                    let v55: num_complex::Complex<f64> = v53.conj();
                    let v56: num_complex::Complex<f64> = Math::method7(v23.clone());
                    let v58: f64 = v56.re;
                    let v59: num_complex::Complex<f64> = Math::method7(v55.clone());
                    let v61: f64 = v59.re;
                    let v62: bool = v58 == v61;
                    let v64: bool = if v62 { true } else { Math::method25(v62) };
                    let v66: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("assert_eq"),
                        v58,
                        v61
                    );
                    printfn!("{0}", v66.clone());
                    if v64 == false {
                        panic!("{}", v66,);
                    }
                    {
                        let v69: num_complex::Complex<f64> = Math::method8(v23);
                        let v71: f64 = v69.im;
                        let v72: num_complex::Complex<f64> = Math::method8(v55);
                        let v74: f64 = v72.im;
                        let v75: bool = v71 == v74;
                        let v77: bool = if v75 { true } else { Math::method25(v75) };
                        let v78: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("assert_eq"),
                            v71,
                            v74
                        );
                        printfn!("{0}", v78.clone());
                        if v77 == false {
                            panic!("{}", v78,);
                        }
                    }
                }
            }
        }
        pub fn method39() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method40(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method26(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("v5 }}); { //");
                    v5
                }
            });
            {
                //;
                {
                    let v14: Result<(), pyo3::PyErr> = __result;
                    v14.unwrap();
                    ()
                }
            }
        }
        pub fn method42(v0_1: pyo3::Python) {
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(0.01_f64, 0.01_f64);
            let v5: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v2.clone()),
            );
            let v6: num_complex::Complex<f64> = Math::method19(v0_1, v2);
            let v8: Option<num_complex::Complex<f64>> = v5.ok();
            let _v9: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
            {
                let x_2: Option<Math::US0> = match &v8 {
                    None => None::<Math::US0>,
                    Some(v8_0_0) => {
                        let x: num_complex::Complex<f64> = v8_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Math::US0::US0_0(x.clone())
                        }))())
                    }
                };
                _v9.set(x_2)
            }
            {
                let v14: Math::US0 = defaultValue(Math::US0::US0_1, _v9.get().clone());
                let v16: f64 = f64::NAN;
                let v18: f64 = f64::NAN;
                let v20: num_complex::Complex<f64> = num_complex::Complex::new(v16, v18);
                let v23: num_complex::Complex<f64> = match &v14 {
                    Math::US0::US0_0(v14_0_0) => match &v14 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v20,
                };
                let v24: num_complex::Complex<f64> = Math::method7(v23.clone());
                let v26: f64 = v24.re;
                let v27: bool = v26 < f64::INFINITY;
                let v29: bool = if v27 { true } else { Math::method25(v27) };
                let v31: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("assert_lt"),
                    v26,
                    f64::INFINITY
                );
                printfn!("{0}", v31.clone());
                if v29 == false {
                    panic!("{}", v31,);
                }
                {
                    let v34: num_complex::Complex<f64> = Math::method8(v23);
                    let v36: f64 = v34.im;
                    let v37: bool = v36 < f64::INFINITY;
                    let v39: bool = if v37 { true } else { Math::method25(v37) };
                    let v40: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("assert_lt"),
                        v36,
                        f64::INFINITY
                    );
                    printfn!("{0}", v40.clone());
                    if v39 == false {
                        panic!("{}", v40,);
                    }
                }
            }
        }
        pub fn method41() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method42(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method26(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("v5 }}); { //");
                    v5
                }
            });
            {
                //;
                {
                    let v14: Result<(), pyo3::PyErr> = __result;
                    v14.unwrap();
                    ()
                }
            }
        }
        pub fn method45() -> Array<f64> {
            new_array(&[
                10.0_f64, 20.0_f64, 30.0_f64, 40.0_f64, 50.0_f64, 60.0_f64, 70.0_f64, 80.0_f64,
                90.0_f64, 100.0_f64,
            ])
        }
        pub fn method44(v0_1: pyo3::Python) {
            let v1_1: Array<f64> = Math::method45();
            let v2: i32 = count(v1_1.clone());
            let v3: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method2(v2, v3.clone()) {
                let v5: i32 = v3.l0.get().clone();
                let v6: f64 = v1_1[v5].clone();
                let v8: num_complex::Complex<f64> = num_complex::Complex::new(0.0_f64, v6);
                let v11: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                    v0_1.clone(),
                    string("        s = mpmath.zeta(s)"),
                    Math::method3(v8.clone()),
                );
                let v12: num_complex::Complex<f64> = Math::method19(v0_1.clone(), v8);
                let v14: Option<num_complex::Complex<f64>> = v11.ok();
                let _v15: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
                {
                    let x_2: Option<Math::US0> = match &v14 {
                        None => None::<Math::US0>,
                        Some(v14_0_0) => {
                            let x: num_complex::Complex<f64> = v14_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Math::US0::US0_0(x.clone())
                            }))())
                        }
                    };
                    _v15.set(x_2)
                }
                {
                    let v20: Math::US0 = defaultValue(Math::US0::US0_1, _v15.get().clone());
                    let v22: f64 = f64::NAN;
                    let v24: f64 = f64::NAN;
                    let v26: num_complex::Complex<f64> = num_complex::Complex::new(v22, v24);
                    let v29: num_complex::Complex<f64> = match &v20 {
                        Math::US0::US0_0(v20_0_0) => match &v20 {
                            Math::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v26,
                    };
                    let v30: num_complex::Complex<f64> = Math::method7(v29.clone());
                    let v32: f64 = v30.re;
                    let v33: bool = v32 != 0.0_f64;
                    let v35: bool = if v33 { true } else { Math::method25(v33) };
                    let v37: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("assert_ne"),
                        v32,
                        0.0_f64
                    );
                    printfn!("{0}", v37.clone());
                    if v35 == false {
                        panic!("{}", v37,);
                    }
                    {
                        let v40: num_complex::Complex<f64> = Math::method8(v29);
                        let v42: f64 = v40.im;
                        let v43: bool = v42 != 0.0_f64;
                        let v45: bool = if v43 { true } else { Math::method25(v43) };
                        let v46: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("assert_ne"),
                            v42,
                            0.0_f64
                        );
                        printfn!("{0}", v46.clone());
                        if v45 == false {
                            panic!("{}", v46,);
                        }
                        {
                            let v49: i32 = v5 + 1_i32;
                            v3.l0.set(v49);
                            ()
                        }
                    }
                }
            }
            ()
        }
        pub fn method43() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method44(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method26(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("v5 }}); { //");
                    v5
                }
            });
            {
                //;
                {
                    let v14: Result<(), pyo3::PyErr> = __result;
                    v14.unwrap();
                    ()
                }
            }
        }
        pub fn method47(v0_1: pyo3::Python) {
            let v11: Array<num_complex::Complex<f64>> = new_array(&[
                num_complex::Complex::new(0.5_f64, 14.134725_f64),
                num_complex::Complex::new(0.75_f64, 20.5_f64),
                num_complex::Complex::new(1.25_f64, 30.1_f64),
                num_complex::Complex::new(0.25_f64, 40.0_f64),
                num_complex::Complex::new(1.0_f64, 50.0_f64),
            ]);
            let v12: i32 = count(v11.clone());
            let v13: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method2(v12, v13.clone()) {
                let v15: i32 = v13.l0.get().clone();
                let v16: num_complex::Complex<f64> = v11[v15].clone();
                let v19: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                    v0_1.clone(),
                    string("        s = mpmath.zeta(s)"),
                    Math::method3(v16.clone()),
                );
                let v20: num_complex::Complex<f64> = Math::method19(v0_1.clone(), v16);
                let v22: Option<num_complex::Complex<f64>> = v19.ok();
                let _v23: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
                {
                    let x_2: Option<Math::US0> = match &v22 {
                        None => None::<Math::US0>,
                        Some(v22_0_0) => {
                            let x: num_complex::Complex<f64> = v22_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Math::US0::US0_0(x.clone())
                            }))())
                        }
                    };
                    _v23.set(x_2)
                }
                {
                    let v28: Math::US0 = defaultValue(Math::US0::US0_1, _v23.get().clone());
                    let v30: f64 = f64::NAN;
                    let v32: f64 = f64::NAN;
                    let v34: num_complex::Complex<f64> = num_complex::Complex::new(v30, v32);
                    let v37: num_complex::Complex<f64> = match &v28 {
                        Math::US0::US0_0(v28_0_0) => match &v28 {
                            Math::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v34,
                    };
                    let v38: num_complex::Complex<f64> = Math::method7(v37.clone());
                    let v40: f64 = v38.re;
                    let v41: bool = v40 != 0.0_f64;
                    let v43: bool = if v41 { true } else { Math::method25(v41) };
                    let v45: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("assert_ne"),
                        v40,
                        0.0_f64
                    );
                    printfn!("{0}", v45.clone());
                    if v43 == false {
                        panic!("{}", v45,);
                    }
                    {
                        let v48: num_complex::Complex<f64> = Math::method8(v37);
                        let v50: f64 = v48.im;
                        let v51: bool = v50 != 0.0_f64;
                        let v53: bool = if v51 { true } else { Math::method25(v51) };
                        let v54: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("assert_ne"),
                            v50,
                            0.0_f64
                        );
                        printfn!("{0}", v54.clone());
                        if v53 == false {
                            panic!("{}", v54,);
                        }
                        {
                            let v57: i32 = v15 + 1_i32;
                            v13.l0.set(v57);
                            ()
                        }
                    }
                }
            }
            ()
        }
        pub fn method46() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method47(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method26(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("v5 }}); { //");
                    v5
                }
            });
            {
                //;
                {
                    let v14: Result<(), pyo3::PyErr> = __result;
                    v14.unwrap();
                    ()
                }
            }
        }
        pub fn method49(v0_1: pyo3::Python) {
            let v9: Array<num_complex::Complex<f64>> = new_array(&[
                num_complex::Complex::new(3.0_f64, 4.0_f64),
                num_complex::Complex::new(2.5_f64, -3.5_f64),
                num_complex::Complex::new(1.5_f64, 2.5_f64),
                num_complex::Complex::new(0.5_f64, 14.134725_f64),
            ]);
            let v10: i32 = count(v9.clone());
            let v11: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method2(v10, v11.clone()) {
                let v13: i32 = v11.l0.get().clone();
                let v14: num_complex::Complex<f64> = v9[v13].clone();
                let v17: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                    v0_1.clone(),
                    string("        s = mpmath.zeta(s)"),
                    Math::method3(v14.clone()),
                );
                let v18: num_complex::Complex<f64> = Math::method19(v0_1.clone(), v14.clone());
                let v20: Option<num_complex::Complex<f64>> = v17.ok();
                let _v21: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
                {
                    let x_2: Option<Math::US0> = match &v20 {
                        None => None::<Math::US0>,
                        Some(v20_0_0) => {
                            let x: num_complex::Complex<f64> = v20_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Math::US0::US0_0(x.clone())
                            }))())
                        }
                    };
                    _v21.set(x_2)
                }
                {
                    let v26: Math::US0 = defaultValue(Math::US0::US0_1, _v21.get().clone());
                    let v28: f64 = f64::NAN;
                    let v30: f64 = f64::NAN;
                    let v32: num_complex::Complex<f64> = num_complex::Complex::new(v28, v30);
                    let v35: num_complex::Complex<f64> = match &v26 {
                        Math::US0::US0_0(v26_0_0) => match &v26 {
                            Math::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v32,
                    };
                    let v38: num_complex::Complex<f64> =
                        Math::method22(num_complex::Complex::new(2.0_f64, 0.0_f64));
                    let v39: num_complex::Complex<f64> = Math::method23(v14.clone());
                    let v41: num_complex::Complex<f64> = num_complex::Complex::powc(v38, v39);
                    let v43: num_complex::Complex<f64> =
                        num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                    let v45: num_complex::Complex<f64> =
                        num_complex::Complex::new(1.0_f64, 0.0_f64);
                    let v47: num_complex::Complex<f64> = v14.clone() - v45;
                    let v48: num_complex::Complex<f64> = Math::method22(v43);
                    let v49: num_complex::Complex<f64> = Math::method23(v47);
                    let v51: num_complex::Complex<f64> = num_complex::Complex::powc(v48, v49);
                    let v53: num_complex::Complex<f64> = v41 * v51;
                    let v55: num_complex::Complex<f64> =
                        num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                    let v57: num_complex::Complex<f64> = v55 * v14.clone();
                    let v59: num_complex::Complex<f64> =
                        num_complex::Complex::new(2.0_f64, 0.0_f64);
                    let v61: num_complex::Complex<f64> = v57 / v59;
                    let v63: num_complex::Complex<f64> = v61.sin();
                    let v65: num_complex::Complex<f64> = v53 * v63;
                    let v67: num_complex::Complex<f64> =
                        num_complex::Complex::new(1.0_f64, 0.0_f64);
                    let v72: Result<num_complex::Complex<f64>, std::string::String> =
                        Math::method24(
                            v0_1.clone(),
                            string("        s = mpmath.gamma(s)"),
                            Math::method3(v67 - v14.clone()),
                        );
                    let v74: Option<num_complex::Complex<f64>> = v72.ok();
                    let _v75: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
                    {
                        let x_5: Option<Math::US0> = match &v74 {
                            None => None::<Math::US0>,
                            Some(v74_0_0) => {
                                let x_3: num_complex::Complex<f64> = v74_0_0.clone();
                                Some((Func0::new({
                                    let x_3 = x_3.clone();
                                    move || Math::US0::US0_0(x_3.clone())
                                }))())
                            }
                        };
                        _v75.set(x_5)
                    }
                    {
                        let v80: Math::US0 = defaultValue(Math::US0::US0_1, _v75.get().clone());
                        let v82: f64 = f64::NAN;
                        let v84: f64 = f64::NAN;
                        let v86: num_complex::Complex<f64> = num_complex::Complex::new(v82, v84);
                        let v89: num_complex::Complex<f64> = match &v80 {
                            Math::US0::US0_0(v80_0_0) => match &v80 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v86,
                        };
                        let v91: num_complex::Complex<f64> = v65 * v89;
                        let v92: num_complex::Complex<f64> = Math::method7(v14.clone());
                        let v95: f64 = 1.0_f64 - v92.re;
                        let v96: num_complex::Complex<f64> = Math::method8(v14);
                        let v99: f64 = -v96.im;
                        let v101: num_complex::Complex<f64> = num_complex::Complex::new(v95, v99);
                        let v104: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(
                                v0_1.clone(),
                                string("        s = mpmath.zeta(s)"),
                                Math::method3(v101.clone()),
                            );
                        let v105: num_complex::Complex<f64> = Math::method19(v0_1.clone(), v101);
                        let v107: Option<num_complex::Complex<f64>> = v104.ok();
                        let _v108: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
                        {
                            let x_8: Option<Math::US0> = match &v107 {
                                None => None::<Math::US0>,
                                Some(v107_0_0) => {
                                    let x_6: num_complex::Complex<f64> = v107_0_0.clone();
                                    Some((Func0::new({
                                        let x_6 = x_6.clone();
                                        move || Math::US0::US0_0(x_6.clone())
                                    }))())
                                }
                            };
                            _v108.set(x_8)
                        }
                        {
                            let v113: Math::US0 =
                                defaultValue(Math::US0::US0_1, _v108.get().clone());
                            let v115: f64 = f64::NAN;
                            let v117: f64 = f64::NAN;
                            let v119: num_complex::Complex<f64> =
                                num_complex::Complex::new(v115, v117);
                            let v122: num_complex::Complex<f64> = match &v113 {
                                Math::US0::US0_0(v113_0_0) => match &v113 {
                                    Math::US0::US0_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => v119,
                            };
                            let v124: num_complex::Complex<f64> = v91 * v122;
                            let v125: num_complex::Complex<f64> = Math::method7(v35.clone());
                            let v127: f64 = v125.re;
                            let v128: num_complex::Complex<f64> = Math::method7(v124.clone());
                            let v131: f64 = v127 - v128.re;
                            let v132: f64 = -v131;
                            let v134: f64 = if v131 >= v132 { v131 } else { v132 };
                            let v135: bool = v134 < 0.0001_f64;
                            let v137: bool = if v135 { true } else { Math::method25(v135) };
                            let v139: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("assert_lt"),
                                v134,
                                0.0001_f64
                            );
                            printfn!("{0}", v139.clone());
                            if v137 == false {
                                panic!("{}", v139,);
                            }
                            {
                                let v142: num_complex::Complex<f64> = Math::method8(v35);
                                let v144: f64 = v142.im;
                                let v145: num_complex::Complex<f64> = Math::method8(v124);
                                let v148: f64 = v144 - v145.im;
                                let v149: f64 = -v148;
                                let v151: f64 = if v148 >= v149 { v148 } else { v149 };
                                let v152: bool = v151 < 0.0001_f64;
                                let v154: bool = if v152 { true } else { Math::method25(v152) };
                                let v155: string = sprintf!(
                                    "{} / actual: {:?} / expected: {:?}",
                                    string("assert_lt"),
                                    v151,
                                    0.0001_f64
                                );
                                printfn!("{0}", v155.clone());
                                if v154 == false {
                                    panic!("{}", v155,);
                                }
                                {
                                    let v158: i32 = v13 + 1_i32;
                                    v11.l0.set(v158);
                                    ()
                                }
                            }
                        }
                    }
                }
            }
            ()
        }
        pub fn method48() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method49(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method26(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("v5 }}); { //");
                    v5
                }
            });
            {
                //;
                {
                    let v14: Result<(), pyo3::PyErr> = __result;
                    v14.unwrap();
                    ()
                }
            }
        }
        pub fn method52(v0_1: i32, v1_1: LrcPtr<Math::Mut3>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method51(v0_1: pyo3::Python) {
            let v1_1: Array<f64> = new_array(&[
                2.0_f64, 2.5_f64, 3.0_f64, 3.5_f64, 4.0_f64, 4.5_f64, 5.0_f64,
            ]);
            let v2: Array<f64> = new_array(&[
                2.0_f64, 3.0_f64, 5.0_f64, 7.0_f64, 11.0_f64, 13.0_f64, 17.0_f64, 19.0_f64,
                23.0_f64, 29.0_f64, 31.0_f64, 37.0_f64, 41.0_f64, 43.0_f64, 47.0_f64, 53.0_f64,
                59.0_f64, 61.0_f64, 67.0_f64, 71.0_f64,
            ]);
            let v3: i32 = count(v1_1.clone());
            let v4: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method2(v3, v4.clone()) {
                let v6: i32 = v4.l0.get().clone();
                let v7: f64 = v1_1[v6].clone();
                let v9: num_complex::Complex<f64> = num_complex::Complex::new(v7, 0.0_f64);
                let v10: i32 = count(v2.clone());
                let v11: LrcPtr<Math::Mut3> = LrcPtr::new(Math::Mut3 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(1.0_f64),
                });
                while Math::method52(v10, v11.clone()) {
                    let v13: i32 = v11.l0.get().clone();
                    let v14: f64 = v11.l1.get().clone();
                    let v15: f64 = v2[v13].clone();
                    let v16: f64 = -v7;
                    let v19: f64 = v14 / (1.0_f64 - v15.powf(v16));
                    let v20: i32 = v13 + 1_i32;
                    v11.l0.set(v20);
                    v11.l1.set(v19);
                    ()
                }
                {
                    let v21: f64 = v11.l1.get().clone();
                    let v24: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                        v0_1.clone(),
                        string("        s = mpmath.zeta(s)"),
                        Math::method3(v9.clone()),
                    );
                    let v25: num_complex::Complex<f64> = Math::method19(v0_1.clone(), v9);
                    let v27: Option<num_complex::Complex<f64>> = v24.ok();
                    let _v28: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
                    {
                        let x_2: Option<Math::US0> = match &v27 {
                            None => None::<Math::US0>,
                            Some(v27_0_0) => {
                                let x: num_complex::Complex<f64> = v27_0_0.clone();
                                Some((Func0::new({
                                    let x = x.clone();
                                    move || Math::US0::US0_0(x.clone())
                                }))())
                            }
                        };
                        _v28.set(x_2)
                    }
                    {
                        let v33: Math::US0 = defaultValue(Math::US0::US0_1, _v28.get().clone());
                        let v35: f64 = f64::NAN;
                        let v37: f64 = f64::NAN;
                        let v39: num_complex::Complex<f64> = num_complex::Complex::new(v35, v37);
                        let v42: num_complex::Complex<f64> = match &v33 {
                            Math::US0::US0_0(v33_0_0) => match &v33 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v39,
                        };
                        let v43: num_complex::Complex<f64> = Math::method7(v42.clone());
                        let v46: f64 = v43.re - v21;
                        let v47: f64 = -v46;
                        let v49: f64 = if v46 >= v47 { v46 } else { v47 };
                        let v50: bool = v49 < 0.01_f64;
                        let v52: bool = if v50 { true } else { Math::method25(v50) };
                        let v54: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("assert_lt"),
                            v49,
                            0.01_f64
                        );
                        printfn!("{0}", v54.clone());
                        if v52 == false {
                            panic!("{}", v54,);
                        }
                        {
                            let v57: num_complex::Complex<f64> = Math::method8(v42);
                            let v59: f64 = v57.im;
                            let v60: bool = v59 < 0.01_f64;
                            let v62: bool = if v60 { true } else { Math::method25(v60) };
                            let v63: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("assert_lt"),
                                v59,
                                0.01_f64
                            );
                            printfn!("{0}", v63.clone());
                            if v62 == false {
                                panic!("{}", v63,);
                            }
                            {
                                let v66: i32 = v6 + 1_i32;
                                v4.l0.set(v66);
                                ()
                            }
                        }
                    }
                }
            }
            ()
        }
        pub fn method50() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method51(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method26(Ok::<(), pyo3::PyErr>(()));
                    let v12: string = string("v5 }}); { //");
                    v5
                }
            });
            {
                //;
                {
                    let v14: Result<(), pyo3::PyErr> = __result;
                    v14.unwrap();
                    ()
                }
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
            Math::method27();
        } /* /*;
          {
              let v12: string =
                  string("*/ #[test] fn test_trivial_zero_at_negative_even___() { //");
              let v13: bool =
                  */
        #[test]
        fn test_trivial_zero_at_negative_even___() {
            //;
            Math::method29();
        } /* /*;
          {
              let v16: string =
                  string("*/ #[test] fn test_non_trivial_zero___() { //");
              let v17: bool =
                  */
        #[test]
        fn test_non_trivial_zero___() {
            //;
            Math::method33();
        } /* /*;
          {
              let v20: string =
                  string("*/ #[test] fn test_real_part_greater_than_one___() { //");
              let v21: bool =
                  */
        #[test]
        fn test_real_part_greater_than_one___() {
            //;
            Math::method35();
        } /* /*;
          {
              let v24: string =
                  string("*/ #[test] fn test_zeta_at_1___() { //");
              let v25: bool =
                  */
        #[test]
        fn test_zeta_at_1___() {
            //;
            Math::method37();
        } /* /*;
          {
              let v28: string =
                  string("*/ #[test] fn test_symmetry_across_real_axis___() { //");
              let v29: bool =
                  */
        #[test]
        fn test_symmetry_across_real_axis___() {
            //;
            Math::method39();
        } /* /*;
          {
              let v32: string =
                  string("*/ #[test] fn test_behavior_near_origin___() { //");
              let v33: bool =
                  */
        #[test]
        fn test_behavior_near_origin___() {
            //;
            Math::method41();
        } /* /*;
          {
              let v36: string =
                  string("*/ #[test] fn test_imaginary_axis() { //");
              let v37: bool =
                  */
        #[test]
        fn test_imaginary_axis() {
            //;
            Math::method43();
        } /* /*;
          {
              let v40: string =
                  string("*/ #[test] fn test_critical_strip() { //");
              let v41: bool =
                  */
        #[test]
        fn test_critical_strip() {
            //;
            Math::method46();
        } /* /*;
          {
              let v44: string =
                  string("*/ #[test] fn test_reflection_formula_for_specific_value() { //");
              let v45: bool =
                  */
        #[test]
        fn test_reflection_formula_for_specific_value() {
            //;
            Math::method48();
        } /* /*;
          {
              let v48: string =
                  string("*/ #[test] fn test_euler_product_formula() { //");
              let v49: bool =
                  */
        #[test]
        fn test_euler_product_formula() {
            //;
            Math::method50();
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
        pub fn closure5(unitVar: (), v0_1: Array<string>) -> i32 {
            {
                let value: string = sprintf!("value: {}", 1_i32);
                printfn!("{0}", value)
            }
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
            v1.get_or_init(|| Func1::new(move |v: Array<string>| Math::closure5((), v)))
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
