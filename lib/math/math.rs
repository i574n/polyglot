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
        pub fn closure1(unitVar: (), v0_1: pyo3::PyErr) -> std::string::String {
            let _v3: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v3.set(Some(x))
            }
            match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
            }
        }
        pub fn method8() -> Func1<pyo3::PyErr, std::string::String> {
            Func1::new(move |v: pyo3::PyErr| Math::closure1((), v))
        }
        pub fn method9() -> string {
            string("fn")
        }
        pub fn method10(
            v0_1: pyo3::Bound<pyo3::types::PyModule>,
        ) -> pyo3::Bound<pyo3::types::PyModule> {
            v0_1
        }
        pub fn closure2(unitVar: (), v0_1: pyo3::PyErr) -> std::string::String {
            let _v3: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v3.set(Some(x))
            }
            match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
            }
        }
        pub fn method11() -> Func1<pyo3::PyErr, std::string::String> {
            Func1::new(move |v: pyo3::PyErr| Math::closure2((), v))
        }
        pub fn method12(
            v0_: bool,
            v0__1: LrcPtr<(f64, f64)>,
        ) -> LrcPtr<(bool, LrcPtr<(f64, f64)>)> {
            LrcPtr::new((v0_, v0__1))
        }
        pub fn method13(v0_1: pyo3::Bound<pyo3::PyAny>) -> pyo3::Bound<pyo3::PyAny> {
            v0_1
        }
        pub fn closure3(unitVar: (), v0_1: pyo3::PyErr) -> std::string::String {
            let _v3: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v3.set(Some(x))
            }
            match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
            }
        }
        pub fn method14() -> Func1<pyo3::PyErr, std::string::String> {
            Func1::new(move |v: pyo3::PyErr| Math::closure3((), v))
        }
        pub fn method15(v0_1: pyo3::Bound<pyo3::PyAny>) -> pyo3::Bound<pyo3::PyAny> {
            v0_1
        }
        pub fn closure4(unitVar: (), v0_1: pyo3::PyErr) -> std::string::String {
            let _v3: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v3.set(Some(x))
            }
            match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
            }
        }
        pub fn method16() -> Func1<pyo3::PyErr, std::string::String> {
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
            let v42: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v2.clone().re, v2.im))));
            let v43: pyo3::Python = Math::method7(v0_1);
            let v45: &str = &*v36;
            let v47: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code_bound(v43, v45, "", "");
            let v48 = Math::method8();
            let v50: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                v47.map_err(|x| v48(x));
            let v52: pyo3::Bound<pyo3::types::PyModule> = v50.unwrap();
            let v53: string = Math::method9();
            let v55: &str = &*v53;
            let v56: pyo3::Bound<pyo3::types::PyModule> = Math::method10(v52);
            let v58: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v56.getattr(v55);
            let v59 = Math::method11();
            let v61: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> =
                v58.map_err(|x| v59(x));
            let v63: pyo3::Bound<pyo3::PyAny> = v61.unwrap();
            let v64: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method12(v42.0.clone(), v42.1.clone());
            let v65: pyo3::Bound<pyo3::PyAny> = Math::method13(v63);
            let v67: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                pyo3::prelude::PyAnyMethods::call(&v65, ((*v64).0, *(*v64).1), None);
            let v68 = Math::method14();
            let v70: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> =
                v67.map_err(|x| v68(x));
            let v73: pyo3::Bound<pyo3::PyAny> = Math::method15(v70?);
            let v75: Result<(f64, f64), pyo3::PyErr> = v73.extract();
            let v76 = Math::method16();
            let v78: Result<(f64, f64), std::string::String> = v75.map_err(|x| v76(x));
            let patternInput: (f64, f64) = v78?;
            Ok::<num_complex::Complex<f64>, std::string::String>(num_complex::Complex::new(
                patternInput.0.clone(),
                patternInput.1.clone(),
            ))
        }
        pub fn method18(v0_1: LrcPtr<Math::Mut0>) -> bool {
            v0_1.l0.get().clone() < 10000_i32
        }
        pub fn method19(v0_1: i32, v1_1: LrcPtr<Math::Mut2>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method20(
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
            let v48 = Math::method8();
            let v50: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                v47.map_err(|x| v48(x));
            let v52: pyo3::Bound<pyo3::types::PyModule> = v50.unwrap();
            let v53: string = Math::method9();
            let v55: &str = &*v53;
            let v56: pyo3::Bound<pyo3::types::PyModule> = Math::method10(v52);
            let v58: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v56.getattr(v55);
            let v59 = Math::method11();
            let v61: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> =
                v58.map_err(|x| v59(x));
            let v63: pyo3::Bound<pyo3::PyAny> = v61.unwrap();
            let v64: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method12(v42.0.clone(), v42.1.clone());
            let v65: pyo3::Bound<pyo3::PyAny> = Math::method13(v63);
            let v67: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                pyo3::prelude::PyAnyMethods::call(&v65, ((*v64).0, *(*v64).1), None);
            let v68 = Math::method14();
            let v70: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> =
                v67.map_err(|x| v68(x));
            let v73: pyo3::Bound<pyo3::PyAny> = Math::method15(v70?);
            let v75: Result<(f64, f64), pyo3::PyErr> = v73.extract();
            let v76 = Math::method16();
            let v78: Result<(f64, f64), std::string::String> = v75.map_err(|x| v76(x));
            let patternInput: (f64, f64) = v78?;
            Ok::<num_complex::Complex<f64>, std::string::String>(num_complex::Complex::new(
                patternInput.0.clone(),
                patternInput.1.clone(),
            ))
        }
        pub fn method17(
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
                while Math::method18(v9.clone()) {
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
                    while Math::method19(v13, v14.clone()) {
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
                let v39: Result<num_complex::Complex<f64>, std::string::String> = Math::method20(
                    v0_1.clone(),
                    string("        s = mpmath.gamma(s)"),
                    Math::method3(v34 - v1_1.clone()),
                );
                let v41: Option<num_complex::Complex<f64>> = v39.ok();
                let _v44: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
                {
                    let x_2: Option<Math::US0> = match &v41 {
                        None => None::<Math::US0>,
                        Some(v41_0_0) => {
                            let x: num_complex::Complex<f64> = v41_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Math::US0::US0_0(x.clone())
                            }))())
                        }
                    };
                    _v44.set(x_2)
                }
                {
                    let v71: Math::US0 = defaultValue(Math::US0::US0_1, _v44.get().clone());
                    let v80: f64 = f64::NAN;
                    let v82: f64 = f64::NAN;
                    let v84: num_complex::Complex<f64> = num_complex::Complex::new(v80, v82);
                    let v87: num_complex::Complex<f64> = match &v71 {
                        Math::US0::US0_0(v71_0_0) => match &v71 {
                            Math::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v84,
                    };
                    let v89: num_complex::Complex<f64> =
                        num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                    let v91: num_complex::Complex<f64> = v89 * v1_1.clone();
                    let v93: num_complex::Complex<f64> =
                        num_complex::Complex::new(2.0_f64, 0.0_f64);
                    let v95: num_complex::Complex<f64> = v91 / v93;
                    let v97: num_complex::Complex<f64> = v95.sin();
                    let v100: f64 = 1.0_f64 - v1_1.clone().re;
                    let v103: f64 = -v1_1.clone().im;
                    let v105: num_complex::Complex<f64> = num_complex::Complex::new(v100, v103);
                    let v611: num_complex::Complex<f64> = if v105.clone().re <= 1.0_f64 {
                        num_complex::Complex::new(0.0_f64, 0.0_f64)
                    } else {
                        println!("zeta / count: {:?} / s: {:?}", 1_i32, v105.clone());
                        if v105.clone().re > 1.0_f64 {
                            let v116: num_complex::Complex<f64> =
                                num_complex::Complex::new(0.0_f64, 0.0_f64);
                            let v117: Array<i32> = new_init(&0_i32, 10000_i32);
                            let v118: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                l0: MutCell::new(0_i32),
                            });
                            while Math::method18(v118.clone()) {
                                let v120: i32 = v118.l0.get().clone();
                                v117.get_mut()[v120 as usize] = v120;
                                {
                                    let v121: i32 = v120 + 1_i32;
                                    v118.l0.set(v121);
                                    ()
                                }
                            }
                            {
                                let v122: i32 = count(v117.clone());
                                let v123: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                    l0: MutCell::new(0_i32),
                                    l1: MutCell::new(v116),
                                });
                                while Math::method19(v122, v123.clone()) {
                                    let v125: i32 = v123.l0.get().clone();
                                    let v126: num_complex::Complex<f64> = v123.l1.get().clone();
                                    let v127: i32 = v117[v125].clone();
                                    let v129: num_complex::Complex<f64> =
                                        num_complex::Complex::new(1.0_f64, 0.0_f64);
                                    let v131: f64 = v127 as f64;
                                    let v133: num_complex::Complex<f64> =
                                        num_complex::Complex::new(v131, 0.0_f64);
                                    let v135: num_complex::Complex<f64> =
                                        num_complex::Complex::powc(v133, v105.clone());
                                    let v137: num_complex::Complex<f64> = v129 / v135;
                                    let v139: num_complex::Complex<f64> = v126 + v137;
                                    let v140: i32 = v125 + 1_i32;
                                    v123.l0.set(v140);
                                    v123.l1.set(v139);
                                    ()
                                }
                                v123.l1.get().clone()
                            }
                        } else {
                            let v143: num_complex::Complex<f64> =
                                num_complex::Complex::new(1.0_f64, 0.0_f64);
                            let v148: Result<num_complex::Complex<f64>, std::string::String> =
                                Math::method20(
                                    v0_1.clone(),
                                    string("        s = mpmath.gamma(s)"),
                                    Math::method3(v143 - v105.clone()),
                                );
                            let v150: Option<num_complex::Complex<f64>> = v148.ok();
                            let _v153: LrcPtr<MutCell<Option<Math::US0>>> =
                                refCell(None::<Math::US0>);
                            {
                                let x_5: Option<Math::US0> = match &v150 {
                                    None => None::<Math::US0>,
                                    Some(v150_0_0) => {
                                        let x_3: num_complex::Complex<f64> = v150_0_0.clone();
                                        Some((Func0::new({
                                            let x_3 = x_3.clone();
                                            move || Math::US0::US0_0(x_3.clone())
                                        }))())
                                    }
                                };
                                _v153.set(x_5)
                            }
                            {
                                let v180: Math::US0 =
                                    defaultValue(Math::US0::US0_1, _v153.get().clone());
                                let v189: f64 = f64::NAN;
                                let v191: f64 = f64::NAN;
                                let v193: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v189, v191);
                                let v196: num_complex::Complex<f64> = match &v180 {
                                    Math::US0::US0_0(v180_0_0) => match &v180 {
                                        Math::US0::US0_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => v193,
                                };
                                let v198: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v200: num_complex::Complex<f64> = v198 * v105.clone();
                                let v202: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v204: num_complex::Complex<f64> = v200 / v202;
                                let v206: num_complex::Complex<f64> = v204.sin();
                                let v209: f64 = 1.0_f64 - v105.clone().re;
                                let v212: f64 = -v105.clone().im;
                                let v214: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v209, v212);
                                let v595: num_complex::Complex<f64> = if v214.clone().re <= 1.0_f64
                                {
                                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                                } else {
                                    println!("zeta / count: {:?} / s: {:?}", 2_i32, v214.clone());
                                    if v214.clone().re > 1.0_f64 {
                                        let v225: num_complex::Complex<f64> =
                                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                                        let v226: Array<i32> = new_init(&0_i32, 10000_i32);
                                        let v227: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                            l0: MutCell::new(0_i32),
                                        });
                                        while Math::method18(v227.clone()) {
                                            let v229: i32 = v227.l0.get().clone();
                                            v226.get_mut()[v229 as usize] = v229;
                                            {
                                                let v230: i32 = v229 + 1_i32;
                                                v227.l0.set(v230);
                                                ()
                                            }
                                        }
                                        {
                                            let v231: i32 = count(v226.clone());
                                            let v232: LrcPtr<Math::Mut2> =
                                                LrcPtr::new(Math::Mut2 {
                                                    l0: MutCell::new(0_i32),
                                                    l1: MutCell::new(v225),
                                                });
                                            while Math::method19(v231, v232.clone()) {
                                                let v234: i32 = v232.l0.get().clone();
                                                let v235: num_complex::Complex<f64> =
                                                    v232.l1.get().clone();
                                                let v236: i32 = v226[v234].clone();
                                                let v238: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v240: f64 = v236 as f64;
                                                let v242: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v240, 0.0_f64);
                                                let v244: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v242, v214.clone());
                                                let v246: num_complex::Complex<f64> = v238 / v244;
                                                let v248: num_complex::Complex<f64> = v235 + v246;
                                                let v249: i32 = v234 + 1_i32;
                                                v232.l0.set(v249);
                                                v232.l1.set(v248);
                                                ()
                                            }
                                            v232.l1.get().clone()
                                        }
                                    } else {
                                        let v252: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v257: Result<
                                            num_complex::Complex<f64>,
                                            std::string::String,
                                        > = Math::method20(
                                            v0_1.clone(),
                                            string("        s = mpmath.gamma(s)"),
                                            Math::method3(v252 - v214.clone()),
                                        );
                                        let v259: Option<num_complex::Complex<f64>> = v257.ok();
                                        let _v262: LrcPtr<MutCell<Option<Math::US0>>> =
                                            refCell(None::<Math::US0>);
                                        {
                                            let x_8: Option<Math::US0> = match &v259 {
                                                None => None::<Math::US0>,
                                                Some(v259_0_0) => {
                                                    let x_6: num_complex::Complex<f64> =
                                                        v259_0_0.clone();
                                                    Some((Func0::new({
                                                        let x_6 = x_6.clone();
                                                        move || Math::US0::US0_0(x_6.clone())
                                                    }))(
                                                    ))
                                                }
                                            };
                                            _v262.set(x_8)
                                        }
                                        {
                                            let v289: Math::US0 =
                                                defaultValue(Math::US0::US0_1, _v262.get().clone());
                                            let v298: f64 = f64::NAN;
                                            let v300: f64 = f64::NAN;
                                            let v302: num_complex::Complex<f64> =
                                                num_complex::Complex::new(v298, v300);
                                            let v305: num_complex::Complex<f64> = match &v289 {
                                                Math::US0::US0_0(v289_0_0) => match &v289 {
                                                    Math::US0::US0_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                },
                                                _ => v302,
                                            };
                                            let v307: num_complex::Complex<f64> =
                                                num_complex::Complex::new(
                                                    3.141592653589793_f64,
                                                    0.0_f64,
                                                );
                                            let v309: num_complex::Complex<f64> =
                                                v307 * v214.clone();
                                            let v311: num_complex::Complex<f64> =
                                                num_complex::Complex::new(2.0_f64, 0.0_f64);
                                            let v313: num_complex::Complex<f64> = v309 / v311;
                                            let v315: num_complex::Complex<f64> = v313.sin();
                                            let v318: f64 = 1.0_f64 - v214.clone().re;
                                            let v321: f64 = -v214.clone().im;
                                            let v323: num_complex::Complex<f64> =
                                                num_complex::Complex::new(v318, v321);
                                            let v579: num_complex::Complex<f64> = if v323.clone().re
                                                <= 1.0_f64
                                            {
                                                num_complex::Complex::new(0.0_f64, 0.0_f64)
                                            } else {
                                                println!(
                                                    "zeta / count: {:?} / s: {:?}",
                                                    3_i32,
                                                    v323.clone()
                                                );
                                                if v323.clone().re > 1.0_f64 {
                                                    let v334: num_complex::Complex<f64> =
                                                        num_complex::Complex::new(0.0_f64, 0.0_f64);
                                                    let v335: Array<i32> =
                                                        new_init(&0_i32, 10000_i32);
                                                    let v336: LrcPtr<Math::Mut0> =
                                                        LrcPtr::new(Math::Mut0 {
                                                            l0: MutCell::new(0_i32),
                                                        });
                                                    while Math::method18(v336.clone()) {
                                                        let v338: i32 = v336.l0.get().clone();
                                                        v335.get_mut()[v338 as usize] = v338;
                                                        {
                                                            let v339: i32 = v338 + 1_i32;
                                                            v336.l0.set(v339);
                                                            ()
                                                        }
                                                    }
                                                    {
                                                        let v340: i32 = count(v335.clone());
                                                        let v341: LrcPtr<Math::Mut2> =
                                                            LrcPtr::new(Math::Mut2 {
                                                                l0: MutCell::new(0_i32),
                                                                l1: MutCell::new(v334),
                                                            });
                                                        while Math::method19(v340, v341.clone()) {
                                                            let v343: i32 = v341.l0.get().clone();
                                                            let v344: num_complex::Complex<f64> =
                                                                v341.l1.get().clone();
                                                            let v345: i32 = v335[v343].clone();
                                                            let v347: num_complex::Complex<f64> =
                                                                num_complex::Complex::new(
                                                                    1.0_f64, 0.0_f64,
                                                                );
                                                            let v349: f64 = v345 as f64;
                                                            let v351: num_complex::Complex<f64> =
                                                                num_complex::Complex::new(
                                                                    v349, 0.0_f64,
                                                                );
                                                            let v353: num_complex::Complex<f64> =
                                                                num_complex::Complex::powc(
                                                                    v351,
                                                                    v323.clone(),
                                                                );
                                                            let v355: num_complex::Complex<f64> =
                                                                v347 / v353;
                                                            let v357: num_complex::Complex<f64> =
                                                                v344 + v355;
                                                            let v358: i32 = v343 + 1_i32;
                                                            v341.l0.set(v358);
                                                            v341.l1.set(v357);
                                                            ()
                                                        }
                                                        v341.l1.get().clone()
                                                    }
                                                } else {
                                                    let v361: num_complex::Complex<f64> =
                                                        num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                    let v366: Result<
                                                        num_complex::Complex<f64>,
                                                        std::string::String,
                                                    > = Math::method20(
                                                        v0_1.clone(),
                                                        string("        s = mpmath.gamma(s)"),
                                                        Math::method3(v361 - v323.clone()),
                                                    );
                                                    let v368: Option<num_complex::Complex<f64>> =
                                                        v366.ok();
                                                    let _v371: LrcPtr<MutCell<Option<Math::US0>>> =
                                                        refCell(None::<Math::US0>);
                                                    {
                                                        let x_11: Option<Math::US0> = match &v368 {
                                                            None => None::<Math::US0>,
                                                            Some(v368_0_0) => {
                                                                let x_9: num_complex::Complex<f64> =
                                                                    v368_0_0.clone();
                                                                Some((Func0::new({
                                                                    let x_9 = x_9.clone();
                                                                    move || {
                                                                        Math::US0::US0_0(
                                                                            x_9.clone(),
                                                                        )
                                                                    }
                                                                }))(
                                                                ))
                                                            }
                                                        };
                                                        _v371.set(x_11)
                                                    }
                                                    {
                                                        let v398: Math::US0 = defaultValue(
                                                            Math::US0::US0_1,
                                                            _v371.get().clone(),
                                                        );
                                                        let v407: f64 = f64::NAN;
                                                        let v409: f64 = f64::NAN;
                                                        let v411: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(v407, v409);
                                                        let v414: num_complex::Complex<f64> =
                                                            match &v398 {
                                                                Math::US0::US0_0(v398_0_0) => {
                                                                    match &v398 {
                                                                        Math::US0::US0_0(x) => {
                                                                            x.clone()
                                                                        }
                                                                        _ => unreachable!(),
                                                                    }
                                                                }
                                                                _ => v411,
                                                            };
                                                        let v416: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                3.141592653589793_f64,
                                                                0.0_f64,
                                                            );
                                                        let v418: num_complex::Complex<f64> =
                                                            v416 * v323.clone();
                                                        let v420: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                2.0_f64, 0.0_f64,
                                                            );
                                                        let v422: num_complex::Complex<f64> =
                                                            v418 / v420;
                                                        let v424: num_complex::Complex<f64> =
                                                            v422.sin();
                                                        let v427: f64 = 1.0_f64 - v323.clone().re;
                                                        let v430: f64 = -v323.clone().im;
                                                        let v432: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(v427, v430);
                                                        let v563: num_complex::Complex<f64> =
                                                            if v432.clone().re <= 1.0_f64 {
                                                                num_complex::Complex::new(
                                                                    0.0_f64, 0.0_f64,
                                                                )
                                                            } else {
                                                                println!(
                                                                    "zeta / count: {:?} / s: {:?}",
                                                                    4_i32,
                                                                    v432.clone()
                                                                );
                                                                if v432.clone().re > 1.0_f64 {
                                                                    let v443: num_complex::Complex<
                                                                        f64,
                                                                    > = num_complex::Complex::new(
                                                                        0.0_f64, 0.0_f64,
                                                                    );
                                                                    let v444: Array<i32> =
                                                                        new_init(&0_i32, 10000_i32);
                                                                    let v445: LrcPtr<Math::Mut0> =
                                                                        LrcPtr::new(Math::Mut0 {
                                                                            l0: MutCell::new(0_i32),
                                                                        });
                                                                    while Math::method18(
                                                                        v445.clone(),
                                                                    ) {
                                                                        let v447: i32 =
                                                                            v445.l0.get().clone();
                                                                        v444.get_mut()
                                                                            [v447 as usize] = v447;
                                                                        {
                                                                            let v448: i32 =
                                                                                v447 + 1_i32;
                                                                            v445.l0.set(v448);
                                                                            ()
                                                                        }
                                                                    }
                                                                    {
                                                                        let v449: i32 =
                                                                            count(v444.clone());
                                                                        let v450: LrcPtr<
                                                                            Math::Mut2,
                                                                        > = LrcPtr::new(
                                                                            Math::Mut2 {
                                                                                l0: MutCell::new(
                                                                                    0_i32,
                                                                                ),
                                                                                l1: MutCell::new(
                                                                                    v443,
                                                                                ),
                                                                            },
                                                                        );
                                                                        while Math::method19(
                                                                            v449,
                                                                            v450.clone(),
                                                                        ) {
                                                                            let v452: i32 = v450
                                                                                .l0
                                                                                .get()
                                                                                .clone();
                                                                            let v453:
                                                                                                num_complex::Complex<f64> =
                                                                                            v450.l1.get().clone();
                                                                            let v454: i32 =
                                                                                v444[v452].clone();
                                                                            let v456:
                                                                                                num_complex::Complex<f64> =
                                                                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                                            let v458: f64 =
                                                                                v454 as f64;
                                                                            let v460:
                                                                                                num_complex::Complex<f64> =
                                                                                            num_complex::Complex::new(v458, 0.0_f64);
                                                                            let v462:
                                                                                                num_complex::Complex<f64> =
                                                                                            num_complex::Complex::powc(v460, v432.clone());
                                                                            let v464:
                                                                                                num_complex::Complex<f64> =
                                                                                            v456 / v462;
                                                                            let v466:
                                                                                                num_complex::Complex<f64> =
                                                                                            v453 + v464;
                                                                            let v467: i32 =
                                                                                v452 + 1_i32;
                                                                            v450.l0.set(v467);
                                                                            v450.l1.set(v466);
                                                                            ()
                                                                        }
                                                                        v450.l1.get().clone()
                                                                    }
                                                                } else {
                                                                    let v470: num_complex::Complex<
                                                                        f64,
                                                                    > = num_complex::Complex::new(
                                                                        1.0_f64, 0.0_f64,
                                                                    );
                                                                    let v475:
                                                                                        Result<num_complex::Complex<f64>,
                                                                                               std::string::String> =
                                                                                    Math::method20(v0_1,
                                                                                                   string("        s = mpmath.gamma(s)"),
                                                                                                   Math::method3(v470 - v432.clone()));
                                                                    let v477: Option<
                                                                        num_complex::Complex<f64>,
                                                                    > = v475.ok();
                                                                    let _v480: LrcPtr<
                                                                        MutCell<Option<Math::US0>>,
                                                                    > = refCell(None::<Math::US0>);
                                                                    {
                                                                        let x_14: Option<
                                                                            Math::US0,
                                                                        > = match &v477 {
                                                                            None => {
                                                                                None::<Math::US0>
                                                                            }
                                                                            Some(v477_0_0) => {
                                                                                let x_12:
                                                                                                        num_complex::Complex<f64> =
                                                                                                    v477_0_0.clone();
                                                                                Some((Func0::new(
                                                                                    {
                                                                                        let x_12
                                                                                                                         =
                                                                                                                         x_12.clone();
                                                                                        move || {
                                                                                            Math::US0::US0_0(x_12.clone())
                                                                                        }
                                                                                    },
                                                                                ))(
                                                                                ))
                                                                            }
                                                                        };
                                                                        _v480.set(x_14)
                                                                    }
                                                                    {
                                                                        let v507: Math::US0 =
                                                                            defaultValue(
                                                                                Math::US0::US0_1,
                                                                                _v480.get().clone(),
                                                                            );
                                                                        let v516: f64 = f64::NAN;
                                                                        let v518: f64 = f64::NAN;
                                                                        let v520:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(v516, v518);
                                                                        let v523:
                                                                                            num_complex::Complex<f64> =
                                                                                        match &v507
                                                                                            {
                                                                                            Math::US0::US0_0(v507_0_0)
                                                                                            =>
                                                                                            match &v507
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
                                                                                            v520,
                                                                                        };
                                                                        let v525:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                                                        let v527:
                                                                                            num_complex::Complex<f64> =
                                                                                        v525 * v432.clone();
                                                                        let v529:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                                        let v531:
                                                                                            num_complex::Complex<f64> =
                                                                                        v527 / v529;
                                                                        let v533:
                                                                                            num_complex::Complex<f64> =
                                                                                        v531.sin();
                                                                        let v536: f64 = 1.0_f64
                                                                            - v432.clone().re;
                                                                        let v539: f64 =
                                                                            -v432.clone().im;
                                                                        let v541:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(v536, v539);
                                                                        let v547:
                                                                                            num_complex::Complex<f64> =
                                                                                        if v541.clone().re
                                                                                               <=
                                                                                               1.0_f64
                                                                                           {
                                                                                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                                                                                        } else {
                                                                                            v541
                                                                                        };
                                                                        let v549:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                                        let v551:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                                                        let v553:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::powc(v551, v432.clone());
                                                                        let v555:
                                                                                            num_complex::Complex<f64> =
                                                                                        v549 * v553;
                                                                        let v557:
                                                                                            num_complex::Complex<f64> =
                                                                                        v555 * v533;
                                                                        let v559:
                                                                                            num_complex::Complex<f64> =
                                                                                        v557 * v523;
                                                                        v559 * v547
                                                                    }
                                                                }
                                                            };
                                                        let v565: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                2.0_f64, 0.0_f64,
                                                            );
                                                        let v567: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                3.141592653589793_f64,
                                                                0.0_f64,
                                                            );
                                                        let v569: num_complex::Complex<f64> =
                                                            num_complex::Complex::powc(
                                                                v567,
                                                                v323.clone(),
                                                            );
                                                        let v571: num_complex::Complex<f64> =
                                                            v565 * v569;
                                                        let v573: num_complex::Complex<f64> =
                                                            v571 * v424;
                                                        let v575: num_complex::Complex<f64> =
                                                            v573 * v414;
                                                        v575 * v563
                                                    }
                                                }
                                            };
                                            let v581: num_complex::Complex<f64> =
                                                num_complex::Complex::new(2.0_f64, 0.0_f64);
                                            let v583: num_complex::Complex<f64> =
                                                num_complex::Complex::new(
                                                    3.141592653589793_f64,
                                                    0.0_f64,
                                                );
                                            let v585: num_complex::Complex<f64> =
                                                num_complex::Complex::powc(v583, v214.clone());
                                            let v587: num_complex::Complex<f64> = v581 * v585;
                                            let v589: num_complex::Complex<f64> = v587 * v315;
                                            let v591: num_complex::Complex<f64> = v589 * v305;
                                            v591 * v579
                                        }
                                    }
                                };
                                let v597: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v599: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v601: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v599, v105.clone());
                                let v603: num_complex::Complex<f64> = v597 * v601;
                                let v605: num_complex::Complex<f64> = v603 * v206;
                                let v607: num_complex::Complex<f64> = v605 * v196;
                                v607 * v595
                            }
                        }
                    };
                    let v613: num_complex::Complex<f64> =
                        num_complex::Complex::new(2.0_f64, 0.0_f64);
                    let v615: num_complex::Complex<f64> =
                        num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                    let v617: num_complex::Complex<f64> =
                        num_complex::Complex::powc(v615, v1_1.clone());
                    let v619: num_complex::Complex<f64> = v613 * v617;
                    let v621: num_complex::Complex<f64> = v619 * v97;
                    let v623: num_complex::Complex<f64> = v621 * v87;
                    v623 * v611
                }
            }
        }
        pub fn method21(v0_1: bool) -> bool {
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
                let v15: num_complex::Complex<f64> = Math::method17(v0_1.clone(), v10);
                let v17: Option<num_complex::Complex<f64>> = v14.ok();
                let _v20: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
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
                    _v20.set(x_2)
                }
                {
                    let v47: Math::US0 = defaultValue(Math::US0::US0_1, _v20.get().clone());
                    let v56: f64 = f64::NAN;
                    let v58: f64 = f64::NAN;
                    let v60: num_complex::Complex<f64> = num_complex::Complex::new(v56, v58);
                    let v63: num_complex::Complex<f64> = match &v47 {
                        Math::US0::US0_0(v47_0_0) => match &v47 {
                            Math::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v60,
                    };
                    let v65: f64 = v63.clone().im;
                    let v66: bool = v65 == 0.0_f64;
                    let v68: bool = if v66 { true } else { Math::method21(v66) };
                    let v72: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("assert_eq"),
                        v65,
                        0.0_f64
                    );
                    printfn!("{0}", v72.clone());
                    if v68 == false {
                        panic!("{}", v72,);
                    }
                    {
                        let v89: f64 = v63.re - patternInput.1.clone();
                        let v90: f64 = -v89;
                        let v92: f64 = if v89 >= v90 { v89 } else { v90 };
                        let v93: bool = v92 < 0.0001_f64;
                        let v95: bool = if v93 { true } else { Math::method21(v93) };
                        let v99: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("assert_lt"),
                            v92,
                            0.0001_f64
                        );
                        printfn!("{0}", v99.clone());
                        if v95 == false {
                            panic!("{}", v99,);
                        }
                        {
                            let v114: i32 = v9 + 1_i32;
                            v7.l0.set(v114);
                            ()
                        }
                    }
                }
            }
            ()
        }
        pub fn method22(v0_1: Result<(), pyo3::PyErr>) -> Result<(), pyo3::PyErr> {
            v0_1
        }
        pub fn method0() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method1(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method22(Ok::<(), pyo3::PyErr>(()));
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
        pub fn method24(v0_1: pyo3::Python) {
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, -2.0_f64);
            let v5: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v2.clone()),
            );
            let v6: num_complex::Complex<f64> = Math::method17(v0_1, v2);
            let v8: Option<num_complex::Complex<f64>> = v5.ok();
            let _v11: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
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
                _v11.set(x_2)
            }
            {
                let v38: Math::US0 = defaultValue(Math::US0::US0_1, _v11.get().clone());
                let v47: f64 = f64::NAN;
                let v49: f64 = f64::NAN;
                let v51: num_complex::Complex<f64> = num_complex::Complex::new(v47, v49);
                let v54: num_complex::Complex<f64> = match &v38 {
                    Math::US0::US0_0(v38_0_0) => match &v38 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v51,
                };
                let v57: f64 = v54.clone().re - 0.8673_f64;
                let v58: f64 = -v57;
                let v60: f64 = if v57 >= v58 { v57 } else { v58 };
                let v61: bool = v60 < 0.001_f64;
                let v63: bool = if v61 { true } else { Math::method21(v61) };
                let v67: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("assert_lt"),
                    v60,
                    0.001_f64
                );
                printfn!("{0}", v67.clone());
                if v63 == false {
                    panic!("{}", v67,);
                }
                {
                    let v84: f64 = v54.im - 0.275_f64;
                    let v85: f64 = -v84;
                    let v87: f64 = if v84 >= v85 { v84 } else { v85 };
                    let v88: bool = v87 < 0.001_f64;
                    let v90: bool = if v88 { true } else { Math::method21(v88) };
                    let v93: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("assert_lt"),
                        v87,
                        0.001_f64
                    );
                    printfn!("{0}", v93.clone());
                    if v90 == false {
                        panic!("{}", v93,);
                    }
                }
            }
        }
        pub fn method23() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method24(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method22(Ok::<(), pyo3::PyErr>(()));
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
        pub fn method27() -> LrcPtr<Math::UH0> {
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
        pub fn method28(v0_1: pyo3::Python, v1_1: LrcPtr<Math::UH0>) {
            let v0_1: MutCell<pyo3::Python> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1_1.clone());
            '_method28: loop {
                break '_method28 (match v1_1.get().clone().as_ref() {
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
                        let v9: num_complex::Complex<f64> = Math::method17(v0_1.get().clone(), v5);
                        let v11: Option<num_complex::Complex<f64>> = v8.ok();
                        let _v14: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
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
                            _v14.set(x_2)
                        }
                        {
                            let v41: Math::US0 = defaultValue(Math::US0::US0_1, _v14.get().clone());
                            let v50: f64 = f64::NAN;
                            let v52: f64 = f64::NAN;
                            let v54: num_complex::Complex<f64> =
                                num_complex::Complex::new(v50, v52);
                            let v57: num_complex::Complex<f64> = match &v41 {
                                Math::US0::US0_0(v41_0_0) => match &v41 {
                                    Math::US0::US0_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => v54,
                            };
                            let v59: f64 = v57.clone().re;
                            let v60: bool = v59 == 0.0_f64;
                            let v62: bool = if v60 { true } else { Math::method21(v60) };
                            let v66: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("assert_eq"),
                                v59,
                                0.0_f64
                            );
                            printfn!("{0}", v66.clone());
                            if v62 == false {
                                panic!("{}", v66,);
                            }
                            {
                                let v82: f64 = v57.im;
                                let v83: bool = v82 == 0.0_f64;
                                let v85: bool = if v83 { true } else { Math::method21(v83) };
                                let v88: string = sprintf!(
                                    "{} / actual: {:?} / expected: {:?}",
                                    string("assert_eq"),
                                    v82,
                                    0.0_f64
                                );
                                printfn!("{0}", v88.clone());
                                if v85 == false {
                                    panic!("{}", v88,);
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
                                    continue '_method28;
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method26(v0_1: pyo3::Python) {
            Math::method28(v0_1, Math::method27());
        }
        pub fn method25() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method26(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method22(Ok::<(), pyo3::PyErr>(()));
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
        pub fn method30(v0_1: pyo3::Python) {
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
                let v22: num_complex::Complex<f64> = Math::method17(v0_1.clone(), v18);
                let v24: Option<num_complex::Complex<f64>> = v21.ok();
                let _v27: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
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
                    _v27.set(x_2)
                }
                {
                    let v54: Math::US0 = defaultValue(Math::US0::US0_1, _v27.get().clone());
                    let v63: f64 = f64::NAN;
                    let v65: f64 = f64::NAN;
                    let v67: num_complex::Complex<f64> = num_complex::Complex::new(v63, v65);
                    let v70: num_complex::Complex<f64> = match &v54 {
                        Math::US0::US0_0(v54_0_0) => match &v54 {
                            Math::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v67,
                    };
                    let v72: f64 = v70.clone().re;
                    let v73: f64 = -v72;
                    let v75: f64 = if v72 >= v73 { v72 } else { v73 };
                    let v76: bool = v75 < 0.0001_f64;
                    let v78: bool = if v76 { true } else { Math::method21(v76) };
                    let v82: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("assert_lt"),
                        v75,
                        0.0001_f64
                    );
                    printfn!("{0}", v82.clone());
                    if v78 == false {
                        panic!("{}", v82,);
                    }
                    {
                        let v98: f64 = v70.im;
                        let v99: f64 = -v98;
                        let v101: f64 = if v98 >= v99 { v98 } else { v99 };
                        let v102: bool = v101 < 0.0001_f64;
                        let v104: bool = if v102 { true } else { Math::method21(v102) };
                        let v107: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("assert_lt"),
                            v101,
                            0.0001_f64
                        );
                        printfn!("{0}", v107.clone());
                        if v104 == false {
                            panic!("{}", v107,);
                        }
                        {
                            let v122: i32 = v17 + 1_i32;
                            v15.l0.set(v122);
                            ()
                        }
                    }
                }
            }
            ()
        }
        pub fn method29() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method30(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method22(Ok::<(), pyo3::PyErr>(()));
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
        pub fn method32(v0_1: pyo3::Python) {
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
                let v12: num_complex::Complex<f64> = Math::method17(v0_1.clone(), v8);
                let v14: Option<num_complex::Complex<f64>> = v11.ok();
                let _v17: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
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
                    _v17.set(x_2)
                }
                {
                    let v44: Math::US0 = defaultValue(Math::US0::US0_1, _v17.get().clone());
                    let v53: f64 = f64::NAN;
                    let v55: f64 = f64::NAN;
                    let v57: num_complex::Complex<f64> = num_complex::Complex::new(v53, v55);
                    let v60: num_complex::Complex<f64> = match &v44 {
                        Math::US0::US0_0(v44_0_0) => match &v44 {
                            Math::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v57,
                    };
                    let v62: f64 = v60.clone().re;
                    let v63: bool = v62 > 0.0_f64;
                    let v65: bool = if v63 { true } else { Math::method21(v63) };
                    let v69: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("assert_gt"),
                        v62,
                        0.0_f64
                    );
                    printfn!("{0}", v69.clone());
                    if v65 == false {
                        panic!("{}", v69,);
                    }
                    {
                        let v85: f64 = v60.im;
                        let v86: bool = v85 == 0.0_f64;
                        let v88: bool = if v86 { true } else { Math::method21(v86) };
                        let v92: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("assert_eq"),
                            v85,
                            0.0_f64
                        );
                        printfn!("{0}", v92.clone());
                        if v88 == false {
                            panic!("{}", v92,);
                        }
                        {
                            let v107: i32 = v5 + 1_i32;
                            v3.l0.set(v107);
                            ()
                        }
                    }
                }
            }
            ()
        }
        pub fn method31() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method32(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method22(Ok::<(), pyo3::PyErr>(()));
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
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(1.0_f64, 0.0_f64);
            let v5: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v2.clone()),
            );
            let v6: num_complex::Complex<f64> = Math::method17(v0_1, v2);
            let v8: Option<num_complex::Complex<f64>> = v5.ok();
            let _v11: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
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
                _v11.set(x_2)
            }
            {
                let v38: Math::US0 = defaultValue(Math::US0::US0_1, _v11.get().clone());
                let v47: f64 = f64::NAN;
                let v49: f64 = f64::NAN;
                let v51: num_complex::Complex<f64> = num_complex::Complex::new(v47, v49);
                let v54: num_complex::Complex<f64> = match &v38 {
                    Math::US0::US0_0(v38_0_0) => match &v38 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v51,
                };
                let v56: f64 = v54.clone().re;
                let v57: bool = v56 == f64::INFINITY;
                let v59: bool = if v57 { true } else { Math::method21(v57) };
                let v63: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("assert_eq"),
                    v56,
                    f64::INFINITY
                );
                printfn!("{0}", v63.clone());
                if v59 == false {
                    panic!("{}", v63,);
                }
                {
                    let v79: f64 = v54.im;
                    let v80: bool = v79 == 0.0_f64;
                    let v82: bool = if v80 { true } else { Math::method21(v80) };
                    let v85: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("assert_eq"),
                        v79,
                        0.0_f64
                    );
                    printfn!("{0}", v85.clone());
                    if v82 == false {
                        panic!("{}", v85,);
                    }
                }
            }
        }
        pub fn method33() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method34(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method22(Ok::<(), pyo3::PyErr>(()));
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
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 10.0_f64);
            let v5: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v2.clone()),
            );
            let v6: num_complex::Complex<f64> = Math::method17(v0_1.clone(), v2.clone());
            let v8: Option<num_complex::Complex<f64>> = v5.ok();
            let _v11: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
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
                _v11.set(x_2)
            }
            {
                let v38: Math::US0 = defaultValue(Math::US0::US0_1, _v11.get().clone());
                let v47: f64 = f64::NAN;
                let v49: f64 = f64::NAN;
                let v51: num_complex::Complex<f64> = num_complex::Complex::new(v47, v49);
                let v54: num_complex::Complex<f64> = match &v38 {
                    Math::US0::US0_0(v38_0_0) => match &v38 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v51,
                };
                let v56: f64 = v2.clone().re;
                let v59: f64 = -v2.im;
                let v61: num_complex::Complex<f64> = num_complex::Complex::new(v56, v59);
                let v64: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                    v0_1.clone(),
                    string("        s = mpmath.zeta(s)"),
                    Math::method3(v61.clone()),
                );
                let v65: num_complex::Complex<f64> = Math::method17(v0_1, v61);
                let v67: Option<num_complex::Complex<f64>> = v64.ok();
                let _v70: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
                {
                    let x_5: Option<Math::US0> = match &v67 {
                        None => None::<Math::US0>,
                        Some(v67_0_0) => {
                            let x_3: num_complex::Complex<f64> = v67_0_0.clone();
                            Some((Func0::new({
                                let x_3 = x_3.clone();
                                move || Math::US0::US0_0(x_3.clone())
                            }))())
                        }
                    };
                    _v70.set(x_5)
                }
                {
                    let v97: Math::US0 = defaultValue(Math::US0::US0_1, _v70.get().clone());
                    let v106: f64 = f64::NAN;
                    let v108: f64 = f64::NAN;
                    let v110: num_complex::Complex<f64> = num_complex::Complex::new(v106, v108);
                    let v113: num_complex::Complex<f64> = match &v97 {
                        Math::US0::US0_0(v97_0_0) => match &v97 {
                            Math::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v110,
                    };
                    let v115: num_complex::Complex<f64> = v113.conj();
                    let v117: f64 = v54.clone().re;
                    let v119: f64 = v115.clone().re;
                    let v120: bool = v117 == v119;
                    let v122: bool = if v120 { true } else { Math::method21(v120) };
                    let v126: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("assert_eq"),
                        v117,
                        v119
                    );
                    printfn!("{0}", v126.clone());
                    if v122 == false {
                        panic!("{}", v126,);
                    }
                    {
                        let v142: f64 = v54.im;
                        let v144: f64 = v115.im;
                        let v145: bool = v142 == v144;
                        let v147: bool = if v145 { true } else { Math::method21(v145) };
                        let v150: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("assert_eq"),
                            v142,
                            v144
                        );
                        printfn!("{0}", v150.clone());
                        if v147 == false {
                            panic!("{}", v150,);
                        }
                    }
                }
            }
        }
        pub fn method35() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method36(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method22(Ok::<(), pyo3::PyErr>(()));
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
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(0.01_f64, 0.01_f64);
            let v5: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v2.clone()),
            );
            let v6: num_complex::Complex<f64> = Math::method17(v0_1, v2);
            let v8: Option<num_complex::Complex<f64>> = v5.ok();
            let _v11: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
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
                _v11.set(x_2)
            }
            {
                let v38: Math::US0 = defaultValue(Math::US0::US0_1, _v11.get().clone());
                let v47: f64 = f64::NAN;
                let v49: f64 = f64::NAN;
                let v51: num_complex::Complex<f64> = num_complex::Complex::new(v47, v49);
                let v54: num_complex::Complex<f64> = match &v38 {
                    Math::US0::US0_0(v38_0_0) => match &v38 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v51,
                };
                let v56: f64 = v54.clone().re;
                let v57: bool = v56 < f64::INFINITY;
                let v59: bool = if v57 { true } else { Math::method21(v57) };
                let v63: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("assert_lt"),
                    v56,
                    f64::INFINITY
                );
                printfn!("{0}", v63.clone());
                if v59 == false {
                    panic!("{}", v63,);
                }
                {
                    let v79: f64 = v54.im;
                    let v80: bool = v79 < f64::INFINITY;
                    let v82: bool = if v80 { true } else { Math::method21(v80) };
                    let v85: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("assert_lt"),
                        v79,
                        f64::INFINITY
                    );
                    printfn!("{0}", v85.clone());
                    if v82 == false {
                        panic!("{}", v85,);
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
                    let v5: Result<(), pyo3::PyErr> = Math::method22(Ok::<(), pyo3::PyErr>(()));
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
        pub fn method41() -> LrcPtr<Math::UH0> {
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
        pub fn method42(v0_1: pyo3::Python, v1_1: LrcPtr<Math::UH0>) {
            let v0_1: MutCell<pyo3::Python> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1_1.clone());
            '_method42: loop {
                break '_method42 (match v1_1.get().clone().as_ref() {
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
                        let v9: num_complex::Complex<f64> = Math::method17(v0_1.get().clone(), v5);
                        let v11: Option<num_complex::Complex<f64>> = v8.ok();
                        let _v14: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
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
                            _v14.set(x_2)
                        }
                        {
                            let v41: Math::US0 = defaultValue(Math::US0::US0_1, _v14.get().clone());
                            let v50: f64 = f64::NAN;
                            let v52: f64 = f64::NAN;
                            let v54: num_complex::Complex<f64> =
                                num_complex::Complex::new(v50, v52);
                            let v57: num_complex::Complex<f64> = match &v41 {
                                Math::US0::US0_0(v41_0_0) => match &v41 {
                                    Math::US0::US0_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => v54,
                            };
                            let v59: f64 = v57.clone().re;
                            let v62: bool = v59 != 0.0_f64;
                            let v70: bool = if v62 { true } else { Math::method21(v62) };
                            let v74: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("assert_ne"),
                                v59,
                                0.0_f64
                            );
                            printfn!("{0}", v74.clone());
                            if v70 == false {
                                panic!("{}", v74,);
                            }
                            {
                                let v90: f64 = v57.im;
                                let v93: bool = v90 != 0.0_f64;
                                let v101: bool = if v93 { true } else { Math::method21(v93) };
                                let v104: string = sprintf!(
                                    "{} / actual: {:?} / expected: {:?}",
                                    string("assert_ne"),
                                    v90,
                                    0.0_f64
                                );
                                printfn!("{0}", v104.clone());
                                if v101 == false {
                                    panic!("{}", v104,);
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
                                    continue '_method42;
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method40(v0_1: pyo3::Python) {
            Math::method42(v0_1, Math::method41());
        }
        pub fn method39() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method40(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method22(Ok::<(), pyo3::PyErr>(()));
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
        pub fn method45() -> LrcPtr<Math::UH1> {
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
        pub fn method46(v0_1: pyo3::Python, v1_1: LrcPtr<Math::UH1>) {
            let v0_1: MutCell<pyo3::Python> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Math::UH1>> = MutCell::new(v1_1.clone());
            '_method46: loop {
                break '_method46 (match v1_1.get().clone().as_ref() {
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
                        let v7: num_complex::Complex<f64> = Math::method17(v0_1.get().clone(), v2);
                        let v9: Option<num_complex::Complex<f64>> = v6.ok();
                        let _v12: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
                        {
                            let x_2: Option<Math::US0> = match &v9 {
                                None => None::<Math::US0>,
                                Some(v9_0_0) => {
                                    let x: num_complex::Complex<f64> = v9_0_0.clone();
                                    Some((Func0::new({
                                        let x = x.clone();
                                        move || Math::US0::US0_0(x.clone())
                                    }))())
                                }
                            };
                            _v12.set(x_2)
                        }
                        {
                            let v39: Math::US0 = defaultValue(Math::US0::US0_1, _v12.get().clone());
                            let v48: f64 = f64::NAN;
                            let v50: f64 = f64::NAN;
                            let v52: num_complex::Complex<f64> =
                                num_complex::Complex::new(v48, v50);
                            let v55: num_complex::Complex<f64> = match &v39 {
                                Math::US0::US0_0(v39_0_0) => match &v39 {
                                    Math::US0::US0_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => v52,
                            };
                            let v57: f64 = v55.clone().re;
                            let v60: bool = v57 != 0.0_f64;
                            let v68: bool = if v60 { true } else { Math::method21(v60) };
                            let v72: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("assert_ne"),
                                v57,
                                0.0_f64
                            );
                            printfn!("{0}", v72.clone());
                            if v68 == false {
                                panic!("{}", v72,);
                            }
                            {
                                let v88: f64 = v55.im;
                                let v91: bool = v88 != 0.0_f64;
                                let v99: bool = if v91 { true } else { Math::method21(v91) };
                                let v102: string = sprintf!(
                                    "{} / actual: {:?} / expected: {:?}",
                                    string("assert_ne"),
                                    v88,
                                    0.0_f64
                                );
                                printfn!("{0}", v102.clone());
                                if v99 == false {
                                    panic!("{}", v102,);
                                }
                                {
                                    let v0_1_temp: pyo3::Python = v0_1.get().clone();
                                    let v1_1_temp: LrcPtr<Math::UH1> =
                                        match v1_1.get().clone().as_ref() {
                                            Math::UH1::UH1_1(_, x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    continue '_method46;
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method44(v0_1: pyo3::Python) {
            Math::method46(v0_1, Math::method45());
        }
        pub fn method43() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method44(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method22(Ok::<(), pyo3::PyErr>(()));
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
        pub fn method49() -> LrcPtr<Math::UH1> {
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
        pub fn method50(v0_1: pyo3::Python, v1_1: LrcPtr<Math::UH1>) {
            let v0_1: MutCell<pyo3::Python> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Math::UH1>> = MutCell::new(v1_1.clone());
            '_method50: loop {
                break '_method50 (match v1_1.get().clone().as_ref() {
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
                            Math::method17(v0_1.get().clone(), v2.clone());
                        let v9: Option<num_complex::Complex<f64>> = v6.ok();
                        let _v12: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
                        {
                            let x_2: Option<Math::US0> = match &v9 {
                                None => None::<Math::US0>,
                                Some(v9_0_0) => {
                                    let x: num_complex::Complex<f64> = v9_0_0.clone();
                                    Some((Func0::new({
                                        let x = x.clone();
                                        move || Math::US0::US0_0(x.clone())
                                    }))())
                                }
                            };
                            _v12.set(x_2)
                        }
                        {
                            let v39: Math::US0 = defaultValue(Math::US0::US0_1, _v12.get().clone());
                            let v48: f64 = f64::NAN;
                            let v50: f64 = f64::NAN;
                            let v52: num_complex::Complex<f64> =
                                num_complex::Complex::new(v48, v50);
                            let v55: num_complex::Complex<f64> = match &v39 {
                                Math::US0::US0_0(v39_0_0) => match &v39 {
                                    Math::US0::US0_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => v52,
                            };
                            let v57: num_complex::Complex<f64> =
                                num_complex::Complex::new(2.0_f64, 0.0_f64);
                            let v59: num_complex::Complex<f64> =
                                num_complex::Complex::powc(v57, v2.clone());
                            let v61: num_complex::Complex<f64> =
                                num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                            let v63: num_complex::Complex<f64> =
                                num_complex::Complex::new(1.0_f64, 0.0_f64);
                            let v65: num_complex::Complex<f64> = v2.clone() - v63;
                            let v67: num_complex::Complex<f64> =
                                num_complex::Complex::powc(v61, v65);
                            let v69: num_complex::Complex<f64> = v59 * v67;
                            let v71: num_complex::Complex<f64> =
                                num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                            let v73: num_complex::Complex<f64> = v71 * v2.clone();
                            let v75: num_complex::Complex<f64> =
                                num_complex::Complex::new(2.0_f64, 0.0_f64);
                            let v77: num_complex::Complex<f64> = v73 / v75;
                            let v79: num_complex::Complex<f64> = v77.sin();
                            let v81: num_complex::Complex<f64> = v69 * v79;
                            let v83: num_complex::Complex<f64> =
                                num_complex::Complex::new(1.0_f64, 0.0_f64);
                            let v88: Result<num_complex::Complex<f64>, std::string::String> =
                                Math::method20(
                                    v0_1.get().clone(),
                                    string("        s = mpmath.gamma(s)"),
                                    Math::method3(v83 - v2.clone()),
                                );
                            let v90: Option<num_complex::Complex<f64>> = v88.ok();
                            let _v93: LrcPtr<MutCell<Option<Math::US0>>> =
                                refCell(None::<Math::US0>);
                            {
                                let x_5: Option<Math::US0> = match &v90 {
                                    None => None::<Math::US0>,
                                    Some(v90_0_0) => {
                                        let x_3: num_complex::Complex<f64> = v90_0_0.clone();
                                        Some((Func0::new({
                                            let x_3 = x_3.clone();
                                            move || Math::US0::US0_0(x_3.clone())
                                        }))())
                                    }
                                };
                                _v93.set(x_5)
                            }
                            {
                                let v120: Math::US0 =
                                    defaultValue(Math::US0::US0_1, _v93.get().clone());
                                let v129: f64 = f64::NAN;
                                let v131: f64 = f64::NAN;
                                let v133: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v129, v131);
                                let v136: num_complex::Complex<f64> = match &v120 {
                                    Math::US0::US0_0(v120_0_0) => match &v120 {
                                        Math::US0::US0_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => v133,
                                };
                                let v138: num_complex::Complex<f64> = v81 * v136;
                                let v141: f64 = 1.0_f64 - v2.clone().re;
                                let v144: f64 = -v2.im;
                                let v146: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v141, v144);
                                let v149: Result<num_complex::Complex<f64>, std::string::String> =
                                    Math::method4(
                                        v0_1.get().clone(),
                                        string("        s = mpmath.zeta(s)"),
                                        Math::method3(v146.clone()),
                                    );
                                let v150: num_complex::Complex<f64> =
                                    Math::method17(v0_1.get().clone(), v146);
                                let v152: Option<num_complex::Complex<f64>> = v149.ok();
                                let _v155: LrcPtr<MutCell<Option<Math::US0>>> =
                                    refCell(None::<Math::US0>);
                                {
                                    let x_8: Option<Math::US0> = match &v152 {
                                        None => None::<Math::US0>,
                                        Some(v152_0_0) => {
                                            let x_6: num_complex::Complex<f64> = v152_0_0.clone();
                                            Some((Func0::new({
                                                let x_6 = x_6.clone();
                                                move || Math::US0::US0_0(x_6.clone())
                                            }))())
                                        }
                                    };
                                    _v155.set(x_8)
                                }
                                {
                                    let v182: Math::US0 =
                                        defaultValue(Math::US0::US0_1, _v155.get().clone());
                                    let v191: f64 = f64::NAN;
                                    let v193: f64 = f64::NAN;
                                    let v195: num_complex::Complex<f64> =
                                        num_complex::Complex::new(v191, v193);
                                    let v198: num_complex::Complex<f64> = match &v182 {
                                        Math::US0::US0_0(v182_0_0) => match &v182 {
                                            Math::US0::US0_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => v195,
                                    };
                                    let v200: num_complex::Complex<f64> = v138 * v198;
                                    let v205: f64 = v55.clone().re - v200.clone().re;
                                    let v206: f64 = -v205;
                                    let v208: f64 = if v205 >= v206 { v205 } else { v206 };
                                    let v209: bool = v208 < 0.0001_f64;
                                    let v211: bool = if v209 { true } else { Math::method21(v209) };
                                    let v215: string = sprintf!(
                                        "{} / actual: {:?} / expected: {:?}",
                                        string("assert_lt"),
                                        v208,
                                        0.0001_f64
                                    );
                                    printfn!("{0}", v215.clone());
                                    if v211 == false {
                                        panic!("{}", v215,);
                                    }
                                    {
                                        let v234: f64 = v55.im - v200.im;
                                        let v235: f64 = -v234;
                                        let v237: f64 = if v234 >= v235 { v234 } else { v235 };
                                        let v238: bool = v237 < 0.0001_f64;
                                        let v240: bool =
                                            if v238 { true } else { Math::method21(v238) };
                                        let v243: string = sprintf!(
                                            "{} / actual: {:?} / expected: {:?}",
                                            string("assert_lt"),
                                            v237,
                                            0.0001_f64
                                        );
                                        printfn!("{0}", v243.clone());
                                        if v240 == false {
                                            panic!("{}", v243,);
                                        }
                                        {
                                            let v0_1_temp: pyo3::Python = v0_1.get().clone();
                                            let v1_1_temp: LrcPtr<Math::UH1> =
                                                match v1_1.get().clone().as_ref() {
                                                    Math::UH1::UH1_1(_, x) => x.clone(),
                                                    _ => unreachable!(),
                                                };
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            continue '_method50;
                                        }
                                    }
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method48(v0_1: pyo3::Python) {
            Math::method50(v0_1, Math::method49());
        }
        pub fn method47() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method48(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method22(Ok::<(), pyo3::PyErr>(()));
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
        pub fn method53() -> LrcPtr<Math::UH0> {
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
        pub fn method54() -> LrcPtr<Math::UH0> {
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
        pub fn method56(v0_1: f64, v1_1: LrcPtr<Math::UH0>, v2: f64) -> f64 {
            let v0_1: MutCell<f64> = MutCell::new(v0_1);
            let v1_1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1_1.clone());
            let v2: MutCell<f64> = MutCell::new(v2);
            '_method56: loop {
                break '_method56 (match v1_1.get().clone().as_ref() {
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
                            continue '_method56;
                        }
                    }
                });
            }
        }
        pub fn method55(v0_1: pyo3::Python, v1_1: LrcPtr<Math::UH0>, v2: LrcPtr<Math::UH0>) {
            let v0_1: MutCell<pyo3::Python> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v2.clone());
            '_method55: loop {
                break '_method55 (match v2.get().clone().as_ref() {
                    Math::UH0::UH0_0 => (),
                    Math::UH0::UH0_1(v2_1_0, v2_1_1) => {
                        let v3: f64 = match v2.get().clone().as_ref() {
                            Math::UH0::UH0_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v6: num_complex::Complex<f64> = num_complex::Complex::new(v3, 0.0_f64);
                        let v8: f64 = Math::method56(v3, v1_1.get().clone(), 1.0_f64);
                        let v11: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(
                                v0_1.get().clone(),
                                string("        s = mpmath.zeta(s)"),
                                Math::method3(v6.clone()),
                            );
                        let v12: num_complex::Complex<f64> = Math::method17(v0_1.get().clone(), v6);
                        let v14: Option<num_complex::Complex<f64>> = v11.ok();
                        let _v17: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
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
                            _v17.set(x_2)
                        }
                        {
                            let v44: Math::US0 = defaultValue(Math::US0::US0_1, _v17.get().clone());
                            let v53: f64 = f64::NAN;
                            let v55: f64 = f64::NAN;
                            let v57: num_complex::Complex<f64> =
                                num_complex::Complex::new(v53, v55);
                            let v60: num_complex::Complex<f64> = match &v44 {
                                Math::US0::US0_0(v44_0_0) => match &v44 {
                                    Math::US0::US0_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => v57,
                            };
                            let v63: f64 = v60.clone().re - v8;
                            let v64: f64 = -v63;
                            let v66: f64 = if v63 >= v64 { v63 } else { v64 };
                            let v67: bool = v66 < 0.01_f64;
                            let v69: bool = if v67 { true } else { Math::method21(v67) };
                            let v73: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("assert_lt"),
                                v66,
                                0.01_f64
                            );
                            printfn!("{0}", v73.clone());
                            if v69 == false {
                                panic!("{}", v73,);
                            }
                            {
                                let v89: f64 = v60.im;
                                let v90: bool = v89 < 0.01_f64;
                                let v92: bool = if v90 { true } else { Math::method21(v90) };
                                let v95: string = sprintf!(
                                    "{} / actual: {:?} / expected: {:?}",
                                    string("assert_lt"),
                                    v89,
                                    0.01_f64
                                );
                                printfn!("{0}", v95.clone());
                                if v92 == false {
                                    panic!("{}", v95,);
                                }
                                {
                                    let v0_1_temp: pyo3::Python = v0_1.get().clone();
                                    let v1_1_temp: LrcPtr<Math::UH0> = v1_1.get().clone();
                                    let v2_temp: LrcPtr<Math::UH0> = match v2.get().clone().as_ref()
                                    {
                                        Math::UH0::UH0_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    continue '_method55;
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method52(v0_1: pyo3::Python) {
            let v1_1: LrcPtr<Math::UH0> = Math::method53();
            Math::method55(v0_1, Math::method54(), v1_1)
        }
        pub fn method51() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method52(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method22(Ok::<(), pyo3::PyErr>(()));
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
            Math::method23();
        } /* /*;
          {
              let v12: string =
                  string("*/ #[test] fn test_trivial_zero_at_negative_even___() { //");
              let v13: bool =
                  */
        #[test]
        fn test_trivial_zero_at_negative_even___() {
            //;
            Math::method25();
        } /* /*;
          {
              let v16: string =
                  string("*/ #[test] fn test_non_trivial_zero___() { //");
              let v17: bool =
                  */
        #[test]
        fn test_non_trivial_zero___() {
            //;
            Math::method29();
        } /* /*;
          {
              let v20: string =
                  string("*/ #[test] fn test_real_part_greater_than_one___() { //");
              let v21: bool =
                  */
        #[test]
        fn test_real_part_greater_than_one___() {
            //;
            Math::method31();
        } /* /*;
          {
              let v24: string =
                  string("*/ #[test] fn test_zeta_at_1___() { //");
              let v25: bool =
                  */
        #[test]
        fn test_zeta_at_1___() {
            //;
            Math::method33();
        } /* /*;
          {
              let v28: string =
                  string("*/ #[test] fn test_symmetry_across_real_axis___() { //");
              let v29: bool =
                  */
        #[test]
        fn test_symmetry_across_real_axis___() {
            //;
            Math::method35();
        } /* /*;
          {
              let v32: string =
                  string("*/ #[test] fn test_behavior_near_origin___() { //");
              let v33: bool =
                  */
        #[test]
        fn test_behavior_near_origin___() {
            //;
            Math::method37();
        } /* /*;
          {
              let v36: string =
                  string("*/ #[test] fn test_imaginary_axis() { //");
              let v37: bool =
                  */
        #[test]
        fn test_imaginary_axis() {
            //;
            Math::method39();
        } /* /*;
          {
              let v40: string =
                  string("*/ #[test] fn test_critical_strip() { //");
              let v41: bool =
                  */
        #[test]
        fn test_critical_strip() {
            //;
            Math::method43();
        } /* /*;
          {
              let v44: string =
                  string("*/ #[test] fn test_reflection_formula_for_specific_value() { //");
              let v45: bool =
                  */
        #[test]
        fn test_reflection_formula_for_specific_value() {
            //;
            Math::method47();
        } /* /*;
          {
              let v48: string =
                  string("*/ #[test] fn test_euler_product_formula() { //");
              let v49: bool =
                  */
        #[test]
        fn test_euler_product_formula() {
            //;
            Math::method51();
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
