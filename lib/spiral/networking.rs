pub mod Networking {
    use super::*;
    type Async<T> = T;
    use fable_library_rust::DateTime_::DateTime;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::List_::empty;
    use fable_library_rust::List_::ofArray;
    use fable_library_rust::List_::toArray;
    use fable_library_rust::Map_::find;
    use fable_library_rust::Map_::ofSeq;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::Native_::defaultOf;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::refCell;
    use fable_library_rust::Native_::Any;
    use fable_library_rust::Native_::Arc;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::defaultValue;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::Seq_::ofList;
    use fable_library_rust::String_::padLeft;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
    use fable_library_rust::System::Exception;
    use fable_library_rust::TimeSpan_::TimeSpan;
    pub mod State {
        use super::*;
        pub fn trace_state() -> LrcPtr<
            MutCell<
                Option<(
                    LrcPtr<Networking::Mut0>,
                    LrcPtr<Networking::Mut1>,
                    LrcPtr<Networking::Mut2>,
                    Option<i64>,
                    LrcPtr<Networking::Mut3>,
                )>,
            >,
        > {
            static trace_state: OnceInit<
                LrcPtr<
                    MutCell<
                        Option<(
                            LrcPtr<Networking::Mut0>,
                            LrcPtr<Networking::Mut1>,
                            LrcPtr<Networking::Mut2>,
                            Option<i64>,
                            LrcPtr<Networking::Mut3>,
                        )>,
                    >,
                >,
            > = OnceInit::new();
            trace_state
                .get_or_init(|| {
                    LrcPtr::new(MutCell::new(
                        None::<(
                            LrcPtr<Networking::Mut0>,
                            LrcPtr<Networking::Mut1>,
                            LrcPtr<Networking::Mut2>,
                            Option<i64>,
                            LrcPtr<Networking::Mut3>,
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
    impl Networking::US0 {
        pub fn get_IsUS0_0(this_: &MutCell<Networking::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_1(this_: &MutCell<Networking::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_2(this_: &MutCell<Networking::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_3(this_: &MutCell<Networking::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_4(this_: &MutCell<Networking::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Networking::US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut0 {
        pub l0: MutCell<i64>,
    }
    impl core::fmt::Display for Networking::Mut0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut1 {
        pub l0: MutCell<bool>,
    }
    impl core::fmt::Display for Networking::Mut1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut2 {
        pub l0: MutCell<Networking::US0>,
    }
    impl core::fmt::Display for Networking::Mut2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub struct Mut3 {
        pub l0: MutCell<Func1<string, ()>>,
    }
    impl core::fmt::Display for Networking::Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(i64),
        US1_1,
    }
    impl Networking::US1 {
        pub fn get_IsUS1_0(this_: &MutCell<Networking::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS1_1(this_: &MutCell<Networking::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Networking::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US2 {
        US2_0(Networking::US0),
        US2_1,
    }
    impl Networking::US2 {
        pub fn get_IsUS2_0(this_: &MutCell<Networking::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS2_1(this_: &MutCell<Networking::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Networking::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(string),
        US3_1,
    }
    impl Networking::US3 {
        pub fn get_IsUS3_0(this_: &MutCell<Networking::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS3_1(this_: &MutCell<Networking::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Networking::US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US4 {
        US4_0(bool),
        US4_1,
    }
    impl Networking::US4 {
        pub fn get_IsUS4_0(this_: &MutCell<Networking::US4>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS4_1(this_: &MutCell<Networking::US4>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Networking::US4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US5 {
        US5_0(bool),
        US5_1(LrcPtr<Exception>),
    }
    impl Networking::US5 {
        pub fn get_IsUS5_0(this_: &MutCell<Networking::US5>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS5_1(this_: &MutCell<Networking::US5>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Networking::US5 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US6 {
        US6_0(bool),
        US6_1(LrcPtr<Exception>),
    }
    impl Networking::US6 {
        pub fn get_IsUS6_0(this_: &MutCell<Networking::US6>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS6_1(this_: &MutCell<Networking::US6>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Networking::US6 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US7 {
        US7_0(i32),
        US7_1,
    }
    impl Networking::US7 {
        pub fn get_IsUS7_0(this_: &MutCell<Networking::US7>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS7_1(this_: &MutCell<Networking::US7>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Networking::US7 {
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
    pub fn method1(v0_1: string) -> string {
        let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v3_1: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
        let v5_1: bool = true;
        let _result = v3_1.map(|x| {
            //;
            let v7: std::string::String = x;
            let v9: string = fable_library_rust::String_::fromString(v7);
            let v11: bool = true;
            v9
        });
        let v13: Result<string, std::env::VarError> = _result;
        let v14: string = Networking::method2();
        {
            let x: string = v13.unwrap_or(v14);
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn method3() -> string {
        string("AUTOMATION")
    }
    pub fn closure1(unitVar: (), v0_1: string) {
        ();
    }
    pub fn closure0(
        unitVar: (),
        v0_1: Networking::US0,
    ) -> (
        LrcPtr<Networking::Mut0>,
        LrcPtr<Networking::Mut1>,
        LrcPtr<Networking::Mut2>,
        Option<i64>,
        LrcPtr<Networking::Mut3>,
    ) {
        let _v1: MutCell<Option<(Networking::US1, Networking::US2)>> =
            MutCell::new(None::<(Networking::US1, Networking::US2)>);
        let v3_1: string = Networking::method1(Networking::method0());
        let v9: Networking::US2 = if string("Verbose") == v3_1.clone() {
            Networking::US2::US2_0(Networking::US0::US0_0)
        } else {
            Networking::US2::US2_1
        };
        let v54: Networking::US2 = match &v9 {
            Networking::US2::US2_0(v9_0_0) => Networking::US2::US2_0(match &v9 {
                Networking::US2::US2_0(x) => x.clone(),
                _ => unreachable!(),
            }),
            _ => {
                let v17: Networking::US2 = if string("Debug") == v3_1.clone() {
                    Networking::US2::US2_0(Networking::US0::US0_1)
                } else {
                    Networking::US2::US2_1
                };
                match &v17 {
                    Networking::US2::US2_0(v17_0_0) => Networking::US2::US2_0(match &v17 {
                        Networking::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v25: Networking::US2 = if string("Info") == v3_1.clone() {
                            Networking::US2::US2_0(Networking::US0::US0_2)
                        } else {
                            Networking::US2::US2_1
                        };
                        match &v25 {
                            Networking::US2::US2_0(v25_0_0) => Networking::US2::US2_0(match &v25 {
                                Networking::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v33: Networking::US2 = if string("Warning") == v3_1.clone() {
                                    Networking::US2::US2_0(Networking::US0::US0_3)
                                } else {
                                    Networking::US2::US2_1
                                };
                                match &v33 {
                                    Networking::US2::US2_0(v33_0_0) => {
                                        Networking::US2::US2_0(match &v33 {
                                            Networking::US2::US2_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v41: Networking::US2 =
                                            if string("Critical") == v3_1.clone() {
                                                Networking::US2::US2_0(Networking::US0::US0_4)
                                            } else {
                                                Networking::US2::US2_1
                                            };
                                        match &v41 {
                                            Networking::US2::US2_0(v41_0_0) => {
                                                Networking::US2::US2_0(match &v41 {
                                                    Networking::US2::US2_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => Networking::US2::US2_1,
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        };
        {
            let x: (Networking::US1, Networking::US2) = (
                if Networking::method1(Networking::method3()) == string("True") {
                    Networking::US1::US1_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                } else {
                    Networking::US1::US1_1
                },
                v54,
            );
            _v1.set(Some(x))
        }
        {
            let patternInput: (Networking::US1, Networking::US2) = match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            };
            let v259: Networking::US2 = patternInput.1.clone();
            let v258: Networking::US1 = patternInput.0.clone();
            let v267: LrcPtr<Networking::Mut3> = LrcPtr::new(Networking::Mut3 {
                l0: MutCell::new(Func1::new(move |v: string| Networking::closure1((), v))),
            });
            (
                LrcPtr::new(Networking::Mut0 {
                    l0: MutCell::new(0_i64),
                }),
                LrcPtr::new(Networking::Mut1 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Networking::Mut2 {
                    l0: MutCell::new(match &v259 {
                        Networking::US2::US2_0(v259_0_0) => match &v259 {
                            Networking::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0_1,
                    }),
                }),
                match &v258 {
                    Networking::US1::US1_0(v258_0_0) => Some(match &v258 {
                        Networking::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
                v267,
            )
        }
    }
    pub fn closure4(v0_1: i32, v1_1: string, unitVar: ()) -> string {
        sprintf!("networking.test_port_open / port: {} / ex: {}", v0_1, v1_1)
    }
    pub fn closure5(unitVar: (), unitVar_1: ()) -> string {
        string("")
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
    pub fn closure6(
        v0_1: Networking::US0,
        v1_1: Func0<string>,
        v2_1: Func0<string>,
        unitVar: (),
    ) -> string {
        if Networking::State::trace_state().get().clone().is_none() {
            Networking::State::trace_state()
                .set(Some(Networking::closure0((), Networking::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                Option<i64>,
                LrcPtr<Networking::Mut3>,
            ) = getValue(Networking::State::trace_state().get().clone());
            let v8: Option<i64> = patternInput.3.clone();
            let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v11: LrcPtr<MutCell<Option<Networking::US1>>> = refCell(None::<Networking::US1>);
            {
                let x_2: Option<Networking::US1> = match &v8 {
                    None => None::<Networking::US1>,
                    Some(v8_0_0) => {
                        let x: i64 = v8_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Networking::US1::US1_0(x)
                        }))())
                    }
                };
                _v11.set(x_2)
            }
            {
                let v16: Networking::US1 = defaultValue(Networking::US1::US1_1, _v11.get().clone());
                let v35: DateTime = match &v16 {
                    Networking::US1::US1_0(v16_0_0) => {
                        let v23: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v16 {
                                Networking::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v23.hours(),
                            v23.minutes(),
                            v23.seconds(),
                            v23.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x_3: string = {
                        let provider: string = Networking::method5();
                        v35.toString(provider)
                    };
                    _v10.set(Some(x_3))
                }
                {
                    let v152: string = match &_v10.get().clone() {
                        None => panic!("{}", string("base.run_target / _v10=None"),),
                        Some(_v10_0_0) => _v10_0_0.clone(),
                    };
                    let v159: Networking::US3 = if if let Networking::US0::US0_0 = &v0_1 {
                        true
                    } else {
                        false
                    } {
                        Networking::US3::US3_0(string("Verbose"))
                    } else {
                        Networking::US3::US3_1
                    };
                    let v208: Networking::US3 = match &v159 {
                        Networking::US3::US3_0(v159_0_0) => Networking::US3::US3_0(match &v159 {
                            Networking::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v168: Networking::US3 = if if let Networking::US0::US0_1 = &v0_1 {
                                true
                            } else {
                                false
                            } {
                                Networking::US3::US3_0(string("Debug"))
                            } else {
                                Networking::US3::US3_1
                            };
                            match &v168 {
                                Networking::US3::US3_0(v168_0_0) => {
                                    Networking::US3::US3_0(match &v168 {
                                        Networking::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v177: Networking::US3 =
                                        if if let Networking::US0::US0_2 = &v0_1 {
                                            true
                                        } else {
                                            false
                                        } {
                                            Networking::US3::US3_0(string("Info"))
                                        } else {
                                            Networking::US3::US3_1
                                        };
                                    match &v177 {
                                        Networking::US3::US3_0(v177_0_0) => {
                                            Networking::US3::US3_0(match &v177 {
                                                Networking::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v186: Networking::US3 =
                                                if if let Networking::US0::US0_3 = &v0_1 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    Networking::US3::US3_0(string("Warning"))
                                                } else {
                                                    Networking::US3::US3_1
                                                };
                                            match &v186 {
                                                Networking::US3::US3_0(v186_0_0) => {
                                                    Networking::US3::US3_0(match &v186 {
                                                        Networking::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v195: Networking::US3 =
                                                        if if let Networking::US0::US0_4 = &v0_1 {
                                                            true
                                                        } else {
                                                            false
                                                        } {
                                                            Networking::US3::US3_0(string(
                                                                "Critical",
                                                            ))
                                                        } else {
                                                            Networking::US3::US3_1
                                                        };
                                                    match &v195 {
                                                        Networking::US3::US3_0(v195_0_0) => {
                                                            Networking::US3::US3_0(match &v195 {
                                                                Networking::US3::US3_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            })
                                                        }
                                                        _ => Networking::US3::US3_1,
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    };
                    let v215: string = padLeft(
                        toLower(match &v208 {
                            Networking::US3::US3_0(v208_0_0) => match &v208 {
                                Networking::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v231: &str = match &v0_1 {
                        Networking::US0::US0_1 => inline_colorization::color_bright_blue,
                        Networking::US0::US0_2 => inline_colorization::color_bright_green,
                        Networking::US0::US0_0 => inline_colorization::color_bright_black,
                        Networking::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v233: &str = &*v215;
                    let v235: &str = inline_colorization::color_reset;
                    let v237: string = string("format!(\"{v231}{v233}{v235}\")");
                    let v238: std::string::String = format!("{v231}{v233}{v235}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v238);
                        _v216.set(Some(x_5))
                    }
                    trimEndChars(
                        trimStartChars(
                            sprintf!(
                                "{} {} #{} {} / {}",
                                v152,
                                match &_v216.get().clone() {
                                    None => panic!("{}", string("base.run_target / _v216=None"),),
                                    Some(_v216_0_0) => _v216_0_0.clone(),
                                },
                                (patternInput.0.clone()).l0.get().clone(),
                                v1_1(),
                                v2_1()
                            ),
                            toArray(empty::<char>()),
                        ),
                        toArray(ofArray(new_array(&[' ', '/']))),
                    )
                }
            }
        }
    }
    pub fn method9(v0_1: Networking::US0, v1_1: Func0<string>) {
        fn v2_1(
            v: Networking::US0,
        ) -> (
            LrcPtr<Networking::Mut0>,
            LrcPtr<Networking::Mut1>,
            LrcPtr<Networking::Mut2>,
            Option<i64>,
            LrcPtr<Networking::Mut3>,
        ) {
            Networking::closure0((), v)
        }
        if Networking::State::trace_state().get().clone().is_none() {
            Networking::State::trace_state().set(Some(v2_1(Networking::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                Option<i64>,
                LrcPtr<Networking::Mut3>,
            ) = getValue(Networking::State::trace_state().get().clone());
            let v4_1: LrcPtr<Networking::Mut0> = patternInput.0.clone();
            if Networking::State::trace_state().get().clone().is_none() {
                Networking::State::trace_state().set(Some(v2_1(Networking::US0::US0_0)));
            }
            {
                let patternInput_1: (
                    LrcPtr<Networking::Mut0>,
                    LrcPtr<Networking::Mut1>,
                    LrcPtr<Networking::Mut2>,
                    Option<i64>,
                    LrcPtr<Networking::Mut3>,
                ) = getValue(Networking::State::trace_state().get().clone());
                let v15: Networking::US0 = (patternInput_1.2.clone()).l0.get().clone();
                if if (patternInput_1.1.clone()).l0.get().clone() == false {
                    false
                } else {
                    find(
                        v0_1,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                            LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                            LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                            LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                            LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                        ])))),
                    ) >= find(
                        v15,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                            LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                            LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                            LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                            LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                        ])))),
                    )
                } {
                    let v23: i64 = v4_1.l0.get().clone() + 1_i64;
                    v4_1.l0.set(v23);
                    {
                        let v24: string = sprintf!("{}", v1_1());
                        let _v25: MutCell<Option<()>> = MutCell::new(None::<()>);
                        println!("{}", v24.clone());
                        _v25.set(Some(()));
                        match &_v25.get().clone() {
                            None => panic!("{}", string("base.run_target / _v25=None"),),
                            Some(_v25_0_0) => _v25_0_0.clone(),
                        }
                        ((patternInput.4.clone()).l0.get().clone())(v24)
                    }
                }
            }
        }
    }
    pub fn method4(v0_1: Networking::US0, v1_1: Func0<string>, v2_1: Func0<string>) {
        Networking::method9(
            v0_1.clone(),
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2_1 = v2_1.clone();
                move || Networking::closure6(v0_1.clone(), v1_1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn closure3(v0_1: string, v1_1: i32) -> Arc<Async<bool>> {
        let _v2: MutCell<Option<Arc<Async<bool>>>> = MutCell::new(None::<Arc<Async<bool>>>);
        {
            let x: Arc<Async<bool>> = defaultOf();
            _v2.set(Some(x))
        }
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn closure2(unitVar: (), v0_1: string) -> Func1<i32, Arc<Async<bool>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: i32| Networking::closure3(v0_1.clone(), v)
        })
    }
    pub fn closure10(unitVar: (), v0_1: bool) -> Networking::US5 {
        Networking::US5::US5_0(v0_1)
    }
    pub fn closure11(unitVar: (), v0_1: LrcPtr<Exception>) -> Networking::US5 {
        Networking::US5::US5_1(v0_1)
    }
    pub fn closure12(unitVar: (), unitVar_1: ()) -> string {
        string("async.run_with_timeout_async")
    }
    pub fn closure13(v0_1: i32, unitVar: ()) -> string {
        sprintf!("timeout: {} / {}", v0_1, Networking::closure5((), ()))
    }
    pub fn closure14(v0_1: string, unitVar: ()) -> string {
        sprintf!("async.run_with_timeout_async** / ex: {}", v0_1)
    }
    pub fn closure9(v0_1: i32, v1_1: string, v2_1: i32) -> Arc<Async<bool>> {
        let _v3: MutCell<Option<Arc<Async<bool>>>> = MutCell::new(None::<Arc<Async<bool>>>);
        {
            let x: Arc<Async<bool>> = defaultOf();
            _v3.set(Some(x))
        }
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
    }
    pub fn closure8(v0_1: i32, v1_1: string) -> Func1<i32, Arc<Async<bool>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: i32| Networking::closure9(v0_1, v1_1.clone(), v)
        })
    }
    pub fn closure7(unitVar: (), v0_1: i32) -> Func1<string, Func1<i32, Arc<Async<bool>>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| Networking::closure8(v0_1, v)
        })
    }
    pub fn closure19(unitVar: (), unitVar_1: ()) -> string {
        string("networking.wait_for_port_access")
    }
    pub fn closure20(v0_1: Option<i32>, v1_1: bool, v2_1: i32, v3_1: i64, unitVar: ()) -> string {
        sprintf!(
            "port: {} / retry: {} / timeout: {:?} / status: {} / {}",
            v2_1,
            v3_1,
            v0_1,
            v1_1,
            Networking::closure5((), ())
        )
    }
    pub fn method10(
        v0_1: Option<i32>,
        v1_1: bool,
        v2_1: string,
        v3_1: i32,
        v4_1: i64,
    ) -> Arc<Async<i64>> {
        let _v5: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v5.set(Some(x))
        }
        match &_v5.get().clone() {
            None => panic!("{}", string("base.run_target / _v5=None"),),
            Some(_v5_0_0) => _v5_0_0.clone(),
        }
    }
    pub fn closure18(v0_1: Option<i32>, v1_1: bool, v2_1: string, v3_1: i32) -> Arc<Async<i64>> {
        Networking::method10(v0_1, v1_1, v2_1, v3_1, 0_i64)
    }
    pub fn closure17(v0_1: Option<i32>, v1_1: bool, v2_1: string) -> Func1<i32, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            let v2_1 = v2_1.clone();
            move |v: i32| Networking::closure18(v0_1.clone(), v1_1, v2_1.clone(), v)
        })
    }
    pub fn closure16(v0_1: Option<i32>, v1_1: bool) -> Func1<string, Func1<i32, Arc<Async<i64>>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: string| Networking::closure17(v0_1.clone(), v1_1, v)
        })
    }
    pub fn closure15(
        unitVar: (),
        v0_1: Option<i32>,
    ) -> Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: bool| Networking::closure16(v0_1.clone(), v)
        })
    }
    pub fn method11(v0_1: Option<i32>, v1_1: string, v2_1: i32) -> Arc<Async<i32>> {
        let _v3: MutCell<Option<Arc<Async<i32>>>> = MutCell::new(None::<Arc<Async<i32>>>);
        {
            let x: Arc<Async<i32>> = defaultOf();
            _v3.set(Some(x))
        }
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
    }
    pub fn closure23(v0_1: Option<i32>, v1_1: string, v2_1: i32) -> Arc<Async<i32>> {
        Networking::method11(v0_1, v1_1, v2_1)
    }
    pub fn closure22(v0_1: Option<i32>, v1_1: string) -> Func1<i32, Arc<Async<i32>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: i32| Networking::closure23(v0_1.clone(), v1_1.clone(), v)
        })
    }
    pub fn closure21(unitVar: (), v0_1: Option<i32>) -> Func1<string, Func1<i32, Arc<Async<i32>>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| Networking::closure22(v0_1.clone(), v)
        })
    }
    pub fn v0() -> Func1<
        Networking::US0,
        (
            LrcPtr<Networking::Mut0>,
            LrcPtr<Networking::Mut1>,
            LrcPtr<Networking::Mut2>,
            Option<i64>,
            LrcPtr<Networking::Mut3>,
        ),
    > {
        static v0: OnceInit<
            Func1<
                Networking::US0,
                (
                    LrcPtr<Networking::Mut0>,
                    LrcPtr<Networking::Mut1>,
                    LrcPtr<Networking::Mut2>,
                    Option<i64>,
                    LrcPtr<Networking::Mut3>,
                ),
            >,
        > = OnceInit::new();
        v0.get_or_init(|| Func1::new(move |v: Networking::US0| Networking::closure0((), v)))
            .clone()
    }
    pub fn v1() -> Networking::US0 {
        static v1: OnceInit<Networking::US0> = OnceInit::new();
        v1.get_or_init(|| Networking::US0::US0_0).clone()
    }
    on_startup!(
        if Networking::State::trace_state().get().clone().is_none() {
            Networking::State::trace_state().set(Some((Networking::v0())(Networking::v1())));
        }
    );
    pub fn v2() -> Func1<string, Func1<i32, Arc<Async<bool>>>> {
        static v2: OnceInit<Func1<string, Func1<i32, Arc<Async<bool>>>>> = OnceInit::new();
        v2.get_or_init(|| Func1::new(move |v: string| Networking::closure2((), v)))
            .clone()
    }
    pub fn test_port_open(x: string) -> Func1<i32, Arc<Async<bool>>> {
        (Networking::v2())(x)
    }
    pub fn v3() -> Func1<i32, Func1<string, Func1<i32, Arc<Async<bool>>>>> {
        static v3: OnceInit<Func1<i32, Func1<string, Func1<i32, Arc<Async<bool>>>>>> =
            OnceInit::new();
        v3.get_or_init(|| Func1::new(move |v: i32| Networking::closure7((), v)))
            .clone()
    }
    pub fn test_port_open_timeout(x: i32) -> Func1<string, Func1<i32, Arc<Async<bool>>>> {
        (Networking::v3())(x)
    }
    pub fn v4() -> Func1<Option<i32>, Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>>> {
        static v4: OnceInit<
            Func1<Option<i32>, Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>>>,
        > = OnceInit::new();
        v4.get_or_init(|| Func1::new(move |v: Option<i32>| Networking::closure15((), v)))
            .clone()
    }
    pub fn wait_for_port_access(
        x: Option<i32>,
    ) -> Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>> {
        (Networking::v4())(x)
    }
    pub fn v5() -> Func1<Option<i32>, Func1<string, Func1<i32, Arc<Async<i32>>>>> {
        static v5: OnceInit<Func1<Option<i32>, Func1<string, Func1<i32, Arc<Async<i32>>>>>> =
            OnceInit::new();
        v5.get_or_init(|| Func1::new(move |v: Option<i32>| Networking::closure21((), v)))
            .clone()
    }
    pub fn get_available_port(x: Option<i32>) -> Func1<string, Func1<i32, Arc<Async<i32>>>> {
        (Networking::v5())(x)
    }
    on_startup!(());
}
