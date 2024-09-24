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
                    let v67: &str = &*v65;
                    let v69: std::string::String = String::from(v67);
                    let v71: Box<std::string::String> = Box::new(v69);
                    let v73: &'static mut std::string::String = Box::leak(v71);
                    let v75: clap::builder::PossibleValue =
                        clap::builder::PossibleValue::new(&**v73);
                    let v77: bool = true;
                    v75
                })
                .collect::<Vec<_>>();
            let v79: Vec<clap::builder::PossibleValue> = _vec_map;
            let v81: clap::builder::ValueParser = Into::<clap::builder::ValueParser>::into(
                clap::builder::PossibleValuesParser::new(v79),
            );
            let v83: clap::Arg = v34.value_parser(v81);
            let v85: clap::Command = clap::Command::arg(v23, v83);
            let v87: string = string("r#\"wasm\"#");
            let v88: &'static str = r#"wasm"#;
            let v90: clap::Arg = clap::Arg::new(v88);
            let v92: clap::Arg = v90.short('w');
            let v93: string = string("r#\"wasm\"#");
            let v94: &'static str = r#"wasm"#;
            let v96: clap::Arg = v92.long(v94);
            let v98: clap::Arg = v96.required(true);
            clap::Command::arg(v85, v98)
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
            let v295: Spiral_wasm::US5 = _v1.1.clone();
            let v294: Spiral_wasm::US2 = _v1.0.clone();
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
                    l0: MutCell::new(match &v294 {
                        Spiral_wasm::US2::US2_0(v294_0_0) => match &v294 {
                            Spiral_wasm::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0_1,
                    }),
                }),
                match &v295 {
                    Spiral_wasm::US5::US5_0(v295_0_0) => Some(match &v295 {
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
            let v23: &str = &*v5;
            let v25: &str = inline_colorization::color_reset;
            let v27: std::string::String = format!("{}{}{}", v21, v23, v25);
            fable_library_rust::String_::fromString(v27)
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
            let v23: &str = &*v5;
            let v25: &str = inline_colorization::color_reset;
            let v27: std::string::String = format!("{}{}{}", v21, v23, v25);
            fable_library_rust::String_::fromString(v27)
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
                        let v372: std::string::String = String::from(v370);
                        let v374: bool = true;
                        v372
                    })
                    .collect::<Vec<_>>();
                let v376: Vec<std::string::String> = _vec_map;
                let v379: bool = true;
                v376.iter().for_each(|x| {
                    Func1::new(move |v: std::string::String| Spiral_wasm::closure16((), v))(
                        x.clone(),
                    );
                }); //;
                let v381: near_workspaces::types::Gas = v250.clone().total_gas_burnt;
                let v383: u64 = v381.as_gas();
                let v390: () = {
                    Spiral_wasm::closure18(
                        v1,
                        v383,
                        v383 as f64 / 10000000000000000.0_f64 * 6.68_f64,
                        (),
                    );
                    ()
                };
                let v503: near_workspaces::result::ExecutionFinalResult = v250.clone();
                let v505: Vec<&near_workspaces::result::ExecutionOutcome> = v503.outcomes();
                let v507 = v505.into_iter();
                let v509 = v507.cloned();
                let v512: bool = true;
                v509.for_each(|x| {
                    Func1::new(move |v_1: near_workspaces::result::ExecutionOutcome| {
                        Spiral_wasm::closure19((), v_1)
                    })(x)
                });
                let v517: () = {
                    Spiral_wasm::closure21(v250.clone().into_result(), ());
                    ()
                };
                let v629: near_workspaces::result::ExecutionFinalResult =
                    Spiral_wasm::method34(v250.clone());
                let v631: Vec<&near_workspaces::result::ExecutionOutcome> = v629.receipt_failures();
                let v635: i32 = v631.clone().len() as i32;
                let v638: () = {
                    Spiral_wasm::closure22(v631.clone(), v635, ());
                    ()
                };
                let v750: near_workspaces::result::ExecutionFinalResult =
                    Spiral_wasm::method36(v250.clone());
                let v752: &[near_workspaces::result::ExecutionOutcome] = v750.receipt_outcomes();
                let v754: Vec<near_workspaces::result::ExecutionOutcome> = v752.into();
                let v758: i32 = v754.clone().len() as i32;
                let v761: () = {
                    Spiral_wasm::closure23(v754, v758, ());
                    ()
                };
                let v877: () = {
                    Spiral_wasm::closure24(v250.clone().json(), ());
                    ()
                };
                let v993: () = {
                    Spiral_wasm::closure25(v250.borsh(), ());
                    ()
                };
                let v1105: string = Spiral_wasm::method40(v631, v758, v1);
                let v1118: Result<Spiral_wasm::US4, anyhow::Error> =
                    Spiral_wasm::method41(if v635 > 0_i32 {
                        Ok::<Spiral_wasm::US4, anyhow::Error>(Spiral_wasm::US4::US4_0(
                            v1105.clone(),
                        ))
                    } else {
                        if v758 > 1_i32 {
                            Ok::<Spiral_wasm::US4, anyhow::Error>(Spiral_wasm::US4::US4_1)
                        } else {
                            let v1113: anyhow::Error = anyhow::anyhow!(v1105);
                            Err(v1113)
                        }
                    });
                let v1122: string = string("true; v1118 });  // rust.fix_closure\'");
                let v1123: bool = true;
                v1118
            }); // rust.fix_closure';
            let v1125 = __future_init;
            v1125
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
            let v23: &str = &*v5;
            let v25: &str = inline_colorization::color_reset;
            let v27: std::string::String = format!("{}{}{}", v21, v23, v25);
            fable_library_rust::String_::fromString(v27)
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
            let v23: &str = &*v5;
            let v25: &str = inline_colorization::color_reset;
            let v27: std::string::String = format!("{}{}{}", v21, v23, v25);
            fable_library_rust::String_::fromString(v27)
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
                let v5: &str = &*v3;
                let v7: Option<std::string::String> = clap::ArgMatches::get_one(&v0_1, v5).cloned();
                let v21: Spiral_wasm::US0 =
                    defaultValue(Spiral_wasm::US0::US0_1, map(Spiral_wasm::method2(), v7));
                let v28: std::string::String = match &v21 {
                    Spiral_wasm::US0::US0_0(v21_0_0) => match &v21 {
                        Spiral_wasm::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                };
                let v30: string = fable_library_rust::String_::fromString(v28);
                let v33: () = {
                    Spiral_wasm::closure12(v30.clone(), ());
                    ()
                };
                let v146: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v30);
                let v148: Vec<u8> = v146?;
                let v150: std::pin::Pin<
                    Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4, anyhow::Error>>>,
                > = Spiral_wasm::method24(v148.clone(), 1_u8);
                let v152: Result<Spiral_wasm::US4, anyhow::Error> = v150.await;
                let v153 = Spiral_wasm::method42();
                let v155: Result<Spiral_wasm::US4, std::string::String> = v152.map_err(|x| v153(x));
                fn v156(v: Spiral_wasm::US4) -> Spiral_wasm::US6 {
                    Spiral_wasm::closure27((), v)
                }
                fn v157(v_1: std::string::String) -> Spiral_wasm::US6 {
                    Spiral_wasm::closure28((), v_1)
                }
                let v158: Spiral_wasm::US6 = match &v155 {
                    Err(v155_1_0) => v157(v155_1_0.clone()),
                    Ok(v155_0_0) => v156(v155_0_0.clone()),
                };
                let v8671: std::pin::Pin<Box<dyn std::future::Future<Output = Spiral_wasm::US7>>> =
                    match &v158 {
                        Spiral_wasm::US6::US6_0(v158_0_0) => {
                            let v159: Spiral_wasm::US4 = v158_0_0.clone();
                            match &v159 {
                                Spiral_wasm::US4::US4_0(v159_0_0) => {
                                    let v187: () = {
                                        Spiral_wasm::closure86(
                                            match &v159 {
                                                Spiral_wasm::US4::US4_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            (),
                                        );
                                        ()
                                    };
                                    let v301: bool = true;
                                    let __future_init = Box::pin(async move {
                                        //;
                                        let v303: bool = true;
                                        let __future_init = Box::pin(async move {
                                            //;
                                            let v304: u8 = Spiral_wasm::method80();
                                            let v308: string =
                                                string("true; v304 });  // rust.fix_closure\'");
                                            let v309: bool = true;
                                            v304
                                        }); // rust.fix_closure';
                                        let v311 = __future_init;
                                        let v313: std::pin::Pin<
                                            Box<dyn std::future::Future<Output = u8>>,
                                        > = v311;
                                        let v316: Spiral_wasm::US7 =
                                            Spiral_wasm::method47(v313.await);
                                        let v318: string =
                                            string("true; v316 });  // rust.fix_closure\'");
                                        let v319: bool = true;
                                        v316
                                    }); // rust.fix_closure';
                                    let v321 = __future_init;
                                    v321
                                }
                                _ => {
                                    let v161: bool = true;
                                    let __future_init = Box::pin(async move {
                                        //;
                                        let v163: bool = true;
                                        let __future_init = Box::pin(async move {
                                            //;
                                            let v164: u8 = Spiral_wasm::method80();
                                            let v168: string =
                                                string("true; v164 });  // rust.fix_closure\'");
                                            let v169: bool = true;
                                            v164
                                        }); // rust.fix_closure';
                                        let v171 = __future_init;
                                        let v173: std::pin::Pin<
                                            Box<dyn std::future::Future<Output = u8>>,
                                        > = v171;
                                        let v176: Spiral_wasm::US7 =
                                            Spiral_wasm::method49(v173.await);
                                        let v178: string =
                                            string("true; v176 });  // rust.fix_closure\'");
                                        let v179: bool = true;
                                        v176
                                    }); // rust.fix_closure';
                                    let v181 = __future_init;
                                    v181
                                }
                            }
                        }
                        Spiral_wasm::US6::US6_1(v158_1_0) => {
                            let v329: () = {
                                Spiral_wasm::closure29(v158_1_0.clone(), ());
                                ()
                            };
                            let v443: std::pin::Pin<
                                Box<
                                    dyn std::future::Future<
                                        Output = Result<Spiral_wasm::US4, anyhow::Error>,
                                    >,
                                >,
                            > = Spiral_wasm::method24(v148.clone(), 2_u8);
                            let v445: Result<Spiral_wasm::US4, anyhow::Error> = v443.await;
                            let v446 = Spiral_wasm::method42();
                            let v448: Result<Spiral_wasm::US4, std::string::String> =
                                v445.map_err(|x| v446(x));
                            let v449: Spiral_wasm::US6 = match &v448 {
                                Err(v448_1_0) => v157(v448_1_0.clone()),
                                Ok(v448_0_0) => v156(v448_0_0.clone()),
                            };
                            match &v449 {
                                Spiral_wasm::US6::US6_0(v449_0_0) => {
                                    let v450: Spiral_wasm::US4 = v449_0_0.clone();
                                    match &v450 {
                                        Spiral_wasm::US4::US4_0(v450_0_0) => {
                                            let v478: () = {
                                                Spiral_wasm::closure85(
                                                    match &v450 {
                                                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    },
                                                    (),
                                                );
                                                ()
                                            };
                                            let v592: bool = true;
                                            let __future_init = Box::pin(async move {
                                                //;
                                                let v594: bool = true;
                                                let __future_init = Box::pin(async move {
                                                    //;
                                                    let v595: u8 = Spiral_wasm::method79();
                                                    let v599: string = string(
                                                        "true; v595 });  // rust.fix_closure\'",
                                                    );
                                                    let v600: bool = true;
                                                    v595
                                                }); // rust.fix_closure';
                                                let v602 = __future_init;
                                                let v604: std::pin::Pin<
                                                    Box<dyn std::future::Future<Output = u8>>,
                                                > = v602;
                                                let v607: Spiral_wasm::US7 =
                                                    Spiral_wasm::method47(v604.await);
                                                let v609: string =
                                                    string("true; v607 });  // rust.fix_closure\'");
                                                let v610: bool = true;
                                                v607
                                            }); // rust.fix_closure';
                                            let v612 = __future_init;
                                            v612
                                        }
                                        _ => {
                                            let v452: bool = true;
                                            let __future_init = Box::pin(async move {
                                                //;
                                                let v454: bool = true;
                                                let __future_init = Box::pin(async move {
                                                    //;
                                                    let v455: u8 = Spiral_wasm::method79();
                                                    let v459: string = string(
                                                        "true; v455 });  // rust.fix_closure\'",
                                                    );
                                                    let v460: bool = true;
                                                    v455
                                                }); // rust.fix_closure';
                                                let v462 = __future_init;
                                                let v464: std::pin::Pin<
                                                    Box<dyn std::future::Future<Output = u8>>,
                                                > = v462;
                                                let v467: Spiral_wasm::US7 =
                                                    Spiral_wasm::method49(v464.await);
                                                let v469: string =
                                                    string("true; v467 });  // rust.fix_closure\'");
                                                let v470: bool = true;
                                                v467
                                            }); // rust.fix_closure';
                                            let v472 = __future_init;
                                            v472
                                        }
                                    }
                                }
                                Spiral_wasm::US6::US6_1(v449_1_0) => {
                                    let v620: () = {
                                        Spiral_wasm::closure30(v449_1_0.clone(), ());
                                        ()
                                    };
                                    let v734: std::pin::Pin<
                                        Box<
                                            dyn std::future::Future<
                                                Output = Result<Spiral_wasm::US4, anyhow::Error>,
                                            >,
                                        >,
                                    > = Spiral_wasm::method24(v148.clone(), 3_u8);
                                    let v736: Result<Spiral_wasm::US4, anyhow::Error> = v734.await;
                                    let v737 = Spiral_wasm::method42();
                                    let v739: Result<Spiral_wasm::US4, std::string::String> =
                                        v736.map_err(|x| v737(x));
                                    let v740: Spiral_wasm::US6 = match &v739 {
                                        Err(v739_1_0) => v157(v739_1_0.clone()),
                                        Ok(v739_0_0) => v156(v739_0_0.clone()),
                                    };
                                    match &v740 {
                                        Spiral_wasm::US6::US6_0(v740_0_0) => {
                                            let v741: Spiral_wasm::US4 = v740_0_0.clone();
                                            match &v741 {
                                                Spiral_wasm::US4::US4_0(v741_0_0) => {
                                                    let v769: () = {
                                                        Spiral_wasm::closure84(
                                                            match &v741 {
                                                                Spiral_wasm::US4::US4_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            },
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    let v883: bool = true;
                                                    let __future_init = Box::pin(async move {
                                                        //;
                                                        let v885: bool = true;
                                                        let __future_init = Box::pin(async move {
                                                            //;
                                                            let v886: u8 = Spiral_wasm::method78();
                                                            let v890: string =
                                                    string("true; v886 });  // rust.fix_closure\'");
                                                            let v891: bool = true;
                                                            v886
                                                        }); // rust.fix_closure';
                                                        let v893 = __future_init;
                                                        let v895: std::pin::Pin<
                                                            Box<
                                                                dyn std::future::Future<
                                                                    Output = u8,
                                                                >,
                                                            >,
                                                        > = v893;
                                                        let v898: Spiral_wasm::US7 =
                                                            Spiral_wasm::method47(v895.await);
                                                        let v900: string = string(
                                                            "true; v898 });  // rust.fix_closure\'",
                                                        );
                                                        let v901: bool = true;
                                                        v898
                                                    }); // rust.fix_closure';
                                                    let v903 = __future_init;
                                                    v903
                                                }
                                                _ => {
                                                    let v743: bool = true;
                                                    let __future_init = Box::pin(async move {
                                                        //;
                                                        let v745: bool = true;
                                                        let __future_init = Box::pin(async move {
                                                            //;
                                                            let v746: u8 = Spiral_wasm::method78();
                                                            let v750: string =
                                                    string("true; v746 });  // rust.fix_closure\'");
                                                            let v751: bool = true;
                                                            v746
                                                        }); // rust.fix_closure';
                                                        let v753 = __future_init;
                                                        let v755: std::pin::Pin<
                                                            Box<
                                                                dyn std::future::Future<
                                                                    Output = u8,
                                                                >,
                                                            >,
                                                        > = v753;
                                                        let v758: Spiral_wasm::US7 =
                                                            Spiral_wasm::method49(v755.await);
                                                        let v760: string = string(
                                                            "true; v758 });  // rust.fix_closure\'",
                                                        );
                                                        let v761: bool = true;
                                                        v758
                                                    }); // rust.fix_closure';
                                                    let v763 = __future_init;
                                                    v763
                                                }
                                            }
                                        }
                                        Spiral_wasm::US6::US6_1(v740_1_0) => {
                                            let v911: () = {
                                                Spiral_wasm::closure31(v740_1_0.clone(), ());
                                                ()
                                            };
                                            let v1025: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = Result<
                                                            Spiral_wasm::US4,
                                                            anyhow::Error,
                                                        >,
                                                    >,
                                                >,
                                            > = Spiral_wasm::method24(v148.clone(), 4_u8);
                                            let v1027: Result<Spiral_wasm::US4, anyhow::Error> =
                                                v1025.await;
                                            let v1028 = Spiral_wasm::method42();
                                            let v1030: Result<
                                                Spiral_wasm::US4,
                                                std::string::String,
                                            > = v1027.map_err(|x| v1028(x));
                                            let v1031: Spiral_wasm::US6 = match &v1030 {
                                                Err(v1030_1_0) => v157(v1030_1_0.clone()),
                                                Ok(v1030_0_0) => v156(v1030_0_0.clone()),
                                            };
                                            match &v1031 {
                                                Spiral_wasm::US6::US6_0(v1031_0_0) => {
                                                    let v1032: Spiral_wasm::US4 = v1031_0_0.clone();
                                                    match &v1032 {
                                                        Spiral_wasm::US4::US4_0(v1032_0_0) => {
                                                            let v1060: () = {
                                                                Spiral_wasm::closure83(
                                                                    match &v1032 {
                                                                        Spiral_wasm::US4::US4_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    },
                                                                    (),
                                                                );
                                                                ()
                                                            };
                                                            let v1174: bool = true;
                                                            let __future_init = Box::pin(
                                                                async move {
                                                                    //;
                                                                    let v1176: bool = true;
                                                                    let __future_init = Box::pin(
                                                                        async move {
                                                                            //;
                                                                            let v1177: u8 =
                                                            Spiral_wasm::method77();
                                                                            let v1181: string =
                                                            string("true; v1177 });  // rust.fix_closure\'");
                                                                            let v1182: bool = true;
                                                                            v1177
                                                                        },
                                                                    ); // rust.fix_closure';
                                                                    let v1184 = __future_init;
                                                                    let v1186: std::pin::Pin<
                                                                        Box<
                                                                            dyn std::future::Future<
                                                                                Output = u8,
                                                                            >,
                                                                        >,
                                                                    > = v1184;
                                                                    let v1189: Spiral_wasm::US7 =
                                                                        Spiral_wasm::method47(
                                                                            v1186.await,
                                                                        );
                                                                    let v1191: string =
                                                            string("true; v1189 });  // rust.fix_closure\'");
                                                                    let v1192: bool = true;
                                                                    v1189
                                                                },
                                                            ); // rust.fix_closure';
                                                            let v1194 = __future_init;
                                                            v1194
                                                        }
                                                        _ => {
                                                            let v1034: bool = true;
                                                            let __future_init = Box::pin(
                                                                async move {
                                                                    //;
                                                                    let v1036: bool = true;
                                                                    let __future_init = Box::pin(
                                                                        async move {
                                                                            //;
                                                                            let v1037: u8 =
                                                            Spiral_wasm::method77();
                                                                            let v1041: string =
                                                            string("true; v1037 });  // rust.fix_closure\'");
                                                                            let v1042: bool = true;
                                                                            v1037
                                                                        },
                                                                    ); // rust.fix_closure';
                                                                    let v1044 = __future_init;
                                                                    let v1046: std::pin::Pin<
                                                                        Box<
                                                                            dyn std::future::Future<
                                                                                Output = u8,
                                                                            >,
                                                                        >,
                                                                    > = v1044;
                                                                    let v1049: Spiral_wasm::US7 =
                                                                        Spiral_wasm::method49(
                                                                            v1046.await,
                                                                        );
                                                                    let v1051: string =
                                                            string("true; v1049 });  // rust.fix_closure\'");
                                                                    let v1052: bool = true;
                                                                    v1049
                                                                },
                                                            ); // rust.fix_closure';
                                                            let v1054 = __future_init;
                                                            v1054
                                                        }
                                                    }
                                                }
                                                Spiral_wasm::US6::US6_1(v1031_1_0) => {
                                                    let v1202: () = {
                                                        Spiral_wasm::closure32(
                                                            v1031_1_0.clone(),
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    let v1316: std::pin::Pin<
                                                        Box<
                                                            dyn std::future::Future<
                                                                Output = Result<
                                                                    Spiral_wasm::US4,
                                                                    anyhow::Error,
                                                                >,
                                                            >,
                                                        >,
                                                    > = Spiral_wasm::method24(v148.clone(), 5_u8);
                                                    let v1318: Result<
                                                        Spiral_wasm::US4,
                                                        anyhow::Error,
                                                    > = v1316.await;
                                                    let v1319 = Spiral_wasm::method42();
                                                    let v1321: Result<
                                                        Spiral_wasm::US4,
                                                        std::string::String,
                                                    > = v1318.map_err(|x| v1319(x));
                                                    let v1322: Spiral_wasm::US6 = match &v1321 {
                                                        Err(v1321_1_0) => v157(v1321_1_0.clone()),
                                                        Ok(v1321_0_0) => v156(v1321_0_0.clone()),
                                                    };
                                                    match &v1322 {
                                                        Spiral_wasm::US6::US6_0(v1322_0_0) => {
                                                            let v1323: Spiral_wasm::US4 =
                                                                v1322_0_0.clone();
                                                            match &v1323 {
                                                                Spiral_wasm::US4::US4_0(
                                                                    v1323_0_0,
                                                                ) => {
                                                                    let v1351: () = {
                                                                        Spiral_wasm::closure82(match &v1323
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
                                                                    let v1465: bool = true;
                                                                    let __future_init = Box::pin(
                                                                        async move {
                                                                            //;
                                                                            let v1467: bool = true;
                                                                            let __future_init =
                                                                                Box::pin(
                                                                                    async move {
                                                                                        //;
                                                                                        let v1468:
                                                                        u8 =
                                                                    Spiral_wasm::method76();
                                                                                        let v1472:
                                                                        string =
                                                                    string("true; v1468 });  // rust.fix_closure\'");
                                                                                        let v1473:
                                                                        bool =
                                                                    true;
                                                                                        v1468
                                                                                    },
                                                                                ); // rust.fix_closure';
                                                                            let v1475 =
                                                                                __future_init;
                                                                            let v1477:
                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                    v1475;
                                                                            let v1480:
                                                                        Spiral_wasm::US7 =
                                                                    Spiral_wasm::method47(v1477.await);
                                                                            let v1482:
                                                                        string =
                                                                    string("true; v1480 });  // rust.fix_closure\'");
                                                                            let v1483: bool = true;
                                                                            v1480
                                                                        },
                                                                    ); // rust.fix_closure';
                                                                    let v1485 = __future_init;
                                                                    v1485
                                                                }
                                                                _ => {
                                                                    let v1325: bool = true;
                                                                    let __future_init = Box::pin(
                                                                        async move {
                                                                            //;
                                                                            let v1327: bool = true;
                                                                            let __future_init =
                                                                                Box::pin(
                                                                                    async move {
                                                                                        //;
                                                                                        let v1328:
                                                                        u8 =
                                                                    Spiral_wasm::method76();
                                                                                        let v1332:
                                                                        string =
                                                                    string("true; v1328 });  // rust.fix_closure\'");
                                                                                        let v1333:
                                                                        bool =
                                                                    true;
                                                                                        v1328
                                                                                    },
                                                                                ); // rust.fix_closure';
                                                                            let v1335 =
                                                                                __future_init;
                                                                            let v1337:
                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                    v1335;
                                                                            let v1340:
                                                                        Spiral_wasm::US7 =
                                                                    Spiral_wasm::method49(v1337.await);
                                                                            let v1342:
                                                                        string =
                                                                    string("true; v1340 });  // rust.fix_closure\'");
                                                                            let v1343: bool = true;
                                                                            v1340
                                                                        },
                                                                    ); // rust.fix_closure';
                                                                    let v1345 = __future_init;
                                                                    v1345
                                                                }
                                                            }
                                                        }
                                                        Spiral_wasm::US6::US6_1(v1322_1_0) => {
                                                            let v1493: () = {
                                                                Spiral_wasm::closure33(
                                                                    v1322_1_0.clone(),
                                                                    (),
                                                                );
                                                                ()
                                                            };
                                                            let v1607: std::pin::Pin<
                                                                Box<
                                                                    dyn std::future::Future<
                                                                        Output = Result<
                                                                            Spiral_wasm::US4,
                                                                            anyhow::Error,
                                                                        >,
                                                                    >,
                                                                >,
                                                            > = Spiral_wasm::method24(
                                                                v148.clone(),
                                                                6_u8,
                                                            );
                                                            let v1609: Result<
                                                                Spiral_wasm::US4,
                                                                anyhow::Error,
                                                            > = v1607.await;
                                                            let v1610 = Spiral_wasm::method42();
                                                            let v1612: Result<
                                                                Spiral_wasm::US4,
                                                                std::string::String,
                                                            > = v1609.map_err(|x| v1610(x));
                                                            let v1613: Spiral_wasm::US6 =
                                                                match &v1612 {
                                                                    Err(v1612_1_0) => {
                                                                        v157(v1612_1_0.clone())
                                                                    }
                                                                    Ok(v1612_0_0) => {
                                                                        v156(v1612_0_0.clone())
                                                                    }
                                                                };
                                                            match &v1613 {
                                                                Spiral_wasm::US6::US6_0(
                                                                    v1613_0_0,
                                                                ) => {
                                                                    let v1614: Spiral_wasm::US4 =
                                                                        v1613_0_0.clone();
                                                                    match &v1614 {
                                                                        Spiral_wasm::US4::US4_0(
                                                                            v1614_0_0,
                                                                        ) => {
                                                                            let v1642: () = {
                                                                                Spiral_wasm::closure81(match &v1614
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
                                                                            let v1756: bool = true;
                                                                            let __future_init =
                                                                                Box::pin(
                                                                                    async move {
                                                                                        //;
                                                                                        let v1758:
                                                                                bool =
                                                                            true;
                                                                                        let __future_init =
                                                                                            Box::pin(
                                                                                                async move {
                                                                                                    //;
                                                                                                    let v1759:
                                                                                u8 =
                                                                            Spiral_wasm::method75();
                                                                                                    let v1763:
                                                                                string =
                                                                            string("true; v1759 });  // rust.fix_closure\'");
                                                                                                    let v1764:
                                                                                bool =
                                                                            true;
                                                                                                    v1759
                                                                                                },
                                                                                            ); // rust.fix_closure';
                                                                                        let v1766 =
                                                                            __future_init;
                                                                                        let v1768:
                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                            v1766;
                                                                                        let v1771:
                                                                                Spiral_wasm::US7 =
                                                                            Spiral_wasm::method47(v1768.await);
                                                                                        let v1773:
                                                                                string =
                                                                            string("true; v1771 });  // rust.fix_closure\'");
                                                                                        let v1774:
                                                                                bool =
                                                                            true;
                                                                                        v1771
                                                                                    },
                                                                                ); // rust.fix_closure';
                                                                            let v1776 =
                                                                                __future_init;
                                                                            v1776
                                                                        }
                                                                        _ => {
                                                                            let v1616: bool = true;
                                                                            let __future_init =
                                                                                Box::pin(
                                                                                    async move {
                                                                                        //;
                                                                                        let v1618:
                                                                                bool =
                                                                            true;
                                                                                        let __future_init =
                                                                                            Box::pin(
                                                                                                async move {
                                                                                                    //;
                                                                                                    let v1619:
                                                                                u8 =
                                                                            Spiral_wasm::method75();
                                                                                                    let v1623:
                                                                                string =
                                                                            string("true; v1619 });  // rust.fix_closure\'");
                                                                                                    let v1624:
                                                                                bool =
                                                                            true;
                                                                                                    v1619
                                                                                                },
                                                                                            ); // rust.fix_closure';
                                                                                        let v1626 =
                                                                            __future_init;
                                                                                        let v1628:
                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                            v1626;
                                                                                        let v1631:
                                                                                Spiral_wasm::US7 =
                                                                            Spiral_wasm::method49(v1628.await);
                                                                                        let v1633:
                                                                                string =
                                                                            string("true; v1631 });  // rust.fix_closure\'");
                                                                                        let v1634:
                                                                                bool =
                                                                            true;
                                                                                        v1631
                                                                                    },
                                                                                ); // rust.fix_closure';
                                                                            let v1636 =
                                                                                __future_init;
                                                                            v1636
                                                                        }
                                                                    }
                                                                }
                                                                Spiral_wasm::US6::US6_1(
                                                                    v1613_1_0,
                                                                ) => {
                                                                    let v1784: () = {
                                                                        Spiral_wasm::closure34(
                                                                            v1613_1_0.clone(),
                                                                            (),
                                                                        );
                                                                        ()
                                                                    };
                                                                    let v1898:
                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                  anyhow::Error>>>> =
                                                                    Spiral_wasm::method24(v148.clone(),
                                                                                          7_u8);
                                                                    let v1900: Result<
                                                                        Spiral_wasm::US4,
                                                                        anyhow::Error,
                                                                    > = v1898.await;
                                                                    let v1901 =
                                                                        Spiral_wasm::method42();
                                                                    let v1903: Result<
                                                                        Spiral_wasm::US4,
                                                                        std::string::String,
                                                                    > = v1900.map_err(|x| v1901(x));
                                                                    let v1904: Spiral_wasm::US6 =
                                                                        match &v1903 {
                                                                            Err(v1903_1_0) => v157(
                                                                                v1903_1_0.clone(),
                                                                            ),
                                                                            Ok(v1903_0_0) => v156(
                                                                                v1903_0_0.clone(),
                                                                            ),
                                                                        };
                                                                    match &v1904 {
                                                                        Spiral_wasm::US6::US6_0(
                                                                            v1904_0_0,
                                                                        ) => {
                                                                            let v1905:
                                                                                Spiral_wasm::US4 =
                                                                            v1904_0_0.clone();
                                                                            match &v1905
                                                                            {
                                                                            Spiral_wasm::US4::US4_0(v1905_0_0)
                                                                            =>
                                                                            {
                                                                                let v1933:
                                                                                        () =
                                                                                    {
                                                                                        Spiral_wasm::closure80(match &v1905
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
                                                                                let v2047:
                                                                                        bool =
                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                let v2049:
                                                                                        bool =
                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                let v2050:
                                                                                        u8 =
                                                                                    Spiral_wasm::method74();
                                                                                let v2054:
                                                                                        string =
                                                                                    string("true; v2050 });  // rust.fix_closure\'");
                                                                                let v2055:
                                                                                        bool =
                                                                                    true; v2050 });  // rust.fix_closure';
                                                                                let v2057 =
                                                                                    __future_init;
                                                                                let v2059:
                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                    v2057;
                                                                                let v2062:
                                                                                        Spiral_wasm::US7 =
                                                                                    Spiral_wasm::method47(v2059.await);
                                                                                let v2064:
                                                                                        string =
                                                                                    string("true; v2062 });  // rust.fix_closure\'");
                                                                                let v2065:
                                                                                        bool =
                                                                                    true; v2062 });  // rust.fix_closure';
                                                                                let v2067 =
                                                                                    __future_init;
                                                                                v2067
                                                                            }
                                                                            _
                                                                            =>
                                                                            {
                                                                                let v1907:
                                                                                        bool =
                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                let v1909:
                                                                                        bool =
                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                let v1910:
                                                                                        u8 =
                                                                                    Spiral_wasm::method74();
                                                                                let v1914:
                                                                                        string =
                                                                                    string("true; v1910 });  // rust.fix_closure\'");
                                                                                let v1915:
                                                                                        bool =
                                                                                    true; v1910 });  // rust.fix_closure';
                                                                                let v1917 =
                                                                                    __future_init;
                                                                                let v1919:
                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                    v1917;
                                                                                let v1922:
                                                                                        Spiral_wasm::US7 =
                                                                                    Spiral_wasm::method49(v1919.await);
                                                                                let v1924:
                                                                                        string =
                                                                                    string("true; v1922 });  // rust.fix_closure\'");
                                                                                let v1925:
                                                                                        bool =
                                                                                    true; v1922 });  // rust.fix_closure';
                                                                                let v1927 =
                                                                                    __future_init;
                                                                                v1927
                                                                            }
                                                                        }
                                                                        }
                                                                        Spiral_wasm::US6::US6_1(
                                                                            v1904_1_0,
                                                                        ) => {
                                                                            let v2075: () = {
                                                                                Spiral_wasm::closure35(v1904_1_0.clone(),
                                                                                                       ());
                                                                                ()
                                                                            };
                                                                            let v2189:
                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                          anyhow::Error>>>> =
                                                                            Spiral_wasm::method24(v148.clone(),
                                                                                                  8_u8);
                                                                            let v2191: Result<
                                                                                Spiral_wasm::US4,
                                                                                anyhow::Error,
                                                                            > = v2189.await;
                                                                            let v2192 =
                                                                            Spiral_wasm::method42();
                                                                            let v2194: Result<
                                                                                Spiral_wasm::US4,
                                                                                std::string::String,
                                                                            > = v2191.map_err(
                                                                                |x| v2192(x),
                                                                            );
                                                                            let v2195:
                                                                                Spiral_wasm::US6 =
                                                                            match &v2194
                                                                                {
                                                                                Err(v2194_1_0)
                                                                                =>
                                                                                v157(v2194_1_0.clone()),
                                                                                Ok(v2194_0_0)
                                                                                =>
                                                                                v156(v2194_0_0.clone()),
                                                                            };
                                                                            match &v2195
                                                                            {
                                                                            Spiral_wasm::US6::US6_0(v2195_0_0)
                                                                            =>
                                                                            {
                                                                                let v2196:
                                                                                        Spiral_wasm::US4 =
                                                                                    v2195_0_0.clone();
                                                                                match &v2196
                                                                                    {
                                                                                    Spiral_wasm::US4::US4_0(v2196_0_0)
                                                                                    =>
                                                                                    {
                                                                                        let v2224:
                                                                                                () =
                                                                                            {
                                                                                                Spiral_wasm::closure79(match &v2196
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
                                                                                        let v2338:
                                                                                                bool =
                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                        let v2340:
                                                                                                bool =
                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                        let v2341:
                                                                                                u8 =
                                                                                            Spiral_wasm::method73();
                                                                                        let v2345:
                                                                                                string =
                                                                                            string("true; v2341 });  // rust.fix_closure\'");
                                                                                        let v2346:
                                                                                                bool =
                                                                                            true; v2341 });  // rust.fix_closure';
                                                                                        let v2348 =
                                                                                            __future_init;
                                                                                        let v2350:
                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                            v2348;
                                                                                        let v2353:
                                                                                                Spiral_wasm::US7 =
                                                                                            Spiral_wasm::method47(v2350.await);
                                                                                        let v2355:
                                                                                                string =
                                                                                            string("true; v2353 });  // rust.fix_closure\'");
                                                                                        let v2356:
                                                                                                bool =
                                                                                            true; v2353 });  // rust.fix_closure';
                                                                                        let v2358 =
                                                                                            __future_init;
                                                                                        v2358
                                                                                    }
                                                                                    _
                                                                                    =>
                                                                                    {
                                                                                        let v2198:
                                                                                                bool =
                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                        let v2200:
                                                                                                bool =
                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                        let v2201:
                                                                                                u8 =
                                                                                            Spiral_wasm::method73();
                                                                                        let v2205:
                                                                                                string =
                                                                                            string("true; v2201 });  // rust.fix_closure\'");
                                                                                        let v2206:
                                                                                                bool =
                                                                                            true; v2201 });  // rust.fix_closure';
                                                                                        let v2208 =
                                                                                            __future_init;
                                                                                        let v2210:
                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                            v2208;
                                                                                        let v2213:
                                                                                                Spiral_wasm::US7 =
                                                                                            Spiral_wasm::method49(v2210.await);
                                                                                        let v2215:
                                                                                                string =
                                                                                            string("true; v2213 });  // rust.fix_closure\'");
                                                                                        let v2216:
                                                                                                bool =
                                                                                            true; v2213 });  // rust.fix_closure';
                                                                                        let v2218 =
                                                                                            __future_init;
                                                                                        v2218
                                                                                    }
                                                                                }
                                                                            }
                                                                            Spiral_wasm::US6::US6_1(v2195_1_0)
                                                                            =>
                                                                            {
                                                                                let v2366:
                                                                                        () =
                                                                                    {
                                                                                        Spiral_wasm::closure36(v2195_1_0.clone(),
                                                                                                               ());
                                                                                        ()
                                                                                    };
                                                                                let v2480:
                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                  anyhow::Error>>>> =
                                                                                    Spiral_wasm::method24(v148.clone(),
                                                                                                          9_u8);
                                                                                let v2482:
                                                                                        Result<Spiral_wasm::US4,
                                                                                               anyhow::Error> =
                                                                                    v2480.await;
                                                                                let v2483 =
                                                                                    Spiral_wasm::method42();
                                                                                let v2485:
                                                                                        Result<Spiral_wasm::US4,
                                                                                               std::string::String> =
                                                                                    v2482.map_err(|x| v2483(x));
                                                                                let v2486:
                                                                                        Spiral_wasm::US6 =
                                                                                    match &v2485
                                                                                        {
                                                                                        Err(v2485_1_0)
                                                                                        =>
                                                                                        v157(v2485_1_0.clone()),
                                                                                        Ok(v2485_0_0)
                                                                                        =>
                                                                                        v156(v2485_0_0.clone()),
                                                                                    };
                                                                                match &v2486
                                                                                    {
                                                                                    Spiral_wasm::US6::US6_0(v2486_0_0)
                                                                                    =>
                                                                                    {
                                                                                        let v2487:
                                                                                                Spiral_wasm::US4 =
                                                                                            v2486_0_0.clone();
                                                                                        match &v2487
                                                                                            {
                                                                                            Spiral_wasm::US4::US4_0(v2487_0_0)
                                                                                            =>
                                                                                            {
                                                                                                let v2515:
                                                                                                        () =
                                                                                                    {
                                                                                                        Spiral_wasm::closure78(match &v2487
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
                                                                                                let v2629:
                                                                                                        bool =
                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                let v2631:
                                                                                                        bool =
                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                let v2632:
                                                                                                        u8 =
                                                                                                    Spiral_wasm::method72();
                                                                                                let v2636:
                                                                                                        string =
                                                                                                    string("true; v2632 });  // rust.fix_closure\'");
                                                                                                let v2637:
                                                                                                        bool =
                                                                                                    true; v2632 });  // rust.fix_closure';
                                                                                                let v2639 =
                                                                                                    __future_init;
                                                                                                let v2641:
                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                    v2639;
                                                                                                let v2644:
                                                                                                        Spiral_wasm::US7 =
                                                                                                    Spiral_wasm::method47(v2641.await);
                                                                                                let v2646:
                                                                                                        string =
                                                                                                    string("true; v2644 });  // rust.fix_closure\'");
                                                                                                let v2647:
                                                                                                        bool =
                                                                                                    true; v2644 });  // rust.fix_closure';
                                                                                                let v2649 =
                                                                                                    __future_init;
                                                                                                v2649
                                                                                            }
                                                                                            _
                                                                                            =>
                                                                                            {
                                                                                                let v2489:
                                                                                                        bool =
                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                let v2491:
                                                                                                        bool =
                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                let v2492:
                                                                                                        u8 =
                                                                                                    Spiral_wasm::method72();
                                                                                                let v2496:
                                                                                                        string =
                                                                                                    string("true; v2492 });  // rust.fix_closure\'");
                                                                                                let v2497:
                                                                                                        bool =
                                                                                                    true; v2492 });  // rust.fix_closure';
                                                                                                let v2499 =
                                                                                                    __future_init;
                                                                                                let v2501:
                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                    v2499;
                                                                                                let v2504:
                                                                                                        Spiral_wasm::US7 =
                                                                                                    Spiral_wasm::method49(v2501.await);
                                                                                                let v2506:
                                                                                                        string =
                                                                                                    string("true; v2504 });  // rust.fix_closure\'");
                                                                                                let v2507:
                                                                                                        bool =
                                                                                                    true; v2504 });  // rust.fix_closure';
                                                                                                let v2509 =
                                                                                                    __future_init;
                                                                                                v2509
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                    Spiral_wasm::US6::US6_1(v2486_1_0)
                                                                                    =>
                                                                                    {
                                                                                        let v2657:
                                                                                                () =
                                                                                            {
                                                                                                Spiral_wasm::closure37(v2486_1_0.clone(),
                                                                                                                       ());
                                                                                                ()
                                                                                            };
                                                                                        let v2771:
                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                          anyhow::Error>>>> =
                                                                                            Spiral_wasm::method24(v148.clone(),
                                                                                                                  10_u8);
                                                                                        let v2773:
                                                                                                Result<Spiral_wasm::US4,
                                                                                                       anyhow::Error> =
                                                                                            v2771.await;
                                                                                        let v2774 =
                                                                                            Spiral_wasm::method42();
                                                                                        let v2776:
                                                                                                Result<Spiral_wasm::US4,
                                                                                                       std::string::String> =
                                                                                            v2773.map_err(|x| v2774(x));
                                                                                        let v2777:
                                                                                                Spiral_wasm::US6 =
                                                                                            match &v2776
                                                                                                {
                                                                                                Err(v2776_1_0)
                                                                                                =>
                                                                                                v157(v2776_1_0.clone()),
                                                                                                Ok(v2776_0_0)
                                                                                                =>
                                                                                                v156(v2776_0_0.clone()),
                                                                                            };
                                                                                        match &v2777
                                                                                            {
                                                                                            Spiral_wasm::US6::US6_0(v2777_0_0)
                                                                                            =>
                                                                                            {
                                                                                                let v2778:
                                                                                                        Spiral_wasm::US4 =
                                                                                                    v2777_0_0.clone();
                                                                                                match &v2778
                                                                                                    {
                                                                                                    Spiral_wasm::US4::US4_0(v2778_0_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v2806:
                                                                                                                () =
                                                                                                            {
                                                                                                                Spiral_wasm::closure77(match &v2778
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
                                                                                                        let v2920:
                                                                                                                bool =
                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                        let v2922:
                                                                                                                bool =
                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                        let v2923:
                                                                                                                u8 =
                                                                                                            Spiral_wasm::method71();
                                                                                                        let v2927:
                                                                                                                string =
                                                                                                            string("true; v2923 });  // rust.fix_closure\'");
                                                                                                        let v2928:
                                                                                                                bool =
                                                                                                            true; v2923 });  // rust.fix_closure';
                                                                                                        let v2930 =
                                                                                                            __future_init;
                                                                                                        let v2932:
                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                            v2930;
                                                                                                        let v2935:
                                                                                                                Spiral_wasm::US7 =
                                                                                                            Spiral_wasm::method47(v2932.await);
                                                                                                        let v2937:
                                                                                                                string =
                                                                                                            string("true; v2935 });  // rust.fix_closure\'");
                                                                                                        let v2938:
                                                                                                                bool =
                                                                                                            true; v2935 });  // rust.fix_closure';
                                                                                                        let v2940 =
                                                                                                            __future_init;
                                                                                                        v2940
                                                                                                    }
                                                                                                    _
                                                                                                    =>
                                                                                                    {
                                                                                                        let v2780:
                                                                                                                bool =
                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                        let v2782:
                                                                                                                bool =
                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                        let v2783:
                                                                                                                u8 =
                                                                                                            Spiral_wasm::method71();
                                                                                                        let v2787:
                                                                                                                string =
                                                                                                            string("true; v2783 });  // rust.fix_closure\'");
                                                                                                        let v2788:
                                                                                                                bool =
                                                                                                            true; v2783 });  // rust.fix_closure';
                                                                                                        let v2790 =
                                                                                                            __future_init;
                                                                                                        let v2792:
                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                            v2790;
                                                                                                        let v2795:
                                                                                                                Spiral_wasm::US7 =
                                                                                                            Spiral_wasm::method49(v2792.await);
                                                                                                        let v2797:
                                                                                                                string =
                                                                                                            string("true; v2795 });  // rust.fix_closure\'");
                                                                                                        let v2798:
                                                                                                                bool =
                                                                                                            true; v2795 });  // rust.fix_closure';
                                                                                                        let v2800 =
                                                                                                            __future_init;
                                                                                                        v2800
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                            Spiral_wasm::US6::US6_1(v2777_1_0)
                                                                                            =>
                                                                                            {
                                                                                                let v2948:
                                                                                                        () =
                                                                                                    {
                                                                                                        Spiral_wasm::closure38(v2777_1_0.clone(),
                                                                                                                               ());
                                                                                                        ()
                                                                                                    };
                                                                                                let v3062:
                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                  anyhow::Error>>>> =
                                                                                                    Spiral_wasm::method24(v148.clone(),
                                                                                                                          11_u8);
                                                                                                let v3064:
                                                                                                        Result<Spiral_wasm::US4,
                                                                                                               anyhow::Error> =
                                                                                                    v3062.await;
                                                                                                let v3065 =
                                                                                                    Spiral_wasm::method42();
                                                                                                let v3067:
                                                                                                        Result<Spiral_wasm::US4,
                                                                                                               std::string::String> =
                                                                                                    v3064.map_err(|x| v3065(x));
                                                                                                let v3068:
                                                                                                        Spiral_wasm::US6 =
                                                                                                    match &v3067
                                                                                                        {
                                                                                                        Err(v3067_1_0)
                                                                                                        =>
                                                                                                        v157(v3067_1_0.clone()),
                                                                                                        Ok(v3067_0_0)
                                                                                                        =>
                                                                                                        v156(v3067_0_0.clone()),
                                                                                                    };
                                                                                                match &v3068
                                                                                                    {
                                                                                                    Spiral_wasm::US6::US6_0(v3068_0_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v3069:
                                                                                                                Spiral_wasm::US4 =
                                                                                                            v3068_0_0.clone();
                                                                                                        match &v3069
                                                                                                            {
                                                                                                            Spiral_wasm::US4::US4_0(v3069_0_0)
                                                                                                            =>
                                                                                                            {
                                                                                                                let v3097:
                                                                                                                        () =
                                                                                                                    {
                                                                                                                        Spiral_wasm::closure76(match &v3069
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
                                                                                                                    Spiral_wasm::method47(v3223.await);
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
                                                                                                            _
                                                                                                            =>
                                                                                                            {
                                                                                                                let v3071:
                                                                                                                        bool =
                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                let v3073:
                                                                                                                        bool =
                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                let v3074:
                                                                                                                        u8 =
                                                                                                                    Spiral_wasm::method70();
                                                                                                                let v3078:
                                                                                                                        string =
                                                                                                                    string("true; v3074 });  // rust.fix_closure\'");
                                                                                                                let v3079:
                                                                                                                        bool =
                                                                                                                    true; v3074 });  // rust.fix_closure';
                                                                                                                let v3081 =
                                                                                                                    __future_init;
                                                                                                                let v3083:
                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                    v3081;
                                                                                                                let v3086:
                                                                                                                        Spiral_wasm::US7 =
                                                                                                                    Spiral_wasm::method49(v3083.await);
                                                                                                                let v3088:
                                                                                                                        string =
                                                                                                                    string("true; v3086 });  // rust.fix_closure\'");
                                                                                                                let v3089:
                                                                                                                        bool =
                                                                                                                    true; v3086 });  // rust.fix_closure';
                                                                                                                let v3091 =
                                                                                                                    __future_init;
                                                                                                                v3091
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                    Spiral_wasm::US6::US6_1(v3068_1_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v3239:
                                                                                                                () =
                                                                                                            {
                                                                                                                Spiral_wasm::closure39(v3068_1_0.clone(),
                                                                                                                                       ());
                                                                                                                ()
                                                                                                            };
                                                                                                        let v3353:
                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                          anyhow::Error>>>> =
                                                                                                            Spiral_wasm::method24(v148.clone(),
                                                                                                                                  12_u8);
                                                                                                        let v3355:
                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                       anyhow::Error> =
                                                                                                            v3353.await;
                                                                                                        let v3356 =
                                                                                                            Spiral_wasm::method42();
                                                                                                        let v3358:
                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                       std::string::String> =
                                                                                                            v3355.map_err(|x| v3356(x));
                                                                                                        let v3359:
                                                                                                                Spiral_wasm::US6 =
                                                                                                            match &v3358
                                                                                                                {
                                                                                                                Err(v3358_1_0)
                                                                                                                =>
                                                                                                                v157(v3358_1_0.clone()),
                                                                                                                Ok(v3358_0_0)
                                                                                                                =>
                                                                                                                v156(v3358_0_0.clone()),
                                                                                                            };
                                                                                                        match &v3359
                                                                                                            {
                                                                                                            Spiral_wasm::US6::US6_0(v3359_0_0)
                                                                                                            =>
                                                                                                            {
                                                                                                                let v3360:
                                                                                                                        Spiral_wasm::US4 =
                                                                                                                    v3359_0_0.clone();
                                                                                                                match &v3360
                                                                                                                    {
                                                                                                                    Spiral_wasm::US4::US4_0(v3360_0_0)
                                                                                                                    =>
                                                                                                                    {
                                                                                                                        let v3388:
                                                                                                                                () =
                                                                                                                            {
                                                                                                                                Spiral_wasm::closure75(match &v3360
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
                                                                                                                        let v3502:
                                                                                                                                bool =
                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                        let v3504:
                                                                                                                                bool =
                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                        let v3505:
                                                                                                                                u8 =
                                                                                                                            Spiral_wasm::method69();
                                                                                                                        let v3509:
                                                                                                                                string =
                                                                                                                            string("true; v3505 });  // rust.fix_closure\'");
                                                                                                                        let v3510:
                                                                                                                                bool =
                                                                                                                            true; v3505 });  // rust.fix_closure';
                                                                                                                        let v3512 =
                                                                                                                            __future_init;
                                                                                                                        let v3514:
                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                            v3512;
                                                                                                                        let v3517:
                                                                                                                                Spiral_wasm::US7 =
                                                                                                                            Spiral_wasm::method47(v3514.await);
                                                                                                                        let v3519:
                                                                                                                                string =
                                                                                                                            string("true; v3517 });  // rust.fix_closure\'");
                                                                                                                        let v3520:
                                                                                                                                bool =
                                                                                                                            true; v3517 });  // rust.fix_closure';
                                                                                                                        let v3522 =
                                                                                                                            __future_init;
                                                                                                                        v3522
                                                                                                                    }
                                                                                                                    _
                                                                                                                    =>
                                                                                                                    {
                                                                                                                        let v3362:
                                                                                                                                bool =
                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                        let v3364:
                                                                                                                                bool =
                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                        let v3365:
                                                                                                                                u8 =
                                                                                                                            Spiral_wasm::method69();
                                                                                                                        let v3369:
                                                                                                                                string =
                                                                                                                            string("true; v3365 });  // rust.fix_closure\'");
                                                                                                                        let v3370:
                                                                                                                                bool =
                                                                                                                            true; v3365 });  // rust.fix_closure';
                                                                                                                        let v3372 =
                                                                                                                            __future_init;
                                                                                                                        let v3374:
                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                            v3372;
                                                                                                                        let v3377:
                                                                                                                                Spiral_wasm::US7 =
                                                                                                                            Spiral_wasm::method49(v3374.await);
                                                                                                                        let v3379:
                                                                                                                                string =
                                                                                                                            string("true; v3377 });  // rust.fix_closure\'");
                                                                                                                        let v3380:
                                                                                                                                bool =
                                                                                                                            true; v3377 });  // rust.fix_closure';
                                                                                                                        let v3382 =
                                                                                                                            __future_init;
                                                                                                                        v3382
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                            Spiral_wasm::US6::US6_1(v3359_1_0)
                                                                                                            =>
                                                                                                            {
                                                                                                                let v3530:
                                                                                                                        () =
                                                                                                                    {
                                                                                                                        Spiral_wasm::closure40(v3359_1_0.clone(),
                                                                                                                                               ());
                                                                                                                        ()
                                                                                                                    };
                                                                                                                let v3644:
                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                  anyhow::Error>>>> =
                                                                                                                    Spiral_wasm::method24(v148.clone(),
                                                                                                                                          13_u8);
                                                                                                                let v3646:
                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                               anyhow::Error> =
                                                                                                                    v3644.await;
                                                                                                                let v3647 =
                                                                                                                    Spiral_wasm::method42();
                                                                                                                let v3649:
                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                               std::string::String> =
                                                                                                                    v3646.map_err(|x| v3647(x));
                                                                                                                let v3650:
                                                                                                                        Spiral_wasm::US6 =
                                                                                                                    match &v3649
                                                                                                                        {
                                                                                                                        Err(v3649_1_0)
                                                                                                                        =>
                                                                                                                        v157(v3649_1_0.clone()),
                                                                                                                        Ok(v3649_0_0)
                                                                                                                        =>
                                                                                                                        v156(v3649_0_0.clone()),
                                                                                                                    };
                                                                                                                match &v3650
                                                                                                                    {
                                                                                                                    Spiral_wasm::US6::US6_0(v3650_0_0)
                                                                                                                    =>
                                                                                                                    {
                                                                                                                        let v3651:
                                                                                                                                Spiral_wasm::US4 =
                                                                                                                            v3650_0_0.clone();
                                                                                                                        match &v3651
                                                                                                                            {
                                                                                                                            Spiral_wasm::US4::US4_0(v3651_0_0)
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let v3679:
                                                                                                                                        () =
                                                                                                                                    {
                                                                                                                                        Spiral_wasm::closure74(match &v3651
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
                                                                                                                                let v3793:
                                                                                                                                        bool =
                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                let v3795:
                                                                                                                                        bool =
                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                let v3796:
                                                                                                                                        u8 =
                                                                                                                                    Spiral_wasm::method68();
                                                                                                                                let v3800:
                                                                                                                                        string =
                                                                                                                                    string("true; v3796 });  // rust.fix_closure\'");
                                                                                                                                let v3801:
                                                                                                                                        bool =
                                                                                                                                    true; v3796 });  // rust.fix_closure';
                                                                                                                                let v3803 =
                                                                                                                                    __future_init;
                                                                                                                                let v3805:
                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                    v3803;
                                                                                                                                let v3808:
                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                    Spiral_wasm::method47(v3805.await);
                                                                                                                                let v3810:
                                                                                                                                        string =
                                                                                                                                    string("true; v3808 });  // rust.fix_closure\'");
                                                                                                                                let v3811:
                                                                                                                                        bool =
                                                                                                                                    true; v3808 });  // rust.fix_closure';
                                                                                                                                let v3813 =
                                                                                                                                    __future_init;
                                                                                                                                v3813
                                                                                                                            }
                                                                                                                            _
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let v3653:
                                                                                                                                        bool =
                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                let v3655:
                                                                                                                                        bool =
                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                let v3656:
                                                                                                                                        u8 =
                                                                                                                                    Spiral_wasm::method68();
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
                                                                                                                                    Spiral_wasm::method49(v3665.await);
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
                                                                                                                        }
                                                                                                                    }
                                                                                                                    Spiral_wasm::US6::US6_1(v3650_1_0)
                                                                                                                    =>
                                                                                                                    {
                                                                                                                        let v3821:
                                                                                                                                () =
                                                                                                                            {
                                                                                                                                Spiral_wasm::closure41(v3650_1_0.clone(),
                                                                                                                                                       ());
                                                                                                                                ()
                                                                                                                            };
                                                                                                                        let v3935:
                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                          anyhow::Error>>>> =
                                                                                                                            Spiral_wasm::method24(v148.clone(),
                                                                                                                                                  14_u8);
                                                                                                                        let v3937:
                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                       anyhow::Error> =
                                                                                                                            v3935.await;
                                                                                                                        let v3938 =
                                                                                                                            Spiral_wasm::method42();
                                                                                                                        let v3940:
                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                       std::string::String> =
                                                                                                                            v3937.map_err(|x| v3938(x));
                                                                                                                        let v3941:
                                                                                                                                Spiral_wasm::US6 =
                                                                                                                            match &v3940
                                                                                                                                {
                                                                                                                                Err(v3940_1_0)
                                                                                                                                =>
                                                                                                                                v157(v3940_1_0.clone()),
                                                                                                                                Ok(v3940_0_0)
                                                                                                                                =>
                                                                                                                                v156(v3940_0_0.clone()),
                                                                                                                            };
                                                                                                                        match &v3941
                                                                                                                            {
                                                                                                                            Spiral_wasm::US6::US6_0(v3941_0_0)
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let v3942:
                                                                                                                                        Spiral_wasm::US4 =
                                                                                                                                    v3941_0_0.clone();
                                                                                                                                match &v3942
                                                                                                                                    {
                                                                                                                                    Spiral_wasm::US4::US4_0(v3942_0_0)
                                                                                                                                    =>
                                                                                                                                    {
                                                                                                                                        let v3970:
                                                                                                                                                () =
                                                                                                                                            {
                                                                                                                                                Spiral_wasm::closure73(match &v3942
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
                                                                                                                                        let v4084:
                                                                                                                                                bool =
                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                        let v4086:
                                                                                                                                                bool =
                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                        let v4087:
                                                                                                                                                u8 =
                                                                                                                                            Spiral_wasm::method67();
                                                                                                                                        let v4091:
                                                                                                                                                string =
                                                                                                                                            string("true; v4087 });  // rust.fix_closure\'");
                                                                                                                                        let v4092:
                                                                                                                                                bool =
                                                                                                                                            true; v4087 });  // rust.fix_closure';
                                                                                                                                        let v4094 =
                                                                                                                                            __future_init;
                                                                                                                                        let v4096:
                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                            v4094;
                                                                                                                                        let v4099:
                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                            Spiral_wasm::method47(v4096.await);
                                                                                                                                        let v4101:
                                                                                                                                                string =
                                                                                                                                            string("true; v4099 });  // rust.fix_closure\'");
                                                                                                                                        let v4102:
                                                                                                                                                bool =
                                                                                                                                            true; v4099 });  // rust.fix_closure';
                                                                                                                                        let v4104 =
                                                                                                                                            __future_init;
                                                                                                                                        v4104
                                                                                                                                    }
                                                                                                                                    _
                                                                                                                                    =>
                                                                                                                                    {
                                                                                                                                        let v3944:
                                                                                                                                                bool =
                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                        let v3946:
                                                                                                                                                bool =
                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                        let v3947:
                                                                                                                                                u8 =
                                                                                                                                            Spiral_wasm::method67();
                                                                                                                                        let v3951:
                                                                                                                                                string =
                                                                                                                                            string("true; v3947 });  // rust.fix_closure\'");
                                                                                                                                        let v3952:
                                                                                                                                                bool =
                                                                                                                                            true; v3947 });  // rust.fix_closure';
                                                                                                                                        let v3954 =
                                                                                                                                            __future_init;
                                                                                                                                        let v3956:
                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                            v3954;
                                                                                                                                        let v3959:
                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                            Spiral_wasm::method49(v3956.await);
                                                                                                                                        let v3961:
                                                                                                                                                string =
                                                                                                                                            string("true; v3959 });  // rust.fix_closure\'");
                                                                                                                                        let v3962:
                                                                                                                                                bool =
                                                                                                                                            true; v3959 });  // rust.fix_closure';
                                                                                                                                        let v3964 =
                                                                                                                                            __future_init;
                                                                                                                                        v3964
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                            Spiral_wasm::US6::US6_1(v3941_1_0)
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let v4112:
                                                                                                                                        () =
                                                                                                                                    {
                                                                                                                                        Spiral_wasm::closure42(v3941_1_0.clone(),
                                                                                                                                                               ());
                                                                                                                                        ()
                                                                                                                                    };
                                                                                                                                let v4226:
                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                  anyhow::Error>>>> =
                                                                                                                                    Spiral_wasm::method24(v148.clone(),
                                                                                                                                                          15_u8);
                                                                                                                                let v4228:
                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                               anyhow::Error> =
                                                                                                                                    v4226.await;
                                                                                                                                let v4229 =
                                                                                                                                    Spiral_wasm::method42();
                                                                                                                                let v4231:
                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                               std::string::String> =
                                                                                                                                    v4228.map_err(|x| v4229(x));
                                                                                                                                let v4232:
                                                                                                                                        Spiral_wasm::US6 =
                                                                                                                                    match &v4231
                                                                                                                                        {
                                                                                                                                        Err(v4231_1_0)
                                                                                                                                        =>
                                                                                                                                        v157(v4231_1_0.clone()),
                                                                                                                                        Ok(v4231_0_0)
                                                                                                                                        =>
                                                                                                                                        v156(v4231_0_0.clone()),
                                                                                                                                    };
                                                                                                                                match &v4232
                                                                                                                                    {
                                                                                                                                    Spiral_wasm::US6::US6_0(v4232_0_0)
                                                                                                                                    =>
                                                                                                                                    {
                                                                                                                                        let v4233:
                                                                                                                                                Spiral_wasm::US4 =
                                                                                                                                            v4232_0_0.clone();
                                                                                                                                        match &v4233
                                                                                                                                            {
                                                                                                                                            Spiral_wasm::US4::US4_0(v4233_0_0)
                                                                                                                                            =>
                                                                                                                                            {
                                                                                                                                                let v4261:
                                                                                                                                                        () =
                                                                                                                                                    {
                                                                                                                                                        Spiral_wasm::closure72(match &v4233
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
                                                                                                                                                let v4375:
                                                                                                                                                        bool =
                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                let v4377:
                                                                                                                                                        bool =
                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                let v4378:
                                                                                                                                                        u8 =
                                                                                                                                                    Spiral_wasm::method66();
                                                                                                                                                let v4382:
                                                                                                                                                        string =
                                                                                                                                                    string("true; v4378 });  // rust.fix_closure\'");
                                                                                                                                                let v4383:
                                                                                                                                                        bool =
                                                                                                                                                    true; v4378 });  // rust.fix_closure';
                                                                                                                                                let v4385 =
                                                                                                                                                    __future_init;
                                                                                                                                                let v4387:
                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                    v4385;
                                                                                                                                                let v4390:
                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                    Spiral_wasm::method47(v4387.await);
                                                                                                                                                let v4392:
                                                                                                                                                        string =
                                                                                                                                                    string("true; v4390 });  // rust.fix_closure\'");
                                                                                                                                                let v4393:
                                                                                                                                                        bool =
                                                                                                                                                    true; v4390 });  // rust.fix_closure';
                                                                                                                                                let v4395 =
                                                                                                                                                    __future_init;
                                                                                                                                                v4395
                                                                                                                                            }
                                                                                                                                            _
                                                                                                                                            =>
                                                                                                                                            {
                                                                                                                                                let v4235:
                                                                                                                                                        bool =
                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                let v4237:
                                                                                                                                                        bool =
                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                let v4238:
                                                                                                                                                        u8 =
                                                                                                                                                    Spiral_wasm::method66();
                                                                                                                                                let v4242:
                                                                                                                                                        string =
                                                                                                                                                    string("true; v4238 });  // rust.fix_closure\'");
                                                                                                                                                let v4243:
                                                                                                                                                        bool =
                                                                                                                                                    true; v4238 });  // rust.fix_closure';
                                                                                                                                                let v4245 =
                                                                                                                                                    __future_init;
                                                                                                                                                let v4247:
                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                    v4245;
                                                                                                                                                let v4250:
                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                    Spiral_wasm::method49(v4247.await);
                                                                                                                                                let v4252:
                                                                                                                                                        string =
                                                                                                                                                    string("true; v4250 });  // rust.fix_closure\'");
                                                                                                                                                let v4253:
                                                                                                                                                        bool =
                                                                                                                                                    true; v4250 });  // rust.fix_closure';
                                                                                                                                                let v4255 =
                                                                                                                                                    __future_init;
                                                                                                                                                v4255
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                    Spiral_wasm::US6::US6_1(v4232_1_0)
                                                                                                                                    =>
                                                                                                                                    {
                                                                                                                                        let v4403:
                                                                                                                                                () =
                                                                                                                                            {
                                                                                                                                                Spiral_wasm::closure43(v4232_1_0.clone(),
                                                                                                                                                                       ());
                                                                                                                                                ()
                                                                                                                                            };
                                                                                                                                        let v4517:
                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                          anyhow::Error>>>> =
                                                                                                                                            Spiral_wasm::method24(v148.clone(),
                                                                                                                                                                  16_u8);
                                                                                                                                        let v4519:
                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                       anyhow::Error> =
                                                                                                                                            v4517.await;
                                                                                                                                        let v4520 =
                                                                                                                                            Spiral_wasm::method42();
                                                                                                                                        let v4522:
                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                       std::string::String> =
                                                                                                                                            v4519.map_err(|x| v4520(x));
                                                                                                                                        let v4523:
                                                                                                                                                Spiral_wasm::US6 =
                                                                                                                                            match &v4522
                                                                                                                                                {
                                                                                                                                                Err(v4522_1_0)
                                                                                                                                                =>
                                                                                                                                                v157(v4522_1_0.clone()),
                                                                                                                                                Ok(v4522_0_0)
                                                                                                                                                =>
                                                                                                                                                v156(v4522_0_0.clone()),
                                                                                                                                            };
                                                                                                                                        match &v4523
                                                                                                                                            {
                                                                                                                                            Spiral_wasm::US6::US6_0(v4523_0_0)
                                                                                                                                            =>
                                                                                                                                            {
                                                                                                                                                let v4524:
                                                                                                                                                        Spiral_wasm::US4 =
                                                                                                                                                    v4523_0_0.clone();
                                                                                                                                                match &v4524
                                                                                                                                                    {
                                                                                                                                                    Spiral_wasm::US4::US4_0(v4524_0_0)
                                                                                                                                                    =>
                                                                                                                                                    {
                                                                                                                                                        let v4552:
                                                                                                                                                                () =
                                                                                                                                                            {
                                                                                                                                                                Spiral_wasm::closure71(match &v4524
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
                                                                                                                                                        let v4666:
                                                                                                                                                                bool =
                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                        let v4668:
                                                                                                                                                                bool =
                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                        let v4669:
                                                                                                                                                                u8 =
                                                                                                                                                            Spiral_wasm::method65();
                                                                                                                                                        let v4673:
                                                                                                                                                                string =
                                                                                                                                                            string("true; v4669 });  // rust.fix_closure\'");
                                                                                                                                                        let v4674:
                                                                                                                                                                bool =
                                                                                                                                                            true; v4669 });  // rust.fix_closure';
                                                                                                                                                        let v4676 =
                                                                                                                                                            __future_init;
                                                                                                                                                        let v4678:
                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                            v4676;
                                                                                                                                                        let v4681:
                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                            Spiral_wasm::method47(v4678.await);
                                                                                                                                                        let v4683:
                                                                                                                                                                string =
                                                                                                                                                            string("true; v4681 });  // rust.fix_closure\'");
                                                                                                                                                        let v4684:
                                                                                                                                                                bool =
                                                                                                                                                            true; v4681 });  // rust.fix_closure';
                                                                                                                                                        let v4686 =
                                                                                                                                                            __future_init;
                                                                                                                                                        v4686
                                                                                                                                                    }
                                                                                                                                                    _
                                                                                                                                                    =>
                                                                                                                                                    {
                                                                                                                                                        let v4526:
                                                                                                                                                                bool =
                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                        let v4528:
                                                                                                                                                                bool =
                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                        let v4529:
                                                                                                                                                                u8 =
                                                                                                                                                            Spiral_wasm::method65();
                                                                                                                                                        let v4533:
                                                                                                                                                                string =
                                                                                                                                                            string("true; v4529 });  // rust.fix_closure\'");
                                                                                                                                                        let v4534:
                                                                                                                                                                bool =
                                                                                                                                                            true; v4529 });  // rust.fix_closure';
                                                                                                                                                        let v4536 =
                                                                                                                                                            __future_init;
                                                                                                                                                        let v4538:
                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                            v4536;
                                                                                                                                                        let v4541:
                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                            Spiral_wasm::method49(v4538.await);
                                                                                                                                                        let v4543:
                                                                                                                                                                string =
                                                                                                                                                            string("true; v4541 });  // rust.fix_closure\'");
                                                                                                                                                        let v4544:
                                                                                                                                                                bool =
                                                                                                                                                            true; v4541 });  // rust.fix_closure';
                                                                                                                                                        let v4546 =
                                                                                                                                                            __future_init;
                                                                                                                                                        v4546
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                            Spiral_wasm::US6::US6_1(v4523_1_0)
                                                                                                                                            =>
                                                                                                                                            {
                                                                                                                                                let v4694:
                                                                                                                                                        () =
                                                                                                                                                    {
                                                                                                                                                        Spiral_wasm::closure44(v4523_1_0.clone(),
                                                                                                                                                                               ());
                                                                                                                                                        ()
                                                                                                                                                    };
                                                                                                                                                let v4808:
                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                  anyhow::Error>>>> =
                                                                                                                                                    Spiral_wasm::method24(v148.clone(),
                                                                                                                                                                          17_u8);
                                                                                                                                                let v4810:
                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                               anyhow::Error> =
                                                                                                                                                    v4808.await;
                                                                                                                                                let v4811 =
                                                                                                                                                    Spiral_wasm::method42();
                                                                                                                                                let v4813:
                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                               std::string::String> =
                                                                                                                                                    v4810.map_err(|x| v4811(x));
                                                                                                                                                let v4814:
                                                                                                                                                        Spiral_wasm::US6 =
                                                                                                                                                    match &v4813
                                                                                                                                                        {
                                                                                                                                                        Err(v4813_1_0)
                                                                                                                                                        =>
                                                                                                                                                        v157(v4813_1_0.clone()),
                                                                                                                                                        Ok(v4813_0_0)
                                                                                                                                                        =>
                                                                                                                                                        v156(v4813_0_0.clone()),
                                                                                                                                                    };
                                                                                                                                                match &v4814
                                                                                                                                                    {
                                                                                                                                                    Spiral_wasm::US6::US6_0(v4814_0_0)
                                                                                                                                                    =>
                                                                                                                                                    {
                                                                                                                                                        let v4815:
                                                                                                                                                                Spiral_wasm::US4 =
                                                                                                                                                            v4814_0_0.clone();
                                                                                                                                                        match &v4815
                                                                                                                                                            {
                                                                                                                                                            Spiral_wasm::US4::US4_0(v4815_0_0)
                                                                                                                                                            =>
                                                                                                                                                            {
                                                                                                                                                                let v4843:
                                                                                                                                                                        () =
                                                                                                                                                                    {
                                                                                                                                                                        Spiral_wasm::closure70(match &v4815
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
                                                                                                                                                                let v4957:
                                                                                                                                                                        bool =
                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                let v4959:
                                                                                                                                                                        bool =
                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                let v4960:
                                                                                                                                                                        u8 =
                                                                                                                                                                    Spiral_wasm::method64();
                                                                                                                                                                let v4964:
                                                                                                                                                                        string =
                                                                                                                                                                    string("true; v4960 });  // rust.fix_closure\'");
                                                                                                                                                                let v4965:
                                                                                                                                                                        bool =
                                                                                                                                                                    true; v4960 });  // rust.fix_closure';
                                                                                                                                                                let v4967 =
                                                                                                                                                                    __future_init;
                                                                                                                                                                let v4969:
                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                    v4967;
                                                                                                                                                                let v4972:
                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                    Spiral_wasm::method47(v4969.await);
                                                                                                                                                                let v4974:
                                                                                                                                                                        string =
                                                                                                                                                                    string("true; v4972 });  // rust.fix_closure\'");
                                                                                                                                                                let v4975:
                                                                                                                                                                        bool =
                                                                                                                                                                    true; v4972 });  // rust.fix_closure';
                                                                                                                                                                let v4977 =
                                                                                                                                                                    __future_init;
                                                                                                                                                                v4977
                                                                                                                                                            }
                                                                                                                                                            _
                                                                                                                                                            =>
                                                                                                                                                            {
                                                                                                                                                                let v4817:
                                                                                                                                                                        bool =
                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                let v4819:
                                                                                                                                                                        bool =
                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                let v4820:
                                                                                                                                                                        u8 =
                                                                                                                                                                    Spiral_wasm::method64();
                                                                                                                                                                let v4824:
                                                                                                                                                                        string =
                                                                                                                                                                    string("true; v4820 });  // rust.fix_closure\'");
                                                                                                                                                                let v4825:
                                                                                                                                                                        bool =
                                                                                                                                                                    true; v4820 });  // rust.fix_closure';
                                                                                                                                                                let v4827 =
                                                                                                                                                                    __future_init;
                                                                                                                                                                let v4829:
                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                    v4827;
                                                                                                                                                                let v4832:
                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                    Spiral_wasm::method49(v4829.await);
                                                                                                                                                                let v4834:
                                                                                                                                                                        string =
                                                                                                                                                                    string("true; v4832 });  // rust.fix_closure\'");
                                                                                                                                                                let v4835:
                                                                                                                                                                        bool =
                                                                                                                                                                    true; v4832 });  // rust.fix_closure';
                                                                                                                                                                let v4837 =
                                                                                                                                                                    __future_init;
                                                                                                                                                                v4837
                                                                                                                                                            }
                                                                                                                                                        }
                                                                                                                                                    }
                                                                                                                                                    Spiral_wasm::US6::US6_1(v4814_1_0)
                                                                                                                                                    =>
                                                                                                                                                    {
                                                                                                                                                        let v4985:
                                                                                                                                                                () =
                                                                                                                                                            {
                                                                                                                                                                Spiral_wasm::closure45(v4814_1_0.clone(),
                                                                                                                                                                                       ());
                                                                                                                                                                ()
                                                                                                                                                            };
                                                                                                                                                        let v5099:
                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                          anyhow::Error>>>> =
                                                                                                                                                            Spiral_wasm::method24(v148.clone(),
                                                                                                                                                                                  18_u8);
                                                                                                                                                        let v5101:
                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                       anyhow::Error> =
                                                                                                                                                            v5099.await;
                                                                                                                                                        let v5102 =
                                                                                                                                                            Spiral_wasm::method42();
                                                                                                                                                        let v5104:
                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                       std::string::String> =
                                                                                                                                                            v5101.map_err(|x| v5102(x));
                                                                                                                                                        let v5105:
                                                                                                                                                                Spiral_wasm::US6 =
                                                                                                                                                            match &v5104
                                                                                                                                                                {
                                                                                                                                                                Err(v5104_1_0)
                                                                                                                                                                =>
                                                                                                                                                                v157(v5104_1_0.clone()),
                                                                                                                                                                Ok(v5104_0_0)
                                                                                                                                                                =>
                                                                                                                                                                v156(v5104_0_0.clone()),
                                                                                                                                                            };
                                                                                                                                                        match &v5105
                                                                                                                                                            {
                                                                                                                                                            Spiral_wasm::US6::US6_0(v5105_0_0)
                                                                                                                                                            =>
                                                                                                                                                            {
                                                                                                                                                                let v5106:
                                                                                                                                                                        Spiral_wasm::US4 =
                                                                                                                                                                    v5105_0_0.clone();
                                                                                                                                                                match &v5106
                                                                                                                                                                    {
                                                                                                                                                                    Spiral_wasm::US4::US4_0(v5106_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    {
                                                                                                                                                                        let v5134:
                                                                                                                                                                                () =
                                                                                                                                                                            {
                                                                                                                                                                                Spiral_wasm::closure69(match &v5106
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
                                                                                                                                                                        let v5248:
                                                                                                                                                                                bool =
                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                        let v5250:
                                                                                                                                                                                bool =
                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                        let v5251:
                                                                                                                                                                                u8 =
                                                                                                                                                                            Spiral_wasm::method63();
                                                                                                                                                                        let v5255:
                                                                                                                                                                                string =
                                                                                                                                                                            string("true; v5251 });  // rust.fix_closure\'");
                                                                                                                                                                        let v5256:
                                                                                                                                                                                bool =
                                                                                                                                                                            true; v5251 });  // rust.fix_closure';
                                                                                                                                                                        let v5258 =
                                                                                                                                                                            __future_init;
                                                                                                                                                                        let v5260:
                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                            v5258;
                                                                                                                                                                        let v5263:
                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                            Spiral_wasm::method47(v5260.await);
                                                                                                                                                                        let v5265:
                                                                                                                                                                                string =
                                                                                                                                                                            string("true; v5263 });  // rust.fix_closure\'");
                                                                                                                                                                        let v5266:
                                                                                                                                                                                bool =
                                                                                                                                                                            true; v5263 });  // rust.fix_closure';
                                                                                                                                                                        let v5268 =
                                                                                                                                                                            __future_init;
                                                                                                                                                                        v5268
                                                                                                                                                                    }
                                                                                                                                                                    _
                                                                                                                                                                    =>
                                                                                                                                                                    {
                                                                                                                                                                        let v5108:
                                                                                                                                                                                bool =
                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                        let v5110:
                                                                                                                                                                                bool =
                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                        let v5111:
                                                                                                                                                                                u8 =
                                                                                                                                                                            Spiral_wasm::method63();
                                                                                                                                                                        let v5115:
                                                                                                                                                                                string =
                                                                                                                                                                            string("true; v5111 });  // rust.fix_closure\'");
                                                                                                                                                                        let v5116:
                                                                                                                                                                                bool =
                                                                                                                                                                            true; v5111 });  // rust.fix_closure';
                                                                                                                                                                        let v5118 =
                                                                                                                                                                            __future_init;
                                                                                                                                                                        let v5120:
                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                            v5118;
                                                                                                                                                                        let v5123:
                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                            Spiral_wasm::method49(v5120.await);
                                                                                                                                                                        let v5125:
                                                                                                                                                                                string =
                                                                                                                                                                            string("true; v5123 });  // rust.fix_closure\'");
                                                                                                                                                                        let v5126:
                                                                                                                                                                                bool =
                                                                                                                                                                            true; v5123 });  // rust.fix_closure';
                                                                                                                                                                        let v5128 =
                                                                                                                                                                            __future_init;
                                                                                                                                                                        v5128
                                                                                                                                                                    }
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                            Spiral_wasm::US6::US6_1(v5105_1_0)
                                                                                                                                                            =>
                                                                                                                                                            {
                                                                                                                                                                let v5276:
                                                                                                                                                                        () =
                                                                                                                                                                    {
                                                                                                                                                                        Spiral_wasm::closure46(v5105_1_0.clone(),
                                                                                                                                                                                               ());
                                                                                                                                                                        ()
                                                                                                                                                                    };
                                                                                                                                                                let v5390:
                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                  anyhow::Error>>>> =
                                                                                                                                                                    Spiral_wasm::method24(v148.clone(),
                                                                                                                                                                                          19_u8);
                                                                                                                                                                let v5392:
                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                               anyhow::Error> =
                                                                                                                                                                    v5390.await;
                                                                                                                                                                let v5393 =
                                                                                                                                                                    Spiral_wasm::method42();
                                                                                                                                                                let v5395:
                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                               std::string::String> =
                                                                                                                                                                    v5392.map_err(|x| v5393(x));
                                                                                                                                                                let v5396:
                                                                                                                                                                        Spiral_wasm::US6 =
                                                                                                                                                                    match &v5395
                                                                                                                                                                        {
                                                                                                                                                                        Err(v5395_1_0)
                                                                                                                                                                        =>
                                                                                                                                                                        v157(v5395_1_0.clone()),
                                                                                                                                                                        Ok(v5395_0_0)
                                                                                                                                                                        =>
                                                                                                                                                                        v156(v5395_0_0.clone()),
                                                                                                                                                                    };
                                                                                                                                                                match &v5396
                                                                                                                                                                    {
                                                                                                                                                                    Spiral_wasm::US6::US6_0(v5396_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    {
                                                                                                                                                                        let v5397:
                                                                                                                                                                                Spiral_wasm::US4 =
                                                                                                                                                                            v5396_0_0.clone();
                                                                                                                                                                        match &v5397
                                                                                                                                                                            {
                                                                                                                                                                            Spiral_wasm::US4::US4_0(v5397_0_0)
                                                                                                                                                                            =>
                                                                                                                                                                            {
                                                                                                                                                                                let v5425:
                                                                                                                                                                                        () =
                                                                                                                                                                                    {
                                                                                                                                                                                        Spiral_wasm::closure68(match &v5397
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
                                                                                                                                                                                let v5539:
                                                                                                                                                                                        bool =
                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                let v5541:
                                                                                                                                                                                        bool =
                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                let v5542:
                                                                                                                                                                                        u8 =
                                                                                                                                                                                    Spiral_wasm::method62();
                                                                                                                                                                                let v5546:
                                                                                                                                                                                        string =
                                                                                                                                                                                    string("true; v5542 });  // rust.fix_closure\'");
                                                                                                                                                                                let v5547:
                                                                                                                                                                                        bool =
                                                                                                                                                                                    true; v5542 });  // rust.fix_closure';
                                                                                                                                                                                let v5549 =
                                                                                                                                                                                    __future_init;
                                                                                                                                                                                let v5551:
                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                    v5549;
                                                                                                                                                                                let v5554:
                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                    Spiral_wasm::method47(v5551.await);
                                                                                                                                                                                let v5556:
                                                                                                                                                                                        string =
                                                                                                                                                                                    string("true; v5554 });  // rust.fix_closure\'");
                                                                                                                                                                                let v5557:
                                                                                                                                                                                        bool =
                                                                                                                                                                                    true; v5554 });  // rust.fix_closure';
                                                                                                                                                                                let v5559 =
                                                                                                                                                                                    __future_init;
                                                                                                                                                                                v5559
                                                                                                                                                                            }
                                                                                                                                                                            _
                                                                                                                                                                            =>
                                                                                                                                                                            {
                                                                                                                                                                                let v5399:
                                                                                                                                                                                        bool =
                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                let v5401:
                                                                                                                                                                                        bool =
                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                let v5402:
                                                                                                                                                                                        u8 =
                                                                                                                                                                                    Spiral_wasm::method62();
                                                                                                                                                                                let v5406:
                                                                                                                                                                                        string =
                                                                                                                                                                                    string("true; v5402 });  // rust.fix_closure\'");
                                                                                                                                                                                let v5407:
                                                                                                                                                                                        bool =
                                                                                                                                                                                    true; v5402 });  // rust.fix_closure';
                                                                                                                                                                                let v5409 =
                                                                                                                                                                                    __future_init;
                                                                                                                                                                                let v5411:
                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                    v5409;
                                                                                                                                                                                let v5414:
                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                    Spiral_wasm::method49(v5411.await);
                                                                                                                                                                                let v5416:
                                                                                                                                                                                        string =
                                                                                                                                                                                    string("true; v5414 });  // rust.fix_closure\'");
                                                                                                                                                                                let v5417:
                                                                                                                                                                                        bool =
                                                                                                                                                                                    true; v5414 });  // rust.fix_closure';
                                                                                                                                                                                let v5419 =
                                                                                                                                                                                    __future_init;
                                                                                                                                                                                v5419
                                                                                                                                                                            }
                                                                                                                                                                        }
                                                                                                                                                                    }
                                                                                                                                                                    Spiral_wasm::US6::US6_1(v5396_1_0)
                                                                                                                                                                    =>
                                                                                                                                                                    {
                                                                                                                                                                        let v5567:
                                                                                                                                                                                () =
                                                                                                                                                                            {
                                                                                                                                                                                Spiral_wasm::closure47(v5396_1_0.clone(),
                                                                                                                                                                                                       ());
                                                                                                                                                                                ()
                                                                                                                                                                            };
                                                                                                                                                                        let v5681:
                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                          anyhow::Error>>>> =
                                                                                                                                                                            Spiral_wasm::method24(v148.clone(),
                                                                                                                                                                                                  20_u8);
                                                                                                                                                                        let v5683:
                                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                                       anyhow::Error> =
                                                                                                                                                                            v5681.await;
                                                                                                                                                                        let v5684 =
                                                                                                                                                                            Spiral_wasm::method42();
                                                                                                                                                                        let v5686:
                                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                                       std::string::String> =
                                                                                                                                                                            v5683.map_err(|x| v5684(x));
                                                                                                                                                                        let v5687:
                                                                                                                                                                                Spiral_wasm::US6 =
                                                                                                                                                                            match &v5686
                                                                                                                                                                                {
                                                                                                                                                                                Err(v5686_1_0)
                                                                                                                                                                                =>
                                                                                                                                                                                v157(v5686_1_0.clone()),
                                                                                                                                                                                Ok(v5686_0_0)
                                                                                                                                                                                =>
                                                                                                                                                                                v156(v5686_0_0.clone()),
                                                                                                                                                                            };
                                                                                                                                                                        match &v5687
                                                                                                                                                                            {
                                                                                                                                                                            Spiral_wasm::US6::US6_0(v5687_0_0)
                                                                                                                                                                            =>
                                                                                                                                                                            {
                                                                                                                                                                                let v5688:
                                                                                                                                                                                        Spiral_wasm::US4 =
                                                                                                                                                                                    v5687_0_0.clone();
                                                                                                                                                                                match &v5688
                                                                                                                                                                                    {
                                                                                                                                                                                    Spiral_wasm::US4::US4_0(v5688_0_0)
                                                                                                                                                                                    =>
                                                                                                                                                                                    {
                                                                                                                                                                                        let v5716:
                                                                                                                                                                                                () =
                                                                                                                                                                                            {
                                                                                                                                                                                                Spiral_wasm::closure67(match &v5688
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
                                                                                                                                                                                        let v5830:
                                                                                                                                                                                                bool =
                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                        let v5832:
                                                                                                                                                                                                bool =
                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                        let v5833:
                                                                                                                                                                                                u8 =
                                                                                                                                                                                            Spiral_wasm::method61();
                                                                                                                                                                                        let v5837:
                                                                                                                                                                                                string =
                                                                                                                                                                                            string("true; v5833 });  // rust.fix_closure\'");
                                                                                                                                                                                        let v5838:
                                                                                                                                                                                                bool =
                                                                                                                                                                                            true; v5833 });  // rust.fix_closure';
                                                                                                                                                                                        let v5840 =
                                                                                                                                                                                            __future_init;
                                                                                                                                                                                        let v5842:
                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                            v5840;
                                                                                                                                                                                        let v5845:
                                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                                            Spiral_wasm::method47(v5842.await);
                                                                                                                                                                                        let v5847:
                                                                                                                                                                                                string =
                                                                                                                                                                                            string("true; v5845 });  // rust.fix_closure\'");
                                                                                                                                                                                        let v5848:
                                                                                                                                                                                                bool =
                                                                                                                                                                                            true; v5845 });  // rust.fix_closure';
                                                                                                                                                                                        let v5850 =
                                                                                                                                                                                            __future_init;
                                                                                                                                                                                        v5850
                                                                                                                                                                                    }
                                                                                                                                                                                    _
                                                                                                                                                                                    =>
                                                                                                                                                                                    {
                                                                                                                                                                                        let v5690:
                                                                                                                                                                                                bool =
                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                        let v5692:
                                                                                                                                                                                                bool =
                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                        let v5693:
                                                                                                                                                                                                u8 =
                                                                                                                                                                                            Spiral_wasm::method61();
                                                                                                                                                                                        let v5697:
                                                                                                                                                                                                string =
                                                                                                                                                                                            string("true; v5693 });  // rust.fix_closure\'");
                                                                                                                                                                                        let v5698:
                                                                                                                                                                                                bool =
                                                                                                                                                                                            true; v5693 });  // rust.fix_closure';
                                                                                                                                                                                        let v5700 =
                                                                                                                                                                                            __future_init;
                                                                                                                                                                                        let v5702:
                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                            v5700;
                                                                                                                                                                                        let v5705:
                                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                                            Spiral_wasm::method49(v5702.await);
                                                                                                                                                                                        let v5707:
                                                                                                                                                                                                string =
                                                                                                                                                                                            string("true; v5705 });  // rust.fix_closure\'");
                                                                                                                                                                                        let v5708:
                                                                                                                                                                                                bool =
                                                                                                                                                                                            true; v5705 });  // rust.fix_closure';
                                                                                                                                                                                        let v5710 =
                                                                                                                                                                                            __future_init;
                                                                                                                                                                                        v5710
                                                                                                                                                                                    }
                                                                                                                                                                                }
                                                                                                                                                                            }
                                                                                                                                                                            Spiral_wasm::US6::US6_1(v5687_1_0)
                                                                                                                                                                            =>
                                                                                                                                                                            {
                                                                                                                                                                                let v5858:
                                                                                                                                                                                        () =
                                                                                                                                                                                    {
                                                                                                                                                                                        Spiral_wasm::closure48(v5687_1_0.clone(),
                                                                                                                                                                                                               ());
                                                                                                                                                                                        ()
                                                                                                                                                                                    };
                                                                                                                                                                                let v5972:
                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                  anyhow::Error>>>> =
                                                                                                                                                                                    Spiral_wasm::method24(v148.clone(),
                                                                                                                                                                                                          21_u8);
                                                                                                                                                                                let v5974:
                                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                                               anyhow::Error> =
                                                                                                                                                                                    v5972.await;
                                                                                                                                                                                let v5975 =
                                                                                                                                                                                    Spiral_wasm::method42();
                                                                                                                                                                                let v5977:
                                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                                               std::string::String> =
                                                                                                                                                                                    v5974.map_err(|x| v5975(x));
                                                                                                                                                                                let v5978:
                                                                                                                                                                                        Spiral_wasm::US6 =
                                                                                                                                                                                    match &v5977
                                                                                                                                                                                        {
                                                                                                                                                                                        Err(v5977_1_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v157(v5977_1_0.clone()),
                                                                                                                                                                                        Ok(v5977_0_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v156(v5977_0_0.clone()),
                                                                                                                                                                                    };
                                                                                                                                                                                match &v5978
                                                                                                                                                                                    {
                                                                                                                                                                                    Spiral_wasm::US6::US6_0(v5978_0_0)
                                                                                                                                                                                    =>
                                                                                                                                                                                    {
                                                                                                                                                                                        let v5979:
                                                                                                                                                                                                Spiral_wasm::US4 =
                                                                                                                                                                                            v5978_0_0.clone();
                                                                                                                                                                                        match &v5979
                                                                                                                                                                                            {
                                                                                                                                                                                            Spiral_wasm::US4::US4_0(v5979_0_0)
                                                                                                                                                                                            =>
                                                                                                                                                                                            {
                                                                                                                                                                                                let v6007:
                                                                                                                                                                                                        () =
                                                                                                                                                                                                    {
                                                                                                                                                                                                        Spiral_wasm::closure66(match &v5979
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
                                                                                                                                                                                                let v6121:
                                                                                                                                                                                                        bool =
                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                let v6123:
                                                                                                                                                                                                        bool =
                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                let v6124:
                                                                                                                                                                                                        u8 =
                                                                                                                                                                                                    Spiral_wasm::method60();
                                                                                                                                                                                                let v6128:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    string("true; v6124 });  // rust.fix_closure\'");
                                                                                                                                                                                                let v6129:
                                                                                                                                                                                                        bool =
                                                                                                                                                                                                    true; v6124 });  // rust.fix_closure';
                                                                                                                                                                                                let v6131 =
                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                let v6133:
                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                    v6131;
                                                                                                                                                                                                let v6136:
                                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                                    Spiral_wasm::method47(v6133.await);
                                                                                                                                                                                                let v6138:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    string("true; v6136 });  // rust.fix_closure\'");
                                                                                                                                                                                                let v6139:
                                                                                                                                                                                                        bool =
                                                                                                                                                                                                    true; v6136 });  // rust.fix_closure';
                                                                                                                                                                                                let v6141 =
                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                v6141
                                                                                                                                                                                            }
                                                                                                                                                                                            _
                                                                                                                                                                                            =>
                                                                                                                                                                                            {
                                                                                                                                                                                                let v5981:
                                                                                                                                                                                                        bool =
                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                let v5983:
                                                                                                                                                                                                        bool =
                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                let v5984:
                                                                                                                                                                                                        u8 =
                                                                                                                                                                                                    Spiral_wasm::method60();
                                                                                                                                                                                                let v5988:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    string("true; v5984 });  // rust.fix_closure\'");
                                                                                                                                                                                                let v5989:
                                                                                                                                                                                                        bool =
                                                                                                                                                                                                    true; v5984 });  // rust.fix_closure';
                                                                                                                                                                                                let v5991 =
                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                let v5993:
                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                    v5991;
                                                                                                                                                                                                let v5996:
                                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                                    Spiral_wasm::method49(v5993.await);
                                                                                                                                                                                                let v5998:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    string("true; v5996 });  // rust.fix_closure\'");
                                                                                                                                                                                                let v5999:
                                                                                                                                                                                                        bool =
                                                                                                                                                                                                    true; v5996 });  // rust.fix_closure';
                                                                                                                                                                                                let v6001 =
                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                v6001
                                                                                                                                                                                            }
                                                                                                                                                                                        }
                                                                                                                                                                                    }
                                                                                                                                                                                    Spiral_wasm::US6::US6_1(v5978_1_0)
                                                                                                                                                                                    =>
                                                                                                                                                                                    {
                                                                                                                                                                                        let v6149:
                                                                                                                                                                                                () =
                                                                                                                                                                                            {
                                                                                                                                                                                                Spiral_wasm::closure49(v5978_1_0.clone(),
                                                                                                                                                                                                                       ());
                                                                                                                                                                                                ()
                                                                                                                                                                                            };
                                                                                                                                                                                        let v6263:
                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                          anyhow::Error>>>> =
                                                                                                                                                                                            Spiral_wasm::method24(v148.clone(),
                                                                                                                                                                                                                  22_u8);
                                                                                                                                                                                        let v6265:
                                                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                                                       anyhow::Error> =
                                                                                                                                                                                            v6263.await;
                                                                                                                                                                                        let v6266 =
                                                                                                                                                                                            Spiral_wasm::method42();
                                                                                                                                                                                        let v6268:
                                                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                                                       std::string::String> =
                                                                                                                                                                                            v6265.map_err(|x| v6266(x));
                                                                                                                                                                                        let v6269:
                                                                                                                                                                                                Spiral_wasm::US6 =
                                                                                                                                                                                            match &v6268
                                                                                                                                                                                                {
                                                                                                                                                                                                Err(v6268_1_0)
                                                                                                                                                                                                =>
                                                                                                                                                                                                v157(v6268_1_0.clone()),
                                                                                                                                                                                                Ok(v6268_0_0)
                                                                                                                                                                                                =>
                                                                                                                                                                                                v156(v6268_0_0.clone()),
                                                                                                                                                                                            };
                                                                                                                                                                                        match &v6269
                                                                                                                                                                                            {
                                                                                                                                                                                            Spiral_wasm::US6::US6_0(v6269_0_0)
                                                                                                                                                                                            =>
                                                                                                                                                                                            {
                                                                                                                                                                                                let v6270:
                                                                                                                                                                                                        Spiral_wasm::US4 =
                                                                                                                                                                                                    v6269_0_0.clone();
                                                                                                                                                                                                match &v6270
                                                                                                                                                                                                    {
                                                                                                                                                                                                    Spiral_wasm::US4::US4_0(v6270_0_0)
                                                                                                                                                                                                    =>
                                                                                                                                                                                                    {
                                                                                                                                                                                                        let v6298:
                                                                                                                                                                                                                () =
                                                                                                                                                                                                            {
                                                                                                                                                                                                                Spiral_wasm::closure65(match &v6270
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
                                                                                                                                                                                                        let v6412:
                                                                                                                                                                                                                bool =
                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                        let v6414:
                                                                                                                                                                                                                bool =
                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                        let v6415:
                                                                                                                                                                                                                u8 =
                                                                                                                                                                                                            Spiral_wasm::method59();
                                                                                                                                                                                                        let v6419:
                                                                                                                                                                                                                string =
                                                                                                                                                                                                            string("true; v6415 });  // rust.fix_closure\'");
                                                                                                                                                                                                        let v6420:
                                                                                                                                                                                                                bool =
                                                                                                                                                                                                            true; v6415 });  // rust.fix_closure';
                                                                                                                                                                                                        let v6422 =
                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                        let v6424:
                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                            v6422;
                                                                                                                                                                                                        let v6427:
                                                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                                                            Spiral_wasm::method47(v6424.await);
                                                                                                                                                                                                        let v6429:
                                                                                                                                                                                                                string =
                                                                                                                                                                                                            string("true; v6427 });  // rust.fix_closure\'");
                                                                                                                                                                                                        let v6430:
                                                                                                                                                                                                                bool =
                                                                                                                                                                                                            true; v6427 });  // rust.fix_closure';
                                                                                                                                                                                                        let v6432 =
                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                        v6432
                                                                                                                                                                                                    }
                                                                                                                                                                                                    _
                                                                                                                                                                                                    =>
                                                                                                                                                                                                    {
                                                                                                                                                                                                        let v6272:
                                                                                                                                                                                                                bool =
                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                        let v6274:
                                                                                                                                                                                                                bool =
                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                        let v6275:
                                                                                                                                                                                                                u8 =
                                                                                                                                                                                                            Spiral_wasm::method59();
                                                                                                                                                                                                        let v6279:
                                                                                                                                                                                                                string =
                                                                                                                                                                                                            string("true; v6275 });  // rust.fix_closure\'");
                                                                                                                                                                                                        let v6280:
                                                                                                                                                                                                                bool =
                                                                                                                                                                                                            true; v6275 });  // rust.fix_closure';
                                                                                                                                                                                                        let v6282 =
                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                        let v6284:
                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                            v6282;
                                                                                                                                                                                                        let v6287:
                                                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                                                            Spiral_wasm::method49(v6284.await);
                                                                                                                                                                                                        let v6289:
                                                                                                                                                                                                                string =
                                                                                                                                                                                                            string("true; v6287 });  // rust.fix_closure\'");
                                                                                                                                                                                                        let v6290:
                                                                                                                                                                                                                bool =
                                                                                                                                                                                                            true; v6287 });  // rust.fix_closure';
                                                                                                                                                                                                        let v6292 =
                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                        v6292
                                                                                                                                                                                                    }
                                                                                                                                                                                                }
                                                                                                                                                                                            }
                                                                                                                                                                                            Spiral_wasm::US6::US6_1(v6269_1_0)
                                                                                                                                                                                            =>
                                                                                                                                                                                            {
                                                                                                                                                                                                let v6440:
                                                                                                                                                                                                        () =
                                                                                                                                                                                                    {
                                                                                                                                                                                                        Spiral_wasm::closure50(v6269_1_0.clone(),
                                                                                                                                                                                                                               ());
                                                                                                                                                                                                        ()
                                                                                                                                                                                                    };
                                                                                                                                                                                                let v6554:
                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                                  anyhow::Error>>>> =
                                                                                                                                                                                                    Spiral_wasm::method24(v148.clone(),
                                                                                                                                                                                                                          23_u8);
                                                                                                                                                                                                let v6556:
                                                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                                                               anyhow::Error> =
                                                                                                                                                                                                    v6554.await;
                                                                                                                                                                                                let v6557 =
                                                                                                                                                                                                    Spiral_wasm::method42();
                                                                                                                                                                                                let v6559:
                                                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                                                               std::string::String> =
                                                                                                                                                                                                    v6556.map_err(|x| v6557(x));
                                                                                                                                                                                                let v6560:
                                                                                                                                                                                                        Spiral_wasm::US6 =
                                                                                                                                                                                                    match &v6559
                                                                                                                                                                                                        {
                                                                                                                                                                                                        Err(v6559_1_0)
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        v157(v6559_1_0.clone()),
                                                                                                                                                                                                        Ok(v6559_0_0)
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        v156(v6559_0_0.clone()),
                                                                                                                                                                                                    };
                                                                                                                                                                                                match &v6560
                                                                                                                                                                                                    {
                                                                                                                                                                                                    Spiral_wasm::US6::US6_0(v6560_0_0)
                                                                                                                                                                                                    =>
                                                                                                                                                                                                    {
                                                                                                                                                                                                        let v6561:
                                                                                                                                                                                                                Spiral_wasm::US4 =
                                                                                                                                                                                                            v6560_0_0.clone();
                                                                                                                                                                                                        match &v6561
                                                                                                                                                                                                            {
                                                                                                                                                                                                            Spiral_wasm::US4::US4_0(v6561_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            {
                                                                                                                                                                                                                let v6589:
                                                                                                                                                                                                                        () =
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        Spiral_wasm::closure64(match &v6561
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
                                                                                                                                                                                                                let v6703:
                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                let v6705:
                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                let v6706:
                                                                                                                                                                                                                        u8 =
                                                                                                                                                                                                                    Spiral_wasm::method58();
                                                                                                                                                                                                                let v6710:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    string("true; v6706 });  // rust.fix_closure\'");
                                                                                                                                                                                                                let v6711:
                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                    true; v6706 });  // rust.fix_closure';
                                                                                                                                                                                                                let v6713 =
                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                let v6715:
                                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                    v6713;
                                                                                                                                                                                                                let v6718:
                                                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                                                    Spiral_wasm::method47(v6715.await);
                                                                                                                                                                                                                let v6720:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    string("true; v6718 });  // rust.fix_closure\'");
                                                                                                                                                                                                                let v6721:
                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                    true; v6718 });  // rust.fix_closure';
                                                                                                                                                                                                                let v6723 =
                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                v6723
                                                                                                                                                                                                            }
                                                                                                                                                                                                            _
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            {
                                                                                                                                                                                                                let v6563:
                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                let v6565:
                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                let v6566:
                                                                                                                                                                                                                        u8 =
                                                                                                                                                                                                                    Spiral_wasm::method58();
                                                                                                                                                                                                                let v6570:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    string("true; v6566 });  // rust.fix_closure\'");
                                                                                                                                                                                                                let v6571:
                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                    true; v6566 });  // rust.fix_closure';
                                                                                                                                                                                                                let v6573 =
                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                let v6575:
                                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                    v6573;
                                                                                                                                                                                                                let v6578:
                                                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                                                    Spiral_wasm::method49(v6575.await);
                                                                                                                                                                                                                let v6580:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    string("true; v6578 });  // rust.fix_closure\'");
                                                                                                                                                                                                                let v6581:
                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                    true; v6578 });  // rust.fix_closure';
                                                                                                                                                                                                                let v6583 =
                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                v6583
                                                                                                                                                                                                            }
                                                                                                                                                                                                        }
                                                                                                                                                                                                    }
                                                                                                                                                                                                    Spiral_wasm::US6::US6_1(v6560_1_0)
                                                                                                                                                                                                    =>
                                                                                                                                                                                                    {
                                                                                                                                                                                                        let v6731:
                                                                                                                                                                                                                () =
                                                                                                                                                                                                            {
                                                                                                                                                                                                                Spiral_wasm::closure51(v6560_1_0.clone(),
                                                                                                                                                                                                                                       ());
                                                                                                                                                                                                                ()
                                                                                                                                                                                                            };
                                                                                                                                                                                                        let v6845:
                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                                          anyhow::Error>>>> =
                                                                                                                                                                                                            Spiral_wasm::method24(v148.clone(),
                                                                                                                                                                                                                                  24_u8);
                                                                                                                                                                                                        let v6847:
                                                                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                                                                       anyhow::Error> =
                                                                                                                                                                                                            v6845.await;
                                                                                                                                                                                                        let v6848 =
                                                                                                                                                                                                            Spiral_wasm::method42();
                                                                                                                                                                                                        let v6850:
                                                                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                                                                       std::string::String> =
                                                                                                                                                                                                            v6847.map_err(|x| v6848(x));
                                                                                                                                                                                                        let v6851:
                                                                                                                                                                                                                Spiral_wasm::US6 =
                                                                                                                                                                                                            match &v6850
                                                                                                                                                                                                                {
                                                                                                                                                                                                                Err(v6850_1_0)
                                                                                                                                                                                                                =>
                                                                                                                                                                                                                v157(v6850_1_0.clone()),
                                                                                                                                                                                                                Ok(v6850_0_0)
                                                                                                                                                                                                                =>
                                                                                                                                                                                                                v156(v6850_0_0.clone()),
                                                                                                                                                                                                            };
                                                                                                                                                                                                        match &v6851
                                                                                                                                                                                                            {
                                                                                                                                                                                                            Spiral_wasm::US6::US6_0(v6851_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            {
                                                                                                                                                                                                                let v6852:
                                                                                                                                                                                                                        Spiral_wasm::US4 =
                                                                                                                                                                                                                    v6851_0_0.clone();
                                                                                                                                                                                                                match &v6852
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                    Spiral_wasm::US4::US4_0(v6852_0_0)
                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        let v6880:
                                                                                                                                                                                                                                () =
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                Spiral_wasm::closure63(match &v6852
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
                                                                                                                                                                                                                        let v6994:
                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                        let v6996:
                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                        let v6997:
                                                                                                                                                                                                                                u8 =
                                                                                                                                                                                                                            Spiral_wasm::method57();
                                                                                                                                                                                                                        let v7001:
                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                            string("true; v6997 });  // rust.fix_closure\'");
                                                                                                                                                                                                                        let v7002:
                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                            true; v6997 });  // rust.fix_closure';
                                                                                                                                                                                                                        let v7004 =
                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                        let v7006:
                                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                            v7004;
                                                                                                                                                                                                                        let v7009:
                                                                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                                                                            Spiral_wasm::method47(v7006.await);
                                                                                                                                                                                                                        let v7011:
                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                            string("true; v7009 });  // rust.fix_closure\'");
                                                                                                                                                                                                                        let v7012:
                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                            true; v7009 });  // rust.fix_closure';
                                                                                                                                                                                                                        let v7014 =
                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                        v7014
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                    _
                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        let v6854:
                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                        let v6856:
                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                        let v6857:
                                                                                                                                                                                                                                u8 =
                                                                                                                                                                                                                            Spiral_wasm::method57();
                                                                                                                                                                                                                        let v6861:
                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                            string("true; v6857 });  // rust.fix_closure\'");
                                                                                                                                                                                                                        let v6862:
                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                            true; v6857 });  // rust.fix_closure';
                                                                                                                                                                                                                        let v6864 =
                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                        let v6866:
                                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                            v6864;
                                                                                                                                                                                                                        let v6869:
                                                                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                                                                            Spiral_wasm::method49(v6866.await);
                                                                                                                                                                                                                        let v6871:
                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                            string("true; v6869 });  // rust.fix_closure\'");
                                                                                                                                                                                                                        let v6872:
                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                            true; v6869 });  // rust.fix_closure';
                                                                                                                                                                                                                        let v6874 =
                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                        v6874
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                }
                                                                                                                                                                                                            }
                                                                                                                                                                                                            Spiral_wasm::US6::US6_1(v6851_1_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            {
                                                                                                                                                                                                                let v7022:
                                                                                                                                                                                                                        () =
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        Spiral_wasm::closure52(v6851_1_0.clone(),
                                                                                                                                                                                                                                               ());
                                                                                                                                                                                                                        ()
                                                                                                                                                                                                                    };
                                                                                                                                                                                                                let v7136:
                                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                                                  anyhow::Error>>>> =
                                                                                                                                                                                                                    Spiral_wasm::method24(v148.clone(),
                                                                                                                                                                                                                                          25_u8);
                                                                                                                                                                                                                let v7138:
                                                                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                                                                               anyhow::Error> =
                                                                                                                                                                                                                    v7136.await;
                                                                                                                                                                                                                let v7139 =
                                                                                                                                                                                                                    Spiral_wasm::method42();
                                                                                                                                                                                                                let v7141:
                                                                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                                                                               std::string::String> =
                                                                                                                                                                                                                    v7138.map_err(|x| v7139(x));
                                                                                                                                                                                                                let v7142:
                                                                                                                                                                                                                        Spiral_wasm::US6 =
                                                                                                                                                                                                                    match &v7141
                                                                                                                                                                                                                        {
                                                                                                                                                                                                                        Err(v7141_1_0)
                                                                                                                                                                                                                        =>
                                                                                                                                                                                                                        v157(v7141_1_0.clone()),
                                                                                                                                                                                                                        Ok(v7141_0_0)
                                                                                                                                                                                                                        =>
                                                                                                                                                                                                                        v156(v7141_0_0.clone()),
                                                                                                                                                                                                                    };
                                                                                                                                                                                                                match &v7142
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                    Spiral_wasm::US6::US6_0(v7142_0_0)
                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        let v7143:
                                                                                                                                                                                                                                Spiral_wasm::US4 =
                                                                                                                                                                                                                            v7142_0_0.clone();
                                                                                                                                                                                                                        match &v7143
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                            Spiral_wasm::US4::US4_0(v7143_0_0)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                let v7171:
                                                                                                                                                                                                                                        () =
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        Spiral_wasm::closure62(match &v7143
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
                                                                                                                                                                                                                                let v7285:
                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                let v7287:
                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                let v7288:
                                                                                                                                                                                                                                        u8 =
                                                                                                                                                                                                                                    Spiral_wasm::method56();
                                                                                                                                                                                                                                let v7292:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    string("true; v7288 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                let v7293:
                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                    true; v7288 });  // rust.fix_closure';
                                                                                                                                                                                                                                let v7295 =
                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                let v7297:
                                                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                                    v7295;
                                                                                                                                                                                                                                let v7300:
                                                                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                                                                    Spiral_wasm::method47(v7297.await);
                                                                                                                                                                                                                                let v7302:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    string("true; v7300 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                let v7303:
                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                    true; v7300 });  // rust.fix_closure';
                                                                                                                                                                                                                                let v7305 =
                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                v7305
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                            _
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                let v7145:
                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                let v7147:
                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                let v7148:
                                                                                                                                                                                                                                        u8 =
                                                                                                                                                                                                                                    Spiral_wasm::method56();
                                                                                                                                                                                                                                let v7152:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    string("true; v7148 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                let v7153:
                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                    true; v7148 });  // rust.fix_closure';
                                                                                                                                                                                                                                let v7155 =
                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                let v7157:
                                                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                                    v7155;
                                                                                                                                                                                                                                let v7160:
                                                                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                                                                    Spiral_wasm::method49(v7157.await);
                                                                                                                                                                                                                                let v7162:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    string("true; v7160 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                let v7163:
                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                    true; v7160 });  // rust.fix_closure';
                                                                                                                                                                                                                                let v7165 =
                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                v7165
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                    Spiral_wasm::US6::US6_1(v7142_1_0)
                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        let v7313:
                                                                                                                                                                                                                                () =
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                Spiral_wasm::closure53(v7142_1_0.clone(),
                                                                                                                                                                                                                                                       ());
                                                                                                                                                                                                                                ()
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        let v7427:
                                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                                                          anyhow::Error>>>> =
                                                                                                                                                                                                                            Spiral_wasm::method24(v148.clone(),
                                                                                                                                                                                                                                                  26_u8);
                                                                                                                                                                                                                        let v7429:
                                                                                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                       anyhow::Error> =
                                                                                                                                                                                                                            v7427.await;
                                                                                                                                                                                                                        let v7430 =
                                                                                                                                                                                                                            Spiral_wasm::method42();
                                                                                                                                                                                                                        let v7432:
                                                                                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                       std::string::String> =
                                                                                                                                                                                                                            v7429.map_err(|x| v7430(x));
                                                                                                                                                                                                                        let v7433:
                                                                                                                                                                                                                                Spiral_wasm::US6 =
                                                                                                                                                                                                                            match &v7432
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                Err(v7432_1_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v157(v7432_1_0.clone()),
                                                                                                                                                                                                                                Ok(v7432_0_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v156(v7432_0_0.clone()),
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        match &v7433
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                            Spiral_wasm::US6::US6_0(v7433_0_0)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                let v7434:
                                                                                                                                                                                                                                        Spiral_wasm::US4 =
                                                                                                                                                                                                                                    v7433_0_0.clone();
                                                                                                                                                                                                                                match &v7434
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                    Spiral_wasm::US4::US4_0(v7434_0_0)
                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        let v7462:
                                                                                                                                                                                                                                                () =
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                Spiral_wasm::closure61(match &v7434
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
                                                                                                                                                                                                                                        let v7576:
                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                        let v7578:
                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                        let v7579:
                                                                                                                                                                                                                                                u8 =
                                                                                                                                                                                                                                            Spiral_wasm::method55();
                                                                                                                                                                                                                                        let v7583:
                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                            string("true; v7579 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                        let v7584:
                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                            true; v7579 });  // rust.fix_closure';
                                                                                                                                                                                                                                        let v7586 =
                                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                                        let v7588:
                                                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                                            v7586;
                                                                                                                                                                                                                                        let v7591:
                                                                                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                                                                                            Spiral_wasm::method47(v7588.await);
                                                                                                                                                                                                                                        let v7593:
                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                            string("true; v7591 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                        let v7594:
                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                            true; v7591 });  // rust.fix_closure';
                                                                                                                                                                                                                                        let v7596 =
                                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                                        v7596
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                    _
                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        let v7436:
                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                        let v7438:
                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                        let v7439:
                                                                                                                                                                                                                                                u8 =
                                                                                                                                                                                                                                            Spiral_wasm::method55();
                                                                                                                                                                                                                                        let v7443:
                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                            string("true; v7439 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                        let v7444:
                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                            true; v7439 });  // rust.fix_closure';
                                                                                                                                                                                                                                        let v7446 =
                                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                                        let v7448:
                                                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                                            v7446;
                                                                                                                                                                                                                                        let v7451:
                                                                                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                                                                                            Spiral_wasm::method49(v7448.await);
                                                                                                                                                                                                                                        let v7453:
                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                            string("true; v7451 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                        let v7454:
                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                            true; v7451 });  // rust.fix_closure';
                                                                                                                                                                                                                                        let v7456 =
                                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                                        v7456
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                            Spiral_wasm::US6::US6_1(v7433_1_0)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                let v7604:
                                                                                                                                                                                                                                        () =
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        Spiral_wasm::closure54(v7433_1_0.clone(),
                                                                                                                                                                                                                                                               ());
                                                                                                                                                                                                                                        ()
                                                                                                                                                                                                                                    };
                                                                                                                                                                                                                                let v7718:
                                                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                                                                  anyhow::Error>>>> =
                                                                                                                                                                                                                                    Spiral_wasm::method24(v148.clone(),
                                                                                                                                                                                                                                                          27_u8);
                                                                                                                                                                                                                                let v7720:
                                                                                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                               anyhow::Error> =
                                                                                                                                                                                                                                    v7718.await;
                                                                                                                                                                                                                                let v7721 =
                                                                                                                                                                                                                                    Spiral_wasm::method42();
                                                                                                                                                                                                                                let v7723:
                                                                                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                               std::string::String> =
                                                                                                                                                                                                                                    v7720.map_err(|x| v7721(x));
                                                                                                                                                                                                                                let v7724:
                                                                                                                                                                                                                                        Spiral_wasm::US6 =
                                                                                                                                                                                                                                    match &v7723
                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                        Err(v7723_1_0)
                                                                                                                                                                                                                                        =>
                                                                                                                                                                                                                                        v157(v7723_1_0.clone()),
                                                                                                                                                                                                                                        Ok(v7723_0_0)
                                                                                                                                                                                                                                        =>
                                                                                                                                                                                                                                        v156(v7723_0_0.clone()),
                                                                                                                                                                                                                                    };
                                                                                                                                                                                                                                match &v7724
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                    Spiral_wasm::US6::US6_0(v7724_0_0)
                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        let v7725:
                                                                                                                                                                                                                                                Spiral_wasm::US4 =
                                                                                                                                                                                                                                            v7724_0_0.clone();
                                                                                                                                                                                                                                        match &v7725
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                            Spiral_wasm::US4::US4_0(v7725_0_0)
                                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                let v7753:
                                                                                                                                                                                                                                                        () =
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        Spiral_wasm::closure60(match &v7725
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
                                                                                                                                                                                                                                                let v7867:
                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                let v7869:
                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                let v7870:
                                                                                                                                                                                                                                                        u8 =
                                                                                                                                                                                                                                                    Spiral_wasm::method54();
                                                                                                                                                                                                                                                let v7874:
                                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                                    string("true; v7870 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                let v7875:
                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                    true; v7870 });  // rust.fix_closure';
                                                                                                                                                                                                                                                let v7877 =
                                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                                let v7879:
                                                                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                                                    v7877;
                                                                                                                                                                                                                                                let v7882:
                                                                                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                                                                                    Spiral_wasm::method47(v7879.await);
                                                                                                                                                                                                                                                let v7884:
                                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                                    string("true; v7882 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                let v7885:
                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                    true; v7882 });  // rust.fix_closure';
                                                                                                                                                                                                                                                let v7887 =
                                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                                v7887
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                            _
                                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                let v7727:
                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                let v7729:
                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                let v7730:
                                                                                                                                                                                                                                                        u8 =
                                                                                                                                                                                                                                                    Spiral_wasm::method54();
                                                                                                                                                                                                                                                let v7734:
                                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                                    string("true; v7730 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                let v7735:
                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                    true; v7730 });  // rust.fix_closure';
                                                                                                                                                                                                                                                let v7737 =
                                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                                let v7739:
                                                                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                                                    v7737;
                                                                                                                                                                                                                                                let v7742:
                                                                                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                                                                                    Spiral_wasm::method49(v7739.await);
                                                                                                                                                                                                                                                let v7744:
                                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                                    string("true; v7742 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                let v7745:
                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                    true; v7742 });  // rust.fix_closure';
                                                                                                                                                                                                                                                let v7747 =
                                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                                v7747
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                    Spiral_wasm::US6::US6_1(v7724_1_0)
                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        let v7895:
                                                                                                                                                                                                                                                () =
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                Spiral_wasm::closure55(v7724_1_0.clone(),
                                                                                                                                                                                                                                                                       ());
                                                                                                                                                                                                                                                ()
                                                                                                                                                                                                                                            };
                                                                                                                                                                                                                                        let v8009:
                                                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                                                                          anyhow::Error>>>> =
                                                                                                                                                                                                                                            Spiral_wasm::method24(v148.clone(),
                                                                                                                                                                                                                                                                  28_u8);
                                                                                                                                                                                                                                        let v8011:
                                                                                                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                       anyhow::Error> =
                                                                                                                                                                                                                                            v8009.await;
                                                                                                                                                                                                                                        let v8012 =
                                                                                                                                                                                                                                            Spiral_wasm::method42();
                                                                                                                                                                                                                                        let v8014:
                                                                                                                                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                       std::string::String> =
                                                                                                                                                                                                                                            v8011.map_err(|x| v8012(x));
                                                                                                                                                                                                                                        let v8015:
                                                                                                                                                                                                                                                Spiral_wasm::US6 =
                                                                                                                                                                                                                                            match &v8014
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                Err(v8014_1_0)
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                v157(v8014_1_0.clone()),
                                                                                                                                                                                                                                                Ok(v8014_0_0)
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                v156(v8014_0_0.clone()),
                                                                                                                                                                                                                                            };
                                                                                                                                                                                                                                        match &v8015
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                            Spiral_wasm::US6::US6_0(v8015_0_0)
                                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                let v8016:
                                                                                                                                                                                                                                                        Spiral_wasm::US4 =
                                                                                                                                                                                                                                                    v8015_0_0.clone();
                                                                                                                                                                                                                                                match &v8016
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    Spiral_wasm::US4::US4_0(v8016_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        let v8044:
                                                                                                                                                                                                                                                                () =
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                Spiral_wasm::closure59(match &v8016
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
                                                                                                                                                                                                                                                        let v8158:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                        let v8160:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                        let v8161:
                                                                                                                                                                                                                                                                u8 =
                                                                                                                                                                                                                                                            Spiral_wasm::method53();
                                                                                                                                                                                                                                                        let v8165:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            string("true; v8161 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                        let v8166:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; v8161 });  // rust.fix_closure';
                                                                                                                                                                                                                                                        let v8168 =
                                                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                                                        let v8170:
                                                                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                                                            v8168;
                                                                                                                                                                                                                                                        let v8173:
                                                                                                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                                                                                                            Spiral_wasm::method47(v8170.await);
                                                                                                                                                                                                                                                        let v8175:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            string("true; v8173 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                        let v8176:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; v8173 });  // rust.fix_closure';
                                                                                                                                                                                                                                                        let v8178 =
                                                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                                                        v8178
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                    _
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        let v8018:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                        let v8020:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                        let v8021:
                                                                                                                                                                                                                                                                u8 =
                                                                                                                                                                                                                                                            Spiral_wasm::method53();
                                                                                                                                                                                                                                                        let v8025:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            string("true; v8021 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                        let v8026:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; v8021 });  // rust.fix_closure';
                                                                                                                                                                                                                                                        let v8028 =
                                                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                                                        let v8030:
                                                                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                                                            v8028;
                                                                                                                                                                                                                                                        let v8033:
                                                                                                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                                                                                                            Spiral_wasm::method49(v8030.await);
                                                                                                                                                                                                                                                        let v8035:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            string("true; v8033 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                        let v8036:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; v8033 });  // rust.fix_closure';
                                                                                                                                                                                                                                                        let v8038 =
                                                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                                                        v8038
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                            Spiral_wasm::US6::US6_1(v8015_1_0)
                                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                let v8186:
                                                                                                                                                                                                                                                        () =
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        Spiral_wasm::closure56(v8015_1_0.clone(),
                                                                                                                                                                                                                                                                               ());
                                                                                                                                                                                                                                                        ()
                                                                                                                                                                                                                                                    };
                                                                                                                                                                                                                                                let v8300:
                                                                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                                                                                  anyhow::Error>>>> =
                                                                                                                                                                                                                                                    Spiral_wasm::method24(v148.clone(),
                                                                                                                                                                                                                                                                          29_u8);
                                                                                                                                                                                                                                                let v8302:
                                                                                                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                               anyhow::Error> =
                                                                                                                                                                                                                                                    v8300.await;
                                                                                                                                                                                                                                                let v8303 =
                                                                                                                                                                                                                                                    Spiral_wasm::method42();
                                                                                                                                                                                                                                                let v8305:
                                                                                                                                                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                                                                                                                                                               std::string::String> =
                                                                                                                                                                                                                                                    v8302.map_err(|x| v8303(x));
                                                                                                                                                                                                                                                let v8306:
                                                                                                                                                                                                                                                        Spiral_wasm::US6 =
                                                                                                                                                                                                                                                    match &v8305
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                        Err(v8305_1_0)
                                                                                                                                                                                                                                                        =>
                                                                                                                                                                                                                                                        v157(v8305_1_0.clone()),
                                                                                                                                                                                                                                                        Ok(v8305_0_0)
                                                                                                                                                                                                                                                        =>
                                                                                                                                                                                                                                                        v156(v8305_0_0.clone()),
                                                                                                                                                                                                                                                    };
                                                                                                                                                                                                                                                match &v8306
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    Spiral_wasm::US6::US6_0(v8306_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        let v8307:
                                                                                                                                                                                                                                                                Spiral_wasm::US4 =
                                                                                                                                                                                                                                                            v8306_0_0.clone();
                                                                                                                                                                                                                                                        match &v8307
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                            Spiral_wasm::US4::US4_0(v8307_0_0)
                                                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                let v8335:
                                                                                                                                                                                                                                                                        () =
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        Spiral_wasm::closure58(match &v8307
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
                                                                                                                                                                                                                                                                let v8449:
                                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                                let v8451:
                                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                                let v8452:
                                                                                                                                                                                                                                                                        u8 =
                                                                                                                                                                                                                                                                    Spiral_wasm::method48();
                                                                                                                                                                                                                                                                let v8456:
                                                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                                                    string("true; v8452 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                                let v8457:
                                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                                    true; v8452 });  // rust.fix_closure';
                                                                                                                                                                                                                                                                let v8459 =
                                                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                                                let v8461:
                                                                                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                                                                    v8459;
                                                                                                                                                                                                                                                                let v8464:
                                                                                                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                                                                                                    Spiral_wasm::method47(v8461.await);
                                                                                                                                                                                                                                                                let v8466:
                                                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                                                    string("true; v8464 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                                let v8467:
                                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                                    true; v8464 });  // rust.fix_closure';
                                                                                                                                                                                                                                                                let v8469 =
                                                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                                                v8469
                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                            _
                                                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                let v8309:
                                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                                let v8311:
                                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                                let v8312:
                                                                                                                                                                                                                                                                        u8 =
                                                                                                                                                                                                                                                                    Spiral_wasm::method48();
                                                                                                                                                                                                                                                                let v8316:
                                                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                                                    string("true; v8312 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                                let v8317:
                                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                                    true; v8312 });  // rust.fix_closure';
                                                                                                                                                                                                                                                                let v8319 =
                                                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                                                let v8321:
                                                                                                                                                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                                                                    v8319;
                                                                                                                                                                                                                                                                let v8324:
                                                                                                                                                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                                                                                                                                                    Spiral_wasm::method49(v8321.await);
                                                                                                                                                                                                                                                                let v8326:
                                                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                                                    string("true; v8324 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                                let v8327:
                                                                                                                                                                                                                                                                        bool =
                                                                                                                                                                                                                                                                    true; v8324 });  // rust.fix_closure';
                                                                                                                                                                                                                                                                let v8329 =
                                                                                                                                                                                                                                                                    __future_init;
                                                                                                                                                                                                                                                                v8329
                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                    Spiral_wasm::US6::US6_1(v8306_1_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        let v8477:
                                                                                                                                                                                                                                                                () =
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                Spiral_wasm::closure57(v8306_1_0.clone(),
                                                                                                                                                                                                                                                                                       ());
                                                                                                                                                                                                                                                                ()
                                                                                                                                                                                                                                                            };
                                                                                                                                                                                                                                                        let v8591:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                        let v8593:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                                                                                                                                        let v8594:
                                                                                                                                                                                                                                                                u8 =
                                                                                                                                                                                                                                                            Spiral_wasm::method46();
                                                                                                                                                                                                                                                        let v8598:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            string("true; v8594 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                        let v8599:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; v8594 });  // rust.fix_closure';
                                                                                                                                                                                                                                                        let v8601 =
                                                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                                                        let v8603:
                                                                                                                                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                                                                                                                                            v8601;
                                                                                                                                                                                                                                                        let v8606:
                                                                                                                                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                                                                                                                                            Spiral_wasm::method47(v8603.await);
                                                                                                                                                                                                                                                        let v8608:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            string("true; v8606 });  // rust.fix_closure\'");
                                                                                                                                                                                                                                                        let v8609:
                                                                                                                                                                                                                                                                bool =
                                                                                                                                                                                                                                                            true; v8606 });  // rust.fix_closure';
                                                                                                                                                                                                                                                        let v8611 =
                                                                                                                                                                                                                                                            __future_init;
                                                                                                                                                                                                                                                        v8611
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
                let v8673: Spiral_wasm::US7 = v8671.await;
                let v8676: () = {
                    Spiral_wasm::closure87(v8673.clone(), ());
                    ()
                };
                let v8798: Result<u8, anyhow::Error> = Spiral_wasm::method83(match &v8673 {
                    Spiral_wasm::US7::US7_0(v8673_0_0) => {
                        Ok::<u8, anyhow::Error>(v8673_0_0.clone())
                    }
                    Spiral_wasm::US7::US7_1(v8673_1_0) => {
                        let v8791: string = Spiral_wasm::method82(v8673_1_0.clone());
                        let v8793: anyhow::Error = anyhow::anyhow!(v8791);
                        Err(v8793)
                    }
                });
                let v8802: string = string("true; v8798 });  // rust.fix_closure\'");
                let v8803: bool = true;
                v8798
            }); // rust.fix_closure';
            let v8805 = __future_init;
            v8805
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
            let v6: &str = &*v4;
            let v8: Option<std::string::String> =
                clap::ArgMatches::get_one(&v3.clone(), v6).cloned();
            let v22: Spiral_wasm::US0 =
                defaultValue(Spiral_wasm::US0::US0_1, map(Spiral_wasm::method2(), v8));
            let v78: Spiral_wasm::US1 = match &v22 {
                Spiral_wasm::US0::US0_0(v22_0_0) => {
                    let v28: string = fable_library_rust::String_::fromString(match &v22 {
                        Spiral_wasm::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    });
                    let v33: Spiral_wasm::US2 = if string("Verbose") == v28.clone() {
                        Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_0)
                    } else {
                        Spiral_wasm::US2::US2_1
                    };
                    Spiral_wasm::US1::US1_0(match &v33 {
                        Spiral_wasm::US2::US2_0(v33_0_0) => Spiral_wasm::US2::US2_0(match &v33 {
                            Spiral_wasm::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v40: Spiral_wasm::US2 = if string("Debug") == v28.clone() {
                                Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_1)
                            } else {
                                Spiral_wasm::US2::US2_1
                            };
                            match &v40 {
                                Spiral_wasm::US2::US2_0(v40_0_0) => {
                                    Spiral_wasm::US2::US2_0(match &v40 {
                                        Spiral_wasm::US2::US2_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v47: Spiral_wasm::US2 = if string("Info") == v28.clone() {
                                        Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_2)
                                    } else {
                                        Spiral_wasm::US2::US2_1
                                    };
                                    match &v47 {
                                        Spiral_wasm::US2::US2_0(v47_0_0) => {
                                            Spiral_wasm::US2::US2_0(match &v47 {
                                                Spiral_wasm::US2::US2_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v54: Spiral_wasm::US2 =
                                                if string("Warning") == v28.clone() {
                                                    Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_3)
                                                } else {
                                                    Spiral_wasm::US2::US2_1
                                                };
                                            match &v54 {
                                                Spiral_wasm::US2::US2_0(v54_0_0) => {
                                                    Spiral_wasm::US2::US2_0(match &v54 {
                                                        Spiral_wasm::US2::US2_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v61: Spiral_wasm::US2 =
                                                        if string("Critical") == v28.clone() {
                                                            Spiral_wasm::US2::US2_0(
                                                                Spiral_wasm::US3::US3_4,
                                                            )
                                                        } else {
                                                            Spiral_wasm::US2::US2_1
                                                        };
                                                    match &v61 {
                                                        Spiral_wasm::US2::US2_0(v61_0_0) => {
                                                            Spiral_wasm::US2::US2_0(match &v61 {
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
            let v85: Spiral_wasm::US2 = if let Spiral_wasm::US1::US1_0(v78_0_0) = &v78 {
                let v79: Spiral_wasm::US2 = match &v78 {
                    Spiral_wasm::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                };
                if let Spiral_wasm::US2::US2_0(v79_0_0) = &v79 {
                    Spiral_wasm::US2::US2_0(match &v79 {
                        Spiral_wasm::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    })
                } else {
                    Spiral_wasm::US2::US2_1
                }
            } else {
                Spiral_wasm::US2::US2_1
            };
            let v92: () = {
                Spiral_wasm::closure2(
                    match &v85 {
                        Spiral_wasm::US2::US2_0(v85_0_0) => match &v85 {
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
            let v124: () = {
                Spiral_wasm::closure5(v0_1, ());
                ()
            };
            let v240: string = Spiral_wasm::method19();
            let v242: &str = &*v240;
            let v244: bool = clap::ArgMatches::get_flag(&v3, v242);
            let v245: std::pin::Pin<
                Box<dyn std::future::Future<Output = Result<u8, anyhow::Error>>>,
            > = Spiral_wasm::method20(v3);
            let v247 = tokio::runtime::Builder::new_multi_thread()
                .enable_all()
                .build()
                .unwrap();
            let v249: Result<u8, anyhow::Error> = v247.handle().block_on(v245);
            let v250 = Spiral_wasm::method42();
            let v252: Result<u8, std::string::String> = v249.map_err(|x| v250(x));
            let v254: Option<u8> = v252.clone().ok();
            let v268: Spiral_wasm::US8 =
                defaultValue(Spiral_wasm::US8::US8_1, map(Spiral_wasm::method84(), v254));
            match &v268 {
                Spiral_wasm::US8::US8_0(v268_0_0) => {
                    if v244 {
                        let v275: Result<(), string> =
                            Err(string("spiral_wasm.main / exception=true"));
                        v275.unwrap();
                        ()
                    }
                }
                _ => {
                    if v244 {
                        ()
                    } else {
                        let v278: u8 = v252.unwrap();
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
