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
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(Trace::US0),
        US1_1,
    }
    impl core::fmt::Display for Trace::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US2 {
        US2_0(i64),
        US2_1,
    }
    impl core::fmt::Display for Trace::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(string),
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
    pub fn method0() -> string {
        string("TRACE_LEVEL")
    }
    pub fn method2() -> string {
        string("")
    }
    pub fn method1(v0: string) -> string {
        let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v5: Result<std::string::String, std::env::VarError> = std::env::var(&*v0);
        let v7: bool = true;
        let _result = v5.map(|x| {
            //;
            let v9: std::string::String = x;
            let v11: string = fable_library_rust::String_::fromString(v9);
            let v13: bool = true;
            v11
        });
        let v15: Result<string, std::env::VarError> = _result;
        let v16: string = Trace::method2();
        {
            let x: string = v15.unwrap_or(v16);
            _v3.set(Some(x))
        }
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
    }
    pub fn method3() -> string {
        string("AUTOMATION")
    }
    pub fn closure1(unitVar: (), v0: string) {
        ();
    }
    pub fn closure0(
        unitVar: (),
        v0: Trace::US0,
    ) -> (
        LrcPtr<Trace::Mut0>,
        LrcPtr<Trace::Mut1>,
        LrcPtr<Trace::Mut2>,
        LrcPtr<Trace::Mut3>,
        Option<i64>,
    ) {
        let _v3: MutCell<Option<(Trace::US1, Trace::US2)>> =
            MutCell::new(None::<(Trace::US1, Trace::US2)>);
        let v5: string = Trace::method1(Trace::method0());
        let v11: Trace::US1 = if string("Verbose") == v5.clone() {
            Trace::US1::US1_0(Trace::US0::US0_0)
        } else {
            Trace::US1::US1_1
        };
        {
            let x: (Trace::US1, Trace::US2) = (
                match &v11 {
                    Trace::US1::US1_0(v11_0_0) => Trace::US1::US1_0(match &v11 {
                        Trace::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v19: Trace::US1 = if string("Debug") == v5.clone() {
                            Trace::US1::US1_0(Trace::US0::US0_1)
                        } else {
                            Trace::US1::US1_1
                        };
                        match &v19 {
                            Trace::US1::US1_0(v19_0_0) => Trace::US1::US1_0(match &v19 {
                                Trace::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v27: Trace::US1 = if string("Info") == v5.clone() {
                                    Trace::US1::US1_0(Trace::US0::US0_2)
                                } else {
                                    Trace::US1::US1_1
                                };
                                match &v27 {
                                    Trace::US1::US1_0(v27_0_0) => Trace::US1::US1_0(match &v27 {
                                        Trace::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }),
                                    _ => {
                                        let v35: Trace::US1 = if string("Warning") == v5.clone() {
                                            Trace::US1::US1_0(Trace::US0::US0_3)
                                        } else {
                                            Trace::US1::US1_1
                                        };
                                        match &v35 {
                                            Trace::US1::US1_0(v35_0_0) => {
                                                Trace::US1::US1_0(match &v35 {
                                                    Trace::US1::US1_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v43: Trace::US1 =
                                                    if string("Critical") == v5.clone() {
                                                        Trace::US1::US1_0(Trace::US0::US0_4)
                                                    } else {
                                                        Trace::US1::US1_1
                                                    };
                                                match &v43 {
                                                    Trace::US1::US1_0(v43_0_0) => {
                                                        Trace::US1::US1_0(match &v43 {
                                                            Trace::US1::US1_0(x) => x.clone(),
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
                },
                if Trace::method1(Trace::method3()) == string("True") {
                    Trace::US2::US2_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                } else {
                    Trace::US2::US2_1
                },
            );
            _v3.set(Some(x))
        }
        {
            let patternInput: (Trace::US1, Trace::US2) = match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
            };
            let v325: Trace::US2 = patternInput.1.clone();
            let v324: Trace::US1 = patternInput.0.clone();
            (
                LrcPtr::new(Trace::Mut0 {
                    l0: MutCell::new(0_i64),
                }),
                LrcPtr::new(Trace::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| Trace::closure1((), v))),
                }),
                LrcPtr::new(Trace::Mut2 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Trace::Mut3 {
                    l0: MutCell::new(match &v324 {
                        Trace::US1::US1_0(v324_0_0) => match &v324 {
                            Trace::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0,
                    }),
                }),
                match &v325 {
                    Trace::US2::US2_0(v325_0_0) => Some(match &v325 {
                        Trace::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
            )
        }
    }
    pub fn method5() -> string {
        string("hh:mm:ss")
    }
    pub fn method6() -> string {
        string("")
    }
    pub fn method7() -> string {
        string("HH:mm:ss")
    }
    pub fn method8() -> string {
        string("\u{001b}[0m")
    }
    pub fn method9(v0: LrcPtr<Trace::Mut4>, v1: string) {
        let v4: string = sprintf!("{}", v1);
        let v12: string = append(v0.l0.get().clone(), v4);
        v0.l0.set(v12);
        ()
    }
    pub fn closure5(v0: Trace::US0, v1: Func0<string>, v2: Func0<string>, unitVar: ()) -> string {
        if Trace::State::trace_state().get().clone().is_none() {
            Trace::State::trace_state().set(Some(Trace::closure0((), Trace::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<Trace::Mut0>,
                LrcPtr<Trace::Mut1>,
                LrcPtr<Trace::Mut2>,
                LrcPtr<Trace::Mut3>,
                Option<i64>,
            ) = getValue(Trace::State::trace_state().get().clone());
            let v18: Option<i64> = patternInput.4.clone();
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v38: LrcPtr<MutCell<Option<Trace::US2>>> = refCell(None::<Trace::US2>);
            {
                let x_2: Option<Trace::US2> = match &v18 {
                    None => None::<Trace::US2>,
                    Some(v18_0_0) => {
                        let x: i64 = v18_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Trace::US2::US2_0(x)
                        }))())
                    }
                };
                _v38.set(x_2)
            }
            {
                let v65: Trace::US2 = defaultValue(Trace::US2::US2_1, _v38.get().clone());
                let v163: DateTime = match &v65 {
                    Trace::US2::US2_0(v65_0_0) => {
                        let v97: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v65 {
                                Trace::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v97.hours(),
                            v97.minutes(),
                            v97.seconds(),
                            v97.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x_3: string = {
                        let provider: string = Trace::method5();
                        v163.toString(provider)
                    };
                    _v35.set(Some(x_3))
                }
                {
                    let v772: string = match &_v35.get().clone() {
                        None => panic!("{}", string("base.run_target / _v35=None"),),
                        Some(_v35_0_0) => _v35_0_0.clone(),
                    };
                    let v931: Trace::US3 = if if let Trace::US0::US0_0 = &v0 {
                        true
                    } else {
                        false
                    } {
                        Trace::US3::US3_0(string("Verbose"))
                    } else {
                        Trace::US3::US3_1
                    };
                    let v980: Trace::US3 = match &v931 {
                        Trace::US3::US3_0(v931_0_0) => Trace::US3::US3_0(match &v931 {
                            Trace::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v940: Trace::US3 = if if let Trace::US0::US0_1 = &v0 {
                                true
                            } else {
                                false
                            } {
                                Trace::US3::US3_0(string("Debug"))
                            } else {
                                Trace::US3::US3_1
                            };
                            match &v940 {
                                Trace::US3::US3_0(v940_0_0) => Trace::US3::US3_0(match &v940 {
                                    Trace::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                                _ => {
                                    let v949: Trace::US3 = if if let Trace::US0::US0_2 = &v0 {
                                        true
                                    } else {
                                        false
                                    } {
                                        Trace::US3::US3_0(string("Info"))
                                    } else {
                                        Trace::US3::US3_1
                                    };
                                    match &v949 {
                                        Trace::US3::US3_0(v949_0_0) => {
                                            Trace::US3::US3_0(match &v949 {
                                                Trace::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v958: Trace::US3 = if if let Trace::US0::US0_3 = &v0
                                            {
                                                true
                                            } else {
                                                false
                                            } {
                                                Trace::US3::US3_0(string("Warning"))
                                            } else {
                                                Trace::US3::US3_1
                                            };
                                            match &v958 {
                                                Trace::US3::US3_0(v958_0_0) => {
                                                    Trace::US3::US3_0(match &v958 {
                                                        Trace::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v967: Trace::US3 =
                                                        if if let Trace::US0::US0_4 = &v0 {
                                                            true
                                                        } else {
                                                            false
                                                        } {
                                                            Trace::US3::US3_0(string("Critical"))
                                                        } else {
                                                            Trace::US3::US3_1
                                                        };
                                                    match &v967 {
                                                        Trace::US3::US3_0(v967_0_0) => {
                                                            Trace::US3::US3_0(match &v967 {
                                                                Trace::US3::US3_0(x) => x.clone(),
                                                                _ => unreachable!(),
                                                            })
                                                        }
                                                        _ => Trace::US3::US3_1,
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    };
                    let v997: string = padLeft(
                        toLower(match &v980 {
                            Trace::US3::US3_0(v980_0_0) => match &v980 {
                                Trace::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v1029: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v1044: &str = match &v0 {
                        Trace::US0::US0_1 => inline_colorization::color_bright_blue,
                        Trace::US0::US0_2 => inline_colorization::color_bright_green,
                        Trace::US0::US0_0 => inline_colorization::color_bright_black,
                        Trace::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v1046: &str = &*v997;
                    let v1048: &str = inline_colorization::color_reset;
                    let v1050: string = string("format!(\"{v1044}{v1046}{v1048}\")");
                    let v1051: std::string::String = format!("{v1044}{v1046}{v1048}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v1051);
                        _v1029.set(Some(x_5))
                    }
                    {
                        let v1141: string = match &_v1029.get().clone() {
                            None => panic!("{}", string("base.run_target / _v1029=None"),),
                            Some(_v1029_0_0) => _v1029_0_0.clone(),
                        };
                        let v1160: i64 = (patternInput.0.clone()).l0.get().clone();
                        let v1163: LrcPtr<Trace::Mut4> = LrcPtr::new(Trace::Mut4 {
                            l0: MutCell::new(string("")),
                        });
                        Trace::method9(v1163.clone(), v2());
                        {
                            let v1164: string = v1163.l0.get().clone();
                            trimEndChars(
                                trimStartChars(
                                    sprintf!("{} {} #{} {} / {}", v772, v1141, v1160, v1(), v1164),
                                    toArray(empty::<char>()),
                                ),
                                toArray(ofArray(new_array(&[' ', '/']))),
                            )
                        }
                    }
                }
            }
        }
    }
    pub fn method10(v0: Trace::US0, v1: Func0<string>) {
        fn v4(
            v: Trace::US0,
        ) -> (
            LrcPtr<Trace::Mut0>,
            LrcPtr<Trace::Mut1>,
            LrcPtr<Trace::Mut2>,
            LrcPtr<Trace::Mut3>,
            Option<i64>,
        ) {
            Trace::closure0((), v)
        }
        if Trace::State::trace_state().get().clone().is_none() {
            Trace::State::trace_state().set(Some(v4(Trace::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<Trace::Mut0>,
                LrcPtr<Trace::Mut1>,
                LrcPtr<Trace::Mut2>,
                LrcPtr<Trace::Mut3>,
                Option<i64>,
            ) = getValue(Trace::State::trace_state().get().clone());
            let v13: LrcPtr<Trace::Mut0> = patternInput.0.clone();
            if Trace::State::trace_state().get().clone().is_none() {
                Trace::State::trace_state().set(Some(v4(Trace::US0::US0_0)));
            }
            {
                let patternInput_1: (
                    LrcPtr<Trace::Mut0>,
                    LrcPtr<Trace::Mut1>,
                    LrcPtr<Trace::Mut2>,
                    LrcPtr<Trace::Mut3>,
                    Option<i64>,
                ) = getValue(Trace::State::trace_state().get().clone());
                let v61: Trace::US0 = (patternInput_1.3.clone()).l0.get().clone();
                if if (patternInput_1.2.clone()).l0.get().clone() == false {
                    false
                } else {
                    find(
                        v0,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Trace::US0::US0_0, 0_i32)),
                            LrcPtr::new((Trace::US0::US0_1, 1_i32)),
                            LrcPtr::new((Trace::US0::US0_2, 2_i32)),
                            LrcPtr::new((Trace::US0::US0_3, 3_i32)),
                            LrcPtr::new((Trace::US0::US0_4, 4_i32)),
                        ])))),
                    ) >= find(
                        v61,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Trace::US0::US0_0, 0_i32)),
                            LrcPtr::new((Trace::US0::US0_1, 1_i32)),
                            LrcPtr::new((Trace::US0::US0_2, 2_i32)),
                            LrcPtr::new((Trace::US0::US0_3, 3_i32)),
                            LrcPtr::new((Trace::US0::US0_4, 4_i32)),
                        ])))),
                    )
                } {
                    let v69: i64 = v13.l0.get().clone() + 1_i64;
                    v13.l0.set(v69);
                    {
                        let v72: string = sprintf!("{}", v1());
                        let _v81: MutCell<Option<()>> = MutCell::new(None::<()>);
                        println!("{}", v72.clone());
                        _v81.set(Some(()));
                        match &_v81.get().clone() {
                            None => panic!("{}", string("base.run_target / _v81=None"),),
                            Some(_v81_0_0) => _v81_0_0.clone(),
                        }
                        ((patternInput.1.clone()).l0.get().clone())(v72)
                    }
                }
            }
        }
    }
    pub fn method4(v0: Trace::US0, v1: Func0<string>, v2: Func0<string>) {
        Trace::method10(
            v0.clone(),
            Func0::new({
                let v0 = v0.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move || Trace::closure5(v0.clone(), v1.clone(), v2.clone(), ())
            }),
        );
    }
    pub fn closure4(v0: Trace::US0, v1: Func0<string>, v2: Func0<string>) {
        Trace::method4(v0, v1, v2);
    }
    pub fn closure3(v0: Trace::US0, v1: Func0<string>) -> Func1<Func0<string>, ()> {
        Func1::new({
            let v0 = v0.clone();
            let v1 = v1.clone();
            move |v: Func0<string>| Trace::closure4(v0.clone(), v1.clone(), v)
        })
    }
    pub fn closure2(unitVar: (), v0: Trace::US0) -> Func1<Func0<string>, Func1<Func0<string>, ()>> {
        Func1::new({
            let v0 = v0.clone();
            move |v: Func0<string>| Trace::closure3(v0.clone(), v)
        })
    }
    pub fn v44() -> Func1<
        Trace::US0,
        (
            LrcPtr<Trace::Mut0>,
            LrcPtr<Trace::Mut1>,
            LrcPtr<Trace::Mut2>,
            LrcPtr<Trace::Mut3>,
            Option<i64>,
        ),
    > {
        static v44: OnceInit<
            Func1<
                Trace::US0,
                (
                    LrcPtr<Trace::Mut0>,
                    LrcPtr<Trace::Mut1>,
                    LrcPtr<Trace::Mut2>,
                    LrcPtr<Trace::Mut3>,
                    Option<i64>,
                ),
            >,
        > = OnceInit::new();
        v44.get_or_init(|| Func1::new(move |v: Trace::US0| Trace::closure0((), v)))
            .clone()
    }
    pub fn v45() -> Trace::US0 {
        static v45: OnceInit<Trace::US0> = OnceInit::new();
        v45.get_or_init(|| Trace::US0::US0_0).clone()
    }
    on_startup!(if Trace::State::trace_state().get().clone().is_none() {
        Trace::State::trace_state().set(Some((Trace::v44())(Trace::v45())));
    });
    pub fn v51() -> Func1<Trace::US0, Func1<Func0<string>, Func1<Func0<string>, ()>>> {
        static v51: OnceInit<Func1<Trace::US0, Func1<Func0<string>, Func1<Func0<string>, ()>>>> =
            OnceInit::new();
        v51.get_or_init(|| Func1::new(move |v: Trace::US0| Trace::closure2((), v)))
            .clone()
    }
    pub fn trace(x: Trace::US0) -> Func1<Func0<string>, Func1<Func0<string>, ()>> {
        (Trace::v51())(x)
    }
    on_startup!(());
}
