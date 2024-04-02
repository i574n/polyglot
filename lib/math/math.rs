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
        pub fn method2() -> f64 {
            2.0_f64
        }
        pub fn method3(v0_1: f64) -> f64 {
            v0_1
        }
        pub fn method4() -> f64 {
            0.0_f64
        }
        pub fn method5() -> f64 {
            -1.0_f64
        }
        pub fn method6(
            v0_1: Array<(num_complex::Complex<f64>, f64)>,
        ) -> Array<(num_complex::Complex<f64>, f64)> {
            v0_1
        }
        pub fn method7(v0_1: i32, v1_1: LrcPtr<Math::Mut0>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method8(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method10(v0_1: Array<string>) -> Array<string> {
            v0_1
        }
        pub fn method12(v0_1: i32, v1_1: LrcPtr<Math::Mut1>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method11(v0_1: Array<string>) -> string {
            let v1_1: i32 = count(v0_1.clone());
            let v3: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                l0: MutCell::new(0_i32),
                l1: MutCell::new(string("")),
            });
            while Math::method12(v1_1, v3.clone()) {
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
        pub fn method13(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method14(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method15(v0_1: pyo3::Python) -> pyo3::Python {
            v0_1
        }
        pub fn method16(v0_1: string) -> string {
            v0_1
        }
        pub fn closure1(unitVar: (), v0_1: pyo3::PyErr) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method17() -> Func1<pyo3::PyErr, std::string::String> {
            Func1::new(move |v: pyo3::PyErr| Math::closure1((), v))
        }
        pub fn method18(
            v0_1: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr>,
        ) -> Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> {
            v0_1
        }
        pub fn method19(
            v0_1: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String>,
        ) -> Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> {
            v0_1
        }
        pub fn method20() -> string {
            string("fn")
        }
        pub fn method21(
            v0_1: pyo3::Bound<pyo3::types::PyModule>,
        ) -> pyo3::Bound<pyo3::types::PyModule> {
            v0_1
        }
        pub fn closure2(unitVar: (), v0_1: pyo3::PyErr) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method22() -> Func1<pyo3::PyErr, std::string::String> {
            Func1::new(move |v: pyo3::PyErr| Math::closure2((), v))
        }
        pub fn method23(
            v0_1: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr>,
        ) -> Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> {
            v0_1
        }
        pub fn method24(
            v0_1: Result<pyo3::Bound<pyo3::PyAny>, std::string::String>,
        ) -> Result<pyo3::Bound<pyo3::PyAny>, std::string::String> {
            v0_1
        }
        pub fn method25(
            v0_: bool,
            v0__1: LrcPtr<(f64, f64)>,
        ) -> LrcPtr<(bool, LrcPtr<(f64, f64)>)> {
            LrcPtr::new((v0_, v0__1))
        }
        pub fn method26(v0_1: pyo3::Bound<pyo3::PyAny>) -> pyo3::Bound<pyo3::PyAny> {
            v0_1
        }
        pub fn closure3(unitVar: (), v0_1: pyo3::PyErr) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method27() -> Func1<pyo3::PyErr, std::string::String> {
            Func1::new(move |v: pyo3::PyErr| Math::closure3((), v))
        }
        pub fn method28(v0_1: pyo3::Bound<pyo3::PyAny>) -> pyo3::Bound<pyo3::PyAny> {
            v0_1
        }
        pub fn closure4(unitVar: (), v0_1: pyo3::PyErr) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method29() -> Func1<pyo3::PyErr, std::string::String> {
            Func1::new(move |v: pyo3::PyErr| Math::closure4((), v))
        }
        pub fn method30(v0_1: Result<(f64, f64), pyo3::PyErr>) -> Result<(f64, f64), pyo3::PyErr> {
            v0_1
        }
        pub fn method31(v0_1: f64) -> f64 {
            v0_1
        }
        pub fn method32(v0_1: f64) -> f64 {
            v0_1
        }
        pub fn method9(
            v0_1: pyo3::Python,
            v1_1: string,
            v2: num_complex::Complex<f64>,
        ) -> Result<num_complex::Complex<f64>, std::string::String> {
            let v13: string =
                string("            args = { k: v for k, v in frame.f_locals.items() if frame.f_code.co_name != \'make_mpc\' and k not in [\'ctx\'] and not callable(v) }");
            let v14: string =
                string("            args_str = \', \'.join([ f\"{k}={re.sub(memory_address_pattern, \' at 0x<?>\', repr(v))}\" for k, v in args.items() ])");
            let v37: string =
                Math::method11(Math::method10(new_array(&[string("import sys"),
                                                          string("import traceback"),
                                                          string("import re"),
                                                          string("count = 0"),
                                                          string("memory_address_pattern = re.compile(r\' at 0x[0-9a-fA-F]+\')"),
                                                          string("def trace_calls(frame, event, arg):"),
                                                          string("    global count"),
                                                          string("    count += 1"),
                                                          string("    if count < 200:"),
                                                          string("        try:"),
                                                          v13, v14,
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
                                                          v1_1,
                                                          string("        if log:"),
                                                          string("            sys.settrace(None)"),
                                                          sprintf!("            print(f\'{} / result: {{s}} / count: {{count}}\', flush=True)",
                                                                   string("zeta_")),
                                                          string("    except ValueError as e:"),
                                                          string("        if s.real == 1:"),
                                                          string("            s = complex(float(\'inf\'), 0)"),
                                                          string("    return (s.real, s.imag)")])));
            let v38: num_complex::Complex<f64> = Math::method13(v2.clone());
            let v40: f64 = v38.re;
            let v41: num_complex::Complex<f64> = Math::method14(v2);
            let v45: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v40, v41.im))));
            let v46: pyo3::Python = Math::method15(v0_1);
            let v47: string = Math::method16(v37);
            let v49: &str = fable_library_rust::String_::LrcStr::as_str(&v47);
            let v51: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code_bound(v46, v49, "", "");
            let v52 = Math::method17();
            let v53: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> = Math::method18(v51);
            let v56: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                Math::method19(v53.map_err(|x| v52(x)));
            let v58: pyo3::Bound<pyo3::types::PyModule> = v56.unwrap();
            let v59: string = Math::method20();
            let v61: &str = fable_library_rust::String_::LrcStr::as_str(&v59);
            let v62: pyo3::Bound<pyo3::types::PyModule> = Math::method21(v58);
            let v64: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v62.getattr(v61);
            let v65 = Math::method22();
            let v66: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method23(v64);
            let v69: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> =
                Math::method24(v66.map_err(|x| v65(x)));
            let v71: pyo3::Bound<pyo3::PyAny> = v69.unwrap();
            let v72: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method25(v45.0.clone(), v45.1.clone());
            let v73: pyo3::Bound<pyo3::PyAny> = Math::method26(v71);
            let v75: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                pyo3::prelude::PyAnyMethods::call(&v73, ((*v72).0, *(*v72).1), None);
            let v76 = Math::method27();
            let v77: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method23(v75);
            let v79: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> =
                v77.map_err(|x| v76(x));
            let v82: pyo3::Bound<pyo3::PyAny> = Math::method28(v79?);
            let v84: Result<(f64, f64), pyo3::PyErr> = v82.extract();
            let v85 = Math::method29();
            let v86: Result<(f64, f64), pyo3::PyErr> = Math::method30(v84);
            let v88: Result<(f64, f64), std::string::String> = v86.map_err(|x| v85(x));
            let patternInput: (f64, f64) = v88?;
            let v93: f64 = Math::method3(Math::method31(patternInput.0.clone()));
            let v94: f64 = Math::method32(patternInput.1.clone());
            Ok::<num_complex::Complex<f64>, std::string::String>(num_complex::Complex::new(
                v93, v94,
            ))
        }
        pub fn method34(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method35() -> f64 {
            0.0_f64
        }
        pub fn method36(v0_1: LrcPtr<Math::Mut0>) -> bool {
            v0_1.l0.get().clone() < 10000_i32
        }
        pub fn method37(v0_1: i32, v1_1: LrcPtr<Math::Mut2>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method38() -> f64 {
            1.0_f64
        }
        pub fn method39(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method40(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method41(
            v0_1: pyo3::Python,
            v1_1: string,
            v2: num_complex::Complex<f64>,
        ) -> Result<num_complex::Complex<f64>, std::string::String> {
            let v13: string =
                string("            args = { k: v for k, v in frame.f_locals.items() if frame.f_code.co_name != \'make_mpc\' and k not in [\'ctx\'] and not callable(v) }");
            let v14: string =
                string("            args_str = \', \'.join([ f\"{k}={re.sub(memory_address_pattern, \' at 0x<?>\', repr(v))}\" for k, v in args.items() ])");
            let v37: string =
                Math::method11(Math::method10(new_array(&[string("import sys"),
                                                          string("import traceback"),
                                                          string("import re"),
                                                          string("count = 0"),
                                                          string("memory_address_pattern = re.compile(r\' at 0x[0-9a-fA-F]+\')"),
                                                          string("def trace_calls(frame, event, arg):"),
                                                          string("    global count"),
                                                          string("    count += 1"),
                                                          string("    if count < 200:"),
                                                          string("        try:"),
                                                          v13, v14,
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
                                                          v1_1,
                                                          string("        if log:"),
                                                          string("            sys.settrace(None)"),
                                                          sprintf!("            print(f\'{} / result: {{s}} / count: {{count}}\', flush=True)",
                                                                   string("gamma_")),
                                                          string("    except ValueError as e:"),
                                                          string("        if s.real == 1:"),
                                                          string("            s = complex(float(\'inf\'), 0)"),
                                                          string("    return (s.real, s.imag)")])));
            let v38: num_complex::Complex<f64> = Math::method13(v2.clone());
            let v40: f64 = v38.re;
            let v41: num_complex::Complex<f64> = Math::method14(v2);
            let v45: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v40, v41.im))));
            let v46: pyo3::Python = Math::method15(v0_1);
            let v47: string = Math::method16(v37);
            let v49: &str = fable_library_rust::String_::LrcStr::as_str(&v47);
            let v51: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                pyo3::types::PyModule::from_code_bound(v46, v49, "", "");
            let v52 = Math::method17();
            let v53: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> = Math::method18(v51);
            let v56: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                Math::method19(v53.map_err(|x| v52(x)));
            let v58: pyo3::Bound<pyo3::types::PyModule> = v56.unwrap();
            let v59: string = Math::method20();
            let v61: &str = fable_library_rust::String_::LrcStr::as_str(&v59);
            let v62: pyo3::Bound<pyo3::types::PyModule> = Math::method21(v58);
            let v64: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v62.getattr(v61);
            let v65 = Math::method22();
            let v66: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method23(v64);
            let v69: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> =
                Math::method24(v66.map_err(|x| v65(x)));
            let v71: pyo3::Bound<pyo3::PyAny> = v69.unwrap();
            let v72: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method25(v45.0.clone(), v45.1.clone());
            let v73: pyo3::Bound<pyo3::PyAny> = Math::method26(v71);
            let v75: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                pyo3::prelude::PyAnyMethods::call(&v73, ((*v72).0, *(*v72).1), None);
            let v76 = Math::method27();
            let v77: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method23(v75);
            let v79: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> =
                v77.map_err(|x| v76(x));
            let v82: pyo3::Bound<pyo3::PyAny> = Math::method28(v79?);
            let v84: Result<(f64, f64), pyo3::PyErr> = v82.extract();
            let v85 = Math::method29();
            let v86: Result<(f64, f64), pyo3::PyErr> = Math::method30(v84);
            let v88: Result<(f64, f64), std::string::String> = v86.map_err(|x| v85(x));
            let patternInput: (f64, f64) = v88?;
            let v93: f64 = Math::method3(Math::method31(patternInput.0.clone()));
            let v94: f64 = Math::method32(patternInput.1.clone());
            Ok::<num_complex::Complex<f64>, std::string::String>(num_complex::Complex::new(
                v93, v94,
            ))
        }
        pub fn closure5(unitVar: (), v0_1: num_complex::Complex<f64>) -> Math::US0 {
            Math::US0::US0_0(v0_1)
        }
        pub fn method42() -> f64 {
            3.141592653589793_f64
        }
        pub fn method33(
            v0_1: pyo3::Python,
            v1_1: num_complex::Complex<f64>,
        ) -> num_complex::Complex<f64> {
            let v2: num_complex::Complex<f64> = Math::method34(v1_1);
            println!("zeta / count: {:?} / s: {:?}", 0, v2);
            {
                let v4: num_complex::Complex<f64> = Math::method13(v2.clone());
                if v4.re > 1.0_f64 {
                    let v9: f64 = Math::method3(Math::method35());
                    let v10: f64 = Math::method4();
                    let v12: num_complex::Complex<f64> = num_complex::Complex::new(v9, v10);
                    let v13: Array<i32> = new_init(&0_i32, 10000_i32);
                    let v14: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                        l0: MutCell::new(0_i32),
                    });
                    while Math::method36(v14.clone()) {
                        let v16: i32 = v14.l0.get().clone();
                        v13.get_mut()[v16 as usize] = v16;
                        {
                            let v17: i32 = v16 + 1_i32;
                            v14.l0.set(v17);
                            ()
                        }
                    }
                    {
                        let v18: i32 = count(v13.clone());
                        let v19: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(v12),
                        });
                        while Math::method37(v18, v19.clone()) {
                            let v21: i32 = v19.l0.get().clone();
                            let v22: num_complex::Complex<f64> = v19.l1.get().clone();
                            let v23: i32 = v13[v21].clone();
                            let v25: f64 = Math::method3(Math::method38());
                            let v26: f64 = Math::method4();
                            let v28: num_complex::Complex<f64> =
                                num_complex::Complex::new(v25, v26);
                            let v31: f64 = Math::method3(Math::method31(v23 as f64));
                            let v32: f64 = Math::method4();
                            let v35: num_complex::Complex<f64> =
                                Math::method39(num_complex::Complex::new(v31, v32));
                            let v36: num_complex::Complex<f64> = Math::method40(v2.clone());
                            let v38: num_complex::Complex<f64> =
                                num_complex::Complex::powc(v35, v36);
                            let v40: num_complex::Complex<f64> = v28 / v38;
                            let v42: num_complex::Complex<f64> = v22 + v40;
                            let v43: i32 = v21 + 1_i32;
                            v19.l0.set(v43);
                            v19.l1.set(v42);
                            ()
                        }
                        v19.l1.get().clone()
                    }
                } else {
                    let v46: f64 = Math::method3(Math::method38());
                    let v47: f64 = Math::method4();
                    let v49: num_complex::Complex<f64> = num_complex::Complex::new(v46, v47);
                    let v54: Result<num_complex::Complex<f64>, std::string::String> =
                        Math::method41(
                            v0_1.clone(),
                            string("        s = mpmath.gamma(s)"),
                            Math::method8(v49 - v2),
                        );
                    let v57 = Func1::new(move |v: num_complex::Complex<f64>| Math::closure5((), v));
                    let v59: Math::US0 = defaultValue(Math::US0::US0_1, map(v57.clone(), v54.ok()));
                    let v61: f64 = f64::NAN;
                    let v63: f64 = f64::NAN;
                    let v65: f64 = Math::method3(Math::method31(v61));
                    let v66: f64 = Math::method32(v63);
                    let v68: num_complex::Complex<f64> = num_complex::Complex::new(v65, v66);
                    let v71: num_complex::Complex<f64> = match &v59 {
                        Math::US0::US0_0(v59_0_0) => match &v59 {
                            Math::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v68,
                    };
                    let v73: f64 = Math::method3(Math::method42());
                    let v74: f64 = Math::method4();
                    let v76: num_complex::Complex<f64> = num_complex::Complex::new(v73, v74);
                    let v78: num_complex::Complex<f64> = v76 * v2;
                    let v80: f64 = Math::method3(Math::method2());
                    let v81: f64 = Math::method4();
                    let v83: num_complex::Complex<f64> = num_complex::Complex::new(v80, v81);
                    let v85: num_complex::Complex<f64> = v78 / v83;
                    let v87: num_complex::Complex<f64> = v85.sin();
                    let v88: num_complex::Complex<f64> = Math::method13(v2.clone());
                    let v91: f64 = 1.0_f64 - v88.re;
                    let v92: num_complex::Complex<f64> = Math::method14(v2.clone());
                    let v95: f64 = -v92.im;
                    let v97: f64 = Math::method3(Math::method31(v91));
                    let v98: f64 = Math::method32(v95);
                    let v100: num_complex::Complex<f64> = num_complex::Complex::new(v97, v98);
                    let v101: num_complex::Complex<f64> = Math::method13(v100.clone());
                    let v634: num_complex::Complex<f64> = if v101.re <= 1.0_f64 {
                        let v106: f64 = Math::method3(Math::method35());
                        let v107: f64 = Math::method4();
                        num_complex::Complex::new(v106, v107)
                    } else {
                        let v110: num_complex::Complex<f64> = Math::method34(v100);
                        println!("zeta / count: {:?} / s: {:?}", 1, v110);
                        {
                            let v112: num_complex::Complex<f64> = Math::method13(v110.clone());
                            if v112.re > 1.0_f64 {
                                let v117: f64 = Math::method3(Math::method35());
                                let v118: f64 = Math::method4();
                                let v120: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v117, v118);
                                let v121: Array<i32> = new_init(&0_i32, 10000_i32);
                                let v122: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Math::method36(v122.clone()) {
                                    let v124: i32 = v122.l0.get().clone();
                                    v121.get_mut()[v124 as usize] = v124;
                                    {
                                        let v125: i32 = v124 + 1_i32;
                                        v122.l0.set(v125);
                                        ()
                                    }
                                }
                                {
                                    let v126: i32 = count(v121.clone());
                                    let v127: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                        l0: MutCell::new(0_i32),
                                        l1: MutCell::new(v120),
                                    });
                                    while Math::method37(v126, v127.clone()) {
                                        let v129: i32 = v127.l0.get().clone();
                                        let v130: num_complex::Complex<f64> = v127.l1.get().clone();
                                        let v131: i32 = v121[v129].clone();
                                        let v133: f64 = Math::method3(Math::method38());
                                        let v134: f64 = Math::method4();
                                        let v136: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v133, v134);
                                        let v139: f64 = Math::method3(Math::method31(v131 as f64));
                                        let v140: f64 = Math::method4();
                                        let v143: num_complex::Complex<f64> =
                                            Math::method39(num_complex::Complex::new(v139, v140));
                                        let v144: num_complex::Complex<f64> =
                                            Math::method40(v110.clone());
                                        let v146: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v143, v144);
                                        let v148: num_complex::Complex<f64> = v136 / v146;
                                        let v150: num_complex::Complex<f64> = v130 + v148;
                                        let v151: i32 = v129 + 1_i32;
                                        v127.l0.set(v151);
                                        v127.l1.set(v150);
                                        ()
                                    }
                                    v127.l1.get().clone()
                                }
                            } else {
                                let v154: f64 = Math::method3(Math::method38());
                                let v155: f64 = Math::method4();
                                let v157: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v154, v155);
                                let v162: Result<num_complex::Complex<f64>, std::string::String> =
                                    Math::method41(
                                        v0_1.clone(),
                                        string("        s = mpmath.gamma(s)"),
                                        Math::method8(v157 - v110),
                                    );
                                let v166: Math::US0 =
                                    defaultValue(Math::US0::US0_1, map(v57.clone(), v162.ok()));
                                let v168: f64 = f64::NAN;
                                let v170: f64 = f64::NAN;
                                let v172: f64 = Math::method3(Math::method31(v168));
                                let v173: f64 = Math::method32(v170);
                                let v175: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v172, v173);
                                let v178: num_complex::Complex<f64> = match &v166 {
                                    Math::US0::US0_0(v166_0_0) => match &v166 {
                                        Math::US0::US0_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => v175,
                                };
                                let v180: f64 = Math::method3(Math::method42());
                                let v181: f64 = Math::method4();
                                let v183: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v180, v181);
                                let v185: num_complex::Complex<f64> = v183 * v110;
                                let v187: f64 = Math::method3(Math::method2());
                                let v188: f64 = Math::method4();
                                let v190: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v187, v188);
                                let v192: num_complex::Complex<f64> = v185 / v190;
                                let v194: num_complex::Complex<f64> = v192.sin();
                                let v195: num_complex::Complex<f64> = Math::method13(v110.clone());
                                let v198: f64 = 1.0_f64 - v195.re;
                                let v199: num_complex::Complex<f64> = Math::method14(v110.clone());
                                let v202: f64 = -v199.im;
                                let v204: f64 = Math::method3(Math::method31(v198));
                                let v205: f64 = Math::method32(v202);
                                let v207: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v204, v205);
                                let v208: num_complex::Complex<f64> = Math::method13(v207.clone());
                                let v610: num_complex::Complex<f64> = if v208.re <= 1.0_f64 {
                                    let v213: f64 = Math::method3(Math::method35());
                                    let v214: f64 = Math::method4();
                                    num_complex::Complex::new(v213, v214)
                                } else {
                                    let v217: num_complex::Complex<f64> = Math::method34(v207);
                                    println!("zeta / count: {:?} / s: {:?}", 2, v217);
                                    {
                                        let v219: num_complex::Complex<f64> =
                                            Math::method13(v217.clone());
                                        if v219.re > 1.0_f64 {
                                            let v224: f64 = Math::method3(Math::method35());
                                            let v225: f64 = Math::method4();
                                            let v227: num_complex::Complex<f64> =
                                                num_complex::Complex::new(v224, v225);
                                            let v228: Array<i32> = new_init(&0_i32, 10000_i32);
                                            let v229: LrcPtr<Math::Mut0> =
                                                LrcPtr::new(Math::Mut0 {
                                                    l0: MutCell::new(0_i32),
                                                });
                                            while Math::method36(v229.clone()) {
                                                let v231: i32 = v229.l0.get().clone();
                                                v228.get_mut()[v231 as usize] = v231;
                                                {
                                                    let v232: i32 = v231 + 1_i32;
                                                    v229.l0.set(v232);
                                                    ()
                                                }
                                            }
                                            {
                                                let v233: i32 = count(v228.clone());
                                                let v234: LrcPtr<Math::Mut2> =
                                                    LrcPtr::new(Math::Mut2 {
                                                        l0: MutCell::new(0_i32),
                                                        l1: MutCell::new(v227),
                                                    });
                                                while Math::method37(v233, v234.clone()) {
                                                    let v236: i32 = v234.l0.get().clone();
                                                    let v237: num_complex::Complex<f64> =
                                                        v234.l1.get().clone();
                                                    let v238: i32 = v228[v236].clone();
                                                    let v240: f64 = Math::method3(Math::method38());
                                                    let v241: f64 = Math::method4();
                                                    let v243: num_complex::Complex<f64> =
                                                        num_complex::Complex::new(v240, v241);
                                                    let v246: f64 =
                                                        Math::method3(Math::method31(v238 as f64));
                                                    let v247: f64 = Math::method4();
                                                    let v250: num_complex::Complex<f64> =
                                                        Math::method39(num_complex::Complex::new(
                                                            v246, v247,
                                                        ));
                                                    let v251: num_complex::Complex<f64> =
                                                        Math::method40(v217.clone());
                                                    let v253: num_complex::Complex<f64> =
                                                        num_complex::Complex::powc(v250, v251);
                                                    let v255: num_complex::Complex<f64> =
                                                        v243 / v253;
                                                    let v257: num_complex::Complex<f64> =
                                                        v237 + v255;
                                                    let v258: i32 = v236 + 1_i32;
                                                    v234.l0.set(v258);
                                                    v234.l1.set(v257);
                                                    ()
                                                }
                                                v234.l1.get().clone()
                                            }
                                        } else {
                                            let v261: f64 = Math::method3(Math::method38());
                                            let v262: f64 = Math::method4();
                                            let v264: num_complex::Complex<f64> =
                                                num_complex::Complex::new(v261, v262);
                                            let v269: Result<
                                                num_complex::Complex<f64>,
                                                std::string::String,
                                            > = Math::method41(
                                                v0_1.clone(),
                                                string("        s = mpmath.gamma(s)"),
                                                Math::method8(v264 - v217),
                                            );
                                            let v273: Math::US0 = defaultValue(
                                                Math::US0::US0_1,
                                                map(v57.clone(), v269.ok()),
                                            );
                                            let v275: f64 = f64::NAN;
                                            let v277: f64 = f64::NAN;
                                            let v279: f64 = Math::method3(Math::method31(v275));
                                            let v280: f64 = Math::method32(v277);
                                            let v282: num_complex::Complex<f64> =
                                                num_complex::Complex::new(v279, v280);
                                            let v285: num_complex::Complex<f64> = match &v273 {
                                                Math::US0::US0_0(v273_0_0) => match &v273 {
                                                    Math::US0::US0_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                },
                                                _ => v282,
                                            };
                                            let v287: f64 = Math::method3(Math::method42());
                                            let v288: f64 = Math::method4();
                                            let v290: num_complex::Complex<f64> =
                                                num_complex::Complex::new(v287, v288);
                                            let v292: num_complex::Complex<f64> = v290 * v217;
                                            let v294: f64 = Math::method3(Math::method2());
                                            let v295: f64 = Math::method4();
                                            let v297: num_complex::Complex<f64> =
                                                num_complex::Complex::new(v294, v295);
                                            let v299: num_complex::Complex<f64> = v292 / v297;
                                            let v301: num_complex::Complex<f64> = v299.sin();
                                            let v302: num_complex::Complex<f64> =
                                                Math::method13(v217.clone());
                                            let v305: f64 = 1.0_f64 - v302.re;
                                            let v306: num_complex::Complex<f64> =
                                                Math::method14(v217.clone());
                                            let v309: f64 = -v306.im;
                                            let v311: f64 = Math::method3(Math::method31(v305));
                                            let v312: f64 = Math::method32(v309);
                                            let v314: num_complex::Complex<f64> =
                                                num_complex::Complex::new(v311, v312);
                                            let v315: num_complex::Complex<f64> =
                                                Math::method13(v314.clone());
                                            let v586: num_complex::Complex<f64> = if v315.re
                                                <= 1.0_f64
                                            {
                                                let v320: f64 = Math::method3(Math::method35());
                                                let v321: f64 = Math::method4();
                                                num_complex::Complex::new(v320, v321)
                                            } else {
                                                let v324: num_complex::Complex<f64> =
                                                    Math::method34(v314);
                                                println!("zeta / count: {:?} / s: {:?}", 3, v324);
                                                {
                                                    let v326: num_complex::Complex<f64> =
                                                        Math::method13(v324.clone());
                                                    if v326.re > 1.0_f64 {
                                                        let v331: f64 =
                                                            Math::method3(Math::method35());
                                                        let v332: f64 = Math::method4();
                                                        let v334: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(v331, v332);
                                                        let v335: Array<i32> =
                                                            new_init(&0_i32, 10000_i32);
                                                        let v336: LrcPtr<Math::Mut0> =
                                                            LrcPtr::new(Math::Mut0 {
                                                                l0: MutCell::new(0_i32),
                                                            });
                                                        while Math::method36(v336.clone()) {
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
                                                            while Math::method37(v340, v341.clone())
                                                            {
                                                                let v343: i32 =
                                                                    v341.l0.get().clone();
                                                                let v344: num_complex::Complex<
                                                                    f64,
                                                                > = v341.l1.get().clone();
                                                                let v345: i32 = v335[v343].clone();
                                                                let v347: f64 =
                                                                    Math::method3(Math::method38());
                                                                let v348: f64 = Math::method4();
                                                                let v350: num_complex::Complex<
                                                                    f64,
                                                                > = num_complex::Complex::new(
                                                                    v347, v348,
                                                                );
                                                                let v353: f64 = Math::method3(
                                                                    Math::method31(v345 as f64),
                                                                );
                                                                let v354: f64 = Math::method4();
                                                                let v357: num_complex::Complex<
                                                                    f64,
                                                                > = Math::method39(
                                                                    num_complex::Complex::new(
                                                                        v353, v354,
                                                                    ),
                                                                );
                                                                let v358: num_complex::Complex<
                                                                    f64,
                                                                > = Math::method40(v324.clone());
                                                                let v360: num_complex::Complex<
                                                                    f64,
                                                                > = num_complex::Complex::powc(
                                                                    v357, v358,
                                                                );
                                                                let v362: num_complex::Complex<
                                                                    f64,
                                                                > = v350 / v360;
                                                                let v364: num_complex::Complex<
                                                                    f64,
                                                                > = v344 + v362;
                                                                let v365: i32 = v343 + 1_i32;
                                                                v341.l0.set(v365);
                                                                v341.l1.set(v364);
                                                                ()
                                                            }
                                                            v341.l1.get().clone()
                                                        }
                                                    } else {
                                                        let v368: f64 =
                                                            Math::method3(Math::method38());
                                                        let v369: f64 = Math::method4();
                                                        let v371: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(v368, v369);
                                                        let v376: Result<
                                                            num_complex::Complex<f64>,
                                                            std::string::String,
                                                        > = Math::method41(
                                                            v0_1.clone(),
                                                            string("        s = mpmath.gamma(s)"),
                                                            Math::method8(v371 - v324),
                                                        );
                                                        let v380: Math::US0 = defaultValue(
                                                            Math::US0::US0_1,
                                                            map(v57.clone(), v376.ok()),
                                                        );
                                                        let v382: f64 = f64::NAN;
                                                        let v384: f64 = f64::NAN;
                                                        let v386: f64 =
                                                            Math::method3(Math::method31(v382));
                                                        let v387: f64 = Math::method32(v384);
                                                        let v389: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(v386, v387);
                                                        let v392: num_complex::Complex<f64> =
                                                            match &v380 {
                                                                Math::US0::US0_0(v380_0_0) => {
                                                                    match &v380 {
                                                                        Math::US0::US0_0(x) => {
                                                                            x.clone()
                                                                        }
                                                                        _ => unreachable!(),
                                                                    }
                                                                }
                                                                _ => v389,
                                                            };
                                                        let v394: f64 =
                                                            Math::method3(Math::method42());
                                                        let v395: f64 = Math::method4();
                                                        let v397: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(v394, v395);
                                                        let v399: num_complex::Complex<f64> =
                                                            v397 * v324;
                                                        let v401: f64 =
                                                            Math::method3(Math::method2());
                                                        let v402: f64 = Math::method4();
                                                        let v404: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(v401, v402);
                                                        let v406: num_complex::Complex<f64> =
                                                            v399 / v404;
                                                        let v408: num_complex::Complex<f64> =
                                                            v406.sin();
                                                        let v409: num_complex::Complex<f64> =
                                                            Math::method13(v324.clone());
                                                        let v412: f64 = 1.0_f64 - v409.re;
                                                        let v413: num_complex::Complex<f64> =
                                                            Math::method14(v324.clone());
                                                        let v416: f64 = -v413.im;
                                                        let v418: f64 =
                                                            Math::method3(Math::method31(v412));
                                                        let v419: f64 = Math::method32(v416);
                                                        let v421: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(v418, v419);
                                                        let v422: num_complex::Complex<f64> =
                                                            Math::method13(v421.clone());
                                                        let v562: num_complex::Complex<f64> =
                                                            if v422.re <= 1.0_f64 {
                                                                let v427: f64 =
                                                                    Math::method3(Math::method35());
                                                                let v428: f64 = Math::method4();
                                                                num_complex::Complex::new(
                                                                    v427, v428,
                                                                )
                                                            } else {
                                                                let v431: num_complex::Complex<
                                                                    f64,
                                                                > = Math::method34(v421);
                                                                println!(
                                                                    "zeta / count: {:?} / s: {:?}",
                                                                    4, v431
                                                                );
                                                                {
                                                                    let v433: num_complex::Complex<
                                                                        f64,
                                                                    > = Math::method13(
                                                                        v431.clone(),
                                                                    );
                                                                    if v433.re > 1.0_f64 {
                                                                        let v438: f64 =
                                                                            Math::method3(
                                                                                Math::method35(),
                                                                            );
                                                                        let v439: f64 =
                                                                            Math::method4();
                                                                        let v441:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(v438, v439);
                                                                        let v442: Array<i32> =
                                                                            new_init(
                                                                                &0_i32, 10000_i32,
                                                                            );
                                                                        let v443: LrcPtr<
                                                                            Math::Mut0,
                                                                        > = LrcPtr::new(
                                                                            Math::Mut0 {
                                                                                l0: MutCell::new(
                                                                                    0_i32,
                                                                                ),
                                                                            },
                                                                        );
                                                                        while Math::method36(
                                                                            v443.clone(),
                                                                        ) {
                                                                            let v445: i32 = v443
                                                                                .l0
                                                                                .get()
                                                                                .clone();
                                                                            v442.get_mut()
                                                                                [v445 as usize] =
                                                                                v445;
                                                                            {
                                                                                let v446: i32 =
                                                                                    v445 + 1_i32;
                                                                                v443.l0.set(v446);
                                                                                ()
                                                                            }
                                                                        }
                                                                        {
                                                                            let v447: i32 =
                                                                                count(v442.clone());
                                                                            let v448: LrcPtr<
                                                                                Math::Mut2,
                                                                            > = LrcPtr::new(
                                                                                Math::Mut2 {
                                                                                    l0:
                                                                                        MutCell::new(
                                                                                            0_i32,
                                                                                        ),
                                                                                    l1:
                                                                                        MutCell::new(
                                                                                            v441,
                                                                                        ),
                                                                                },
                                                                            );
                                                                            while Math::method37(
                                                                                v447,
                                                                                v448.clone(),
                                                                            ) {
                                                                                let v450: i32 =
                                                                                    v448.l0
                                                                                        .get()
                                                                                        .clone();
                                                                                let v451:
                                                                                                    num_complex::Complex<f64> =
                                                                                                v448.l1.get().clone();
                                                                                let v452: i32 =
                                                                                    v442[v450]
                                                                                        .clone();
                                                                                let v454:
                                                                                                    f64 =
                                                                                                Math::method3(Math::method38());
                                                                                let v455: f64 =
                                                                                    Math::method4();
                                                                                let v457:
                                                                                                    num_complex::Complex<f64> =
                                                                                                num_complex::Complex::new(v454, v455);
                                                                                let v460:
                                                                                                    f64 =
                                                                                                Math::method3(Math::method31(v452
                                                                                                                                 as
                                                                                                                                 f64));
                                                                                let v461: f64 =
                                                                                    Math::method4();
                                                                                let v464:
                                                                                                    num_complex::Complex<f64> =
                                                                                                Math::method39(num_complex::Complex::new(v460, v461));
                                                                                let v465:
                                                                                                    num_complex::Complex<f64> =
                                                                                                Math::method40(v431.clone());
                                                                                let v467:
                                                                                                    num_complex::Complex<f64> =
                                                                                                num_complex::Complex::powc(v464, v465);
                                                                                let v469:
                                                                                                    num_complex::Complex<f64> =
                                                                                                v457 / v467;
                                                                                let v471:
                                                                                                    num_complex::Complex<f64> =
                                                                                                v451 + v469;
                                                                                let v472: i32 =
                                                                                    v450 + 1_i32;
                                                                                v448.l0.set(v472);
                                                                                v448.l1.set(v471);
                                                                                ()
                                                                            }
                                                                            v448.l1.get().clone()
                                                                        }
                                                                    } else {
                                                                        let v475: f64 =
                                                                            Math::method3(
                                                                                Math::method38(),
                                                                            );
                                                                        let v476: f64 =
                                                                            Math::method4();
                                                                        let v478:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(v475, v476);
                                                                        let v483:
                                                                                            Result<num_complex::Complex<f64>,
                                                                                                   std::string::String> =
                                                                                        Math::method41(v0_1,
                                                                                                       string("        s = mpmath.gamma(s)"),
                                                                                                       Math::method8(v478 - v431));
                                                                        let v487: Math::US0 =
                                                                            defaultValue(
                                                                                Math::US0::US0_1,
                                                                                map(v57, v483.ok()),
                                                                            );
                                                                        let v489: f64 = f64::NAN;
                                                                        let v491: f64 = f64::NAN;
                                                                        let v493: f64 =
                                                                            Math::method3(
                                                                                Math::method31(
                                                                                    v489,
                                                                                ),
                                                                            );
                                                                        let v494: f64 =
                                                                            Math::method32(v491);
                                                                        let v496:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(v493, v494);
                                                                        let v499:
                                                                                            num_complex::Complex<f64> =
                                                                                        match &v487
                                                                                            {
                                                                                            Math::US0::US0_0(v487_0_0)
                                                                                            =>
                                                                                            match &v487
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
                                                                                            v496,
                                                                                        };
                                                                        let v501: f64 =
                                                                            Math::method3(
                                                                                Math::method42(),
                                                                            );
                                                                        let v502: f64 =
                                                                            Math::method4();
                                                                        let v504:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(v501, v502);
                                                                        let v506:
                                                                                            num_complex::Complex<f64> =
                                                                                        v504 * v431;
                                                                        let v508: f64 =
                                                                            Math::method3(
                                                                                Math::method2(),
                                                                            );
                                                                        let v509: f64 =
                                                                            Math::method4();
                                                                        let v511:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(v508, v509);
                                                                        let v513:
                                                                                            num_complex::Complex<f64> =
                                                                                        v506 / v511;
                                                                        let v515:
                                                                                            num_complex::Complex<f64> =
                                                                                        v513.sin();
                                                                        let v516:
                                                                                            num_complex::Complex<f64> =
                                                                                        Math::method13(v431.clone());
                                                                        let v519: f64 =
                                                                            1.0_f64 - v516.re;
                                                                        let v520:
                                                                                            num_complex::Complex<f64> =
                                                                                        Math::method14(v431.clone());
                                                                        let v523: f64 = -v520.im;
                                                                        let v525: f64 =
                                                                            Math::method3(
                                                                                Math::method31(
                                                                                    v519,
                                                                                ),
                                                                            );
                                                                        let v526: f64 =
                                                                            Math::method32(v523);
                                                                        let v528:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(v525, v526);
                                                                        let v529:
                                                                                            num_complex::Complex<f64> =
                                                                                        Math::method13(v528.clone());
                                                                        let v538:
                                                                                            num_complex::Complex<f64> =
                                                                                        if v529.re
                                                                                               <=
                                                                                               1.0_f64
                                                                                           {
                                                                                            let v534:
                                                                                                    f64 =
                                                                                                Math::method3(Math::method35());
                                                                                            let v535:
                                                                                                    f64 =
                                                                                                Math::method4();
                                                                                            num_complex::Complex::new(v534, v535)
                                                                                        } else {
                                                                                            v528
                                                                                        };
                                                                        let v540: f64 =
                                                                            Math::method3(
                                                                                Math::method2(),
                                                                            );
                                                                        let v541: f64 =
                                                                            Math::method4();
                                                                        let v543:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(v540, v541);
                                                                        let v545: f64 =
                                                                            Math::method3(
                                                                                Math::method42(),
                                                                            );
                                                                        let v546: f64 =
                                                                            Math::method4();
                                                                        let v549:
                                                                                            num_complex::Complex<f64> =
                                                                                        Math::method39(num_complex::Complex::new(v545, v546));
                                                                        let v550:
                                                                                            num_complex::Complex<f64> =
                                                                                        Math::method40(v431.clone());
                                                                        let v552:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::powc(v549, v550);
                                                                        let v554:
                                                                                            num_complex::Complex<f64> =
                                                                                        v543 * v552;
                                                                        let v556:
                                                                                            num_complex::Complex<f64> =
                                                                                        v554 * v515;
                                                                        let v558:
                                                                                            num_complex::Complex<f64> =
                                                                                        v556 * v499;
                                                                        v558 * v538
                                                                    }
                                                                }
                                                            };
                                                        let v564: f64 =
                                                            Math::method3(Math::method2());
                                                        let v565: f64 = Math::method4();
                                                        let v567: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(v564, v565);
                                                        let v569: f64 =
                                                            Math::method3(Math::method42());
                                                        let v570: f64 = Math::method4();
                                                        let v573: num_complex::Complex<f64> =
                                                            Math::method39(
                                                                num_complex::Complex::new(
                                                                    v569, v570,
                                                                ),
                                                            );
                                                        let v574: num_complex::Complex<f64> =
                                                            Math::method40(v324.clone());
                                                        let v576: num_complex::Complex<f64> =
                                                            num_complex::Complex::powc(v573, v574);
                                                        let v578: num_complex::Complex<f64> =
                                                            v567 * v576;
                                                        let v580: num_complex::Complex<f64> =
                                                            v578 * v408;
                                                        let v582: num_complex::Complex<f64> =
                                                            v580 * v392;
                                                        v582 * v562
                                                    }
                                                }
                                            };
                                            let v588: f64 = Math::method3(Math::method2());
                                            let v589: f64 = Math::method4();
                                            let v591: num_complex::Complex<f64> =
                                                num_complex::Complex::new(v588, v589);
                                            let v593: f64 = Math::method3(Math::method42());
                                            let v594: f64 = Math::method4();
                                            let v597: num_complex::Complex<f64> = Math::method39(
                                                num_complex::Complex::new(v593, v594),
                                            );
                                            let v598: num_complex::Complex<f64> =
                                                Math::method40(v217.clone());
                                            let v600: num_complex::Complex<f64> =
                                                num_complex::Complex::powc(v597, v598);
                                            let v602: num_complex::Complex<f64> = v591 * v600;
                                            let v604: num_complex::Complex<f64> = v602 * v301;
                                            let v606: num_complex::Complex<f64> = v604 * v285;
                                            v606 * v586
                                        }
                                    }
                                };
                                let v612: f64 = Math::method3(Math::method2());
                                let v613: f64 = Math::method4();
                                let v615: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v612, v613);
                                let v617: f64 = Math::method3(Math::method42());
                                let v618: f64 = Math::method4();
                                let v621: num_complex::Complex<f64> =
                                    Math::method39(num_complex::Complex::new(v617, v618));
                                let v622: num_complex::Complex<f64> = Math::method40(v110.clone());
                                let v624: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v621, v622);
                                let v626: num_complex::Complex<f64> = v615 * v624;
                                let v628: num_complex::Complex<f64> = v626 * v194;
                                let v630: num_complex::Complex<f64> = v628 * v178;
                                v630 * v610
                            }
                        }
                    };
                    let v636: f64 = Math::method3(Math::method2());
                    let v637: f64 = Math::method4();
                    let v639: num_complex::Complex<f64> = num_complex::Complex::new(v636, v637);
                    let v641: f64 = Math::method3(Math::method42());
                    let v642: f64 = Math::method4();
                    let v645: num_complex::Complex<f64> =
                        Math::method39(num_complex::Complex::new(v641, v642));
                    let v646: num_complex::Complex<f64> = Math::method40(v2.clone());
                    let v648: num_complex::Complex<f64> = num_complex::Complex::powc(v645, v646);
                    let v650: num_complex::Complex<f64> = v639 * v648;
                    let v652: num_complex::Complex<f64> = v650 * v87;
                    let v654: num_complex::Complex<f64> = v652 * v71;
                    v654 * v634
                }
            }
        }
        pub fn method43(v0_1: bool) -> bool {
            v0_1
        }
        pub fn method1(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method2());
            let v3: f64 = Math::method4();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v7: f64 = Math::method3(Math::method5());
            let v8: f64 = Math::method4();
            let v12: Array<(num_complex::Complex<f64>, f64)> = Math::method6(new_array(&[
                (v5, 1.6449340668482264_f64),
                (num_complex::Complex::new(v7, v8), -0.08333333333333333_f64),
            ]));
            let v13: i32 = count(v12.clone());
            let v14: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method7(v13, v14.clone()) {
                let v16: i32 = v14.l0.get().clone();
                let patternInput: (num_complex::Complex<f64>, f64) = v12[v16].clone();
                let v17: num_complex::Complex<f64> = patternInput.0.clone();
                let v21: Result<num_complex::Complex<f64>, std::string::String> = Math::method9(
                    v0_1.clone(),
                    string("        s = mpmath.zeta(s)"),
                    Math::method8(v17.clone()),
                );
                let v22: num_complex::Complex<f64> = Math::method33(v0_1.clone(), v17);
                let v27: Math::US0 = defaultValue(
                    Math::US0::US0_1,
                    map(
                        Func1::new(move |v: num_complex::Complex<f64>| Math::closure5((), v)),
                        v21.ok(),
                    ),
                );
                let v29: f64 = f64::NAN;
                let v31: f64 = f64::NAN;
                let v33: f64 = Math::method3(Math::method31(v29));
                let v34: f64 = Math::method32(v31);
                let v36: num_complex::Complex<f64> = num_complex::Complex::new(v33, v34);
                let v39: num_complex::Complex<f64> = match &v27 {
                    Math::US0::US0_0(v27_0_0) => match &v27 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v36,
                };
                let v40: num_complex::Complex<f64> = Math::method14(v39.clone());
                let v42: f64 = v40.im;
                let v43: string = sprintf!("{:?}", v42);
                printfn!("{0}", v43);
                {
                    let v44: bool = v42 == 0.0_f64;
                    if (if v44 { true } else { Math::method43(v44) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v42, 0.0_f64),
                        );
                    }
                    {
                        let v49: num_complex::Complex<f64> = Math::method13(v39);
                        let v52: f64 = v49.re - patternInput.1.clone();
                        let v53: f64 = -v52;
                        let v55: f64 = if v52 >= v53 { v52 } else { v53 };
                        let v56: string = sprintf!("{:?}", v55);
                        printfn!("{0}", v56);
                        {
                            let v57: bool = v55 < 0.0001_f64;
                            if (if v57 { true } else { Math::method43(v57) }) == false {
                                panic!(
                                    "{}",
                                    sprintf!(
                                        "__expect / actual: {:?} / expected: {:?}",
                                        v55,
                                        0.0001_f64
                                    ),
                                );
                            }
                            {
                                let v62: i32 = v16 + 1_i32;
                                v14.l0.set(v62);
                                ()
                            }
                        }
                    }
                }
            }
            ()
        }
        pub fn method44(v0_1: Result<(), pyo3::PyErr>) -> Result<(), pyo3::PyErr> {
            v0_1
        }
        pub fn method45(v0_1: Result<(), pyo3::PyErr>) -> Result<(), pyo3::PyErr> {
            v0_1
        }
        pub fn method0() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method1(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method44(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method45(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method48() -> f64 {
            -2.0_f64
        }
        pub fn method47(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method2());
            let v3: f64 = Math::method48();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v8: Result<num_complex::Complex<f64>, std::string::String> = Math::method9(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method8(v5.clone()),
            );
            let v9: num_complex::Complex<f64> = Math::method33(v0_1, v5);
            let v14: Math::US0 = defaultValue(
                Math::US0::US0_1,
                map(
                    Func1::new(move |v: num_complex::Complex<f64>| Math::closure5((), v)),
                    v8.ok(),
                ),
            );
            let v16: f64 = f64::NAN;
            let v18: f64 = f64::NAN;
            let v20: f64 = Math::method3(Math::method31(v16));
            let v21: f64 = Math::method32(v18);
            let v23: num_complex::Complex<f64> = num_complex::Complex::new(v20, v21);
            let v26: num_complex::Complex<f64> = match &v14 {
                Math::US0::US0_0(v14_0_0) => match &v14 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v23,
            };
            let v27: num_complex::Complex<f64> = Math::method13(v26.clone());
            let v30: f64 = v27.re - 0.8673_f64;
            let v31: f64 = -v30;
            let v33: f64 = if v30 >= v31 { v30 } else { v31 };
            let v34: string = sprintf!("{:?}", v33);
            printfn!("{0}", v34);
            {
                let v35: bool = v33 < 0.001_f64;
                if (if v35 { true } else { Math::method43(v35) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v33, 0.001_f64),
                    );
                }
                {
                    let v40: num_complex::Complex<f64> = Math::method14(v26);
                    let v43: f64 = v40.im - 0.275_f64;
                    let v44: f64 = -v43;
                    let v46: f64 = if v43 >= v44 { v43 } else { v44 };
                    let v47: string = sprintf!("{:?}", v46);
                    printfn!("{0}", v47);
                    {
                        let v48: bool = v46 < 0.001_f64;
                        if (if v48 { true } else { Math::method43(v48) }) == false {
                            panic!(
                                "{}",
                                sprintf!(
                                    "__expect / actual: {:?} / expected: {:?}",
                                    v46,
                                    0.001_f64
                                ),
                            );
                        }
                    }
                }
            }
        }
        pub fn method46() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method47(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method44(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method45(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method51() -> LrcPtr<Math::UH0> {
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
        pub fn method52(v0_1: pyo3::Python, v1_1: LrcPtr<Math::UH0>) {
            let v0_1: MutCell<pyo3::Python> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1_1.clone());
            '_method52: loop {
                break '_method52 (match v1_1.get().clone().as_ref() {
                    Math::UH0::UH0_0 => (),
                    Math::UH0::UH0_1(v1_1_1_0, v1_1_1_1) => {
                        let v5: f64 =
                            Math::method3(Math::method31(match v1_1.get().clone().as_ref() {
                                Math::UH0::UH0_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            }));
                        let v6: f64 = Math::method4();
                        let v8: num_complex::Complex<f64> = num_complex::Complex::new(v5, v6);
                        let v11: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method9(
                                v0_1.get().clone(),
                                string("        s = mpmath.zeta(s)"),
                                Math::method8(v8.clone()),
                            );
                        let v12: num_complex::Complex<f64> = Math::method33(v0_1.get().clone(), v8);
                        let v17: Math::US0 = defaultValue(
                            Math::US0::US0_1,
                            map(
                                Func1::new(move |v: num_complex::Complex<f64>| {
                                    Math::closure5((), v)
                                }),
                                v11.ok(),
                            ),
                        );
                        let v19: f64 = f64::NAN;
                        let v21: f64 = f64::NAN;
                        let v23: f64 = Math::method3(Math::method31(v19));
                        let v24: f64 = Math::method32(v21);
                        let v26: num_complex::Complex<f64> = num_complex::Complex::new(v23, v24);
                        let v29: num_complex::Complex<f64> = match &v17 {
                            Math::US0::US0_0(v17_0_0) => match &v17 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v26,
                        };
                        let v30: num_complex::Complex<f64> = Math::method13(v29.clone());
                        let v32: f64 = v30.re;
                        let v33: string = sprintf!("{:?}", v32);
                        printfn!("{0}", v33);
                        {
                            let v34: bool = v32 == 0.0_f64;
                            if (if v34 { true } else { Math::method43(v34) }) == false {
                                panic!(
                                    "{}",
                                    sprintf!(
                                        "__expect / actual: {:?} / expected: {:?}",
                                        v32,
                                        0.0_f64
                                    ),
                                );
                            }
                            {
                                let v39: num_complex::Complex<f64> = Math::method14(v29);
                                let v41: f64 = v39.im;
                                let v42: string = sprintf!("{:?}", v41);
                                printfn!("{0}", v42);
                                {
                                    let v43: bool = v41 == 0.0_f64;
                                    if (if v43 { true } else { Math::method43(v43) }) == false {
                                        panic!(
                                            "{}",
                                            sprintf!(
                                                "__expect / actual: {:?} / expected: {:?}",
                                                v41,
                                                0.0_f64
                                            ),
                                        );
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
                                        continue '_method52;
                                    }
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method50(v0_1: pyo3::Python) {
            Math::method52(v0_1, Math::method51());
        }
        pub fn method49() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method50(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method44(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method45(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method55() -> f64 {
            0.5_f64
        }
        pub fn method56() -> f64 {
            14.134725_f64
        }
        pub fn method57() -> f64 {
            21.02204_f64
        }
        pub fn method58() -> f64 {
            25.010857_f64
        }
        pub fn method59() -> f64 {
            30.424876_f64
        }
        pub fn method60() -> f64 {
            32.935062_f64
        }
        pub fn method61() -> f64 {
            37.586178_f64
        }
        pub fn method62(
            v0_1: Array<num_complex::Complex<f64>>,
        ) -> Array<num_complex::Complex<f64>> {
            v0_1
        }
        pub fn method54(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method55());
            let v3: f64 = Math::method56();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v7: f64 = Math::method3(Math::method55());
            let v8: f64 = Math::method57();
            let v10: num_complex::Complex<f64> = num_complex::Complex::new(v7, v8);
            let v12: f64 = Math::method3(Math::method55());
            let v13: f64 = Math::method58();
            let v15: num_complex::Complex<f64> = num_complex::Complex::new(v12, v13);
            let v17: f64 = Math::method3(Math::method55());
            let v18: f64 = Math::method59();
            let v20: num_complex::Complex<f64> = num_complex::Complex::new(v17, v18);
            let v22: f64 = Math::method3(Math::method55());
            let v23: f64 = Math::method60();
            let v25: num_complex::Complex<f64> = num_complex::Complex::new(v22, v23);
            let v27: f64 = Math::method3(Math::method55());
            let v28: f64 = Math::method61();
            let v32: Array<num_complex::Complex<f64>> = Math::method62(new_array(&[
                v5,
                v10,
                v15,
                v20,
                v25,
                num_complex::Complex::new(v27, v28),
            ]));
            let v33: i32 = count(v32.clone());
            let v34: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method7(v33, v34.clone()) {
                let v36: i32 = v34.l0.get().clone();
                let v37: num_complex::Complex<f64> = v32[v36].clone();
                let v40: Result<num_complex::Complex<f64>, std::string::String> = Math::method9(
                    v0_1.clone(),
                    string("        s = mpmath.zeta(s)"),
                    Math::method8(v37.clone()),
                );
                let v41: num_complex::Complex<f64> = Math::method33(v0_1.clone(), v37);
                let v46: Math::US0 = defaultValue(
                    Math::US0::US0_1,
                    map(
                        Func1::new(move |v: num_complex::Complex<f64>| Math::closure5((), v)),
                        v40.ok(),
                    ),
                );
                let v48: f64 = f64::NAN;
                let v50: f64 = f64::NAN;
                let v52: f64 = Math::method3(Math::method31(v48));
                let v53: f64 = Math::method32(v50);
                let v55: num_complex::Complex<f64> = num_complex::Complex::new(v52, v53);
                let v58: num_complex::Complex<f64> = match &v46 {
                    Math::US0::US0_0(v46_0_0) => match &v46 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v55,
                };
                let v59: num_complex::Complex<f64> = Math::method13(v58.clone());
                let v61: f64 = v59.re;
                let v62: f64 = -v61;
                let v64: f64 = if v61 >= v62 { v61 } else { v62 };
                let v65: string = sprintf!("{:?}", v64);
                printfn!("{0}", v65);
                {
                    let v66: bool = v64 < 0.0001_f64;
                    if (if v66 { true } else { Math::method43(v66) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v64, 0.0001_f64),
                        );
                    }
                    {
                        let v71: num_complex::Complex<f64> = Math::method14(v58);
                        let v73: f64 = v71.im;
                        let v74: f64 = -v73;
                        let v76: f64 = if v73 >= v74 { v73 } else { v74 };
                        let v77: string = sprintf!("{:?}", v76);
                        printfn!("{0}", v77);
                        {
                            let v78: bool = v76 < 0.0001_f64;
                            if (if v78 { true } else { Math::method43(v78) }) == false {
                                panic!(
                                    "{}",
                                    sprintf!(
                                        "__expect / actual: {:?} / expected: {:?}",
                                        v76,
                                        0.0001_f64
                                    ),
                                );
                            }
                            {
                                let v83: i32 = v36 + 1_i32;
                                v34.l0.set(v83);
                                ()
                            }
                        }
                    }
                }
            }
            ()
        }
        pub fn method53() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method54(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method44(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method45(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method65(v0_1: Array<f64>) -> Array<f64> {
            v0_1
        }
        pub fn method64(v0_1: pyo3::Python) {
            let v2: Array<f64> = Math::method65(new_array(&[
                2.0_f64, 3.0_f64, 4.0_f64, 5.0_f64, 10.0_f64, 20.0_f64, 50.0_f64,
            ]));
            let v3: i32 = count(v2.clone());
            let v4: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method7(v3, v4.clone()) {
                let v6: i32 = v4.l0.get().clone();
                let v9: f64 = Math::method3(Math::method31(v2[v6].clone()));
                let v10: f64 = Math::method4();
                let v12: num_complex::Complex<f64> = num_complex::Complex::new(v9, v10);
                let v15: Result<num_complex::Complex<f64>, std::string::String> = Math::method9(
                    v0_1.clone(),
                    string("        s = mpmath.zeta(s)"),
                    Math::method8(v12.clone()),
                );
                let v16: num_complex::Complex<f64> = Math::method33(v0_1.clone(), v12);
                let v21: Math::US0 = defaultValue(
                    Math::US0::US0_1,
                    map(
                        Func1::new(move |v: num_complex::Complex<f64>| Math::closure5((), v)),
                        v15.ok(),
                    ),
                );
                let v23: f64 = f64::NAN;
                let v25: f64 = f64::NAN;
                let v27: f64 = Math::method3(Math::method31(v23));
                let v28: f64 = Math::method32(v25);
                let v30: num_complex::Complex<f64> = num_complex::Complex::new(v27, v28);
                let v33: num_complex::Complex<f64> = match &v21 {
                    Math::US0::US0_0(v21_0_0) => match &v21 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v30,
                };
                let v34: num_complex::Complex<f64> = Math::method13(v33.clone());
                let v36: f64 = v34.re;
                let v37: string = sprintf!("{:?}", v36);
                printfn!("{0}", v37);
                {
                    let v38: bool = v36 > 0.0_f64;
                    if (if v38 { true } else { Math::method43(v38) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v36, 0.0_f64),
                        );
                    }
                    {
                        let v43: num_complex::Complex<f64> = Math::method14(v33);
                        let v45: f64 = v43.im;
                        let v46: string = sprintf!("{:?}", v45);
                        printfn!("{0}", v46);
                        {
                            let v47: bool = v45 == 0.0_f64;
                            if (if v47 { true } else { Math::method43(v47) }) == false {
                                panic!(
                                    "{}",
                                    sprintf!(
                                        "__expect / actual: {:?} / expected: {:?}",
                                        v45,
                                        0.0_f64
                                    ),
                                );
                            }
                            {
                                let v52: i32 = v6 + 1_i32;
                                v4.l0.set(v52);
                                ()
                            }
                        }
                    }
                }
            }
            ()
        }
        pub fn method63() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method64(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method44(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method45(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method67(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method38());
            let v3: f64 = Math::method4();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v8: Result<num_complex::Complex<f64>, std::string::String> = Math::method9(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method8(v5.clone()),
            );
            let v9: num_complex::Complex<f64> = Math::method33(v0_1, v5);
            let v14: Math::US0 = defaultValue(
                Math::US0::US0_1,
                map(
                    Func1::new(move |v: num_complex::Complex<f64>| Math::closure5((), v)),
                    v8.ok(),
                ),
            );
            let v16: f64 = f64::NAN;
            let v18: f64 = f64::NAN;
            let v20: f64 = Math::method3(Math::method31(v16));
            let v21: f64 = Math::method32(v18);
            let v23: num_complex::Complex<f64> = num_complex::Complex::new(v20, v21);
            let v26: num_complex::Complex<f64> = match &v14 {
                Math::US0::US0_0(v14_0_0) => match &v14 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v23,
            };
            let v27: num_complex::Complex<f64> = Math::method13(v26.clone());
            let v29: f64 = v27.re;
            let v30: string = sprintf!("{:?}", v29);
            printfn!("{0}", v30);
            {
                let v31: bool = v29 == f64::INFINITY;
                if (if v31 { true } else { Math::method43(v31) }) == false {
                    panic!(
                        "{}",
                        sprintf!(
                            "__expect / actual: {:?} / expected: {:?}",
                            v29,
                            f64::INFINITY
                        ),
                    );
                }
                {
                    let v36: num_complex::Complex<f64> = Math::method14(v26);
                    let v38: f64 = v36.im;
                    let v39: string = sprintf!("{:?}", v38);
                    printfn!("{0}", v39);
                    {
                        let v40: bool = v38 == 0.0_f64;
                        if (if v40 { true } else { Math::method43(v40) }) == false {
                            panic!(
                                "{}",
                                sprintf!("__expect / actual: {:?} / expected: {:?}", v38, 0.0_f64),
                            );
                        }
                    }
                }
            }
        }
        pub fn method66() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method67(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method44(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method45(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method70() -> f64 {
            10.0_f64
        }
        pub fn method69(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method2());
            let v3: f64 = Math::method70();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v8: Result<num_complex::Complex<f64>, std::string::String> = Math::method9(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method8(v5.clone()),
            );
            let v9: num_complex::Complex<f64> = Math::method33(v0_1.clone(), v5.clone());
            let v12 = Func1::new(move |v: num_complex::Complex<f64>| Math::closure5((), v));
            let v14: Math::US0 = defaultValue(Math::US0::US0_1, map(v12.clone(), v8.ok()));
            let v16: f64 = f64::NAN;
            let v18: f64 = f64::NAN;
            let v20: f64 = Math::method3(Math::method31(v16));
            let v21: f64 = Math::method32(v18);
            let v23: num_complex::Complex<f64> = num_complex::Complex::new(v20, v21);
            let v26: num_complex::Complex<f64> = match &v14 {
                Math::US0::US0_0(v14_0_0) => match &v14 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v23,
            };
            let v27: num_complex::Complex<f64> = Math::method13(v5.clone());
            let v29: f64 = v27.re;
            let v30: num_complex::Complex<f64> = Math::method14(v5);
            let v33: f64 = -v30.im;
            let v35: f64 = Math::method3(Math::method31(v29));
            let v36: f64 = Math::method32(v33);
            let v38: num_complex::Complex<f64> = num_complex::Complex::new(v35, v36);
            let v41: Result<num_complex::Complex<f64>, std::string::String> = Math::method9(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method8(v38.clone()),
            );
            let v42: num_complex::Complex<f64> = Math::method33(v0_1, v38);
            let v46: Math::US0 = defaultValue(Math::US0::US0_1, map(v12, v41.ok()));
            let v48: f64 = f64::NAN;
            let v50: f64 = f64::NAN;
            let v52: f64 = Math::method3(Math::method31(v48));
            let v53: f64 = Math::method32(v50);
            let v55: num_complex::Complex<f64> = num_complex::Complex::new(v52, v53);
            let v58: num_complex::Complex<f64> = match &v46 {
                Math::US0::US0_0(v46_0_0) => match &v46 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v55,
            };
            let v60: num_complex::Complex<f64> = v58.conj();
            let v61: num_complex::Complex<f64> = Math::method13(v26.clone());
            let v63: f64 = v61.re;
            let v64: num_complex::Complex<f64> = Math::method13(v60.clone());
            let v66: f64 = v64.re;
            let v67: string = sprintf!("{:?}", v63);
            printfn!("{0}", v67);
            {
                let v68: bool = v63 == v66;
                if (if v68 { true } else { Math::method43(v68) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v63, v66),
                    );
                }
                {
                    let v73: num_complex::Complex<f64> = Math::method14(v26);
                    let v75: f64 = v73.im;
                    let v76: num_complex::Complex<f64> = Math::method14(v60);
                    let v78: f64 = v76.im;
                    let v79: string = sprintf!("{:?}", v75);
                    printfn!("{0}", v79);
                    {
                        let v80: bool = v75 == v78;
                        if (if v80 { true } else { Math::method43(v80) }) == false {
                            panic!(
                                "{}",
                                sprintf!("__expect / actual: {:?} / expected: {:?}", v75, v78),
                            );
                        }
                    }
                }
            }
        }
        pub fn method68() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method69(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method44(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method45(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method73() -> f64 {
            0.01_f64
        }
        pub fn method74() -> f64 {
            0.01_f64
        }
        pub fn method72(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method73());
            let v3: f64 = Math::method74();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v8: Result<num_complex::Complex<f64>, std::string::String> = Math::method9(
                v0_1.clone(),
                string("        s = mpmath.zeta(s)"),
                Math::method8(v5.clone()),
            );
            let v9: num_complex::Complex<f64> = Math::method33(v0_1, v5);
            let v14: Math::US0 = defaultValue(
                Math::US0::US0_1,
                map(
                    Func1::new(move |v: num_complex::Complex<f64>| Math::closure5((), v)),
                    v8.ok(),
                ),
            );
            let v16: f64 = f64::NAN;
            let v18: f64 = f64::NAN;
            let v20: f64 = Math::method3(Math::method31(v16));
            let v21: f64 = Math::method32(v18);
            let v23: num_complex::Complex<f64> = num_complex::Complex::new(v20, v21);
            let v26: num_complex::Complex<f64> = match &v14 {
                Math::US0::US0_0(v14_0_0) => match &v14 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => v23,
            };
            let v27: num_complex::Complex<f64> = Math::method13(v26.clone());
            let v29: f64 = v27.re;
            let v30: string = sprintf!("{:?}", v29);
            printfn!("{0}", v30);
            {
                let v31: bool = v29 < f64::INFINITY;
                if (if v31 { true } else { Math::method43(v31) }) == false {
                    panic!(
                        "{}",
                        sprintf!(
                            "__expect / actual: {:?} / expected: {:?}",
                            v29,
                            f64::INFINITY
                        ),
                    );
                }
                {
                    let v36: num_complex::Complex<f64> = Math::method14(v26);
                    let v38: f64 = v36.im;
                    let v39: string = sprintf!("{:?}", v38);
                    printfn!("{0}", v39);
                    {
                        let v40: bool = v38 < f64::INFINITY;
                        if (if v40 { true } else { Math::method43(v40) }) == false {
                            panic!(
                                "{}",
                                sprintf!(
                                    "__expect / actual: {:?} / expected: {:?}",
                                    v38,
                                    f64::INFINITY
                                ),
                            );
                        }
                    }
                }
            }
        }
        pub fn method71() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method72(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method44(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method45(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method77() -> Array<f64> {
            Math::method65(new_array(&[
                10.0_f64, 20.0_f64, 30.0_f64, 40.0_f64, 50.0_f64, 60.0_f64, 70.0_f64, 80.0_f64,
                90.0_f64, 100.0_f64,
            ]))
        }
        pub fn method78(v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn method76(v0_1: pyo3::Python) {
            let v1_1: Array<f64> = Math::method77();
            let v2: i32 = count(v1_1.clone());
            let v3: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method7(v2, v3.clone()) {
                let v5: i32 = v3.l0.get().clone();
                let v6: f64 = v1_1[v5].clone();
                let v8: f64 = Math::method3(Math::method35());
                let v9: f64 = Math::method32(v6);
                let v11: num_complex::Complex<f64> = num_complex::Complex::new(v8, v9);
                let v14: Result<num_complex::Complex<f64>, std::string::String> = Math::method9(
                    v0_1.clone(),
                    string("        s = mpmath.zeta(s)"),
                    Math::method8(v11.clone()),
                );
                let v15: num_complex::Complex<f64> = Math::method33(v0_1.clone(), v11);
                let v20: Math::US0 = defaultValue(
                    Math::US0::US0_1,
                    map(
                        Func1::new(move |v: num_complex::Complex<f64>| Math::closure5((), v)),
                        v14.ok(),
                    ),
                );
                let v22: f64 = f64::NAN;
                let v24: f64 = f64::NAN;
                let v26: f64 = Math::method3(Math::method31(v22));
                let v27: f64 = Math::method32(v24);
                let v29: num_complex::Complex<f64> = num_complex::Complex::new(v26, v27);
                let v32: num_complex::Complex<f64> = match &v20 {
                    Math::US0::US0_0(v20_0_0) => match &v20 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v29,
                };
                let v33: num_complex::Complex<f64> = Math::method13(v32.clone());
                let v35: f64 = v33.re;
                let v36: string = sprintf!("{:?}", v35);
                printfn!("{0}", v36);
                {
                    let v38: bool = Math::method78(v35 == 0.0_f64);
                    if (if v38 { true } else { Math::method43(v38) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v35, 0.0_f64),
                        );
                    }
                    {
                        let v43: num_complex::Complex<f64> = Math::method14(v32);
                        let v45: f64 = v43.im;
                        let v46: string = sprintf!("{:?}", v45);
                        printfn!("{0}", v46);
                        {
                            let v48: bool = Math::method78(v45 == 0.0_f64);
                            if (if v48 { true } else { Math::method43(v48) }) == false {
                                panic!(
                                    "{}",
                                    sprintf!(
                                        "__expect / actual: {:?} / expected: {:?}",
                                        v45,
                                        0.0_f64
                                    ),
                                );
                            }
                            {
                                let v53: i32 = v5 + 1_i32;
                                v3.l0.set(v53);
                                ()
                            }
                        }
                    }
                }
            }
            ()
        }
        pub fn method75() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method76(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method44(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method45(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method81() -> f64 {
            0.75_f64
        }
        pub fn method82() -> f64 {
            20.5_f64
        }
        pub fn method83() -> f64 {
            1.25_f64
        }
        pub fn method84() -> f64 {
            30.1_f64
        }
        pub fn method85() -> f64 {
            0.25_f64
        }
        pub fn method86() -> f64 {
            40.0_f64
        }
        pub fn method87() -> f64 {
            50.0_f64
        }
        pub fn method80(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method55());
            let v3: f64 = Math::method56();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v7: f64 = Math::method3(Math::method81());
            let v8: f64 = Math::method82();
            let v10: num_complex::Complex<f64> = num_complex::Complex::new(v7, v8);
            let v12: f64 = Math::method3(Math::method83());
            let v13: f64 = Math::method84();
            let v15: num_complex::Complex<f64> = num_complex::Complex::new(v12, v13);
            let v17: f64 = Math::method3(Math::method85());
            let v18: f64 = Math::method86();
            let v20: num_complex::Complex<f64> = num_complex::Complex::new(v17, v18);
            let v22: f64 = Math::method3(Math::method38());
            let v23: f64 = Math::method87();
            let v27: Array<num_complex::Complex<f64>> = Math::method62(new_array(&[
                v5,
                v10,
                v15,
                v20,
                num_complex::Complex::new(v22, v23),
            ]));
            let v28: i32 = count(v27.clone());
            let v29: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method7(v28, v29.clone()) {
                let v31: i32 = v29.l0.get().clone();
                let v32: num_complex::Complex<f64> = v27[v31].clone();
                let v35: Result<num_complex::Complex<f64>, std::string::String> = Math::method9(
                    v0_1.clone(),
                    string("        s = mpmath.zeta(s)"),
                    Math::method8(v32.clone()),
                );
                let v36: num_complex::Complex<f64> = Math::method33(v0_1.clone(), v32);
                let v41: Math::US0 = defaultValue(
                    Math::US0::US0_1,
                    map(
                        Func1::new(move |v: num_complex::Complex<f64>| Math::closure5((), v)),
                        v35.ok(),
                    ),
                );
                let v43: f64 = f64::NAN;
                let v45: f64 = f64::NAN;
                let v47: f64 = Math::method3(Math::method31(v43));
                let v48: f64 = Math::method32(v45);
                let v50: num_complex::Complex<f64> = num_complex::Complex::new(v47, v48);
                let v53: num_complex::Complex<f64> = match &v41 {
                    Math::US0::US0_0(v41_0_0) => match &v41 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v50,
                };
                let v54: num_complex::Complex<f64> = Math::method13(v53.clone());
                let v56: f64 = v54.re;
                let v57: string = sprintf!("{:?}", v56);
                printfn!("{0}", v57);
                {
                    let v59: bool = Math::method78(v56 == 0.0_f64);
                    if (if v59 { true } else { Math::method43(v59) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v56, 0.0_f64),
                        );
                    }
                    {
                        let v64: num_complex::Complex<f64> = Math::method14(v53);
                        let v66: f64 = v64.im;
                        let v67: string = sprintf!("{:?}", v66);
                        printfn!("{0}", v67);
                        {
                            let v69: bool = Math::method78(v66 == 0.0_f64);
                            if (if v69 { true } else { Math::method43(v69) }) == false {
                                panic!(
                                    "{}",
                                    sprintf!(
                                        "__expect / actual: {:?} / expected: {:?}",
                                        v66,
                                        0.0_f64
                                    ),
                                );
                            }
                            {
                                let v74: i32 = v31 + 1_i32;
                                v29.l0.set(v74);
                                ()
                            }
                        }
                    }
                }
            }
            ()
        }
        pub fn method79() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method80(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method44(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method45(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method90() -> f64 {
            3.0_f64
        }
        pub fn method91() -> f64 {
            4.0_f64
        }
        pub fn method92() -> f64 {
            2.5_f64
        }
        pub fn method93() -> f64 {
            -3.5_f64
        }
        pub fn method94() -> f64 {
            1.5_f64
        }
        pub fn method95() -> f64 {
            2.5_f64
        }
        pub fn method89(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method90());
            let v3: f64 = Math::method91();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v7: f64 = Math::method3(Math::method92());
            let v8: f64 = Math::method93();
            let v10: num_complex::Complex<f64> = num_complex::Complex::new(v7, v8);
            let v12: f64 = Math::method3(Math::method94());
            let v13: f64 = Math::method95();
            let v15: num_complex::Complex<f64> = num_complex::Complex::new(v12, v13);
            let v17: f64 = Math::method3(Math::method55());
            let v18: f64 = Math::method56();
            let v22: Array<num_complex::Complex<f64>> = Math::method62(new_array(&[
                v5,
                v10,
                v15,
                num_complex::Complex::new(v17, v18),
            ]));
            let v23: i32 = count(v22.clone());
            let v24: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method7(v23, v24.clone()) {
                let v26: i32 = v24.l0.get().clone();
                let v27: num_complex::Complex<f64> = v22[v26].clone();
                let v30: Result<num_complex::Complex<f64>, std::string::String> = Math::method9(
                    v0_1.clone(),
                    string("        s = mpmath.zeta(s)"),
                    Math::method8(v27.clone()),
                );
                let v31: num_complex::Complex<f64> = Math::method33(v0_1.clone(), v27.clone());
                let v34 = Func1::new(move |v: num_complex::Complex<f64>| Math::closure5((), v));
                let v36: Math::US0 = defaultValue(Math::US0::US0_1, map(v34.clone(), v30.ok()));
                let v38: f64 = f64::NAN;
                let v40: f64 = f64::NAN;
                let v42: f64 = Math::method3(Math::method31(v38));
                let v43: f64 = Math::method32(v40);
                let v45: num_complex::Complex<f64> = num_complex::Complex::new(v42, v43);
                let v48: num_complex::Complex<f64> = match &v36 {
                    Math::US0::US0_0(v36_0_0) => match &v36 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v45,
                };
                let v50: f64 = Math::method3(Math::method2());
                let v51: f64 = Math::method4();
                let v54: num_complex::Complex<f64> =
                    Math::method39(num_complex::Complex::new(v50, v51));
                let v55: num_complex::Complex<f64> = Math::method40(v27.clone());
                let v57: num_complex::Complex<f64> = num_complex::Complex::powc(v54, v55);
                let v59: f64 = Math::method3(Math::method42());
                let v60: f64 = Math::method4();
                let v62: num_complex::Complex<f64> = num_complex::Complex::new(v59, v60);
                let v64: f64 = Math::method3(Math::method38());
                let v65: f64 = Math::method4();
                let v67: num_complex::Complex<f64> = num_complex::Complex::new(v64, v65);
                let v69: num_complex::Complex<f64> = v27 - v67;
                let v70: num_complex::Complex<f64> = Math::method39(v62);
                let v71: num_complex::Complex<f64> = Math::method40(v69);
                let v73: num_complex::Complex<f64> = num_complex::Complex::powc(v70, v71);
                let v75: num_complex::Complex<f64> = v57 * v73;
                let v77: f64 = Math::method3(Math::method42());
                let v78: f64 = Math::method4();
                let v80: num_complex::Complex<f64> = num_complex::Complex::new(v77, v78);
                let v82: num_complex::Complex<f64> = v80 * v27;
                let v84: f64 = Math::method3(Math::method2());
                let v85: f64 = Math::method4();
                let v87: num_complex::Complex<f64> = num_complex::Complex::new(v84, v85);
                let v89: num_complex::Complex<f64> = v82 / v87;
                let v91: num_complex::Complex<f64> = v89.sin();
                let v93: num_complex::Complex<f64> = v75 * v91;
                let v95: f64 = Math::method3(Math::method38());
                let v96: f64 = Math::method4();
                let v98: num_complex::Complex<f64> = num_complex::Complex::new(v95, v96);
                let v103: Result<num_complex::Complex<f64>, std::string::String> = Math::method41(
                    v0_1.clone(),
                    string("        s = mpmath.gamma(s)"),
                    Math::method8(v98 - v27),
                );
                let v107: Math::US0 = defaultValue(Math::US0::US0_1, map(v34.clone(), v103.ok()));
                let v109: f64 = f64::NAN;
                let v111: f64 = f64::NAN;
                let v113: f64 = Math::method3(Math::method31(v109));
                let v114: f64 = Math::method32(v111);
                let v116: num_complex::Complex<f64> = num_complex::Complex::new(v113, v114);
                let v119: num_complex::Complex<f64> = match &v107 {
                    Math::US0::US0_0(v107_0_0) => match &v107 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v116,
                };
                let v121: num_complex::Complex<f64> = v93 * v119;
                let v122: num_complex::Complex<f64> = Math::method13(v27.clone());
                let v125: f64 = 1.0_f64 - v122.re;
                let v126: num_complex::Complex<f64> = Math::method14(v27);
                let v129: f64 = -v126.im;
                let v131: f64 = Math::method3(Math::method31(v125));
                let v132: f64 = Math::method32(v129);
                let v134: num_complex::Complex<f64> = num_complex::Complex::new(v131, v132);
                let v137: Result<num_complex::Complex<f64>, std::string::String> = Math::method9(
                    v0_1.clone(),
                    string("        s = mpmath.zeta(s)"),
                    Math::method8(v134.clone()),
                );
                let v138: num_complex::Complex<f64> = Math::method33(v0_1.clone(), v134);
                let v142: Math::US0 = defaultValue(Math::US0::US0_1, map(v34, v137.ok()));
                let v144: f64 = f64::NAN;
                let v146: f64 = f64::NAN;
                let v148: f64 = Math::method3(Math::method31(v144));
                let v149: f64 = Math::method32(v146);
                let v151: num_complex::Complex<f64> = num_complex::Complex::new(v148, v149);
                let v154: num_complex::Complex<f64> = match &v142 {
                    Math::US0::US0_0(v142_0_0) => match &v142 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v151,
                };
                let v156: num_complex::Complex<f64> = v121 * v154;
                let v157: num_complex::Complex<f64> = Math::method13(v48.clone());
                let v159: f64 = v157.re;
                let v160: num_complex::Complex<f64> = Math::method13(v156.clone());
                let v163: f64 = v159 - v160.re;
                let v164: f64 = -v163;
                let v166: f64 = if v163 >= v164 { v163 } else { v164 };
                let v167: string = sprintf!("{:?}", v166);
                printfn!("{0}", v167);
                {
                    let v168: bool = v166 < 0.0001_f64;
                    if (if v168 { true } else { Math::method43(v168) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v166, 0.0001_f64),
                        );
                    }
                    {
                        let v173: num_complex::Complex<f64> = Math::method14(v48);
                        let v175: f64 = v173.im;
                        let v176: num_complex::Complex<f64> = Math::method14(v156);
                        let v179: f64 = v175 - v176.im;
                        let v180: f64 = -v179;
                        let v182: f64 = if v179 >= v180 { v179 } else { v180 };
                        let v183: string = sprintf!("{:?}", v182);
                        printfn!("{0}", v183);
                        {
                            let v184: bool = v182 < 0.0001_f64;
                            if (if v184 { true } else { Math::method43(v184) }) == false {
                                panic!(
                                    "{}",
                                    sprintf!(
                                        "__expect / actual: {:?} / expected: {:?}",
                                        v182,
                                        0.0001_f64
                                    ),
                                );
                            }
                            {
                                let v189: i32 = v26 + 1_i32;
                                v24.l0.set(v189);
                                ()
                            }
                        }
                    }
                }
            }
            ()
        }
        pub fn method88() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method89(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method44(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method45(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method98(v0_1: i32, v1_1: LrcPtr<Math::Mut3>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method97(v0_1: pyo3::Python) {
            let v2: Array<f64> = Math::method65(new_array(&[
                2.0_f64, 2.5_f64, 3.0_f64, 3.5_f64, 4.0_f64, 4.5_f64, 5.0_f64,
            ]));
            let v4: Array<f64> = Math::method65(new_array(&[
                2.0_f64, 3.0_f64, 5.0_f64, 7.0_f64, 11.0_f64, 13.0_f64, 17.0_f64, 19.0_f64,
                23.0_f64, 29.0_f64, 31.0_f64, 37.0_f64, 41.0_f64, 43.0_f64, 47.0_f64, 53.0_f64,
                59.0_f64, 61.0_f64, 67.0_f64, 71.0_f64,
            ]));
            let v5: i32 = count(v2.clone());
            let v6: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method7(v5, v6.clone()) {
                let v8: i32 = v6.l0.get().clone();
                let v9: f64 = v2[v8].clone();
                let v11: f64 = Math::method3(Math::method31(v9));
                let v12: f64 = Math::method4();
                let v14: num_complex::Complex<f64> = num_complex::Complex::new(v11, v12);
                let v15: i32 = count(v4.clone());
                let v16: LrcPtr<Math::Mut3> = LrcPtr::new(Math::Mut3 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(1.0_f64),
                });
                while Math::method98(v15, v16.clone()) {
                    let v18: i32 = v16.l0.get().clone();
                    let v19: f64 = v16.l1.get().clone();
                    let v20: f64 = v4[v18].clone();
                    let v21: f64 = -v9;
                    let v24: f64 = v19 / (1.0_f64 - v20.powf(v21));
                    let v25: i32 = v18 + 1_i32;
                    v16.l0.set(v25);
                    v16.l1.set(v24);
                    ()
                }
                {
                    let v26: f64 = v16.l1.get().clone();
                    let v29: Result<num_complex::Complex<f64>, std::string::String> = Math::method9(
                        v0_1.clone(),
                        string("        s = mpmath.zeta(s)"),
                        Math::method8(v14.clone()),
                    );
                    let v30: num_complex::Complex<f64> = Math::method33(v0_1.clone(), v14);
                    let v35: Math::US0 = defaultValue(
                        Math::US0::US0_1,
                        map(
                            Func1::new(move |v: num_complex::Complex<f64>| Math::closure5((), v)),
                            v29.ok(),
                        ),
                    );
                    let v37: f64 = f64::NAN;
                    let v39: f64 = f64::NAN;
                    let v41: f64 = Math::method3(Math::method31(v37));
                    let v42: f64 = Math::method32(v39);
                    let v44: num_complex::Complex<f64> = num_complex::Complex::new(v41, v42);
                    let v47: num_complex::Complex<f64> = match &v35 {
                        Math::US0::US0_0(v35_0_0) => match &v35 {
                            Math::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v44,
                    };
                    let v48: num_complex::Complex<f64> = Math::method13(v47.clone());
                    let v51: f64 = v48.re - v26;
                    let v52: f64 = -v51;
                    let v54: f64 = if v51 >= v52 { v51 } else { v52 };
                    let v55: string = sprintf!("{:?}", v54);
                    printfn!("{0}", v55);
                    {
                        let v56: bool = v54 < 0.01_f64;
                        if (if v56 { true } else { Math::method43(v56) }) == false {
                            panic!(
                                "{}",
                                sprintf!("__expect / actual: {:?} / expected: {:?}", v54, 0.01_f64),
                            );
                        }
                        {
                            let v61: num_complex::Complex<f64> = Math::method14(v47);
                            let v63: f64 = v61.im;
                            let v64: string = sprintf!("{:?}", v63);
                            printfn!("{0}", v64);
                            {
                                let v65: bool = v63 < 0.01_f64;
                                if (if v65 { true } else { Math::method43(v65) }) == false {
                                    panic!(
                                        "{}",
                                        sprintf!(
                                            "__expect / actual: {:?} / expected: {:?}",
                                            v63,
                                            0.01_f64
                                        ),
                                    );
                                }
                                {
                                    let v70: i32 = v8 + 1_i32;
                                    v6.l0.set(v70);
                                    ()
                                }
                            }
                        }
                    }
                }
            }
            ()
        }
        pub fn method96() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method97(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method44(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method45(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn closure0(unitVar: (), unitVar_1: ()) {} //;
        #[test]
        fn test_zeta_at_known_values_() {
            //;
            Math::method0();
        }
        #[test]
        fn test_zeta_at_2_minus2() {
            //;
            Math::method46();
        }
        #[test]
        fn test_trivial_zero_at_negative_even___() {
            //;
            Math::method49();
        }
        #[test]
        fn test_non_trivial_zero___() {
            //;
            Math::method53();
        }
        #[test]
        fn test_real_part_greater_than_one___() {
            //;
            Math::method63();
        }
        #[test]
        fn test_zeta_at_1___() {
            //;
            Math::method66();
        }
        #[test]
        fn test_symmetry_across_real_axis___() {
            //;
            Math::method68();
        }
        #[test]
        fn test_behavior_near_origin___() {
            //;
            Math::method71();
        }
        #[test]
        fn test_imaginary_axis() {
            //;
            Math::method75();
        }
        #[test]
        fn test_critical_strip() {
            //;
            Math::method79();
        }
        #[test]
        fn test_reflection_formula_for_specific_value() {
            //;
            Math::method88();
        }
        #[test]
        fn test_euler_product_formula() {
            //;
            Math::method96()
        }
        pub fn closure6(unitVar: (), v0_1: Array<string>) -> i32 {
            let v1_1: string = sprintf!("value: {}", 1_i32);
            printfn!("{0}", v1_1);
            0_i32
        }
        pub fn v0() -> Func0<()> {
            static v0: OnceInit<Func0<()>> = OnceInit::new();
            v0.get_or_insert_with(|| Func0::new(move || Math::closure0((), ())))
                .clone()
        }
        pub fn tests() {
            (Math::v0())();
        }
        pub fn v1() -> Func1<Array<string>, i32> {
            static v1: OnceInit<Func1<Array<string>, i32>> = OnceInit::new();
            v1.get_or_insert_with(|| Func1::new(move |v: Array<string>| Math::closure6((), v)))
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
#[path = "../../lib/spiral/common.rs"]
mod module_e7e93d99;
pub use module_e7e93d99::*;
#[path = "../../lib/spiral/date_time.rs"]
mod module_d18105aa;
pub use module_d18105aa::*;
#[path = "../../lib/spiral/file_system.rs"]
mod module_c5eb79e8;
pub use module_c5eb79e8::*;
#[path = "../../lib/spiral/lib.rs"]
mod module_8d8b0653;
pub use module_8d8b0653::*;
#[path = "../../lib/spiral/sm.rs"]
mod module_2aeb754a;
pub use module_2aeb754a::*;
pub mod Polyglot {
    pub use crate::module_8cb3e09e::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Math::main(array_from(args));
}
