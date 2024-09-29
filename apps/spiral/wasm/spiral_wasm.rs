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
        use fable_library_rust::String_::padLeft;
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
        #[derive(Clone, Debug)]
        pub enum US6 {
            US6_0(Spiral_wasm::US4),
            US6_1(std::string::String),
        }
        impl core::fmt::Display for Spiral_wasm::US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US7 {
            US7_0(u8),
            US7_1(u8),
        }
        impl core::fmt::Display for Spiral_wasm::US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US8 {
            US8_0(u8),
            US8_1,
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
            let v8: string = string("r#\"exception\"#");
            let v9: &'static str = r#"exception"#;
            let v11: clap::Arg = clap::Arg::new(v9);
            let v13: clap::Arg = v11.short('e');
            let v14: string = string("r#\"exception\"#");
            let v15: &'static str = r#"exception"#;
            let v17: clap::Arg = v13.long(v15);
            let v19: clap::ArgAction = clap::ArgAction::SetTrue;
            let v21: clap::Arg = v17.action(v19);
            let v23: clap::Command = clap::Command::arg(v6, v21);
            let v25: string = string("r#\"trace_level\"#");
            let v26: &'static str = r#"trace_level"#;
            let v28: clap::Arg = clap::Arg::new(v26);
            let v30: clap::Arg = v28.short('t');
            let v31: string = string("r#\"trace_level\"#");
            let v32: &'static str = r#"trace_level"#;
            let v34: clap::Arg = v30.long(v32);
            let v57: Array<string> = toArray(ofArray(new_array(&[
                string("Verbose"),
                string("Debug"),
                string("Info"),
                string("Warning"),
                string("Critical"),
            ])));
            let v61: Vec<string> = v57.to_vec();
            let v63: bool = true;
            let _vec_map: Vec<_> = v61
                .into_iter()
                .map(|x| {
                    //;
                    let v65: string = x;
                    let v68: &str = &*v65;
                    let v89: std::string::String = String::from(v68);
                    let v109: Box<std::string::String> = Box::new(v89);
                    let v111: &'static mut std::string::String = Box::leak(v109);
                    let v113: clap::builder::PossibleValue =
                        clap::builder::PossibleValue::new(&**v111);
                    let v115: bool = true;
                    v113
                })
                .collect::<Vec<_>>();
            let v117: Vec<clap::builder::PossibleValue> = _vec_map;
            let v119: clap::builder::ValueParser = Into::<clap::builder::ValueParser>::into(
                clap::builder::PossibleValuesParser::new(v117),
            );
            let v121: clap::Arg = v34.value_parser(v119);
            let v123: clap::Command = clap::Command::arg(v23, v121);
            let v125: string = string("r#\"wasm\"#");
            let v126: &'static str = r#"wasm"#;
            let v128: clap::Arg = clap::Arg::new(v126);
            let v130: clap::Arg = v128.short('w');
            let v131: string = string("r#\"wasm\"#");
            let v132: &'static str = r#"wasm"#;
            let v134: clap::Arg = v130.long(v132);
            let v136: clap::Arg = v134.required(true);
            clap::Command::arg(v123, v136)
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
        pub fn closure7(unitVar: (), v0_1: i64) -> Spiral_wasm::US5 {
            Spiral_wasm::US5::US5_0(v0_1)
        }
        pub fn method10() -> Func1<i64, Spiral_wasm::US5> {
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
            let v20: Spiral_wasm::US5 =
                defaultValue(Spiral_wasm::US5::US5_1, map(Spiral_wasm::method10(), v5));
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
            let provider: string = Spiral_wasm::method11();
            v60.toString(provider)
        }
        pub fn method14() -> string {
            string("\u{001b}[0m")
        }
        pub fn method13() -> string {
            let v5: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v21: &str = inline_colorization::color_bright_black;
            let v24: &str = &*v5;
            let v44: &str = inline_colorization::color_reset;
            let v46: std::string::String = format!("{}{}{}", v21, v24, v44);
            fable_library_rust::String_::fromString(v46)
        }
        pub fn method16() -> string {
            string("")
        }
        pub fn closure8(v0_1: LrcPtr<Spiral_wasm::Mut3>, v1: string, unitVar: ()) {
            let v3: string = append(v0_1.l0.get().clone(), v1);
            v0_1.l0.set(v3);
            ()
        }
        pub fn method15(v0_1: Array<string>) -> string {
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
        pub fn method17(v0_1: string, v1: string, v2: string, v3: i64, v4: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!("{} {} #{} {} / {}", v0_1, v1, v3, v2, v4),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
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
        pub fn method18(
            v0_1: string,
            v1: LrcPtr<Spiral_wasm::Mut0>,
            v2: LrcPtr<Spiral_wasm::Mut1>,
            v3: LrcPtr<Spiral_wasm::Mut2>,
            v4: LrcPtr<Spiral_wasm::Mut3>,
            v5: LrcPtr<Spiral_wasm::Mut4>,
            v6: Option<i64>,
        ) {
            let v9: () = {
                Spiral_wasm::closure9(v1, ());
                ()
            };
            println!("{}", v0_1.clone());
            ();
            (v2.l0.get().clone())(v0_1)
        }
        pub fn closure5(v0_1: Array<string>, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v82: string = Spiral_wasm::method17(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method13(),
                    string("spiral_wasm.main"),
                    v56.l0.get().clone(),
                    Spiral_wasm::method15(v0_1),
                );
                let v84: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v82,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method19() -> string {
            string("exception")
        }
        pub fn method21() -> string {
            string("wasm")
        }
        pub fn method22(v0_1: string) -> string {
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
        pub fn method23(v0_1: string, v1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1,
                        v2,
                        string("spiral_wasm.run"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure12(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v78: string = Spiral_wasm::method23(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method13(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method22(v0_1),
                );
                let v80: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v78,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method25(
            v0_1: u8,
            v1: near_workspaces::Worker<near_workspaces::network::Sandbox>,
        ) -> string {
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
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("worker")), ());
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
        pub fn closure13(
            v0_1: u8,
            v1: near_workspaces::Worker<near_workspaces::network::Sandbox>,
            unitVar: (),
        ) {
            fn v3() {
                Spiral_wasm::closure6((), ());
            }
            let v4: () = {
                v3();
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
            let v36: Spiral_wasm::US3 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method23(
                    Spiral_wasm::method9(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method13(),
                    v57.l0.get().clone(),
                    Spiral_wasm::method25(v0_1, v1),
                );
                let v81: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method26(v0_1: u8, v1: near_workspaces::Contract) -> string {
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
                Spiral_wasm::closure8(v3.clone(), sprintf!("{}", string("contract")), ());
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
        pub fn closure14(v0_1: u8, v1: near_workspaces::Contract, unitVar: ()) {
            fn v3() {
                Spiral_wasm::closure6((), ());
            }
            let v4: () = {
                v3();
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
            let v36: Spiral_wasm::US3 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method23(
                    Spiral_wasm::method9(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method13(),
                    v57.l0.get().clone(),
                    Spiral_wasm::method26(v0_1, v1),
                );
                let v81: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method27(v0_1: u8, v1: near_workspaces::result::ExecutionFinalResult) -> string {
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
        pub fn closure15(v0_1: u8, v1: near_workspaces::result::ExecutionFinalResult, unitVar: ()) {
            fn v3() {
                Spiral_wasm::closure6((), ());
            }
            let v4: () = {
                v3();
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
            let v36: Spiral_wasm::US3 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method23(
                    Spiral_wasm::method9(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method13(),
                    v57.l0.get().clone(),
                    Spiral_wasm::method27(v0_1, v1),
                );
                let v81: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
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
        pub fn method28() -> string {
            let v5: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v21: &str = inline_colorization::color_bright_blue;
            let v24: &str = &*v5;
            let v44: &str = inline_colorization::color_reset;
            let v46: std::string::String = format!("{}{}{}", v21, v24, v44);
            fable_library_rust::String_::fromString(v46)
        }
        pub fn method29(v0_1: u8, v1: f64, v2: u64) -> string {
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
        pub fn method30(v0_1: string, v1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1,
                        v2,
                        string("near_workspaces.print_usd"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure18(v0_1: u8, v1: u64, v2: f64, unitVar: ()) {
            fn v4() {
                Spiral_wasm::closure6((), ());
            }
            let v5: () = {
                v4();
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
            let v37: Spiral_wasm::US3 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v80: string = Spiral_wasm::method30(
                    Spiral_wasm::method9(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method28(),
                    v58.l0.get().clone(),
                    Spiral_wasm::method29(v0_1, v2, v1),
                );
                let v82: () = {
                    v4();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v80,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method31(v0_1: bool, v1: f64, v2: f64, v3: u64, v4: u128) -> string {
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
        pub fn method32(v0_1: string, v1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1,
                        v2,
                        string("near_workspaces.print_usd / outcome"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure20(v0_1: bool, v1: u64, v2: f64, v3: u128, v4: f64, unitVar: ()) {
            fn v6() {
                Spiral_wasm::closure6((), ());
            }
            let v7: () = {
                v6();
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
            let v39: Spiral_wasm::US3 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v39,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v46: () = {
                    v6();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v60: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v82: string = Spiral_wasm::method32(
                    Spiral_wasm::method9(
                        v60.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method28(),
                    v60.l0.get().clone(),
                    Spiral_wasm::method31(v0_1, v2, v4, v1, v3),
                );
                let v84: () = {
                    v6();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v82,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure19(unitVar: (), v0_1: near_workspaces::result::ExecutionOutcome) {
            let v2: bool = v0_1.clone().is_success();
            let v4: near_workspaces::types::Gas = v0_1.clone().gas_burnt;
            let v6: u64 = v4.as_gas();
            let v10: f64 = v6 as f64 / 10000000000000000.0_f64 * 6.68_f64;
            let v12: near_workspaces::types::NearToken = v0_1.tokens_burnt;
            let v14: u128 = v12.as_yoctonear();
            let v21: () = {
                Spiral_wasm::closure20(
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
        pub fn method33(
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
        pub fn closure21(
            v0_1: Result<
                near_workspaces::result::ExecutionSuccess,
                near_workspaces::result::ExecutionFailure,
            >,
            unitVar: (),
        ) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v78: string = Spiral_wasm::method23(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method13(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method33(v0_1),
                );
                let v80: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v78,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method34(
            v0_1: near_workspaces::result::ExecutionFinalResult,
        ) -> near_workspaces::result::ExecutionFinalResult {
            v0_1
        }
        pub fn method35(v0_1: i32, v1: Vec<&near_workspaces::result::ExecutionOutcome>) -> string {
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
        pub fn closure22(
            v0_1: Vec<&near_workspaces::result::ExecutionOutcome>,
            v1: i32,
            unitVar: (),
        ) {
            fn v3() {
                Spiral_wasm::closure6((), ());
            }
            let v4: () = {
                v3();
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
            let v36: Spiral_wasm::US3 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method23(
                    Spiral_wasm::method9(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method13(),
                    v57.l0.get().clone(),
                    Spiral_wasm::method35(v1, v0_1),
                );
                let v81: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method36(
            v0_1: near_workspaces::result::ExecutionFinalResult,
        ) -> near_workspaces::result::ExecutionFinalResult {
            v0_1
        }
        pub fn method37(v0_1: i32, v1: Vec<near_workspaces::result::ExecutionOutcome>) -> string {
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
        pub fn closure23(
            v0_1: Vec<near_workspaces::result::ExecutionOutcome>,
            v1: i32,
            unitVar: (),
        ) {
            fn v3() {
                Spiral_wasm::closure6((), ());
            }
            let v4: () = {
                v3();
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
            let v36: Spiral_wasm::US3 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method23(
                    Spiral_wasm::method9(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method13(),
                    v57.l0.get().clone(),
                    Spiral_wasm::method37(v1, v0_1),
                );
                let v81: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method38(
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
        pub fn closure24(
            v0_1: Result<std::string::String, near_workspaces::error::Error>,
            unitVar: (),
        ) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v78: string = Spiral_wasm::method23(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method13(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method38(v0_1),
                );
                let v80: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v78,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method39(
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
        pub fn closure25(
            v0_1: Result<std::string::String, near_workspaces::error::Error>,
            unitVar: (),
        ) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v78: string = Spiral_wasm::method23(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method13(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method39(v0_1),
                );
                let v80: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v78,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method40(
            v0_1: Vec<&near_workspaces::result::ExecutionOutcome>,
            v1: i32,
            v2: u8,
        ) -> string {
            let v4: LrcPtr<Spiral_wasm::Mut3> = LrcPtr::new(Spiral_wasm::Mut3 {
                l0: MutCell::new(Spiral_wasm::method16()),
            });
            let v11: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("receipt_failures")), ());
                ()
            };
            let v29: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v34: std::string::String = format!("{:#?}", v0_1);
            let v64: () = {
                Spiral_wasm::closure8(
                    v4.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v34)),
                    (),
                );
                ()
            };
            let v73: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v82: () = {
                Spiral_wasm::closure8(
                    v4.clone(),
                    sprintf!("{}", string("receipt_outcomes_len")),
                    (),
                );
                ()
            };
            let v90: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v98: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v106: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v115: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v123: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v131: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v140: () = {
                Spiral_wasm::closure8(v4.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method41(
            v0_1: Result<Spiral_wasm::US4, anyhow::Error>,
        ) -> Result<Spiral_wasm::US4, anyhow::Error> {
            v0_1
        }
        pub fn method24(
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
                let v10: () = {
                    Spiral_wasm::closure13(v1, v7.clone(), ());
                    ()
                };
                let v123: std::pin::Pin<
                    Box<
                        dyn std::future::Future<
                            Output = Result<
                                near_workspaces::Contract,
                                near_workspaces::error::Error,
                            >,
                        >,
                    >,
                > = Box::pin(v7.dev_deploy(&v0_1));
                let v125: Result<near_workspaces::Contract, near_workspaces::error::Error> =
                    v123.await;
                let v127: near_workspaces::Contract = v125?;
                let v130: () = {
                    Spiral_wasm::closure14(v1, v127.clone(), ());
                    ()
                };
                let v244: near_workspaces::operations::CallTransaction =
                    v127.call(&*string("state_main"));
                let v246: std::pin::Pin<
                    Box<
                        dyn std::future::Future<
                            Output = Result<
                                near_workspaces::result::ExecutionFinalResult,
                                near_workspaces::error::Error,
                            >,
                        >,
                    >,
                > = Box::pin(v244.transact());
                let v248: Result<
                    near_workspaces::result::ExecutionFinalResult,
                    near_workspaces::error::Error,
                > = v246.await;
                let v250: near_workspaces::result::ExecutionFinalResult = v248?;
                let v253: () = {
                    Spiral_wasm::closure15(v1, v250.clone(), ());
                    ()
                };
                let v366: Vec<&str> = v250.logs();
                let v368: bool = true;
                let _vec_map: Vec<_> = v366
                    .into_iter()
                    .map(|x| {
                        //;
                        let v370: &str = x;
                        let v373: std::string::String = String::from(v370);
                        let v393: bool = true;
                        v373
                    })
                    .collect::<Vec<_>>();
                let v395: Vec<std::string::String> = _vec_map;
                let v398: bool = true;
                v395.iter().for_each(|x| {
                    Func1::new(move |v: std::string::String| Spiral_wasm::closure16((), v))(
                        x.clone(),
                    );
                }); //;
                let v400: near_workspaces::types::Gas = v250.clone().total_gas_burnt;
                let v402: u64 = v400.as_gas();
                let v409: () = {
                    Spiral_wasm::closure18(
                        v1,
                        v402,
                        v402 as f64 / 10000000000000000.0_f64 * 6.68_f64,
                        (),
                    );
                    ()
                };
                let v522: near_workspaces::result::ExecutionFinalResult = v250.clone();
                let v524: Vec<&near_workspaces::result::ExecutionOutcome> = v522.outcomes();
                let v526 = v524.into_iter();
                let v528 = v526.cloned();
                let v531: bool = true;
                v528.for_each(|x| {
                    Func1::new(move |v_1: near_workspaces::result::ExecutionOutcome| {
                        Spiral_wasm::closure19((), v_1)
                    })(x)
                });
                let v536: () = {
                    Spiral_wasm::closure21(v250.clone().into_result(), ());
                    ()
                };
                let v648: near_workspaces::result::ExecutionFinalResult =
                    Spiral_wasm::method34(v250.clone());
                let v650: Vec<&near_workspaces::result::ExecutionOutcome> = v648.receipt_failures();
                let v654: i32 = v650.clone().len() as i32;
                let v657: () = {
                    Spiral_wasm::closure22(v650.clone(), v654, ());
                    ()
                };
                let v769: near_workspaces::result::ExecutionFinalResult =
                    Spiral_wasm::method36(v250.clone());
                let v771: &[near_workspaces::result::ExecutionOutcome] = v769.receipt_outcomes();
                let v773: Vec<near_workspaces::result::ExecutionOutcome> = v771.into();
                let v777: i32 = v773.clone().len() as i32;
                let v780: () = {
                    Spiral_wasm::closure23(v773, v777, ());
                    ()
                };
                let v896: () = {
                    Spiral_wasm::closure24(v250.clone().json(), ());
                    ()
                };
                let v1012: () = {
                    Spiral_wasm::closure25(v250.borsh(), ());
                    ()
                };
                let v1124: string = Spiral_wasm::method40(v650, v777, v1);
                let v1148: Result<Spiral_wasm::US4, anyhow::Error> =
                    Spiral_wasm::method41(if v654 > 0_i32 {
                        Ok::<Spiral_wasm::US4, anyhow::Error>(Spiral_wasm::US4::US4_0(
                            v1124.clone(),
                        ))
                    } else {
                        if v777 > 1_i32 {
                            Ok::<Spiral_wasm::US4, anyhow::Error>(Spiral_wasm::US4::US4_1)
                        } else {
                            let v1132: anyhow::Error = anyhow::anyhow!(v1124);
                            Err(v1132)
                        }
                    });
                let v1152: string = string("true; v1148 });  // rust.fix_closure\'");
                let v1153: bool = true;
                v1148
            }); // rust.fix_closure';
            let v1155 = __future_init;
            v1155
        }
        pub fn closure26(unitVar: (), v0_1: anyhow::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method42() -> Func1<anyhow::Error, std::string::String> {
            Func1::new(move |v: anyhow::Error| Spiral_wasm::closure26((), v))
        }
        pub fn closure27(unitVar: (), v0_1: Spiral_wasm::US4) -> Spiral_wasm::US6 {
            Spiral_wasm::US6::US6_0(v0_1)
        }
        pub fn closure28(unitVar: (), v0_1: std::string::String) -> Spiral_wasm::US6 {
            Spiral_wasm::US6::US6_1(v0_1)
        }
        pub fn method43() -> string {
            let v5: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
            let v21: &str = inline_colorization::color_yellow;
            let v24: &str = &*v5;
            let v44: &str = inline_colorization::color_reset;
            let v46: std::string::String = format!("{}{}{}", v21, v24, v44);
            fable_library_rust::String_::fromString(v46)
        }
        pub fn method44(v0_1: u8, v1: std::string::String) -> string {
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
        pub fn method45(v0_1: string, v1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1,
                        v2,
                        string("spiral_wasm.run / Error error"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure29(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(1_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure30(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(2_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure31(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(3_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure32(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(4_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure33(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(5_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure34(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(6_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure35(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(7_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure36(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(8_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure37(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(9_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure38(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(10_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure39(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(11_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure40(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(12_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure41(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(13_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure42(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(14_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure43(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(15_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure44(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(16_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure45(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(17_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure46(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(18_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure47(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(19_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure48(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(20_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure49(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(21_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure50(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(22_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure51(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(23_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure52(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(24_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure53(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(25_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure54(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(26_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure55(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(27_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure56(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(28_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure57(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method45(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method43(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method44(29_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method46() -> u8 {
            30_u8
        }
        pub fn method47(v0_1: u8) -> Spiral_wasm::US7 {
            Spiral_wasm::US7::US7_1(v0_1)
        }
        pub fn method48() -> u8 {
            29_u8
        }
        pub fn method49(v0_1: u8) -> Spiral_wasm::US7 {
            Spiral_wasm::US7::US7_0(v0_1)
        }
        pub fn method50() -> string {
            let v5: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
            let v21: &str = inline_colorization::color_bright_red;
            let v24: &str = &*v5;
            let v44: &str = inline_colorization::color_reset;
            let v46: std::string::String = format!("{}{}{}", v21, v24, v44);
            fable_library_rust::String_::fromString(v46)
        }
        pub fn method51(v0_1: u8, v1: string) -> string {
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
        pub fn method52(v0_1: string, v1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1,
                        v2,
                        string("spiral_wasm.run / Ok (Some error)"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure58(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(29_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method53() -> u8 {
            28_u8
        }
        pub fn closure59(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(28_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method54() -> u8 {
            27_u8
        }
        pub fn closure60(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(27_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method55() -> u8 {
            26_u8
        }
        pub fn closure61(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(26_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method56() -> u8 {
            25_u8
        }
        pub fn closure62(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(25_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method57() -> u8 {
            24_u8
        }
        pub fn closure63(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(24_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method58() -> u8 {
            23_u8
        }
        pub fn closure64(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(23_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method59() -> u8 {
            22_u8
        }
        pub fn closure65(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(22_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method60() -> u8 {
            21_u8
        }
        pub fn closure66(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(21_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method61() -> u8 {
            20_u8
        }
        pub fn closure67(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(20_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method62() -> u8 {
            19_u8
        }
        pub fn closure68(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(19_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method63() -> u8 {
            18_u8
        }
        pub fn closure69(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(18_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method64() -> u8 {
            17_u8
        }
        pub fn closure70(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(17_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method65() -> u8 {
            16_u8
        }
        pub fn closure71(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(16_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method66() -> u8 {
            15_u8
        }
        pub fn closure72(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(15_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method67() -> u8 {
            14_u8
        }
        pub fn closure73(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(14_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method68() -> u8 {
            13_u8
        }
        pub fn closure74(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(13_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method69() -> u8 {
            12_u8
        }
        pub fn closure75(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(12_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method70() -> u8 {
            11_u8
        }
        pub fn closure76(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(11_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method71() -> u8 {
            10_u8
        }
        pub fn closure77(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(10_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method72() -> u8 {
            9_u8
        }
        pub fn closure78(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(9_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method73() -> u8 {
            8_u8
        }
        pub fn closure79(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(8_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method74() -> u8 {
            7_u8
        }
        pub fn closure80(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(7_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method75() -> u8 {
            6_u8
        }
        pub fn closure81(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(6_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method76() -> u8 {
            5_u8
        }
        pub fn closure82(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(5_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method77() -> u8 {
            4_u8
        }
        pub fn closure83(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(4_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method78() -> u8 {
            3_u8
        }
        pub fn closure84(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(3_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method79() -> u8 {
            2_u8
        }
        pub fn closure85(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(2_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method80() -> u8 {
            1_u8
        }
        pub fn closure86(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_wasm::method52(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method50(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method51(1_u8, v0_1),
                );
                let v81: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method81(v0_1: Spiral_wasm::US7) -> string {
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
        pub fn closure87(v0_1: Spiral_wasm::US7, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure6((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                let v78: string = Spiral_wasm::method23(
                    Spiral_wasm::method9(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_wasm::method13(),
                    v56.l0.get().clone(),
                    Spiral_wasm::method81(v0_1),
                );
                let v80: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    LrcPtr<Spiral_wasm::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::TraceState::trace_state().get().clone());
                Spiral_wasm::method18(
                    v78,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method82(v0_1: u8) -> string {
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
        pub fn method83(v0_1: Result<u8, anyhow::Error>) -> Result<u8, anyhow::Error> {
            v0_1
        }
        pub fn method20(
            v0_1: clap::ArgMatches,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<u8, anyhow::Error>>>>
        {
            let v2: bool = true;
            let __future_init = Box::pin(async move {
                //;
                let v3: string = Spiral_wasm::method21();
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
                    Spiral_wasm::closure12(v49.clone(), ());
                    ()
                };
                let v165: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v49);
                let v167: Vec<u8> = v165?;
                let v169: std::pin::Pin<
                    Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4, anyhow::Error>>>,
                > = Spiral_wasm::method24(v167.clone(), 1_u8);
                let v171: Result<Spiral_wasm::US4, anyhow::Error> = v169.await;
                let v172 = Spiral_wasm::method42();
                let v183: Result<Spiral_wasm::US4, std::string::String> = v171.map_err(|x| v172(x));
                fn v186(v: Spiral_wasm::US4) -> Spiral_wasm::US6 {
                    Spiral_wasm::closure27((), v)
                }
                fn v187(v_1: std::string::String) -> Spiral_wasm::US6 {
                    Spiral_wasm::closure28((), v_1)
                }
                let v188: Spiral_wasm::US6 = match &v183 {
                    Err(v183_1_0) => v187(v183_1_0.clone()),
                    Ok(v183_0_0) => v186(v183_0_0.clone()),
                };
                let v9009: std::pin::Pin<Box<dyn std::future::Future<Output = Spiral_wasm::US7>>> =
                    match &v188 {
                        Spiral_wasm::US6::US6_0(v188_0_0) => {
                            let v189: Spiral_wasm::US4 = v188_0_0.clone();
                            match &v189 {
                                Spiral_wasm::US4::US4_0(v189_0_0) => {
                                    let v217: () = {
                                        Spiral_wasm::closure86(
                                            match &v189 {
                                                Spiral_wasm::US4::US4_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            (),
                                        );
                                        ()
                                    };
                                    let v331: bool = true;
                                    let __future_init = Box::pin(async move {
                                        //;
                                        let v333: bool = true;
                                        let __future_init = Box::pin(async move {
                                            //;
                                            let v334: u8 = Spiral_wasm::method80();
                                            let v338: string =
                                                string("true; v334 });  // rust.fix_closure\'");
                                            let v339: bool = true;
                                            v334
                                        }); // rust.fix_closure';
                                        let v341 = __future_init;
                                        let v343: std::pin::Pin<
                                            Box<dyn std::future::Future<Output = u8>>,
                                        > = v341;
                                        let v346: Spiral_wasm::US7 =
                                            Spiral_wasm::method47(v343.await);
                                        let v348: string =
                                            string("true; v346 });  // rust.fix_closure\'");
                                        let v349: bool = true;
                                        v346
                                    }); // rust.fix_closure';
                                    let v351 = __future_init;
                                    v351
                                }
                                _ => {
                                    let v191: bool = true;
                                    let __future_init = Box::pin(async move {
                                        //;
                                        let v193: bool = true;
                                        let __future_init = Box::pin(async move {
                                            //;
                                            let v194: u8 = Spiral_wasm::method80();
                                            let v198: string =
                                                string("true; v194 });  // rust.fix_closure\'");
                                            let v199: bool = true;
                                            v194
                                        }); // rust.fix_closure';
                                        let v201 = __future_init;
                                        let v203: std::pin::Pin<
                                            Box<dyn std::future::Future<Output = u8>>,
                                        > = v201;
                                        let v206: Spiral_wasm::US7 =
                                            Spiral_wasm::method49(v203.await);
                                        let v208: string =
                                            string("true; v206 });  // rust.fix_closure\'");
                                        let v209: bool = true;
                                        v206
                                    }); // rust.fix_closure';
                                    let v211 = __future_init;
                                    v211
                                }
                            }
                        }
                        Spiral_wasm::US6::US6_1(v188_1_0) => {
                            let v359: () = {
                                Spiral_wasm::closure29(v188_1_0.clone(), ());
                                ()
                            };
                            let v473: std::pin::Pin<
                                Box<
                                    dyn std::future::Future<
                                        Output = Result<Spiral_wasm::US4, anyhow::Error>,
                                    >,
                                >,
                            > = Spiral_wasm::method24(v167.clone(), 2_u8);
                            let v475: Result<Spiral_wasm::US4, anyhow::Error> = v473.await;
                            let v476 = Spiral_wasm::method42();
                            let v487: Result<Spiral_wasm::US4, std::string::String> =
                                v475.map_err(|x| v476(x));
                            let v490: Spiral_wasm::US6 = match &v487 {
                                Err(v487_1_0) => v187(v487_1_0.clone()),
                                Ok(v487_0_0) => v186(v487_0_0.clone()),
                            };
                            match &v490 {
                                Spiral_wasm::US6::US6_0(v490_0_0) => {
                                    let v491: Spiral_wasm::US4 = v490_0_0.clone();
                                    match &v491 {
                                        Spiral_wasm::US4::US4_0(v491_0_0) => {
                                            let v519: () = {
                                                Spiral_wasm::closure85(
                                                    match &v491 {
                                                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    },
                                                    (),
                                                );
                                                ()
                                            };
                                            let v633: bool = true;
                                            let __future_init = Box::pin(async move {
                                                //;
                                                let v635: bool = true;
                                                let __future_init = Box::pin(async move {
                                                    //;
                                                    let v636: u8 = Spiral_wasm::method79();
                                                    let v640: string = string(
                                                        "true; v636 });  // rust.fix_closure\'",
                                                    );
                                                    let v641: bool = true;
                                                    v636
                                                }); // rust.fix_closure';
                                                let v643 = __future_init;
                                                let v645: std::pin::Pin<
                                                    Box<dyn std::future::Future<Output = u8>>,
                                                > = v643;
                                                let v648: Spiral_wasm::US7 =
                                                    Spiral_wasm::method47(v645.await);
                                                let v650: string =
                                                    string("true; v648 });  // rust.fix_closure\'");
                                                let v651: bool = true;
                                                v648
                                            }); // rust.fix_closure';
                                            let v653 = __future_init;
                                            v653
                                        }
                                        _ => {
                                            let v493: bool = true;
                                            let __future_init = Box::pin(async move {
                                                //;
                                                let v495: bool = true;
                                                let __future_init = Box::pin(async move {
                                                    //;
                                                    let v496: u8 = Spiral_wasm::method79();
                                                    let v500: string = string(
                                                        "true; v496 });  // rust.fix_closure\'",
                                                    );
                                                    let v501: bool = true;
                                                    v496
                                                }); // rust.fix_closure';
                                                let v503 = __future_init;
                                                let v505: std::pin::Pin<
                                                    Box<dyn std::future::Future<Output = u8>>,
                                                > = v503;
                                                let v508: Spiral_wasm::US7 =
                                                    Spiral_wasm::method49(v505.await);
                                                let v510: string =
                                                    string("true; v508 });  // rust.fix_closure\'");
                                                let v511: bool = true;
                                                v508
                                            }); // rust.fix_closure';
                                            let v513 = __future_init;
                                            v513
                                        }
                                    }
                                }
                                Spiral_wasm::US6::US6_1(v490_1_0) => {
                                    let v661: () = {
                                        Spiral_wasm::closure30(v490_1_0.clone(), ());
                                        ()
                                    };
                                    let v775: std::pin::Pin<
                                        Box<
                                            dyn std::future::Future<
                                                Output = Result<Spiral_wasm::US4, anyhow::Error>,
                                            >,
                                        >,
                                    > = Spiral_wasm::method24(v167.clone(), 3_u8);
                                    let v777: Result<Spiral_wasm::US4, anyhow::Error> = v775.await;
                                    let v778 = Spiral_wasm::method42();
                                    let v789: Result<Spiral_wasm::US4, std::string::String> =
                                        v777.map_err(|x| v778(x));
                                    let v792: Spiral_wasm::US6 = match &v789 {
                                        Err(v789_1_0) => v187(v789_1_0.clone()),
                                        Ok(v789_0_0) => v186(v789_0_0.clone()),
                                    };
                                    match &v792 {
                                        Spiral_wasm::US6::US6_0(v792_0_0) => {
                                            let v793: Spiral_wasm::US4 = v792_0_0.clone();
                                            match &v793 {
                                                Spiral_wasm::US4::US4_0(v793_0_0) => {
                                                    let v821: () = {
                                                        Spiral_wasm::closure84(
                                                            match &v793 {
                                                                Spiral_wasm::US4::US4_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            },
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    let v935: bool = true;
                                                    let __future_init = Box::pin(async move {
                                                        //;
                                                        let v937: bool = true;
                                                        let __future_init = Box::pin(async move {
                                                            //;
                                                            let v938: u8 = Spiral_wasm::method78();
                                                            let v942: string =
                                                    string("true; v938 });  // rust.fix_closure\'");
                                                            let v943: bool = true;
                                                            v938
                                                        }); // rust.fix_closure';
                                                        let v945 = __future_init;
                                                        let v947: std::pin::Pin<
                                                            Box<
                                                                dyn std::future::Future<
                                                                    Output = u8,
                                                                >,
                                                            >,
                                                        > = v945;
                                                        let v950: Spiral_wasm::US7 =
                                                            Spiral_wasm::method47(v947.await);
                                                        let v952: string = string(
                                                            "true; v950 });  // rust.fix_closure\'",
                                                        );
                                                        let v953: bool = true;
                                                        v950
                                                    }); // rust.fix_closure';
                                                    let v955 = __future_init;
                                                    v955
                                                }
                                                _ => {
                                                    let v795: bool = true;
                                                    let __future_init = Box::pin(async move {
                                                        //;
                                                        let v797: bool = true;
                                                        let __future_init = Box::pin(async move {
                                                            //;
                                                            let v798: u8 = Spiral_wasm::method78();
                                                            let v802: string =
                                                    string("true; v798 });  // rust.fix_closure\'");
                                                            let v803: bool = true;
                                                            v798
                                                        }); // rust.fix_closure';
                                                        let v805 = __future_init;
                                                        let v807: std::pin::Pin<
                                                            Box<
                                                                dyn std::future::Future<
                                                                    Output = u8,
                                                                >,
                                                            >,
                                                        > = v805;
                                                        let v810: Spiral_wasm::US7 =
                                                            Spiral_wasm::method49(v807.await);
                                                        let v812: string = string(
                                                            "true; v810 });  // rust.fix_closure\'",
                                                        );
                                                        let v813: bool = true;
                                                        v810
                                                    }); // rust.fix_closure';
                                                    let v815 = __future_init;
                                                    v815
                                                }
                                            }
                                        }
                                        Spiral_wasm::US6::US6_1(v792_1_0) => {
                                            let v963: () = {
                                                Spiral_wasm::closure31(v792_1_0.clone(), ());
                                                ()
                                            };
                                            let v1077: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = Result<
                                                            Spiral_wasm::US4,
                                                            anyhow::Error,
                                                        >,
                                                    >,
                                                >,
                                            > = Spiral_wasm::method24(v167.clone(), 4_u8);
                                            let v1079: Result<Spiral_wasm::US4, anyhow::Error> =
                                                v1077.await;
                                            let v1080 = Spiral_wasm::method42();
                                            let v1091: Result<
                                                Spiral_wasm::US4,
                                                std::string::String,
                                            > = v1079.map_err(|x| v1080(x));
                                            let v1094: Spiral_wasm::US6 = match &v1091 {
                                                Err(v1091_1_0) => v187(v1091_1_0.clone()),
                                                Ok(v1091_0_0) => v186(v1091_0_0.clone()),
                                            };
                                            match &v1094 {
                                                Spiral_wasm::US6::US6_0(v1094_0_0) => {
                                                    let v1095: Spiral_wasm::US4 = v1094_0_0.clone();
                                                    match &v1095 {
                                                        Spiral_wasm::US4::US4_0(v1095_0_0) => {
                                                            let v1123: () = {
                                                                Spiral_wasm::closure83(
                                                                    match &v1095 {
                                                                        Spiral_wasm::US4::US4_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    },
                                                                    (),
                                                                );
                                                                ()
                                                            };
                                                            let v1237: bool = true;
                                                            let __future_init = Box::pin(
                                                                async move {
                                                                    //;
                                                                    let v1239: bool = true;
                                                                    let __future_init = Box::pin(
                                                                        async move {
                                                                            //;
                                                                            let v1240: u8 =
                                                            Spiral_wasm::method77();
                                                                            let v1244: string =
                                                            string("true; v1240 });  // rust.fix_closure\'");
                                                                            let v1245: bool = true;
                                                                            v1240
                                                                        },
                                                                    ); // rust.fix_closure';
                                                                    let v1247 = __future_init;
                                                                    let v1249: std::pin::Pin<
                                                                        Box<
                                                                            dyn std::future::Future<
                                                                                Output = u8,
                                                                            >,
                                                                        >,
                                                                    > = v1247;
                                                                    let v1252: Spiral_wasm::US7 =
                                                                        Spiral_wasm::method47(
                                                                            v1249.await,
                                                                        );
                                                                    let v1254: string =
                                                            string("true; v1252 });  // rust.fix_closure\'");
                                                                    let v1255: bool = true;
                                                                    v1252
                                                                },
                                                            ); // rust.fix_closure';
                                                            let v1257 = __future_init;
                                                            v1257
                                                        }
                                                        _ => {
                                                            let v1097: bool = true;
                                                            let __future_init = Box::pin(
                                                                async move {
                                                                    //;
                                                                    let v1099: bool = true;
                                                                    let __future_init = Box::pin(
                                                                        async move {
                                                                            //;
                                                                            let v1100: u8 =
                                                            Spiral_wasm::method77();
                                                                            let v1104: string =
                                                            string("true; v1100 });  // rust.fix_closure\'");
                                                                            let v1105: bool = true;
                                                                            v1100
                                                                        },
                                                                    ); // rust.fix_closure';
                                                                    let v1107 = __future_init;
                                                                    let v1109: std::pin::Pin<
                                                                        Box<
                                                                            dyn std::future::Future<
                                                                                Output = u8,
                                                                            >,
                                                                        >,
                                                                    > = v1107;
                                                                    let v1112: Spiral_wasm::US7 =
                                                                        Spiral_wasm::method49(
                                                                            v1109.await,
                                                                        );
                                                                    let v1114: string =
                                                            string("true; v1112 });  // rust.fix_closure\'");
                                                                    let v1115: bool = true;
                                                                    v1112
                                                                },
                                                            ); // rust.fix_closure';
                                                            let v1117 = __future_init;
                                                            v1117
                                                        }
                                                    }
                                                }
                                                Spiral_wasm::US6::US6_1(v1094_1_0) => {
                                                    let v1265: () = {
                                                        Spiral_wasm::closure32(
                                                            v1094_1_0.clone(),
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    let v1379: std::pin::Pin<
                                                        Box<
                                                            dyn std::future::Future<
                                                                Output = Result<
                                                                    Spiral_wasm::US4,
                                                                    anyhow::Error,
                                                                >,
                                                            >,
                                                        >,
                                                    > = Spiral_wasm::method24(v167.clone(), 5_u8);
                                                    let v1381: Result<
                                                        Spiral_wasm::US4,
                                                        anyhow::Error,
                                                    > = v1379.await;
                                                    let v1382 = Spiral_wasm::method42();
                                                    let v1393: Result<
                                                        Spiral_wasm::US4,
                                                        std::string::String,
                                                    > = v1381.map_err(|x| v1382(x));
                                                    let v1396: Spiral_wasm::US6 = match &v1393 {
                                                        Err(v1393_1_0) => v187(v1393_1_0.clone()),
                                                        Ok(v1393_0_0) => v186(v1393_0_0.clone()),
                                                    };
                                                    match &v1396 {
                                                        Spiral_wasm::US6::US6_0(v1396_0_0) => {
                                                            let v1397: Spiral_wasm::US4 =
                                                                v1396_0_0.clone();
                                                            match &v1397 {
                                                                Spiral_wasm::US4::US4_0(
                                                                    v1397_0_0,
                                                                ) => {
                                                                    let v1425: () = {
                                                                        Spiral_wasm::closure82(match &v1397
                                                                                                   {
                                                                                                   Spiral_wasm::US4::US4_0(x)
                                                                                                   =>
                                                                                                   x.clone(),
                                                                                                   _
                                                                                                   =>
                                                                                                   unreachable!(),
                                                                                               },
                                                                                               ());
                                                                        ()
                                                                    };
                                                                    let v1539: bool = true;
                                                                    let __future_init = Box::pin(
                                                                        async move {
                                                                            //;
                                                                            let v1541: bool = true;
                                                                            let __future_init =
                                                                                Box::pin(
                                                                                    async move {
                                                                                        //;
                                                                                        let v1542:
                                                                        u8 =
                                                                    Spiral_wasm::method76();
                                                                                        let v1546:
                                                                        string =
                                                                    string("true; v1542 });  // rust.fix_closure\'");
                                                                                        let v1547:
                                                                        bool =
                                                                    true;
                                                                                        v1542
                                                                                    },
                                                                                ); // rust.fix_closure';
                                                                            let v1549 =
                                                                                __future_init;
                                                                            let v1551:
                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                    v1549;
                                                                            let v1554:
                                                                        Spiral_wasm::US7 =
                                                                    Spiral_wasm::method47(v1551.await);
                                                                            let v1556:
                                                                        string =
                                                                    string("true; v1554 });  // rust.fix_closure\'");
                                                                            let v1557: bool = true;
                                                                            v1554
                                                                        },
                                                                    ); // rust.fix_closure';
                                                                    let v1559 = __future_init;
                                                                    v1559
                                                                }
                                                                _ => {
                                                                    let v1399: bool = true;
                                                                    let __future_init = Box::pin(
                                                                        async move {
                                                                            //;
                                                                            let v1401: bool = true;
                                                                            let __future_init =
                                                                                Box::pin(
                                                                                    async move {
                                                                                        //;
                                                                                        let v1402:
                                                                        u8 =
                                                                    Spiral_wasm::method76();
                                                                                        let v1406:
                                                                        string =
                                                                    string("true; v1402 });  // rust.fix_closure\'");
                                                                                        let v1407:
                                                                        bool =
                                                                    true;
                                                                                        v1402
                                                                                    },
                                                                                ); // rust.fix_closure';
                                                                            let v1409 =
                                                                                __future_init;
                                                                            let v1411:
                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                    v1409;
                                                                            let v1414:
                                                                        Spiral_wasm::US7 =
                                                                    Spiral_wasm::method49(v1411.await);
                                                                            let v1416:
                                                                        string =
                                                                    string("true; v1414 });  // rust.fix_closure\'");
                                                                            let v1417: bool = true;
                                                                            v1414
                                                                        },
                                                                    ); // rust.fix_closure';
                                                                    let v1419 = __future_init;
                                                                    v1419
                                                                }
                                                            }
                                                        }
                                                        Spiral_wasm::US6::US6_1(v1396_1_0) => {
                                                            let v1567: () = {
                                                                Spiral_wasm::closure33(
                                                                    v1396_1_0.clone(),
                                                                    (),
                                                                );
                                                                ()
                                                            };
                                                            let v1681: std::pin::Pin<
                                                                Box<
                                                                    dyn std::future::Future<
                                                                        Output = Result<
                                                                            Spiral_wasm::US4,
                                                                            anyhow::Error,
                                                                        >,
                                                                    >,
                                                                >,
                                                            > = Spiral_wasm::method24(
                                                                v167.clone(),
                                                                6_u8,
                                                            );
                                                            let v1683: Result<
                                                                Spiral_wasm::US4,
                                                                anyhow::Error,
                                                            > = v1681.await;
                                                            let v1684 = Spiral_wasm::method42();
                                                            let v1695: Result<
                                                                Spiral_wasm::US4,
                                                                std::string::String,
                                                            > = v1683.map_err(|x| v1684(x));
                                                            let v1698: Spiral_wasm::US6 =
                                                                match &v1695 {
                                                                    Err(v1695_1_0) => {
                                                                        v187(v1695_1_0.clone())
                                                                    }
                                                                    Ok(v1695_0_0) => {
                                                                        v186(v1695_0_0.clone())
                                                                    }
                                                                };
                                                            match &v1698 {
                                                                Spiral_wasm::US6::US6_0(
                                                                    v1698_0_0,
                                                                ) => {
                                                                    let v1699: Spiral_wasm::US4 =
                                                                        v1698_0_0.clone();
                                                                    match &v1699 {
                                                                        Spiral_wasm::US4::US4_0(
                                                                            v1699_0_0,
                                                                        ) => {
                                                                            let v1727: () = {
                                                                                Spiral_wasm::closure81(match &v1699
                                                                                                           {
                                                                                                           Spiral_wasm::US4::US4_0(x)
                                                                                                           =>
                                                                                                           x.clone(),
                                                                                                           _
                                                                                                           =>
                                                                                                           unreachable!(),
                                                                                                       },
                                                                                                       ());
                                                                                ()
                                                                            };
                                                                            let v1841: bool = true;
                                                                            let __future_init =
                                                                                Box::pin(
                                                                                    async move {
                                                                                        //;
                                                                                        let v1843:
                                                                                bool =
                                                                            true;
                                                                                        let __future_init =
                                                                                            Box::pin(
                                                                                                async move {
                                                                                                    //;
                                                                                                    let v1844:
                                                                                u8 =
                                                                            Spiral_wasm::method75();
                                                                                                    let v1848:
                                                                                string =
                                                                            string("true; v1844 });  // rust.fix_closure\'");
                                                                                                    let v1849:
                                                                                bool =
                                                                            true;
                                                                                                    v1844
                                                                                                },
                                                                                            ); // rust.fix_closure';
                                                                                        let v1851 =
                                                                            __future_init;
                                                                                        let v1853:
                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                            v1851;
                                                                                        let v1856:
                                                                                Spiral_wasm::US7 =
                                                                            Spiral_wasm::method47(v1853.await);
                                                                                        let v1858:
                                                                                string =
                                                                            string("true; v1856 });  // rust.fix_closure\'");
                                                                                        let v1859:
                                                                                bool =
                                                                            true;
                                                                                        v1856
                                                                                    },
                                                                                ); // rust.fix_closure';
                                                                            let v1861 =
                                                                                __future_init;
                                                                            v1861
                                                                        }
                                                                        _ => {
                                                                            let v1701: bool = true;
                                                                            let __future_init =
                                                                                Box::pin(
                                                                                    async move {
                                                                                        //;
                                                                                        let v1703:
                                                                                bool =
                                                                            true;
                                                                                        let __future_init =
                                                                                            Box::pin(
                                                                                                async move {
                                                                                                    //;
                                                                                                    let v1704:
                                                                                u8 =
                                                                            Spiral_wasm::method75();
                                                                                                    let v1708:
                                                                                string =
                                                                            string("true; v1704 });  // rust.fix_closure\'");
                                                                                                    let v1709:
                                                                                bool =
                                                                            true;
                                                                                                    v1704
                                                                                                },
                                                                                            ); // rust.fix_closure';
                                                                                        let v1711 =
                                                                            __future_init;
                                                                                        let v1713:
                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                            v1711;
                                                                                        let v1716:
                                                                                Spiral_wasm::US7 =
                                                                            Spiral_wasm::method49(v1713.await);
                                                                                        let v1718:
                                                                                string =
                                                                            string("true; v1716 });  // rust.fix_closure\'");
                                                                                        let v1719:
                                                                                bool =
                                                                            true;
                                                                                        v1716
                                                                                    },
                                                                                ); // rust.fix_closure';
                                                                            let v1721 =
                                                                                __future_init;
                                                                            v1721
                                                                        }
                                                                    }
                                                                }
                                                                Spiral_wasm::US6::US6_1(
                                                                    v1698_1_0,
                                                                ) => {
                                                                    let v1869: () = {
                                                                        Spiral_wasm::closure34(
                                                                            v1698_1_0.clone(),
                                                                            (),
                                                                        );
                                                                        ()
                                                                    };
                                                                    let v1983:
                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                  anyhow::Error>>>> =
                                                                    Spiral_wasm::method24(v167.clone(),
                                                                                          7_u8);
                                                                    let v1985: Result<
                                                                        Spiral_wasm::US4,
                                                                        anyhow::Error,
                                                                    > = v1983.await;
                                                                    let v1986 =
                                                                        Spiral_wasm::method42();
                                                                    let v1997: Result<
                                                                        Spiral_wasm::US4,
                                                                        std::string::String,
                                                                    > = v1985.map_err(|x| v1986(x));
                                                                    let v2000: Spiral_wasm::US6 =
                                                                        match &v1997 {
                                                                            Err(v1997_1_0) => v187(
                                                                                v1997_1_0.clone(),
                                                                            ),
                                                                            Ok(v1997_0_0) => v186(
                                                                                v1997_0_0.clone(),
                                                                            ),
                                                                        };
                                                                    match &v2000 {
                                                                        Spiral_wasm::US6::US6_0(
                                                                            v2000_0_0,
                                                                        ) => {
                                                                            let v2001:
                                                                                Spiral_wasm::US4 =
                                                                            v2000_0_0.clone();
                                                                            match &v2001
                                                                            {
                                                                            Spiral_wasm::US4::US4_0(v2001_0_0)
                                                                            =>
                                                                            {
                                                                                let v2029:
                                                                                        () =
                                                                                    {
                                                                                        Spiral_wasm::closure80(match &v2001
                                                                                                                   {
                                                                                                                   Spiral_wasm::US4::US4_0(x)
                                                                                                                   =>
                                                                                                                   x.clone(),
                                                                                                                   _
                                                                                                                   =>
                                                                                                                   unreachable!(),
                                                                                                               },
                                                                                                               ());
                                                                                        ()
                                                                                    };
                                                                                let v2143:
                                                                                        bool =
                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                let v2145:
                                                                                        bool =
                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                let v2146:
                                                                                        u8 =
                                                                                    Spiral_wasm::method74();
                                                                                let v2150:
                                                                                        string =
                                                                                    string("true; v2146 });  // rust.fix_closure\'");
                                                                                let v2151:
                                                                                        bool =
                                                                                    true; v2146 });  // rust.fix_closure';
                                                                                let v2153 =
                                                                                    __future_init;
                                                                                let v2155:
                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                    v2153;
                                                                                let v2158:
                                                                                        Spiral_wasm::US7 =
                                                                                    Spiral_wasm::method47(v2155.await);
                                                                                let v2160:
                                                                                        string =
                                                                                    string("true; v2158 });  // rust.fix_closure\'");
                                                                                let v2161:
                                                                                        bool =
                                                                                    true; v2158 });  // rust.fix_closure';
                                                                                let v2163 =
                                                                                    __future_init;
                                                                                v2163
                                                                            }
                                                                            _
                                                                            =>
                                                                            {
                                                                                let v2003:
                                                                                        bool =
                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                let v2005:
                                                                                        bool =
                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                let v2006:
                                                                                        u8 =
                                                                                    Spiral_wasm::method74();
                                                                                let v2010:
                                                                                        string =
                                                                                    string("true; v2006 });  // rust.fix_closure\'");
                                                                                let v2011:
                                                                                        bool =
                                                                                    true; v2006 });  // rust.fix_closure';
                                                                                let v2013 =
                                                                                    __future_init;
                                                                                let v2015:
                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                    v2013;
                                                                                let v2018:
                                                                                        Spiral_wasm::US7 =
                                                                                    Spiral_wasm::method49(v2015.await);
                                                                                let v2020:
                                                                                        string =
                                                                                    string("true; v2018 });  // rust.fix_closure\'");
                                                                                let v2021:
                                                                                        bool =
                                                                                    true; v2018 });  // rust.fix_closure';
                                                                                let v2023 =
                                                                                    __future_init;
                                                                                v2023
                                                                            }
                                                                        }
                                                                        }
                                                                        Spiral_wasm::US6::US6_1(
                                                                            v2000_1_0,
                                                                        ) => {
                                                                            let v2171: () = {
                                                                                Spiral_wasm::closure35(v2000_1_0.clone(),
                                                                                                       ());
                                                                                ()
                                                                            };
                                                                            let v2285:
                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                          anyhow::Error>>>> =
                                                                            Spiral_wasm::method24(v167.clone(),
                                                                                                  8_u8);
                                                                            let v2287: Result<
                                                                                Spiral_wasm::US4,
                                                                                anyhow::Error,
                                                                            > = v2285.await;
                                                                            let v2288 =
                                                                            Spiral_wasm::method42();
                                                                            let v2299: Result<
                                                                                Spiral_wasm::US4,
                                                                                std::string::String,
                                                                            > = v2287.map_err(
                                                                                |x| v2288(x),
                                                                            );
                                                                            let v2302:
                                                                                Spiral_wasm::US6 =
                                                                            match &v2299
                                                                                {
                                                                                Err(v2299_1_0)
                                                                                =>
                                                                                v187(v2299_1_0.clone()),
                                                                                Ok(v2299_0_0)
                                                                                =>
                                                                                v186(v2299_0_0.clone()),
                                                                            };
                                                                            match &v2302
                                                                            {
                                                                            Spiral_wasm::US6::US6_0(v2302_0_0)
                                                                            =>
                                                                            {
                                                                                let v2303:
                                                                                        Spiral_wasm::US4 =
                                                                                    v2302_0_0.clone();
                                                                                match &v2303
                                                                                    {
                                                                                    Spiral_wasm::US4::US4_0(v2303_0_0)
                                                                                    =>
                                                                                    {
                                                                                        let v2331:
                                                                                                () =
                                                                                            {
                                                                                                Spiral_wasm::closure79(match &v2303
                                                                                                                           {
                                                                                                                           Spiral_wasm::US4::US4_0(x)
                                                                                                                           =>
                                                                                                                           x.clone(),
                                                                                                                           _
                                                                                                                           =>
                                                                                                                           unreachable!(),
                                                                                                                       },
                                                                                                                       ());
                                                                                                ()
                                                                                            };
                                                                                        let v2445:
                                                                                                bool =
                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                        let v2447:
                                                                                                bool =
                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                        let v2448:
                                                                                                u8 =
                                                                                            Spiral_wasm::method73();
                                                                                        let v2452:
                                                                                                string =
                                                                                            string("true; v2448 });  // rust.fix_closure\'");
                                                                                        let v2453:
                                                                                                bool =
                                                                                            true; v2448 });  // rust.fix_closure';
                                                                                        let v2455 =
                                                                                            __future_init;
                                                                                        let v2457:
                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                            v2455;
                                                                                        let v2460:
                                                                                                Spiral_wasm::US7 =
                                                                                            Spiral_wasm::method47(v2457.await);
                                                                                        let v2462:
                                                                                                string =
                                                                                            string("true; v2460 });  // rust.fix_closure\'");
                                                                                        let v2463:
                                                                                                bool =
                                                                                            true; v2460 });  // rust.fix_closure';
                                                                                        let v2465 =
                                                                                            __future_init;
                                                                                        v2465
                                                                                    }
                                                                                    _
                                                                                    =>
                                                                                    {
                                                                                        let v2305:
                                                                                                bool =
                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                        let v2307:
                                                                                                bool =
                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                        let v2308:
                                                                                                u8 =
                                                                                            Spiral_wasm::method73();
                                                                                        let v2312:
                                                                                                string =
                                                                                            string("true; v2308 });  // rust.fix_closure\'");
                                                                                        let v2313:
                                                                                                bool =
                                                                                            true; v2308 });  // rust.fix_closure';
                                                                                        let v2315 =
                                                                                            __future_init;
                                                                                        let v2317:
                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                            v2315;
                                                                                        let v2320:
                                                                                                Spiral_wasm::US7 =
                                                                                            Spiral_wasm::method49(v2317.await);
                                                                                        let v2322:
                                                                                                string =
                                                                                            string("true; v2320 });  // rust.fix_closure\'");
                                                                                        let v2323:
                                                                                                bool =
                                                                                            true; v2320 });  // rust.fix_closure';
                                                                                        let v2325 =
                                                                                            __future_init;
                                                                                        v2325
                                                                                    }
                                                                                }
                                                                            }
                                                                            Spiral_wasm::US6::US6_1(v2302_1_0)
                                                                            =>
                                                                            {
                                                                                let v2473:
                                                                                        () =
                                                                                    {
                                                                                        Spiral_wasm::closure36(v2302_1_0.clone(),
                                                                                                               ());
                                                                                        ()
                                                                                    };
                                                                                let v2587:
                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                  anyhow::Error>>>> =
                                                                                    Spiral_wasm::method24(v167.clone(),
                                                                                                          9_u8);
                                                                                let v2589:
                                                                                        Result<Spiral_wasm::US4,
                                                                                               anyhow::Error> =
                                                                                    v2587.await;
                                                                                let v2590 =
                                                                                    Spiral_wasm::method42();
                                                                                let v2601:
                                                                                        Result<Spiral_wasm::US4,
                                                                                               std::string::String> =
                                                                                    v2589.map_err(|x| v2590(x));
                                                                                let v2604:
                                                                                        Spiral_wasm::US6 =
                                                                                    match &v2601
                                                                                        {
                                                                                        Err(v2601_1_0)
                                                                                        =>
                                                                                        v187(v2601_1_0.clone()),
                                                                                        Ok(v2601_0_0)
                                                                                        =>
                                                                                        v186(v2601_0_0.clone()),
                                                                                    };
                                                                                match &v2604
                                                                                    {
                                                                                    Spiral_wasm::US6::US6_0(v2604_0_0)
                                                                                    =>
                                                                                    {
                                                                                        let v2605:
                                                                                                Spiral_wasm::US4 =
                                                                                            v2604_0_0.clone();
                                                                                        match &v2605
                                                                                            {
                                                                                            Spiral_wasm::US4::US4_0(v2605_0_0)
                                                                                            =>
                                                                                            {
                                                                                                let v2633:
                                                                                                        () =
                                                                                                    {
                                                                                                        Spiral_wasm::closure78(match &v2605
                                                                                                                                   {
                                                                                                                                   Spiral_wasm::US4::US4_0(x)
                                                                                                                                   =>
                                                                                                                                   x.clone(),
                                                                                                                                   _
                                                                                                                                   =>
                                                                                                                                   unreachable!(),
                                                                                                                               },
                                                                                                                               ());
                                                                                                        ()
                                                                                                    };
                                                                                                let v2747:
                                                                                                        bool =
                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                let v2749:
                                                                                                        bool =
                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                let v2750:
                                                                                                        u8 =
                                                                                                    Spiral_wasm::method72();
                                                                                                let v2754:
                                                                                                        string =
                                                                                                    string("true; v2750 });  // rust.fix_closure\'");
                                                                                                let v2755:
                                                                                                        bool =
                                                                                                    true; v2750 });  // rust.fix_closure';
                                                                                                let v2757 =
                                                                                                    __future_init;
                                                                                                let v2759:
                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                    v2757;
                                                                                                let v2762:
                                                                                                        Spiral_wasm::US7 =
                                                                                                    Spiral_wasm::method47(v2759.await);
                                                                                                let v2764:
                                                                                                        string =
                                                                                                    string("true; v2762 });  // rust.fix_closure\'");
                                                                                                let v2765:
                                                                                                        bool =
                                                                                                    true; v2762 });  // rust.fix_closure';
                                                                                                let v2767 =
                                                                                                    __future_init;
                                                                                                v2767
                                                                                            }
                                                                                            _
                                                                                            =>
                                                                                            {
                                                                                                let v2607:
                                                                                                        bool =
                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                let v2609:
                                                                                                        bool =
                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                let v2610:
                                                                                                        u8 =
                                                                                                    Spiral_wasm::method72();
                                                                                                let v2614:
                                                                                                        string =
                                                                                                    string("true; v2610 });  // rust.fix_closure\'");
                                                                                                let v2615:
                                                                                                        bool =
                                                                                                    true; v2610 });  // rust.fix_closure';
                                                                                                let v2617 =
                                                                                                    __future_init;
                                                                                                let v2619:
                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                    v2617;
                                                                                                let v2622:
                                                                                                        Spiral_wasm::US7 =
                                                                                                    Spiral_wasm::method49(v2619.await);
                                                                                                let v2624:
                                                                                                        string =
                                                                                                    string("true; v2622 });  // rust.fix_closure\'");
                                                                                                let v2625:
                                                                                                        bool =
                                                                                                    true; v2622 });  // rust.fix_closure';
                                                                                                let v2627 =
                                                                                                    __future_init;
                                                                                                v2627
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                    Spiral_wasm::US6::US6_1(v2604_1_0)
                                                                                    =>
                                                                                    {
                                                                                        let v2775:
                                                                                                () =
                                                                                            {
                                                                                                Spiral_wasm::closure37(v2604_1_0.clone(),
                                                                                                                       ());
                                                                                                ()
                                                                                            };
                                                                                        let v2889:
                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                          anyhow::Error>>>> =
                                                                                            Spiral_wasm::method24(v167.clone(),
                                                                                                                  10_u8);
                                                                                        let v2891:
                                                                                                Result<Spiral_wasm::US4,
                                                                                                       anyhow::Error> =
                                                                                            v2889.await;
                                                                                        let v2892 =
                                                                                            Spiral_wasm::method42();
                                                                                        let v2903:
                                                                                                Result<Spiral_wasm::US4,
                                                                                                       std::string::String> =
                                                                                            v2891.map_err(|x| v2892(x));
                                                                                        let v2906:
                                                                                                Spiral_wasm::US6 =
                                                                                            match &v2903
                                                                                                {
                                                                                                Err(v2903_1_0)
                                                                                                =>
                                                                                                v187(v2903_1_0.clone()),
                                                                                                Ok(v2903_0_0)
                                                                                                =>
                                                                                                v186(v2903_0_0.clone()),
                                                                                            };
                                                                                        match &v2906
                                                                                            {
                                                                                            Spiral_wasm::US6::US6_0(v2906_0_0)
                                                                                            =>
                                                                                            {
                                                                                                let v2907:
                                                                                                        Spiral_wasm::US4 =
                                                                                                    v2906_0_0.clone();
                                                                                                match &v2907
                                                                                                    {
                                                                                                    Spiral_wasm::US4::US4_0(v2907_0_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v2935:
                                                                                                                () =
                                                                                                            {
                                                                                                                Spiral_wasm::closure77(match &v2907
                                                                                                                                           {
                                                                                                                                           Spiral_wasm::US4::US4_0(x)
                                                                                                                                           =>
                                                                                                                                           x.clone(),
                                                                                                                                           _
                                                                                                                                           =>
                                                                                                                                           unreachable!(),
                                                                                                                                       },
                                                                                                                                       ());
                                                                                                                ()
                                                                                                            };
                                                                                                        let v3049:
                                                                                                                bool =
                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                        let v3051:
                                                                                                                bool =
                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                        let v3052:
                                                                                                                u8 =
                                                                                                            Spiral_wasm::method71();
                                                                                                        let v3056:
                                                                                                                string =
                                                                                                            string("true; v3052 });  // rust.fix_closure\'");
                                                                                                        let v3057:
                                                                                                                bool =
                                                                                                            true; v3052 });  // rust.fix_closure';
                                                                                                        let v3059 =
                                                                                                            __future_init;
                                                                                                        let v3061:
                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                            v3059;
                                                                                                        let v3064:
                                                                                                                Spiral_wasm::US7 =
                                                                                                            Spiral_wasm::method47(v3061.await);
                                                                                                        let v3066:
                                                                                                                string =
                                                                                                            string("true; v3064 });  // rust.fix_closure\'");
                                                                                                        let v3067:
                                                                                                                bool =
                                                                                                            true; v3064 });  // rust.fix_closure';
                                                                                                        let v3069 =
                                                                                                            __future_init;
                                                                                                        v3069
                                                                                                    }
                                                                                                    _
                                                                                                    =>
                                                                                                    {
                                                                                                        let v2909:
                                                                                                                bool =
                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                        let v2911:
                                                                                                                bool =
                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                        let v2912:
                                                                                                                u8 =
                                                                                                            Spiral_wasm::method71();
                                                                                                        let v2916:
                                                                                                                string =
                                                                                                            string("true; v2912 });  // rust.fix_closure\'");
                                                                                                        let v2917:
                                                                                                                bool =
                                                                                                            true; v2912 });  // rust.fix_closure';
                                                                                                        let v2919 =
                                                                                                            __future_init;
                                                                                                        let v2921:
                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                            v2919;
                                                                                                        let v2924:
                                                                                                                Spiral_wasm::US7 =
                                                                                                            Spiral_wasm::method49(v2921.await);
                                                                                                        let v2926:
                                                                                                                string =
                                                                                                            string("true; v2924 });  // rust.fix_closure\'");
                                                                                                        let v2927:
                                                                                                                bool =
                                                                                                            true; v2924 });  // rust.fix_closure';
                                                                                                        let v2929 =
                                                                                                            __future_init;
                                                                                                        v2929
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                            Spiral_wasm::US6::US6_1(v2906_1_0)
                                                                                            =>
                                                                                            {
                                                                                                let v3077:
                                                                                                        () =
                                                                                                    {
                                                                                                        Spiral_wasm::closure38(v2906_1_0.clone(),
                                                                                                                               ());
                                                                                                        ()
                                                                                                    };
                                                                                                let v3191:
                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                  anyhow::Error>>>> =
                                                                                                    Spiral_wasm::method24(v167.clone(),
                                                                                                                          11_u8);
                                                                                                let v3193:
                                                                                                        Result<Spiral_wasm::US4,
                                                                                                               anyhow::Error> =
                                                                                                    v3191.await;
                                                                                                let v3194 =
                                                                                                    Spiral_wasm::method42();
                                                                                                let v3205:
                                                                                                        Result<Spiral_wasm::US4,
                                                                                                               std::string::String> =
                                                                                                    v3193.map_err(|x| v3194(x));
                                                                                                let v3208:
                                                                                                        Spiral_wasm::US6 =
                                                                                                    match &v3205
                                                                                                        {
                                                                                                        Err(v3205_1_0)
                                                                                                        =>
                                                                                                        v187(v3205_1_0.clone()),
                                                                                                        Ok(v3205_0_0)
                                                                                                        =>
                                                                                                        v186(v3205_0_0.clone()),
                                                                                                    };
                                                                                                match &v3208
                                                                                                    {
                                                                                                    Spiral_wasm::US6::US6_0(v3208_0_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v3209:
                                                                                                                Spiral_wasm::US4 =
                                                                                                            v3208_0_0.clone();
                                                                                                        match &v3209
                                                                                                            {
                                                                                                            Spiral_wasm::US4::US4_0(v3209_0_0)
                                                                                                            =>
                                                                                                            {
                                                                                                                let v3237:
                                                                                                                        () =
                                                                                                                    {
                                                                                                                        Spiral_wasm::closure76(match &v3209
                                                                                                                                                   {
                                                                                                                                                   Spiral_wasm::US4::US4_0(x)
                                                                                                                                                   =>
                                                                                                                                                   x.clone(),
                                                                                                                                                   _
                                                                                                                                                   =>
                                                                                                                                                   unreachable!(),
                                                                                                                                               },
                                                                                                                                               ());
                                                                                                                        ()
                                                                                                                    };
                                                                                                                let v3351:
                                                                                                                        bool =
                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                let v3353:
                                                                                                                        bool =
                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                let v3354:
                                                                                                                        u8 =
                                                                                                                    Spiral_wasm::method70();
                                                                                                                let v3358:
                                                                                                                        string =
                                                                                                                    string("true; v3354 });  // rust.fix_closure\'");
                                                                                                                let v3359:
                                                                                                                        bool =
                                                                                                                    true; v3354 });  // rust.fix_closure';
                                                                                                                let v3361 =
                                                                                                                    __future_init;
                                                                                                                let v3363:
                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                    v3361;
                                                                                                                let v3366:
                                                                                                                        Spiral_wasm::US7 =
                                                                                                                    Spiral_wasm::method47(v3363.await);
                                                                                                                let v3368:
                                                                                                                        string =
                                                                                                                    string("true; v3366 });  // rust.fix_closure\'");
                                                                                                                let v3369:
                                                                                                                        bool =
                                                                                                                    true; v3366 });  // rust.fix_closure';
                                                                                                                let v3371 =
                                                                                                                    __future_init;
                                                                                                                v3371
                                                                                                            }
                                                                                                            _
                                                                                                            =>
                                                                                                            {
                                                                                                                let v3211:
                                                                                                                        bool =
                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                let v3213:
                                                                                                                        bool =
                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                let v3214:
                                                                                                                        u8 =
                                                                                                                    Spiral_wasm::method70();
                                                                                                                let v3218:
                                                                                                                        string =
                                                                                                                    string("true; v3214 });  // rust.fix_closure\'");
                                                                                                                let v3219:
                                                                                                                        bool =
                                                                                                                    true; v3214 });  // rust.fix_closure';
                                                                                                                let v3221 =
                                                                                                                    __future_init;
                                                                                                                let v3223:
                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                    v3221;
                                                                                                                let v3226:
                                                                                                                        Spiral_wasm::US7 =
                                                                                                                    Spiral_wasm::method49(v3223.await);
                                                                                                                let v3228:
                                                                                                                        string =
                                                                                                                    string("true; v3226 });  // rust.fix_closure\'");
                                                                                                                let v3229:
                                                                                                                        bool =
                                                                                                                    true; v3226 });  // rust.fix_closure';
                                                                                                                let v3231 =
                                                                                                                    __future_init;
                                                                                                                v3231
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                    Spiral_wasm::US6::US6_1(v3208_1_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v3379:
                                                                                                                () =
                                                                                                            {
                                                                                                                Spiral_wasm::closure39(v3208_1_0.clone(),
                                                                                                                                       ());
                                                                                                                ()
                                                                                                            };
                                                                                                        let v3493:
                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                          anyhow::Error>>>> =
                                                                                                            Spiral_wasm::method24(v167.clone(),
                                                                                                                                  12_u8);
                                                                                                        let v3495:
                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                       anyhow::Error> =
                                                                                                            v3493.await;
                                                                                                        let v3496 =
                                                                                                            Spiral_wasm::method42();
                                                                                                        let v3507:
                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                       std::string::String> =
                                                                                                            v3495.map_err(|x| v3496(x));
                                                                                                        let v3510:
                                                                                                                Spiral_wasm::US6 =
                                                                                                            match &v3507
                                                                                                                {
                                                                                                                Err(v3507_1_0)
                                                                                                                =>
                                                                                                                v187(v3507_1_0.clone()),
                                                                                                                Ok(v3507_0_0)
                                                                                                                =>
                                                                                                                v186(v3507_0_0.clone()),
                                                                                                            };
                                                                                                        match &v3510
                                                                                                            {
                                                                                                            Spiral_wasm::US6::US6_0(v3510_0_0)
                                                                                                            =>
                                                                                                            {
                                                                                                                let v3511:
                                                                                                                        Spiral_wasm::US4 =
                                                                                                                    v3510_0_0.clone();
                                                                                                                match &v3511
                                                                                                                    {
                                                                                                                    Spiral_wasm::US4::US4_0(v3511_0_0)
                                                                                                                    =>
                                                                                                                    {
                                                                                                                        let v3539:
                                                                                                                                () =
                                                                                                                            {
                                                                                                                                Spiral_wasm::closure75(match &v3511
                                                                                                                                                           {
                                                                                                                                                           Spiral_wasm::US4::US4_0(x)
                                                                                                                                                           =>
                                                                                                                                                           x.clone(),
                                                                                                                                                           _
                                                                                                                                                           =>
                                                                                                                                                           unreachable!(),
                                                                                                                                                       },
                                                                                                                                                       ());
                                                                                                                                ()
                                                                                                                            };
                                                                                                                        let v3653:
                                                                                                                                bool =
                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                        let v3655:
                                                                                                                                bool =
                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                        let v3656:
                                                                                                                                u8 =
                                                                                                                            Spiral_wasm::method69();
                                                                                                                        let v3660:
                                                                                                                                string =
                                                                                                                            string("true; v3656 });  // rust.fix_closure\'");
                                                                                                                        let v3661:
                                                                                                                                bool =
                                                                                                                            true; v3656 });  // rust.fix_closure';
                                                                                                                        let v3663 =
                                                                                                                            __future_init;
                                                                                                                        let v3665:
                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                            v3663;
                                                                                                                        let v3668:
                                                                                                                                Spiral_wasm::US7 =
                                                                                                                            Spiral_wasm::method47(v3665.await);
                                                                                                                        let v3670:
                                                                                                                                string =
                                                                                                                            string("true; v3668 });  // rust.fix_closure\'");
                                                                                                                        let v3671:
                                                                                                                                bool =
                                                                                                                            true; v3668 });  // rust.fix_closure';
                                                                                                                        let v3673 =
                                                                                                                            __future_init;
                                                                                                                        v3673
                                                                                                                    }
                                                                                                                    _
                                                                                                                    =>
                                                                                                                    {
                                                                                                                        let v3513:
                                                                                                                                bool =
                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                        let v3515:
                                                                                                                                bool =
                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                        let v3516:
                                                                                                                                u8 =
                                                                                                                            Spiral_wasm::method69();
                                                                                                                        let v3520:
                                                                                                                                string =
                                                                                                                            string("true; v3516 });  // rust.fix_closure\'");
                                                                                                                        let v3521:
                                                                                                                                bool =
                                                                                                                            true; v3516 });  // rust.fix_closure';
                                                                                                                        let v3523 =
                                                                                                                            __future_init;
                                                                                                                        let v3525:
                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                            v3523;
                                                                                                                        let v3528:
                                                                                                                                Spiral_wasm::US7 =
                                                                                                                            Spiral_wasm::method49(v3525.await);
                                                                                                                        let v3530:
                                                                                                                                string =
                                                                                                                            string("true; v3528 });  // rust.fix_closure\'");
                                                                                                                        let v3531:
                                                                                                                                bool =
                                                                                                                            true; v3528 });  // rust.fix_closure';
                                                                                                                        let v3533 =
                                                                                                                            __future_init;
                                                                                                                        v3533
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                            Spiral_wasm::US6::US6_1(v3510_1_0)
                                                                                                            =>
                                                                                                            {
                                                                                                                let v3681:
                                                                                                                        () =
                                                                                                                    {
                                                                                                                        Spiral_wasm::closure40(v3510_1_0.clone(),
                                                                                                                                               ());
                                                                                                                        ()
                                                                                                                    };
                                                                                                                let v3795:
                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                  anyhow::Error>>>> =
                                                                                                                    Spiral_wasm::method24(v167.clone(),
                                                                                                                                          13_u8);
                                                                                                                let v3797:
                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                               anyhow::Error> =
                                                                                                                    v3795.await;
                                                                                                                let v3798 =
                                                                                                                    Spiral_wasm::method42();
                                                                                                                let v3809:
                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                               std::string::String> =
                                                                                                                    v3797.map_err(|x| v3798(x));
                                                                                                                let v3812:
                                                                                                                        Spiral_wasm::US6 =
                                                                                                                    match &v3809
                                                                                                                        {
                                                                                                                        Err(v3809_1_0)
                                                                                                                        =>
                                                                                                                        v187(v3809_1_0.clone()),
                                                                                                                        Ok(v3809_0_0)
                                                                                                                        =>
                                                                                                                        v186(v3809_0_0.clone()),
                                                                                                                    };
                                                                                                                match &v3812
                                                                                                                    {
                                                                                                                    Spiral_wasm::US6::US6_0(v3812_0_0)
                                                                                                                    =>
                                                                                                                    {
                                                                                                                        let v3813:
                                                                                                                                Spiral_wasm::US4 =
                                                                                                                            v3812_0_0.clone();
                                                                                                                        match &v3813
                                                                                                                            {
                                                                                                                            Spiral_wasm::US4::US4_0(v3813_0_0)
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let v3841:
                                                                                                                                        () =
                                                                                                                                    {
                                                                                                                                        Spiral_wasm::closure74(match &v3813
                                                                                                                                                                   {
                                                                                                                                                                   Spiral_wasm::US4::US4_0(x)
                                                                                                                                                                   =>
                                                                                                                                                                   x.clone(),
                                                                                                                                                                   _
                                                                                                                                                                   =>
                                                                                                                                                                   unreachable!(),
                                                                                                                                                               },
                                                                                                                                                               ());
                                                                                                                                        ()
                                                                                                                                    };
                                                                                                                                let v3955:
                                                                                                                                        bool =
                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                let v3957:
                                                                                                                                        bool =
                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                let v3958:
                                                                                                                                        u8 =
                                                                                                                                    Spiral_wasm::method68();
                                                                                                                                let v3962:
                                                                                                                                        string =
                                                                                                                                    string("true; v3958 });  // rust.fix_closure\'");
                                                                                                                                let v3963:
                                                                                                                                        bool =
                                                                                                                                    true; v3958 });  // rust.fix_closure';
                                                                                                                                let v3965 =
                                                                                                                                    __future_init;
                                                                                                                                let v3967:
                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                    v3965;
                                                                                                                                let v3970:
                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                    Spiral_wasm::method47(v3967.await);
                                                                                                                                let v3972:
                                                                                                                                        string =
                                                                                                                                    string("true; v3970 });  // rust.fix_closure\'");
                                                                                                                                let v3973:
                                                                                                                                        bool =
                                                                                                                                    true; v3970 });  // rust.fix_closure';
                                                                                                                                let v3975 =
                                                                                                                                    __future_init;
                                                                                                                                v3975
                                                                                                                            }
                                                                                                                            _
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let v3815:
                                                                                                                                        bool =
                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                let v3817:
                                                                                                                                        bool =
                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                let v3818:
                                                                                                                                        u8 =
                                                                                                                                    Spiral_wasm::method68();
                                                                                                                                let v3822:
                                                                                                                                        string =
                                                                                                                                    string("true; v3818 });  // rust.fix_closure\'");
                                                                                                                                let v3823:
                                                                                                                                        bool =
                                                                                                                                    true; v3818 });  // rust.fix_closure';
                                                                                                                                let v3825 =
                                                                                                                                    __future_init;
                                                                                                                                let v3827:
                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                    v3825;
                                                                                                                                let v3830:
                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                    Spiral_wasm::method49(v3827.await);
                                                                                                                                let v3832:
                                                                                                                                        string =
                                                                                                                                    string("true; v3830 });  // rust.fix_closure\'");
                                                                                                                                let v3833:
                                                                                                                                        bool =
                                                                                                                                    true; v3830 });  // rust.fix_closure';
                                                                                                                                let v3835 =
                                                                                                                                    __future_init;
                                                                                                                                v3835
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                    Spiral_wasm::US6::US6_1(v3812_1_0)
                                                                                                                    =>
                                                                                                                    {
                                                                                                                        let v3983:
                                                                                                                                () =
                                                                                                                            {
                                                                                                                                Spiral_wasm::closure41(v3812_1_0.clone(),
                                                                                                                                                       ());
                                                                                                                                ()
                                                                                                                            };
                                                                                                                        let v4097:
                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                          anyhow::Error>>>> =
                                                                                                                            Spiral_wasm::method24(v167.clone(),
                                                                                                                                                  14_u8);
                                                                                                                        let v4099:
                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                       anyhow::Error> =
                                                                                                                            v4097.await;
                                                                                                                        let v4100 =
                                                                                                                            Spiral_wasm::method42();
                                                                                                                        let v4111:
                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                       std::string::String> =
                                                                                                                            v4099.map_err(|x| v4100(x));
                                                                                                                        let v4114:
                                                                                                                                Spiral_wasm::US6 =
                                                                                                                            match &v4111
                                                                                                                                {
                                                                                                                                Err(v4111_1_0)
                                                                                                                                =>
                                                                                                                                v187(v4111_1_0.clone()),
                                                                                                                                Ok(v4111_0_0)
                                                                                                                                =>
                                                                                                                                v186(v4111_0_0.clone()),
                                                                                                                            };
                                                                                                                        match &v4114
                                                                                                                            {
                                                                                                                            Spiral_wasm::US6::US6_0(v4114_0_0)
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let v4115:
                                                                                                                                        Spiral_wasm::US4 =
                                                                                                                                    v4114_0_0.clone();
                                                                                                                                match &v4115
                                                                                                                                    {
                                                                                                                                    Spiral_wasm::US4::US4_0(v4115_0_0)
                                                                                                                                    =>
                                                                                                                                    {
                                                                                                                                        let v4143:
                                                                                                                                                () =
                                                                                                                                            {
                                                                                                                                                Spiral_wasm::closure73(match &v4115
                                                                                                                                                                           {
                                                                                                                                                                           Spiral_wasm::US4::US4_0(x)
                                                                                                                                                                           =>
                                                                                                                                                                           x.clone(),
                                                                                                                                                                           _
                                                                                                                                                                           =>
                                                                                                                                                                           unreachable!(),
                                                                                                                                                                       },
                                                                                                                                                                       ());
                                                                                                                                                ()
                                                                                                                                            };
                                                                                                                                        let v4257:
                                                                                                                                                bool =
                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                        let v4259:
                                                                                                                                                bool =
                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                        let v4260:
                                                                                                                                                u8 =
                                                                                                                                            Spiral_wasm::method67();
                                                                                                                                        let v4264:
                                                                                                                                                string =
                                                                                                                                            string("true; v4260 });  // rust.fix_closure\'");
                                                                                                                                        let v4265:
                                                                                                                                                bool =
                                                                                                                                            true; v4260 });  // rust.fix_closure';
                                                                                                                                        let v4267 =
                                                                                                                                            __future_init;
                                                                                                                                        let v4269:
                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                            v4267;
                                                                                                                                        let v4272:
                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                            Spiral_wasm::method47(v4269.await);
                                                                                                                                        let v4274:
                                                                                                                                                string =
                                                                                                                                            string("true; v4272 });  // rust.fix_closure\'");
                                                                                                                                        let v4275:
                                                                                                                                                bool =
                                                                                                                                            true; v4272 });  // rust.fix_closure';
                                                                                                                                        let v4277 =
                                                                                                                                            __future_init;
                                                                                                                                        v4277
                                                                                                                                    }
                                                                                                                                    _
                                                                                                                                    =>
                                                                                                                                    {
                                                                                                                                        let v4117:
                                                                                                                                                bool =
                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                        let v4119:
                                                                                                                                                bool =
                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                        let v4120:
                                                                                                                                                u8 =
                                                                                                                                            Spiral_wasm::method67();
                                                                                                                                        let v4124:
                                                                                                                                                string =
                                                                                                                                            string("true; v4120 });  // rust.fix_closure\'");
                                                                                                                                        let v4125:
                                                                                                                                                bool =
                                                                                                                                            true; v4120 });  // rust.fix_closure';
                                                                                                                                        let v4127 =
                                                                                                                                            __future_init;
                                                                                                                                        let v4129:
                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                            v4127;
                                                                                                                                        let v4132:
                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                            Spiral_wasm::method49(v4129.await);
                                                                                                                                        let v4134:
                                                                                                                                                string =
                                                                                                                                            string("true; v4132 });  // rust.fix_closure\'");
                                                                                                                                        let v4135:
                                                                                                                                                bool =
                                                                                                                                            true; v4132 });  // rust.fix_closure';
                                                                                                                                        let v4137 =
                                                                                                                                            __future_init;
                                                                                                                                        v4137
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                            Spiral_wasm::US6::US6_1(v4114_1_0)
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let v4285:
                                                                                                                                        () =
                                                                                                                                    {
                                                                                                                                        Spiral_wasm::closure42(v4114_1_0.clone(),
                                                                                                                                                               ());
                                                                                                                                        ()
                                                                                                                                    };
                                                                                                                                let v4399:
                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                  anyhow::Error>>>> =
                                                                                                                                    Spiral_wasm::method24(v167.clone(),
                                                                                                                                                          15_u8);
                                                                                                                                let v4401:
                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                               anyhow::Error> =
                                                                                                                                    v4399.await;
                                                                                                                                let v4402 =
                                                                                                                                    Spiral_wasm::method42();
                                                                                                                                let v4413:
                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                               std::string::String> =
                                                                                                                                    v4401.map_err(|x| v4402(x));
                                                                                                                                let v4416:
                                                                                                                                        Spiral_wasm::US6 =
                                                                                                                                    match &v4413
                                                                                                                                        {
                                                                                                                                        Err(v4413_1_0)
                                                                                                                                        =>
                                                                                                                                        v187(v4413_1_0.clone()),
                                                                                                                                        Ok(v4413_0_0)
                                                                                                                                        =>
                                                                                                                                        v186(v4413_0_0.clone()),
                                                                                                                                    };
                                                                                                                                match &v4416
                                                                                                                                    {
                                                                                                                                    Spiral_wasm::US6::US6_0(v4416_0_0)
                                                                                                                                    =>
                                                                                                                                    {
                                                                                                                                        let v4417:
                                                                                                                                                Spiral_wasm::US4 =
                                                                                                                                            v4416_0_0.clone();
                                                                                                                                        match &v4417
                                                                                                                                            {
                                                                                                                                            Spiral_wasm::US4::US4_0(v4417_0_0)
                                                                                                                                            =>
                                                                                                                                            {
                                                                                                                                                let v4445:
                                                                                                                                                        () =
                                                                                                                                                    {
                                                                                                                                                        Spiral_wasm::closure72(match &v4417
                                                                                                                                                                                   {
                                                                                                                                                                                   Spiral_wasm::US4::US4_0(x)
                                                                                                                                                                                   =>
                                                                                                                                                                                   x.clone(),
                                                                                                                                                                                   _
                                                                                                                                                                                   =>
                                                                                                                                                                                   unreachable!(),
                                                                                                                                                                               },
                                                                                                                                                                               ());
                                                                                                                                                        ()
                                                                                                                                                    };
                                                                                                                                                let v4559:
                                                                                                                                                        bool =
                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                let v4561:
                                                                                                                                                        bool =
                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                let v4562:
                                                                                                                                                        u8 =
                                                                                                                                                    Spiral_wasm::method66();
                                                                                                                                                let v4566:
                                                                                                                                                        string =
                                                                                                                                                    string("true; v4562 });  // rust.fix_closure\'");
                                                                                                                                                let v4567:
                                                                                                                                                        bool =
                                                                                                                                                    true; v4562 });  // rust.fix_closure';
                                                                                                                                                let v4569 =
                                                                                                                                                    __future_init;
                                                                                                                                                let v4571:
                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                    v4569;
                                                                                                                                                let v4574:
                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                    Spiral_wasm::method47(v4571.await);
                                                                                                                                                let v4576:
                                                                                                                                                        string =
                                                                                                                                                    string("true; v4574 });  // rust.fix_closure\'");
                                                                                                                                                let v4577:
                                                                                                                                                        bool =
                                                                                                                                                    true; v4574 });  // rust.fix_closure';
                                                                                                                                                let v4579 =
                                                                                                                                                    __future_init;
                                                                                                                                                v4579
                                                                                                                                            }
                                                                                                                                            _
                                                                                                                                            =>
                                                                                                                                            {
                                                                                                                                                let v4419:
                                                                                                                                                        bool =
                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                let v4421:
                                                                                                                                                        bool =
                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                let v4422:
                                                                                                                                                        u8 =
                                                                                                                                                    Spiral_wasm::method66();
                                                                                                                                                let v4426:
                                                                                                                                                        string =
                                                                                                                                                    string("true; v4422 });  // rust.fix_closure\'");
                                                                                                                                                let v4427:
                                                                                                                                                        bool =
                                                                                                                                                    true; v4422 });  // rust.fix_closure';
                                                                                                                                                let v4429 =
                                                                                                                                                    __future_init;
                                                                                                                                                let v4431:
                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                    v4429;
                                                                                                                                                let v4434:
                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                    Spiral_wasm::method49(v4431.await);
                                                                                                                                                let v4436:
                                                                                                                                                        string =
                                                                                                                                                    string("true; v4434 });  // rust.fix_closure\'");
                                                                                                                                                let v4437:
                                                                                                                                                        bool =
                                                                                                                                                    true; v4434 });  // rust.fix_closure';
                                                                                                                                                let v4439 =
                                                                                                                                                    __future_init;
                                                                                                                                                v4439
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                    Spiral_wasm::US6::US6_1(v4416_1_0)
                                                                                                                                    =>
                                                                                                                                    {
                                                                                                                                        let v4587:
                                                                                                                                                () =
                                                                                                                                            {
                                                                                                                                                Spiral_wasm::closure43(v4416_1_0.clone(),
                                                                                                                                                                       ());
                                                                                                                                                ()
                                                                                                                                            };
                                                                                                                                        let v4701:
                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                          anyhow::Error>>>> =
                                                                                                                                            Spiral_wasm::method24(v167.clone(),
                                                                                                                                                                  16_u8);
                                                                                                                                        let v4703:
                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                       anyhow::Error> =
                                                                                                                                            v4701.await;
                                                                                                                                        let v4704 =
                                                                                                                                            Spiral_wasm::method42();
                                                                                                                                        let v4715:
                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                       std::string::String> =
                                                                                                                                            v4703.map_err(|x| v4704(x));
                                                                                                                                        let v4718:
                                                                                                                                                Spiral_wasm::US6 =
                                                                                                                                            match &v4715
                                                                                                                                                {
                                                                                                                                                Err(v4715_1_0)
                                                                                                                                                =>
                                                                                                                                                v187(v4715_1_0.clone()),
                                                                                                                                                Ok(v4715_0_0)
                                                                                                                                                =>
                                                                                                                                                v186(v4715_0_0.clone()),
                                                                                                                                            };
                                                                                                                                        match &v4718
                                                                                                                                            {
                                                                                                                                            Spiral_wasm::US6::US6_0(v4718_0_0)
                                                                                                                                            =>
                                                                                                                                            {
                                                                                                                                                let v4719:
                                                                                                                                                        Spiral_wasm::US4 =
                                                                                                                                                    v4718_0_0.clone();
                                                                                                                                                match &v4719
                                                                                                                                                    {
                                                                                                                                                    Spiral_wasm::US4::US4_0(v4719_0_0)
                                                                                                                                                    =>
                                                                                                                                                    {
                                                                                                                                                        let v4747:
                                                                                                                                                                () =
                                                                                                                                                            {
                                                                                                                                                                Spiral_wasm::closure71(match &v4719
                                                                                                                                                                                           {
                                                                                                                                                                                           Spiral_wasm::US4::US4_0(x)
                                                                                                                                                                                           =>
                                                                                                                                                                                           x.clone(),
                                                                                                                                                                                           _
                                                                                                                                                                                           =>
                                                                                                                                                                                           unreachable!(),
                                                                                                                                                                                       },
                                                                                                                                                                                       ());
                                                                                                                                                                ()
                                                                                                                                                            };
                                                                                                                                                        let v4861:
                                                                                                                                                                bool =
                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                        let v4863:
                                                                                                                                                                bool =
                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                        let v4864:
                                                                                                                                                                u8 =
                                                                                                                                                            Spiral_wasm::method65();
                                                                                                                                                        let v4868:
                                                                                                                                                                string =
                                                                                                                                                            string("true; v4864 });  // rust.fix_closure\'");
                                                                                                                                                        let v4869:
                                                                                                                                                                bool =
                                                                                                                                                            true; v4864 });  // rust.fix_closure';
                                                                                                                                                        let v4871 =
                                                                                                                                                            __future_init;
                                                                                                                                                        let v4873:
                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                            v4871;
                                                                                                                                                        let v4876:
                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                            Spiral_wasm::method47(v4873.await);
                                                                                                                                                        let v4878:
                                                                                                                                                                string =
                                                                                                                                                            string("true; v4876 });  // rust.fix_closure\'");
                                                                                                                                                        let v4879:
                                                                                                                                                                bool =
                                                                                                                                                            true; v4876 });  // rust.fix_closure';
                                                                                                                                                        let v4881 =
                                                                                                                                                            __future_init;
                                                                                                                                                        v4881
                                                                                                                                                    }
                                                                                                                                                    _
                                                                                                                                                    =>
                                                                                                                                                    {
                                                                                                                                                        let v4721:
                                                                                                                                                                bool =
                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                        let v4723:
                                                                                                                                                                bool =
                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                        let v4724:
                                                                                                                                                                u8 =
                                                                                                                                                            Spiral_wasm::method65();
                                                                                                                                                        let v4728:
                                                                                                                                                                string =
                                                                                                                                                            string("true; v4724 });  // rust.fix_closure\'");
                                                                                                                                                        let v4729:
                                                                                                                                                                bool =
                                                                                                                                                            true; v4724 });  // rust.fix_closure';
                                                                                                                                                        let v4731 =
                                                                                                                                                            __future_init;
                                                                                                                                                        let v4733:
                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                            v4731;
                                                                                                                                                        let v4736:
                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                            Spiral_wasm::method49(v4733.await);
                                                                                                                                                        let v4738:
                                                                                                                                                                string =
                                                                                                                                                            string("true; v4736 });  // rust.fix_closure\'");
                                                                                                                                                        let v4739:
                                                                                                                                                                bool =
                                                                                                                                                            true; v4736 });  // rust.fix_closure';
                                                                                                                                                        let v4741 =
                                                                                                                                                            __future_init;
                                                                                                                                                        v4741
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                            Spiral_wasm::US6::US6_1(v4718_1_0)
                                                                                                                                            =>
                                                                                                                                            {
                                                                                                                                                let v4889:
                                                                                                                                                        () =
                                                                                                                                                    {
                                                                                                                                                        Spiral_wasm::closure44(v4718_1_0.clone(),
                                                                                                                                                                               ());
                                                                                                                                                        ()
                                                                                                                                                    };
                                                                                                                                                let v5003:
                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                  anyhow::Error>>>> =
                                                                                                                                                    Spiral_wasm::method24(v167.clone(),
                                                                                                                                                                          17_u8);
                                                                                                                                                let v5005:
                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                               anyhow::Error> =
                                                                                                                                                    v5003.await;
                                                                                                                                                let v5006 =
                                                                                                                                                    Spiral_wasm::method42();
                                                                                                                                                let v5017:
                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                               std::string::String> =
                                                                                                                                                    v5005.map_err(|x| v5006(x));
                                                                                                                                                let v5020:
                                                                                                                                                        Spiral_wasm::US6 =
                                                                                                                                                    match &v5017
                                                                                                                                                        {
                                                                                                                                                        Err(v5017_1_0)
                                                                                                                                                        =>
                                                                                                                                                        v187(v5017_1_0.clone()),
                                                                                                                                                        Ok(v5017_0_0)
                                                                                                                                                        =>
                                                                                                                                                        v186(v5017_0_0.clone()),
                                                                                                                                                    };
                                                                                                                                                match &v5020
                                                                                                                                                    {
                                                                                                                                                    Spiral_wasm::US6::US6_0(v5020_0_0)
                                                                                                                                                    =>
                                                                                                                                                    {
                                                                                                                                                        let v5021:
                                                                                                                                                                Spiral_wasm::US4 =
                                                                                                                                                            v5020_0_0.clone();
                                                                                                                                                        match &v5021
                                                                                                                                                            {
                                                                                                                                                            Spiral_wasm::US4::US4_0(v5021_0_0)
                                                                                                                                                            =>
                                                                                                                                                            {
                                                                                                                                                                let v5049:
                                                                                                                                                                        () =
                                                                                                                                                                    {
                                                                                                                                                                        Spiral_wasm::closure70(match &v5021
                                                                                                                                                                                                   {
                                                                                                                                                                                                   Spiral_wasm::US4::US4_0(x)
                                                                                                                                                                                                   =>
                                                                                                                                                                                                   x.clone(),
                                                                                                                                                                                                   _
                                                                                                                                                                                                   =>
                                                                                                                                                                                                   unreachable!(),
                                                                                                                                                                                               },
                                                                                                                                                                                               ());
                                                                                                                                                                        ()
                                                                                                                                                                    };
                                                                                                                                                                let v5163:
                                                                                                                                                                        bool =
                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                let v5165:
                                                                                                                                                                        bool =
                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                let v5166:
                                                                                                                                                                        u8 =
                                                                                                                                                                    Spiral_wasm::method64();
                                                                                                                                                                let v5170:
                                                                                                                                                                        string =
                                                                                                                                                                    string("true; v5166 });  // rust.fix_closure\'");
                                                                                                                                                                let v5171:
                                                                                                                                                                        bool =
                                                                                                                                                                    true; v5166 });  // rust.fix_closure';
                                                                                                                                                                let v5173 =
                                                                                                                                                                    __future_init;
                                                                                                                                                                let v5175:
                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                    v5173;
                                                                                                                                                                let v5178:
                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                    Spiral_wasm::method47(v5175.await);
                                                                                                                                                                let v5180:
                                                                                                                                                                        string =
                                                                                                                                                                    string("true; v5178 });  // rust.fix_closure\'");
                                                                                                                                                                let v5181:
                                                                                                                                                                        bool =
                                                                                                                                                                    true; v5178 });  // rust.fix_closure';
                                                                                                                                                                let v5183 =
                                                                                                                                                                    __future_init;
                                                                                                                                                                v5183
                                                                                                                                                            }
                                                                                                                                                            _
                                                                                                                                                            =>
                                                                                                                                                            {
                                                                                                                                                                let v5023:
                                                                                                                                                                        bool =
                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                let v5025:
                                                                                                                                                                        bool =
                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                let v5026:
                                                                                                                                                                        u8 =
                                                                                                                                                                    Spiral_wasm::method64();
                                                                                                                                                                let v5030:
                                                                                                                                                                        string =
                                                                                                                                                                    string("true; v5026 });  // rust.fix_closure\'");
                                                                                                                                                                let v5031:
                                                                                                                                                                        bool =
                                                                                                                                                                    true; v5026 });  // rust.fix_closure';
                                                                                                                                                                let v5033 =
                                                                                                                                                                    __future_init;
                                                                                                                                                                let v5035:
                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                    v5033;
                                                                                                                                                                let v5038:
                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                    Spiral_wasm::method49(v5035.await);
                                                                                                                                                                let v5040:
                                                                                                                                                                        string =
                                                                                                                                                                    string("true; v5038 });  // rust.fix_closure\'");
                                                                                                                                                                let v5041:
                                                                                                                                                                        bool =
                                                                                                                                                                    true; v5038 });  // rust.fix_closure';
                                                                                                                                                                let v5043 =
                                                                                                                                                                    __future_init;
                                                                                                                                                                v5043
                                                                                                                                                            }
                                                                                                                                                        }
                                                                                                                                                    }
                                                                                                                                                    Spiral_wasm::US6::US6_1(v5020_1_0)
                                                                                                                                                    =>
                                                                                                                                                    {
                                                                                                                                                        let v5191:
                                                                                                                                                                () =
                                                                                                                                                            {
                                                                                                                                                                Spiral_wasm::closure45(v5020_1_0.clone(),
                                                                                                                                                                                       ());
                                                                                                                                                                ()
                                                                                                                                                            };
                                                                                                                                                        let v5305:
                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                          anyhow::Error>>>> =
                                                                                                                                                            Spiral_wasm::method24(v167.clone(),
                                                                                                                                                                                  18_u8);
                                                                                                                                                        let v5307:
                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                       anyhow::Error> =
                                                                                                                                                            v5305.await;
                                                                                                                                                        let v5308 =
                                                                                                                                                            Spiral_wasm::method42();
                                                                                                                                                        let v5319:
                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                       std::string::String> =
                                                                                                                                                            v5307.map_err(|x| v5308(x));
                                                                                                                                                        let v5322:
                                                                                                                                                                Spiral_wasm::US6 =
                                                                                                                                                            match &v5319
                                                                                                                                                                {
                                                                                                                                                                Err(v5319_1_0)
                                                                                                                                                                =>
                                                                                                                                                                v187(v5319_1_0.clone()),
                                                                                                                                                                Ok(v5319_0_0)
                                                                                                                                                                =>
                                                                                                                                                                v186(v5319_0_0.clone()),
                                                                                                                                                            };
                                                                                                                                                        match &v5322
                                                                                                                                                            {
                                                                                                                                                            Spiral_wasm::US6::US6_0(v5322_0_0)
                                                                                                                                                            =>
                                                                                                                                                            {
                                                                                                                                                                let v5323:
                                                                                                                                                                        Spiral_wasm::US4 =
                                                                                                                                                                    v5322_0_0.clone();
                                                                                                                                                                match &v5323
                                                                                                                                                                    {
                                                                                                                                                                    Spiral_wasm::US4::US4_0(v5323_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    {
                                                                                                                                                                        let v5351:
                                                                                                                                                                                () =
                                                                                                                                                                            {
                                                                                                                                                                                Spiral_wasm::closure69(match &v5323
                                                                                                                                                                                                           {
                                                                                                                                                                                                           Spiral_wasm::US4::US4_0(x)
                                                                                                                                                                                                           =>
                                                                                                                                                                                                           x.clone(),
                                                                                                                                                                                                           _
                                                                                                                                                                                                           =>
                                                                                                                                                                                                           unreachable!(),
                                                                                                                                                                                                       },
                                                                                                                                                                                                       ());
                                                                                                                                                                                ()
                                                                                                                                                                            };
                                                                                                                                                                        let v5465:
                                                                                                                                                                                bool =
                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                        let v5467:
                                                                                                                                                                                bool =
                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                        let v5468:
                                                                                                                                                                                u8 =
                                                                                                                                                                            Spiral_wasm::method63();
                                                                                                                                                                        let v5472:
                                                                                                                                                                                string =
                                                                                                                                                                            string("true; v5468 });  // rust.fix_closure\'");
                                                                                                                                                                        let v5473:
                                                                                                                                                                                bool =
                                                                                                                                                                            true; v5468 });  // rust.fix_closure';
                                                                                                                                                                        let v5475 =
                                                                                                                                                                            __future_init;
                                                                                                                                                                        let v5477:
                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                            v5475;
                                                                                                                                                                        let v5480:
                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                            Spiral_wasm::method47(v5477.await);
                                                                                                                                                                        let v5482:
                                                                                                                                                                                string =
                                                                                                                                                                            string("true; v5480 });  // rust.fix_closure\'");
                                                                                                                                                                        let v5483:
                                                                                                                                                                                bool =
                                                                                                                                                                            true; v5480 });  // rust.fix_closure';
                                                                                                                                                                        let v5485 =
                                                                                                                                                                            __future_init;
                                                                                                                                                                        v5485
                                                                                                                                                                    }
                                                                                                                                                                    _
                                                                                                                                                                    =>
                                                                                                                                                                    {
                                                                                                                                                                        let v5325:
                                                                                                                                                                                bool =
                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                        let v5327:
                                                                                                                                                                                bool =
                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                        let v5328:
                                                                                                                                                                                u8 =
                                                                                                                                                                            Spiral_wasm::method63();
                                                                                                                                                                        let v5332:
                                                                                                                                                                                string =
                                                                                                                                                                            string("true; v5328 });  // rust.fix_closure\'");
                                                                                                                                                                        let v5333:
                                                                                                                                                                                bool =
                                                                                                                                                                            true; v5328 });  // rust.fix_closure';
                                                                                                                                                                        let v5335 =
                                                                                                                                                                            __future_init;
                                                                                                                                                                        let v5337:
                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                            v5335;
                                                                                                                                                                        let v5340:
                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                            Spiral_wasm::method49(v5337.await);
                                                                                                                                                                        let v5342:
                                                                                                                                                                                string =
                                                                                                                                                                            string("true; v5340 });  // rust.fix_closure\'");
                                                                                                                                                                        let v5343:
                                                                                                                                                                                bool =
                                                                                                                                                                            true; v5340 });  // rust.fix_closure';
                                                                                                                                                                        let v5345 =
                                                                                                                                                                            __future_init;
                                                                                                                                                                        v5345
                                                                                                                                                                    }
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                            Spiral_wasm::US6::US6_1(v5322_1_0)
                                                                                                                                                            =>
                                                                                                                                                            {
                                                                                                                                                                let v5493:
                                                                                                                                                                        () =
                                                                                                                                                                    {
                                                                                                                                                                        Spiral_wasm::closure46(v5322_1_0.clone(),
                                                                                                                                                                                               ());
                                                                                                                                                                        ()
                                                                                                                                                                    };
                                                                                                                                                                let v5607:
                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                  anyhow::Error>>>> =
                                                                                                                                                                    Spiral_wasm::method24(v167.clone(),
                                                                                                                                                                                          19_u8);
                                                                                                                                                                let v5609:
                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                               anyhow::Error> =
                                                                                                                                                                    v5607.await;
                                                                                                                                                                let v5610 =
                                                                                                                                                                    Spiral_wasm::method42();
                                                                                                                                                                let v5621:
                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                               std::string::String> =
                                                                                                                                                                    v5609.map_err(|x| v5610(x));
                                                                                                                                                                let v5624:
                                                                                                                                                                        Spiral_wasm::US6 =
                                                                                                                                                                    match &v5621
                                                                                                                                                                        {
                                                                                                                                                                        Err(v5621_1_0)
                                                                                                                                                                        =>
                                                                                                                                                                        v187(v5621_1_0.clone()),
                                                                                                                                                                        Ok(v5621_0_0)
                                                                                                                                                                        =>
                                                                                                                                                                        v186(v5621_0_0.clone()),
                                                                                                                                                                    };
                                                                                                                                                                match &v5624
                                                                                                                                                                    {
                                                                                                                                                                    Spiral_wasm::US6::US6_0(v5624_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    {
                                                                                                                                                                        let v5625:
                                                                                                                                                                                Spiral_wasm::US4 =
                                                                                                                                                                            v5624_0_0.clone();
                                                                                                                                                                        match &v5625
                                                                                                                                                                            {
                                                                                                                                                                            Spiral_wasm::US4::US4_0(v5625_0_0)
                                                                                                                                                                            =>
                                                                                                                                                                            {
                                                                                                                                                                                let v5653:
                                                                                                                                                                                        () =
                                                                                                                                                                                    {
                                                                                                                                                                                        Spiral_wasm::closure68(match &v5625
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                   Spiral_wasm::US4::US4_0(x)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   x.clone(),
                                                                                                                                                                                                                   _
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   unreachable!(),
                                                                                                                                                                                                               },
                                                                                                                                                                                                               ());
                                                                                                                                                                                        ()
                                                                                                                                                                                    };
                                                                                                                                                                                let v5767:
                                                                                                                                                                                        bool =
                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                let v5769:
                                                                                                                                                                                        bool =
                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                let v5770:
                                                                                                                                                                                        u8 =
                                                                                                                                                                                    Spiral_wasm::method62();
                                                                                                                                                                                let v5774:
                                                                                                                                                                                        string =
                                                                                                                                                                                    string("true; v5770 });  // rust.fix_closure\'");
                                                                                                                                                                                let v5775:
                                                                                                                                                                                        bool =
                                                                                                                                                                                    true; v5770 });  // rust.fix_closure';
                                                                                                                                                                                let v5777 =
                                                                                                                                                                                    __future_init;
                                                                                                                                                                                let v5779:
                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                    v5777;
                                                                                                                                                                                let v5782:
                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                    Spiral_wasm::method47(v5779.await);
                                                                                                                                                                                let v5784:
                                                                                                                                                                                        string =
                                                                                                                                                                                    string("true; v5782 });  // rust.fix_closure\'");
                                                                                                                                                                                let v5785:
                                                                                                                                                                                        bool =
                                                                                                                                                                                    true; v5782 });  // rust.fix_closure';
                                                                                                                                                                                let v5787 =
                                                                                                                                                                                    __future_init;
                                                                                                                                                                                v5787
                                                                                                                                                                            }
                                                                                                                                                                            _
                                                                                                                                                                            =>
                                                                                                                                                                            {
                                                                                                                                                                                let v5627:
                                                                                                                                                                                        bool =
                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                let v5629:
                                                                                                                                                                                        bool =
                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                let v5630:
                                                                                                                                                                                        u8 =
                                                                                                                                                                                    Spiral_wasm::method62();
                                                                                                                                                                                let v5634:
                                                                                                                                                                                        string =
                                                                                                                                                                                    string("true; v5630 });  // rust.fix_closure\'");
                                                                                                                                                                                let v5635:
                                                                                                                                                                                        bool =
                                                                                                                                                                                    true; v5630 });  // rust.fix_closure';
                                                                                                                                                                                let v5637 =
                                                                                                                                                                                    __future_init;
                                                                                                                                                                                let v5639:
                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                    v5637;
                                                                                                                                                                                let v5642:
                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                    Spiral_wasm::method49(v5639.await);
                                                                                                                                                                                let v5644:
                                                                                                                                                                                        string =
                                                                                                                                                                                    string("true; v5642 });  // rust.fix_closure\'");
                                                                                                                                                                                let v5645:
                                                                                                                                                                                        bool =
                                                                                                                                                                                    true; v5642 });  // rust.fix_closure';
                                                                                                                                                                                let v5647 =
                                                                                                                                                                                    __future_init;
                                                                                                                                                                                v5647
                                                                                                                                                                            }
                                                                                                                                                                        }
                                                                                                                                                                    }
                                                                                                                                                                    Spiral_wasm::US6::US6_1(v5624_1_0)
                                                                                                                                                                    =>
                                                                                                                                                                    {
                                                                                                                                                                        let v5795:
                                                                                                                                                                                () =
                                                                                                                                                                            {
                                                                                                                                                                                Spiral_wasm::closure47(v5624_1_0.clone(),
                                                                                                                                                                                                       ());
                                                                                                                                                                                ()
                                                                                                                                                                            };
                                                                                                                                                                        let v5909:
                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                          anyhow::Error>>>> =
                                                                                                                                                                            Spiral_wasm::method24(v167.clone(),
                                                                                                                                                                                                  20_u8);
                                                                                                                                                                        let v5911:
                                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                                       anyhow::Error> =
                                                                                                                                                                            v5909.await;
                                                                                                                                                                        let v5912 =
                                                                                                                                                                            Spiral_wasm::method42();
                                                                                                                                                                        let v5923:
                                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                                       std::string::String> =
                                                                                                                                                                            v5911.map_err(|x| v5912(x));
                                                                                                                                                                        let v5926:
                                                                                                                                                                                Spiral_wasm::US6 =
                                                                                                                                                                            match &v5923
                                                                                                                                                                                {
                                                                                                                                                                                Err(v5923_1_0)
                                                                                                                                                                                =>
                                                                                                                                                                                v187(v5923_1_0.clone()),
                                                                                                                                                                                Ok(v5923_0_0)
                                                                                                                                                                                =>
                                                                                                                                                                                v186(v5923_0_0.clone()),
                                                                                                                                                                            };
                                                                                                                                                                        match &v5926
                                                                                                                                                                            {
                                                                                                                                                                            Spiral_wasm::US6::US6_0(v5926_0_0)
                                                                                                                                                                            =>
                                                                                                                                                                            {
                                                                                                                                                                                let v5927:
                                                                                                                                                                                        Spiral_wasm::US4 =
                                                                                                                                                                                    v5926_0_0.clone();
                                                                                                                                                                                match &v5927
                                                                                                                                                                                    {
                                                                                                                                                                                    Spiral_wasm::US4::US4_0(v5927_0_0)
                                                                                                                                                                                    =>
                                                                                                                                                                                    {
                                                                                                                                                                                        let v5955:
                                                                                                                                                                                                () =
                                                                                                                                                                                            {
                                                                                                                                                                                                Spiral_wasm::closure67(match &v5927
                                                                                                                                                                                                                           {
                                                                                                                                                                                                                           Spiral_wasm::US4::US4_0(x)
                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                           x.clone(),
                                                                                                                                                                                                                           _
                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                           unreachable!(),
                                                                                                                                                                                                                       },
                                                                                                                                                                                                                       ());
                                                                                                                                                                                                ()
                                                                                                                                                                                            };
                                                                                                                                                                                        let v6069:
                                                                                                                                                                                                bool =
                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                        let v6071:
                                                                                                                                                                                                bool =
                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                        let v6072:
                                                                                                                                                                                                u8 =
                                                                                                                                                                                            Spiral_wasm::method61();
                                                                                                                                                                                        let v6076:
                                                                                                                                                                                                string =
                                                                                                                                                                                            string("true; v6072 });  // rust.fix_closure\'");
                                                                                                                                                                                        let v6077:
                                                                                                                                                                                                bool =
                                                                                                                                                                                            true; v6072 });  // rust.fix_closure';
                                                                                                                                                                                        let v6079 =
                                                                                                                                                                                            __future_init;
                                                                                                                                                                                        let v6081:
                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                            v6079;
                                                                                                                                                                                        let v6084:
                                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                                            Spiral_wasm::method47(v6081.await);
                                                                                                                                                                                        let v6086:
                                                                                                                                                                                                string =
                                                                                                                                                                                            string("true; v6084 });  // rust.fix_closure\'");
                                                                                                                                                                                        let v6087:
                                                                                                                                                                                                bool =
                                                                                                                                                                                            true; v6084 });  // rust.fix_closure';
                                                                                                                                                                                        let v6089 =
                                                                                                                                                                                            __future_init;
                                                                                                                                                                                        v6089
                                                                                                                                                                                    }
                                                                                                                                                                                    _
                                                                                                                                                                                    =>
                                                                                                                                                                                    {
                                                                                                                                                                                        let v5929:
                                                                                                                                                                                                bool =
                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                        let v5931:
                                                                                                                                                                                                bool =
                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                        let v5932:
                                                                                                                                                                                                u8 =
                                                                                                                                                                                            Spiral_wasm::method61();
                                                                                                                                                                                        let v5936:
                                                                                                                                                                                                string =
                                                                                                                                                                                            string("true; v5932 });  // rust.fix_closure\'");
                                                                                                                                                                                        let v5937:
                                                                                                                                                                                                bool =
                                                                                                                                                                                            true; v5932 });  // rust.fix_closure';
                                                                                                                                                                                        let v5939 =
                                                                                                                                                                                            __future_init;
                                                                                                                                                                                        let v5941:
                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                            v5939;
                                                                                                                                                                                        let v5944:
                                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                                            Spiral_wasm::method49(v5941.await);
                                                                                                                                                                                        let v5946:
                                                                                                                                                                                                string =
                                                                                                                                                                                            string("true; v5944 });  // rust.fix_closure\'");
                                                                                                                                                                                        let v5947:
                                                                                                                                                                                                bool =
                                                                                                                                                                                            true; v5944 });  // rust.fix_closure';
                                                                                                                                                                                        let v5949 =
                                                                                                                                                                                            __future_init;
                                                                                                                                                                                        v5949
                                                                                                                                                                                    }
                                                                                                                                                                                }
                                                                                                                                                                            }
                                                                                                                                                                            Spiral_wasm::US6::US6_1(v5926_1_0)
                                                                                                                                                                            =>
                                                                                                                                                                            {
                                                                                                                                                                                let v6097:
                                                                                                                                                                                        () =
                                                                                                                                                                                    {
                                                                                                                                                                                        Spiral_wasm::closure48(v5926_1_0.clone(),
                                                                                                                                                                                                               ());
                                                                                                                                                                                        ()
                                                                                                                                                                                    };
                                                                                                                                                                                let v6211:
                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                  anyhow::Error>>>> =
                                                                                                                                                                                    Spiral_wasm::method24(v167.clone(),
                                                                                                                                                                                                          21_u8);
                                                                                                                                                                                let v6213:
                                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                                               anyhow::Error> =
                                                                                                                                                                                    v6211.await;
                                                                                                                                                                                let v6214 =
                                                                                                                                                                                    Spiral_wasm::method42();
                                                                                                                                                                                let v6225:
                                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                                               std::string::String> =
                                                                                                                                                                                    v6213.map_err(|x| v6214(x));
                                                                                                                                                                                let v6228:
                                                                                                                                                                                        Spiral_wasm::US6 =
                                                                                                                                                                                    match &v6225
                                                                                                                                                                                        {
                                                                                                                                                                                        Err(v6225_1_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v187(v6225_1_0.clone()),
                                                                                                                                                                                        Ok(v6225_0_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v186(v6225_0_0.clone()),
                                                                                                                                                                                    };
                                                                                                                                                                                match &v6228
                                                                                                                                                                                    {
                                                                                                                                                                                    Spiral_wasm::US6::US6_0(v6228_0_0)
                                                                                                                                                                                    =>
                                                                                                                                                                                    {
                                                                                                                                                                                        let v6229:
                                                                                                                                                                                                Spiral_wasm::US4 =
                                                                                                                                                                                            v6228_0_0.clone();
                                                                                                                                                                                        match &v6229
                                                                                                                                                                                            {
                                                                                                                                                                                            Spiral_wasm::US4::US4_0(v6229_0_0)
                                                                                                                                                                                            =>
                                                                                                                                                                                            {
                                                                                                                                                                                                let v6257:
                                                                                                                                                                                                        () =
                                                                                                                                                                                                    {
                                                                                                                                                                                                        Spiral_wasm::closure66(match &v6229
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                   Spiral_wasm::US4::US4_0(x)
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   x.clone(),
                                                                                                                                                                                                                                   _
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   unreachable!(),
                                                                                                                                                                                                                               },
                                                                                                                                                                                                                               ());
                                                                                                                                                                                                        ()
                                                                                                                                                                                                    };
                                                                                                                                                                                                let v6371:
                                                                                                                                                                                                        bool =
                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                let v6373:
                                                                                                                                                                                                        bool =
                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                let v6374:
                                                                                                                                                                                                        u8 =
                                                                                                                                                                                                    Spiral_wasm::method60();
                                                                                                                                                                                                let v6378:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    string("true; v6374 });  // rust.fix_closure\'");
                                                                                                                                                                                                let v6379:
                                                                                                                                                                                                        bool =
                                                                                                                                                                                                    true; v6374 });  // rust.fix_closure';
                                                                                                                                                                                                let v6381 =
                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                let v6383:
                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                    v6381;
                                                                                                                                                                                                let v6386:
                                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                                    Spiral_wasm::method47(v6383.await);
                                                                                                                                                                                                let v6388:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    string("true; v6386 });  // rust.fix_closure\'");
                                                                                                                                                                                                let v6389:
                                                                                                                                                                                                        bool =
                                                                                                                                                                                                    true; v6386 });  // rust.fix_closure';
                                                                                                                                                                                                let v6391 =
                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                v6391
                                                                                                                                                                                            }
                                                                                                                                                                                            _
                                                                                                                                                                                            =>
                                                                                                                                                                                            {
                                                                                                                                                                                                let v6231:
                                                                                                                                                                                                        bool =
                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                let v6233:
                                                                                                                                                                                                        bool =
                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                let v6234:
                                                                                                                                                                                                        u8 =
                                                                                                                                                                                                    Spiral_wasm::method60();
                                                                                                                                                                                                let v6238:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    string("true; v6234 });  // rust.fix_closure\'");
                                                                                                                                                                                                let v6239:
                                                                                                                                                                                                        bool =
                                                                                                                                                                                                    true; v6234 });  // rust.fix_closure';
                                                                                                                                                                                                let v6241 =
                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                let v6243:
                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                    v6241;
                                                                                                                                                                                                let v6246:
                                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                                    Spiral_wasm::method49(v6243.await);
                                                                                                                                                                                                let v6248:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    string("true; v6246 });  // rust.fix_closure\'");
                                                                                                                                                                                                let v6249:
                                                                                                                                                                                                        bool =
                                                                                                                                                                                                    true; v6246 });  // rust.fix_closure';
                                                                                                                                                                                                let v6251 =
                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                v6251
                                                                                                                                                                                            }
                                                                                                                                                                                        }
                                                                                                                                                                                    }
                                                                                                                                                                                    Spiral_wasm::US6::US6_1(v6228_1_0)
                                                                                                                                                                                    =>
                                                                                                                                                                                    {
                                                                                                                                                                                        let v6399:
                                                                                                                                                                                                () =
                                                                                                                                                                                            {
                                                                                                                                                                                                Spiral_wasm::closure49(v6228_1_0.clone(),
                                                                                                                                                                                                                       ());
                                                                                                                                                                                                ()
                                                                                                                                                                                            };
                                                                                                                                                                                        let v6513:
                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                          anyhow::Error>>>> =
                                                                                                                                                                                            Spiral_wasm::method24(v167.clone(),
                                                                                                                                                                                                                  22_u8);
                                                                                                                                                                                        let v6515:
                                                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                                                       anyhow::Error> =
                                                                                                                                                                                            v6513.await;
                                                                                                                                                                                        let v6516 =
                                                                                                                                                                                            Spiral_wasm::method42();
                                                                                                                                                                                        let v6527:
                                                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                                                       std::string::String> =
                                                                                                                                                                                            v6515.map_err(|x| v6516(x));
                                                                                                                                                                                        let v6530:
                                                                                                                                                                                                Spiral_wasm::US6 =
                                                                                                                                                                                            match &v6527
                                                                                                                                                                                                {
                                                                                                                                                                                                Err(v6527_1_0)
                                                                                                                                                                                                =>
                                                                                                                                                                                                v187(v6527_1_0.clone()),
                                                                                                                                                                                                Ok(v6527_0_0)
                                                                                                                                                                                                =>
                                                                                                                                                                                                v186(v6527_0_0.clone()),
                                                                                                                                                                                            };
                                                                                                                                                                                        match &v6530
                                                                                                                                                                                            {
                                                                                                                                                                                            Spiral_wasm::US6::US6_0(v6530_0_0)
                                                                                                                                                                                            =>
                                                                                                                                                                                            {
                                                                                                                                                                                                let v6531:
                                                                                                                                                                                                        Spiral_wasm::US4 =
                                                                                                                                                                                                    v6530_0_0.clone();
                                                                                                                                                                                                match &v6531
                                                                                                                                                                                                    {
                                                                                                                                                                                                    Spiral_wasm::US4::US4_0(v6531_0_0)
                                                                                                                                                                                                    =>
                                                                                                                                                                                                    {
                                                                                                                                                                                                        let v6559:
                                                                                                                                                                                                                () =
                                                                                                                                                                                                            {
                                                                                                                                                                                                                Spiral_wasm::closure65(match &v6531
                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                           Spiral_wasm::US4::US4_0(x)
                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                           x.clone(),
                                                                                                                                                                                                                                           _
                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                           unreachable!(),
                                                                                                                                                                                                                                       },
                                                                                                                                                                                                                                       ());
                                                                                                                                                                                                                ()
                                                                                                                                                                                                            };
                                                                                                                                                                                                        let v6673:
                                                                                                                                                                                                                bool =
                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                        let v6675:
                                                                                                                                                                                                                bool =
                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                        let v6676:
                                                                                                                                                                                                                u8 =
                                                                                                                                                                                                            Spiral_wasm::method59();
                                                                                                                                                                                                        let v6680:
                                                                                                                                                                                                                string =
                                                                                                                                                                                                            string("true; v6676 });  // rust.fix_closure\'");
                                                                                                                                                                                                        let v6681:
                                                                                                                                                                                                                bool =
                                                                                                                                                                                                            true; v6676 });  // rust.fix_closure';
                                                                                                                                                                                                        let v6683 =
                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                        let v6685:
                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                            v6683;
                                                                                                                                                                                                        let v6688:
                                                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                                                            Spiral_wasm::method47(v6685.await);
                                                                                                                                                                                                        let v6690:
                                                                                                                                                                                                                string =
                                                                                                                                                                                                            string("true; v6688 });  // rust.fix_closure\'");
                                                                                                                                                                                                        let v6691:
                                                                                                                                                                                                                bool =
                                                                                                                                                                                                            true; v6688 });  // rust.fix_closure';
                                                                                                                                                                                                        let v6693 =
                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                        v6693
                                                                                                                                                                                                    }
                                                                                                                                                                                                    _
                                                                                                                                                                                                    =>
                                                                                                                                                                                                    {
                                                                                                                                                                                                        let v6533:
                                                                                                                                                                                                                bool =
                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                        let v6535:
                                                                                                                                                                                                                bool =
                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                        let v6536:
                                                                                                                                                                                                                u8 =
                                                                                                                                                                                                            Spiral_wasm::method59();
                                                                                                                                                                                                        let v6540:
                                                                                                                                                                                                                string =
                                                                                                                                                                                                            string("true; v6536 });  // rust.fix_closure\'");
                                                                                                                                                                                                        let v6541:
                                                                                                                                                                                                                bool =
                                                                                                                                                                                                            true; v6536 });  // rust.fix_closure';
                                                                                                                                                                                                        let v6543 =
                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                        let v6545:
                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                            v6543;
                                                                                                                                                                                                        let v6548:
                                                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                                                            Spiral_wasm::method49(v6545.await);
                                                                                                                                                                                                        let v6550:
                                                                                                                                                                                                                string =
                                                                                                                                                                                                            string("true; v6548 });  // rust.fix_closure\'");
                                                                                                                                                                                                        let v6551:
                                                                                                                                                                                                                bool =
                                                                                                                                                                                                            true; v6548 });  // rust.fix_closure';
                                                                                                                                                                                                        let v6553 =
                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                        v6553
                                                                                                                                                                                                    }
                                                                                                                                                                                                }
                                                                                                                                                                                            }
                                                                                                                                                                                            Spiral_wasm::US6::US6_1(v6530_1_0)
                                                                                                                                                                                            =>
                                                                                                                                                                                            {
                                                                                                                                                                                                let v6701:
                                                                                                                                                                                                        () =
                                                                                                                                                                                                    {
                                                                                                                                                                                                        Spiral_wasm::closure50(v6530_1_0.clone(),
                                                                                                                                                                                                                               ());
                                                                                                                                                                                                        ()
                                                                                                                                                                                                    };
                                                                                                                                                                                                let v6815:
                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                                  anyhow::Error>>>> =
                                                                                                                                                                                                    Spiral_wasm::method24(v167.clone(),
                                                                                                                                                                                                                          23_u8);
                                                                                                                                                                                                let v6817:
                                                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                                                               anyhow::Error> =
                                                                                                                                                                                                    v6815.await;
                                                                                                                                                                                                let v6818 =
                                                                                                                                                                                                    Spiral_wasm::method42();
                                                                                                                                                                                                let v6829:
                                                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                                                               std::string::String> =
                                                                                                                                                                                                    v6817.map_err(|x| v6818(x));
                                                                                                                                                                                                let v6832:
                                                                                                                                                                                                        Spiral_wasm::US6 =
                                                                                                                                                                                                    match &v6829
                                                                                                                                                                                                        {
                                                                                                                                                                                                        Err(v6829_1_0)
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        v187(v6829_1_0.clone()),
                                                                                                                                                                                                        Ok(v6829_0_0)
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        v186(v6829_0_0.clone()),
                                                                                                                                                                                                    };
                                                                                                                                                                                                match &v6832
                                                                                                                                                                                                    {
                                                                                                                                                                                                    Spiral_wasm::US6::US6_0(v6832_0_0)
                                                                                                                                                                                                    =>
                                                                                                                                                                                                    {
                                                                                                                                                                                                        let v6833:
                                                                                                                                                                                                                Spiral_wasm::US4 =
                                                                                                                                                                                                            v6832_0_0.clone();
                                                                                                                                                                                                        match &v6833
                                                                                                                                                                                                            {
                                                                                                                                                                                                            Spiral_wasm::US4::US4_0(v6833_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            {
                                                                                                                                                                                                                let v6861:
                                                                                                                                                                                                                        () =
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        Spiral_wasm::closure64(match &v6833
                                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                                   Spiral_wasm::US4::US4_0(x)
                                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                                   x.clone(),
                                                                                                                                                                                                                                                   _
                                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                                   unreachable!(),
                                                                                                                                                                                                                                               },
                                                                                                                                                                                                                                               ());
                                                                                                                                                                                                                        ()
                                                                                                                                                                                                                    };
                                                                                                                                                                                                                let v6975:
                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                let v6977:
                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                let v6978:
                                                                                                                                                                                                                        u8 =
                                                                                                                                                                                                                    Spiral_wasm::method58();
                                                                                                                                                                                                                let v6982:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    string("true; v6978 });  // rust.fix_closure\'");
                                                                                                                                                                                                                let v6983:
                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                    true; v6978 });  // rust.fix_closure';
                                                                                                                                                                                                                let v6985 =
                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                let v6987:
                                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                    v6985;
                                                                                                                                                                                                                let v6990:
                                                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                                                    Spiral_wasm::method47(v6987.await);
                                                                                                                                                                                                                let v6992:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    string("true; v6990 });  // rust.fix_closure\'");
                                                                                                                                                                                                                let v6993:
                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                    true; v6990 });  // rust.fix_closure';
                                                                                                                                                                                                                let v6995 =
                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                v6995
                                                                                                                                                                                                            }
                                                                                                                                                                                                            _
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            {
                                                                                                                                                                                                                let v6835:
                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                let v6837:
                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                let v6838:
                                                                                                                                                                                                                        u8 =
                                                                                                                                                                                                                    Spiral_wasm::method58();
                                                                                                                                                                                                                let v6842:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    string("true; v6838 });  // rust.fix_closure\'");
                                                                                                                                                                                                                let v6843:
                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                    true; v6838 });  // rust.fix_closure';
                                                                                                                                                                                                                let v6845 =
                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                let v6847:
                                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                    v6845;
                                                                                                                                                                                                                let v6850:
                                                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                                                    Spiral_wasm::method49(v6847.await);
                                                                                                                                                                                                                let v6852:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    string("true; v6850 });  // rust.fix_closure\'");
                                                                                                                                                                                                                let v6853:
                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                    true; v6850 });  // rust.fix_closure';
                                                                                                                                                                                                                let v6855 =
                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                v6855
                                                                                                                                                                                                            }
                                                                                                                                                                                                        }
                                                                                                                                                                                                    }
                                                                                                                                                                                                    Spiral_wasm::US6::US6_1(v6832_1_0)
                                                                                                                                                                                                    =>
                                                                                                                                                                                                    {
                                                                                                                                                                                                        let v7003:
                                                                                                                                                                                                                () =
                                                                                                                                                                                                            {
                                                                                                                                                                                                                Spiral_wasm::closure51(v6832_1_0.clone(),
                                                                                                                                                                                                                                       ());
                                                                                                                                                                                                                ()
                                                                                                                                                                                                            };
                                                                                                                                                                                                        let v7117:
                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                                          anyhow::Error>>>> =
                                                                                                                                                                                                            Spiral_wasm::method24(v167.clone(),
                                                                                                                                                                                                                                  24_u8);
                                                                                                                                                                                                        let v7119:
                                                                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                                                                       anyhow::Error> =
                                                                                                                                                                                                            v7117.await;
                                                                                                                                                                                                        let v7120 =
                                                                                                                                                                                                            Spiral_wasm::method42();
                                                                                                                                                                                                        let v7131:
                                                                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                                                                       std::string::String> =
                                                                                                                                                                                                            v7119.map_err(|x| v7120(x));
                                                                                                                                                                                                        let v7134:
                                                                                                                                                                                                                Spiral_wasm::US6 =
                                                                                                                                                                                                            match &v7131
                                                                                                                                                                                                                {
                                                                                                                                                                                                                Err(v7131_1_0)
                                                                                                                                                                                                                =>
                                                                                                                                                                                                                v187(v7131_1_0.clone()),
                                                                                                                                                                                                                Ok(v7131_0_0)
                                                                                                                                                                                                                =>
                                                                                                                                                                                                                v186(v7131_0_0.clone()),
                                                                                                                                                                                                            };
                                                                                                                                                                                                        match &v7134
                                                                                                                                                                                                            {
                                                                                                                                                                                                            Spiral_wasm::US6::US6_0(v7134_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            {
                                                                                                                                                                                                                let v7135:
                                                                                                                                                                                                                        Spiral_wasm::US4 =
                                                                                                                                                                                                                    v7134_0_0.clone();
                                                                                                                                                                                                                match &v7135
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                    Spiral_wasm::US4::US4_0(v7135_0_0)
                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        let v7163:
                                                                                                                                                                                                                                () =
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                Spiral_wasm::closure63(match &v7135
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                           Spiral_wasm::US4::US4_0(x)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           x.clone(),
                                                                                                                                                                                                                                                           _
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           unreachable!(),
                                                                                                                                                                                                                                                       },
                                                                                                                                                                                                                                                       ());
                                                                                                                                                                                                                                ()
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        let v7277:
                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                        let v7279:
                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                        let v7280:
                                                                                                                                                                                                                                u8 =
                                                                                                                                                                                                                            Spiral_wasm::method57();
                                                                                                                                                                                                                        let v7284:
                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                            string("true; v7280 });  // rust.fix_closure\'");
                                                                                                                                                                                                                        let v7285:
                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                            true; v7280 });  // rust.fix_closure';
                                                                                                                                                                                                                        let v7287 =
                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                        let v7289:
                                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                            v7287;
                                                                                                                                                                                                                        let v7292:
                                                                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                                                                            Spiral_wasm::method47(v7289.await);
                                                                                                                                                                                                                        let v7294:
                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                            string("true; v7292 });  // rust.fix_closure\'");
                                                                                                                                                                                                                        let v7295:
                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                            true; v7292 });  // rust.fix_closure';
                                                                                                                                                                                                                        let v7297 =
                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                        v7297
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                    _
                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        let v7137:
                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                        let v7139:
                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                        let v7140:
                                                                                                                                                                                                                                u8 =
                                                                                                                                                                                                                            Spiral_wasm::method57();
                                                                                                                                                                                                                        let v7144:
                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                            string("true; v7140 });  // rust.fix_closure\'");
                                                                                                                                                                                                                        let v7145:
                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                            true; v7140 });  // rust.fix_closure';
                                                                                                                                                                                                                        let v7147 =
                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                        let v7149:
                                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                            v7147;
                                                                                                                                                                                                                        let v7152:
                                                                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                                                                            Spiral_wasm::method49(v7149.await);
                                                                                                                                                                                                                        let v7154:
                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                            string("true; v7152 });  // rust.fix_closure\'");
                                                                                                                                                                                                                        let v7155:
                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                            true; v7152 });  // rust.fix_closure';
                                                                                                                                                                                                                        let v7157 =
                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                        v7157
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                }
                                                                                                                                                                                                            }
                                                                                                                                                                                                            Spiral_wasm::US6::US6_1(v7134_1_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            {
                                                                                                                                                                                                                let v7305:
                                                                                                                                                                                                                        () =
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        Spiral_wasm::closure52(v7134_1_0.clone(),
                                                                                                                                                                                                                                               ());
                                                                                                                                                                                                                        ()
                                                                                                                                                                                                                    };
                                                                                                                                                                                                                let v7419:
                                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                                                  anyhow::Error>>>> =
                                                                                                                                                                                                                    Spiral_wasm::method24(v167.clone(),
                                                                                                                                                                                                                                          25_u8);
                                                                                                                                                                                                                let v7421:
                                                                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                                                                               anyhow::Error> =
                                                                                                                                                                                                                    v7419.await;
                                                                                                                                                                                                                let v7422 =
                                                                                                                                                                                                                    Spiral_wasm::method42();
                                                                                                                                                                                                                let v7433:
                                                                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                                                                               std::string::String> =
                                                                                                                                                                                                                    v7421.map_err(|x| v7422(x));
                                                                                                                                                                                                                let v7436:
                                                                                                                                                                                                                        Spiral_wasm::US6 =
                                                                                                                                                                                                                    match &v7433
                                                                                                                                                                                                                        {
                                                                                                                                                                                                                        Err(v7433_1_0)
                                                                                                                                                                                                                        =>
                                                                                                                                                                                                                        v187(v7433_1_0.clone()),
                                                                                                                                                                                                                        Ok(v7433_0_0)
                                                                                                                                                                                                                        =>
                                                                                                                                                                                                                        v186(v7433_0_0.clone()),
                                                                                                                                                                                                                    };
                                                                                                                                                                                                                match &v7436
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                    Spiral_wasm::US6::US6_0(v7436_0_0)
                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        let v7437:
                                                                                                                                                                                                                                Spiral_wasm::US4 =
                                                                                                                                                                                                                            v7436_0_0.clone();
                                                                                                                                                                                                                        match &v7437
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                            Spiral_wasm::US4::US4_0(v7437_0_0)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                let v7465:
                                                                                                                                                                                                                                        () =
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        Spiral_wasm::closure62(match &v7437
                                                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                                                   Spiral_wasm::US4::US4_0(x)
                                                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                                                   x.clone(),
                                                                                                                                                                                                                                                                   _
                                                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                                                   unreachable!(),
                                                                                                                                                                                                                                                               },
                                                                                                                                                                                                                                                               ());
                                                                                                                                                                                                                                        ()
                                                                                                                                                                                                                                    };
                                                                                                                                                                                                                                let v7579:
                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                let v7581:
                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                let v7582:
                                                                                                                                                                                                                                        u8 =
                                                                                                                                                                                                                                    Spiral_wasm::method56();
                                                                                                                                                                                                                                let v7586:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    string("true; v7582 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                let v7587:
                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                    true; v7582 });  // rust.fix_closure';
                                                                                                                                                                                                                                let v7589 =
                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                let v7591:
                                                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                                    v7589;
                                                                                                                                                                                                                                let v7594:
                                                                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                                                                    Spiral_wasm::method47(v7591.await);
                                                                                                                                                                                                                                let v7596:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    string("true; v7594 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                let v7597:
                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                    true; v7594 });  // rust.fix_closure';
                                                                                                                                                                                                                                let v7599 =
                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                v7599
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                            _
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                let v7439:
                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                let v7441:
                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                let v7442:
                                                                                                                                                                                                                                        u8 =
                                                                                                                                                                                                                                    Spiral_wasm::method56();
                                                                                                                                                                                                                                let v7446:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    string("true; v7442 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                let v7447:
                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                    true; v7442 });  // rust.fix_closure';
                                                                                                                                                                                                                                let v7449 =
                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                let v7451:
                                                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                                    v7449;
                                                                                                                                                                                                                                let v7454:
                                                                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                                                                    Spiral_wasm::method49(v7451.await);
                                                                                                                                                                                                                                let v7456:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    string("true; v7454 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                let v7457:
                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                    true; v7454 });  // rust.fix_closure';
                                                                                                                                                                                                                                let v7459 =
                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                v7459
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                    Spiral_wasm::US6::US6_1(v7436_1_0)
                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        let v7607:
                                                                                                                                                                                                                                () =
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                Spiral_wasm::closure53(v7436_1_0.clone(),
                                                                                                                                                                                                                                                       ());
                                                                                                                                                                                                                                ()
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        let v7721:
                                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                                                          anyhow::Error>>>> =
                                                                                                                                                                                                                            Spiral_wasm::method24(v167.clone(),
                                                                                                                                                                                                                                                  26_u8);
                                                                                                                                                                                                                        let v7723:
                                                                                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                       anyhow::Error> =
                                                                                                                                                                                                                            v7721.await;
                                                                                                                                                                                                                        let v7724 =
                                                                                                                                                                                                                            Spiral_wasm::method42();
                                                                                                                                                                                                                        let v7735:
                                                                                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                       std::string::String> =
                                                                                                                                                                                                                            v7723.map_err(|x| v7724(x));
                                                                                                                                                                                                                        let v7738:
                                                                                                                                                                                                                                Spiral_wasm::US6 =
                                                                                                                                                                                                                            match &v7735
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                Err(v7735_1_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v187(v7735_1_0.clone()),
                                                                                                                                                                                                                                Ok(v7735_0_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v186(v7735_0_0.clone()),
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        match &v7738
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                            Spiral_wasm::US6::US6_0(v7738_0_0)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                let v7739:
                                                                                                                                                                                                                                        Spiral_wasm::US4 =
                                                                                                                                                                                                                                    v7738_0_0.clone();
                                                                                                                                                                                                                                match &v7739
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                    Spiral_wasm::US4::US4_0(v7739_0_0)
                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        let v7767:
                                                                                                                                                                                                                                                () =
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                Spiral_wasm::closure61(match &v7739
                                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                                           Spiral_wasm::US4::US4_0(x)
                                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                                           x.clone(),
                                                                                                                                                                                                                                                                           _
                                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                                           unreachable!(),
                                                                                                                                                                                                                                                                       },
                                                                                                                                                                                                                                                                       ());
                                                                                                                                                                                                                                                ()
                                                                                                                                                                                                                                            };
                                                                                                                                                                                                                                        let v7881:
                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                        let v7883:
                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                        let v7884:
                                                                                                                                                                                                                                                u8 =
                                                                                                                                                                                                                                            Spiral_wasm::method55();
                                                                                                                                                                                                                                        let v7888:
                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                            string("true; v7884 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                        let v7889:
                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                            true; v7884 });  // rust.fix_closure';
                                                                                                                                                                                                                                        let v7891 =
                                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                                        let v7893:
                                                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                                            v7891;
                                                                                                                                                                                                                                        let v7896:
                                                                                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                                                                                            Spiral_wasm::method47(v7893.await);
                                                                                                                                                                                                                                        let v7898:
                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                            string("true; v7896 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                        let v7899:
                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                            true; v7896 });  // rust.fix_closure';
                                                                                                                                                                                                                                        let v7901 =
                                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                                        v7901
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                    _
                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        let v7741:
                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                        let v7743:
                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                        let v7744:
                                                                                                                                                                                                                                                u8 =
                                                                                                                                                                                                                                            Spiral_wasm::method55();
                                                                                                                                                                                                                                        let v7748:
                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                            string("true; v7744 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                        let v7749:
                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                            true; v7744 });  // rust.fix_closure';
                                                                                                                                                                                                                                        let v7751 =
                                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                                        let v7753:
                                                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                                            v7751;
                                                                                                                                                                                                                                        let v7756:
                                                                                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                                                                                            Spiral_wasm::method49(v7753.await);
                                                                                                                                                                                                                                        let v7758:
                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                            string("true; v7756 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                        let v7759:
                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                            true; v7756 });  // rust.fix_closure';
                                                                                                                                                                                                                                        let v7761 =
                                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                                        v7761
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                            Spiral_wasm::US6::US6_1(v7738_1_0)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                let v7909:
                                                                                                                                                                                                                                        () =
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        Spiral_wasm::closure54(v7738_1_0.clone(),
                                                                                                                                                                                                                                                               ());
                                                                                                                                                                                                                                        ()
                                                                                                                                                                                                                                    };
                                                                                                                                                                                                                                let v8023:
                                                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                                                                  anyhow::Error>>>> =
                                                                                                                                                                                                                                    Spiral_wasm::method24(v167.clone(),
                                                                                                                                                                                                                                                          27_u8);
                                                                                                                                                                                                                                let v8025:
                                                                                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                               anyhow::Error> =
                                                                                                                                                                                                                                    v8023.await;
                                                                                                                                                                                                                                let v8026 =
                                                                                                                                                                                                                                    Spiral_wasm::method42();
                                                                                                                                                                                                                                let v8037:
                                                                                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                               std::string::String> =
                                                                                                                                                                                                                                    v8025.map_err(|x| v8026(x));
                                                                                                                                                                                                                                let v8040:
                                                                                                                                                                                                                                        Spiral_wasm::US6 =
                                                                                                                                                                                                                                    match &v8037
                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                        Err(v8037_1_0)
                                                                                                                                                                                                                                        =>
                                                                                                                                                                                                                                        v187(v8037_1_0.clone()),
                                                                                                                                                                                                                                        Ok(v8037_0_0)
                                                                                                                                                                                                                                        =>
                                                                                                                                                                                                                                        v186(v8037_0_0.clone()),
                                                                                                                                                                                                                                    };
                                                                                                                                                                                                                                match &v8040
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                    Spiral_wasm::US6::US6_0(v8040_0_0)
                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        let v8041:
                                                                                                                                                                                                                                                Spiral_wasm::US4 =
                                                                                                                                                                                                                                            v8040_0_0.clone();
                                                                                                                                                                                                                                        match &v8041
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                            Spiral_wasm::US4::US4_0(v8041_0_0)
                                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                let v8069:
                                                                                                                                                                                                                                                        () =
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        Spiral_wasm::closure60(match &v8041
                                                                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                                                                   Spiral_wasm::US4::US4_0(x)
                                                                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                                                                   x.clone(),
                                                                                                                                                                                                                                                                                   _
                                                                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                                                                   unreachable!(),
                                                                                                                                                                                                                                                                               },
                                                                                                                                                                                                                                                                               ());
                                                                                                                                                                                                                                                        ()
                                                                                                                                                                                                                                                    };
                                                                                                                                                                                                                                                let v8183:
                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                let v8185:
                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                let v8186:
                                                                                                                                                                                                                                                        u8 =
                                                                                                                                                                                                                                                    Spiral_wasm::method54();
                                                                                                                                                                                                                                                let v8190:
                                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                                    string("true; v8186 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                let v8191:
                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                    true; v8186 });  // rust.fix_closure';
                                                                                                                                                                                                                                                let v8193 =
                                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                                let v8195:
                                                                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                                                    v8193;
                                                                                                                                                                                                                                                let v8198:
                                                                                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                                                                                    Spiral_wasm::method47(v8195.await);
                                                                                                                                                                                                                                                let v8200:
                                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                                    string("true; v8198 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                let v8201:
                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                    true; v8198 });  // rust.fix_closure';
                                                                                                                                                                                                                                                let v8203 =
                                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                                v8203
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                            _
                                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                let v8043:
                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                let v8045:
                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                let v8046:
                                                                                                                                                                                                                                                        u8 =
                                                                                                                                                                                                                                                    Spiral_wasm::method54();
                                                                                                                                                                                                                                                let v8050:
                                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                                    string("true; v8046 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                let v8051:
                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                    true; v8046 });  // rust.fix_closure';
                                                                                                                                                                                                                                                let v8053 =
                                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                                let v8055:
                                                                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                                                    v8053;
                                                                                                                                                                                                                                                let v8058:
                                                                                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                                                                                    Spiral_wasm::method49(v8055.await);
                                                                                                                                                                                                                                                let v8060:
                                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                                    string("true; v8058 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                let v8061:
                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                    true; v8058 });  // rust.fix_closure';
                                                                                                                                                                                                                                                let v8063 =
                                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                                v8063
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                    Spiral_wasm::US6::US6_1(v8040_1_0)
                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        let v8211:
                                                                                                                                                                                                                                                () =
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                Spiral_wasm::closure55(v8040_1_0.clone(),
                                                                                                                                                                                                                                                                       ());
                                                                                                                                                                                                                                                ()
                                                                                                                                                                                                                                            };
                                                                                                                                                                                                                                        let v8325:
                                                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                                                                          anyhow::Error>>>> =
                                                                                                                                                                                                                                            Spiral_wasm::method24(v167.clone(),
                                                                                                                                                                                                                                                                  28_u8);
                                                                                                                                                                                                                                        let v8327:
                                                                                                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                       anyhow::Error> =
                                                                                                                                                                                                                                            v8325.await;
                                                                                                                                                                                                                                        let v8328 =
                                                                                                                                                                                                                                            Spiral_wasm::method42();
                                                                                                                                                                                                                                        let v8339:
                                                                                                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                       std::string::String> =
                                                                                                                                                                                                                                            v8327.map_err(|x| v8328(x));
                                                                                                                                                                                                                                        let v8342:
                                                                                                                                                                                                                                                Spiral_wasm::US6 =
                                                                                                                                                                                                                                            match &v8339
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                Err(v8339_1_0)
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                v187(v8339_1_0.clone()),
                                                                                                                                                                                                                                                Ok(v8339_0_0)
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                v186(v8339_0_0.clone()),
                                                                                                                                                                                                                                            };
                                                                                                                                                                                                                                        match &v8342
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                            Spiral_wasm::US6::US6_0(v8342_0_0)
                                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                let v8343:
                                                                                                                                                                                                                                                        Spiral_wasm::US4 =
                                                                                                                                                                                                                                                    v8342_0_0.clone();
                                                                                                                                                                                                                                                match &v8343
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    Spiral_wasm::US4::US4_0(v8343_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        let v8371:
                                                                                                                                                                                                                                                                () =
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                Spiral_wasm::closure59(match &v8343
                                                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                                                           Spiral_wasm::US4::US4_0(x)
                                                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                                                           x.clone(),
                                                                                                                                                                                                                                                                                           _
                                                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                                                           unreachable!(),
                                                                                                                                                                                                                                                                                       },
                                                                                                                                                                                                                                                                                       ());
                                                                                                                                                                                                                                                                ()
                                                                                                                                                                                                                                                            };
                                                                                                                                                                                                                                                        let v8485:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                        let v8487:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                        let v8488:
                                                                                                                                                                                                                                                                u8 =
                                                                                                                                                                                                                                                            Spiral_wasm::method53();
                                                                                                                                                                                                                                                        let v8492:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            string("true; v8488 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                        let v8493:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; v8488 });  // rust.fix_closure';
                                                                                                                                                                                                                                                        let v8495 =
                                                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                                                        let v8497:
                                                                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                                                            v8495;
                                                                                                                                                                                                                                                        let v8500:
                                                                                                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                                                                                                            Spiral_wasm::method47(v8497.await);
                                                                                                                                                                                                                                                        let v8502:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            string("true; v8500 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                        let v8503:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; v8500 });  // rust.fix_closure';
                                                                                                                                                                                                                                                        let v8505 =
                                                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                                                        v8505
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                    _
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        let v8345:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                        let v8347:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                        let v8348:
                                                                                                                                                                                                                                                                u8 =
                                                                                                                                                                                                                                                            Spiral_wasm::method53();
                                                                                                                                                                                                                                                        let v8352:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            string("true; v8348 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                        let v8353:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; v8348 });  // rust.fix_closure';
                                                                                                                                                                                                                                                        let v8355 =
                                                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                                                        let v8357:
                                                                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                                                            v8355;
                                                                                                                                                                                                                                                        let v8360:
                                                                                                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                                                                                                            Spiral_wasm::method49(v8357.await);
                                                                                                                                                                                                                                                        let v8362:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            string("true; v8360 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                        let v8363:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; v8360 });  // rust.fix_closure';
                                                                                                                                                                                                                                                        let v8365 =
                                                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                                                        v8365
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                            Spiral_wasm::US6::US6_1(v8342_1_0)
                                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                let v8513:
                                                                                                                                                                                                                                                        () =
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        Spiral_wasm::closure56(v8342_1_0.clone(),
                                                                                                                                                                                                                                                                               ());
                                                                                                                                                                                                                                                        ()
                                                                                                                                                                                                                                                    };
                                                                                                                                                                                                                                                let v8627:
                                                                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                                                                                  anyhow::Error>>>> =
                                                                                                                                                                                                                                                    Spiral_wasm::method24(v167.clone(),
                                                                                                                                                                                                                                                                          29_u8);
                                                                                                                                                                                                                                                let v8629:
                                                                                                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                               anyhow::Error> =
                                                                                                                                                                                                                                                    v8627.await;
                                                                                                                                                                                                                                                let v8630 =
                                                                                                                                                                                                                                                    Spiral_wasm::method42();
                                                                                                                                                                                                                                                let v8641:
                                                                                                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                               std::string::String> =
                                                                                                                                                                                                                                                    v8629.map_err(|x| v8630(x));
                                                                                                                                                                                                                                                let v8644:
                                                                                                                                                                                                                                                        Spiral_wasm::US6 =
                                                                                                                                                                                                                                                    match &v8641
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                        Err(v8641_1_0)
                                                                                                                                                                                                                                                        =>
                                                                                                                                                                                                                                                        v187(v8641_1_0.clone()),
                                                                                                                                                                                                                                                        Ok(v8641_0_0)
                                                                                                                                                                                                                                                        =>
                                                                                                                                                                                                                                                        v186(v8641_0_0.clone()),
                                                                                                                                                                                                                                                    };
                                                                                                                                                                                                                                                match &v8644
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    Spiral_wasm::US6::US6_0(v8644_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        let v8645:
                                                                                                                                                                                                                                                                Spiral_wasm::US4 =
                                                                                                                                                                                                                                                            v8644_0_0.clone();
                                                                                                                                                                                                                                                        match &v8645
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                            Spiral_wasm::US4::US4_0(v8645_0_0)
                                                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                let v8673:
                                                                                                                                                                                                                                                                        () =
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        Spiral_wasm::closure58(match &v8645
                                                                                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                                                                                   Spiral_wasm::US4::US4_0(x)
                                                                                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                                                                                   x.clone(),
                                                                                                                                                                                                                                                                                                   _
                                                                                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                                                                                   unreachable!(),
                                                                                                                                                                                                                                                                                               },
                                                                                                                                                                                                                                                                                               ());
                                                                                                                                                                                                                                                                        ()
                                                                                                                                                                                                                                                                    };
                                                                                                                                                                                                                                                                let v8787:
                                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                                let v8789:
                                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                                let v8790:
                                                                                                                                                                                                                                                                        u8 =
                                                                                                                                                                                                                                                                    Spiral_wasm::method48();
                                                                                                                                                                                                                                                                let v8794:
                                                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                                                    string("true; v8790 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                                let v8795:
                                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                                    true; v8790 });  // rust.fix_closure';
                                                                                                                                                                                                                                                                let v8797 =
                                                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                                                let v8799:
                                                                                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                                                                    v8797;
                                                                                                                                                                                                                                                                let v8802:
                                                                                                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                                                                                                    Spiral_wasm::method47(v8799.await);
                                                                                                                                                                                                                                                                let v8804:
                                                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                                                    string("true; v8802 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                                let v8805:
                                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                                    true; v8802 });  // rust.fix_closure';
                                                                                                                                                                                                                                                                let v8807 =
                                                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                                                v8807
                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                            _
                                                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                let v8647:
                                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                                let v8649:
                                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                                let v8650:
                                                                                                                                                                                                                                                                        u8 =
                                                                                                                                                                                                                                                                    Spiral_wasm::method48();
                                                                                                                                                                                                                                                                let v8654:
                                                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                                                    string("true; v8650 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                                let v8655:
                                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                                    true; v8650 });  // rust.fix_closure';
                                                                                                                                                                                                                                                                let v8657 =
                                                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                                                let v8659:
                                                                                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                                                                    v8657;
                                                                                                                                                                                                                                                                let v8662:
                                                                                                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                                                                                                    Spiral_wasm::method49(v8659.await);
                                                                                                                                                                                                                                                                let v8664:
                                                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                                                    string("true; v8662 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                                let v8665:
                                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                                    true; v8662 });  // rust.fix_closure';
                                                                                                                                                                                                                                                                let v8667 =
                                                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                                                v8667
                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                    Spiral_wasm::US6::US6_1(v8644_1_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        let v8815:
                                                                                                                                                                                                                                                                () =
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                Spiral_wasm::closure57(v8644_1_0.clone(),
                                                                                                                                                                                                                                                                                       ());
                                                                                                                                                                                                                                                                ()
                                                                                                                                                                                                                                                            };
                                                                                                                                                                                                                                                        let v8929:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                        let v8931:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                        let v8932:
                                                                                                                                                                                                                                                                u8 =
                                                                                                                                                                                                                                                            Spiral_wasm::method46();
                                                                                                                                                                                                                                                        let v8936:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            string("true; v8932 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                        let v8937:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; v8932 });  // rust.fix_closure';
                                                                                                                                                                                                                                                        let v8939 =
                                                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                                                        let v8941:
                                                                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                                                            v8939;
                                                                                                                                                                                                                                                        let v8944:
                                                                                                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                                                                                                            Spiral_wasm::method47(v8941.await);
                                                                                                                                                                                                                                                        let v8946:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            string("true; v8944 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                        let v8947:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; v8944 });  // rust.fix_closure';
                                                                                                                                                                                                                                                        let v8949 =
                                                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                                                        v8949
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
                                        }
                                    }
                                }
                            }
                        }
                    };
                let v9011: Spiral_wasm::US7 = v9009.await;
                let v9014: () = {
                    Spiral_wasm::closure87(v9011.clone(), ());
                    ()
                };
                let v9147: Result<u8, anyhow::Error> = Spiral_wasm::method83(match &v9011 {
                    Spiral_wasm::US7::US7_0(v9011_0_0) => {
                        Ok::<u8, anyhow::Error>(v9011_0_0.clone())
                    }
                    Spiral_wasm::US7::US7_1(v9011_1_0) => {
                        let v9129: string = Spiral_wasm::method82(v9011_1_0.clone());
                        let v9131: anyhow::Error = anyhow::anyhow!(v9129);
                        Err(v9131)
                    }
                });
                let v9151: string = string("true; v9147 });  // rust.fix_closure\'");
                let v9152: bool = true;
                v9147
            }); // rust.fix_closure';
            let v9154 = __future_init;
            v9154
        }
        pub fn closure88(unitVar: (), v0_1: u8) -> Spiral_wasm::US8 {
            Spiral_wasm::US8::US8_0(v0_1)
        }
        pub fn method84() -> Func1<u8, Spiral_wasm::US8> {
            Func1::new(move |v: u8| Spiral_wasm::closure88((), v))
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
            let v259: string = Spiral_wasm::method19();
            let v262: &str = &*v259;
            let v282: bool = clap::ArgMatches::get_flag(&v3.clone(), v262);
            let v283: std::pin::Pin<
                Box<dyn std::future::Future<Output = Result<u8, anyhow::Error>>>,
            > = Spiral_wasm::method20(v3);
            let v285 = tokio::runtime::Builder::new_multi_thread()
                .enable_all()
                .build()
                .unwrap();
            let v287: Result<u8, anyhow::Error> = v285.handle().block_on(v283);
            let v288 = Spiral_wasm::method42();
            let v299: Result<u8, std::string::String> = v287.map_err(|x| v288(x));
            let v304: Option<u8> = v299.clone().ok();
            let v328: Spiral_wasm::US8 =
                defaultValue(Spiral_wasm::US8::US8_1, map(Spiral_wasm::method84(), v304));
            match &v328 {
                Spiral_wasm::US8::US8_0(v328_0_0) => {
                    if v282 {
                        let v336: Result<(), string> =
                            Err(string("spiral_wasm.main / exception=true"));
                        v336.unwrap();
                        ();
                        ()
                    }
                }
                _ => {
                    if v282 {
                        ()
                    } else {
                        let v353: u8 = v299.unwrap();
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
