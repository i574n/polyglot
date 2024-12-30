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
mod module_fb49c4a9 {
    pub mod Spiral_wasm {
        use super::*;
        use fable_library_rust::DateTime_::DateTime;
        use fable_library_rust::List_::empty;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::singleton;
        use fable_library_rust::List_::toArray;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::contains;
        use fable_library_rust::String_::getCharAt;
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toLower;
        use fable_library_rust::String_::trimEndChars;
        use fable_library_rust::String_::trimStartChars;
        use fable_library_rust::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::TimeSpan_::TimeSpan;
        pub mod TraceState {
            use super::*;
            pub fn trace_state() -> LrcPtr<
                MutCell<
                    Option<(
                        LrcPtr<Spiral_wasm::Mut0>,
                        LrcPtr<Spiral_wasm::Mut1>,
                        LrcPtr<Spiral_wasm::Mut2>,
                        LrcPtr<Spiral_wasm::Mut3>,
                        LrcPtr<Spiral_wasm::Mut4>,
                        Option<i64>,
                    )>,
                >,
            > {
                static trace_state: OnceInit<
                    LrcPtr<
                        MutCell<
                            Option<(
                                LrcPtr<Spiral_wasm::Mut0>,
                                LrcPtr<Spiral_wasm::Mut1>,
                                LrcPtr<Spiral_wasm::Mut2>,
                                LrcPtr<Spiral_wasm::Mut3>,
                                LrcPtr<Spiral_wasm::Mut4>,
                                Option<i64>,
                            )>,
                        >,
                    >,
                > = OnceInit::new();
                trace_state
                    .get_or_init(|| {
                        LrcPtr::new(MutCell::new(
                            None::<(
                                LrcPtr<Spiral_wasm::Mut0>,
                                LrcPtr<Spiral_wasm::Mut1>,
                                LrcPtr<Spiral_wasm::Mut2>,
                                LrcPtr<Spiral_wasm::Mut3>,
                                LrcPtr<Spiral_wasm::Mut4>,
                                Option<i64>,
                            )>,
                        ))
                    })
                    .clone()
            }
        }
        pub trait IOsEnviron: core::fmt::Debug + core::fmt::Display {
            fn environ(&self) -> LrcPtr<dyn Any>;
        }
        impl<V: IOsEnviron + core::fmt::Debug + core::fmt::Display> IOsEnviron for LrcPtr<V> {
            #[inline]
            fn environ(&self) -> LrcPtr<dyn Any> {
                (**self).environ()
            }
        }
        #[derive(Clone, Debug)]
        pub enum US0 {
            US0_0(std::string::String),
            US0_1,
        }
        impl core::fmt::Display for US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US3 {
            US3_0,
            US3_1,
            US3_2,
            US3_3,
            US3_4,
        }
        impl core::fmt::Display for US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US2 {
            US2_0(Spiral_wasm::US3),
            US2_1,
        }
        impl core::fmt::Display for US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US1 {
            US1_0(Spiral_wasm::US2),
            US1_1,
        }
        impl core::fmt::Display for US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut0 {
            pub l0: MutCell<i64>,
        }
        impl core::fmt::Display for Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut1 {
            pub l0: MutCell<Func1<string, ()>>,
        }
        impl core::fmt::Display for Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut2 {
            pub l0: MutCell<bool>,
        }
        impl core::fmt::Display for Mut2 {
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
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut4 {
            pub l0: MutCell<Spiral_wasm::US3>,
        }
        impl core::fmt::Display for Mut4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US4 {
            US4_0(i64),
            US4_1,
        }
        impl core::fmt::Display for US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US5 {
            US5_0,
            US5_1,
            US5_2,
        }
        impl core::fmt::Display for US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US6 {
            US6_0(Spiral_wasm::US5),
            US6_1(Spiral_wasm::US5),
            US6_2(Spiral_wasm::US5),
            US6_3(Spiral_wasm::US5),
            US6_4(Spiral_wasm::US5),
        }
        impl core::fmt::Display for US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US7 {
            US7_0(string),
            US7_1,
        }
        impl core::fmt::Display for US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US8 {
            US8_0(u8, Spiral_wasm::US7),
            US8_1(u8, Spiral_wasm::US7),
        }
        impl core::fmt::Display for US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US9 {
            US9_0(Spiral_wasm::US7),
            US9_1(std::string::String),
        }
        impl core::fmt::Display for US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US10 {
            US10_0(u8),
            US10_1(std::string::String),
        }
        impl core::fmt::Display for US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn method0() -> clap::Command {
            let v1: string = string("r#\"command\"#");
            let v2: &'static str = r#"command"#;
            let v4: clap::Command = clap::Command::new(v2);
            let v6: clap::Command = clap::Command::args_override_self(v4, true);
            let v7: usize = 0_i32 as usize;
            let v10: usize = 1_i32 as usize;
            let v24: clap::builder::ValueRange = if (v10) == (0_i32 as usize) {
                clap::builder::ValueRange::new(v7..)
            } else {
                let v22: string = string("clap::builder::ValueRange::new($0..=$1)");
                clap::builder::ValueRange::new(v7..=v10)
            };
            let v26: string = string("r#\"exception\"#");
            let v27: &'static str = r#"exception"#;
            let v29: clap::Arg = clap::Arg::new(v27);
            let v31: clap::Arg = v29.short('e');
            let v32: string = string("r#\"exception\"#");
            let v33: &'static str = r#"exception"#;
            let v35: clap::Arg = v31.long(v33);
            let v37: clap::Arg = v35.num_args(v24);
            let v39: clap::Arg = v37.require_equals(true);
            let v41: string = string("r#\"\"#");
            let v42: &str = r#""#;
            let v44: clap::Arg = v39.default_missing_value(v42);
            let v46: clap::Command = clap::Command::arg(v6, v44);
            let v48: string = string("r#\"trace_level\"#");
            let v49: &'static str = r#"trace_level"#;
            let v51: clap::Arg = clap::Arg::new(v49);
            let v53: clap::Arg = v51.short('t');
            let v54: string = string("r#\"trace_level\"#");
            let v55: &'static str = r#"trace_level"#;
            let v57: clap::Arg = v53.long(v55);
            let v80: Array<string> = toArray(ofArray(new_array(&[
                string("Verbose"),
                string("Debug"),
                string("Info"),
                string("Warning"),
                string("Critical"),
            ])));
            let v84: Vec<string> = v80.to_vec();
            let v86: bool = true;
            let _vec_map: Vec<_> = v84
                .into_iter()
                .map(|x| {
                    //;
                    let v88: string = x;
                    let v91: &str = &*v88;
                    let v115: std::string::String = String::from(v91);
                    let v138: Box<std::string::String> = Box::new(v115);
                    let v140: &'static mut std::string::String = Box::leak(v138);
                    let v142: clap::builder::PossibleValue =
                        clap::builder::PossibleValue::new(&**v140);
                    let v144: bool = true;
                    v142
                })
                .collect::<Vec<_>>();
            let v146: Vec<clap::builder::PossibleValue> = _vec_map;
            let v148: clap::builder::ValueParser = Into::<clap::builder::ValueParser>::into(
                clap::builder::PossibleValuesParser::new(v146),
            );
            let v150: clap::Arg = v57.value_parser(v148);
            let v152: clap::Command = clap::Command::arg(v46, v150);
            let v154: string = string("r#\"wasm\"#");
            let v155: &'static str = r#"wasm"#;
            let v157: clap::Arg = clap::Arg::new(v155);
            let v159: clap::Arg = v157.short('w');
            let v160: string = string("r#\"wasm\"#");
            let v161: &'static str = r#"wasm"#;
            let v163: clap::Arg = v159.long(v161);
            let v165: clap::Arg = v163.required(true);
            clap::Command::arg(v152, v165)
        }
        pub fn method1() -> string {
            string("trace_level")
        }
        pub fn closure1(unitVar: (), v0_1: std::string::String) -> Spiral_wasm::US0 {
            Spiral_wasm::US0::US0_0(v0_1)
        }
        pub fn method2() -> Func1<std::string::String, Spiral_wasm::US0> {
            Func1::new(move |v: std::string::String| Spiral_wasm::closure1((), v))
        }
        pub fn method6(v0_1: string) -> string {
            v0_1
        }
        pub fn method7() -> string {
            string("")
        }
        pub fn closure3(unitVar: (), v0_1: string) -> Spiral_wasm::US7 {
            Spiral_wasm::US7::US7_0(v0_1)
        }
        pub fn method8() -> Func1<string, Spiral_wasm::US7> {
            Func1::new(move |v: string| Spiral_wasm::closure3((), v))
        }
        pub fn method5(v0_1: string) -> string {
            let v2: string = Spiral_wasm::method6(v0_1);
            let v4: Result<std::string::String, std::env::VarError> = std::env::var(&*v2);
            let v6: bool = true;
            let _result_map_ = v4.map(|x| {
                //;
                let v8: std::string::String = x;
                let v10: string = fable_library_rust::String_::fromString(v8);
                let v12: bool = true;
                v10
            });
            let v14: Result<string, std::env::VarError> = _result_map_;
            let v15: string = Spiral_wasm::method7();
            v14.unwrap_or(v15)
        }
        pub fn method4() -> (Spiral_wasm::US2, Spiral_wasm::US4) {
            let v1: string = Spiral_wasm::method5(string("TRACE_LEVEL"));
            let v6: Spiral_wasm::US2 = if string("Verbose") == (v1.clone()) {
                Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_0)
            } else {
                Spiral_wasm::US2::US2_1
            };
            (
                match &v6 {
                    Spiral_wasm::US2::US2_0(v6_0_0) => Spiral_wasm::US2::US2_0(
                        match &v6 {
                            Spiral_wasm::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => {
                        let v13: Spiral_wasm::US2 = if string("Debug") == (v1.clone()) {
                            Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_1)
                        } else {
                            Spiral_wasm::US2::US2_1
                        };
                        match &v13 {
                            Spiral_wasm::US2::US2_0(v13_0_0) => Spiral_wasm::US2::US2_0(
                                match &v13 {
                                    Spiral_wasm::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                let v20: Spiral_wasm::US2 = if string("Info") == (v1.clone()) {
                                    Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_2)
                                } else {
                                    Spiral_wasm::US2::US2_1
                                };
                                match &v20 {
                                    Spiral_wasm::US2::US2_0(v20_0_0) => Spiral_wasm::US2::US2_0(
                                        match &v20 {
                                            Spiral_wasm::US2::US2_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                    ),
                                    _ => {
                                        let v27: Spiral_wasm::US2 =
                                            if string("Warning") == (v1.clone()) {
                                                Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_3)
                                            } else {
                                                Spiral_wasm::US2::US2_1
                                            };
                                        match &v27 {
                                            Spiral_wasm::US2::US2_0(v27_0_0) => {
                                                Spiral_wasm::US2::US2_0(
                                                    match &v27 {
                                                        Spiral_wasm::US2::US2_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                )
                                            }
                                            _ => {
                                                let v34: Spiral_wasm::US2 = if string("Critical")
                                                    == (v1.clone())
                                                {
                                                    Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_4)
                                                } else {
                                                    Spiral_wasm::US2::US2_1
                                                };
                                                match &v34 {
                                                    Spiral_wasm::US2::US2_0(v34_0_0) => {
                                                        Spiral_wasm::US2::US2_0(
                                                            match &v34 {
                                                                Spiral_wasm::US2::US2_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            }
                                                            .clone(),
                                                        )
                                                    }
                                                    _ => Spiral_wasm::US2::US2_1,
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                if (Spiral_wasm::method5(string("AUTOMATION"))) != string("True") {
                    Spiral_wasm::US4::US4_1
                } else {
                    Spiral_wasm::US4::US4_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                },
            )
        }
        pub fn closure4(unitVar: (), v0_1: string) {
            ();
        }
        pub fn method3(
            v0_1: Spiral_wasm::US3,
        ) -> (
            LrcPtr<Spiral_wasm::Mut0>,
            LrcPtr<Spiral_wasm::Mut1>,
            LrcPtr<Spiral_wasm::Mut2>,
            LrcPtr<Spiral_wasm::Mut3>,
            LrcPtr<Spiral_wasm::Mut4>,
            Option<i64>,
        ) {
            let patternInput: (Spiral_wasm::US2, Spiral_wasm::US4) = Spiral_wasm::method4();
            let _run_target_args__v1: (Spiral_wasm::US2, Spiral_wasm::US4) =
                (patternInput.0.clone(), patternInput.1.clone());
            let v132: Spiral_wasm::US4 = _run_target_args__v1.1.clone();
            let v131: Spiral_wasm::US2 = _run_target_args__v1.0.clone();
            (
                LrcPtr::new(Spiral_wasm::Mut0 {
                    l0: MutCell::new(1_i64),
                }),
                LrcPtr::new(Spiral_wasm::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| Spiral_wasm::closure4((), v))),
                }),
                LrcPtr::new(Spiral_wasm::Mut2 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Spiral_wasm::Mut3 {
                    l0: MutCell::new(string("")),
                }),
                LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(match &v131 {
                        Spiral_wasm::US2::US2_0(v131_0_0) => match &v131 {
                            Spiral_wasm::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => v0_1.clone(),
                    }),
                }),
                match &v132 {
                    Spiral_wasm::US4::US4_0(v132_0_0) => Some(match &v132 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
            )
        }
        pub fn closure2(v0_1: Spiral_wasm::US3, unitVar: ()) {
            if Spiral_wasm::TraceState::trace_state()
                .get()
                .clone()
                .is_none()
            {
                let patternInput: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = Spiral_wasm::method3(v0_1);
                Spiral_wasm::TraceState::trace_state().set(Some((
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                )));
                ()
            };
        }
        pub fn closure6(unitVar: (), unitVar_1: ()) {
            if Spiral_wasm::TraceState::trace_state()
                .get()
                .clone()
                .is_none()
            {
                let patternInput: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = Spiral_wasm::method3(Spiral_wasm::US3::US3_0);
                Spiral_wasm::TraceState::trace_state().set(Some((
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                )));
                ()
            };
        }
        pub fn method9(v0_1: Spiral_wasm::US3) -> bool {
            let v3: () = {
                Spiral_wasm::closure6((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                LrcPtr<Spiral_wasm::Mut4>,
                Option<i64>,
            ) = Spiral_wasm::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v35: Spiral_wasm::US3 = (patternInput.4.clone()).l0.get().clone();
            if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                (find(
                    v0_1,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                        LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                        LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                        LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                        LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                    ])))),
                )) >= (find(
                    v35,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                        LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                        LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                        LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                        LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                    ])))),
                ))
            }
        }
        pub fn closure7(unitVar: (), v0_1: i64) -> Spiral_wasm::US4 {
            Spiral_wasm::US4::US4_0(v0_1)
        }
        pub fn method11() -> Func1<i64, Spiral_wasm::US4> {
            Func1::new(move |v: i64| Spiral_wasm::closure7((), v))
        }
        pub fn method12() -> string {
            string("hh:mm:ss")
        }
        pub fn method13() -> string {
            string("HH:mm:ss")
        }
        pub fn method10(
            v0_1: LrcPtr<Spiral_wasm::Mut0>,
            v1: LrcPtr<Spiral_wasm::Mut1>,
            v2: LrcPtr<Spiral_wasm::Mut2>,
            v3: LrcPtr<Spiral_wasm::Mut3>,
            v4: LrcPtr<Spiral_wasm::Mut4>,
            v5: Option<i64>,
        ) -> string {
            let v20: Spiral_wasm::US4 =
                defaultValue(Spiral_wasm::US4::US4_1, map(Spiral_wasm::method11(), v5));
            let v117: DateTime = match &v20 {
                Spiral_wasm::US4::US4_0(v20_0_0) => {
                    let v77: TimeSpan = TimeSpan::new_ticks(
                        ({
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        }) - (match &v20 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v77.hours(),
                        v77.minutes(),
                        v77.seconds(),
                        v77.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v118: string = Spiral_wasm::method12();
            let provider: string = if (v118.clone()) == string("") {
                string("M-d-y hh:mm:ss tt")
            } else {
                v118
            };
            v117.toString(provider)
        }
        pub fn method16() -> string {
            string("")
        }
        pub fn closure8(v0_1: LrcPtr<Spiral_wasm::Mut3>, v1: string, unitVar: ()) {
            let v3: string = append((v0_1.l0.get().clone()), (v1));
            v0_1.l0.set(v3);
            ()
        }
        pub fn method15(v0_1: char) -> string {
            let v2: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v8: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method17() -> string {
            string("\u{001b}[0m")
        }
        pub fn method14() -> string {
            let v6: string = Spiral_wasm::method15(getCharAt(toLower(string("Verbose")), 0_i32));
            let v9: &str = inline_colorization::color_bright_black;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method19(v0_1: Array<string>) -> string {
            let v2: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v9: () = {
                Spiral_wasm::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v18: () = {
                Spiral_wasm::closure8(v2.clone(), string("args"), ());
                ()
            };
            let v27: () = {
                Spiral_wasm::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v38: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{:?}", v0_1), ());
                ()
            };
            let v47: () = {
                Spiral_wasm::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method20(v0_1: string) -> string {
            trimEndChars(
                trimStartChars(v0_1, toArray(empty::<char>())),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn method18(
            v0_1: LrcPtr<Spiral_wasm::Mut0>,
            v1: LrcPtr<Spiral_wasm::Mut1>,
            v2: LrcPtr<Spiral_wasm::Mut2>,
            v3: LrcPtr<Spiral_wasm::Mut3>,
            v4: LrcPtr<Spiral_wasm::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: Array<string>,
        ) -> string {
            let v9: string = Spiral_wasm::method19(v8);
            Spiral_wasm::method20(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_wasm.main"),
                v9
            ))
        }
        pub fn closure9(v0_1: LrcPtr<Spiral_wasm::Mut0>, unitVar: ()) {
            let v2: i64 = (v0_1.l0.get().clone()) + 1_i64;
            v0_1.l0.set(v2);
            ()
        }
        pub fn closure11(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure10(unitVar: (), v0_1: string) {
            let v3: () = {
                Spiral_wasm::closure11(v0_1, ());
                ()
            };
            ()
        }
        pub fn method21(v0_1: string) {
            let v3: () = {
                Spiral_wasm::closure6((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                LrcPtr<Spiral_wasm::Mut4>,
                Option<i64>,
            ) = Spiral_wasm::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v37: () = {
                Spiral_wasm::closure9(patternInput.0.clone(), ());
                ()
            };
            println!("{}", v0_1.clone());
            ((patternInput.1.clone()).l0.get().clone())(v0_1)
        }
        pub fn closure5(v0_1: Array<string>, unitVar: ()) {
            if Spiral_wasm::method9(Spiral_wasm::US3::US3_0) {
                let v5: () = {
                    Spiral_wasm::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = Spiral_wasm::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method18(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_wasm::method10(v19, v20, v21, v22, v23, v24),
                    Spiral_wasm::method14(),
                    v0_1,
                ))
            };
        }
        pub fn method22() -> string {
            string("exception")
        }
        pub fn closure12(unitVar: (), v0_1: std::string::String) -> string {
            trimEndChars(
                trimStartChars(
                    fable_library_rust::String_::fromString(v0_1),
                    toArray(singleton('\\')),
                ),
                toArray(singleton('\\')),
            )
        }
        pub fn method23() -> Func1<std::string::String, string> {
            Func1::new(move |v: std::string::String| Spiral_wasm::closure12((), v))
        }
        pub fn method25() -> string {
            string("wasm")
        }
        pub fn method27(v0_1: string) -> string {
            let v2: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v9: () = {
                Spiral_wasm::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v18: () = {
                Spiral_wasm::closure8(v2.clone(), string("wasm_path"), ());
                ()
            };
            let v27: () = {
                Spiral_wasm::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v35: () = {
                Spiral_wasm::closure8(v2.clone(), v0_1, ());
                ()
            };
            let v44: () = {
                Spiral_wasm::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method26(
            v0_1: LrcPtr<Spiral_wasm::Mut0>,
            v1: LrcPtr<Spiral_wasm::Mut1>,
            v2: LrcPtr<Spiral_wasm::Mut2>,
            v3: LrcPtr<Spiral_wasm::Mut3>,
            v4: LrcPtr<Spiral_wasm::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
        ) -> string {
            let v9: string = Spiral_wasm::method27(v8);
            Spiral_wasm::method20(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_wasm.run"),
                v9
            ))
        }
        pub fn closure13(v0_1: string, unitVar: ()) {
            if Spiral_wasm::method9(Spiral_wasm::US3::US3_0) {
                let v5: () = {
                    Spiral_wasm::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = Spiral_wasm::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method26(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_wasm::method10(v19, v20, v21, v22, v23, v24),
                    Spiral_wasm::method14(),
                    v0_1,
                ))
            };
        }
        pub fn method31(
            v0_1: u8,
            v1: near_workspaces::Worker<near_workspaces::network::Sandbox>,
            v2: near_workspaces::Contract,
        ) -> string {
            let v4: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v11: () = {
                Spiral_wasm::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Spiral_wasm::closure8(v4.clone(), string("retry"), ());
                ()
            };
            let v29: () = {
                Spiral_wasm::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v37: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Spiral_wasm::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v55: () = {
                Spiral_wasm::closure8(v4.clone(), string("worker"), ());
                ()
            };
            let v63: () = {
                Spiral_wasm::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v68: std::string::String = format!("{:#?}", v1);
            let v101: () = {
                Spiral_wasm::closure8(v4.clone(), fable_library_rust::String_::fromString(v68), ());
                ()
            };
            let v109: () = {
                Spiral_wasm::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v118: () = {
                Spiral_wasm::closure8(v4.clone(), string("contract"), ());
                ()
            };
            let v126: () = {
                Spiral_wasm::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v131: std::string::String = format!("{:#?}", v2);
            let v164: () = {
                Spiral_wasm::closure8(
                    v4.clone(),
                    fable_library_rust::String_::fromString(v131),
                    (),
                );
                ()
            };
            let v173: () = {
                Spiral_wasm::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method30(
            v0_1: LrcPtr<Spiral_wasm::Mut0>,
            v1: LrcPtr<Spiral_wasm::Mut1>,
            v2: LrcPtr<Spiral_wasm::Mut2>,
            v3: LrcPtr<Spiral_wasm::Mut3>,
            v4: LrcPtr<Spiral_wasm::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: u8,
            v9: near_workspaces::Worker<near_workspaces::network::Sandbox>,
            v10: near_workspaces::Contract,
        ) -> string {
            let v11: string = Spiral_wasm::method31(v8, v9, v10);
            Spiral_wasm::method20(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_wasm.run"),
                v11
            ))
        }
        pub fn closure14(
            v0_1: u8,
            v1: near_workspaces::Worker<near_workspaces::network::Sandbox>,
            v2: near_workspaces::Contract,
            unitVar: (),
        ) {
            if Spiral_wasm::method9(Spiral_wasm::US3::US3_0) {
                let v7: () = {
                    Spiral_wasm::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = Spiral_wasm::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v24: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v23: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v22: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v21: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method30(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Spiral_wasm::method10(v21, v22, v23, v24, v25, v26),
                    Spiral_wasm::method14(),
                    v0_1,
                    v1,
                    v2,
                ))
            };
        }
        pub fn method33(v0_1: u8, v1: near_workspaces::result::ExecutionFinalResult) -> string {
            let v3: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v10: () = {
                Spiral_wasm::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Spiral_wasm::closure8(v3.clone(), string("retry"), ());
                ()
            };
            let v28: () = {
                Spiral_wasm::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v36: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_wasm::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v54: () = {
                Spiral_wasm::closure8(v3.clone(), string("result"), ());
                ()
            };
            let v62: () = {
                Spiral_wasm::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v67: std::string::String = format!("{:#?}", v1);
            let v100: () = {
                Spiral_wasm::closure8(v3.clone(), fable_library_rust::String_::fromString(v67), ());
                ()
            };
            let v109: () = {
                Spiral_wasm::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method32(
            v0_1: LrcPtr<Spiral_wasm::Mut0>,
            v1: LrcPtr<Spiral_wasm::Mut1>,
            v2: LrcPtr<Spiral_wasm::Mut2>,
            v3: LrcPtr<Spiral_wasm::Mut3>,
            v4: LrcPtr<Spiral_wasm::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: u8,
            v9: near_workspaces::result::ExecutionFinalResult,
        ) -> string {
            let v10: string = Spiral_wasm::method33(v8, v9);
            Spiral_wasm::method20(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_wasm.run"),
                v10
            ))
        }
        pub fn closure15(v0_1: u8, v1: near_workspaces::result::ExecutionFinalResult, unitVar: ()) {
            if Spiral_wasm::method9(Spiral_wasm::US3::US3_0) {
                let v6: () = {
                    Spiral_wasm::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = Spiral_wasm::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method32(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_wasm::method10(v20, v21, v22, v23, v24, v25),
                    Spiral_wasm::method14(),
                    v0_1,
                    v1,
                ))
            };
        }
        pub fn closure17(v0_1: std::string::String, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure16(unitVar: (), v0_1: std::string::String) {
            let v3: () = {
                Spiral_wasm::closure17(v0_1, ());
                ()
            };
            ()
        }
        pub fn method34() {
            let v2: () = {
                Spiral_wasm::closure6((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                LrcPtr<Spiral_wasm::Mut4>,
                Option<i64>,
            ) = Spiral_wasm::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v36: () = {
                Spiral_wasm::closure9(patternInput.0.clone(), ());
                ()
            };
            println!("{}", string(" "));
            ((patternInput.1.clone()).l0.get().clone())(string(" "))
        }
        pub fn closure18(unitVar: (), unitVar_1: ()) {
            if Spiral_wasm::method9(Spiral_wasm::US3::US3_2) {
                Spiral_wasm::method34();
            };
        }
        pub fn method35() -> string {
            let v6: string = Spiral_wasm::method15(getCharAt(toLower(string("Info")), 0_i32));
            let v9: &str = inline_colorization::color_bright_green;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method37(v0_1: u8, v1: f64, v2: u64) -> string {
            let v4: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v11: () = {
                Spiral_wasm::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Spiral_wasm::closure8(v4.clone(), string("retry"), ());
                ()
            };
            let v29: () = {
                Spiral_wasm::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v37: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Spiral_wasm::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v55: () = {
                Spiral_wasm::closure8(v4.clone(), string("total_gas_burnt_usd"), ());
                ()
            };
            let v63: () = {
                Spiral_wasm::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v71: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{:+.6}", v1), ());
                ()
            };
            let v79: () = {
                Spiral_wasm::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v88: () = {
                Spiral_wasm::closure8(v4.clone(), string("total_gas_burnt"), ());
                ()
            };
            let v96: () = {
                Spiral_wasm::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v104: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Spiral_wasm::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method36(
            v0_1: LrcPtr<Spiral_wasm::Mut0>,
            v1: LrcPtr<Spiral_wasm::Mut1>,
            v2: LrcPtr<Spiral_wasm::Mut2>,
            v3: LrcPtr<Spiral_wasm::Mut3>,
            v4: LrcPtr<Spiral_wasm::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: u8,
            v9: f64,
            v10: u64,
        ) -> string {
            let v11: string = Spiral_wasm::method37(v8, v9, v10);
            Spiral_wasm::method20(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("near_workspaces.print_usd"),
                v11
            ))
        }
        pub fn closure19(v0_1: u8, v1: u64, v2: f64, unitVar: ()) {
            if Spiral_wasm::method9(Spiral_wasm::US3::US3_2) {
                let v7: () = {
                    Spiral_wasm::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = Spiral_wasm::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v24: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v23: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v22: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v21: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method36(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Spiral_wasm::method10(v21, v22, v23, v24, v25, v26),
                    Spiral_wasm::method35(),
                    v0_1,
                    v2,
                    v1,
                ))
            };
        }
        pub fn method39(v0_1: bool, v1: f64, v2: f64, v3: u64, v4: u128) -> string {
            let v6: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v13: () = {
                Spiral_wasm::closure8(v6.clone(), string("{ "), ());
                ()
            };
            let v22: () = {
                Spiral_wasm::closure8(v6.clone(), string("is_success"), ());
                ()
            };
            let v31: () = {
                Spiral_wasm::closure8(v6.clone(), string(" = "), ());
                ()
            };
            let v42: () = {
                Spiral_wasm::closure8(
                    v6.clone(),
                    if v0_1 {
                        string("true")
                    } else {
                        string("false")
                    },
                    (),
                );
                ()
            };
            let v51: () = {
                Spiral_wasm::closure8(v6.clone(), string("; "), ());
                ()
            };
            let v60: () = {
                Spiral_wasm::closure8(v6.clone(), string("gas_burnt_usd"), ());
                ()
            };
            let v68: () = {
                Spiral_wasm::closure8(v6.clone(), string(" = "), ());
                ()
            };
            let v76: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{:+.6}", v1), ());
                ()
            };
            let v84: () = {
                Spiral_wasm::closure8(v6.clone(), string("; "), ());
                ()
            };
            let v93: () = {
                Spiral_wasm::closure8(v6.clone(), string("tokens_burnt_usd"), ());
                ()
            };
            let v101: () = {
                Spiral_wasm::closure8(v6.clone(), string(" = "), ());
                ()
            };
            let v109: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{:+.6}", v2), ());
                ()
            };
            let v117: () = {
                Spiral_wasm::closure8(v6.clone(), string("; "), ());
                ()
            };
            let v126: () = {
                Spiral_wasm::closure8(v6.clone(), string("gas_burnt"), ());
                ()
            };
            let v134: () = {
                Spiral_wasm::closure8(v6.clone(), string(" = "), ());
                ()
            };
            let v142: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v150: () = {
                Spiral_wasm::closure8(v6.clone(), string("; "), ());
                ()
            };
            let v159: () = {
                Spiral_wasm::closure8(v6.clone(), string("tokens_burnt"), ());
                ()
            };
            let v167: () = {
                Spiral_wasm::closure8(v6.clone(), string(" = "), ());
                ()
            };
            let v172: std::string::String = format!("{:#?}", v4);
            let v205: () = {
                Spiral_wasm::closure8(
                    v6.clone(),
                    fable_library_rust::String_::fromString(v172),
                    (),
                );
                ()
            };
            let v214: () = {
                Spiral_wasm::closure8(v6.clone(), string(" }"), ());
                ()
            };
            v6.l0.get().clone()
        }
        pub fn method38(
            v0_1: LrcPtr<Spiral_wasm::Mut0>,
            v1: LrcPtr<Spiral_wasm::Mut1>,
            v2: LrcPtr<Spiral_wasm::Mut2>,
            v3: LrcPtr<Spiral_wasm::Mut3>,
            v4: LrcPtr<Spiral_wasm::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: bool,
            v9: f64,
            v10: f64,
            v11: u64,
            v12: u128,
        ) -> string {
            let v13: string = Spiral_wasm::method39(v8, v9, v10, v11, v12);
            Spiral_wasm::method20(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("near_workspaces.print_usd / outcome"),
                v13
            ))
        }
        pub fn closure21(v0_1: bool, v1: u64, v2: f64, v3: u128, v4: f64, unitVar: ()) {
            if Spiral_wasm::method9(Spiral_wasm::US3::US3_2) {
                let v9: () = {
                    Spiral_wasm::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = Spiral_wasm::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v28: Option<i64> = patternInput.5.clone();
                let v27: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v26: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v25: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v24: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v23: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method38(
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    Spiral_wasm::method10(v23, v24, v25, v26, v27, v28),
                    Spiral_wasm::method35(),
                    v0_1,
                    v2,
                    v4,
                    v1,
                    v3,
                ))
            };
        }
        pub fn closure20(unitVar: (), v0_1: near_workspaces::result::ExecutionOutcome) {
            let v2: bool = v0_1.clone().is_success();
            let v4: near_workspaces::types::Gas = v0_1.clone().gas_burnt;
            let v6: u64 = v4.as_gas();
            let v12: f64 = ((v6 as f64) / 10000000000000000.0_f64) * 6.68_f64;
            let v14: near_workspaces::types::NearToken = v0_1.tokens_burnt;
            let v16: u128 = v14.as_yoctonear();
            let v23: () = {
                Spiral_wasm::closure21(
                    v2,
                    v6,
                    v12,
                    v16.clone(),
                    ((v16 as f64) / 1E+24_f64) * 6.68_f64,
                    (),
                );
                ()
            };
            ()
        }
        pub fn method41(
            v0_1: Result<
                near_workspaces::result::ExecutionSuccess,
                near_workspaces::result::ExecutionFailure,
            >,
        ) -> string {
            let v2: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v9: () = {
                Spiral_wasm::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v18: () = {
                Spiral_wasm::closure8(v2.clone(), string("result2"), ());
                ()
            };
            let v27: () = {
                Spiral_wasm::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v32: std::string::String = format!("{:#?}", v0_1);
            let v65: () = {
                Spiral_wasm::closure8(v2.clone(), fable_library_rust::String_::fromString(v32), ());
                ()
            };
            let v74: () = {
                Spiral_wasm::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method40(
            v0_1: LrcPtr<Spiral_wasm::Mut0>,
            v1: LrcPtr<Spiral_wasm::Mut1>,
            v2: LrcPtr<Spiral_wasm::Mut2>,
            v3: LrcPtr<Spiral_wasm::Mut3>,
            v4: LrcPtr<Spiral_wasm::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: Result<
                near_workspaces::result::ExecutionSuccess,
                near_workspaces::result::ExecutionFailure,
            >,
        ) -> string {
            let v9: string = Spiral_wasm::method41(v8);
            Spiral_wasm::method20(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_wasm.run"),
                v9
            ))
        }
        pub fn closure22(
            v0_1: Result<
                near_workspaces::result::ExecutionSuccess,
                near_workspaces::result::ExecutionFailure,
            >,
            unitVar: (),
        ) {
            if Spiral_wasm::method9(Spiral_wasm::US3::US3_0) {
                let v5: () = {
                    Spiral_wasm::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = Spiral_wasm::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method40(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_wasm::method10(v19, v20, v21, v22, v23, v24),
                    Spiral_wasm::method14(),
                    v0_1,
                ))
            };
        }
        pub fn method42(
            v0_1: near_workspaces::result::ExecutionFinalResult,
        ) -> near_workspaces::result::ExecutionFinalResult {
            v0_1
        }
        pub fn method44(v0_1: i32, v1: Vec<&near_workspaces::result::ExecutionOutcome>) -> string {
            let v3: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v10: () = {
                Spiral_wasm::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Spiral_wasm::closure8(v3.clone(), string("receipt_failures_len"), ());
                ()
            };
            let v28: () = {
                Spiral_wasm::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v36: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_wasm::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v54: () = {
                Spiral_wasm::closure8(v3.clone(), string("receipt_failures"), ());
                ()
            };
            let v62: () = {
                Spiral_wasm::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v67: std::string::String = format!("{:#?}", v1);
            let v100: () = {
                Spiral_wasm::closure8(v3.clone(), fable_library_rust::String_::fromString(v67), ());
                ()
            };
            let v109: () = {
                Spiral_wasm::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method43(
            v0_1: LrcPtr<Spiral_wasm::Mut0>,
            v1: LrcPtr<Spiral_wasm::Mut1>,
            v2: LrcPtr<Spiral_wasm::Mut2>,
            v3: LrcPtr<Spiral_wasm::Mut3>,
            v4: LrcPtr<Spiral_wasm::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: Vec<&near_workspaces::result::ExecutionOutcome>,
        ) -> string {
            let v10: string = Spiral_wasm::method44(v8, v9);
            Spiral_wasm::method20(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_wasm.run"),
                v10
            ))
        }
        pub fn closure23(
            v0_1: Vec<&near_workspaces::result::ExecutionOutcome>,
            v1: i32,
            unitVar: (),
        ) {
            if Spiral_wasm::method9(Spiral_wasm::US3::US3_0) {
                let v6: () = {
                    Spiral_wasm::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = Spiral_wasm::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method43(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_wasm::method10(v20, v21, v22, v23, v24, v25),
                    Spiral_wasm::method14(),
                    v1,
                    v0_1,
                ))
            };
        }
        pub fn method45(
            v0_1: near_workspaces::result::ExecutionFinalResult,
        ) -> near_workspaces::result::ExecutionFinalResult {
            v0_1
        }
        pub fn method47(v0_1: i32, v1: Vec<near_workspaces::result::ExecutionOutcome>) -> string {
            let v3: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v10: () = {
                Spiral_wasm::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Spiral_wasm::closure8(v3.clone(), string("receipt_outcomes_len"), ());
                ()
            };
            let v28: () = {
                Spiral_wasm::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v36: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_wasm::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v54: () = {
                Spiral_wasm::closure8(v3.clone(), string("receipt_outcomes"), ());
                ()
            };
            let v62: () = {
                Spiral_wasm::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v67: std::string::String = format!("{:#?}", v1);
            let v100: () = {
                Spiral_wasm::closure8(v3.clone(), fable_library_rust::String_::fromString(v67), ());
                ()
            };
            let v109: () = {
                Spiral_wasm::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method46(
            v0_1: LrcPtr<Spiral_wasm::Mut0>,
            v1: LrcPtr<Spiral_wasm::Mut1>,
            v2: LrcPtr<Spiral_wasm::Mut2>,
            v3: LrcPtr<Spiral_wasm::Mut3>,
            v4: LrcPtr<Spiral_wasm::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: Vec<near_workspaces::result::ExecutionOutcome>,
        ) -> string {
            let v10: string = Spiral_wasm::method47(v8, v9);
            Spiral_wasm::method20(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_wasm.run"),
                v10
            ))
        }
        pub fn closure24(
            v0_1: Vec<near_workspaces::result::ExecutionOutcome>,
            v1: i32,
            unitVar: (),
        ) {
            if Spiral_wasm::method9(Spiral_wasm::US3::US3_0) {
                let v6: () = {
                    Spiral_wasm::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = Spiral_wasm::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method46(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_wasm::method10(v20, v21, v22, v23, v24, v25),
                    Spiral_wasm::method14(),
                    v1,
                    v0_1,
                ))
            };
        }
        pub fn method49(
            v0_1: Result<std::string::String, near_workspaces::error::Error>,
        ) -> string {
            let v2: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v9: () = {
                Spiral_wasm::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v18: () = {
                Spiral_wasm::closure8(v2.clone(), string("json"), ());
                ()
            };
            let v27: () = {
                Spiral_wasm::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v32: std::string::String = format!("{:#?}", v0_1);
            let v65: () = {
                Spiral_wasm::closure8(v2.clone(), fable_library_rust::String_::fromString(v32), ());
                ()
            };
            let v74: () = {
                Spiral_wasm::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method48(
            v0_1: LrcPtr<Spiral_wasm::Mut0>,
            v1: LrcPtr<Spiral_wasm::Mut1>,
            v2: LrcPtr<Spiral_wasm::Mut2>,
            v3: LrcPtr<Spiral_wasm::Mut3>,
            v4: LrcPtr<Spiral_wasm::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: Result<std::string::String, near_workspaces::error::Error>,
        ) -> string {
            let v9: string = Spiral_wasm::method49(v8);
            Spiral_wasm::method20(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_wasm.run"),
                v9
            ))
        }
        pub fn closure25(
            v0_1: Result<std::string::String, near_workspaces::error::Error>,
            unitVar: (),
        ) {
            if Spiral_wasm::method9(Spiral_wasm::US3::US3_0) {
                let v5: () = {
                    Spiral_wasm::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = Spiral_wasm::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method48(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_wasm::method10(v19, v20, v21, v22, v23, v24),
                    Spiral_wasm::method14(),
                    v0_1,
                ))
            };
        }
        pub fn method51(
            v0_1: Result<std::string::String, near_workspaces::error::Error>,
        ) -> string {
            let v2: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v9: () = {
                Spiral_wasm::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v18: () = {
                Spiral_wasm::closure8(v2.clone(), string("borsh"), ());
                ()
            };
            let v27: () = {
                Spiral_wasm::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v32: std::string::String = format!("{:#?}", v0_1);
            let v65: () = {
                Spiral_wasm::closure8(v2.clone(), fable_library_rust::String_::fromString(v32), ());
                ()
            };
            let v74: () = {
                Spiral_wasm::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method50(
            v0_1: LrcPtr<Spiral_wasm::Mut0>,
            v1: LrcPtr<Spiral_wasm::Mut1>,
            v2: LrcPtr<Spiral_wasm::Mut2>,
            v3: LrcPtr<Spiral_wasm::Mut3>,
            v4: LrcPtr<Spiral_wasm::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: Result<std::string::String, near_workspaces::error::Error>,
        ) -> string {
            let v9: string = Spiral_wasm::method51(v8);
            Spiral_wasm::method20(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_wasm.run"),
                v9
            ))
        }
        pub fn closure26(
            v0_1: Result<std::string::String, near_workspaces::error::Error>,
            unitVar: (),
        ) {
            if Spiral_wasm::method9(Spiral_wasm::US3::US3_0) {
                let v5: () = {
                    Spiral_wasm::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = Spiral_wasm::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method50(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_wasm::method10(v19, v20, v21, v22, v23, v24),
                    Spiral_wasm::method14(),
                    v0_1,
                ))
            };
        }
        pub fn method52(
            v0_1: i32,
            v1: u8,
            v2: Vec<&near_workspaces::result::ExecutionOutcome>,
        ) -> string {
            let v4: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v11: () = {
                Spiral_wasm::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Spiral_wasm::closure8(v4.clone(), string("receipt_outcomes_len"), ());
                ()
            };
            let v29: () = {
                Spiral_wasm::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v37: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Spiral_wasm::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v55: () = {
                Spiral_wasm::closure8(v4.clone(), string("retry"), ());
                ()
            };
            let v63: () = {
                Spiral_wasm::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v71: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v79: () = {
                Spiral_wasm::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v88: () = {
                Spiral_wasm::closure8(v4.clone(), string("receipt_failures"), ());
                ()
            };
            let v96: () = {
                Spiral_wasm::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v101: std::string::String = format!("{:#?}", v2);
            let v134: () = {
                Spiral_wasm::closure8(
                    v4.clone(),
                    fable_library_rust::String_::fromString(v101),
                    (),
                );
                ()
            };
            let v143: () = {
                Spiral_wasm::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method29(
            v0_1: Vec<u8>,
            v1: u8,
        ) -> std::pin::Pin<
            Box<dyn std::future::Future<Output = Result<Spiral_wasm::US7, anyhow::Error>>>,
        > {
            let v3: bool = true;
            let __future_init = Box::pin(
                /*;
                let v5: bool = */
                async move {
                    /*;
                    let v7: bool = */
 //;
                    let v9: Result<
                        near_workspaces::Worker<near_workspaces::network::Sandbox>,
                        near_workspaces::error::Error,
                    > = near_workspaces::sandbox().await;
                    let v11: near_workspaces::Worker<near_workspaces::network::Sandbox> = v9?;
                    let v13: near_workspaces::Worker<near_workspaces::network::Sandbox> =
                        v11.clone();
                    let v15: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                Output = Result<
                                    near_workspaces::Contract,
                                    near_workspaces::error::Error,
                                >,
                            >,
                        >,
                    > = Box::pin(v13.dev_deploy(&v0_1));
                    let v17: Result<near_workspaces::Contract, near_workspaces::error::Error> =
                        v15.await;
                    let v19: near_workspaces::Contract = v17?;
                    let v22: () = {
                        Spiral_wasm::closure14(v1, v11, v19.clone(), ());
                        ()
                    };
                    let v64: near_workspaces::operations::CallTransaction =
                        v19.call(&*string("state_main"));
                    let v66: near_workspaces::types::Gas =
                        near_workspaces::types::Gas::from_tgas(300);
                    let v68: near_workspaces::operations::CallTransaction = v64.gas(v66);
                    let v70: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                Output = Result<
                                    near_workspaces::result::ExecutionFinalResult,
                                    near_workspaces::error::Error,
                                >,
                            >,
                        >,
                    > = Box::pin(v68.transact());
                    let v72: Result<
                        near_workspaces::result::ExecutionFinalResult,
                        near_workspaces::error::Error,
                    > = v70.await;
                    let v74: near_workspaces::result::ExecutionFinalResult = v72?;
                    let v77: () = {
                        Spiral_wasm::closure15(v1, v74.clone(), ());
                        ()
                    };
                    let v118: Vec<&str> = v74.logs();
                    let v120: bool = true;
                    let _vec_map: Vec<_> = v118
                        .into_iter()
                        .map(|x| {
                            //;
                            let v122: &str = x;
                            let v125: std::string::String = String::from(v122);
                            let v148: bool = true;
                            v125
                        })
                        .collect::<Vec<_>>();
                    let v150: Vec<std::string::String> = _vec_map;
                    let v153: bool = true;
                    v150.iter().for_each(|x| {
                        Func1::new(move |v: std::string::String| Spiral_wasm::closure16((), v))(
                            x.clone(),
                        );
                    }); //;
                    let v156: () = {
                        Spiral_wasm::closure18((), ());
                        ()
                    };
                    let v160: near_workspaces::types::Gas = v74.clone().total_gas_burnt;
                    let v162: u64 = v160.as_gas();
                    let v171: () = {
                        Spiral_wasm::closure19(
                            v1,
                            v162,
                            ((v162 as f64) / 10000000000000000.0_f64) * 6.68_f64,
                            (),
                        );
                        ()
                    };
                    let v212: near_workspaces::result::ExecutionFinalResult = v74.clone();
                    let v214: Vec<&near_workspaces::result::ExecutionOutcome> = v212.outcomes();
                    let v216 = v214.into_iter();
                    let v218 = v216.cloned();
                    let v221: bool = true;
                    v218.for_each(|x| {
                        Func1::new(move |v_1: near_workspaces::result::ExecutionOutcome| {
                            Spiral_wasm::closure20((), v_1)
                        })(x)
                    });
                    let v226: () = {
                        Spiral_wasm::closure22(v74.clone().into_result(), ());
                        ()
                    };
                    let v266: near_workspaces::result::ExecutionFinalResult =
                        Spiral_wasm::method42(v74.clone());
                    let v268: Vec<&near_workspaces::result::ExecutionOutcome> =
                        v266.receipt_failures();
                    let v271: i32 = v268.clone().len() as i32;
                    let v280: () = {
                        Spiral_wasm::closure23(v268.clone(), v271, ());
                        ()
                    };
                    let v320: near_workspaces::result::ExecutionFinalResult =
                        Spiral_wasm::method45(v74.clone());
                    let v322: &[near_workspaces::result::ExecutionOutcome] =
                        v320.receipt_outcomes();
                    let v324: Vec<near_workspaces::result::ExecutionOutcome> = v322.into();
                    let v327: i32 = v324.clone().len() as i32;
                    let v336: () = {
                        Spiral_wasm::closure24(v324, v327, ());
                        ()
                    };
                    let v380: () = {
                        Spiral_wasm::closure25(v74.clone().json(), ());
                        ()
                    };
                    let v424: () = {
                        Spiral_wasm::closure26(v74.borsh(), ());
                        ()
                    };
                    let v464: string = Spiral_wasm::method52(v327, v1, v268);
                    let v488: Result<Spiral_wasm::US7, anyhow::Error> = if (v271) > 0_i32 {
                        Ok::<Spiral_wasm::US7, anyhow::Error>(Spiral_wasm::US7::US7_0(v464.clone()))
                    } else {
                        if (v327) > 1_i32 {
                            Ok::<Spiral_wasm::US7, anyhow::Error>(Spiral_wasm::US7::US7_1)
                        } else {
                            let v472: anyhow::Error = anyhow::anyhow!(v464);
                            Err(v472)
                        }
                    };
                    let v491: string = string("}");
                    let v496: bool = true;
                    let _fix_closure_v493 = v488;
                    let v503: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v493 "), (v491))),
                                string("); "),
                            )),
                            string(""),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v504: bool = true;
                    _fix_closure_v493
                },
            ); // rust.fix_closure';
            let v506 = __future_init;
            v506
        }
        pub fn closure27(unitVar: (), v0_1: anyhow::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method53() -> Func1<anyhow::Error, std::string::String> {
            Func1::new(move |v: anyhow::Error| Spiral_wasm::closure27((), v))
        }
        pub fn closure28(unitVar: (), v0_1: Spiral_wasm::US7) -> Spiral_wasm::US9 {
            Spiral_wasm::US9::US9_0(v0_1)
        }
        pub fn method54() -> Func1<Spiral_wasm::US7, Spiral_wasm::US9> {
            Func1::new(move |v: Spiral_wasm::US7| Spiral_wasm::closure28((), v))
        }
        pub fn closure29(unitVar: (), v0_1: std::string::String) -> Spiral_wasm::US9 {
            Spiral_wasm::US9::US9_1(v0_1)
        }
        pub fn method55() -> Func1<std::string::String, Spiral_wasm::US9> {
            Func1::new(move |v: std::string::String| Spiral_wasm::closure29((), v))
        }
        pub fn method56() -> string {
            let v6: string = Spiral_wasm::method15(getCharAt(toLower(string("Warning")), 0_i32));
            let v9: &str = inline_colorization::color_yellow;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method58(v0_1: u8, v1: std::string::String) -> string {
            let v3: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v10: () = {
                Spiral_wasm::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Spiral_wasm::closure8(v3.clone(), string("retry"), ());
                ()
            };
            let v28: () = {
                Spiral_wasm::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v36: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_wasm::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v54: () = {
                Spiral_wasm::closure8(v3.clone(), string("error"), ());
                ()
            };
            let v62: () = {
                Spiral_wasm::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v67: std::string::String = format!("{:#?}", v1);
            let v100: () = {
                Spiral_wasm::closure8(v3.clone(), fable_library_rust::String_::fromString(v67), ());
                ()
            };
            let v109: () = {
                Spiral_wasm::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method57(
            v0_1: LrcPtr<Spiral_wasm::Mut0>,
            v1: LrcPtr<Spiral_wasm::Mut1>,
            v2: LrcPtr<Spiral_wasm::Mut2>,
            v3: LrcPtr<Spiral_wasm::Mut3>,
            v4: LrcPtr<Spiral_wasm::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: u8,
            v9: std::string::String,
        ) -> string {
            let v10: string = Spiral_wasm::method58(v8, v9);
            Spiral_wasm::method20(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_wasm.run / Error error"),
                v10
            ))
        }
        pub fn closure30(v0_1: u8, v1: std::string::String, unitVar: ()) {
            if Spiral_wasm::method9(Spiral_wasm::US3::US3_3) {
                let v6: () = {
                    Spiral_wasm::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = Spiral_wasm::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method57(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_wasm::method10(v20, v21, v22, v23, v24, v25),
                    Spiral_wasm::method56(),
                    v0_1,
                    v1,
                ))
            };
        }
        pub fn method59() {
            let v2: () = {
                Spiral_wasm::closure6((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                LrcPtr<Spiral_wasm::Mut4>,
                Option<i64>,
            ) = Spiral_wasm::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v36: () = {
                Spiral_wasm::closure9(patternInput.0.clone(), ());
                ()
            };
            println!("{}", string("\n"));
            ((patternInput.1.clone()).l0.get().clone())(string("\n"))
        }
        pub fn closure31(unitVar: (), unitVar_1: ()) {
            if Spiral_wasm::method9(Spiral_wasm::US3::US3_3) {
                Spiral_wasm::method59();
            };
        }
        pub fn closure32(v0_1: u8, v1: std::string::String, unitVar: ()) {
            if Spiral_wasm::method9(Spiral_wasm::US3::US3_3) {
                let v6: () = {
                    Spiral_wasm::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = Spiral_wasm::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method57(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_wasm::method10(v20, v21, v22, v23, v24, v25),
                    Spiral_wasm::method56(),
                    v0_1,
                    v1,
                ))
            };
        }
        pub fn closure33(unitVar: (), unitVar_1: ()) {
            if Spiral_wasm::method9(Spiral_wasm::US3::US3_3) {
                Spiral_wasm::method59();
            };
        }
        pub fn method60() -> string {
            let v6: string = Spiral_wasm::method15(getCharAt(toLower(string("Critical")), 0_i32));
            let v9: &str = inline_colorization::color_bright_red;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method62(v0_1: u8, v1: string) -> string {
            let v3: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v10: () = {
                Spiral_wasm::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Spiral_wasm::closure8(v3.clone(), string("retry"), ());
                ()
            };
            let v28: () = {
                Spiral_wasm::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v36: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_wasm::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v54: () = {
                Spiral_wasm::closure8(v3.clone(), string("error"), ());
                ()
            };
            let v62: () = {
                Spiral_wasm::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v70: () = {
                Spiral_wasm::closure8(v3.clone(), v1, ());
                ()
            };
            let v79: () = {
                Spiral_wasm::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method61(
            v0_1: LrcPtr<Spiral_wasm::Mut0>,
            v1: LrcPtr<Spiral_wasm::Mut1>,
            v2: LrcPtr<Spiral_wasm::Mut2>,
            v3: LrcPtr<Spiral_wasm::Mut3>,
            v4: LrcPtr<Spiral_wasm::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: u8,
            v9: string,
        ) -> string {
            let v10: string = Spiral_wasm::method62(v8, v9);
            Spiral_wasm::method20(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_wasm.run / Ok (Some error)"),
                v10
            ))
        }
        pub fn closure34(v0_1: u8, v1: string, unitVar: ()) {
            if Spiral_wasm::method9(Spiral_wasm::US3::US3_4) {
                let v6: () = {
                    Spiral_wasm::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = Spiral_wasm::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method61(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_wasm::method10(v20, v21, v22, v23, v24, v25),
                    Spiral_wasm::method60(),
                    v0_1,
                    v1,
                ))
            };
        }
        pub fn method28(
            v0_1: Vec<u8>,
            v1: u8,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Spiral_wasm::US8>>> {
            let v3: bool = true;
            let __future_init = Box::pin(
                /*;
                let v5: bool = */
                async move {
                    /*;
                    let v7: bool = */
 //;
                    let v8: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                Output = Result<Spiral_wasm::US7, anyhow::Error>,
                            >,
                        >,
                    > = Spiral_wasm::method29(v0_1.clone(), v1);
                    let v10: Result<Spiral_wasm::US7, anyhow::Error> = v8.await;
                    let v11 = Spiral_wasm::method53();
                    let v23: Result<Spiral_wasm::US7, std::string::String> =
                        v10.map_err(|x| v11(x));
                    let v26 = Spiral_wasm::method54();
                    let v27 = Spiral_wasm::method55();
                    let v28: Spiral_wasm::US9 = match &v23 {
                        Err(v23_1_0) => v27(v23_1_0.clone()),
                        Ok(v23_0_0) => v26(v23_0_0.clone()),
                    };
                    let v270: Spiral_wasm::US8 = match &v28 {
                        Spiral_wasm::US9::US9_0(v28_0_0) => {
                            let v29: Spiral_wasm::US7 = v28_0_0.clone();
                            match &v29 {
                                Spiral_wasm::US7::US7_0(v29_0_0) => {
                                    let v61: string = match &v29 {
                                        Spiral_wasm::US7::US7_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone();
                                    let v64: () = {
                                        Spiral_wasm::closure34(v1, v61.clone(), ());
                                        ()
                                    };
                                    let v105: bool = true;
                                    let __future_init = Box::pin(
                                        /*;
                                        let v107: bool = */
                                        async move {
                                            /*;
                                            let v109: bool = */
 //;
                                            let v112: string = string("}");
                                            let v118: bool = true;
                                            let _fix_closure_v115 =
                                                (v1, Spiral_wasm::US7::US7_0(v61));
                                            let v125: string = append(
                                                (append(
                                                    (append(
                                                        (append(
                                                            string("true; _fix_closure_v115 "),
                                                            (v112),
                                                        )),
                                                        string("); "),
                                                    )),
                                                    string(""),
                                                )),
                                                string(" // rust.fix_closure\'"),
                                            );
                                            let v126: bool = true;
                                            _fix_closure_v115
                                        },
                                    ); // rust.fix_closure';
                                    let v128 = __future_init;
                                    let v130: std::pin::Pin<
                                        Box<
                                            dyn std::future::Future<
                                                Output = (u8, Spiral_wasm::US7),
                                            >,
                                        >,
                                    > = v128;
                                    let patternInput_2: (u8, Spiral_wasm::US7) = v130.await;
                                    Spiral_wasm::US8::US8_1(
                                        patternInput_2.0.clone(),
                                        patternInput_2.1.clone(),
                                    )
                                }
                                _ => {
                                    let v31: bool = true;
                                    let __future_init = Box::pin(
                                        /*;
                                        let v33: bool = */
                                        async move {
                                            /*;
                                            let v35: bool = */
 //;
                                            let v38: string = string("}");
                                            let v44: bool = true;
                                            let _fix_closure_v41 = (v1, Spiral_wasm::US7::US7_1);
                                            let v51: string = append(
                                                (append(
                                                    (append(
                                                        (append(
                                                            string("true; _fix_closure_v41 "),
                                                            (v38),
                                                        )),
                                                        string("); "),
                                                    )),
                                                    string(""),
                                                )),
                                                string(" // rust.fix_closure\'"),
                                            );
                                            let v52: bool = true;
                                            _fix_closure_v41
                                        },
                                    ); // rust.fix_closure';
                                    let v54 = __future_init;
                                    let v56: std::pin::Pin<
                                        Box<
                                            dyn std::future::Future<
                                                Output = (u8, Spiral_wasm::US7),
                                            >,
                                        >,
                                    > = v54;
                                    let patternInput_1: (u8, Spiral_wasm::US7) = v56.await;
                                    Spiral_wasm::US8::US8_0(
                                        patternInput_1.0.clone(),
                                        patternInput_1.1.clone(),
                                    )
                                }
                            }
                        }
                        Spiral_wasm::US9::US9_1(v28_1_0) => {
                            let v137: std::string::String = v28_1_0.clone();
                            if (v1) >= 15_u8 {
                                let v141: () = {
                                    Spiral_wasm::closure30(v1, v137.clone(), ());
                                    ()
                                };
                                let v183: () = {
                                    Spiral_wasm::closure31((), ());
                                    ()
                                };
                                let v187: bool = true;
                                let __future_init = Box::pin(
                                    /*;
                                    let v189: bool = */
                                    async move {
                                        /*;
                                        let v191: bool = */
 //;
                                        let v194: string = string("}");
                                        let v200: bool = true;
                                        let _fix_closure_v197 = (v1, Spiral_wasm::US7::US7_1);
                                        let v207: string = append(
                                            (append(
                                                (append(
                                                    (append(
                                                        string("true; _fix_closure_v197 "),
                                                        (v194),
                                                    )),
                                                    string("); "),
                                                )),
                                                string(""),
                                            )),
                                            string(" // rust.fix_closure\'"),
                                        );
                                        let v208: bool = true;
                                        _fix_closure_v197
                                    },
                                ); // rust.fix_closure';
                                let v210 = __future_init;
                                let v212: std::pin::Pin<
                                    Box<dyn std::future::Future<Output = (u8, Spiral_wasm::US7)>>,
                                > = v210;
                                let patternInput: (u8, Spiral_wasm::US7) = v212.await;
                                Spiral_wasm::US8::US8_0(
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                )
                            } else {
                                let v219: () = {
                                    Spiral_wasm::closure32(v1, v137, ());
                                    ()
                                };
                                let v261: () = {
                                    Spiral_wasm::closure33((), ());
                                    ()
                                };
                                let v265: std::pin::Pin<
                                    Box<dyn std::future::Future<Output = Spiral_wasm::US8>>,
                                > = Spiral_wasm::method28(v0_1.clone(), (v1) + 1_u8);
                                v265.await
                            }
                        }
                    };
                    let v273: string = string("}");
                    let v278: bool = true;
                    let _fix_closure_v275 = v270;
                    let v285: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v275 "), (v273))),
                                string("); "),
                            )),
                            string(""),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v286: bool = true;
                    _fix_closure_v275
                },
            ); // rust.fix_closure';
            let v288 = __future_init;
            v288
        }
        pub fn method64(v0_1: Spiral_wasm::US8) -> string {
            let v2: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v9: () = {
                Spiral_wasm::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v18: () = {
                Spiral_wasm::closure8(v2.clone(), string("retries"), ());
                ()
            };
            let v27: () = {
                Spiral_wasm::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v38: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{:?}", v0_1), ());
                ()
            };
            let v47: () = {
                Spiral_wasm::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method63(
            v0_1: LrcPtr<Spiral_wasm::Mut0>,
            v1: LrcPtr<Spiral_wasm::Mut1>,
            v2: LrcPtr<Spiral_wasm::Mut2>,
            v3: LrcPtr<Spiral_wasm::Mut3>,
            v4: LrcPtr<Spiral_wasm::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: Spiral_wasm::US8,
        ) -> string {
            let v9: string = Spiral_wasm::method64(v8);
            Spiral_wasm::method20(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_wasm.run"),
                v9
            ))
        }
        pub fn closure35(v0_1: Spiral_wasm::US8, unitVar: ()) {
            if Spiral_wasm::method9(Spiral_wasm::US3::US3_0) {
                let v5: () = {
                    Spiral_wasm::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = Spiral_wasm::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method63(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_wasm::method10(v19, v20, v21, v22, v23, v24),
                    Spiral_wasm::method14(),
                    v0_1,
                ))
            };
        }
        pub fn method65(v0_1: Spiral_wasm::US8, v1: Spiral_wasm::US7) -> string {
            let v3: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v10: () = {
                Spiral_wasm::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Spiral_wasm::closure8(v3.clone(), string("retries"), ());
                ()
            };
            let v28: () = {
                Spiral_wasm::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v39: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{:?}", v0_1), ());
                ()
            };
            let v48: () = {
                Spiral_wasm::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v57: () = {
                Spiral_wasm::closure8(v3.clone(), string("error"), ());
                ()
            };
            let v65: () = {
                Spiral_wasm::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v76: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{:?}", v1), ());
                ()
            };
            let v85: () = {
                Spiral_wasm::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method24(
            v0_1: clap::ArgMatches,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<u8, anyhow::Error>>>>
        {
            let v2: bool = true;
            let __future_init = Box::pin(
                /*;
                let v4: bool = */
                async move {
                    /*;
                    let v6: bool = */
 //;
                    let v7: string = Spiral_wasm::method25();
                    let v10: &str = &*v7;
                    let v33: Option<std::string::String> =
                        clap::ArgMatches::get_one(&v0_1, v10).cloned();
                    let v47: Spiral_wasm::US0 =
                        defaultValue(Spiral_wasm::US0::US0_1, map(Spiral_wasm::method2(), v33));
                    let v54: std::string::String = match &v47 {
                        Spiral_wasm::US0::US0_0(v47_0_0) => match &v47 {
                            Spiral_wasm::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v56: string = fable_library_rust::String_::fromString(v54);
                    let v59: () = {
                        Spiral_wasm::closure13(v56.clone(), ());
                        ()
                    };
                    let v100: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v56);
                    let v104: std::pin::Pin<
                        Box<dyn std::future::Future<Output = Spiral_wasm::US8>>,
                    > = Spiral_wasm::method28(v100?, 1_u8);
                    let v106: Spiral_wasm::US8 = v104.await;
                    let v109: () = {
                        Spiral_wasm::closure35(v106.clone(), ());
                        ()
                    };
                    let v172: Result<u8, anyhow::Error> = match &v106 {
                        Spiral_wasm::US8::US8_0(v106_0_0, v106_0_1) => {
                            Ok::<u8, anyhow::Error>(v106_0_0.clone())
                        }
                        Spiral_wasm::US8::US8_1(v106_1_0, v106_1_1) => {
                            let v154: string =
                                Spiral_wasm::method65(v106.clone(), v106_1_1.clone());
                            let v156: anyhow::Error = anyhow::anyhow!(v154);
                            Err(v156)
                        }
                    };
                    let v175: string = string("}");
                    let v180: bool = true;
                    let _fix_closure_v177 = v172;
                    let v187: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v177 "), (v175))),
                                string("); "),
                            )),
                            string(""),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v188: bool = true;
                    _fix_closure_v177
                },
            ); // rust.fix_closure';
            let v190 = __future_init;
            v190
        }
        pub fn closure36(unitVar: (), v0_1: u8) -> Spiral_wasm::US10 {
            Spiral_wasm::US10::US10_0(v0_1)
        }
        pub fn method66() -> Func1<u8, Spiral_wasm::US10> {
            Func1::new(move |v: u8| Spiral_wasm::closure36((), v))
        }
        pub fn closure37(unitVar: (), v0_1: std::string::String) -> Spiral_wasm::US10 {
            Spiral_wasm::US10::US10_1(v0_1)
        }
        pub fn method67() -> Func1<std::string::String, Spiral_wasm::US10> {
            Func1::new(move |v: std::string::String| Spiral_wasm::closure37((), v))
        }
        pub fn closure0(unitVar: (), v0_1: Array<string>) -> i32 {
            let v1: clap::Command = Spiral_wasm::method0();
            let v3: clap::ArgMatches = clap::Command::get_matches(v1);
            let v4: string = Spiral_wasm::method1();
            let v7: &str = &*v4;
            let v30: Option<std::string::String> =
                clap::ArgMatches::get_one(&v3.clone(), v7).cloned();
            let v44: Spiral_wasm::US0 =
                defaultValue(Spiral_wasm::US0::US0_1, map(Spiral_wasm::method2(), v30));
            let v100: Spiral_wasm::US1 = match &v44 {
                Spiral_wasm::US0::US0_0(v44_0_0) => {
                    let v50: string = fable_library_rust::String_::fromString(
                        match &v44 {
                            Spiral_wasm::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    );
                    let v55: Spiral_wasm::US2 = if string("Verbose") == (v50.clone()) {
                        Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_0)
                    } else {
                        Spiral_wasm::US2::US2_1
                    };
                    Spiral_wasm::US1::US1_0(match &v55 {
                        Spiral_wasm::US2::US2_0(v55_0_0) => Spiral_wasm::US2::US2_0(
                            match &v55 {
                                Spiral_wasm::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                        ),
                        _ => {
                            let v62: Spiral_wasm::US2 = if string("Debug") == (v50.clone()) {
                                Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_1)
                            } else {
                                Spiral_wasm::US2::US2_1
                            };
                            match &v62 {
                                Spiral_wasm::US2::US2_0(v62_0_0) => Spiral_wasm::US2::US2_0(
                                    match &v62 {
                                        Spiral_wasm::US2::US2_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                ),
                                _ => {
                                    let v69: Spiral_wasm::US2 = if string("Info") == (v50.clone()) {
                                        Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_2)
                                    } else {
                                        Spiral_wasm::US2::US2_1
                                    };
                                    match &v69 {
                                        Spiral_wasm::US2::US2_0(v69_0_0) => {
                                            Spiral_wasm::US2::US2_0(
                                                match &v69 {
                                                    Spiral_wasm::US2::US2_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                                .clone(),
                                            )
                                        }
                                        _ => {
                                            let v76: Spiral_wasm::US2 =
                                                if string("Warning") == (v50.clone()) {
                                                    Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_3)
                                                } else {
                                                    Spiral_wasm::US2::US2_1
                                                };
                                            match &v76 {
                                                Spiral_wasm::US2::US2_0(v76_0_0) => {
                                                    Spiral_wasm::US2::US2_0(
                                                        match &v76 {
                                                            Spiral_wasm::US2::US2_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        }
                                                        .clone(),
                                                    )
                                                }
                                                _ => {
                                                    let v83: Spiral_wasm::US2 =
                                                        if string("Critical") == (v50.clone()) {
                                                            Spiral_wasm::US2::US2_0(
                                                                Spiral_wasm::US3::US3_4,
                                                            )
                                                        } else {
                                                            Spiral_wasm::US2::US2_1
                                                        };
                                                    match &v83 {
                                                        Spiral_wasm::US2::US2_0(v83_0_0) => {
                                                            Spiral_wasm::US2::US2_0(
                                                                match &v83 {
                                                                    Spiral_wasm::US2::US2_0(x) => {
                                                                        x.clone()
                                                                    }
                                                                    _ => unreachable!(),
                                                                }
                                                                .clone(),
                                                            )
                                                        }
                                                        _ => Spiral_wasm::US2::US2_1,
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    })
                }
                _ => Spiral_wasm::US1::US1_1,
            };
            let v107: Spiral_wasm::US2 = if let Spiral_wasm::US1::US1_0(v100_0_0) = &v100 {
                let v101: Spiral_wasm::US2 = v100_0_0.clone();
                if let Spiral_wasm::US2::US2_0(v101_0_0) = &v101 {
                    Spiral_wasm::US2::US2_0(v101_0_0.clone())
                } else {
                    Spiral_wasm::US2::US2_1
                }
            } else {
                Spiral_wasm::US2::US2_1
            };
            let v114: () = {
                Spiral_wasm::closure2(
                    match &v107 {
                        Spiral_wasm::US2::US2_0(v107_0_0) => match &v107 {
                            Spiral_wasm::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => Spiral_wasm::US3::US3_0,
                    },
                    (),
                );
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                LrcPtr<Spiral_wasm::Mut4>,
                Option<i64>,
            ) = Spiral_wasm::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v146: () = {
                Spiral_wasm::closure5(v0_1, ());
                ()
            };
            let v186: string = Spiral_wasm::method22();
            let v189: &str = &*v186;
            let v212: Option<std::string::String> =
                clap::ArgMatches::get_one(&v3.clone(), v189).cloned();
            let v214: Option<string> = map(Spiral_wasm::method23(), v212);
            let v303: Spiral_wasm::US7 =
                defaultValue(Spiral_wasm::US7::US7_1, map(Spiral_wasm::method8(), v214));
            let v307: std::pin::Pin<
                Box<dyn std::future::Future<Output = Result<u8, anyhow::Error>>>,
            > = Spiral_wasm::method24(v3);
            let v309 = tokio::runtime::Builder::new_multi_thread()
                .enable_all()
                .build()
                .unwrap();
            let v311: Result<u8, anyhow::Error> = v309.handle().block_on(v307);
            let v312 = Spiral_wasm::method53();
            let v324: Result<u8, std::string::String> = v311.map_err(|x| v312(x));
            let v327 = Spiral_wasm::method66();
            let v328 = Spiral_wasm::method67();
            let v329: Spiral_wasm::US10 = match &v324 {
                Err(v324_1_0) => v328(v324_1_0.clone()),
                Ok(v324_0_0) => v327(v324_0_0.clone()),
            };
            match &v329 {
                Spiral_wasm::US10::US10_0(v329_0_0) => {
                    if let Spiral_wasm::US7::US7_0(v303_0_0) = &v303 {
                        let v332: string = sprintf!(
                            "spiral_wasm.main / retries: {} / exception: \'{}\'",
                            v329_0_0.clone(),
                            v303_0_0.clone()
                        );
                        let v335: Result<(), string> = Err(v332);
                        v335.unwrap();
                        ()
                    }
                }
                Spiral_wasm::US10::US10_1(v329_1_0) => {
                    let v351: std::string::String = v329_1_0.clone();
                    if let Spiral_wasm::US7::US7_0(v303_0_0) = &v303 {
                        let v352: string = v303_0_0.clone();
                        if string("") == (v352.clone()) {
                            ()
                        } else {
                            if contains(
                                fable_library_rust::String_::fromString(v351.clone()),
                                v352.clone(),
                            ) {
                                ()
                            } else {
                                let v359: string = sprintf!(
                                    "spiral_wasm.main / exception: \'{}\' / error: {}",
                                    v352,
                                    v351
                                );
                                let v362: Result<(), string> = Err(v359);
                                v362.unwrap();
                                ()
                            }
                        }
                    } else {
                        let v380: u8 = v324.clone().unwrap();
                        ()
                    }
                }
            }
            0_i32
        }
        pub fn v0() -> Func1<Array<string>, i32> {
            static v0: OnceInit<Func1<Array<string>, i32>> = OnceInit::new();
            v0.get_or_init(|| Func1::new(move |v: Array<string>| Spiral_wasm::closure0((), v)))
                .clone()
        }
        pub fn main(args: Array<string>) -> i32 {
            (Spiral_wasm::v0())(args)
        }
    }
}
pub use module_fb49c4a9::*;
#[path = "../../../lib/fsharp/Common.rs"]
mod module_ad43931;
pub use module_ad43931::*;
#[path = "../../../lib/spiral/async_.rs"]
mod module_67c461a2;
pub use module_67c461a2::*;
#[path = "../../../lib/spiral/common.rs"]
mod module_181b15d6;
pub use module_181b15d6::*;
#[path = "../../../lib/spiral/crypto.rs"]
mod module_90d9c778;
pub use module_90d9c778::*;
#[path = "../../../lib/spiral/date_time.rs"]
mod module_e43a8385;
pub use module_e43a8385::*;
#[path = "../../../lib/spiral/file_system.rs"]
mod module_a7db9b47;
pub use module_a7db9b47::*;
#[path = "../../../lib/spiral/lib.rs"]
mod module_98e448fc;
pub use module_98e448fc::*;
#[path = "../../../lib/spiral/networking.rs"]
mod module_268024e5;
pub use module_268024e5::*;
#[path = "../../../lib/spiral/platform.rs"]
mod module_7d8ad484;
pub use module_7d8ad484::*;
#[path = "../../../lib/spiral/runtime.rs"]
mod module_485aae07;
pub use module_485aae07::*;
#[path = "../../../lib/spiral/sm.rs"]
mod module_582b4305;
pub use module_582b4305::*;
#[path = "../../../lib/spiral/threading.rs"]
mod module_d5afb6f5;
pub use module_d5afb6f5::*;
#[path = "../../../lib/spiral/trace.rs"]
mod module_9e77af3a;
pub use module_9e77af3a::*;
pub mod Polyglot {
    pub use crate::module_ad43931::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Spiral_wasm::main(array_from(args));
}
