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
        pub struct Mut2 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<f64>,
        }
        impl core::fmt::Display for Math::Mut2 {
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
        pub fn method9(v0_1: Array<string>) -> Array<string> {
            v0_1
        }
        pub fn method11(v0_1: i32, v1_1: LrcPtr<Math::Mut1>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method10(v0_1: Array<string>) -> string {
            let v1_1: i32 = count(v0_1.clone());
            let v3: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                l0: MutCell::new(0_i32),
                l1: MutCell::new(string("")),
            });
            while Math::method11(v1_1, v3.clone()) {
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
        pub fn method12(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method13(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method14(v0_1: pyo3::Python) -> pyo3::Python {
            v0_1
        }
        pub fn method15(v0_1: string) -> string {
            v0_1
        }
        pub fn method16(
            v0_1: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr>,
        ) -> Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> {
            v0_1
        }
        pub fn method17() -> string {
            string("fn")
        }
        pub fn method18(
            v0_1: pyo3::Bound<pyo3::types::PyModule>,
        ) -> pyo3::Bound<pyo3::types::PyModule> {
            v0_1
        }
        pub fn method19(
            v0_1: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr>,
        ) -> Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> {
            v0_1
        }
        pub fn method20(
            v0_: bool,
            v0__1: LrcPtr<(f64, f64)>,
        ) -> LrcPtr<(bool, LrcPtr<(f64, f64)>)> {
            LrcPtr::new((v0_, v0__1))
        }
        pub fn method21(v0_1: pyo3::Bound<pyo3::PyAny>) -> pyo3::Bound<pyo3::PyAny> {
            v0_1
        }
        pub fn method22(v0_1: pyo3::Bound<pyo3::PyAny>) -> pyo3::Bound<pyo3::PyAny> {
            v0_1
        }
        pub fn method23(v0_1: Result<(f64, f64), pyo3::PyErr>) -> Result<(f64, f64), pyo3::PyErr> {
            v0_1
        }
        pub fn method24(v0_1: f64) -> f64 {
            v0_1
        }
        pub fn method25(v0_1: f64) -> f64 {
            v0_1
        }
        pub fn method8(
            v0_1: pyo3::Python,
            v1_1: num_complex::Complex<f64>,
            v2: string,
        ) -> Result<num_complex::Complex<f64>, pyo3::PyErr> {
            let v34: string =
                Math::method10(Math::method9(new_array(&[string("import sys"),
                                                         string("import traceback"),
                                                         string("count = 0"),
                                                         string("def trace_calls(frame, event, arg):"),
                                                         string("  global count"),
                                                         string("  count += 1"),
                                                         string("  if count < 500:"),
                                                         string("    try:"),
                                                         string("      args = {k: v for k, v in frame.f_locals.items() if k != \'ctx\'}"),
                                                         string("      args_str = \', \'.join([f\"{k}={repr(v)}\" for k, v in args.items()])"),
                                                         sprintf!("      print(f\'{{event}}({}) / f_code.co_name: {{frame.f_code.co_name}} / f_locals: {{args_str}} / f_lineno: {{frame.f_lineno}} / f_code.co_filename: {{frame.f_code.co_filename.split(\'site-packages\')[-1]}} / f_back.f_lineno: {{frame.f_back.f_lineno}} / f_back.f_code.co_filename: {{frame.f_back.f_code.co_filename.split(\'site-packages\')[-1]}}\', flush=True)",
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
                                                         v2,
                                                         string("    if log:"),
                                                         string("      sys.settrace(None)"),
                                                         sprintf!("      print(f\'{} / result: {{s}} / count: {{count}}\', flush=True)",
                                                                  string("zeta_")),
                                                         string("  except ValueError as e:"),
                                                         string("    if s.real == 1:"),
                                                         string("      s = complex(float(\'inf\'), 0)"),
                                                         string("  return (s.real, s.imag)")])));
            let v35: num_complex::Complex<f64> = Math::method12(v1_1.clone());
            let v37: f64 = v35.re;
            let v38: num_complex::Complex<f64> = Math::method13(v1_1);
            let v42: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v37, v38.im))));
            let v43: pyo3::Python = Math::method14(v0_1);
            let v44: string = Math::method15(v34);
            let v46: &str = fable_library_rust::String_::LrcStr::as_str(&v44);
            let v49: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                Math::method16(pyo3::types::PyModule::from_code_bound(v43, v46, "", ""));
            let v51: pyo3::Bound<pyo3::types::PyModule> = v49.unwrap();
            let v52: string = Math::method17();
            let v54: &str = fable_library_rust::String_::LrcStr::as_str(&v52);
            let v55: pyo3::Bound<pyo3::types::PyModule> = Math::method18(v51);
            let v58: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                Math::method19(v55.getattr(v54));
            let v60: pyo3::Bound<pyo3::PyAny> = v58.unwrap();
            let v61: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method20(v42.0.clone(), v42.1.clone());
            let v62: pyo3::Bound<pyo3::PyAny> = Math::method21(v60);
            let v65: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method19(
                pyo3::prelude::PyAnyMethods::call(&v62, ((*v61).0, *(*v61).1), None),
            );
            let v68: pyo3::Bound<pyo3::PyAny> = Math::method22(v65.unwrap());
            let v71: Result<(f64, f64), pyo3::PyErr> = Math::method23(v68.extract());
            let patternInput: (f64, f64) = v71.unwrap();
            let v76: f64 = Math::method3(Math::method24(patternInput.0.clone()));
            let v77: f64 = Math::method25(patternInput.1.clone());
            Ok::<num_complex::Complex<f64>, pyo3::PyErr>(num_complex::Complex::new(v76, v77))
        }
        pub fn method26(
            v0_1: Result<num_complex::Complex<f64>, pyo3::PyErr>,
        ) -> Result<num_complex::Complex<f64>, pyo3::PyErr> {
            v0_1
        }
        pub fn method27() -> f64 {
            0.0_f64
        }
        pub fn method28(v0_1: bool) -> bool {
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
                let v21: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method26(Math::method8(
                        v0_1.clone(),
                        patternInput.0.clone(),
                        string("    s = mpmath.zeta(s)"),
                    ));
                let v23: num_complex::Complex<f64> = v21.unwrap();
                let v25: f64 = Math::method3(Math::method27());
                let v26: f64 = Math::method4();
                let v28: num_complex::Complex<f64> = num_complex::Complex::new(v25, v26);
                let v29: num_complex::Complex<f64> = Math::method13(v23.clone());
                let v31: f64 = v29.im;
                let v32: bool = v31 == 0.0_f64;
                if (if v32 { true } else { Math::method28(v32) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v31, 0.0_f64),
                    );
                }
                {
                    let v37: num_complex::Complex<f64> = Math::method12(v23);
                    let v40: f64 = v37.re - patternInput.1.clone();
                    let v41: f64 = -v40;
                    let v43: f64 = if v40 >= v41 { v40 } else { v41 };
                    let v44: bool = v43 < 0.0001_f64;
                    if (if v44 { true } else { Math::method28(v44) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v43, 0.0001_f64),
                        );
                    }
                    {
                        let v49: i32 = v16 + 1_i32;
                        v14.l0.set(v49);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method29(v0_1: Result<(), pyo3::PyErr>) -> Result<(), pyo3::PyErr> {
            v0_1
        }
        pub fn method30(v0_1: Result<(), pyo3::PyErr>) -> Result<(), pyo3::PyErr> {
            v0_1
        }
        pub fn method0() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method1(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method30(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method33() -> f64 {
            -2.0_f64
        }
        pub fn method32(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method2());
            let v3: f64 = Math::method33();
            let v8: Result<num_complex::Complex<f64>, pyo3::PyErr> = Math::method26(Math::method8(
                v0_1,
                num_complex::Complex::new(v2, v3),
                string("    s = mpmath.zeta(s)"),
            ));
            let v10: num_complex::Complex<f64> = v8.unwrap();
            let v12: f64 = Math::method3(Math::method27());
            let v13: f64 = Math::method4();
            let v15: num_complex::Complex<f64> = num_complex::Complex::new(v12, v13);
            let v16: num_complex::Complex<f64> = Math::method12(v10.clone());
            let v19: f64 = v16.re - 0.8673_f64;
            let v20: f64 = -v19;
            let v22: f64 = if v19 >= v20 { v19 } else { v20 };
            let v23: bool = v22 < 0.001_f64;
            if (if v23 { true } else { Math::method28(v23) }) == false {
                panic!(
                    "{}",
                    sprintf!("__expect / actual: {:?} / expected: {:?}", v22, 0.001_f64),
                );
            }
            {
                let v28: num_complex::Complex<f64> = Math::method13(v10);
                let v31: f64 = v28.im - 0.275_f64;
                let v32: f64 = -v31;
                let v34: f64 = if v31 >= v32 { v31 } else { v32 };
                let v35: bool = v34 < 0.001_f64;
                if (if v35 { true } else { Math::method28(v35) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v34, 0.001_f64),
                    );
                }
            }
        }
        pub fn method31() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method32(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method30(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method36() -> LrcPtr<Math::UH0> {
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
        pub fn method37(v0_1: pyo3::Python, v1_1: LrcPtr<Math::UH0>) {
            let v0_1: MutCell<pyo3::Python> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1_1.clone());
            '_method37: loop {
                break '_method37 (match v1_1.get().clone().as_ref() {
                    Math::UH0::UH0_1 => (),
                    Math::UH0::UH0_0(v1_1_0_0, v1_1_0_1) => {
                        let v5: f64 = Math::method3(Math::method24(v1_1_0_0.clone()));
                        let v6: f64 = Math::method4();
                        let v11: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                            Math::method26(Math::method8(
                                v0_1.get().clone(),
                                num_complex::Complex::new(v5, v6),
                                string("    s = mpmath.zeta(s)"),
                            ));
                        let v13: num_complex::Complex<f64> = v11.unwrap();
                        let v15: f64 = Math::method3(Math::method27());
                        let v16: f64 = Math::method4();
                        let v18: num_complex::Complex<f64> = num_complex::Complex::new(v15, v16);
                        let v19: num_complex::Complex<f64> = Math::method12(v13.clone());
                        let v21: f64 = v19.re;
                        let v22: bool = v21 == 0.0_f64;
                        if (if v22 { true } else { Math::method28(v22) }) == false {
                            panic!(
                                "{}",
                                sprintf!("__expect / actual: {:?} / expected: {:?}", v21, 0.0_f64),
                            );
                        }
                        {
                            let v27: num_complex::Complex<f64> = Math::method13(v13);
                            let v29: f64 = v27.im;
                            let v30: bool = v29 == 0.0_f64;
                            if (if v30 { true } else { Math::method28(v30) }) == false {
                                panic!(
                                    "{}",
                                    sprintf!(
                                        "__expect / actual: {:?} / expected: {:?}",
                                        v29,
                                        0.0_f64
                                    ),
                                );
                            }
                            {
                                let v0_1_temp: pyo3::Python = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<Math::UH0> = v1_1_0_1.clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                continue '_method37;
                            }
                        }
                    }
                });
            }
        }
        pub fn method35(v0_1: pyo3::Python) {
            Math::method37(v0_1, Math::method36());
        }
        pub fn method34() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method35(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method30(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method40() -> f64 {
            0.5_f64
        }
        pub fn method41() -> f64 {
            14.134725_f64
        }
        pub fn method42() -> f64 {
            21.02204_f64
        }
        pub fn method43() -> f64 {
            25.010857_f64
        }
        pub fn method44() -> f64 {
            30.424876_f64
        }
        pub fn method45() -> f64 {
            32.935062_f64
        }
        pub fn method46() -> f64 {
            37.586178_f64
        }
        pub fn method47(
            v0_1: Array<num_complex::Complex<f64>>,
        ) -> Array<num_complex::Complex<f64>> {
            v0_1
        }
        pub fn method39(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method40());
            let v3: f64 = Math::method41();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v7: f64 = Math::method3(Math::method40());
            let v8: f64 = Math::method42();
            let v10: num_complex::Complex<f64> = num_complex::Complex::new(v7, v8);
            let v12: f64 = Math::method3(Math::method40());
            let v13: f64 = Math::method43();
            let v15: num_complex::Complex<f64> = num_complex::Complex::new(v12, v13);
            let v17: f64 = Math::method3(Math::method40());
            let v18: f64 = Math::method44();
            let v20: num_complex::Complex<f64> = num_complex::Complex::new(v17, v18);
            let v22: f64 = Math::method3(Math::method40());
            let v23: f64 = Math::method45();
            let v25: num_complex::Complex<f64> = num_complex::Complex::new(v22, v23);
            let v27: f64 = Math::method3(Math::method40());
            let v28: f64 = Math::method46();
            let v32: Array<num_complex::Complex<f64>> = Math::method47(new_array(&[
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
                let v40: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method26(Math::method8(
                        v0_1.clone(),
                        v32[v36].clone(),
                        string("    s = mpmath.zeta(s)"),
                    ));
                let v42: num_complex::Complex<f64> = v40.unwrap();
                let v44: f64 = Math::method3(Math::method27());
                let v45: f64 = Math::method4();
                let v47: num_complex::Complex<f64> = num_complex::Complex::new(v44, v45);
                let v48: num_complex::Complex<f64> = Math::method12(v42.clone());
                let v50: f64 = v48.re;
                let v51: f64 = -v50;
                let v53: f64 = if v50 >= v51 { v50 } else { v51 };
                let v54: bool = v53 < 0.0001_f64;
                if (if v54 { true } else { Math::method28(v54) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v53, 0.0001_f64),
                    );
                }
                {
                    let v59: num_complex::Complex<f64> = Math::method13(v42);
                    let v61: f64 = v59.im;
                    let v62: f64 = -v61;
                    let v64: f64 = if v61 >= v62 { v61 } else { v62 };
                    let v65: bool = v64 < 0.0001_f64;
                    if (if v65 { true } else { Math::method28(v65) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v64, 0.0001_f64),
                        );
                    }
                    {
                        let v70: i32 = v36 + 1_i32;
                        v34.l0.set(v70);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method38() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method39(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method30(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method50(v0_1: Array<f64>) -> Array<f64> {
            v0_1
        }
        pub fn method49(v0_1: pyo3::Python) {
            let v2: Array<f64> = Math::method50(new_array(&[
                2.0_f64, 3.0_f64, 4.0_f64, 5.0_f64, 10.0_f64, 20.0_f64, 50.0_f64,
            ]));
            let v3: i32 = count(v2.clone());
            let v4: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method7(v3, v4.clone()) {
                let v6: i32 = v4.l0.get().clone();
                let v9: f64 = Math::method3(Math::method24(v2[v6].clone()));
                let v10: f64 = Math::method4();
                let v15: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method26(Math::method8(
                        v0_1.clone(),
                        num_complex::Complex::new(v9, v10),
                        string("    s = mpmath.zeta(s)"),
                    ));
                let v17: num_complex::Complex<f64> = v15.unwrap();
                let v19: f64 = Math::method3(Math::method27());
                let v20: f64 = Math::method4();
                let v22: num_complex::Complex<f64> = num_complex::Complex::new(v19, v20);
                let v23: num_complex::Complex<f64> = Math::method12(v17.clone());
                let v25: f64 = v23.re;
                let v26: bool = v25 > 0.0_f64;
                if (if v26 { true } else { Math::method28(v26) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v25, 0.0_f64),
                    );
                }
                {
                    let v31: num_complex::Complex<f64> = Math::method13(v17);
                    let v33: f64 = v31.im;
                    let v34: bool = v33 == 0.0_f64;
                    if (if v34 { true } else { Math::method28(v34) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v33, 0.0_f64),
                        );
                    }
                    {
                        let v39: i32 = v6 + 1_i32;
                        v4.l0.set(v39);
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
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method30(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method53() -> f64 {
            1.0_f64
        }
        pub fn method52(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method53());
            let v3: f64 = Math::method4();
            let v8: Result<num_complex::Complex<f64>, pyo3::PyErr> = Math::method26(Math::method8(
                v0_1,
                num_complex::Complex::new(v2, v3),
                string("    s = mpmath.zeta(s)"),
            ));
            let v10: num_complex::Complex<f64> = v8.unwrap();
            let v12: f64 = Math::method3(Math::method27());
            let v13: f64 = Math::method4();
            let v15: num_complex::Complex<f64> = num_complex::Complex::new(v12, v13);
            let v16: num_complex::Complex<f64> = Math::method12(v10.clone());
            let v18: f64 = v16.re;
            let v19: bool = v18 == f64::INFINITY;
            if (if v19 { true } else { Math::method28(v19) }) == false {
                panic!(
                    "{}",
                    sprintf!(
                        "__expect / actual: {:?} / expected: {:?}",
                        v18,
                        f64::INFINITY
                    ),
                );
            }
            {
                let v24: num_complex::Complex<f64> = Math::method13(v10);
                let v26: f64 = v24.im;
                let v27: bool = v26 == 0.0_f64;
                if (if v27 { true } else { Math::method28(v27) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v26, 0.0_f64),
                    );
                }
            }
        }
        pub fn method51() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method52(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method30(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method56() -> f64 {
            10.0_f64
        }
        pub fn method55(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method2());
            let v3: f64 = Math::method56();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v8: Result<num_complex::Complex<f64>, pyo3::PyErr> = Math::method26(Math::method8(
                v0_1.clone(),
                v5.clone(),
                string("    s = mpmath.zeta(s)"),
            ));
            let v10: num_complex::Complex<f64> = v8.unwrap();
            let v12: f64 = Math::method3(Math::method27());
            let v13: f64 = Math::method4();
            let v15: num_complex::Complex<f64> = num_complex::Complex::new(v12, v13);
            let v16: num_complex::Complex<f64> = Math::method12(v5.clone());
            let v18: f64 = v16.re;
            let v19: num_complex::Complex<f64> = Math::method13(v5);
            let v22: f64 = -v19.im;
            let v24: f64 = Math::method3(Math::method24(v18));
            let v25: f64 = Math::method25(v22);
            let v30: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                Math::method26(Math::method8(
                    v0_1,
                    num_complex::Complex::new(v24, v25),
                    string("    s = mpmath.zeta(s)"),
                ));
            let v32: num_complex::Complex<f64> = v30.unwrap();
            let v34: f64 = Math::method3(Math::method27());
            let v35: f64 = Math::method4();
            let v37: num_complex::Complex<f64> = num_complex::Complex::new(v34, v35);
            let v39: num_complex::Complex<f64> = v32.conj();
            let v40: num_complex::Complex<f64> = Math::method12(v10.clone());
            let v42: f64 = v40.re;
            let v43: num_complex::Complex<f64> = Math::method12(v39.clone());
            let v45: f64 = v43.re;
            let v46: bool = v42 == v45;
            if (if v46 { true } else { Math::method28(v46) }) == false {
                panic!(
                    "{}",
                    sprintf!("__expect / actual: {:?} / expected: {:?}", v42, v45),
                );
            }
            {
                let v51: num_complex::Complex<f64> = Math::method13(v10);
                let v53: f64 = v51.im;
                let v54: num_complex::Complex<f64> = Math::method13(v39);
                let v56: f64 = v54.im;
                let v57: bool = v53 == v56;
                if (if v57 { true } else { Math::method28(v57) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v53, v56),
                    );
                }
            }
        }
        pub fn method54() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method55(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method30(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method59() -> f64 {
            0.01_f64
        }
        pub fn method60() -> f64 {
            0.01_f64
        }
        pub fn method58(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method59());
            let v3: f64 = Math::method60();
            let v8: Result<num_complex::Complex<f64>, pyo3::PyErr> = Math::method26(Math::method8(
                v0_1,
                num_complex::Complex::new(v2, v3),
                string("    s = mpmath.zeta(s)"),
            ));
            let v10: num_complex::Complex<f64> = v8.unwrap();
            let v12: f64 = Math::method3(Math::method27());
            let v13: f64 = Math::method4();
            let v15: num_complex::Complex<f64> = num_complex::Complex::new(v12, v13);
            let v16: num_complex::Complex<f64> = Math::method12(v10.clone());
            let v18: f64 = v16.re;
            let v19: bool = v18 < f64::INFINITY;
            if (if v19 { true } else { Math::method28(v19) }) == false {
                panic!(
                    "{}",
                    sprintf!(
                        "__expect / actual: {:?} / expected: {:?}",
                        v18,
                        f64::INFINITY
                    ),
                );
            }
            {
                let v24: num_complex::Complex<f64> = Math::method13(v10);
                let v26: f64 = v24.im;
                let v27: bool = v26 < f64::INFINITY;
                if (if v27 { true } else { Math::method28(v27) }) == false {
                    panic!(
                        "{}",
                        sprintf!(
                            "__expect / actual: {:?} / expected: {:?}",
                            v26,
                            f64::INFINITY
                        ),
                    );
                }
            }
        }
        pub fn method57() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method58(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method30(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method62(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method5());
            let v3: f64 = Math::method4();
            let v8: Result<num_complex::Complex<f64>, pyo3::PyErr> = Math::method26(Math::method8(
                v0_1,
                num_complex::Complex::new(v2, v3),
                string("    s = mpmath.zeta(s)"),
            ));
            let v10: num_complex::Complex<f64> = v8.unwrap();
            let v12: f64 = Math::method3(Math::method27());
            let v13: f64 = Math::method4();
            let v15: num_complex::Complex<f64> = num_complex::Complex::new(v12, v13);
            let v16: num_complex::Complex<f64> = Math::method12(v10.clone());
            let v19: f64 = v16.re + 0.08333333333333333_f64;
            let v20: f64 = -v19;
            let v22: f64 = if v19 >= v20 { v19 } else { v20 };
            let v23: bool = v22 < 0.0001_f64;
            if (if v23 { true } else { Math::method28(v23) }) == false {
                panic!(
                    "{}",
                    sprintf!("__expect / actual: {:?} / expected: {:?}", v22, 0.0001_f64),
                );
            }
            {
                let v28: num_complex::Complex<f64> = Math::method13(v10);
                let v30: f64 = v28.im;
                let v31: bool = v30 == 0.0_f64;
                if (if v31 { true } else { Math::method28(v31) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v30, 0.0_f64),
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
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method30(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method65() -> Array<f64> {
            Math::method50(new_array(&[
                10.0_f64, 20.0_f64, 30.0_f64, 40.0_f64, 50.0_f64, 60.0_f64, 70.0_f64, 80.0_f64,
                90.0_f64, 100.0_f64,
            ]))
        }
        pub fn method66(v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn method64(v0_1: pyo3::Python) {
            let v1_1: Array<f64> = Math::method65();
            let v2: i32 = count(v1_1.clone());
            let v3: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method7(v2, v3.clone()) {
                let v5: i32 = v3.l0.get().clone();
                let v6: f64 = v1_1[v5].clone();
                let v8: f64 = Math::method3(Math::method27());
                let v9: f64 = Math::method25(v6);
                let v14: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method26(Math::method8(
                        v0_1.clone(),
                        num_complex::Complex::new(v8, v9),
                        string("    s = mpmath.zeta(s)"),
                    ));
                let v16: num_complex::Complex<f64> = v14.unwrap();
                let v18: f64 = Math::method3(Math::method27());
                let v19: f64 = Math::method4();
                let v21: num_complex::Complex<f64> = num_complex::Complex::new(v18, v19);
                let v22: num_complex::Complex<f64> = Math::method12(v16.clone());
                let v24: f64 = v22.re;
                let v26: bool = Math::method66(v24 == 0.0_f64);
                if (if v26 { true } else { Math::method28(v26) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v24, 0.0_f64),
                    );
                }
                {
                    let v31: num_complex::Complex<f64> = Math::method13(v16);
                    let v33: f64 = v31.im;
                    let v35: bool = Math::method66(v33 == 0.0_f64);
                    if (if v35 { true } else { Math::method28(v35) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v33, 0.0_f64),
                        );
                    }
                    {
                        let v40: i32 = v5 + 1_i32;
                        v3.l0.set(v40);
                        ()
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
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method30(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method69() -> f64 {
            0.75_f64
        }
        pub fn method70() -> f64 {
            20.5_f64
        }
        pub fn method71() -> f64 {
            1.25_f64
        }
        pub fn method72() -> f64 {
            30.1_f64
        }
        pub fn method73() -> f64 {
            0.25_f64
        }
        pub fn method74() -> f64 {
            40.0_f64
        }
        pub fn method75() -> f64 {
            50.0_f64
        }
        pub fn method68(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method40());
            let v3: f64 = Math::method41();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v7: f64 = Math::method3(Math::method69());
            let v8: f64 = Math::method70();
            let v10: num_complex::Complex<f64> = num_complex::Complex::new(v7, v8);
            let v12: f64 = Math::method3(Math::method71());
            let v13: f64 = Math::method72();
            let v15: num_complex::Complex<f64> = num_complex::Complex::new(v12, v13);
            let v17: f64 = Math::method3(Math::method73());
            let v18: f64 = Math::method74();
            let v20: num_complex::Complex<f64> = num_complex::Complex::new(v17, v18);
            let v22: f64 = Math::method3(Math::method53());
            let v23: f64 = Math::method75();
            let v27: Array<num_complex::Complex<f64>> = Math::method47(new_array(&[
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
                let v35: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method26(Math::method8(
                        v0_1.clone(),
                        v27[v31].clone(),
                        string("    s = mpmath.zeta(s)"),
                    ));
                let v37: num_complex::Complex<f64> = v35.unwrap();
                let v39: f64 = Math::method3(Math::method27());
                let v40: f64 = Math::method4();
                let v42: num_complex::Complex<f64> = num_complex::Complex::new(v39, v40);
                let v43: num_complex::Complex<f64> = Math::method12(v37.clone());
                let v45: f64 = v43.re;
                let v47: bool = Math::method66(v45 == 0.0_f64);
                if (if v47 { true } else { Math::method28(v47) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v45, 0.0_f64),
                    );
                }
                {
                    let v52: num_complex::Complex<f64> = Math::method13(v37);
                    let v54: f64 = v52.im;
                    let v56: bool = Math::method66(v54 == 0.0_f64);
                    if (if v56 { true } else { Math::method28(v56) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v54, 0.0_f64),
                        );
                    }
                    {
                        let v61: i32 = v31 + 1_i32;
                        v29.l0.set(v61);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method67() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method68(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method30(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method78() -> f64 {
            3.0_f64
        }
        pub fn method79() -> f64 {
            4.0_f64
        }
        pub fn method80() -> f64 {
            2.5_f64
        }
        pub fn method81() -> f64 {
            -3.5_f64
        }
        pub fn method82() -> f64 {
            1.5_f64
        }
        pub fn method83() -> f64 {
            2.5_f64
        }
        pub fn method84(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method85(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method86() -> f64 {
            3.141592653589793_f64
        }
        pub fn method87(
            v0_1: pyo3::Python,
            v1_1: num_complex::Complex<f64>,
            v2: string,
        ) -> Result<num_complex::Complex<f64>, pyo3::PyErr> {
            let v34: string =
                Math::method10(Math::method9(new_array(&[string("import sys"),
                                                         string("import traceback"),
                                                         string("count = 0"),
                                                         string("def trace_calls(frame, event, arg):"),
                                                         string("  global count"),
                                                         string("  count += 1"),
                                                         string("  if count < 500:"),
                                                         string("    try:"),
                                                         string("      args = {k: v for k, v in frame.f_locals.items() if k != \'ctx\'}"),
                                                         string("      args_str = \', \'.join([f\"{k}={repr(v)}\" for k, v in args.items()])"),
                                                         sprintf!("      print(f\'{{event}}({}) / f_code.co_name: {{frame.f_code.co_name}} / f_locals: {{args_str}} / f_lineno: {{frame.f_lineno}} / f_code.co_filename: {{frame.f_code.co_filename.split(\'site-packages\')[-1]}} / f_back.f_lineno: {{frame.f_back.f_lineno}} / f_back.f_code.co_filename: {{frame.f_back.f_code.co_filename.split(\'site-packages\')[-1]}}\', flush=True)",
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
                                                         v2,
                                                         string("    if log:"),
                                                         string("      sys.settrace(None)"),
                                                         sprintf!("      print(f\'{} / result: {{s}} / count: {{count}}\', flush=True)",
                                                                  string("gamma_")),
                                                         string("  except ValueError as e:"),
                                                         string("    if s.real == 1:"),
                                                         string("      s = complex(float(\'inf\'), 0)"),
                                                         string("  return (s.real, s.imag)")])));
            let v35: num_complex::Complex<f64> = Math::method12(v1_1.clone());
            let v37: f64 = v35.re;
            let v38: num_complex::Complex<f64> = Math::method13(v1_1);
            let v42: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v37, v38.im))));
            let v43: pyo3::Python = Math::method14(v0_1);
            let v44: string = Math::method15(v34);
            let v46: &str = fable_library_rust::String_::LrcStr::as_str(&v44);
            let v49: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                Math::method16(pyo3::types::PyModule::from_code_bound(v43, v46, "", ""));
            let v51: pyo3::Bound<pyo3::types::PyModule> = v49.unwrap();
            let v52: string = Math::method17();
            let v54: &str = fable_library_rust::String_::LrcStr::as_str(&v52);
            let v55: pyo3::Bound<pyo3::types::PyModule> = Math::method18(v51);
            let v58: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                Math::method19(v55.getattr(v54));
            let v60: pyo3::Bound<pyo3::PyAny> = v58.unwrap();
            let v61: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method20(v42.0.clone(), v42.1.clone());
            let v62: pyo3::Bound<pyo3::PyAny> = Math::method21(v60);
            let v65: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method19(
                pyo3::prelude::PyAnyMethods::call(&v62, ((*v61).0, *(*v61).1), None),
            );
            let v68: pyo3::Bound<pyo3::PyAny> = Math::method22(v65.unwrap());
            let v71: Result<(f64, f64), pyo3::PyErr> = Math::method23(v68.extract());
            let patternInput: (f64, f64) = v71.unwrap();
            let v76: f64 = Math::method3(Math::method24(patternInput.0.clone()));
            let v77: f64 = Math::method25(patternInput.1.clone());
            Ok::<num_complex::Complex<f64>, pyo3::PyErr>(num_complex::Complex::new(v76, v77))
        }
        pub fn method77(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method78());
            let v3: f64 = Math::method79();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v7: f64 = Math::method3(Math::method80());
            let v8: f64 = Math::method81();
            let v10: num_complex::Complex<f64> = num_complex::Complex::new(v7, v8);
            let v12: f64 = Math::method3(Math::method82());
            let v13: f64 = Math::method83();
            let v15: num_complex::Complex<f64> = num_complex::Complex::new(v12, v13);
            let v17: f64 = Math::method3(Math::method40());
            let v18: f64 = Math::method41();
            let v22: Array<num_complex::Complex<f64>> = Math::method47(new_array(&[
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
                let v30: Result<num_complex::Complex<f64>, pyo3::PyErr> = Math::method26(
                    Math::method8(v0_1.clone(), v27.clone(), string("    s = mpmath.zeta(s)")),
                );
                let v32: num_complex::Complex<f64> = v30.unwrap();
                let v34: f64 = Math::method3(Math::method27());
                let v35: f64 = Math::method4();
                let v37: num_complex::Complex<f64> = num_complex::Complex::new(v34, v35);
                let v39: f64 = Math::method3(Math::method2());
                let v40: f64 = Math::method4();
                let v43: num_complex::Complex<f64> =
                    Math::method84(num_complex::Complex::new(v39, v40));
                let v44: num_complex::Complex<f64> = Math::method85(v27.clone());
                let v46: num_complex::Complex<f64> = num_complex::Complex::powc(v43, v44);
                let v48: f64 = Math::method3(Math::method86());
                let v49: f64 = Math::method4();
                let v51: num_complex::Complex<f64> = num_complex::Complex::new(v48, v49);
                let v53: f64 = Math::method3(Math::method53());
                let v54: f64 = Math::method4();
                let v56: num_complex::Complex<f64> = num_complex::Complex::new(v53, v54);
                let v58: num_complex::Complex<f64> = v27 - v56;
                let v59: num_complex::Complex<f64> = Math::method84(v51);
                let v60: num_complex::Complex<f64> = Math::method85(v58);
                let v62: num_complex::Complex<f64> = num_complex::Complex::powc(v59, v60);
                let v64: num_complex::Complex<f64> = v46 * v62;
                let v66: f64 = Math::method3(Math::method86());
                let v67: f64 = Math::method4();
                let v69: num_complex::Complex<f64> = num_complex::Complex::new(v66, v67);
                let v71: num_complex::Complex<f64> = v69 * v27;
                let v73: f64 = Math::method3(Math::method2());
                let v74: f64 = Math::method4();
                let v76: num_complex::Complex<f64> = num_complex::Complex::new(v73, v74);
                let v78: num_complex::Complex<f64> = v71 / v76;
                let v80: num_complex::Complex<f64> = v78.sin();
                let v82: num_complex::Complex<f64> = v64 * v80;
                let v84: f64 = Math::method3(Math::method53());
                let v85: f64 = Math::method4();
                let v87: num_complex::Complex<f64> = num_complex::Complex::new(v84, v85);
                let v92: Result<num_complex::Complex<f64>, pyo3::PyErr> = Math::method26(
                    Math::method87(v0_1.clone(), v87 - v27, string("    s = mpmath.gamma(s)")),
                );
                let v94: num_complex::Complex<f64> = v92.unwrap();
                let v96: num_complex::Complex<f64> = v82 * v94;
                let v97: num_complex::Complex<f64> = Math::method12(v27.clone());
                let v100: f64 = 1.0_f64 - v97.re;
                let v101: num_complex::Complex<f64> = Math::method13(v27);
                let v104: f64 = -v101.im;
                let v106: f64 = Math::method3(Math::method24(v100));
                let v107: f64 = Math::method25(v104);
                let v112: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method26(Math::method8(
                        v0_1.clone(),
                        num_complex::Complex::new(v106, v107),
                        string("    s = mpmath.zeta(s)"),
                    ));
                let v114: num_complex::Complex<f64> = v112.unwrap();
                let v116: f64 = Math::method3(Math::method27());
                let v117: f64 = Math::method4();
                let v119: num_complex::Complex<f64> = num_complex::Complex::new(v116, v117);
                let v121: num_complex::Complex<f64> = v96 * v114;
                let v122: num_complex::Complex<f64> = Math::method12(v32.clone());
                let v124: f64 = v122.re;
                let v125: num_complex::Complex<f64> = Math::method12(v121.clone());
                let v128: f64 = v124 - v125.re;
                let v129: f64 = -v128;
                let v131: f64 = if v128 >= v129 { v128 } else { v129 };
                let v132: bool = v131 < 0.0001_f64;
                if (if v132 { true } else { Math::method28(v132) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v131, 0.0001_f64),
                    );
                }
                {
                    let v137: num_complex::Complex<f64> = Math::method13(v32);
                    let v139: f64 = v137.im;
                    let v140: num_complex::Complex<f64> = Math::method13(v121);
                    let v143: f64 = v139 - v140.im;
                    let v144: f64 = -v143;
                    let v146: f64 = if v143 >= v144 { v143 } else { v144 };
                    let v147: bool = v146 < 0.0001_f64;
                    if (if v147 { true } else { Math::method28(v147) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v146, 0.0001_f64),
                        );
                    }
                    {
                        let v152: i32 = v26 + 1_i32;
                        v24.l0.set(v152);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method76() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method77(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method30(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method90(v0_1: i32, v1_1: LrcPtr<Math::Mut2>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method89(v0_1: pyo3::Python) {
            let v2: Array<f64> = Math::method50(new_array(&[
                2.0_f64, 2.5_f64, 3.0_f64, 3.5_f64, 4.0_f64, 4.5_f64, 5.0_f64,
            ]));
            let v4: Array<f64> = Math::method50(new_array(&[
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
                let v11: f64 = Math::method3(Math::method24(v9));
                let v12: f64 = Math::method4();
                let v14: num_complex::Complex<f64> = num_complex::Complex::new(v11, v12);
                let v15: i32 = count(v4.clone());
                let v16: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(1.0_f64),
                });
                while Math::method90(v15, v16.clone()) {
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
                    let v29: Result<num_complex::Complex<f64>, pyo3::PyErr> = Math::method26(
                        Math::method8(v0_1.clone(), v14, string("    s = mpmath.zeta(s)")),
                    );
                    let v31: num_complex::Complex<f64> = v29.unwrap();
                    let v33: f64 = Math::method3(Math::method27());
                    let v34: f64 = Math::method4();
                    let v36: num_complex::Complex<f64> = num_complex::Complex::new(v33, v34);
                    let v37: num_complex::Complex<f64> = Math::method12(v31.clone());
                    let v40: f64 = v37.re - v26;
                    let v41: f64 = -v40;
                    let v43: f64 = if v40 >= v41 { v40 } else { v41 };
                    let v44: bool = v43 < 0.01_f64;
                    if (if v44 { true } else { Math::method28(v44) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v43, 0.01_f64),
                        );
                    }
                    {
                        let v49: num_complex::Complex<f64> = Math::method13(v31);
                        let v51: f64 = v49.im;
                        let v52: bool = v51 < 0.01_f64;
                        if (if v52 { true } else { Math::method28(v52) }) == false {
                            panic!(
                                "{}",
                                sprintf!("__expect / actual: {:?} / expected: {:?}", v51, 0.01_f64),
                            );
                        }
                        {
                            let v57: i32 = v8 + 1_i32;
                            v6.l0.set(v57);
                            ()
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
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method30(__result);
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
            Math::method31();
        }
        #[test]
        fn test_trivial_zero_at_negative_even___() {
            //;
            Math::method34();
        }
        #[test]
        fn test_non_trivial_zero___() {
            //;
            Math::method38();
        }
        #[test]
        fn test_real_part_greater_than_one___() {
            //;
            Math::method48();
        }
        #[test]
        fn test_zeta_at_1___() {
            //;
            Math::method51();
        }
        #[test]
        fn test_symmetry_across_real_axis___() {
            //;
            Math::method54();
        }
        #[test]
        fn test_behavior_near_origin___() {
            //;
            Math::method57();
        }
        #[test]
        fn test_zeta_at_minus_1() {
            //;
            Math::method61();
        }
        #[test]
        fn test_imaginary_axis() {
            //;
            Math::method63();
        }
        #[test]
        fn test_critical_strip() {
            //;
            Math::method67();
        }
        #[test]
        fn test_reflection_formula_for_specific_value() {
            //;
            Math::method76();
        }
        #[test]
        fn test_euler_product_formula() {
            //;
            Math::method88()
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
