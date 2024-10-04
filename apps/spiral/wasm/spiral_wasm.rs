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
mod module_fb49c4a9 {
    pub mod Spiral_wasm {
        use super::*;
        use fable_library_rust::DateTime_::DateTime;
        use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
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
        use fable_library_rust::Option_::getValue;
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
        pub trait IOsEnviron {
            fn environ(&self) -> LrcPtr<dyn Any>;
        }
        impl<V: IOsEnviron + Clone + 'static> IOsEnviron for LrcPtr<V> {
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
        impl core::fmt::Display for Spiral_wasm::US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US3 {
            US3_0,
            US3_1,
            US3_2,
            US3_3,
            US3_4,
        }
        impl core::fmt::Display for Spiral_wasm::US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US2 {
            US2_0(Spiral_wasm::US3),
            US2_1,
        }
        impl core::fmt::Display for Spiral_wasm::US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US1 {
            US1_0(Spiral_wasm::US2),
            US1_1,
        }
        impl core::fmt::Display for Spiral_wasm::US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut0 {
            pub l0: MutCell<i64>,
        }
        impl core::fmt::Display for Spiral_wasm::Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut1 {
            pub l0: MutCell<Func1<string, ()>>,
        }
        impl core::fmt::Display for Spiral_wasm::Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut2 {
            pub l0: MutCell<bool>,
        }
        impl core::fmt::Display for Spiral_wasm::Mut2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut3 {
            pub l0: MutCell<string>,
        }
        impl core::fmt::Display for Spiral_wasm::Mut3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut4 {
            pub l0: MutCell<Spiral_wasm::US3>,
        }
        impl core::fmt::Display for Spiral_wasm::Mut4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US4 {
            US4_0(string),
            US4_1,
        }
        impl core::fmt::Display for Spiral_wasm::US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US5 {
            US5_0(i64),
            US5_1,
        }
        impl core::fmt::Display for Spiral_wasm::US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US6 {
            US6_0(u8, Spiral_wasm::US4),
            US6_1(u8, Spiral_wasm::US4),
        }
        impl core::fmt::Display for Spiral_wasm::US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US7 {
            US7_0(Spiral_wasm::US4),
            US7_1(std::string::String),
        }
        impl core::fmt::Display for Spiral_wasm::US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US8 {
            US8_0(u8),
            US8_1(std::string::String),
        }
        impl core::fmt::Display for Spiral_wasm::US8 {
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
            let v21: clap::builder::ValueRange = if v10 == v7 {
                clap::builder::ValueRange::new(v7..)
            } else {
                let v19: string = string("clap::builder::ValueRange::new($0..=$1)");
                clap::builder::ValueRange::new(v7..=v10)
            };
            let v23: string = string("r#\"exception\"#");
            let v24: &'static str = r#"exception"#;
            let v26: clap::Arg = clap::Arg::new(v24);
            let v28: clap::Arg = v26.short('e');
            let v29: string = string("r#\"exception\"#");
            let v30: &'static str = r#"exception"#;
            let v32: clap::Arg = v28.long(v30);
            let v34: clap::Arg = v32.num_args(v21);
            let v36: clap::Arg = v34.require_equals(true);
            let v38: string = string("r#\"\"#");
            let v39: &str = r#""#;
            let v41: clap::Arg = v36.default_missing_value(v39);
            let v43: clap::Command = clap::Command::arg(v6, v41);
            let v45: string = string("r#\"trace_level\"#");
            let v46: &'static str = r#"trace_level"#;
            let v48: clap::Arg = clap::Arg::new(v46);
            let v50: clap::Arg = v48.short('t');
            let v51: string = string("r#\"trace_level\"#");
            let v52: &'static str = r#"trace_level"#;
            let v54: clap::Arg = v50.long(v52);
            let v77: Array<string> = toArray(ofArray(new_array(&[
                string("Verbose"),
                string("Debug"),
                string("Info"),
                string("Warning"),
                string("Critical"),
            ])));
            let v81: Vec<string> = v77.to_vec();
            let v83: bool = true;
            let _vec_map: Vec<_> = v81
                .into_iter()
                .map(|x| {
                    //;
                    let v85: string = x;
                    let v88: &str = &*v85;
                    let v109: std::string::String = String::from(v88);
                    let v129: Box<std::string::String> = Box::new(v109);
                    let v131: &'static mut std::string::String = Box::leak(v129);
                    let v133: clap::builder::PossibleValue =
                        clap::builder::PossibleValue::new(&**v131);
                    let v135: bool = true;
                    v133
                })
                .collect::<Vec<_>>();
            let v137: Vec<clap::builder::PossibleValue> = _vec_map;
            let v139: clap::builder::ValueParser = Into::<clap::builder::ValueParser>::into(
                clap::builder::PossibleValuesParser::new(v137),
            );
            let v141: clap::Arg = v54.value_parser(v139);
            let v143: clap::Command = clap::Command::arg(v43, v141);
            let v145: string = string("r#\"wasm\"#");
            let v146: &'static str = r#"wasm"#;
            let v148: clap::Arg = clap::Arg::new(v146);
            let v150: clap::Arg = v148.short('w');
            let v151: string = string("r#\"wasm\"#");
            let v152: &'static str = r#"wasm"#;
            let v154: clap::Arg = v150.long(v152);
            let v156: clap::Arg = v154.required(true);
            clap::Command::arg(v143, v156)
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
        pub fn method4() -> string {
            string("TRACE_LEVEL")
        }
        pub fn method6() -> string {
            string("")
        }
        pub fn closure3(unitVar: (), v0_1: string) -> Spiral_wasm::US4 {
            Spiral_wasm::US4::US4_0(v0_1)
        }
        pub fn method7() -> Func1<string, Spiral_wasm::US4> {
            Func1::new(move |v: string| Spiral_wasm::closure3((), v))
        }
        pub fn method5(v0_1: string) -> string {
            let v3: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
            let v5: bool = true;
            let _result_map_ = v3.map(|x| {
                //;
                let v7: std::string::String = x;
                let v9: string = fable_library_rust::String_::fromString(v7);
                let v11: bool = true;
                v9
            });
            let v13: Result<string, std::env::VarError> = _result_map_;
            let v14: string = Spiral_wasm::method6();
            v13.unwrap_or(v14)
        }
        pub fn method8() -> string {
            string("AUTOMATION")
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
            let v3: string = Spiral_wasm::method5(Spiral_wasm::method4());
            let v8: Spiral_wasm::US2 = if string("Verbose") == v3.clone() {
                Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_0)
            } else {
                Spiral_wasm::US2::US2_1
            };
            let _v1: (Spiral_wasm::US2, Spiral_wasm::US5) = (
                match &v8 {
                    Spiral_wasm::US2::US2_0(v8_0_0) => Spiral_wasm::US2::US2_0(match &v8 {
                        Spiral_wasm::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v15: Spiral_wasm::US2 = if string("Debug") == v3.clone() {
                            Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_1)
                        } else {
                            Spiral_wasm::US2::US2_1
                        };
                        match &v15 {
                            Spiral_wasm::US2::US2_0(v15_0_0) => {
                                Spiral_wasm::US2::US2_0(match &v15 {
                                    Spiral_wasm::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v22: Spiral_wasm::US2 = if string("Info") == v3.clone() {
                                    Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_2)
                                } else {
                                    Spiral_wasm::US2::US2_1
                                };
                                match &v22 {
                                    Spiral_wasm::US2::US2_0(v22_0_0) => {
                                        Spiral_wasm::US2::US2_0(match &v22 {
                                            Spiral_wasm::US2::US2_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v29: Spiral_wasm::US2 =
                                            if string("Warning") == v3.clone() {
                                                Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_3)
                                            } else {
                                                Spiral_wasm::US2::US2_1
                                            };
                                        match &v29 {
                                            Spiral_wasm::US2::US2_0(v29_0_0) => {
                                                Spiral_wasm::US2::US2_0(match &v29 {
                                                    Spiral_wasm::US2::US2_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v36: Spiral_wasm::US2 = if string("Critical")
                                                    == v3.clone()
                                                {
                                                    Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_4)
                                                } else {
                                                    Spiral_wasm::US2::US2_1
                                                };
                                                match &v36 {
                                                    Spiral_wasm::US2::US2_0(v36_0_0) => {
                                                        Spiral_wasm::US2::US2_0(match &v36 {
                                                            Spiral_wasm::US2::US2_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
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
                if Spiral_wasm::method5(Spiral_wasm::method8()) == string("True") {
                    Spiral_wasm::US5::US5_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                } else {
                    Spiral_wasm::US5::US5_1
                },
            );
            let v352: Spiral_wasm::US5 = _v1.1.clone();
            let v351: Spiral_wasm::US2 = _v1.0.clone();
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
                    l0: MutCell::new(match &v351 {
                        Spiral_wasm::US2::US2_0(v351_0_0) => match &v351 {
                            Spiral_wasm::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0_1,
                    }),
                }),
                match &v352 {
                    Spiral_wasm::US5::US5_0(v352_0_0) => Some(match &v352 {
                        Spiral_wasm::US5::US5_0(x) => x.clone(),
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
            ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
            let v35: Spiral_wasm::US3 = (patternInput.4.clone()).l0.get().clone();
            if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                find(
                    v0_1,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                        LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                        LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                        LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                        LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                    ])))),
                ) >= find(
                    v35,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                        LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                        LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                        LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                        LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                    ])))),
                )
            }
        }
        pub fn closure7(unitVar: (), v0_1: i64) -> Spiral_wasm::US5 {
            Spiral_wasm::US5::US5_0(v0_1)
        }
        pub fn method11() -> Func1<i64, Spiral_wasm::US5> {
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
            let v20: Spiral_wasm::US5 =
                defaultValue(Spiral_wasm::US5::US5_1, map(Spiral_wasm::method11(), v5));
            let v60: DateTime = match &v20 {
                Spiral_wasm::US5::US5_0(v20_0_0) => {
                    let v34: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v20 {
                            Spiral_wasm::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v34.hours(),
                        v34.minutes(),
                        v34.seconds(),
                        v34.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let provider: string = Spiral_wasm::method12();
            v60.toString(provider)
        }
        pub fn method16() -> string {
            string("")
        }
        pub fn closure8(v0_1: LrcPtr<Spiral_wasm::Mut3>, v1: string, unitVar: ()) {
            let v3: string = append(v0_1.l0.get().clone(), v1);
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
            let v32: &str = inline_colorization::color_reset;
            let v34: std::string::String = format!("{}{}{}", v9, v12, v32);
            fable_library_rust::String_::fromString(v34)
        }
        pub fn method19(v0_1: Array<string>) -> string {
            let v2: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v9: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string("args")), ());
                ()
            };
            let v27: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v38: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", sprintf!("{:?}", v0_1)), ());
                ()
            };
            let v47: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string(" }")), ());
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
            let v2: i64 = v0_1.l0.get().clone() + 1_i64;
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
            ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
            let v37: () = {
                Spiral_wasm::closure9(patternInput.0.clone(), ());
                ()
            };
            println!("{}", v0_1.clone());
            ();
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
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
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
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string("wasm_path")), ());
                ()
            };
            let v27: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v35: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v44: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string(" }")), ());
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
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
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
        pub fn method29(v0_1: u8) -> (u8, Spiral_wasm::US4) {
            (v0_1, Spiral_wasm::US4::US4_1)
        }
        pub fn method32(
            v0_1: u8,
            v1: near_workspaces::Worker<near_workspaces::network::Sandbox>,
            v2: near_workspaces::Contract,
        ) -> string {
            let v4: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v11: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v29: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v37: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v55: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("worker")), ());
                ()
            };
            let v63: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v68: std::string::String = format!("{:#?}", v1);
            let v98: () = {
                Spiral_wasm::closure8(
                    v4.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v68)),
                    (),
                );
                ()
            };
            let v106: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v115: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("contract")), ());
                ()
            };
            let v123: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v128: std::string::String = format!("{:#?}", v2);
            let v158: () = {
                Spiral_wasm::closure8(
                    v4.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v128)),
                    (),
                );
                ()
            };
            let v167: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method31(
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
            let v11: string = Spiral_wasm::method32(v8, v9, v10);
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
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v24: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v23: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v22: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v21: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method31(
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
        pub fn method34(v0_1: u8, v1: near_workspaces::result::ExecutionFinalResult) -> string {
            let v3: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v10: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v28: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v36: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v54: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("result")), ());
                ()
            };
            let v62: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v67: std::string::String = format!("{:#?}", v1);
            let v97: () = {
                Spiral_wasm::closure8(
                    v3.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v67)),
                    (),
                );
                ()
            };
            let v106: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method33(
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
            let v10: string = Spiral_wasm::method34(v8, v9);
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
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method33(
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
        pub fn method35() {
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
            ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
            let v36: () = {
                Spiral_wasm::closure9(patternInput.0.clone(), ());
                ()
            };
            println!("{}", string(" "));
            ();
            ((patternInput.1.clone()).l0.get().clone())(string(" "))
        }
        pub fn closure18(unitVar: (), unitVar_1: ()) {
            if Spiral_wasm::method9(Spiral_wasm::US3::US3_2) {
                Spiral_wasm::method35();
            };
        }
        pub fn method36() -> string {
            let v6: string = Spiral_wasm::method15(getCharAt(toLower(string("Info")), 0_i32));
            let v9: &str = inline_colorization::color_bright_green;
            let v12: &str = &*v6;
            let v32: &str = inline_colorization::color_reset;
            let v34: std::string::String = format!("{}{}{}", v9, v12, v32);
            fable_library_rust::String_::fromString(v34)
        }
        pub fn method38(v0_1: u8, v1: f64, v2: u64) -> string {
            let v4: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v11: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v29: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v37: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v55: () = {
                Spiral_wasm::closure8(
                    v4.clone(),
                    sprintf!("{}", string("total_gas_burnt_usd")),
                    (),
                );
                ()
            };
            let v63: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v71: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{:+.6}", v1), ());
                ()
            };
            let v79: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v88: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("total_gas_burnt")), ());
                ()
            };
            let v96: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v104: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method37(
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
            let v11: string = Spiral_wasm::method38(v8, v9, v10);
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
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v24: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v23: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v22: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v21: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method37(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Spiral_wasm::method10(v21, v22, v23, v24, v25, v26),
                    Spiral_wasm::method36(),
                    v0_1,
                    v2,
                    v1,
                ))
            };
        }
        pub fn method40(v0_1: bool, v1: f64, v2: f64, v3: u64, v4: u128) -> string {
            let v6: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v13: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v22: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{}", string("is_success")), ());
                ()
            };
            let v31: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v42: () = {
                Spiral_wasm::closure8(
                    v6.clone(),
                    sprintf!(
                        "{}",
                        if v0_1 {
                            string("true")
                        } else {
                            string("false")
                        }
                    ),
                    (),
                );
                ()
            };
            let v51: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v60: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{}", string("gas_burnt_usd")), ());
                ()
            };
            let v68: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v76: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{:+.6}", v1), ());
                ()
            };
            let v84: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v93: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{}", string("tokens_burnt_usd")), ());
                ()
            };
            let v101: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v109: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{:+.6}", v2), ());
                ()
            };
            let v117: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v126: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{}", string("gas_burnt")), ());
                ()
            };
            let v134: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v142: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v150: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v159: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{}", string("tokens_burnt")), ());
                ()
            };
            let v167: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v172: std::string::String = format!("{:#?}", v4);
            let v202: () = {
                Spiral_wasm::closure8(
                    v6.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v172)),
                    (),
                );
                ()
            };
            let v211: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v6.l0.get().clone()
        }
        pub fn method39(
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
            let v13: string = Spiral_wasm::method40(v8, v9, v10, v11, v12);
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
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v28: Option<i64> = patternInput.5.clone();
                let v27: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v26: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v25: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v24: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v23: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method39(
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    Spiral_wasm::method10(v23, v24, v25, v26, v27, v28),
                    Spiral_wasm::method36(),
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
            let v10: f64 = v6 as f64 / 10000000000000000.0_f64 * 6.68_f64;
            let v12: near_workspaces::types::NearToken = v0_1.tokens_burnt;
            let v14: u128 = v12.as_yoctonear();
            let v21: () = {
                Spiral_wasm::closure21(
                    v2,
                    v6,
                    v10,
                    v14.clone(),
                    v14 as f64 / 1E+24_f64 * 6.68_f64,
                    (),
                );
                ()
            };
            ()
        }
        pub fn method42(
            v0_1: Result<
                near_workspaces::result::ExecutionSuccess,
                near_workspaces::result::ExecutionFailure,
            >,
        ) -> string {
            let v2: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v9: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string("result2")), ());
                ()
            };
            let v27: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v32: std::string::String = format!("{:#?}", v0_1);
            let v62: () = {
                Spiral_wasm::closure8(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v32)),
                    (),
                );
                ()
            };
            let v71: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method41(
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
            let v9: string = Spiral_wasm::method42(v8);
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
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method41(
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
        pub fn method43(
            v0_1: near_workspaces::result::ExecutionFinalResult,
        ) -> near_workspaces::result::ExecutionFinalResult {
            v0_1
        }
        pub fn method45(v0_1: i32, v1: Vec<&near_workspaces::result::ExecutionOutcome>) -> string {
            let v3: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v10: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Spiral_wasm::closure8(
                    v3.clone(),
                    sprintf!("{}", string("receipt_failures_len")),
                    (),
                );
                ()
            };
            let v28: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v36: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v54: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("receipt_failures")), ());
                ()
            };
            let v62: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v67: std::string::String = format!("{:#?}", v1);
            let v97: () = {
                Spiral_wasm::closure8(
                    v3.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v67)),
                    (),
                );
                ()
            };
            let v106: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method44(
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
            let v10: string = Spiral_wasm::method45(v8, v9);
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
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method44(
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
        pub fn method46(
            v0_1: near_workspaces::result::ExecutionFinalResult,
        ) -> near_workspaces::result::ExecutionFinalResult {
            v0_1
        }
        pub fn method48(v0_1: i32, v1: Vec<near_workspaces::result::ExecutionOutcome>) -> string {
            let v3: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v10: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Spiral_wasm::closure8(
                    v3.clone(),
                    sprintf!("{}", string("receipt_outcomes_len")),
                    (),
                );
                ()
            };
            let v28: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v36: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v54: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("receipt_outcomes")), ());
                ()
            };
            let v62: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v67: std::string::String = format!("{:#?}", v1);
            let v97: () = {
                Spiral_wasm::closure8(
                    v3.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v67)),
                    (),
                );
                ()
            };
            let v106: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method47(
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
            let v10: string = Spiral_wasm::method48(v8, v9);
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
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method47(
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
        pub fn method50(
            v0_1: Result<std::string::String, near_workspaces::error::Error>,
        ) -> string {
            let v2: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v9: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string("json")), ());
                ()
            };
            let v27: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v32: std::string::String = format!("{:#?}", v0_1);
            let v62: () = {
                Spiral_wasm::closure8(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v32)),
                    (),
                );
                ()
            };
            let v71: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method49(
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
            let v9: string = Spiral_wasm::method50(v8);
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
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method49(
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
            v0_1: Result<std::string::String, near_workspaces::error::Error>,
        ) -> string {
            let v2: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v9: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string("borsh")), ());
                ()
            };
            let v27: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v32: std::string::String = format!("{:#?}", v0_1);
            let v62: () = {
                Spiral_wasm::closure8(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v32)),
                    (),
                );
                ()
            };
            let v71: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method51(
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
            let v9: string = Spiral_wasm::method52(v8);
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
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method51(
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
        pub fn method53(
            v0_1: i32,
            v1: u8,
            v2: Vec<&near_workspaces::result::ExecutionOutcome>,
        ) -> string {
            let v4: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v11: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Spiral_wasm::closure8(
                    v4.clone(),
                    sprintf!("{}", string("receipt_outcomes_len")),
                    (),
                );
                ()
            };
            let v29: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v37: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v55: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v63: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v71: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v79: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v88: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("receipt_failures")), ());
                ()
            };
            let v96: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v101: std::string::String = format!("{:#?}", v2);
            let v131: () = {
                Spiral_wasm::closure8(
                    v4.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v101)),
                    (),
                );
                ()
            };
            let v140: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method54(
            v0_1: Result<Spiral_wasm::US4, anyhow::Error>,
        ) -> Result<Spiral_wasm::US4, anyhow::Error> {
            v0_1
        }
        pub fn method30(
            v0_1: Vec<u8>,
            v1: u8,
        ) -> std::pin::Pin<
            Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4, anyhow::Error>>>,
        > {
            let v3: bool = true;
            let __future_init = Box::pin(async move {
                //;
                let v5: Result<
                    near_workspaces::Worker<near_workspaces::network::Sandbox>,
                    near_workspaces::error::Error,
                > = near_workspaces::sandbox().await;
                let v7: near_workspaces::Worker<near_workspaces::network::Sandbox> = v5?;
                let v9: near_workspaces::Worker<near_workspaces::network::Sandbox> = v7.clone();
                let v11: std::pin::Pin<
                    Box<
                        dyn std::future::Future<
                            Output = Result<
                                near_workspaces::Contract,
                                near_workspaces::error::Error,
                            >,
                        >,
                    >,
                > = Box::pin(v9.dev_deploy(&v0_1));
                let v13: Result<near_workspaces::Contract, near_workspaces::error::Error> =
                    v11.await;
                let v15: near_workspaces::Contract = v13?;
                let v18: () = {
                    Spiral_wasm::closure14(v1, v7, v15.clone(), ());
                    ()
                };
                let v60: near_workspaces::operations::CallTransaction =
                    v15.call(&*string("state_main"));
                let v62: near_workspaces::types::Gas = near_workspaces::types::Gas::from_tgas(300);
                let v64: near_workspaces::operations::CallTransaction = v60.gas(v62);
                let v66: std::pin::Pin<
                    Box<
                        dyn std::future::Future<
                            Output = Result<
                                near_workspaces::result::ExecutionFinalResult,
                                near_workspaces::error::Error,
                            >,
                        >,
                    >,
                > = Box::pin(v64.transact());
                let v68: Result<
                    near_workspaces::result::ExecutionFinalResult,
                    near_workspaces::error::Error,
                > = v66.await;
                let v70: near_workspaces::result::ExecutionFinalResult = v68?;
                let v73: () = {
                    Spiral_wasm::closure15(v1, v70.clone(), ());
                    ()
                };
                let v114: Vec<&str> = v70.logs();
                let v116: bool = true;
                let _vec_map: Vec<_> = v114
                    .into_iter()
                    .map(|x| {
                        //;
                        let v118: &str = x;
                        let v121: std::string::String = String::from(v118);
                        let v141: bool = true;
                        v121
                    })
                    .collect::<Vec<_>>();
                let v143: Vec<std::string::String> = _vec_map;
                let v146: bool = true;
                v143.iter().for_each(|x| {
                    Func1::new(move |v: std::string::String| Spiral_wasm::closure16((), v))(
                        x.clone(),
                    );
                }); //;
                let v149: () = {
                    Spiral_wasm::closure18((), ());
                    ()
                };
                let v153: near_workspaces::types::Gas = v70.clone().total_gas_burnt;
                let v155: u64 = v153.as_gas();
                let v162: () = {
                    Spiral_wasm::closure19(
                        v1,
                        v155,
                        v155 as f64 / 10000000000000000.0_f64 * 6.68_f64,
                        (),
                    );
                    ()
                };
                let v203: near_workspaces::result::ExecutionFinalResult = v70.clone();
                let v205: Vec<&near_workspaces::result::ExecutionOutcome> = v203.outcomes();
                let v207 = v205.into_iter();
                let v209 = v207.cloned();
                let v212: bool = true;
                v209.for_each(|x| {
                    Func1::new(move |v_1: near_workspaces::result::ExecutionOutcome| {
                        Spiral_wasm::closure20((), v_1)
                    })(x)
                });
                let v217: () = {
                    Spiral_wasm::closure22(v70.clone().into_result(), ());
                    ()
                };
                let v257: near_workspaces::result::ExecutionFinalResult =
                    Spiral_wasm::method43(v70.clone());
                let v259: Vec<&near_workspaces::result::ExecutionOutcome> = v257.receipt_failures();
                let v263: i32 = v259.clone().len() as i32;
                let v266: () = {
                    Spiral_wasm::closure23(v259.clone(), v263, ());
                    ()
                };
                let v306: near_workspaces::result::ExecutionFinalResult =
                    Spiral_wasm::method46(v70.clone());
                let v308: &[near_workspaces::result::ExecutionOutcome] = v306.receipt_outcomes();
                let v310: Vec<near_workspaces::result::ExecutionOutcome> = v308.into();
                let v314: i32 = v310.clone().len() as i32;
                let v317: () = {
                    Spiral_wasm::closure24(v310, v314, ());
                    ()
                };
                let v361: () = {
                    Spiral_wasm::closure25(v70.clone().json(), ());
                    ()
                };
                let v405: () = {
                    Spiral_wasm::closure26(v70.borsh(), ());
                    ()
                };
                let v445: string = Spiral_wasm::method53(v314, v1, v259);
                let v469: Result<Spiral_wasm::US4, anyhow::Error> =
                    Spiral_wasm::method54(if v263 > 0_i32 {
                        Ok::<Spiral_wasm::US4, anyhow::Error>(Spiral_wasm::US4::US4_0(v445.clone()))
                    } else {
                        if v314 > 1_i32 {
                            Ok::<Spiral_wasm::US4, anyhow::Error>(Spiral_wasm::US4::US4_1)
                        } else {
                            let v453: anyhow::Error = anyhow::anyhow!(v445);
                            Err(v453)
                        }
                    });
                let v472: string = string("}");
                let v476: bool = true;
                let v473 = v469;
                let v487: string = append(
                    append(
                        append(append(string("true; v473 "), v472), string("); ")),
                        string(""),
                    ),
                    string(" // rust.fix_closure\'"),
                );
                let v488: bool = true;
                v473
            }); // rust.fix_closure';
            let v490 = __future_init;
            v490
        }
        pub fn closure27(unitVar: (), v0_1: anyhow::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method55() -> Func1<anyhow::Error, std::string::String> {
            Func1::new(move |v: anyhow::Error| Spiral_wasm::closure27((), v))
        }
        pub fn closure28(unitVar: (), v0_1: Spiral_wasm::US4) -> Spiral_wasm::US7 {
            Spiral_wasm::US7::US7_0(v0_1)
        }
        pub fn closure29(unitVar: (), v0_1: std::string::String) -> Spiral_wasm::US7 {
            Spiral_wasm::US7::US7_1(v0_1)
        }
        pub fn method56() -> string {
            let v6: string = Spiral_wasm::method15(getCharAt(toLower(string("Warning")), 0_i32));
            let v9: &str = inline_colorization::color_yellow;
            let v12: &str = &*v6;
            let v32: &str = inline_colorization::color_reset;
            let v34: std::string::String = format!("{}{}{}", v9, v12, v32);
            fable_library_rust::String_::fromString(v34)
        }
        pub fn method58(v0_1: u8, v1: std::string::String) -> string {
            let v3: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v10: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v28: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v36: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v54: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("error")), ());
                ()
            };
            let v62: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v67: std::string::String = format!("{:#?}", v1);
            let v97: () = {
                Spiral_wasm::closure8(
                    v3.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v67)),
                    (),
                );
                ()
            };
            let v106: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string(" }")), ());
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
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
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
            ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
            let v36: () = {
                Spiral_wasm::closure9(patternInput.0.clone(), ());
                ()
            };
            println!("{}", string("\n"));
            ();
            ((patternInput.1.clone()).l0.get().clone())(string("\n"))
        }
        pub fn closure31(unitVar: (), unitVar_1: ()) {
            if Spiral_wasm::method9(Spiral_wasm::US3::US3_3) {
                Spiral_wasm::method59();
            };
        }
        pub fn method60() -> string {
            let v6: string = Spiral_wasm::method15(getCharAt(toLower(string("Critical")), 0_i32));
            let v9: &str = inline_colorization::color_bright_red;
            let v12: &str = &*v6;
            let v32: &str = inline_colorization::color_reset;
            let v34: std::string::String = format!("{}{}{}", v9, v12, v32);
            fable_library_rust::String_::fromString(v34)
        }
        pub fn method62(v0_1: u8, v1: string) -> string {
            let v3: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v10: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v28: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v36: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v54: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("error")), ());
                ()
            };
            let v62: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v70: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v79: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string(" }")), ());
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
        pub fn closure32(v0_1: u8, v1: string, unitVar: ()) {
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
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
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
        pub fn method63(v0_1: u8, v1: string) -> (u8, Spiral_wasm::US4) {
            (v0_1, Spiral_wasm::US4::US4_0(v1))
        }
        pub fn method64(v0_1: Spiral_wasm::US6) -> Spiral_wasm::US6 {
            v0_1
        }
        pub fn method28(
            v0_1: Vec<u8>,
            v1: u8,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Spiral_wasm::US6>>> {
            let v3: bool = true;
            let __future_init = Box::pin(async move {
                //;
                let v219: Spiral_wasm::US6 = Spiral_wasm::method64(if v1 >= 30_u8 {
                    let v6: bool = true;
                    let __future_init = Box::pin(async move {
                        //;
                        let patternInput: (u8, Spiral_wasm::US4) = Spiral_wasm::method29(v1);
                        let v11: string = string("}");
                        let v15: bool = true;
                        let v12 = (patternInput.0.clone(), patternInput.1.clone());
                        let v26: string = append(
                            append(
                                append(append(string("true; v12 "), v11), string("); ")),
                                string(""),
                            ),
                            string(" // rust.fix_closure\'"),
                        );
                        let v27: bool = true;
                        v12
                    }); // rust.fix_closure';
                    let v29 = __future_init;
                    let v31: std::pin::Pin<
                        Box<dyn std::future::Future<Output = (u8, Spiral_wasm::US4)>>,
                    > = v29;
                    let patternInput_1: (u8, Spiral_wasm::US4) = v31.await;
                    Spiral_wasm::US6::US6_1(patternInput_1.0.clone(), patternInput_1.1.clone())
                } else {
                    let v36: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                Output = Result<Spiral_wasm::US4, anyhow::Error>,
                            >,
                        >,
                    > = Spiral_wasm::method30(v0_1.clone(), v1);
                    let v38: Result<Spiral_wasm::US4, anyhow::Error> = v36.await;
                    let v39 = Spiral_wasm::method55();
                    let v50: Result<Spiral_wasm::US4, std::string::String> =
                        v38.map_err(|x| v39(x));
                    let v55: Spiral_wasm::US7 = match &v50 {
                        Err(v50_1_0) => Spiral_wasm::closure29((), v50_1_0.clone()),
                        Ok(v50_0_0) => Spiral_wasm::closure28((), v50_0_0.clone()),
                    };
                    match &v55 {
                        Spiral_wasm::US7::US7_0(v55_0_0) => {
                            let v56: Spiral_wasm::US4 = v55_0_0.clone();
                            match &v56 {
                                Spiral_wasm::US4::US4_0(v56_0_0) => {
                                    let v88: string = match &v56 {
                                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    let v91: () = {
                                        Spiral_wasm::closure32(v1, v88.clone(), ());
                                        ()
                                    };
                                    let v132: bool = true;
                                    let __future_init = Box::pin(async move {
                                        //;
                                        let patternInput_4: (u8, Spiral_wasm::US4) =
                                            Spiral_wasm::method63(v1, v88);
                                        let v137: string = string("}");
                                        let v141: bool = true;
                                        let v138 =
                                            (patternInput_4.0.clone(), patternInput_4.1.clone());
                                        let v152: string = append(
                                            append(
                                                append(
                                                    append(string("true; v138 "), v137),
                                                    string("); "),
                                                ),
                                                string(""),
                                            ),
                                            string(" // rust.fix_closure\'"),
                                        );
                                        let v153: bool = true;
                                        v138
                                    }); // rust.fix_closure';
                                    let v155 = __future_init;
                                    let v157: std::pin::Pin<
                                        Box<
                                            dyn std::future::Future<
                                                Output = (u8, Spiral_wasm::US4),
                                            >,
                                        >,
                                    > = v155;
                                    let patternInput_5: (u8, Spiral_wasm::US4) = v157.await;
                                    Spiral_wasm::US6::US6_1(
                                        patternInput_5.0.clone(),
                                        patternInput_5.1.clone(),
                                    )
                                }
                                _ => {
                                    let v58: bool = true;
                                    let __future_init = Box::pin(async move {
                                        //;
                                        let patternInput_2: (u8, Spiral_wasm::US4) =
                                            Spiral_wasm::method29(v1);
                                        let v63: string = string("}");
                                        let v67: bool = true;
                                        let v64 =
                                            (patternInput_2.0.clone(), patternInput_2.1.clone());
                                        let v78: string = append(
                                            append(
                                                append(
                                                    append(string("true; v64 "), v63),
                                                    string("); "),
                                                ),
                                                string(""),
                                            ),
                                            string(" // rust.fix_closure\'"),
                                        );
                                        let v79: bool = true;
                                        v64
                                    }); // rust.fix_closure';
                                    let v81 = __future_init;
                                    let v83: std::pin::Pin<
                                        Box<
                                            dyn std::future::Future<
                                                Output = (u8, Spiral_wasm::US4),
                                            >,
                                        >,
                                    > = v81;
                                    let patternInput_3: (u8, Spiral_wasm::US4) = v83.await;
                                    Spiral_wasm::US6::US6_0(
                                        patternInput_3.0.clone(),
                                        patternInput_3.1.clone(),
                                    )
                                }
                            }
                        }
                        Spiral_wasm::US7::US7_1(v55_1_0) => {
                            let v167: () = {
                                Spiral_wasm::closure30(v1, v55_1_0.clone(), ());
                                ()
                            };
                            let v209: () = {
                                Spiral_wasm::closure31((), ());
                                ()
                            };
                            let v213: std::pin::Pin<
                                Box<dyn std::future::Future<Output = Spiral_wasm::US6>>,
                            > = Spiral_wasm::method28(v0_1, v1 + 1_u8);
                            v213.await
                        }
                    }
                });
                let v222: string = string("}");
                let v226: bool = true;
                let v223 = v219;
                let v237: string = append(
                    append(
                        append(append(string("true; v223 "), v222), string("); ")),
                        string(""),
                    ),
                    string(" // rust.fix_closure\'"),
                );
                let v238: bool = true;
                v223
            }); // rust.fix_closure';
            let v240 = __future_init;
            v240
        }
        pub fn method66(v0_1: Spiral_wasm::US6) -> string {
            let v2: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v9: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string("retries")), ());
                ()
            };
            let v27: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v38: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", sprintf!("{:?}", v0_1)), ());
                ()
            };
            let v47: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method65(
            v0_1: LrcPtr<Spiral_wasm::Mut0>,
            v1: LrcPtr<Spiral_wasm::Mut1>,
            v2: LrcPtr<Spiral_wasm::Mut2>,
            v3: LrcPtr<Spiral_wasm::Mut3>,
            v4: LrcPtr<Spiral_wasm::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: Spiral_wasm::US6,
        ) -> string {
            let v9: string = Spiral_wasm::method66(v8);
            Spiral_wasm::method20(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_wasm.run"),
                v9
            ))
        }
        pub fn closure33(v0_1: Spiral_wasm::US6, unitVar: ()) {
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
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_wasm::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_wasm::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_wasm::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_wasm::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                Spiral_wasm::method21(Spiral_wasm::method65(
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
        pub fn method67(v0_1: Spiral_wasm::US6, v1: Spiral_wasm::US4) -> string {
            let v3: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v10: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("retries")), ());
                ()
            };
            let v28: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v39: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", sprintf!("{:?}", v0_1)), ());
                ()
            };
            let v48: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v57: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("error")), ());
                ()
            };
            let v65: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v76: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", sprintf!("{:?}", v1)), ());
                ()
            };
            let v85: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method68(v0_1: Result<u8, anyhow::Error>) -> Result<u8, anyhow::Error> {
            v0_1
        }
        pub fn method24(
            v0_1: clap::ArgMatches,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<u8, anyhow::Error>>>>
        {
            let v2: bool = true;
            let __future_init = Box::pin(async move {
                //;
                let v3: string = Spiral_wasm::method25();
                let v6: &str = &*v3;
                let v26: Option<std::string::String> =
                    clap::ArgMatches::get_one(&v0_1, v6).cloned();
                let v40: Spiral_wasm::US0 =
                    defaultValue(Spiral_wasm::US0::US0_1, map(Spiral_wasm::method2(), v26));
                let v47: std::string::String = match &v40 {
                    Spiral_wasm::US0::US0_0(v40_0_0) => match &v40 {
                        Spiral_wasm::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                };
                let v49: string = fable_library_rust::String_::fromString(v47);
                let v52: () = {
                    Spiral_wasm::closure13(v49.clone(), ());
                    ()
                };
                let v93: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v49);
                let v97: std::pin::Pin<Box<dyn std::future::Future<Output = Spiral_wasm::US6>>> =
                    Spiral_wasm::method28(v93?, 1_u8);
                let v99: Spiral_wasm::US6 = v97.await;
                let v102: () = {
                    Spiral_wasm::closure33(v99.clone(), ());
                    ()
                };
                let v165: Result<u8, anyhow::Error> = Spiral_wasm::method68(match &v99 {
                    Spiral_wasm::US6::US6_0(v99_0_0, v99_0_1) => {
                        Ok::<u8, anyhow::Error>(v99_0_0.clone())
                    }
                    Spiral_wasm::US6::US6_1(v99_1_0, v99_1_1) => {
                        let v147: string = Spiral_wasm::method67(v99.clone(), v99_1_1.clone());
                        let v149: anyhow::Error = anyhow::anyhow!(v147);
                        Err(v149)
                    }
                });
                let v168: string = string("}");
                let v172: bool = true;
                let v169 = v165;
                let v183: string = append(
                    append(
                        append(append(string("true; v169 "), v168), string("); ")),
                        string(""),
                    ),
                    string(" // rust.fix_closure\'"),
                );
                let v184: bool = true;
                v169
            }); // rust.fix_closure';
            let v186 = __future_init;
            v186
        }
        pub fn closure34(unitVar: (), v0_1: u8) -> Spiral_wasm::US8 {
            Spiral_wasm::US8::US8_0(v0_1)
        }
        pub fn closure35(unitVar: (), v0_1: std::string::String) -> Spiral_wasm::US8 {
            Spiral_wasm::US8::US8_1(v0_1)
        }
        pub fn closure0(unitVar: (), v0_1: Array<string>) -> i32 {
            let v1: clap::Command = Spiral_wasm::method0();
            let v3: clap::ArgMatches = clap::Command::get_matches(v1);
            let v4: string = Spiral_wasm::method1();
            let v7: &str = &*v4;
            let v27: Option<std::string::String> =
                clap::ArgMatches::get_one(&v3.clone(), v7).cloned();
            let v41: Spiral_wasm::US0 =
                defaultValue(Spiral_wasm::US0::US0_1, map(Spiral_wasm::method2(), v27));
            let v97: Spiral_wasm::US1 = match &v41 {
                Spiral_wasm::US0::US0_0(v41_0_0) => {
                    let v47: string = fable_library_rust::String_::fromString(match &v41 {
                        Spiral_wasm::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    });
                    let v52: Spiral_wasm::US2 = if string("Verbose") == v47.clone() {
                        Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_0)
                    } else {
                        Spiral_wasm::US2::US2_1
                    };
                    Spiral_wasm::US1::US1_0(match &v52 {
                        Spiral_wasm::US2::US2_0(v52_0_0) => Spiral_wasm::US2::US2_0(match &v52 {
                            Spiral_wasm::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v59: Spiral_wasm::US2 = if string("Debug") == v47.clone() {
                                Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_1)
                            } else {
                                Spiral_wasm::US2::US2_1
                            };
                            match &v59 {
                                Spiral_wasm::US2::US2_0(v59_0_0) => {
                                    Spiral_wasm::US2::US2_0(match &v59 {
                                        Spiral_wasm::US2::US2_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v66: Spiral_wasm::US2 = if string("Info") == v47.clone() {
                                        Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_2)
                                    } else {
                                        Spiral_wasm::US2::US2_1
                                    };
                                    match &v66 {
                                        Spiral_wasm::US2::US2_0(v66_0_0) => {
                                            Spiral_wasm::US2::US2_0(match &v66 {
                                                Spiral_wasm::US2::US2_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v73: Spiral_wasm::US2 =
                                                if string("Warning") == v47.clone() {
                                                    Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_3)
                                                } else {
                                                    Spiral_wasm::US2::US2_1
                                                };
                                            match &v73 {
                                                Spiral_wasm::US2::US2_0(v73_0_0) => {
                                                    Spiral_wasm::US2::US2_0(match &v73 {
                                                        Spiral_wasm::US2::US2_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v80: Spiral_wasm::US2 =
                                                        if string("Critical") == v47.clone() {
                                                            Spiral_wasm::US2::US2_0(
                                                                Spiral_wasm::US3::US3_4,
                                                            )
                                                        } else {
                                                            Spiral_wasm::US2::US2_1
                                                        };
                                                    match &v80 {
                                                        Spiral_wasm::US2::US2_0(v80_0_0) => {
                                                            Spiral_wasm::US2::US2_0(match &v80 {
                                                                Spiral_wasm::US2::US2_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            })
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
            let v104: Spiral_wasm::US2 = if let Spiral_wasm::US1::US1_0(v97_0_0) = &v97 {
                let v98: Spiral_wasm::US2 = match &v97 {
                    Spiral_wasm::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                };
                if let Spiral_wasm::US2::US2_0(v98_0_0) = &v98 {
                    Spiral_wasm::US2::US2_0(match &v98 {
                        Spiral_wasm::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    })
                } else {
                    Spiral_wasm::US2::US2_1
                }
            } else {
                Spiral_wasm::US2::US2_1
            };
            let v111: () = {
                Spiral_wasm::closure2(
                    match &v104 {
                        Spiral_wasm::US2::US2_0(v104_0_0) => match &v104 {
                            Spiral_wasm::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
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
            ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
            let v143: () = {
                Spiral_wasm::closure5(v0_1, ());
                ()
            };
            let v183: string = Spiral_wasm::method22();
            let v186: &str = &*v183;
            let v206: Option<std::string::String> =
                clap::ArgMatches::get_one(&v3.clone(), v186).cloned();
            let v208: Option<string> = map(Spiral_wasm::method23(), v206);
            let v285: Spiral_wasm::US4 =
                defaultValue(Spiral_wasm::US4::US4_1, map(Spiral_wasm::method7(), v208));
            let v289: std::pin::Pin<
                Box<dyn std::future::Future<Output = Result<u8, anyhow::Error>>>,
            > = Spiral_wasm::method24(v3);
            let v291 = tokio::runtime::Builder::new_multi_thread()
                .enable_all()
                .build()
                .unwrap();
            let v293: Result<u8, anyhow::Error> = v291.handle().block_on(v289);
            let v294 = Spiral_wasm::method55();
            let v305: Result<u8, std::string::String> = v293.map_err(|x| v294(x));
            let v310: Spiral_wasm::US8 = match &v305 {
                Err(v305_1_0) => Spiral_wasm::closure35((), v305_1_0.clone()),
                Ok(v305_0_0) => Spiral_wasm::closure34((), v305_0_0.clone()),
            };
            match &v310 {
                Spiral_wasm::US8::US8_0(v310_0_0) => {
                    if let Spiral_wasm::US4::US4_0(v285_0_0) = &v285 {
                        let v313: string = sprintf!(
                            "spiral_wasm.main / retries: {} / exception: \'{}\'",
                            v310_0_0.clone(),
                            match &v285 {
                                Spiral_wasm::US4::US4_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                        );
                        let v316: Result<(), string> = Err(v313);
                        v316.unwrap();
                        ();
                        ()
                    }
                }
                Spiral_wasm::US8::US8_1(v310_1_0) => {
                    let v331: std::string::String = v310_1_0.clone();
                    if let Spiral_wasm::US4::US4_0(v285_0_0) = &v285 {
                        let v332: string = match &v285 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        if string("") == v332.clone() {
                            ()
                        } else {
                            if contains(
                                fable_library_rust::String_::fromString(v331.clone()),
                                v332.clone(),
                            ) {
                                ()
                            } else {
                                let v339: string = sprintf!(
                                    "spiral_wasm.main / exception: \'{}\' / error: {}",
                                    v332,
                                    v331
                                );
                                let v342: Result<(), string> = Err(v339);
                                v342.unwrap();
                                ();
                                ()
                            }
                        }
                    } else {
                        let v359: u8 = v305.clone().unwrap();
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
