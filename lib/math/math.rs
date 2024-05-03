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
        use fable_library_rust::Option_::getValue;
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
        impl Math::US0 {
            pub fn get_IsUS0_0(this_: &MutCell<Math::US0>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS0_1(this_: &MutCell<Math::US0>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
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
        impl Math::UH0 {
            pub fn get_IsUH0_0(this_: LrcPtr<Math::UH0>, unitArg: ()) -> bool {
                if let Math::UH0::UH0_0 = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUH0_1(this_: LrcPtr<Math::UH0>, unitArg: ()) -> bool {
                if let Math::UH0::UH0_1(this__1_0, this__1_1) = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
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
            getValue(_v1.get().clone())
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
            getValue(_v1.get().clone())
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
            getValue(_v1.get().clone())
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
            getValue(_v1.get().clone())
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
            let v47: &str = fable_library_rust::String_::LrcStr::as_str(&v36);
            let v49: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code_bound(v45, v47, "", "");
            let v50 = Math::method10();
            let v52: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                v49.map_err(|x| v50(x));
            let v54: pyo3::Bound<pyo3::types::PyModule> = v52.unwrap();
            let v55: string = Math::method11();
            let v57: &str = fable_library_rust::String_::LrcStr::as_str(&v55);
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
            let v47: &str = fable_library_rust::String_::LrcStr::as_str(&v36);
            let v49: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code_bound(v45, v47, "", "");
            let v50 = Math::method10();
            let v52: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                v49.map_err(|x| v50(x));
            let v54: pyo3::Bound<pyo3::types::PyModule> = v52.unwrap();
            let v55: string = Math::method11();
            let v57: &str = fable_library_rust::String_::LrcStr::as_str(&v55);
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
        pub fn closure5(unitVar: (), v0_1: num_complex::Complex<f64>) -> Math::US0 {
            Math::US0::US0_0(v0_1)
        }
        pub fn method25() -> Func1<num_complex::Complex<f64>, Math::US0> {
            Func1::new(move |v: num_complex::Complex<f64>| Math::closure5((), v))
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
                            let v22: f64 = v19 as f64;
                            let v25: num_complex::Complex<f64> =
                                Math::method22(num_complex::Complex::new(v22, 0.0_f64));
                            let v26: num_complex::Complex<f64> = Math::method23(v1_1.clone());
                            let v28: num_complex::Complex<f64> =
                                num_complex::Complex::powc(v25, v26);
                            let v30: num_complex::Complex<f64> = v21 / v28;
                            let v32: num_complex::Complex<f64> = v18 + v30;
                            let v33: i32 = v17 + 1_i32;
                            v15.l0.set(v33);
                            v15.l1.set(v32);
                            ()
                        }
                        v15.l1.get().clone()
                    }
                } else {
                    let v36: num_complex::Complex<f64> =
                        num_complex::Complex::new(1.0_f64, 0.0_f64);
                    let v41: Result<num_complex::Complex<f64>, std::string::String> =
                        Math::method24(
                            v0_1.clone(),
                            string("        s = mpmath.gamma(s)"),
                            Math::method3(v36 - v1_1.clone()),
                        );
                    let v43: Option<num_complex::Complex<f64>> = v41.ok();
                    let v46: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method25(), v43));
                    let v48: f64 = f64::NAN;
                    let v50: f64 = f64::NAN;
                    let v52: num_complex::Complex<f64> = num_complex::Complex::new(v48, v50);
                    let v55: num_complex::Complex<f64> = match &v46 {
                        Math::US0::US0_0(v46_0_0) => match &v46 {
                            Math::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v52,
                    };
                    let v57: num_complex::Complex<f64> =
                        num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                    let v59: num_complex::Complex<f64> = v57 * v1_1.clone();
                    let v61: num_complex::Complex<f64> =
                        num_complex::Complex::new(2.0_f64, 0.0_f64);
                    let v63: num_complex::Complex<f64> = v59 / v61;
                    let v65: num_complex::Complex<f64> = v63.sin();
                    let v66: num_complex::Complex<f64> = Math::method7(v1_1.clone());
                    let v69: f64 = 1.0_f64 - v66.re;
                    let v70: num_complex::Complex<f64> = Math::method8(v1_1.clone());
                    let v73: f64 = -v70.im;
                    let v75: num_complex::Complex<f64> = num_complex::Complex::new(v69, v73);
                    let v76: num_complex::Complex<f64> = Math::method7(v75.clone());
                    let v474: num_complex::Complex<f64> = if v76.re <= 1.0_f64 {
                        num_complex::Complex::new(0.0_f64, 0.0_f64)
                    } else {
                        println!("zeta / count: {:?} / s: {:?}", 1, v75.clone());
                        {
                            let v83: num_complex::Complex<f64> = Math::method7(v75.clone());
                            if v83.re > 1.0_f64 {
                                let v88: num_complex::Complex<f64> =
                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                let v89: Array<i32> = new_init(&0_i32, 10000_i32);
                                let v90: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Math::method20(v90.clone()) {
                                    let v92: i32 = v90.l0.get().clone();
                                    v89.get_mut()[v92 as usize] = v92;
                                    {
                                        let v93: i32 = v92 + 1_i32;
                                        v90.l0.set(v93);
                                        ()
                                    }
                                }
                                {
                                    let v94: i32 = count(v89.clone());
                                    let v95: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                        l0: MutCell::new(0_i32),
                                        l1: MutCell::new(v88),
                                    });
                                    while Math::method21(v94, v95.clone()) {
                                        let v97: i32 = v95.l0.get().clone();
                                        let v98: num_complex::Complex<f64> = v95.l1.get().clone();
                                        let v99: i32 = v89[v97].clone();
                                        let v101: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v102: f64 = v99 as f64;
                                        let v105: num_complex::Complex<f64> = Math::method22(
                                            num_complex::Complex::new(v102, 0.0_f64),
                                        );
                                        let v106: num_complex::Complex<f64> =
                                            Math::method23(v75.clone());
                                        let v108: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v105, v106);
                                        let v110: num_complex::Complex<f64> = v101 / v108;
                                        let v112: num_complex::Complex<f64> = v98 + v110;
                                        let v113: i32 = v97 + 1_i32;
                                        v95.l0.set(v113);
                                        v95.l1.set(v112);
                                        ()
                                    }
                                    v95.l1.get().clone()
                                }
                            } else {
                                let v116: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v121: Result<num_complex::Complex<f64>, std::string::String> =
                                    Math::method24(
                                        v0_1.clone(),
                                        string("        s = mpmath.gamma(s)"),
                                        Math::method3(v116 - v75.clone()),
                                    );
                                let v123: Option<num_complex::Complex<f64>> = v121.ok();
                                let v126: Math::US0 =
                                    defaultValue(Math::US0::US0_1, map(Math::method25(), v123));
                                let v128: f64 = f64::NAN;
                                let v130: f64 = f64::NAN;
                                let v132: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v128, v130);
                                let v135: num_complex::Complex<f64> = match &v126 {
                                    Math::US0::US0_0(v126_0_0) => match &v126 {
                                        Math::US0::US0_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => v132,
                                };
                                let v137: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v139: num_complex::Complex<f64> = v137 * v75.clone();
                                let v141: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v143: num_complex::Complex<f64> = v139 / v141;
                                let v145: num_complex::Complex<f64> = v143.sin();
                                let v146: num_complex::Complex<f64> = Math::method7(v75.clone());
                                let v149: f64 = 1.0_f64 - v146.re;
                                let v150: num_complex::Complex<f64> = Math::method8(v75.clone());
                                let v153: f64 = -v150.im;
                                let v155: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v149, v153);
                                let v156: num_complex::Complex<f64> = Math::method7(v155.clone());
                                let v456: num_complex::Complex<f64> = if v156.re <= 1.0_f64 {
                                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                                } else {
                                    println!("zeta / count: {:?} / s: {:?}", 2, v155.clone());
                                    {
                                        let v163: num_complex::Complex<f64> =
                                            Math::method7(v155.clone());
                                        if v163.re > 1.0_f64 {
                                            let v168: num_complex::Complex<f64> =
                                                num_complex::Complex::new(0.0_f64, 0.0_f64);
                                            let v169: Array<i32> = new_init(&0_i32, 10000_i32);
                                            let v170: LrcPtr<Math::Mut0> =
                                                LrcPtr::new(Math::Mut0 {
                                                    l0: MutCell::new(0_i32),
                                                });
                                            while Math::method20(v170.clone()) {
                                                let v172: i32 = v170.l0.get().clone();
                                                v169.get_mut()[v172 as usize] = v172;
                                                {
                                                    let v173: i32 = v172 + 1_i32;
                                                    v170.l0.set(v173);
                                                    ()
                                                }
                                            }
                                            {
                                                let v174: i32 = count(v169.clone());
                                                let v175: LrcPtr<Math::Mut2> =
                                                    LrcPtr::new(Math::Mut2 {
                                                        l0: MutCell::new(0_i32),
                                                        l1: MutCell::new(v168),
                                                    });
                                                while Math::method21(v174, v175.clone()) {
                                                    let v177: i32 = v175.l0.get().clone();
                                                    let v178: num_complex::Complex<f64> =
                                                        v175.l1.get().clone();
                                                    let v179: i32 = v169[v177].clone();
                                                    let v181: num_complex::Complex<f64> =
                                                        num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                    let v182: f64 = v179 as f64;
                                                    let v185: num_complex::Complex<f64> =
                                                        Math::method22(num_complex::Complex::new(
                                                            v182, 0.0_f64,
                                                        ));
                                                    let v186: num_complex::Complex<f64> =
                                                        Math::method23(v155.clone());
                                                    let v188: num_complex::Complex<f64> =
                                                        num_complex::Complex::powc(v185, v186);
                                                    let v190: num_complex::Complex<f64> =
                                                        v181 / v188;
                                                    let v192: num_complex::Complex<f64> =
                                                        v178 + v190;
                                                    let v193: i32 = v177 + 1_i32;
                                                    v175.l0.set(v193);
                                                    v175.l1.set(v192);
                                                    ()
                                                }
                                                v175.l1.get().clone()
                                            }
                                        } else {
                                            let v196: num_complex::Complex<f64> =
                                                num_complex::Complex::new(1.0_f64, 0.0_f64);
                                            let v201: Result<
                                                num_complex::Complex<f64>,
                                                std::string::String,
                                            > = Math::method24(
                                                v0_1.clone(),
                                                string("        s = mpmath.gamma(s)"),
                                                Math::method3(v196 - v155.clone()),
                                            );
                                            let v203: Option<num_complex::Complex<f64>> = v201.ok();
                                            let v206: Math::US0 = defaultValue(
                                                Math::US0::US0_1,
                                                map(Math::method25(), v203),
                                            );
                                            let v208: f64 = f64::NAN;
                                            let v210: f64 = f64::NAN;
                                            let v212: num_complex::Complex<f64> =
                                                num_complex::Complex::new(v208, v210);
                                            let v215: num_complex::Complex<f64> = match &v206 {
                                                Math::US0::US0_0(v206_0_0) => match &v206 {
                                                    Math::US0::US0_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                },
                                                _ => v212,
                                            };
                                            let v217: num_complex::Complex<f64> =
                                                num_complex::Complex::new(
                                                    3.141592653589793_f64,
                                                    0.0_f64,
                                                );
                                            let v219: num_complex::Complex<f64> =
                                                v217 * v155.clone();
                                            let v221: num_complex::Complex<f64> =
                                                num_complex::Complex::new(2.0_f64, 0.0_f64);
                                            let v223: num_complex::Complex<f64> = v219 / v221;
                                            let v225: num_complex::Complex<f64> = v223.sin();
                                            let v226: num_complex::Complex<f64> =
                                                Math::method7(v155.clone());
                                            let v229: f64 = 1.0_f64 - v226.re;
                                            let v230: num_complex::Complex<f64> =
                                                Math::method8(v155.clone());
                                            let v233: f64 = -v230.im;
                                            let v235: num_complex::Complex<f64> =
                                                num_complex::Complex::new(v229, v233);
                                            let v236: num_complex::Complex<f64> =
                                                Math::method7(v235.clone());
                                            let v438: num_complex::Complex<f64> = if v236.re
                                                <= 1.0_f64
                                            {
                                                num_complex::Complex::new(0.0_f64, 0.0_f64)
                                            } else {
                                                println!(
                                                    "zeta / count: {:?} / s: {:?}",
                                                    3,
                                                    v235.clone()
                                                );
                                                {
                                                    let v243: num_complex::Complex<f64> =
                                                        Math::method7(v235.clone());
                                                    if v243.re > 1.0_f64 {
                                                        let v248: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                0.0_f64, 0.0_f64,
                                                            );
                                                        let v249: Array<i32> =
                                                            new_init(&0_i32, 10000_i32);
                                                        let v250: LrcPtr<Math::Mut0> =
                                                            LrcPtr::new(Math::Mut0 {
                                                                l0: MutCell::new(0_i32),
                                                            });
                                                        while Math::method20(v250.clone()) {
                                                            let v252: i32 = v250.l0.get().clone();
                                                            v249.get_mut()[v252 as usize] = v252;
                                                            {
                                                                let v253: i32 = v252 + 1_i32;
                                                                v250.l0.set(v253);
                                                                ()
                                                            }
                                                        }
                                                        {
                                                            let v254: i32 = count(v249.clone());
                                                            let v255: LrcPtr<Math::Mut2> =
                                                                LrcPtr::new(Math::Mut2 {
                                                                    l0: MutCell::new(0_i32),
                                                                    l1: MutCell::new(v248),
                                                                });
                                                            while Math::method21(v254, v255.clone())
                                                            {
                                                                let v257: i32 =
                                                                    v255.l0.get().clone();
                                                                let v258: num_complex::Complex<
                                                                    f64,
                                                                > = v255.l1.get().clone();
                                                                let v259: i32 = v249[v257].clone();
                                                                let v261: num_complex::Complex<
                                                                    f64,
                                                                > = num_complex::Complex::new(
                                                                    1.0_f64, 0.0_f64,
                                                                );
                                                                let v262: f64 = v259 as f64;
                                                                let v265: num_complex::Complex<
                                                                    f64,
                                                                > = Math::method22(
                                                                    num_complex::Complex::new(
                                                                        v262, 0.0_f64,
                                                                    ),
                                                                );
                                                                let v266: num_complex::Complex<
                                                                    f64,
                                                                > = Math::method23(v235.clone());
                                                                let v268: num_complex::Complex<
                                                                    f64,
                                                                > = num_complex::Complex::powc(
                                                                    v265, v266,
                                                                );
                                                                let v270: num_complex::Complex<
                                                                    f64,
                                                                > = v261 / v268;
                                                                let v272: num_complex::Complex<
                                                                    f64,
                                                                > = v258 + v270;
                                                                let v273: i32 = v257 + 1_i32;
                                                                v255.l0.set(v273);
                                                                v255.l1.set(v272);
                                                                ()
                                                            }
                                                            v255.l1.get().clone()
                                                        }
                                                    } else {
                                                        let v276: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                1.0_f64, 0.0_f64,
                                                            );
                                                        let v281: Result<
                                                            num_complex::Complex<f64>,
                                                            std::string::String,
                                                        > = Math::method24(
                                                            v0_1.clone(),
                                                            string("        s = mpmath.gamma(s)"),
                                                            Math::method3(v276 - v235.clone()),
                                                        );
                                                        let v283: Option<
                                                            num_complex::Complex<f64>,
                                                        > = v281.ok();
                                                        let v286: Math::US0 = defaultValue(
                                                            Math::US0::US0_1,
                                                            map(Math::method25(), v283),
                                                        );
                                                        let v288: f64 = f64::NAN;
                                                        let v290: f64 = f64::NAN;
                                                        let v292: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(v288, v290);
                                                        let v295: num_complex::Complex<f64> =
                                                            match &v286 {
                                                                Math::US0::US0_0(v286_0_0) => {
                                                                    match &v286 {
                                                                        Math::US0::US0_0(x) => {
                                                                            x.clone()
                                                                        }
                                                                        _ => unreachable!(),
                                                                    }
                                                                }
                                                                _ => v292,
                                                            };
                                                        let v297: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                3.141592653589793_f64,
                                                                0.0_f64,
                                                            );
                                                        let v299: num_complex::Complex<f64> =
                                                            v297 * v235.clone();
                                                        let v301: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                2.0_f64, 0.0_f64,
                                                            );
                                                        let v303: num_complex::Complex<f64> =
                                                            v299 / v301;
                                                        let v305: num_complex::Complex<f64> =
                                                            v303.sin();
                                                        let v306: num_complex::Complex<f64> =
                                                            Math::method7(v235.clone());
                                                        let v309: f64 = 1.0_f64 - v306.re;
                                                        let v310: num_complex::Complex<f64> =
                                                            Math::method8(v235.clone());
                                                        let v313: f64 = -v310.im;
                                                        let v315: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(v309, v313);
                                                        let v316: num_complex::Complex<f64> =
                                                            Math::method7(v315.clone());
                                                        let v420: num_complex::Complex<f64> =
                                                            if v316.re <= 1.0_f64 {
                                                                num_complex::Complex::new(
                                                                    0.0_f64, 0.0_f64,
                                                                )
                                                            } else {
                                                                println!(
                                                                    "zeta / count: {:?} / s: {:?}",
                                                                    4,
                                                                    v315.clone()
                                                                );
                                                                {
                                                                    let v323: num_complex::Complex<
                                                                        f64,
                                                                    > = Math::method7(v315.clone());
                                                                    if v323.re > 1.0_f64 {
                                                                        let v328:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(0.0_f64, 0.0_f64);
                                                                        let v329: Array<i32> =
                                                                            new_init(
                                                                                &0_i32, 10000_i32,
                                                                            );
                                                                        let v330: LrcPtr<
                                                                            Math::Mut0,
                                                                        > = LrcPtr::new(
                                                                            Math::Mut0 {
                                                                                l0: MutCell::new(
                                                                                    0_i32,
                                                                                ),
                                                                            },
                                                                        );
                                                                        while Math::method20(
                                                                            v330.clone(),
                                                                        ) {
                                                                            let v332: i32 = v330
                                                                                .l0
                                                                                .get()
                                                                                .clone();
                                                                            v329.get_mut()
                                                                                [v332 as usize] =
                                                                                v332;
                                                                            {
                                                                                let v333: i32 =
                                                                                    v332 + 1_i32;
                                                                                v330.l0.set(v333);
                                                                                ()
                                                                            }
                                                                        }
                                                                        {
                                                                            let v334: i32 =
                                                                                count(v329.clone());
                                                                            let v335: LrcPtr<
                                                                                Math::Mut2,
                                                                            > = LrcPtr::new(
                                                                                Math::Mut2 {
                                                                                    l0:
                                                                                        MutCell::new(
                                                                                            0_i32,
                                                                                        ),
                                                                                    l1:
                                                                                        MutCell::new(
                                                                                            v328,
                                                                                        ),
                                                                                },
                                                                            );
                                                                            while Math::method21(
                                                                                v334,
                                                                                v335.clone(),
                                                                            ) {
                                                                                let v337: i32 =
                                                                                    v335.l0
                                                                                        .get()
                                                                                        .clone();
                                                                                let v338:
                                                                                                    num_complex::Complex<f64> =
                                                                                                v335.l1.get().clone();
                                                                                let v339: i32 =
                                                                                    v329[v337]
                                                                                        .clone();
                                                                                let v341:
                                                                                                    num_complex::Complex<f64> =
                                                                                                num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                                                let v342: f64 =
                                                                                    v339 as f64;
                                                                                let v345:
                                                                                                    num_complex::Complex<f64> =
                                                                                                Math::method22(num_complex::Complex::new(v342, 0.0_f64));
                                                                                let v346:
                                                                                                    num_complex::Complex<f64> =
                                                                                                Math::method23(v315.clone());
                                                                                let v348:
                                                                                                    num_complex::Complex<f64> =
                                                                                                num_complex::Complex::powc(v345, v346);
                                                                                let v350:
                                                                                                    num_complex::Complex<f64> =
                                                                                                v341 / v348;
                                                                                let v352:
                                                                                                    num_complex::Complex<f64> =
                                                                                                v338 + v350;
                                                                                let v353: i32 =
                                                                                    v337 + 1_i32;
                                                                                v335.l0.set(v353);
                                                                                v335.l1.set(v352);
                                                                                ()
                                                                            }
                                                                            v335.l1.get().clone()
                                                                        }
                                                                    } else {
                                                                        let v356:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                                        let v361:
                                                                                            Result<num_complex::Complex<f64>,
                                                                                                   std::string::String> =
                                                                                        Math::method24(v0_1,
                                                                                                       string("        s = mpmath.gamma(s)"),
                                                                                                       Math::method3(v356 - v315.clone()));
                                                                        let v363: Option<
                                                                            num_complex::Complex<
                                                                                f64,
                                                                            >,
                                                                        > = v361.ok();
                                                                        let v366: Math::US0 =
                                                                            defaultValue(
                                                                                Math::US0::US0_1,
                                                                                map(
                                                                                    Math::method25(
                                                                                    ),
                                                                                    v363,
                                                                                ),
                                                                            );
                                                                        let v368: f64 = f64::NAN;
                                                                        let v370: f64 = f64::NAN;
                                                                        let v372:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(v368, v370);
                                                                        let v375:
                                                                                            num_complex::Complex<f64> =
                                                                                        match &v366
                                                                                            {
                                                                                            Math::US0::US0_0(v366_0_0)
                                                                                            =>
                                                                                            match &v366
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
                                                                                            v372,
                                                                                        };
                                                                        let v377:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                                                        let v379:
                                                                                            num_complex::Complex<f64> =
                                                                                        v377 * v315.clone();
                                                                        let v381:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                                        let v383:
                                                                                            num_complex::Complex<f64> =
                                                                                        v379 / v381;
                                                                        let v385:
                                                                                            num_complex::Complex<f64> =
                                                                                        v383.sin();
                                                                        let v386:
                                                                                            num_complex::Complex<f64> =
                                                                                        Math::method7(v315.clone());
                                                                        let v389: f64 =
                                                                            1.0_f64 - v386.re;
                                                                        let v390:
                                                                                            num_complex::Complex<f64> =
                                                                                        Math::method8(v315.clone());
                                                                        let v393: f64 = -v390.im;
                                                                        let v395:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(v389, v393);
                                                                        let v396:
                                                                                            num_complex::Complex<f64> =
                                                                                        Math::method7(v395.clone());
                                                                        let v402:
                                                                                            num_complex::Complex<f64> =
                                                                                        if v396.re
                                                                                               <=
                                                                                               1.0_f64
                                                                                           {
                                                                                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                                                                                        } else {
                                                                                            v395
                                                                                        };
                                                                        let v404:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                                        let v407:
                                                                                            num_complex::Complex<f64> =
                                                                                        Math::method22(num_complex::Complex::new(3.141592653589793_f64, 0.0_f64));
                                                                        let v408:
                                                                                            num_complex::Complex<f64> =
                                                                                        Math::method23(v315.clone());
                                                                        let v410:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::powc(v407, v408);
                                                                        let v412:
                                                                                            num_complex::Complex<f64> =
                                                                                        v404 * v410;
                                                                        let v414:
                                                                                            num_complex::Complex<f64> =
                                                                                        v412 * v385;
                                                                        let v416:
                                                                                            num_complex::Complex<f64> =
                                                                                        v414 * v375;
                                                                        v416 * v402
                                                                    }
                                                                }
                                                            };
                                                        let v422: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                2.0_f64, 0.0_f64,
                                                            );
                                                        let v425: num_complex::Complex<f64> =
                                                            Math::method22(
                                                                num_complex::Complex::new(
                                                                    3.141592653589793_f64,
                                                                    0.0_f64,
                                                                ),
                                                            );
                                                        let v426: num_complex::Complex<f64> =
                                                            Math::method23(v235.clone());
                                                        let v428: num_complex::Complex<f64> =
                                                            num_complex::Complex::powc(v425, v426);
                                                        let v430: num_complex::Complex<f64> =
                                                            v422 * v428;
                                                        let v432: num_complex::Complex<f64> =
                                                            v430 * v305;
                                                        let v434: num_complex::Complex<f64> =
                                                            v432 * v295;
                                                        v434 * v420
                                                    }
                                                }
                                            };
                                            let v440: num_complex::Complex<f64> =
                                                num_complex::Complex::new(2.0_f64, 0.0_f64);
                                            let v443: num_complex::Complex<f64> =
                                                Math::method22(num_complex::Complex::new(
                                                    3.141592653589793_f64,
                                                    0.0_f64,
                                                ));
                                            let v444: num_complex::Complex<f64> =
                                                Math::method23(v155.clone());
                                            let v446: num_complex::Complex<f64> =
                                                num_complex::Complex::powc(v443, v444);
                                            let v448: num_complex::Complex<f64> = v440 * v446;
                                            let v450: num_complex::Complex<f64> = v448 * v225;
                                            let v452: num_complex::Complex<f64> = v450 * v215;
                                            v452 * v438
                                        }
                                    }
                                };
                                let v458: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v461: num_complex::Complex<f64> = Math::method22(
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64),
                                );
                                let v462: num_complex::Complex<f64> = Math::method23(v75.clone());
                                let v464: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v461, v462);
                                let v466: num_complex::Complex<f64> = v458 * v464;
                                let v468: num_complex::Complex<f64> = v466 * v145;
                                let v470: num_complex::Complex<f64> = v468 * v135;
                                v470 * v456
                            }
                        }
                    };
                    let v476: num_complex::Complex<f64> =
                        num_complex::Complex::new(2.0_f64, 0.0_f64);
                    let v479: num_complex::Complex<f64> =
                        Math::method22(num_complex::Complex::new(3.141592653589793_f64, 0.0_f64));
                    let v480: num_complex::Complex<f64> = Math::method23(v1_1.clone());
                    let v482: num_complex::Complex<f64> = num_complex::Complex::powc(v479, v480);
                    let v484: num_complex::Complex<f64> = v476 * v482;
                    let v486: num_complex::Complex<f64> = v484 * v65;
                    let v488: num_complex::Complex<f64> = v486 * v55;
                    v488 * v474
                }
            }
        }
        pub fn method26(v0_1: bool) -> bool {
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
                let v20: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method25(), v17));
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
                let v30: num_complex::Complex<f64> = Math::method8(v29.clone());
                let v32: f64 = v30.im;
                let v33: bool = v32 == 0.0_f64;
                let v35: bool = if v33 { true } else { Math::method26(v33) };
                let v37: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("assert_eq"),
                    v32,
                    0.0_f64
                );
                printfn!("{0}", v37.clone());
                if v35 == false {
                    panic!("{}", v37,);
                }
                {
                    let v39: num_complex::Complex<f64> = Math::method7(v29);
                    let v42: f64 = v39.re - patternInput.1.clone();
                    let v43: f64 = -v42;
                    let v45: f64 = if v42 >= v43 { v42 } else { v43 };
                    let v46: bool = v45 < 0.0001_f64;
                    let v48: bool = if v46 { true } else { Math::method26(v46) };
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
                        let v52: i32 = v9 + 1_i32;
                        v7.l0.set(v52);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method27(v0_1: Result<(), pyo3::PyErr>) -> Result<(), pyo3::PyErr> {
            v0_1
        }
        pub fn method0() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method1(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method27(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v9: Result<(), pyo3::PyErr> = __result;
                    v9.unwrap();
                    ()
                }
            }
        }
        pub fn method29(v0_1: pyo3::Python) {
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, -2.0_f64);
            let v5: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v2.clone()),
            );
            let v6: num_complex::Complex<f64> = Math::method19(v0_1, v2);
            let v8: Option<num_complex::Complex<f64>> = v5.ok();
            let v11: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method25(), v8));
            let v13: f64 = f64::NAN;
            let v15: f64 = f64::NAN;
            let v17: num_complex::Complex<f64> = num_complex::Complex::new(v13, v15);
            let v20: num_complex::Complex<f64> = match &v11 {
                Math::US0::US0_0(v11_0_0) => match &v11 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v17,
            };
            let v21: num_complex::Complex<f64> = Math::method7(v20.clone());
            let v24: f64 = v21.re - 0.8673_f64;
            let v25: f64 = -v24;
            let v27: f64 = if v24 >= v25 { v24 } else { v25 };
            let v28: bool = v27 < 0.001_f64;
            let v30: bool = if v28 { true } else { Math::method26(v28) };
            let v32: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("assert_lt"),
                v27,
                0.001_f64
            );
            printfn!("{0}", v32.clone());
            if v30 == false {
                panic!("{}", v32,);
            }
            {
                let v34: num_complex::Complex<f64> = Math::method8(v20);
                let v37: f64 = v34.im - 0.275_f64;
                let v38: f64 = -v37;
                let v40: f64 = if v37 >= v38 { v37 } else { v38 };
                let v41: bool = v40 < 0.001_f64;
                let v43: bool = if v41 { true } else { Math::method26(v41) };
                let v44: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("assert_lt"),
                    v40,
                    0.001_f64
                );
                printfn!("{0}", v44.clone());
                if v43 == false {
                    panic!("{}", v44,);
                }
            }
        }
        pub fn method28() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method29(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method27(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v9: Result<(), pyo3::PyErr> = __result;
                    v9.unwrap();
                    ()
                }
            }
        }
        pub fn method32() -> LrcPtr<Math::UH0> {
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
        pub fn method33(v0_1: pyo3::Python, v1_1: LrcPtr<Math::UH0>) {
            let v0_1: MutCell<pyo3::Python> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1_1.clone());
            '_method33: loop {
                break '_method33 (match v1_1.get().clone().as_ref() {
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
                        let v14: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method25(), v11));
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
                        let v27: bool = v26 == 0.0_f64;
                        let v29: bool = if v27 { true } else { Math::method26(v27) };
                        let v31: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("assert_eq"),
                            v26,
                            0.0_f64
                        );
                        printfn!("{0}", v31.clone());
                        if v29 == false {
                            panic!("{}", v31,);
                        }
                        {
                            let v33: num_complex::Complex<f64> = Math::method8(v23);
                            let v35: f64 = v33.im;
                            let v36: bool = v35 == 0.0_f64;
                            let v38: bool = if v36 { true } else { Math::method26(v36) };
                            let v39: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("assert_eq"),
                                v35,
                                0.0_f64
                            );
                            printfn!("{0}", v39.clone());
                            if v38 == false {
                                panic!("{}", v39,);
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
                                continue '_method33;
                            }
                        }
                    }
                });
            }
        }
        pub fn method31(v0_1: pyo3::Python) {
            Math::method33(v0_1, Math::method32());
        }
        pub fn method30() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method31(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method27(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v9: Result<(), pyo3::PyErr> = __result;
                    v9.unwrap();
                    ()
                }
            }
        }
        pub fn method35(v0_1: pyo3::Python) {
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
                let v27: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method25(), v24));
                let v29: f64 = f64::NAN;
                let v31: f64 = f64::NAN;
                let v33: num_complex::Complex<f64> = num_complex::Complex::new(v29, v31);
                let v36: num_complex::Complex<f64> = match &v27 {
                    Math::US0::US0_0(v27_0_0) => match &v27 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v33,
                };
                let v37: num_complex::Complex<f64> = Math::method7(v36.clone());
                let v39: f64 = v37.re;
                let v40: f64 = -v39;
                let v42: f64 = if v39 >= v40 { v39 } else { v40 };
                let v43: bool = v42 < 0.0001_f64;
                let v45: bool = if v43 { true } else { Math::method26(v43) };
                let v47: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("assert_lt"),
                    v42,
                    0.0001_f64
                );
                printfn!("{0}", v47.clone());
                if v45 == false {
                    panic!("{}", v47,);
                }
                {
                    let v49: num_complex::Complex<f64> = Math::method8(v36);
                    let v51: f64 = v49.im;
                    let v52: f64 = -v51;
                    let v54: f64 = if v51 >= v52 { v51 } else { v52 };
                    let v55: bool = v54 < 0.0001_f64;
                    let v57: bool = if v55 { true } else { Math::method26(v55) };
                    let v58: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("assert_lt"),
                        v54,
                        0.0001_f64
                    );
                    printfn!("{0}", v58.clone());
                    if v57 == false {
                        panic!("{}", v58,);
                    }
                    {
                        let v60: i32 = v17 + 1_i32;
                        v15.l0.set(v60);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method34() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method35(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method27(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v9: Result<(), pyo3::PyErr> = __result;
                    v9.unwrap();
                    ()
                }
            }
        }
        pub fn method37(v0_1: pyo3::Python) {
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
                let v17: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method25(), v14));
                let v19: f64 = f64::NAN;
                let v21: f64 = f64::NAN;
                let v23: num_complex::Complex<f64> = num_complex::Complex::new(v19, v21);
                let v26: num_complex::Complex<f64> = match &v17 {
                    Math::US0::US0_0(v17_0_0) => match &v17 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v23,
                };
                let v27: num_complex::Complex<f64> = Math::method7(v26.clone());
                let v29: f64 = v27.re;
                let v30: bool = v29 > 0.0_f64;
                let v32: bool = if v30 { true } else { Math::method26(v30) };
                let v34: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("assert_gt"),
                    v29,
                    0.0_f64
                );
                printfn!("{0}", v34.clone());
                if v32 == false {
                    panic!("{}", v34,);
                }
                {
                    let v36: num_complex::Complex<f64> = Math::method8(v26);
                    let v38: f64 = v36.im;
                    let v39: bool = v38 == 0.0_f64;
                    let v41: bool = if v39 { true } else { Math::method26(v39) };
                    let v43: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("assert_eq"),
                        v38,
                        0.0_f64
                    );
                    printfn!("{0}", v43.clone());
                    if v41 == false {
                        panic!("{}", v43,);
                    }
                    {
                        let v45: i32 = v5 + 1_i32;
                        v3.l0.set(v45);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method36() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method37(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method27(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v9: Result<(), pyo3::PyErr> = __result;
                    v9.unwrap();
                    ()
                }
            }
        }
        pub fn method39(v0_1: pyo3::Python) {
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(1.0_f64, 0.0_f64);
            let v5: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v2.clone()),
            );
            let v6: num_complex::Complex<f64> = Math::method19(v0_1, v2);
            let v8: Option<num_complex::Complex<f64>> = v5.ok();
            let v11: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method25(), v8));
            let v13: f64 = f64::NAN;
            let v15: f64 = f64::NAN;
            let v17: num_complex::Complex<f64> = num_complex::Complex::new(v13, v15);
            let v20: num_complex::Complex<f64> = match &v11 {
                Math::US0::US0_0(v11_0_0) => match &v11 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v17,
            };
            let v21: num_complex::Complex<f64> = Math::method7(v20.clone());
            let v23: f64 = v21.re;
            let v24: bool = v23 == f64::INFINITY;
            let v26: bool = if v24 { true } else { Math::method26(v24) };
            let v28: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("assert_eq"),
                v23,
                f64::INFINITY
            );
            printfn!("{0}", v28.clone());
            if v26 == false {
                panic!("{}", v28,);
            }
            {
                let v30: num_complex::Complex<f64> = Math::method8(v20);
                let v32: f64 = v30.im;
                let v33: bool = v32 == 0.0_f64;
                let v35: bool = if v33 { true } else { Math::method26(v33) };
                let v36: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("assert_eq"),
                    v32,
                    0.0_f64
                );
                printfn!("{0}", v36.clone());
                if v35 == false {
                    panic!("{}", v36,);
                }
            }
        }
        pub fn method38() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method39(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method27(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v9: Result<(), pyo3::PyErr> = __result;
                    v9.unwrap();
                    ()
                }
            }
        }
        pub fn method41(v0_1: pyo3::Python) {
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 10.0_f64);
            let v5: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v2.clone()),
            );
            let v6: num_complex::Complex<f64> = Math::method19(v0_1.clone(), v2.clone());
            let v8: Option<num_complex::Complex<f64>> = v5.ok();
            let v11: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method25(), v8));
            let v13: f64 = f64::NAN;
            let v15: f64 = f64::NAN;
            let v17: num_complex::Complex<f64> = num_complex::Complex::new(v13, v15);
            let v20: num_complex::Complex<f64> = match &v11 {
                Math::US0::US0_0(v11_0_0) => match &v11 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v17,
            };
            let v21: num_complex::Complex<f64> = Math::method7(v2.clone());
            let v23: f64 = v21.re;
            let v24: num_complex::Complex<f64> = Math::method8(v2);
            let v27: f64 = -v24.im;
            let v29: num_complex::Complex<f64> = num_complex::Complex::new(v23, v27);
            let v32: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v29.clone()),
            );
            let v33: num_complex::Complex<f64> = Math::method19(v0_1, v29);
            let v35: Option<num_complex::Complex<f64>> = v32.ok();
            let v38: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method25(), v35));
            let v40: f64 = f64::NAN;
            let v42: f64 = f64::NAN;
            let v44: num_complex::Complex<f64> = num_complex::Complex::new(v40, v42);
            let v47: num_complex::Complex<f64> = match &v38 {
                Math::US0::US0_0(v38_0_0) => match &v38 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v44,
            };
            let v49: num_complex::Complex<f64> = v47.conj();
            let v50: num_complex::Complex<f64> = Math::method7(v20.clone());
            let v52: f64 = v50.re;
            let v53: num_complex::Complex<f64> = Math::method7(v49.clone());
            let v55: f64 = v53.re;
            let v56: bool = v52 == v55;
            let v58: bool = if v56 { true } else { Math::method26(v56) };
            let v60: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("assert_eq"),
                v52,
                v55
            );
            printfn!("{0}", v60.clone());
            if v58 == false {
                panic!("{}", v60,);
            }
            {
                let v62: num_complex::Complex<f64> = Math::method8(v20);
                let v64: f64 = v62.im;
                let v65: num_complex::Complex<f64> = Math::method8(v49);
                let v67: f64 = v65.im;
                let v68: bool = v64 == v67;
                let v70: bool = if v68 { true } else { Math::method26(v68) };
                let v71: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("assert_eq"),
                    v64,
                    v67
                );
                printfn!("{0}", v71.clone());
                if v70 == false {
                    panic!("{}", v71,);
                }
            }
        }
        pub fn method40() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method41(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method27(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v9: Result<(), pyo3::PyErr> = __result;
                    v9.unwrap();
                    ()
                }
            }
        }
        pub fn method43(v0_1: pyo3::Python) {
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(0.01_f64, 0.01_f64);
            let v5: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v2.clone()),
            );
            let v6: num_complex::Complex<f64> = Math::method19(v0_1, v2);
            let v8: Option<num_complex::Complex<f64>> = v5.ok();
            let v11: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method25(), v8));
            let v13: f64 = f64::NAN;
            let v15: f64 = f64::NAN;
            let v17: num_complex::Complex<f64> = num_complex::Complex::new(v13, v15);
            let v20: num_complex::Complex<f64> = match &v11 {
                Math::US0::US0_0(v11_0_0) => match &v11 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v17,
            };
            let v21: num_complex::Complex<f64> = Math::method7(v20.clone());
            let v23: f64 = v21.re;
            let v24: bool = v23 < f64::INFINITY;
            let v26: bool = if v24 { true } else { Math::method26(v24) };
            let v28: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("assert_lt"),
                v23,
                f64::INFINITY
            );
            printfn!("{0}", v28.clone());
            if v26 == false {
                panic!("{}", v28,);
            }
            {
                let v30: num_complex::Complex<f64> = Math::method8(v20);
                let v32: f64 = v30.im;
                let v33: bool = v32 < f64::INFINITY;
                let v35: bool = if v33 { true } else { Math::method26(v33) };
                let v36: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("assert_lt"),
                    v32,
                    f64::INFINITY
                );
                printfn!("{0}", v36.clone());
                if v35 == false {
                    panic!("{}", v36,);
                }
            }
        }
        pub fn method42() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method43(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method27(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v9: Result<(), pyo3::PyErr> = __result;
                    v9.unwrap();
                    ()
                }
            }
        }
        pub fn method46() -> Array<f64> {
            new_array(&[
                10.0_f64, 20.0_f64, 30.0_f64, 40.0_f64, 50.0_f64, 60.0_f64, 70.0_f64, 80.0_f64,
                90.0_f64, 100.0_f64,
            ])
        }
        pub fn method45(v0_1: pyo3::Python) {
            let v1_1: Array<f64> = Math::method46();
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
                let v17: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method25(), v14));
                let v19: f64 = f64::NAN;
                let v21: f64 = f64::NAN;
                let v23: num_complex::Complex<f64> = num_complex::Complex::new(v19, v21);
                let v26: num_complex::Complex<f64> = match &v17 {
                    Math::US0::US0_0(v17_0_0) => match &v17 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v23,
                };
                let v27: num_complex::Complex<f64> = Math::method7(v26.clone());
                let v29: f64 = v27.re;
                let v30: bool = v29 != 0.0_f64;
                let v32: bool = if v30 { true } else { Math::method26(v30) };
                let v34: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("assert_ne"),
                    v29,
                    0.0_f64
                );
                printfn!("{0}", v34.clone());
                if v32 == false {
                    panic!("{}", v34,);
                }
                {
                    let v36: num_complex::Complex<f64> = Math::method8(v26);
                    let v38: f64 = v36.im;
                    let v39: bool = v38 != 0.0_f64;
                    let v41: bool = if v39 { true } else { Math::method26(v39) };
                    let v42: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("assert_ne"),
                        v38,
                        0.0_f64
                    );
                    printfn!("{0}", v42.clone());
                    if v41 == false {
                        panic!("{}", v42,);
                    }
                    {
                        let v44: i32 = v5 + 1_i32;
                        v3.l0.set(v44);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method44() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method45(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method27(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v9: Result<(), pyo3::PyErr> = __result;
                    v9.unwrap();
                    ()
                }
            }
        }
        pub fn method48(v0_1: pyo3::Python) {
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
                let v25: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method25(), v22));
                let v27: f64 = f64::NAN;
                let v29: f64 = f64::NAN;
                let v31: num_complex::Complex<f64> = num_complex::Complex::new(v27, v29);
                let v34: num_complex::Complex<f64> = match &v25 {
                    Math::US0::US0_0(v25_0_0) => match &v25 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v31,
                };
                let v35: num_complex::Complex<f64> = Math::method7(v34.clone());
                let v37: f64 = v35.re;
                let v38: bool = v37 != 0.0_f64;
                let v40: bool = if v38 { true } else { Math::method26(v38) };
                let v42: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("assert_ne"),
                    v37,
                    0.0_f64
                );
                printfn!("{0}", v42.clone());
                if v40 == false {
                    panic!("{}", v42,);
                }
                {
                    let v44: num_complex::Complex<f64> = Math::method8(v34);
                    let v46: f64 = v44.im;
                    let v47: bool = v46 != 0.0_f64;
                    let v49: bool = if v47 { true } else { Math::method26(v47) };
                    let v50: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("assert_ne"),
                        v46,
                        0.0_f64
                    );
                    printfn!("{0}", v50.clone());
                    if v49 == false {
                        panic!("{}", v50,);
                    }
                    {
                        let v52: i32 = v15 + 1_i32;
                        v13.l0.set(v52);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method47() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method48(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method27(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v9: Result<(), pyo3::PyErr> = __result;
                    v9.unwrap();
                    ()
                }
            }
        }
        pub fn method50(v0_1: pyo3::Python) {
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
                let v23: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method25(), v20));
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
                let v35: num_complex::Complex<f64> =
                    Math::method22(num_complex::Complex::new(2.0_f64, 0.0_f64));
                let v36: num_complex::Complex<f64> = Math::method23(v14.clone());
                let v38: num_complex::Complex<f64> = num_complex::Complex::powc(v35, v36);
                let v40: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v42: num_complex::Complex<f64> = num_complex::Complex::new(1.0_f64, 0.0_f64);
                let v44: num_complex::Complex<f64> = v14.clone() - v42;
                let v45: num_complex::Complex<f64> = Math::method22(v40);
                let v46: num_complex::Complex<f64> = Math::method23(v44);
                let v48: num_complex::Complex<f64> = num_complex::Complex::powc(v45, v46);
                let v50: num_complex::Complex<f64> = v38 * v48;
                let v52: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v54: num_complex::Complex<f64> = v52 * v14.clone();
                let v56: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v58: num_complex::Complex<f64> = v54 / v56;
                let v60: num_complex::Complex<f64> = v58.sin();
                let v62: num_complex::Complex<f64> = v50 * v60;
                let v64: num_complex::Complex<f64> = num_complex::Complex::new(1.0_f64, 0.0_f64);
                let v69: Result<num_complex::Complex<f64>, std::string::String> = Math::method24(
                    v0_1.clone(),
                    string("        s = mpmath.gamma(s)"),
                    Math::method3(v64 - v14.clone()),
                );
                let v71: Option<num_complex::Complex<f64>> = v69.ok();
                let v74: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method25(), v71));
                let v76: f64 = f64::NAN;
                let v78: f64 = f64::NAN;
                let v80: num_complex::Complex<f64> = num_complex::Complex::new(v76, v78);
                let v83: num_complex::Complex<f64> = match &v74 {
                    Math::US0::US0_0(v74_0_0) => match &v74 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v80,
                };
                let v85: num_complex::Complex<f64> = v62 * v83;
                let v86: num_complex::Complex<f64> = Math::method7(v14.clone());
                let v89: f64 = 1.0_f64 - v86.re;
                let v90: num_complex::Complex<f64> = Math::method8(v14);
                let v93: f64 = -v90.im;
                let v95: num_complex::Complex<f64> = num_complex::Complex::new(v89, v93);
                let v98: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                    v0_1.clone(),
                    string("        s = mpmath.zeta(s)"),
                    Math::method3(v95.clone()),
                );
                let v99: num_complex::Complex<f64> = Math::method19(v0_1.clone(), v95);
                let v101: Option<num_complex::Complex<f64>> = v98.ok();
                let v104: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method25(), v101));
                let v106: f64 = f64::NAN;
                let v108: f64 = f64::NAN;
                let v110: num_complex::Complex<f64> = num_complex::Complex::new(v106, v108);
                let v113: num_complex::Complex<f64> = match &v104 {
                    Math::US0::US0_0(v104_0_0) => match &v104 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v110,
                };
                let v115: num_complex::Complex<f64> = v85 * v113;
                let v116: num_complex::Complex<f64> = Math::method7(v32.clone());
                let v118: f64 = v116.re;
                let v119: num_complex::Complex<f64> = Math::method7(v115.clone());
                let v122: f64 = v118 - v119.re;
                let v123: f64 = -v122;
                let v125: f64 = if v122 >= v123 { v122 } else { v123 };
                let v126: bool = v125 < 0.0001_f64;
                let v128: bool = if v126 { true } else { Math::method26(v126) };
                let v130: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("assert_lt"),
                    v125,
                    0.0001_f64
                );
                printfn!("{0}", v130.clone());
                if v128 == false {
                    panic!("{}", v130,);
                }
                {
                    let v132: num_complex::Complex<f64> = Math::method8(v32);
                    let v134: f64 = v132.im;
                    let v135: num_complex::Complex<f64> = Math::method8(v115);
                    let v138: f64 = v134 - v135.im;
                    let v139: f64 = -v138;
                    let v141: f64 = if v138 >= v139 { v138 } else { v139 };
                    let v142: bool = v141 < 0.0001_f64;
                    let v144: bool = if v142 { true } else { Math::method26(v142) };
                    let v145: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("assert_lt"),
                        v141,
                        0.0001_f64
                    );
                    printfn!("{0}", v145.clone());
                    if v144 == false {
                        panic!("{}", v145,);
                    }
                    {
                        let v147: i32 = v13 + 1_i32;
                        v11.l0.set(v147);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method49() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method50(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method27(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v9: Result<(), pyo3::PyErr> = __result;
                    v9.unwrap();
                    ()
                }
            }
        }
        pub fn method53(v0_1: i32, v1_1: LrcPtr<Math::Mut3>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method52(v0_1: pyo3::Python) {
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
                while Math::method53(v10, v11.clone()) {
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
                    let v30: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method25(), v27));
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
                    let v43: f64 = v40.re - v21;
                    let v44: f64 = -v43;
                    let v46: f64 = if v43 >= v44 { v43 } else { v44 };
                    let v47: bool = v46 < 0.01_f64;
                    let v49: bool = if v47 { true } else { Math::method26(v47) };
                    let v51: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("assert_lt"),
                        v46,
                        0.01_f64
                    );
                    printfn!("{0}", v51.clone());
                    if v49 == false {
                        panic!("{}", v51,);
                    }
                    {
                        let v53: num_complex::Complex<f64> = Math::method8(v39);
                        let v55: f64 = v53.im;
                        let v56: bool = v55 < 0.01_f64;
                        let v58: bool = if v56 { true } else { Math::method26(v56) };
                        let v59: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("assert_lt"),
                            v55,
                            0.01_f64
                        );
                        printfn!("{0}", v59.clone());
                        if v58 == false {
                            panic!("{}", v59,);
                        }
                        {
                            let v61: i32 = v6 + 1_i32;
                            v4.l0.set(v61);
                            ()
                        }
                    }
                }
            }
            ()
        }
        pub fn method51() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method52(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method27(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v9: Result<(), pyo3::PyErr> = __result;
                    v9.unwrap();
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
            Math::method28();
        } /* /*;
          {
              let v12: string =
                  string("*/ #[test] fn test_trivial_zero_at_negative_even___() { //");
              let v13: bool =
                  */
        #[test]
        fn test_trivial_zero_at_negative_even___() {
            //;
            Math::method30();
        } /* /*;
          {
              let v16: string =
                  string("*/ #[test] fn test_non_trivial_zero___() { //");
              let v17: bool =
                  */
        #[test]
        fn test_non_trivial_zero___() {
            //;
            Math::method34();
        } /* /*;
          {
              let v20: string =
                  string("*/ #[test] fn test_real_part_greater_than_one___() { //");
              let v21: bool =
                  */
        #[test]
        fn test_real_part_greater_than_one___() {
            //;
            Math::method36();
        } /* /*;
          {
              let v24: string =
                  string("*/ #[test] fn test_zeta_at_1___() { //");
              let v25: bool =
                  */
        #[test]
        fn test_zeta_at_1___() {
            //;
            Math::method38();
        } /* /*;
          {
              let v28: string =
                  string("*/ #[test] fn test_symmetry_across_real_axis___() { //");
              let v29: bool =
                  */
        #[test]
        fn test_symmetry_across_real_axis___() {
            //;
            Math::method40();
        } /* /*;
          {
              let v32: string =
                  string("*/ #[test] fn test_behavior_near_origin___() { //");
              let v33: bool =
                  */
        #[test]
        fn test_behavior_near_origin___() {
            //;
            Math::method42();
        } /* /*;
          {
              let v36: string =
                  string("*/ #[test] fn test_imaginary_axis() { //");
              let v37: bool =
                  */
        #[test]
        fn test_imaginary_axis() {
            //;
            Math::method44();
        } /* /*;
          {
              let v40: string =
                  string("*/ #[test] fn test_critical_strip() { //");
              let v41: bool =
                  */
        #[test]
        fn test_critical_strip() {
            //;
            Math::method47();
        } /* /*;
          {
              let v44: string =
                  string("*/ #[test] fn test_reflection_formula_for_specific_value() { //");
              let v45: bool =
                  */
        #[test]
        fn test_reflection_formula_for_specific_value() {
            //;
            Math::method49();
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
        pub fn closure6(unitVar: (), v0_1: Array<string>) -> i32 {
            let v1_1: string = sprintf!("value: {}", 1_i32);
            printfn!("{0}", v1_1);
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
            v1.get_or_init(|| Func1::new(move |v: Array<string>| Math::closure6((), v)))
                .clone()
        }
        pub fn main(args: Array<string>) -> i32 {
            (Math::v1())(args)
        }
    }
}
pub use module_b7a9935b::*;
#[path = "../../lib/fsharp/Common.rs"]
mod module_8cb3e09e;
pub use module_8cb3e09e::*;
#[path = "../../lib/spiral/async_.rs"]
mod module_62d8b4ed;
pub use module_62d8b4ed::*;
#[path = "../../lib/spiral/common.rs"]
mod module_e7e93d99;
pub use module_e7e93d99::*;
#[path = "../../lib/spiral/crypto.rs"]
mod module_981523f7;
pub use module_981523f7::*;
#[path = "../../lib/spiral/date_time.rs"]
mod module_d18105aa;
pub use module_d18105aa::*;
#[path = "../../lib/spiral/file_system.rs"]
mod module_c5eb79e8;
pub use module_c5eb79e8::*;
#[path = "../../lib/spiral/lib.rs"]
mod module_8d8b0653;
pub use module_8d8b0653::*;
#[path = "../../lib/spiral/networking.rs"]
mod module_2612ff6a;
pub use module_2612ff6a::*;
#[path = "../../lib/spiral/runtime.rs"]
mod module_3a43928;
pub use module_3a43928::*;
#[path = "../../lib/spiral/sm.rs"]
mod module_2aeb754a;
pub use module_2aeb754a::*;
#[path = "../../lib/spiral/threading.rs"]
mod module_444ab8da;
pub use module_444ab8da::*;
#[path = "../../lib/spiral/trace.rs"]
mod module_e61b6515;
pub use module_e61b6515::*;
pub mod Polyglot {
    pub use crate::module_8cb3e09e::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Math::main(array_from(args));
}
