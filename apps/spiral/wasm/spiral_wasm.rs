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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US4 {
            US4_0(i64),
            US4_1,
        }
        impl core::fmt::Display for Spiral_wasm::US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US5 {
            US5_0,
            US5_1,
            US5_2,
        }
        impl core::fmt::Display for Spiral_wasm::US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US6 {
            US6_0(Spiral_wasm::US5),
            US6_1(Spiral_wasm::US5),
            US6_2(Spiral_wasm::US5),
            US6_3(Spiral_wasm::US5),
            US6_4(Spiral_wasm::US5),
        }
        impl core::fmt::Display for Spiral_wasm::US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US7 {
            US7_0(string),
            US7_1,
        }
        impl core::fmt::Display for Spiral_wasm::US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US8 {
            US8_0(u8, Spiral_wasm::US7),
            US8_1(u8, Spiral_wasm::US7),
        }
        impl core::fmt::Display for Spiral_wasm::US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US9 {
            US9_0(Spiral_wasm::US7),
            US9_1(std::string::String),
        }
        impl core::fmt::Display for Spiral_wasm::US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US10 {
            US10_0(u8),
            US10_1(std::string::String),
        }
        impl core::fmt::Display for Spiral_wasm::US10 {
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
                    let v112: std::string::String = String::from(v88);
                    let v135: Box<std::string::String> = Box::new(v112);
                    let v137: &'static mut std::string::String = Box::leak(v135);
                    let v139: clap::builder::PossibleValue =
                        clap::builder::PossibleValue::new(&**v137);
                    let v141: bool = true;
                    v139
                })
                .collect::<Vec<_>>();
            let v143: Vec<clap::builder::PossibleValue> = _vec_map;
            let v145: clap::builder::ValueParser = Into::<clap::builder::ValueParser>::into(
                clap::builder::PossibleValuesParser::new(v143),
            );
            let v147: clap::Arg = v54.value_parser(v145);
            let v149: clap::Command = clap::Command::arg(v43, v147);
            let v151: string = string("r#\"wasm\"#");
            let v152: &'static str = r#"wasm"#;
            let v154: clap::Arg = clap::Arg::new(v152);
            let v156: clap::Arg = v154.short('w');
            let v157: string = string("r#\"wasm\"#");
            let v158: &'static str = r#"wasm"#;
            let v160: clap::Arg = v156.long(v158);
            let v162: clap::Arg = v160.required(true);
            clap::Command::arg(v149, v162)
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
        pub fn method6() -> string {
            string("")
        }
        pub fn closure3(unitVar: (), v0_1: string) -> Spiral_wasm::US7 {
            Spiral_wasm::US7::US7_0(v0_1)
        }
        pub fn method7() -> Func1<string, Spiral_wasm::US7> {
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
        pub fn method4() -> (Spiral_wasm::US2, Spiral_wasm::US4) {
            let v1: string = Spiral_wasm::method5(string("TRACE_LEVEL"));
            let v6: Spiral_wasm::US2 = if string("Verbose") == v1.clone() {
                Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_0)
            } else {
                Spiral_wasm::US2::US2_1
            };
            (
                match &v6 {
                    Spiral_wasm::US2::US2_0(v6_0_0) => Spiral_wasm::US2::US2_0(match &v6 {
                        Spiral_wasm::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v13: Spiral_wasm::US2 = if string("Debug") == v1.clone() {
                            Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_1)
                        } else {
                            Spiral_wasm::US2::US2_1
                        };
                        match &v13 {
                            Spiral_wasm::US2::US2_0(v13_0_0) => {
                                Spiral_wasm::US2::US2_0(match &v13 {
                                    Spiral_wasm::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v20: Spiral_wasm::US2 = if string("Info") == v1.clone() {
                                    Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_2)
                                } else {
                                    Spiral_wasm::US2::US2_1
                                };
                                match &v20 {
                                    Spiral_wasm::US2::US2_0(v20_0_0) => {
                                        Spiral_wasm::US2::US2_0(match &v20 {
                                            Spiral_wasm::US2::US2_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v27: Spiral_wasm::US2 =
                                            if string("Warning") == v1.clone() {
                                                Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_3)
                                            } else {
                                                Spiral_wasm::US2::US2_1
                                            };
                                        match &v27 {
                                            Spiral_wasm::US2::US2_0(v27_0_0) => {
                                                Spiral_wasm::US2::US2_0(match &v27 {
                                                    Spiral_wasm::US2::US2_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v34: Spiral_wasm::US2 = if string("Critical")
                                                    == v1.clone()
                                                {
                                                    Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_4)
                                                } else {
                                                    Spiral_wasm::US2::US2_1
                                                };
                                                match &v34 {
                                                    Spiral_wasm::US2::US2_0(v34_0_0) => {
                                                        Spiral_wasm::US2::US2_0(match &v34 {
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
                if Spiral_wasm::method5(string("AUTOMATION")) != string("True") {
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
            let _v1: (Spiral_wasm::US2, Spiral_wasm::US4) =
                (patternInput.0.clone(), patternInput.1.clone());
            let v132: Spiral_wasm::US4 = _v1.1.clone();
            let v131: Spiral_wasm::US2 = _v1.0.clone();
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
                        },
                        _ => v0_1,
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
        pub fn method8(v0_1: Spiral_wasm::US3) -> bool {
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
        pub fn closure7(unitVar: (), v0_1: i64) -> Spiral_wasm::US4 {
            Spiral_wasm::US4::US4_0(v0_1)
        }
        pub fn method10() -> Func1<i64, Spiral_wasm::US4> {
            Func1::new(move |v: i64| Spiral_wasm::closure7((), v))
        }
        pub fn method11() -> string {
            string("hh:mm:ss")
        }
        pub fn method12() -> string {
            string("HH:mm:ss")
        }
        pub fn method9(
            v0_1: LrcPtr<Spiral_wasm::Mut0>,
            v1: LrcPtr<Spiral_wasm::Mut1>,
            v2: LrcPtr<Spiral_wasm::Mut2>,
            v3: LrcPtr<Spiral_wasm::Mut3>,
            v4: LrcPtr<Spiral_wasm::Mut4>,
            v5: Option<i64>,
        ) -> string {
            let v20: Spiral_wasm::US4 =
                defaultValue(Spiral_wasm::US4::US4_1, map(Spiral_wasm::method10(), v5));
            let v116: DateTime = match &v20 {
                Spiral_wasm::US4::US4_0(v20_0_0) => {
                    let v78: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v20 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v78.hours(),
                        v78.minutes(),
                        v78.seconds(),
                        v78.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let provider: string = Spiral_wasm::method11();
            v116.toString(provider)
        }
        pub fn method15() -> string {
            string("")
        }
        pub fn closure8(v0_1: LrcPtr<Spiral_wasm::Mut3>, v1: string, unitVar: ()) {
            let v3: string = append(v0_1.l0.get().clone(), v1);
            v0_1.l0.set(v3);
            ()
        }
        pub fn method14(v0_1: char) -> string {
            let v2: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method15()),
            });
            let v8: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method16() -> string {
            string("\u{001b}[0m")
        }
        pub fn method13() -> string {
            let v6: string = Spiral_wasm::method14(getCharAt(toLower(string("Verbose")), 0_i32));
            let v9: &str = inline_colorization::color_bright_black;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method18(v0_1: Array<string>) -> string {
            let v2: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method15()),
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
        pub fn method19(v0_1: string) -> string {
            trimEndChars(
                trimStartChars(v0_1, toArray(empty::<char>())),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn method17(
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
            let v9: string = Spiral_wasm::method18(v8);
            Spiral_wasm::method19(sprintf!(
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
        pub fn method20(v0_1: string) {
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
            if Spiral_wasm::method8(Spiral_wasm::US3::US3_0) {
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
                Spiral_wasm::method20(Spiral_wasm::method17(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_wasm::method9(v19, v20, v21, v22, v23, v24),
                    Spiral_wasm::method13(),
                    v0_1,
                ))
            };
        }
        pub fn method21() -> string {
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
        pub fn method22() -> Func1<std::string::String, string> {
            Func1::new(move |v: std::string::String| Spiral_wasm::closure12((), v))
        }
        pub fn method24() -> string {
            string("wasm")
        }
        pub fn method26(v0_1: string) -> string {
            let v2: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method15()),
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
        pub fn method25(
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
            let v9: string = Spiral_wasm::method26(v8);
            Spiral_wasm::method19(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_wasm.run"),
                v9
            ))
        }
        pub fn closure13(v0_1: string, unitVar: ()) {
            if Spiral_wasm::method8(Spiral_wasm::US3::US3_0) {
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
                Spiral_wasm::method20(Spiral_wasm::method25(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_wasm::method9(v19, v20, v21, v22, v23, v24),
                    Spiral_wasm::method13(),
                    v0_1,
                ))
            };
        }
        pub fn method30(
            v0_1: u8,
            v1: near_workspaces::Worker<near_workspaces::network::Sandbox>,
            v2: near_workspaces::Contract,
        ) -> string {
            let v4: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method15()),
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
            let v101: () = {
                Spiral_wasm::closure8(
                    v4.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v68)),
                    (),
                );
                ()
            };
            let v109: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v118: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("contract")), ());
                ()
            };
            let v126: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v131: std::string::String = format!("{:#?}", v2);
            let v164: () = {
                Spiral_wasm::closure8(
                    v4.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v131)),
                    (),
                );
                ()
            };
            let v173: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method29(
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
            let v11: string = Spiral_wasm::method30(v8, v9, v10);
            Spiral_wasm::method19(sprintf!(
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
            if Spiral_wasm::method8(Spiral_wasm::US3::US3_0) {
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
                Spiral_wasm::method20(Spiral_wasm::method29(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Spiral_wasm::method9(v21, v22, v23, v24, v25, v26),
                    Spiral_wasm::method13(),
                    v0_1,
                    v1,
                    v2,
                ))
            };
        }
        pub fn method32(v0_1: u8, v1: near_workspaces::result::ExecutionFinalResult) -> string {
            let v3: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method15()),
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
            let v100: () = {
                Spiral_wasm::closure8(
                    v3.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v67)),
                    (),
                );
                ()
            };
            let v109: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
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
            v9: near_workspaces::result::ExecutionFinalResult,
        ) -> string {
            let v10: string = Spiral_wasm::method32(v8, v9);
            Spiral_wasm::method19(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_wasm.run"),
                v10
            ))
        }
        pub fn closure15(v0_1: u8, v1: near_workspaces::result::ExecutionFinalResult, unitVar: ()) {
            if Spiral_wasm::method8(Spiral_wasm::US3::US3_0) {
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
                Spiral_wasm::method20(Spiral_wasm::method31(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_wasm::method9(v20, v21, v22, v23, v24, v25),
                    Spiral_wasm::method13(),
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
        pub fn method33() {
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
            if Spiral_wasm::method8(Spiral_wasm::US3::US3_2) {
                Spiral_wasm::method33();
            };
        }
        pub fn method34() -> string {
            let v6: string = Spiral_wasm::method14(getCharAt(toLower(string("Info")), 0_i32));
            let v9: &str = inline_colorization::color_bright_green;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method36(v0_1: u8, v1: f64, v2: u64) -> string {
            let v4: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method15()),
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
        pub fn method35(
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
            let v11: string = Spiral_wasm::method36(v8, v9, v10);
            Spiral_wasm::method19(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("near_workspaces.print_usd"),
                v11
            ))
        }
        pub fn closure19(v0_1: u8, v1: u64, v2: f64, unitVar: ()) {
            if Spiral_wasm::method8(Spiral_wasm::US3::US3_2) {
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
                Spiral_wasm::method20(Spiral_wasm::method35(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Spiral_wasm::method9(v21, v22, v23, v24, v25, v26),
                    Spiral_wasm::method34(),
                    v0_1,
                    v2,
                    v1,
                ))
            };
        }
        pub fn method38(v0_1: bool, v1: f64, v2: f64, v3: u64, v4: u128) -> string {
            let v6: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method15()),
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
            let v205: () = {
                Spiral_wasm::closure8(
                    v6.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v172)),
                    (),
                );
                ()
            };
            let v214: () = {
                Spiral_wasm::closure8(v6.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v6.l0.get().clone()
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
            v8: bool,
            v9: f64,
            v10: f64,
            v11: u64,
            v12: u128,
        ) -> string {
            let v13: string = Spiral_wasm::method38(v8, v9, v10, v11, v12);
            Spiral_wasm::method19(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("near_workspaces.print_usd / outcome"),
                v13
            ))
        }
        pub fn closure21(v0_1: bool, v1: u64, v2: f64, v3: u128, v4: f64, unitVar: ()) {
            if Spiral_wasm::method8(Spiral_wasm::US3::US3_2) {
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
                Spiral_wasm::method20(Spiral_wasm::method37(
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    Spiral_wasm::method9(v23, v24, v25, v26, v27, v28),
                    Spiral_wasm::method34(),
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
            let v12: f64 = v6 as f64 / 10000000000000000.0_f64 * 6.68_f64;
            let v14: near_workspaces::types::NearToken = v0_1.tokens_burnt;
            let v16: u128 = v14.as_yoctonear();
            let v23: () = {
                Spiral_wasm::closure21(
                    v2,
                    v6,
                    v12,
                    v16.clone(),
                    v16 as f64 / 1E+24_f64 * 6.68_f64,
                    (),
                );
                ()
            };
            ()
        }
        pub fn method40(
            v0_1: Result<
                near_workspaces::result::ExecutionSuccess,
                near_workspaces::result::ExecutionFailure,
            >,
        ) -> string {
            let v2: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method15()),
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
            let v65: () = {
                Spiral_wasm::closure8(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v32)),
                    (),
                );
                ()
            };
            let v74: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
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
            v8: Result<
                near_workspaces::result::ExecutionSuccess,
                near_workspaces::result::ExecutionFailure,
            >,
        ) -> string {
            let v9: string = Spiral_wasm::method40(v8);
            Spiral_wasm::method19(sprintf!(
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
            if Spiral_wasm::method8(Spiral_wasm::US3::US3_0) {
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
                Spiral_wasm::method20(Spiral_wasm::method39(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_wasm::method9(v19, v20, v21, v22, v23, v24),
                    Spiral_wasm::method13(),
                    v0_1,
                ))
            };
        }
        pub fn method41(
            v0_1: near_workspaces::result::ExecutionFinalResult,
        ) -> near_workspaces::result::ExecutionFinalResult {
            v0_1
        }
        pub fn method43(v0_1: i32, v1: Vec<&near_workspaces::result::ExecutionOutcome>) -> string {
            let v3: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method15()),
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
            let v100: () = {
                Spiral_wasm::closure8(
                    v3.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v67)),
                    (),
                );
                ()
            };
            let v109: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method42(
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
            let v10: string = Spiral_wasm::method43(v8, v9);
            Spiral_wasm::method19(sprintf!(
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
            if Spiral_wasm::method8(Spiral_wasm::US3::US3_0) {
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
                Spiral_wasm::method20(Spiral_wasm::method42(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_wasm::method9(v20, v21, v22, v23, v24, v25),
                    Spiral_wasm::method13(),
                    v1,
                    v0_1,
                ))
            };
        }
        pub fn method44(
            v0_1: near_workspaces::result::ExecutionFinalResult,
        ) -> near_workspaces::result::ExecutionFinalResult {
            v0_1
        }
        pub fn method46(v0_1: i32, v1: Vec<near_workspaces::result::ExecutionOutcome>) -> string {
            let v3: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method15()),
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
            let v100: () = {
                Spiral_wasm::closure8(
                    v3.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v67)),
                    (),
                );
                ()
            };
            let v109: () = {
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method45(
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
            let v10: string = Spiral_wasm::method46(v8, v9);
            Spiral_wasm::method19(sprintf!(
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
            if Spiral_wasm::method8(Spiral_wasm::US3::US3_0) {
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
                Spiral_wasm::method20(Spiral_wasm::method45(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_wasm::method9(v20, v21, v22, v23, v24, v25),
                    Spiral_wasm::method13(),
                    v1,
                    v0_1,
                ))
            };
        }
        pub fn method48(
            v0_1: Result<std::string::String, near_workspaces::error::Error>,
        ) -> string {
            let v2: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method15()),
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
            let v65: () = {
                Spiral_wasm::closure8(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v32)),
                    (),
                );
                ()
            };
            let v74: () = {
                Spiral_wasm::closure8(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
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
            v8: Result<std::string::String, near_workspaces::error::Error>,
        ) -> string {
            let v9: string = Spiral_wasm::method48(v8);
            Spiral_wasm::method19(sprintf!(
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
            if Spiral_wasm::method8(Spiral_wasm::US3::US3_0) {
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
                Spiral_wasm::method20(Spiral_wasm::method47(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_wasm::method9(v19, v20, v21, v22, v23, v24),
                    Spiral_wasm::method13(),
                    v0_1,
                ))
            };
        }
        pub fn method50(
            v0_1: Result<std::string::String, near_workspaces::error::Error>,
        ) -> string {
            let v2: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method15()),
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
            let v65: () = {
                Spiral_wasm::closure8(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v32)),
                    (),
                );
                ()
            };
            let v74: () = {
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
            Spiral_wasm::method19(sprintf!(
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
            if Spiral_wasm::method8(Spiral_wasm::US3::US3_0) {
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
                Spiral_wasm::method20(Spiral_wasm::method49(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_wasm::method9(v19, v20, v21, v22, v23, v24),
                    Spiral_wasm::method13(),
                    v0_1,
                ))
            };
        }
        pub fn method51(
            v0_1: i32,
            v1: u8,
            v2: Vec<&near_workspaces::result::ExecutionOutcome>,
        ) -> string {
            let v4: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method15()),
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
            let v134: () = {
                Spiral_wasm::closure8(
                    v4.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v101)),
                    (),
                );
                ()
            };
            let v143: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method52(
            v0_1: Result<Spiral_wasm::US7, anyhow::Error>,
        ) -> Result<Spiral_wasm::US7, anyhow::Error> {
            v0_1
        }
        pub fn method28(
            v0_1: Vec<u8>,
            v1: u8,
        ) -> std::pin::Pin<
            Box<dyn std::future::Future<Output = Result<Spiral_wasm::US7, anyhow::Error>>>,
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
                        let v144: bool = true;
                        v121
                    })
                    .collect::<Vec<_>>();
                let v146: Vec<std::string::String> = _vec_map;
                let v149: bool = true;
                v146.iter().for_each(|x| {
                    Func1::new(move |v: std::string::String| Spiral_wasm::closure16((), v))(
                        x.clone(),
                    );
                }); //;
                let v152: () = {
                    Spiral_wasm::closure18((), ());
                    ()
                };
                let v156: near_workspaces::types::Gas = v70.clone().total_gas_burnt;
                let v158: u64 = v156.as_gas();
                let v167: () = {
                    Spiral_wasm::closure19(
                        v1,
                        v158,
                        v158 as f64 / 10000000000000000.0_f64 * 6.68_f64,
                        (),
                    );
                    ()
                };
                let v208: near_workspaces::result::ExecutionFinalResult = v70.clone();
                let v210: Vec<&near_workspaces::result::ExecutionOutcome> = v208.outcomes();
                let v212 = v210.into_iter();
                let v214 = v212.cloned();
                let v217: bool = true;
                v214.for_each(|x| {
                    Func1::new(move |v_1: near_workspaces::result::ExecutionOutcome| {
                        Spiral_wasm::closure20((), v_1)
                    })(x)
                });
                let v222: () = {
                    Spiral_wasm::closure22(v70.clone().into_result(), ());
                    ()
                };
                let v262: near_workspaces::result::ExecutionFinalResult =
                    Spiral_wasm::method41(v70.clone());
                let v264: Vec<&near_workspaces::result::ExecutionOutcome> = v262.receipt_failures();
                let v267: i32 = v264.clone().len() as i32;
                let v276: () = {
                    Spiral_wasm::closure23(v264.clone(), v267, ());
                    ()
                };
                let v316: near_workspaces::result::ExecutionFinalResult =
                    Spiral_wasm::method44(v70.clone());
                let v318: &[near_workspaces::result::ExecutionOutcome] = v316.receipt_outcomes();
                let v320: Vec<near_workspaces::result::ExecutionOutcome> = v318.into();
                let v323: i32 = v320.clone().len() as i32;
                let v332: () = {
                    Spiral_wasm::closure24(v320, v323, ());
                    ()
                };
                let v376: () = {
                    Spiral_wasm::closure25(v70.clone().json(), ());
                    ()
                };
                let v420: () = {
                    Spiral_wasm::closure26(v70.borsh(), ());
                    ()
                };
                let v460: string = Spiral_wasm::method51(v323, v1, v264);
                let v485: Result<Spiral_wasm::US7, anyhow::Error> =
                    Spiral_wasm::method52(if v267 > 0_i32 {
                        Ok::<Spiral_wasm::US7, anyhow::Error>(Spiral_wasm::US7::US7_0(v460.clone()))
                    } else {
                        if v323 > 1_i32 {
                            Ok::<Spiral_wasm::US7, anyhow::Error>(Spiral_wasm::US7::US7_1)
                        } else {
                            let v468: anyhow::Error = anyhow::anyhow!(v460);
                            Err(v468)
                        }
                    });
                let v488: string = string("}");
                let v492: bool = true;
                let v489 = v485;
                let v504: string = append(
                    append(
                        append(append(string("true; v489 "), v488), string("); ")),
                        string(""),
                    ),
                    string(" // rust.fix_closure\'"),
                );
                let v505: bool = true;
                v489
            }); // rust.fix_closure';
            let v507 = __future_init;
            v507
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
            let v6: string = Spiral_wasm::method14(getCharAt(toLower(string("Warning")), 0_i32));
            let v9: &str = inline_colorization::color_yellow;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method58(v0_1: u8, v1: std::string::String) -> string {
            let v3: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method15()),
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
            let v100: () = {
                Spiral_wasm::closure8(
                    v3.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v67)),
                    (),
                );
                ()
            };
            let v109: () = {
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
            Spiral_wasm::method19(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_wasm.run / Error error"),
                v10
            ))
        }
        pub fn closure30(v0_1: u8, v1: std::string::String, unitVar: ()) {
            if Spiral_wasm::method8(Spiral_wasm::US3::US3_3) {
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
                Spiral_wasm::method20(Spiral_wasm::method57(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_wasm::method9(v20, v21, v22, v23, v24, v25),
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
            if Spiral_wasm::method8(Spiral_wasm::US3::US3_3) {
                Spiral_wasm::method59();
            };
        }
        pub fn method60(v0_1: u8) -> (u8, Spiral_wasm::US7) {
            (v0_1, Spiral_wasm::US7::US7_1)
        }
        pub fn closure32(v0_1: u8, v1: std::string::String, unitVar: ()) {
            if Spiral_wasm::method8(Spiral_wasm::US3::US3_3) {
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
                Spiral_wasm::method20(Spiral_wasm::method57(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_wasm::method9(v20, v21, v22, v23, v24, v25),
                    Spiral_wasm::method56(),
                    v0_1,
                    v1,
                ))
            };
        }
        pub fn closure33(unitVar: (), unitVar_1: ()) {
            if Spiral_wasm::method8(Spiral_wasm::US3::US3_3) {
                Spiral_wasm::method59();
            };
        }
        pub fn method61() -> string {
            let v6: string = Spiral_wasm::method14(getCharAt(toLower(string("Critical")), 0_i32));
            let v9: &str = inline_colorization::color_bright_red;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method63(v0_1: u8, v1: string) -> string {
            let v3: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method15()),
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
        pub fn method62(
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
            let v10: string = Spiral_wasm::method63(v8, v9);
            Spiral_wasm::method19(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_wasm.run / Ok (Some error)"),
                v10
            ))
        }
        pub fn closure34(v0_1: u8, v1: string, unitVar: ()) {
            if Spiral_wasm::method8(Spiral_wasm::US3::US3_4) {
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
                Spiral_wasm::method20(Spiral_wasm::method62(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_wasm::method9(v20, v21, v22, v23, v24, v25),
                    Spiral_wasm::method61(),
                    v0_1,
                    v1,
                ))
            };
        }
        pub fn method64(v0_1: u8, v1: string) -> (u8, Spiral_wasm::US7) {
            (v0_1, Spiral_wasm::US7::US7_0(v1))
        }
        pub fn method65(v0_1: Spiral_wasm::US8) -> Spiral_wasm::US8 {
            v0_1
        }
        pub fn method27(
            v0_1: Vec<u8>,
            v1: u8,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Spiral_wasm::US8>>> {
            let v3: bool = true;
            let __future_init = Box::pin(async move {
                //;
                let v4: std::pin::Pin<
                    Box<dyn std::future::Future<Output = Result<Spiral_wasm::US7, anyhow::Error>>>,
                > = Spiral_wasm::method28(v0_1.clone(), v1);
                let v6: Result<Spiral_wasm::US7, anyhow::Error> = v4.await;
                let v7 = Spiral_wasm::method53();
                let v19: Result<Spiral_wasm::US7, std::string::String> = v6.map_err(|x| v7(x));
                let v22 = Spiral_wasm::method54();
                let v23 = Spiral_wasm::method55();
                let v24: Spiral_wasm::US9 = match &v19 {
                    Err(v19_1_0) => v23(v19_1_0.clone()),
                    Ok(v19_0_0) => v22(v19_0_0.clone()),
                };
                let v270: Spiral_wasm::US8 = Spiral_wasm::method65(match &v24 {
                    Spiral_wasm::US9::US9_0(v24_0_0) => {
                        let v25: Spiral_wasm::US7 = v24_0_0.clone();
                        match &v25 {
                            Spiral_wasm::US7::US7_0(v25_0_0) => {
                                let v58: string = match &v25 {
                                    Spiral_wasm::US7::US7_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                let v61: () = {
                                    Spiral_wasm::closure34(v1, v58.clone(), ());
                                    ()
                                };
                                let v102: bool = true;
                                let __future_init = Box::pin(async move {
                                    //;
                                    let patternInput_4: (u8, Spiral_wasm::US7) =
                                        Spiral_wasm::method64(v1, v58);
                                    let v107: string = string("}");
                                    let v111: bool = true;
                                    let v108 = (patternInput_4.0.clone(), patternInput_4.1.clone());
                                    let v123: string = append(
                                        append(
                                            append(
                                                append(string("true; v108 "), v107),
                                                string("); "),
                                            ),
                                            string(""),
                                        ),
                                        string(" // rust.fix_closure\'"),
                                    );
                                    let v124: bool = true;
                                    v108
                                }); // rust.fix_closure';
                                let v126 = __future_init;
                                let v128: std::pin::Pin<
                                    Box<dyn std::future::Future<Output = (u8, Spiral_wasm::US7)>>,
                                > = v126;
                                let patternInput_5: (u8, Spiral_wasm::US7) = v128.await;
                                Spiral_wasm::US8::US8_1(
                                    patternInput_5.0.clone(),
                                    patternInput_5.1.clone(),
                                )
                            }
                            _ => {
                                let v27: bool = true;
                                let __future_init = Box::pin(async move {
                                    //;
                                    let patternInput_2: (u8, Spiral_wasm::US7) =
                                        Spiral_wasm::method60(v1);
                                    let v32: string = string("}");
                                    let v36: bool = true;
                                    let v33 = (patternInput_2.0.clone(), patternInput_2.1.clone());
                                    let v48: string = append(
                                        append(
                                            append(
                                                append(string("true; v33 "), v32),
                                                string("); "),
                                            ),
                                            string(""),
                                        ),
                                        string(" // rust.fix_closure\'"),
                                    );
                                    let v49: bool = true;
                                    v33
                                }); // rust.fix_closure';
                                let v51 = __future_init;
                                let v53: std::pin::Pin<
                                    Box<dyn std::future::Future<Output = (u8, Spiral_wasm::US7)>>,
                                > = v51;
                                let patternInput_3: (u8, Spiral_wasm::US7) = v53.await;
                                Spiral_wasm::US8::US8_0(
                                    patternInput_3.0.clone(),
                                    patternInput_3.1.clone(),
                                )
                            }
                        }
                    }
                    Spiral_wasm::US9::US9_1(v24_1_0) => {
                        let v135: std::string::String = v24_1_0.clone();
                        if v1 >= 15_u8 {
                            let v139: () = {
                                Spiral_wasm::closure30(v1, v135.clone(), ());
                                ()
                            };
                            let v181: () = {
                                Spiral_wasm::closure31((), ());
                                ()
                            };
                            let v185: bool = true;
                            let __future_init = Box::pin(async move {
                                //;
                                let patternInput: (u8, Spiral_wasm::US7) =
                                    Spiral_wasm::method60(v1);
                                let v190: string = string("}");
                                let v194: bool = true;
                                let v191 = (patternInput.0.clone(), patternInput.1.clone());
                                let v206: string = append(
                                    append(
                                        append(append(string("true; v191 "), v190), string("); ")),
                                        string(""),
                                    ),
                                    string(" // rust.fix_closure\'"),
                                );
                                let v207: bool = true;
                                v191
                            }); // rust.fix_closure';
                            let v209 = __future_init;
                            let v211: std::pin::Pin<
                                Box<dyn std::future::Future<Output = (u8, Spiral_wasm::US7)>>,
                            > = v209;
                            let patternInput_1: (u8, Spiral_wasm::US7) = v211.await;
                            Spiral_wasm::US8::US8_0(
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                            )
                        } else {
                            let v218: () = {
                                Spiral_wasm::closure32(v1, v135, ());
                                ()
                            };
                            let v260: () = {
                                Spiral_wasm::closure33((), ());
                                ()
                            };
                            let v264: std::pin::Pin<
                                Box<dyn std::future::Future<Output = Spiral_wasm::US8>>,
                            > = Spiral_wasm::method27(v0_1, v1 + 1_u8);
                            v264.await
                        }
                    }
                });
                let v273: string = string("}");
                let v277: bool = true;
                let v274 = v270;
                let v289: string = append(
                    append(
                        append(append(string("true; v274 "), v273), string("); ")),
                        string(""),
                    ),
                    string(" // rust.fix_closure\'"),
                );
                let v290: bool = true;
                v274
            }); // rust.fix_closure';
            let v292 = __future_init;
            v292
        }
        pub fn method67(v0_1: Spiral_wasm::US8) -> string {
            let v2: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method15()),
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
        pub fn method66(
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
            let v9: string = Spiral_wasm::method67(v8);
            Spiral_wasm::method19(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_wasm.run"),
                v9
            ))
        }
        pub fn closure35(v0_1: Spiral_wasm::US8, unitVar: ()) {
            if Spiral_wasm::method8(Spiral_wasm::US3::US3_0) {
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
                Spiral_wasm::method20(Spiral_wasm::method66(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_wasm::method9(v19, v20, v21, v22, v23, v24),
                    Spiral_wasm::method13(),
                    v0_1,
                ))
            };
        }
        pub fn method68(v0_1: Spiral_wasm::US8, v1: Spiral_wasm::US7) -> string {
            let v3: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method15()),
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
        pub fn method69(v0_1: Result<u8, anyhow::Error>) -> Result<u8, anyhow::Error> {
            v0_1
        }
        pub fn method23(
            v0_1: clap::ArgMatches,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<u8, anyhow::Error>>>>
        {
            let v2: bool = true;
            let __future_init = Box::pin(async move {
                //;
                let v3: string = Spiral_wasm::method24();
                let v6: &str = &*v3;
                let v29: Option<std::string::String> =
                    clap::ArgMatches::get_one(&v0_1, v6).cloned();
                let v43: Spiral_wasm::US0 =
                    defaultValue(Spiral_wasm::US0::US0_1, map(Spiral_wasm::method2(), v29));
                let v50: std::string::String = match &v43 {
                    Spiral_wasm::US0::US0_0(v43_0_0) => match &v43 {
                        Spiral_wasm::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                };
                let v52: string = fable_library_rust::String_::fromString(v50);
                let v55: () = {
                    Spiral_wasm::closure13(v52.clone(), ());
                    ()
                };
                let v96: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v52);
                let v100: std::pin::Pin<Box<dyn std::future::Future<Output = Spiral_wasm::US8>>> =
                    Spiral_wasm::method27(v96?, 1_u8);
                let v102: Spiral_wasm::US8 = v100.await;
                let v105: () = {
                    Spiral_wasm::closure35(v102.clone(), ());
                    ()
                };
                let v169: Result<u8, anyhow::Error> = Spiral_wasm::method69(match &v102 {
                    Spiral_wasm::US8::US8_0(v102_0_0, v102_0_1) => {
                        Ok::<u8, anyhow::Error>(v102_0_0.clone())
                    }
                    Spiral_wasm::US8::US8_1(v102_1_0, v102_1_1) => {
                        let v150: string = Spiral_wasm::method68(v102.clone(), v102_1_1.clone());
                        let v152: anyhow::Error = anyhow::anyhow!(v150);
                        Err(v152)
                    }
                });
                let v172: string = string("}");
                let v176: bool = true;
                let v173 = v169;
                let v188: string = append(
                    append(
                        append(append(string("true; v173 "), v172), string("); ")),
                        string(""),
                    ),
                    string(" // rust.fix_closure\'"),
                );
                let v189: bool = true;
                v173
            }); // rust.fix_closure';
            let v191 = __future_init;
            v191
        }
        pub fn closure36(unitVar: (), v0_1: u8) -> Spiral_wasm::US10 {
            Spiral_wasm::US10::US10_0(v0_1)
        }
        pub fn method70() -> Func1<u8, Spiral_wasm::US10> {
            Func1::new(move |v: u8| Spiral_wasm::closure36((), v))
        }
        pub fn closure37(unitVar: (), v0_1: std::string::String) -> Spiral_wasm::US10 {
            Spiral_wasm::US10::US10_1(v0_1)
        }
        pub fn method71() -> Func1<std::string::String, Spiral_wasm::US10> {
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
                    let v50: string = fable_library_rust::String_::fromString(match &v44 {
                        Spiral_wasm::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    });
                    let v55: Spiral_wasm::US2 = if string("Verbose") == v50.clone() {
                        Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_0)
                    } else {
                        Spiral_wasm::US2::US2_1
                    };
                    Spiral_wasm::US1::US1_0(match &v55 {
                        Spiral_wasm::US2::US2_0(v55_0_0) => Spiral_wasm::US2::US2_0(match &v55 {
                            Spiral_wasm::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v62: Spiral_wasm::US2 = if string("Debug") == v50.clone() {
                                Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_1)
                            } else {
                                Spiral_wasm::US2::US2_1
                            };
                            match &v62 {
                                Spiral_wasm::US2::US2_0(v62_0_0) => {
                                    Spiral_wasm::US2::US2_0(match &v62 {
                                        Spiral_wasm::US2::US2_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v69: Spiral_wasm::US2 = if string("Info") == v50.clone() {
                                        Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_2)
                                    } else {
                                        Spiral_wasm::US2::US2_1
                                    };
                                    match &v69 {
                                        Spiral_wasm::US2::US2_0(v69_0_0) => {
                                            Spiral_wasm::US2::US2_0(match &v69 {
                                                Spiral_wasm::US2::US2_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v76: Spiral_wasm::US2 =
                                                if string("Warning") == v50.clone() {
                                                    Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_3)
                                                } else {
                                                    Spiral_wasm::US2::US2_1
                                                };
                                            match &v76 {
                                                Spiral_wasm::US2::US2_0(v76_0_0) => {
                                                    Spiral_wasm::US2::US2_0(match &v76 {
                                                        Spiral_wasm::US2::US2_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v83: Spiral_wasm::US2 =
                                                        if string("Critical") == v50.clone() {
                                                            Spiral_wasm::US2::US2_0(
                                                                Spiral_wasm::US3::US3_4,
                                                            )
                                                        } else {
                                                            Spiral_wasm::US2::US2_1
                                                        };
                                                    match &v83 {
                                                        Spiral_wasm::US2::US2_0(v83_0_0) => {
                                                            Spiral_wasm::US2::US2_0(match &v83 {
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
            let v107: Spiral_wasm::US2 = if let Spiral_wasm::US1::US1_0(v100_0_0) = &v100 {
                let v101: Spiral_wasm::US2 = match &v100 {
                    Spiral_wasm::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                };
                if let Spiral_wasm::US2::US2_0(v101_0_0) = &v101 {
                    Spiral_wasm::US2::US2_0(match &v101 {
                        Spiral_wasm::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    })
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
            let v146: () = {
                Spiral_wasm::closure5(v0_1, ());
                ()
            };
            let v186: string = Spiral_wasm::method21();
            let v189: &str = &*v186;
            let v212: Option<std::string::String> =
                clap::ArgMatches::get_one(&v3.clone(), v189).cloned();
            let v214: Option<string> = map(Spiral_wasm::method22(), v212);
            let v299: Spiral_wasm::US7 =
                defaultValue(Spiral_wasm::US7::US7_1, map(Spiral_wasm::method7(), v214));
            let v303: std::pin::Pin<
                Box<dyn std::future::Future<Output = Result<u8, anyhow::Error>>>,
            > = Spiral_wasm::method23(v3);
            let v305 = tokio::runtime::Builder::new_multi_thread()
                .enable_all()
                .build()
                .unwrap();
            let v307: Result<u8, anyhow::Error> = v305.handle().block_on(v303);
            let v308 = Spiral_wasm::method53();
            let v320: Result<u8, std::string::String> = v307.map_err(|x| v308(x));
            let v323 = Spiral_wasm::method70();
            let v324 = Spiral_wasm::method71();
            let v325: Spiral_wasm::US10 = match &v320 {
                Err(v320_1_0) => v324(v320_1_0.clone()),
                Ok(v320_0_0) => v323(v320_0_0.clone()),
            };
            match &v325 {
                Spiral_wasm::US10::US10_0(v325_0_0) => {
                    if let Spiral_wasm::US7::US7_0(v299_0_0) = &v299 {
                        let v328: string = sprintf!(
                            "spiral_wasm.main / retries: {} / exception: \'{}\'",
                            v325_0_0.clone(),
                            match &v299 {
                                Spiral_wasm::US7::US7_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                        );
                        let v331: Result<(), string> = Err(v328);
                        v331.unwrap();
                        ();
                        ()
                    }
                }
                Spiral_wasm::US10::US10_1(v325_1_0) => {
                    let v347: std::string::String = v325_1_0.clone();
                    if let Spiral_wasm::US7::US7_0(v299_0_0) = &v299 {
                        let v348: string = match &v299 {
                            Spiral_wasm::US7::US7_0(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        if string("") == v348.clone() {
                            ()
                        } else {
                            if contains(
                                fable_library_rust::String_::fromString(v347.clone()),
                                v348.clone(),
                            ) {
                                ()
                            } else {
                                let v355: string = sprintf!(
                                    "spiral_wasm.main / exception: \'{}\' / error: {}",
                                    v348,
                                    v347
                                );
                                let v358: Result<(), string> = Err(v355);
                                v358.unwrap();
                                ();
                                ()
                            }
                        }
                    } else {
                        let v376: u8 = v320.clone().unwrap();
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
