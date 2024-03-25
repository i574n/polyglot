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
        #[derive(Clone, Debug, PartialEq, PartialOrd)]
        pub enum UH0 {
            UH0_0(f64, LrcPtr<Math::UH0>),
            UH0_1,
        }
        impl Math::UH0 {
            pub fn get_IsUH0_0(this_: LrcPtr<Math::UH0>, unitArg: ()) -> bool {
                if let Math::UH0::UH0_0(this__0_0, this__0_1) = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUH0_1(this_: LrcPtr<Math::UH0>, unitArg: ()) -> bool {
                if let Math::UH0::UH0_1 = this_.as_ref() {
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
        pub fn method17(
            v0_1: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr>,
        ) -> Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> {
            v0_1
        }
        pub fn method18() -> string {
            string("fn")
        }
        pub fn method19(
            v0_1: pyo3::Bound<pyo3::types::PyModule>,
        ) -> pyo3::Bound<pyo3::types::PyModule> {
            v0_1
        }
        pub fn method20(
            v0_1: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr>,
        ) -> Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> {
            v0_1
        }
        pub fn method21(
            v0_: bool,
            v0__1: LrcPtr<(f64, f64)>,
        ) -> LrcPtr<(bool, LrcPtr<(f64, f64)>)> {
            LrcPtr::new((v0_, v0__1))
        }
        pub fn method22(v0_1: pyo3::Bound<pyo3::PyAny>) -> pyo3::Bound<pyo3::PyAny> {
            v0_1
        }
        pub fn method23(v0_1: pyo3::Bound<pyo3::PyAny>) -> pyo3::Bound<pyo3::PyAny> {
            v0_1
        }
        pub fn method24(v0_1: Result<(f64, f64), pyo3::PyErr>) -> Result<(f64, f64), pyo3::PyErr> {
            v0_1
        }
        pub fn method25(v0_1: f64) -> f64 {
            v0_1
        }
        pub fn method26(v0_1: f64) -> f64 {
            v0_1
        }
        pub fn method9(
            v0_1: pyo3::Python,
            v1_1: string,
            v2: num_complex::Complex<f64>,
        ) -> Result<num_complex::Complex<f64>, pyo3::PyErr> {
            let v14: string =
                string("      args_str = \', \'.join([ f\"{k}={re.sub(memory_address_pattern, \' at 0x<?>\', repr(v))}\" for k, v in args.items() ])");
            let v36: string =
                Math::method11(Math::method10(new_array(&[string("import sys"),
                                                          string("import traceback"),
                                                          string("import re"),
                                                          string("count = 0"),
                                                          string("memory_address_pattern = re.compile(r\' at 0x[0-9a-fA-F]+\')"),
                                                          string("def trace_calls(frame, event, arg):"),
                                                          string("  global count"),
                                                          string("  count += 1"),
                                                          string("  if count < 300:"),
                                                          string("    try:"),
                                                          string("      args = { k: v for k, v in frame.f_locals.items() if k not in [\'ctx\'] and not callable(v) }"),
                                                          v14,
                                                          sprintf!("      print(f\"{{event}}({}) / f_code.co_name: {{frame.f_code.co_name}} / f_locals: {{args_str}} / f_lineno: {{frame.f_lineno}} / f_code.co_filename: {{frame.f_code.co_filename.split(\'site-packages\')[-1]}} / f_back.f_lineno: {{ \'\' if frame.f_back is None else frame.f_back.f_lineno }} / f_back.f_code.co_filename: {{ \'\' if frame.f_back is None else frame.f_back.f_code.co_filename.split(\'site-packages\')[-1] }}\", flush=True)",
                                                                   string("zeta_")),
                                                          string("    except ValueError as e:"),
                                                          sprintf!("      print(f\'{} / e: {{e}}\', flush=True)",
                                                                   string("zeta_")),
                                                          string("import mpmath"),
                                                          string("def fn(log, s):"),
                                                          string("  global count"),
                                                          string("  if log:"),
                                                          sprintf!("    print(f\'{} / s: {{s}} / count: {{count}}\', flush=True)",
                                                                   string("zeta_")),
                                                          string("  s = complex(*s)"),
                                                          string("  try:"),
                                                          string("    if log: sys.settrace(trace_calls)"),
                                                          v1_1,
                                                          string("    if log:"),
                                                          string("      sys.settrace(None)"),
                                                          sprintf!("      print(f\'{} / result: {{s}} / count: {{count}}\', flush=True)",
                                                                   string("zeta_")),
                                                          string("  except ValueError as e:"),
                                                          string("    if s.real == 1:"),
                                                          string("      s = complex(float(\'inf\'), 0)"),
                                                          string("  return (s.real, s.imag)")])));
            let v37: num_complex::Complex<f64> = Math::method13(v2.clone());
            let v39: f64 = v37.re;
            let v40: num_complex::Complex<f64> = Math::method14(v2);
            let v44: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v39, v40.im))));
            let v45: pyo3::Python = Math::method15(v0_1);
            let v46: string = Math::method16(v36);
            let v48: &str = fable_library_rust::String_::LrcStr::as_str(&v46);
            let v51: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                Math::method17(pyo3::types::PyModule::from_code_bound(v45, v48, "", ""));
            let v53: pyo3::Bound<pyo3::types::PyModule> = v51.unwrap();
            let v54: string = Math::method18();
            let v56: &str = fable_library_rust::String_::LrcStr::as_str(&v54);
            let v57: pyo3::Bound<pyo3::types::PyModule> = Math::method19(v53);
            let v60: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                Math::method20(v57.getattr(v56));
            let v62: pyo3::Bound<pyo3::PyAny> = v60.unwrap();
            let v63: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method21(v44.0.clone(), v44.1.clone());
            let v64: pyo3::Bound<pyo3::PyAny> = Math::method22(v62);
            let v67: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method20(
                pyo3::prelude::PyAnyMethods::call(&v64, ((*v63).0, *(*v63).1), None),
            );
            let v70: pyo3::Bound<pyo3::PyAny> = Math::method23(v67.unwrap());
            let v73: Result<(f64, f64), pyo3::PyErr> = Math::method24(v70.extract());
            let patternInput: (f64, f64) = v73.unwrap();
            let v78: f64 = Math::method3(Math::method25(patternInput.0.clone()));
            let v79: f64 = Math::method26(patternInput.1.clone());
            Ok::<num_complex::Complex<f64>, pyo3::PyErr>(num_complex::Complex::new(v78, v79))
        }
        pub fn method27(
            v0_1: Result<num_complex::Complex<f64>, pyo3::PyErr>,
        ) -> Result<num_complex::Complex<f64>, pyo3::PyErr> {
            v0_1
        }
        pub fn method29(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method30() -> f64 {
            0.0_f64
        }
        pub fn method31(v0_1: LrcPtr<Math::Mut0>) -> bool {
            v0_1.l0.get().clone() < 10000_i32
        }
        pub fn method32(v0_1: i32, v1_1: LrcPtr<Math::Mut2>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method33() -> f64 {
            1.0_f64
        }
        pub fn method34(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method35(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method36(
            v0_1: pyo3::Python,
            v1_1: string,
            v2: num_complex::Complex<f64>,
        ) -> Result<num_complex::Complex<f64>, pyo3::PyErr> {
            let v14: string =
                string("      args_str = \', \'.join([ f\"{k}={re.sub(memory_address_pattern, \' at 0x<?>\', repr(v))}\" for k, v in args.items() ])");
            let v36: string =
                Math::method11(Math::method10(new_array(&[string("import sys"),
                                                          string("import traceback"),
                                                          string("import re"),
                                                          string("count = 0"),
                                                          string("memory_address_pattern = re.compile(r\' at 0x[0-9a-fA-F]+\')"),
                                                          string("def trace_calls(frame, event, arg):"),
                                                          string("  global count"),
                                                          string("  count += 1"),
                                                          string("  if count < 300:"),
                                                          string("    try:"),
                                                          string("      args = { k: v for k, v in frame.f_locals.items() if k not in [\'ctx\'] and not callable(v) }"),
                                                          v14,
                                                          sprintf!("      print(f\"{{event}}({}) / f_code.co_name: {{frame.f_code.co_name}} / f_locals: {{args_str}} / f_lineno: {{frame.f_lineno}} / f_code.co_filename: {{frame.f_code.co_filename.split(\'site-packages\')[-1]}} / f_back.f_lineno: {{ \'\' if frame.f_back is None else frame.f_back.f_lineno }} / f_back.f_code.co_filename: {{ \'\' if frame.f_back is None else frame.f_back.f_code.co_filename.split(\'site-packages\')[-1] }}\", flush=True)",
                                                                   string("gamma_")),
                                                          string("    except ValueError as e:"),
                                                          sprintf!("      print(f\'{} / e: {{e}}\', flush=True)",
                                                                   string("gamma_")),
                                                          string("import mpmath"),
                                                          string("def fn(log, s):"),
                                                          string("  global count"),
                                                          string("  if log:"),
                                                          sprintf!("    print(f\'{} / s: {{s}} / count: {{count}}\', flush=True)",
                                                                   string("gamma_")),
                                                          string("  s = complex(*s)"),
                                                          string("  try:"),
                                                          string("    if log: sys.settrace(trace_calls)"),
                                                          v1_1,
                                                          string("    if log:"),
                                                          string("      sys.settrace(None)"),
                                                          sprintf!("      print(f\'{} / result: {{s}} / count: {{count}}\', flush=True)",
                                                                   string("gamma_")),
                                                          string("  except ValueError as e:"),
                                                          string("    if s.real == 1:"),
                                                          string("      s = complex(float(\'inf\'), 0)"),
                                                          string("  return (s.real, s.imag)")])));
            let v37: num_complex::Complex<f64> = Math::method13(v2.clone());
            let v39: f64 = v37.re;
            let v40: num_complex::Complex<f64> = Math::method14(v2);
            let v44: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v39, v40.im))));
            let v45: pyo3::Python = Math::method15(v0_1);
            let v46: string = Math::method16(v36);
            let v48: &str = fable_library_rust::String_::LrcStr::as_str(&v46);
            let v51: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                Math::method17(pyo3::types::PyModule::from_code_bound(v45, v48, "", ""));
            let v53: pyo3::Bound<pyo3::types::PyModule> = v51.unwrap();
            let v54: string = Math::method18();
            let v56: &str = fable_library_rust::String_::LrcStr::as_str(&v54);
            let v57: pyo3::Bound<pyo3::types::PyModule> = Math::method19(v53);
            let v60: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                Math::method20(v57.getattr(v56));
            let v62: pyo3::Bound<pyo3::PyAny> = v60.unwrap();
            let v63: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method21(v44.0.clone(), v44.1.clone());
            let v64: pyo3::Bound<pyo3::PyAny> = Math::method22(v62);
            let v67: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method20(
                pyo3::prelude::PyAnyMethods::call(&v64, ((*v63).0, *(*v63).1), None),
            );
            let v70: pyo3::Bound<pyo3::PyAny> = Math::method23(v67.unwrap());
            let v73: Result<(f64, f64), pyo3::PyErr> = Math::method24(v70.extract());
            let patternInput: (f64, f64) = v73.unwrap();
            let v78: f64 = Math::method3(Math::method25(patternInput.0.clone()));
            let v79: f64 = Math::method26(patternInput.1.clone());
            Ok::<num_complex::Complex<f64>, pyo3::PyErr>(num_complex::Complex::new(v78, v79))
        }
        pub fn method37() -> f64 {
            3.141592653589793_f64
        }
        pub fn method28(
            v0_1: pyo3::Python,
            v1_1: num_complex::Complex<f64>,
        ) -> num_complex::Complex<f64> {
            let v2: num_complex::Complex<f64> = Math::method29(v1_1);
            println!("zeta / count: {:?} / s: {:?}", 0, v2);
            {
                let v4: num_complex::Complex<f64> = Math::method13(v2.clone());
                if v4.re > 1.0_f64 {
                    let v9: f64 = Math::method3(Math::method30());
                    let v10: f64 = Math::method4();
                    let v12: num_complex::Complex<f64> = num_complex::Complex::new(v9, v10);
                    let v13: Array<i32> = new_init(&0_i32, 10000_i32);
                    let v14: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                        l0: MutCell::new(0_i32),
                    });
                    while Math::method31(v14.clone()) {
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
                        while Math::method32(v18, v19.clone()) {
                            let v21: i32 = v19.l0.get().clone();
                            let v22: num_complex::Complex<f64> = v19.l1.get().clone();
                            let v23: i32 = v13[v21].clone();
                            let v25: f64 = Math::method3(Math::method33());
                            let v26: f64 = Math::method4();
                            let v28: num_complex::Complex<f64> =
                                num_complex::Complex::new(v25, v26);
                            let v31: f64 = Math::method3(Math::method25(v23 as f64));
                            let v32: f64 = Math::method4();
                            let v35: num_complex::Complex<f64> =
                                Math::method34(num_complex::Complex::new(v31, v32));
                            let v36: num_complex::Complex<f64> = Math::method35(v2.clone());
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
                    let v46: f64 = Math::method3(Math::method33());
                    let v47: f64 = Math::method4();
                    let v49: num_complex::Complex<f64> = num_complex::Complex::new(v46, v47);
                    let v55: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                        Math::method27(Math::method36(
                            v0_1.clone(),
                            string("    s = mpmath.gamma(s)"),
                            Math::method8(v49 - v2),
                        ));
                    let v57: num_complex::Complex<f64> = v55.unwrap();
                    let v59: f64 = Math::method3(Math::method37());
                    let v60: f64 = Math::method4();
                    let v62: num_complex::Complex<f64> = num_complex::Complex::new(v59, v60);
                    let v64: num_complex::Complex<f64> = v62 * v2;
                    let v66: f64 = Math::method3(Math::method2());
                    let v67: f64 = Math::method4();
                    let v69: num_complex::Complex<f64> = num_complex::Complex::new(v66, v67);
                    let v71: num_complex::Complex<f64> = v64 / v69;
                    let v73: num_complex::Complex<f64> = v71.sin();
                    let v74: num_complex::Complex<f64> = Math::method13(v2.clone());
                    let v77: f64 = 1.0_f64 - v74.re;
                    let v78: num_complex::Complex<f64> = Math::method14(v2.clone());
                    let v81: f64 = -v78.im;
                    let v83: f64 = Math::method3(Math::method25(v77));
                    let v84: f64 = Math::method26(v81);
                    let v86: num_complex::Complex<f64> = num_complex::Complex::new(v83, v84);
                    let v87: num_complex::Complex<f64> = Math::method13(v86.clone());
                    let v568: num_complex::Complex<f64> = if v87.re <= 1.0_f64 {
                        let v92: f64 = Math::method3(Math::method30());
                        let v93: f64 = Math::method4();
                        num_complex::Complex::new(v92, v93)
                    } else {
                        let v96: num_complex::Complex<f64> = Math::method29(v86);
                        println!("zeta / count: {:?} / s: {:?}", 1, v96);
                        {
                            let v98: num_complex::Complex<f64> = Math::method13(v96.clone());
                            if v98.re > 1.0_f64 {
                                let v103: f64 = Math::method3(Math::method30());
                                let v104: f64 = Math::method4();
                                let v106: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v103, v104);
                                let v107: Array<i32> = new_init(&0_i32, 10000_i32);
                                let v108: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Math::method31(v108.clone()) {
                                    let v110: i32 = v108.l0.get().clone();
                                    v107.get_mut()[v110 as usize] = v110;
                                    {
                                        let v111: i32 = v110 + 1_i32;
                                        v108.l0.set(v111);
                                        ()
                                    }
                                }
                                {
                                    let v112: i32 = count(v107.clone());
                                    let v113: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                        l0: MutCell::new(0_i32),
                                        l1: MutCell::new(v106),
                                    });
                                    while Math::method32(v112, v113.clone()) {
                                        let v115: i32 = v113.l0.get().clone();
                                        let v116: num_complex::Complex<f64> = v113.l1.get().clone();
                                        let v117: i32 = v107[v115].clone();
                                        let v119: f64 = Math::method3(Math::method33());
                                        let v120: f64 = Math::method4();
                                        let v122: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v119, v120);
                                        let v125: f64 = Math::method3(Math::method25(v117 as f64));
                                        let v126: f64 = Math::method4();
                                        let v129: num_complex::Complex<f64> =
                                            Math::method34(num_complex::Complex::new(v125, v126));
                                        let v130: num_complex::Complex<f64> =
                                            Math::method35(v96.clone());
                                        let v132: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v129, v130);
                                        let v134: num_complex::Complex<f64> = v122 / v132;
                                        let v136: num_complex::Complex<f64> = v116 + v134;
                                        let v137: i32 = v115 + 1_i32;
                                        v113.l0.set(v137);
                                        v113.l1.set(v136);
                                        ()
                                    }
                                    v113.l1.get().clone()
                                }
                            } else {
                                let v140: f64 = Math::method3(Math::method33());
                                let v141: f64 = Math::method4();
                                let v143: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v140, v141);
                                let v149: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                                    Math::method27(Math::method36(
                                        v0_1.clone(),
                                        string("    s = mpmath.gamma(s)"),
                                        Math::method8(v143 - v96),
                                    ));
                                let v151: num_complex::Complex<f64> = v149.unwrap();
                                let v153: f64 = Math::method3(Math::method37());
                                let v154: f64 = Math::method4();
                                let v156: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v153, v154);
                                let v158: num_complex::Complex<f64> = v156 * v96;
                                let v160: f64 = Math::method3(Math::method2());
                                let v161: f64 = Math::method4();
                                let v163: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v160, v161);
                                let v165: num_complex::Complex<f64> = v158 / v163;
                                let v167: num_complex::Complex<f64> = v165.sin();
                                let v168: num_complex::Complex<f64> = Math::method13(v96.clone());
                                let v171: f64 = 1.0_f64 - v168.re;
                                let v172: num_complex::Complex<f64> = Math::method14(v96.clone());
                                let v175: f64 = -v172.im;
                                let v177: f64 = Math::method3(Math::method25(v171));
                                let v178: f64 = Math::method26(v175);
                                let v180: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v177, v178);
                                let v181: num_complex::Complex<f64> = Math::method13(v180.clone());
                                let v544: num_complex::Complex<f64> = if v181.re <= 1.0_f64 {
                                    let v186: f64 = Math::method3(Math::method30());
                                    let v187: f64 = Math::method4();
                                    num_complex::Complex::new(v186, v187)
                                } else {
                                    let v190: num_complex::Complex<f64> = Math::method29(v180);
                                    println!("zeta / count: {:?} / s: {:?}", 2, v190);
                                    {
                                        let v192: num_complex::Complex<f64> =
                                            Math::method13(v190.clone());
                                        if v192.re > 1.0_f64 {
                                            let v197: f64 = Math::method3(Math::method30());
                                            let v198: f64 = Math::method4();
                                            let v200: num_complex::Complex<f64> =
                                                num_complex::Complex::new(v197, v198);
                                            let v201: Array<i32> = new_init(&0_i32, 10000_i32);
                                            let v202: LrcPtr<Math::Mut0> =
                                                LrcPtr::new(Math::Mut0 {
                                                    l0: MutCell::new(0_i32),
                                                });
                                            while Math::method31(v202.clone()) {
                                                let v204: i32 = v202.l0.get().clone();
                                                v201.get_mut()[v204 as usize] = v204;
                                                {
                                                    let v205: i32 = v204 + 1_i32;
                                                    v202.l0.set(v205);
                                                    ()
                                                }
                                            }
                                            {
                                                let v206: i32 = count(v201.clone());
                                                let v207: LrcPtr<Math::Mut2> =
                                                    LrcPtr::new(Math::Mut2 {
                                                        l0: MutCell::new(0_i32),
                                                        l1: MutCell::new(v200),
                                                    });
                                                while Math::method32(v206, v207.clone()) {
                                                    let v209: i32 = v207.l0.get().clone();
                                                    let v210: num_complex::Complex<f64> =
                                                        v207.l1.get().clone();
                                                    let v211: i32 = v201[v209].clone();
                                                    let v213: f64 = Math::method3(Math::method33());
                                                    let v214: f64 = Math::method4();
                                                    let v216: num_complex::Complex<f64> =
                                                        num_complex::Complex::new(v213, v214);
                                                    let v219: f64 =
                                                        Math::method3(Math::method25(v211 as f64));
                                                    let v220: f64 = Math::method4();
                                                    let v223: num_complex::Complex<f64> =
                                                        Math::method34(num_complex::Complex::new(
                                                            v219, v220,
                                                        ));
                                                    let v224: num_complex::Complex<f64> =
                                                        Math::method35(v190.clone());
                                                    let v226: num_complex::Complex<f64> =
                                                        num_complex::Complex::powc(v223, v224);
                                                    let v228: num_complex::Complex<f64> =
                                                        v216 / v226;
                                                    let v230: num_complex::Complex<f64> =
                                                        v210 + v228;
                                                    let v231: i32 = v209 + 1_i32;
                                                    v207.l0.set(v231);
                                                    v207.l1.set(v230);
                                                    ()
                                                }
                                                v207.l1.get().clone()
                                            }
                                        } else {
                                            let v234: f64 = Math::method3(Math::method33());
                                            let v235: f64 = Math::method4();
                                            let v237: num_complex::Complex<f64> =
                                                num_complex::Complex::new(v234, v235);
                                            let v243: Result<
                                                num_complex::Complex<f64>,
                                                pyo3::PyErr,
                                            > = Math::method27(Math::method36(
                                                v0_1.clone(),
                                                string("    s = mpmath.gamma(s)"),
                                                Math::method8(v237 - v190),
                                            ));
                                            let v245: num_complex::Complex<f64> = v243.unwrap();
                                            let v247: f64 = Math::method3(Math::method37());
                                            let v248: f64 = Math::method4();
                                            let v250: num_complex::Complex<f64> =
                                                num_complex::Complex::new(v247, v248);
                                            let v252: num_complex::Complex<f64> = v250 * v190;
                                            let v254: f64 = Math::method3(Math::method2());
                                            let v255: f64 = Math::method4();
                                            let v257: num_complex::Complex<f64> =
                                                num_complex::Complex::new(v254, v255);
                                            let v259: num_complex::Complex<f64> = v252 / v257;
                                            let v261: num_complex::Complex<f64> = v259.sin();
                                            let v262: num_complex::Complex<f64> =
                                                Math::method13(v190.clone());
                                            let v265: f64 = 1.0_f64 - v262.re;
                                            let v266: num_complex::Complex<f64> =
                                                Math::method14(v190.clone());
                                            let v269: f64 = -v266.im;
                                            let v271: f64 = Math::method3(Math::method25(v265));
                                            let v272: f64 = Math::method26(v269);
                                            let v274: num_complex::Complex<f64> =
                                                num_complex::Complex::new(v271, v272);
                                            let v275: num_complex::Complex<f64> =
                                                Math::method13(v274.clone());
                                            let v520: num_complex::Complex<f64> = if v275.re
                                                <= 1.0_f64
                                            {
                                                let v280: f64 = Math::method3(Math::method30());
                                                let v281: f64 = Math::method4();
                                                num_complex::Complex::new(v280, v281)
                                            } else {
                                                let v284: num_complex::Complex<f64> =
                                                    Math::method29(v274);
                                                println!("zeta / count: {:?} / s: {:?}", 3, v284);
                                                {
                                                    let v286: num_complex::Complex<f64> =
                                                        Math::method13(v284.clone());
                                                    if v286.re > 1.0_f64 {
                                                        let v291: f64 =
                                                            Math::method3(Math::method30());
                                                        let v292: f64 = Math::method4();
                                                        let v294: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(v291, v292);
                                                        let v295: Array<i32> =
                                                            new_init(&0_i32, 10000_i32);
                                                        let v296: LrcPtr<Math::Mut0> =
                                                            LrcPtr::new(Math::Mut0 {
                                                                l0: MutCell::new(0_i32),
                                                            });
                                                        while Math::method31(v296.clone()) {
                                                            let v298: i32 = v296.l0.get().clone();
                                                            v295.get_mut()[v298 as usize] = v298;
                                                            {
                                                                let v299: i32 = v298 + 1_i32;
                                                                v296.l0.set(v299);
                                                                ()
                                                            }
                                                        }
                                                        {
                                                            let v300: i32 = count(v295.clone());
                                                            let v301: LrcPtr<Math::Mut2> =
                                                                LrcPtr::new(Math::Mut2 {
                                                                    l0: MutCell::new(0_i32),
                                                                    l1: MutCell::new(v294),
                                                                });
                                                            while Math::method32(v300, v301.clone())
                                                            {
                                                                let v303: i32 =
                                                                    v301.l0.get().clone();
                                                                let v304: num_complex::Complex<
                                                                    f64,
                                                                > = v301.l1.get().clone();
                                                                let v305: i32 = v295[v303].clone();
                                                                let v307: f64 =
                                                                    Math::method3(Math::method33());
                                                                let v308: f64 = Math::method4();
                                                                let v310: num_complex::Complex<
                                                                    f64,
                                                                > = num_complex::Complex::new(
                                                                    v307, v308,
                                                                );
                                                                let v313: f64 = Math::method3(
                                                                    Math::method25(v305 as f64),
                                                                );
                                                                let v314: f64 = Math::method4();
                                                                let v317: num_complex::Complex<
                                                                    f64,
                                                                > = Math::method34(
                                                                    num_complex::Complex::new(
                                                                        v313, v314,
                                                                    ),
                                                                );
                                                                let v318: num_complex::Complex<
                                                                    f64,
                                                                > = Math::method35(v284.clone());
                                                                let v320: num_complex::Complex<
                                                                    f64,
                                                                > = num_complex::Complex::powc(
                                                                    v317, v318,
                                                                );
                                                                let v322: num_complex::Complex<
                                                                    f64,
                                                                > = v310 / v320;
                                                                let v324: num_complex::Complex<
                                                                    f64,
                                                                > = v304 + v322;
                                                                let v325: i32 = v303 + 1_i32;
                                                                v301.l0.set(v325);
                                                                v301.l1.set(v324);
                                                                ()
                                                            }
                                                            v301.l1.get().clone()
                                                        }
                                                    } else {
                                                        let v328: f64 =
                                                            Math::method3(Math::method33());
                                                        let v329: f64 = Math::method4();
                                                        let v331: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(v328, v329);
                                                        let v337: Result<
                                                            num_complex::Complex<f64>,
                                                            pyo3::PyErr,
                                                        > = Math::method27(Math::method36(
                                                            v0_1.clone(),
                                                            string("    s = mpmath.gamma(s)"),
                                                            Math::method8(v331 - v284),
                                                        ));
                                                        let v339: num_complex::Complex<f64> =
                                                            v337.unwrap();
                                                        let v341: f64 =
                                                            Math::method3(Math::method37());
                                                        let v342: f64 = Math::method4();
                                                        let v344: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(v341, v342);
                                                        let v346: num_complex::Complex<f64> =
                                                            v344 * v284;
                                                        let v348: f64 =
                                                            Math::method3(Math::method2());
                                                        let v349: f64 = Math::method4();
                                                        let v351: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(v348, v349);
                                                        let v353: num_complex::Complex<f64> =
                                                            v346 / v351;
                                                        let v355: num_complex::Complex<f64> =
                                                            v353.sin();
                                                        let v356: num_complex::Complex<f64> =
                                                            Math::method13(v284.clone());
                                                        let v359: f64 = 1.0_f64 - v356.re;
                                                        let v360: num_complex::Complex<f64> =
                                                            Math::method14(v284.clone());
                                                        let v363: f64 = -v360.im;
                                                        let v365: f64 =
                                                            Math::method3(Math::method25(v359));
                                                        let v366: f64 = Math::method26(v363);
                                                        let v368: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(v365, v366);
                                                        let v369: num_complex::Complex<f64> =
                                                            Math::method13(v368.clone());
                                                        let v496: num_complex::Complex<f64> =
                                                            if v369.re <= 1.0_f64 {
                                                                let v374: f64 =
                                                                    Math::method3(Math::method30());
                                                                let v375: f64 = Math::method4();
                                                                num_complex::Complex::new(
                                                                    v374, v375,
                                                                )
                                                            } else {
                                                                let v378: num_complex::Complex<
                                                                    f64,
                                                                > = Math::method29(v368);
                                                                println!(
                                                                    "zeta / count: {:?} / s: {:?}",
                                                                    4, v378
                                                                );
                                                                {
                                                                    let v380: num_complex::Complex<
                                                                        f64,
                                                                    > = Math::method13(
                                                                        v378.clone(),
                                                                    );
                                                                    if v380.re > 1.0_f64 {
                                                                        let v385: f64 =
                                                                            Math::method3(
                                                                                Math::method30(),
                                                                            );
                                                                        let v386: f64 =
                                                                            Math::method4();
                                                                        let v388:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(v385, v386);
                                                                        let v389: Array<i32> =
                                                                            new_init(
                                                                                &0_i32, 10000_i32,
                                                                            );
                                                                        let v390: LrcPtr<
                                                                            Math::Mut0,
                                                                        > = LrcPtr::new(
                                                                            Math::Mut0 {
                                                                                l0: MutCell::new(
                                                                                    0_i32,
                                                                                ),
                                                                            },
                                                                        );
                                                                        while Math::method31(
                                                                            v390.clone(),
                                                                        ) {
                                                                            let v392: i32 = v390
                                                                                .l0
                                                                                .get()
                                                                                .clone();
                                                                            v389.get_mut()
                                                                                [v392 as usize] =
                                                                                v392;
                                                                            {
                                                                                let v393: i32 =
                                                                                    v392 + 1_i32;
                                                                                v390.l0.set(v393);
                                                                                ()
                                                                            }
                                                                        }
                                                                        {
                                                                            let v394: i32 =
                                                                                count(v389.clone());
                                                                            let v395: LrcPtr<
                                                                                Math::Mut2,
                                                                            > = LrcPtr::new(
                                                                                Math::Mut2 {
                                                                                    l0:
                                                                                        MutCell::new(
                                                                                            0_i32,
                                                                                        ),
                                                                                    l1:
                                                                                        MutCell::new(
                                                                                            v388,
                                                                                        ),
                                                                                },
                                                                            );
                                                                            while Math::method32(
                                                                                v394,
                                                                                v395.clone(),
                                                                            ) {
                                                                                let v397: i32 =
                                                                                    v395.l0
                                                                                        .get()
                                                                                        .clone();
                                                                                let v398:
                                                                                                    num_complex::Complex<f64> =
                                                                                                v395.l1.get().clone();
                                                                                let v399: i32 =
                                                                                    v389[v397]
                                                                                        .clone();
                                                                                let v401:
                                                                                                    f64 =
                                                                                                Math::method3(Math::method33());
                                                                                let v402: f64 =
                                                                                    Math::method4();
                                                                                let v404:
                                                                                                    num_complex::Complex<f64> =
                                                                                                num_complex::Complex::new(v401, v402);
                                                                                let v407:
                                                                                                    f64 =
                                                                                                Math::method3(Math::method25(v399
                                                                                                                                 as
                                                                                                                                 f64));
                                                                                let v408: f64 =
                                                                                    Math::method4();
                                                                                let v411:
                                                                                                    num_complex::Complex<f64> =
                                                                                                Math::method34(num_complex::Complex::new(v407, v408));
                                                                                let v412:
                                                                                                    num_complex::Complex<f64> =
                                                                                                Math::method35(v378.clone());
                                                                                let v414:
                                                                                                    num_complex::Complex<f64> =
                                                                                                num_complex::Complex::powc(v411, v412);
                                                                                let v416:
                                                                                                    num_complex::Complex<f64> =
                                                                                                v404 / v414;
                                                                                let v418:
                                                                                                    num_complex::Complex<f64> =
                                                                                                v398 + v416;
                                                                                let v419: i32 =
                                                                                    v397 + 1_i32;
                                                                                v395.l0.set(v419);
                                                                                v395.l1.set(v418);
                                                                                ()
                                                                            }
                                                                            v395.l1.get().clone()
                                                                        }
                                                                    } else {
                                                                        let v422: f64 =
                                                                            Math::method3(
                                                                                Math::method33(),
                                                                            );
                                                                        let v423: f64 =
                                                                            Math::method4();
                                                                        let v425:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(v422, v423);
                                                                        let v431:
                                                                                            Result<num_complex::Complex<f64>,
                                                                                                   pyo3::PyErr> =
                                                                                        Math::method27(Math::method36(v0_1,
                                                                                                                      string("    s = mpmath.gamma(s)"),
                                                                                                                      Math::method8(v425 - v378)));
                                                                        let v433:
                                                                                            num_complex::Complex<f64> =
                                                                                        v431.unwrap();
                                                                        let v435: f64 =
                                                                            Math::method3(
                                                                                Math::method37(),
                                                                            );
                                                                        let v436: f64 =
                                                                            Math::method4();
                                                                        let v438:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(v435, v436);
                                                                        let v440:
                                                                                            num_complex::Complex<f64> =
                                                                                        v438 * v378;
                                                                        let v442: f64 =
                                                                            Math::method3(
                                                                                Math::method2(),
                                                                            );
                                                                        let v443: f64 =
                                                                            Math::method4();
                                                                        let v445:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(v442, v443);
                                                                        let v447:
                                                                                            num_complex::Complex<f64> =
                                                                                        v440 / v445;
                                                                        let v449:
                                                                                            num_complex::Complex<f64> =
                                                                                        v447.sin();
                                                                        let v450:
                                                                                            num_complex::Complex<f64> =
                                                                                        Math::method13(v378.clone());
                                                                        let v453: f64 =
                                                                            1.0_f64 - v450.re;
                                                                        let v454:
                                                                                            num_complex::Complex<f64> =
                                                                                        Math::method14(v378.clone());
                                                                        let v457: f64 = -v454.im;
                                                                        let v459: f64 =
                                                                            Math::method3(
                                                                                Math::method25(
                                                                                    v453,
                                                                                ),
                                                                            );
                                                                        let v460: f64 =
                                                                            Math::method26(v457);
                                                                        let v462:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(v459, v460);
                                                                        let v463:
                                                                                            num_complex::Complex<f64> =
                                                                                        Math::method13(v462.clone());
                                                                        let v472:
                                                                                            num_complex::Complex<f64> =
                                                                                        if v463.re
                                                                                               <=
                                                                                               1.0_f64
                                                                                           {
                                                                                            let v468:
                                                                                                    f64 =
                                                                                                Math::method3(Math::method30());
                                                                                            let v469:
                                                                                                    f64 =
                                                                                                Math::method4();
                                                                                            num_complex::Complex::new(v468, v469)
                                                                                        } else {
                                                                                            v462
                                                                                        };
                                                                        let v474: f64 =
                                                                            Math::method3(
                                                                                Math::method2(),
                                                                            );
                                                                        let v475: f64 =
                                                                            Math::method4();
                                                                        let v477:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::new(v474, v475);
                                                                        let v479: f64 =
                                                                            Math::method3(
                                                                                Math::method37(),
                                                                            );
                                                                        let v480: f64 =
                                                                            Math::method4();
                                                                        let v483:
                                                                                            num_complex::Complex<f64> =
                                                                                        Math::method34(num_complex::Complex::new(v479, v480));
                                                                        let v484:
                                                                                            num_complex::Complex<f64> =
                                                                                        Math::method35(v378.clone());
                                                                        let v486:
                                                                                            num_complex::Complex<f64> =
                                                                                        num_complex::Complex::powc(v483, v484);
                                                                        let v488:
                                                                                            num_complex::Complex<f64> =
                                                                                        v477 * v486;
                                                                        let v490:
                                                                                            num_complex::Complex<f64> =
                                                                                        v488 * v449;
                                                                        let v492:
                                                                                            num_complex::Complex<f64> =
                                                                                        v490 * v433;
                                                                        v492 * v472
                                                                    }
                                                                }
                                                            };
                                                        let v498: f64 =
                                                            Math::method3(Math::method2());
                                                        let v499: f64 = Math::method4();
                                                        let v501: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(v498, v499);
                                                        let v503: f64 =
                                                            Math::method3(Math::method37());
                                                        let v504: f64 = Math::method4();
                                                        let v507: num_complex::Complex<f64> =
                                                            Math::method34(
                                                                num_complex::Complex::new(
                                                                    v503, v504,
                                                                ),
                                                            );
                                                        let v508: num_complex::Complex<f64> =
                                                            Math::method35(v284.clone());
                                                        let v510: num_complex::Complex<f64> =
                                                            num_complex::Complex::powc(v507, v508);
                                                        let v512: num_complex::Complex<f64> =
                                                            v501 * v510;
                                                        let v514: num_complex::Complex<f64> =
                                                            v512 * v355;
                                                        let v516: num_complex::Complex<f64> =
                                                            v514 * v339;
                                                        v516 * v496
                                                    }
                                                }
                                            };
                                            let v522: f64 = Math::method3(Math::method2());
                                            let v523: f64 = Math::method4();
                                            let v525: num_complex::Complex<f64> =
                                                num_complex::Complex::new(v522, v523);
                                            let v527: f64 = Math::method3(Math::method37());
                                            let v528: f64 = Math::method4();
                                            let v531: num_complex::Complex<f64> = Math::method34(
                                                num_complex::Complex::new(v527, v528),
                                            );
                                            let v532: num_complex::Complex<f64> =
                                                Math::method35(v190.clone());
                                            let v534: num_complex::Complex<f64> =
                                                num_complex::Complex::powc(v531, v532);
                                            let v536: num_complex::Complex<f64> = v525 * v534;
                                            let v538: num_complex::Complex<f64> = v536 * v261;
                                            let v540: num_complex::Complex<f64> = v538 * v245;
                                            v540 * v520
                                        }
                                    }
                                };
                                let v546: f64 = Math::method3(Math::method2());
                                let v547: f64 = Math::method4();
                                let v549: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v546, v547);
                                let v551: f64 = Math::method3(Math::method37());
                                let v552: f64 = Math::method4();
                                let v555: num_complex::Complex<f64> =
                                    Math::method34(num_complex::Complex::new(v551, v552));
                                let v556: num_complex::Complex<f64> = Math::method35(v96.clone());
                                let v558: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v555, v556);
                                let v560: num_complex::Complex<f64> = v549 * v558;
                                let v562: num_complex::Complex<f64> = v560 * v167;
                                let v564: num_complex::Complex<f64> = v562 * v151;
                                v564 * v544
                            }
                        }
                    };
                    let v570: f64 = Math::method3(Math::method2());
                    let v571: f64 = Math::method4();
                    let v573: num_complex::Complex<f64> = num_complex::Complex::new(v570, v571);
                    let v575: f64 = Math::method3(Math::method37());
                    let v576: f64 = Math::method4();
                    let v579: num_complex::Complex<f64> =
                        Math::method34(num_complex::Complex::new(v575, v576));
                    let v580: num_complex::Complex<f64> = Math::method35(v2.clone());
                    let v582: num_complex::Complex<f64> = num_complex::Complex::powc(v579, v580);
                    let v584: num_complex::Complex<f64> = v573 * v582;
                    let v586: num_complex::Complex<f64> = v584 * v73;
                    let v588: num_complex::Complex<f64> = v586 * v57;
                    v588 * v568
                }
            }
        }
        pub fn method38(v0_1: bool) -> bool {
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
                let v22: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method27(Math::method9(
                        v0_1.clone(),
                        string("    s = mpmath.zeta(s)"),
                        Math::method8(v17.clone()),
                    ));
                let v24: num_complex::Complex<f64> = v22.unwrap();
                let v25: num_complex::Complex<f64> = Math::method28(v0_1.clone(), v17);
                let v26: num_complex::Complex<f64> = Math::method14(v24.clone());
                let v28: f64 = v26.im;
                let v29: bool = v28 == 0.0_f64;
                if (if v29 { true } else { Math::method38(v29) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v28, 0.0_f64),
                    );
                }
                {
                    let v34: num_complex::Complex<f64> = Math::method13(v24);
                    let v37: f64 = v34.re - patternInput.1.clone();
                    let v38: f64 = -v37;
                    let v40: f64 = if v37 >= v38 { v37 } else { v38 };
                    let v41: bool = v40 < 0.0001_f64;
                    if (if v41 { true } else { Math::method38(v41) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v40, 0.0001_f64),
                        );
                    }
                    {
                        let v46: i32 = v16 + 1_i32;
                        v14.l0.set(v46);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method39(v0_1: Result<(), pyo3::PyErr>) -> Result<(), pyo3::PyErr> {
            v0_1
        }
        pub fn method40(v0_1: Result<(), pyo3::PyErr>) -> Result<(), pyo3::PyErr> {
            v0_1
        }
        pub fn method0() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method1(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method39(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method40(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method43() -> f64 {
            -2.0_f64
        }
        pub fn method42(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method2());
            let v3: f64 = Math::method43();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v9: Result<num_complex::Complex<f64>, pyo3::PyErr> = Math::method27(Math::method9(
                v0_1.clone(),
                string("    s = mpmath.zeta(s)"),
                Math::method8(v5.clone()),
            ));
            let v11: num_complex::Complex<f64> = v9.unwrap();
            let v12: num_complex::Complex<f64> = Math::method28(v0_1, v5);
            let v13: num_complex::Complex<f64> = Math::method13(v11.clone());
            let v16: f64 = v13.re - 0.8673_f64;
            let v17: f64 = -v16;
            let v19: f64 = if v16 >= v17 { v16 } else { v17 };
            let v20: bool = v19 < 0.001_f64;
            if (if v20 { true } else { Math::method38(v20) }) == false {
                panic!(
                    "{}",
                    sprintf!("__expect / actual: {:?} / expected: {:?}", v19, 0.001_f64),
                );
            }
            {
                let v25: num_complex::Complex<f64> = Math::method14(v11);
                let v28: f64 = v25.im - 0.275_f64;
                let v29: f64 = -v28;
                let v31: f64 = if v28 >= v29 { v28 } else { v29 };
                let v32: bool = v31 < 0.001_f64;
                if (if v32 { true } else { Math::method38(v32) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v31, 0.001_f64),
                    );
                }
            }
        }
        pub fn method41() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method42(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method39(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method40(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method46() -> LrcPtr<Math::UH0> {
            LrcPtr::new(Math::UH0::UH0_0(-2.0_f64,
                                         LrcPtr::new(Math::UH0::UH0_0(-4.0_f64,
                                                                      LrcPtr::new(Math::UH0::UH0_0(-6.0_f64,
                                                                                                   LrcPtr::new(Math::UH0::UH0_0(-8.0_f64,
                                                                                                                                LrcPtr::new(Math::UH0::UH0_0(-10.0_f64,
                                                                                                                                                             LrcPtr::new(Math::UH0::UH0_0(-12.0_f64,
                                                                                                                                                                                          LrcPtr::new(Math::UH0::UH0_0(-14.0_f64,
                                                                                                                                                                                                                       LrcPtr::new(Math::UH0::UH0_0(-16.0_f64,
                                                                                                                                                                                                                                                    LrcPtr::new(Math::UH0::UH0_0(-18.0_f64,
                                                                                                                                                                                                                                                                                 LrcPtr::new(Math::UH0::UH0_0(-20.0_f64,
                                                                                                                                                                                                                                                                                                              LrcPtr::new(Math::UH0::UH0_0(-22.0_f64,
                                                                                                                                                                                                                                                                                                                                           LrcPtr::new(Math::UH0::UH0_0(-24.0_f64,
                                                                                                                                                                                                                                                                                                                                                                        LrcPtr::new(Math::UH0::UH0_0(-26.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                     LrcPtr::new(Math::UH0::UH0_0(-28.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                                                  LrcPtr::new(Math::UH0::UH0_0(-30.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                                                                               LrcPtr::new(Math::UH0::UH0_0(-32.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            LrcPtr::new(Math::UH0::UH0_0(-34.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         LrcPtr::new(Math::UH0::UH0_0(-36.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      LrcPtr::new(Math::UH0::UH0_0(-38.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   LrcPtr::new(Math::UH0::UH0_0(-40.0_f64,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                LrcPtr::new(Math::UH0::UH0_1)))))))))))))))))))))))))))))))))))))))))
        }
        pub fn method47(v0_1: pyo3::Python, v1_1: LrcPtr<Math::UH0>) {
            let v0_1: MutCell<pyo3::Python> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1_1.clone());
            '_method47: loop {
                break '_method47 (match v1_1.get().clone().as_ref() {
                    Math::UH0::UH0_1 => (),
                    Math::UH0::UH0_0(v1_1_0_0, v1_1_0_1) => {
                        let v5: f64 = Math::method3(Math::method25(v1_1_0_0.clone()));
                        let v6: f64 = Math::method4();
                        let v8: num_complex::Complex<f64> = num_complex::Complex::new(v5, v6);
                        let v12: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                            Math::method27(Math::method9(
                                v0_1.get().clone(),
                                string("    s = mpmath.zeta(s)"),
                                Math::method8(v8.clone()),
                            ));
                        let v14: num_complex::Complex<f64> = v12.unwrap();
                        let v15: num_complex::Complex<f64> = Math::method28(v0_1.get().clone(), v8);
                        let v16: num_complex::Complex<f64> = Math::method13(v14.clone());
                        let v18: f64 = v16.re;
                        let v19: bool = v18 == 0.0_f64;
                        if (if v19 { true } else { Math::method38(v19) }) == false {
                            panic!(
                                "{}",
                                sprintf!("__expect / actual: {:?} / expected: {:?}", v18, 0.0_f64),
                            );
                        }
                        {
                            let v24: num_complex::Complex<f64> = Math::method14(v14);
                            let v26: f64 = v24.im;
                            let v27: bool = v26 == 0.0_f64;
                            if (if v27 { true } else { Math::method38(v27) }) == false {
                                panic!(
                                    "{}",
                                    sprintf!(
                                        "__expect / actual: {:?} / expected: {:?}",
                                        v26,
                                        0.0_f64
                                    ),
                                );
                            }
                            {
                                let v0_1_temp: pyo3::Python = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<Math::UH0> = v1_1_0_1.clone();
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
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method45(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method39(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method40(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method50() -> f64 {
            0.5_f64
        }
        pub fn method51() -> f64 {
            14.134725_f64
        }
        pub fn method52() -> f64 {
            21.02204_f64
        }
        pub fn method53() -> f64 {
            25.010857_f64
        }
        pub fn method54() -> f64 {
            30.424876_f64
        }
        pub fn method55() -> f64 {
            32.935062_f64
        }
        pub fn method56() -> f64 {
            37.586178_f64
        }
        pub fn method57(
            v0_1: Array<num_complex::Complex<f64>>,
        ) -> Array<num_complex::Complex<f64>> {
            v0_1
        }
        pub fn method49(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method50());
            let v3: f64 = Math::method51();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v7: f64 = Math::method3(Math::method50());
            let v8: f64 = Math::method52();
            let v10: num_complex::Complex<f64> = num_complex::Complex::new(v7, v8);
            let v12: f64 = Math::method3(Math::method50());
            let v13: f64 = Math::method53();
            let v15: num_complex::Complex<f64> = num_complex::Complex::new(v12, v13);
            let v17: f64 = Math::method3(Math::method50());
            let v18: f64 = Math::method54();
            let v20: num_complex::Complex<f64> = num_complex::Complex::new(v17, v18);
            let v22: f64 = Math::method3(Math::method50());
            let v23: f64 = Math::method55();
            let v25: num_complex::Complex<f64> = num_complex::Complex::new(v22, v23);
            let v27: f64 = Math::method3(Math::method50());
            let v28: f64 = Math::method56();
            let v32: Array<num_complex::Complex<f64>> = Math::method57(new_array(&[
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
                let v41: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method27(Math::method9(
                        v0_1.clone(),
                        string("    s = mpmath.zeta(s)"),
                        Math::method8(v37.clone()),
                    ));
                let v43: num_complex::Complex<f64> = v41.unwrap();
                let v44: num_complex::Complex<f64> = Math::method28(v0_1.clone(), v37);
                let v45: num_complex::Complex<f64> = Math::method13(v43.clone());
                let v47: f64 = v45.re;
                let v48: f64 = -v47;
                let v50: f64 = if v47 >= v48 { v47 } else { v48 };
                let v51: bool = v50 < 0.0001_f64;
                if (if v51 { true } else { Math::method38(v51) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v50, 0.0001_f64),
                    );
                }
                {
                    let v56: num_complex::Complex<f64> = Math::method14(v43);
                    let v58: f64 = v56.im;
                    let v59: f64 = -v58;
                    let v61: f64 = if v58 >= v59 { v58 } else { v59 };
                    let v62: bool = v61 < 0.0001_f64;
                    if (if v62 { true } else { Math::method38(v62) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v61, 0.0001_f64),
                        );
                    }
                    {
                        let v67: i32 = v36 + 1_i32;
                        v34.l0.set(v67);
                        ()
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
                    let v5: Result<(), pyo3::PyErr> = Math::method39(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method40(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method60(v0_1: Array<f64>) -> Array<f64> {
            v0_1
        }
        pub fn method59(v0_1: pyo3::Python) {
            let v2: Array<f64> = Math::method60(new_array(&[
                2.0_f64, 3.0_f64, 4.0_f64, 5.0_f64, 10.0_f64, 20.0_f64, 50.0_f64,
            ]));
            let v3: i32 = count(v2.clone());
            let v4: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method7(v3, v4.clone()) {
                let v6: i32 = v4.l0.get().clone();
                let v9: f64 = Math::method3(Math::method25(v2[v6].clone()));
                let v10: f64 = Math::method4();
                let v12: num_complex::Complex<f64> = num_complex::Complex::new(v9, v10);
                let v16: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method27(Math::method9(
                        v0_1.clone(),
                        string("    s = mpmath.zeta(s)"),
                        Math::method8(v12.clone()),
                    ));
                let v18: num_complex::Complex<f64> = v16.unwrap();
                let v19: num_complex::Complex<f64> = Math::method28(v0_1.clone(), v12);
                let v20: num_complex::Complex<f64> = Math::method13(v18.clone());
                let v22: f64 = v20.re;
                let v23: bool = v22 > 0.0_f64;
                if (if v23 { true } else { Math::method38(v23) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v22, 0.0_f64),
                    );
                }
                {
                    let v28: num_complex::Complex<f64> = Math::method14(v18);
                    let v30: f64 = v28.im;
                    let v31: bool = v30 == 0.0_f64;
                    if (if v31 { true } else { Math::method38(v31) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v30, 0.0_f64),
                        );
                    }
                    {
                        let v36: i32 = v6 + 1_i32;
                        v4.l0.set(v36);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method58() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method59(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method39(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method40(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method62(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method33());
            let v3: f64 = Math::method4();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v9: Result<num_complex::Complex<f64>, pyo3::PyErr> = Math::method27(Math::method9(
                v0_1.clone(),
                string("    s = mpmath.zeta(s)"),
                Math::method8(v5.clone()),
            ));
            let v11: num_complex::Complex<f64> = v9.unwrap();
            let v12: num_complex::Complex<f64> = Math::method28(v0_1, v5);
            let v13: num_complex::Complex<f64> = Math::method13(v11.clone());
            let v15: f64 = v13.re;
            let v16: bool = v15 == f64::INFINITY;
            if (if v16 { true } else { Math::method38(v16) }) == false {
                panic!(
                    "{}",
                    sprintf!(
                        "__expect / actual: {:?} / expected: {:?}",
                        v15,
                        f64::INFINITY
                    ),
                );
            }
            {
                let v21: num_complex::Complex<f64> = Math::method14(v11);
                let v23: f64 = v21.im;
                let v24: bool = v23 == 0.0_f64;
                if (if v24 { true } else { Math::method38(v24) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v23, 0.0_f64),
                    );
                }
            }
        }
        pub fn method61() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method62(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method39(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method40(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method65() -> f64 {
            10.0_f64
        }
        pub fn method64(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method2());
            let v3: f64 = Math::method65();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v9: Result<num_complex::Complex<f64>, pyo3::PyErr> = Math::method27(Math::method9(
                v0_1.clone(),
                string("    s = mpmath.zeta(s)"),
                Math::method8(v5.clone()),
            ));
            let v11: num_complex::Complex<f64> = v9.unwrap();
            let v12: num_complex::Complex<f64> = Math::method28(v0_1.clone(), v5.clone());
            let v13: num_complex::Complex<f64> = Math::method13(v5.clone());
            let v15: f64 = v13.re;
            let v16: num_complex::Complex<f64> = Math::method14(v5);
            let v19: f64 = -v16.im;
            let v21: f64 = Math::method3(Math::method25(v15));
            let v22: f64 = Math::method26(v19);
            let v24: num_complex::Complex<f64> = num_complex::Complex::new(v21, v22);
            let v28: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                Math::method27(Math::method9(
                    v0_1.clone(),
                    string("    s = mpmath.zeta(s)"),
                    Math::method8(v24.clone()),
                ));
            let v30: num_complex::Complex<f64> = v28.unwrap();
            let v31: num_complex::Complex<f64> = Math::method28(v0_1, v24);
            let v33: num_complex::Complex<f64> = v30.conj();
            let v34: num_complex::Complex<f64> = Math::method13(v11.clone());
            let v36: f64 = v34.re;
            let v37: num_complex::Complex<f64> = Math::method13(v33.clone());
            let v39: f64 = v37.re;
            let v40: bool = v36 == v39;
            if (if v40 { true } else { Math::method38(v40) }) == false {
                panic!(
                    "{}",
                    sprintf!("__expect / actual: {:?} / expected: {:?}", v36, v39),
                );
            }
            {
                let v45: num_complex::Complex<f64> = Math::method14(v11);
                let v47: f64 = v45.im;
                let v48: num_complex::Complex<f64> = Math::method14(v33);
                let v50: f64 = v48.im;
                let v51: bool = v47 == v50;
                if (if v51 { true } else { Math::method38(v51) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v47, v50),
                    );
                }
            }
        }
        pub fn method63() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method64(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method39(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method40(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method68() -> f64 {
            0.01_f64
        }
        pub fn method69() -> f64 {
            0.01_f64
        }
        pub fn method67(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method68());
            let v3: f64 = Math::method69();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v9: Result<num_complex::Complex<f64>, pyo3::PyErr> = Math::method27(Math::method9(
                v0_1.clone(),
                string("    s = mpmath.zeta(s)"),
                Math::method8(v5.clone()),
            ));
            let v11: num_complex::Complex<f64> = v9.unwrap();
            let v12: num_complex::Complex<f64> = Math::method28(v0_1, v5);
            let v13: num_complex::Complex<f64> = Math::method13(v11.clone());
            let v15: f64 = v13.re;
            let v16: bool = v15 < f64::INFINITY;
            if (if v16 { true } else { Math::method38(v16) }) == false {
                panic!(
                    "{}",
                    sprintf!(
                        "__expect / actual: {:?} / expected: {:?}",
                        v15,
                        f64::INFINITY
                    ),
                );
            }
            {
                let v21: num_complex::Complex<f64> = Math::method14(v11);
                let v23: f64 = v21.im;
                let v24: bool = v23 < f64::INFINITY;
                if (if v24 { true } else { Math::method38(v24) }) == false {
                    panic!(
                        "{}",
                        sprintf!(
                            "__expect / actual: {:?} / expected: {:?}",
                            v23,
                            f64::INFINITY
                        ),
                    );
                }
            }
        }
        pub fn method66() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method67(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method39(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method40(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method72() -> Array<f64> {
            Math::method60(new_array(&[
                10.0_f64, 20.0_f64, 30.0_f64, 40.0_f64, 50.0_f64, 60.0_f64, 70.0_f64, 80.0_f64,
                90.0_f64, 100.0_f64,
            ]))
        }
        pub fn method73(v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn method71(v0_1: pyo3::Python) {
            let v1_1: Array<f64> = Math::method72();
            let v2: i32 = count(v1_1.clone());
            let v3: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method7(v2, v3.clone()) {
                let v5: i32 = v3.l0.get().clone();
                let v6: f64 = v1_1[v5].clone();
                let v8: f64 = Math::method3(Math::method30());
                let v9: f64 = Math::method26(v6);
                let v11: num_complex::Complex<f64> = num_complex::Complex::new(v8, v9);
                let v15: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method27(Math::method9(
                        v0_1.clone(),
                        string("    s = mpmath.zeta(s)"),
                        Math::method8(v11.clone()),
                    ));
                let v17: num_complex::Complex<f64> = v15.unwrap();
                let v18: num_complex::Complex<f64> = Math::method28(v0_1.clone(), v11);
                let v19: num_complex::Complex<f64> = Math::method13(v17.clone());
                let v21: f64 = v19.re;
                let v23: bool = Math::method73(v21 == 0.0_f64);
                if (if v23 { true } else { Math::method38(v23) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v21, 0.0_f64),
                    );
                }
                {
                    let v28: num_complex::Complex<f64> = Math::method14(v17);
                    let v30: f64 = v28.im;
                    let v32: bool = Math::method73(v30 == 0.0_f64);
                    if (if v32 { true } else { Math::method38(v32) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v30, 0.0_f64),
                        );
                    }
                    {
                        let v37: i32 = v5 + 1_i32;
                        v3.l0.set(v37);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method70() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method71(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method39(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method40(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method76() -> f64 {
            0.75_f64
        }
        pub fn method77() -> f64 {
            20.5_f64
        }
        pub fn method78() -> f64 {
            1.25_f64
        }
        pub fn method79() -> f64 {
            30.1_f64
        }
        pub fn method80() -> f64 {
            0.25_f64
        }
        pub fn method81() -> f64 {
            40.0_f64
        }
        pub fn method82() -> f64 {
            50.0_f64
        }
        pub fn method75(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method50());
            let v3: f64 = Math::method51();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v7: f64 = Math::method3(Math::method76());
            let v8: f64 = Math::method77();
            let v10: num_complex::Complex<f64> = num_complex::Complex::new(v7, v8);
            let v12: f64 = Math::method3(Math::method78());
            let v13: f64 = Math::method79();
            let v15: num_complex::Complex<f64> = num_complex::Complex::new(v12, v13);
            let v17: f64 = Math::method3(Math::method80());
            let v18: f64 = Math::method81();
            let v20: num_complex::Complex<f64> = num_complex::Complex::new(v17, v18);
            let v22: f64 = Math::method3(Math::method33());
            let v23: f64 = Math::method82();
            let v27: Array<num_complex::Complex<f64>> = Math::method57(new_array(&[
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
                let v36: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method27(Math::method9(
                        v0_1.clone(),
                        string("    s = mpmath.zeta(s)"),
                        Math::method8(v32.clone()),
                    ));
                let v38: num_complex::Complex<f64> = v36.unwrap();
                let v39: num_complex::Complex<f64> = Math::method28(v0_1.clone(), v32);
                let v40: num_complex::Complex<f64> = Math::method13(v38.clone());
                let v42: f64 = v40.re;
                let v44: bool = Math::method73(v42 == 0.0_f64);
                if (if v44 { true } else { Math::method38(v44) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v42, 0.0_f64),
                    );
                }
                {
                    let v49: num_complex::Complex<f64> = Math::method14(v38);
                    let v51: f64 = v49.im;
                    let v53: bool = Math::method73(v51 == 0.0_f64);
                    if (if v53 { true } else { Math::method38(v53) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v51, 0.0_f64),
                        );
                    }
                    {
                        let v58: i32 = v31 + 1_i32;
                        v29.l0.set(v58);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method74() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method75(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method39(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method40(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method85() -> f64 {
            3.0_f64
        }
        pub fn method86() -> f64 {
            4.0_f64
        }
        pub fn method87() -> f64 {
            2.5_f64
        }
        pub fn method88() -> f64 {
            -3.5_f64
        }
        pub fn method89() -> f64 {
            1.5_f64
        }
        pub fn method90() -> f64 {
            2.5_f64
        }
        pub fn method84(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method85());
            let v3: f64 = Math::method86();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v7: f64 = Math::method3(Math::method87());
            let v8: f64 = Math::method88();
            let v10: num_complex::Complex<f64> = num_complex::Complex::new(v7, v8);
            let v12: f64 = Math::method3(Math::method89());
            let v13: f64 = Math::method90();
            let v15: num_complex::Complex<f64> = num_complex::Complex::new(v12, v13);
            let v17: f64 = Math::method3(Math::method50());
            let v18: f64 = Math::method51();
            let v22: Array<num_complex::Complex<f64>> = Math::method57(new_array(&[
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
                let v31: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method27(Math::method9(
                        v0_1.clone(),
                        string("    s = mpmath.zeta(s)"),
                        Math::method8(v27.clone()),
                    ));
                let v33: num_complex::Complex<f64> = v31.unwrap();
                let v34: num_complex::Complex<f64> = Math::method28(v0_1.clone(), v27.clone());
                let v36: f64 = Math::method3(Math::method2());
                let v37: f64 = Math::method4();
                let v40: num_complex::Complex<f64> =
                    Math::method34(num_complex::Complex::new(v36, v37));
                let v41: num_complex::Complex<f64> = Math::method35(v27.clone());
                let v43: num_complex::Complex<f64> = num_complex::Complex::powc(v40, v41);
                let v45: f64 = Math::method3(Math::method37());
                let v46: f64 = Math::method4();
                let v48: num_complex::Complex<f64> = num_complex::Complex::new(v45, v46);
                let v50: f64 = Math::method3(Math::method33());
                let v51: f64 = Math::method4();
                let v53: num_complex::Complex<f64> = num_complex::Complex::new(v50, v51);
                let v55: num_complex::Complex<f64> = v27 - v53;
                let v56: num_complex::Complex<f64> = Math::method34(v48);
                let v57: num_complex::Complex<f64> = Math::method35(v55);
                let v59: num_complex::Complex<f64> = num_complex::Complex::powc(v56, v57);
                let v61: num_complex::Complex<f64> = v43 * v59;
                let v63: f64 = Math::method3(Math::method37());
                let v64: f64 = Math::method4();
                let v66: num_complex::Complex<f64> = num_complex::Complex::new(v63, v64);
                let v68: num_complex::Complex<f64> = v66 * v27;
                let v70: f64 = Math::method3(Math::method2());
                let v71: f64 = Math::method4();
                let v73: num_complex::Complex<f64> = num_complex::Complex::new(v70, v71);
                let v75: num_complex::Complex<f64> = v68 / v73;
                let v77: num_complex::Complex<f64> = v75.sin();
                let v79: num_complex::Complex<f64> = v61 * v77;
                let v81: f64 = Math::method3(Math::method33());
                let v82: f64 = Math::method4();
                let v84: num_complex::Complex<f64> = num_complex::Complex::new(v81, v82);
                let v90: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method27(Math::method36(
                        v0_1.clone(),
                        string("    s = mpmath.gamma(s)"),
                        Math::method8(v84 - v27),
                    ));
                let v92: num_complex::Complex<f64> = v90.unwrap();
                let v94: num_complex::Complex<f64> = v79 * v92;
                let v95: num_complex::Complex<f64> = Math::method13(v27.clone());
                let v98: f64 = 1.0_f64 - v95.re;
                let v99: num_complex::Complex<f64> = Math::method14(v27);
                let v102: f64 = -v99.im;
                let v104: f64 = Math::method3(Math::method25(v98));
                let v105: f64 = Math::method26(v102);
                let v107: num_complex::Complex<f64> = num_complex::Complex::new(v104, v105);
                let v111: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method27(Math::method9(
                        v0_1.clone(),
                        string("    s = mpmath.zeta(s)"),
                        Math::method8(v107.clone()),
                    ));
                let v113: num_complex::Complex<f64> = v111.unwrap();
                let v114: num_complex::Complex<f64> = Math::method28(v0_1.clone(), v107);
                let v116: num_complex::Complex<f64> = v94 * v113;
                let v117: num_complex::Complex<f64> = Math::method13(v33.clone());
                let v119: f64 = v117.re;
                let v120: num_complex::Complex<f64> = Math::method13(v116.clone());
                let v123: f64 = v119 - v120.re;
                let v124: f64 = -v123;
                let v126: f64 = if v123 >= v124 { v123 } else { v124 };
                let v127: bool = v126 < 0.0001_f64;
                if (if v127 { true } else { Math::method38(v127) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v126, 0.0001_f64),
                    );
                }
                {
                    let v132: num_complex::Complex<f64> = Math::method14(v33);
                    let v134: f64 = v132.im;
                    let v135: num_complex::Complex<f64> = Math::method14(v116);
                    let v138: f64 = v134 - v135.im;
                    let v139: f64 = -v138;
                    let v141: f64 = if v138 >= v139 { v138 } else { v139 };
                    let v142: bool = v141 < 0.0001_f64;
                    if (if v142 { true } else { Math::method38(v142) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v141, 0.0001_f64),
                        );
                    }
                    {
                        let v147: i32 = v26 + 1_i32;
                        v24.l0.set(v147);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method83() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method84(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method39(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method40(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method93(v0_1: i32, v1_1: LrcPtr<Math::Mut3>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method92(v0_1: pyo3::Python) {
            let v2: Array<f64> = Math::method60(new_array(&[
                2.0_f64, 2.5_f64, 3.0_f64, 3.5_f64, 4.0_f64, 4.5_f64, 5.0_f64,
            ]));
            let v4: Array<f64> = Math::method60(new_array(&[
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
                let v11: f64 = Math::method3(Math::method25(v9));
                let v12: f64 = Math::method4();
                let v14: num_complex::Complex<f64> = num_complex::Complex::new(v11, v12);
                let v15: i32 = count(v4.clone());
                let v16: LrcPtr<Math::Mut3> = LrcPtr::new(Math::Mut3 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(1.0_f64),
                });
                while Math::method93(v15, v16.clone()) {
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
                    let v30: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                        Math::method27(Math::method9(
                            v0_1.clone(),
                            string("    s = mpmath.zeta(s)"),
                            Math::method8(v14.clone()),
                        ));
                    let v32: num_complex::Complex<f64> = v30.unwrap();
                    let v33: num_complex::Complex<f64> = Math::method28(v0_1.clone(), v14);
                    let v34: num_complex::Complex<f64> = Math::method13(v32.clone());
                    let v37: f64 = v34.re - v26;
                    let v38: f64 = -v37;
                    let v40: f64 = if v37 >= v38 { v37 } else { v38 };
                    let v41: bool = v40 < 0.01_f64;
                    if (if v41 { true } else { Math::method38(v41) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v40, 0.01_f64),
                        );
                    }
                    {
                        let v46: num_complex::Complex<f64> = Math::method14(v32);
                        let v48: f64 = v46.im;
                        let v49: bool = v48 < 0.01_f64;
                        if (if v49 { true } else { Math::method38(v49) }) == false {
                            panic!(
                                "{}",
                                sprintf!("__expect / actual: {:?} / expected: {:?}", v48, 0.01_f64),
                            );
                        }
                        {
                            let v54: i32 = v8 + 1_i32;
                            v6.l0.set(v54);
                            ()
                        }
                    }
                }
            }
            ()
        }
        pub fn method91() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method92(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method39(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method40(__result);
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
            Math::method41();
        }
        #[test]
        fn test_trivial_zero_at_negative_even___() {
            //;
            Math::method44();
        }
        #[test]
        fn test_non_trivial_zero___() {
            //;
            Math::method48();
        }
        #[test]
        fn test_real_part_greater_than_one___() {
            //;
            Math::method58();
        }
        #[test]
        fn test_zeta_at_1___() {
            //;
            Math::method61();
        }
        #[test]
        fn test_symmetry_across_real_axis___() {
            //;
            Math::method63();
        }
        #[test]
        fn test_behavior_near_origin___() {
            //;
            Math::method66();
        }
        #[test]
        fn test_imaginary_axis() {
            //;
            Math::method70();
        }
        #[test]
        fn test_critical_strip() {
            //;
            Math::method74();
        }
        #[test]
        fn test_reflection_formula_for_specific_value() {
            //;
            Math::method83();
        }
        #[test]
        fn test_euler_product_formula() {
            //;
            Math::method91()
        }
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
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
            v1.get_or_insert_with(|| Func1::new(move |v: Array<string>| Math::closure1((), v)))
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
pub mod Polyglot {
    pub use crate::module_8cb3e09e::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Math::main(array_from(args));
}
