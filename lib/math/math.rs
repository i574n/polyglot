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
#![allow(unused_assignments)]
use fable_library_rust::NativeArray_::array_from;
use fable_library_rust::String_::fromString;
mod module_b7a9935b {
    pub mod Math {
        use super::*;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Native_::on_startup;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::NativeArray_::get_Count;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_init;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::replace;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toString;
        on_startup!();
        use pyo3::prelude::PyAnyMethods;
        //,);
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut0 {
            pub l0: MutCell<i32>,
        }
        impl core::fmt::Display for Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut1 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<string>,
            pub l2: MutCell<string>,
        }
        impl core::fmt::Display for Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut2 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<num_complex::Complex<f64>>,
        }
        impl core::fmt::Display for Mut2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US0 {
            US0_0(num_complex::Complex<f64>),
            US0_1,
        }
        impl core::fmt::Display for US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut3 {
            pub l0: MutCell<string>,
        }
        impl core::fmt::Display for Mut3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd)]
        pub enum UH0 {
            UH0_0,
            UH0_1(f64, LrcPtr<Math::UH0>),
        }
        impl core::fmt::Display for UH0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH1 {
            UH1_0,
            UH1_1(num_complex::Complex<f64>, LrcPtr<Math::UH1>),
        }
        impl core::fmt::Display for UH1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn method2(v0: i32, v1: LrcPtr<Math::Mut0>) -> bool {
            (v1.l0.get().clone()) < (v0)
        }
        pub fn method3(v0: num_complex::Complex<f64>) -> num_complex::Complex<f64> {
            v0
        }
        pub fn method5(v0: i32, v1: LrcPtr<Math::Mut1>) -> bool {
            (v1.l0.get().clone()) < (v0)
        }
        pub fn method6(v0: string) -> string {
            v0
        }
        pub fn method7(v0: pyo3::Python) -> pyo3::Python {
            v0
        }
        pub fn method8() -> string {
            string("fn")
        }
        pub fn method9(
            v0: pyo3::Bound<pyo3::types::PyModule>,
        ) -> pyo3::Bound<pyo3::types::PyModule> {
            v0
        }
        pub fn method10(
            v0_: bool,
            v0__1: LrcPtr<(f64, f64)>,
        ) -> LrcPtr<(bool, LrcPtr<(f64, f64)>)> {
            LrcPtr::new((v0_, v0__1))
        }
        pub fn method11(v0: pyo3::Bound<pyo3::PyAny>) -> pyo3::Bound<pyo3::PyAny> {
            v0
        }
        pub fn method12(v0: pyo3::Bound<pyo3::PyAny>) -> pyo3::Bound<pyo3::PyAny> {
            v0
        }
        pub fn method4(
            v0: pyo3::Python,
            v1: num_complex::Complex<f64>,
        ) -> Result<num_complex::Complex<f64>, std::string::String> {
            let v12: string = string(
                "            args = { k: v for k, v in frame.f_locals.items() if frame.f_code.co_name != \'make_mpc\' and k not in [\'ctx\'] and not callable(v) }",
            );
            let v13: string = string(
                "            args_str = \', \'.join([ f\"{k}={re.sub(memory_address_pattern, \' at 0x<?>\', repr(v))}\" for k, v in args.items() ])",
            );
            let v14: string = string(
                "            print(f\"{event}(__NAME__) / f_code.co_name: {frame.f_code.co_name} / f_locals: {args_str} / f_lineno: {frame.f_lineno} / f_code.co_filename: {frame.f_code.co_filename.split(\'site-packages\')[-1]} / f_back.f_lineno: { \'\' if frame.f_back is None else frame.f_back.f_lineno } / f_back.f_code.co_filename: { \'\' if frame.f_back is None else frame.f_back.f_code.co_filename.split(\'site-packages\')[-1] } / arg: {re.sub(memory_address_pattern, \' at 0x<?>\', repr(arg))}\", flush=True)",
            );
            let v33: Array<string> = new_array(&[
                string("import sys"),
                string("import traceback"),
                string("import re"),
                string("count = 0"),
                string("memory_address_pattern = re.compile(r\' at 0x[0-9a-fA-F]+\')"),
                string("def trace_calls(frame, event, arg):"),
                string("    global count"),
                string("    count += 1"),
                string("    if count < 200:"),
                string("        try:"),
                v12,
                v13,
                v14,
                string("        except ValueError as e:"),
                string("            print(f\'__NAME__ / e: {e}\', flush=True)"),
                string("        return trace_calls"),
                string("import mpmath"),
                string("def fn(log, s):"),
                string("    global count"),
                string("    if log:"),
                string("        print(f\'__NAME__ / s: {s} / count: {count}\', flush=True)"),
                string("    s = complex(*s)"),
                string("    try:"),
                string("        if log: sys.settrace(trace_calls)"),
                string("        s = mpmath.zeta(s)"),
                string("        if log:"),
                string("            sys.settrace(None)"),
                string(
                    "            print(f\'__NAME__ / result: {s} / count: {count}\', flush=True)",
                ),
                string("    except ValueError as e:"),
                string("        if s.real == 1:"),
                string("            s = complex(float(\'inf\'), 0)"),
                string("    return (s.real, s.imag)"),
            ]);
            let v34: i32 = get_Count(v33.clone());
            let v36: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                l0: MutCell::new(0_i32),
                l1: MutCell::new(string("")),
                l2: MutCell::new(string("")),
            });
            while Math::method5(v34, v36.clone()) {
                let v38: i32 = v36.l0.get().clone();
                let v41: i32 = ((v38.wrapping_neg()) + (v34)) - 1_i32;
                let matchValue: string = v36.l1.get().clone();
                let matchValue_1: string = v36.l2.get().clone();
                let v67: string =
                    append((append((v33[v41].clone()), (matchValue_1))), (matchValue));
                let v68: i32 = (v38) + 1_i32;
                v36.l0.set(v68);
                v36.l1.set(v67);
                v36.l2.set(string("\n"));
                ()
            }
            {
                let matchValue_2: string = v36.l1.get().clone();
                let matchValue_3: string = v36.l2.get().clone();
                let v98: string =
                    Math::method6(replace(matchValue_2, string("__NAME__"), string("zeta_")));
                let v139: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    LrcPtr::new((false, LrcPtr::new((v1.clone().re, v1.im))));
                let v171: pyo3::Python = Math::method7(v0);
                let v446: &str = &*v98;
                let v613: std::string::String = String::from(v446);
                let v630: std::ffi::CString = std::ffi::CString::new(v613).unwrap();
                let v633: &str = &*string("");
                let v643: std::string::String = String::from(v633);
                let v652: std::ffi::CString = std::ffi::CString::new(v643).unwrap();
                let v654: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                    pyo3::types::PyModule::from_code(v171, &v630, &v652, &v652);
                let v656: bool = true;
                let _result_map_error__ = v654.map_err(|x| {
                    //;
                    let v658: pyo3::PyErr = x;
                    let v683: std::string::String = format!("{}", v658);
                    let v700: bool = true;
                    v683
                });
                let v702: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                    _result_map_error__;
                let v704: pyo3::Bound<pyo3::types::PyModule> = v702.unwrap();
                let v705: string = Math::method8();
                let v708: &str = &*v705;
                let v716: pyo3::Bound<pyo3::types::PyModule> = Math::method9(v704);
                let v722: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v716.getattr(v708);
                let v724: bool = true;
                let _result_map_error__ = v722.map_err(|x| {
                    //;
                    let v726: pyo3::PyErr = x;
                    let v729: std::string::String = format!("{}", v726);
                    let v738: bool = true;
                    v729
                });
                let v740: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> =
                    _result_map_error__;
                let v742: pyo3::Bound<pyo3::PyAny> = v740.unwrap();
                let v743: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    Math::method10(v139.0.clone(), v139.1.clone());
                let v744: pyo3::Bound<pyo3::PyAny> = Math::method11(v742);
                let v766: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                    pyo3::prelude::PyAnyMethods::call(&v744, ((*v743).0, *(*v743).1), None);
                let v802: bool = true;
                let _result_map_error__ = v766.map_err(|x| {
                    //;
                    let v804: pyo3::PyErr = x;
                    let v807: std::string::String = format!("{}", v804);
                    let v816: bool = true;
                    v807
                });
                let v818: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> =
                    _result_map_error__;
                let v821: pyo3::Bound<pyo3::PyAny> = Math::method12(v818?);
                let v823: Result<(f64, f64), pyo3::PyErr> = v821.extract();
                let v825: bool = true;
                let _result_map_error__ = v823.map_err(|x| {
                    //;
                    let v827: pyo3::PyErr = x;
                    let v830: std::string::String = format!("{}", v827);
                    let v839: bool = true;
                    v830
                });
                let v841: Result<(f64, f64), std::string::String> = _result_map_error__;
                let patternInput_2: (f64, f64) = v841?;
                Ok::<num_complex::Complex<f64>, std::string::String>(num_complex::Complex::new(
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                ))
            }
        }
        pub fn method14(v0: LrcPtr<Math::Mut0>) -> bool {
            (v0.l0.get().clone()) < 10000_i32
        }
        pub fn method15(v0: i32, v1: LrcPtr<Math::Mut2>) -> bool {
            (v1.l0.get().clone()) < (v0)
        }
        pub fn method16(
            v0: pyo3::Python,
            v1: num_complex::Complex<f64>,
        ) -> Result<num_complex::Complex<f64>, std::string::String> {
            let v12: string = string(
                "            args = { k: v for k, v in frame.f_locals.items() if frame.f_code.co_name != \'make_mpc\' and k not in [\'ctx\'] and not callable(v) }",
            );
            let v13: string = string(
                "            args_str = \', \'.join([ f\"{k}={re.sub(memory_address_pattern, \' at 0x<?>\', repr(v))}\" for k, v in args.items() ])",
            );
            let v14: string = string(
                "            print(f\"{event}(__NAME__) / f_code.co_name: {frame.f_code.co_name} / f_locals: {args_str} / f_lineno: {frame.f_lineno} / f_code.co_filename: {frame.f_code.co_filename.split(\'site-packages\')[-1]} / f_back.f_lineno: { \'\' if frame.f_back is None else frame.f_back.f_lineno } / f_back.f_code.co_filename: { \'\' if frame.f_back is None else frame.f_back.f_code.co_filename.split(\'site-packages\')[-1] } / arg: {re.sub(memory_address_pattern, \' at 0x<?>\', repr(arg))}\", flush=True)",
            );
            let v33: Array<string> = new_array(&[
                string("import sys"),
                string("import traceback"),
                string("import re"),
                string("count = 0"),
                string("memory_address_pattern = re.compile(r\' at 0x[0-9a-fA-F]+\')"),
                string("def trace_calls(frame, event, arg):"),
                string("    global count"),
                string("    count += 1"),
                string("    if count < 200:"),
                string("        try:"),
                v12,
                v13,
                v14,
                string("        except ValueError as e:"),
                string("            print(f\'__NAME__ / e: {e}\', flush=True)"),
                string("        return trace_calls"),
                string("import mpmath"),
                string("def fn(log, s):"),
                string("    global count"),
                string("    if log:"),
                string("        print(f\'__NAME__ / s: {s} / count: {count}\', flush=True)"),
                string("    s = complex(*s)"),
                string("    try:"),
                string("        if log: sys.settrace(trace_calls)"),
                string("        s = mpmath.gamma(s)"),
                string("        if log:"),
                string("            sys.settrace(None)"),
                string(
                    "            print(f\'__NAME__ / result: {s} / count: {count}\', flush=True)",
                ),
                string("    except ValueError as e:"),
                string("        if s.real == 1:"),
                string("            s = complex(float(\'inf\'), 0)"),
                string("    return (s.real, s.imag)"),
            ]);
            let v34: i32 = get_Count(v33.clone());
            let v36: LrcPtr<Math::Mut1> = LrcPtr::new(Math::Mut1 {
                l0: MutCell::new(0_i32),
                l1: MutCell::new(string("")),
                l2: MutCell::new(string("")),
            });
            while Math::method5(v34, v36.clone()) {
                let v38: i32 = v36.l0.get().clone();
                let v41: i32 = ((v38.wrapping_neg()) + (v34)) - 1_i32;
                let matchValue: string = v36.l1.get().clone();
                let matchValue_1: string = v36.l2.get().clone();
                let v46: string =
                    append((append((v33[v41].clone()), (matchValue_1))), (matchValue));
                let v47: i32 = (v38) + 1_i32;
                v36.l0.set(v47);
                v36.l1.set(v46);
                v36.l2.set(string("\n"));
                ()
            }
            {
                let matchValue_2: string = v36.l1.get().clone();
                let matchValue_3: string = v36.l2.get().clone();
                let v67: string =
                    Math::method6(replace(matchValue_2, string("__NAME__"), string("gamma_")));
                let v73: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    LrcPtr::new((false, LrcPtr::new((v1.clone().re, v1.im))));
                let v74: pyo3::Python = Math::method7(v0);
                let v77: &str = &*v67;
                let v87: std::string::String = String::from(v77);
                let v96: std::ffi::CString = std::ffi::CString::new(v87).unwrap();
                let v99: &str = &*string("");
                let v109: std::string::String = String::from(v99);
                let v118: std::ffi::CString = std::ffi::CString::new(v109).unwrap();
                let v120: Result<pyo3::Bound<pyo3::types::PyModule>, pyo3::PyErr> =
                    pyo3::types::PyModule::from_code(v74, &v96, &v118, &v118);
                let v122: bool = true;
                let _result_map_error__ = v120.map_err(|x| {
                    //;
                    let v124: pyo3::PyErr = x;
                    let v127: std::string::String = format!("{}", v124);
                    let v136: bool = true;
                    v127
                });
                let v138: Result<pyo3::Bound<pyo3::types::PyModule>, std::string::String> =
                    _result_map_error__;
                let v140: pyo3::Bound<pyo3::types::PyModule> = v138.unwrap();
                let v141: string = Math::method8();
                let v144: &str = &*v141;
                let v152: pyo3::Bound<pyo3::types::PyModule> = Math::method9(v140);
                let v154: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> = v152.getattr(v144);
                let v156: bool = true;
                let _result_map_error__ = v154.map_err(|x| {
                    //;
                    let v158: pyo3::PyErr = x;
                    let v161: std::string::String = format!("{}", v158);
                    let v170: bool = true;
                    v161
                });
                let v172: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> =
                    _result_map_error__;
                let v174: pyo3::Bound<pyo3::PyAny> = v172.unwrap();
                let v175: LrcPtr<(bool, LrcPtr<(f64, f64)>)> =
                    Math::method10(v73.0.clone(), v73.1.clone());
                let v176: pyo3::Bound<pyo3::PyAny> = Math::method11(v174);
                let v178: Result<pyo3::Bound<pyo3::PyAny>, pyo3::PyErr> =
                    pyo3::prelude::PyAnyMethods::call(&v176, ((*v175).0, *(*v175).1), None);
                let v180: bool = true;
                let _result_map_error__ = v178.map_err(|x| {
                    //;
                    let v182: pyo3::PyErr = x;
                    let v185: std::string::String = format!("{}", v182);
                    let v194: bool = true;
                    v185
                });
                let v196: Result<pyo3::Bound<pyo3::PyAny>, std::string::String> =
                    _result_map_error__;
                let v199: pyo3::Bound<pyo3::PyAny> = Math::method12(v196?);
                let v201: Result<(f64, f64), pyo3::PyErr> = v199.extract();
                let v203: bool = true;
                let _result_map_error__ = v201.map_err(|x| {
                    //;
                    let v205: pyo3::PyErr = x;
                    let v208: std::string::String = format!("{}", v205);
                    let v217: bool = true;
                    v208
                });
                let v219: Result<(f64, f64), std::string::String> = _result_map_error__;
                let patternInput_2: (f64, f64) = v219?;
                Ok::<num_complex::Complex<f64>, std::string::String>(num_complex::Complex::new(
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                ))
            }
        }
        pub fn closure1(unitVar: (), v0: num_complex::Complex<f64>) -> Math::US0 {
            Math::US0::US0_0(v0)
        }
        pub fn method17() -> Func1<num_complex::Complex<f64>, Math::US0> {
            Func1::new(move |v: num_complex::Complex<f64>| Math::closure1((), v))
        }
        pub fn method13(
            v0: pyo3::Python,
            v1: num_complex::Complex<f64>,
        ) -> num_complex::Complex<f64> {
            println!("zeta / count: {:?} / s: {:?}", 0_i32, v1.clone());
            if (v1.clone().re) > 1.0_f64 {
                let v7_1: num_complex::Complex<f64> = num_complex::Complex::new(0.0_f64, 0.0_f64);
                let v8: Array<i32> = new_init(&0_i32, 10000_i32);
                let v9: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                    l0: MutCell::new(0_i32),
                });
                while Math::method14(v9.clone()) {
                    let v11: i32 = v9.l0.get().clone();
                    v8.get_mut()[v11 as usize] = v11;
                    {
                        let v12: i32 = (v11) + 1_i32;
                        v9.l0.set(v12);
                        ()
                    }
                }
                {
                    let v13: i32 = get_Count(v8.clone());
                    let v14: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                        l0: MutCell::new(0_i32),
                        l1: MutCell::new(v7_1),
                    });
                    while Math::method15(v13, v14.clone()) {
                        let v16: i32 = v14.l0.get().clone();
                        let v17: num_complex::Complex<f64> = v14.l1.get().clone();
                        let v18: i32 = v8[v16].clone();
                        let v20: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v24: f64 = v18 as f64;
                        let v55: num_complex::Complex<f64> =
                            num_complex::Complex::new(v24, 0.0_f64);
                        let v57: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v55, v1.clone());
                        let v59: num_complex::Complex<f64> = v20 / v57;
                        let v61: num_complex::Complex<f64> = v17 + v59;
                        let v62: i32 = (v16) + 1_i32;
                        v14.l0.set(v62);
                        v14.l1.set(v61);
                        ()
                    }
                    v14.l1.get().clone()
                }
            } else {
                let v65: num_complex::Complex<f64> = num_complex::Complex::new(1.0_f64, 0.0_f64);
                let v69: Result<num_complex::Complex<f64>, std::string::String> =
                    Math::method16(v0.clone(), Math::method3(v65 - v1.clone()));
                let v74: Option<num_complex::Complex<f64>> = v69.ok();
                let v178: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v74));
                let v202: f64 = f64::NAN;
                let v204: f64 = f64::NAN;
                let v206: num_complex::Complex<f64> = num_complex::Complex::new(v202, v204);
                let v209: num_complex::Complex<f64> = match &v178 {
                    Math::US0::US0_0(v178_0_0) => match &v178 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v206.clone(),
                };
                let v211: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v213: num_complex::Complex<f64> = v211 * v1.clone();
                let v215: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v217: num_complex::Complex<f64> = v213 / v215;
                let v219: num_complex::Complex<f64> = v217.sin();
                let v222: f64 = 1.0_f64 - (v1.clone().re);
                let v225: f64 = -v1.clone().im;
                let v227: num_complex::Complex<f64> = num_complex::Complex::new(v222, v225);
                let v629: num_complex::Complex<f64> = if (v227.clone().re) <= 1.0_f64 {
                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                } else {
                    println!("zeta / count: {:?} / s: {:?}", 1_i32, v227.clone());
                    if (v227.clone().re) > 1.0_f64 {
                        let v238: num_complex::Complex<f64> =
                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                        let v239: Array<i32> = new_init(&0_i32, 10000_i32);
                        let v240: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                            l0: MutCell::new(0_i32),
                        });
                        while Math::method14(v240.clone()) {
                            let v242: i32 = v240.l0.get().clone();
                            v239.get_mut()[v242 as usize] = v242;
                            {
                                let v243: i32 = (v242) + 1_i32;
                                v240.l0.set(v243);
                                ()
                            }
                        }
                        {
                            let v244: i32 = get_Count(v239.clone());
                            let v245: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                l0: MutCell::new(0_i32),
                                l1: MutCell::new(v238),
                            });
                            while Math::method15(v244, v245.clone()) {
                                let v247: i32 = v245.l0.get().clone();
                                let v248: num_complex::Complex<f64> = v245.l1.get().clone();
                                let v249: i32 = v239[v247].clone();
                                let v251: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v253: f64 = v249 as f64;
                                let v255: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v253, 0.0_f64);
                                let v257: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v255, v227.clone());
                                let v259: num_complex::Complex<f64> = v251 / v257;
                                let v261: num_complex::Complex<f64> = v248 + v259;
                                let v262: i32 = (v247) + 1_i32;
                                v245.l0.set(v262);
                                v245.l1.set(v261);
                                ()
                            }
                            v245.l1.get().clone()
                        }
                    } else {
                        let v265: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v269: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method16(v0.clone(), Math::method3(v265 - v227.clone()));
                        let v272: Option<num_complex::Complex<f64>> = v269.ok();
                        let v283: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v272));
                        let v285: f64 = f64::NAN;
                        let v287: f64 = f64::NAN;
                        let v289: num_complex::Complex<f64> = num_complex::Complex::new(v285, v287);
                        let v292: num_complex::Complex<f64> = match &v283 {
                            Math::US0::US0_0(v283_0_0) => match &v283 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v289.clone(),
                        };
                        let v294: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v296: num_complex::Complex<f64> = v294 * v227.clone();
                        let v298: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v300: num_complex::Complex<f64> = v296 / v298;
                        let v302: num_complex::Complex<f64> = v300.sin();
                        let v305: f64 = 1.0_f64 - (v227.clone().re);
                        let v308: f64 = -v227.clone().im;
                        let v310: num_complex::Complex<f64> = num_complex::Complex::new(v305, v308);
                        let v613: num_complex::Complex<f64> = if (v310.clone().re) <= 1.0_f64 {
                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                        } else {
                            println!("zeta / count: {:?} / s: {:?}", 2_i32, v310.clone());
                            if (v310.clone().re) > 1.0_f64 {
                                let v321: num_complex::Complex<f64> =
                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                let v322: Array<i32> = new_init(&0_i32, 10000_i32);
                                let v323: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Math::method14(v323.clone()) {
                                    let v325: i32 = v323.l0.get().clone();
                                    v322.get_mut()[v325 as usize] = v325;
                                    {
                                        let v326: i32 = (v325) + 1_i32;
                                        v323.l0.set(v326);
                                        ()
                                    }
                                }
                                {
                                    let v327: i32 = get_Count(v322.clone());
                                    let v328: LrcPtr<Math::Mut2> = LrcPtr::new(Math::Mut2 {
                                        l0: MutCell::new(0_i32),
                                        l1: MutCell::new(v321),
                                    });
                                    while Math::method15(v327, v328.clone()) {
                                        let v330: i32 = v328.l0.get().clone();
                                        let v331: num_complex::Complex<f64> = v328.l1.get().clone();
                                        let v332: i32 = v322[v330].clone();
                                        let v334: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v336: f64 = v332 as f64;
                                        let v338: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v336, 0.0_f64);
                                        let v340: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v338, v310.clone());
                                        let v342: num_complex::Complex<f64> = v334 / v340;
                                        let v344: num_complex::Complex<f64> = v331 + v342;
                                        let v345: i32 = (v330) + 1_i32;
                                        v328.l0.set(v345);
                                        v328.l1.set(v344);
                                        ()
                                    }
                                    v328.l1.get().clone()
                                }
                            } else {
                                let v348: num_complex::Complex<f64> =
                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                let v352: Result<num_complex::Complex<f64>, std::string::String> =
                                    Math::method16(v0.clone(), Math::method3(v348 - v310.clone()));
                                let v355: Option<num_complex::Complex<f64>> = v352.ok();
                                let v366: Math::US0 =
                                    defaultValue(Math::US0::US0_1, map(Math::method17(), v355));
                                let v368: f64 = f64::NAN;
                                let v370: f64 = f64::NAN;
                                let v372: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v368, v370);
                                let v375: num_complex::Complex<f64> = match &v366 {
                                    Math::US0::US0_0(v366_0_0) => match &v366 {
                                        Math::US0::US0_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                    _ => v372.clone(),
                                };
                                let v377: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v379: num_complex::Complex<f64> = v377 * v310.clone();
                                let v381: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v383: num_complex::Complex<f64> = v379 / v381;
                                let v385: num_complex::Complex<f64> = v383.sin();
                                let v388: f64 = 1.0_f64 - (v310.clone().re);
                                let v391: f64 = -v310.clone().im;
                                let v393: num_complex::Complex<f64> =
                                    num_complex::Complex::new(v388, v391);
                                let v597: num_complex::Complex<f64> = if (v393.clone().re)
                                    <= 1.0_f64
                                {
                                    num_complex::Complex::new(0.0_f64, 0.0_f64)
                                } else {
                                    println!("zeta / count: {:?} / s: {:?}", 3_i32, v393.clone());
                                    if (v393.clone().re) > 1.0_f64 {
                                        let v404: num_complex::Complex<f64> =
                                            num_complex::Complex::new(0.0_f64, 0.0_f64);
                                        let v405: Array<i32> = new_init(&0_i32, 10000_i32);
                                        let v406: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                                            l0: MutCell::new(0_i32),
                                        });
                                        while Math::method14(v406.clone()) {
                                            let v408: i32 = v406.l0.get().clone();
                                            v405.get_mut()[v408 as usize] = v408;
                                            {
                                                let v409: i32 = (v408) + 1_i32;
                                                v406.l0.set(v409);
                                                ()
                                            }
                                        }
                                        {
                                            let v410: i32 = get_Count(v405.clone());
                                            let v411: LrcPtr<Math::Mut2> =
                                                LrcPtr::new(Math::Mut2 {
                                                    l0: MutCell::new(0_i32),
                                                    l1: MutCell::new(v404),
                                                });
                                            while Math::method15(v410, v411.clone()) {
                                                let v413: i32 = v411.l0.get().clone();
                                                let v414: num_complex::Complex<f64> =
                                                    v411.l1.get().clone();
                                                let v415: i32 = v405[v413].clone();
                                                let v417: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v419: f64 = v415 as f64;
                                                let v421: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v419, 0.0_f64);
                                                let v423: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v421, v393.clone());
                                                let v425: num_complex::Complex<f64> = v417 / v423;
                                                let v427: num_complex::Complex<f64> = v414 + v425;
                                                let v428: i32 = (v413) + 1_i32;
                                                v411.l0.set(v428);
                                                v411.l1.set(v427);
                                                ()
                                            }
                                            v411.l1.get().clone()
                                        }
                                    } else {
                                        let v431: num_complex::Complex<f64> =
                                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                                        let v435: Result<
                                            num_complex::Complex<f64>,
                                            std::string::String,
                                        > = Math::method16(
                                            v0.clone(),
                                            Math::method3(v431 - v393.clone()),
                                        );
                                        let v438: Option<num_complex::Complex<f64>> = v435.ok();
                                        let v449: Math::US0 = defaultValue(
                                            Math::US0::US0_1,
                                            map(Math::method17(), v438),
                                        );
                                        let v451: f64 = f64::NAN;
                                        let v453: f64 = f64::NAN;
                                        let v455: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v451, v453);
                                        let v458: num_complex::Complex<f64> = match &v449 {
                                            Math::US0::US0_0(v449_0_0) => match &v449 {
                                                Math::US0::US0_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                            _ => v455.clone(),
                                        };
                                        let v460: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v462: num_complex::Complex<f64> = v460 * v393.clone();
                                        let v464: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v466: num_complex::Complex<f64> = v462 / v464;
                                        let v468: num_complex::Complex<f64> = v466.sin();
                                        let v471: f64 = 1.0_f64 - (v393.clone().re);
                                        let v474: f64 = -v393.clone().im;
                                        let v476: num_complex::Complex<f64> =
                                            num_complex::Complex::new(v471, v474);
                                        let v581: num_complex::Complex<f64> = if (v476.clone().re)
                                            <= 1.0_f64
                                        {
                                            num_complex::Complex::new(0.0_f64, 0.0_f64)
                                        } else {
                                            println!(
                                                "zeta / count: {:?} / s: {:?}",
                                                4_i32,
                                                v476.clone()
                                            );
                                            if (v476.clone().re) > 1.0_f64 {
                                                let v487: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(0.0_f64, 0.0_f64);
                                                let v488: Array<i32> = new_init(&0_i32, 10000_i32);
                                                let v489: LrcPtr<Math::Mut0> =
                                                    LrcPtr::new(Math::Mut0 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Math::method14(v489.clone()) {
                                                    let v491: i32 = v489.l0.get().clone();
                                                    v488.get_mut()[v491 as usize] = v491;
                                                    {
                                                        let v492: i32 = (v491) + 1_i32;
                                                        v489.l0.set(v492);
                                                        ()
                                                    }
                                                }
                                                {
                                                    let v493: i32 = get_Count(v488.clone());
                                                    let v494: LrcPtr<Math::Mut2> =
                                                        LrcPtr::new(Math::Mut2 {
                                                            l0: MutCell::new(0_i32),
                                                            l1: MutCell::new(v487),
                                                        });
                                                    while Math::method15(v493, v494.clone()) {
                                                        let v496: i32 = v494.l0.get().clone();
                                                        let v497: num_complex::Complex<f64> =
                                                            v494.l1.get().clone();
                                                        let v498: i32 = v488[v496].clone();
                                                        let v500: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                1.0_f64, 0.0_f64,
                                                            );
                                                        let v502: f64 = v498 as f64;
                                                        let v504: num_complex::Complex<f64> =
                                                            num_complex::Complex::new(
                                                                v502, 0.0_f64,
                                                            );
                                                        let v506: num_complex::Complex<f64> =
                                                            num_complex::Complex::powc(
                                                                v504,
                                                                v476.clone(),
                                                            );
                                                        let v508: num_complex::Complex<f64> =
                                                            v500 / v506;
                                                        let v510: num_complex::Complex<f64> =
                                                            v497 + v508;
                                                        let v511: i32 = (v496) + 1_i32;
                                                        v494.l0.set(v511);
                                                        v494.l1.set(v510);
                                                        ()
                                                    }
                                                    v494.l1.get().clone()
                                                }
                                            } else {
                                                let v514: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(1.0_f64, 0.0_f64);
                                                let v518: Result<
                                                    num_complex::Complex<f64>,
                                                    std::string::String,
                                                > = Math::method16(
                                                    v0,
                                                    Math::method3(v514 - v476.clone()),
                                                );
                                                let v521: Option<num_complex::Complex<f64>> =
                                                    v518.ok();
                                                let v532: Math::US0 = defaultValue(
                                                    Math::US0::US0_1,
                                                    map(Math::method17(), v521),
                                                );
                                                let v534: f64 = f64::NAN;
                                                let v536: f64 = f64::NAN;
                                                let v538: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v534, v536);
                                                let v541: num_complex::Complex<f64> = match &v532 {
                                                    Math::US0::US0_0(v532_0_0) => match &v532 {
                                                        Math::US0::US0_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                    _ => v538.clone(),
                                                };
                                                let v543: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(
                                                        3.141592653589793_f64,
                                                        0.0_f64,
                                                    );
                                                let v545: num_complex::Complex<f64> =
                                                    v543 * v476.clone();
                                                let v547: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                let v549: num_complex::Complex<f64> = v545 / v547;
                                                let v551: num_complex::Complex<f64> = v549.sin();
                                                let v554: f64 = 1.0_f64 - (v476.clone().re);
                                                let v557: f64 = -v476.clone().im;
                                                let v559: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(v554, v557);
                                                let v565: num_complex::Complex<f64> =
                                                    if (v559.clone().re) <= 1.0_f64 {
                                                        num_complex::Complex::new(0.0_f64, 0.0_f64)
                                                    } else {
                                                        v559
                                                    };
                                                let v567: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                                let v569: num_complex::Complex<f64> =
                                                    num_complex::Complex::new(
                                                        3.141592653589793_f64,
                                                        0.0_f64,
                                                    );
                                                let v571: num_complex::Complex<f64> =
                                                    num_complex::Complex::powc(v569, v476.clone());
                                                let v573: num_complex::Complex<f64> = v567 * v571;
                                                let v575: num_complex::Complex<f64> = v573 * v551;
                                                let v577: num_complex::Complex<f64> = v575 * v541;
                                                v577 * v565
                                            }
                                        };
                                        let v583: num_complex::Complex<f64> =
                                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                                        let v585: num_complex::Complex<f64> =
                                            num_complex::Complex::new(
                                                3.141592653589793_f64,
                                                0.0_f64,
                                            );
                                        let v587: num_complex::Complex<f64> =
                                            num_complex::Complex::powc(v585, v393.clone());
                                        let v589: num_complex::Complex<f64> = v583 * v587;
                                        let v591: num_complex::Complex<f64> = v589 * v468;
                                        let v593: num_complex::Complex<f64> = v591 * v458;
                                        v593 * v581
                                    }
                                };
                                let v599: num_complex::Complex<f64> =
                                    num_complex::Complex::new(2.0_f64, 0.0_f64);
                                let v601: num_complex::Complex<f64> =
                                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                                let v603: num_complex::Complex<f64> =
                                    num_complex::Complex::powc(v601, v310.clone());
                                let v605: num_complex::Complex<f64> = v599 * v603;
                                let v607: num_complex::Complex<f64> = v605 * v385;
                                let v609: num_complex::Complex<f64> = v607 * v375;
                                v609 * v597
                            }
                        };
                        let v615: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v617: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v619: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v617, v227.clone());
                        let v621: num_complex::Complex<f64> = v615 * v619;
                        let v623: num_complex::Complex<f64> = v621 * v302;
                        let v625: num_complex::Complex<f64> = v623 * v292;
                        v625 * v613
                    }
                };
                let v631: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 0.0_f64);
                let v633: num_complex::Complex<f64> =
                    num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                let v635: num_complex::Complex<f64> = num_complex::Complex::powc(v633, v1.clone());
                let v637: num_complex::Complex<f64> = v631 * v635;
                let v639: num_complex::Complex<f64> = v637 * v219;
                let v641: num_complex::Complex<f64> = v639 * v209;
                v641 * v629
            }
        }
        pub fn method18(v0: bool) -> bool {
            v0
        }
        pub fn method20() -> string {
            string("")
        }
        pub fn method21(v0: LrcPtr<Math::Mut3>) {
            let v3: string = append((v0.l0.get().clone()), string("{ "));
            v0.l0.set(v3);
            ()
        }
        pub fn method22(v0: LrcPtr<Math::Mut3>) {
            let v3: string = append((v0.l0.get().clone()), string("expected"));
            v0.l0.set(v3);
            ()
        }
        pub fn method23(v0: LrcPtr<Math::Mut3>) {
            let v3: string = append((v0.l0.get().clone()), string(" = "));
            v0.l0.set(v3);
            ()
        }
        pub fn method24(v0: LrcPtr<Math::Mut3>, v1: string) {
            let v3: string = append((v0.l0.get().clone()), (v1));
            v0.l0.set(v3);
            ()
        }
        pub fn method25(v0: LrcPtr<Math::Mut3>) {
            let v3: string = append((v0.l0.get().clone()), string(" }"));
            v0.l0.set(v3);
            ()
        }
        pub fn method19(v0: f64) -> string {
            let v6_1: LrcPtr<Math::Mut3> = LrcPtr::new(Math::Mut3 {
                l0: MutCell::new(Math::method20()),
            });
            Math::method21(v6_1.clone());
            Math::method22(v6_1.clone());
            Math::method23(v6_1.clone());
            Math::method24(v6_1.clone(), sprintf!("{:+.6}", v0));
            Math::method25(v6_1.clone());
            v6_1.l0.get().clone()
        }
        pub fn method27(v0: LrcPtr<Math::Mut3>) {
            let v3: string = append((v0.l0.get().clone()), string("actual"));
            v0.l0.set(v3);
            ()
        }
        pub fn method28(v0: LrcPtr<Math::Mut3>) {
            let v3: string = append((v0.l0.get().clone()), string("; "));
            v0.l0.set(v3);
            ()
        }
        pub fn method26(v0: f64, v1: f64) -> string {
            let v3: LrcPtr<Math::Mut3> = LrcPtr::new(Math::Mut3 {
                l0: MutCell::new(Math::method20()),
            });
            Math::method21(v3.clone());
            Math::method27(v3.clone());
            Math::method23(v3.clone());
            Math::method24(v3.clone(), sprintf!("{:+.6}", v0));
            Math::method28(v3.clone());
            Math::method22(v3.clone());
            Math::method23(v3.clone());
            Math::method24(v3.clone(), sprintf!("{:+.6}", v1));
            Math::method25(v3.clone());
            v3.l0.get().clone()
        }
        pub fn closure2(v0: string, unitVar: ()) {
            printfn!("{0}", v0);
        }
        pub fn method1(v0: pyo3::Python) {
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
            let v6_1: i32 = get_Count(v5.clone());
            let v7_1: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method2(v6_1, v7_1.clone()) {
                let v9: i32 = v7_1.l0.get().clone();
                let patternInput: (num_complex::Complex<f64>, f64) = v5[v9].clone();
                let v10: num_complex::Complex<f64> = patternInput.0.clone();
                let v13: Result<num_complex::Complex<f64>, std::string::String> =
                    Math::method4(v0.clone(), Math::method3(v10.clone()));
                let v14: num_complex::Complex<f64> = Math::method13(v0.clone(), v10);
                let v17: Option<num_complex::Complex<f64>> = v13.ok();
                let v28: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v17));
                let v30: f64 = f64::NAN;
                let v32: f64 = f64::NAN;
                let v34: num_complex::Complex<f64> = num_complex::Complex::new(v30, v32);
                let v37: num_complex::Complex<f64> = match &v28 {
                    Math::US0::US0_0(v28_0_0) => match &v28 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v34.clone(),
                };
                let v39: f64 = v37.clone().im;
                let v40: bool = (v39) == 0.0_f64;
                let v42: bool = if v40 { true } else { Math::method18(v40) };
                let v47: string = if v40 {
                    Math::method19(0.0_f64)
                } else {
                    Math::method26(v39, 0.0_f64)
                };
                let v69: string = append(
                    string("__assert_eq "),
                    (if v40 {
                        Math::method19(0.0_f64)
                    } else {
                        Math::method26(v39, 0.0_f64)
                    }),
                );
                let v74: () = {
                    Math::closure2(v69.clone(), ());
                    ()
                };
                if (v42) == false {
                    panic!("{}", v69,);
                }
                {
                    let v85: f64 = (v37.re) - (patternInput.1.clone());
                    let v86: f64 = -v85;
                    let v88: f64 = if (v85) >= (v86) { v85 } else { v86 };
                    let v89: bool = (v88) < 0.0001_f64;
                    let v91: bool = if v89 { true } else { Math::method18(v89) };
                    let v96: string = if v89 {
                        Math::method19(0.0001_f64)
                    } else {
                        Math::method26(v88, 0.0001_f64)
                    };
                    let v115: string = append(
                        string("__assert_lt "),
                        (if v89 {
                            Math::method19(0.0001_f64)
                        } else {
                            Math::method26(v88, 0.0001_f64)
                        }),
                    );
                    let v118: () = {
                        Math::closure2(v115.clone(), ());
                        ()
                    };
                    if (v91) == false {
                        panic!("{}", v115,);
                    }
                    {
                        let v120: i32 = (v9) + 1_i32;
                        v7_1.l0.set(v120);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method29(v0: Result<(), pyo3::PyErr>) -> Result<(), pyo3::PyErr> {
            v0
        }
        pub fn method0() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method1(py);
                {
                    let v53: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v100: string = string("}}");
                    let v102: string = string("{");
                    let v107: bool = true;
                    let _fix_closure_v104 = v53;
                    let v113: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v104 "), (v100))),
                                string("); "),
                            )),
                            (v102),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v114: bool = true;
                    _fix_closure_v104
                }
            });
            {
                // rust.fix_closure';
                let v145: Result<(), pyo3::PyErr> = __run_test;
                v145.unwrap();
                ()
            }
        }
        pub fn method31(v0: pyo3::Python) {
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, -2.0_f64);
            let v4: Result<num_complex::Complex<f64>, std::string::String> =
                Math::method4(v0.clone(), Math::method3(v2.clone()));
            let v5: num_complex::Complex<f64> = Math::method13(v0, v2);
            let v8: Option<num_complex::Complex<f64>> = v4.ok();
            let v19: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v8));
            let v21: f64 = f64::NAN;
            let v23: f64 = f64::NAN;
            let v25: num_complex::Complex<f64> = num_complex::Complex::new(v21, v23);
            let v28: num_complex::Complex<f64> = match &v19 {
                Math::US0::US0_0(v19_0_0) => match &v19 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v25.clone(),
            };
            let v31: f64 = (v28.clone().re) - 0.8673_f64;
            let v32: f64 = -v31;
            let v34: f64 = if (v31) >= (v32) { v31 } else { v32 };
            let v35: bool = (v34) < 0.001_f64;
            let v37: bool = if v35 { true } else { Math::method18(v35) };
            let v42: string = if v35 {
                Math::method19(0.001_f64)
            } else {
                Math::method26(v34, 0.001_f64)
            };
            let v51: string = append(
                string("__assert_lt "),
                (if v35 {
                    Math::method19(0.001_f64)
                } else {
                    Math::method26(v34, 0.001_f64)
                }),
            );
            let v54: () = {
                Math::closure2(v51.clone(), ());
                ()
            };
            if (v37) == false {
                panic!("{}", v51,);
            }
            {
                let v58: f64 = (v28.im) - 0.275_f64;
                let v59: f64 = -v58;
                let v61: f64 = if (v58) >= (v59) { v58 } else { v59 };
                let v62: bool = (v61) < 0.001_f64;
                let v64: bool = if v62 { true } else { Math::method18(v62) };
                let v69: string = if v62 {
                    Math::method19(0.001_f64)
                } else {
                    Math::method26(v61, 0.001_f64)
                };
                let v76: string = append(
                    string("__assert_lt "),
                    (if v62 {
                        Math::method19(0.001_f64)
                    } else {
                        Math::method26(v61, 0.001_f64)
                    }),
                );
                let v79: () = {
                    Math::closure2(v76.clone(), ());
                    ()
                };
                if (v64) == false {
                    panic!("{}", v76,);
                }
            }
        }
        pub fn method30() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method31(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v22: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v23: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v25: Result<(), pyo3::PyErr> = __run_test;
                v25.unwrap();
                ()
            }
        }
        pub fn method34() -> LrcPtr<Math::UH0> {
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
        pub fn method35(v0: pyo3::Python, v1: LrcPtr<Math::UH0>) {
            let v0: MutCell<pyo3::Python> = MutCell::new(v0.clone());
            let v1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1.clone());
            '_method35: loop {
                break '_method35 (match v1.get().clone().as_ref() {
                    Math::UH0::UH0_0 => (),
                    Math::UH0::UH0_1(v1_1_0, v1_1_1) => {
                        let v5: num_complex::Complex<f64> = num_complex::Complex::new(
                            match v1.get().clone().as_ref() {
                                Math::UH0::UH0_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            },
                            0.0_f64,
                        );
                        let v7_1: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(v0.get().clone(), Math::method3(v5.clone()));
                        let v8: num_complex::Complex<f64> = Math::method13(v0.get().clone(), v5);
                        let v11: Option<num_complex::Complex<f64>> = v7_1.ok();
                        let v22: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v11));
                        let v24: f64 = f64::NAN;
                        let v26: f64 = f64::NAN;
                        let v28: num_complex::Complex<f64> = num_complex::Complex::new(v24, v26);
                        let v31: num_complex::Complex<f64> = match &v22 {
                            Math::US0::US0_0(v22_0_0) => match &v22 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v28.clone(),
                        };
                        let v33: f64 = v31.clone().re;
                        let v34: bool = (v33) == 0.0_f64;
                        let v36: bool = if v34 { true } else { Math::method18(v34) };
                        let v41: string = if v34 {
                            Math::method19(0.0_f64)
                        } else {
                            Math::method26(v33, 0.0_f64)
                        };
                        let v50: string = append(
                            string("__assert_eq "),
                            (if v34 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v33, 0.0_f64)
                            }),
                        );
                        let v53: () = {
                            Math::closure2(v50.clone(), ());
                            ()
                        };
                        if (v36) == false {
                            panic!("{}", v50,);
                        }
                        {
                            let v56: f64 = v31.im;
                            let v57: bool = (v56) == 0.0_f64;
                            let v59: bool = if v57 { true } else { Math::method18(v57) };
                            let v64: string = if v57 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v56, 0.0_f64)
                            };
                            let v71: string = append(
                                string("__assert_eq "),
                                (if v57 {
                                    Math::method19(0.0_f64)
                                } else {
                                    Math::method26(v56, 0.0_f64)
                                }),
                            );
                            let v74: () = {
                                Math::closure2(v71.clone(), ());
                                ()
                            };
                            if (v59) == false {
                                panic!("{}", v71,);
                            }
                            {
                                let v0_temp: pyo3::Python = v0.get().clone();
                                let v1_temp: LrcPtr<Math::UH0> = match v1.get().clone().as_ref() {
                                    Math::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
                                v0.set(v0_temp);
                                v1.set(v1_temp);
                                continue '_method35;
                            }
                        }
                    }
                });
            }
        }
        pub fn method33(v0: pyo3::Python) {
            Math::method35(v0, Math::method34());
        }
        pub fn method32() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method33(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v22: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v23: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v25: Result<(), pyo3::PyErr> = __run_test;
                v25.unwrap();
                ()
            }
        }
        pub fn method37(v0: pyo3::Python) {
            let v13: Array<num_complex::Complex<f64>> = new_array(&[
                num_complex::Complex::new(0.5_f64, 14.134725_f64),
                num_complex::Complex::new(0.5_f64, 21.02204_f64),
                num_complex::Complex::new(0.5_f64, 25.010857_f64),
                num_complex::Complex::new(0.5_f64, 30.424876_f64),
                num_complex::Complex::new(0.5_f64, 32.935062_f64),
                num_complex::Complex::new(0.5_f64, 37.586178_f64),
            ]);
            let v14: i32 = get_Count(v13.clone());
            let v15: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method2(v14, v15.clone()) {
                let v17: i32 = v15.l0.get().clone();
                let v18: num_complex::Complex<f64> = v13[v17].clone();
                let v20: Result<num_complex::Complex<f64>, std::string::String> =
                    Math::method4(v0.clone(), Math::method3(v18.clone()));
                let v21: num_complex::Complex<f64> = Math::method13(v0.clone(), v18);
                let v24: Option<num_complex::Complex<f64>> = v20.ok();
                let v35: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v24));
                let v37: f64 = f64::NAN;
                let v39: f64 = f64::NAN;
                let v41: num_complex::Complex<f64> = num_complex::Complex::new(v37, v39);
                let v44: num_complex::Complex<f64> = match &v35 {
                    Math::US0::US0_0(v35_0_0) => match &v35 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v41.clone(),
                };
                let v46: f64 = v44.clone().re;
                let v47: f64 = -v46;
                let v49: f64 = if (v46) >= (v47) { v46 } else { v47 };
                let v50: bool = (v49) < 0.0001_f64;
                let v52: bool = if v50 { true } else { Math::method18(v50) };
                let v57: string = if v50 {
                    Math::method19(0.0001_f64)
                } else {
                    Math::method26(v49, 0.0001_f64)
                };
                let v66: string = append(
                    string("__assert_lt "),
                    (if v50 {
                        Math::method19(0.0001_f64)
                    } else {
                        Math::method26(v49, 0.0001_f64)
                    }),
                );
                let v69: () = {
                    Math::closure2(v66.clone(), ());
                    ()
                };
                if (v52) == false {
                    panic!("{}", v66,);
                }
                {
                    let v72: f64 = v44.im;
                    let v73: f64 = -v72;
                    let v75: f64 = if (v72) >= (v73) { v72 } else { v73 };
                    let v76: bool = (v75) < 0.0001_f64;
                    let v78: bool = if v76 { true } else { Math::method18(v76) };
                    let v83: string = if v76 {
                        Math::method19(0.0001_f64)
                    } else {
                        Math::method26(v75, 0.0001_f64)
                    };
                    let v90: string = append(
                        string("__assert_lt "),
                        (if v76 {
                            Math::method19(0.0001_f64)
                        } else {
                            Math::method26(v75, 0.0001_f64)
                        }),
                    );
                    let v93: () = {
                        Math::closure2(v90.clone(), ());
                        ()
                    };
                    if (v78) == false {
                        panic!("{}", v90,);
                    }
                    {
                        let v95: i32 = (v17) + 1_i32;
                        v15.l0.set(v95);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method36() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method37(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v22: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v23: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v25: Result<(), pyo3::PyErr> = __run_test;
                v25.unwrap();
                ()
            }
        }
        pub fn method39(v0: pyo3::Python) {
            let v1: Array<f64> = new_array(&[
                2.0_f64, 3.0_f64, 4.0_f64, 5.0_f64, 10.0_f64, 20.0_f64, 50.0_f64,
            ]);
            let v2: i32 = get_Count(v1.clone());
            let v3: LrcPtr<Math::Mut0> = LrcPtr::new(Math::Mut0 {
                l0: MutCell::new(0_i32),
            });
            while Math::method2(v2, v3.clone()) {
                let v5: i32 = v3.l0.get().clone();
                let v6_1: f64 = v1[v5].clone();
                let v8: num_complex::Complex<f64> = num_complex::Complex::new(v6_1, 0.0_f64);
                let v10: Result<num_complex::Complex<f64>, std::string::String> =
                    Math::method4(v0.clone(), Math::method3(v8.clone()));
                let v11: num_complex::Complex<f64> = Math::method13(v0.clone(), v8);
                let v14: Option<num_complex::Complex<f64>> = v10.ok();
                let v25: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v14));
                let v27: f64 = f64::NAN;
                let v29: f64 = f64::NAN;
                let v31: num_complex::Complex<f64> = num_complex::Complex::new(v27, v29);
                let v34: num_complex::Complex<f64> = match &v25 {
                    Math::US0::US0_0(v25_0_0) => match &v25 {
                        Math::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v31.clone(),
                };
                let v36: f64 = v34.clone().re;
                let v37: bool = (v36) > 0.0_f64;
                let v39: bool = if v37 { true } else { Math::method18(v37) };
                let v44: string = if v37 {
                    Math::method19(0.0_f64)
                } else {
                    Math::method26(v36, 0.0_f64)
                };
                let v66: string = append(
                    string("__assert_gt "),
                    (if v37 {
                        Math::method19(0.0_f64)
                    } else {
                        Math::method26(v36, 0.0_f64)
                    }),
                );
                let v69: () = {
                    Math::closure2(v66.clone(), ());
                    ()
                };
                if (v39) == false {
                    panic!("{}", v66,);
                }
                {
                    let v72: f64 = v34.im;
                    let v73: bool = (v72) == 0.0_f64;
                    let v75: bool = if v73 { true } else { Math::method18(v73) };
                    let v80: string = if v73 {
                        Math::method19(0.0_f64)
                    } else {
                        Math::method26(v72, 0.0_f64)
                    };
                    let v88: string = append(
                        string("__assert_eq "),
                        (if v73 {
                            Math::method19(0.0_f64)
                        } else {
                            Math::method26(v72, 0.0_f64)
                        }),
                    );
                    let v91: () = {
                        Math::closure2(v88.clone(), ());
                        ()
                    };
                    if (v75) == false {
                        panic!("{}", v88,);
                    }
                    {
                        let v93: i32 = (v5) + 1_i32;
                        v3.l0.set(v93);
                        ()
                    }
                }
            }
            ()
        }
        pub fn method38() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method39(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v22: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v23: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v25: Result<(), pyo3::PyErr> = __run_test;
                v25.unwrap();
                ()
            }
        }
        pub fn method41(v0: pyo3::Python) {
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(1.0_f64, 0.0_f64);
            let v4: Result<num_complex::Complex<f64>, std::string::String> =
                Math::method4(v0.clone(), Math::method3(v2.clone()));
            let v5: num_complex::Complex<f64> = Math::method13(v0, v2);
            let v8: Option<num_complex::Complex<f64>> = v4.ok();
            let v19: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v8));
            let v21: f64 = f64::NAN;
            let v23: f64 = f64::NAN;
            let v25: num_complex::Complex<f64> = num_complex::Complex::new(v21, v23);
            let v28: num_complex::Complex<f64> = match &v19 {
                Math::US0::US0_0(v19_0_0) => match &v19 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v25.clone(),
            };
            let v30: f64 = v28.clone().re;
            let v31: bool = (v30) == (f64::INFINITY);
            let v33: bool = if v31 { true } else { Math::method18(v31) };
            let v38: string = if v31 {
                Math::method19(f64::INFINITY)
            } else {
                Math::method26(v30, f64::INFINITY)
            };
            let v47: string = append(
                string("__assert_eq "),
                (if v31 {
                    Math::method19(f64::INFINITY)
                } else {
                    Math::method26(v30, f64::INFINITY)
                }),
            );
            let v50: () = {
                Math::closure2(v47.clone(), ());
                ()
            };
            if (v33) == false {
                panic!("{}", v47,);
            }
            {
                let v53: f64 = v28.im;
                let v54: bool = (v53) == 0.0_f64;
                let v56: bool = if v54 { true } else { Math::method18(v54) };
                let v61: string = if v54 {
                    Math::method19(0.0_f64)
                } else {
                    Math::method26(v53, 0.0_f64)
                };
                let v68: string = append(
                    string("__assert_eq "),
                    (if v54 {
                        Math::method19(0.0_f64)
                    } else {
                        Math::method26(v53, 0.0_f64)
                    }),
                );
                let v71: () = {
                    Math::closure2(v68.clone(), ());
                    ()
                };
                if (v56) == false {
                    panic!("{}", v68,);
                }
            }
        }
        pub fn method40() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method41(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v22: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v23: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v25: Result<(), pyo3::PyErr> = __run_test;
                v25.unwrap();
                ()
            }
        }
        pub fn method43(v0: pyo3::Python) {
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(2.0_f64, 10.0_f64);
            let v4: Result<num_complex::Complex<f64>, std::string::String> =
                Math::method4(v0.clone(), Math::method3(v2.clone()));
            let v5: num_complex::Complex<f64> = Math::method13(v0.clone(), v2.clone());
            let v8: Option<num_complex::Complex<f64>> = v4.ok();
            let v19: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v8));
            let v21: f64 = f64::NAN;
            let v23: f64 = f64::NAN;
            let v25: num_complex::Complex<f64> = num_complex::Complex::new(v21, v23);
            let v28: num_complex::Complex<f64> = match &v19 {
                Math::US0::US0_0(v19_0_0) => match &v19 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v25.clone(),
            };
            let v30: f64 = v2.clone().re;
            let v33: f64 = -v2.im;
            let v35: num_complex::Complex<f64> = num_complex::Complex::new(v30, v33);
            let v37: Result<num_complex::Complex<f64>, std::string::String> =
                Math::method4(v0.clone(), Math::method3(v35.clone()));
            let v38: num_complex::Complex<f64> = Math::method13(v0, v35);
            let v41: Option<num_complex::Complex<f64>> = v37.ok();
            let v52: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v41));
            let v54: f64 = f64::NAN;
            let v56: f64 = f64::NAN;
            let v58: num_complex::Complex<f64> = num_complex::Complex::new(v54, v56);
            let v61: num_complex::Complex<f64> = match &v52 {
                Math::US0::US0_0(v52_0_0) => match &v52 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v58.clone(),
            };
            let v63: num_complex::Complex<f64> = v61.conj();
            let v65: f64 = v28.clone().re;
            let v67: f64 = v63.clone().re;
            let v68: bool = (v65) == (v67);
            let v70: bool = if v68 { true } else { Math::method18(v68) };
            let v73: string = if v68 {
                Math::method19(v67)
            } else {
                Math::method26(v65, v67)
            };
            let v80: string = append(
                string("__assert_eq "),
                (if v68 {
                    Math::method19(v67)
                } else {
                    Math::method26(v65, v67)
                }),
            );
            let v83: () = {
                Math::closure2(v80.clone(), ());
                ()
            };
            if (v70) == false {
                panic!("{}", v80,);
            }
            {
                let v86: f64 = v28.im;
                let v88: f64 = v63.im;
                let v89: bool = (v86) == (v88);
                let v91: bool = if v89 { true } else { Math::method18(v89) };
                let v94: string = if v89 {
                    Math::method19(v88)
                } else {
                    Math::method26(v86, v88)
                };
                let v99: string = append(
                    string("__assert_eq "),
                    (if v89 {
                        Math::method19(v88)
                    } else {
                        Math::method26(v86, v88)
                    }),
                );
                let v102: () = {
                    Math::closure2(v99.clone(), ());
                    ()
                };
                if (v91) == false {
                    panic!("{}", v99,);
                }
            }
        }
        pub fn method42() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method43(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v22: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v23: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v25: Result<(), pyo3::PyErr> = __run_test;
                v25.unwrap();
                ()
            }
        }
        pub fn method45(v0: pyo3::Python) {
            let v2: num_complex::Complex<f64> = num_complex::Complex::new(0.01_f64, 0.01_f64);
            let v4: Result<num_complex::Complex<f64>, std::string::String> =
                Math::method4(v0.clone(), Math::method3(v2.clone()));
            let v5: num_complex::Complex<f64> = Math::method13(v0, v2);
            let v8: Option<num_complex::Complex<f64>> = v4.ok();
            let v19: Math::US0 = defaultValue(Math::US0::US0_1, map(Math::method17(), v8));
            let v21: f64 = f64::NAN;
            let v23: f64 = f64::NAN;
            let v25: num_complex::Complex<f64> = num_complex::Complex::new(v21, v23);
            let v28: num_complex::Complex<f64> = match &v19 {
                Math::US0::US0_0(v19_0_0) => match &v19 {
                    Math::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => v25.clone(),
            };
            let v30: f64 = v28.clone().re;
            let v31: bool = (v30) < (f64::INFINITY);
            let v33: bool = if v31 { true } else { Math::method18(v31) };
            let v38: string = if v31 {
                Math::method19(f64::INFINITY)
            } else {
                Math::method26(v30, f64::INFINITY)
            };
            let v47: string = append(
                string("__assert_lt "),
                (if v31 {
                    Math::method19(f64::INFINITY)
                } else {
                    Math::method26(v30, f64::INFINITY)
                }),
            );
            let v50: () = {
                Math::closure2(v47.clone(), ());
                ()
            };
            if (v33) == false {
                panic!("{}", v47,);
            }
            {
                let v53: f64 = v28.im;
                let v54: bool = (v53) < (f64::INFINITY);
                let v56: bool = if v54 { true } else { Math::method18(v54) };
                let v61: string = if v54 {
                    Math::method19(f64::INFINITY)
                } else {
                    Math::method26(v53, f64::INFINITY)
                };
                let v68: string = append(
                    string("__assert_lt "),
                    (if v54 {
                        Math::method19(f64::INFINITY)
                    } else {
                        Math::method26(v53, f64::INFINITY)
                    }),
                );
                let v71: () = {
                    Math::closure2(v68.clone(), ());
                    ()
                };
                if (v56) == false {
                    panic!("{}", v68,);
                }
            }
        }
        pub fn method44() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method45(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v22: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v23: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v25: Result<(), pyo3::PyErr> = __run_test;
                v25.unwrap();
                ()
            }
        }
        pub fn method48() -> LrcPtr<Math::UH0> {
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
        pub fn method49(v0: pyo3::Python, v1: LrcPtr<Math::UH0>) {
            let v0: MutCell<pyo3::Python> = MutCell::new(v0.clone());
            let v1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1.clone());
            '_method49: loop {
                break '_method49 (match v1.get().clone().as_ref() {
                    Math::UH0::UH0_0 => (),
                    Math::UH0::UH0_1(v1_1_0, v1_1_1) => {
                        let v5: num_complex::Complex<f64> = num_complex::Complex::new(
                            0.0_f64,
                            match v1.get().clone().as_ref() {
                                Math::UH0::UH0_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        let v7_1: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(v0.get().clone(), Math::method3(v5.clone()));
                        let v8: num_complex::Complex<f64> = Math::method13(v0.get().clone(), v5);
                        let v11: Option<num_complex::Complex<f64>> = v7_1.ok();
                        let v22: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v11));
                        let v24: f64 = f64::NAN;
                        let v26: f64 = f64::NAN;
                        let v28: num_complex::Complex<f64> = num_complex::Complex::new(v24, v26);
                        let v31: num_complex::Complex<f64> = match &v22 {
                            Math::US0::US0_0(v22_0_0) => match &v22 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v28.clone(),
                        };
                        let v33: f64 = v31.clone().re;
                        let v36: bool = (v33) != 0.0_f64;
                        let v45: bool = if v36 { true } else { Math::method18(v36) };
                        let v50: string = if v36 {
                            Math::method19(0.0_f64)
                        } else {
                            Math::method26(v33, 0.0_f64)
                        };
                        let v72: string = append(
                            string("__assert_ne "),
                            (if v36 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v33, 0.0_f64)
                            }),
                        );
                        let v75: () = {
                            Math::closure2(v72.clone(), ());
                            ()
                        };
                        if (v45) == false {
                            panic!("{}", v72,);
                        }
                        {
                            let v78: f64 = v31.im;
                            let v79: bool = (v78) != 0.0_f64;
                            let v81: bool = if v79 { true } else { Math::method18(v79) };
                            let v86: string = if v79 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v78, 0.0_f64)
                            };
                            let v93: string = append(
                                string("__assert_ne "),
                                (if v79 {
                                    Math::method19(0.0_f64)
                                } else {
                                    Math::method26(v78, 0.0_f64)
                                }),
                            );
                            let v96: () = {
                                Math::closure2(v93.clone(), ());
                                ()
                            };
                            if (v81) == false {
                                panic!("{}", v93,);
                            }
                            {
                                let v0_temp: pyo3::Python = v0.get().clone();
                                let v1_temp: LrcPtr<Math::UH0> = match v1.get().clone().as_ref() {
                                    Math::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
                                v0.set(v0_temp);
                                v1.set(v1_temp);
                                continue '_method49;
                            }
                        }
                    }
                });
            }
        }
        pub fn method47(v0: pyo3::Python) {
            Math::method49(v0, Math::method48());
        }
        pub fn method46() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method47(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v22: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v23: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v25: Result<(), pyo3::PyErr> = __run_test;
                v25.unwrap();
                ()
            }
        }
        pub fn method52() -> LrcPtr<Math::UH1> {
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
        pub fn method53(v0: pyo3::Python, v1: LrcPtr<Math::UH1>) {
            let v0: MutCell<pyo3::Python> = MutCell::new(v0.clone());
            let v1: MutCell<LrcPtr<Math::UH1>> = MutCell::new(v1.clone());
            '_method53: loop {
                break '_method53 (match v1.get().clone().as_ref() {
                    Math::UH1::UH1_0 => (),
                    Math::UH1::UH1_1(v1_1_0, v1_1_1) => {
                        let v2: num_complex::Complex<f64> = match v1.get().clone().as_ref() {
                            Math::UH1::UH1_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone();
                        let v5: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(v0.get().clone(), Math::method3(v2.clone()));
                        let v6_1: num_complex::Complex<f64> = Math::method13(v0.get().clone(), v2);
                        let v9: Option<num_complex::Complex<f64>> = v5.ok();
                        let v20: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v9));
                        let v22: f64 = f64::NAN;
                        let v24: f64 = f64::NAN;
                        let v26: num_complex::Complex<f64> = num_complex::Complex::new(v22, v24);
                        let v29: num_complex::Complex<f64> = match &v20 {
                            Math::US0::US0_0(v20_0_0) => match &v20 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v26.clone(),
                        };
                        let v31: f64 = v29.clone().re;
                        let v32: bool = (v31) != 0.0_f64;
                        let v34: bool = if v32 { true } else { Math::method18(v32) };
                        let v39: string = if v32 {
                            Math::method19(0.0_f64)
                        } else {
                            Math::method26(v31, 0.0_f64)
                        };
                        let v48: string = append(
                            string("__assert_ne "),
                            (if v32 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v31, 0.0_f64)
                            }),
                        );
                        let v51: () = {
                            Math::closure2(v48.clone(), ());
                            ()
                        };
                        if (v34) == false {
                            panic!("{}", v48,);
                        }
                        {
                            let v54: f64 = v29.im;
                            let v55: bool = (v54) != 0.0_f64;
                            let v57: bool = if v55 { true } else { Math::method18(v55) };
                            let v62: string = if v55 {
                                Math::method19(0.0_f64)
                            } else {
                                Math::method26(v54, 0.0_f64)
                            };
                            let v69: string = append(
                                string("__assert_ne "),
                                (if v55 {
                                    Math::method19(0.0_f64)
                                } else {
                                    Math::method26(v54, 0.0_f64)
                                }),
                            );
                            let v72: () = {
                                Math::closure2(v69.clone(), ());
                                ()
                            };
                            if (v57) == false {
                                panic!("{}", v69,);
                            }
                            {
                                let v0_temp: pyo3::Python = v0.get().clone();
                                let v1_temp: LrcPtr<Math::UH1> = match v1.get().clone().as_ref() {
                                    Math::UH1::UH1_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
                                v0.set(v0_temp);
                                v1.set(v1_temp);
                                continue '_method53;
                            }
                        }
                    }
                });
            }
        }
        pub fn method51(v0: pyo3::Python) {
            Math::method53(v0, Math::method52());
        }
        pub fn method50() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method51(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v22: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v23: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v25: Result<(), pyo3::PyErr> = __run_test;
                v25.unwrap();
                ()
            }
        }
        pub fn method56() -> LrcPtr<Math::UH1> {
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
        pub fn method57(v0: pyo3::Python, v1: LrcPtr<Math::UH1>) {
            let v0: MutCell<pyo3::Python> = MutCell::new(v0.clone());
            let v1: MutCell<LrcPtr<Math::UH1>> = MutCell::new(v1.clone());
            '_method57: loop {
                break '_method57 (match v1.get().clone().as_ref() {
                    Math::UH1::UH1_0 => (),
                    Math::UH1::UH1_1(v1_1_0, v1_1_1) => {
                        let v2: num_complex::Complex<f64> = match v1.get().clone().as_ref() {
                            Math::UH1::UH1_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone();
                        let v5: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(v0.get().clone(), Math::method3(v2.clone()));
                        let v6_1: num_complex::Complex<f64> =
                            Math::method13(v0.get().clone(), v2.clone());
                        let v9: Option<num_complex::Complex<f64>> = v5.ok();
                        let v20: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v9));
                        let v22: f64 = f64::NAN;
                        let v24: f64 = f64::NAN;
                        let v26: num_complex::Complex<f64> = num_complex::Complex::new(v22, v24);
                        let v29: num_complex::Complex<f64> = match &v20 {
                            Math::US0::US0_0(v20_0_0) => match &v20 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v26.clone(),
                        };
                        let v31: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v33: num_complex::Complex<f64> =
                            num_complex::Complex::powc(v31, v2.clone());
                        let v35: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v37: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v39: num_complex::Complex<f64> = v2.clone() - v37;
                        let v41: num_complex::Complex<f64> = num_complex::Complex::powc(v35, v39);
                        let v43: num_complex::Complex<f64> = v33 * v41;
                        let v45: num_complex::Complex<f64> =
                            num_complex::Complex::new(3.141592653589793_f64, 0.0_f64);
                        let v47: num_complex::Complex<f64> = v45 * v2.clone();
                        let v49: num_complex::Complex<f64> =
                            num_complex::Complex::new(2.0_f64, 0.0_f64);
                        let v51: num_complex::Complex<f64> = v47 / v49;
                        let v53: num_complex::Complex<f64> = v51.sin();
                        let v55: num_complex::Complex<f64> = v43 * v53;
                        let v57: num_complex::Complex<f64> =
                            num_complex::Complex::new(1.0_f64, 0.0_f64);
                        let v61: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method16(v0.get().clone(), Math::method3(v57 - v2.clone()));
                        let v64: Option<num_complex::Complex<f64>> = v61.ok();
                        let v75: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v64));
                        let v77: f64 = f64::NAN;
                        let v79: f64 = f64::NAN;
                        let v81: num_complex::Complex<f64> = num_complex::Complex::new(v77, v79);
                        let v84: num_complex::Complex<f64> = match &v75 {
                            Math::US0::US0_0(v75_0_0) => match &v75 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v81.clone(),
                        };
                        let v86: num_complex::Complex<f64> = v55 * v84;
                        let v89: f64 = 1.0_f64 - (v2.clone().re);
                        let v92: f64 = -v2.im;
                        let v94: num_complex::Complex<f64> = num_complex::Complex::new(v89, v92);
                        let v96: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(v0.get().clone(), Math::method3(v94.clone()));
                        let v97: num_complex::Complex<f64> = Math::method13(v0.get().clone(), v94);
                        let v100: Option<num_complex::Complex<f64>> = v96.ok();
                        let v111: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v100));
                        let v113: f64 = f64::NAN;
                        let v115: f64 = f64::NAN;
                        let v117: num_complex::Complex<f64> = num_complex::Complex::new(v113, v115);
                        let v120: num_complex::Complex<f64> = match &v111 {
                            Math::US0::US0_0(v111_0_0) => match &v111 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v117.clone(),
                        };
                        let v122: num_complex::Complex<f64> = v86 * v120;
                        let v127: f64 = (v29.clone().re) - (v122.clone().re);
                        let v128: f64 = -v127;
                        let v130: f64 = if (v127) >= (v128) { v127 } else { v128 };
                        let v131: bool = (v130) < 0.0001_f64;
                        let v133: bool = if v131 { true } else { Math::method18(v131) };
                        let v138: string = if v131 {
                            Math::method19(0.0001_f64)
                        } else {
                            Math::method26(v130, 0.0001_f64)
                        };
                        let v147: string = append(
                            string("__assert_lt "),
                            (if v131 {
                                Math::method19(0.0001_f64)
                            } else {
                                Math::method26(v130, 0.0001_f64)
                            }),
                        );
                        let v150: () = {
                            Math::closure2(v147.clone(), ());
                            ()
                        };
                        if (v133) == false {
                            panic!("{}", v147,);
                        }
                        {
                            let v156: f64 = (v29.im) - (v122.im);
                            let v157: f64 = -v156;
                            let v159: f64 = if (v156) >= (v157) { v156 } else { v157 };
                            let v160: bool = (v159) < 0.0001_f64;
                            let v162: bool = if v160 { true } else { Math::method18(v160) };
                            let v167: string = if v160 {
                                Math::method19(0.0001_f64)
                            } else {
                                Math::method26(v159, 0.0001_f64)
                            };
                            let v174: string = append(
                                string("__assert_lt "),
                                (if v160 {
                                    Math::method19(0.0001_f64)
                                } else {
                                    Math::method26(v159, 0.0001_f64)
                                }),
                            );
                            let v177: () = {
                                Math::closure2(v174.clone(), ());
                                ()
                            };
                            if (v162) == false {
                                panic!("{}", v174,);
                            }
                            {
                                let v0_temp: pyo3::Python = v0.get().clone();
                                let v1_temp: LrcPtr<Math::UH1> = match v1.get().clone().as_ref() {
                                    Math::UH1::UH1_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
                                v0.set(v0_temp);
                                v1.set(v1_temp);
                                continue '_method57;
                            }
                        }
                    }
                });
            }
        }
        pub fn method55(v0: pyo3::Python) {
            Math::method57(v0, Math::method56());
        }
        pub fn method54() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method55(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v22: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v23: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v25: Result<(), pyo3::PyErr> = __run_test;
                v25.unwrap();
                ()
            }
        }
        pub fn method60() -> LrcPtr<Math::UH0> {
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
        pub fn method61() -> LrcPtr<Math::UH0> {
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
        pub fn method63(v0: f64, v1: LrcPtr<Math::UH0>, v2: f64) -> f64 {
            let v0: MutCell<f64> = MutCell::new(v0);
            let v1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1.clone());
            let v2: MutCell<f64> = MutCell::new(v2);
            '_method63: loop {
                break '_method63 (match v1.get().clone().as_ref() {
                    Math::UH0::UH0_0 => v2.get().clone(),
                    Math::UH0::UH0_1(v1_1_0, v1_1_1) => {
                        let v5: f64 = -v0.get().clone();
                        {
                            let v0_temp: f64 = v0.get().clone();
                            let v1_temp: LrcPtr<Math::UH0> = match v1.get().clone().as_ref() {
                                Math::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone();
                            let v2_temp: f64 = (v2.get().clone())
                                / (1.0_f64
                                    - (match v1.get().clone().as_ref() {
                                        Math::UH0::UH0_1(x, _) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .powf(v5)));
                            v0.set(v0_temp);
                            v1.set(v1_temp);
                            v2.set(v2_temp);
                            continue '_method63;
                        }
                    }
                });
            }
        }
        pub fn method62(v0: pyo3::Python, v1: LrcPtr<Math::UH0>, v2: LrcPtr<Math::UH0>) {
            let v0: MutCell<pyo3::Python> = MutCell::new(v0.clone());
            let v1: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v1.clone());
            let v2: MutCell<LrcPtr<Math::UH0>> = MutCell::new(v2.clone());
            '_method62: loop {
                break '_method62 (match v2.get().clone().as_ref() {
                    Math::UH0::UH0_0 => (),
                    Math::UH0::UH0_1(v2_1_0, v2_1_1) => {
                        let v3: f64 = match v2.get().clone().as_ref() {
                            Math::UH0::UH0_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v6_1: num_complex::Complex<f64> =
                            num_complex::Complex::new(v3, 0.0_f64);
                        let v8: f64 = Math::method63(v3, v1.get().clone(), 1.0_f64);
                        let v10: Result<num_complex::Complex<f64>, std::string::String> =
                            Math::method4(v0.get().clone(), Math::method3(v6_1.clone()));
                        let v11: num_complex::Complex<f64> = Math::method13(v0.get().clone(), v6_1);
                        let v14: Option<num_complex::Complex<f64>> = v10.ok();
                        let v25: Math::US0 =
                            defaultValue(Math::US0::US0_1, map(Math::method17(), v14));
                        let v27: f64 = f64::NAN;
                        let v29: f64 = f64::NAN;
                        let v31: num_complex::Complex<f64> = num_complex::Complex::new(v27, v29);
                        let v34: num_complex::Complex<f64> = match &v25 {
                            Math::US0::US0_0(v25_0_0) => match &v25 {
                                Math::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v31.clone(),
                        };
                        let v37: f64 = (v34.clone().re) - (v8);
                        let v38: f64 = -v37;
                        let v40: f64 = if (v37) >= (v38) { v37 } else { v38 };
                        let v41: bool = (v40) < 0.01_f64;
                        let v43: bool = if v41 { true } else { Math::method18(v41) };
                        let v48: string = if v41 {
                            Math::method19(0.01_f64)
                        } else {
                            Math::method26(v40, 0.01_f64)
                        };
                        let v57: string = append(
                            string("__assert_lt "),
                            (if v41 {
                                Math::method19(0.01_f64)
                            } else {
                                Math::method26(v40, 0.01_f64)
                            }),
                        );
                        let v60: () = {
                            Math::closure2(v57.clone(), ());
                            ()
                        };
                        if (v43) == false {
                            panic!("{}", v57,);
                        }
                        {
                            let v63: f64 = v34.im;
                            let v64: bool = (v63) < 0.01_f64;
                            let v66: bool = if v64 { true } else { Math::method18(v64) };
                            let v71: string = if v64 {
                                Math::method19(0.01_f64)
                            } else {
                                Math::method26(v63, 0.01_f64)
                            };
                            let v78: string = append(
                                string("__assert_lt "),
                                (if v64 {
                                    Math::method19(0.01_f64)
                                } else {
                                    Math::method26(v63, 0.01_f64)
                                }),
                            );
                            let v81: () = {
                                Math::closure2(v78.clone(), ());
                                ()
                            };
                            if (v66) == false {
                                panic!("{}", v78,);
                            }
                            {
                                let v0_temp: pyo3::Python = v0.get().clone();
                                let v1_temp: LrcPtr<Math::UH0> = v1.get().clone();
                                let v2_temp: LrcPtr<Math::UH0> = match v2.get().clone().as_ref() {
                                    Math::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
                                v0.set(v0_temp);
                                v1.set(v1_temp);
                                v2.set(v2_temp);
                                continue '_method62;
                            }
                        }
                    }
                });
            }
        }
        pub fn method59(v0: pyo3::Python) {
            let v1: LrcPtr<Math::UH0> = Math::method60();
            Math::method62(v0, Math::method61(), v1)
        }
        pub fn method58() {
            pyo3::Python::initialize();
            let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> {
                //;
                Math::method59(py);
                {
                    let v5: Result<(), pyo3::PyErr> = Math::method29(Ok::<(), pyo3::PyErr>(()));
                    let v9: string = string("}}");
                    let v11: string = string("{");
                    let v16: bool = true;
                    let _fix_closure_v13 = v5;
                    let v22: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v13 "), (v9))),
                                string("); "),
                            )),
                            (v11),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v23: bool = true;
                    _fix_closure_v13
                }
            });
            {
                // rust.fix_closure';
                let v25: Result<(), pyo3::PyErr> = __run_test;
                v25.unwrap();
                ()
            }
        }
        pub fn closure0(unitVar: (), unitVar_1: ()) {
            let v1: bool = true;
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
            Math::method30();
        } /* /*;
        {
        let v12: string =
        string("*/ #[test] fn test_trivial_zero_at_negative_even___() { //");
        let v13: bool =
         */
        #[test]
        fn test_trivial_zero_at_negative_even___() {
            //;
            Math::method32();
        } /* /*;
        {
        let v16: string =
        string("*/ #[test] fn test_non_trivial_zero___() { //");
        let v17: bool =
         */
        #[test]
        fn test_non_trivial_zero___() {
            //;
            Math::method36();
        } /* /*;
        {
        let v20: string =
        string("*/ #[test] fn test_real_part_greater_than_one___() { //");
        let v21: bool =
         */
        #[test]
        fn test_real_part_greater_than_one___() {
            //;
            Math::method38();
        } /* /*;
        {
        let v24: string =
        string("*/ #[test] fn test_zeta_at_1___() { //");
        let v25: bool =
         */
        #[test]
        fn test_zeta_at_1___() {
            //;
            Math::method40();
        } /* /*;
        {
        let v28: string =
        string("*/ #[test] fn test_symmetry_across_real_axis___() { //");
        let v29: bool =
         */
        #[test]
        fn test_symmetry_across_real_axis___() {
            //;
            Math::method42();
        } /* /*;
        {
        let v32: string =
        string("*/ #[test] fn test_behavior_near_origin___() { //");
        let v33: bool =
         */
        #[test]
        fn test_behavior_near_origin___() {
            //;
            Math::method44();
        } /* /*;
        {
        let v36: string =
        string("*/ #[test] fn test_imaginary_axis() { //");
        let v37: bool =
         */
        #[test]
        fn test_imaginary_axis() {
            //;
            Math::method46();
        } /* /*;
        {
        let v40: string =
        string("*/ #[test] fn test_critical_strip() { //");
        let v41: bool =
         */
        #[test]
        fn test_critical_strip() {
            //;
            Math::method50();
        } /* /*;
        {
        let v44: string =
        string("*/ #[test] fn test_reflection_formula_for_specific_value() { //");
        let v45: bool =
         */
        #[test]
        fn test_reflection_formula_for_specific_value() {
            //;
            Math::method54();
        } /* /*;
        {
        let v48: string =
        string("*/ #[test] fn test_euler_product_formula() { //");
        let v49: bool =
         */
        #[test]
        fn test_euler_product_formula() {
            //;
            Math::method58();
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
        pub fn closure3(unitVar: (), v0: Array<string>) -> i32 {
            let v36: () = {
                Math::closure2(append(string("value: "), (toString(1_i32))), ());
                ()
            };
            0_i32
        }
        pub fn v6() -> Func0<()> {
            static v6: OnceInit<Func0<()>> = OnceInit::new();
            v6.get_or_init(|| Func0::new(move || Math::closure0((), ())))
                .clone()
        }
        pub fn tests() {
            (Math::v6())();
        }
        pub fn v7() -> Func1<Array<string>, i32> {
            static v7: OnceInit<Func1<Array<string>, i32>> = OnceInit::new();
            v7.get_or_init(|| Func1::new(move |v: Array<string>| Math::closure3((), v)))
                .clone()
        }
        pub fn main(args: Array<string>) -> i32 {
            (Math::v7())(args)
        }
    }
}
pub use module_b7a9935b::*;
#[path = "../../deps/spiral/lib/spiral/async_.rs"]
mod module_2335f2f5;
pub use module_2335f2f5::*;
#[path = "../../deps/spiral/lib/spiral/common.rs"]
mod module_652e6d81;
pub use module_652e6d81::*;
#[path = "../../deps/spiral/lib/spiral/crypto.rs"]
mod module_dd5f95ef;
pub use module_dd5f95ef::*;
#[path = "../../deps/spiral/lib/spiral/date_time.rs"]
mod module_ca5e6cb2;
pub use module_ca5e6cb2::*;
#[path = "../../deps/spiral/lib/spiral/file_system.rs"]
mod module_5ab1faf0;
pub use module_5ab1faf0::*;
#[path = "../../deps/spiral/lib/spiral/lib.rs"]
mod module_b386774b;
pub use module_b386774b::*;
#[path = "../../deps/spiral/lib/spiral/networking.rs"]
mod module_ce497f72;
pub use module_ce497f72::*;
#[path = "../../deps/spiral/lib/spiral/platform.rs"]
mod module_9a61edd3;
pub use module_9a61edd3::*;
#[path = "../../deps/spiral/lib/spiral/runtime.rs"]
mod module_502d7e30;
pub use module_502d7e30::*;
#[path = "../../deps/spiral/lib/spiral/sm.rs"]
mod module_34f67952;
pub use module_34f67952::*;
#[path = "../../deps/spiral/lib/spiral/threading.rs"]
mod module_11c0c5c2;
pub use module_11c0c5c2::*;
#[path = "../../deps/spiral/lib/spiral/trace.rs"]
mod module_28ecba0d;
pub use module_28ecba0d::*;
#[path = "../../lib/fsharp/Common.rs"]
mod module_ad43931;
pub use module_ad43931::*;
pub mod Polyglot {
    pub use crate::module_ad43931::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Math::main(array_from(args));
}
