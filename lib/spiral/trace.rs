pub mod Trace {
    use super::*;
    use fable_library_rust::DateTime_::DateTime;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::List_::empty;
    use fable_library_rust::List_::ofArray;
    use fable_library_rust::List_::toArray;
    use fable_library_rust::Map_::find;
    use fable_library_rust::Map_::ofSeq;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::refCell;
    use fable_library_rust::Native_::Any;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::defaultValue;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::Seq_::ofList;
    use fable_library_rust::String_::append;
    use fable_library_rust::String_::padLeft;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
    use fable_library_rust::TimeSpan_::TimeSpan;
    pub mod State {
        use super::*;
        pub fn trace_state() -> LrcPtr<
            MutCell<
                Option<(
                    LrcPtr<Trace::Mut0>,
                    LrcPtr<Trace::Mut1>,
                    LrcPtr<Trace::Mut2>,
                    LrcPtr<Trace::Mut3>,
                    Option<i64>,
                )>,
            >,
        > {
            static trace_state: OnceInit<
                LrcPtr<
                    MutCell<
                        Option<(
                            LrcPtr<Trace::Mut0>,
                            LrcPtr<Trace::Mut1>,
                            LrcPtr<Trace::Mut2>,
                            LrcPtr<Trace::Mut3>,
                            Option<i64>,
                        )>,
                    >,
                >,
            > = OnceInit::new();
            trace_state
                .get_or_init(|| {
                    LrcPtr::new(MutCell::new(
                        None::<(
                            LrcPtr<Trace::Mut0>,
                            LrcPtr<Trace::Mut1>,
                            LrcPtr<Trace::Mut2>,
                            LrcPtr<Trace::Mut3>,
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
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US0 {
        US0_0,
        US0_1,
        US0_2,
        US0_3,
        US0_4,
    }
    impl core::fmt::Display for Trace::US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut0 {
        pub l0: MutCell<i64>,
    }
    impl core::fmt::Display for Trace::Mut0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub struct Mut1 {
        pub l0: MutCell<Func1<string, ()>>,
    }
    impl core::fmt::Display for Trace::Mut1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut2 {
        pub l0: MutCell<bool>,
    }
    impl core::fmt::Display for Trace::Mut2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut3 {
        pub l0: MutCell<Trace::US0>,
    }
    impl core::fmt::Display for Trace::Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(string),
        US1_1,
    }
    impl core::fmt::Display for Trace::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US2 {
        US2_0(Trace::US0),
        US2_1,
    }
    impl core::fmt::Display for Trace::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(i64),
        US3_1,
    }
    impl core::fmt::Display for Trace::US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut4 {
        pub l0: MutCell<string>,
    }
    impl core::fmt::Display for Trace::Mut4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn method1() -> string {
        string("TRACE_LEVEL")
    }
    pub fn method3() -> string {
        string("")
    }
    pub fn method2(v0_1: string) -> string {
        let v3: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
        let v5: bool = true;
        let _result = v3.map(|x| {
            //;
            let v7: std::string::String = x;
            let v9: string = fable_library_rust::String_::fromString(v7);
            let v11: bool = true;
            v9
        });
        let v13: Result<string, std::env::VarError> = _result;
        let v14: string = Trace::method3();
        v13.unwrap_or(v14)
    }
    pub fn method4() -> string {
        string("AUTOMATION")
    }
    pub fn closure0(unitVar: (), v0_1: string) {
        ();
    }
    pub fn method0(
        v0_1: Trace::US0,
    ) -> (
        LrcPtr<Trace::Mut0>,
        LrcPtr<Trace::Mut1>,
        LrcPtr<Trace::Mut2>,
        LrcPtr<Trace::Mut3>,
        Option<i64>,
    ) {
        let v3: string = Trace::method2(Trace::method1());
        let v8: Trace::US2 = if string("Verbose") == v3.clone() {
            Trace::US2::US2_0(Trace::US0::US0_0)
        } else {
            Trace::US2::US2_1
        };
        let _v1: (Trace::US2, Trace::US3) = (
            match &v8 {
                Trace::US2::US2_0(v8_0_0) => Trace::US2::US2_0(match &v8 {
                    Trace::US2::US2_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => {
                    let v15: Trace::US2 = if string("Debug") == v3.clone() {
                        Trace::US2::US2_0(Trace::US0::US0_1)
                    } else {
                        Trace::US2::US2_1
                    };
                    match &v15 {
                        Trace::US2::US2_0(v15_0_0) => Trace::US2::US2_0(match &v15 {
                            Trace::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v22: Trace::US2 = if string("Info") == v3.clone() {
                                Trace::US2::US2_0(Trace::US0::US0_2)
                            } else {
                                Trace::US2::US2_1
                            };
                            match &v22 {
                                Trace::US2::US2_0(v22_0_0) => Trace::US2::US2_0(match &v22 {
                                    Trace::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                                _ => {
                                    let v29: Trace::US2 = if string("Warning") == v3.clone() {
                                        Trace::US2::US2_0(Trace::US0::US0_3)
                                    } else {
                                        Trace::US2::US2_1
                                    };
                                    match &v29 {
                                        Trace::US2::US2_0(v29_0_0) => {
                                            Trace::US2::US2_0(match &v29 {
                                                Trace::US2::US2_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v36: Trace::US2 =
                                                if string("Critical") == v3.clone() {
                                                    Trace::US2::US2_0(Trace::US0::US0_4)
                                                } else {
                                                    Trace::US2::US2_1
                                                };
                                            match &v36 {
                                                Trace::US2::US2_0(v36_0_0) => {
                                                    Trace::US2::US2_0(match &v36 {
                                                        Trace::US2::US2_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => Trace::US2::US2_1,
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            },
            if Trace::method2(Trace::method4()) == string("True") {
                Trace::US3::US3_0({
                    let _arg: DateTime = DateTime::now();
                    _arg.ticks()
                })
            } else {
                Trace::US3::US3_1
            },
        );
        let v295: Trace::US3 = _v1.1.clone();
        let v294: Trace::US2 = _v1.0.clone();
        (
            LrcPtr::new(Trace::Mut0 {
                l0: MutCell::new(0_i64),
            }),
            LrcPtr::new(Trace::Mut1 {
                l0: MutCell::new(Func1::new(move |v: string| Trace::closure0((), v))),
            }),
            LrcPtr::new(Trace::Mut2 {
                l0: MutCell::new(true),
            }),
            LrcPtr::new(Trace::Mut3 {
                l0: MutCell::new(match &v294 {
                    Trace::US2::US2_0(v294_0_0) => match &v294 {
                        Trace::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v0_1,
                }),
            }),
            match &v295 {
                Trace::US3::US3_0(v295_0_0) => Some(match &v295 {
                    Trace::US3::US3_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<i64>,
            },
        )
    }
    pub fn method5() -> string {
        string("hh:mm:ss")
    }
    pub fn method6() -> string {
        string("HH:mm:ss")
    }
    pub fn method7() -> string {
        string("\u{001b}[0m")
    }
    pub fn method8() -> string {
        string("")
    }
    pub fn closure3(v0_1: Trace::US0, v1: Func0<string>, v2: Func0<string>) {
        if Trace::State::trace_state().get().clone().is_none() {
            let patternInput: (
                LrcPtr<Trace::Mut0>,
                LrcPtr<Trace::Mut1>,
                LrcPtr<Trace::Mut2>,
                LrcPtr<Trace::Mut3>,
                Option<i64>,
            ) = Trace::method0(Trace::US0::US0_0);
            Trace::State::trace_state().set(Some((
                patternInput.0.clone(),
                patternInput.1.clone(),
                patternInput.2.clone(),
                patternInput.3.clone(),
                patternInput.4.clone(),
            )));
            ()
        }
        {
            let patternInput_1: (
                LrcPtr<Trace::Mut0>,
                LrcPtr<Trace::Mut1>,
                LrcPtr<Trace::Mut2>,
                LrcPtr<Trace::Mut3>,
                Option<i64>,
            ) = getValue(Trace::State::trace_state().get().clone());
            let v15: LrcPtr<Trace::Mut0> = patternInput_1.0.clone();
            if Trace::State::trace_state().get().clone().is_none() {
                let patternInput_2: (
                    LrcPtr<Trace::Mut0>,
                    LrcPtr<Trace::Mut1>,
                    LrcPtr<Trace::Mut2>,
                    LrcPtr<Trace::Mut3>,
                    Option<i64>,
                ) = Trace::method0(Trace::US0::US0_0);
                Trace::State::trace_state().set(Some((
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                )));
                ()
            }
            {
                let patternInput_3: (
                    LrcPtr<Trace::Mut0>,
                    LrcPtr<Trace::Mut1>,
                    LrcPtr<Trace::Mut2>,
                    LrcPtr<Trace::Mut3>,
                    Option<i64>,
                ) = getValue(Trace::State::trace_state().get().clone());
                let v57: Trace::US0 = (patternInput_3.3.clone()).l0.get().clone();
                if if (patternInput_3.2.clone()).l0.get().clone() == false {
                    false
                } else {
                    find(
                        v0_1.clone(),
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Trace::US0::US0_0, 0_i32)),
                            LrcPtr::new((Trace::US0::US0_1, 1_i32)),
                            LrcPtr::new((Trace::US0::US0_2, 2_i32)),
                            LrcPtr::new((Trace::US0::US0_3, 3_i32)),
                            LrcPtr::new((Trace::US0::US0_4, 4_i32)),
                        ])))),
                    ) >= find(
                        v57,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Trace::US0::US0_0, 0_i32)),
                            LrcPtr::new((Trace::US0::US0_1, 1_i32)),
                            LrcPtr::new((Trace::US0::US0_2, 2_i32)),
                            LrcPtr::new((Trace::US0::US0_3, 3_i32)),
                            LrcPtr::new((Trace::US0::US0_4, 4_i32)),
                        ])))),
                    )
                } {
                    let v65: i64 = v15.l0.get().clone() + 1_i64;
                    v15.l0.set(v65);
                    if Trace::State::trace_state().get().clone().is_none() {
                        let patternInput_4: (
                            LrcPtr<Trace::Mut0>,
                            LrcPtr<Trace::Mut1>,
                            LrcPtr<Trace::Mut2>,
                            LrcPtr<Trace::Mut3>,
                            Option<i64>,
                        ) = Trace::method0(Trace::US0::US0_0);
                        Trace::State::trace_state().set(Some((
                            patternInput_4.0.clone(),
                            patternInput_4.1.clone(),
                            patternInput_4.2.clone(),
                            patternInput_4.3.clone(),
                            patternInput_4.4.clone(),
                        )));
                        ()
                    }
                    {
                        let patternInput_5: (
                            LrcPtr<Trace::Mut0>,
                            LrcPtr<Trace::Mut1>,
                            LrcPtr<Trace::Mut2>,
                            LrcPtr<Trace::Mut3>,
                            Option<i64>,
                        ) = getValue(Trace::State::trace_state().get().clone());
                        let v82: Option<i64> = patternInput_5.4.clone();
                        let _v94: LrcPtr<MutCell<Option<Trace::US3>>> = refCell(None::<Trace::US3>);
                        {
                            let x_2: Option<Trace::US3> = match &v82 {
                                None => None::<Trace::US3>,
                                Some(v82_0_0) => {
                                    let x: i64 = v82_0_0.clone();
                                    Some((Func0::new({
                                        let x = x.clone();
                                        move || Trace::US3::US3_0(x)
                                    }))())
                                }
                            };
                            _v94.set(x_2)
                        }
                        {
                            let v109: Trace::US3 =
                                defaultValue(Trace::US3::US3_1, _v94.get().clone());
                            let v149: DateTime = match &v109 {
                                Trace::US3::US3_0(v109_0_0) => {
                                    let v123: TimeSpan = TimeSpan::new_ticks(
                                        {
                                            let _arg: DateTime = DateTime::now();
                                            _arg.ticks()
                                        } - match &v109 {
                                            Trace::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                    );
                                    DateTime::new_ymdhms_milli(
                                        1_i32,
                                        1_i32,
                                        1_i32,
                                        v123.hours(),
                                        v123.minutes(),
                                        v123.seconds(),
                                        v123.milliseconds(),
                                    )
                                }
                                _ => DateTime::now(),
                            };
                            let v154: string = {
                                let provider: string = Trace::method5();
                                v149.toString(provider)
                            };
                            let v515: Trace::US1 = if if let Trace::US0::US0_0 = &v0_1 {
                                true
                            } else {
                                false
                            } {
                                Trace::US1::US1_0(string("Verbose"))
                            } else {
                                Trace::US1::US1_1
                            };
                            let v556: Trace::US1 = match &v515 {
                                Trace::US1::US1_0(v515_0_0) => Trace::US1::US1_0(match &v515 {
                                    Trace::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                                _ => {
                                    let v522: Trace::US1 = if if let Trace::US0::US0_1 = &v0_1 {
                                        true
                                    } else {
                                        false
                                    } {
                                        Trace::US1::US1_0(string("Debug"))
                                    } else {
                                        Trace::US1::US1_1
                                    };
                                    match &v522 {
                                        Trace::US1::US1_0(v522_0_0) => {
                                            Trace::US1::US1_0(match &v522 {
                                                Trace::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v529: Trace::US1 =
                                                if if let Trace::US0::US0_2 = &v0_1 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    Trace::US1::US1_0(string("Info"))
                                                } else {
                                                    Trace::US1::US1_1
                                                };
                                            match &v529 {
                                                Trace::US1::US1_0(v529_0_0) => {
                                                    Trace::US1::US1_0(match &v529 {
                                                        Trace::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v536: Trace::US1 =
                                                        if if let Trace::US0::US0_3 = &v0_1 {
                                                            true
                                                        } else {
                                                            false
                                                        } {
                                                            Trace::US1::US1_0(string("Warning"))
                                                        } else {
                                                            Trace::US1::US1_1
                                                        };
                                                    match &v536 {
                                                        Trace::US1::US1_0(v536_0_0) => {
                                                            Trace::US1::US1_0(match &v536 {
                                                                Trace::US1::US1_0(x) => x.clone(),
                                                                _ => unreachable!(),
                                                            })
                                                        }
                                                        _ => {
                                                            let v543: Trace::US1 =
                                                                if if let Trace::US0::US0_4 = &v0_1
                                                                {
                                                                    true
                                                                } else {
                                                                    false
                                                                } {
                                                                    Trace::US1::US1_0(string(
                                                                        "Critical",
                                                                    ))
                                                                } else {
                                                                    Trace::US1::US1_1
                                                                };
                                                            match &v543 {
                                                                Trace::US1::US1_0(v543_0_0) => {
                                                                    Trace::US1::US1_0(match &v543 {
                                                                        Trace::US1::US1_0(x) => {
                                                                            x.clone()
                                                                        }
                                                                        _ => unreachable!(),
                                                                    })
                                                                }
                                                                _ => Trace::US1::US1_1,
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            };
                            let v565: string = padLeft(
                                toLower(match &v556 {
                                    Trace::US1::US1_0(v556_0_0) => match &v556 {
                                        Trace::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => panic!("{}", string("Option does not have a value."),),
                                }),
                                7_i32,
                                ' ',
                            );
                            let v594: &str = match &v0_1 {
                                Trace::US0::US0_1 => inline_colorization::color_bright_blue,
                                Trace::US0::US0_2 => inline_colorization::color_bright_green,
                                Trace::US0::US0_0 => inline_colorization::color_bright_black,
                                Trace::US0::US0_3 => inline_colorization::color_yellow,
                                _ => inline_colorization::color_bright_red,
                            };
                            let v596: &str = &*v565;
                            let v598: &str = inline_colorization::color_reset;
                            let v600: string = string("format!(\"{v594}{v596}{v598}\")");
                            let v601: std::string::String = format!("{v594}{v596}{v598}");
                            let v603: string = fable_library_rust::String_::fromString(v601);
                            let v706: i64 = (patternInput_5.0.clone()).l0.get().clone();
                            let v707: string = v2();
                            let v709: LrcPtr<Trace::Mut4> = LrcPtr::new(Trace::Mut4 {
                                l0: MutCell::new(Trace::method8()),
                            });
                            let v710: string = sprintf!("{}", v707);
                            let v714: string = append(v709.l0.get().clone(), v710);
                            v709.l0.set(v714);
                            {
                                let v715: string = v709.l0.get().clone();
                                let v753: string = trimEndChars(
                                    trimStartChars(
                                        sprintf!("{} {} #{} {} / {}", v154, v603, v706, v1(), v715),
                                        toArray(empty::<char>()),
                                    ),
                                    toArray(ofArray(new_array(&[' ', '/']))),
                                );
                                println!("{}", v753.clone());
                                ();
                                ((patternInput_1.1.clone()).l0.get().clone())(v753)
                            }
                        }
                    }
                }
            }
        }
    }
    pub fn closure2(v0_1: Trace::US0, v1: Func0<string>) -> Func1<Func0<string>, ()> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1 = v1.clone();
            move |v: Func0<string>| Trace::closure3(v0_1.clone(), v1.clone(), v)
        })
    }
    pub fn closure1(
        unitVar: (),
        v0_1: Trace::US0,
    ) -> Func1<Func0<string>, Func1<Func0<string>, ()>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: Func0<string>| Trace::closure2(v0_1.clone(), v)
        })
    }
    pub fn v0() -> bool {
        static v0: OnceInit<bool> = OnceInit::new();
        v0.get_or_init(|| Trace::State::trace_state().get().clone().is_none())
            .clone()
    }
    on_startup!(if Trace::v0() {
        let patternInput: (
            LrcPtr<Trace::Mut0>,
            LrcPtr<Trace::Mut1>,
            LrcPtr<Trace::Mut2>,
            LrcPtr<Trace::Mut3>,
            Option<i64>,
        ) = Trace::method0(Trace::US0::US0_0);
        Trace::State::trace_state().set(Some((
            patternInput.0.clone(),
            patternInput.1.clone(),
            patternInput.2.clone(),
            patternInput.3.clone(),
            patternInput.4.clone(),
        )));
        ()
    });
    pub fn v12() -> Func1<Trace::US0, Func1<Func0<string>, Func1<Func0<string>, ()>>> {
        static v12: OnceInit<Func1<Trace::US0, Func1<Func0<string>, Func1<Func0<string>, ()>>>> =
            OnceInit::new();
        v12.get_or_init(|| Func1::new(move |v: Trace::US0| Trace::closure1((), v)))
            .clone()
    }
    pub fn trace(x: Trace::US0) -> Func1<Func0<string>, Func1<Func0<string>, ()>> {
        (Trace::v12())(x)
    }
    on_startup!(());
}
