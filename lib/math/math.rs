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
        pub fn method1() -> f64 {
            2.0_f64
        }
        pub fn method2() -> f64 {
            0.0_f64
        }
        pub fn method3() -> f64 {
            -1.0_f64
        }
        pub fn method4(
            v0_1: Array<(num_complex::Complex<f64>, f64)>,
        ) -> Array<(num_complex::Complex<f64>, f64)> {
            v0_1
        }
        pub fn method5(v0_1: i32, v1_1: LrcPtr<Math::Mut0>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method6(v0_1: Array<string>) -> Array<string> {
            v0_1
        }
        pub fn method7(v0_1: i32, v1_1: LrcPtr<Math::Mut1>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method8(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method9(v0_1: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0_1
        }
        pub fn method10(v0_1: pyo3::Python) -> pyo3::Python {
            v0_1
        }
        pub fn method11(v0_1: string) -> string {
            v0_1
        }
        pub fn method12(
            v0_1: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr>,
        ) -> Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> {
            v0_1
        }
        pub fn method13() -> string {
            string("fn")
        }
        pub fn method14(
            v0_1: pyo3::Bound<pyo3::types::PyModule>,
        ) -> pyo3::Bound<pyo3::types::PyModule> {
            v0_1
        }
        pub fn method15(
            v0_1: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr>,
        ) -> Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> {
            v0_1
        }
        pub fn method16(v0_: LrcPtr<(f64, f64)>, v0__1: ()) -> LrcPtr<(LrcPtr<(f64, f64)>, ())> {
            LrcPtr::new((v0_, ()))
        }
        pub fn method17(v0_1: pyo3::Bound<pyo3::PyAny>) -> pyo3::Bound<pyo3::PyAny> {
            v0_1
        }
        pub fn method18(v0_1: pyo3::Bound<pyo3::PyAny>) -> pyo3::Bound<pyo3::PyAny> {
            v0_1
        }
        pub fn method19(v0_1: Result<(f64, f64), pyo3::PyErr>) -> Result<(f64, f64), pyo3::PyErr> {
            v0_1
        }
        pub fn method20(v0_1: f64) -> f64 {
            v0_1
        }
        pub fn method21(v0_1: f64) -> f64 {
            v0_1
        }
        pub fn method22(
            v0_1: Result<num_complex::Complex<f64>, pyo3::PyErr>,
        ) -> Result<num_complex::Complex<f64>, pyo3::PyErr> {
            v0_1
        }
        pub fn method23(v0_1: bool) -> bool {
            v0_1
        }
        pub fn method24(v0_1: Result<(), pyo3::PyErr>) -> Result<(), pyo3::PyErr> {
            v0_1
        }
        pub fn method25(v0_1: Result<(), pyo3::PyErr>) -> Result<(), pyo3::PyErr> {
            v0_1
        }
        pub fn method0() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                {
                    let v3: pyo3::Python = py;
                    let v4: f64 = Math::method1();
                    let v5: f64 = Math::method2();
                    let v7: num_complex::Complex<f64> = num_complex::Complex::new(v4, v5);
                    let v8: f64 = Math::method3();
                    let v9: f64 = Math::method2();
                    let v13: Array<(num_complex::Complex<f64>, f64)> = Math::method4(new_array(&[
                        (v7, 1.6449340668482264_f64),
                        (num_complex::Complex::new(v8, v9), -0.08333333333333333_f64),
                    ]));
                    let v14: i32 = count(v13.clone());
                    let v15: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                        l0: MutCell::new(0_i32),
                    });
                    while Math::method5(v14, v15.clone()) {
                        let v17: i32 = v15.l0.get().clone();
                        let patternInput: (num_complex::Complex<f64>, f64) = v13[v17].clone();
                        let v18: num_complex::Complex<f64> = patternInput.0.clone();
                        let v30: Array<string> = Math::method6(new_array(&[
                            string("import mpmath"),
                            string("def fn(s, _):"),
                            string("    s = complex(*s)"),
                            string("    try:"),
                            string("        s = mpmath.zeta(s)"),
                            string("    except ValueError as e:"),
                            string("        if s.real == 1:"),
                            string("            s = complex(float(\'inf\'), 0)"),
                            string("    return (s.real, s.imag)"),
                        ]));
                        let v31: i32 = count(v30.clone());
                        let v33: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(string("")),
                        });
                        while Math::method7(v31, v33.clone()) {
                            let v35: i32 = v33.l0.get().clone();
                            let v39: string = append(
                                append(
                                    append(v33.l1.get().clone(), v30[v35].clone()),
                                    string("\n"),
                                ),
                                string(""),
                            );
                            let v40: i32 = v35 + 1_i32;
                            v33.l0.set(v40);
                            v33.l1.set(v39);
                            ()
                        }
                        {
                            let v41: string = v33.l1.get().clone();
                            let v42: num_complex::Complex<f64> = Math::method8(v18.clone());
                            let v44: f64 = v42.re;
                            let v45: num_complex::Complex<f64> = Math::method9(v18);
                            let v47: f64 = v45.im;
                            let v50: pyo3::Python = Math::method10(v3.clone());
                            let v51: string = Math::method11(v41);
                            let v53: &str = fable_library_rust::String_::LrcStr::as_str(&v51);
                            let v56: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                                Math::method12(pyo3::types::PyModule::from_code_bound(
                                    v50, v53, "", "",
                                ));
                            let v58: pyo3::Bound<pyo3::types::PyModule> = v56.unwrap();
                            let v59: string = Math::method13();
                            let v61: &str = fable_library_rust::String_::LrcStr::as_str(&v59);
                            let v62: pyo3::Bound<pyo3::types::PyModule> = Math::method14(v58);
                            let v65: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                                Math::method15(v62.getattr(v61));
                            let v67: pyo3::Bound<pyo3::PyAny> = v65.unwrap();
                            let v68: LrcPtr<(LrcPtr<(f64, f64)>, ())> = Math::method16(
                                (LrcPtr::new((LrcPtr::new((v44, v47)), ()))).0.clone(),
                                (),
                            );
                            let v69: pyo3::Bound<pyo3::PyAny> = Math::method17(v67);
                            let v72: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method15(
                                pyo3::prelude::PyAnyMethods::call(&v69, (*(*v68).0, ()), None),
                            );
                            let v75: pyo3::Bound<pyo3::PyAny> = Math::method18(v72.unwrap());
                            let v78: Result<(f64, f64), pyo3::PyErr> =
                                Math::method19(v75.extract());
                            let patternInput_1: (f64, f64) = v78.unwrap();
                            let v82: f64 = Math::method20(patternInput_1.0.clone());
                            let v83: f64 = Math::method21(patternInput_1.1.clone());
                            let v87: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                                Math::method22(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                                    num_complex::Complex::new(v82, v83),
                                ));
                            let v89: num_complex::Complex<f64> = v87.unwrap();
                            let v90: num_complex::Complex<f64> = Math::method9(v89.clone());
                            let v92: f64 = v90.im;
                            let v93: bool = v92 == 0.0_f64;
                            if (if v93 { true } else { Math::method23(v93) }) == false {
                                panic!(
                                    "{}",
                                    sprintf!(
                                        "__expect / actual: {:?} / expected: {:?}",
                                        v92,
                                        0.0_f64
                                    ),
                                );
                            }
                            {
                                let v98: num_complex::Complex<f64> = Math::method8(v89);
                                let v101: f64 = v98.re - patternInput.1.clone();
                                let v102: f64 = -v101;
                                let v104: f64 = if v101 >= v102 { v101 } else { v102 };
                                let v105: bool = v104 < 0.0001_f64;
                                if (if v105 { true } else { Math::method23(v105) }) == false {
                                    panic!(
                                        "{}",
                                        sprintf!(
                                            "__expect / actual: {:?} / expected: {:?}",
                                            v104,
                                            0.0001_f64
                                        ),
                                    );
                                }
                                {
                                    let v110: i32 = v17 + 1_i32;
                                    v15.l0.set(v110);
                                    ()
                                }
                            }
                        }
                    }
                    {
                        let v112: Result<(), pyo3::PyErr> =
                            Math::method24(Ok::<(), pyo3::PyErr>(()));
                        v112
                    }
                }
            });
            {
                {
                    //;
                    {
                        let v117: Result<(), pyo3::PyErr> = Math::method25(__result);
                        v117.unwrap();
                        ()
                    }
                }
            }
        }
        pub fn method27() -> f64 {
            -2.0_f64
        }
        pub fn method26() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                {
                    let v3: pyo3::Python = py;
                    let v4: f64 = Math::method1();
                    let v5: f64 = Math::method27();
                    let v7: num_complex::Complex<f64> = num_complex::Complex::new(v4, v5);
                    let v18: Array<string> = Math::method6(new_array(&[
                        string("import mpmath"),
                        string("def fn(s, _):"),
                        string("    s = complex(*s)"),
                        string("    try:"),
                        string("        s = mpmath.zeta(s)"),
                        string("    except ValueError as e:"),
                        string("        if s.real == 1:"),
                        string("            s = complex(float(\'inf\'), 0)"),
                        string("    return (s.real, s.imag)"),
                    ]));
                    let v19: i32 = count(v18.clone());
                    let v21: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                        l0: MutCell::new(0_i32),
                        l1: MutCell::new(string("")),
                    });
                    while Math::method7(v19, v21.clone()) {
                        let v23: i32 = v21.l0.get().clone();
                        let v27: string = append(
                            append(append(v21.l1.get().clone(), v18[v23].clone()), string("\n")),
                            string(""),
                        );
                        let v28: i32 = v23 + 1_i32;
                        v21.l0.set(v28);
                        v21.l1.set(v27);
                        ()
                    }
                    {
                        let v29: string = v21.l1.get().clone();
                        let v30: num_complex::Complex<f64> = Math::method8(v7.clone());
                        let v32: f64 = v30.re;
                        let v33: num_complex::Complex<f64> = Math::method9(v7);
                        let v35: f64 = v33.im;
                        let v38: pyo3::Python = Math::method10(v3);
                        let v39: string = Math::method11(v29);
                        let v41: &str = fable_library_rust::String_::LrcStr::as_str(&v39);
                        let v44: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                            Math::method12(pyo3::types::PyModule::from_code_bound(
                                v38, v41, "", "",
                            ));
                        let v46: pyo3::Bound<pyo3::types::PyModule> = v44.unwrap();
                        let v47: string = Math::method13();
                        let v49: &str = fable_library_rust::String_::LrcStr::as_str(&v47);
                        let v50: pyo3::Bound<pyo3::types::PyModule> = Math::method14(v46);
                        let v53: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                            Math::method15(v50.getattr(v49));
                        let v55: pyo3::Bound<pyo3::PyAny> = v53.unwrap();
                        let v56: LrcPtr<(LrcPtr<(f64, f64)>, ())> = Math::method16(
                            (LrcPtr::new((LrcPtr::new((v32, v35)), ()))).0.clone(),
                            (),
                        );
                        let v57: pyo3::Bound<pyo3::PyAny> = Math::method17(v55);
                        let v60: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method15(
                            pyo3::prelude::PyAnyMethods::call(&v57, (*(*v56).0, ()), None),
                        );
                        let v63: pyo3::Bound<pyo3::PyAny> = Math::method18(v60.unwrap());
                        let v66: Result<(f64, f64), pyo3::PyErr> = Math::method19(v63.extract());
                        let patternInput: (f64, f64) = v66.unwrap();
                        let v70: f64 = Math::method20(patternInput.0.clone());
                        let v71: f64 = Math::method21(patternInput.1.clone());
                        let v75: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                            Math::method22(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                                num_complex::Complex::new(v70, v71),
                            ));
                        let v77: num_complex::Complex<f64> = v75.unwrap();
                        let v78: num_complex::Complex<f64> = Math::method8(v77.clone());
                        let v81: f64 = v78.re - 0.8673_f64;
                        let v82: f64 = -v81;
                        let v84: f64 = if v81 >= v82 { v81 } else { v82 };
                        let v85: bool = v84 < 0.001_f64;
                        if (if v85 { true } else { Math::method23(v85) }) == false {
                            panic!(
                                "{}",
                                sprintf!(
                                    "__expect / actual: {:?} / expected: {:?}",
                                    v84,
                                    0.001_f64
                                ),
                            );
                        }
                        {
                            let v90: num_complex::Complex<f64> = Math::method9(v77);
                            let v93: f64 = v90.im - 0.275_f64;
                            let v94: f64 = -v93;
                            let v96: f64 = if v93 >= v94 { v93 } else { v94 };
                            let v97: bool = v96 < 0.001_f64;
                            if (if v97 { true } else { Math::method23(v97) }) == false {
                                panic!(
                                    "{}",
                                    sprintf!(
                                        "__expect / actual: {:?} / expected: {:?}",
                                        v96,
                                        0.001_f64
                                    ),
                                );
                            }
                            {
                                let v103: Result<(), pyo3::PyErr> =
                                    Math::method24(Ok::<(), pyo3::PyErr>(()));
                                v103
                            }
                        }
                    }
                }
            });
            {
                {
                    {
                        {
                            //;
                            {
                                let v108: Result<(), pyo3::PyErr> = Math::method25(__result);
                                v108.unwrap();
                                ()
                            }
                        }
                    }
                }
            }
        }
        pub fn method29() -> LrcPtr<Math::UH0> {
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
        pub fn method30(v0_1: pyo3::Python, v1_1: LrcPtr<Math::UH0>) {
            let v0_1: MutCell<pyo3::Python> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1_1.clone());
            '_method30: loop {
                break '_method30 (match v1_1.get().clone().as_ref() {
                    Math::UH0::UH0_1 => (),
                    Math::UH0::UH0_0(v1_1_0_0, v1_1_0_1) => {
                        let v4: f64 = Math::method20(v1_1_0_0.clone());
                        let v5: f64 = Math::method2();
                        let v7: num_complex::Complex<f64> = num_complex::Complex::new(v4, v5);
                        let v18: Array<string> = Math::method6(new_array(&[
                            string("import mpmath"),
                            string("def fn(s, _):"),
                            string("    s = complex(*s)"),
                            string("    try:"),
                            string("        s = mpmath.zeta(s)"),
                            string("    except ValueError as e:"),
                            string("        if s.real == 1:"),
                            string("            s = complex(float(\'inf\'), 0)"),
                            string("    return (s.real, s.imag)"),
                        ]));
                        let v19: i32 = count(v18.clone());
                        let v21: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(string("")),
                        });
                        while Math::method7(v19, v21.clone()) {
                            let v23: i32 = v21.l0.get().clone();
                            let v27: string = append(
                                append(
                                    append(v21.l1.get().clone(), v18[v23].clone()),
                                    string("\n"),
                                ),
                                string(""),
                            );
                            let v28: i32 = v23 + 1_i32;
                            v21.l0.set(v28);
                            v21.l1.set(v27);
                            ()
                        }
                        {
                            let v29: string = v21.l1.get().clone();
                            let v30: num_complex::Complex<f64> = Math::method8(v7.clone());
                            let v32: f64 = v30.re;
                            let v33: num_complex::Complex<f64> = Math::method9(v7);
                            let v35: f64 = v33.im;
                            let v38: pyo3::Python = Math::method10(v0_1.get().clone());
                            let v39: string = Math::method11(v29);
                            let v41: &str = fable_library_rust::String_::LrcStr::as_str(&v39);
                            let v44: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                                Math::method12(pyo3::types::PyModule::from_code_bound(
                                    v38, v41, "", "",
                                ));
                            let v46: pyo3::Bound<pyo3::types::PyModule> = v44.unwrap();
                            let v47: string = Math::method13();
                            let v49: &str = fable_library_rust::String_::LrcStr::as_str(&v47);
                            let v50: pyo3::Bound<pyo3::types::PyModule> = Math::method14(v46);
                            let v53: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                                Math::method15(v50.getattr(v49));
                            let v55: pyo3::Bound<pyo3::PyAny> = v53.unwrap();
                            let v56: LrcPtr<(LrcPtr<(f64, f64)>, ())> = Math::method16(
                                (LrcPtr::new((LrcPtr::new((v32, v35)), ()))).0.clone(),
                                (),
                            );
                            let v57: pyo3::Bound<pyo3::PyAny> = Math::method17(v55);
                            let v60: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method15(
                                pyo3::prelude::PyAnyMethods::call(&v57, (*(*v56).0, ()), None),
                            );
                            let v63: pyo3::Bound<pyo3::PyAny> = Math::method18(v60.unwrap());
                            let v66: Result<(f64, f64), pyo3::PyErr> =
                                Math::method19(v63.extract());
                            let patternInput: (f64, f64) = v66.unwrap();
                            let v70: f64 = Math::method20(patternInput.0.clone());
                            let v71: f64 = Math::method21(patternInput.1.clone());
                            let v75: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                                Math::method22(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                                    num_complex::Complex::new(v70, v71),
                                ));
                            let v77: num_complex::Complex<f64> = v75.unwrap();
                            let v78: num_complex::Complex<f64> = Math::method8(v77.clone());
                            let v80: f64 = v78.re;
                            let v81: bool = v80 == 0.0_f64;
                            if (if v81 { true } else { Math::method23(v81) }) == false {
                                panic!(
                                    "{}",
                                    sprintf!(
                                        "__expect / actual: {:?} / expected: {:?}",
                                        v80,
                                        0.0_f64
                                    ),
                                );
                            }
                            {
                                let v86: num_complex::Complex<f64> = Math::method9(v77);
                                let v88: f64 = v86.im;
                                let v89: bool = v88 == 0.0_f64;
                                if (if v89 { true } else { Math::method23(v89) }) == false {
                                    panic!(
                                        "{}",
                                        sprintf!(
                                            "__expect / actual: {:?} / expected: {:?}",
                                            v88,
                                            0.0_f64
                                        ),
                                    );
                                }
                                {
                                    let v0_1_temp: pyo3::Python = v0_1.get().clone();
                                    let v1_1_temp: LrcPtr<Math::UH0> = v1_1_0_1.clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    continue '_method30;
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method28() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                Math::method30(py, Math::method29());
                {
                    let v6: Result<(), pyo3::PyErr> = Math::method24(Ok::<(), pyo3::PyErr>(()));
                    v6
                }
            });
            {
                //;
                {
                    let v11: Result<(), pyo3::PyErr> = Math::method25(__result);
                    v11.unwrap();
                    ()
                }
            }
        }
        pub fn method32() -> f64 {
            0.5_f64
        }
        pub fn method33() -> f64 {
            14.134725_f64
        }
        pub fn method34() -> f64 {
            21.02204_f64
        }
        pub fn method35() -> f64 {
            25.010857_f64
        }
        pub fn method36() -> f64 {
            30.424876_f64
        }
        pub fn method37() -> f64 {
            32.935062_f64
        }
        pub fn method38() -> f64 {
            37.586178_f64
        }
        pub fn method39(
            v0_1: Array<num_complex::Complex<f64>>,
        ) -> Array<num_complex::Complex<f64>> {
            v0_1
        }
        pub fn method31() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                {
                    let v3: pyo3::Python = py;
                    let v4: f64 = Math::method32();
                    let v5: f64 = Math::method33();
                    let v7: num_complex::Complex<f64> = num_complex::Complex::new(v4, v5);
                    let v8: f64 = Math::method32();
                    let v9: f64 = Math::method34();
                    let v11: num_complex::Complex<f64> = num_complex::Complex::new(v8, v9);
                    let v12: f64 = Math::method32();
                    let v13: f64 = Math::method35();
                    let v15: num_complex::Complex<f64> = num_complex::Complex::new(v12, v13);
                    let v16: f64 = Math::method32();
                    let v17: f64 = Math::method36();
                    let v19: num_complex::Complex<f64> = num_complex::Complex::new(v16, v17);
                    let v20: f64 = Math::method32();
                    let v21: f64 = Math::method37();
                    let v23: num_complex::Complex<f64> = num_complex::Complex::new(v20, v21);
                    let v24: f64 = Math::method32();
                    let v25: f64 = Math::method38();
                    let v29: Array<num_complex::Complex<f64>> = Math::method39(new_array(&[
                        v7,
                        v11,
                        v15,
                        v19,
                        v23,
                        num_complex::Complex::new(v24, v25),
                    ]));
                    let v30: i32 = count(v29.clone());
                    let v31: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                        l0: MutCell::new(0_i32),
                    });
                    while Math::method5(v30, v31.clone()) {
                        let v33: i32 = v31.l0.get().clone();
                        let v34: num_complex::Complex<f64> = v29[v33].clone();
                        let v45: Array<string> = Math::method6(new_array(&[
                            string("import mpmath"),
                            string("def fn(s, _):"),
                            string("    s = complex(*s)"),
                            string("    try:"),
                            string("        s = mpmath.zeta(s)"),
                            string("    except ValueError as e:"),
                            string("        if s.real == 1:"),
                            string("            s = complex(float(\'inf\'), 0)"),
                            string("    return (s.real, s.imag)"),
                        ]));
                        let v46: i32 = count(v45.clone());
                        let v48: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(string("")),
                        });
                        while Math::method7(v46, v48.clone()) {
                            let v50: i32 = v48.l0.get().clone();
                            let v54: string = append(
                                append(
                                    append(v48.l1.get().clone(), v45[v50].clone()),
                                    string("\n"),
                                ),
                                string(""),
                            );
                            let v55: i32 = v50 + 1_i32;
                            v48.l0.set(v55);
                            v48.l1.set(v54);
                            ()
                        }
                        {
                            let v56: string = v48.l1.get().clone();
                            let v57: num_complex::Complex<f64> = Math::method8(v34.clone());
                            let v59: f64 = v57.re;
                            let v60: num_complex::Complex<f64> = Math::method9(v34);
                            let v62: f64 = v60.im;
                            let v65: pyo3::Python = Math::method10(v3.clone());
                            let v66: string = Math::method11(v56);
                            let v68: &str = fable_library_rust::String_::LrcStr::as_str(&v66);
                            let v71: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                                Math::method12(pyo3::types::PyModule::from_code_bound(
                                    v65, v68, "", "",
                                ));
                            let v73: pyo3::Bound<pyo3::types::PyModule> = v71.unwrap();
                            let v74: string = Math::method13();
                            let v76: &str = fable_library_rust::String_::LrcStr::as_str(&v74);
                            let v77: pyo3::Bound<pyo3::types::PyModule> = Math::method14(v73);
                            let v80: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                                Math::method15(v77.getattr(v76));
                            let v82: pyo3::Bound<pyo3::PyAny> = v80.unwrap();
                            let v83: LrcPtr<(LrcPtr<(f64, f64)>, ())> = Math::method16(
                                (LrcPtr::new((LrcPtr::new((v59, v62)), ()))).0.clone(),
                                (),
                            );
                            let v84: pyo3::Bound<pyo3::PyAny> = Math::method17(v82);
                            let v87: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method15(
                                pyo3::prelude::PyAnyMethods::call(&v84, (*(*v83).0, ()), None),
                            );
                            let v90: pyo3::Bound<pyo3::PyAny> = Math::method18(v87.unwrap());
                            let v93: Result<(f64, f64), pyo3::PyErr> =
                                Math::method19(v90.extract());
                            let patternInput: (f64, f64) = v93.unwrap();
                            let v97: f64 = Math::method20(patternInput.0.clone());
                            let v98: f64 = Math::method21(patternInput.1.clone());
                            let v102: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                                Math::method22(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                                    num_complex::Complex::new(v97, v98),
                                ));
                            let v104: num_complex::Complex<f64> = v102.unwrap();
                            let v105: num_complex::Complex<f64> = Math::method8(v104.clone());
                            let v107: f64 = v105.re;
                            let v108: f64 = -v107;
                            let v110: f64 = if v107 >= v108 { v107 } else { v108 };
                            let v111: bool = v110 < 0.0001_f64;
                            if (if v111 { true } else { Math::method23(v111) }) == false {
                                panic!(
                                    "{}",
                                    sprintf!(
                                        "__expect / actual: {:?} / expected: {:?}",
                                        v110,
                                        0.0001_f64
                                    ),
                                );
                            }
                            {
                                let v116: num_complex::Complex<f64> = Math::method9(v104);
                                let v118: f64 = v116.im;
                                let v119: f64 = -v118;
                                let v121: f64 = if v118 >= v119 { v118 } else { v119 };
                                let v122: bool = v121 < 0.0001_f64;
                                if (if v122 { true } else { Math::method23(v122) }) == false {
                                    panic!(
                                        "{}",
                                        sprintf!(
                                            "__expect / actual: {:?} / expected: {:?}",
                                            v121,
                                            0.0001_f64
                                        ),
                                    );
                                }
                                {
                                    let v127: i32 = v33 + 1_i32;
                                    v31.l0.set(v127);
                                    ()
                                }
                            }
                        }
                    }
                    {
                        let v129: Result<(), pyo3::PyErr> =
                            Math::method24(Ok::<(), pyo3::PyErr>(()));
                        v129
                    }
                }
            });
            {
                {
                    //;
                    {
                        let v134: Result<(), pyo3::PyErr> = Math::method25(__result);
                        v134.unwrap();
                        ()
                    }
                }
            }
        }
        pub fn method41(v0_1: Array<f64>) -> Array<f64> {
            v0_1
        }
        pub fn method40() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                {
                    let v3: pyo3::Python = py;
                    let v5: Array<f64> = Math::method41(new_array(&[
                        2.0_f64, 3.0_f64, 4.0_f64, 5.0_f64, 10.0_f64, 20.0_f64, 50.0_f64,
                    ]));
                    let v6: i32 = count(v5.clone());
                    let v7: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                        l0: MutCell::new(0_i32),
                    });
                    while Math::method5(v6, v7.clone()) {
                        let v9: i32 = v7.l0.get().clone();
                        let v11: f64 = Math::method20(v5[v9].clone());
                        let v12: f64 = Math::method2();
                        let v14: num_complex::Complex<f64> = num_complex::Complex::new(v11, v12);
                        let v25: Array<string> = Math::method6(new_array(&[
                            string("import mpmath"),
                            string("def fn(s, _):"),
                            string("    s = complex(*s)"),
                            string("    try:"),
                            string("        s = mpmath.zeta(s)"),
                            string("    except ValueError as e:"),
                            string("        if s.real == 1:"),
                            string("            s = complex(float(\'inf\'), 0)"),
                            string("    return (s.real, s.imag)"),
                        ]));
                        let v26: i32 = count(v25.clone());
                        let v28: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(string("")),
                        });
                        while Math::method7(v26, v28.clone()) {
                            let v30: i32 = v28.l0.get().clone();
                            let v34: string = append(
                                append(
                                    append(v28.l1.get().clone(), v25[v30].clone()),
                                    string("\n"),
                                ),
                                string(""),
                            );
                            let v35: i32 = v30 + 1_i32;
                            v28.l0.set(v35);
                            v28.l1.set(v34);
                            ()
                        }
                        {
                            let v36: string = v28.l1.get().clone();
                            let v37: num_complex::Complex<f64> = Math::method8(v14.clone());
                            let v39: f64 = v37.re;
                            let v40: num_complex::Complex<f64> = Math::method9(v14);
                            let v42: f64 = v40.im;
                            let v45: pyo3::Python = Math::method10(v3.clone());
                            let v46: string = Math::method11(v36);
                            let v48: &str = fable_library_rust::String_::LrcStr::as_str(&v46);
                            let v51: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                                Math::method12(pyo3::types::PyModule::from_code_bound(
                                    v45, v48, "", "",
                                ));
                            let v53: pyo3::Bound<pyo3::types::PyModule> = v51.unwrap();
                            let v54: string = Math::method13();
                            let v56: &str = fable_library_rust::String_::LrcStr::as_str(&v54);
                            let v57: pyo3::Bound<pyo3::types::PyModule> = Math::method14(v53);
                            let v60: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                                Math::method15(v57.getattr(v56));
                            let v62: pyo3::Bound<pyo3::PyAny> = v60.unwrap();
                            let v63: LrcPtr<(LrcPtr<(f64, f64)>, ())> = Math::method16(
                                (LrcPtr::new((LrcPtr::new((v39, v42)), ()))).0.clone(),
                                (),
                            );
                            let v64: pyo3::Bound<pyo3::PyAny> = Math::method17(v62);
                            let v67: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method15(
                                pyo3::prelude::PyAnyMethods::call(&v64, (*(*v63).0, ()), None),
                            );
                            let v70: pyo3::Bound<pyo3::PyAny> = Math::method18(v67.unwrap());
                            let v73: Result<(f64, f64), pyo3::PyErr> =
                                Math::method19(v70.extract());
                            let patternInput: (f64, f64) = v73.unwrap();
                            let v77: f64 = Math::method20(patternInput.0.clone());
                            let v78: f64 = Math::method21(patternInput.1.clone());
                            let v82: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                                Math::method22(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                                    num_complex::Complex::new(v77, v78),
                                ));
                            let v84: num_complex::Complex<f64> = v82.unwrap();
                            let v85: num_complex::Complex<f64> = Math::method8(v84.clone());
                            let v87: f64 = v85.re;
                            let v88: bool = v87 > 0.0_f64;
                            if (if v88 { true } else { Math::method23(v88) }) == false {
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
                                let v93: num_complex::Complex<f64> = Math::method9(v84);
                                let v95: f64 = v93.im;
                                let v96: bool = v95 == 0.0_f64;
                                if (if v96 { true } else { Math::method23(v96) }) == false {
                                    panic!(
                                        "{}",
                                        sprintf!(
                                            "__expect / actual: {:?} / expected: {:?}",
                                            v95,
                                            0.0_f64
                                        ),
                                    );
                                }
                                {
                                    let v101: i32 = v9 + 1_i32;
                                    v7.l0.set(v101);
                                    ()
                                }
                            }
                        }
                    }
                    {
                        let v103: Result<(), pyo3::PyErr> =
                            Math::method24(Ok::<(), pyo3::PyErr>(()));
                        v103
                    }
                }
            });
            {
                {
                    //;
                    {
                        let v108: Result<(), pyo3::PyErr> = Math::method25(__result);
                        v108.unwrap();
                        ()
                    }
                }
            }
        }
        pub fn method43() -> f64 {
            1.0_f64
        }
        pub fn method42() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                {
                    let v3: pyo3::Python = py;
                    let v4: f64 = Math::method43();
                    let v5: f64 = Math::method2();
                    let v7: num_complex::Complex<f64> = num_complex::Complex::new(v4, v5);
                    let v18: Array<string> = Math::method6(new_array(&[
                        string("import mpmath"),
                        string("def fn(s, _):"),
                        string("    s = complex(*s)"),
                        string("    try:"),
                        string("        s = mpmath.zeta(s)"),
                        string("    except ValueError as e:"),
                        string("        if s.real == 1:"),
                        string("            s = complex(float(\'inf\'), 0)"),
                        string("    return (s.real, s.imag)"),
                    ]));
                    let v19: i32 = count(v18.clone());
                    let v21: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                        l0: MutCell::new(0_i32),
                        l1: MutCell::new(string("")),
                    });
                    while Math::method7(v19, v21.clone()) {
                        let v23: i32 = v21.l0.get().clone();
                        let v27: string = append(
                            append(append(v21.l1.get().clone(), v18[v23].clone()), string("\n")),
                            string(""),
                        );
                        let v28: i32 = v23 + 1_i32;
                        v21.l0.set(v28);
                        v21.l1.set(v27);
                        ()
                    }
                    {
                        let v29: string = v21.l1.get().clone();
                        let v30: num_complex::Complex<f64> = Math::method8(v7.clone());
                        let v32: f64 = v30.re;
                        let v33: num_complex::Complex<f64> = Math::method9(v7);
                        let v35: f64 = v33.im;
                        let v38: pyo3::Python = Math::method10(v3);
                        let v39: string = Math::method11(v29);
                        let v41: &str = fable_library_rust::String_::LrcStr::as_str(&v39);
                        let v44: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                            Math::method12(pyo3::types::PyModule::from_code_bound(
                                v38, v41, "", "",
                            ));
                        let v46: pyo3::Bound<pyo3::types::PyModule> = v44.unwrap();
                        let v47: string = Math::method13();
                        let v49: &str = fable_library_rust::String_::LrcStr::as_str(&v47);
                        let v50: pyo3::Bound<pyo3::types::PyModule> = Math::method14(v46);
                        let v53: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                            Math::method15(v50.getattr(v49));
                        let v55: pyo3::Bound<pyo3::PyAny> = v53.unwrap();
                        let v56: LrcPtr<(LrcPtr<(f64, f64)>, ())> = Math::method16(
                            (LrcPtr::new((LrcPtr::new((v32, v35)), ()))).0.clone(),
                            (),
                        );
                        let v57: pyo3::Bound<pyo3::PyAny> = Math::method17(v55);
                        let v60: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method15(
                            pyo3::prelude::PyAnyMethods::call(&v57, (*(*v56).0, ()), None),
                        );
                        let v63: pyo3::Bound<pyo3::PyAny> = Math::method18(v60.unwrap());
                        let v66: Result<(f64, f64), pyo3::PyErr> = Math::method19(v63.extract());
                        let patternInput: (f64, f64) = v66.unwrap();
                        let v70: f64 = Math::method20(patternInput.0.clone());
                        let v71: f64 = Math::method21(patternInput.1.clone());
                        let v75: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                            Math::method22(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                                num_complex::Complex::new(v70, v71),
                            ));
                        let v77: num_complex::Complex<f64> = v75.unwrap();
                        let v78: num_complex::Complex<f64> = Math::method8(v77.clone());
                        let v80: f64 = v78.re;
                        let v81: bool = v80 == f64::INFINITY;
                        if (if v81 { true } else { Math::method23(v81) }) == false {
                            panic!(
                                "{}",
                                sprintf!(
                                    "__expect / actual: {:?} / expected: {:?}",
                                    v80,
                                    f64::INFINITY
                                ),
                            );
                        }
                        {
                            let v86: num_complex::Complex<f64> = Math::method9(v77);
                            let v88: f64 = v86.im;
                            let v89: bool = v88 == 0.0_f64;
                            if (if v89 { true } else { Math::method23(v89) }) == false {
                                panic!(
                                    "{}",
                                    sprintf!(
                                        "__expect / actual: {:?} / expected: {:?}",
                                        v88,
                                        0.0_f64
                                    ),
                                );
                            }
                            {
                                let v95: Result<(), pyo3::PyErr> =
                                    Math::method24(Ok::<(), pyo3::PyErr>(()));
                                v95
                            }
                        }
                    }
                }
            });
            {
                {
                    {
                        {
                            //;
                            {
                                let v100: Result<(), pyo3::PyErr> = Math::method25(__result);
                                v100.unwrap();
                                ()
                            }
                        }
                    }
                }
            }
        }
        pub fn method45() -> f64 {
            10.0_f64
        }
        pub fn method44() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                {
                    let v3: pyo3::Python = py;
                    let v4: f64 = Math::method1();
                    let v5: f64 = Math::method45();
                    let v7: num_complex::Complex<f64> = num_complex::Complex::new(v4, v5);
                    let v18: Array<string> = Math::method6(new_array(&[
                        string("import mpmath"),
                        string("def fn(s, _):"),
                        string("    s = complex(*s)"),
                        string("    try:"),
                        string("        s = mpmath.zeta(s)"),
                        string("    except ValueError as e:"),
                        string("        if s.real == 1:"),
                        string("            s = complex(float(\'inf\'), 0)"),
                        string("    return (s.real, s.imag)"),
                    ]));
                    let v19: i32 = count(v18.clone());
                    let v21: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                        l0: MutCell::new(0_i32),
                        l1: MutCell::new(string("")),
                    });
                    while Math::method7(v19, v21.clone()) {
                        let v23: i32 = v21.l0.get().clone();
                        let v27: string = append(
                            append(append(v21.l1.get().clone(), v18[v23].clone()), string("\n")),
                            string(""),
                        );
                        let v28: i32 = v23 + 1_i32;
                        v21.l0.set(v28);
                        v21.l1.set(v27);
                        ()
                    }
                    {
                        let v29: string = v21.l1.get().clone();
                        let v30: num_complex::Complex<f64> = Math::method8(v7.clone());
                        let v32: f64 = v30.re;
                        let v33: num_complex::Complex<f64> = Math::method9(v7.clone());
                        let v35: f64 = v33.im;
                        let v38: pyo3::Python = Math::method10(v3.clone());
                        let v39: string = Math::method11(v29);
                        let v41: &str = fable_library_rust::String_::LrcStr::as_str(&v39);
                        let v44: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                            Math::method12(pyo3::types::PyModule::from_code_bound(
                                v38, v41, "", "",
                            ));
                        let v46: pyo3::Bound<pyo3::types::PyModule> = v44.unwrap();
                        let v47: string = Math::method13();
                        let v49: &str = fable_library_rust::String_::LrcStr::as_str(&v47);
                        let v50: pyo3::Bound<pyo3::types::PyModule> = Math::method14(v46);
                        let v53: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                            Math::method15(v50.getattr(v49));
                        let v55: pyo3::Bound<pyo3::PyAny> = v53.unwrap();
                        let v56: LrcPtr<(LrcPtr<(f64, f64)>, ())> = Math::method16(
                            (LrcPtr::new((LrcPtr::new((v32, v35)), ()))).0.clone(),
                            (),
                        );
                        let v57: pyo3::Bound<pyo3::PyAny> = Math::method17(v55);
                        let v60: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method15(
                            pyo3::prelude::PyAnyMethods::call(&v57, (*(*v56).0, ()), None),
                        );
                        let v63: pyo3::Bound<pyo3::PyAny> = Math::method18(v60.unwrap());
                        let v66: Result<(f64, f64), pyo3::PyErr> = Math::method19(v63.extract());
                        let patternInput: (f64, f64) = v66.unwrap();
                        let v70: f64 = Math::method20(patternInput.0.clone());
                        let v71: f64 = Math::method21(patternInput.1.clone());
                        let v75: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                            Math::method22(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                                num_complex::Complex::new(v70, v71),
                            ));
                        let v77: num_complex::Complex<f64> = v75.unwrap();
                        let v78: num_complex::Complex<f64> = Math::method8(v7.clone());
                        let v80: f64 = v78.re;
                        let v81: num_complex::Complex<f64> = Math::method9(v7);
                        let v84: f64 = -v81.im;
                        let v85: f64 = Math::method20(v80);
                        let v86: f64 = Math::method21(v84);
                        let v88: num_complex::Complex<f64> = num_complex::Complex::new(v85, v86);
                        let v90: Array<string> = Math::method6(new_array(&[
                            string("import mpmath"),
                            string("def fn(s, _):"),
                            string("    s = complex(*s)"),
                            string("    try:"),
                            string("        s = mpmath.zeta(s)"),
                            string("    except ValueError as e:"),
                            string("        if s.real == 1:"),
                            string("            s = complex(float(\'inf\'), 0)"),
                            string("    return (s.real, s.imag)"),
                        ]));
                        let v91: i32 = count(v90.clone());
                        let v92: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(string("")),
                        });
                        while Math::method7(v91, v92.clone()) {
                            let v94: i32 = v92.l0.get().clone();
                            let v98: string = append(
                                append(
                                    append(v92.l1.get().clone(), v90[v94].clone()),
                                    string("\n"),
                                ),
                                string(""),
                            );
                            let v99: i32 = v94 + 1_i32;
                            v92.l0.set(v99);
                            v92.l1.set(v98);
                            ()
                        }
                        {
                            let v100: string = v92.l1.get().clone();
                            let v101: num_complex::Complex<f64> = Math::method8(v88.clone());
                            let v103: f64 = v101.re;
                            let v104: num_complex::Complex<f64> = Math::method9(v88);
                            let v106: f64 = v104.im;
                            let v109: pyo3::Python = Math::method10(v3);
                            let v110: string = Math::method11(v100);
                            let v112: &str = fable_library_rust::String_::LrcStr::as_str(&v110);
                            let v115: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                                Math::method12(pyo3::types::PyModule::from_code_bound(
                                    v109, v112, "", "",
                                ));
                            let v117: pyo3::Bound<pyo3::types::PyModule> = v115.unwrap();
                            let v118: string = Math::method13();
                            let v120: &str = fable_library_rust::String_::LrcStr::as_str(&v118);
                            let v121: pyo3::Bound<pyo3::types::PyModule> = Math::method14(v117);
                            let v124: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                                Math::method15(v121.getattr(v120));
                            let v126: pyo3::Bound<pyo3::PyAny> = v124.unwrap();
                            let v127: LrcPtr<(LrcPtr<(f64, f64)>, ())> = Math::method16(
                                (LrcPtr::new((LrcPtr::new((v103, v106)), ()))).0.clone(),
                                (),
                            );
                            let v128: pyo3::Bound<pyo3::PyAny> = Math::method17(v126);
                            let v131: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                                Math::method15(pyo3::prelude::PyAnyMethods::call(
                                    &v128,
                                    (*(*v127).0, ()),
                                    None,
                                ));
                            let v134: pyo3::Bound<pyo3::PyAny> = Math::method18(v131.unwrap());
                            let v137: Result<(f64, f64), pyo3::PyErr> =
                                Math::method19(v134.extract());
                            let patternInput_1: (f64, f64) = v137.unwrap();
                            let v141: f64 = Math::method20(patternInput_1.0.clone());
                            let v142: f64 = Math::method21(patternInput_1.1.clone());
                            let v146: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                                Math::method22(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                                    num_complex::Complex::new(v141, v142),
                                ));
                            let v148: num_complex::Complex<f64> = v146.unwrap();
                            let v150: num_complex::Complex<f64> = v148.conj();
                            let v151: num_complex::Complex<f64> = Math::method8(v77.clone());
                            let v153: f64 = v151.re;
                            let v154: num_complex::Complex<f64> = Math::method8(v150.clone());
                            let v156: f64 = v154.re;
                            let v157: bool = v153 == v156;
                            if (if v157 { true } else { Math::method23(v157) }) == false {
                                panic!(
                                    "{}",
                                    sprintf!(
                                        "__expect / actual: {:?} / expected: {:?}",
                                        v153,
                                        v156
                                    ),
                                );
                            }
                            {
                                let v162: num_complex::Complex<f64> = Math::method9(v77);
                                let v164: f64 = v162.im;
                                let v165: num_complex::Complex<f64> = Math::method9(v150);
                                let v167: f64 = v165.im;
                                let v168: bool = v164 == v167;
                                if (if v168 { true } else { Math::method23(v168) }) == false {
                                    panic!(
                                        "{}",
                                        sprintf!(
                                            "__expect / actual: {:?} / expected: {:?}",
                                            v164,
                                            v167
                                        ),
                                    );
                                }
                                {
                                    let v174: Result<(), pyo3::PyErr> =
                                        Math::method24(Ok::<(), pyo3::PyErr>(()));
                                    v174
                                }
                            }
                        }
                    }
                }
            });
            {
                {
                    {
                        {
                            {
                                //;
                                {
                                    let v179: Result<(), pyo3::PyErr> = Math::method25(__result);
                                    v179.unwrap();
                                    ()
                                }
                            }
                        }
                    }
                }
            }
        }
        pub fn method47() -> f64 {
            0.01_f64
        }
        pub fn method48() -> f64 {
            0.01_f64
        }
        pub fn method46() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                {
                    let v3: pyo3::Python = py;
                    let v4: f64 = Math::method47();
                    let v5: f64 = Math::method48();
                    let v7: num_complex::Complex<f64> = num_complex::Complex::new(v4, v5);
                    let v18: Array<string> = Math::method6(new_array(&[
                        string("import mpmath"),
                        string("def fn(s, _):"),
                        string("    s = complex(*s)"),
                        string("    try:"),
                        string("        s = mpmath.zeta(s)"),
                        string("    except ValueError as e:"),
                        string("        if s.real == 1:"),
                        string("            s = complex(float(\'inf\'), 0)"),
                        string("    return (s.real, s.imag)"),
                    ]));
                    let v19: i32 = count(v18.clone());
                    let v21: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                        l0: MutCell::new(0_i32),
                        l1: MutCell::new(string("")),
                    });
                    while Math::method7(v19, v21.clone()) {
                        let v23: i32 = v21.l0.get().clone();
                        let v27: string = append(
                            append(append(v21.l1.get().clone(), v18[v23].clone()), string("\n")),
                            string(""),
                        );
                        let v28: i32 = v23 + 1_i32;
                        v21.l0.set(v28);
                        v21.l1.set(v27);
                        ()
                    }
                    {
                        let v29: string = v21.l1.get().clone();
                        let v30: num_complex::Complex<f64> = Math::method8(v7.clone());
                        let v32: f64 = v30.re;
                        let v33: num_complex::Complex<f64> = Math::method9(v7);
                        let v35: f64 = v33.im;
                        let v38: pyo3::Python = Math::method10(v3);
                        let v39: string = Math::method11(v29);
                        let v41: &str = fable_library_rust::String_::LrcStr::as_str(&v39);
                        let v44: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                            Math::method12(pyo3::types::PyModule::from_code_bound(
                                v38, v41, "", "",
                            ));
                        let v46: pyo3::Bound<pyo3::types::PyModule> = v44.unwrap();
                        let v47: string = Math::method13();
                        let v49: &str = fable_library_rust::String_::LrcStr::as_str(&v47);
                        let v50: pyo3::Bound<pyo3::types::PyModule> = Math::method14(v46);
                        let v53: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                            Math::method15(v50.getattr(v49));
                        let v55: pyo3::Bound<pyo3::PyAny> = v53.unwrap();
                        let v56: LrcPtr<(LrcPtr<(f64, f64)>, ())> = Math::method16(
                            (LrcPtr::new((LrcPtr::new((v32, v35)), ()))).0.clone(),
                            (),
                        );
                        let v57: pyo3::Bound<pyo3::PyAny> = Math::method17(v55);
                        let v60: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method15(
                            pyo3::prelude::PyAnyMethods::call(&v57, (*(*v56).0, ()), None),
                        );
                        let v63: pyo3::Bound<pyo3::PyAny> = Math::method18(v60.unwrap());
                        let v66: Result<(f64, f64), pyo3::PyErr> = Math::method19(v63.extract());
                        let patternInput: (f64, f64) = v66.unwrap();
                        let v70: f64 = Math::method20(patternInput.0.clone());
                        let v71: f64 = Math::method21(patternInput.1.clone());
                        let v75: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                            Math::method22(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                                num_complex::Complex::new(v70, v71),
                            ));
                        let v77: num_complex::Complex<f64> = v75.unwrap();
                        let v78: num_complex::Complex<f64> = Math::method8(v77.clone());
                        let v80: f64 = v78.re;
                        let v81: bool = v80 < f64::INFINITY;
                        if (if v81 { true } else { Math::method23(v81) }) == false {
                            panic!(
                                "{}",
                                sprintf!(
                                    "__expect / actual: {:?} / expected: {:?}",
                                    v80,
                                    f64::INFINITY
                                ),
                            );
                        }
                        {
                            let v86: num_complex::Complex<f64> = Math::method9(v77);
                            let v88: f64 = v86.im;
                            let v89: bool = v88 < f64::INFINITY;
                            if (if v89 { true } else { Math::method23(v89) }) == false {
                                panic!(
                                    "{}",
                                    sprintf!(
                                        "__expect / actual: {:?} / expected: {:?}",
                                        v88,
                                        f64::INFINITY
                                    ),
                                );
                            }
                            {
                                let v95: Result<(), pyo3::PyErr> =
                                    Math::method24(Ok::<(), pyo3::PyErr>(()));
                                v95
                            }
                        }
                    }
                }
            });
            {
                {
                    {
                        {
                            //;
                            {
                                let v100: Result<(), pyo3::PyErr> = Math::method25(__result);
                                v100.unwrap();
                                ()
                            }
                        }
                    }
                }
            }
        }
        pub fn method49() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                {
                    let v3: pyo3::Python = py;
                    let v4: f64 = Math::method3();
                    let v5: f64 = Math::method2();
                    let v7: num_complex::Complex<f64> = num_complex::Complex::new(v4, v5);
                    let v18: Array<string> = Math::method6(new_array(&[
                        string("import mpmath"),
                        string("def fn(s, _):"),
                        string("    s = complex(*s)"),
                        string("    try:"),
                        string("        s = mpmath.zeta(s)"),
                        string("    except ValueError as e:"),
                        string("        if s.real == 1:"),
                        string("            s = complex(float(\'inf\'), 0)"),
                        string("    return (s.real, s.imag)"),
                    ]));
                    let v19: i32 = count(v18.clone());
                    let v21: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                        l0: MutCell::new(0_i32),
                        l1: MutCell::new(string("")),
                    });
                    while Math::method7(v19, v21.clone()) {
                        let v23: i32 = v21.l0.get().clone();
                        let v27: string = append(
                            append(append(v21.l1.get().clone(), v18[v23].clone()), string("\n")),
                            string(""),
                        );
                        let v28: i32 = v23 + 1_i32;
                        v21.l0.set(v28);
                        v21.l1.set(v27);
                        ()
                    }
                    {
                        let v29: string = v21.l1.get().clone();
                        let v30: num_complex::Complex<f64> = Math::method8(v7.clone());
                        let v32: f64 = v30.re;
                        let v33: num_complex::Complex<f64> = Math::method9(v7);
                        let v35: f64 = v33.im;
                        let v38: pyo3::Python = Math::method10(v3);
                        let v39: string = Math::method11(v29);
                        let v41: &str = fable_library_rust::String_::LrcStr::as_str(&v39);
                        let v44: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                            Math::method12(pyo3::types::PyModule::from_code_bound(
                                v38, v41, "", "",
                            ));
                        let v46: pyo3::Bound<pyo3::types::PyModule> = v44.unwrap();
                        let v47: string = Math::method13();
                        let v49: &str = fable_library_rust::String_::LrcStr::as_str(&v47);
                        let v50: pyo3::Bound<pyo3::types::PyModule> = Math::method14(v46);
                        let v53: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                            Math::method15(v50.getattr(v49));
                        let v55: pyo3::Bound<pyo3::PyAny> = v53.unwrap();
                        let v56: LrcPtr<(LrcPtr<(f64, f64)>, ())> = Math::method16(
                            (LrcPtr::new((LrcPtr::new((v32, v35)), ()))).0.clone(),
                            (),
                        );
                        let v57: pyo3::Bound<pyo3::PyAny> = Math::method17(v55);
                        let v60: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method15(
                            pyo3::prelude::PyAnyMethods::call(&v57, (*(*v56).0, ()), None),
                        );
                        let v63: pyo3::Bound<pyo3::PyAny> = Math::method18(v60.unwrap());
                        let v66: Result<(f64, f64), pyo3::PyErr> = Math::method19(v63.extract());
                        let patternInput: (f64, f64) = v66.unwrap();
                        let v70: f64 = Math::method20(patternInput.0.clone());
                        let v71: f64 = Math::method21(patternInput.1.clone());
                        let v75: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                            Math::method22(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                                num_complex::Complex::new(v70, v71),
                            ));
                        let v77: num_complex::Complex<f64> = v75.unwrap();
                        let v78: num_complex::Complex<f64> = Math::method8(v77.clone());
                        let v81: f64 = v78.re + 0.08333333333333333_f64;
                        let v82: f64 = -v81;
                        let v84: f64 = if v81 >= v82 { v81 } else { v82 };
                        let v85: bool = v84 < 0.0001_f64;
                        if (if v85 { true } else { Math::method23(v85) }) == false {
                            panic!(
                                "{}",
                                sprintf!(
                                    "__expect / actual: {:?} / expected: {:?}",
                                    v84,
                                    0.0001_f64
                                ),
                            );
                        }
                        {
                            let v90: num_complex::Complex<f64> = Math::method9(v77);
                            let v92: f64 = v90.im;
                            let v93: bool = v92 == 0.0_f64;
                            if (if v93 { true } else { Math::method23(v93) }) == false {
                                panic!(
                                    "{}",
                                    sprintf!(
                                        "__expect / actual: {:?} / expected: {:?}",
                                        v92,
                                        0.0_f64
                                    ),
                                );
                            }
                            {
                                let v99: Result<(), pyo3::PyErr> =
                                    Math::method24(Ok::<(), pyo3::PyErr>(()));
                                v99
                            }
                        }
                    }
                }
            });
            {
                {
                    {
                        {
                            //;
                            {
                                let v104: Result<(), pyo3::PyErr> = Math::method25(__result);
                                v104.unwrap();
                                ()
                            }
                        }
                    }
                }
            }
        }
        pub fn method51() -> Array<f64> {
            Math::method41(new_array(&[
                10.0_f64, 20.0_f64, 30.0_f64, 40.0_f64, 50.0_f64, 60.0_f64, 70.0_f64, 80.0_f64,
                90.0_f64, 100.0_f64,
            ]))
        }
        pub fn method52() -> f64 {
            0.0_f64
        }
        pub fn method53(v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn method50() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                {
                    let v3: pyo3::Python = py;
                    let v4: Array<f64> = Math::method51();
                    let v5: i32 = count(v4.clone());
                    let v6: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                        l0: MutCell::new(0_i32),
                    });
                    while Math::method5(v5, v6.clone()) {
                        let v8: i32 = v6.l0.get().clone();
                        let v9: f64 = v4[v8].clone();
                        let v10: f64 = Math::method52();
                        let v11: f64 = Math::method21(v9);
                        let v13: num_complex::Complex<f64> = num_complex::Complex::new(v10, v11);
                        let v24: Array<string> = Math::method6(new_array(&[
                            string("import mpmath"),
                            string("def fn(s, _):"),
                            string("    s = complex(*s)"),
                            string("    try:"),
                            string("        s = mpmath.zeta(s)"),
                            string("    except ValueError as e:"),
                            string("        if s.real == 1:"),
                            string("            s = complex(float(\'inf\'), 0)"),
                            string("    return (s.real, s.imag)"),
                        ]));
                        let v25: i32 = count(v24.clone());
                        let v27: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(string("")),
                        });
                        while Math::method7(v25, v27.clone()) {
                            let v29: i32 = v27.l0.get().clone();
                            let v33: string = append(
                                append(
                                    append(v27.l1.get().clone(), v24[v29].clone()),
                                    string("\n"),
                                ),
                                string(""),
                            );
                            let v34: i32 = v29 + 1_i32;
                            v27.l0.set(v34);
                            v27.l1.set(v33);
                            ()
                        }
                        {
                            let v35: string = v27.l1.get().clone();
                            let v36: num_complex::Complex<f64> = Math::method8(v13.clone());
                            let v38: f64 = v36.re;
                            let v39: num_complex::Complex<f64> = Math::method9(v13);
                            let v41: f64 = v39.im;
                            let v44: pyo3::Python = Math::method10(v3.clone());
                            let v45: string = Math::method11(v35);
                            let v47: &str = fable_library_rust::String_::LrcStr::as_str(&v45);
                            let v50: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                                Math::method12(pyo3::types::PyModule::from_code_bound(
                                    v44, v47, "", "",
                                ));
                            let v52: pyo3::Bound<pyo3::types::PyModule> = v50.unwrap();
                            let v53: string = Math::method13();
                            let v55: &str = fable_library_rust::String_::LrcStr::as_str(&v53);
                            let v56: pyo3::Bound<pyo3::types::PyModule> = Math::method14(v52);
                            let v59: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                                Math::method15(v56.getattr(v55));
                            let v61: pyo3::Bound<pyo3::PyAny> = v59.unwrap();
                            let v62: LrcPtr<(LrcPtr<(f64, f64)>, ())> = Math::method16(
                                (LrcPtr::new((LrcPtr::new((v38, v41)), ()))).0.clone(),
                                (),
                            );
                            let v63: pyo3::Bound<pyo3::PyAny> = Math::method17(v61);
                            let v66: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method15(
                                pyo3::prelude::PyAnyMethods::call(&v63, (*(*v62).0, ()), None),
                            );
                            let v69: pyo3::Bound<pyo3::PyAny> = Math::method18(v66.unwrap());
                            let v72: Result<(f64, f64), pyo3::PyErr> =
                                Math::method19(v69.extract());
                            let patternInput: (f64, f64) = v72.unwrap();
                            let v76: f64 = Math::method20(patternInput.0.clone());
                            let v77: f64 = Math::method21(patternInput.1.clone());
                            let v81: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                                Math::method22(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                                    num_complex::Complex::new(v76, v77),
                                ));
                            let v83: num_complex::Complex<f64> = v81.unwrap();
                            let v84: num_complex::Complex<f64> = Math::method8(v83.clone());
                            let v86: f64 = v84.re;
                            let v88: bool = Math::method53(v86 == 0.0_f64);
                            if (if v88 { true } else { Math::method23(v88) }) == false {
                                panic!(
                                    "{}",
                                    sprintf!(
                                        "__expect / actual: {:?} / expected: {:?}",
                                        v86,
                                        0.0_f64
                                    ),
                                );
                            }
                            {
                                let v93: num_complex::Complex<f64> = Math::method9(v83);
                                let v95: f64 = v93.im;
                                let v97: bool = Math::method53(v95 == 0.0_f64);
                                if (if v97 { true } else { Math::method23(v97) }) == false {
                                    panic!(
                                        "{}",
                                        sprintf!(
                                            "__expect / actual: {:?} / expected: {:?}",
                                            v95,
                                            0.0_f64
                                        ),
                                    );
                                }
                                {
                                    let v102: i32 = v8 + 1_i32;
                                    v6.l0.set(v102);
                                    ()
                                }
                            }
                        }
                    }
                    {
                        let v104: Result<(), pyo3::PyErr> =
                            Math::method24(Ok::<(), pyo3::PyErr>(()));
                        v104
                    }
                }
            });
            {
                {
                    //;
                    {
                        let v109: Result<(), pyo3::PyErr> = Math::method25(__result);
                        v109.unwrap();
                        ()
                    }
                }
            }
        }
        pub fn method55() -> f64 {
            0.75_f64
        }
        pub fn method56() -> f64 {
            20.5_f64
        }
        pub fn method57() -> f64 {
            1.25_f64
        }
        pub fn method58() -> f64 {
            30.1_f64
        }
        pub fn method59() -> f64 {
            0.25_f64
        }
        pub fn method60() -> f64 {
            40.0_f64
        }
        pub fn method61() -> f64 {
            50.0_f64
        }
        pub fn method54() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                {
                    let v3: pyo3::Python = py;
                    let v4: f64 = Math::method32();
                    let v5: f64 = Math::method33();
                    let v7: num_complex::Complex<f64> = num_complex::Complex::new(v4, v5);
                    let v8: f64 = Math::method55();
                    let v9: f64 = Math::method56();
                    let v11: num_complex::Complex<f64> = num_complex::Complex::new(v8, v9);
                    let v12: f64 = Math::method57();
                    let v13: f64 = Math::method58();
                    let v15: num_complex::Complex<f64> = num_complex::Complex::new(v12, v13);
                    let v16: f64 = Math::method59();
                    let v17: f64 = Math::method60();
                    let v19: num_complex::Complex<f64> = num_complex::Complex::new(v16, v17);
                    let v20: f64 = Math::method43();
                    let v21: f64 = Math::method61();
                    let v25: Array<num_complex::Complex<f64>> = Math::method39(new_array(&[
                        v7,
                        v11,
                        v15,
                        v19,
                        num_complex::Complex::new(v20, v21),
                    ]));
                    let v26: i32 = count(v25.clone());
                    let v27: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                        l0: MutCell::new(0_i32),
                    });
                    while Math::method5(v26, v27.clone()) {
                        let v29: i32 = v27.l0.get().clone();
                        let v30: num_complex::Complex<f64> = v25[v29].clone();
                        let v41: Array<string> = Math::method6(new_array(&[
                            string("import mpmath"),
                            string("def fn(s, _):"),
                            string("    s = complex(*s)"),
                            string("    try:"),
                            string("        s = mpmath.zeta(s)"),
                            string("    except ValueError as e:"),
                            string("        if s.real == 1:"),
                            string("            s = complex(float(\'inf\'), 0)"),
                            string("    return (s.real, s.imag)"),
                        ]));
                        let v42: i32 = count(v41.clone());
                        let v44: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(string("")),
                        });
                        while Math::method7(v42, v44.clone()) {
                            let v46: i32 = v44.l0.get().clone();
                            let v50: string = append(
                                append(
                                    append(v44.l1.get().clone(), v41[v46].clone()),
                                    string("\n"),
                                ),
                                string(""),
                            );
                            let v51: i32 = v46 + 1_i32;
                            v44.l0.set(v51);
                            v44.l1.set(v50);
                            ()
                        }
                        {
                            let v52: string = v44.l1.get().clone();
                            let v53: num_complex::Complex<f64> = Math::method8(v30.clone());
                            let v55: f64 = v53.re;
                            let v56: num_complex::Complex<f64> = Math::method9(v30);
                            let v58: f64 = v56.im;
                            let v61: pyo3::Python = Math::method10(v3.clone());
                            let v62: string = Math::method11(v52);
                            let v64: &str = fable_library_rust::String_::LrcStr::as_str(&v62);
                            let v67: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                                Math::method12(pyo3::types::PyModule::from_code_bound(
                                    v61, v64, "", "",
                                ));
                            let v69: pyo3::Bound<pyo3::types::PyModule> = v67.unwrap();
                            let v70: string = Math::method13();
                            let v72: &str = fable_library_rust::String_::LrcStr::as_str(&v70);
                            let v73: pyo3::Bound<pyo3::types::PyModule> = Math::method14(v69);
                            let v76: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                                Math::method15(v73.getattr(v72));
                            let v78: pyo3::Bound<pyo3::PyAny> = v76.unwrap();
                            let v79: LrcPtr<(LrcPtr<(f64, f64)>, ())> = Math::method16(
                                (LrcPtr::new((LrcPtr::new((v55, v58)), ()))).0.clone(),
                                (),
                            );
                            let v80: pyo3::Bound<pyo3::PyAny> = Math::method17(v78);
                            let v83: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method15(
                                pyo3::prelude::PyAnyMethods::call(&v80, (*(*v79).0, ()), None),
                            );
                            let v86: pyo3::Bound<pyo3::PyAny> = Math::method18(v83.unwrap());
                            let v89: Result<(f64, f64), pyo3::PyErr> =
                                Math::method19(v86.extract());
                            let patternInput: (f64, f64) = v89.unwrap();
                            let v93: f64 = Math::method20(patternInput.0.clone());
                            let v94: f64 = Math::method21(patternInput.1.clone());
                            let v98: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                                Math::method22(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                                    num_complex::Complex::new(v93, v94),
                                ));
                            let v100: num_complex::Complex<f64> = v98.unwrap();
                            let v101: num_complex::Complex<f64> = Math::method8(v100.clone());
                            let v103: f64 = v101.re;
                            let v105: bool = Math::method53(v103 == 0.0_f64);
                            if (if v105 { true } else { Math::method23(v105) }) == false {
                                panic!(
                                    "{}",
                                    sprintf!(
                                        "__expect / actual: {:?} / expected: {:?}",
                                        v103,
                                        0.0_f64
                                    ),
                                );
                            }
                            {
                                let v110: num_complex::Complex<f64> = Math::method9(v100);
                                let v112: f64 = v110.im;
                                let v114: bool = Math::method53(v112 == 0.0_f64);
                                if (if v114 { true } else { Math::method23(v114) }) == false {
                                    panic!(
                                        "{}",
                                        sprintf!(
                                            "__expect / actual: {:?} / expected: {:?}",
                                            v112,
                                            0.0_f64
                                        ),
                                    );
                                }
                                {
                                    let v119: i32 = v29 + 1_i32;
                                    v27.l0.set(v119);
                                    ()
                                }
                            }
                        }
                    }
                    {
                        let v121: Result<(), pyo3::PyErr> =
                            Math::method24(Ok::<(), pyo3::PyErr>(()));
                        v121
                    }
                }
            });
            {
                {
                    //;
                    {
                        let v126: Result<(), pyo3::PyErr> = Math::method25(__result);
                        v126.unwrap();
                        ()
                    }
                }
            }
        }
        pub fn method63() -> f64 {
            3.0_f64
        }
        pub fn method64() -> f64 {
            4.0_f64
        }
        pub fn method65() -> f64 {
            2.5_f64
        }
        pub fn method66() -> f64 {
            -3.5_f64
        }
        pub fn method67() -> f64 {
            1.5_f64
        }
        pub fn method68() -> f64 {
            2.5_f64
        }
        pub fn method69() -> f64 {
            3.141592653589793_f64
        }
        pub fn method62() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                {
                    let v3: pyo3::Python = py;
                    let v4: f64 = Math::method63();
                    let v5: f64 = Math::method64();
                    let v7: num_complex::Complex<f64> = num_complex::Complex::new(v4, v5);
                    let v8: f64 = Math::method65();
                    let v9: f64 = Math::method66();
                    let v11: num_complex::Complex<f64> = num_complex::Complex::new(v8, v9);
                    let v12: f64 = Math::method67();
                    let v13: f64 = Math::method68();
                    let v15: num_complex::Complex<f64> = num_complex::Complex::new(v12, v13);
                    let v16: f64 = Math::method32();
                    let v17: f64 = Math::method33();
                    let v21: Array<num_complex::Complex<f64>> = Math::method39(new_array(&[
                        v7,
                        v11,
                        v15,
                        num_complex::Complex::new(v16, v17),
                    ]));
                    let v22: i32 = count(v21.clone());
                    let v23: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                        l0: MutCell::new(0_i32),
                    });
                    while Math::method5(v22, v23.clone()) {
                        let v25: i32 = v23.l0.get().clone();
                        let v26: num_complex::Complex<f64> = v21[v25].clone();
                        let v37: Array<string> = Math::method6(new_array(&[
                            string("import mpmath"),
                            string("def fn(s, _):"),
                            string("    s = complex(*s)"),
                            string("    try:"),
                            string("        s = mpmath.zeta(s)"),
                            string("    except ValueError as e:"),
                            string("        if s.real == 1:"),
                            string("            s = complex(float(\'inf\'), 0)"),
                            string("    return (s.real, s.imag)"),
                        ]));
                        let v38: i32 = count(v37.clone());
                        let v40: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(string("")),
                        });
                        while Math::method7(v38, v40.clone()) {
                            let v42: i32 = v40.l0.get().clone();
                            let v46: string = append(
                                append(
                                    append(v40.l1.get().clone(), v37[v42].clone()),
                                    string("\n"),
                                ),
                                string(""),
                            );
                            let v47: i32 = v42 + 1_i32;
                            v40.l0.set(v47);
                            v40.l1.set(v46);
                            ()
                        }
                        {
                            let v48: string = v40.l1.get().clone();
                            let v49: num_complex::Complex<f64> = Math::method8(v26.clone());
                            let v51: f64 = v49.re;
                            let v52: num_complex::Complex<f64> = Math::method9(v26.clone());
                            let v54: f64 = v52.im;
                            let v57: pyo3::Python = Math::method10(v3.clone());
                            let v58: string = Math::method11(v48);
                            let v60: &str = fable_library_rust::String_::LrcStr::as_str(&v58);
                            let v63: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                                Math::method12(pyo3::types::PyModule::from_code_bound(
                                    v57, v60, "", "",
                                ));
                            let v65: pyo3::Bound<pyo3::types::PyModule> = v63.unwrap();
                            let v66: string = Math::method13();
                            let v68: &str = fable_library_rust::String_::LrcStr::as_str(&v66);
                            let v69: pyo3::Bound<pyo3::types::PyModule> = Math::method14(v65);
                            let v72: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                                Math::method15(v69.getattr(v68));
                            let v74: pyo3::Bound<pyo3::PyAny> = v72.unwrap();
                            let v75: LrcPtr<(LrcPtr<(f64, f64)>, ())> = Math::method16(
                                (LrcPtr::new((LrcPtr::new((v51, v54)), ()))).0.clone(),
                                (),
                            );
                            let v76: pyo3::Bound<pyo3::PyAny> = Math::method17(v74);
                            let v79: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method15(
                                pyo3::prelude::PyAnyMethods::call(&v76, (*(*v75).0, ()), None),
                            );
                            let v82: pyo3::Bound<pyo3::PyAny> = Math::method18(v79.unwrap());
                            let v85: Result<(f64, f64), pyo3::PyErr> =
                                Math::method19(v82.extract());
                            let patternInput: (f64, f64) = v85.unwrap();
                            let v89: f64 = Math::method20(patternInput.0.clone());
                            let v90: f64 = Math::method21(patternInput.1.clone());
                            let v94: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                                Math::method22(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                                    num_complex::Complex::new(v89, v90),
                                ));
                            let v96: num_complex::Complex<f64> = v94.unwrap();
                            let v97: f64 = Math::method1();
                            let v98: f64 = Math::method2();
                            let v100: num_complex::Complex<f64> =
                                num_complex::Complex::new(v97, v98);
                            let v102: num_complex::Complex<f64> =
                                num_complex::Complex::powc(v100, v26);
                            let v103: f64 = Math::method69();
                            let v104: f64 = Math::method2();
                            let v106: num_complex::Complex<f64> =
                                num_complex::Complex::new(v103, v104);
                            let v107: f64 = Math::method43();
                            let v108: f64 = Math::method2();
                            let v110: num_complex::Complex<f64> =
                                num_complex::Complex::new(v107, v108);
                            let v112: num_complex::Complex<f64> = v26 - v110;
                            let v114: num_complex::Complex<f64> =
                                num_complex::Complex::powc(v106, v112);
                            let v116: num_complex::Complex<f64> = v102 * v114;
                            let v117: f64 = Math::method69();
                            let v118: f64 = Math::method2();
                            let v120: num_complex::Complex<f64> =
                                num_complex::Complex::new(v117, v118);
                            let v122: num_complex::Complex<f64> = v120 * v26;
                            let v123: f64 = Math::method1();
                            let v124: f64 = Math::method2();
                            let v126: num_complex::Complex<f64> =
                                num_complex::Complex::new(v123, v124);
                            let v128: num_complex::Complex<f64> = v122 / v126;
                            let v130: num_complex::Complex<f64> = v128.sin();
                            let v132: num_complex::Complex<f64> = v116 * v130;
                            let v133: f64 = Math::method43();
                            let v134: f64 = Math::method2();
                            let v136: num_complex::Complex<f64> =
                                num_complex::Complex::new(v133, v134);
                            let v138: num_complex::Complex<f64> = v136 - v26;
                            let v141: Array<string> = Math::method6(new_array(&[
                                string("import mpmath"),
                                string("def fn(s, _):"),
                                string("    s = complex(*s)"),
                                string("    s = mpmath.gamma(s)"),
                                string("    return (s.real, s.imag)"),
                            ]));
                            let v142: i32 = count(v141.clone());
                            let v143: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                                l0: MutCell::new(0_i32),
                                l1: MutCell::new(string("")),
                            });
                            while Math::method7(v142, v143.clone()) {
                                let v145: i32 = v143.l0.get().clone();
                                let v149: string = append(
                                    append(
                                        append(v143.l1.get().clone(), v141[v145].clone()),
                                        string("\n"),
                                    ),
                                    string(""),
                                );
                                let v150: i32 = v145 + 1_i32;
                                v143.l0.set(v150);
                                v143.l1.set(v149);
                                ()
                            }
                            {
                                let v151: string = v143.l1.get().clone();
                                let v152: num_complex::Complex<f64> = Math::method8(v138.clone());
                                let v154: f64 = v152.re;
                                let v155: num_complex::Complex<f64> = Math::method9(v138);
                                let v157: f64 = v155.im;
                                let v160: pyo3::Python = Math::method10(v3.clone());
                                let v161: string = Math::method11(v151);
                                let v163: &str = fable_library_rust::String_::LrcStr::as_str(&v161);
                                let v166: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                                    Math::method12(pyo3::types::PyModule::from_code_bound(
                                        v160, v163, "", "",
                                    ));
                                let v168: pyo3::Bound<pyo3::types::PyModule> = v166.unwrap();
                                let v169: string = Math::method13();
                                let v171: &str = fable_library_rust::String_::LrcStr::as_str(&v169);
                                let v172: pyo3::Bound<pyo3::types::PyModule> = Math::method14(v168);
                                let v175: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                                    Math::method15(v172.getattr(v171));
                                let v177: pyo3::Bound<pyo3::PyAny> = v175.unwrap();
                                let v178: LrcPtr<(LrcPtr<(f64, f64)>, ())> = Math::method16(
                                    (LrcPtr::new((LrcPtr::new((v154, v157)), ()))).0.clone(),
                                    (),
                                );
                                let v179: pyo3::Bound<pyo3::PyAny> = Math::method17(v177);
                                let v182: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                                    Math::method15(pyo3::prelude::PyAnyMethods::call(
                                        &v179,
                                        (*(*v178).0, ()),
                                        None,
                                    ));
                                let v185: pyo3::Bound<pyo3::PyAny> = Math::method18(v182.unwrap());
                                let v188: Result<(f64, f64), pyo3::PyErr> =
                                    Math::method19(v185.extract());
                                let patternInput_1: (f64, f64) = v188.unwrap();
                                let v192: f64 = Math::method20(patternInput_1.0.clone());
                                let v193: f64 = Math::method21(patternInput_1.1.clone());
                                let v197: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                                    Math::method22(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                                        num_complex::Complex::new(v192, v193),
                                    ));
                                let v199: num_complex::Complex<f64> = v197.unwrap();
                                let v201: num_complex::Complex<f64> = v132 * v199;
                                let v202: num_complex::Complex<f64> = Math::method8(v26.clone());
                                let v205: f64 = 1.0_f64 - v202.re;
                                let v206: num_complex::Complex<f64> = Math::method9(v26);
                                let v209: f64 = -v206.im;
                                let v210: f64 = Math::method20(v205);
                                let v211: f64 = Math::method21(v209);
                                let v213: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v210, v211);
                                let v215: Array<string> = Math::method6(new_array(&[
                                    string("import mpmath"),
                                    string("def fn(s, _):"),
                                    string("    s = complex(*s)"),
                                    string("    try:"),
                                    string("        s = mpmath.zeta(s)"),
                                    string("    except ValueError as e:"),
                                    string("        if s.real == 1:"),
                                    string("            s = complex(float(\'inf\'), 0)"),
                                    string("    return (s.real, s.imag)"),
                                ]));
                                let v216: i32 = count(v215.clone());
                                let v217: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                                    l0: MutCell::new(0_i32),
                                    l1: MutCell::new(string("")),
                                });
                                while Math::method7(v216, v217.clone()) {
                                    let v219: i32 = v217.l0.get().clone();
                                    let v223: string = append(
                                        append(
                                            append(v217.l1.get().clone(), v215[v219].clone()),
                                            string("\n"),
                                        ),
                                        string(""),
                                    );
                                    let v224: i32 = v219 + 1_i32;
                                    v217.l0.set(v224);
                                    v217.l1.set(v223);
                                    ()
                                }
                                {
                                    let v225: string = v217.l1.get().clone();
                                    let v226: num_complex::Complex<f64> =
                                        Math::method8(v213.clone());
                                    let v228: f64 = v226.re;
                                    let v229: num_complex::Complex<f64> = Math::method9(v213);
                                    let v231: f64 = v229.im;
                                    let v234: pyo3::Python = Math::method10(v3.clone());
                                    let v235: string = Math::method11(v225);
                                    let v237: &str =
                                        fable_library_rust::String_::LrcStr::as_str(&v235);
                                    let v240: Result<
                                        pyo3::Bound<pyo3::types::PyModule>,
                                        pyo3::PyErr,
                                    > = Math::method12(pyo3::types::PyModule::from_code_bound(
                                        v234, v237, "", "",
                                    ));
                                    let v242: pyo3::Bound<pyo3::types::PyModule> = v240.unwrap();
                                    let v243: string = Math::method13();
                                    let v245: &str =
                                        fable_library_rust::String_::LrcStr::as_str(&v243);
                                    let v246: pyo3::Bound<pyo3::types::PyModule> =
                                        Math::method14(v242);
                                    let v249: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                                        Math::method15(v246.getattr(v245));
                                    let v251: pyo3::Bound<pyo3::PyAny> = v249.unwrap();
                                    let v252: LrcPtr<(LrcPtr<(f64, f64)>, ())> = Math::method16(
                                        (LrcPtr::new((LrcPtr::new((v228, v231)), ()))).0.clone(),
                                        (),
                                    );
                                    let v253: pyo3::Bound<pyo3::PyAny> = Math::method17(v251);
                                    let v256: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                                        Math::method15(pyo3::prelude::PyAnyMethods::call(
                                            &v253,
                                            (*(*v252).0, ()),
                                            None,
                                        ));
                                    let v259: pyo3::Bound<pyo3::PyAny> =
                                        Math::method18(v256.unwrap());
                                    let v262: Result<(f64, f64), pyo3::PyErr> =
                                        Math::method19(v259.extract());
                                    let patternInput_2: (f64, f64) = v262.unwrap();
                                    let v266: f64 = Math::method20(patternInput_2.0.clone());
                                    let v267: f64 = Math::method21(patternInput_2.1.clone());
                                    let v271: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                                        Math::method22(
                                            Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                                                num_complex::Complex::new(v266, v267),
                                            ),
                                        );
                                    let v273: num_complex::Complex<f64> = v271.unwrap();
                                    let v275: num_complex::Complex<f64> = v201 * v273;
                                    let v276: num_complex::Complex<f64> =
                                        Math::method8(v96.clone());
                                    let v278: f64 = v276.re;
                                    let v279: num_complex::Complex<f64> =
                                        Math::method8(v275.clone());
                                    let v282: f64 = v278 - v279.re;
                                    let v283: f64 = -v282;
                                    let v285: f64 = if v282 >= v283 { v282 } else { v283 };
                                    let v286: bool = v285 < 0.0001_f64;
                                    if (if v286 { true } else { Math::method23(v286) }) == false {
                                        panic!(
                                            "{}",
                                            sprintf!(
                                                "__expect / actual: {:?} / expected: {:?}",
                                                v285,
                                                0.0001_f64
                                            ),
                                        );
                                    }
                                    {
                                        let v291: num_complex::Complex<f64> = Math::method9(v96);
                                        let v293: f64 = v291.im;
                                        let v294: num_complex::Complex<f64> = Math::method9(v275);
                                        let v297: f64 = v293 - v294.im;
                                        let v298: f64 = -v297;
                                        let v300: f64 = if v297 >= v298 { v297 } else { v298 };
                                        let v301: bool = v300 < 0.0001_f64;
                                        if (if v301 { true } else { Math::method23(v301) }) == false
                                        {
                                            panic!(
                                                "{}",
                                                sprintf!(
                                                    "__expect / actual: {:?} / expected: {:?}",
                                                    v300,
                                                    0.0001_f64
                                                ),
                                            );
                                        }
                                        {
                                            let v306: i32 = v25 + 1_i32;
                                            v23.l0.set(v306);
                                            ()
                                        }
                                    }
                                }
                            }
                        }
                    }
                    {
                        let v308: Result<(), pyo3::PyErr> =
                            Math::method24(Ok::<(), pyo3::PyErr>(()));
                        v308
                    }
                }
            });
            {
                {
                    //;
                    {
                        let v313: Result<(), pyo3::PyErr> = Math::method25(__result);
                        v313.unwrap();
                        ()
                    }
                }
            }
        }
        pub fn method71(v0_1: i32, v1_1: LrcPtr<Math::Mut2>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method70() {
            pyo3::prepare_freethreaded_python();
            let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
                //;
                {
                    let v3: pyo3::Python = py;
                    let v5: Array<f64> = Math::method41(new_array(&[
                        2.0_f64, 2.5_f64, 3.0_f64, 3.5_f64, 4.0_f64, 4.5_f64, 5.0_f64,
                    ]));
                    let v7: Array<f64> = Math::method41(new_array(&[
                        2.0_f64, 3.0_f64, 5.0_f64, 7.0_f64, 11.0_f64, 13.0_f64, 17.0_f64, 19.0_f64,
                        23.0_f64, 29.0_f64, 31.0_f64, 37.0_f64, 41.0_f64, 43.0_f64, 47.0_f64,
                        53.0_f64, 59.0_f64, 61.0_f64, 67.0_f64, 71.0_f64,
                    ]));
                    let v8: i32 = count(v5.clone());
                    let v9: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                        l0: MutCell::new(0_i32),
                    });
                    while Math::method5(v8, v9.clone()) {
                        let v11: i32 = v9.l0.get().clone();
                        let v12: f64 = v5[v11].clone();
                        let v13: f64 = Math::method20(v12);
                        let v14: f64 = Math::method2();
                        let v16: num_complex::Complex<f64> = num_complex::Complex::new(v13, v14);
                        let v17: i32 = count(v7.clone());
                        let v18: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(1.0_f64),
                        });
                        while Math::method71(v17, v18.clone()) {
                            let v20: i32 = v18.l0.get().clone();
                            let v21: f64 = v18.l1.get().clone();
                            let v22: f64 = v7[v20].clone();
                            let v23: f64 = -v12;
                            let v26: f64 = v21 / (1.0_f64 - v22.powf(v23));
                            let v27: i32 = v20 + 1_i32;
                            v18.l0.set(v27);
                            v18.l1.set(v26);
                            ()
                        }
                        {
                            let v28: f64 = v18.l1.get().clone();
                            let v39: Array<string> = Math::method6(new_array(&[
                                string("import mpmath"),
                                string("def fn(s, _):"),
                                string("    s = complex(*s)"),
                                string("    try:"),
                                string("        s = mpmath.zeta(s)"),
                                string("    except ValueError as e:"),
                                string("        if s.real == 1:"),
                                string("            s = complex(float(\'inf\'), 0)"),
                                string("    return (s.real, s.imag)"),
                            ]));
                            let v40: i32 = count(v39.clone());
                            let v42: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                                l0: MutCell::new(0_i32),
                                l1: MutCell::new(string("")),
                            });
                            while Math::method7(v40, v42.clone()) {
                                let v44: i32 = v42.l0.get().clone();
                                let v48: string = append(
                                    append(
                                        append(v42.l1.get().clone(), v39[v44].clone()),
                                        string("\n"),
                                    ),
                                    string(""),
                                );
                                let v49: i32 = v44 + 1_i32;
                                v42.l0.set(v49);
                                v42.l1.set(v48);
                                ()
                            }
                            {
                                let v50: string = v42.l1.get().clone();
                                let v51: num_complex::Complex<f64> = Math::method8(v16.clone());
                                let v53: f64 = v51.re;
                                let v54: num_complex::Complex<f64> = Math::method9(v16);
                                let v56: f64 = v54.im;
                                let v59: pyo3::Python = Math::method10(v3.clone());
                                let v60: string = Math::method11(v50);
                                let v62: &str = fable_library_rust::String_::LrcStr::as_str(&v60);
                                let v65: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                                    Math::method12(pyo3::types::PyModule::from_code_bound(
                                        v59, v62, "", "",
                                    ));
                                let v67: pyo3::Bound<pyo3::types::PyModule> = v65.unwrap();
                                let v68: string = Math::method13();
                                let v70: &str = fable_library_rust::String_::LrcStr::as_str(&v68);
                                let v71: pyo3::Bound<pyo3::types::PyModule> = Math::method14(v67);
                                let v74: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                                    Math::method15(v71.getattr(v70));
                                let v76: pyo3::Bound<pyo3::PyAny> = v74.unwrap();
                                let v77: LrcPtr<(LrcPtr<(f64, f64)>, ())> = Math::method16(
                                    (LrcPtr::new((LrcPtr::new((v53, v56)), ()))).0.clone(),
                                    (),
                                );
                                let v78: pyo3::Bound<pyo3::PyAny> = Math::method17(v76);
                                let v81: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                                    Math::method15(pyo3::prelude::PyAnyMethods::call(
                                        &v78,
                                        (*(*v77).0, ()),
                                        None,
                                    ));
                                let v84: pyo3::Bound<pyo3::PyAny> = Math::method18(v81.unwrap());
                                let v87: Result<(f64, f64), pyo3::PyErr> =
                                    Math::method19(v84.extract());
                                let patternInput: (f64, f64) = v87.unwrap();
                                let v91: f64 = Math::method20(patternInput.0.clone());
                                let v92: f64 = Math::method21(patternInput.1.clone());
                                let v96: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                                    Math::method22(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                                        num_complex::Complex::new(v91, v92),
                                    ));
                                let v98: num_complex::Complex<f64> = v96.unwrap();
                                let v99: num_complex::Complex<f64> = Math::method8(v98.clone());
                                let v102: f64 = v99.re - v28;
                                let v103: f64 = -v102;
                                let v105: f64 = if v102 >= v103 { v102 } else { v103 };
                                let v106: bool = v105 < 0.01_f64;
                                if (if v106 { true } else { Math::method23(v106) }) == false {
                                    panic!(
                                        "{}",
                                        sprintf!(
                                            "__expect / actual: {:?} / expected: {:?}",
                                            v105,
                                            0.01_f64
                                        ),
                                    );
                                }
                                {
                                    let v111: num_complex::Complex<f64> = Math::method9(v98);
                                    let v113: f64 = v111.im;
                                    let v114: bool = v113 < 0.01_f64;
                                    if (if v114 { true } else { Math::method23(v114) }) == false {
                                        panic!(
                                            "{}",
                                            sprintf!(
                                                "__expect / actual: {:?} / expected: {:?}",
                                                v113,
                                                0.01_f64
                                            ),
                                        );
                                    }
                                    {
                                        let v119: i32 = v11 + 1_i32;
                                        v9.l0.set(v119);
                                        ()
                                    }
                                }
                            }
                        }
                    }
                    {
                        let v121: Result<(), pyo3::PyErr> =
                            Math::method24(Ok::<(), pyo3::PyErr>(()));
                        v121
                    }
                }
            });
            {
                {
                    //;
                    {
                        let v126: Result<(), pyo3::PyErr> = Math::method25(__result);
                        v126.unwrap();
                        ()
                    }
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
            Math::method26();
        }
        #[test]
        fn test_trivial_zero_at_negative_even___() {
            //;
            Math::method28();
        }
        #[test]
        fn test_non_trivial_zero___() {
            //;
            Math::method31();
        }
        #[test]
        fn test_real_part_greater_than_one___() {
            //;
            Math::method40();
        }
        #[test]
        fn test_zeta_at_1___() {
            //;
            Math::method42();
        }
        #[test]
        fn test_symmetry_across_real_axis___() {
            //;
            Math::method44();
        }
        #[test]
        fn test_behavior_near_origin___() {
            //;
            Math::method46();
        }
        #[test]
        fn test_zeta_at_minus_1() {
            //;
            Math::method49();
        }
        #[test]
        fn test_imaginary_axis() {
            //;
            Math::method50();
        }
        #[test]
        fn test_critical_strip() {
            //;
            Math::method54();
        }
        #[test]
        fn test_reflection_formula_for_specific_value() {
            //;
            Math::method62();
        }
        #[test]
        fn test_euler_product_formula() {
            //;
            Math::method70()
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
