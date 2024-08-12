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
        pub fn closure5(
            v0_1: LrcPtr<MutCell<Option<Math::US0>>>,
            v1_1: Option<Math::US0>,
        ) -> LrcPtr<MutCell<Option<Math::US0>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure6(
            v0_1: Option<num_complex::Complex<f64>>,
            v1_1: Func1<Option<Math::US0>, LrcPtr<MutCell<Option<Math::US0>>>>,
            unitVar: (),
        ) {
            {
                let value: LrcPtr<MutCell<Option<Math::US0>>> = v1_1(match &v0_1 {
                    None => None::<Math::US0>,
                    Some(v0_1_0_0) => {
                        let x: num_complex::Complex<f64> = v0_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Math::US0::US0_0(x.clone())
                        }))())
                    }
                });
                ()
            }
            ()
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
                let v47: () = {
                    Math::closure6(
                        v41,
                        Func1::new({
                            let _v42 = _v42.clone();
                            move |v: Option<Math::US0>| Math::closure5(_v42.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v62: Math::US0 = defaultValue(Math::US0::US0_1, _v42.get().clone());
                let v67: f64 = f64::NAN;
                let v69: f64 = f64::NAN;
                let v71: num_complex::Complex<f64> = num_complex::Complex::new(v67, v69);
                let v74: num_complex::Complex<f64> = match &v62 {
                    Math::US0::US0_0(v62_0_0) => match &v62 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v71,
                };
                let v76: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v78: num_complex::Complex<f64> = v76 * v1_1.clone();
                let v80: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v82: num_complex::Complex<f64> = v78 / v80;
                let v84: num_complex::Complex<f64> = v82.sin();
                let v87: f64 = 1.0_f64 - v1_1.clone().re;
                let v90: f64 = -v1_1.clone().im;
                let v92: num_complex::Complex<f64> = num_complex::Complex::new(v87, v90);
                let v546: num_complex::Complex<f64> = if v92.clone().re <= 1.0_f64 {
                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                } else {
                    println!("zeta / count: {:?} / s: {:?}", 1_i32, v92.clone());
                    if v92.clone().re > 1.0_f64 {
                        let v103: num_complex::Complex<f64> =
                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                        let v104: Array<i32> = new_init(&0_i32, 10000_i32);
                        let v105: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                            l0: MutCell::new(0_i32),
                        });
                        while Math::method18(v105.clone()) {
                            let v107: i32 = v105.l0.get().clone();
                            v104.get_mut()[v107 as usize] = v107;
                            {
                                let v108: i32 = v107 + 1_i32;
                                v105.l0.set(v108);
                                ()
                            }
                        }
                        {
                            let v109: i32 = count(v104.clone());
                            let v110: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                l0: MutCell::new(0_i32),
                                l1: MutCell::new(v103),
                            });
                            while Math::method19(v109, v110.clone()) {
                                let v112: i32 = v110.l0.get().clone();
                                let v113: num_complex::Complex<f64> = v110.l1.get().clone();
                                let v114: i32 = v104[v112].clone();
                                let v116: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v118: f64 = v114 as f64;
                                let v120: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v118, 0.0_f64);
                                let v122: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v120, v92.clone());
                                let v124: num_complex::Complex<f64> = v116 / v122;
                                let v126: num_complex::Complex<f64> = v113 + v124;
                                let v127: i32 = v112 + 1_i32;
                                v110.l0.set(v127);
                                v110.l1.set(v126);
                                ()
                            }
                            v110.l1.get().clone()
                        }
                    } else {
                        let v130: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v135: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method20(
                                v0_1.clone(),
                                string("        s = mpmath.gamma(s)"),
                                Math::method3(v130 - v92.clone()),
                            );
                        let v137: Option<num_complex::Complex<f64>> = v135.ok();
                        let _v138: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
                        let v143: () = {
                            Math::closure6(
                                v137,
                                Func1::new({
                                    let _v138 = _v138.clone();
                                    move |v_1: Option<Math::US0>| Math::closure5(_v138.clone(), v_1)
                                }),
                                (),
                            );
                            ()
                        };
                        let v158: Math::US0 = defaultValue(Math::US0::US0_1, _v138.get().clone());
                        let v163: f64 = f64::NAN;
                        let v165: f64 = f64::NAN;
                        let v167: num_complex::Complex<f64> = num_complex::Complex::new(v163, v165);
                        let v170: num_complex::Complex<f64> = match &v158 {
                            Math::US0::US0_0(v158_0_0) => match &v158 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v167,
                        };
                        let v172: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v174: num_complex::Complex<f64> = v172 * v92.clone();
                        let v176: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v178: num_complex::Complex<f64> = v174 / v176;
                        let v180: num_complex::Complex<f64> = v178.sin();
                        let v183: f64 = 1.0_f64 - v92.clone().re;
                        let v186: f64 = -v92.clone().im;
                        let v188: num_complex::Complex<f64> = num_complex::Complex::new(v183, v186);
                        let v530: num_complex::Complex<f64> = if v188.clone().re <= 1.0_f64 {
                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                        } else {
                            println!("zeta / count: {:?} / s: {:?}", 2_i32, v188.clone());
                            if v188.clone().re > 1.0_f64 {
                                let v199: num_complex::Complex<f64> =
                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                let v200: Array<i32> = new_init(&0_i32, 10000_i32);
                                let v201: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Math::method18(v201.clone()) {
                                    let v203: i32 = v201.l0.get().clone();
                                    v200.get_mut()[v203 as usize] = v203;
                                    {
                                        let v204: i32 = v203 + 1_i32;
                                        v201.l0.set(v204);
                                        ()
                                    }
                                }
                                {
                                    let v205: i32 = count(v200.clone());
                                    let v206: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                        l0: MutCell::new(0_i32),
                                        l1: MutCell::new(v199),
                                    });
                                    while Math::method19(v205, v206.clone()) {
                                        let v208: i32 = v206.l0.get().clone();
                                        let v209: num_complex::Complex<f64> = v206.l1.get().clone();
                                        let v210: i32 = v200[v208].clone();
                                        let v212: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v214: f64 = v210 as f64;
                                        let v216: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v214, 0.0_f64);
                                        let v218: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v216, v188.clone());
                                        let v220: num_complex::Complex<f64> = v212 / v218;
                                        let v222: num_complex::Complex<f64> = v209 + v220;
                                        let v223: i32 = v208 + 1_i32;
                                        v206.l0.set(v223);
                                        v206.l1.set(v222);
                                        ()
                                    }
                                    v206.l1.get().clone()
                                }
                            } else {
                                let v226: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v231: Result<num_complex::Complex<f64>, std::string::String> =
                                    Math::method20(
                                        v0_1.clone(),
                                        string("        s = mpmath.gamma(s)"),
                                        Math::method3(v226 - v188.clone()),
                                    );
                                let v233: Option<num_complex::Complex<f64>> = v231.ok();
                                let _v234: LrcPtr<MutCell<Option<Math::US0>>> =
                                    refCell(None::<Math::US0>);
                                let v239: () = {
                                    Math::closure6(
                                        v233,
                                        Func1::new({
                                            let _v234 = _v234.clone();
                                            move |v_2: Option<Math::US0>| {
                                                Math::closure5(_v234.clone(), v_2)
                                            }
                                        }),
                                        (),
                                    );
                                    ()
                                };
                                let v254: Math::US0 =
                                    defaultValue(Math::US0::US0_1, _v234.get().clone());
                                let v259: f64 = f64::NAN;
                                let v261: f64 = f64::NAN;
                                let v263: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v259, v261);
                                let v266: num_complex::Complex<f64> = match &v254 {
                                    Math::US0::US0_0(v254_0_0) => match &v254 {
                                        Math::US0::US0_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => v263,
                                };
                                let v268: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v270: num_complex::Complex<f64> = v268 * v188.clone();
                                let v272: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v274: num_complex::Complex<f64> = v270 / v272;
                                let v276: num_complex::Complex<f64> = v274.sin();
                                let v279: f64 = 1.0_f64 - v188.clone().re;
                                let v282: f64 = -v188.clone().im;
                                let v284: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v279, v282);
                                let v514: num_complex::Complex<f64> = if v284.clone().re <= 1.0_f64
                                {
                                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                                } else {
                                    println!("zeta / count: {:?} / s: {:?}", 3_i32, v284.clone());
                                    if v284.clone().re > 1.0_f64 {
                                        let v295: num_complex::Complex<f64> =
                                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                                        let v296: Array<i32> = new_init(&0_i32, 10000_i32);
                                        let v297: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                            l0: MutCell::new(0_i32),
                                        });
                                        while Math::method18(v297.clone()) {
                                            let v299: i32 = v297.l0.get().clone();
                                            v296.get_mut()[v299 as usize] = v299;
                                            {
                                                let v300: i32 = v299 + 1_i32;
                                                v297.l0.set(v300);
                                                ()
                                            }
                                        }
                                        {
                                            let v301: i32 = count(v296.clone());
                                            let v302: LrcPtr<Math::Mut2> =
                                                LrcPtr::new(Math::Mut2 {
                                                    l0: MutCell::new(0_i32),
                                                    l1: MutCell::new(v295),
                                                });
                                            while Math::method19(v301, v302.clone()) {
                                                let v304: i32 = v302.l0.get().clone();
                                                let v305: num_complex::Complex<f64> =
                                                    v302.l1.get().clone();
                                                let v306: i32 = v296[v304].clone();
                                                let v308: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v310: f64 = v306 as f64;
                                                let v312: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v310, 0.0_f64);
                                                let v314: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v312, v284.clone());
                                                let v316: num_complex::Complex<f64> = v308 / v314;
                                                let v318: num_complex::Complex<f64> = v305 + v316;
                                                let v319: i32 = v304 + 1_i32;
                                                v302.l0.set(v319);
                                                v302.l1.set(v318);
                                                ()
                                            }
                                            v302.l1.get().clone()
                                        }
                                    } else {
                                        let v322: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v327: Result<
                                            num_complex::Complex<f64>,
                                            std::string::String,
                                        > = Math::method20(
                                            v0_1.clone(),
                                            string("        s = mpmath.gamma(s)"),
                                            Math::method3(v322 - v284.clone()),
                                        );
                                        let v329: Option<num_complex::Complex<f64>> = v327.ok();
                                        let _v330: LrcPtr<MutCell<Option<Math::US0>>> =
                                            refCell(None::<Math::US0>);
                                        let v335: () = {
                                            Math::closure6(
                                                v329,
                                                Func1::new({
                                                    let _v330 = _v330.clone();
                                                    move |v_3: Option<Math::US0>| {
                                                        Math::closure5(_v330.clone(), v_3)
                                                    }
                                                }),
                                                (),
                                            );
                                            ()
                                        };
                                        let v350: Math::US0 =
                                            defaultValue(Math::US0::US0_1, _v330.get().clone());
                                        let v355: f64 = f64::NAN;
                                        let v357: f64 = f64::NAN;
                                        let v359: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v355, v357);
                                        let v362: num_complex::Complex<f64> = match &v350 {
                                            Math::US0::US0_0(v350_0_0) => match &v350 {
                                                Math::US0::US0_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => v359,
                                        };
                                        let v364: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v366: num_complex::Complex<f64> = v364 * v284.clone();
                                        let v368: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v370: num_complex::Complex<f64> = v366 / v368;
                                        let v372: num_complex::Complex<f64> = v370.sin();
                                        let v375: f64 = 1.0_f64 - v284.clone().re;
                                        let v378: f64 = -v284.clone().im;
                                        let v380: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v375, v378);
                                        let v498: num_complex::Complex<f64> = if v380.clone().re
                                            <= 1.0_f64
                                        {
                                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                                        } else {
                                            println!(
                                                "zeta / count: {:?} / s: {:?}",
                                                4_i32,
                                                v380.clone()
                                            );
                                            if v380.clone().re > 1.0_f64 {
                                                let v391: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                                let v392: Array<i32> = new_init(&0_i32, 10000_i32);
                                                let v393: LrcPtr<Math::Mut0> =
                                                    LrcPtr::new(Math::Mut0 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Math::method18(v393.clone()) {
                                                    let v395: i32 = v393.l0.get().clone();
                                                    v392.get_mut()[v395 as usize] = v395;
                                                    {
                                                        let v396: i32 = v395 + 1_i32;
                                                        v393.l0.set(v396);
                                                        ()
                                                    }
                                                }
                                                {
                                                    let v397: i32 = count(v392.clone());
                                                    let v398: LrcPtr<Math::Mut2> =
                                                        LrcPtr::new(Math::Mut2 {
                                                            l0: MutCell::new(0_i32),
                                                            l1: MutCell::new(v391),
                                                        });
                                                    while Math::method19(v397, v398.clone()) {
                                                        let v400: i32 = v398.l0.get().clone();
                                                        let v401: num_complex::Complex<f64> =
                                                            v398.l1.get().clone();
                                                        let v402: i32 = v392[v400].clone();
                                                        let v404: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                1.0_f64, 0.0_f64,
                                                            );
                                                        let v406: f64 = v402 as f64;
                                                        let v408: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                v406, 0.0_f64,
                                                            );
                                                        let v410: num_complex::Complex<f64> =
                                                            num_complex::Complex::powc(
                                                                v408,
                                                                v380.clone(),
                                                            );
                                                        let v412: num_complex::Complex<f64> =
                                                            v404 / v410;
                                                        let v414: num_complex::Complex<f64> =
                                                            v401 + v412;
                                                        let v415: i32 = v400 + 1_i32;
                                                        v398.l0.set(v415);
                                                        v398.l1.set(v414);
                                                        ()
                                                    }
                                                    v398.l1.get().clone()
                                                }
                                            } else {
                                                let v418: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v423: Result<
                                                    num_complex::Complex<f64>,
                                                    std::string::String,
                                                > = Math::method20(
                                                    v0_1,
                                                    string("        s = mpmath.gamma(s)"),
                                                    Math::method3(v418 - v380.clone()),
                                                );
                                                let v425: Option<num_complex::Complex<f64>> =
                                                    v423.ok();
                                                let _v426: LrcPtr<MutCell<Option<Math::US0>>> =
                                                    refCell(None::<Math::US0>);
                                                let v431: () = {
                                                    Math::closure6(
                                                        v425,
                                                        Func1::new({
                                                            let _v426 = _v426.clone();
                                                            move |v_4: Option<Math::US0>| {
                                                                Math::closure5(_v426.clone(), v_4)
                                                            }
                                                        }),
                                                        (),
                                                    );
                                                    ()
                                                };
                                                let v446: Math::US0 = defaultValue(
                                                    Math::US0::US0_1,
                                                    _v426.get().clone(),
                                                );
                                                let v451: f64 = f64::NAN;
                                                let v453: f64 = f64::NAN;
                                                let v455: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v451, v453);
                                                let v458: num_complex::Complex<f64> = match &v446 {
                                                    Math::US0::US0_0(v446_0_0) => match &v446 {
                                                        Math::US0::US0_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    },
                                                    _ => v455,
                                                };
                                                let v460: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(
                                                        3.141592653589793_f64,
                                                        0.0_f64,
                                                    );
                                                let v462: num_complex::Complex<f64> =
                                                    v460 * v380.clone();
                                                let v464: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                let v466: num_complex::Complex<f64> = v462 / v464;
                                                let v468: num_complex::Complex<f64> = v466.sin();
                                                let v471: f64 = 1.0_f64 - v380.clone().re;
                                                let v474: f64 = -v380.clone().im;
                                                let v476: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v471, v474);
                                                let v482: num_complex::Complex<f64> =
                                                    if v476.clone().re <= 1.0_f64 {
                                                        num_complex::Complex::new(0.0_f64, 0.0_f64)
                                                    } else {
                                                        v476
                                                    };
                                                let v484: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                let v486: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(
                                                        3.141592653589793_f64,
                                                        0.0_f64,
                                                    );
                                                let v488: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v486, v380.clone());
                                                let v490: num_complex::Complex<f64> = v484 * v488;
                                                let v492: num_complex::Complex<f64> = v490 * v468;
                                                let v494: num_complex::Complex<f64> = v492 * v458;
                                                v494 * v482
                                            }
                                        };
                                        let v500: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v502: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v504: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v502, v284.clone());
                                        let v506: num_complex::Complex<f64> = v500 * v504;
                                        let v508: num_complex::Complex<f64> = v506 * v372;
                                        let v510: num_complex::Complex<f64> = v508 * v362;
                                        v510 * v498
                                    }
                                };
                                let v516: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v518: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v520: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v518, v188.clone());
                                let v522: num_complex::Complex<f64> = v516 * v520;
                                let v524: num_complex::Complex<f64> = v522 * v276;
                                let v526: num_complex::Complex<f64> = v524 * v266;
                                v526 * v514
                            }
                        };
                        let v532: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v534: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v536: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v534, v92.clone());
                        let v538: num_complex::Complex<f64> = v532 * v536;
                        let v540: num_complex::Complex<f64> = v538 * v180;
                        let v542: num_complex::Complex<f64> = v540 * v170;
                        v542 * v530
                    }
                };
                let v548: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v550: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v552: num_complex::Complex<f64> =
                    num_complex::Complex::powc(v550, v1_1.clone());
                let v554: num_complex::Complex<f64> = v548 * v552;
                let v556: num_complex::Complex<f64> = v554 * v84;
                let v558: num_complex::Complex<f64> = v556 * v74;
                v558 * v546
            }
        }
        pub fn method21(v0_1: bool) -> bool {
            v0_1
        }
        pub fn closure7(v0_1: string, unitVar: ()) {
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
                let v15: num_complex::Complex<f64> = Math::method17(v0_1.clone(), v10);
                let v17: Option<num_complex::Complex<f64>> = v14.ok();
                let _v18: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
                let v23: () = {
                    Math::closure6(
                        v17,
                        Func1::new({
                            let _v18 = _v18.clone();
                            move |v: Option<Math::US0>| Math::closure5(_v18.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v38: Math::US0 = defaultValue(Math::US0::US0_1, _v18.get().clone());
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
                let v52: f64 = v50.clone().im;
                let v53: bool = v52 == 0.0_f64;
                let v55: bool = if v53 { true } else { Math::method21(v53) };
                let v57: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_eq"),
                    v52,
                    0.0_f64
                );
                let v62: () = {
                    Math::closure7(v57.clone(), ());
                    ()
                };
                if v55 == false {
                    panic!("{}", v57,);
                }
                {
                    let v67: f64 = v50.re - patternInput.1.clone();
                    let v68: f64 = -v67;
                    let v70: f64 = if v67 >= v68 { v67 } else { v68 };
                    let v71: bool = v70 < 0.0001_f64;
                    let v73: bool = if v71 { true } else { Math::method21(v71) };
                    let v75: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_lt"),
                        v70,
                        0.0001_f64
                    );
                    let v80: () = {
                        Math::closure7(v75.clone(), ());
                        ()
                    };
                    if v73 == false {
                        panic!("{}", v75,);
                    }
                    {
                        let v83: i32 = v9 + 1_i32;
                        v7.l0.set(v83);
                        ()
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __result;
                v15.unwrap();
                ()
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
            let v14: () = {
                Math::closure6(
                    v8,
                    Func1::new({
                        let _v9 = _v9.clone();
                        move |v: Option<Math::US0>| Math::closure5(_v9.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v29: Math::US0 = defaultValue(Math::US0::US0_1, _v9.get().clone());
            let v34: f64 = f64::NAN;
            let v36: f64 = f64::NAN;
            let v38: num_complex::Complex<f64> = num_complex::Complex::new(v34, v36);
            let v41: num_complex::Complex<f64> = match &v29 {
                Math::US0::US0_0(v29_0_0) => match &v29 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v38,
            };
            let v44: f64 = v41.clone().re - 0.8673_f64;
            let v45: f64 = -v44;
            let v47: f64 = if v44 >= v45 { v44 } else { v45 };
            let v48: bool = v47 < 0.001_f64;
            let v50: bool = if v48 { true } else { Math::method21(v48) };
            let v52: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_lt"),
                v47,
                0.001_f64
            );
            let v57: () = {
                Math::closure7(v52.clone(), ());
                ()
            };
            if v50 == false {
                panic!("{}", v52,);
            }
            {
                let v62: f64 = v41.im - 0.275_f64;
                let v63: f64 = -v62;
                let v65: f64 = if v62 >= v63 { v62 } else { v63 };
                let v66: bool = v65 < 0.001_f64;
                let v68: bool = if v66 { true } else { Math::method21(v66) };
                let v69: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_lt"),
                    v65,
                    0.001_f64
                );
                let v74: () = {
                    Math::closure7(v69.clone(), ());
                    ()
                };
                if v68 == false {
                    panic!("{}", v69,);
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __result;
                v15.unwrap();
                ()
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
                        let v17: () = {
                            Math::closure6(
                                v11,
                                Func1::new({
                                    let _v12 = _v12.clone();
                                    move |v: Option<Math::US0>| Math::closure5(_v12.clone(), v)
                                }),
                                (),
                            );
                            ()
                        };
                        let v32: Math::US0 = defaultValue(Math::US0::US0_1, _v12.get().clone());
                        let v37: f64 = f64::NAN;
                        let v39: f64 = f64::NAN;
                        let v41: num_complex::Complex<f64> = num_complex::Complex::new(v37, v39);
                        let v44: num_complex::Complex<f64> = match &v32 {
                            Math::US0::US0_0(v32_0_0) => match &v32 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v41,
                        };
                        let v46: f64 = v44.clone().re;
                        let v47: bool = v46 == 0.0_f64;
                        let v49: bool = if v47 { true } else { Math::method21(v47) };
                        let v51: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_eq"),
                            v46,
                            0.0_f64
                        );
                        let v56: () = {
                            Math::closure7(v51.clone(), ());
                            ()
                        };
                        if v49 == false {
                            panic!("{}", v51,);
                        }
                        {
                            let v60: f64 = v44.im;
                            let v61: bool = v60 == 0.0_f64;
                            let v63: bool = if v61 { true } else { Math::method21(v61) };
                            let v64: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_eq"),
                                v60,
                                0.0_f64
                            );
                            let v69: () = {
                                Math::closure7(v64.clone(), ());
                                ()
                            };
                            if v63 == false {
                                panic!("{}", v64,);
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
                                continue '_method28;
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __result;
                v15.unwrap();
                ()
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
                let v30: () = {
                    Math::closure6(
                        v24,
                        Func1::new({
                            let _v25 = _v25.clone();
                            move |v: Option<Math::US0>| Math::closure5(_v25.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v45: Math::US0 = defaultValue(Math::US0::US0_1, _v25.get().clone());
                let v50: f64 = f64::NAN;
                let v52: f64 = f64::NAN;
                let v54: num_complex::Complex<f64> = num_complex::Complex::new(v50, v52);
                let v57: num_complex::Complex<f64> = match &v45 {
                    Math::US0::US0_0(v45_0_0) => match &v45 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v54,
                };
                let v59: f64 = v57.clone().re;
                let v60: f64 = -v59;
                let v62: f64 = if v59 >= v60 { v59 } else { v60 };
                let v63: bool = v62 < 0.0001_f64;
                let v65: bool = if v63 { true } else { Math::method21(v63) };
                let v67: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_lt"),
                    v62,
                    0.0001_f64
                );
                let v72: () = {
                    Math::closure7(v67.clone(), ());
                    ()
                };
                if v65 == false {
                    panic!("{}", v67,);
                }
                {
                    let v76: f64 = v57.im;
                    let v77: f64 = -v76;
                    let v79: f64 = if v76 >= v77 { v76 } else { v77 };
                    let v80: bool = v79 < 0.0001_f64;
                    let v82: bool = if v80 { true } else { Math::method21(v80) };
                    let v83: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_lt"),
                        v79,
                        0.0001_f64
                    );
                    let v88: () = {
                        Math::closure7(v83.clone(), ());
                        ()
                    };
                    if v82 == false {
                        panic!("{}", v83,);
                    }
                    {
                        let v91: i32 = v17 + 1_i32;
                        v15.l0.set(v91);
                        ()
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __result;
                v15.unwrap();
                ()
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
                let v20: () = {
                    Math::closure6(
                        v14,
                        Func1::new({
                            let _v15 = _v15.clone();
                            move |v: Option<Math::US0>| Math::closure5(_v15.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v35: Math::US0 = defaultValue(Math::US0::US0_1, _v15.get().clone());
                let v40: f64 = f64::NAN;
                let v42: f64 = f64::NAN;
                let v44: num_complex::Complex<f64> = num_complex::Complex::new(v40, v42);
                let v47: num_complex::Complex<f64> = match &v35 {
                    Math::US0::US0_0(v35_0_0) => match &v35 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v44,
                };
                let v49: f64 = v47.clone().re;
                let v50: bool = v49 > 0.0_f64;
                let v52: bool = if v50 { true } else { Math::method21(v50) };
                let v54: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_gt"),
                    v49,
                    0.0_f64
                );
                let v59: () = {
                    Math::closure7(v54.clone(), ());
                    ()
                };
                if v52 == false {
                    panic!("{}", v54,);
                }
                {
                    let v63: f64 = v47.im;
                    let v64: bool = v63 == 0.0_f64;
                    let v66: bool = if v64 { true } else { Math::method21(v64) };
                    let v68: string = sprintf!(
                        "{} / actual: {:?} / expected: {:?}",
                        string("__assert_eq"),
                        v63,
                        0.0_f64
                    );
                    let v73: () = {
                        Math::closure7(v68.clone(), ());
                        ()
                    };
                    if v66 == false {
                        panic!("{}", v68,);
                    }
                    {
                        let v76: i32 = v5 + 1_i32;
                        v3.l0.set(v76);
                        ()
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __result;
                v15.unwrap();
                ()
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
            let v14: () = {
                Math::closure6(
                    v8,
                    Func1::new({
                        let _v9 = _v9.clone();
                        move |v: Option<Math::US0>| Math::closure5(_v9.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v29: Math::US0 = defaultValue(Math::US0::US0_1, _v9.get().clone());
            let v34: f64 = f64::NAN;
            let v36: f64 = f64::NAN;
            let v38: num_complex::Complex<f64> = num_complex::Complex::new(v34, v36);
            let v41: num_complex::Complex<f64> = match &v29 {
                Math::US0::US0_0(v29_0_0) => match &v29 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v38,
            };
            let v43: f64 = v41.clone().re;
            let v44: bool = v43 == f64::INFINITY;
            let v46: bool = if v44 { true } else { Math::method21(v44) };
            let v48: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_eq"),
                v43,
                f64::INFINITY
            );
            let v53: () = {
                Math::closure7(v48.clone(), ());
                ()
            };
            if v46 == false {
                panic!("{}", v48,);
            }
            {
                let v57: f64 = v41.im;
                let v58: bool = v57 == 0.0_f64;
                let v60: bool = if v58 { true } else { Math::method21(v58) };
                let v61: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_eq"),
                    v57,
                    0.0_f64
                );
                let v66: () = {
                    Math::closure7(v61.clone(), ());
                    ()
                };
                if v60 == false {
                    panic!("{}", v61,);
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __result;
                v15.unwrap();
                ()
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
            let v14: () = {
                Math::closure6(
                    v8,
                    Func1::new({
                        let _v9 = _v9.clone();
                        move |v: Option<Math::US0>| Math::closure5(_v9.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v29: Math::US0 = defaultValue(Math::US0::US0_1, _v9.get().clone());
            let v34: f64 = f64::NAN;
            let v36: f64 = f64::NAN;
            let v38: num_complex::Complex<f64> = num_complex::Complex::new(v34, v36);
            let v41: num_complex::Complex<f64> = match &v29 {
                Math::US0::US0_0(v29_0_0) => match &v29 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v38,
            };
            let v43: f64 = v2.clone().re;
            let v46: f64 = -v2.im;
            let v48: num_complex::Complex<f64> = num_complex::Complex::new(v43, v46);
            let v51: Result<num_complex::Complex<f64>, std::string::String> = Math::method4(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method3(v48.clone()),
            );
            let v52: num_complex::Complex<f64> = Math::method17(v0_1, v48);
            let v54: Option<num_complex::Complex<f64>> = v51.ok();
            let _v55: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
            let v60: () = {
                Math::closure6(
                    v54,
                    Func1::new({
                        let _v55 = _v55.clone();
                        move |v_1: Option<Math::US0>| Math::closure5(_v55.clone(), v_1)
                    }),
                    (),
                );
                ()
            };
            let v75: Math::US0 = defaultValue(Math::US0::US0_1, _v55.get().clone());
            let v80: f64 = f64::NAN;
            let v82: f64 = f64::NAN;
            let v84: num_complex::Complex<f64> = num_complex::Complex::new(v80, v82);
            let v87: num_complex::Complex<f64> = match &v75 {
                Math::US0::US0_0(v75_0_0) => match &v75 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v84,
            };
            let v89: num_complex::Complex<f64> = v87.conj();
            let v91: f64 = v41.clone().re;
            let v93: f64 = v89.clone().re;
            let v94: bool = v91 == v93;
            let v96: bool = if v94 { true } else { Math::method21(v94) };
            let v98: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_eq"),
                v91,
                v93
            );
            let v103: () = {
                Math::closure7(v98.clone(), ());
                ()
            };
            if v96 == false {
                panic!("{}", v98,);
            }
            {
                let v107: f64 = v41.im;
                let v109: f64 = v89.im;
                let v110: bool = v107 == v109;
                let v112: bool = if v110 { true } else { Math::method21(v110) };
                let v113: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_eq"),
                    v107,
                    v109
                );
                let v118: () = {
                    Math::closure7(v113.clone(), ());
                    ()
                };
                if v112 == false {
                    panic!("{}", v113,);
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __result;
                v15.unwrap();
                ()
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
            let v14: () = {
                Math::closure6(
                    v8,
                    Func1::new({
                        let _v9 = _v9.clone();
                        move |v: Option<Math::US0>| Math::closure5(_v9.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v29: Math::US0 = defaultValue(Math::US0::US0_1, _v9.get().clone());
            let v34: f64 = f64::NAN;
            let v36: f64 = f64::NAN;
            let v38: num_complex::Complex<f64> = num_complex::Complex::new(v34, v36);
            let v41: num_complex::Complex<f64> = match &v29 {
                Math::US0::US0_0(v29_0_0) => match &v29 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v38,
            };
            let v43: f64 = v41.clone().re;
            let v44: bool = v43 < f64::INFINITY;
            let v46: bool = if v44 { true } else { Math::method21(v44) };
            let v48: string = sprintf!(
                "{} / actual: {:?} / expected: {:?}",
                string("__assert_lt"),
                v43,
                f64::INFINITY
            );
            let v53: () = {
                Math::closure7(v48.clone(), ());
                ()
            };
            if v46 == false {
                panic!("{}", v48,);
            }
            {
                let v57: f64 = v41.im;
                let v58: bool = v57 < f64::INFINITY;
                let v60: bool = if v58 { true } else { Math::method21(v58) };
                let v61: string = sprintf!(
                    "{} / actual: {:?} / expected: {:?}",
                    string("__assert_lt"),
                    v57,
                    f64::INFINITY
                );
                let v66: () = {
                    Math::closure7(v61.clone(), ());
                    ()
                };
                if v60 == false {
                    panic!("{}", v61,);
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __result;
                v15.unwrap();
                ()
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
                        let v17: () = {
                            Math::closure6(
                                v11,
                                Func1::new({
                                    let _v12 = _v12.clone();
                                    move |v: Option<Math::US0>| Math::closure5(_v12.clone(), v)
                                }),
                                (),
                            );
                            ()
                        };
                        let v32: Math::US0 = defaultValue(Math::US0::US0_1, _v12.get().clone());
                        let v37: f64 = f64::NAN;
                        let v39: f64 = f64::NAN;
                        let v41: num_complex::Complex<f64> = num_complex::Complex::new(v37, v39);
                        let v44: num_complex::Complex<f64> = match &v32 {
                            Math::US0::US0_0(v32_0_0) => match &v32 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v41,
                        };
                        let v46: f64 = v44.clone().re;
                        let v47: bool = v46 != 0.0_f64;
                        let v51: bool = if v47 { true } else { Math::method21(v47) };
                        let v53: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_ne"),
                            v46,
                            0.0_f64
                        );
                        let v58: () = {
                            Math::closure7(v53.clone(), ());
                            ()
                        };
                        if v51 == false {
                            panic!("{}", v53,);
                        }
                        {
                            let v62: f64 = v44.im;
                            let v63: bool = v62 != 0.0_f64;
                            let v67: bool = if v63 { true } else { Math::method21(v63) };
                            let v68: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_ne"),
                                v62,
                                0.0_f64
                            );
                            let v73: () = {
                                Math::closure7(v68.clone(), ());
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
                                continue '_method42;
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __result;
                v15.unwrap();
                ()
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
                        let v15: () = {
                            Math::closure6(
                                v9,
                                Func1::new({
                                    let _v10 = _v10.clone();
                                    move |v: Option<Math::US0>| Math::closure5(_v10.clone(), v)
                                }),
                                (),
                            );
                            ()
                        };
                        let v30: Math::US0 = defaultValue(Math::US0::US0_1, _v10.get().clone());
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
                        let v45: bool = v44 != 0.0_f64;
                        let v49: bool = if v45 { true } else { Math::method21(v45) };
                        let v51: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_ne"),
                            v44,
                            0.0_f64
                        );
                        let v56: () = {
                            Math::closure7(v51.clone(), ());
                            ()
                        };
                        if v49 == false {
                            panic!("{}", v51,);
                        }
                        {
                            let v60: f64 = v42.im;
                            let v61: bool = v60 != 0.0_f64;
                            let v65: bool = if v61 { true } else { Math::method21(v61) };
                            let v66: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_ne"),
                                v60,
                                0.0_f64
                            );
                            let v71: () = {
                                Math::closure7(v66.clone(), ());
                                ()
                            };
                            if v65 == false {
                                panic!("{}", v66,);
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
                                continue '_method46;
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __result;
                v15.unwrap();
                ()
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
                        let v15: () = {
                            Math::closure6(
                                v9,
                                Func1::new({
                                    let _v10 = _v10.clone();
                                    move |v: Option<Math::US0>| Math::closure5(_v10.clone(), v)
                                }),
                                (),
                            );
                            ()
                        };
                        let v30: Math::US0 = defaultValue(Math::US0::US0_1, _v10.get().clone());
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
                        let v44: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v46: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v44, v2.clone());
                        let v48: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v50: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v52: num_complex::Complex<f64> = v2.clone() - v50;
                        let v54: num_complex::Complex<f64> = num_complex::Complex::powc(v48, v52);
                        let v56: num_complex::Complex<f64> = v46 * v54;
                        let v58: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v60: num_complex::Complex<f64> = v58 * v2.clone();
                        let v62: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v64: num_complex::Complex<f64> = v60 / v62;
                        let v66: num_complex::Complex<f64> = v64.sin();
                        let v68: num_complex::Complex<f64> = v56 * v66;
                        let v70: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v75: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method20(
                                v0_1.get().clone(),
                                string("        s = mpmath.gamma(s)"),
                                Math::method3(v70 - v2.clone()),
                            );
                        let v77: Option<num_complex::Complex<f64>> = v75.ok();
                        let _v78: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
                        let v83: () = {
                            Math::closure6(
                                v77,
                                Func1::new({
                                    let _v78 = _v78.clone();
                                    move |v_1: Option<Math::US0>| Math::closure5(_v78.clone(), v_1)
                                }),
                                (),
                            );
                            ()
                        };
                        let v98: Math::US0 = defaultValue(Math::US0::US0_1, _v78.get().clone());
                        let v103: f64 = f64::NAN;
                        let v105: f64 = f64::NAN;
                        let v107: num_complex::Complex<f64> = num_complex::Complex::new(v103, v105);
                        let v110: num_complex::Complex<f64> = match &v98 {
                            Math::US0::US0_0(v98_0_0) => match &v98 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v107,
                        };
                        let v112: num_complex::Complex<f64> = v68 * v110;
                        let v115: f64 = 1.0_f64 - v2.clone().re;
                        let v118: f64 = -v2.im;
                        let v120: num_complex::Complex<f64> = num_complex::Complex::new(v115, v118);
                        let v123: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(
                                v0_1.get().clone(),
                                string("        s = mpmath.zeta(s)"),
                                Math::method3(v120.clone()),
                            );
                        let v124: num_complex::Complex<f64> =
                            Math::method17(v0_1.get().clone(), v120);
                        let v126: Option<num_complex::Complex<f64>> = v123.ok();
                        let _v127: LrcPtr<MutCell<Option<Math::US0>>> = refCell(None::<Math::US0>);
                        let v132: () = {
                            Math::closure6(
                                v126,
                                Func1::new({
                                    let _v127 = _v127.clone();
                                    move |v_2: Option<Math::US0>| Math::closure5(_v127.clone(), v_2)
                                }),
                                (),
                            );
                            ()
                        };
                        let v147: Math::US0 = defaultValue(Math::US0::US0_1, _v127.get().clone());
                        let v152: f64 = f64::NAN;
                        let v154: f64 = f64::NAN;
                        let v156: num_complex::Complex<f64> = num_complex::Complex::new(v152, v154);
                        let v159: num_complex::Complex<f64> = match &v147 {
                            Math::US0::US0_0(v147_0_0) => match &v147 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v156,
                        };
                        let v161: num_complex::Complex<f64> = v112 * v159;
                        let v166: f64 = v42.clone().re - v161.clone().re;
                        let v167: f64 = -v166;
                        let v169: f64 = if v166 >= v167 { v166 } else { v167 };
                        let v170: bool = v169 < 0.0001_f64;
                        let v172: bool = if v170 { true } else { Math::method21(v170) };
                        let v174: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_lt"),
                            v169,
                            0.0001_f64
                        );
                        let v179: () = {
                            Math::closure7(v174.clone(), ());
                            ()
                        };
                        if v172 == false {
                            panic!("{}", v174,);
                        }
                        {
                            let v186: f64 = v42.im - v161.im;
                            let v187: f64 = -v186;
                            let v189: f64 = if v186 >= v187 { v186 } else { v187 };
                            let v190: bool = v189 < 0.0001_f64;
                            let v192: bool = if v190 { true } else { Math::method21(v190) };
                            let v193: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_lt"),
                                v189,
                                0.0001_f64
                            );
                            let v198: () = {
                                Math::closure7(v193.clone(), ());
                                ()
                            };
                            if v192 == false {
                                panic!("{}", v193,);
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
                                continue '_method50;
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __result;
                v15.unwrap();
                ()
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
                        let v20: () = {
                            Math::closure6(
                                v14,
                                Func1::new({
                                    let _v15 = _v15.clone();
                                    move |v: Option<Math::US0>| Math::closure5(_v15.clone(), v)
                                }),
                                (),
                            );
                            ()
                        };
                        let v35: Math::US0 = defaultValue(Math::US0::US0_1, _v15.get().clone());
                        let v40: f64 = f64::NAN;
                        let v42: f64 = f64::NAN;
                        let v44: num_complex::Complex<f64> = num_complex::Complex::new(v40, v42);
                        let v47: num_complex::Complex<f64> = match &v35 {
                            Math::US0::US0_0(v35_0_0) => match &v35 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v44,
                        };
                        let v50: f64 = v47.clone().re - v8;
                        let v51: f64 = -v50;
                        let v53: f64 = if v50 >= v51 { v50 } else { v51 };
                        let v54: bool = v53 < 0.01_f64;
                        let v56: bool = if v54 { true } else { Math::method21(v54) };
                        let v58: string = sprintf!(
                            "{} / actual: {:?} / expected: {:?}",
                            string("__assert_lt"),
                            v53,
                            0.01_f64
                        );
                        let v63: () = {
                            Math::closure7(v58.clone(), ());
                            ()
                        };
                        if v56 == false {
                            panic!("{}", v58,);
                        }
                        {
                            let v67: f64 = v47.im;
                            let v68: bool = v67 < 0.01_f64;
                            let v70: bool = if v68 { true } else { Math::method21(v68) };
                            let v71: string = sprintf!(
                                "{} / actual: {:?} / expected: {:?}",
                                string("__assert_lt"),
                                v67,
                                0.01_f64
                            );
                            let v76: () = {
                                Math::closure7(v71.clone(), ());
                                ()
                            };
                            if v70 == false {
                                panic!("{}", v71,);
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
                                continue '_method55;
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
                    let v12: string = string("true; v5 }}); { // rust.fix_closure\'");
                    let v13: bool = true;
                    v5
                }
            });
            {
                // rust.fix_closure';
                let v15: Result<(), pyo3::PyErr> = __result;
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
        pub fn closure8(unitVar: (), v0_1: Array<string>) -> i32 {
            let v4: () = {
                Math::closure7(sprintf!("value: {}", 1_i32), ());
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
            v1.get_or_init(|| Func1::new(move |v: Array<string>| Math::closure8((), v)))
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
