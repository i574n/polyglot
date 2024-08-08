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
            format!("{}", v0_1)
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
            format!("{}", v0_1)
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
            format!("{}", v0_1)
        }
        pub fn method14() -> Func1<pyo3::PyErr, std::string::String> {
            Func1::new(move |v: pyo3::PyErr| Math::closure3((), v))
        }
        pub fn method15(v0_1: pyo3::Bound<pyo3::PyAny>) -> pyo3::Bound<pyo3::PyAny> {
            v0_1
        }
        pub fn closure4(unitVar: (), v0_1: pyo3::PyErr) -> std::string::String {
            format!("{}", v0_1)
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
                let _v42: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
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
                    _v42.set(x_2)
                }
                {
                    let v57: Math::US0 = defaultValue(Math::US0::US0_1, _v42.get().clone());
                    let v62: f64 = f64::NAN;
                    let v64: f64 = f64::NAN;
                    let v66: num_complex::Complex<f64> = num_complex::Complex::new(v62, v64);
                    let v69: num_complex::Complex<f64> = match &v57 {
                        Math::US0::US0_0(v57_0_0) => match &v57 {
                            Math::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v66,
                    };
                    let v71: num_complex::Complex<f64> =
                        num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                    let v73: num_complex::Complex<f64> = v71 * v1_1.clone();
                    let v75: num_complex::Complex<f64> =
                        num_complex::Complex::new(2.0_f64, 0.0_f64);
                    let v77: num_complex::Complex<f64> = v73 / v75;
                    let v79: num_complex::Complex<f64> = v77.sin();
                    let v82: f64 = 1.0_f64 - v1_1.clone().re;
                    let v85: f64 = -v1_1.clone().im;
                    let v87: num_complex::Complex<f64> = num_complex::Complex::new(v82, v85);
                    let v521: num_complex::Complex<f64> = if v87.clone().re <= 1.0_f64 {
                        num_complex::Complex::new(0.0_f64, 0.0_f64)
                    } else {
                        println!("zeta / count: {:?} / s: {:?}", 1_i32, v87.clone());
                        if v87.clone().re > 1.0_f64 {
                            let v98: num_complex::Complex<f64> =
                                num_complex::Complex::new(0.0_f64, 0.0_f64);
                            let v99: Array<i32> = new_init(&0_i32, 10000_i32);
                            let v100: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                l0: MutCell::new(0_i32),
                            });
                            while Math::method18(v100.clone()) {
                                let v102: i32 = v100.l0.get().clone();
                                v99.get_mut()[v102 as usize] = v102;
                                {
                                    let v103: i32 = v102 + 1_i32;
                                    v100.l0.set(v103);
                                    ()
                                }
                            }
                            {
                                let v104: i32 = count(v99.clone());
                                let v105: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                    l0: MutCell::new(0_i32),
                                    l1: MutCell::new(v98),
                                });
                                while Math::method19(v104, v105.clone()) {
                                    let v107: i32 = v105.l0.get().clone();
                                    let v108: num_complex::Complex<f64> = v105.l1.get().clone();
                                    let v109: i32 = v99[v107].clone();
                                    let v111: num_complex::Complex<f64> =
                                        num_complex::Complex::new(1.0_f64, 0.0_f64);
                                    let v113: f64 = v109 as f64;
                                    let v115: num_complex::Complex<f64> =
                                        num_complex::Complex::new(v113, 0.0_f64);
                                    let v117: num_complex::Complex<f64> =
                                        num_complex::Complex::powc(v115, v87.clone());
                                    let v119: num_complex::Complex<f64> = v111 / v117;
                                    let v121: num_complex::Complex<f64> = v108 + v119;
                                    let v122: i32 = v107 + 1_i32;
                                    v105.l0.set(v122);
                                    v105.l1.set(v121);
                                    ()
                                }
                                v105.l1.get().clone()
                            }
                        } else {
                            let v125: num_complex::Complex<f64> =
                                num_complex::Complex::new(1.0_f64, 0.0_f64);
                            let v130: Result<num_complex::Complex<f64>, std::string::String> =
                                Math::method20(
                                    v0_1.clone(),
                                    string("        s = mpmath.gamma(s)"),
                                    Math::method3(v125 - v87.clone()),
                                );
                            let v132: Option<num_complex::Complex<f64>> = v130.ok();
                            let _v133: LrcPtr<MutCell<Option<Math::US0>>> =
                                refCell(None::<Math::US0>);
                            {
                                let x_5: Option<Math::US0> = match &v132 {
                                    None => None::<Math::US0>,
                                    Some(v132_0_0) => {
                                        let x_3: num_complex::Complex<f64> = v132_0_0.clone();
                                        Some((Func0::new({
                                            let x_3 = x_3.clone();
                                            move || Math::US0::US0_0(x_3.clone())
                                        }))())
                                    }
                                };
                                _v133.set(x_5)
                            }
                            {
                                let v148: Math::US0 =
                                    defaultValue(Math::US0::US0_1, _v133.get().clone());
                                let v153: f64 = f64::NAN;
                                let v155: f64 = f64::NAN;
                                let v157: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v153, v155);
                                let v160: num_complex::Complex<f64> = match &v148 {
                                    Math::US0::US0_0(v148_0_0) => match &v148 {
                                        Math::US0::US0_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => v157,
                                };
                                let v162: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v164: num_complex::Complex<f64> = v162 * v87.clone();
                                let v166: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v168: num_complex::Complex<f64> = v164 / v166;
                                let v170: num_complex::Complex<f64> = v168.sin();
                                let v173: f64 = 1.0_f64 - v87.clone().re;
                                let v176: f64 = -v87.clone().im;
                                let v178: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v173, v176);
                                let v505: num_complex::Complex<f64> = if v178.clone().re <= 1.0_f64
                                {
                                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                                } else {
                                    println!("zeta / count: {:?} / s: {:?}", 2_i32, v178.clone());
                                    if v178.clone().re > 1.0_f64 {
                                        let v189: num_complex::Complex<f64> =
                                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                                        let v190: Array<i32> = new_init(&0_i32, 10000_i32);
                                        let v191: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                            l0: MutCell::new(0_i32),
                                        });
                                        while Math::method18(v191.clone()) {
                                            let v193: i32 = v191.l0.get().clone();
                                            v190.get_mut()[v193 as usize] = v193;
                                            {
                                                let v194: i32 = v193 + 1_i32;
                                                v191.l0.set(v194);
                                                ()
                                            }
                                        }
                                        {
                                            let v195: i32 = count(v190.clone());
                                            let v196: LrcPtr<Math::Mut2> =
                                                LrcPtr::new(Math::Mut2 {
                                                    l0: MutCell::new(0_i32),
                                                    l1: MutCell::new(v189),
                                                });
                                            while Math::method19(v195, v196.clone()) {
                                                let v198: i32 = v196.l0.get().clone();
                                                let v199: num_complex::Complex<f64> =
                                                    v196.l1.get().clone();
                                                let v200: i32 = v190[v198].clone();
                                                let v202: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v204: f64 = v200 as f64;
                                                let v206: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v204, 0.0_f64);
                                                let v208: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v206, v178.clone());
                                                let v210: num_complex::Complex<f64> = v202 / v208;
                                                let v212: num_complex::Complex<f64> = v199 + v210;
                                                let v213: i32 = v198 + 1_i32;
                                                v196.l0.set(v213);
                                                v196.l1.set(v212);
                                                ()
                                            }
                                            v196.l1.get().clone()
                                        }
                                    } else {
                                        let v216: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v221: Result<
                                            num_complex::Complex<f64>,
                                            std::string::String,
                                        > = Math::method20(
                                            v0_1.clone(),
                                            string("        s = mpmath.gamma(s)"),
                                            Math::method3(v216 - v178.clone()),
                                        );
                                        let v223: Option<num_complex::Complex<f64>> = v221.ok();
                                        let _v224: LrcPtr<MutCell<Option<Math::US0>>> =
                                            refCell(None::<Math::US0>);
                                        {
                                            let x_8: Option<Math::US0> = match &v223 {
                                                None => None::<Math::US0>,
                                                Some(v223_0_0) => {
                                                    let x_6: num_complex::Complex<f64> =
                                                        v223_0_0.clone();
                                                    Some((Func0::new({
                                                        let x_6 = x_6.clone();
                                                        move || Math::US0::US0_0(x_6.clone())
                                                    }))(
                                                    ))
                                                }
                                            };
                                            _v224.set(x_8)
                                        }
                                        {
                                            let v239: Math::US0 =
                                                defaultValue(Math::US0::US0_1, _v224.get().clone());
                                            let v244: f64 = f64::NAN;
                                            let v246: f64 = f64::NAN;
                                            let v248: num_complex::Complex<f64> =
                                                num_complex::Complex::new(v244, v246);
                                            let v251: num_complex::Complex<f64> = match &v239 {
                                                Math::US0::US0_0(v239_0_0) => match &v239 {
                                                    Math::US0::US0_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                },
                                                _ => v248,
                                            };
                                            let v253: num_complex::Complex<f64> =
                                                num_complex::Complex::new(
                                                    3.141592653589793_f64,
                                                    0.0_f64,
                                                );
                                            let v255: num_complex::Complex<f64> =
                                                v253 * v178.clone();
                                            let v257: num_complex::Complex<f64> =
                                                num_complex::Complex::new(2.0_f64, 0.0_f64);
                                            let v259: num_complex::Complex<f64> = v255 / v257;
                                            let v261: num_complex::Complex<f64> = v259.sin();
                                            let v264: f64 = 1.0_f64 - v178.clone().re;
                                            let v267: f64 = -v178.clone().im;
                                            let v269: num_complex::Complex<f64> =
                                                num_complex::Complex::new(v264, v267);
                                            let v489: num_complex::Complex<f64> = if v269.clone().re
                                                <= 1.0_f64
                                            {
                                                num_complex::Complex::new(0.0_f64, 0.0_f64)
                                            } else {
                                                println!(
                                                    "zeta / count: {:?} / s: {:?}",
                                                    3_i32,
                                                    v269.clone()
                                                );
                                                if v269.clone().re > 1.0_f64 {
                                                    let v280: num_complex::Complex<f64> =
                                                        num_complex::Complex::new(0.0_f64, 0.0_f64);
                                                    let v281: Array<i32> =
                                                        new_init(&0_i32, 10000_i32);
                                                    let v282: LrcPtr<Math::Mut0> =
                                                        LrcPtr::new(Math::Mut0 {
                                                            l0: MutCell::new(0_i32),
                                                        });
                                                    while Math::method18(v282.clone()) {
                                                        let v284: i32 = v282.l0.get().clone();
                                                        v281.get_mut()[v284 as usize] = v284;
                                                        {
                                                            let v285: i32 = v284 + 1_i32;
                                                            v282.l0.set(v285);
                                                            ()
                                                        }
                                                    }
                                                    {
                                                        let v286: i32 = count(v281.clone());
                                                        let v287: LrcPtr<Math::Mut2> =
                                                            LrcPtr::new(Math::Mut2 {
                                                                l0: MutCell::new(0_i32),
                                                                l1: MutCell::new(v280),
                                                            });
                                                        while Math::method19(v286, v287.clone()) {
                                                            let v289: i32 = v287.l0.get().clone();
                                                            let v290: num_complex::Complex<f64> =
                                                                v287.l1.get().clone();
                                                            let v291: i32 = v281[v289].clone();
                                                            let v293: num_complex::Complex<f64> =
                                                                num_complex::Complex::new(
                                                                    1.0_f64, 0.0_f64,
                                                                );
                                                            let v295: f64 = v291 as f64;
                                                            let v297: num_complex::Complex<f64> =
                                                                num_complex::Complex::new(
                                                                    v295, 0.0_f64,
                                                                );
                                                            let v299: num_complex::Complex<f64> =
                                                                num_complex::Complex::powc(
                                                                    v297,
                                                                    v269.clone(),
                                                                );
                                                            let v301: num_complex::Complex<f64> =
                                                                v293 / v299;
                                                            let v303: num_complex::Complex<f64> =
                                                                v290 + v301;
                                                            let v304: i32 = v289 + 1_i32;
                                                            v287.l0.set(v304);
                                                            v287.l1.set(v303);
                                                            ()
                                                        }
                                                        v287.l1.get().clone()
                                                    }
                                                } else {
                                                    let v307: num_complex::Complex<f64> =
                                                        num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                    let v312: Result<
                                                        num_complex::Complex<f64>,
                                                        std::string::String,
                                                    > = Math::method20(
                                                        v0_1.clone(),
                                                        string("        s = mpmath.gamma(s)"),
                                                        Math::method3(v307 - v269.clone()),
                                                    );
                                                    let v314: Option<num_complex::Complex<f64>> =
                                                        v312.ok();
                                                    let _v315: LrcPtr<MutCell<Option<Math::US0>>> =
                                                        refCell(None::<Math::US0>);
                                                    {
                                                        let x_11: Option<Math::US0> = match &v314 {
                                                            None => None::<Math::US0>,
                                                            Some(v314_0_0) => {
                                                                let x_9: num_complex::Complex<f64> =
                                                                    v314_0_0.clone();
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
                                                        _v315.set(x_11)
                                                    }
                                                    {
                                                        let v330: Math::US0 = defaultValue(
                                                            Math::US0::US0_1,
                                                            _v315.get().clone(),
                                                        );
                                                        let v335: f64 = f64::NAN;
                                                        let v337: f64 = f64::NAN;
                                                        let v339: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(v335, v337);
                                                        let v342: num_complex::Complex<f64> =
                                                            match &v330 {
                                                                Math::US0::US0_0(v330_0_0) => {
                                                                    match &v330 {
                                                                        Math::US0::US0_0(x) => {
                                                                            x.clone()
                                                                        }
                                                                        _ => unreachable!(),
                                                                    }
                                                                }
                                                                _ => v339,
                                                            };
                                                        let v344: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                3.141592653589793_f64,
                                                                0.0_f64,
                                                            );
                                                        let v346: num_complex::Complex<f64> =
                                                            v344 * v269.clone();
                                                        let v348: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                2.0_f64, 0.0_f64,
                                                            );
                                                        let v350: num_complex::Complex<f64> =
                                                            v346 / v348;
                                                        let v352: num_complex::Complex<f64> =
                                                            v350.sin();
                                                        let v355: f64 = 1.0_f64 - v269.clone().re;
                                                        let v358: f64 = -v269.clone().im;
                                                        let v360: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(v355, v358);
                                                        let v473: num_complex::Complex<f64> =
                                                            if v360.clone().re <= 1.0_f64 {
                                                                num_complex::Complex::new(
                                                                    0.0_f64, 0.0_f64,
                                                                )
                                                            } else {
                                                                println!(
                                                                    "zeta / count: {:?} / s: {:?}",
                                                                    4_i32,
                                                                    v360.clone()
                                                                );
                                                                if v360.clone().re > 1.0_f64 {
                                                                    let v371: num_complex::Complex<
                                                                        f64,
                                                                    > = num_complex::Complex::new(
                                                                        0.0_f64, 0.0_f64,
                                                                    );
                                                                    let v372: Array<i32> =
                                                                        new_init(&0_i32, 10000_i32);
                                                                    let v373: LrcPtr<Math::Mut0> =
                                                                        LrcPtr::new(Math::Mut0 {
                                                                            l0: MutCell::new(0_i32),
                                                                        });
                                                                    while Math::method18(
                                                                        v373.clone(),
                                                                    ) {
                                                                        let v375: i32 =
                                                                            v373.l0.get().clone();
                                                                        v372.get_mut()
                                                                            [v375 as usize] = v375;
                                                                        {
                                                                            let v376: i32 =
                                                                                v375 + 1_i32;
                                                                            v373.l0.set(v376);
                                                                            ()
                                                                        }
                                                                    }
                                                                    {
                                                                        let v377: i32 =
                                                                            count(v372.clone());
                                                                        let v378: LrcPtr<
                                                                            Math::Mut2,
                                                                        > = LrcPtr::new(
                                                                            Math::Mut2 {
                                                                                l0: MutCell::new(
                                                                                    0_i32,
                                                                                ),
                                                                                l1: MutCell::new(
                                                                                    v371,
                                                                                ),
                                                                            },
                                                                        );
                                                                        while Math::method19(
                                                                            v377,
                                                                            v378.clone(),
                                                                        ) {
                                                                            let v380: i32 = v378
                                                                                .l0
                                                                                .get()
                                                                                .clone();
                                                                            let v381:
                                                                                                num_complex::Complex<f64> =
                                                                                            v378.l1.get().clone();
                                                                            let v382: i32 =
                                                                                v372[v380].clone();
                                                                            let v384:
                                                                                                num_complex::Complex<f64> =
                                                                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                                            let v386: f64 =
                                                                                v382 as f64;
                                                                            let v388:
                                                                                                num_complex::Complex<f64> =
                                                                                            num_complex::Complex::new(v386, 0.0_f64);
                                                                            let v390:
                                                                                                num_complex::Complex<f64> =
                                                                                            num_complex::Complex::powc(v388, v360.clone());
                                                                            let v392:
                                                                                                num_complex::Complex<f64> =
                                                                                            v384 / v390;
                                                                            let v394:
                                                                                                num_complex::Complex<f64> =
                                                                                            v381 + v392;
                                                                            let v395: i32 =
                                                                                v380 + 1_i32;
                                                                            v378.l0.set(v395);
                                                                            v378.l1.set(v394);
                                                                            ()
                                                                        }
                                                                        v378.l1.get().clone()
                                                                    }
                                                                } else {
                                                                    let v398: num_complex::Complex<
                                                                        f64,
                                                                    > = num_complex::Complex::new(
                                                                        1.0_f64, 0.0_f64,
                                                                    );
                                                                    let v403:
                                                                                        Result<num_complex::Complex<f64>,
                                                                                               std::string::String> =
                                                                                    Math::method20(v0_1,
                                                                                                   string("        s = mpmath.gamma(s)"),
                                                                                                   Math::method3(v398 - v360.clone()));
                                                                    let v405: Option<
                                                                        num_complex::Complex<f64>,
                                                                    > = v403.ok();
                                                                    let _v406: LrcPtr<
                                                                        MutCell<Option<Math::US0>>,
                                                                    > = refCell(None::<Math::US0>);
                                                                    {
                                                                        let x_14: Option<
                                                                            Math::US0,
                                                                        > = match &v405 {
                                                                            None => {
                                                                                None::<Math::US0>
                                                                            }
                                                                            Some(v405_0_0) => {
                                                                                let x_12:
                                                                                                        num_complex::Complex<f64> =
                                                                                                    v405_0_0.clone();
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
                                                                        _v406.set(x_14)
                                                                    }
                                                                    {
                                                                        let v421: Math::US0 =
                                                                            defaultValue(
                                                                                Math::US0::US0_1,
                                                                                _v406.get().clone(),
                                                                            );
                                                                        let v426: f64 = f64::NAN;
                                                                        let v428: f64 = f64::NAN;
                                                                        let v430:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(v426, v428);
                                                                        let v433:
                                                                                            num_complex::Complex<f64> =
                                                                                        match &v421
                                                                                            {
                                                                                            Math::US0::US0_0(v421_0_0)
                                                                                            =>
                                                                                            match &v421
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
                                                                                            v430,
                                                                                        };
                                                                        let v435:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                                                        let v437:
                                                                                            num_complex::Complex<f64> =
                                                                                        v435 * v360.clone();
                                                                        let v439:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                                        let v441:
                                                                                            num_complex::Complex<f64> =
                                                                                        v437 / v439;
                                                                        let v443:
                                                                                            num_complex::Complex<f64> =
                                                                                        v441.sin();
                                                                        let v446: f64 = 1.0_f64
                                                                            - v360.clone().re;
                                                                        let v449: f64 =
                                                                            -v360.clone().im;
                                                                        let v451:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(v446, v449);
                                                                        let v457:
                                                                                            num_complex::Complex<f64> =
                                                                                        if v451.clone().re
                                                                                               <=
                                                                                               1.0_f64
                                                                                           {
                                                                                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                                                                                        } else {
                                                                                            v451
                                                                                        };
                                                                        let v459:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                                        let v461:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                                                        let v463:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::powc(v461, v360.clone());
                                                                        let v465:
                                                                                            num_complex::Complex<f64> =
                                                                                        v459 * v463;
                                                                        let v467:
                                                                                            num_complex::Complex<f64> =
                                                                                        v465 * v443;
                                                                        let v469:
                                                                                            num_complex::Complex<f64> =
                                                                                        v467 * v433;
                                                                        v469 * v457
                                                                    }
                                                                }
                                                            };
                                                        let v475: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                2.0_f64, 0.0_f64,
                                                            );
                                                        let v477: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                3.141592653589793_f64,
                                                                0.0_f64,
                                                            );
                                                        let v479: num_complex::Complex<f64> =
                                                            num_complex::Complex::powc(
                                                                v477,
                                                                v269.clone(),
                                                            );
                                                        let v481: num_complex::Complex<f64> =
                                                            v475 * v479;
                                                        let v483: num_complex::Complex<f64> =
                                                            v481 * v352;
                                                        let v485: num_complex::Complex<f64> =
                                                            v483 * v342;
                                                        v485 * v473
                                                    }
                                                }
                                            };
                                            let v491: num_complex::Complex<f64> =
                                                num_complex::Complex::new(2.0_f64, 0.0_f64);
                                            let v493: num_complex::Complex<f64> =
                                                num_complex::Complex::new(
                                                    3.141592653589793_f64,
                                                    0.0_f64,
                                                );
                                            let v495: num_complex::Complex<f64> =
                                                num_complex::Complex::powc(v493, v178.clone());
                                            let v497: num_complex::Complex<f64> = v491 * v495;
                                            let v499: num_complex::Complex<f64> = v497 * v261;
                                            let v501: num_complex::Complex<f64> = v499 * v251;
                                            v501 * v489
                                        }
                                    }
                                };
                                let v507: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v509: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v511: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v509, v87.clone());
                                let v513: num_complex::Complex<f64> = v507 * v511;
                                let v515: num_complex::Complex<f64> = v513 * v170;
                                let v517: num_complex::Complex<f64> = v515 * v160;
                                v517 * v505
                            }
                        }
                    };
                    let v523: num_complex::Complex<f64> =
                        num_complex::Complex::new(2.0_f64, 0.0_f64);
                    let v525: num_complex::Complex<f64> =
                        num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                    let v527: num_complex::Complex<f64> =
                        num_complex::Complex::powc(v525, v1_1.clone());
                    let v529: num_complex::Complex<f64> = v523 * v527;
                    let v531: num_complex::Complex<f64> = v529 * v79;
                    let v533: num_complex::Complex<f64> = v531 * v69;
                    v533 * v521
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
                    let v33: Math::US0 = defaultValue(Math::US0::US0_1, _v18.get().clone());
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
                    let v47: f64 = v45.clone().im;
                    let v48: bool = v47 == 0.0_f64;
                    let v50: bool = if v48 { true } else { Math::method21(v48) };
                    let v52: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_eq"),
                        v47,
                        0.0_f64
                    );
                    printfn!("{0}", v52.clone());
                    if v50 == false {
                        panic!("{}", v52,);
                    }
                    {
                        let v58: f64 = v45.re - patternInput.1.clone();
                        let v59: f64 = -v58;
                        let v61: f64 = if v58 >= v59 { v58 } else { v59 };
                        let v62: bool = v61 < 0.0001_f64;
                        let v64: bool = if v62 { true } else { Math::method21(v62) };
                        let v66: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_lt"),
                            v61,
                            0.0001_f64
                        );
                        printfn!("{0}", v66.clone());
                        if v64 == false {
                            panic!("{}", v66,);
                        }
                        {
                            let v70: i32 = v9 + 1_i32;
                            v7.l0.set(v70);
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
                    let v12: string = string("v5 }}); { // rust.fix_closure\'");
                    v5
                }
            });
            {
                // rust.fix_closure';
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
                let v24: Math::US0 = defaultValue(Math::US0::US0_1, _v9.get().clone());
                let v29: f64 = f64::NAN;
                let v31: f64 = f64::NAN;
                let v33: num_complex::Complex<f64> = num_complex::Complex::new(v29, v31);
                let v36: num_complex::Complex<f64> = match &v24 {
                    Math::US0::US0_0(v24_0_0) => match &v24 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v33,
                };
                let v39: f64 = v36.clone().re - 0.8673_f64;
                let v40: f64 = -v39;
                let v42: f64 = if v39 >= v40 { v39 } else { v40 };
                let v43: bool = v42 < 0.001_f64;
                let v45: bool = if v43 { true } else { Math::method21(v43) };
                let v47: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_lt"),
                    v42,
                    0.001_f64
                );
                printfn!("{0}", v47.clone());
                if v45 == false {
                    panic!("{}", v47,);
                }
                {
                    let v53: f64 = v36.im - 0.275_f64;
                    let v54: f64 = -v53;
                    let v56: f64 = if v53 >= v54 { v53 } else { v54 };
                    let v57: bool = v56 < 0.001_f64;
                    let v59: bool = if v57 { true } else { Math::method21(v57) };
                    let v60: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_lt"),
                        v56,
                        0.001_f64
                    );
                    printfn!("{0}", v60.clone());
                    if v59 == false {
                        panic!("{}", v60,);
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
                    let v12: string = string("v5 }}); { // rust.fix_closure\'");
                    v5
                }
            });
            {
                // rust.fix_closure';
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
                            let v27: Math::US0 = defaultValue(Math::US0::US0_1, _v12.get().clone());
                            let v32: f64 = f64::NAN;
                            let v34: f64 = f64::NAN;
                            let v36: num_complex::Complex<f64> =
                                num_complex::Complex::new(v32, v34);
                            let v39: num_complex::Complex<f64> = match &v27 {
                                Math::US0::US0_0(v27_0_0) => match &v27 {
                                    Math::US0::US0_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => v36,
                            };
                            let v41: f64 = v39.clone().re;
                            let v42: bool = v41 == 0.0_f64;
                            let v44: bool = if v42 { true } else { Math::method21(v42) };
                            let v46: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_eq"),
                                v41,
                                0.0_f64
                            );
                            printfn!("{0}", v46.clone());
                            if v44 == false {
                                panic!("{}", v46,);
                            }
                            {
                                let v51: f64 = v39.im;
                                let v52: bool = v51 == 0.0_f64;
                                let v54: bool = if v52 { true } else { Math::method21(v52) };
                                let v55: string = sprintf!(
                                    "{} / actual: {:?} / expected: {:?}",
                                    string("__assert_eq"),
                                    v51,
                                    0.0_f64
                                );
                                printfn!("{0}", v55.clone());
                                if v54 == false {
                                    panic!("{}", v55,);
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
                    let v12: string = string("v5 }}); { // rust.fix_closure\'");
                    v5
                }
            });
            {
                // rust.fix_closure';
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
                    let v40: Math::US0 = defaultValue(Math::US0::US0_1, _v25.get().clone());
                    let v45: f64 = f64::NAN;
                    let v47: f64 = f64::NAN;
                    let v49: num_complex::Complex<f64> = num_complex::Complex::new(v45, v47);
                    let v52: num_complex::Complex<f64> = match &v40 {
                        Math::US0::US0_0(v40_0_0) => match &v40 {
                            Math::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v49,
                    };
                    let v54: f64 = v52.clone().re;
                    let v55: f64 = -v54;
                    let v57: f64 = if v54 >= v55 { v54 } else { v55 };
                    let v58: bool = v57 < 0.0001_f64;
                    let v60: bool = if v58 { true } else { Math::method21(v58) };
                    let v62: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_lt"),
                        v57,
                        0.0001_f64
                    );
                    printfn!("{0}", v62.clone());
                    if v60 == false {
                        panic!("{}", v62,);
                    }
                    {
                        let v67: f64 = v52.im;
                        let v68: f64 = -v67;
                        let v70: f64 = if v67 >= v68 { v67 } else { v68 };
                        let v71: bool = v70 < 0.0001_f64;
                        let v73: bool = if v71 { true } else { Math::method21(v71) };
                        let v74: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_lt"),
                            v70,
                            0.0001_f64
                        );
                        printfn!("{0}", v74.clone());
                        if v73 == false {
                            panic!("{}", v74,);
                        }
                        {
                            let v78: i32 = v17 + 1_i32;
                            v15.l0.set(v78);
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
                    let v12: string = string("v5 }}); { // rust.fix_closure\'");
                    v5
                }
            });
            {
                // rust.fix_closure';
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
                    let v30: Math::US0 = defaultValue(Math::US0::US0_1, _v15.get().clone());
                    let v35: f64 = f64::NAN;
                    let v37: f64 = f64::NAN;
                    let v39: num_complex::Complex<f64> = num_complex::Complex::new(v35, v37);
                    let v42: num_complex::Complex<f64> = match &v30 {
                        Math::US0::US0_0(v30_0_0) => match &v30 {
                            Math::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v39,
                    };
                    let v44: f64 = v42.clone().re;
                    let v45: bool = v44 > 0.0_f64;
                    let v47: bool = if v45 { true } else { Math::method21(v45) };
                    let v49: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_gt"),
                        v44,
                        0.0_f64
                    );
                    printfn!("{0}", v49.clone());
                    if v47 == false {
                        panic!("{}", v49,);
                    }
                    {
                        let v54: f64 = v42.im;
                        let v55: bool = v54 == 0.0_f64;
                        let v57: bool = if v55 { true } else { Math::method21(v55) };
                        let v59: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_eq"),
                            v54,
                            0.0_f64
                        );
                        printfn!("{0}", v59.clone());
                        if v57 == false {
                            panic!("{}", v59,);
                        }
                        {
                            let v63: i32 = v5 + 1_i32;
                            v3.l0.set(v63);
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
                    let v12: string = string("v5 }}); { // rust.fix_closure\'");
                    v5
                }
            });
            {
                // rust.fix_closure';
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
                let v24: Math::US0 = defaultValue(Math::US0::US0_1, _v9.get().clone());
                let v29: f64 = f64::NAN;
                let v31: f64 = f64::NAN;
                let v33: num_complex::Complex<f64> = num_complex::Complex::new(v29, v31);
                let v36: num_complex::Complex<f64> = match &v24 {
                    Math::US0::US0_0(v24_0_0) => match &v24 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v33,
                };
                let v38: f64 = v36.clone().re;
                let v39: bool = v38 == f64::INFINITY;
                let v41: bool = if v39 { true } else { Math::method21(v39) };
                let v43: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_eq"),
                    v38,
                    f64::INFINITY
                );
                printfn!("{0}", v43.clone());
                if v41 == false {
                    panic!("{}", v43,);
                }
                {
                    let v48: f64 = v36.im;
                    let v49: bool = v48 == 0.0_f64;
                    let v51: bool = if v49 { true } else { Math::method21(v49) };
                    let v52: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_eq"),
                        v48,
                        0.0_f64
                    );
                    printfn!("{0}", v52.clone());
                    if v51 == false {
                        panic!("{}", v52,);
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
                    let v12: string = string("v5 }}); { // rust.fix_closure\'");
                    v5
                }
            });
            {
                // rust.fix_closure';
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
                let v24: Math::US0 = defaultValue(Math::US0::US0_1, _v9.get().clone());
                let v29: f64 = f64::NAN;
                let v31: f64 = f64::NAN;
                let v33: num_complex::Complex<f64> = num_complex::Complex::new(v29, v31);
                let v36: num_complex::Complex<f64> = match &v24 {
                    Math::US0::US0_0(v24_0_0) => match &v24 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v33,
                };
                let v38: f64 = v2.clone().re;
                let v41: f64 = -v2.im;
                let v43: num_complex::Complex<f64> = num_complex::Complex::new(v38, v41);
                let v46: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                    v0_1.clone(),
                    string("        s = mpmath.zeta(s)"),
                    Math::method3(v43.clone()),
                );
                let v47: num_complex::Complex<f64> = Math::method17(v0_1, v43);
                let v49: Option<num_complex::Complex<f64>> = v46.ok();
                let _v50: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
                {
                    let x_5: Option<Math::US0> = match &v49 {
                        None => None::<Math::US0>,
                        Some(v49_0_0) => {
                            let x_3: num_complex::Complex<f64> = v49_0_0.clone();
                            Some((Func0::new({
                                let x_3 = x_3.clone();
                                move || Math::US0::US0_0(x_3.clone())
                            }))())
                        }
                    };
                    _v50.set(x_5)
                }
                {
                    let v65: Math::US0 = defaultValue(Math::US0::US0_1, _v50.get().clone());
                    let v70: f64 = f64::NAN;
                    let v72: f64 = f64::NAN;
                    let v74: num_complex::Complex<f64> = num_complex::Complex::new(v70, v72);
                    let v77: num_complex::Complex<f64> = match &v65 {
                        Math::US0::US0_0(v65_0_0) => match &v65 {
                            Math::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v74,
                    };
                    let v79: num_complex::Complex<f64> = v77.conj();
                    let v81: f64 = v36.clone().re;
                    let v83: f64 = v79.clone().re;
                    let v84: bool = v81 == v83;
                    let v86: bool = if v84 { true } else { Math::method21(v84) };
                    let v88: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_eq"),
                        v81,
                        v83
                    );
                    printfn!("{0}", v88.clone());
                    if v86 == false {
                        panic!("{}", v88,);
                    }
                    {
                        let v93: f64 = v36.im;
                        let v95: f64 = v79.im;
                        let v96: bool = v93 == v95;
                        let v98: bool = if v96 { true } else { Math::method21(v96) };
                        let v99: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_eq"),
                            v93,
                            v95
                        );
                        printfn!("{0}", v99.clone());
                        if v98 == false {
                            panic!("{}", v99,);
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
                    let v12: string = string("v5 }}); { // rust.fix_closure\'");
                    v5
                }
            });
            {
                // rust.fix_closure';
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
                let v24: Math::US0 = defaultValue(Math::US0::US0_1, _v9.get().clone());
                let v29: f64 = f64::NAN;
                let v31: f64 = f64::NAN;
                let v33: num_complex::Complex<f64> = num_complex::Complex::new(v29, v31);
                let v36: num_complex::Complex<f64> = match &v24 {
                    Math::US0::US0_0(v24_0_0) => match &v24 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v33,
                };
                let v38: f64 = v36.clone().re;
                let v39: bool = v38 < f64::INFINITY;
                let v41: bool = if v39 { true } else { Math::method21(v39) };
                let v43: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_lt"),
                    v38,
                    f64::INFINITY
                );
                printfn!("{0}", v43.clone());
                if v41 == false {
                    panic!("{}", v43,);
                }
                {
                    let v48: f64 = v36.im;
                    let v49: bool = v48 < f64::INFINITY;
                    let v51: bool = if v49 { true } else { Math::method21(v49) };
                    let v52: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_lt"),
                        v48,
                        f64::INFINITY
                    );
                    printfn!("{0}", v52.clone());
                    if v51 == false {
                        panic!("{}", v52,);
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
                    let v12: string = string("v5 }}); { // rust.fix_closure\'");
                    v5
                }
            });
            {
                // rust.fix_closure';
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
                            let v27: Math::US0 = defaultValue(Math::US0::US0_1, _v12.get().clone());
                            let v32: f64 = f64::NAN;
                            let v34: f64 = f64::NAN;
                            let v36: num_complex::Complex<f64> =
                                num_complex::Complex::new(v32, v34);
                            let v39: num_complex::Complex<f64> = match &v27 {
                                Math::US0::US0_0(v27_0_0) => match &v27 {
                                    Math::US0::US0_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => v36,
                            };
                            let v41: f64 = v39.clone().re;
                            let v42: bool = v41 != 0.0_f64;
                            let v46: bool = if v42 { true } else { Math::method21(v42) };
                            let v48: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_ne"),
                                v41,
                                0.0_f64
                            );
                            printfn!("{0}", v48.clone());
                            if v46 == false {
                                panic!("{}", v48,);
                            }
                            {
                                let v53: f64 = v39.im;
                                let v54: bool = v53 != 0.0_f64;
                                let v58: bool = if v54 { true } else { Math::method21(v54) };
                                let v59: string = sprintf!(
                                    "{} / actual: {:?} / expected: {:?}",
                                    string("__assert_ne"),
                                    v53,
                                    0.0_f64
                                );
                                printfn!("{0}", v59.clone());
                                if v58 == false {
                                    panic!("{}", v59,);
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
                    let v12: string = string("v5 }}); { // rust.fix_closure\'");
                    v5
                }
            });
            {
                // rust.fix_closure';
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
                        let _v10: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
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
                            _v10.set(x_2)
                        }
                        {
                            let v25: Math::US0 = defaultValue(Math::US0::US0_1, _v10.get().clone());
                            let v30: f64 = f64::NAN;
                            let v32: f64 = f64::NAN;
                            let v34: num_complex::Complex<f64> =
                                num_complex::Complex::new(v30, v32);
                            let v37: num_complex::Complex<f64> = match &v25 {
                                Math::US0::US0_0(v25_0_0) => match &v25 {
                                    Math::US0::US0_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => v34,
                            };
                            let v39: f64 = v37.clone().re;
                            let v40: bool = v39 != 0.0_f64;
                            let v44: bool = if v40 { true } else { Math::method21(v40) };
                            let v46: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_ne"),
                                v39,
                                0.0_f64
                            );
                            printfn!("{0}", v46.clone());
                            if v44 == false {
                                panic!("{}", v46,);
                            }
                            {
                                let v51: f64 = v37.im;
                                let v52: bool = v51 != 0.0_f64;
                                let v56: bool = if v52 { true } else { Math::method21(v52) };
                                let v57: string = sprintf!(
                                    "{} / actual: {:?} / expected: {:?}",
                                    string("__assert_ne"),
                                    v51,
                                    0.0_f64
                                );
                                printfn!("{0}", v57.clone());
                                if v56 == false {
                                    panic!("{}", v57,);
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
                    let v12: string = string("v5 }}); { // rust.fix_closure\'");
                    v5
                }
            });
            {
                // rust.fix_closure';
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
                        let _v10: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
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
                            _v10.set(x_2)
                        }
                        {
                            let v25: Math::US0 = defaultValue(Math::US0::US0_1, _v10.get().clone());
                            let v30: f64 = f64::NAN;
                            let v32: f64 = f64::NAN;
                            let v34: num_complex::Complex<f64> =
                                num_complex::Complex::new(v30, v32);
                            let v37: num_complex::Complex<f64> = match &v25 {
                                Math::US0::US0_0(v25_0_0) => match &v25 {
                                    Math::US0::US0_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => v34,
                            };
                            let v39: num_complex::Complex<f64> =
                                num_complex::Complex::new(2.0_f64, 0.0_f64);
                            let v41: num_complex::Complex<f64> =
                                num_complex::Complex::powc(v39, v2.clone());
                            let v43: num_complex::Complex<f64> =
                                num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                            let v45: num_complex::Complex<f64> =
                                num_complex::Complex::new(1.0_f64, 0.0_f64);
                            let v47: num_complex::Complex<f64> = v2.clone() - v45;
                            let v49: num_complex::Complex<f64> =
                                num_complex::Complex::powc(v43, v47);
                            let v51: num_complex::Complex<f64> = v41 * v49;
                            let v53: num_complex::Complex<f64> =
                                num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                            let v55: num_complex::Complex<f64> = v53 * v2.clone();
                            let v57: num_complex::Complex<f64> =
                                num_complex::Complex::new(2.0_f64, 0.0_f64);
                            let v59: num_complex::Complex<f64> = v55 / v57;
                            let v61: num_complex::Complex<f64> = v59.sin();
                            let v63: num_complex::Complex<f64> = v51 * v61;
                            let v65: num_complex::Complex<f64> =
                                num_complex::Complex::new(1.0_f64, 0.0_f64);
                            let v70: Result<num_complex::Complex<f64>, std::string::String> =
                                Math::method20(
                                    v0_1.get().clone(),
                                    string("        s = mpmath.gamma(s)"),
                                    Math::method3(v65 - v2.clone()),
                                );
                            let v72: Option<num_complex::Complex<f64>> = v70.ok();
                            let _v73: LrcPtr<MutCell<Option<Math::US0>>> =
                                refCell(None::<Math::US0>);
                            {
                                let x_5: Option<Math::US0> = match &v72 {
                                    None => None::<Math::US0>,
                                    Some(v72_0_0) => {
                                        let x_3: num_complex::Complex<f64> = v72_0_0.clone();
                                        Some((Func0::new({
                                            let x_3 = x_3.clone();
                                            move || Math::US0::US0_0(x_3.clone())
                                        }))())
                                    }
                                };
                                _v73.set(x_5)
                            }
                            {
                                let v88: Math::US0 =
                                    defaultValue(Math::US0::US0_1, _v73.get().clone());
                                let v93: f64 = f64::NAN;
                                let v95: f64 = f64::NAN;
                                let v97: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v93, v95);
                                let v100: num_complex::Complex<f64> = match &v88 {
                                    Math::US0::US0_0(v88_0_0) => match &v88 {
                                        Math::US0::US0_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => v97,
                                };
                                let v102: num_complex::Complex<f64> = v63 * v100;
                                let v105: f64 = 1.0_f64 - v2.clone().re;
                                let v108: f64 = -v2.im;
                                let v110: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v105, v108);
                                let v113: Result<num_complex::Complex<f64>, std::string::String> =
                                    Math::method4(
                                        v0_1.get().clone(),
                                        string("        s = mpmath.zeta(s)"),
                                        Math::method3(v110.clone()),
                                    );
                                let v114: num_complex::Complex<f64> =
                                    Math::method17(v0_1.get().clone(), v110);
                                let v116: Option<num_complex::Complex<f64>> = v113.ok();
                                let _v117: LrcPtr<MutCell<Option<Math::US0>>> =
                                    refCell(None::<Math::US0>);
                                {
                                    let x_8: Option<Math::US0> = match &v116 {
                                        None => None::<Math::US0>,
                                        Some(v116_0_0) => {
                                            let x_6: num_complex::Complex<f64> = v116_0_0.clone();
                                            Some((Func0::new({
                                                let x_6 = x_6.clone();
                                                move || Math::US0::US0_0(x_6.clone())
                                            }))())
                                        }
                                    };
                                    _v117.set(x_8)
                                }
                                {
                                    let v132: Math::US0 =
                                        defaultValue(Math::US0::US0_1, _v117.get().clone());
                                    let v137: f64 = f64::NAN;
                                    let v139: f64 = f64::NAN;
                                    let v141: num_complex::Complex<f64> =
                                        num_complex::Complex::new(v137, v139);
                                    let v144: num_complex::Complex<f64> = match &v132 {
                                        Math::US0::US0_0(v132_0_0) => match &v132 {
                                            Math::US0::US0_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => v141,
                                    };
                                    let v146: num_complex::Complex<f64> = v102 * v144;
                                    let v151: f64 = v37.clone().re - v146.clone().re;
                                    let v152: f64 = -v151;
                                    let v154: f64 = if v151 >= v152 { v151 } else { v152 };
                                    let v155: bool = v154 < 0.0001_f64;
                                    let v157: bool = if v155 { true } else { Math::method21(v155) };
                                    let v159: string = sprintf!(
                                        "{} / actual: {:?} / expected: {:?}",
                                        string("__assert_lt"),
                                        v154,
                                        0.0001_f64
                                    );
                                    printfn!("{0}", v159.clone());
                                    if v157 == false {
                                        panic!("{}", v159,);
                                    }
                                    {
                                        let v167: f64 = v37.im - v146.im;
                                        let v168: f64 = -v167;
                                        let v170: f64 = if v167 >= v168 { v167 } else { v168 };
                                        let v171: bool = v170 < 0.0001_f64;
                                        let v173: bool =
                                            if v171 { true } else { Math::method21(v171) };
                                        let v174: string = sprintf!(
                                            "{} / actual: {:?} / expected: {:?}",
                                            string("__assert_lt"),
                                            v170,
                                            0.0001_f64
                                        );
                                        printfn!("{0}", v174.clone());
                                        if v173 == false {
                                            panic!("{}", v174,);
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
                    let v12: string = string("v5 }}); { // rust.fix_closure\'");
                    v5
                }
            });
            {
                // rust.fix_closure';
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
                            let v30: Math::US0 = defaultValue(Math::US0::US0_1, _v15.get().clone());
                            let v35: f64 = f64::NAN;
                            let v37: f64 = f64::NAN;
                            let v39: num_complex::Complex<f64> =
                                num_complex::Complex::new(v35, v37);
                            let v42: num_complex::Complex<f64> = match &v30 {
                                Math::US0::US0_0(v30_0_0) => match &v30 {
                                    Math::US0::US0_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => v39,
                            };
                            let v45: f64 = v42.clone().re - v8;
                            let v46: f64 = -v45;
                            let v48: f64 = if v45 >= v46 { v45 } else { v46 };
                            let v49: bool = v48 < 0.01_f64;
                            let v51: bool = if v49 { true } else { Math::method21(v49) };
                            let v53: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_lt"),
                                v48,
                                0.01_f64
                            );
                            printfn!("{0}", v53.clone());
                            if v51 == false {
                                panic!("{}", v53,);
                            }
                            {
                                let v58: f64 = v42.im;
                                let v59: bool = v58 < 0.01_f64;
                                let v61: bool = if v59 { true } else { Math::method21(v59) };
                                let v62: string = sprintf!(
                                    "{} / actual: {:?} / expected: {:?}",
                                    string("__assert_lt"),
                                    v58,
                                    0.01_f64
                                );
                                printfn!("{0}", v62.clone());
                                if v61 == false {
                                    panic!("{}", v62,);
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
                    let v12: string = string("v5 }}); { // rust.fix_closure\'");
                    v5
                }
            });
            {
                // rust.fix_closure';
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
