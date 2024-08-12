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
    pub fn closure1(
        v0_1: LrcPtr<MutCell<Option<Trace::US1>>>,
        v1_1: Option<Trace::US1>,
    ) -> LrcPtr<MutCell<Option<Trace::US1>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure2(
        v0_1: Option<string>,
        v1_1: Func1<Option<Trace::US1>, LrcPtr<MutCell<Option<Trace::US1>>>>,
        unitVar: (),
    ) {
        {
            let value: LrcPtr<MutCell<Option<Trace::US1>>> = v1_1(match &v0_1 {
                None => None::<Trace::US1>,
                Some(v0_1_0_0) => {
                    let x: string = v0_1_0_0.clone();
                    Some((Func0::new({
                        let x = x.clone();
                        move || Trace::US1::US1_0(x.clone())
                    }))())
                }
            });
            ()
        }
        ()
    }
    pub fn method2(v0_1: string) -> string {
        let v18: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
        let v20: bool = true;
        let _result = v18.map(|x| {
            //;
            let v22: std::string::String = x;
            let v24: string = fable_library_rust::String_::fromString(v22);
            let v26: bool = true;
            v24
        });
        let v28: Result<string, std::env::VarError> = _result;
        let v29: string = Trace::method3();
        v28.unwrap_or(v29)
    }
    pub fn method4() -> string {
        string("AUTOMATION")
    }
    pub fn closure3(unitVar: (), v0_1: string) {
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
        let _v1: (Trace::US2, Trace::US3) = (Trace::US2::US2_1, Trace::US3::US3_1);
        let v295: Trace::US3 = _v1.1.clone();
        let v294: Trace::US2 = _v1.0.clone();
        (
            LrcPtr::new(Trace::Mut0 {
                l0: MutCell::new(0_i64),
            }),
            LrcPtr::new(Trace::Mut1 {
                l0: MutCell::new(Func1::new(move |v: string| Trace::closure3((), v))),
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
    pub fn closure0(unitVar: (), unitVar_1: ()) {
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
        };
    }
    pub fn closure8(v0_1: LrcPtr<Trace::Mut0>, unitVar: ()) {
        let v2_1: i64 = v0_1.l0.get().clone() + 1_i64;
        v0_1.l0.set(v2_1);
        ()
    }
    pub fn closure9(
        v0_1: LrcPtr<MutCell<Option<Trace::US3>>>,
        v1_1: Option<Trace::US3>,
    ) -> LrcPtr<MutCell<Option<Trace::US3>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure10(
        v0_1: Option<i64>,
        v1_1: Func1<Option<Trace::US3>, LrcPtr<MutCell<Option<Trace::US3>>>>,
        unitVar: (),
    ) {
        {
            let value: LrcPtr<MutCell<Option<Trace::US3>>> = v1_1(match &v0_1 {
                None => None::<Trace::US3>,
                Some(v0_1_0_0) => {
                    let x: i64 = v0_1_0_0.clone();
                    Some((Func0::new({
                        let x = x.clone();
                        move || Trace::US3::US3_0(x)
                    }))())
                }
            });
            ()
        }
        ()
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
    pub fn closure11(v0_1: LrcPtr<Trace::Mut4>, v1_1: string, unitVar: ()) {
        let v3: string = append(v0_1.l0.get().clone(), v1_1);
        v0_1.l0.set(v3);
        ()
    }
    pub fn closure7(v0_1: Trace::US0, v1_1: Func0<string>, v2_1: Func0<string>, unitVar: ()) {
        fn v4() {
            Trace::closure0((), ());
        }
        let v5_1: () = {
            v4();
            ()
        };
        let patternInput: (
            LrcPtr<Trace::Mut0>,
            LrcPtr<Trace::Mut1>,
            LrcPtr<Trace::Mut2>,
            LrcPtr<Trace::Mut3>,
            Option<i64>,
        ) = getValue(Trace::State::trace_state().get().clone());
        let v24: () = {
            v4();
            ()
        };
        let patternInput_1: (
            LrcPtr<Trace::Mut0>,
            LrcPtr<Trace::Mut1>,
            LrcPtr<Trace::Mut2>,
            LrcPtr<Trace::Mut3>,
            Option<i64>,
        ) = getValue(Trace::State::trace_state().get().clone());
        let v42: Trace::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
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
                v42,
                ofSeq(ofList(ofArray(new_array(&[
                    LrcPtr::new((Trace::US0::US0_0, 0_i32)),
                    LrcPtr::new((Trace::US0::US0_1, 1_i32)),
                    LrcPtr::new((Trace::US0::US0_2, 2_i32)),
                    LrcPtr::new((Trace::US0::US0_3, 3_i32)),
                    LrcPtr::new((Trace::US0::US0_4, 4_i32)),
                ])))),
            )
        } {
            let v51: () = {
                Trace::closure8(patternInput.0.clone(), ());
                ()
            };
            let v53: () = {
                v4();
                ()
            };
            let patternInput_2: (
                LrcPtr<Trace::Mut0>,
                LrcPtr<Trace::Mut1>,
                LrcPtr<Trace::Mut2>,
                LrcPtr<Trace::Mut3>,
                Option<i64>,
            ) = getValue(Trace::State::trace_state().get().clone());
            let _v138: LrcPtr<MutCell<Option<Trace::US3>>> = refCell(None::<Trace::US3>);
            let v143: () = {
                Trace::closure10(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v138 = _v138.clone();
                        move |v: Option<Trace::US3>| Trace::closure9(_v138.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v156: Trace::US3 = defaultValue(Trace::US3::US3_1, _v138.get().clone());
            let v196: DateTime = match &v156 {
                Trace::US3::US3_0(v156_0_0) => {
                    let v170: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v156 {
                            Trace::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v170.hours(),
                        v170.minutes(),
                        v170.seconds(),
                        v170.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v201: string = {
                let provider: string = Trace::method5();
                v196.toString(provider)
            };
            let v514: Trace::US1 = if if let Trace::US0::US0_0 = &v0_1 {
                true
            } else {
                false
            } {
                Trace::US1::US1_0(string("Verbose"))
            } else {
                Trace::US1::US1_1
            };
            let v555: Trace::US1 = match &v514 {
                Trace::US1::US1_0(v514_0_0) => Trace::US1::US1_0(match &v514 {
                    Trace::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => {
                    let v521: Trace::US1 = if if let Trace::US0::US0_1 = &v0_1 {
                        true
                    } else {
                        false
                    } {
                        Trace::US1::US1_0(string("Debug"))
                    } else {
                        Trace::US1::US1_1
                    };
                    match &v521 {
                        Trace::US1::US1_0(v521_0_0) => Trace::US1::US1_0(match &v521 {
                            Trace::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v528: Trace::US1 = if if let Trace::US0::US0_2 = &v0_1 {
                                true
                            } else {
                                false
                            } {
                                Trace::US1::US1_0(string("Info"))
                            } else {
                                Trace::US1::US1_1
                            };
                            match &v528 {
                                Trace::US1::US1_0(v528_0_0) => Trace::US1::US1_0(match &v528 {
                                    Trace::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                                _ => {
                                    let v535: Trace::US1 = if if let Trace::US0::US0_3 = &v0_1 {
                                        true
                                    } else {
                                        false
                                    } {
                                        Trace::US1::US1_0(string("Warning"))
                                    } else {
                                        Trace::US1::US1_1
                                    };
                                    match &v535 {
                                        Trace::US1::US1_0(v535_0_0) => {
                                            Trace::US1::US1_0(match &v535 {
                                                Trace::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v542: Trace::US1 =
                                                if if let Trace::US0::US0_4 = &v0_1 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    Trace::US1::US1_0(string("Critical"))
                                                } else {
                                                    Trace::US1::US1_1
                                                };
                                            match &v542 {
                                                Trace::US1::US1_0(v542_0_0) => {
                                                    Trace::US1::US1_0(match &v542 {
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
            };
            let v564: string = padLeft(
                toLower(match &v555 {
                    Trace::US1::US1_0(v555_0_0) => match &v555 {
                        Trace::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                }),
                7_i32,
                ' ',
            );
            let v617: &str = match &v0_1 {
                Trace::US0::US0_1 => inline_colorization::color_bright_blue,
                Trace::US0::US0_2 => inline_colorization::color_bright_green,
                Trace::US0::US0_0 => inline_colorization::color_bright_black,
                Trace::US0::US0_3 => inline_colorization::color_yellow,
                _ => inline_colorization::color_bright_red,
            };
            let v619: &str = &*v564;
            let v621: &str = inline_colorization::color_reset;
            let v623: string = string("format!(\"{v617}{v619}{v621}\")");
            let v624: std::string::String = format!("{v617}{v619}{v621}");
            let v626: string = fable_library_rust::String_::fromString(v624);
            let v705: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v706: string = v2_1();
            let v708: LrcPtr<Trace::Mut4> = LrcPtr::new(Trace::Mut4 {
                l0: MutCell::new(Trace::method8()),
            });
            let v714: () = {
                Trace::closure11(v708.clone(), sprintf!("{}", v706), ());
                ()
            };
            let v715: string = v708.l0.get().clone();
            let v753: string = trimEndChars(
                trimStartChars(
                    sprintf!("{} {} #{} {} / {}", v201, v626, v705, v1_1(), v715),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v753.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v753)
        }
    }
    pub fn closure6(v0_1: Trace::US0, v1_1: Func0<string>, v2_1: Func0<string>) {
        let v5_1: () = {
            Trace::closure7(v0_1, v1_1, v2_1, ());
            ()
        };
        ()
    }
    pub fn closure5(v0_1: Trace::US0, v1_1: Func0<string>) -> Func1<Func0<string>, ()> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: Func0<string>| Trace::closure6(v0_1.clone(), v1_1.clone(), v)
        })
    }
    pub fn closure4(
        unitVar: (),
        v0_1: Trace::US0,
    ) -> Func1<Func0<string>, Func1<Func0<string>, ()>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: Func0<string>| Trace::closure5(v0_1.clone(), v)
        })
    }
    pub fn v0() -> () {
        static v0: OnceInit<()> = OnceInit::new();
        v0.get_or_init(|| ()).clone()
    }
    pub fn v1() -> Func0<()> {
        static v1: OnceInit<Func0<()>> = OnceInit::new();
        v1.get_or_init(|| Func0::new(move || Trace::closure0((), ())))
            .clone()
    }
    pub fn v2() -> () {
        static v2: OnceInit<()> = OnceInit::new();
        v2.get_or_init(|| {
            (Trace::v1())();
            Trace::v0()
        })
        .clone()
    }
    pub fn v5() -> Func1<Trace::US0, Func1<Func0<string>, Func1<Func0<string>, ()>>> {
        static v5: OnceInit<Func1<Trace::US0, Func1<Func0<string>, Func1<Func0<string>, ()>>>> =
            OnceInit::new();
        v5.get_or_init(|| Func1::new(move |v: Trace::US0| Trace::closure4((), v)))
            .clone()
    }
    pub fn trace(x: Trace::US0) -> Func1<Func0<string>, Func1<Func0<string>, ()>> {
        (Trace::v5())(x)
    }
    on_startup!(());
}
