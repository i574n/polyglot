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
        pub fn method8(v0_1: Array<string>) -> Array<string> {
            v0_1
        }
        pub fn method10(v0_1: i32, v1_1: LrcPtr<Math::Mut1>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method9(v0_1: Array<string>) -> string {
            let v1_1: i32 = count(v0_1.clone());
            let v3: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                l0: MutCell::new(0_i32),
                l1: MutCell::new(string("")),
            });
            while Math::method10(v1_1, v3.clone()) {
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
        pub fn method11(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method12(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method13(v0_1: pyo3::Python) -> pyo3::Python {
            v0_1
        }
        pub fn method14(v0_1: string) -> string {
            v0_1
        }
        pub fn method15(
            v0_1: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr>,
        ) -> Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> {
            v0_1
        }
        pub fn method16() -> string {
            string("fn")
        }
        pub fn method17(
            v0_1: pyo3::Bound<pyo3::types::PyModule>,
        ) -> pyo3::Bound<pyo3::types::PyModule> {
            v0_1
        }
        pub fn method18(
            v0_1: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr>,
        ) -> Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> {
            v0_1
        }
        pub fn method19(
            v0_: bool,
            v0__1: LrcPtr<(f64, f64)>,
        ) -> LrcPtr<(bool, LrcPtr<(f64, f64)>)> {
            LrcPtr::new((v0_, v0__1))
        }
        pub fn method20(v0_1: pyo3::Bound<pyo3::PyAny>) -> pyo3::Bound<pyo3::PyAny> {
            v0_1
        }
        pub fn method21(v0_1: pyo3::Bound<pyo3::PyAny>) -> pyo3::Bound<pyo3::PyAny> {
            v0_1
        }
        pub fn method22(v0_1: Result<(f64, f64), pyo3::PyErr>) -> Result<(f64, f64), pyo3::PyErr> {
            v0_1
        }
        pub fn method23(v0_1: f64) -> f64 {
            v0_1
        }
        pub fn method24(v0_1: f64) -> f64 {
            v0_1
        }
        pub fn method25(
            v0_1: Result<num_complex::Complex<f64>, pyo3::PyErr>,
        ) -> Result<num_complex::Complex<f64>, pyo3::PyErr> {
            v0_1
        }
        pub fn method26() -> f64 {
            0.0_f64
        }
        pub fn method27(v0_1: bool) -> bool {
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
                let v32: string = Math::method9(Math::method8(new_array(&[
                    string("import mpmath"),
                    string("def fn(log, s):"),
                    string("    if log:"),
                    string("        print(f\'zeta_ / s: {s}\', flush=True)"),
                    string("    s = complex(*s)"),
                    string("    try:"),
                    string("        s = mpmath.zeta(s)"),
                    string("    except ValueError as e:"),
                    string("        if s.real == 1:"),
                    string("            s = complex(float(\'inf\'), 0)"),
                    string("    return (s.real, s.imag)"),
                ])));
                let v33: num_complex::Complex<f64> = Math::method11(v17.clone());
                let v35: f64 = v33.re;
                let v36: num_complex::Complex<f64> = Math::method12(v17);
                let v40: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    LrcPtr::new((false, LrcPtr::new((v35, v36.im))));
                let v41: pyo3::Python = Math::method13(v0_1.clone());
                let v42: string = Math::method14(v32);
                let v44: &str = fable_library_rust::String_::LrcStr::as_str(&v42);
                let v47: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                    Math::method15(pyo3::types::PyModule::from_code_bound(v41, v44, "", ""));
                let v49: pyo3::Bound<pyo3::types::PyModule> = v47.unwrap();
                let v50: string = Math::method16();
                let v52: &str = fable_library_rust::String_::LrcStr::as_str(&v50);
                let v53: pyo3::Bound<pyo3::types::PyModule> = Math::method17(v49);
                let v56: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                    Math::method18(v53.getattr(v52));
                let v58: pyo3::Bound<pyo3::PyAny> = v56.unwrap();
                let v59: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    Math::method19(v40.0.clone(), v40.1.clone());
                let v60: pyo3::Bound<pyo3::PyAny> = Math::method20(v58);
                let v63: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method18(
                    pyo3::prelude::PyAnyMethods::call(&v60, ((*v59).0, *(*v59).1), None),
                );
                let v66: pyo3::Bound<pyo3::PyAny> = Math::method21(v63.unwrap());
                let v69: Result<(f64, f64), pyo3::PyErr> = Math::method22(v66.extract());
                let patternInput_1: (f64, f64) = v69.unwrap();
                let v74: f64 = Math::method3(Math::method23(patternInput_1.0.clone()));
                let v75: f64 = Math::method24(patternInput_1.1.clone());
                let v79: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method25(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                        num_complex::Complex::new(v74, v75),
                    ));
                let v81: num_complex::Complex<f64> = v79.unwrap();
                let v83: f64 = Math::method3(Math::method26());
                let v84: f64 = Math::method4();
                let v86: num_complex::Complex<f64> = num_complex::Complex::new(v83, v84);
                let v87: num_complex::Complex<f64> = Math::method12(v81.clone());
                let v89: f64 = v87.im;
                let v90: bool = v89 == 0.0_f64;
                if (if v90 { true } else { Math::method27(v90) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v89, 0.0_f64),
                    );
                }
                {
                    let v95: num_complex::Complex<f64> = Math::method11(v81);
                    let v98: f64 = v95.re - patternInput.1.clone();
                    let v99: f64 = -v98;
                    let v101: f64 = if v98 >= v99 { v98 } else { v99 };
                    let v102: bool = v101 < 0.0001_f64;
                    if (if v102 { true } else { Math::method27(v102) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v101, 0.0001_f64),
                        );
                    }
                    {
                        let v107: i32 = v16 + 1_i32;
                        v14.l0.set(v107);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method28(v0_1: Result<(), pyo3::PyErr>) -> Result<(), pyo3::PyErr> {
            v0_1
        }
        pub fn method29(v0_1: Result<(), pyo3::PyErr>) -> Result<(), pyo3::PyErr> {
            v0_1
        }
        pub fn method0() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method1(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method28(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method29(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method32() -> f64 {
            -2.0_f64
        }
        pub fn method31(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method2());
            let v3: f64 = Math::method32();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v19: string = Math::method9(Math::method8(new_array(&[
                string("import mpmath"),
                string("def fn(log, s):"),
                string("    if log:"),
                string("        print(f\'zeta_ / s: {s}\', flush=True)"),
                string("    s = complex(*s)"),
                string("    try:"),
                string("        s = mpmath.zeta(s)"),
                string("    except ValueError as e:"),
                string("        if s.real == 1:"),
                string("            s = complex(float(\'inf\'), 0)"),
                string("    return (s.real, s.imag)"),
            ])));
            let v20: num_complex::Complex<f64> = Math::method11(v5.clone());
            let v22: f64 = v20.re;
            let v23: num_complex::Complex<f64> = Math::method12(v5);
            let v27: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v22, v23.im))));
            let v28: pyo3::Python = Math::method13(v0_1);
            let v29: string = Math::method14(v19);
            let v31: &str = fable_library_rust::String_::LrcStr::as_str(&v29);
            let v34: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                Math::method15(pyo3::types::PyModule::from_code_bound(v28, v31, "", ""));
            let v36: pyo3::Bound<pyo3::types::PyModule> = v34.unwrap();
            let v37: string = Math::method16();
            let v39: &str = fable_library_rust::String_::LrcStr::as_str(&v37);
            let v40: pyo3::Bound<pyo3::types::PyModule> = Math::method17(v36);
            let v43: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                Math::method18(v40.getattr(v39));
            let v45: pyo3::Bound<pyo3::PyAny> = v43.unwrap();
            let v46: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method19(v27.0.clone(), v27.1.clone());
            let v47: pyo3::Bound<pyo3::PyAny> = Math::method20(v45);
            let v50: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method18(
                pyo3::prelude::PyAnyMethods::call(&v47, ((*v46).0, *(*v46).1), None),
            );
            let v53: pyo3::Bound<pyo3::PyAny> = Math::method21(v50.unwrap());
            let v56: Result<(f64, f64), pyo3::PyErr> = Math::method22(v53.extract());
            let patternInput: (f64, f64) = v56.unwrap();
            let v61: f64 = Math::method3(Math::method23(patternInput.0.clone()));
            let v62: f64 = Math::method24(patternInput.1.clone());
            let v66: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                Math::method25(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                    num_complex::Complex::new(v61, v62),
                ));
            let v68: num_complex::Complex<f64> = v66.unwrap();
            let v70: f64 = Math::method3(Math::method26());
            let v71: f64 = Math::method4();
            let v73: num_complex::Complex<f64> = num_complex::Complex::new(v70, v71);
            let v74: num_complex::Complex<f64> = Math::method11(v68.clone());
            let v77: f64 = v74.re - 0.8673_f64;
            let v78: f64 = -v77;
            let v80: f64 = if v77 >= v78 { v77 } else { v78 };
            let v81: bool = v80 < 0.001_f64;
            if (if v81 { true } else { Math::method27(v81) }) == false {
                panic!(
                    "{}",
                    sprintf!("__expect / actual: {:?} / expected: {:?}", v80, 0.001_f64),
                );
            }
            {
                let v86: num_complex::Complex<f64> = Math::method12(v68);
                let v89: f64 = v86.im - 0.275_f64;
                let v90: f64 = -v89;
                let v92: f64 = if v89 >= v90 { v89 } else { v90 };
                let v93: bool = v92 < 0.001_f64;
                if (if v93 { true } else { Math::method27(v93) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v92, 0.001_f64),
                    );
                }
            }
        }
        pub fn method30() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method31(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method28(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method29(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method35() -> LrcPtr<Math::UH0> {
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
        pub fn method36(v0_1: pyo3::Python, v1_1: LrcPtr<Math::UH0>) {
            let v0_1: MutCell<pyo3::Python> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1_1.clone());
            '_method36: loop {
                break '_method36 (match v1_1.get().clone().as_ref() {
                    Math::UH0::UH0_1 => (),
                    Math::UH0::UH0_0(v1_1_0_0, v1_1_0_1) => {
                        let v5: f64 = Math::method3(Math::method23(v1_1_0_0.clone()));
                        let v6: f64 = Math::method4();
                        let v8: num_complex::Complex<f64> = num_complex::Complex::new(v5, v6);
                        let v22: string = Math::method9(Math::method8(new_array(&[
                            string("import mpmath"),
                            string("def fn(log, s):"),
                            string("    if log:"),
                            string("        print(f\'zeta_ / s: {s}\', flush=True)"),
                            string("    s = complex(*s)"),
                            string("    try:"),
                            string("        s = mpmath.zeta(s)"),
                            string("    except ValueError as e:"),
                            string("        if s.real == 1:"),
                            string("            s = complex(float(\'inf\'), 0)"),
                            string("    return (s.real, s.imag)"),
                        ])));
                        let v23: num_complex::Complex<f64> = Math::method11(v8.clone());
                        let v25: f64 = v23.re;
                        let v26: num_complex::Complex<f64> = Math::method12(v8);
                        let v30: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                            LrcPtr::new((false, LrcPtr::new((v25, v26.im))));
                        let v31: pyo3::Python = Math::method13(v0_1.get().clone());
                        let v32: string = Math::method14(v22);
                        let v34: &str = fable_library_rust::String_::LrcStr::as_str(&v32);
                        let v37: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                            Math::method15(pyo3::types::PyModule::from_code_bound(
                                v31, v34, "", "",
                            ));
                        let v39: pyo3::Bound<pyo3::types::PyModule> = v37.unwrap();
                        let v40: string = Math::method16();
                        let v42: &str = fable_library_rust::String_::LrcStr::as_str(&v40);
                        let v43: pyo3::Bound<pyo3::types::PyModule> = Math::method17(v39);
                        let v46: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                            Math::method18(v43.getattr(v42));
                        let v48: pyo3::Bound<pyo3::PyAny> = v46.unwrap();
                        let v49: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                            Math::method19(v30.0.clone(), v30.1.clone());
                        let v50: pyo3::Bound<pyo3::PyAny> = Math::method20(v48);
                        let v53: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method18(
                            pyo3::prelude::PyAnyMethods::call(&v50, ((*v49).0, *(*v49).1), None),
                        );
                        let v56: pyo3::Bound<pyo3::PyAny> = Math::method21(v53.unwrap());
                        let v59: Result<(f64, f64), pyo3::PyErr> = Math::method22(v56.extract());
                        let patternInput: (f64, f64) = v59.unwrap();
                        let v64: f64 = Math::method3(Math::method23(patternInput.0.clone()));
                        let v65: f64 = Math::method24(patternInput.1.clone());
                        let v69: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                            Math::method25(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                                num_complex::Complex::new(v64, v65),
                            ));
                        let v71: num_complex::Complex<f64> = v69.unwrap();
                        let v73: f64 = Math::method3(Math::method26());
                        let v74: f64 = Math::method4();
                        let v76: num_complex::Complex<f64> = num_complex::Complex::new(v73, v74);
                        let v77: num_complex::Complex<f64> = Math::method11(v71.clone());
                        let v79: f64 = v77.re;
                        let v80: bool = v79 == 0.0_f64;
                        if (if v80 { true } else { Math::method27(v80) }) == false {
                            panic!(
                                "{}",
                                sprintf!("__expect / actual: {:?} / expected: {:?}", v79, 0.0_f64),
                            );
                        }
                        {
                            let v85: num_complex::Complex<f64> = Math::method12(v71);
                            let v87: f64 = v85.im;
                            let v88: bool = v87 == 0.0_f64;
                            if (if v88 { true } else { Math::method27(v88) }) == false {
                                panic!(
                                    "{}",
                                    sprintf!(
                                        "__expect / actual: {:?} / expected: {:?}",
                                        v87,
                                        0.0_f64
                                    ),
                                );
                            }
                            {
                                let v0_1_temp: pyo3::Python = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<Math::UH0> = v1_1_0_1.clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                continue '_method36;
                            }
                        }
                    }
                });
            }
        }
        pub fn method34(v0_1: pyo3::Python) {
            Math::method36(v0_1, Math::method35());
        }
        pub fn method33() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method34(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method28(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method29(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method39() -> f64 {
            0.5_f64
        }
        pub fn method40() -> f64 {
            14.134725_f64
        }
        pub fn method41() -> f64 {
            21.02204_f64
        }
        pub fn method42() -> f64 {
            25.010857_f64
        }
        pub fn method43() -> f64 {
            30.424876_f64
        }
        pub fn method44() -> f64 {
            32.935062_f64
        }
        pub fn method45() -> f64 {
            37.586178_f64
        }
        pub fn method46(
            v0_1: Array<num_complex::Complex<f64>>,
        ) -> Array<num_complex::Complex<f64>> {
            v0_1
        }
        pub fn method38(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method39());
            let v3: f64 = Math::method40();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v7: f64 = Math::method3(Math::method39());
            let v8: f64 = Math::method41();
            let v10: num_complex::Complex<f64> = num_complex::Complex::new(v7, v8);
            let v12: f64 = Math::method3(Math::method39());
            let v13: f64 = Math::method42();
            let v15: num_complex::Complex<f64> = num_complex::Complex::new(v12, v13);
            let v17: f64 = Math::method3(Math::method39());
            let v18: f64 = Math::method43();
            let v20: num_complex::Complex<f64> = num_complex::Complex::new(v17, v18);
            let v22: f64 = Math::method3(Math::method39());
            let v23: f64 = Math::method44();
            let v25: num_complex::Complex<f64> = num_complex::Complex::new(v22, v23);
            let v27: f64 = Math::method3(Math::method39());
            let v28: f64 = Math::method45();
            let v32: Array<num_complex::Complex<f64>> = Math::method46(new_array(&[
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
                let v51: string = Math::method9(Math::method8(new_array(&[
                    string("import mpmath"),
                    string("def fn(log, s):"),
                    string("    if log:"),
                    string("        print(f\'zeta_ / s: {s}\', flush=True)"),
                    string("    s = complex(*s)"),
                    string("    try:"),
                    string("        s = mpmath.zeta(s)"),
                    string("    except ValueError as e:"),
                    string("        if s.real == 1:"),
                    string("            s = complex(float(\'inf\'), 0)"),
                    string("    return (s.real, s.imag)"),
                ])));
                let v52: num_complex::Complex<f64> = Math::method11(v37.clone());
                let v54: f64 = v52.re;
                let v55: num_complex::Complex<f64> = Math::method12(v37);
                let v59: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    LrcPtr::new((false, LrcPtr::new((v54, v55.im))));
                let v60: pyo3::Python = Math::method13(v0_1.clone());
                let v61: string = Math::method14(v51);
                let v63: &str = fable_library_rust::String_::LrcStr::as_str(&v61);
                let v66: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                    Math::method15(pyo3::types::PyModule::from_code_bound(v60, v63, "", ""));
                let v68: pyo3::Bound<pyo3::types::PyModule> = v66.unwrap();
                let v69: string = Math::method16();
                let v71: &str = fable_library_rust::String_::LrcStr::as_str(&v69);
                let v72: pyo3::Bound<pyo3::types::PyModule> = Math::method17(v68);
                let v75: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                    Math::method18(v72.getattr(v71));
                let v77: pyo3::Bound<pyo3::PyAny> = v75.unwrap();
                let v78: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    Math::method19(v59.0.clone(), v59.1.clone());
                let v79: pyo3::Bound<pyo3::PyAny> = Math::method20(v77);
                let v82: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method18(
                    pyo3::prelude::PyAnyMethods::call(&v79, ((*v78).0, *(*v78).1), None),
                );
                let v85: pyo3::Bound<pyo3::PyAny> = Math::method21(v82.unwrap());
                let v88: Result<(f64, f64), pyo3::PyErr> = Math::method22(v85.extract());
                let patternInput: (f64, f64) = v88.unwrap();
                let v93: f64 = Math::method3(Math::method23(patternInput.0.clone()));
                let v94: f64 = Math::method24(patternInput.1.clone());
                let v98: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method25(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                        num_complex::Complex::new(v93, v94),
                    ));
                let v100: num_complex::Complex<f64> = v98.unwrap();
                let v102: f64 = Math::method3(Math::method26());
                let v103: f64 = Math::method4();
                let v105: num_complex::Complex<f64> = num_complex::Complex::new(v102, v103);
                let v106: num_complex::Complex<f64> = Math::method11(v100.clone());
                let v108: f64 = v106.re;
                let v109: f64 = -v108;
                let v111: f64 = if v108 >= v109 { v108 } else { v109 };
                let v112: bool = v111 < 0.0001_f64;
                if (if v112 { true } else { Math::method27(v112) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v111, 0.0001_f64),
                    );
                }
                {
                    let v117: num_complex::Complex<f64> = Math::method12(v100);
                    let v119: f64 = v117.im;
                    let v120: f64 = -v119;
                    let v122: f64 = if v119 >= v120 { v119 } else { v120 };
                    let v123: bool = v122 < 0.0001_f64;
                    if (if v123 { true } else { Math::method27(v123) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v122, 0.0001_f64),
                        );
                    }
                    {
                        let v128: i32 = v36 + 1_i32;
                        v34.l0.set(v128);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method37() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method38(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method28(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method29(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method49(v0_1: Array<f64>) -> Array<f64> {
            v0_1
        }
        pub fn method48(v0_1: pyo3::Python) {
            let v2: Array<f64> = Math::method49(new_array(&[
                2.0_f64, 3.0_f64, 4.0_f64, 5.0_f64, 10.0_f64, 20.0_f64, 50.0_f64,
            ]));
            let v3: i32 = count(v2.clone());
            let v4: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method7(v3, v4.clone()) {
                let v6: i32 = v4.l0.get().clone();
                let v9: f64 = Math::method3(Math::method23(v2[v6].clone()));
                let v10: f64 = Math::method4();
                let v12: num_complex::Complex<f64> = num_complex::Complex::new(v9, v10);
                let v26: string = Math::method9(Math::method8(new_array(&[
                    string("import mpmath"),
                    string("def fn(log, s):"),
                    string("    if log:"),
                    string("        print(f\'zeta_ / s: {s}\', flush=True)"),
                    string("    s = complex(*s)"),
                    string("    try:"),
                    string("        s = mpmath.zeta(s)"),
                    string("    except ValueError as e:"),
                    string("        if s.real == 1:"),
                    string("            s = complex(float(\'inf\'), 0)"),
                    string("    return (s.real, s.imag)"),
                ])));
                let v27: num_complex::Complex<f64> = Math::method11(v12.clone());
                let v29: f64 = v27.re;
                let v30: num_complex::Complex<f64> = Math::method12(v12);
                let v34: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    LrcPtr::new((false, LrcPtr::new((v29, v30.im))));
                let v35: pyo3::Python = Math::method13(v0_1.clone());
                let v36: string = Math::method14(v26);
                let v38: &str = fable_library_rust::String_::LrcStr::as_str(&v36);
                let v41: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                    Math::method15(pyo3::types::PyModule::from_code_bound(v35, v38, "", ""));
                let v43: pyo3::Bound<pyo3::types::PyModule> = v41.unwrap();
                let v44: string = Math::method16();
                let v46: &str = fable_library_rust::String_::LrcStr::as_str(&v44);
                let v47: pyo3::Bound<pyo3::types::PyModule> = Math::method17(v43);
                let v50: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                    Math::method18(v47.getattr(v46));
                let v52: pyo3::Bound<pyo3::PyAny> = v50.unwrap();
                let v53: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    Math::method19(v34.0.clone(), v34.1.clone());
                let v54: pyo3::Bound<pyo3::PyAny> = Math::method20(v52);
                let v57: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method18(
                    pyo3::prelude::PyAnyMethods::call(&v54, ((*v53).0, *(*v53).1), None),
                );
                let v60: pyo3::Bound<pyo3::PyAny> = Math::method21(v57.unwrap());
                let v63: Result<(f64, f64), pyo3::PyErr> = Math::method22(v60.extract());
                let patternInput: (f64, f64) = v63.unwrap();
                let v68: f64 = Math::method3(Math::method23(patternInput.0.clone()));
                let v69: f64 = Math::method24(patternInput.1.clone());
                let v73: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method25(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                        num_complex::Complex::new(v68, v69),
                    ));
                let v75: num_complex::Complex<f64> = v73.unwrap();
                let v77: f64 = Math::method3(Math::method26());
                let v78: f64 = Math::method4();
                let v80: num_complex::Complex<f64> = num_complex::Complex::new(v77, v78);
                let v81: num_complex::Complex<f64> = Math::method11(v75.clone());
                let v83: f64 = v81.re;
                let v84: bool = v83 > 0.0_f64;
                if (if v84 { true } else { Math::method27(v84) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v83, 0.0_f64),
                    );
                }
                {
                    let v89: num_complex::Complex<f64> = Math::method12(v75);
                    let v91: f64 = v89.im;
                    let v92: bool = v91 == 0.0_f64;
                    if (if v92 { true } else { Math::method27(v92) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v91, 0.0_f64),
                        );
                    }
                    {
                        let v97: i32 = v6 + 1_i32;
                        v4.l0.set(v97);
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
                    let v5: Result<(), pyo3::PyErr> = Math::method28(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method29(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method52() -> f64 {
            1.0_f64
        }
        pub fn method51(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method52());
            let v3: f64 = Math::method4();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v19: string = Math::method9(Math::method8(new_array(&[
                string("import mpmath"),
                string("def fn(log, s):"),
                string("    if log:"),
                string("        print(f\'zeta_ / s: {s}\', flush=True)"),
                string("    s = complex(*s)"),
                string("    try:"),
                string("        s = mpmath.zeta(s)"),
                string("    except ValueError as e:"),
                string("        if s.real == 1:"),
                string("            s = complex(float(\'inf\'), 0)"),
                string("    return (s.real, s.imag)"),
            ])));
            let v20: num_complex::Complex<f64> = Math::method11(v5.clone());
            let v22: f64 = v20.re;
            let v23: num_complex::Complex<f64> = Math::method12(v5);
            let v27: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v22, v23.im))));
            let v28: pyo3::Python = Math::method13(v0_1);
            let v29: string = Math::method14(v19);
            let v31: &str = fable_library_rust::String_::LrcStr::as_str(&v29);
            let v34: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                Math::method15(pyo3::types::PyModule::from_code_bound(v28, v31, "", ""));
            let v36: pyo3::Bound<pyo3::types::PyModule> = v34.unwrap();
            let v37: string = Math::method16();
            let v39: &str = fable_library_rust::String_::LrcStr::as_str(&v37);
            let v40: pyo3::Bound<pyo3::types::PyModule> = Math::method17(v36);
            let v43: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                Math::method18(v40.getattr(v39));
            let v45: pyo3::Bound<pyo3::PyAny> = v43.unwrap();
            let v46: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method19(v27.0.clone(), v27.1.clone());
            let v47: pyo3::Bound<pyo3::PyAny> = Math::method20(v45);
            let v50: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method18(
                pyo3::prelude::PyAnyMethods::call(&v47, ((*v46).0, *(*v46).1), None),
            );
            let v53: pyo3::Bound<pyo3::PyAny> = Math::method21(v50.unwrap());
            let v56: Result<(f64, f64), pyo3::PyErr> = Math::method22(v53.extract());
            let patternInput: (f64, f64) = v56.unwrap();
            let v61: f64 = Math::method3(Math::method23(patternInput.0.clone()));
            let v62: f64 = Math::method24(patternInput.1.clone());
            let v66: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                Math::method25(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                    num_complex::Complex::new(v61, v62),
                ));
            let v68: num_complex::Complex<f64> = v66.unwrap();
            let v70: f64 = Math::method3(Math::method26());
            let v71: f64 = Math::method4();
            let v73: num_complex::Complex<f64> = num_complex::Complex::new(v70, v71);
            let v74: num_complex::Complex<f64> = Math::method11(v68.clone());
            let v76: f64 = v74.re;
            let v77: bool = v76 == f64::INFINITY;
            if (if v77 { true } else { Math::method27(v77) }) == false {
                panic!(
                    "{}",
                    sprintf!(
                        "__expect / actual: {:?} / expected: {:?}",
                        v76,
                        f64::INFINITY
                    ),
                );
            }
            {
                let v82: num_complex::Complex<f64> = Math::method12(v68);
                let v84: f64 = v82.im;
                let v85: bool = v84 == 0.0_f64;
                if (if v85 { true } else { Math::method27(v85) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v84, 0.0_f64),
                    );
                }
            }
        }
        pub fn method50() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method51(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method28(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method29(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method55() -> f64 {
            10.0_f64
        }
        pub fn method54(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method2());
            let v3: f64 = Math::method55();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v19: string = Math::method9(Math::method8(new_array(&[
                string("import mpmath"),
                string("def fn(log, s):"),
                string("    if log:"),
                string("        print(f\'zeta_ / s: {s}\', flush=True)"),
                string("    s = complex(*s)"),
                string("    try:"),
                string("        s = mpmath.zeta(s)"),
                string("    except ValueError as e:"),
                string("        if s.real == 1:"),
                string("            s = complex(float(\'inf\'), 0)"),
                string("    return (s.real, s.imag)"),
            ])));
            let v20: num_complex::Complex<f64> = Math::method11(v5.clone());
            let v22: f64 = v20.re;
            let v23: num_complex::Complex<f64> = Math::method12(v5.clone());
            let v27: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v22, v23.im))));
            let v28: pyo3::Python = Math::method13(v0_1.clone());
            let v29: string = Math::method14(v19);
            let v31: &str = fable_library_rust::String_::LrcStr::as_str(&v29);
            let v34: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                Math::method15(pyo3::types::PyModule::from_code_bound(v28, v31, "", ""));
            let v36: pyo3::Bound<pyo3::types::PyModule> = v34.unwrap();
            let v37: string = Math::method16();
            let v39: &str = fable_library_rust::String_::LrcStr::as_str(&v37);
            let v40: pyo3::Bound<pyo3::types::PyModule> = Math::method17(v36);
            let v43: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                Math::method18(v40.getattr(v39));
            let v45: pyo3::Bound<pyo3::PyAny> = v43.unwrap();
            let v46: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method19(v27.0.clone(), v27.1.clone());
            let v47: pyo3::Bound<pyo3::PyAny> = Math::method20(v45);
            let v50: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method18(
                pyo3::prelude::PyAnyMethods::call(&v47, ((*v46).0, *(*v46).1), None),
            );
            let v53: pyo3::Bound<pyo3::PyAny> = Math::method21(v50.unwrap());
            let v56: Result<(f64, f64), pyo3::PyErr> = Math::method22(v53.extract());
            let patternInput: (f64, f64) = v56.unwrap();
            let v61: f64 = Math::method3(Math::method23(patternInput.0.clone()));
            let v62: f64 = Math::method24(patternInput.1.clone());
            let v66: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                Math::method25(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                    num_complex::Complex::new(v61, v62),
                ));
            let v68: num_complex::Complex<f64> = v66.unwrap();
            let v70: f64 = Math::method3(Math::method26());
            let v71: f64 = Math::method4();
            let v73: num_complex::Complex<f64> = num_complex::Complex::new(v70, v71);
            let v74: num_complex::Complex<f64> = Math::method11(v5.clone());
            let v76: f64 = v74.re;
            let v77: num_complex::Complex<f64> = Math::method12(v5);
            let v80: f64 = -v77.im;
            let v82: f64 = Math::method3(Math::method23(v76));
            let v83: f64 = Math::method24(v80);
            let v85: num_complex::Complex<f64> = num_complex::Complex::new(v82, v83);
            let v88: string = Math::method9(Math::method8(new_array(&[
                string("import mpmath"),
                string("def fn(log, s):"),
                string("    if log:"),
                string("        print(f\'zeta_ / s: {s}\', flush=True)"),
                string("    s = complex(*s)"),
                string("    try:"),
                string("        s = mpmath.zeta(s)"),
                string("    except ValueError as e:"),
                string("        if s.real == 1:"),
                string("            s = complex(float(\'inf\'), 0)"),
                string("    return (s.real, s.imag)"),
            ])));
            let v89: num_complex::Complex<f64> = Math::method11(v85.clone());
            let v91: f64 = v89.re;
            let v92: num_complex::Complex<f64> = Math::method12(v85);
            let v96: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v91, v92.im))));
            let v97: pyo3::Python = Math::method13(v0_1);
            let v98: string = Math::method14(v88);
            let v100: &str = fable_library_rust::String_::LrcStr::as_str(&v98);
            let v103: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                Math::method15(pyo3::types::PyModule::from_code_bound(v97, v100, "", ""));
            let v105: pyo3::Bound<pyo3::types::PyModule> = v103.unwrap();
            let v106: string = Math::method16();
            let v108: &str = fable_library_rust::String_::LrcStr::as_str(&v106);
            let v109: pyo3::Bound<pyo3::types::PyModule> = Math::method17(v105);
            let v112: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                Math::method18(v109.getattr(v108));
            let v114: pyo3::Bound<pyo3::PyAny> = v112.unwrap();
            let v115: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method19(v96.0.clone(), v96.1.clone());
            let v116: pyo3::Bound<pyo3::PyAny> = Math::method20(v114);
            let v119: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method18(
                pyo3::prelude::PyAnyMethods::call(&v116, ((*v115).0, *(*v115).1), None),
            );
            let v122: pyo3::Bound<pyo3::PyAny> = Math::method21(v119.unwrap());
            let v125: Result<(f64, f64), pyo3::PyErr> = Math::method22(v122.extract());
            let patternInput_1: (f64, f64) = v125.unwrap();
            let v130: f64 = Math::method3(Math::method23(patternInput_1.0.clone()));
            let v131: f64 = Math::method24(patternInput_1.1.clone());
            let v135: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                Math::method25(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                    num_complex::Complex::new(v130, v131),
                ));
            let v137: num_complex::Complex<f64> = v135.unwrap();
            let v139: f64 = Math::method3(Math::method26());
            let v140: f64 = Math::method4();
            let v142: num_complex::Complex<f64> = num_complex::Complex::new(v139, v140);
            let v144: num_complex::Complex<f64> = v137.conj();
            let v145: num_complex::Complex<f64> = Math::method11(v68.clone());
            let v147: f64 = v145.re;
            let v148: num_complex::Complex<f64> = Math::method11(v144.clone());
            let v150: f64 = v148.re;
            let v151: bool = v147 == v150;
            if (if v151 { true } else { Math::method27(v151) }) == false {
                panic!(
                    "{}",
                    sprintf!("__expect / actual: {:?} / expected: {:?}", v147, v150),
                );
            }
            {
                let v156: num_complex::Complex<f64> = Math::method12(v68);
                let v158: f64 = v156.im;
                let v159: num_complex::Complex<f64> = Math::method12(v144);
                let v161: f64 = v159.im;
                let v162: bool = v158 == v161;
                if (if v162 { true } else { Math::method27(v162) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v158, v161),
                    );
                }
            }
        }
        pub fn method53() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method54(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method28(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method29(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method58() -> f64 {
            0.01_f64
        }
        pub fn method59() -> f64 {
            0.01_f64
        }
        pub fn method57(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method58());
            let v3: f64 = Math::method59();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v19: string = Math::method9(Math::method8(new_array(&[
                string("import mpmath"),
                string("def fn(log, s):"),
                string("    if log:"),
                string("        print(f\'zeta_ / s: {s}\', flush=True)"),
                string("    s = complex(*s)"),
                string("    try:"),
                string("        s = mpmath.zeta(s)"),
                string("    except ValueError as e:"),
                string("        if s.real == 1:"),
                string("            s = complex(float(\'inf\'), 0)"),
                string("    return (s.real, s.imag)"),
            ])));
            let v20: num_complex::Complex<f64> = Math::method11(v5.clone());
            let v22: f64 = v20.re;
            let v23: num_complex::Complex<f64> = Math::method12(v5);
            let v27: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v22, v23.im))));
            let v28: pyo3::Python = Math::method13(v0_1);
            let v29: string = Math::method14(v19);
            let v31: &str = fable_library_rust::String_::LrcStr::as_str(&v29);
            let v34: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                Math::method15(pyo3::types::PyModule::from_code_bound(v28, v31, "", ""));
            let v36: pyo3::Bound<pyo3::types::PyModule> = v34.unwrap();
            let v37: string = Math::method16();
            let v39: &str = fable_library_rust::String_::LrcStr::as_str(&v37);
            let v40: pyo3::Bound<pyo3::types::PyModule> = Math::method17(v36);
            let v43: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                Math::method18(v40.getattr(v39));
            let v45: pyo3::Bound<pyo3::PyAny> = v43.unwrap();
            let v46: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method19(v27.0.clone(), v27.1.clone());
            let v47: pyo3::Bound<pyo3::PyAny> = Math::method20(v45);
            let v50: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method18(
                pyo3::prelude::PyAnyMethods::call(&v47, ((*v46).0, *(*v46).1), None),
            );
            let v53: pyo3::Bound<pyo3::PyAny> = Math::method21(v50.unwrap());
            let v56: Result<(f64, f64), pyo3::PyErr> = Math::method22(v53.extract());
            let patternInput: (f64, f64) = v56.unwrap();
            let v61: f64 = Math::method3(Math::method23(patternInput.0.clone()));
            let v62: f64 = Math::method24(patternInput.1.clone());
            let v66: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                Math::method25(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                    num_complex::Complex::new(v61, v62),
                ));
            let v68: num_complex::Complex<f64> = v66.unwrap();
            let v70: f64 = Math::method3(Math::method26());
            let v71: f64 = Math::method4();
            let v73: num_complex::Complex<f64> = num_complex::Complex::new(v70, v71);
            let v74: num_complex::Complex<f64> = Math::method11(v68.clone());
            let v76: f64 = v74.re;
            let v77: bool = v76 < f64::INFINITY;
            if (if v77 { true } else { Math::method27(v77) }) == false {
                panic!(
                    "{}",
                    sprintf!(
                        "__expect / actual: {:?} / expected: {:?}",
                        v76,
                        f64::INFINITY
                    ),
                );
            }
            {
                let v82: num_complex::Complex<f64> = Math::method12(v68);
                let v84: f64 = v82.im;
                let v85: bool = v84 < f64::INFINITY;
                if (if v85 { true } else { Math::method27(v85) }) == false {
                    panic!(
                        "{}",
                        sprintf!(
                            "__expect / actual: {:?} / expected: {:?}",
                            v84,
                            f64::INFINITY
                        ),
                    );
                }
            }
        }
        pub fn method56() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method57(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method28(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method29(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method61(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method5());
            let v3: f64 = Math::method4();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v19: string = Math::method9(Math::method8(new_array(&[
                string("import mpmath"),
                string("def fn(log, s):"),
                string("    if log:"),
                string("        print(f\'zeta_ / s: {s}\', flush=True)"),
                string("    s = complex(*s)"),
                string("    try:"),
                string("        s = mpmath.zeta(s)"),
                string("    except ValueError as e:"),
                string("        if s.real == 1:"),
                string("            s = complex(float(\'inf\'), 0)"),
                string("    return (s.real, s.imag)"),
            ])));
            let v20: num_complex::Complex<f64> = Math::method11(v5.clone());
            let v22: f64 = v20.re;
            let v23: num_complex::Complex<f64> = Math::method12(v5);
            let v27: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v22, v23.im))));
            let v28: pyo3::Python = Math::method13(v0_1);
            let v29: string = Math::method14(v19);
            let v31: &str = fable_library_rust::String_::LrcStr::as_str(&v29);
            let v34: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                Math::method15(pyo3::types::PyModule::from_code_bound(v28, v31, "", ""));
            let v36: pyo3::Bound<pyo3::types::PyModule> = v34.unwrap();
            let v37: string = Math::method16();
            let v39: &str = fable_library_rust::String_::LrcStr::as_str(&v37);
            let v40: pyo3::Bound<pyo3::types::PyModule> = Math::method17(v36);
            let v43: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                Math::method18(v40.getattr(v39));
            let v45: pyo3::Bound<pyo3::PyAny> = v43.unwrap();
            let v46: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method19(v27.0.clone(), v27.1.clone());
            let v47: pyo3::Bound<pyo3::PyAny> = Math::method20(v45);
            let v50: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method18(
                pyo3::prelude::PyAnyMethods::call(&v47, ((*v46).0, *(*v46).1), None),
            );
            let v53: pyo3::Bound<pyo3::PyAny> = Math::method21(v50.unwrap());
            let v56: Result<(f64, f64), pyo3::PyErr> = Math::method22(v53.extract());
            let patternInput: (f64, f64) = v56.unwrap();
            let v61: f64 = Math::method3(Math::method23(patternInput.0.clone()));
            let v62: f64 = Math::method24(patternInput.1.clone());
            let v66: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                Math::method25(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                    num_complex::Complex::new(v61, v62),
                ));
            let v68: num_complex::Complex<f64> = v66.unwrap();
            let v70: f64 = Math::method3(Math::method26());
            let v71: f64 = Math::method4();
            let v73: num_complex::Complex<f64> = num_complex::Complex::new(v70, v71);
            let v74: num_complex::Complex<f64> = Math::method11(v68.clone());
            let v77: f64 = v74.re + 0.08333333333333333_f64;
            let v78: f64 = -v77;
            let v80: f64 = if v77 >= v78 { v77 } else { v78 };
            let v81: bool = v80 < 0.0001_f64;
            if (if v81 { true } else { Math::method27(v81) }) == false {
                panic!(
                    "{}",
                    sprintf!("__expect / actual: {:?} / expected: {:?}", v80, 0.0001_f64),
                );
            }
            {
                let v86: num_complex::Complex<f64> = Math::method12(v68);
                let v88: f64 = v86.im;
                let v89: bool = v88 == 0.0_f64;
                if (if v89 { true } else { Math::method27(v89) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v88, 0.0_f64),
                    );
                }
            }
        }
        pub fn method60() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method61(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method28(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method29(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method64() -> Array<f64> {
            Math::method49(new_array(&[
                10.0_f64, 20.0_f64, 30.0_f64, 40.0_f64, 50.0_f64, 60.0_f64, 70.0_f64, 80.0_f64,
                90.0_f64, 100.0_f64,
            ]))
        }
        pub fn method65(v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn method63(v0_1: pyo3::Python) {
            let v1_1: Array<f64> = Math::method64();
            let v2: i32 = count(v1_1.clone());
            let v3: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method7(v2, v3.clone()) {
                let v5: i32 = v3.l0.get().clone();
                let v6: f64 = v1_1[v5].clone();
                let v8: f64 = Math::method3(Math::method26());
                let v9: f64 = Math::method24(v6);
                let v11: num_complex::Complex<f64> = num_complex::Complex::new(v8, v9);
                let v25: string = Math::method9(Math::method8(new_array(&[
                    string("import mpmath"),
                    string("def fn(log, s):"),
                    string("    if log:"),
                    string("        print(f\'zeta_ / s: {s}\', flush=True)"),
                    string("    s = complex(*s)"),
                    string("    try:"),
                    string("        s = mpmath.zeta(s)"),
                    string("    except ValueError as e:"),
                    string("        if s.real == 1:"),
                    string("            s = complex(float(\'inf\'), 0)"),
                    string("    return (s.real, s.imag)"),
                ])));
                let v26: num_complex::Complex<f64> = Math::method11(v11.clone());
                let v28: f64 = v26.re;
                let v29: num_complex::Complex<f64> = Math::method12(v11);
                let v33: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    LrcPtr::new((false, LrcPtr::new((v28, v29.im))));
                let v34: pyo3::Python = Math::method13(v0_1.clone());
                let v35: string = Math::method14(v25);
                let v37: &str = fable_library_rust::String_::LrcStr::as_str(&v35);
                let v40: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                    Math::method15(pyo3::types::PyModule::from_code_bound(v34, v37, "", ""));
                let v42: pyo3::Bound<pyo3::types::PyModule> = v40.unwrap();
                let v43: string = Math::method16();
                let v45: &str = fable_library_rust::String_::LrcStr::as_str(&v43);
                let v46: pyo3::Bound<pyo3::types::PyModule> = Math::method17(v42);
                let v49: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                    Math::method18(v46.getattr(v45));
                let v51: pyo3::Bound<pyo3::PyAny> = v49.unwrap();
                let v52: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    Math::method19(v33.0.clone(), v33.1.clone());
                let v53: pyo3::Bound<pyo3::PyAny> = Math::method20(v51);
                let v56: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method18(
                    pyo3::prelude::PyAnyMethods::call(&v53, ((*v52).0, *(*v52).1), None),
                );
                let v59: pyo3::Bound<pyo3::PyAny> = Math::method21(v56.unwrap());
                let v62: Result<(f64, f64), pyo3::PyErr> = Math::method22(v59.extract());
                let patternInput: (f64, f64) = v62.unwrap();
                let v67: f64 = Math::method3(Math::method23(patternInput.0.clone()));
                let v68: f64 = Math::method24(patternInput.1.clone());
                let v72: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method25(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                        num_complex::Complex::new(v67, v68),
                    ));
                let v74: num_complex::Complex<f64> = v72.unwrap();
                let v76: f64 = Math::method3(Math::method26());
                let v77: f64 = Math::method4();
                let v79: num_complex::Complex<f64> = num_complex::Complex::new(v76, v77);
                let v80: num_complex::Complex<f64> = Math::method11(v74.clone());
                let v82: f64 = v80.re;
                let v84: bool = Math::method65(v82 == 0.0_f64);
                if (if v84 { true } else { Math::method27(v84) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v82, 0.0_f64),
                    );
                }
                {
                    let v89: num_complex::Complex<f64> = Math::method12(v74);
                    let v91: f64 = v89.im;
                    let v93: bool = Math::method65(v91 == 0.0_f64);
                    if (if v93 { true } else { Math::method27(v93) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v91, 0.0_f64),
                        );
                    }
                    {
                        let v98: i32 = v5 + 1_i32;
                        v3.l0.set(v98);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method62() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method63(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method28(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method29(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method68() -> f64 {
            0.75_f64
        }
        pub fn method69() -> f64 {
            20.5_f64
        }
        pub fn method70() -> f64 {
            1.25_f64
        }
        pub fn method71() -> f64 {
            30.1_f64
        }
        pub fn method72() -> f64 {
            0.25_f64
        }
        pub fn method73() -> f64 {
            40.0_f64
        }
        pub fn method74() -> f64 {
            50.0_f64
        }
        pub fn method67(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method39());
            let v3: f64 = Math::method40();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v7: f64 = Math::method3(Math::method68());
            let v8: f64 = Math::method69();
            let v10: num_complex::Complex<f64> = num_complex::Complex::new(v7, v8);
            let v12: f64 = Math::method3(Math::method70());
            let v13: f64 = Math::method71();
            let v15: num_complex::Complex<f64> = num_complex::Complex::new(v12, v13);
            let v17: f64 = Math::method3(Math::method72());
            let v18: f64 = Math::method73();
            let v20: num_complex::Complex<f64> = num_complex::Complex::new(v17, v18);
            let v22: f64 = Math::method3(Math::method52());
            let v23: f64 = Math::method74();
            let v27: Array<num_complex::Complex<f64>> = Math::method46(new_array(&[
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
                let v46: string = Math::method9(Math::method8(new_array(&[
                    string("import mpmath"),
                    string("def fn(log, s):"),
                    string("    if log:"),
                    string("        print(f\'zeta_ / s: {s}\', flush=True)"),
                    string("    s = complex(*s)"),
                    string("    try:"),
                    string("        s = mpmath.zeta(s)"),
                    string("    except ValueError as e:"),
                    string("        if s.real == 1:"),
                    string("            s = complex(float(\'inf\'), 0)"),
                    string("    return (s.real, s.imag)"),
                ])));
                let v47: num_complex::Complex<f64> = Math::method11(v32.clone());
                let v49: f64 = v47.re;
                let v50: num_complex::Complex<f64> = Math::method12(v32);
                let v54: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    LrcPtr::new((false, LrcPtr::new((v49, v50.im))));
                let v55: pyo3::Python = Math::method13(v0_1.clone());
                let v56: string = Math::method14(v46);
                let v58: &str = fable_library_rust::String_::LrcStr::as_str(&v56);
                let v61: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                    Math::method15(pyo3::types::PyModule::from_code_bound(v55, v58, "", ""));
                let v63: pyo3::Bound<pyo3::types::PyModule> = v61.unwrap();
                let v64: string = Math::method16();
                let v66: &str = fable_library_rust::String_::LrcStr::as_str(&v64);
                let v67: pyo3::Bound<pyo3::types::PyModule> = Math::method17(v63);
                let v70: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                    Math::method18(v67.getattr(v66));
                let v72: pyo3::Bound<pyo3::PyAny> = v70.unwrap();
                let v73: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    Math::method19(v54.0.clone(), v54.1.clone());
                let v74: pyo3::Bound<pyo3::PyAny> = Math::method20(v72);
                let v77: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method18(
                    pyo3::prelude::PyAnyMethods::call(&v74, ((*v73).0, *(*v73).1), None),
                );
                let v80: pyo3::Bound<pyo3::PyAny> = Math::method21(v77.unwrap());
                let v83: Result<(f64, f64), pyo3::PyErr> = Math::method22(v80.extract());
                let patternInput: (f64, f64) = v83.unwrap();
                let v88: f64 = Math::method3(Math::method23(patternInput.0.clone()));
                let v89: f64 = Math::method24(patternInput.1.clone());
                let v93: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method25(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                        num_complex::Complex::new(v88, v89),
                    ));
                let v95: num_complex::Complex<f64> = v93.unwrap();
                let v97: f64 = Math::method3(Math::method26());
                let v98: f64 = Math::method4();
                let v100: num_complex::Complex<f64> = num_complex::Complex::new(v97, v98);
                let v101: num_complex::Complex<f64> = Math::method11(v95.clone());
                let v103: f64 = v101.re;
                let v105: bool = Math::method65(v103 == 0.0_f64);
                if (if v105 { true } else { Math::method27(v105) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v103, 0.0_f64),
                    );
                }
                {
                    let v110: num_complex::Complex<f64> = Math::method12(v95);
                    let v112: f64 = v110.im;
                    let v114: bool = Math::method65(v112 == 0.0_f64);
                    if (if v114 { true } else { Math::method27(v114) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v112, 0.0_f64),
                        );
                    }
                    {
                        let v119: i32 = v31 + 1_i32;
                        v29.l0.set(v119);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method66() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method67(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method28(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method29(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method77() -> f64 {
            3.0_f64
        }
        pub fn method78() -> f64 {
            4.0_f64
        }
        pub fn method79() -> f64 {
            2.5_f64
        }
        pub fn method80() -> f64 {
            -3.5_f64
        }
        pub fn method81() -> f64 {
            1.5_f64
        }
        pub fn method82() -> f64 {
            2.5_f64
        }
        pub fn method83(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method84(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method85() -> f64 {
            3.141592653589793_f64
        }
        pub fn method76(v0_1: pyo3::Python) {
            let v2: f64 = Math::method3(Math::method77());
            let v3: f64 = Math::method78();
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v7: f64 = Math::method3(Math::method79());
            let v8: f64 = Math::method80();
            let v10: num_complex::Complex<f64> = num_complex::Complex::new(v7, v8);
            let v12: f64 = Math::method3(Math::method81());
            let v13: f64 = Math::method82();
            let v15: num_complex::Complex<f64> = num_complex::Complex::new(v12, v13);
            let v17: f64 = Math::method3(Math::method39());
            let v18: f64 = Math::method40();
            let v22: Array<num_complex::Complex<f64>> = Math::method46(new_array(&[
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
                let v41: string = Math::method9(Math::method8(new_array(&[
                    string("import mpmath"),
                    string("def fn(log, s):"),
                    string("    if log:"),
                    string("        print(f\'zeta_ / s: {s}\', flush=True)"),
                    string("    s = complex(*s)"),
                    string("    try:"),
                    string("        s = mpmath.zeta(s)"),
                    string("    except ValueError as e:"),
                    string("        if s.real == 1:"),
                    string("            s = complex(float(\'inf\'), 0)"),
                    string("    return (s.real, s.imag)"),
                ])));
                let v42: num_complex::Complex<f64> = Math::method11(v27.clone());
                let v44: f64 = v42.re;
                let v45: num_complex::Complex<f64> = Math::method12(v27.clone());
                let v49: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    LrcPtr::new((false, LrcPtr::new((v44, v45.im))));
                let v50: pyo3::Python = Math::method13(v0_1.clone());
                let v51: string = Math::method14(v41);
                let v53: &str = fable_library_rust::String_::LrcStr::as_str(&v51);
                let v56: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                    Math::method15(pyo3::types::PyModule::from_code_bound(v50, v53, "", ""));
                let v58: pyo3::Bound<pyo3::types::PyModule> = v56.unwrap();
                let v59: string = Math::method16();
                let v61: &str = fable_library_rust::String_::LrcStr::as_str(&v59);
                let v62: pyo3::Bound<pyo3::types::PyModule> = Math::method17(v58);
                let v65: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                    Math::method18(v62.getattr(v61));
                let v67: pyo3::Bound<pyo3::PyAny> = v65.unwrap();
                let v68: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    Math::method19(v49.0.clone(), v49.1.clone());
                let v69: pyo3::Bound<pyo3::PyAny> = Math::method20(v67);
                let v72: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method18(
                    pyo3::prelude::PyAnyMethods::call(&v69, ((*v68).0, *(*v68).1), None),
                );
                let v75: pyo3::Bound<pyo3::PyAny> = Math::method21(v72.unwrap());
                let v78: Result<(f64, f64), pyo3::PyErr> = Math::method22(v75.extract());
                let patternInput: (f64, f64) = v78.unwrap();
                let v83: f64 = Math::method3(Math::method23(patternInput.0.clone()));
                let v84: f64 = Math::method24(patternInput.1.clone());
                let v88: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method25(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                        num_complex::Complex::new(v83, v84),
                    ));
                let v90: num_complex::Complex<f64> = v88.unwrap();
                let v92: f64 = Math::method3(Math::method26());
                let v93: f64 = Math::method4();
                let v95: num_complex::Complex<f64> = num_complex::Complex::new(v92, v93);
                let v97: f64 = Math::method3(Math::method2());
                let v98: f64 = Math::method4();
                let v101: num_complex::Complex<f64> =
                    Math::method83(num_complex::Complex::new(v97, v98));
                let v102: num_complex::Complex<f64> = Math::method84(v27.clone());
                let v104: num_complex::Complex<f64> = num_complex::Complex::powc(v101, v102);
                let v106: f64 = Math::method3(Math::method85());
                let v107: f64 = Math::method4();
                let v109: num_complex::Complex<f64> = num_complex::Complex::new(v106, v107);
                let v111: f64 = Math::method3(Math::method52());
                let v112: f64 = Math::method4();
                let v114: num_complex::Complex<f64> = num_complex::Complex::new(v111, v112);
                let v116: num_complex::Complex<f64> = v27 - v114;
                let v117: num_complex::Complex<f64> = Math::method83(v109);
                let v118: num_complex::Complex<f64> = Math::method84(v116);
                let v120: num_complex::Complex<f64> = num_complex::Complex::powc(v117, v118);
                let v122: num_complex::Complex<f64> = v104 * v120;
                let v124: f64 = Math::method3(Math::method85());
                let v125: f64 = Math::method4();
                let v127: num_complex::Complex<f64> = num_complex::Complex::new(v124, v125);
                let v129: num_complex::Complex<f64> = v127 * v27;
                let v131: f64 = Math::method3(Math::method2());
                let v132: f64 = Math::method4();
                let v134: num_complex::Complex<f64> = num_complex::Complex::new(v131, v132);
                let v136: num_complex::Complex<f64> = v129 / v134;
                let v138: num_complex::Complex<f64> = v136.sin();
                let v140: num_complex::Complex<f64> = v122 * v138;
                let v142: f64 = Math::method3(Math::method52());
                let v143: f64 = Math::method4();
                let v145: num_complex::Complex<f64> = num_complex::Complex::new(v142, v143);
                let v147: num_complex::Complex<f64> = v145 - v27;
                let v152: string = Math::method9(Math::method8(new_array(&[
                    string("import mpmath"),
                    string("def fn(log, s):"),
                    string("    if log:"),
                    string("        print(f\'gamma_ / s: {s}\', flush=True)"),
                    string("    s = complex(*s)"),
                    string("    s = mpmath.gamma(s)"),
                    string("    return (s.real, s.imag)"),
                ])));
                let v153: num_complex::Complex<f64> = Math::method11(v147.clone());
                let v155: f64 = v153.re;
                let v156: num_complex::Complex<f64> = Math::method12(v147);
                let v160: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    LrcPtr::new((false, LrcPtr::new((v155, v156.im))));
                let v161: pyo3::Python = Math::method13(v0_1.clone());
                let v162: string = Math::method14(v152);
                let v164: &str = fable_library_rust::String_::LrcStr::as_str(&v162);
                let v167: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                    Math::method15(pyo3::types::PyModule::from_code_bound(v161, v164, "", ""));
                let v169: pyo3::Bound<pyo3::types::PyModule> = v167.unwrap();
                let v170: string = Math::method16();
                let v172: &str = fable_library_rust::String_::LrcStr::as_str(&v170);
                let v173: pyo3::Bound<pyo3::types::PyModule> = Math::method17(v169);
                let v176: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                    Math::method18(v173.getattr(v172));
                let v178: pyo3::Bound<pyo3::PyAny> = v176.unwrap();
                let v179: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    Math::method19(v160.0.clone(), v160.1.clone());
                let v180: pyo3::Bound<pyo3::PyAny> = Math::method20(v178);
                let v183: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method18(
                    pyo3::prelude::PyAnyMethods::call(&v180, ((*v179).0, *(*v179).1), None),
                );
                let v186: pyo3::Bound<pyo3::PyAny> = Math::method21(v183.unwrap());
                let v189: Result<(f64, f64), pyo3::PyErr> = Math::method22(v186.extract());
                let patternInput_1: (f64, f64) = v189.unwrap();
                let v194: f64 = Math::method3(Math::method23(patternInput_1.0.clone()));
                let v195: f64 = Math::method24(patternInput_1.1.clone());
                let v199: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method25(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                        num_complex::Complex::new(v194, v195),
                    ));
                let v201: num_complex::Complex<f64> = v199.unwrap();
                let v203: num_complex::Complex<f64> = v140 * v201;
                let v204: num_complex::Complex<f64> = Math::method11(v27.clone());
                let v207: f64 = 1.0_f64 - v204.re;
                let v208: num_complex::Complex<f64> = Math::method12(v27);
                let v211: f64 = -v208.im;
                let v213: f64 = Math::method3(Math::method23(v207));
                let v214: f64 = Math::method24(v211);
                let v216: num_complex::Complex<f64> = num_complex::Complex::new(v213, v214);
                let v219: string = Math::method9(Math::method8(new_array(&[
                    string("import mpmath"),
                    string("def fn(log, s):"),
                    string("    if log:"),
                    string("        print(f\'zeta_ / s: {s}\', flush=True)"),
                    string("    s = complex(*s)"),
                    string("    try:"),
                    string("        s = mpmath.zeta(s)"),
                    string("    except ValueError as e:"),
                    string("        if s.real == 1:"),
                    string("            s = complex(float(\'inf\'), 0)"),
                    string("    return (s.real, s.imag)"),
                ])));
                let v220: num_complex::Complex<f64> = Math::method11(v216.clone());
                let v222: f64 = v220.re;
                let v223: num_complex::Complex<f64> = Math::method12(v216);
                let v227: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    LrcPtr::new((false, LrcPtr::new((v222, v223.im))));
                let v228: pyo3::Python = Math::method13(v0_1.clone());
                let v229: string = Math::method14(v219);
                let v231: &str = fable_library_rust::String_::LrcStr::as_str(&v229);
                let v234: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                    Math::method15(pyo3::types::PyModule::from_code_bound(v228, v231, "", ""));
                let v236: pyo3::Bound<pyo3::types::PyModule> = v234.unwrap();
                let v237: string = Math::method16();
                let v239: &str = fable_library_rust::String_::LrcStr::as_str(&v237);
                let v240: pyo3::Bound<pyo3::types::PyModule> = Math::method17(v236);
                let v243: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                    Math::method18(v240.getattr(v239));
                let v245: pyo3::Bound<pyo3::PyAny> = v243.unwrap();
                let v246: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    Math::method19(v227.0.clone(), v227.1.clone());
                let v247: pyo3::Bound<pyo3::PyAny> = Math::method20(v245);
                let v250: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method18(
                    pyo3::prelude::PyAnyMethods::call(&v247, ((*v246).0, *(*v246).1), None),
                );
                let v253: pyo3::Bound<pyo3::PyAny> = Math::method21(v250.unwrap());
                let v256: Result<(f64, f64), pyo3::PyErr> = Math::method22(v253.extract());
                let patternInput_2: (f64, f64) = v256.unwrap();
                let v261: f64 = Math::method3(Math::method23(patternInput_2.0.clone()));
                let v262: f64 = Math::method24(patternInput_2.1.clone());
                let v266: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method25(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                        num_complex::Complex::new(v261, v262),
                    ));
                let v268: num_complex::Complex<f64> = v266.unwrap();
                let v270: f64 = Math::method3(Math::method26());
                let v271: f64 = Math::method4();
                let v273: num_complex::Complex<f64> = num_complex::Complex::new(v270, v271);
                let v275: num_complex::Complex<f64> = v203 * v268;
                let v276: num_complex::Complex<f64> = Math::method11(v90.clone());
                let v278: f64 = v276.re;
                let v279: num_complex::Complex<f64> = Math::method11(v275.clone());
                let v282: f64 = v278 - v279.re;
                let v283: f64 = -v282;
                let v285: f64 = if v282 >= v283 { v282 } else { v283 };
                let v286: bool = v285 < 0.0001_f64;
                if (if v286 { true } else { Math::method27(v286) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v285, 0.0001_f64),
                    );
                }
                {
                    let v291: num_complex::Complex<f64> = Math::method12(v90);
                    let v293: f64 = v291.im;
                    let v294: num_complex::Complex<f64> = Math::method12(v275);
                    let v297: f64 = v293 - v294.im;
                    let v298: f64 = -v297;
                    let v300: f64 = if v297 >= v298 { v297 } else { v298 };
                    let v301: bool = v300 < 0.0001_f64;
                    if (if v301 { true } else { Math::method27(v301) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v300, 0.0001_f64),
                        );
                    }
                    {
                        let v306: i32 = v26 + 1_i32;
                        v24.l0.set(v306);
                        ()
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
                    let v5: Result<(), pyo3::PyErr> = Math::method28(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method29(__result);
                    v10.unwrap();
                    ()
                }
            }
        }
        pub fn method88(v0_1: i32, v1_1: LrcPtr<Math::Mut2>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method87(v0_1: pyo3::Python) {
            let v2: Array<f64> = Math::method49(new_array(&[
                2.0_f64, 2.5_f64, 3.0_f64, 3.5_f64, 4.0_f64, 4.5_f64, 5.0_f64,
            ]));
            let v4: Array<f64> = Math::method49(new_array(&[
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
                let v11: f64 = Math::method3(Math::method23(v9));
                let v12: f64 = Math::method4();
                let v14: num_complex::Complex<f64> = num_complex::Complex::new(v11, v12);
                let v15: i32 = count(v4.clone());
                let v16: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(1.0_f64),
                });
                while Math::method88(v15, v16.clone()) {
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
                    let v40: string = Math::method9(Math::method8(new_array(&[
                        string("import mpmath"),
                        string("def fn(log, s):"),
                        string("    if log:"),
                        string("        print(f\'zeta_ / s: {s}\', flush=True)"),
                        string("    s = complex(*s)"),
                        string("    try:"),
                        string("        s = mpmath.zeta(s)"),
                        string("    except ValueError as e:"),
                        string("        if s.real == 1:"),
                        string("            s = complex(float(\'inf\'), 0)"),
                        string("    return (s.real, s.imag)"),
                    ])));
                    let v41: num_complex::Complex<f64> = Math::method11(v14.clone());
                    let v43: f64 = v41.re;
                    let v44: num_complex::Complex<f64> = Math::method12(v14);
                    let v48: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                        LrcPtr::new((false, LrcPtr::new((v43, v44.im))));
                    let v49: pyo3::Python = Math::method13(v0_1.clone());
                    let v50: string = Math::method14(v40);
                    let v52: &str = fable_library_rust::String_::LrcStr::as_str(&v50);
                    let v55: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                        Math::method15(pyo3::types::PyModule::from_code_bound(v49, v52, "", ""));
                    let v57: pyo3::Bound<pyo3::types::PyModule> = v55.unwrap();
                    let v58: string = Math::method16();
                    let v60: &str = fable_library_rust::String_::LrcStr::as_str(&v58);
                    let v61: pyo3::Bound<pyo3::types::PyModule> = Math::method17(v57);
                    let v64: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                        Math::method18(v61.getattr(v60));
                    let v66: pyo3::Bound<pyo3::PyAny> = v64.unwrap();
                    let v67: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                        Math::method19(v48.0.clone(), v48.1.clone());
                    let v68: pyo3::Bound<pyo3::PyAny> = Math::method20(v66);
                    let v71: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method18(
                        pyo3::prelude::PyAnyMethods::call(&v68, ((*v67).0, *(*v67).1), None),
                    );
                    let v74: pyo3::Bound<pyo3::PyAny> = Math::method21(v71.unwrap());
                    let v77: Result<(f64, f64), pyo3::PyErr> = Math::method22(v74.extract());
                    let patternInput: (f64, f64) = v77.unwrap();
                    let v82: f64 = Math::method3(Math::method23(patternInput.0.clone()));
                    let v83: f64 = Math::method24(patternInput.1.clone());
                    let v87: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                        Math::method25(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                            num_complex::Complex::new(v82, v83),
                        ));
                    let v89: num_complex::Complex<f64> = v87.unwrap();
                    let v91: f64 = Math::method3(Math::method26());
                    let v92: f64 = Math::method4();
                    let v94: num_complex::Complex<f64> = num_complex::Complex::new(v91, v92);
                    let v95: num_complex::Complex<f64> = Math::method11(v89.clone());
                    let v98: f64 = v95.re - v26;
                    let v99: f64 = -v98;
                    let v101: f64 = if v98 >= v99 { v98 } else { v99 };
                    let v102: bool = v101 < 0.01_f64;
                    if (if v102 { true } else { Math::method27(v102) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v101, 0.01_f64),
                        );
                    }
                    {
                        let v107: num_complex::Complex<f64> = Math::method12(v89);
                        let v109: f64 = v107.im;
                        let v110: bool = v109 < 0.01_f64;
                        if (if v110 { true } else { Math::method27(v110) }) == false {
                            panic!(
                                "{}",
                                sprintf!(
                                    "__expect / actual: {:?} / expected: {:?}",
                                    v109,
                                    0.01_f64
                                ),
                            );
                        }
                        {
                            let v115: i32 = v8 + 1_i32;
                            v6.l0.set(v115);
                            ()
                        }
                    }
                }
            }
            ()
        }
        pub fn method86() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method87(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method28(Ok::<(), pyo3::PyErr>(()));
                    v5
                }
            });
            {
                //;
                {
                    let v10: Result<(), pyo3::PyErr> = Math::method29(__result);
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
            Math::method30();
        }
        #[test]
        fn test_trivial_zero_at_negative_even___() {
            //;
            Math::method33();
        }
        #[test]
        fn test_non_trivial_zero___() {
            //;
            Math::method37();
        }
        #[test]
        fn test_real_part_greater_than_one___() {
            //;
            Math::method47();
        }
        #[test]
        fn test_zeta_at_1___() {
            //;
            Math::method50();
        }
        #[test]
        fn test_symmetry_across_real_axis___() {
            //;
            Math::method53();
        }
        #[test]
        fn test_behavior_near_origin___() {
            //;
            Math::method56();
        }
        #[test]
        fn test_zeta_at_minus_1() {
            //;
            Math::method60();
        }
        #[test]
        fn test_imaginary_axis() {
            //;
            Math::method62();
        }
        #[test]
        fn test_critical_strip() {
            //;
            Math::method66();
        }
        #[test]
        fn test_reflection_formula_for_specific_value() {
            //;
            Math::method75();
        }
        #[test]
        fn test_euler_product_formula() {
            //;
            Math::method86()
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
