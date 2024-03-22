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
        pub fn method8() -> Array<string> {
            Math::method9(new_array(&[string("import sys"),
                                      string("import traceback"),
                                      string("def trace_calls(frame, event, arg):"),
                                      string("    if event != \'call\':"),
                                      string("        return"),
                                      string("    co = frame.f_code"),
                                      string("    func_name = co.co_name"),
                                      string("    func_line_no = frame.f_lineno"),
                                      string("    func_filename = co.co_filename"),
                                      string("    caller = frame.f_back"),
                                      string("    caller_line_no = caller.f_lineno"),
                                      string("    caller_filename = caller.f_code.co_filename"),
                                      string("    args = frame.f_locals"),
                                      string("    args_str = \', \'.join([f\"{k}={v}\" for k, v in args.items() if k != \'ctx\'])"),
                                      sprintf!("    print(f\'{} / Call to {{func_name}}({{args_str}}) on line {{func_line_no}} of {{func_filename}} from line {{caller_line_no}} of {{caller_filename}}\', flush=True)",
                                               string("zeta_")),
                                      string("def start_trace():"),
                                      string("    sys.settrace(trace_calls)"),
                                      string("def stop_trace():"),
                                      string("    sys.settrace(None)"),
                                      string("import mpmath"),
                                      string("def fn(log, s):"),
                                      string("    if log:"),
                                      sprintf!("        print(f\'{} / s: {{s}}\', flush=True)",
                                               string("zeta_")),
                                      string("    s = complex(*s)"),
                                      string("    try:"),
                                      string("        if log: start_trace()"),
                                      string("        s = mpmath.zeta(s)"),
                                      string("        if log: stop_trace()"),
                                      string("    except ValueError as e:"),
                                      string("        if s.real == 1:"),
                                      string("            s = complex(float(\'inf\'), 0)"),
                                      string("    return (s.real, s.imag)")]))
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
                let v17: num_complex::Complex<f64> = patternInput.0.clone();
                let v20: string = Math::method10(Math::method8());
                let v21: num_complex::Complex<f64> = Math::method12(v17.clone());
                let v23: f64 = v21.re;
                let v24: num_complex::Complex<f64> = Math::method13(v17);
                let v28: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    LrcPtr::new((false, LrcPtr::new((v23, v24.im))));
                let v29: pyo3::Python = Math::method14(v0_1.clone());
                let v30: string = Math::method15(v20);
                let v32: &str = fable_library_rust::String_::LrcStr::as_str(&v30);
                let v35: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                    Math::method16(pyo3::types::PyModule::from_code_bound(v29, v32, "", ""));
                let v37: pyo3::Bound<pyo3::types::PyModule> = v35.unwrap();
                let v38: string = Math::method17();
                let v40: &str = fable_library_rust::String_::LrcStr::as_str(&v38);
                let v41: pyo3::Bound<pyo3::types::PyModule> = Math::method18(v37);
                let v44: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                    Math::method19(v41.getattr(v40));
                let v46: pyo3::Bound<pyo3::PyAny> = v44.unwrap();
                let v47: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    Math::method20(v28.0.clone(), v28.1.clone());
                let v48: pyo3::Bound<pyo3::PyAny> = Math::method21(v46);
                let v51: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method19(
                    pyo3::prelude::PyAnyMethods::call(&v48, ((*v47).0, *(*v47).1), None),
                );
                let v54: pyo3::Bound<pyo3::PyAny> = Math::method22(v51.unwrap());
                let v57: Result<(f64, f64), pyo3::PyErr> = Math::method23(v54.extract());
                let patternInput_1: (f64, f64) = v57.unwrap();
                let v62: f64 = Math::method3(Math::method24(patternInput_1.0.clone()));
                let v63: f64 = Math::method25(patternInput_1.1.clone());
                let v67: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method26(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                        num_complex::Complex::new(v62, v63),
                    ));
                let v69: num_complex::Complex<f64> = v67.unwrap();
                let v71: f64 = Math::method3(Math::method27());
                let v72: f64 = Math::method4();
                let v74: num_complex::Complex<f64> = num_complex::Complex::new(v71, v72);
                let v75: num_complex::Complex<f64> = Math::method13(v69.clone());
                let v77: f64 = v75.im;
                let v78: bool = v77 == 0.0_f64;
                if (if v78 { true } else { Math::method28(v78) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v77, 0.0_f64),
                    );
                }
                {
                    let v83: num_complex::Complex<f64> = Math::method12(v69);
                    let v86: f64 = v83.re - patternInput.1.clone();
                    let v87: f64 = -v86;
                    let v89: f64 = if v86 >= v87 { v86 } else { v87 };
                    let v90: bool = v89 < 0.0001_f64;
                    if (if v90 { true } else { Math::method28(v90) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v89, 0.0001_f64),
                        );
                    }
                    {
                        let v95: i32 = v16 + 1_i32;
                        v14.l0.set(v95);
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
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v7: string = Math::method10(Math::method8());
            let v8: num_complex::Complex<f64> = Math::method12(v5.clone());
            let v10: f64 = v8.re;
            let v11: num_complex::Complex<f64> = Math::method13(v5);
            let v15: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v10, v11.im))));
            let v16: pyo3::Python = Math::method14(v0_1);
            let v17: string = Math::method15(v7);
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v22: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                Math::method16(pyo3::types::PyModule::from_code_bound(v16, v19, "", ""));
            let v24: pyo3::Bound<pyo3::types::PyModule> = v22.unwrap();
            let v25: string = Math::method17();
            let v27: &str = fable_library_rust::String_::LrcStr::as_str(&v25);
            let v28: pyo3::Bound<pyo3::types::PyModule> = Math::method18(v24);
            let v31: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                Math::method19(v28.getattr(v27));
            let v33: pyo3::Bound<pyo3::PyAny> = v31.unwrap();
            let v34: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method20(v15.0.clone(), v15.1.clone());
            let v35: pyo3::Bound<pyo3::PyAny> = Math::method21(v33);
            let v38: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method19(
                pyo3::prelude::PyAnyMethods::call(&v35, ((*v34).0, *(*v34).1), None),
            );
            let v41: pyo3::Bound<pyo3::PyAny> = Math::method22(v38.unwrap());
            let v44: Result<(f64, f64), pyo3::PyErr> = Math::method23(v41.extract());
            let patternInput: (f64, f64) = v44.unwrap();
            let v49: f64 = Math::method3(Math::method24(patternInput.0.clone()));
            let v50: f64 = Math::method25(patternInput.1.clone());
            let v54: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                Math::method26(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                    num_complex::Complex::new(v49, v50),
                ));
            let v56: num_complex::Complex<f64> = v54.unwrap();
            let v58: f64 = Math::method3(Math::method27());
            let v59: f64 = Math::method4();
            let v61: num_complex::Complex<f64> = num_complex::Complex::new(v58, v59);
            let v62: num_complex::Complex<f64> = Math::method12(v56.clone());
            let v65: f64 = v62.re - 0.8673_f64;
            let v66: f64 = -v65;
            let v68: f64 = if v65 >= v66 { v65 } else { v66 };
            let v69: bool = v68 < 0.001_f64;
            if (if v69 { true } else { Math::method28(v69) }) == false {
                panic!(
                    "{}",
                    sprintf!("__expect / actual: {:?} / expected: {:?}", v68, 0.001_f64),
                );
            }
            {
                let v74: num_complex::Complex<f64> = Math::method13(v56);
                let v77: f64 = v74.im - 0.275_f64;
                let v78: f64 = -v77;
                let v80: f64 = if v77 >= v78 { v77 } else { v78 };
                let v81: bool = v80 < 0.001_f64;
                if (if v81 { true } else { Math::method28(v81) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v80, 0.001_f64),
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
                        let v8: num_complex::Complex<f64> = num_complex::Complex::new(v5, v6);
                        let v10: string = Math::method10(Math::method8());
                        let v11: num_complex::Complex<f64> = Math::method12(v8.clone());
                        let v13: f64 = v11.re;
                        let v14: num_complex::Complex<f64> = Math::method13(v8);
                        let v18: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                            LrcPtr::new((false, LrcPtr::new((v13, v14.im))));
                        let v19: pyo3::Python = Math::method14(v0_1.get().clone());
                        let v20: string = Math::method15(v10);
                        let v22: &str = fable_library_rust::String_::LrcStr::as_str(&v20);
                        let v25: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                            Math::method16(pyo3::types::PyModule::from_code_bound(
                                v19, v22, "", "",
                            ));
                        let v27: pyo3::Bound<pyo3::types::PyModule> = v25.unwrap();
                        let v28: string = Math::method17();
                        let v30: &str = fable_library_rust::String_::LrcStr::as_str(&v28);
                        let v31: pyo3::Bound<pyo3::types::PyModule> = Math::method18(v27);
                        let v34: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                            Math::method19(v31.getattr(v30));
                        let v36: pyo3::Bound<pyo3::PyAny> = v34.unwrap();
                        let v37: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                            Math::method20(v18.0.clone(), v18.1.clone());
                        let v38: pyo3::Bound<pyo3::PyAny> = Math::method21(v36);
                        let v41: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method19(
                            pyo3::prelude::PyAnyMethods::call(&v38, ((*v37).0, *(*v37).1), None),
                        );
                        let v44: pyo3::Bound<pyo3::PyAny> = Math::method22(v41.unwrap());
                        let v47: Result<(f64, f64), pyo3::PyErr> = Math::method23(v44.extract());
                        let patternInput: (f64, f64) = v47.unwrap();
                        let v52: f64 = Math::method3(Math::method24(patternInput.0.clone()));
                        let v53: f64 = Math::method25(patternInput.1.clone());
                        let v57: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                            Math::method26(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                                num_complex::Complex::new(v52, v53),
                            ));
                        let v59: num_complex::Complex<f64> = v57.unwrap();
                        let v61: f64 = Math::method3(Math::method27());
                        let v62: f64 = Math::method4();
                        let v64: num_complex::Complex<f64> = num_complex::Complex::new(v61, v62);
                        let v65: num_complex::Complex<f64> = Math::method12(v59.clone());
                        let v67: f64 = v65.re;
                        let v68: bool = v67 == 0.0_f64;
                        if (if v68 { true } else { Math::method28(v68) }) == false {
                            panic!(
                                "{}",
                                sprintf!("__expect / actual: {:?} / expected: {:?}", v67, 0.0_f64),
                            );
                        }
                        {
                            let v73: num_complex::Complex<f64> = Math::method13(v59);
                            let v75: f64 = v73.im;
                            let v76: bool = v75 == 0.0_f64;
                            if (if v76 { true } else { Math::method28(v76) }) == false {
                                panic!(
                                    "{}",
                                    sprintf!(
                                        "__expect / actual: {:?} / expected: {:?}",
                                        v75,
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
                let v37: num_complex::Complex<f64> = v32[v36].clone();
                let v39: string = Math::method10(Math::method8());
                let v40: num_complex::Complex<f64> = Math::method12(v37.clone());
                let v42: f64 = v40.re;
                let v43: num_complex::Complex<f64> = Math::method13(v37);
                let v47: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    LrcPtr::new((false, LrcPtr::new((v42, v43.im))));
                let v48: pyo3::Python = Math::method14(v0_1.clone());
                let v49: string = Math::method15(v39);
                let v51: &str = fable_library_rust::String_::LrcStr::as_str(&v49);
                let v54: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                    Math::method16(pyo3::types::PyModule::from_code_bound(v48, v51, "", ""));
                let v56: pyo3::Bound<pyo3::types::PyModule> = v54.unwrap();
                let v57: string = Math::method17();
                let v59: &str = fable_library_rust::String_::LrcStr::as_str(&v57);
                let v60: pyo3::Bound<pyo3::types::PyModule> = Math::method18(v56);
                let v63: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                    Math::method19(v60.getattr(v59));
                let v65: pyo3::Bound<pyo3::PyAny> = v63.unwrap();
                let v66: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    Math::method20(v47.0.clone(), v47.1.clone());
                let v67: pyo3::Bound<pyo3::PyAny> = Math::method21(v65);
                let v70: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method19(
                    pyo3::prelude::PyAnyMethods::call(&v67, ((*v66).0, *(*v66).1), None),
                );
                let v73: pyo3::Bound<pyo3::PyAny> = Math::method22(v70.unwrap());
                let v76: Result<(f64, f64), pyo3::PyErr> = Math::method23(v73.extract());
                let patternInput: (f64, f64) = v76.unwrap();
                let v81: f64 = Math::method3(Math::method24(patternInput.0.clone()));
                let v82: f64 = Math::method25(patternInput.1.clone());
                let v86: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method26(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                        num_complex::Complex::new(v81, v82),
                    ));
                let v88: num_complex::Complex<f64> = v86.unwrap();
                let v90: f64 = Math::method3(Math::method27());
                let v91: f64 = Math::method4();
                let v93: num_complex::Complex<f64> = num_complex::Complex::new(v90, v91);
                let v94: num_complex::Complex<f64> = Math::method12(v88.clone());
                let v96: f64 = v94.re;
                let v97: f64 = -v96;
                let v99: f64 = if v96 >= v97 { v96 } else { v97 };
                let v100: bool = v99 < 0.0001_f64;
                if (if v100 { true } else { Math::method28(v100) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v99, 0.0001_f64),
                    );
                }
                {
                    let v105: num_complex::Complex<f64> = Math::method13(v88);
                    let v107: f64 = v105.im;
                    let v108: f64 = -v107;
                    let v110: f64 = if v107 >= v108 { v107 } else { v108 };
                    let v111: bool = v110 < 0.0001_f64;
                    if (if v111 { true } else { Math::method28(v111) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v110, 0.0001_f64),
                        );
                    }
                    {
                        let v116: i32 = v36 + 1_i32;
                        v34.l0.set(v116);
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
                let v12: num_complex::Complex<f64> = num_complex::Complex::new(v9, v10);
                let v14: string = Math::method10(Math::method8());
                let v15: num_complex::Complex<f64> = Math::method12(v12.clone());
                let v17: f64 = v15.re;
                let v18: num_complex::Complex<f64> = Math::method13(v12);
                let v22: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    LrcPtr::new((false, LrcPtr::new((v17, v18.im))));
                let v23: pyo3::Python = Math::method14(v0_1.clone());
                let v24: string = Math::method15(v14);
                let v26: &str = fable_library_rust::String_::LrcStr::as_str(&v24);
                let v29: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                    Math::method16(pyo3::types::PyModule::from_code_bound(v23, v26, "", ""));
                let v31: pyo3::Bound<pyo3::types::PyModule> = v29.unwrap();
                let v32: string = Math::method17();
                let v34: &str = fable_library_rust::String_::LrcStr::as_str(&v32);
                let v35: pyo3::Bound<pyo3::types::PyModule> = Math::method18(v31);
                let v38: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                    Math::method19(v35.getattr(v34));
                let v40: pyo3::Bound<pyo3::PyAny> = v38.unwrap();
                let v41: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    Math::method20(v22.0.clone(), v22.1.clone());
                let v42: pyo3::Bound<pyo3::PyAny> = Math::method21(v40);
                let v45: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method19(
                    pyo3::prelude::PyAnyMethods::call(&v42, ((*v41).0, *(*v41).1), None),
                );
                let v48: pyo3::Bound<pyo3::PyAny> = Math::method22(v45.unwrap());
                let v51: Result<(f64, f64), pyo3::PyErr> = Math::method23(v48.extract());
                let patternInput: (f64, f64) = v51.unwrap();
                let v56: f64 = Math::method3(Math::method24(patternInput.0.clone()));
                let v57: f64 = Math::method25(patternInput.1.clone());
                let v61: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method26(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                        num_complex::Complex::new(v56, v57),
                    ));
                let v63: num_complex::Complex<f64> = v61.unwrap();
                let v65: f64 = Math::method3(Math::method27());
                let v66: f64 = Math::method4();
                let v68: num_complex::Complex<f64> = num_complex::Complex::new(v65, v66);
                let v69: num_complex::Complex<f64> = Math::method12(v63.clone());
                let v71: f64 = v69.re;
                let v72: bool = v71 > 0.0_f64;
                if (if v72 { true } else { Math::method28(v72) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v71, 0.0_f64),
                    );
                }
                {
                    let v77: num_complex::Complex<f64> = Math::method13(v63);
                    let v79: f64 = v77.im;
                    let v80: bool = v79 == 0.0_f64;
                    if (if v80 { true } else { Math::method28(v80) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v79, 0.0_f64),
                        );
                    }
                    {
                        let v85: i32 = v6 + 1_i32;
                        v4.l0.set(v85);
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
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v7: string = Math::method10(Math::method8());
            let v8: num_complex::Complex<f64> = Math::method12(v5.clone());
            let v10: f64 = v8.re;
            let v11: num_complex::Complex<f64> = Math::method13(v5);
            let v15: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v10, v11.im))));
            let v16: pyo3::Python = Math::method14(v0_1);
            let v17: string = Math::method15(v7);
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v22: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                Math::method16(pyo3::types::PyModule::from_code_bound(v16, v19, "", ""));
            let v24: pyo3::Bound<pyo3::types::PyModule> = v22.unwrap();
            let v25: string = Math::method17();
            let v27: &str = fable_library_rust::String_::LrcStr::as_str(&v25);
            let v28: pyo3::Bound<pyo3::types::PyModule> = Math::method18(v24);
            let v31: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                Math::method19(v28.getattr(v27));
            let v33: pyo3::Bound<pyo3::PyAny> = v31.unwrap();
            let v34: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method20(v15.0.clone(), v15.1.clone());
            let v35: pyo3::Bound<pyo3::PyAny> = Math::method21(v33);
            let v38: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method19(
                pyo3::prelude::PyAnyMethods::call(&v35, ((*v34).0, *(*v34).1), None),
            );
            let v41: pyo3::Bound<pyo3::PyAny> = Math::method22(v38.unwrap());
            let v44: Result<(f64, f64), pyo3::PyErr> = Math::method23(v41.extract());
            let patternInput: (f64, f64) = v44.unwrap();
            let v49: f64 = Math::method3(Math::method24(patternInput.0.clone()));
            let v50: f64 = Math::method25(patternInput.1.clone());
            let v54: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                Math::method26(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                    num_complex::Complex::new(v49, v50),
                ));
            let v56: num_complex::Complex<f64> = v54.unwrap();
            let v58: f64 = Math::method3(Math::method27());
            let v59: f64 = Math::method4();
            let v61: num_complex::Complex<f64> = num_complex::Complex::new(v58, v59);
            let v62: num_complex::Complex<f64> = Math::method12(v56.clone());
            let v64: f64 = v62.re;
            let v65: bool = v64 == f64::INFINITY;
            if (if v65 { true } else { Math::method28(v65) }) == false {
                panic!(
                    "{}",
                    sprintf!(
                        "__expect / actual: {:?} / expected: {:?}",
                        v64,
                        f64::INFINITY
                    ),
                );
            }
            {
                let v70: num_complex::Complex<f64> = Math::method13(v56);
                let v72: f64 = v70.im;
                let v73: bool = v72 == 0.0_f64;
                if (if v73 { true } else { Math::method28(v73) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v72, 0.0_f64),
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
            let v7: string = Math::method10(Math::method8());
            let v8: num_complex::Complex<f64> = Math::method12(v5.clone());
            let v10: f64 = v8.re;
            let v11: num_complex::Complex<f64> = Math::method13(v5.clone());
            let v15: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v10, v11.im))));
            let v16: pyo3::Python = Math::method14(v0_1.clone());
            let v17: string = Math::method15(v7);
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v22: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                Math::method16(pyo3::types::PyModule::from_code_bound(v16, v19, "", ""));
            let v24: pyo3::Bound<pyo3::types::PyModule> = v22.unwrap();
            let v25: string = Math::method17();
            let v27: &str = fable_library_rust::String_::LrcStr::as_str(&v25);
            let v28: pyo3::Bound<pyo3::types::PyModule> = Math::method18(v24);
            let v31: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                Math::method19(v28.getattr(v27));
            let v33: pyo3::Bound<pyo3::PyAny> = v31.unwrap();
            let v34: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method20(v15.0.clone(), v15.1.clone());
            let v35: pyo3::Bound<pyo3::PyAny> = Math::method21(v33);
            let v38: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method19(
                pyo3::prelude::PyAnyMethods::call(&v35, ((*v34).0, *(*v34).1), None),
            );
            let v41: pyo3::Bound<pyo3::PyAny> = Math::method22(v38.unwrap());
            let v44: Result<(f64, f64), pyo3::PyErr> = Math::method23(v41.extract());
            let patternInput: (f64, f64) = v44.unwrap();
            let v49: f64 = Math::method3(Math::method24(patternInput.0.clone()));
            let v50: f64 = Math::method25(patternInput.1.clone());
            let v54: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                Math::method26(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                    num_complex::Complex::new(v49, v50),
                ));
            let v56: num_complex::Complex<f64> = v54.unwrap();
            let v58: f64 = Math::method3(Math::method27());
            let v59: f64 = Math::method4();
            let v61: num_complex::Complex<f64> = num_complex::Complex::new(v58, v59);
            let v62: num_complex::Complex<f64> = Math::method12(v5.clone());
            let v64: f64 = v62.re;
            let v65: num_complex::Complex<f64> = Math::method13(v5);
            let v68: f64 = -v65.im;
            let v70: f64 = Math::method3(Math::method24(v64));
            let v71: f64 = Math::method25(v68);
            let v73: num_complex::Complex<f64> = num_complex::Complex::new(v70, v71);
            let v75: string = Math::method10(Math::method8());
            let v76: num_complex::Complex<f64> = Math::method12(v73.clone());
            let v78: f64 = v76.re;
            let v79: num_complex::Complex<f64> = Math::method13(v73);
            let v83: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v78, v79.im))));
            let v84: pyo3::Python = Math::method14(v0_1);
            let v85: string = Math::method15(v75);
            let v87: &str = fable_library_rust::String_::LrcStr::as_str(&v85);
            let v90: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                Math::method16(pyo3::types::PyModule::from_code_bound(v84, v87, "", ""));
            let v92: pyo3::Bound<pyo3::types::PyModule> = v90.unwrap();
            let v93: string = Math::method17();
            let v95: &str = fable_library_rust::String_::LrcStr::as_str(&v93);
            let v96: pyo3::Bound<pyo3::types::PyModule> = Math::method18(v92);
            let v99: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                Math::method19(v96.getattr(v95));
            let v101: pyo3::Bound<pyo3::PyAny> = v99.unwrap();
            let v102: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method20(v83.0.clone(), v83.1.clone());
            let v103: pyo3::Bound<pyo3::PyAny> = Math::method21(v101);
            let v106: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method19(
                pyo3::prelude::PyAnyMethods::call(&v103, ((*v102).0, *(*v102).1), None),
            );
            let v109: pyo3::Bound<pyo3::PyAny> = Math::method22(v106.unwrap());
            let v112: Result<(f64, f64), pyo3::PyErr> = Math::method23(v109.extract());
            let patternInput_1: (f64, f64) = v112.unwrap();
            let v117: f64 = Math::method3(Math::method24(patternInput_1.0.clone()));
            let v118: f64 = Math::method25(patternInput_1.1.clone());
            let v122: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                Math::method26(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                    num_complex::Complex::new(v117, v118),
                ));
            let v124: num_complex::Complex<f64> = v122.unwrap();
            let v126: f64 = Math::method3(Math::method27());
            let v127: f64 = Math::method4();
            let v129: num_complex::Complex<f64> = num_complex::Complex::new(v126, v127);
            let v131: num_complex::Complex<f64> = v124.conj();
            let v132: num_complex::Complex<f64> = Math::method12(v56.clone());
            let v134: f64 = v132.re;
            let v135: num_complex::Complex<f64> = Math::method12(v131.clone());
            let v137: f64 = v135.re;
            let v138: bool = v134 == v137;
            if (if v138 { true } else { Math::method28(v138) }) == false {
                panic!(
                    "{}",
                    sprintf!("__expect / actual: {:?} / expected: {:?}", v134, v137),
                );
            }
            {
                let v143: num_complex::Complex<f64> = Math::method13(v56);
                let v145: f64 = v143.im;
                let v146: num_complex::Complex<f64> = Math::method13(v131);
                let v148: f64 = v146.im;
                let v149: bool = v145 == v148;
                if (if v149 { true } else { Math::method28(v149) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v145, v148),
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
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v7: string = Math::method10(Math::method8());
            let v8: num_complex::Complex<f64> = Math::method12(v5.clone());
            let v10: f64 = v8.re;
            let v11: num_complex::Complex<f64> = Math::method13(v5);
            let v15: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v10, v11.im))));
            let v16: pyo3::Python = Math::method14(v0_1);
            let v17: string = Math::method15(v7);
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v22: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                Math::method16(pyo3::types::PyModule::from_code_bound(v16, v19, "", ""));
            let v24: pyo3::Bound<pyo3::types::PyModule> = v22.unwrap();
            let v25: string = Math::method17();
            let v27: &str = fable_library_rust::String_::LrcStr::as_str(&v25);
            let v28: pyo3::Bound<pyo3::types::PyModule> = Math::method18(v24);
            let v31: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                Math::method19(v28.getattr(v27));
            let v33: pyo3::Bound<pyo3::PyAny> = v31.unwrap();
            let v34: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method20(v15.0.clone(), v15.1.clone());
            let v35: pyo3::Bound<pyo3::PyAny> = Math::method21(v33);
            let v38: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method19(
                pyo3::prelude::PyAnyMethods::call(&v35, ((*v34).0, *(*v34).1), None),
            );
            let v41: pyo3::Bound<pyo3::PyAny> = Math::method22(v38.unwrap());
            let v44: Result<(f64, f64), pyo3::PyErr> = Math::method23(v41.extract());
            let patternInput: (f64, f64) = v44.unwrap();
            let v49: f64 = Math::method3(Math::method24(patternInput.0.clone()));
            let v50: f64 = Math::method25(patternInput.1.clone());
            let v54: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                Math::method26(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                    num_complex::Complex::new(v49, v50),
                ));
            let v56: num_complex::Complex<f64> = v54.unwrap();
            let v58: f64 = Math::method3(Math::method27());
            let v59: f64 = Math::method4();
            let v61: num_complex::Complex<f64> = num_complex::Complex::new(v58, v59);
            let v62: num_complex::Complex<f64> = Math::method12(v56.clone());
            let v64: f64 = v62.re;
            let v65: bool = v64 < f64::INFINITY;
            if (if v65 { true } else { Math::method28(v65) }) == false {
                panic!(
                    "{}",
                    sprintf!(
                        "__expect / actual: {:?} / expected: {:?}",
                        v64,
                        f64::INFINITY
                    ),
                );
            }
            {
                let v70: num_complex::Complex<f64> = Math::method13(v56);
                let v72: f64 = v70.im;
                let v73: bool = v72 < f64::INFINITY;
                if (if v73 { true } else { Math::method28(v73) }) == false {
                    panic!(
                        "{}",
                        sprintf!(
                            "__expect / actual: {:?} / expected: {:?}",
                            v72,
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
            let v5: num_complex::Complex<f64> = num_complex::Complex::new(v2, v3);
            let v7: string = Math::method10(Math::method8());
            let v8: num_complex::Complex<f64> = Math::method12(v5.clone());
            let v10: f64 = v8.re;
            let v11: num_complex::Complex<f64> = Math::method13(v5);
            let v15: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                LrcPtr::new((false, LrcPtr::new((v10, v11.im))));
            let v16: pyo3::Python = Math::method14(v0_1);
            let v17: string = Math::method15(v7);
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v22: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                Math::method16(pyo3::types::PyModule::from_code_bound(v16, v19, "", ""));
            let v24: pyo3::Bound<pyo3::types::PyModule> = v22.unwrap();
            let v25: string = Math::method17();
            let v27: &str = fable_library_rust::String_::LrcStr::as_str(&v25);
            let v28: pyo3::Bound<pyo3::types::PyModule> = Math::method18(v24);
            let v31: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                Math::method19(v28.getattr(v27));
            let v33: pyo3::Bound<pyo3::PyAny> = v31.unwrap();
            let v34: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                Math::method20(v15.0.clone(), v15.1.clone());
            let v35: pyo3::Bound<pyo3::PyAny> = Math::method21(v33);
            let v38: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method19(
                pyo3::prelude::PyAnyMethods::call(&v35, ((*v34).0, *(*v34).1), None),
            );
            let v41: pyo3::Bound<pyo3::PyAny> = Math::method22(v38.unwrap());
            let v44: Result<(f64, f64), pyo3::PyErr> = Math::method23(v41.extract());
            let patternInput: (f64, f64) = v44.unwrap();
            let v49: f64 = Math::method3(Math::method24(patternInput.0.clone()));
            let v50: f64 = Math::method25(patternInput.1.clone());
            let v54: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                Math::method26(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                    num_complex::Complex::new(v49, v50),
                ));
            let v56: num_complex::Complex<f64> = v54.unwrap();
            let v58: f64 = Math::method3(Math::method27());
            let v59: f64 = Math::method4();
            let v61: num_complex::Complex<f64> = num_complex::Complex::new(v58, v59);
            let v62: num_complex::Complex<f64> = Math::method12(v56.clone());
            let v65: f64 = v62.re + 0.08333333333333333_f64;
            let v66: f64 = -v65;
            let v68: f64 = if v65 >= v66 { v65 } else { v66 };
            let v69: bool = v68 < 0.0001_f64;
            if (if v69 { true } else { Math::method28(v69) }) == false {
                panic!(
                    "{}",
                    sprintf!("__expect / actual: {:?} / expected: {:?}", v68, 0.0001_f64),
                );
            }
            {
                let v74: num_complex::Complex<f64> = Math::method13(v56);
                let v76: f64 = v74.im;
                let v77: bool = v76 == 0.0_f64;
                if (if v77 { true } else { Math::method28(v77) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v76, 0.0_f64),
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
                let v11: num_complex::Complex<f64> = num_complex::Complex::new(v8, v9);
                let v13: string = Math::method10(Math::method8());
                let v14: num_complex::Complex<f64> = Math::method12(v11.clone());
                let v16: f64 = v14.re;
                let v17: num_complex::Complex<f64> = Math::method13(v11);
                let v21: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    LrcPtr::new((false, LrcPtr::new((v16, v17.im))));
                let v22: pyo3::Python = Math::method14(v0_1.clone());
                let v23: string = Math::method15(v13);
                let v25: &str = fable_library_rust::String_::LrcStr::as_str(&v23);
                let v28: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                    Math::method16(pyo3::types::PyModule::from_code_bound(v22, v25, "", ""));
                let v30: pyo3::Bound<pyo3::types::PyModule> = v28.unwrap();
                let v31: string = Math::method17();
                let v33: &str = fable_library_rust::String_::LrcStr::as_str(&v31);
                let v34: pyo3::Bound<pyo3::types::PyModule> = Math::method18(v30);
                let v37: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                    Math::method19(v34.getattr(v33));
                let v39: pyo3::Bound<pyo3::PyAny> = v37.unwrap();
                let v40: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    Math::method20(v21.0.clone(), v21.1.clone());
                let v41: pyo3::Bound<pyo3::PyAny> = Math::method21(v39);
                let v44: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method19(
                    pyo3::prelude::PyAnyMethods::call(&v41, ((*v40).0, *(*v40).1), None),
                );
                let v47: pyo3::Bound<pyo3::PyAny> = Math::method22(v44.unwrap());
                let v50: Result<(f64, f64), pyo3::PyErr> = Math::method23(v47.extract());
                let patternInput: (f64, f64) = v50.unwrap();
                let v55: f64 = Math::method3(Math::method24(patternInput.0.clone()));
                let v56: f64 = Math::method25(patternInput.1.clone());
                let v60: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method26(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                        num_complex::Complex::new(v55, v56),
                    ));
                let v62: num_complex::Complex<f64> = v60.unwrap();
                let v64: f64 = Math::method3(Math::method27());
                let v65: f64 = Math::method4();
                let v67: num_complex::Complex<f64> = num_complex::Complex::new(v64, v65);
                let v68: num_complex::Complex<f64> = Math::method12(v62.clone());
                let v70: f64 = v68.re;
                let v72: bool = Math::method66(v70 == 0.0_f64);
                if (if v72 { true } else { Math::method28(v72) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v70, 0.0_f64),
                    );
                }
                {
                    let v77: num_complex::Complex<f64> = Math::method13(v62);
                    let v79: f64 = v77.im;
                    let v81: bool = Math::method66(v79 == 0.0_f64);
                    if (if v81 { true } else { Math::method28(v81) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v79, 0.0_f64),
                        );
                    }
                    {
                        let v86: i32 = v5 + 1_i32;
                        v3.l0.set(v86);
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
                let v32: num_complex::Complex<f64> = v27[v31].clone();
                let v34: string = Math::method10(Math::method8());
                let v35: num_complex::Complex<f64> = Math::method12(v32.clone());
                let v37: f64 = v35.re;
                let v38: num_complex::Complex<f64> = Math::method13(v32);
                let v42: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    LrcPtr::new((false, LrcPtr::new((v37, v38.im))));
                let v43: pyo3::Python = Math::method14(v0_1.clone());
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
                let v81: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method26(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                        num_complex::Complex::new(v76, v77),
                    ));
                let v83: num_complex::Complex<f64> = v81.unwrap();
                let v85: f64 = Math::method3(Math::method27());
                let v86: f64 = Math::method4();
                let v88: num_complex::Complex<f64> = num_complex::Complex::new(v85, v86);
                let v89: num_complex::Complex<f64> = Math::method12(v83.clone());
                let v91: f64 = v89.re;
                let v93: bool = Math::method66(v91 == 0.0_f64);
                if (if v93 { true } else { Math::method28(v93) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v91, 0.0_f64),
                    );
                }
                {
                    let v98: num_complex::Complex<f64> = Math::method13(v83);
                    let v100: f64 = v98.im;
                    let v102: bool = Math::method66(v100 == 0.0_f64);
                    if (if v102 { true } else { Math::method28(v102) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v100, 0.0_f64),
                        );
                    }
                    {
                        let v107: i32 = v31 + 1_i32;
                        v29.l0.set(v107);
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
        pub fn method87() -> Array<string> {
            Math::method9(new_array(&[string("import sys"),
                                      string("import traceback"),
                                      string("def trace_calls(frame, event, arg):"),
                                      string("    if event != \'call\':"),
                                      string("        return"),
                                      string("    co = frame.f_code"),
                                      string("    func_name = co.co_name"),
                                      string("    func_line_no = frame.f_lineno"),
                                      string("    func_filename = co.co_filename"),
                                      string("    caller = frame.f_back"),
                                      string("    caller_line_no = caller.f_lineno"),
                                      string("    caller_filename = caller.f_code.co_filename"),
                                      string("    args = frame.f_locals"),
                                      string("    args_str = \', \'.join([f\"{k}={v}\" for k, v in args.items() if k != \'ctx\'])"),
                                      sprintf!("    print(f\'{} / Call to {{func_name}}({{args_str}}) on line {{func_line_no}} of {{func_filename}} from line {{caller_line_no}} of {{caller_filename}}\', flush=True)",
                                               string("gamma_")),
                                      string("def start_trace():"),
                                      string("    sys.settrace(trace_calls)"),
                                      string("def stop_trace():"),
                                      string("    sys.settrace(None)"),
                                      string("import mpmath"),
                                      string("def fn(log, s):"),
                                      string("    if log:"),
                                      sprintf!("        print(f\'{} / s: {{s}}\', flush=True)",
                                               string("gamma_")),
                                      string("    s = complex(*s)"),
                                      string("    try:"),
                                      string("        if log: start_trace()"),
                                      string("        s = mpmath.gamma(s)"),
                                      string("        if log: stop_trace()"),
                                      string("    except ValueError as e:"),
                                      string("        if s.real == 1:"),
                                      string("            s = complex(float(\'inf\'), 0)"),
                                      string("    return (s.real, s.imag)")]))
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
                let v29: string = Math::method10(Math::method8());
                let v30: num_complex::Complex<f64> = Math::method12(v27.clone());
                let v32: f64 = v30.re;
                let v33: num_complex::Complex<f64> = Math::method13(v27.clone());
                let v37: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    LrcPtr::new((false, LrcPtr::new((v32, v33.im))));
                let v38: pyo3::Python = Math::method14(v0_1.clone());
                let v39: string = Math::method15(v29);
                let v41: &str = fable_library_rust::String_::LrcStr::as_str(&v39);
                let v44: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                    Math::method16(pyo3::types::PyModule::from_code_bound(v38, v41, "", ""));
                let v46: pyo3::Bound<pyo3::types::PyModule> = v44.unwrap();
                let v47: string = Math::method17();
                let v49: &str = fable_library_rust::String_::LrcStr::as_str(&v47);
                let v50: pyo3::Bound<pyo3::types::PyModule> = Math::method18(v46);
                let v53: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                    Math::method19(v50.getattr(v49));
                let v55: pyo3::Bound<pyo3::PyAny> = v53.unwrap();
                let v56: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    Math::method20(v37.0.clone(), v37.1.clone());
                let v57: pyo3::Bound<pyo3::PyAny> = Math::method21(v55);
                let v60: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method19(
                    pyo3::prelude::PyAnyMethods::call(&v57, ((*v56).0, *(*v56).1), None),
                );
                let v63: pyo3::Bound<pyo3::PyAny> = Math::method22(v60.unwrap());
                let v66: Result<(f64, f64), pyo3::PyErr> = Math::method23(v63.extract());
                let patternInput: (f64, f64) = v66.unwrap();
                let v71: f64 = Math::method3(Math::method24(patternInput.0.clone()));
                let v72: f64 = Math::method25(patternInput.1.clone());
                let v76: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method26(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                        num_complex::Complex::new(v71, v72),
                    ));
                let v78: num_complex::Complex<f64> = v76.unwrap();
                let v80: f64 = Math::method3(Math::method27());
                let v81: f64 = Math::method4();
                let v83: num_complex::Complex<f64> = num_complex::Complex::new(v80, v81);
                let v85: f64 = Math::method3(Math::method2());
                let v86: f64 = Math::method4();
                let v89: num_complex::Complex<f64> =
                    Math::method84(num_complex::Complex::new(v85, v86));
                let v90: num_complex::Complex<f64> = Math::method85(v27.clone());
                let v92: num_complex::Complex<f64> = num_complex::Complex::powc(v89, v90);
                let v94: f64 = Math::method3(Math::method86());
                let v95: f64 = Math::method4();
                let v97: num_complex::Complex<f64> = num_complex::Complex::new(v94, v95);
                let v99: f64 = Math::method3(Math::method53());
                let v100: f64 = Math::method4();
                let v102: num_complex::Complex<f64> = num_complex::Complex::new(v99, v100);
                let v104: num_complex::Complex<f64> = v27 - v102;
                let v105: num_complex::Complex<f64> = Math::method84(v97);
                let v106: num_complex::Complex<f64> = Math::method85(v104);
                let v108: num_complex::Complex<f64> = num_complex::Complex::powc(v105, v106);
                let v110: num_complex::Complex<f64> = v92 * v108;
                let v112: f64 = Math::method3(Math::method86());
                let v113: f64 = Math::method4();
                let v115: num_complex::Complex<f64> = num_complex::Complex::new(v112, v113);
                let v117: num_complex::Complex<f64> = v115 * v27;
                let v119: f64 = Math::method3(Math::method2());
                let v120: f64 = Math::method4();
                let v122: num_complex::Complex<f64> = num_complex::Complex::new(v119, v120);
                let v124: num_complex::Complex<f64> = v117 / v122;
                let v126: num_complex::Complex<f64> = v124.sin();
                let v128: num_complex::Complex<f64> = v110 * v126;
                let v130: f64 = Math::method3(Math::method53());
                let v131: f64 = Math::method4();
                let v133: num_complex::Complex<f64> = num_complex::Complex::new(v130, v131);
                let v135: num_complex::Complex<f64> = v133 - v27;
                let v137: string = Math::method10(Math::method87());
                let v138: num_complex::Complex<f64> = Math::method12(v135.clone());
                let v140: f64 = v138.re;
                let v141: num_complex::Complex<f64> = Math::method13(v135);
                let v145: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    LrcPtr::new((false, LrcPtr::new((v140, v141.im))));
                let v146: pyo3::Python = Math::method14(v0_1.clone());
                let v147: string = Math::method15(v137);
                let v149: &str = fable_library_rust::String_::LrcStr::as_str(&v147);
                let v152: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                    Math::method16(pyo3::types::PyModule::from_code_bound(v146, v149, "", ""));
                let v154: pyo3::Bound<pyo3::types::PyModule> = v152.unwrap();
                let v155: string = Math::method17();
                let v157: &str = fable_library_rust::String_::LrcStr::as_str(&v155);
                let v158: pyo3::Bound<pyo3::types::PyModule> = Math::method18(v154);
                let v161: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                    Math::method19(v158.getattr(v157));
                let v163: pyo3::Bound<pyo3::PyAny> = v161.unwrap();
                let v164: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    Math::method20(v145.0.clone(), v145.1.clone());
                let v165: pyo3::Bound<pyo3::PyAny> = Math::method21(v163);
                let v168: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method19(
                    pyo3::prelude::PyAnyMethods::call(&v165, ((*v164).0, *(*v164).1), None),
                );
                let v171: pyo3::Bound<pyo3::PyAny> = Math::method22(v168.unwrap());
                let v174: Result<(f64, f64), pyo3::PyErr> = Math::method23(v171.extract());
                let patternInput_1: (f64, f64) = v174.unwrap();
                let v179: f64 = Math::method3(Math::method24(patternInput_1.0.clone()));
                let v180: f64 = Math::method25(patternInput_1.1.clone());
                let v184: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method26(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                        num_complex::Complex::new(v179, v180),
                    ));
                let v186: num_complex::Complex<f64> = v184.unwrap();
                let v188: num_complex::Complex<f64> = v128 * v186;
                let v189: num_complex::Complex<f64> = Math::method12(v27.clone());
                let v192: f64 = 1.0_f64 - v189.re;
                let v193: num_complex::Complex<f64> = Math::method13(v27);
                let v196: f64 = -v193.im;
                let v198: f64 = Math::method3(Math::method24(v192));
                let v199: f64 = Math::method25(v196);
                let v201: num_complex::Complex<f64> = num_complex::Complex::new(v198, v199);
                let v203: string = Math::method10(Math::method8());
                let v204: num_complex::Complex<f64> = Math::method12(v201.clone());
                let v206: f64 = v204.re;
                let v207: num_complex::Complex<f64> = Math::method13(v201);
                let v211: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    LrcPtr::new((false, LrcPtr::new((v206, v207.im))));
                let v212: pyo3::Python = Math::method14(v0_1.clone());
                let v213: string = Math::method15(v203);
                let v215: &str = fable_library_rust::String_::LrcStr::as_str(&v213);
                let v218: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                    Math::method16(pyo3::types::PyModule::from_code_bound(v212, v215, "", ""));
                let v220: pyo3::Bound<pyo3::types::PyModule> = v218.unwrap();
                let v221: string = Math::method17();
                let v223: &str = fable_library_rust::String_::LrcStr::as_str(&v221);
                let v224: pyo3::Bound<pyo3::types::PyModule> = Math::method18(v220);
                let v227: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                    Math::method19(v224.getattr(v223));
                let v229: pyo3::Bound<pyo3::PyAny> = v227.unwrap();
                let v230: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    Math::method20(v211.0.clone(), v211.1.clone());
                let v231: pyo3::Bound<pyo3::PyAny> = Math::method21(v229);
                let v234: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method19(
                    pyo3::prelude::PyAnyMethods::call(&v231, ((*v230).0, *(*v230).1), None),
                );
                let v237: pyo3::Bound<pyo3::PyAny> = Math::method22(v234.unwrap());
                let v240: Result<(f64, f64), pyo3::PyErr> = Math::method23(v237.extract());
                let patternInput_2: (f64, f64) = v240.unwrap();
                let v245: f64 = Math::method3(Math::method24(patternInput_2.0.clone()));
                let v246: f64 = Math::method25(patternInput_2.1.clone());
                let v250: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                    Math::method26(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                        num_complex::Complex::new(v245, v246),
                    ));
                let v252: num_complex::Complex<f64> = v250.unwrap();
                let v254: f64 = Math::method3(Math::method27());
                let v255: f64 = Math::method4();
                let v257: num_complex::Complex<f64> = num_complex::Complex::new(v254, v255);
                let v259: num_complex::Complex<f64> = v188 * v252;
                let v260: num_complex::Complex<f64> = Math::method12(v78.clone());
                let v262: f64 = v260.re;
                let v263: num_complex::Complex<f64> = Math::method12(v259.clone());
                let v266: f64 = v262 - v263.re;
                let v267: f64 = -v266;
                let v269: f64 = if v266 >= v267 { v266 } else { v267 };
                let v270: bool = v269 < 0.0001_f64;
                if (if v270 { true } else { Math::method28(v270) }) == false {
                    panic!(
                        "{}",
                        sprintf!("__expect / actual: {:?} / expected: {:?}", v269, 0.0001_f64),
                    );
                }
                {
                    let v275: num_complex::Complex<f64> = Math::method13(v78);
                    let v277: f64 = v275.im;
                    let v278: num_complex::Complex<f64> = Math::method13(v259);
                    let v281: f64 = v277 - v278.im;
                    let v282: f64 = -v281;
                    let v284: f64 = if v281 >= v282 { v281 } else { v282 };
                    let v285: bool = v284 < 0.0001_f64;
                    if (if v285 { true } else { Math::method28(v285) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v284, 0.0001_f64),
                        );
                    }
                    {
                        let v290: i32 = v26 + 1_i32;
                        v24.l0.set(v290);
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
                    let v28: string = Math::method10(Math::method8());
                    let v29: num_complex::Complex<f64> = Math::method12(v14.clone());
                    let v31: f64 = v29.re;
                    let v32: num_complex::Complex<f64> = Math::method13(v14);
                    let v36: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                        LrcPtr::new((false, LrcPtr::new((v31, v32.im))));
                    let v37: pyo3::Python = Math::method14(v0_1.clone());
                    let v38: string = Math::method15(v28);
                    let v40: &str = fable_library_rust::String_::LrcStr::as_str(&v38);
                    let v43: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                        Math::method16(pyo3::types::PyModule::from_code_bound(v37, v40, "", ""));
                    let v45: pyo3::Bound<pyo3::types::PyModule> = v43.unwrap();
                    let v46: string = Math::method17();
                    let v48: &str = fable_library_rust::String_::LrcStr::as_str(&v46);
                    let v49: pyo3::Bound<pyo3::types::PyModule> = Math::method18(v45);
                    let v52: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                        Math::method19(v49.getattr(v48));
                    let v54: pyo3::Bound<pyo3::PyAny> = v52.unwrap();
                    let v55: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                        Math::method20(v36.0.clone(), v36.1.clone());
                    let v56: pyo3::Bound<pyo3::PyAny> = Math::method21(v54);
                    let v59: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = Math::method19(
                        pyo3::prelude::PyAnyMethods::call(&v56, ((*v55).0, *(*v55).1), None),
                    );
                    let v62: pyo3::Bound<pyo3::PyAny> = Math::method22(v59.unwrap());
                    let v65: Result<(f64, f64), pyo3::PyErr> = Math::method23(v62.extract());
                    let patternInput: (f64, f64) = v65.unwrap();
                    let v70: f64 = Math::method3(Math::method24(patternInput.0.clone()));
                    let v71: f64 = Math::method25(patternInput.1.clone());
                    let v75: Result<num_complex::Complex<f64>, pyo3::PyErr> =
                        Math::method26(Ok::<num_complex::Complex<f64>, pyo3::PyErr>(
                            num_complex::Complex::new(v70, v71),
                        ));
                    let v77: num_complex::Complex<f64> = v75.unwrap();
                    let v79: f64 = Math::method3(Math::method27());
                    let v80: f64 = Math::method4();
                    let v82: num_complex::Complex<f64> = num_complex::Complex::new(v79, v80);
                    let v83: num_complex::Complex<f64> = Math::method12(v77.clone());
                    let v86: f64 = v83.re - v26;
                    let v87: f64 = -v86;
                    let v89: f64 = if v86 >= v87 { v86 } else { v87 };
                    let v90: bool = v89 < 0.01_f64;
                    if (if v90 { true } else { Math::method28(v90) }) == false {
                        panic!(
                            "{}",
                            sprintf!("__expect / actual: {:?} / expected: {:?}", v89, 0.01_f64),
                        );
                    }
                    {
                        let v95: num_complex::Complex<f64> = Math::method13(v77);
                        let v97: f64 = v95.im;
                        let v98: bool = v97 < 0.01_f64;
                        if (if v98 { true } else { Math::method28(v98) }) == false {
                            panic!(
                                "{}",
                                sprintf!("__expect / actual: {:?} / expected: {:?}", v97, 0.01_f64),
                            );
                        }
                        {
                            let v103: i32 = v8 + 1_i32;
                            v6.l0.set(v103);
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
